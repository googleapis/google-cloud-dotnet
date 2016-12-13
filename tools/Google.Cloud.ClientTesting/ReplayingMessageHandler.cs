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

using Google.Apis.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// Test helper class effectively acting as an HTTP mock.
    /// We may well want to put this into Google.Api.Gax.Rest.Testing at some point.
    /// Additionally, it could do with being able to return non-OK results...
    /// </summary>
    public class ReplayingMessageHandler : ConfigurableMessageHandler
    {
        private readonly Queue<Tuple<Uri, string, string>> _requestResponses = new Queue<Tuple<Uri, string, string>>();

        public ReplayingMessageHandler() : base(new HttpClientHandler())
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Assert.NotEmpty(_requestResponses);

            var requestResponse = _requestResponses.Dequeue();
            Uri expectedRequestUri = requestResponse.Item1;
            string expectedRequestContent = requestResponse.Item2;
            string providedResponse = requestResponse.Item3;
            Assert.Equal(expectedRequestUri, request.RequestUri);
            string body = await (request.Content?.ReadAsStringAsync() ?? Task.FromResult<string>(null));
            Assert.Equal(expectedRequestContent, body);
            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(providedResponse) };
        }

        public void ExpectRequest(Uri requestUri, string requestContent, string responseContent)
        {
            _requestResponses.Enqueue(Tuple.Create(requestUri, requestContent, responseContent));
        }
    }
}
