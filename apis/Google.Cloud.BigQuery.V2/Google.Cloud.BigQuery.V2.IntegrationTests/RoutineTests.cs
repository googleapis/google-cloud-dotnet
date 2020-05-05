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
    [Collection(nameof(BigQueryFixture))]
    public class RoutineTests
    {
        private readonly BigQueryFixture _fixture;

        public RoutineTests(BigQueryFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Create()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var routineId = _fixture.CreateRoutineId();
            Routine routine = new Routine
            {
                DefinitionBody = "SELECT 1;",
                Description = "test routine",
            };
            routine.SetRoutineLanguage(RoutineLanguage.Sql);
            routine.SetRoutineType(RoutineType.StoredProcedure);

            var created = client.CreateRoutine(datasetId, routineId, routine);
            var fetched = client.GetRoutine(datasetId, routineId);

            Assert.Equal(created.Resource.ETag, fetched.Resource.ETag);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var routineId = _fixture.CreateRoutineId();
            Routine routine = new Routine
            {
                DefinitionBody = "SELECT 1;",
                Description = "test routine",
            };
            routine.SetRoutineLanguage(RoutineLanguage.Sql);
            routine.SetRoutineType(RoutineType.StoredProcedure);

            var created = await client.CreateRoutineAsync(datasetId, routineId, routine);
            var fetched = client.GetRoutine(datasetId, routineId);

            Assert.Equal(created.Resource.ETag, fetched.Resource.ETag);
        }

        [Fact]
        public void Get()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var dataset = client.GetDataset(_fixture.DatasetId);
            var routineId = _fixture.CreateRoutineId();
            _fixture.CreateRoutine(routineId, dataset);

            var fetched = client.GetRoutine(datasetId, routineId);

            Assert.Equal(routineId, fetched.Reference.RoutineId);
        }

        [Fact]
        public async Task GetAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var dataset = client.GetDataset(_fixture.DatasetId);
            var routineId = _fixture.CreateRoutineId();
            _fixture.CreateRoutine(routineId, dataset);

            var fetched = await client.GetRoutineAsync(datasetId, routineId);

            Assert.Equal(routineId, fetched.Reference.RoutineId);
        }

        [Fact]
        public void Delete()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var dataset = client.GetDataset(_fixture.DatasetId);
            var routineId = _fixture.CreateRoutineId();
            _fixture.CreateRoutine(routineId, dataset);

            client.DeleteRoutine(datasetId, routineId);

            var exception = Assert.Throws<GoogleApiException>(() => client.GetRoutine(datasetId, routineId));
            Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var dataset = client.GetDataset(_fixture.DatasetId);
            var routineId = _fixture.CreateRoutineId();
            _fixture.CreateRoutine(routineId, dataset);

            await client.DeleteRoutineAsync(datasetId, routineId);

            var exception = Assert.Throws<GoogleApiException>(() => client.GetRoutine(datasetId, routineId));
            Assert.Equal(HttpStatusCode.NotFound, exception.HttpStatusCode);
        }

        [Fact]
        public void List()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var dataset = client.GetDataset(_fixture.DatasetId);
            var routineId = _fixture.CreateRoutineId();
            _fixture.CreateRoutine(routineId, dataset);

            var fetched = client.ListRoutines(datasetId);

            Assert.Contains(fetched, routine => routine.Reference.RoutineId == routineId);
        }

        [Fact]
        public async Task ListAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var dataset = client.GetDataset(_fixture.DatasetId);
            var routineId = _fixture.CreateRoutineId();
            _fixture.CreateRoutine(routineId, dataset);

            var fetched = await client.ListRoutinesAsync(datasetId).ToListAsync();

            Assert.Contains(fetched, routine => routine.Reference.RoutineId == routineId);
        }

        [Fact]
        public void Update()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var dataset = client.GetDataset(_fixture.DatasetId);
            var routineId = _fixture.CreateRoutineId();
            _fixture.CreateRoutine(routineId, dataset);

            var fetched = client.GetRoutine(datasetId, routineId);
            fetched.Resource.Description = "updated description";
            fetched.Resource.DefinitionBody = "SELECT 2;";

            var updated = fetched.Update();

            Assert.Equal(routineId, updated.Reference.RoutineId);
            Assert.Equal("updated description", updated.Resource.Description);
            Assert.Equal("SELECT 2;", updated.Resource.DefinitionBody);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var dataset = client.GetDataset(_fixture.DatasetId);
            var routineId = _fixture.CreateRoutineId();
            _fixture.CreateRoutine(routineId, dataset);

            var fetched = client.GetRoutine(datasetId, routineId);
            fetched.Resource.Description = "updated description";
            fetched.Resource.DefinitionBody = "SELECT 2;";

            var updated = await fetched.UpdateAsync();

            Assert.Equal(routineId, updated.Reference.RoutineId);
            Assert.Equal("updated description", updated.Resource.Description);
            Assert.Equal("SELECT 2;", updated.Resource.DefinitionBody);
        }

        [Fact(Skip = "It seems that ETag is not being used in Routine to prevent concurrent modifications.")]
        public void UpdateModel_ConflictMatchEtag()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var dataset = client.GetDataset(_fixture.DatasetId);
            var routineId = _fixture.CreateRoutineId();

            _fixture.CreateRoutine(routineId, dataset);
            var original = client.GetRoutine(datasetId, routineId);

            // Modify on the server, which will change the etag
            var sneaky = client.GetRoutine(datasetId, routineId);
            sneaky.Resource.Description = "Sneak attack!";
            sneaky.Update();

            // Fails due to the conflict.
            original.Resource.Description = "Description";
            
            var exception = Assert.Throws<GoogleApiException>(() => original.Update());
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        }
    }
}
