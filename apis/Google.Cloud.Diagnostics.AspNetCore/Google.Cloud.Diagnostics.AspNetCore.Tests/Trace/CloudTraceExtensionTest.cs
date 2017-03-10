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

using static Google.Cloud.Diagnostics.AspNetCore.CloudTraceExtension;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests
{
    public class CloudTraceExtensionTest
    {
        private const string _traceId = "105445aa7843bc8bf206b12000100f00";
        private const ulong _spanId = 81237123;

        /// <summary>
        /// Create an <see cref="IServiceProvider"/> to be used during tests of 
        /// <see cref="CloudTraceExtension.CreateTraceHeaderContext(IServiceProvider)"/>.
        /// It will set up an <see cref="IHttpContextAccessor"/> with the passed in trace header,
        /// a <see cref="ShouldTraceRequest"/> with the passed in should trace function and a
        /// <see cref="TraceIdFactory"/>.
        /// </summary>
        private IServiceProvider CreateProviderForTraceHeaderContext(
            string traceHeader, Func<HttpRequest, bool?> shouldTraceFunc = null)
        {
            var context = new DefaultHttpContext();
            var request = new DefaultHttpRequest(context);
            request.Headers[TraceHeaderContext.TraceHeader] = traceHeader;

            var accessor = new HttpContextAccessor();
            accessor.HttpContext = context;

            var traceIdFactory = TraceIdFactory.Create();

            Mock<IServiceProvider> mockProvider = new Mock<IServiceProvider>();
            mockProvider.Setup(p => p.GetService(typeof(IHttpContextAccessor))).Returns(accessor);
            mockProvider.Setup(p => p.GetService(typeof(ShouldTraceRequest))).Returns(
                new ShouldTraceRequest(shouldTraceFunc));
            mockProvider.Setup(p => p.GetService(typeof(TraceIdFactory))).Returns(traceIdFactory);
            return mockProvider.Object;
        }

        [Fact]
        public void CreateTraceHeaderContext()
        {
            var header = $"{_traceId}/{_spanId};o=1";
            var provider = CreateProviderForTraceHeaderContext(header);
            var headerContext = CloudTraceExtension.CreateTraceHeaderContext(provider);
            Assert.Equal(TraceHeaderContext.FromHeader(header).ToString(), headerContext.ToString());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        [InlineData(null)]
        public void CreateTraceHeaderContext_ForceTrace(bool? shouldTrace)
        {
            var provider = CreateProviderForTraceHeaderContext($"{_traceId}/{_spanId};", ((HttpRequest r) => shouldTrace));
            var headerContext = CloudTraceExtension.CreateTraceHeaderContext(provider);
            Assert.Equal(_traceId, headerContext.TraceId);
            Assert.Equal(_spanId, headerContext.SpanId);
            Assert.Equal(shouldTrace, headerContext.ShouldTrace);
        }

        [Fact]
        public void CreateTraceHeaderContext_ForceTrace_NoHeader()
        {
            var provider = CreateProviderForTraceHeaderContext("", ((HttpRequest r) => true));
            var headerContext = CloudTraceExtension.CreateTraceHeaderContext(provider);
            Assert.NotNull(headerContext.TraceId);
            Assert.Equal((ulong)0, headerContext.SpanId);
            Assert.Equal(true, headerContext.ShouldTrace);
        }

        [Fact]
        public void CreateManagedTracer()
        {
            var mockProvider = new Mock<IServiceProvider>();
            mockProvider.Setup(p => p.GetService(typeof(IHttpContextAccessor))).Returns(new HttpContextAccessor());
            var tracer = CloudTraceExtension.CreateManagedTracer(mockProvider.Object);
            Assert.IsType(typeof(ContextTracerManager), tracer);
            mockProvider.VerifyAll();
        }

        [Fact]
        public void GetServiceCheckNotNull()
        {
            var accessor = new HttpContextAccessor();
            var mockProvider = new Mock<IServiceProvider>();
            mockProvider.Setup(p => p.GetService(typeof(IHttpContextAccessor))).Returns(accessor);
            var service = mockProvider.Object.GetServiceCheckNotNull<IHttpContextAccessor>();
            Assert.Equal(accessor, service);
        }

        [Fact]
        public void GetServiceCheckNotNull_Throws()
        {
            var mockProvider = new Mock<IServiceProvider>();
            Assert.Throws<InvalidOperationException>(
                () => mockProvider.Object.GetServiceCheckNotNull<IHttpContextAccessor>());
        }
    }
}