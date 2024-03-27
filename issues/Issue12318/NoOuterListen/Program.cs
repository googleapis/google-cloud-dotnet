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

if (args.Length != 2)
{
    Console.WriteLine("Arguments: <project-id> <collection-id>");
    return;
}

string projectId = args[0];
string collectionId = args[1];

var db = FirestoreDb.Create(projectId);

var collection = db.Collection(collectionId);

int callbackCount = 0;

var snapshot = await collection.GetSnapshotAsync();
foreach (var doc in snapshot)
{
    var listener = doc.Reference.Listen(snapshot => Interlocked.Increment(ref callbackCount));
    _ = listener.ListenerTask.ContinueWith(task => Console.WriteLine(task.Exception), TaskContinuationOptions.OnlyOnFaulted);
}

Thread.Sleep(10000);

Console.WriteLine($"Docs: {snapshot.Count}; Callbacks to listener: {callbackCount}");
