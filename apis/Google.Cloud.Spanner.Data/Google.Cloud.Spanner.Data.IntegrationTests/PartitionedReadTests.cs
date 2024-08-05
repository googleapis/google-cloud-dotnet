// Copyright 2017 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(PartitionedReadTableFixture))]
    [CommonTestDiagnostics]
    public class PartitionedReadTests
    {
        private readonly PartitionedReadTableFixture _fixture;

        public PartitionedReadTests(PartitionedReadTableFixture fixture) =>
            _fixture = fixture;

        [SkippableTheory, CombinatorialData]
        public async Task DistributedReadAsync(bool dataBoostEnabled)
        {
            // TODO: xUnit 3 will allow to set traits to individual data rows, and we should use that instead for consistency.
            Skip.If(dataBoostEnabled && _fixture.RunningOnEmulator, "DataBoostEnabled is not supported on the emulator");

            TransactionId transactionId = null;
            try
            {
                (var partitions, transactionId) = await GetPartitionsAsync(
                    connection => connection.CreateReadCommand(_fixture.TableName, ReadOptions.FromColumns(_fixture.ColumnNames), KeySet.All),
                    PartitionOptions.Default.WithPartitionSizeBytes(1000).WithDataBoostEnabled(dataBoostEnabled));

                Assert.Equal(dataBoostEnabled, partitions.FirstOrDefault().Request.ReadRequest.DataBoostEnabled);
                await AssertAllRowsReadAsync(partitions, transactionId);
            }
            finally
            {
                await DisposeTransactionAsync(transactionId);
            }

        }

        [SkippableTheory, CombinatorialData]
        public async Task DistributedQueryAsync(bool dataBoostEnabled)
        {
            // TODO: xUnit 3 will allow to set traits to individual data rows, and we should use that instead for consistency.
            Skip.If(dataBoostEnabled && _fixture.RunningOnEmulator, "DataBoostEnabled is not supported on the emulator");

            TransactionId transactionId = null;
            try
            {
                (var partitions, transactionId) = await GetPartitionsAsync(
                connection => connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName}"),
                PartitionOptions.Default.WithPartitionSizeBytes(1000).WithDataBoostEnabled(dataBoostEnabled));

                Assert.Equal(dataBoostEnabled, partitions.FirstOrDefault().Request.ExecuteSqlRequest.DataBoostEnabled);
                await AssertAllRowsReadAsync(partitions, transactionId);
            }
            finally
            {
                await DisposeTransactionAsync(transactionId);
            }
        }

        private async Task AssertAllRowsReadAsync(IEnumerable<CommandPartition> partitions, TransactionId transactionId)
        {
            int[] partitionNumRows = await Task.WhenAll(partitions.Select(
                    partitions => DistributedReadWorkerAsync(partitions, transactionId)));
            Assert.Equal(_fixture.TableRowCount, partitionNumRows.Sum());
        }

        private async Task<(IEnumerable<CommandPartition> partitions, TransactionId transactionId)> GetPartitionsAsync(Func<SpannerConnection, SpannerCommand> commandFactory, PartitionOptions options)
        {
            using var connection = new SpannerConnection(_fixture.ConnectionString);
            await connection.OpenAsync();

            using var transaction = await connection.BeginTransactionAsync(SpannerTransactionCreationOptions.ReadOnly.WithIsDetached(true), cancellationToken: default);

            using var cmd = commandFactory(connection);
            cmd.Transaction = transaction;
            return (await cmd.GetReaderPartitionsAsync(options), transaction.TransactionId);
        }

        /// <summary>
        /// TransactionId and CommandPartition are serializable.
        /// </summary>
        private static async Task<int> DistributedReadWorkerAsync(CommandPartition readPartition, TransactionId id)
        {
            int readRows = 0;

            // Note: we only use state provided by the arguments here.
            using var connection = new SpannerConnection(id.ConnectionString);
            using var transaction = await connection.BeginTransactionAsync(SpannerTransactionCreationOptions.FromReadOnlyTransactionId(id), cancellationToken: default);
            using var cmd = connection.CreateCommandWithPartition(readPartition, transaction);
            using (var reader = await cmd.ExecuteReaderAsync())
            while (await reader.ReadAsync())
            {
                readRows++;
            }
            return readRows;
        }

        private static async Task DisposeTransactionAsync(TransactionId transactionId)
        {
            if (transactionId is null)
            {
                return;
            }
            using var connection = new SpannerConnection(transactionId.ConnectionString);
            using var transaction = await connection.BeginTransactionAsync(SpannerTransactionCreationOptions.FromReadOnlyTransactionId(transactionId), cancellationToken: default);
            transaction.DisposeBehavior = DisposeBehavior.CloseResources;
        }
    }
}
