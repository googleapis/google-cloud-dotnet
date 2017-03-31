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

using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http.ExceptionHandling;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNet.Tests
{
    public class ExceptionLoggerContextWrapperTest
    {
        [Fact]
        public void ExceptionLoggerContextWrapper()
        {
            var userAgent = new ProductInfoHeaderValue("user-agent", "user-agent-value");
            var requestMessage = new HttpRequestMessage();
            requestMessage.Method = new HttpMethod("POST");
            requestMessage.RequestUri = new Uri("http://google.com/");
            requestMessage.Headers.UserAgent.Add(userAgent);

            var responseMessage = new HttpResponseMessage();
            responseMessage.StatusCode = (HttpStatusCode) 409;

            var exceptionContext = new ExceptionContext(
                new Exception(), ExceptionCatchBlocks.HttpServer, requestMessage, responseMessage);
            var context = new ExceptionLoggerContext(exceptionContext);

            var wrapper = new ExceptionLoggerContextWrapper(context);
            Assert.Equal("POST", wrapper.GetHttpMethod());
            Assert.Equal("http://google.com/", wrapper.GetUri());
            Assert.Equal("user-agent/user-agent-value", wrapper.GetUserAgent());
            Assert.Equal(409, wrapper.GetStatusCode());
        }

        [Fact]
        public void ExceptionLoggerContextWrapper_Simple()
        {
            var exceptionContext = new ExceptionContext(
                new Exception(), ExceptionCatchBlocks.HttpServer,
                new HttpRequestMessage(), new HttpResponseMessage());
            var context = new ExceptionLoggerContext(exceptionContext);

            var wrapper = new ExceptionLoggerContextWrapper(context);
            Assert.Equal("GET", wrapper.GetHttpMethod());
            Assert.Null(wrapper.GetUri());
            Assert.Equal("", wrapper.GetUserAgent());
            Assert.Equal(200, wrapper.GetStatusCode());
        }
    }
}
