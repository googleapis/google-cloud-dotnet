// Copyright 2019 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
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

using Google.Cloud.Spanner.Data.CommonTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(DmlTableFixture))]
    public class RetriableTransactionTests
    {
        private readonly DmlTableFixture _fixture;
        private readonly string _selectSql;
        private readonly string _updateSql;
        private readonly string _insertSql;

        public RetriableTransactionTests(DmlTableFixture fixture)
        {
            _fixture = fixture;
            _selectSql = $"SELECT OriginalValue FROM {_fixture.TableName} WHERE UpdateMe AND Key=@Key";
            _updateSql = $"UPDATE {_fixture.TableName} SET Value = Value + 1 WHERE UpdateMe AND Key=@Key";
            _insertSql = $"INSERT INTO {_fixture.TableName} (Key, OriginalValue, Value, UpdateMe, DeleteMe, CopyMe) SELECT Key, OriginalValue + 10, Value, UpdateMe, DeleteMe, CopyMe FROM {_fixture.TableName} WHERE CopyMe AND KEY=@Key";
        }

        [Fact]
        public async Task FirstCallSucceeds()
        {
            string key = _fixture.CreateTestRows();
            int calls = 0;
            int rowsAffected;
            using (var connection = _fixture.GetConnection())
            {
                rowsAffected = await connection.RunWithRetriableTransactionAsync(
                    transaction => WorkAsync(connection, transaction));
            }

            async Task<int> WorkAsync(SpannerConnection connection, SpannerTransaction transaction)
            {
                calls++;

                // Read some data, because we should be able to.
                await SelectAndReadFixtureData(key, connection, transaction);

                int rows = 0;

                // This should update rows 1 and 4.
                rows += await DmlUpdateFixtureData(key, connection, transaction);
                // This should delete row 4. But that will happen on commit after everything else.
                rows += await DeleteFixtureData(key, connection, transaction);
                // This will first insert 3 and 4 as 13 and 14.
                // Then will update 1, 4 and 14.
                rows += (int)(await BatchDmlInsertUpdateFixtureData(key, connection, transaction)).Sum();

                return rows;
            }

            Assert.Equal(8, rowsAffected);
            Assert.Equal(1, calls);

            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 }, // Not updated
                { 1, 3 }, // Updated by DML, and then by Batch.
                { 2, 2 }, // Not updated
                { 3, 3 }, // Not updated
              //{ 4, 6 }, // Updated by DML, and then by Batch. Deleted at the end.
                { 13, 3 }, // Inserted by Batch.
                { 14, 6 }, // Inserted by Batch. Updated by batch.
            };

            Assert.Equal(expected, actual);
        }

        [Fact]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task RetriesOnce()
        {
            // Requires multiple read/write transactions which is not supported on the emulator.
            string key = _fixture.CreateTestRows();

            ManualResetEventSlim firstTaskUpdateAttempted = new ManualResetEventSlim(false);
            ManualResetEventSlim secondTaskUpdateAttempted = new ManualResetEventSlim(false);

            int firstTaskCallCount = 0;
            int secondTaskCallCount = 0;

            int[] rowsUpdatedByTask;

            using (var connection = _fixture.GetConnection())
            {
                // Start two tasks that attempt the same update.
                // Guarantee that the first attempted updates on each task are concurrent using events.
                var firstUpdateTask = connection.RunWithRetriableTransactionAsync(transaction => WorkAsync(connection, transaction, firstTaskUpdateAttempted, secondTaskUpdateAttempted, () => firstTaskCallCount++));
                var secondUpdateTask = connection.RunWithRetriableTransactionAsync(transaction => WorkAsync(connection, transaction, secondTaskUpdateAttempted, firstTaskUpdateAttempted, () => secondTaskCallCount++));

                rowsUpdatedByTask = await Task.WhenAll(firstUpdateTask, secondUpdateTask);
            }

            async Task<int> WorkAsync(SpannerConnection connection, SpannerTransaction transaction, ManualResetEventSlim thisUpdateDone, ManualResetEventSlim otherUpdateDone, Action callStart)
            {
                // Just to count how many times this method was called.
                // We can't have ref parameters in async methods.
                callStart();

                int rows;
                try
                {
                    // Let's update some data with the retriable transaction that we received as paremeter.
                    // This can fail with a status of "aborted" if the other task update went in first
                    // and this update detects the write locks already out of sync.
                    rows = await DmlUpdateFixtureData(key, connection, transaction);
                }
                finally
                {
                    // We attempted an update.
                    // Whether it succeeded or aborted, we signal the task performing the
                    // other concurrent update that we're done with our own update.
                    thisUpdateDone.Set();
                    // We don't need to reset the event because we only need 
                    // one concurrent update to test the retriable transaction.
                    // If both tasks execute more than once, we can let them compete
                    // naturally, the retry transaction has already been guaranteed
                    // to have retried at least once in one task.
                }

                // Wait on the other task to attempt their concurrent update.
                // That's how we make sure that updates happened concurrently.
                otherUpdateDone.Wait();

                return rows;

                // The commit will be attempted now, and if it fails with a status of "aborted",
                // the retriable transaction should retry this whole method.
            }

            // Each task should have updated the same two rows.
            Assert.Equal(new int[] { 2, 2 }, rowsUpdatedByTask);

            // Each task should have been called at least once.
            Assert.True(firstTaskCallCount >= 1);
            Assert.True(secondTaskCallCount >= 1);

            // One task should have been called at least twice (that's the retried task).
            // They might have been called more than twice because of other possible abort causes.
            Assert.True(firstTaskCallCount >= 2 || secondTaskCallCount >= 2);

            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 }, // Not updated
                { 1, 3 }, // Updated twice, once by each task.
                { 2, 2 }, // Not updated
                { 3, 3 }, // Not updated
                { 4, 6 }  // Updated twice, once by each task.
            };

            Assert.Equal(expected, actual);
        }

        private async Task<IReadOnlyList<long>> BatchDmlInsertUpdateFixtureData(string key, SpannerConnection connection, SpannerTransaction transaction)
        {
            var command = transaction.CreateBatchDmlCommand();
            command.Add(_insertSql, new SpannerParameterCollection
            {
                { "Key", SpannerDbType.String, key }
            });
            command.Add(_updateSql, new SpannerParameterCollection
            {
                { "Key", SpannerDbType.String, key }
            });
            return await command.ExecuteNonQueryAsync();
        }

        private async Task<int> DmlUpdateFixtureData(string key, SpannerConnection connection, SpannerTransaction transaction)
        {
            using (var command = connection.CreateDmlCommand(_updateSql))
            {
                command.Transaction = transaction;
                command.Parameters.Add("Key", SpannerDbType.String, key);
                return await command.ExecuteNonQueryAsync();
            }
        }

        private async Task<int> DeleteFixtureData(string key, SpannerConnection connection, SpannerTransaction transaction)
        {
            var parameters = new SpannerParameterCollection
            {
                { "Key", SpannerDbType.String, key },
                { "OriginalValue", SpannerDbType.Int64, 4 }
            };
            using (var command = connection.CreateDeleteCommand(_fixture.TableName, parameters))
            {
                command.Transaction = transaction;
                return await command.ExecuteNonQueryAsync();
            }
        }

        private async Task SelectAndReadFixtureData(string key, SpannerConnection connection, SpannerTransaction transaction)
        {
            using (var command = connection.CreateSelectCommand(_selectSql))
            {
                command.Transaction = transaction;
                command.Parameters.Add("Key", SpannerDbType.String, key);
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync()) ;
            }
        }
    }
}
