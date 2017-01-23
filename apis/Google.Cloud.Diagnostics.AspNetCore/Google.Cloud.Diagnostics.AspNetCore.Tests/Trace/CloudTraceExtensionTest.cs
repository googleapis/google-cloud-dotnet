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
using Google.Cloud.Diagnostics.Common.Tests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Moq;
using System;
using Xunit;

using ProjectId = Google.Cloud.Diagnostics.AspNetCore.CloudTraceExtension.ProjectId;
using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests.Trace
{
    public class CloudTraceExtensionTest
    {
        private const string ProjectId = "pid";
        private const string TraceId = "105445aa7843bc8bf206b12000100f00";
        private const ulong SpanId = 81237123;

        /// <summary>
        /// Creates an <see cref="IServiceProvider"/> with all the needed dependencies to
        /// create an <see cref="IManagedTracer"/>.
        /// </summary>
        /// <param name="context">The trace header context.</param>
        /// <param name="rateLimiterShouldTrace">True if the rate limiter should allow tracing.</param>
        private Mock<IServiceProvider> CreateProviderForCreateManagedTracer(
            TraceHeaderContext context, bool rateLimiterShouldTrace)
        {
            Mock<IConsumer<TraceProto>> mockConsumer = new Mock<IConsumer<TraceProto>>();
            Mock<IServiceProvider> mockProvider = new Mock<IServiceProvider>();

            mockProvider.Setup(p => p.GetService(typeof(TraceHeaderContext))).Returns(context);
            mockProvider.Setup(p => p.GetService(typeof(ProjectId))).Returns(new ProjectId { Id = ProjectId });
            mockProvider.Setup(p => p.GetService(typeof(TraceIdFactory))).Returns(TraceIdFactory.Create());
            mockProvider.Setup(p => p.GetService(typeof(IConsumer<TraceProto>))).Returns(mockConsumer.Object);

            var rateLimiter = TraceUtils.GetRateLimiter(rateLimiterShouldTrace ? 1001 : 999);
            var rateLimitingFactory = new RateLimitingTraceOptionsFactory(rateLimiter);
            mockProvider.Setup(p => p.GetService(typeof(RateLimitingTraceOptionsFactory)))
                .Returns(rateLimitingFactory);
            return mockProvider;
        }

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
        public void CreateTraceHeaderContext_NoHeader()
        {
            Mock<IServiceProvider> mockProvider = new Mock<IServiceProvider>();
            mockProvider.Setup(p => p.GetService(typeof(HttpContext))).Returns(null);

            var headerContext = CloudTraceExtension.CreateTraceHeaderContext(mockProvider.Object);
            Assert.Equal(TraceHeaderContext.FromHeader(null), headerContext);
        }

        [Fact]
        public void CreateManagedTracer_DoNothingTracer()
        {
            var context = TraceHeaderContext.Create(null, null, false);
            var mockProvider = CreateProviderForCreateManagedTracer(context, false);

            var tracer = CloudTraceExtension.CreateManagedTracer(mockProvider.Object);
            Assert.IsType(typeof(DoNothingTracer), tracer);
        }

        [Fact]
        public void CreateManagedTracer_SimpleTracer()
        {
            var context = TraceHeaderContext.Create(null, null, null);
            var mockProvider = CreateProviderForCreateManagedTracer(context, true);

            var tracer = CloudTraceExtension.CreateManagedTracer(mockProvider.Object);
            Assert.IsType(typeof(SimpleManagedTracer), tracer);
            Assert.NotEmpty(tracer.GetCurrentTraceId());
            Assert.Null(tracer.GetCurrentSpanId());
        }

        [Fact]
        public void CreateManagedTracer_SimpleTracer_FromHeaderContext()
        {
            var context = TraceHeaderContext.Create(TraceId, SpanId, true);
            var mockProvider = CreateProviderForCreateManagedTracer(context, true);

            var tracer = CloudTraceExtension.CreateManagedTracer(mockProvider.Object);
            Assert.IsType(typeof(SimpleManagedTracer), tracer);
            Assert.Equal(tracer.GetCurrentTraceId(), TraceId);
            Assert.Equal(tracer.GetCurrentSpanId(), SpanId);
        }
    }
}