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

using Xunit;
using static Google.Apis.Storage.v1.BucketsResource;
using static Google.Apis.Storage.v1.BucketsResource.ListRequest;

namespace Google.Cloud.Storage.V1.Tests
{
    public class ListBucketsOptionsTest
    {
        [Fact]
        public void ModifyRequest_DefaultOptions()
        {
            var request = new ListRequest(null, "project");
            var options = new ListBucketsOptions();
            options.ModifyRequest(request);
            Assert.Null(request.Projection);
            Assert.Null(request.Prefix);
            Assert.Null(request.MaxResults);
            Assert.Null(request.PageToken);
            Assert.Null(request.SoftDeleted);
        }

        [Fact]
        public void ModifyRequest_AllOptions()
        {
            var request = new ListRequest(null, "project");
            var options = new ListBucketsOptions
            {
                PageSize = 10,
                Prefix = "prefix",
                Projection = Projection.Full,
                PageToken = "nextpage",
                Fields = "items(name),nextPageToken",
                SoftDeletedOnly = true,
            };
            options.ModifyRequest(request);
            Assert.Equal(10, request.MaxResults);
            Assert.Equal("prefix", request.Prefix);
            Assert.Equal(ProjectionEnum.Full, request.Projection);
            Assert.Equal("nextpage", request.PageToken);
            Assert.Equal("items(name),nextPageToken", request.Fields);
            Assert.True(request.SoftDeleted);
        }
    }
}