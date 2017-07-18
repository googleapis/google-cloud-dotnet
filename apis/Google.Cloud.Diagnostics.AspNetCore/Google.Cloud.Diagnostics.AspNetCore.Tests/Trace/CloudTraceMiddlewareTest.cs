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

using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests
{
    public class CloudTraceMiddlewareTest
    {
        private static readonly TraceIdFactory _traceIdFactory = TraceIdFactory.Create();
        private static readonly TraceHeaderContext _traceHeaderContext = 
            new TraceHeaderContext(_traceIdFactory.NextId(), 0, true);

        /// <summary>
        /// Creates a <see cref="Mock{IManagedTracer}"/> that is set up to start and end a span as well as
        /// annotate the span.
        /// </summary>
        private static Mock<IManagedTracer> CreateIManagedTracerMock(HttpContext context)
        {
            var tracerMock = new Mock<IManagedTracer>();
            tracerMock.Setup(t => t.GetCurrentTraceId()).Returns(_traceHeaderContext.TraceId);
            tracerMock.Setup(t => t.StartSpan(context.Request.Path, null)).Returns(new NullManagedTracer.Span());
            tracerMock.Setup(t => t.AnnotateSpan(It.IsAny<Dictionary<string, string>>()));
            return tracerMock;
        }

        /// <summary>
        /// Create a basic <see cref="HttpContext"/> with a request and request path.
        /// </summary>
        private static HttpContext CreateHttpContext()
        {
            var context = new DefaultHttpContext();
            var request = new DefaultHttpRequest(context);
            request.Path = new PathString("/api/trace");
            return context;
        }

        [Fact]
        public async Task Invoke_Trace()
        {
            var accessor = new HttpContextAccessor { HttpContext = new DefaultHttpContext() };
            var context = CreateHttpContext();
            var tracerMock = CreateIManagedTracerMock(context);

            var delegateMock = new Mock<RequestDelegate>();
            delegateMock.Setup(d => d(context)).Returns(Task.CompletedTask);

            var tracerFactoryMock = new Mock<IManagedTracerFactory>();
            tracerFactoryMock.Setup(f => f.CreateTracer(_traceHeaderContext)).Returns(tracerMock.Object);

            Assert.Equal(NullManagedTracer.Instance, ContextTracerManager.GetCurrentTracer(accessor));

            var middleware = new CloudTraceMiddleware(delegateMock.Object, tracerFactoryMock.Object, accessor);
            await middleware.Invoke(context, _traceHeaderContext);

            Assert.Equal(tracerMock.Object, ContextTracerManager.GetCurrentTracer(accessor));

            Assert.True(context.Response.Headers.ContainsKey(TraceHeaderContext.TraceHeader));
            Assert.Equal(_traceHeaderContext.ToString(), context.Response.Headers[TraceHeaderContext.TraceHeader]);

            delegateMock.VerifyAll();
            tracerMock.VerifyAll();
        }

        [Fact]
        public async Task Invoke_TraceException()
        {
            var accessor = new HttpContextAccessor { HttpContext = new DefaultHttpContext() };
            var context = CreateHttpContext();
            var tracerMock = CreateIManagedTracerMock(context);
            tracerMock.Setup(t => t.SetStackTrace(It.IsAny<StackTrace>()));

            var delegateMock = new Mock<RequestDelegate>();
            delegateMock.Setup(d => d(context)).Throws(new Exception());

            var tracerFactoryMock = new Mock<IManagedTracerFactory>();
            tracerFactoryMock.Setup(f => f.CreateTracer(_traceHeaderContext)).Returns(tracerMock.Object);

            var middleware = new CloudTraceMiddleware(delegateMock.Object, tracerFactoryMock.Object, accessor);
            await Assert.ThrowsAsync<Exception>(
                () => middleware.Invoke(context, _traceHeaderContext));

            Assert.True(context.Response.Headers.ContainsKey(TraceHeaderContext.TraceHeader));
            Assert.Equal(_traceHeaderContext.ToString(), context.Response.Headers[TraceHeaderContext.TraceHeader]);

            delegateMock.VerifyAll();
            tracerMock.VerifyAll();
        }

        [Fact]
        public async Task Invoke_NoTrace()
        {
            var accessor = new HttpContextAccessor { HttpContext = new DefaultHttpContext() };
            var context = new DefaultHttpContext();
            var delegateMock = new Mock<RequestDelegate>();
            var tracerMock = new Mock<IManagedTracer>();

            var tracerFactoryMock = new Mock<IManagedTracerFactory>();
            tracerFactoryMock.Setup(f => f.CreateTracer(_traceHeaderContext)).Returns(tracerMock.Object);

            var middleware = new CloudTraceMiddleware(delegateMock.Object, tracerFactoryMock.Object, accessor);
            await middleware.Invoke(context, _traceHeaderContext);

            Assert.Equal(tracerMock.Object, ContextTracerManager.GetCurrentTracer(accessor));
            Assert.False(context.Response.Headers.ContainsKey(TraceHeaderContext.TraceHeader));

            delegateMock.Verify(d => d(context), Times.Once());
            tracerMock.Verify(t => t.StartSpan(It.IsAny<string>(), null), Times.Never());
        }
    }
}
