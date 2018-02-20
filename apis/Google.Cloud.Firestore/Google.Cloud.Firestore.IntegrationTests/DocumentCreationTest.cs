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

namespace Google.Cloud.Firestore.IntegrationTests
{
    [Collection(nameof(FirestoreFixture))]
    public class DocumentCreationTest
    {
        private readonly FirestoreFixture _fixture;

        public DocumentCreationTest(FirestoreFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task Create_Success()
        {
            var collection = _fixture.NonQueryCollection;
            var reference = await collection.AddAsync(new { Name = "Test" });

            // Make sure we can fetch it again too...
            var snapshot = await reference.GetSnapshotAsync();
            Assert.True(snapshot.Exists);
            var dictionary = snapshot.ToDictionary();
            Assert.Equal("Test", dictionary["Name"]);
        }

        [Fact]
        public async Task Create_AlreadyExists()
        {
            var collection = _fixture.NonQueryCollection;
            var reference = await collection.AddAsync(new { Name = "Test" });

            // TODO: Should we have a more specific exception here?
            // See also https://github.com/googleapis/toolkit/issues/1357
            await Assert.ThrowsAsync<RpcException>(() => reference.CreateAsync(new { Name = "Other" }));
        }
    }
}
