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

using Moq;
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
            var mockedManagedTracer = new Mock<IManagedTracer>(MockBehavior.Strict).Object;
            ContextTracerManager.SetCurrentTracer(mockedManagedTracer);

            Assert.Equal(mockedManagedTracer, ContextTracerManager.GetCurrentTracer());
        }

        [Fact]
        public void Set_NullTraceId_NullTraceContext()
        {
            var managedTracerMock = new Mock<IManagedTracer>(MockBehavior.Strict);
            managedTracerMock.Setup(t => t.GetCurrentTraceId()).Returns<IManagedTracer, string>(null);
            ContextTracerManager.SetCurrentTracer(managedTracerMock.Object);

            Assert.Null(ContextTracerManager.GetCurrentTraceContext());
        }

        [Fact]
        public void Set_NullSpanId_TraceContext()
        {
            var managedTracerMock = new Mock<IManagedTracer>(MockBehavior.Strict);
            managedTracerMock.Setup(t => t.GetCurrentTraceId()).Returns("dummyTraceId");
            managedTracerMock.Setup(t => t.GetCurrentSpanId()).Returns<IManagedTracer, ulong?>(null);
            ContextTracerManager.SetCurrentTracer(managedTracerMock.Object);

            var traceContext = ContextTracerManager.GetCurrentTraceContext();
            Assert.NotNull(traceContext);

            Assert.Equal("dummyTraceId", traceContext.TraceId);
            Assert.Null(traceContext.SpanId);
            Assert.True(traceContext.ShouldTrace);
        }

        [Fact]
        public void Set_TraceContext()
        {
            var managedTracerMock = new Mock<IManagedTracer>(MockBehavior.Strict);
            managedTracerMock.Setup(t => t.GetCurrentTraceId()).Returns("dummyTraceId");
            managedTracerMock.Setup(t => t.GetCurrentSpanId()).Returns(123456789u);
            ContextTracerManager.SetCurrentTracer(managedTracerMock.Object);

            var traceContext = ContextTracerManager.GetCurrentTraceContext();
            Assert.NotNull(traceContext);

            Assert.Equal("dummyTraceId", traceContext.TraceId);
            Assert.Equal(123456789u, traceContext.SpanId);
            Assert.True(traceContext.ShouldTrace);
        }

        [Fact]
        public async Task SetAndGetInNestedAsyncContexts()
        {
            var mockedManagedTracer = new Mock<IManagedTracer>(MockBehavior.Strict).Object;

            async Task<IManagedTracer> getTracer()
            {
                var tracer = ContextTracerManager.GetCurrentTracer();
                await Task.Yield();
                return tracer;
            }

            async Task<IManagedTracer> setTracerAndGet()
            {
                ContextTracerManager.SetCurrentTracer(mockedManagedTracer);
                await Task.Yield();
                return await getTracer();
            }

            var actualManagedTracer = await setTracerAndGet();
            Assert.Equal(mockedManagedTracer, actualManagedTracer);
        }

        [Fact]
        public async Task SetAndGetInDifferentAsyncContexts()
        {
            var mockedManagedTracer = new Mock<IManagedTracer>(MockBehavior.Strict).Object;

            async Task setTracer()
            {
                ContextTracerManager.SetCurrentTracer(mockedManagedTracer);
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
