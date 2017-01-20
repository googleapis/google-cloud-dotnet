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

namespace Google.Cloud.Diagnostics.AspNetCore.Tests.Trace
{
    public class CloudTraceMiddlewareTest
    {
        [Fact]
        public async Task Invoke_Trace()
        {
            var context = new DefaultHttpContext();
            var request = new DefaultHttpRequest(context);
            request.Path = new PathString("/api/trace");

            var delegateMock = new Mock<RequestDelegate>();
            delegateMock.Setup(d => d(context)).Returns(Task.CompletedTask);

            var tracerMock = new Mock<IManagedTracer>();
            tracerMock.Setup(t => t.GetCurrentTraceId()).Returns("trace-id");
            tracerMock.Setup(t => t.StartSpan(request.Path, null));
            tracerMock.Setup(t => t.AnnotateSpan(It.IsAny<Dictionary<string, string>>()));
            tracerMock.Setup(t => t.EndSpan());

            var middleware = new CloudTraceMiddleware(delegateMock.Object);
            await middleware.Invoke(context, tracerMock.Object);

            delegateMock.VerifyAll();
            tracerMock.VerifyAll();
        }

        [Fact]
        public async Task Invoke_TraceException()
        {
            var context = new DefaultHttpContext();
            var request = new DefaultHttpRequest(context);
            request.Path = new PathString("/api/trace");

            var delegateMock = new Mock<RequestDelegate>();
            delegateMock.Setup(d => d(context)).Throws(new Exception());

            var tracerMock = new Mock<IManagedTracer>();
            tracerMock.Setup(t => t.GetCurrentTraceId()).Returns("trace-id");
            tracerMock.Setup(t => t.StartSpan(request.Path, null));
            tracerMock.Setup(t => t.AnnotateSpan(It.IsAny<Dictionary<string, string>>()));
            tracerMock.Setup(t => t.SetStackTrace(It.IsAny<StackTrace>()));
            tracerMock.Setup(t => t.EndSpan());

            var middleware = new CloudTraceMiddleware(delegateMock.Object);
            await Assert.ThrowsAsync<Exception>(
                () => middleware.Invoke(context, tracerMock.Object));

            delegateMock.VerifyAll();
            tracerMock.VerifyAll();
        }

        [Fact]
        public async Task Invoke_NoTrace()
        {
            var context = new DefaultHttpContext();
            var delegateMock = new Mock<RequestDelegate>();
            var tracerMock = new Mock<IManagedTracer>();
            tracerMock.Setup(t => t.GetCurrentTraceId()).Returns((string) null);

            var middleware = new CloudTraceMiddleware(delegateMock.Object);
            await middleware.Invoke(context, tracerMock.Object);

            delegateMock.Verify(d => d(context), Times.Once());
            tracerMock.Verify(t => t.StartSpan(It.IsAny<string>(), null), Times.Never());
            tracerMock.Verify(t => t.EndSpan(), Times.Never());
        }
    }
}
