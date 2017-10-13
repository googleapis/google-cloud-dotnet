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

using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.Data.IntegrationTests
{
    /// <summary>
    /// Miscellaneous tests around how data is stored and retrieved.
    /// </summary>
    [Collection(nameof(FirestoreFixture))]
    public class DataModelTest
    {
        private readonly FirestoreFixture _fixture;

        public DataModelTest(FirestoreFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task TimestampTruncated()
        {
            var doc = await _fixture.NonQueryCollection.AddAsync(new { Timestamp = new Timestamp(100, 123456789) });
            var snapshot = await doc.SnapshotAsync();

            var storedData = snapshot.GetField<Timestamp>("Timestamp");
            Assert.Equal(new Timestamp(100, 123456000), storedData);
        }
    }
}
