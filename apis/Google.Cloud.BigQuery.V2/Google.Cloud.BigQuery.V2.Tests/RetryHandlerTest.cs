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

using Google.Apis.Bigquery.v2;
using Google.Apis.Json;
using Google.Apis.Requests;
using Google.Apis.Util;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using static Google.Apis.Bigquery.v2.ProjectsResource;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class RetryHandlerTest
    {
        [Fact]
        public void IsRetriableRequest_Marked()
        {
            var request = new ListRequest(new BigqueryService());
            RetryHandler.MarkAsRetriable(request);
            var httpRequest = request.CreateRequest();
            Assert.True(RetryHandler.IsRetriableRequest(httpRequest));
        }

        [Fact]
        public void IsRetriableRequest_NotMarked()
        {
            var request = new ListRequest(new BigqueryService());
            var httpRequest = request.CreateRequest();
            Assert.False(RetryHandler.IsRetriableRequest(httpRequest));
        }

        [Fact]
        public async Task IsRetriableResponse_NonRetriableReason()
        {
            var standardResponse = new StandardResponse<object>
            {
                Error = new RequestError
                {
                    Errors = new[] { new SingleError { Reason = "invalidQuery" } }
                }
            };
            await AssertRetriable(false, standardResponse);
        }

        [Fact]
        public async Task IsRetriableResponse_RetriableReason()
        {
            var standardResponse = new StandardResponse<object>
            {
                Error = new RequestError
                {
                    Errors = new[] { new SingleError { Reason = "backendError" } }
                }
            };
            await AssertRetriable(true, standardResponse);
        }

        [Fact]
        public async Task IsRetriableResponse_NoErrors()
        {
            var standardResponse = new StandardResponse<object>
            {
                Error = new RequestError { Message = "Look ma, no errors collection!" }
            };
            await AssertRetriable(false, standardResponse);
        }

        private async Task AssertRetriable(bool expectedRetriable, StandardResponse<object> standardResponse)
        {
            string json = NewtonsoftJsonSerializer.Instance.Serialize(standardResponse);
            var httpResponse = new HttpResponseMessage { Content = new StringContent(json) };
            var actual = await RetryHandler.IsRetriableResponse(httpResponse);
            Assert.Equal(expectedRetriable, actual);
        }

        [Fact]
        public async Task IsRetriableResponse_UnparseableResponse()
        {
            var response = new HttpResponseMessage();
            response.Content = new StringContent("This isn't JSON");
            Assert.False(await RetryHandler.IsRetriableResponse(response));
        }
    }
}
