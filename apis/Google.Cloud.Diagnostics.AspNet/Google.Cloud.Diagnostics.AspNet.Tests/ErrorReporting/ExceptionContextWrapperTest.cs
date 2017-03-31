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

using Moq;
using System;
using System.Web;
using System.Web.Mvc;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNet.Tests
{
    public class ExceptionContextWrapperTest
    {
        [Fact]
        public void ExceptionContextWrapper()
        {
            var uri = "http://google.com/";
            var mockRequest = new Mock<HttpRequestBase>();
            mockRequest.Setup(r => r.HttpMethod).Returns("POST");
            mockRequest.Setup(r => r.Url).Returns(new Uri(uri));
            mockRequest.Setup(r => r.UserAgent).Returns("user-agent");

            var mockResponse = new Mock<HttpResponseBase>();
            mockResponse.Setup(r => r.StatusCode).Returns(409);

            var mockContext = new Mock<HttpContextBase>();
            mockContext.Setup(c => c.Request).Returns(mockRequest.Object);
            mockContext.Setup(c => c.Response).Returns(mockResponse.Object);

            var context = new ExceptionContext
            {
                HttpContext = mockContext.Object,
                Exception = new Exception()
            };

            var wrapper = new ExceptionContextWrapper(context);
            Assert.Equal("POST", wrapper.GetHttpMethod());
            Assert.Equal(uri, wrapper.GetUri());
            Assert.Equal("user-agent", wrapper.GetUserAgent());
            Assert.Equal(409, wrapper.GetStatusCode());
        }

        [Fact]
        public void ExceptionContextWrapper_Simple()
        {
            var mockContext = new Mock<HttpContextBase>();
            mockContext.Setup(c => c.Request).Returns((HttpRequestBase) null);
            mockContext.Setup(c => c.Response).Returns((HttpResponseBase) null);

            var context = new ExceptionContext
            {
                HttpContext = mockContext.Object,
                Exception = new Exception()
            };

            var wrapper = new ExceptionContextWrapper(context);
            Assert.Null(wrapper.GetHttpMethod());
            Assert.Null(wrapper.GetUri());
            Assert.Null(wrapper.GetUserAgent());
            Assert.Equal(0, wrapper.GetStatusCode());
        }
    }
}
