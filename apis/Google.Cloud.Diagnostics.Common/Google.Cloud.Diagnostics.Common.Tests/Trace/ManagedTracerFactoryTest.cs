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
using Xunit;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class ManagedTracerFactoryTest
    {
        private const string ProjectId = "pid";
        private const string TraceId = "105445aa7843bc8bf206b12000100f00";
        private const ulong SpanId = 81237123;

        /// <summary>A trace id factory instance. Not used for testing.</summary>
        private static readonly TraceIdFactory s_traceIdFactory = TraceIdFactory.Create();

        /// <summary>A trace consumer instance. Not used for testing.</summary>
        private static readonly IConsumer<TraceProto> s_comsumer = new Mock<IConsumer<TraceProto>>().Object;

        /// <summary>A trace header that will say to trace.</summary>
        private static readonly TraceHeaderContext s_headerTrue = TraceHeaderContext.Create(TraceId, SpanId, true);

        /// <summary>A trace header that will have no information about whether to trace or not.</summary>
        private static readonly TraceHeaderContext s_headerNull = TraceHeaderContext.Create(null, null, null);

        /// <summary>A trace header that will say not to trace.</summary>
        private static readonly TraceHeaderContext s_headerFalse = TraceHeaderContext.Create(null, null, false);

        /// <summary>A managed tracer factory that has an option factory that will always suggest trace.</summary>
        private static readonly ManagedTracerFactory s_tracerFactoryNoLimit = CreateFactory(TraceOptionsFactory.AlwaysTrace);

        /// <summary>A managed tracer factory that has an option factory that will always suggest not to trace.</summary>
        private static readonly ManagedTracerFactory s_tracerFactoryLimit = CreateFactory(TraceOptionsFactory.NeverTrace);

        [Fact]
        public void ShouldTrace_FalseHeaderTrueRateLimiter()
        {
            Assert.False(s_tracerFactoryNoLimit.ShouldTrace(s_headerFalse));
        }

        [Fact]
        public void ShouldTrace_NoHeaderTrueRateLimiter()
        {
            Assert.True(s_tracerFactoryNoLimit.ShouldTrace(s_headerNull));
        }

        [Fact]
        public void ShouldTrace_TrueHeaderTrueRateLimiter()
        {
            Assert.True(s_tracerFactoryNoLimit.ShouldTrace(s_headerTrue));
        }

        [Fact]
        public void ShouldTrace_FalseHeaderFalseRateLimiter()
        {
            Assert.False(s_tracerFactoryLimit.ShouldTrace(s_headerFalse));
        }

        [Fact]
        public void ShouldTrace_NoHeaderFalseRateLimiter()
        {
            Assert.False(s_tracerFactoryLimit.ShouldTrace(s_headerNull));
        }

        [Fact]
        public void ShouldTrace_TrueHeaderFalseRateLimiter()
        {
            Assert.True(s_tracerFactoryLimit.ShouldTrace(s_headerTrue));
        }

        [Fact]
        public void CreateTracer_DoNothingTracer()
        {
            IManagedTracer tracer =  s_tracerFactoryLimit.CreateTracer(s_headerFalse);
            Assert.IsType(typeof(NullManagedTracer), tracer);
        }

        [Fact]
        public void CreateTracer_SimpleManagedTracer()
        {
            IManagedTracer tracer = s_tracerFactoryNoLimit.CreateTracer(s_headerTrue);
            Assert.IsType(typeof(SimpleManagedTracer), tracer);
            Assert.Equal(tracer.GetCurrentTraceId(), TraceId);
            Assert.Equal(tracer.GetCurrentSpanId(), SpanId);
        }

        private static ManagedTracerFactory CreateFactory(ITraceOptionsFactory optionsFactory) => 
            new ManagedTracerFactory(ProjectId, s_comsumer, optionsFactory, s_traceIdFactory);

        /// <summary>
        /// An option factory for testing.
        /// </summary>
        private class TraceOptionsFactory : ITraceOptionsFactory
        {
            /// <summary>An options factory that will always return options to trace.</summary>
            public static readonly TraceOptionsFactory AlwaysTrace = new TraceOptionsFactory(true);

            /// <summary>An options factory that will always return options to not trace.</summary>
            public static readonly TraceOptionsFactory NeverTrace = new TraceOptionsFactory(false);

            private readonly TraceOptions _options;
            public TraceOptionsFactory(bool shouldTrace)
            {
                _options = TraceOptions.Create(shouldTrace);
            }
            
            public TraceOptions CreateOptions() => _options;
        }
    }
}
