// Copyright 2016 Google Inc. All Rights Reserved.
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

using System.Linq;
using Xunit;

namespace Google.Storage.V1.Snippets
{
    [Collection(nameof(StorageSnippetFixture))]
    public class StorageClientSnippets
    {
        private readonly StorageSnippetFixture _fixture;

        public StorageClientSnippets(StorageSnippetFixture fixture)
        {
            this._fixture = fixture;
        }

        [Fact]
        public void ListObjects()
        {
            var bucketId = _fixture.BucketId;

            // <ListObjects>
            var client = StorageClient.Create();
            // List only objects with a name starting with "Hello"
            var objects = client.ListObjects(bucketId, "Hello");
            // </ListObjects>
            var names = objects.Select(obj => obj.Name).ToList();
            Assert.Contains(_fixture.HelloWorldName, names);
        }
    }
}
