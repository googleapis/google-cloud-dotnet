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
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests
{
    public class CloudTraceExtensionTest
    {
        private const string TraceId = "105445aa7843bc8bf206b12000100f00";
        private const ulong SpanId = 81237123;

        [Fact]
        public void CreateTraceHeaderContext()
        {
            string header = $"{TraceId}/{SpanId};o=1";

            var context = new DefaultHttpContext();
            var request = new DefaultHttpRequest(context);
            request.Headers[TraceHeaderContext.TraceHeader] = header;

            var accessor = new HttpContextAccessor();
            accessor.HttpContext = context;
            
            Mock<IServiceProvider> mockProvider = new Mock<IServiceProvider>();
            mockProvider.Setup(p => p.GetService(typeof(IHttpContextAccessor))).Returns(accessor);

            var headerContext = CloudTraceExtension.CreateTraceHeaderContext(mockProvider.Object);
            Assert.Equal(TraceHeaderContext.FromHeader(header).ToString(), headerContext.ToString());
        }

        [Fact]
        public void CreateManagedTracer()
        {

            var context = TraceHeaderContext.Create(null, null, false);
            var tracerFactoryMock = new Mock<IManagedTracerFactory>();
            tracerFactoryMock.Setup(f => f.CreateTracer(context)).Returns(DoNothingTracer.Instance);
            var mockProvider = new Mock<IServiceProvider>();
            mockProvider.Setup(p => p.GetService(typeof(TraceHeaderContext))).Returns(context);
            mockProvider.Setup(p => p.GetService(typeof(IManagedTracerFactory))).Returns(tracerFactoryMock.Object);

            var tracer = CloudTraceExtension.CreateManagedTracer(mockProvider.Object);
            Assert.IsType(typeof(DoNothingTracer), tracer);
            tracerFactoryMock.VerifyAll();
            mockProvider.VerifyAll();
        }

    }
}