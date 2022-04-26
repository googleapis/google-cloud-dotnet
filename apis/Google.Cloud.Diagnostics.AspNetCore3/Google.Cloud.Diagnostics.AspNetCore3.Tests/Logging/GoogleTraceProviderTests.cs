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

using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using Moq;
using System;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore3.Tests
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class GoogleTraceProviderTests
    {
        [Fact]
        public void GetCurrentTraceContext()
        {
            string traceId = "105445aa7843bc8bf206b12000100f00";
            ulong spanId = 0x12D687;
            // The spanId set on the log entry should confirm to x16
            // format so that the backend can really associate the log entry
            // to the span.
            string expectedSpanId = "000000000012d687";

            IServiceProvider serviceProvider = MockServiceProvider(traceId, spanId, true);


            GoogleTraceProvider traceProvider = new GoogleTraceProvider();
            TraceContextForLogEntry traceContext = traceProvider.GetCurrentTraceContext(serviceProvider);

            Assert.Equal(traceId, traceContext.TraceId);
            Assert.Equal(expectedSpanId, traceContext.SpanId);
        }

        [Fact]
        public void GetCurrentTraceContext_ShouldNotTrace()
        {
            string traceId = "105445aa7843bc8bf206b12000100f00";
            ulong spanId = 1234567;

            IServiceProvider serviceProvider = MockServiceProvider(traceId, spanId, false);

            GoogleTraceProvider traceProvider = new GoogleTraceProvider();
            Assert.Null(traceProvider.GetCurrentTraceContext(serviceProvider));
        }

        private IServiceProvider MockServiceProvider(string traceId, ulong spanId, bool shouldTrace)
        {
            char shouldTraceBit = shouldTrace ? '1' : '0';
            StringValues headerValue = $"{traceId}/{spanId};o={shouldTraceBit}";

            Mock<IHeaderDictionary> headerDictionaryMock = new Mock<IHeaderDictionary>(MockBehavior.Strict);
            headerDictionaryMock.Setup(hd => hd.TryGetValue(TraceHeaderContext.TraceHeader, out headerValue)).Returns(true);

            Mock<HttpRequest> requestMock = new Mock<HttpRequest>(MockBehavior.Strict);
            requestMock.Setup(r => r.Headers).Returns(headerDictionaryMock.Object);

            Mock<HttpContext> contextMock = new Mock<HttpContext>(MockBehavior.Strict);
            contextMock.Setup(c => c.Request).Returns(requestMock.Object);

            Mock<IHttpContextAccessor> contextAccessorMock = new Mock<IHttpContextAccessor>(MockBehavior.Strict);
            contextAccessorMock.Setup(a => a.HttpContext).Returns(contextMock.Object);

            Mock<IServiceProvider> serviceProviderMock = new Mock<IServiceProvider>(MockBehavior.Strict);
            serviceProviderMock.Setup(p => p.GetService(typeof(IHttpContextAccessor))).Returns(contextAccessorMock.Object);

            return serviceProviderMock.Object;
        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}
