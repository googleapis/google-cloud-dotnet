// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(FirestoreFixture))]
    public class IndexSnippets
    {
        private readonly FirestoreFixture _fixture;

        public IndexSnippets(FirestoreFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task GettingStarted()
        {
            string projectId = _fixture.ProjectId;
            string databaseId = _fixture.DatabaseId;
            // Sample: GettingStarted
            FirestoreDb db = new FirestoreDbBuilder { ProjectId = projectId, DatabaseId = databaseId }.Build();

            // Create a document with a random ID in the "users" collection.
            CollectionReference collection = db.Collection("users");
            DocumentReference document = await collection.AddAsync(new { Name = new { First = "Ada", Last = "Lovelace" }, Born = 1815 });

            // A DocumentReference doesn't contain the data - it's just a path.
            // Let's fetch the current document.
            DocumentSnapshot snapshot = await document.GetSnapshotAsync();

            // We can access individual fields by dot-separated path
            Console.WriteLine(snapshot.GetValue<string>("Name.First"));
            Console.WriteLine(snapshot.GetValue<string>("Name.Last"));
            Console.WriteLine(snapshot.GetValue<int>("Born"));

            // Or deserialize the whole document into a dictionary
            Dictionary<string, object> data = snapshot.ToDictionary();
            Dictionary<string, object> name = (Dictionary<string, object>) data["Name"];
            Console.WriteLine(name["First"]);
            Console.WriteLine(name["Last"]);

            // See the "data model" guide for more options for data handling.

            // Query the collection for all documents where doc.Born < 1900.
            Query query = collection.WhereLessThan("Born", 1900);
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
            foreach (DocumentSnapshot queryResult in querySnapshot.Documents)
            {
                string firstName = queryResult.GetValue<string>("Name.First");
                string lastName = queryResult.GetValue<string>("Name.Last");
                int born = queryResult.GetValue<int>("Born");
                Console.WriteLine($"{firstName} {lastName}; born {born}");
            }
            // End sample
        }

        [Fact]
        public void DetectEmulator()
        {
            string projectId = _fixture.ProjectId;
            string databaseId = _fixture.DatabaseId;
            // Sample: EmulatorDetection
            FirestoreDb db = new FirestoreDbBuilder
            {
                ProjectId = projectId,
                EmulatorDetection = EmulatorDetection.EmulatorOrProduction
            }.Build();
            // Use db as normal
            // End sample
        }
    }
}
