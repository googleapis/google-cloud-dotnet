// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Requests;
using Google.Apis.Storage.v1;
using Google.Cloud.ClientTesting;
using System.Net;
using System.Net.Http;

namespace Google.Cloud.Storage.V1.Tests
{
    class FakeStorageService : StorageService
    {
        private readonly ReplayingMessageHandler handler;

        public FakeStorageService() : base(new Initializer
        {
            HttpClientFactory = new FakeHttpClientFactory(new ReplayingMessageHandler()),
            ApplicationName = "Fake",
            GZipEnabled = false
        })
        {
            handler = (ReplayingMessageHandler)HttpClient.MessageHandler.InnerHandler;
        }

        public void ExpectRequest<TResponse>(ClientServiceRequest<TResponse> request, TResponse response)
        {
            var httpRequest = request.CreateRequest();
            string responseContent = SerializeObject(response);
            handler.ExpectRequest(httpRequest.RequestUri, httpRequest.Content?.ReadAsStringAsync()?.Result, responseContent);
        }

        public void ExpectRequest<TResponse>(ClientServiceRequest<TResponse> request, HttpStatusCode statusCode)
        {
            var httpRequest = request.CreateRequest();
            var responseMessage = new HttpResponseMessage(statusCode);
            handler.ExpectRequest(httpRequest.RequestUri, httpRequest.Content?.ReadAsStringAsync()?.Result, responseMessage);
        }

        public void Verify() => handler.Verify();
    }
}
