// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Apis.Util;
using Xunit;
using static Google.Apis.Storage.v1.BucketsResource;

namespace Google.Cloud.Storage.V1.Tests
{
    public class TestBucketIamPermissionsOptionsTest
    {
        [Fact]
        public void ModifyRequest_DefaultOptions()
        {
            var request = new TestIamPermissionsRequest(null, "bucket", new Repeatable<string>(new string[0]));
            var options = new TestBucketIamPermissionsOptions();
            options.ModifyRequest(request);
            Assert.Null(request.UserProject);
        }

        [Fact]
        public void ModifyRequest_AllOptions()
        {
            var request = new TestIamPermissionsRequest(null, "bucket", new Repeatable<string>(new string[0]));
            var options = new TestBucketIamPermissionsOptions
            {
                UserProject = "proj"
            };
            options.ModifyRequest(request);
            Assert.Equal("proj", request.UserProject);
        }
    }
}
