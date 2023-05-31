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
using static Google.Apis.Storage.v1.ObjectsResource;
using static Google.Apis.Storage.v1.ObjectsResource.ListRequest;

namespace Google.Cloud.Storage.V1.Tests
{
    public class ListObjectsOptionsTest
    {
        [Fact]
        public void ModifyRequest_DefaultOptions()
        {
            var request = new ListRequest(null, "bucket");
            var options = new ListObjectsOptions();
            options.ModifyRequest(request);
            Assert.Null(request.Delimiter);
            Assert.Null(request.IncludeTrailingDelimiter);
            Assert.Null(request.Projection);
            Assert.Null(request.MaxResults);
            Assert.Null(request.Versions);
            Assert.Null(request.UserProject);
            Assert.Null(request.PageToken);
            Assert.Null(request.StartOffset);
            Assert.Null(request.EndOffset);
            Assert.Null(request.MatchGlob);
        }

        [Fact]
        public void ModifyRequest_AllOptions()
        {
            var request = new ListRequest(null, "bucket");
            var options = new ListObjectsOptions
            {
                PageSize = 10,
                Delimiter = "/",
                IncludeTrailingDelimiter = true,
                Projection = Projection.Full,
                Versions = true,
                UserProject = "proj",
                PageToken = "nextpage",
                Fields = "items(name),nextPageToken",
                StartOffset = "start",
                EndOffset = "end",
                MatchGlob = "a/*.txt"
            };
            options.ModifyRequest(request);
            Assert.Equal(10, request.MaxResults);
            Assert.Equal("/", request.Delimiter);
            Assert.True(request.IncludeTrailingDelimiter);
            Assert.Equal(ProjectionEnum.Full, request.Projection);
            Assert.True(request.Versions);
            Assert.Equal("proj", request.UserProject);
            Assert.Equal("nextpage", request.PageToken);
            Assert.Equal("items(name),nextPageToken", request.Fields);
            Assert.Equal("start", request.StartOffset);
            Assert.Equal("end", request.EndOffset);
            Assert.Equal("a/*.txt", request.MatchGlob);
        }
    }
}
