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
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net;
using System.Threading;
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
            var routine = CreateTestRoutineInMemory();

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
            var routine = CreateTestRoutineInMemory();

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

        /// <summary>
        /// Calls GetOrCreateRoutine with multiple concurrent requests. We create 5 threads all trying
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
        public void GetOrCreate_HighContention()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var datasetId = _fixture.CreateDatasetId();
            client.CreateDataset(datasetId);
            var routineId = _fixture.CreateRoutineId();
            var routine = CreateTestRoutineInMemory();

            int successes = 0;
            ConcurrentBag<Exception> exceptions = new ConcurrentBag<Exception>();
            var threads = Enumerable.Range(0, 5).Select(_ => new Thread(() =>
            {
                try
                {
                    client.GetOrCreateRoutine(datasetId, routineId, routine);
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
        /// See <see cref="GetOrCreate_HighContention"/> for commentary on the test.
        /// </summary>
        [Fact]
        public async Task GetOrCreateAsync_HighContention()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var datasetId = _fixture.CreateDatasetId();
            await client.CreateDatasetAsync(datasetId);
            var routineId = _fixture.CreateRoutineId();
            var routine = CreateTestRoutineInMemory();

            var tasks = Enumerable.Range(0, 5).Select(_ => client.GetOrCreateRoutineAsync(datasetId, routineId, routine)).ToList();
            await Task.WhenAll(tasks);
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
            fetched.Resource.DefinitionBody = "SELECT 2;";

            var updated = fetched.Update();

            Assert.Equal(routineId, updated.Reference.RoutineId);
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
            fetched.Resource.DefinitionBody = "SELECT 2;";

            var updated = await fetched.UpdateAsync();

            Assert.Equal(routineId, updated.Reference.RoutineId);
            Assert.Equal("SELECT 2;", updated.Resource.DefinitionBody);
        }

        [Fact]
        public void UpdateRoutine_ConflictMatchEtag()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            string datasetId = _fixture.DatasetId;
            var dataset = client.GetDataset(_fixture.DatasetId);
            var routineId = _fixture.CreateRoutineId();

            _fixture.CreateRoutine(routineId, dataset);
            var original = client.GetRoutine(datasetId, routineId);

            // Modify on the server, which will change the etag
            var sneaky = client.GetRoutine(datasetId, routineId);
            sneaky.Resource.DefinitionBody = "SELECT 'sneak attack!';";
            sneaky.Update();

            // Fails due to the conflict.
            original.Resource.DefinitionBody = "SELECT 2;";
            
            var exception = Assert.Throws<GoogleApiException>(() => original.Update());
            Assert.Equal(HttpStatusCode.PreconditionFailed, exception.HttpStatusCode);
        }

        private static Routine CreateTestRoutineInMemory()
        {
            Routine routine = new Routine
            {
                DefinitionBody = "SELECT 1;",
            };
            routine.SetRoutineLanguage(RoutineLanguage.Sql);
            routine.SetRoutineType(RoutineType.StoredProcedure);
            return routine;
        }
    }
}
