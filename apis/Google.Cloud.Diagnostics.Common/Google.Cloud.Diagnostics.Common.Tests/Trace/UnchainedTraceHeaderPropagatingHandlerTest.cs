// Copyright 2018 Google Inc. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class UnchainedTraceHeaderPropagatingHandlerTest
    {
        private const string TraceId = "105445aa7843bc8bf206b12000100f00";
        private const ulong SpanId = 81237123;

        [Fact]
        public void InnerHandler_Unset()
        {
            var mockTracer = new Mock<IManagedTracer>();
            var traceHandler = new UnchainedTraceHeaderPropagatingHandler(() => mockTracer.Object);
            Assert.Null(traceHandler.InnerHandler);
        }

        [Fact]
        public async Task SendAsync_NoTrace()
        {
            var managedTracer = new FakeManagedTracer(null, null);
            var traceHandler = new UnchainedTraceHeaderPropagatingHandler(() => managedTracer)
            {
                InnerHandler = new BounceBackRequestHandler()
            };

            using var httpClient = new HttpClient(traceHandler);
            var response = await httpClient.GetAsync("https://www.google.com");

            AssertDoesNotContainGoogleTraceHeader(response.RequestMessage);
            AssertDoesNotContainTraceProperties(response.RequestMessage);

            managedTracer.AssertNoRanInSpan();
        }

        [Fact]
        public async Task SendAsync_Trace_Default()
        {
            var managedTracer = new FakeManagedTracer(TraceId, SpanId);
            var traceHandler = new UnchainedTraceHeaderPropagatingHandler(() => managedTracer)
            {
                InnerHandler = new BounceBackRequestHandler()
            };

            var url = "https://www.google.com/";

            using var httpClient = new HttpClient(traceHandler);
            var response = await httpClient.GetAsync(url);

            AssertContainsGoogleTraceHeader(response.RequestMessage);
            AssertDoesNotContainTraceProperties(response.RequestMessage);

            managedTracer.AssertSingleRanInSpan(url);
        }

        [Fact]
        public async Task SendAsync_Trace_Custom()
        {
            var managedTracer = new FakeManagedTracer(TraceId, SpanId);
            var traceHandler = new UnchainedTraceHeaderPropagatingHandler(() => managedTracer, SetOutgoingHttpTraceContext)
            {
                InnerHandler = new BounceBackRequestHandler()
            };

            var url = "https://www.google.com/";

            using var httpClient = new HttpClient(traceHandler);
            var response = await httpClient.GetAsync(url);

            AssertContainsTraceProperties(response.RequestMessage);
            AssertDoesNotContainGoogleTraceHeader(response.RequestMessage);

            managedTracer.AssertSingleRanInSpan(url);
        }

        [Fact]
        public async Task SendAsync_Trace_Custom_Labels()
        {
            
            var managedTracer = new FakeManagedTracer(TraceId, SpanId);
            var traceHandler = new UnchainedTraceHeaderPropagatingHandler(
                () => managedTracer,
                SetOutgoingHttpTraceContext,
                new Dictionary<string, string> { { "label1", "value1"} })
            {
                InnerHandler = new BounceBackRequestHandler()
            };

            var url = "https://www.google.com/";

            using var httpClient = new HttpClient(traceHandler);
            var response = await httpClient.GetAsync(url);

            AssertContainsTraceProperties(response.RequestMessage);
            AssertDoesNotContainGoogleTraceHeader(response.RequestMessage);

            managedTracer.AssertHasLabel("label1", "value1");
            managedTracer.AssertSingleRanInSpan(url);
        }

        private class BounceBackRequestHandler : HttpMessageHandler
        {
            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
                Task.FromResult(new HttpResponseMessage { RequestMessage = request });
        }

        private class FakeManagedTracer : IManagedTracer
        {
            private readonly string _traceId;
            private readonly ulong? _spanId;
            private readonly IList<string> _ranInSpans = new List<string>();
            private readonly IDictionary<string, string> _spanLabels = new Dictionary<string, string>();

            internal FakeManagedTracer(string traceId, ulong? spanId) => (_traceId, _spanId) = (traceId, spanId);

            public string GetCurrentTraceId() => _traceId;

            public ulong? GetCurrentSpanId() => _spanId;

            public async Task<T> RunInSpanAsync<T>(Func<Task<T>> func, string name, StartSpanOptions options = null)
            {
                _ranInSpans.Add(name);
                return await func();
            }

            public T RunInSpan<T>(Func<T> func, string name, StartSpanOptions options = null)
            {
                _ranInSpans.Add(name);
                return func();
            }

            public void RunInSpan(Action action, string name, StartSpanOptions options = null)
            {
                _ranInSpans.Add(name);
                action();
            }

            public ISpan StartSpan(string name, StartSpanOptions options = null) => throw new NotImplementedException();

            public void AnnotateSpan(Dictionary<string, string> labels)
            {
                foreach (var label in labels)
                {
                    _spanLabels.Add(label.Key, label.Value);
                }
            }

            public void SetStackTrace(StackTrace stackTrace) => throw new NotImplementedException();

            public void AssertSingleRanInSpan(string spanName)
            {
                var span = Assert.Single(_ranInSpans);
                Assert.Equal(spanName, span);
            }

            public void AssertNoRanInSpan() => Assert.Empty(_ranInSpans);

            public void AssertHasLabel(string key, string value) =>
                Assert.Equal(value, Assert.Contains(key, _spanLabels));
        }

        // TODO: Use Options instead of Properties
        private static void SetOutgoingHttpTraceContext(HttpRequestMessage request, ITraceContext context)
        {
            request.Properties.Add("traceId", context.TraceId);
            request.Properties.Add("spanId", context.SpanId);
        }

        private void AssertContainsTraceProperties(HttpRequestMessage request)
        {
            Assert.Equal(TraceId, request.Properties["traceId"]);
            Assert.Equal(SpanId, request.Properties["spanId"]);
        }

        private void AssertDoesNotContainTraceProperties(HttpRequestMessage request)
        {
            Assert.DoesNotContain("traceId", request.Properties);
            Assert.DoesNotContain("spanId", request.Properties);
        }

        private void AssertContainsGoogleTraceHeader(HttpRequestMessage request)
        {
            var traceHeader = Assert.Single(request.Headers.GetValues(TraceHeaderContext.TraceHeader));
            var currentContext = TraceHeaderContext.FromHeader(traceHeader);
            Assert.Equal(TraceId, currentContext.TraceId);
            Assert.Equal(SpanId, currentContext.SpanId);
            Assert.True(currentContext.ShouldTrace);
        }

        private void AssertDoesNotContainGoogleTraceHeader(HttpRequestMessage request) =>
            Assert.False(request.Headers.Contains(TraceHeaderContext.TraceHeader));
    }
}
