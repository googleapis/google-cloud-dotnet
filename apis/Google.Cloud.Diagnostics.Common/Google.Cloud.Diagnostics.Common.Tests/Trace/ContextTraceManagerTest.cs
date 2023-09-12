// Copyright 2019 Google Inc. All Rights Reserved.
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

using Google.Cloud.Diagnostics.Common.Tests.Trace;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class ContextTraceManagerTest
    {
        [Fact]
        public void Unset_NullManagedTracer()
        {
            Assert.Equal(NullManagedTracer.Instance, ContextTracerManager.GetCurrentTracer());
        }

        [Fact]
        public void Unset_NullTraceContext() =>
            Assert.Null(ContextTracerManager.GetCurrentTraceContext());

        [Fact]
        public void Set()
        {
            var managedTracer = new FakeManagedTracer("traceid");
            ContextTracerManager.SetCurrentTracer(managedTracer);

            Assert.Equal(managedTracer, ContextTracerManager.GetCurrentTracer());
        }

        [Fact]
        public void Set_NullTraceId_NullTraceContext()
        {
            var managedTracer = new FakeManagedTracer(null);
            ContextTracerManager.SetCurrentTracer(managedTracer);

            Assert.Null(ContextTracerManager.GetCurrentTraceContext());
        }

        [Fact]
        public void Set_NullSpanId_TraceContext()
        {
            var managedTracer = new FakeManagedTracer("sampleTraceId", null);
            ContextTracerManager.SetCurrentTracer(managedTracer);

            var traceContext = ContextTracerManager.GetCurrentTraceContext();
            Assert.NotNull(traceContext);

            Assert.Equal("sampleTraceId", traceContext.TraceId);
            Assert.Null(traceContext.SpanId);
            Assert.True(traceContext.ShouldTrace);
        }

        [Fact]
        public void Set_TraceContext()
        {
            var managedTracer = new FakeManagedTracer("sampleTraceId", 123456789UL);
            ContextTracerManager.SetCurrentTracer(managedTracer);

            var traceContext = ContextTracerManager.GetCurrentTraceContext();
            Assert.NotNull(traceContext);

            Assert.Equal("sampleTraceId", traceContext.TraceId);
            Assert.Equal(123456789UL, traceContext.SpanId);
            Assert.True(traceContext.ShouldTrace);
        }

        [Fact]
        public async Task SetAndGetInNestedAsyncContexts()
        {
            var managedTracer = new FakeManagedTracer("traceid");

            async Task<IManagedTracer> getTracer()
            {
                var tracer = ContextTracerManager.GetCurrentTracer();
                await Task.Yield();
                return tracer;
            }

            async Task<IManagedTracer> setTracerAndGet()
            {
                ContextTracerManager.SetCurrentTracer(managedTracer);
                await Task.Yield();
                return await getTracer();
            }

            var actualManagedTracer = await setTracerAndGet();
            Assert.Equal(managedTracer, actualManagedTracer);
        }

        [Fact]
        public async Task SetAndGetInDifferentAsyncContexts()
        {
            var managedTracer = new FakeManagedTracer("traceid");

            async Task setTracer()
            {
                ContextTracerManager.SetCurrentTracer(managedTracer);
                await Task.Yield();
            }

            async Task<IManagedTracer> getTracer()
            {
                var tracer = ContextTracerManager.GetCurrentTracer();
                await Task.Yield();
                return tracer;
            }

            await setTracer();
            var actualManagedTracer = await getTracer();

            // The "intuitive" thing would be to
            // Assert.Equal(mockedManagedTracer, actualManagedTracer);
            // but, we have implemented the ContextTraceManager using AsyncLocal
            // and since in this test we have set the mocked tracer in an independent
            // async context from the one we are then obtaining the tracer, the tracer set
            // on the first async context is not propagated to the second async context where
            // we are trying to obtain it.
            Assert.Equal(NullManagedTracer.Instance, actualManagedTracer);
        }
    }
}
