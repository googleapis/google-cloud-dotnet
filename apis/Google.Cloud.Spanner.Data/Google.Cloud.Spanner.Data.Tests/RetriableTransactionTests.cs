// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Cloud.Spanner.V1.Tests;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class RetriableTransactionTests
    {
        [Fact]
        public async Task TestUpdatingPrevTransactionId()
        {
            Console.WriteLine("Starting TestUpdatingPrevTransactionId");
            SpannerClient spannerClientMock = SpannerClientHelpers.CreateMockClient(Logger.DefaultLogger);
            spannerClientMock.SetupMultiplexSessionCreationAsync()
                    .SetupExecuteBatchDmlAsync()
                    .SetupCommitAsync_Fails(failures: 1, statusCode: StatusCode.Aborted, exceptionRetryDelay: TimeSpan.FromMilliseconds(300))
                    .SetupRollbackAsync();

            using (var connection = SpannerCommandTests.BuildSpannerConnection(spannerClientMock))
            {
                await connection.EnsureIsOpenAsync(default);
                var options = SpannerTransactionCreationOptions.ReadWrite;
                var retriableTransaction = new RetriableTransaction(connection, SystemClock.Instance, SystemScheduler.Instance, options, null, null);

                Assert.Equal(ByteString.Empty, retriableTransaction._prevTransactionId);

                await retriableTransaction.RunAsync(async transaction => {

                    Assert.Equal(retriableTransaction._prevTransactionId, transaction._creationOptions.PreviousTransactionId);
                    Assert.Equal(retriableTransaction._prevTransactionId, transaction._transaction.TransactionOptions.ReadWrite.MultiplexedSessionPreviousTransactionId);

                    var dml = transaction.CreateBatchDmlCommand();
                    dml.Add("UPDATE table_1 SET column_1 = column1 + 5");
                    await dml.ExecuteNonQueryAsync();

                    return 12; // random int value to pacify compiler warning
                });

                Assert.Equal(SpannerClientHelpers.s_transactionId, retriableTransaction._prevTransactionId);
                Console.WriteLine("Finished TestUpdatingPrevTransactionId");
            }
        }

    }
}
