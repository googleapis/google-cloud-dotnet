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

using Google.Cloud.Diagnostics.Common;
using Moq;
using System.IO;
using System.Web;
using Xunit;

using LabelsCommon = Google.Cloud.Diagnostics.Common.TraceLabels;

namespace Google.Cloud.Diagnostics.AspNet.Tests
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
        public void FromHttpRequestWrapper()
        {
            var request = new HttpRequest("name", "https://google.com", "");
            var mockWrapper = new Mock<HttpRequestWrapper>(request);
            mockWrapper.Setup(w => w.ContentLength).Returns(123);
            mockWrapper.Setup(w => w.UserHostName).Returns("google.com");
            mockWrapper.Setup(w => w.HttpMethod).Returns("PUT");

            var labels = Labels.FromHttpRequestWrapper(mockWrapper.Object);
            Assert.Equal(3, labels.Count);
            Assert.Equal("123", labels[LabelsCommon.HttpRequestSize]);
            Assert.Equal("google.com", labels[LabelsCommon.HttpHost]);
            Assert.Equal("PUT", labels[LabelsCommon.HttpMethod]);
        }

        [Fact]
        public void FromHttpResponseWrapper()
        {
            var response = new HttpResponse(new StringWriter());
            var mockWrapper = new Mock<HttpResponseWrapper>(response);
            mockWrapper.Setup(w => w.StatusCode).Returns(404);

            var labels = Labels.FromHttpResponseWrapper(mockWrapper.Object);
            Assert.Equal(1, labels.Count);
            Assert.Equal("404", labels[LabelsCommon.HttpStatusCode]);
        }
    }
}