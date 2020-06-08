// Copyright 2020 Google LLC
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

using Google.Apis.Bigquery.v2.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    [Collection(nameof(BigQueryMLFixture))]
    public class ModelTests
    {
        private readonly BigQueryMLFixture _fixture;

        public ModelTests(BigQueryMLFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void PatchModel()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var modelId = _fixture.ModelId;

            var original = client.GetModel(datasetId, modelId);
            var originalDescription = original.Resource.Description;
            var patched = original.Patch(new Model { Description = $"{originalDescription}_patched" }, matchETag: false);

            // Check the results of the patch
            Assert.Equal($"{originalDescription}_patched", patched.Resource.Description);

            // Check that it's still valid if fetched directly
            var fetched = client.GetModel(datasetId, modelId);
            Assert.Equal($"{originalDescription}_patched", fetched.Resource.Description);
            Assert.Equal(fetched.Resource.ETag, patched.Resource.ETag);
        }

        [Fact]
        public void PatchModel_ConflictMatchEtag()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var modelId = _fixture.ModelId;

            var original = client.GetModel(datasetId, modelId);

            // Modify on the server, which will change the etag
            var sneaky = client.GetModel(datasetId, modelId);
            sneaky = sneaky.Patch(new Model { Description = "Sneak attack!" }, matchETag: false);

            // Fails due to the conflict.
            var exception = Assert.Throws<GoogleApiException>(() => original.Patch(new Model { Description = "Description" }, matchETag: true));
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        }

        [Fact]
        public async Task PatchModelAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var modelId = _fixture.ModelId;

            var original = client.GetModel(datasetId, modelId);
            var originalDescription = original.Resource.Description;
            var patched = await original.PatchAsync(new Model { Description = $"{originalDescription}_patched" }, matchETag: false);

            // Check the results of the patch
            Assert.Equal($"{originalDescription}_patched", patched.Resource.Description);

            // Check that it's still valid if fetched directly
            var fetched = client.GetModel(datasetId, modelId);
            Assert.Equal($"{originalDescription}_patched", fetched.Resource.Description);
            Assert.Equal(fetched.Resource.ETag, patched.Resource.ETag);
        }

        [Fact]
        public void ListModels()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var modelId = _fixture.ModelId;

            var list = client.ListModels(datasetId).ToList();
            Assert.Contains(list, candidate => candidate.Reference.ModelId == modelId);
        }

        [Fact]
        public async Task ListModelsAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var modelId = _fixture.ModelId;

            var list = await client.ListModelsAsync(datasetId).ToListAsync();
            Assert.Contains(list, candidate => candidate.Reference.ModelId == modelId);
        }

        [Fact]
        public void DeleteModel()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var modelId = _fixture.CreateModelId();

            _fixture.CreateModel(client, datasetId, modelId);
            var model = client.GetModel(datasetId, modelId);

            model.Delete();

            var list = client.ListModels(datasetId).ToList();
            Assert.DoesNotContain(list, candidate => candidate.Reference.ModelId == modelId);
        }

        [Fact]
        public async Task DeleteModelAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var modelId = _fixture.CreateModelId();

            _fixture.CreateModel(client, datasetId, modelId);
            var model = client.GetModel(datasetId, modelId);

            await model.DeleteAsync();

            var list = client.ListModels(datasetId).ToList();
            Assert.DoesNotContain(list, candidate => candidate.Reference.ModelId == modelId);
        }

        [Fact]
        public async Task GetModelAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var modelId = _fixture.CreateModelId();

            _fixture.CreateModel(client, datasetId, modelId);
            var model = await client.GetModelAsync(datasetId, modelId);

            Assert.Equal(modelId, model.Reference.ModelId);
        }
    }
}
