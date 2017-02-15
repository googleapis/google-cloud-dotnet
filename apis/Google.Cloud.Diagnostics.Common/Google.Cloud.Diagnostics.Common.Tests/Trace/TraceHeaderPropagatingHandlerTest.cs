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
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class TraceHeaderPropagatingHandlerTest
    {
        private const string traceId = "105445aa7843bc8bf206b12000100f00";
        private const ulong spanId = 81237123;
        private readonly TraceHeaderContext headerContext = 
            TraceHeaderContext.Create(traceId, spanId, true);

        private Mock<IManagedTracer> GetSetUpTracer()
        {
            var mockTracer = new Mock<IManagedTracer>();
            mockTracer.Setup(t => t.GetCurrentTraceId()).Returns(traceId);
            mockTracer.Setup(t => t.GetCurrentSpanId()).Returns(spanId);
            return mockTracer;
        }

        [Fact]
        public async Task SendAsync_NoTrace()
        {
            var mockTracer = new Mock<IManagedTracer>();
            var fakeHandler = new FakeDelegatingHandler();
            var traceHandler = TraceHeaderPropagatingHandler.Create(mockTracer.Object, fakeHandler);

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

            var mockTracer = GetSetUpTracer();
            var fakeHandler = new FakeDelegatingHandler(headerContext);
            var traceHandler = TraceHeaderPropagatingHandler.Create(mockTracer.Object, fakeHandler);

            var requestUri = new Uri("https://www.google.com");

            using (var httpClient = new HttpClient(traceHandler))
            {
                await httpClient.GetAsync(requestUri);
            }

            mockTracer.Verify(t => t.StartSpan(requestUri.ToString(), null), Times.Once());
            mockTracer.Verify(t => t.EndSpan(), Times.Once());
        }

        [Fact]
        public async Task SendAsync_TraceException()
        {
            var mockTracer = GetSetUpTracer();
            var fakeHandler = new FakeDelegatingHandler(headerContext, throwException: true);
            var traceHandler = TraceHeaderPropagatingHandler.Create(mockTracer.Object, fakeHandler);

            var requestUri = new Uri("https://www.google.com");

            using (var httpClient = new HttpClient(traceHandler))
            {
                await Assert.ThrowsAsync<DivideByZeroException>(() => httpClient.GetAsync(requestUri));
            }

            mockTracer.Verify(t => t.StartSpan(requestUri.ToString(), null), Times.Once());
            mockTracer.Verify(t => t.SetStackTrace(It.IsAny<StackTrace>()), Times.Once());
            mockTracer.Verify(t => t.EndSpan(), Times.Once());
        }

        /// <summary>
        /// Fake <see cref="DelegatingHandler"/> to verify added trace headers.
        /// </summary>
        private class FakeDelegatingHandler : DelegatingHandler
        {
            private readonly TraceHeaderContext _context;
            private readonly bool _throwException;

            public FakeDelegatingHandler(TraceHeaderContext context = null, bool throwException = false)
            {
                _context = context;
                _throwException = throwException;
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
                if (_throwException)
                {
                    throw new DivideByZeroException();
                }
                return Task.FromResult(new HttpResponseMessage());
            }

        }
    }
}
