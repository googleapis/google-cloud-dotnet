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
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.IntegrationTests
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
            var snapshot = await doc.GetSnapshotAsync();

            var storedData = snapshot.GetValue<Timestamp>("Timestamp");
            Assert.Equal(new Timestamp(100, 123456000), storedData);
        }

        [Fact]
        public async Task ConverterRegistry()
        {
            var db = new FirestoreDbBuilder
            {
                ProjectId = _fixture.ProjectId,
                DatabaseId = _fixture.DatabaseId,
                EmulatorDetection = EmulatorDetection.EmulatorOrProduction,
                ConverterRegistry = new ConverterRegistry { new GuidConverter() }
            }.Build();
            CollectionReference collection = db.Collection("guids");
            Guid guid = Guid.NewGuid();
            DocumentReference document = await collection.AddAsync(new { Value = guid });
            DocumentSnapshot snapshot = await document.GetSnapshotAsync();
            Guid fetchedGuid = snapshot.GetValue<Guid>("Value");
            Assert.Equal(fetchedGuid, guid);
        }

        public class GuidConverter : IFirestoreConverter<Guid>
        {
            public object ToFirestore(Guid value) => value.ToString("N");

            public Guid FromFirestore(object value)
            {
                switch (value)
                {
                    case string guid: return Guid.ParseExact(guid, "N");
                    case null: throw new ArgumentNullException(nameof(value));
                    default: throw new ArgumentException($"Unexpected data: {value.GetType()}");
                }
            }
        }
    }
}
