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

using Google.Apis.Requests;
using Google.Apis.Translate.v2;
using Google.Cloud.ClientTesting;

namespace Google.Cloud.Translation.V2.Tests
{
    // TODO: Work out a way to put this code in ClientTesting, in a non-service-specific way...

    /// <summary>
    /// A fake service allowing request/response expect/replay.
    /// </summary>
    public class FakeTranslateService : TranslateService
    {
        private readonly ReplayingMessageHandler handler;

        public FakeTranslateService() : base(new Initializer
        {
            HttpClientFactory = new FakeHttpClientFactory(new ReplayingMessageHandler()),
            ApplicationName = "Fake",
            GZipEnabled = false
        })
        {
            handler = (ReplayingMessageHandler)HttpClient.MessageHandler;
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
