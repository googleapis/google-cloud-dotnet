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
using static Google.Apis.Storage.v1.BucketsResource.PatchRequest;

namespace Google.Cloud.Storage.V1.Tests
{
    public class PatchBucketOptionsTest
    {
        [Fact]
        public void ModifyRequest_DefaultOptions()
        {
            var request = new PatchRequest(null, null, "bucket");
            var options = new PatchBucketOptions();
            options.ModifyRequest(request);
            Assert.Null(request.IfMetagenerationMatch);
            Assert.Null(request.IfMetagenerationNotMatch);
            Assert.Null(request.PredefinedAcl);
            Assert.Null(request.PredefinedDefaultObjectAcl);
            Assert.Null(request.Projection);
            Assert.Null(request.UserProject);
        }

        [Fact]
        public void ModifyRequest_PositiveMatchOptions()
        {
            var request = new PatchRequest(null, null, "bucket");
            var options = new PatchBucketOptions
            {
                IfMetagenerationMatch = 1L,
                PredefinedAcl = PredefinedBucketAcl.AuthenticatedRead,
                PredefinedDefaultObjectAcl = PredefinedObjectAcl.BucketOwnerFullControl,
                Projection = Projection.Full,
                UserProject = "proj"
            };
            options.ModifyRequest(request);
            Assert.Equal(1L, request.IfMetagenerationMatch);
            Assert.Null(request.IfMetagenerationNotMatch);
            Assert.Equal(PredefinedAclEnum.AuthenticatedRead, request.PredefinedAcl);
            Assert.Equal(PredefinedDefaultObjectAclEnum.BucketOwnerFullControl, request.PredefinedDefaultObjectAcl);
            Assert.Equal(ProjectionEnum.Full, request.Projection);
            Assert.Equal("proj", request.UserProject);
        }

        [Fact]
        public void ModifyRequest_NegativeMatchOptions()
        {
            var request = new PatchRequest(null, null, "bucket");
            var options = new PatchBucketOptions
            {
                IfMetagenerationNotMatch = 1L,
                PredefinedAcl = PredefinedBucketAcl.AuthenticatedRead,
                PredefinedDefaultObjectAcl = PredefinedObjectAcl.BucketOwnerFullControl,
                Projection = Projection.Full
            };
            options.ModifyRequest(request);
            Assert.Null(request.IfMetagenerationMatch);
            Assert.Equal(1L, request.IfMetagenerationNotMatch);
            Assert.Equal(PredefinedAclEnum.AuthenticatedRead, request.PredefinedAcl);
            Assert.Equal(PredefinedDefaultObjectAclEnum.BucketOwnerFullControl, request.PredefinedDefaultObjectAcl);
            Assert.Equal(ProjectionEnum.Full, request.Projection);
        }

        [Fact]
        public void ModifyRequest_MatchNotMatchConflicts()
        {
            var request = new PatchRequest(null, null, "bucket");
            Assert.Throws<ArgumentException>(() =>
            {
                var options = new PatchBucketOptions { IfMetagenerationMatch = 1L, IfMetagenerationNotMatch = 2L };
                options.ModifyRequest(request);
            });
        }
    }
}
