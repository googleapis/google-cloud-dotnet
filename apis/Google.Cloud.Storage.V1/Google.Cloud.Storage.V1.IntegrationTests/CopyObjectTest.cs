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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Storage.V1.IntegrationTests.TestHelpers;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.IntegrationTests
{

    [Collection(nameof(StorageFixture))]
    public class CopyObjectTest
    {
        private readonly StorageFixture _fixture;

        public CopyObjectTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void CopySpecificGeneration()
        {
            var client = _fixture.Client;
            var sourceBucket = _fixture.ReadBucket;
            var sourceName = _fixture.SmallThenLargeObject;
            var destBucket = _fixture.SingleVersionBucket;
            var firstGenName = IdGenerator.FromGuid();
            var secondGenName = IdGenerator.FromGuid();
            var generations = client.ListObjects(sourceBucket, sourceName, new ListObjectsOptions { Versions = true })
                .Select(o => (long)o.Generation)
                .OrderBy(o => o)
                .ToList();
            Assert.Equal(2, generations.Count);

            client.CopyObject(sourceBucket, sourceName, destBucket, firstGenName, new CopyObjectOptions { SourceGeneration = generations[0] });
            client.CopyObject(sourceBucket, sourceName, destBucket, secondGenName, new CopyObjectOptions { SourceGeneration = generations[1] });

            ValidateData(destBucket, firstGenName, _fixture.SmallContent);
            ValidateData(destBucket, secondGenName, _fixture.LargeContent);
        }

        [Fact]
        public async Task CopyLatestGenerationAsync()
        {
            var destName = IdGenerator.FromGuid();
            await _fixture.Client.CopyObjectAsync(
                _fixture.ReadBucket, _fixture.SmallThenLargeObject,
                _fixture.SingleVersionBucket, destName);

            ValidateData(_fixture.SingleVersionBucket, destName, _fixture.LargeContent);
        }

        [Fact]
        public async Task CopySpecificGenerationAsync()
        {
            var client = _fixture.Client;
            var sourceBucket = _fixture.ReadBucket;
            var sourceName = _fixture.SmallThenLargeObject;
            var destBucket = _fixture.SingleVersionBucket;
            var firstGenName = IdGenerator.FromGuid();
            var secondGenName = IdGenerator.FromGuid();
            var generations = client.ListObjects(sourceBucket, sourceName, new ListObjectsOptions { Versions = true })
                .Select(o => (long)o.Generation)
                .OrderBy(o => o)
                .ToList();
            Assert.Equal(2, generations.Count);

            await client.CopyObjectAsync(sourceBucket, sourceName, destBucket, firstGenName, new CopyObjectOptions { SourceGeneration = generations[0] });
            await client.CopyObjectAsync(sourceBucket, sourceName, destBucket, secondGenName, new CopyObjectOptions { SourceGeneration = generations[1] });

            ValidateData(destBucket, firstGenName, _fixture.SmallContent);
            ValidateData(destBucket, secondGenName, _fixture.LargeContent);
        }

        [Fact]
        public void CopyLatestGeneration()
        {
            var destName = IdGenerator.FromGuid();
            _fixture.Client.CopyObject(
                _fixture.ReadBucket, _fixture.SmallThenLargeObject,
                _fixture.SingleVersionBucket, destName);

            ValidateData(_fixture.SingleVersionBucket, destName, _fixture.LargeContent);
        }

        [Fact]
        public void NoMetadataOverride()
        {
            var destName = IdGenerator.FromGuid();
            _fixture.Client.CopyObject(
                _fixture.ReadBucket, _fixture.SmallThenLargeObject,
                _fixture.SingleVersionBucket, destName);
            Object fetched = _fixture.Client.GetObject(_fixture.SingleVersionBucket, destName);
            Assert.Equal("text/plain", fetched.ContentType);
        }

        [Fact]
        public void MetadataOverride()
        {
            var destName = IdGenerator.FromGuid();
            _fixture.Client.CopyObject(
                _fixture.ReadBucket, _fixture.SmallThenLargeObject,
                _fixture.SingleVersionBucket, destName,
                new CopyObjectOptions { ExtraMetadata = new Object { ContentType = "text/html" } });
            Object fetched = _fixture.Client.GetObject(_fixture.SingleVersionBucket, destName);
            Assert.Equal("text/html", fetched.ContentType);
        }

        [Fact]
        public void CopyObjectWithObjectContexts()
        {
            var custom = new Dictionary<string, ObjectCustomContextPayload>
            {
                  { "A\u00F1\u03A9\U0001F680", new ObjectCustomContextPayload { Value = "Ab\u00F1\u03A9\U0001F680" } },

                  { "CA\u00F1\u03A9\U0001F680", new ObjectCustomContextPayload { Value = "A\u00F1\u03A9\U0001F680" } },

                  { "CB\u00F1\u03A9\U0001F680", new ObjectCustomContextPayload { Value = "B\u00F1\u03A9\U0001F680" } }
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
            var result = _fixture.Client.UploadObject(destination, source);
            _fixture.Client.CopyObject(
                _fixture.SingleVersionBucket, destination.Name,
                _fixture.MultiVersionBucket, destination.Name);
            Object fetched = _fixture.Client.GetObject(_fixture.MultiVersionBucket, destination.Name);
            Assert.Equal(result.Contexts.Custom.Count, fetched.Contexts.Custom.Count);
            Assert.True(result.Contexts.Custom.All(p =>
                fetched.Contexts.Custom.TryGetValue(p.Key, out var val) && val.Value == p.Value.Value));
        }

        [Fact]
        public void ObjectContextsOverride()
        {
            var custom = new Dictionary<string, ObjectCustomContextPayload>
            {
                  { "CB\u00F1\u03A9\U0001F680", new ObjectCustomContextPayload { Value = "B\u00F1\u03A9\U0001F680" } }
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

            var newCustom = new Dictionary<string, ObjectCustomContextPayload>
            {
                  { "CAB\u00F1\u03A9\U0001F680", new ObjectCustomContextPayload { Value = "AB\u00F1\u03A9\U0001F680" } }
            };
            _fixture.Client.CopyObject(
                _fixture.SingleVersionBucket, destination.Name,
                _fixture.MultiVersionBucket, destination.Name,
                new CopyObjectOptions { ExtraMetadata = new Object { Contexts = new Object.ContextsData { Custom = newCustom } } });
            Object fetched = _fixture.Client.GetObject(_fixture.MultiVersionBucket, destination.Name);
            Assert.True(fetched.Contexts.Custom.ContainsKey(newCustom.Keys.Single()));
            Assert.Equal(newCustom.Values.Single().Value, fetched.Contexts.Custom[newCustom.Keys.Single()].Value);
            Assert.False(fetched.Contexts.Custom.ContainsKey(custom.Keys.Single()));
        }
    }
}
