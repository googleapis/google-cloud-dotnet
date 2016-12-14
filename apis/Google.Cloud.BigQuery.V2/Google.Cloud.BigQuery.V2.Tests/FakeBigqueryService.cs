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

using Google.Apis.Bigquery.v2;
using Google.Apis.Requests;
using Google.Cloud.ClientTesting;

namespace Google.Cloud.BigQuery.V2.Tests
{
    /// <summary>
    /// A fake service allowing request/response expect/replay.
    /// </summary>
    public class FakeBigqueryService : BigqueryService
    {
        private readonly ReplayingMessageHandler handler;

        public FakeBigqueryService() : base(new Initializer
        {
            HttpClientFactory = new FakeHttpClientFactory(new ReplayingMessageHandler()),
            ApplicationName = "Fake",
            GZipEnabled = false
        })
        {
            handler = (ReplayingMessageHandler) HttpClient.MessageHandler;
        }

        public void ExpectRequest<TResponse>(ClientServiceRequest<TResponse> request, TResponse response)
        {
            string requestContent = SerializeObject(request);
            var httpRequest = request.CreateRequest();
            string responseContent = SerializeObject(response);            
            handler.ExpectRequest(httpRequest.RequestUri, httpRequest.Content?.ReadAsStringAsync()?.Result, responseContent);
        }
    }
}
