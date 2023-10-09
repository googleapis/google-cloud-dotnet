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
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore.CleanTestData;

internal class Program
{
    private static async Task Main()
    {
        string project = Environment.GetEnvironmentVariable("FIRESTORE_TEST_PROJECT");

        await DeleteCollectionsAsync(project);
        await DeleteIndexesAsync(project);
        await DeleteDatabasesAsync(project);
    }

    private static async Task DeleteCollectionsAsync(string projectId)
    {
        var db = await FirestoreDb.CreateAsync(projectId);
        var collections = await db.ListRootCollectionsAsync()
            .Where(collection => collection.Id.StartsWith("test-", StringComparison.Ordinal))
            .ToListAsync();
        foreach (var collection in collections)
        {
            // Log which collections we're deleting here rather than in DeleteCollectionAsync,
            // as that's called recursively.
            Console.WriteLine($"Deleting collection {collection.Id}");
            await DeleteCollectionAsync(collection);
        }

        async Task DeleteCollectionAsync(CollectionReference collection)
        {
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
    }

    private static async Task DeleteIndexesAsync(string projectId)
    {
        var adminClient = await FirestoreAdminClient.CreateAsync();
        var indexes = await adminClient.ListIndexesAsync(new CollectionGroupName(projectId, "(default)", "-"))
            .Where(index => index.IndexName.CollectionId.StartsWith("test-", StringComparison.Ordinal))
            .ToListAsync();

        foreach (var index in indexes)
        {
            Console.WriteLine($"Deleting index {index.Name}");
            await adminClient.DeleteIndexAsync(index.IndexName);
        }
    }

    private static async Task DeleteDatabasesAsync(string projectId)
    {
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

        var deleteDatabaseEndpointTemplate = $"{restApiUrlBase}/projects/{projectId}/databases/";
        var databases = (await adminClient.ListDatabasesAsync(ProjectName.FromProject(projectId))).Databases
            .Where(db => db.DatabaseName.DatabaseId.StartsWith("test-", StringComparison.Ordinal))
            .ToList();
        foreach (var database in databases)
        {
            await DeleteDatabaseAsync(database.DatabaseName.DatabaseId);
        }

        async Task DeleteDatabaseAsync(string databaseId)
        {
            Console.WriteLine($"Attempting to delete {databaseId}");
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
