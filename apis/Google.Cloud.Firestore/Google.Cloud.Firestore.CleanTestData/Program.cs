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
        string project = Environment.GetEnvironmentVariable("TEST_PROJECT");
        await DeleteDatabasesAsync(project);
    }

    private static async Task DeleteDatabasesAsync(string projectId)
    {
        var adminClient = await FirestoreAdminClient.CreateAsync();
        var databases = (await adminClient.ListDatabasesAsync(ProjectName.FromProject(projectId))).Databases
            .Where(db => db.DatabaseName.DatabaseId.StartsWith("test-", StringComparison.Ordinal))
            .ToList();
        foreach (var database in databases)
        {
            await DeleteDatabaseAsync(database.DatabaseName);
        }

        async Task DeleteDatabaseAsync(DatabaseName dbName)
        {
            Console.WriteLine($"Attempting to delete {dbName.DatabaseId}");
            try
            {
                await adminClient.DeleteDatabaseAsync(dbName);
                Console.WriteLine($"Success deleting {dbName.DatabaseId}");
                // Firestore has a default quota of 60 database operations per minute.
                // We wait 1 second in between database deletes.
                await Task.Delay(1000);
            }
            catch (HttpRequestException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
            {
                Console.WriteLine($"Failure deleting {dbName.DatabaseId}: Not Found");
            }
        }
    }
}
