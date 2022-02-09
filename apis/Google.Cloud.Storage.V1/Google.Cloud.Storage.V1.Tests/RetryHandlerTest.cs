// Copyright 2022 Google Inc. All Rights Reserved.
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

using System.Net;
using System.Net.Http;
using Xunit;

namespace Google.Cloud.Storage.V1.Tests
{
    public class RetryHandlerTest
    {
        [Fact]
        public void IsRetriableResponse_BadGateway()
        {
            var httpResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.BadGateway
            };
            var actual = RetryHandler.IsRetriableResponse(httpResponse);
            Assert.True(actual.Result);
        }

        [Fact]
        public void NonRetriableResponse_RequestUriTooLong()
        {
            var httpResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.RequestUriTooLong
            };
            var actual = RetryHandler.IsRetriableResponse(httpResponse);
            Assert.False(actual.Result);
        }

        [Fact]
        public void NonRetriableResponse_NoErrorCode()
        {
            var httpResponse = new HttpResponseMessage();
            var actual = RetryHandler.IsRetriableResponse(httpResponse);
            Assert.False(actual.Result);
        }
    }
}
