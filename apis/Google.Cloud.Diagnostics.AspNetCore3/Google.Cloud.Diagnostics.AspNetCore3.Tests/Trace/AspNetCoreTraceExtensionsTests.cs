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
using Moq;
using System;
using Xunit;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3.Tests
#elif NETCOREAPP2_1 || NET461
namespace Google.Cloud.Diagnostics.AspNetCore.Tests
#else
#error unknown target framework
#endif
{
    public class AspNetCoreTraceExtensionsTests
    {
        private const string _traceId = "105445aa7843bc8bf206b12000100f00";
        private const ulong _spanId = 81237123;

        private IServiceProvider CreateProviderForTraceHeaderContext(string traceHeader)
        {
            var context = new DefaultHttpContext();
            var request = context.Request;
            request.Headers[TraceHeaderContext.TraceHeader] = traceHeader;

            var accessor = new HttpContextAccessor { HttpContext = context };

            var traceIdFactory = TraceIdFactory.Create();

            Mock<IServiceProvider> mockProvider = new Mock<IServiceProvider>();
            mockProvider.Setup(p => p.GetService(typeof(IHttpContextAccessor))).Returns(accessor);
            mockProvider.Setup(p => p.GetService(typeof(TraceDecisionPredicate))).Returns(
                TraceDecisionPredicate.Default);
            mockProvider.Setup(p => p.GetService(typeof(TraceIdFactory))).Returns(traceIdFactory);
            return mockProvider.Object;
        }

        [Fact]
        public void CreateTraceHeaderContext()
        {
            var header = $"{_traceId}/{_spanId};o=1";
            var provider = CreateProviderForTraceHeaderContext(header);
            var headerContext = AspNetCoreTraceExtensions.ProvideGoogleTraceHeaderContext(provider);
            Assert.Equal(TraceHeaderContext.FromHeader(header).ToString(), headerContext.ToString());
        }

        [Fact]
        public void CreateTraceHeaderContext_UseShouldTraceFallback()
        {
            var header = $"{_traceId}/{_spanId};";
            var provider = CreateProviderForTraceHeaderContext(header);
            var headerContext = AspNetCoreTraceExtensions.ProvideGoogleTraceHeaderContext(provider);
            Assert.Equal(TraceHeaderContext.FromHeader(header).ToString(), headerContext.ToString());
        }
    }
}