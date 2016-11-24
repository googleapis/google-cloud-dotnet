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

using System;
using Xunit;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    using System.IO;
    using static TestHelpers;

    [Collection(nameof(StorageFixture))]
    public class PatchObjectTest
    {
        private readonly StorageFixture _fixture;

        public PatchObjectTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Success()
        {
            var client = _fixture.Client;
            var name = GenerateName();
            var bucket = _fixture.SingleVersionBucket;
            client.UploadObject(bucket, name, null, new MemoryStream(_fixture.SmallContent));

            Object obj = new Object { Name = name, Bucket = bucket, ContentType = "text/plain" };
            var updated = client.PatchObject(obj);
            Assert.Equal("text/plain", updated.ContentType);
        }

        [Fact]
        public void MissingProperties()
        {
            var client = _fixture.Client;
            Assert.Throws<ArgumentException>(() => client.PatchObject(new Object { Bucket = _fixture.SingleVersionBucket }));
            Assert.Throws<ArgumentException>(() => client.PatchObject(new Object { Name = GenerateName() }));
        }
    }
}
