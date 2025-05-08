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

using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.Bigquery.v2.Data.TableFieldSchema;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    [Collection(nameof(BigQueryFixture))]
    public class TablesTest
    {
        private readonly BigQueryFixture _fixture;

        public TablesTest(BigQueryFixture fixture)
        {
            _fixture = fixture;
        }

        // Regression test against issue where the etag returned on create wasn't the same as
        // for the initial fetch.
        [Fact]
        public void CreateTable_InitialEtag()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();
            var created = client.CreateTable(datasetId, tableId, new Table { Description = "Description1", FriendlyName = "FriendlyName1" });

            var fetched = client.GetTable(datasetId, tableId);
            Assert.Equal(created.Resource.ETag, fetched.Resource.ETag);
        }

        [Fact]
        public void CreateTable_TableNoReference()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var created = client.CreateTable(datasetId, tableId, new Table());

            Assert.Equal(_fixture.ProjectId, created.Reference.ProjectId);
            Assert.Equal(datasetId, created.Reference.DatasetId);
            Assert.Equal(tableId, created.Reference.TableId);
        }

        [Fact]
        public async Task CreateTableAsync_TableNoReference()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var created = await client.CreateTableAsync(datasetId, tableId, new Table());

            Assert.Equal(_fixture.ProjectId, created.Reference.ProjectId);
            Assert.Equal(datasetId, created.Reference.DatasetId);
            Assert.Equal(tableId, created.Reference.TableId);
        }

        [Fact]
        public void CreateTable_TableSameReference()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var created = client.CreateTable(
                datasetId,
                tableId,
                new Table
                {
                    TableReference = new TableReference
                    {
                        ProjectId = _fixture.ProjectId,
                        DatasetId = _fixture.DatasetId,
                        TableId = tableId
                    }
                });

            Assert.Equal(_fixture.ProjectId, created.Reference.ProjectId);
            Assert.Equal(datasetId, created.Reference.DatasetId);
            Assert.Equal(tableId, created.Reference.TableId);
        }

        [Fact]
        public async Task CreateTableAsync_TableSameReference()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var created = await client.CreateTableAsync(
                datasetId,
                tableId,
                new Table
                {
                    TableReference = new TableReference
                    {
                        ProjectId = _fixture.ProjectId,
                        DatasetId = _fixture.DatasetId,
                        TableId = tableId
                    }
                });

            Assert.Equal(_fixture.ProjectId, created.Reference.ProjectId);
            Assert.Equal(datasetId, created.Reference.DatasetId);
            Assert.Equal(tableId, created.Reference.TableId);
        }

        [Fact]
        public void CreateTable_TableDifferentReference()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            Assert.Throws<ArgumentException>(() => client.CreateTable(
                datasetId,
                tableId,
                new Table
                {
                    TableReference = new TableReference
                    {
                        ProjectId = _fixture.ProjectId,
                        DatasetId = _fixture.DatasetId,
                        TableId = _fixture.CreateTableId()
                    }
                }));
        }

        [Fact]
        public async Task CreateTableAsync_TableDifferentReference()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            await Assert.ThrowsAsync<ArgumentException>(() => client.CreateTableAsync(
                datasetId,
                tableId,
                new Table
                {
                    TableReference = new TableReference
                    {
                        ProjectId = _fixture.ProjectId,
                        DatasetId = _fixture.DatasetId,
                        TableId = _fixture.CreateTableId()
                    }
                }));
        }

        [Fact]
        public void CreateTable_ViewAndExternalDataConfiguration()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            Assert.Throws<ArgumentException>(() => client.CreateTable(
                datasetId,
                tableId,
                new Table
                {
                    View = new ViewDefinition(),
                    ExternalDataConfiguration = new ExternalDataConfiguration()
                }));
        }

        [Fact]
        public async Task CreateTableAsync_ViewAndExternalDataConfiguration()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            await Assert.ThrowsAsync<ArgumentException>(() => client.CreateTableAsync(
                datasetId,
                tableId,
                new Table
                {
                    View = new ViewDefinition(),
                    ExternalDataConfiguration = new ExternalDataConfiguration()
                }));
        }

        [Fact]
        public void CreateTable_ViewAndMaterializedView()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            Assert.Throws<ArgumentException>(() => client.CreateTable(
                datasetId,
                tableId,
                new Table
                {
                    View = new ViewDefinition(),
                    MaterializedView = new MaterializedViewDefinition()
                }));
        }

        [Fact]
        public async Task CreateTableAsync_ViewAndMaterializedView()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            await Assert.ThrowsAsync<ArgumentException>(() => client.CreateTableAsync(
                datasetId,
                tableId,
                new Table
                {
                    View = new ViewDefinition(),
                    MaterializedView = new MaterializedViewDefinition()
                }));
        }

        [Fact]
        public void CreateTable_MaterializedViewAndExternalDataConfiguration()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            Assert.Throws<ArgumentException>(() => client.CreateTable(
                datasetId,
                tableId,
                new Table
                {
                    MaterializedView = new MaterializedViewDefinition(),
                    ExternalDataConfiguration = new ExternalDataConfiguration()
                }));
        }

        [Fact]
        public async Task CreateTableAsync_MaterializedViewAndExternalDataConfiguration()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            await Assert.ThrowsAsync<ArgumentException>(() => client.CreateTableAsync(
                datasetId,
                tableId,
                new Table
                {
                    MaterializedView = new MaterializedViewDefinition(),
                    ExternalDataConfiguration = new ExternalDataConfiguration()
                }));
        }

        [Fact]
        public void GetOrCreateTable_TableSameReference()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var created = client.GetOrCreateTable(
                datasetId,
                tableId,
                resource: new Table
                {
                    TableReference = new TableReference
                    {
                        ProjectId = _fixture.ProjectId,
                        DatasetId = _fixture.DatasetId,
                        TableId = tableId
                    }
                });

            Assert.Equal(_fixture.ProjectId, created.Reference.ProjectId);
            Assert.Equal(datasetId, created.Reference.DatasetId);
            Assert.Equal(tableId, created.Reference.TableId);
        }

        [Fact]
        public async Task GetOrCreateTableAsync_TableSameReference()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var created = await client.GetOrCreateTableAsync(
                datasetId,
                tableId,
                resource: new Table
                {
                    TableReference = new TableReference
                    {
                        ProjectId = _fixture.ProjectId,
                        DatasetId = _fixture.DatasetId,
                        TableId = tableId
                    }
                });

            Assert.Equal(_fixture.ProjectId, created.Reference.ProjectId);
            Assert.Equal(datasetId, created.Reference.DatasetId);
            Assert.Equal(tableId, created.Reference.TableId);
        }

        [Fact]
        public void GetOrCreateTable_TableDifferentReference()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            Assert.Throws<ArgumentException>(() => client.GetOrCreateTable(
                datasetId,
                tableId,
                resource: new Table
                {
                    TableReference = new TableReference
                    {
                        ProjectId = _fixture.ProjectId,
                        DatasetId = _fixture.DatasetId,
                        TableId = _fixture.CreateTableId()
                    }
                }));
        }

        [Fact]
        public async Task GetOrCreateTableAsync_TableDifferentReference()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            await Assert.ThrowsAsync<ArgumentException>(() => client.GetOrCreateTableAsync(
                datasetId,
                tableId,
                resource: new Table
                {
                    TableReference = new TableReference
                    {
                        ProjectId = _fixture.ProjectId,
                        DatasetId = _fixture.DatasetId,
                        TableId = _fixture.CreateTableId()
                    }
                }));
        }

        /// <summary>
        /// Calls GetOrCreateTable with multiple concurrent requests. We create 5 threads all trying
        /// to GetOrCreate the same dataset at the same time, to check that
        /// "get (not found) -> create (conflict) -> get (ok)" works appropriately.
        /// We use 5 threads as that's the quota limit for updates to a single dataset's metadata within 10
        /// seconds. We can't actually tell for sure whether any of the calls went through all three RPCs,
        /// but the test does fail without the final "get".
        ///
        /// We could potentially detect the create request failing due to lack of quota and perform
        /// a second "get", but the quota check happens early - leading to "not found" errors while the dataset
        /// is being created. Rather than get into polling intervals etc, we just let it fail in that case;
        /// users will need to write higher-level retry if they're in that very niche situation.
        ///
        /// (Threads are used rather than tasks to ensure that the requests really are pretty much "all at
        /// the same time"; we don't want the normal slow task warm-up to skew this, although they're used
        /// in the async test for convenience.)
        /// </summary>
        [Fact]
        public void GetOrCreateTable_HighContention()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var datasetId = _fixture.CreateDatasetId();
            client.CreateDataset(datasetId);
            int successes = 0;
            ConcurrentBag<Exception> exceptions = new ConcurrentBag<Exception>();
            var threads = Enumerable.Range(0, 5).Select(_ => new Thread(() =>
            {
                try
                {
                    client.GetOrCreateTable(datasetId, "highcontention", new Table());
                    Interlocked.Increment(ref successes);
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            })).ToList();

            // Start all the threads at roughly the same time
            threads.ForEach(t => t.Start());

            // ... and wait for them all to finish
            threads.ForEach(t => t.Join(5000));

            Assert.Empty(exceptions);
            // If any threads timed out, we won't have enough successes.
            Assert.Equal(threads.Count, successes);
        }

        /// <summary>
        /// See <see cref="GetOrCreateTable_HighContention"/> for commentary on the test.
        /// </summary>
        [Fact]
        public async Task GetOrCreateTableAsync_HighContention()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var datasetId = _fixture.CreateDatasetId();
            await client.CreateDatasetAsync(datasetId);

            var tasks = Enumerable.Range(0, 5).Select(_ => client.GetOrCreateTableAsync(datasetId, "highcontention", new Table())).ToList();
            await Task.WhenAll(tasks);
        }

        [Fact]
        public void GetTable_Views()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var options = new GetTableOptions { View = TableView.Basic };
            var basicTable = client.GetTable(_fixture.DatasetId, _fixture.PeopleTableId, options);
            options = new GetTableOptions { View = TableView.Full};
            var fullTable = client.GetTable(_fixture.DatasetId, _fixture.PeopleTableId, options);

            Assert.Null(basicTable.Resource.NumLongTermBytes);
            Assert.NotNull(fullTable.Resource.NumLongTermBytes);
            Assert.Equal(ToJson(basicTable.Reference), ToJson(fullTable.Reference));
            Assert.Equal(ToJson(basicTable.Schema), ToJson(fullTable.Schema));

            string ToJson(object obj) => NewtonsoftJsonSerializer.Instance.Serialize(obj);
        }

        [Fact]
        public void UpdateTable()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = client.CreateTable(datasetId, tableId, new Table { Description = "Description1", FriendlyName = "FriendlyName1" });

            // Modify locally...
            original.Resource.Description = "Description2";
            original.Resource.FriendlyName = "FriendlyName2";

            // Check the results of the update
            var updated = original.Update();
            Assert.Equal("Description2", updated.Resource.Description);
            Assert.Equal("FriendlyName2", updated.Resource.FriendlyName);

            // Check that it's still valid if fetched directly
            var fetched = client.GetTable(datasetId, tableId);
            Assert.Equal("Description2", fetched.Resource.Description);
            Assert.Equal("FriendlyName2", fetched.Resource.FriendlyName);
            Assert.NotEqual(original.Resource.ETag, updated.Resource.ETag);
            Assert.Equal(fetched.Resource.ETag, updated.Resource.ETag);
        }

        [Fact]
        public void UpdateTable_Conflict()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = client.CreateTable(datasetId, tableId, new Table { Description = "Description1", FriendlyName = "FriendlyName1" });

            // Modify on the server, which will change the etag
            var sneaky = client.GetTable(datasetId, tableId);
            sneaky.Resource.FriendlyName = "Sneak attack!";
            sneaky.Update();

            // Modify the originally-created version...
            original.Resource.Description = "Description2";

            // Fails due to the conflict.
            var exception = Assert.Throws<GoogleApiException>(() => original.Update());
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        }

        [Fact]
        public void PatchTable()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = client.CreateTable(datasetId, tableId, new Table { Description = "Description1", FriendlyName = "FriendlyName1" });
            var patched = original.Patch(new Table { Description = "Description2" }, matchETag: false);

            // Check the results of the patch
            Assert.Equal("Description2", patched.Resource.Description);
            Assert.Equal("FriendlyName1", patched.Resource.FriendlyName);

            // Check that it's still valid if fetched directly
            var fetched = client.GetTable(datasetId, tableId);
            Assert.Equal("Description2", fetched.Resource.Description);
            Assert.Equal("FriendlyName1", fetched.Resource.FriendlyName);
            Assert.Equal(fetched.Resource.ETag, patched.Resource.ETag);
        }

        [Fact]
        public void PatchTable_ConflictMatchEtag()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = client.CreateTable(datasetId, tableId, new Table { Description = "Description1", FriendlyName = "FriendlyName1" });

            // Modify on the server, which will change the etag
            var sneaky = client.GetTable(datasetId, tableId);
            sneaky.Resource.FriendlyName = "Sneak attack!";
            sneaky.Update();

            // Fails due to the conflict.
            var exception = Assert.Throws<GoogleApiException>(() => original.Patch(new Table { Description = "Description2" }, matchETag: true));
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        }

        [Fact]
        public void PatchTable_ConflictDontMatchEtag()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = client.CreateTable(datasetId, tableId, new Table { Description = "Description1", FriendlyName = "FriendlyName1" });

            // Modify on the server, which will change the etag
            var sneaky = client.GetTable(datasetId, tableId);
            sneaky.Resource.FriendlyName = "Sneak attack!";
            sneaky.Update();

            // Patch from the original, but don't bother with optimistic concurrency checks. (Don't propagate the etag.)
            var patched = original.Patch(new Table { Description = "Description2" }, matchETag: false);

            // Check the results of the patch
            Assert.Equal("Description2", patched.Resource.Description);
            Assert.Equal("Sneak attack!", patched.Resource.FriendlyName);

            // Check that it's still valid if fetched directly
            var fetched = client.GetTable(datasetId, tableId);
            Assert.Equal("Description2", fetched.Resource.Description);
            Assert.Equal("Sneak attack!", fetched.Resource.FriendlyName);
        }

        [Fact]
        public async Task UpdateTableAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = await client.CreateTableAsync(datasetId, tableId, new Table { Description = "Description1", FriendlyName = "FriendlyName1" });

            // Modify locally...
            original.Resource.Description = "Description2";
            original.Resource.FriendlyName = "FriendlyName2";

            // Check the results of the update
            var updated = await original.UpdateAsync();
            Assert.Equal("Description2", updated.Resource.Description);
            Assert.Equal("FriendlyName2", updated.Resource.FriendlyName);

            // Check that it's still valid if fetched directly
            var fetched = await client.GetTableAsync(datasetId, tableId);
            Assert.Equal("Description2", fetched.Resource.Description);
            Assert.Equal("FriendlyName2", fetched.Resource.FriendlyName);
            Assert.NotEqual(original.Resource.ETag, updated.Resource.ETag);
            Assert.Equal(fetched.Resource.ETag, updated.Resource.ETag);
        }

        [Fact]
        public async Task UpdateTableAsync_Conflict()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = await client.CreateTableAsync(datasetId, tableId, new Table { Description = "Description1", FriendlyName = "FriendlyName1" });

            // Modify on the server, which will change the etag
            var sneaky = await client.GetTableAsync(datasetId, tableId);
            sneaky.Resource.FriendlyName = "Sneak attack!";
            sneaky.Update();

            // Modify the originally-created version...
            original.Resource.Description = "Description2";

            // Fails due to the conflict.
            var exception = await Assert.ThrowsAsync<GoogleApiException>(() => original.UpdateAsync());
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        }

        [Fact]
        public async Task PatchTableAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = await client.CreateTableAsync(datasetId, tableId, new Table { Description = "Description1", FriendlyName = "FriendlyName1" });
            var patched = await original.PatchAsync(new Table { Description = "Description2" }, matchETag: false);

            // Check the results of the patch
            Assert.Equal("Description2", patched.Resource.Description);
            Assert.Equal("FriendlyName1", patched.Resource.FriendlyName);

            // Check that it's still valid if fetched directly
            var fetched = await client.GetTableAsync(datasetId, tableId);
            Assert.Equal("Description2", fetched.Resource.Description);
            Assert.Equal("FriendlyName1", fetched.Resource.FriendlyName);
            Assert.Equal(fetched.Resource.ETag, patched.Resource.ETag);
        }

        [Fact]
        public async Task PatchTableAsync_ConflictMatchEtag()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = await client.CreateTableAsync(datasetId, tableId, new Table { Description = "Description1", FriendlyName = "FriendlyName1" });

            // Modify on the server, which will change the etag
            var sneaky = await client.GetTableAsync(datasetId, tableId);
            sneaky.Resource.FriendlyName = "Sneak attack!";
            sneaky.Update();

            // Fails due to the conflict.
            var exception = await Assert.ThrowsAsync<GoogleApiException>(() => original.PatchAsync(new Table { Description = "Description2" }, matchETag: true));
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        }

        [Fact]
        public async Task PatchTableAsync_ConflictDontMatchEtag()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = await client.CreateTableAsync(datasetId, tableId, new Table { Description = "Description1", FriendlyName = "FriendlyName1" });

            // Modify on the server, which will change the etag
            var sneaky = await client.GetTableAsync(datasetId, tableId);
            sneaky.Resource.FriendlyName = "Sneak attack!";
            sneaky.Update();

            // Patch from the original, but don't bother with optimistic concurrency checks. (Don't propagate the etag.)
            var patched = await original.PatchAsync(new Table { Description = "Description2" }, matchETag: false);

            // Check the results of the patch
            Assert.Equal("Description2", patched.Resource.Description);
            Assert.Equal("Sneak attack!", patched.Resource.FriendlyName);

            // Check that it's still valid if fetched directly
            var fetched = await client.GetTableAsync(datasetId, tableId);
            Assert.Equal("Description2", fetched.Resource.Description);
            Assert.Equal("Sneak attack!", fetched.Resource.FriendlyName);
        }

        [Fact]
        public void ListTables_ResourceConversion()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            client.CreateTable(datasetId, tableId, new Table { FriendlyName = "FriendlyName" });
            var list = client.ListTables(datasetId).ToList();
            Assert.Contains(list, candidate => candidate.Reference.TableId == tableId && candidate.Resource.FriendlyName == "FriendlyName");
        }


        [Fact]
        public void ListTables_ResumeWithPageToken()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var totalCount = client.ListTables(datasetId).Count();
            // We want to check that when reading the remained, we still need to paginate.
            // (If we had a bug that always used the original page token, we'd end up in an infinite loop.)
            Assert.True(totalCount > 4, "Must have more than 4 tables for pagination test");
            var firstPage = client.ListTables(datasetId).ReadPage(2);
            Assert.NotNull(firstPage.NextPageToken);

            var options = new ListTablesOptions { PageSize = 2, PageToken = firstPage.NextPageToken };
            var remainder = client.ListTables(datasetId, options).ToList();
            Assert.Equal(totalCount - 2, remainder.Count);
        }

        public static IEnumerable<object[]> FullSchemaOptions
        {
            get
            {
                yield return new object[] { null };
                // Null or empty SelectedFields return the whole schema.
                yield return new object[] { new GetTableOptions { SelectedFields = null } };
                yield return new object[] { new GetTableOptions { SelectedFields = string.Empty } };
            }
        }

        [Theory]
        [MemberData(nameof(FullSchemaOptions))]
        public void GetTable_FullSchema(GetTableOptions options)
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            string tableId = _fixture.HighScoreExtendedTableId;

            var table = client.GetTable(datasetId, tableId, options);

            Assert.Equal(4, table.Schema.Fields.Count);
            Assert.Equal("player", table.Schema.Fields[0].Name);
            Assert.Equal("gameStarted", table.Schema.Fields[1].Name);
            Assert.Equal("score", table.Schema.Fields[2].Name);
            Assert.Equal("gameFinished", table.Schema.Fields[3].Name);
        }

        [Fact]
        public void GetTable_PartialSchema_SimpleTypes()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            string tableId = _fixture.HighScoreExtendedTableId;
            var options = new GetTableOptions
            {
                SelectedFields = "player,score"
            };
            var table = client.GetTable(datasetId, tableId, options);

            Assert.Equal(2, table.Schema.Fields.Count);
            Assert.Equal("player", table.Schema.Fields[0].Name);
            Assert.Equal("score", table.Schema.Fields[1].Name);
        }

        [Fact]
        public void GetTable_PartialSchema_SimpleTypes_Ordered()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            string tableId = _fixture.HighScoreExtendedTableId;
            var options = new GetTableOptions
            {
                // Specify selected fields in a different order
                // to the one they were created in.
                SelectedFields = "score,player"
            };
            var table = client.GetTable(datasetId, tableId, options);

            Assert.Equal(2, table.Schema.Fields.Count);
            // The schema still contains the fields in the same order
            // as the one they were created in.
            Assert.Equal("player", table.Schema.Fields[0].Name);
            Assert.Equal("score", table.Schema.Fields[1].Name);
        }

        [Fact]
        public void GetTable_PartialSchema_ComplexTypes()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            string tableId = _fixture.PeopleTableId;
            var options = new GetTableOptions
            {
                SelectedFields = "age,gender,phoneNumber,children.gender,children.age"
            };
            var table = client.GetTable(datasetId, tableId, options);

            // We still have 4 top level fields because nesting is preserved
            // when requesting a partial table schema.
            Assert.Equal(4, table.Schema.Fields.Count);

            Assert.Equal("age", table.Schema.Fields[0].Name);
            Assert.Equal("gender", table.Schema.Fields[1].Name);

            Assert.Equal("phoneNumber", table.Schema.Fields[2].Name);
            Assert.Equal(2, table.Schema.Fields[2].Fields.Count);
            Assert.Equal("areaCode", table.Schema.Fields[2].Fields[0].Name);
            Assert.Equal("number", table.Schema.Fields[2].Fields[1].Name);

            Assert.Equal("children", table.Schema.Fields[3].Name);
            Assert.Equal(2, table.Schema.Fields[3].Fields.Count);
            Assert.Equal("gender", table.Schema.Fields[3].Fields[0].Name);
            Assert.Equal("age", table.Schema.Fields[3].Fields[1].Name);
        }

        [Fact]
        public void GetTableIamPolicy()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var policy = client.GetTableIamPolicy(
                _fixture.DatasetId, _fixture.HighScoreTableId, new GetTableIamPolicyOptions { PolicyVersion = 3 });

            Assert.NotNull(policy.ETag);
        }

        [Fact]
        public void SetTableIamPolicy()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var tableId = _fixture.CreateTableId();
            client.CreateTable(_fixture.DatasetId, tableId, new Table { FriendlyName = "FriendlyName" });

            var existingPolicy = client.GetTableIamPolicy(_fixture.DatasetId, tableId);

            existingPolicy.Bindings ??= new List<Binding>();

            existingPolicy.Bindings.Add(new Binding
            {
                Members = new List<string> { "domain:google.com" },
                Role = "roles/bigquery.dataViewer"
            });

            var updatedPolicy = client.SetTableIamPolicy(_fixture.DatasetId, tableId, existingPolicy);
            Assert.Contains(updatedPolicy.Bindings,
                binding => binding.Role == "roles/bigquery.dataViewer" && binding.Members.Single() == "domain:google.com");
        }

        [Fact]
        public void TestTableIamPermissions()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            var response = client.TestTableIamPermissions(_fixture.DatasetId, _fixture.HighScoreTableId, new List<string> { "bigquery.tables.get" });
            Assert.Collection(response.Permissions, role => Assert.Equal("bigquery.tables.get", role));
        }

        [Fact]
        public void CreateTableWithPolicyTagsFields()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);

            string sampleTag = $"projects/{_fixture.ProjectId}/locations/us/taxonomies/1/policyTags/2";
            var dataset = client.GetDataset(_fixture.DatasetId);
            var tableId = _fixture.CreateTableId();

            var schema = new TableSchemaBuilder
            {
                { "full_name", BigQueryDbType.String, BigQueryFieldMode.Nullable, "field with policy tag" }
            }.ModifyField("full_name", field => field.PolicyTags = new PolicyTagsData { Names = new[] { sampleTag } })
            .Build();

            dataset.CreateTable(tableId, schema);
            var table = dataset.GetTable(tableId);

            Assert.Contains(sampleTag, table.Schema.Fields.First().PolicyTags.Names);
        }
    }
}
