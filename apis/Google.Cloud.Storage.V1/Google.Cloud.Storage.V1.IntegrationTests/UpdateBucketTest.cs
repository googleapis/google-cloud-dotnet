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
using System.Collections.Generic;
using Xunit;
using static Google.Apis.Storage.v1.Data.Bucket;
using static Google.Apis.Storage.v1.Data.Bucket.LifecycleData;
using static Google.Apis.Storage.v1.Data.Bucket.LifecycleData.RuleData;

namespace Google.Cloud.Storage.V1.IntegrationTests
{
    [Collection(nameof(StorageFixture))]
    public class UpdateBucketTest
    {
        private readonly StorageFixture _fixture;

        public UpdateBucketTest(StorageFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Success()
        {
            var client = _fixture.Client;
            var bucketName = _fixture.BucketPrefix + "bucket-to-update";
            _fixture.CreateBucket(bucketName, false);

            var bucket = client.GetBucket(bucketName);
            bucket.Website = new WebsiteData { MainPageSuffix = "http://example.com" };

            client.UpdateBucket(bucket);

            var fetched = client.GetBucket(bucketName);
            Assert.Equal("http://example.com", fetched.Website.MainPageSuffix);
        }

        [Fact]
        public void NoName()
        {
            var client = _fixture.Client;
            var bucket = client.GetBucket(_fixture.ReadBucket, new GetBucketOptions { Projection = Projection.Full });
            bucket.Name = null;
            Assert.Throws<ArgumentException>(() => client.UpdateBucket(bucket));
        }

        [Fact]
        public void ObjectLifeCycle_Valid()
        {
            var client = _fixture.Client;
            var bucketName = _fixture.GenerateBucketName();
            var bucket = _fixture.CreateBucket(bucketName, false);

            bucket.Lifecycle = new LifecycleData
            {
                Rule = new List<RuleData>
                {
                    new RuleData
                    {
                        Condition = new ConditionData { Age = 5 },
                        Action = new ActionData { Type = "Delete" }
                    }
                }
            };

            client.UpdateBucket(bucket);

            var fetched = client.GetBucket(bucketName);
            var rule = Assert.Single(fetched.Lifecycle?.Rule);
            Assert.Equal(5, rule.Condition.Age);
            Assert.Equal("Delete", rule.Action.Type);
        }
    }
}
