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
using System.Linq;
using Xunit;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    using static TestHelpers;

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
            var firstGenName = GenerateName();
            var secondGenName = GenerateName();
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
        public void CopyLatestGeneration()
        {
            var destName = GenerateName();
            _fixture.Client.CopyObject(
                _fixture.ReadBucket, _fixture.SmallThenLargeObject,
                _fixture.SingleVersionBucket, destName);

            ValidateData(_fixture.SingleVersionBucket, destName, _fixture.LargeContent);
        }

        [Fact]
        public void NoMetadataOverride()
        {
            var destName = GenerateName();
            _fixture.Client.CopyObject(
                _fixture.ReadBucket, _fixture.SmallThenLargeObject,
                _fixture.SingleVersionBucket, destName);
            Object fetched = _fixture.Client.GetObject(_fixture.SingleVersionBucket, destName);
            Assert.Equal("text/plain", fetched.ContentType);
        }

        [Fact]
        public void MetadataOverride()
        {
            var destName = GenerateName();
            _fixture.Client.CopyObject(
                _fixture.ReadBucket, _fixture.SmallThenLargeObject,
                _fixture.SingleVersionBucket, destName,
                new CopyObjectOptions { ExtraMetadata = new Object { ContentType = "text/html" } });
            Object fetched = _fixture.Client.GetObject(_fixture.SingleVersionBucket, destName);
            Assert.Equal("text/html", fetched.ContentType);
        }
    }
}
