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

using Microsoft.AspNetCore.Http;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests
{
    public class HttpContextWrapperTest
    {
        [Fact]
        public void HttpContextWrapper()
        {
            var context = new DefaultHttpContext();

            var request = context.Request;
            request.Method = "POST";
            request.Host = new HostString("google.com");
            request.Scheme = "http";
            request.Headers["User-Agent"] = "user-agent";

            var response = context.Response;
            response.StatusCode = 409;

            var wrapper = new HttpContextWrapper(context);
            Assert.Equal("POST", wrapper.GetHttpMethod());
            Assert.Equal("http://google.com", wrapper.GetUri());
            Assert.Equal("user-agent", wrapper.GetUserAgent());
            Assert.Equal(409, wrapper.GetStatusCode());
        }

        [Fact]
        public void HttpContextWrapper_Simple()
        {
            var context = new DefaultHttpContext();

            var request = context.Request;
            request.Host = new HostString("google.com");
            request.Scheme = "http";

            var wrapper = new HttpContextWrapper(context);
            Assert.Equal("", wrapper.GetHttpMethod());
            Assert.Equal("http://google.com", wrapper.GetUri());
            Assert.Equal("", wrapper.GetUserAgent());
            Assert.Equal(200, wrapper.GetStatusCode());
        }
    }
}
