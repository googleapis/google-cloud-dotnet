// Copyright 2017 Google Inc. All rights reserved.
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

using Google.Api.Gax.Grpc;
using Google.Api.Gax.Grpc.Gcp;
using Google.Cloud.Bigtable.Common.V2;
using Google.Cloud.Bigtable.V2.IntegrationTests;
using Google.Cloud.ClientTesting;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(BigtableClientSnippetsFixture))]
    public class BigtableClientSnippets
    {
        private readonly BigtableClientSnippetsFixture _fixture;

        public BigtableClientSnippets(BigtableClientSnippetsFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task Overview()
        {
            if (_fixture.EmulatorCallInvoker != null)
            {
                // Because we're creating the client in the sample, we can't pass
                // in the emulator channel, so skip this when there is one.
                return;
            }

            string projectId = _fixture.TableName.ProjectId;
            string instanceId = _fixture.TableName.InstanceId;
            string tableId = _fixture.TableName.TableId;

            // Sample: Overview
            BigtableClient client = BigtableClient.Create();
            TableName tableName = new TableName(projectId, instanceId, tableId);

            // Insert a row with some cells into the table
            await client.MutateRowAsync(
                tableName,
                "user12345",
                Mutations.SetCell(
                    familyName: "Score",
                    columnQualifier: "Level 1",
                    value: 456),
                Mutations.SetCell(
                    familyName: "metrics",
                    columnQualifier: "Level 1 - total time",
                    value: 12000));

            // Read the row back from the table, but only the latest cell values
            // from the 'Score' column family
            Row row = await client.ReadRowAsync(
                tableName,
                "user12345",
                filter: RowFilters.Chain(
                    RowFilters.FamilyNameExact("Score"),
                    RowFilters.CellsPerColumnLimit(1)));

            foreach (Family family in row.Families)
            {
                string familyName = family.Name;
                Console.WriteLine($"Family: {familyName}");

                foreach (Column column in family.Columns)
                {
                    BigtableByteString columnQualifier = column.Qualifier;
                    BigtableByteString cellValue = column.Cells[0].Value;
                    Console.WriteLine(
                        $"\tColumn: {(string)columnQualifier}, Value: {(long)cellValue}");
                }
            }
            // End sample

            foreach (Family family in row.Families)
            {
                Assert.Equal("Score", family.Name);

                foreach (Column column in family.Columns)
                {
                    BigtableByteString columnQualifier = column.Qualifier;
                    Assert.Equal("Level 1", (string)columnQualifier);

                    BigtableByteString cellValue = column.Cells[0].Value;
                    Assert.Equal(456, (long)cellValue);
                }
            }
        }

        [Fact]
        public async Task CustomCallInvoker()
        {
            ChannelCredentials credentials = ChannelCredentials.Insecure;

            // Sample: CustomCallInvoker
            // Create a client from a custom credentials and a GcpCallInvoker that has
            // non-default gRPC stream/channel options.
            // The easiest way of creating a GcpCallInvoker is to use a new
            // BigtableServiceApiClientBuilder just to create the call invoker,
            // then remember the call invoker to set it in other builders.
            // Note: the GcpCallInvoker should be long-lived while the BigtableClient
            // instances can be ephemeral and each use the same call invoker.
            BigtableServiceApiSettings settings = new BigtableServiceApiSettings
            {
                MaxChannels = 10,
                PreferredMaxStreamsPerChannel = 4
            };
            GcpCallInvoker callInvoker = new BigtableServiceApiClientBuilder
            {
                Settings = settings,
                ChannelCredentials = credentials,
            }.CreateGcpCallInvoker();

            // These will share the same set of channels to the Bigtable service.
            BigtableClient client1 = new BigtableClientBuilder
            {
                CallInvoker = callInvoker,
                Settings = settings
            }.Build();
            // ...
            BigtableClient client2 = new BigtableClientBuilder
            {
                CallInvoker = callInvoker,
                Settings = settings
            }.Build();
            // ...

            await callInvoker.ShutdownAsync();
            // End sample
        }

        [Fact]
        public async Task CheckAndMutateRowAsync()
        {
            var client = _fixture.TableClient;
            var projectId = _fixture.TableName.ProjectId;
            var instanceId = _fixture.TableName.InstanceId;
            var tableId = _fixture.TableName.TableId;

            await client.MutateRowAsync(
                new TableName(projectId, instanceId, tableId),
                "user12345",
                Mutations.SetCell("Address", "Country", "USA"));

            // Snippet: CheckAndMutateRowAsync(TableName,BigtableByteString,RowFilter,*)
            CheckAndMutateRowResponse response = await client.CheckAndMutateRowAsync(
                new TableName(projectId, instanceId, tableId),
                "user12345",
                // If the latest value in the "Address:Country" column is "USA"...
                RowFilters.Chain(
                    RowFilters.FamilyNameExact("Address"),
                    RowFilters.ColumnQualifierExact("Country"),
                    RowFilters.CellsPerColumnLimit(1),
                    RowFilters.ValueExact("USA")),
                // ...remove all previous Level 1 scores and set the value to 0.
                Mutations.DeleteFromColumn("Score", "Level 1"),
                Mutations.SetCell("Score", "Level 1", 0, new BigtableVersion(1)));

            if (response.PredicateMatched)
            {
                Console.WriteLine("The level 1 scores have been reset");
            }
            else
            {
                Console.WriteLine("The level 1 scores were not modified.");
            }
            // End snippet

            Assert.True(response.PredicateMatched);
        }

        [Fact]
        public async Task MutateRowAsync()
        {
            var client = _fixture.TableClient;
            var projectId = _fixture.TableName.ProjectId;
            var instanceId = _fixture.TableName.InstanceId;
            var tableId = _fixture.TableName.TableId;

            await client.MutateRowAsync(
                new TableName(projectId, instanceId, tableId),
                new byte[] { 0xAB, 0xCD, 0x12, 0x34 },
                Mutations.SetCell("Address", "Country", "USA"),
                Mutations.SetCell("Score", "Level 1", 12));

            // Snippet: MutateRowAsync(TableName,BigtableByteString,*)
            await client.MutateRowAsync(
                new TableName(projectId, instanceId, tableId),
                // From the row with key '0xABCD1234'...
                new byte[] { 0xAB, 0xCD, 0x12, 0x34 },
                // delete all cells from the column family "Address",
                Mutations.DeleteFromFamily("Address"),
                // and all cells from the "Score:Level 1" column which are older than a day (assuming UTC
                // timestamp micros have been used as version values in this column).
                Mutations.DeleteFromColumn(
                    "Score",
                    "Level 1",
                    new BigtableVersionRange(null, DateTime.UtcNow.AddDays(-1))));
            // End snippet

            await BigtableAssert.HasNoValuesAsync(
                client,
                new TableName(projectId, instanceId, tableId),
                new byte[] { 0xAB, 0xCD, 0x12, 0x34 },
                "Address");
        }

        [Fact]
        public async Task MutateRows()
        {
            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var client = _fixture.TableClient;
            var projectId = _fixture.TableName.ProjectId;
            var instanceId = _fixture.TableName.InstanceId;
            var tableId = _fixture.TableName.TableId;

            await client.MutateRowAsync(
                new TableName(projectId, instanceId, tableId),
                "user23456",
                Mutations.SetCell("Score", "Level 1", 12));

            // Snippet: MutateRowsAsync(TableName,*)
            MutateRowsResponse response = await client.MutateRowsAsync(
                new TableName(projectId, instanceId, tableId),
                // From row 'user12345'...
                Mutations.CreateEntry("user12345",
                    // delete all cells from the column family "Score",
                    Mutations.DeleteFromFamily("Score"),
                    // and all cells from the "metrics:clicks" column which are older than a day (assuming UTC
                    // timestamp micros have been used as version values in this column).
                    Mutations.DeleteFromColumn(
                        "metrics",
                        "clicks",
                        new BigtableVersionRange(null, DateTime.UtcNow.AddDays(-1)))),
                // Delete all data from row 'user23456'
                Mutations.CreateEntry("user23456", Mutations.DeleteFromRow()));

            foreach (MutateRowsResponse.Types.Entry entry in response.Entries)
            {
                switch (entry.Index)
                {
                    case 0:
                        Console.WriteLine($"The mutations to row 'user12345' finished with status code {entry.Status.Code}");
                        break;
                    case 1:
                        Console.WriteLine($"The mutations to row 'user23456' finished with status code {entry.Status.Code}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            // End snippet

            await BigtableAssert.HasNoValuesAsync(
                client,
                new TableName(projectId, instanceId, tableId),
                "user23456");
        }

        [Fact]
        public async Task ReadModifyWriteRowAsync()
        {
            var client = _fixture.TableClient;
            var projectId = _fixture.TableName.ProjectId;
            var instanceId = _fixture.TableName.InstanceId;
            var tableId = _fixture.TableName.TableId;

            await client.MutateRowAsync(
                new TableName(projectId, instanceId, tableId),
                "user12345",
                Mutations.SetCell("Score", "Level 1", 12));

            // Snippet: ReadModifyWriteRowAsync(TableName,BigtableByteString,*)
            // Increase the value of the cell with the "Level 1" qualifier in the
            // "Score" column family by 55.
            ReadModifyWriteRowResponse response = await client.ReadModifyWriteRowAsync(
                new TableName(projectId, instanceId, tableId),
                "user12345",
                ReadModifyWriteRules.Increment("Score", "Level 1", 55));

            Cell modifiedCell = response.Row.Families[0].Columns[0].Cells[0];

            // Implicitly convert the ByteString Value into a BigtableByteString,
            // which supports additional conversions specific to Bigtable.
            BigtableByteString value = modifiedCell.Value;

            // Convert the BigtableByteString to a long to obtain the updated value.
            long newScore = (long) value;
            Console.WriteLine($"The total score for level 1 is now {newScore}");
            // End snippet

            Assert.Equal(67, newScore);
        }

        [Fact]
        public async Task ReadRowAsync()
        {
            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var client = _fixture.TableClient;
            var projectId = _fixture.TableName.ProjectId;
            var instanceId = _fixture.TableName.InstanceId;
            var tableId = _fixture.TableName.TableId;

            await client.MutateRowAsync(
                new TableName(projectId, instanceId, tableId),
                "user12345",
                Mutations.DeleteFromRow(),
                Mutations.SetCell("Address", "Country", "USA"),
                Mutations.SetCell("Address", "Line 1", "1234 Main Street"),
                Mutations.SetCell("Address", "Line 2", "Apt. 2"),
                Mutations.SetCell("Score", "Level 1", 12));

            // Snippet: ReadRowAsync(TableName,BigtableByteString,RowFilter,CallSettings)
            // Only read cells from the "Line X" columns, where X is some
            // digit, in the Address column family and only take the most
            // recent cell from each column.
            Row row = await client.ReadRowAsync(
                new TableName(projectId, instanceId, tableId),
                "user12345",
                RowFilters.Chain(
                    RowFilters.FamilyNameExact("Address"),
                    RowFilters.ColumnQualifierRegex(@"Line \d"),
                    RowFilters.CellsPerColumnLimit(1)),
                CallSettings.FromCancellationToken(cancellationToken));

            Family addressFamily = row.Families.FirstOrDefault();
            if (addressFamily != null)
            {
                foreach (Column column in addressFamily.Columns)
                {
                    Console.WriteLine($"    Column qualifier: {column.Qualifier.ToStringUtf8()}");
                    foreach (Cell cell in column.Cells)
                    {
                        Console.WriteLine($"      Cell value: {cell.Value.ToStringUtf8()}");
                        Console.WriteLine($"      Timestamp: {cell.Version.ToDateTime()}");
                        Console.WriteLine($"      Labels: {string.Join(", ", cell.Labels)}");
                    }
                }
            }
            // End snippet

            foreach (Family family in row.Families)
            {
                Assert.Equal("Address", family.Name);
                foreach (Column column in family.Columns)
                {
                    Assert.Equal(1, column.Cells.Count);

                    switch (column.Qualifier.ToStringUtf8())
                    {
                        case "Line 1":
                            Assert.Equal("1234 Main Street", column.Cells[0].Value.ToStringUtf8());
                            break;
                        case "Line 2":
                            Assert.Equal("Apt. 2", column.Cells[0].Value.ToStringUtf8());
                            break;
                        default:
                            Assert.True(false, $"Unexpected column qualifier: {column.Qualifier.ToStringUtf8()}");
                            break;
                    }
                }
            }
        }

        [Fact]
        public async Task ReadRows()
        {
            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var client = _fixture.TableClient;
            var projectId = _fixture.TableName.ProjectId;
            var instanceId = _fixture.TableName.InstanceId;
            var tableId = _fixture.TableName.TableId;

            // Snippet: ReadRows(TableName,RowSet,RowFilter,long?,CallSettings)
            TableName tableName = new TableName(projectId, instanceId, tableId);

            // Read rows whose keys are greater than or equal to 'user00000'
            // and less than 'user99999'.
            RowSet rows = RowSet.FromRowRanges(
                RowRange.ClosedOpen("user00000", "user99999"));

            // Only read cells from the "Address" column family and only take the most recent cell from each column.
            RowFilter filter = RowFilters.Chain(
                RowFilters.FamilyNameExact("Address"),
                RowFilters.CellsPerColumnLimit(1));

            // Just read the first 10 rows.
            long rowsLimit = 10;

            // Make the request
            ReadRowsStream streamingResponse = client.ReadRows(
                tableName,
                rows,
                filter,
                rowsLimit,
                CallSettings.FromCancellationToken(cancellationToken));

            // Read streaming responses from server until complete
            await streamingResponse.ForEachAsync(row =>
            {
                Console.WriteLine($"Row key: {row.Key.ToStringUtf8()}");
                foreach (Family family in row.Families)
                {
                    Console.WriteLine($"  Family name: {family.Name}");
                    foreach (Column column in family.Columns)
                    {
                        Console.WriteLine($"    Column qualifier: {column.Qualifier.ToStringUtf8()}");
                        foreach (Cell cell in column.Cells)
                        {
                            Console.WriteLine($"      Cell value: {cell.Value.ToStringUtf8()}");
                            Console.WriteLine($"      Timestamp: {cell.Version.ToDateTime()}");
                            Console.WriteLine($"      Labels: {string.Join(", ", cell.Labels)}");
                        }
                    }
                }
            });
            // End snippet
        }

        [Fact]
        public async Task SampleRowKeys()
        {
            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var client = _fixture.TableClient;
            var projectId = _fixture.TableName.ProjectId;
            var instanceId = _fixture.TableName.InstanceId;
            var tableId = _fixture.TableName.TableId;

            // Snippet: SampleRowKeys(TableName,CallSettings)
            BigtableServiceApiClient.SampleRowKeysStream streamingResponse = client.SampleRowKeys(
                new TableName(projectId, instanceId, tableId),
                CallSettings.FromCancellationToken(cancellationToken));

            // Get all streaming responses from server in a list so they can be easily iterated.
            IList<SampleRowKeysResponse> rowKeySamples =
                await streamingResponse.ToListAsync(cancellationToken);

            long previousRowOffsetBytes = 0;
            foreach (SampleRowKeysResponse rowKeySample in rowKeySamples)
            {
                // The OffsetBytes are non-decreasing, so their difference should always be 0 or more.
                long offsetDifference = rowKeySample.OffsetBytes - previousRowOffsetBytes;

                Console.WriteLine($"Row key: {rowKeySample.RowKey.ToStringUtf8()}, at offset {rowKeySample.OffsetBytes}");
                Console.WriteLine($"  Approximate bytes since previous row sample: {offsetDifference}");

                previousRowOffsetBytes = rowKeySample.OffsetBytes;
            }
            // End snippet
        }
    }
}
