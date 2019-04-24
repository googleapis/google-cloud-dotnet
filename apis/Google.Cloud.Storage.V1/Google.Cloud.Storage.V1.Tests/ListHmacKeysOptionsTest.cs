// Copyright 2019 Google Inc. All Rights Reserved.
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
using static Google.Apis.Storage.v1.ProjectsResource.HmacKeysResource;

namespace Google.Cloud.Storage.V1.Tests
{
    public class ListHmacKeysOptionsTest
    {
        [Fact]
        public void ModifyRequest_DefaultOptions()
        {
            var request = new ListRequest(null, "project");
            var options = new ListHmacKeysOptions();
            options.ModifyRequest(request);
            Assert.Null(request.ShowDeletedKeys);
            Assert.Null(request.MaxResults);
            Assert.Null(request.PageToken);
        }

        [Fact]
        public void ModifyRequest_AllOptions()
        {
            var request = new ListRequest(null, "project");
            var options = new ListHmacKeysOptions
            {
                PageSize = 10,
                PageToken = "nextpage",
                ShowDeletedKeys = true
            };
            options.ModifyRequest(request);
            Assert.Equal(10, request.MaxResults);
            Assert.Equal("nextpage", request.PageToken);
            Assert.True(request.ShowDeletedKeys);
        }
    }
}
