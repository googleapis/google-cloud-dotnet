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

int callCount = 0;
int resultCount = 0;
collection.Listen((QuerySnapshot querySnapshot) =>
{
    foreach (var sn in querySnapshot)
    {
        var subcollection = sn.Reference.Collection("subcollection");

        Interlocked.Increment(ref callCount);
        subcollection.Listen((QuerySnapshot querySnapshot) =>
        {
            Interlocked.Increment(ref resultCount);
        });
    }
});

Thread.Sleep(10000);

Console.WriteLine($"Calls: {callCount}; Results: {resultCount}");
