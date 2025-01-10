// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Cloud.Firestore.IntegrationTests.Models;
using Google.Cloud.Firestore.V1;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.AggregateField;

namespace Google.Cloud.Firestore.IntegrationTests;

[Collection(nameof(FirestoreFixture))]
public class AggregateQueryTest
{
    private readonly FirestoreFixture _fixture;

    public AggregateQueryTest(FirestoreFixture fixture) => _fixture = fixture;

    [Fact]
    public async Task Count_WithoutLimit()
    {
        CollectionReference collection = _fixture.HighScoreCollection;
        var snapshot = await collection.Count().GetSnapshotAsync();
        Assert.Equal(HighScore.Data.Length, snapshot.Count);
    }

    [Fact]
    public async Task Count_WithLimit()
    {
        CollectionReference collection = _fixture.HighScoreCollection;
        var snapshotWithoutLimit = await collection.Count().GetSnapshotAsync();
        var snapshotWithLimit = await collection.Limit(2).Count().GetSnapshotAsync();
        Assert.Equal(HighScore.Data.Length, snapshotWithoutLimit.Count);
        Assert.Equal(2, snapshotWithLimit.Count);
    }

    [SkippableFact]
    public async Task Sum_ResultTypes()
    {
        Skip.If(_fixture.RunningOnEmulator);

        var db = _fixture.FirestoreDb;
        var collection = _fixture.CreateUniqueCollection();

        await _fixture.CreateIndexAsync(collection, _fixture.AscendingField("x"), _fixture.AscendingField("y"), _fixture.AscendingField("z"));

        var batch = db.StartBatch();
        batch.Set(collection.Document("a"), new { x = 1, y = 1L << 63, z = 1.0 });
        batch.Set(collection.Document("b"), new { x = 2, y = 1L << 63, z = 2.0 });
        await batch.CommitAsync();

        var snapshot = await collection
            .Aggregate(AggregateField.Sum("x"), AggregateField.Sum("y"), AggregateField.Sum("z"))
            .GetSnapshotAsync();

        var sumX = snapshot.GetValue<object>("Sum_x");
        var sumY = snapshot.GetValue<object>("Sum_y");
        var sumZ = snapshot.GetValue<object>("Sum_z");

        // These assertions check the value *and* the type together.
        Assert.Equal(3L, sumX);
        // The result is a double, because 2^64 can't be represented as a signed 64-bit integer.
        Assert.Equal((1L << 63) * 2.0, sumY);
        Assert.Equal(3.0, sumZ);
    }

    [Fact]
    public async Task Sum()
    {
        CollectionReference collection = _fixture.StudentCollection;
        var snapshot = await collection.Aggregate(AggregateField.Sum("Level", "Sum_Of_Levels"), AggregateField.Sum("MathScore"), AggregateField.Sum("EnglishScore"), AggregateField.Sum("Name")).GetSnapshotAsync();
        Assert.Equal(Student.Data.Sum(c => c.Level), snapshot.GetValue<long>("Sum_Of_Levels")); // Long value, Alias check 
        Assert.Equal(Student.Data.Sum(c => c.MathScore), snapshot.GetValue<double>("Sum_MathScore")); // Double value check
        Assert.Equal(double.NaN, snapshot.GetValue<double>("Sum_EnglishScore"));  // NaN value check
    }

    [Fact]
    public async Task Sum_Explain()
    {
        CollectionReference collection = _fixture.StudentCollection;
        var plan = await collection
            .Aggregate(AggregateField.Sum("Level", "Sum_Of_Levels"), AggregateField.Sum("MathScore"), AggregateField.Sum("EnglishScore"), AggregateField.Sum("Name"))
            .ExplainAsync();
        Assert.NotNull(plan);
    }

    [Fact]
    public async Task Sum_ExplainAnalyze()
    {
        CollectionReference collection = _fixture.StudentCollection;
        var queryProfileInfo = await collection.Aggregate(AggregateField.Sum("Level", "Sum_Of_Levels"), AggregateField.Sum("MathScore"), AggregateField.Sum("EnglishScore"), AggregateField.Sum("Name"))
            .ExplainAnalyzeAsync();
        var plan = queryProfileInfo.Plan;
        var stats = queryProfileInfo.Stats;
        Assert.NotNull(plan);
        Assert.NotNull(stats);
        var snapshot = queryProfileInfo.Snapshot;
        Assert.Equal(Student.Data.Sum(c => c.Level), snapshot.GetValue<long>("Sum_Of_Levels")); // Long value, Alias check 
        Assert.Equal(Student.Data.Sum(c => c.MathScore), snapshot.GetValue<double>("Sum_MathScore")); // Double value check
        Assert.Equal(double.NaN, snapshot.GetValue<double>("Sum_EnglishScore"));  // NaN value check
    }

    [Fact]
    public async Task Avg()
    {
        CollectionReference collection = _fixture.StudentCollection;
        var snapshot = await collection.Aggregate(Average("MathScore"), Average("Level", "Avg_Of_Level"), Average("EnglishScore"), Average("Name")).GetSnapshotAsync();
        Assert.Equal(Student.Data.Average(c => c.MathScore), snapshot.GetValue<double>("Avg_MathScore")); // Double value check
        Assert.Equal(Student.Data.Average(c => c.Level), snapshot.GetValue<double>("Avg_Of_Level")); // Alias check
        Assert.Equal(double.NaN, snapshot.GetValue<double>("Avg_EnglishScore")); // NaN value check
    }

    [Fact]
    public async Task SumWithLimit()
    {
        CollectionReference collection = _fixture.HighScoreCollection;
        var snapshot = await collection.Limit(2).Aggregate(AggregateField.Sum("Score")).GetSnapshotAsync();
        Assert.Equal(HighScore.Data.OrderBy(c => c.Score).Take(2).Sum(c => c.Score), snapshot.GetValue<long>("Sum_Score"));
    }

    [Fact]
    public async Task AvgWithLimit()
    {
        CollectionReference collection = _fixture.HighScoreCollection;
        var snapshot = await collection.Limit(2).Aggregate(Average("Level")).GetSnapshotAsync();
        Assert.Equal(HighScore.Data.OrderBy(c => c.Level).Take(2).Average(c => c.Level), snapshot.GetValue<double>("Avg_Level"));
    }

    [Fact]
    public async Task SumWithFilter()
    {
        CollectionReference collection = _fixture.HighScoreCollection;
        var snapshot = await collection.WhereGreaterThan("Score", 100).Aggregate(AggregateField.Sum("Score")).GetSnapshotAsync();
        Assert.Equal(HighScore.Data.Where(x => x.Score > 100).Sum(c => c.Score), snapshot.GetValue<long>("Sum_Score"));
    }

    [Fact]
    public async Task AvgWithFilter()
    {
        CollectionReference collection = _fixture.HighScoreCollection;
        var snapshot = await collection.WhereGreaterThan("Level", 20).Aggregate(Average("Level")).GetSnapshotAsync();
        Assert.Equal(HighScore.Data.Where(x => x.Level > 20).Average(c => c.Level), snapshot.GetValue<double>("Avg_Level"));
    }

    [Fact]
    public async Task MultipleAggregations()
    {
        CollectionReference collection = _fixture.StudentCollection;
        var snapshot = await collection.Aggregate(AggregateField.Sum("MathScore"), Average("MathScore", "avg_score"), Count()).GetSnapshotAsync();
        Assert.Equal(Student.Data.Length, snapshot.GetValue<Value>("Count").IntegerValue);
        Assert.Equal(Student.Data.Length, snapshot.Count.Value);
        Assert.Equal(Student.Data.Sum(c => c.MathScore), snapshot.GetValue<double>("Sum_MathScore"));
        Assert.Equal(Student.Data.Average(c => c.MathScore), snapshot.GetValue<double>("avg_score"));
    }

    [Fact]
    public async Task NestedAggregations()
    {
        CollectionReference collection = _fixture.StudentCollection;
        var snapshot = await collection.Aggregate(AggregateField.Sum("Nested.Math"), Average("Nested.Math", "avg_score"), Count()).GetSnapshotAsync();
        Assert.Equal(Student.Data.Length, snapshot.GetValue<Value>("Count").IntegerValue);
        Assert.Equal(Student.Data.Length, snapshot.Count.Value);
        Assert.Equal(Student.Data.Sum(c => c.Nested.Math), snapshot.GetValue<double>("Sum_Nested.Math"));
        Assert.Equal(Student.Data.Average(c => c.Nested.Math), snapshot.GetValue<double>("avg_score"));
    }
}
