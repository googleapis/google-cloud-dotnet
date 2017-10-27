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

using Grpc.Core;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Firestore.Data.IntegrationTests
{
    [Collection(nameof(FirestoreFixture))]
    public class DocumentDeletionTest
    {
        private readonly FirestoreFixture _fixture;

        public DocumentDeletionTest(FirestoreFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task Delete_Unconditional_DoesntExist()
        {
            var doc = _fixture.NonQueryCollection.GenerateDocument();
            var result = await doc.DeleteAsync();
            var afterDelete = await doc.SnapshotAsync();
            Assert.False(afterDelete.Exists);
        }

        [Fact]
        public async Task Delete_Unconditional_Existed()
        {
            var doc = _fixture.NonQueryCollection.GenerateDocument();
            var createResult = await doc.CreateAsync(new { Name = "Delete me" });
            var deleteResult = await doc.DeleteAsync();
            var afterDelete = await doc.SnapshotAsync();
            Assert.False(afterDelete.Exists);
        }

        [Fact]
        public async Task Delete_Precondition_Success()
        {
            var doc = _fixture.NonQueryCollection.GenerateDocument();
            var createResult = await doc.CreateAsync(new { Name = "Delete me" });
            var deleteResult = await doc.DeleteAsync(Precondition.LastUpdated(createResult.UpdateTime));
            var afterDelete = await doc.SnapshotAsync();
            Assert.False(afterDelete.Exists);
        }

        [Fact]
        public async Task Delete_Precondition_Failed()
        {
            var doc = _fixture.NonQueryCollection.GenerateDocument();
            var createResult = await doc.CreateAsync(new { Name = "Don't delete me" });
            var otherTimestamp = Timestamp.FromDateTimeOffset(createResult.UpdateTime.ToDateTimeOffset().AddSeconds(-1));
            var exception = await Assert.ThrowsAsync<RpcException>(() => doc.DeleteAsync(Precondition.LastUpdated(otherTimestamp)));
            Assert.Equal(StatusCode.FailedPrecondition, exception.Status.StatusCode);
            var afterDelete = await doc.SnapshotAsync();
            Assert.True(afterDelete.Exists);
        }

        [Fact]
        public async Task Delete_Precondition_DoesntExist()
        {
            var doc = _fixture.NonQueryCollection.GenerateDocument();
            var exception = await Assert.ThrowsAsync<RpcException>(() => doc.DeleteAsync(Precondition.LastUpdated(new Timestamp(1, 0))));
            Assert.Equal(StatusCode.FailedPrecondition, exception.Status.StatusCode);
            var afterDelete = await doc.SnapshotAsync();
            Assert.False(afterDelete.Exists);
        }
    }
}
