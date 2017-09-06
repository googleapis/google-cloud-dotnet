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
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    // Note: some of these tests fetch the table in a way that looks unnecessary.
    // Currently, the etag changes between a table being created and it first being fetched,
    // which breaks the "create, update" approach. I'm investigating why this happens.

    [Collection(nameof(BigQueryFixture))]
    public class TablesTest
    {
        private readonly BigQueryFixture _fixture;

        public TablesTest(BigQueryFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void UpdateTable()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = client.CreateTable(datasetId, tableId, new TableSchema(), new CreateTableOptions { Description = "Description1", FriendlyName = "FriendlyName1" });

            // Modify locally...
            original.Resource.Description = "Description2";
            original.Resource.FriendlyName = "FriendlyName2";

            // FIXME: I shouldn't need to do this.
            original.Resource.ETag = client.GetTable(datasetId, tableId).Resource.ETag;

            // Check the results of the update
            var updated = original.Update();
            Assert.Equal("Description2", updated.Resource.Description);
            Assert.Equal("FriendlyName2", updated.Resource.FriendlyName);

            // Check that it's still valid if fetched directly
            var fetched = client.GetTable(datasetId, tableId);
            Assert.Equal("Description2", fetched.Resource.Description);
            Assert.Equal("FriendlyName2", fetched.Resource.FriendlyName);
        }

        [Fact]
        public void UpdateTable_Conflict()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = client.CreateTable(datasetId, tableId, new TableSchema(), new CreateTableOptions { Description = "Description1", FriendlyName = "FriendlyName1" });

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

            var original = client.CreateTable(datasetId, tableId, new TableSchema(), new CreateTableOptions { Description = "Description1", FriendlyName = "FriendlyName1" });
            var patched = original.Patch(new Table { Description = "Description2" }, matchETag: false);

            // Check the results of the patch
            Assert.Equal("Description2", patched.Resource.Description);
            Assert.Equal("FriendlyName1", patched.Resource.FriendlyName);

            // Check that it's still valid if fetched directly
            var fetched = client.GetTable(datasetId, tableId);
            Assert.Equal("Description2", fetched.Resource.Description);
            Assert.Equal("FriendlyName1", fetched.Resource.FriendlyName);
        }

        [Fact]
        public void PatchTable_ConflictMatchEtag()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = client.CreateTable(datasetId, tableId, new TableSchema(), new CreateTableOptions { Description = "Description1", FriendlyName = "FriendlyName1" });
            // FIXME: I shouldn't need to do this.
            original.Resource.ETag = client.GetTable(datasetId, tableId).Resource.ETag;

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

            var original = client.CreateTable(datasetId, tableId, new TableSchema(), new CreateTableOptions { Description = "Description1", FriendlyName = "FriendlyName1" });
            // FIXME: I shouldn't need to do this.
            original.Resource.ETag = client.GetTable(datasetId, tableId).Resource.ETag;

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

            var original = await client.CreateTableAsync(datasetId, tableId, new TableSchema(), new CreateTableOptions { Description = "Description1", FriendlyName = "FriendlyName1" });

            // Modify locally...
            original.Resource.Description = "Description2";
            original.Resource.FriendlyName = "FriendlyName2";

            // FIXME: I shouldn't need to do this.
            original.Resource.ETag = client.GetTable(datasetId, tableId).Resource.ETag;

            // Check the results of the update
            var updated = await original.UpdateAsync();
            Assert.Equal("Description2", updated.Resource.Description);
            Assert.Equal("FriendlyName2", updated.Resource.FriendlyName);

            // Check that it's still valid if fetched directly
            var fetched = await client.GetTableAsync(datasetId, tableId);
            Assert.Equal("Description2", fetched.Resource.Description);
            Assert.Equal("FriendlyName2", fetched.Resource.FriendlyName);
        }

        [Fact]
        public async Task UpdateTableAsync_Conflict()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = await client.CreateTableAsync(datasetId, tableId, new TableSchema(), new CreateTableOptions { Description = "Description1", FriendlyName = "FriendlyName1" });

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

            var original = await client.CreateTableAsync(datasetId, tableId, new TableSchema(), new CreateTableOptions { Description = "Description1", FriendlyName = "FriendlyName1" });
            var patched = await original.PatchAsync(new Table { Description = "Description2" }, matchETag: false);

            // Check the results of the patch
            Assert.Equal("Description2", patched.Resource.Description);
            Assert.Equal("FriendlyName1", patched.Resource.FriendlyName);

            // Check that it's still valid if fetched directly
            var fetched = await client.GetTableAsync(datasetId, tableId);
            Assert.Equal("Description2", fetched.Resource.Description);
            Assert.Equal("FriendlyName1", fetched.Resource.FriendlyName);
        }

        [Fact]
        public async Task PatchTableAsync_ConflictMatchEtag()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var tableId = _fixture.CreateTableId();

            var original = await client.CreateTableAsync(datasetId, tableId, new TableSchema(), new CreateTableOptions { Description = "Description1", FriendlyName = "FriendlyName1" });
            // FIXME: I shouldn't need to do this.
            original.Resource.ETag = client.GetTable(datasetId, tableId).Resource.ETag;

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

            var original = await client.CreateTableAsync(datasetId, tableId, new TableSchema(), new CreateTableOptions { Description = "Description1", FriendlyName = "FriendlyName1" });
            // FIXME: I shouldn't need to do this.
            original.Resource.ETag = client.GetTable(datasetId, tableId).Resource.ETag;

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

            client.CreateTable(datasetId, tableId, new TableSchema(), new CreateTableOptions { FriendlyName = "FriendlyName" });
            var list = client.ListTables(datasetId).ToList();
            Assert.Contains(list, candidate => candidate.Reference.TableId == tableId && candidate.Resource.FriendlyName == "FriendlyName");
        }
    }
}
