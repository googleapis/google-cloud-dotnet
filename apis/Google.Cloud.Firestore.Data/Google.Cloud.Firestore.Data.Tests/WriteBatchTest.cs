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

using Google.Api.Gax.Grpc;
using Google.Cloud.Firestore.V1Beta1;
using Moq;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Data.Tests
{
    public class WriteBatchTest
    {
        [Fact]
        public void Create()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.CreateWriteBatch();
            var doc = db.Document("col/doc");
            batch.Create(doc, new { Name = "Test", Score = 20 });

            var expectedWrite = new Write
            {
                CurrentDocument = new V1Beta1.Precondition { Exists = false },
                Update = new Document
                {
                    Name = doc.Path,
                    Fields =
                    {
                        { "Name", new Value { StringValue = "Test" } },
                        { "Score", new Value { IntegerValue = 20L } }
                    }
                }
            };
            AssertWrites(batch, expectedWrite);
        }

        [Fact]
        public async Task CommitAsync()
        {
            var mock = new Mock<FirestoreClient> { CallBase = true };
            var write1 = new Write { Update = new Document { Name = "irrelevant1" } };
            var write2 = new Write { Update = new Document { Name = "irrelevant2" } };
            var request = new CommitRequest
            {
                Database = "projects/proj/databases/db",
                Writes = { write1, write2 }
            };
            var response = new CommitResponse
            {
                CommitTime = CreateProtoTimestamp(10, 500),
                WriteResults =
                {
                    new V1Beta1.WriteResult { UpdateTime = CreateProtoTimestamp(10, 0) },
                    // Deliberately no UpdateTime; result should default to CommitTime
                    new V1Beta1.WriteResult {  }
                }
            };

            mock.Setup(c => c.CommitAsync(request, It.IsAny<CallSettings>())).ReturnsAsync(response);
            var db = FirestoreDb.Create("proj", "db", mock.Object);
            var reference = db.Document("col/doc");
            var batch = db.CreateWriteBatch();
            batch.Writes.AddRange(new[] { write1, write2 });
            var actualTimestamps = (await batch.CommitAsync()).Select(x => x.UpdateTime);
            var expectedTimestamps = new[] { new Timestamp(10, 0), new Timestamp(10, 500) };
            Assert.Equal(expectedTimestamps, actualTimestamps);
            mock.VerifyAll();
        }

        [Fact]
        public void IsEmpty()
        {
            var db = FirestoreDb.Create("project", "db", new FakeFirestoreClient());
            var batch = db.CreateWriteBatch();
            Assert.True(batch.IsEmpty);
            batch.Create(db.Document("col/doc"), new { Name = "Test" });
            Assert.False(batch.IsEmpty);
        }

        private void AssertWrites(WriteBatch batch, params Write[] writes) =>
            Assert.Equal(writes, batch.Writes);

        private static wkt::Timestamp CreateProtoTimestamp(long seconds, int nanos) =>
            new wkt.Timestamp { Seconds = seconds, Nanos = nanos };
    }
}
