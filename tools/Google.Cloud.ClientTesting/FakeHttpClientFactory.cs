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

        public ConfigurableHttpClient CreateHttpClient(CreateHttpClientArgs args) => new ConfigurableHttpClient(_handler);
    }
}
