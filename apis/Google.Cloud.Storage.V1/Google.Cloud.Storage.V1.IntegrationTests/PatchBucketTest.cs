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
using System;
using Xunit;
using static Google.Apis.Storage.v1.Data.Bucket;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class PatchBucketTest
    {
        private readonly StorageFixture _fixture;

        public PatchBucketTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Success()
        {
            var client = _fixture.Client;
            var bucketName = _fixture.BucketPrefix + "bucket-to-patch";
            _fixture.CreateBucket(bucketName, false);

            var bucket = new Bucket
            {
                Name = bucketName,
                Website = new WebsiteData { MainPageSuffix = "http://example.com" }
            };
            client.PatchBucket(bucket);

            var fetched = client.GetBucket(bucketName);
            Assert.Equal("http://example.com", fetched.Website.MainPageSuffix);
        }

        [Fact]
        public void NoName()
        {
            var client = _fixture.Client;
            Assert.Throws<ArgumentException>(() => client.PatchBucket(new Bucket()));
        }
    }
}
