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

using System;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore.CleanTestData
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string project = Environment.GetEnvironmentVariable("FIRESTORE_TEST_PROJECT");
            var db = FirestoreDb.Create(project);
            var collections = await db.ListRootCollectionsAsync().ToListAsync();
            foreach (var collection in collections)
            {
                if (collection.Id.StartsWith("test-"))
                {
                    await DeleteCollectionAsync(collection);
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
        }
    }
}
