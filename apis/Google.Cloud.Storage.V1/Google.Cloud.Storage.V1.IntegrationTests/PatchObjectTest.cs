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

using Google.Apis.Storage.v1.Data;
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;
using static Google.Cloud.Storage.V1.IntegrationTests.TestHelpers;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
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
            var name = IdGenerator.FromGuid();
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
            Assert.Throws<ArgumentException>(() => client.PatchObject(new Object { Name = IdGenerator.FromGuid() }));
        }

        [Fact]
        public void ClearAllObjectContexts()
        {
            var client = _fixture.Client;
            var custom = new Dictionary<string, ObjectCustomContextPayload>
            {
                  { "A\u00F1\u03A9\U0001F680", new ObjectCustomContextPayload { Value = "Ab\u00F1\u03A9\U0001F680" } }
            };

            var destination = new Object
            {
                Bucket = _fixture.SingleVersionBucket,
                Name = IdGenerator.FromGuid(),
                ContentType = "test/type",
                ContentDisposition = "attachment",
                Metadata = new Dictionary<string, string> { { "x", "y" } },
                Contexts = new Object.ContextsData { Custom = custom }
            };
            var source = GenerateData(100);
            _fixture.Client.UploadObject(destination, source);

            var modifiedCustom = new Dictionary<string, ObjectCustomContextPayload>
            {
            };

            Object obj = new Object { Name = destination.Name, Bucket = destination.Bucket, ContentType = "text/plain", Contexts = new Object.ContextsData { Custom = modifiedCustom } };
            var updated = client.PatchObject(obj);
            Assert.Null(updated.Contexts);
        }
    }
}
