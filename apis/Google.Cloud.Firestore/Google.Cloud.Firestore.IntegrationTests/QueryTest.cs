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
using Google.Cloud.Firestore.IntegrationTests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.IntegrationTests
{
    [Collection(nameof(FirestoreFixture))]
    public class QueryTest
    {
        private readonly FirestoreFixture _fixture;

        public QueryTest(FirestoreFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task EmptyQuery()
        {
            var query = _fixture.HighScoreCollection;
            var snapshot = await query.GetSnapshotAsync();
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(HighScore.Data, items.OrderBy(x => x.Name, StringComparer.Ordinal));
        }

        [Fact]
        public async Task WhereGreaterThan()
        {
            var query = _fixture.HighScoreCollection.WhereGreaterThan("Score", 100);
            var snapshot = await query.GetSnapshotAsync();
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(HighScore.Data.Where(x => x.Score > 100), items.OrderBy(x => x.Name, StringComparer.Ordinal));
        }

        [Fact]
        public async Task OrderBy()
        {
            var query = _fixture.HighScoreCollection.OrderBy("Level");
            var snapshot = await query.GetSnapshotAsync();
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(HighScore.Data.OrderBy(x => x.Level), items);
        }

        [Fact]
        public async Task OrderByDocumentId()
        {
            var query = _fixture.HighScoreCollection.Select("Name").OrderBy(FieldPath.DocumentId);
            var snapshot = await query.GetSnapshotAsync();

            // Check that we got the documents we expected
            var names = snapshot.Documents.Select(doc => doc.GetValue<string>("Name")).OrderBy(x => x, StringComparer.Ordinal);
            Assert.Equal(HighScore.Data.Select(x => x.Name), names);

            // Check that the ordering is actually by document reference
            // (Select just the ID to make it much easier to understand failures.)
            var orderedByReference = snapshot.Documents.Select(doc => doc.Id).OrderBy(x => x, StringComparer.Ordinal);
            Assert.Equal(orderedByReference, snapshot.Documents.Select(x => x.Id));
        }

        [SkippableFact]
        public async Task OrderBySecondaryAscending()
        {
            Skip.If(_fixture.RunningOnEmulator);
            var query = _fixture.HighScoreCollection.OrderBy("Score").OrderBy("Level");
            var snapshot = await query.GetSnapshotAsync();
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(HighScore.Data.OrderBy(x => x.Score).ThenBy(x => x.Level), items);
        }

        [SkippableFact]
        public async Task OrderBySecondaryDescending()
        {
            Skip.If(_fixture.RunningOnEmulator);
            var query = _fixture.HighScoreCollection.OrderBy("Score").OrderByDescending("Level");
            var snapshot = await query.GetSnapshotAsync();
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(HighScore.Data.OrderBy(x => x.Score).ThenByDescending(x => x.Level), items);
        }

        [Fact]
        public async Task Select()
        {
            var query = _fixture.HighScoreCollection.Select("Name", "Score");
            var snapshot = await query.GetSnapshotAsync();
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(
                // Create the equivalent results by creating new objects
                HighScore.Data.Select(x => new HighScore { Name = x.Name, Score = x.Score }),
                items.OrderBy(x => x.Name, StringComparer.Ordinal));
        }

        [Fact]
        public async Task SelectDocumentId()
        {
            var query = _fixture.HighScoreCollection.Select(FieldPath.DocumentId);
            var snapshot = await query.GetSnapshotAsync();

            Assert.Equal(snapshot.Documents.Count, HighScore.Data.Length);

            // Check that all the documents are empty - all we're getting is the doc reference
            Assert.All(snapshot.Documents, doc => Assert.Empty(doc.ToDictionary()));
        }

        [Fact]
        public async Task Limit()
        {
            var query = _fixture.HighScoreCollection.OrderBy("Level").Limit(3);
            var snapshot = await query.GetSnapshotAsync();
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(HighScore.Data.OrderBy(x => x.Level).Take(3), items);
        }

        [Fact]
        public async Task LimitToLast_GetSnapshotAsync()
        {
            var query = _fixture.HighScoreCollection.OrderBy("Level").LimitToLast(3);
            var snapshot = await query.GetSnapshotAsync();
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(HighScore.Data.OrderByDescending(x => x.Level).Take(3).Reverse(), items);
        }

        [Fact]
        public async Task LimitToLast_StreamingThrows()
        {
            var query = _fixture.HighScoreCollection.OrderBy("Level").LimitToLast(3);
            // We need to use the result, as the validation is deferred.
            await Assert.ThrowsAsync<InvalidOperationException>(() => query.StreamAsync().CountAsync().AsTask());
        }

        [Fact]
        public async Task Offset()
        {
            var query = _fixture.HighScoreCollection.OrderBy("Level").Offset(2);
            var snapshot = await query.GetSnapshotAsync();
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(HighScore.Data.OrderBy(x => x.Level).Skip(2), items);
        }

        [Fact]
        public async Task StartAt()
        {
            var query = _fixture.HighScoreCollection.OrderBy("Level").StartAt(20);
            var snapshot = await query.GetSnapshotAsync();
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(HighScore.Data.Where(x => x.Level >= 20).OrderBy(x => x.Score), items);
        }

        [Fact]
        public async Task StartAfter()
        {
            var query = _fixture.HighScoreCollection.OrderBy("Level").StartAfter(20);
            var snapshot = await query.GetSnapshotAsync();
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(HighScore.Data.Where(x => x.Level > 20).OrderBy(x => x.Level), items);
        }

        [Fact]
        public async Task StartAfter_Explain_PlanOnly()
        {
            var query = _fixture.HighScoreCollection.OrderBy("Level").StartAfter(20);
            var explainResults = await query.ExplainAsync(ExplainOptions.PlanOnly);
            Assert.NotNull(explainResults.Metrics.PlanSummary);
            Assert.Null(explainResults.Snapshot);
        }

        [Fact]
        public async Task StartAfter_Explain_PlanAndExecute()
        {
            var query = _fixture.HighScoreCollection.OrderBy("Level").StartAfter(20);
            var queryProfileInfo = await query.ExplainAsync(ExplainOptions.PlanAndExecute);
            var snapshot = queryProfileInfo.Snapshot;
            var plan = queryProfileInfo.Metrics.PlanSummary;
            var stats = queryProfileInfo.Metrics.ExecutionStats;
            Assert.NotNull(plan);
            Assert.NotNull(stats);
            Assert.Equal(snapshot.Documents.Count, stats.ResultsReturned);
            Assert.NotEqual(0, stats.ReadOperations);
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(HighScore.Data.Where(x => x.Level > 20).OrderBy(x => x.Level), items);
        }

        [Fact]
        public async Task EndAt()
        {
            var query = _fixture.HighScoreCollection.OrderBy("Level").EndAt(20);
            var snapshot = await query.GetSnapshotAsync();
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(HighScore.Data.Where(x => x.Level <= 20).OrderBy(x => x.Level), items);
        }

        [Fact]
        public async Task EndBefore()
        {
            var query = _fixture.HighScoreCollection.OrderBy("Level").EndBefore(20);
            var snapshot = await query.GetSnapshotAsync();
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(HighScore.Data.Where(x => x.Level < 20).OrderBy(x => x.Level), items);
        }

        [Fact]
        public async Task RangeByDocumentId()
        {
            var allDocs = await _fixture.HighScoreCollection.StreamAsync()
                .Select(doc => doc.Reference)
                .OrderBy(x => x.Path, StringComparer.Ordinal)
                .ToListAsync();
            var startInclusive = allDocs[1];
            var endExclusive = allDocs[4];
            var query = _fixture.HighScoreCollection.OrderBy(FieldPath.DocumentId)
                .StartAt(startInclusive)
                .EndBefore(endExclusive);
            var results = await query.StreamAsync()
                .Select(doc => doc.Reference)
                .OrderBy(x => x.Path, StringComparer.Ordinal)
                .ToListAsync();
            Assert.Equal(allDocs.Skip(1).Take(3), results);
        }

        // Collection group queries taken from Node implementation
        [Fact]
        public async Task CanQueryCollectionGroups()
        {
            var rootDocPath = $"{_fixture.CollectionGroupQueryCollection.Id}/{IdGenerator.FromGuid()}";
            // Create a random collection group name, but prefix it with "b" for predictable ordering
            var collectionGroup = IdGenerator.FromGuid(prefix: "b");

            string[] docPaths =
            {
                $"abc/123/{collectionGroup}/cg-doc1",
                $"abc/123/{collectionGroup}/cg-doc2",
                $"abc/123/{collectionGroup}/cg-doc3",
                $"{collectionGroup}/cg-doc4",
                $"def/456/{collectionGroup}/cg-doc5",
                $"{collectionGroup}/virtual-doc/nested-coll/not-cg-doc",
                $"x{collectionGroup}/not-cg-doc",
                $"{collectionGroup}x/not-cg-doc",
                $"abc/123/{collectionGroup}x/not-cg-doc",
                $"abc/123/x{collectionGroup}/not-cg-doc",
                $"abc/{collectionGroup}"
            };
            var db = _fixture.FirestoreDb;
            var batch = db.StartBatch();
            batch.Set(db.Document(rootDocPath), new { X = 1 });
            foreach (var docPath in docPaths)
            {
                batch.Set(db.Document($"{rootDocPath}/{docPath}"), new { X = 1 });
            }
            await batch.CommitAsync();

            var querySnapshot = await db.CollectionGroup(collectionGroup).GetSnapshotAsync();
            var actualIds = querySnapshot.Select(d => d.Id).ToList();
            var expectedIds = new List<string> { "cg-doc1", "cg-doc2", "cg-doc3", "cg-doc4", "cg-doc5" };
            Assert.Equal(expectedIds, actualIds);
        }

        [Fact]
        public async Task CanQueryCollectionGroupsWithStartAtEndAtByArbitraryDocumentId()
        {
            var rootDocPath = $"{_fixture.CollectionGroupQueryCollection.Id}/{IdGenerator.FromGuid()}";
            // Create a random collection group name, but prefix it with "b" for predictable ordering
            var collectionGroup = IdGenerator.FromGuid(prefix: "b");

            string[] docPaths =
            {
                $"a/a/{collectionGroup}/cg-doc1",
                $"a/b/a/b/{collectionGroup}/cg-doc2",
                $"a/b/{collectionGroup}/cg-doc3",
                $"a/b/c/d/{collectionGroup}/cg-doc4",
                $"a/c/{collectionGroup}/cg-doc5",
                $"{collectionGroup}/cg-doc6",
                $"a/b/nope/nope"
            };
            var db = _fixture.FirestoreDb;
            var batch = db.StartBatch();
            batch.Set(db.Document(rootDocPath), new { X = 1 });
            foreach (var docPath in docPaths)
            {
                batch.Set(db.Document($"{rootDocPath}/{docPath}"), new { X = 1 });
            }
            await batch.CommitAsync();

            var querySnapshot = await db.CollectionGroup(collectionGroup)
                .OrderBy(FieldPath.DocumentId)
                .StartAt($"{rootDocPath}/a/b")
                .EndAt($"{rootDocPath}/a/b0")
                .GetSnapshotAsync();
            var actualIds = querySnapshot.Select(d => d.Id).ToList();
            var expectedIds = new List<string> { "cg-doc2", "cg-doc3", "cg-doc4" };
            Assert.Equal(expectedIds, actualIds);

            querySnapshot = await db.CollectionGroup(collectionGroup)
                .OrderBy(FieldPath.DocumentId)
                .StartAfter($"{rootDocPath}/a/b")
                .EndBefore($"{rootDocPath}/a/b/{collectionGroup}/cg-doc3")
                .GetSnapshotAsync();
            actualIds = querySnapshot.Select(d => d.Id).ToList();
            Assert.Single(actualIds, "cg-doc2");
        }

        [Fact]
        public async Task CanQueryCollectionGroupsWithWhereFiltersOnArbitraryDocumentId()
        {
            var rootDocPath = $"{_fixture.CollectionGroupQueryCollection.Id}/{IdGenerator.FromGuid()}";
            // Create a random collection group name, but prefix it with "b" for predictable ordering
            var collectionGroup = IdGenerator.FromGuid(prefix: "b");

            string[] docPaths =
            {
                $"a/a/{collectionGroup}/cg-doc1",
                $"a/b/a/b/{collectionGroup}/cg-doc2",
                $"a/b/{collectionGroup}/cg-doc3",
                $"a/b/c/d/{collectionGroup}/cg-doc4",
                $"a/c/{collectionGroup}/cg-doc5",
                $"{collectionGroup}/cg-doc6",
                $"a/b/nope/nope"
            };
            var db = _fixture.FirestoreDb;
            var batch = db.StartBatch();
            batch.Set(db.Document(rootDocPath), new { X = 1 });
            foreach (var docPath in docPaths)
            {
                batch.Set(db.Document($"{rootDocPath}/{docPath}"), new { X = 1 });
            }
            await batch.CommitAsync();

            var querySnapshot = await db.CollectionGroup(collectionGroup)
                .OrderBy(FieldPath.DocumentId)
                .WhereGreaterThanOrEqualTo(FieldPath.DocumentId, db.Document($"{rootDocPath}/a/b"))
                .WhereLessThanOrEqualTo(FieldPath.DocumentId, db.Document($"{rootDocPath}/a/b0"))
                .GetSnapshotAsync();
            var actualIds = querySnapshot.Select(d => d.Id).ToList();
            var expectedIds = new List<string> { "cg-doc2", "cg-doc3", "cg-doc4" };
            Assert.Equal(expectedIds, actualIds);

            querySnapshot = await db.CollectionGroup(collectionGroup)
                .OrderBy(FieldPath.DocumentId)
                .WhereGreaterThan(FieldPath.DocumentId, db.Document($"{rootDocPath}/a/b"))
                .WhereLessThan(FieldPath.DocumentId, db.Document($"{rootDocPath}/a/b/{collectionGroup}/cg-doc3"))
                .GetSnapshotAsync();
            actualIds = querySnapshot.Select(d => d.Id).ToList();
            Assert.Single(actualIds, "cg-doc2");
        }

        [Fact]
        public async Task WhereIn()
        {
            var db = _fixture.FirestoreDb;
            var collection = _fixture.CreateUniqueCollection();
            var batch = db.StartBatch();
            batch.Set(collection.Document("a"), new { zip = 98101 });
            batch.Set(collection.Document("b"), new { zip = 91102 });
            batch.Set(collection.Document("c"), new { zip = 98103 });
            batch.Set(collection.Document("d"), new { zip = new[] { 98101 } });
            batch.Set(collection.Document("e"), new { zip = new object[] { 98101, new { zip = 98101 } } });
            batch.Set(collection.Document("f"), new { zip = new { code = 500 } });
            batch.Set(collection.Document("g"), new { notZip = new { code = 500 } });
            await batch.CommitAsync();

            var querySnapshot = await collection.WhereIn("zip", new[] { 98101, 98103 }).GetSnapshotAsync();
            var ids = querySnapshot.Select(d => d.Id).ToList();
            Assert.Equal(new[] { "a", "c" }, ids);
        }

        [Fact]
        public async Task WhereIn_DocumentId()
        {
            var db = _fixture.FirestoreDb;
            var collection = _fixture.CreateUniqueCollection();

            var batch = db.StartBatch();
            batch.Set(collection.Document("a"), new { X = 1 });
            batch.Set(collection.Document("b"), new { X = 2 });
            batch.Set(collection.Document("c"), new { X = 3 });
            batch.Set(collection.Document("d"), new { X = 4 });
            await batch.CommitAsync();

            var query = collection.WhereIn(FieldPath.DocumentId, new[] { collection.Document("a"), collection.Document("c") });
            var snapshot = await query.GetSnapshotAsync();
            Assert.Equal(2, snapshot.Count);
        }

        [Fact]
        public async Task WhereIn_DocumentId_WithoutDocRef()
        {
            var db = _fixture.FirestoreDb;
            var collection = _fixture.CreateUniqueCollection();

            var batch = db.StartBatch();
            batch.Set(collection.Document("a"), new { X = 1 });
            batch.Set(collection.Document("b"), new { X = 2 });
            batch.Set(collection.Document("c"), new { X = 3 });
            batch.Set(collection.Document("d"), new { X = 4 });
            await batch.CommitAsync();

            var query = collection.WhereIn(FieldPath.DocumentId, new[] { "a", "c" });
            var snapshot = await query.GetSnapshotAsync();
            Assert.Equal(2, snapshot.Count);
        }

        [Fact]
        public async Task WhereIn_ArrayValues()
        {
            var db = _fixture.FirestoreDb;
            var collection = _fixture.CreateUniqueCollection();
            var batch = db.StartBatch();
            batch.Set(collection.Document("ab"), new { values = new[] { "a", "b" } });
            batch.Set(collection.Document("bc"), new { values = new[] { "b", "c" } });
            batch.Set(collection.Document("cd"), new { values = new[] { "c", "d" } });
            batch.Set(collection.Document("de"), new { values = new[] { "d", "e" } });
            batch.Set(collection.Document("ef"), new { values = new[] { "e", "f" } });
            batch.Set(collection.Document("fg"), new { values = new[] { "f", "g" } });
            await batch.CommitAsync();

            var querySnapshot = await collection.WhereIn("values", new[] {
                new[] { "a", "b" }, // Matches ab
                new[] { "c", "d" }, // Matches cd
                new[] { "e", "f", "g" }, // Doesn't match anything
                new[] { "e" } // Doesn't match anything
            }).GetSnapshotAsync();
            var ids = querySnapshot.Select(d => d.Id).ToList();
            Assert.Equal(new[] { "ab", "cd" }, ids);
        }

        [Fact]
        public async Task WhereNotIn()
        {
            var db = _fixture.FirestoreDb;
            var collection = _fixture.CreateUniqueCollection();
            var batch = db.StartBatch();
            batch.Set(collection.Document("a"), new { zip = 98101 });
            batch.Set(collection.Document("b"), new { zip = 91102 });
            batch.Set(collection.Document("c"), new { zip = 98103 });
            batch.Set(collection.Document("d"), new { zip = new[] { 98101 } });
            batch.Set(collection.Document("e"), new { zip = new object[] { 98101, new { zip = 98101 } } });
            batch.Set(collection.Document("f"), new { zip = new { code = 500 } });
            batch.Set(collection.Document("g"), new { notZip = new { code = 500 } });
            await batch.CommitAsync();

            var querySnapshot = await collection.WhereNotIn("zip", new[] { 98101, 98103 }).GetSnapshotAsync();
            var ids = querySnapshot.Select(d => d.Id).ToList();
            // Note: g is not in the list, because the "zip" field doesn't exist there at all.
            Assert.Equal(new[] { "b", "d", "e", "f" }, ids);
        }

        [Fact]
        public async Task WhereArrayContainsAny()
        {
            var db = _fixture.FirestoreDb;
            var collection = _fixture.CreateUniqueCollection();
            var batch = db.StartBatch();
            batch.Set(collection.Document("a"), new { array = new[] { 42 } });
            batch.Set(collection.Document("b"), new { array = new object[] { "a", 42, "c" } });
            batch.Set(collection.Document("c"), new { array = new object[] { 41.999, "42", new { a = 42 } } });
            batch.Set(collection.Document("d"), new { array = new[] { 42 }, array2 = "sigh" });
            batch.Set(collection.Document("e"), new { array = new[] { 43 } });
            batch.Set(collection.Document("f"), new { array = new[] { new { a = 42 } } });
            batch.Set(collection.Document("g"), new { array = 42 });
            await batch.CommitAsync();

            var querySnapshot = await collection.WhereArrayContainsAny("array", new[] { 42, 43 }).GetSnapshotAsync();
            var ids = querySnapshot.Select(d => d.Id).ToList();
            Assert.Equal(new[] { "a", "b", "d", "e" }, ids);
        }

        public static TheoryData<string, object, string[]> ArrayContainsTheoryData = new TheoryData<string, object, string[]>
        {
            { "StringArray", "x", new[] { "string-x,y", "mixed" } },
            { "StringArray", "y", new[] { "string-x,y" } },
            { "Int64Array", 1, new[] { "int64-1,2" } },
            { "DoubleArray", 1.5, new[] { "double-1.5,2.5" } },
            { "DoubleArray", 3.5, new[] { "mixed" } },
            { "HighScoreArray", new HighScore("bob", 3, 4), new[] { "highscore-alice,bob" } },
            // Three variants which don't match bob
            { "HighScoreArray", new HighScore("bill", 3, 4), new string[] { } },
            { "HighScoreArray", new HighScore("bob", 1, 4), new string[] { } },
            { "HighScoreArray", new HighScore("bob", 3, 2), new string[] { } },
            { "TimestampArray", new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc), new[] { "timestamp-2000"} },
            { "TimestampArray", new DateTime(2001, 1, 1, 0, 0, 0, DateTimeKind.Utc), new string[] { } }
        };

        [Theory]
        [MemberData(nameof(ArrayContainsTheoryData))]
        public async Task ArrayContains(string field, object value, string[] expectedNames)
        {
            var snapshot = await _fixture
                .ArrayQueryCollection
                .WhereArrayContains(field, value)
                .GetSnapshotAsync();
            var docs = snapshot.Documents.Select(doc => doc.ConvertTo<ArrayDocument>()).ToList();
            Assert.Equal(expectedNames.OrderBy(x => x), docs.Select(doc => doc.Name).OrderBy(x => x));
        }

        [Fact]
        public async Task OrQueriesAsync()
        {
            CollectionReference collection = _fixture.HighScoreCollection;
            var query = collection.Where(Filter.Or(
                                                    Filter.EqualTo("Score", 90),
                                                    Filter.EqualTo("Score", 110)
                                                   ));
            var snapshot = await query.GetSnapshotAsync();
            Assert.Equal(2, snapshot.Count);
        }

        [SkippableFact]
        public async Task MultipleInequalitiesAsync()
        {
            Skip.If(_fixture.RunningOnEmulator);

            CollectionReference collection = _fixture.HighScoreCollection;
            await _fixture.CreateIndexAsync(collection, _fixture.AscendingField("Level"), _fixture.AscendingField("Score"));
            var levelFilter = Filter.GreaterThan("Level", 17);
            var scoreFilter = Filter.GreaterThan("Score", 105);
            var query = collection.Where(Filter.And(levelFilter, scoreFilter));
            var snapshot = await query.GetSnapshotAsync();
            // Dalip and Erin meet the criteria.
            // Alice's score is too low; Carol's level is too low. (Bob fails on both counts.)
            Assert.Equal(2, snapshot.Count);
            var docs = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(new[] { "Dalip", "Erin" }, docs.Select(doc => doc.Name).OrderBy(x => x));
        }
    }
}
