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

using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task RetriesOnce()
        {
            string key = _fixture.CreateTestRows();
            int calls = 0;
            int rowsUpdated;
            using (var connection = _fixture.GetConnection())
            {
                rowsUpdated = await connection.RunWithRetriableTransactionAsync(transaction => WorkAsync(connection, transaction));
            }

            async Task<int> WorkAsync(SpannerConnection connection, SpannerTransaction transaction)
            {
                calls++;

                // Let's update some data with the retriable transaction.
                int rows = await DmlUpdateFixtureData(key, connection, transaction);

                // The first time let's update the data again using a different transaction.
                // This will cause the retriable transaction to abort.
                if (calls == 1)
                {
                    try
                    {
                        using (var conflictingTransaction = await connection.BeginTransactionAsync())
                        {
                            int conflictingRows = await DmlUpdateFixtureData(key, connection, conflictingTransaction);
                            await conflictingTransaction.CommitAsync();
                            Assert.Equal(2, conflictingRows);
                        }
                    }
                    catch (SpannerException e)
                    {
                        // If there is an exception catched here we just want to propagate it,
                        // and make the test fail. We need to wrap it so it doesn't trigger
                        // the retry.
                        throw new Exception("This shouldn't have happened.", e);
                    }
                }

                return rows;
                // And now that we are done, the retriable transaction should be committed.
                // On the first time this method is called, the commit will abort because our 
                // update was on now stale data and the retry should be triggered.
            }

            Assert.Equal(2, rowsUpdated);
            Assert.Equal(2, calls);

            var actual = _fixture.FetchValues(key);
            var expected = new Dictionary<int, int>
            {
                { 0, 0 }, // Not updated
                { 1, 3 }, // Updated twice, once by the conflicting transaction, once by the main work.
                { 2, 2 }, // Not updated
                { 3, 3 }, // Not updated
                { 4, 6 }  // Updated twice, once by the conflicting transaction, once by the main work.
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
