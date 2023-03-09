// Copyright 2022, Google LLC
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

using Google.Cloud.ClientTesting;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.IntegrationTests;

[Collection(nameof(MultipleFirestoreDbFixture))]
public class FirestoreMultipleDbTest
{
    private readonly MultipleFirestoreDbFixture _fixture;
    public FirestoreMultipleDbTest(MultipleFirestoreDbFixture multipleFirestoreDbFixture) =>
        _fixture = multipleFirestoreDbFixture;
    
    [Fact(Skip = "Not supported at the server yet")]
    public async Task MultipleDbReadWriteTest()
    {
        string dbIdPrefix = IdGenerator.FromGuid(prefix: "db", separator: "-");
        string correctDbId = $"{dbIdPrefix}-correct";
        string incorrectDbId = $"{dbIdPrefix}-incorrect";
        string databaseLocationId = "us-east1";
        string databaseType = "FIRESTORE_NATIVE";

        // Create two databases one for reading and writing, one for reading to validate that correct database should be referenced.
        await _fixture.CreateDatabaseAsync(correctDbId, databaseLocationId, databaseType);
        await _fixture.CreateDatabaseAsync(incorrectDbId, databaseLocationId, databaseType);

        // Write data to the first database; referenced as correct database.
        FirestoreDb correctDbWriter = new FirestoreDbBuilder
        {
            DatabaseId = correctDbId,
            ProjectId = _fixture.ProjectId
        }.Build();
        await correctDbWriter.Collection("cities").Document("SF").SetAsync(new Dictionary<string, object>
        {
            { "Name", "San Francisco" },
            { "State", "CA" },
            { "Country", "USA" },
            { "Capital", false },
            { "Population", 860000 }
        });

        // Read data from database that was referenced while writing.
        FirestoreDb correctDbReader = new FirestoreDbBuilder
        {
            DatabaseId = correctDbId,
            ProjectId = _fixture.ProjectId
        }.Build();
        DocumentReference readerDocRef = correctDbReader.Collection("cities").Document("SF");
        DocumentSnapshot correctDbSnapshot = await readerDocRef.GetSnapshotAsync();
        Dictionary<string, object> items = correctDbSnapshot.ToDictionary();
        Assert.True(correctDbSnapshot.Exists);
        Assert.Equal(5, items.Count);

        // Try to read data from random incorrect database, to validate that the snapshot and data do not exist.
        FirestoreDb incorrectDbReader = new FirestoreDbBuilder { DatabaseId = incorrectDbId, ProjectId = _fixture.ProjectId }.Build();
        DocumentReference incorrectDbDocRef = incorrectDbReader.Collection("cities").Document("SF");
        DocumentSnapshot incorrectDbSnapshot = await incorrectDbDocRef.GetSnapshotAsync();
        Assert.False(incorrectDbSnapshot.Exists);
    }
}
