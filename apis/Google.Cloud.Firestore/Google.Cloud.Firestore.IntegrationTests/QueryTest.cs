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

        [Fact(Skip = "Requires CreateIndex support")]
        public async Task OrderBySecondaryAscending()
        {
            var query = _fixture.HighScoreCollection.OrderBy("Score").OrderBy("Level");
            var snapshot = await query.GetSnapshotAsync();
            var items = snapshot.Documents.Select(doc => doc.ConvertTo<HighScore>()).ToList();
            Assert.Equal(HighScore.Data.OrderBy(x => x.Score).ThenBy(x => x.Level), items);
        }

        [Fact(Skip = "Requires CreateIndex support")]
        public async Task OrderBySecondaryDescending()
        {
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
                .ToList();
            var startInclusive = allDocs[1];
            var endExclusive = allDocs[4];
            var query = _fixture.HighScoreCollection.OrderBy(FieldPath.DocumentId)
                .StartAt(startInclusive)
                .EndBefore(endExclusive);
            var results = await query.StreamAsync()
                .Select(doc => doc.Reference)
                .OrderBy(x => x.Path, StringComparer.Ordinal)
                .ToList();
            Assert.Equal(allDocs.Skip(1).Take(3), results);
        }

        [Fact]
        public async Task SimpleCollectionGroup()
        {
            var collection = _fixture.CollectionGroupName;
            var snapshot = await _fixture.FirestoreDb.CollectionGroup(_fixture.CollectionGroupName)
                .GetSnapshotAsync();
            var documents = snapshot.Documents.Select(doc => doc.ConvertTo<NamedDocument>()).OrderBy(doc => doc.Name).ToList();
            Assert.Equal(new[] { NamedDocument.Child1, NamedDocument.Child2 }, documents);
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
    }
}
