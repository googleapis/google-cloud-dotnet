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

using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Xunit;

using LabelsCommon = Google.Cloud.Diagnostics.Common.TraceLabels;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests
{
    public class LabelsTest
    {
        [Fact]
        public void AgentLabel()
        {
            var labels = Labels.AgentLabel;
            Assert.Single(labels);
            Assert.Contains(CommonUtils.AgentName, labels[LabelsCommon.Agent]);
            Assert.Contains(CommonUtils.GetVersion(typeof(CommonUtils)), labels[LabelsCommon.Agent]);
        }

        [Fact]
        public void FromDefaultHttpRequest()
        {
            var request = new DefaultHttpRequest(new DefaultHttpContext());
            request.ContentLength = 123;
            request.Host = new HostString("google.com");
            request.Method = "PUT";

            var labels = Labels.FromDefaultHttpRequest(request);
            Assert.Equal(3, labels.Count);
            Assert.Equal("123", labels[LabelsCommon.HttpRequestSize]);
            Assert.Equal("google.com", labels[LabelsCommon.HttpHost]);
            Assert.Equal("PUT", labels[LabelsCommon.HttpMethod]);
        }

        [Fact]
        public void FromDefaultHttpResponse()
        {
            var response = new DefaultHttpResponse(new DefaultHttpContext());
            response.StatusCode = 404;

            var labels = Labels.FromDefaultHttpResponse(response);
            Assert.Equal(1, labels.Count);
            Assert.Equal("404", labels[LabelsCommon.HttpStatusCode]);
        }
    }
}
