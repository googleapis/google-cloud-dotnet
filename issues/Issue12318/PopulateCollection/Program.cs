// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Cloud.Firestore;

if (args.Length != 3)
{
    Console.WriteLine("Arguments: <project-id> <collection-id> <count>");
    return;
}

string projectId = args[0];
string collectionId = args[1];
int count = int.Parse(args[2]);

var db = FirestoreDb.Create(projectId);

var collection = db.Collection(collectionId);
// Note: this will fail if count is too high, but for the moment we'll assume we're fine.
// This is much quicker than writing one document at a time.
var batch = db.StartBatch();
for (int i = 0; i < count; i++)
{
    batch.Set(collection.Document(), new { Id = i });
}
await batch.CommitAsync();

var fetchedCount = (await collection.Count().GetSnapshotAsync()).Count;
Console.WriteLine($"Count after fetching: {fetchedCount}");
