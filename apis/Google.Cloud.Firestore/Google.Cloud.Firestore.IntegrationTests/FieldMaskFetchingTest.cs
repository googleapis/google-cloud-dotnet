// Copyright 2018, Google LLC
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

using Google.Cloud.Firestore.IntegrationTests.Models;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.IntegrationTests
{
    [Collection(nameof(FirestoreFixture))]
    public class FieldMaskFetchingTest
    {
        private readonly FirestoreFixture _fixture;
        public FieldMaskFetchingTest(FirestoreFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task FirestoreDbGetAllDocumentsAsync_WithFieldMask()
        {
            var docs = await _fixture.HighScoreCollection.ListDocumentsAsync().ToListAsync();
            var fieldMask = new FieldMask("Name", "Score");
            var snapshots = await _fixture.FirestoreDb.GetAllSnapshotsAsync(docs, fieldMask);
            var models = snapshots.Select(s => s.ConvertTo<HighScore>()).ToList();
            Assert.All(models, AssertMasked);
        }

        [Fact]
        public async Task TransactionGetAllDocumentsAsync_WithFieldMask()
        {
            var docs = await _fixture.HighScoreCollection.ListDocumentsAsync().ToListAsync();
            var fieldMask = new FieldMask("Name", "Score");
            await _fixture.FirestoreDb.RunTransactionAsync(async t =>
            {
                var snapshots = await t.GetAllSnapshotsAsync(docs, fieldMask);
                var models = snapshots.Select(s => s.ConvertTo<HighScore>()).ToList();
                Assert.All(models, AssertMasked);
            });
        }

        private static void AssertMasked(HighScore model)
        {
            // We fetched name and score, so those should always be non-default values.
            Assert.NotNull(model.Name);
            Assert.NotEqual(0, model.Score);
            // We didn't fetch the level, so that should always be 0.
            Assert.Equal(0, model.Level);
        }
    }
}
