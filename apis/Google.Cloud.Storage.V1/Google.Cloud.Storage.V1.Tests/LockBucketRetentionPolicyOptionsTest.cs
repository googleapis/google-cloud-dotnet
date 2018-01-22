// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Xunit;
using static Google.Apis.Storage.v1.BucketsResource;

namespace Google.Cloud.Storage.V1.Tests
{
    public class LockBucketRetentionPolicyOptionsTest
    {
        [Fact]
        public void ModifyRequest_DefaultOptions()
        {
            var request = new LockRetentionPolicyRequest(null, "bucket", 100L);
            var options = new LockBucketRetentionPolicyOptions();
            options.ModifyRequest(request);
            Assert.Null(request.UserProject);
        }

        [Fact]
        public void ModifyRequest_UserProject()
        {
            var request = new LockRetentionPolicyRequest(null, "bucket", 100L);
            var options = new LockBucketRetentionPolicyOptions { UserProject = "project" };
            options.ModifyRequest(request);
            Assert.Equal("project", request.UserProject);
        }
    }
}
