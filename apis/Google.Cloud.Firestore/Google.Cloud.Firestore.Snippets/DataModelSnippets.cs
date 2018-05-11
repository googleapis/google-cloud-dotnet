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

using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(FirestoreFixture))]
    public class DataModelSnippets
    {
        private readonly FirestoreFixture _fixture;

        public DataModelSnippets(FirestoreFixture fixture) => _fixture = fixture;

        // Sample: AttributedClass
        [FirestoreData]
        public class City
        {
            [FirestoreProperty]
            public string Name { get; set; }

            [FirestoreProperty]
            public string State { get; set; }

            [FirestoreProperty]
            public string Country { get; set; }

            [FirestoreProperty("Capital")]
            public bool IsCapital { get; set;  }

            [FirestoreProperty]
            public long Population { get; set; }
        }
        // End sample

        [Fact]
        public async Task AttributedClassUsage()
        {
            string projectId = _fixture.ProjectId;
            // Sample: AttributedClassUsage
            FirestoreDb db = FirestoreDb.Create(projectId);

            // Create a document with a random ID in the "cities" collection.
            CollectionReference collection = db.Collection("cities");
            City city = new City
            {
                Name = "Los Angeles",
                Country = "USA",
                State = "CA",
                IsCapital = false,
                Population = 3900000L
            };
            DocumentReference document = await collection.AddAsync(city);

            // Fetch the data back from the server and deserialize it.
            DocumentSnapshot snapshot = await document.GetSnapshotAsync();
            City citySnapshot = snapshot.ConvertTo<City>();
            Console.WriteLine(citySnapshot.Name); // Los Angeles
            // End sample
        }

        [Fact]
        public async Task DictionaryUsage()
        {
            string projectId = _fixture.ProjectId;
            // Sample: DictionaryUsage
            FirestoreDb db = FirestoreDb.Create(projectId);

            // Create a document with a random ID in the "cities" collection.
            CollectionReference collection = db.Collection("cities");
            Dictionary<string, object> city = new Dictionary<string, object>
            {
                { "Name", "Los Angeles" },
                { "Country", "USA" },
                { "State", "CA" },
                { "Capital", false },
                { "Population", 3900000L }
            };
            DocumentReference document = await collection.AddAsync(city);

            // Fetch the data back from the server and deserialize it.
            DocumentSnapshot snapshot = await document.GetSnapshotAsync();
            Dictionary<string, object> cityData = snapshot.ToDictionary();
            Console.WriteLine(cityData["Name"]); // Los Angeles
            // End sample
        }

        [Fact]
        public async Task AnonymousTypeUsage()
        {
            string projectId = _fixture.ProjectId;
            // Sample: AnonymousTypeUsage
            FirestoreDb db = FirestoreDb.Create(projectId);

            // Create a document with a random ID in the "cities" collection.
            CollectionReference collection = db.Collection("cities");
            var city = new
            {
                Name = "Los Angeles",
                Country = "USA",
                State = "CA",
                Capital = false,
                Population = 3900000L
            };
            DocumentReference document = await collection.AddAsync(city);

            // Update just the population using another anonymous type
            await document.SetAsync(new { Population = 3900005L }, merge: true);

            // Fetch the latest document and print the population
            DocumentSnapshot snapshot = await document.GetSnapshotAsync();
            Console.WriteLine(snapshot.GetValue<long>("Population")); // 3900005
            // End sample
        }

        // Sample: SentinelAttribute
        [FirestoreData]
        public class HighScore
        {
            [FirestoreProperty]
            public int Score { get; set; }

            [FirestoreProperty]
            public string Name { get; set; }

            [FirestoreProperty, ServerTimestamp]
            public Timestamp LastUpdated { get; set; }
        }
        // End sample

        [Fact]
        public async Task AnonymousTypeSentinel()
        {
            string projectId = _fixture.ProjectId;
            FirestoreDb db = FirestoreDb.Create(projectId);

            // Create a document with a random ID in the "cities" collection.
            CollectionReference collection = db.Collection("scores");
            DocumentReference document = await collection.AddAsync(new HighScore { Score = 10, Name = "Jon" });

            // Sample: AnonymousTypeSentinel
            await document.SetAsync(
                new { Score = 20, LastUpdated = FieldValue.ServerTimestamp },
                merge: true);
            // End sample
        }
    }
}
