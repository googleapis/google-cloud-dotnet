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

using Moq;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class TraceHeaderPropagatingHandlerTest
    {
        [Fact]
        public async Task SendAsync_NoTrace()
        {
            var mockTracer = new Mock<IManagedTracer>();
            var traceHandler = TraceHeaderPropagatingHandler.Create(mockTracer.Object);
            traceHandler.InnerHandler = new FakeDelegatingHandler(null);

            using (var httpClient = new HttpClient(traceHandler))
            {
                await httpClient.GetAsync("https://www.google.com");
            }

            mockTracer.Verify(t => t.StartSpan(It.IsAny<string>(), null), Times.Never());
            mockTracer.Verify(t => t.EndSpan(), Times.Never());
        }

        [Fact]
        public async Task SendAsync_Trace()
        {
            string traceId = "105445aa7843bc8bf206b12000100f00";
            ulong spanId = 81237123;
            var headerContext = TraceHeaderContext.Create(traceId, spanId, true);

            var mockTracer = new Mock<IManagedTracer>();
            mockTracer.Setup(t => t.GetCurrentTraceId()).Returns(traceId);
            mockTracer.Setup(t => t.GetCurrentSpanId()).Returns(spanId);

            var traceHandler = TraceHeaderPropagatingHandler.Create(mockTracer.Object);
            traceHandler.InnerHandler = new FakeDelegatingHandler(headerContext);

            var requestUri = new Uri("https://www.google.com");

            using (var httpClient = new HttpClient(traceHandler))
            {
                await httpClient.GetAsync(requestUri);
            }

            mockTracer.Verify(t => t.StartSpan(requestUri.ToString(), null), Times.Once());
            mockTracer.Verify(t => t.EndSpan(), Times.Once());
        }

        /// <summary>
        /// Fake <see cref="DelegatingHandler"/> to verify added trace headers.
        /// </summary>
        private class FakeDelegatingHandler : DelegatingHandler
        {
            TraceHeaderContext _context;

            public FakeDelegatingHandler(TraceHeaderContext context)
            {
                _context = context;
            }

            protected override Task<HttpResponseMessage> SendAsync(
                HttpRequestMessage request, CancellationToken cancellationToken)
            {
                if (_context != null)
                {
                    var traceHeader = request.Headers.GetValues(TraceHeaderContext.TraceHeader).First();
                    var currentContext = TraceHeaderContext.FromHeader(traceHeader);
                    Assert.Equal(_context.TraceId, currentContext.TraceId);
                    Assert.Equal(_context.SpanId, currentContext.SpanId);
                    Assert.Equal(_context.ShouldTrace, currentContext.ShouldTrace);
                }
                return Task.FromResult(new HttpResponseMessage());
            }

        }
    }
}
