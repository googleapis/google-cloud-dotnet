// Copyright 2020 Google LLC
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

using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerMockServerFixture : IDisposable
    {
        private readonly Server _server;
        public MockSpannerService SpannerMock { get; }
        public string Endpoint
        {
            get
            {
                return $"{_server.Ports.ElementAt(0).Host}:{_server.Ports.ElementAt(0).BoundPort}";
            }
        }
        public string Host { get { return _server.Ports.ElementAt(0).Host; } }
        public int Port { get { return _server.Ports.ElementAt(0).BoundPort; } }

        public SpannerMockServerFixture()
        {
            SpannerMock = new MockSpannerService();
            _server = new Server
            {
                Services = { Google.Cloud.Spanner.V1.Spanner.BindService(SpannerMock) },
                Ports = { new ServerPort("localhost", 0, ServerCredentials.Insecure) }
            };
            _server.Start();
        }

        public void Dispose()
        {
            _server.ShutdownAsync().Wait();
        }
    }
}
