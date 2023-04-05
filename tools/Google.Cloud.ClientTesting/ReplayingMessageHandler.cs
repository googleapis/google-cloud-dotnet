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
    public class ReplayingMessageHandler : HttpMessageHandler
    {
        private readonly string _headerToCapture;

        private readonly Queue<Tuple<Uri, string, HttpResponseMessage>> _requestResponses =
            new Queue<Tuple<Uri, string, HttpResponseMessage>>();

        /// <summary>
        /// Stores the timestamp of each attempt made to execute the operation.
        /// </summary>
        public List<DateTime> AttemptTimestamps { get; } = new List<DateTime>();

        /// <summary>
        /// The captured headers, or null if headers are not being captured.
        /// There is one element per request, with an element value of null if the header is not present for the corresponding request.
        /// </summary>
        public List<string> CapturedHeaders { get; }

        /// <summary>
        /// Creates a handler that doesn't capture any headers
        /// </summary>
        public ReplayingMessageHandler()
        {
        }

        /// <summary>
        /// Creates a handler that captures the given header in <see cref="CapturedHeaders"/>,
        /// once per request.
        /// </summary>
        public ReplayingMessageHandler(string header)
        {
            _headerToCapture = header;
            CapturedHeaders = new List<string>();
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            AttemptTimestamps.Add(DateTime.UtcNow);

            Assert.NotEmpty(_requestResponses);
            if (_headerToCapture is string header)
            {
                if (request.Headers.TryGetValues(header, out var values))
                {
                    CapturedHeaders.Add(string.Join(",", values));
                }
                else
                {
                    CapturedHeaders.Add(null);
                }
            }
            var requestResponse = _requestResponses.Dequeue();
            Uri expectedRequestUri = requestResponse.Item1;
            string expectedRequestContent = requestResponse.Item2;
            HttpResponseMessage providedResponse = requestResponse.Item3;
            Assert.Equal(expectedRequestUri, request.RequestUri);
            string body = await (request.Content?.ReadAsStringAsync() ?? Task.FromResult<string>(null));
            Assert.Equal(expectedRequestContent, body);
            return providedResponse;
        }

        public void ExpectRequest(Uri requestUri, string requestContent, string responseContent)
        {
            var responseMessage = new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(responseContent) };
            _requestResponses.Enqueue(Tuple.Create(requestUri, requestContent, responseMessage));
        }

        public void ExpectRequest(Uri requestUri, string requestContent, HttpResponseMessage responseMessage)
        {
            _requestResponses.Enqueue(Tuple.Create(requestUri, requestContent, responseMessage));
        }

        public void Verify()
        {
            Assert.Empty(_requestResponses);
        }
    }
}
