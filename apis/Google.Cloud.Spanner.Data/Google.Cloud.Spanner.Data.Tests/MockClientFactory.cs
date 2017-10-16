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

using System.Collections;
using System.Threading.Tasks;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Grpc.Core;
using Moq;

namespace Google.Cloud.Spanner.Data.Tests
{
    internal class MockClientFactory : ISpannerClientFactory
    {
        private SpannerClient _currentClient;

        public int Invocations { get; private set; }

        public MockClientFactory(SpannerClient firstClient) => _currentClient = firstClient;

        public Task<SpannerClient> CreateClientAsync(ServiceEndpoint endpoint, ChannelCredentials credentials, 
            IDictionary additionalOptions, Logger logger)
        {
            Invocations++;
            var result = _currentClient;
            _currentClient = new Mock<SpannerClient>().Object;
            return Task.FromResult(result);
        }
    }
}
