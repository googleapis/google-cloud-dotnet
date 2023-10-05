// Copyright 2019, Google LLC
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

using Google.Api.Gax.ResourceNames;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Http;
using Google.Cloud.Firestore.Admin.V1;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Google.Cloud.Firestore.CleanTestData
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            string project = Environment.GetEnvironmentVariable("FIRESTORE_TEST_PROJECT");

            var db = await FirestoreDb.CreateAsync(project);
            var adminClient = await FirestoreAdminClient.CreateAsync();

            // Use the REST API for operations not yet supported by Google.Cloud.Firestore.Admin.V1,
            // currently DB deletion.
            // TODO: Start using Google.Cloud.Firestore.Admin.V1 when it supports DB deletion.
            string credentialsPath = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");
            string restApiUrlBase = "https://firestore.googleapis.com/v1";
            string scope = "https://www.googleapis.com/auth/datastore";
            GoogleCredential googleCredential = GoogleCredential.FromFile(credentialsPath).CreateScoped(scope);
            HttpClient httpClient = new HttpClientFactory()
                .CreateHttpClient(new CreateHttpClientArgs { Initializers = { googleCredential } });

            var collections = await db.ListRootCollectionsAsync().ToListAsync();
            foreach (var collection in collections)
            {
                if (collection.Id.StartsWith("test-", StringComparison.Ordinal))
                {
                    await DeleteCollectionAsync(collection);
                }
            }

            var deleteDatabaseEndpointTemplate = $"{restApiUrlBase}/projects/{project}/databases/";
            var databases = (await adminClient.ListDatabasesAsync(ProjectName.FromProject(project))).Databases;
            foreach (var database in databases)
            {
                if (database.DatabaseName.DatabaseId.StartsWith("db", StringComparison.Ordinal))
                {
                    await DeleteDatabaseAsync(database.DatabaseName.DatabaseId);
                }
            }

            async Task DeleteCollectionAsync(CollectionReference collection)
            {
                Console.WriteLine($"Deleting {collection.Id}");
                var allDocs = await collection.ListDocumentsAsync().ToListAsync();
                // Note: one batch per collection is less efficient than filling the batch each time,
                // but it's not a big problem.
                var batch = db.StartBatch();
                foreach (var doc in allDocs)
                {
                    foreach (var child in await doc.ListCollectionsAsync().ToListAsync())
                    {
                        await DeleteCollectionAsync(child);
                    }
                    batch.Delete(doc);
                }
                await batch.CommitAsync();
            }

            async Task DeleteDatabaseAsync(string databaseId)
            {
                Console.WriteLine($"Attemting to delete {databaseId}");
                try
                {
                    var deleteDatabaseEndpoint = new Uri($"{deleteDatabaseEndpointTemplate}{databaseId}");
                    var response = await httpClient.DeleteAsync(deleteDatabaseEndpoint);
                    response.EnsureSuccessStatusCode();
                    Console.WriteLine($"Success deleting {databaseId}");
                }
                catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Failure deleting {databaseId}: Not Found");
                }
            }
        }
    }
}
