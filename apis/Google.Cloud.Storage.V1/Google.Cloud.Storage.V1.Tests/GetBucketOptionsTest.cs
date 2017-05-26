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
using static Google.Apis.Storage.v1.BucketsResource;
using static Google.Apis.Storage.v1.BucketsResource.GetRequest;

namespace Google.Cloud.Storage.V1.Tests
{
    public class GetBucketOptionsTest
    {
        [Fact]
        public void ModifyRequest_DefaultOptions()
        {
            var request = new GetRequest(null, "bucket");
            var options = new GetBucketOptions();
            options.ModifyRequest(request);
            Assert.Null(request.IfMetagenerationMatch);
            Assert.Null(request.IfMetagenerationNotMatch);
            Assert.Null(request.Projection);
            Assert.Null(request.UserProject);
        }

        [Fact]
        public void ModifyRequest_PositiveMatchOptions()
        {
            var request = new GetRequest(null, "bucket");
            var options = new GetBucketOptions
            {
                IfMetagenerationMatch = 1L,
                Projection = Projection.Full,
                UserProject = "proj"
            };
            options.ModifyRequest(request);
            Assert.Equal(1L, request.IfMetagenerationMatch);
            Assert.Null(request.IfMetagenerationNotMatch);
            Assert.Equal(ProjectionEnum.Full, request.Projection);
            Assert.Equal("proj", request.UserProject);
        }

        [Fact]
        public void ModifyRequest_NegativeMatchOptions()
        {
            var request = new GetRequest(null, "bucket");
            var options = new GetBucketOptions
            {
                IfMetagenerationNotMatch = 1L,
                Projection = Projection.Full
            };
            options.ModifyRequest(request);
            Assert.Null(request.IfMetagenerationMatch);
            Assert.Equal(1L, request.IfMetagenerationNotMatch);
            Assert.Equal(ProjectionEnum.Full, request.Projection);
        }

        [Fact]
        public void ModifyRequest_MatchNotMatchConflicts()
        {
            var request = new GetRequest(null, "bucket");
            Assert.Throws<ArgumentException>(() =>
            {
                var options = new GetBucketOptions { IfMetagenerationMatch = 1L, IfMetagenerationNotMatch = 2L };
                options.ModifyRequest(request);
            });
        }

    }
}
