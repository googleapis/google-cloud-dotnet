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
using System.Net.Http;

namespace Google.Cloud.ClientTesting
{
    /// <summary>
    /// HTTP client factory which gets a specific message handler (for mocking) and use for creating the HTTP
    /// client.
    /// </summary>
    public class FakeHttpClientFactory : IHttpClientFactory
    {
        private readonly ConfigurableMessageHandler _handler;

        public FakeHttpClientFactory(ConfigurableMessageHandler handler)
        {
            _handler = handler;
        }

        /// <summary>
        /// Shorthand for creating a <see cref="MockableMessageHandler"/> which uses the given function
        /// to handle requests.
        /// </summary>
        /// <param name="handler"></param>
        public FakeHttpClientFactory(Func<HttpRequestMessage, HttpResponseMessage> handler)
            : this(new ConfigurableMessageHandler(new MockableMessageHandler(handler)))
        {
        }

        public ConfigurableHttpClient CreateHttpClient(CreateHttpClientArgs args) => new ConfigurableHttpClient(_handler);

        /// <summary>
        /// Returns a client factory which produces an HttpClient that throws an exception on
        /// all requests. This is useful for testing code that should never reach the HttpClient.
        /// </summary>
        public static FakeHttpClientFactory Throwing { get; } =
            new FakeHttpClientFactory(request => { throw new Exception("Throwing HttpClient never succeeds"); });
    }
}
