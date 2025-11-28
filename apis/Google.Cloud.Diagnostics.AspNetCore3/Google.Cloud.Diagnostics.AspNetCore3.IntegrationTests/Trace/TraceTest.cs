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

using Google.Apis.Auth.OAuth2;
using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Google.Cloud.Trace.V1;
using Grpc.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Diagnostics.Common.HttpClientBuilderExtensions;
using static Google.Cloud.Diagnostics.AspNetCore3.IntegrationTests.TestServerHelpers;
using System.Runtime.CompilerServices;

namespace Google.Cloud.Diagnostics.AspNetCore3.IntegrationTests
{
    public class TraceTest
    {
        private const string CustromTraceIdHeader = "custom_trace_id";
        private const string CustromSpanIdHeader = "custom_span_id";
        private const string CustromShouldTraceHeader = "custom_should_trace";

        private static readonly TraceIdFactory _traceIdFactory = TraceIdFactory.Create();
        private static readonly SpanIdFactory _spanIdFactory = SpanIdFactory.Create();
        private static readonly IDictionary<string, string> _customLabels = new Dictionary<string, string>
        {
            { "label1", "value1" },
            { "label2", "value2" }
        };

        private readonly string _testId;
        private readonly DateTimeOffset _startTime;

        public TraceTest()
        {
            // The rate limiter instance is static and only set once.  If we do not reset it at the
            // beginning of each test the qps will not change.  This is dependent on the tests not
            // running in parallel.
            RateLimiter.Reset();

            _testId = IdGenerator.FromDateTime();
            _startTime = DateTimeOffset.UtcNow;
        }

        public static TheoryData<Action<IWebHostBuilder>> ConfigurationData =>
            new TheoryData<Action<IWebHostBuilder>>
            {
                null,
                ConfigureCustomTraceContext
            };

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace(Action<IWebHostBuilder> testServerConfigurator)
        {
            var uri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.Trace), _testId);

            using var server = GetTestServer<TraceTestNoBufferHighQpsApplication>(testServerConfigurator);
            using var client = server.CreateClient();
            var response = await client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);
            TraceEntryVerifiers.AssertSpanLabelsContains(
                trace.Spans.First(s => s.Name == uri), TraceEntryData.HttpGetSuccessLabels);

            AssertNoTraceHeaders(response);
        }

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace_TraceFallbackPredicate(Action<IWebHostBuilder> testServerConfigurator)
        {
            var tracedId = $"fallback{_testId}";
            var tracedUri = $"/Trace/{nameof(TraceController.Trace)}/{tracedId}";
            var tracedChildSpanName = EntryData.GetMessage(nameof(TraceController.Trace), tracedId);
            var nonTracedUri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";

            using var server = GetTestServer<TraceTestFallbackPredicate>(testServerConfigurator);
            using var client = server.CreateClient();
            var nonTracedTask = client.GetAsync(nonTracedUri);
            var tracedTask = client.GetAsync(tracedUri);
            await Task.WhenAll(nonTracedTask, tracedTask);

            Assert.Null(TraceEntryPolling.NoEntry.GetTrace(nonTracedUri, _startTime, expectTrace: false));

            var trace = TraceEntryPolling.Default.GetTrace(tracedUri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, tracedUri, tracedChildSpanName);
            TraceEntryVerifiers.AssertSpanLabelsContains(
                trace.Spans.First(s => s.Name == tracedUri), TraceEntryData.HttpGetSuccessLabels);
        }

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace_CustomClient(Action<IWebHostBuilder> testServerConfigurator)
        {
            var uri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";

            using var server = GetTestServer<TraceTestCustomClient>(testServerConfigurator);
            using var client = server.CreateClient();

            // We are using a client with a bad credential.
            var exception = await Assert.ThrowsAsync<HttpRequestException>(() => client.GetAsync(uri));
            var rpcException = Assert.IsType<RpcException>(exception.InnerException.InnerException);
            Assert.Equal(StatusCode.Unauthenticated, rpcException.StatusCode);
        }

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace_DummyNameProvider(Action<IWebHostBuilder> testServerConfigurator)
        {
            var uri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";
            // our dummy provider prefixes with /Dummy
            var expectedTraceName = $"/Dummy{uri}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.Trace), _testId);

            using var server = GetTestServer<TraceTestCustomNameProviderNoBufferHighQpsApplication>(testServerConfigurator);
            using var client = server.CreateClient();
            var response = await client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(expectedTraceName, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, expectedTraceName, childSpanName);
            TraceEntryVerifiers.AssertSpanLabelsContains(
                trace.Spans.First(s => s.Name == expectedTraceName), TraceEntryData.HttpGetSuccessLabels);

            AssertNoTraceHeaders(response);
        }

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace_Label(Action<IWebHostBuilder> testServerConfigurator)
        {
            var uri = $"/Trace/{nameof(TraceController.TraceLabels)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.TraceLabels), _testId);

            using var server = GetTestServer<TraceTestNoBufferHighQpsApplication>(testServerConfigurator);
            using var client = server.CreateClient();
            await client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);
            TraceEntryVerifiers.AssertSpanLabelsContains(trace.Spans.First(s => s.Name == childSpanName),
                new Dictionary<string, string>
                {
                        {TraceEntryData.TraceLabel, TraceEntryData.TraceLabelValue }
                });
        }

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace_OutGoingClientFactory(Action<IWebHostBuilder> testServerConfigurator)
        {
            var uri = $"/Trace/{nameof(TraceController.TraceOutgoingClientFactory)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.TraceOutgoingClientFactory), _testId);
            var outgoingSpanName = "https://google.com/";

            using var server = GetTestServer<TraceTestNoBufferHighQpsApplication>(testServerConfigurator);
            using var client = server.CreateClient();
            await client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName, outgoingSpanName);
        }

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace_OutGoingClientFactory_WithLabels(Action<IWebHostBuilder> testServerConfigurator)
        {
            var uri = $"/Trace/{nameof(TraceController.TraceOutgoingClientFactoryWithLabels)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.TraceOutgoingClientFactory), _testId);
            var outgoingSpanName = "https://google.com/";

            using var server = GetTestServer<TraceTestNoBufferHighQpsApplication>(builder =>
            {
                testServerConfigurator?.Invoke(builder);
                builder.ConfigureServices(services => services
                    .AddHttpClient("outgoing_with_labels", c => c.BaseAddress = new Uri("https://google.com/"))
                    .AddOutgoingGoogleTraceHandler(sp => _customLabels));
            });
            using var client = server.CreateClient();
            await client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName, outgoingSpanName);
            TraceEntryVerifiers.AssertSpanLabelsContains(trace.Spans.First(span => span.Name == outgoingSpanName), _customLabels);
        }

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace_StackTrace(Action<IWebHostBuilder> testServerConfigurator)
        {
            var uri = $"/Trace/{nameof(TraceController.TraceStackTrace)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.TraceStackTrace), _testId);

            using var server = GetTestServer<TraceTestNoBufferHighQpsApplication>(testServerConfigurator);
            using var client = server.CreateClient();
            await client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);
            TraceEntryVerifiers.AssertContainsStackTrace(trace.Spans.First(s => s.Name == childSpanName),
                nameof(TraceController), nameof(TraceController.TraceStackTrace),
                nameof(TraceEntryData), nameof(TraceEntryData.CreateStackTrace));
        }

        public static TheoryData<
            Action<IWebHostBuilder>,
            Action<HttpRequestHeaders, string, ulong?, bool?>,
            Action<HttpResponseMessage, string, ulong?, bool?>> HeaderData =>
            new TheoryData<
            Action<IWebHostBuilder>,
            Action<HttpRequestHeaders, string, ulong?, bool?>,
            Action<HttpResponseMessage, string, ulong?, bool?>>
            {
                { null, GoogleTraceContextEmitter, AssertGoogleTraceHeader },
                { ConfigureCustomTraceContext, CustomTraceContextEmitter, AssertCustomTraceHeader }
            };

        [Theory]
        [MemberData(nameof(HeaderData))]
        public async Task Trace_Header(
            Action<IWebHostBuilder> testServerConfigurator,
            Action<HttpRequestHeaders, string, ulong?, bool?> traceContextEmitter,
            Action<HttpResponseMessage, string, ulong?, bool?> assertTraceContext)
        {
            string traceId = _traceIdFactory.NextId();
            ulong spanId = _spanIdFactory.NextId();

            var uri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.Trace), _testId);

            using var server = GetTestServer<TraceTestNoBufferLowQpsApplication>(testServerConfigurator);
            using var client = server.CreateClient();
            traceContextEmitter(client.DefaultRequestHeaders, traceId, spanId, true);

            var response = await client.GetAsync(uri);

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);

            Assert.Equal(traceId, trace.TraceId);
            var parentSpan = trace.Spans.First(s => s.Name == uri);
            Assert.Equal(spanId, parentSpan.ParentSpanId);

            assertTraceContext(response, traceId, spanId, true);
        }

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace_MultipleHeaderPropagation(Action<IWebHostBuilder> testServerConfigurator)
        {
            var createFirstSpanUri = $"/Propagation/{nameof(PropagationController.CreateFirstSpan)}/{_testId}";
            var createFirstSpanSpanName = EntryData.GetMessage(nameof(PropagationController.CreateFirstSpan), _testId);

            var createSecondSpanUri = $"/Propagation/{nameof(PropagationController.CreatesSecondSpan)}/{_testId}";
            var createSecondSpanSpanName = EntryData.GetMessage(nameof(PropagationController.CreatesSecondSpan), _testId);

            var createNoSpanUri = $"/Propagation/{nameof(PropagationController.CreateNoSpan)}/{_testId}";
            var createNoSpanLabels = new Dictionary<string, string>
            {
                {"Message", EntryData.GetMessage(nameof(PropagationController.CreateNoSpan), _testId) }
            };

            // The clientSideServer is the server to which this method, i.e. the client, will post the request, which in turn will generate other requests to other servers.
            using (var clientSideServer = GetTestServer<TraceTestNoBufferHighQpsApplication>(testServerConfigurator))
            // The firstCallServer is the server used from within the first request to make subsequent requests.
            using (var firstCallServer = GetTestServer<TraceTestNoBufferHighQpsApplication>(testServerConfigurator))
            // The secondCallServer is the server used from within the second request to make subsequent requests.
            using (var secondCallServer = GetTestServer<TraceTestNoBufferHighQpsApplication>(testServerConfigurator))
            using (var client = clientSideServer.CreateClient())
            {
                // Set the servers on the Controller so it can generate the subsequent requests.
                // This is needed beacuse we are not making requests against published services but
                // to services that are only available through the test servers.
                // Whoever makes requests to those services (as PropagationController does) needs to do so
                // through an HttpClient generated from the test server.
                PropagationController.FirstCallServer = firstCallServer;
                PropagationController.SecondCallServer = secondCallServer;

                // This request will in turn make other requests, always propagating a trace handler.
                // This request first creates a span, and within that span:
                // 1. Makes a request to a method that does not create a new span but annotates the existing span
                // which is there because of the propagating header.
                // 2. Makes a request that creates a second span and within that span calls the same method in 1.
                await client.GetAsync(createFirstSpanUri);

                // Cleanup
                PropagationController.FirstCallServer = null;
                PropagationController.SecondCallServer = null;
            }

            var trace = TraceEntryPolling.Default.GetTrace(createFirstSpanUri, _startTime);

            // The structure of the spans on the trace should be
            // + span with name createFirstSpanUri (automatically created)
            // ---+ span with name createFirstSpanSpanName (explicitly created in CreateFirstSpan)
            // -------- span with name createNoSpanUri (automatically created because of the trace header and explicitly annotated)
            // -------+ span with name createSecondSpanUri (automatically created because of the trace header)
            // -----------+ span with name createSecondSpanSpanName (explicitly created in CreateSecondSpan)
            // ---------------- span with name createNoSpanUri (automatically created because of the trace header and explicitly annotated)

            Assert.NotNull(trace);

            var automaticFirst = trace.Spans.Single(s => s.Name == createFirstSpanUri);

            var manualFirst = trace.Spans.Single(s => s.Name == createFirstSpanSpanName && s.ParentSpanId == automaticFirst.SpanId);

            var automaticNoSpanInFirst = trace.Spans.Single(s => s.Name == createNoSpanUri && s.ParentSpanId == manualFirst.SpanId);
            TraceEntryVerifiers.AssertSpanLabelsContains(automaticNoSpanInFirst, createNoSpanLabels);
            var automaticSecond = trace.Spans.Single(s => s.Name == createSecondSpanUri && s.ParentSpanId == manualFirst.SpanId);

            var manualSecond = trace.Spans.Single(s => s.Name == createSecondSpanSpanName && s.ParentSpanId == automaticSecond.SpanId);

            var automaticNoSpanInSecond = trace.Spans.Single(s => s.Name == createNoSpanUri && s.ParentSpanId == manualSecond.SpanId);
            TraceEntryVerifiers.AssertSpanLabelsContains(automaticNoSpanInSecond, createNoSpanLabels);
        }

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace_QPS(Action<IWebHostBuilder> testServerConfigurator)
        {
            var traceUri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";
            var traceLabelUri = $"/Trace/{nameof(TraceController.TraceLabels)}/{_testId}";

            using var server = GetTestServer<TraceTestNoBufferApplication>(testServerConfigurator);
            using var client = server.CreateClient();
            // Make two requests, one of the two should be traced as they both occur at nearly the same time.
            var traceTask = client.GetAsync(traceUri);
            var traceLabelsTask = client.GetAsync(traceLabelUri);
            await Task.WhenAll(traceTask, traceLabelsTask);

            // We expect exactly one of the two following traces to have been sent to the backend,
            // but we don't know which. By polling but not expecting a trace in both cases we force
            // the poller to wait for the max configured wait time, poll and return one trace if it
            // found one or null if it didn't.
            // In test pollers, minEntries and expectTrace should be understood as a minimum requirement
            // and not as an exact requirement.
            var trace = TraceEntryPolling.NoEntry.GetTrace(traceUri, _startTime, expectTrace: false);
            var traceLabel = TraceEntryPolling.NoEntry.GetTrace(traceLabelUri, _startTime, expectTrace: false);

            Assert.True((trace == null && traceLabel != null) || (trace != null && traceLabel == null));
        }

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace_Buffer(Action<IWebHostBuilder> testServerConfigurator)
        {
            var traceUri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";
            var traceStackTraceUri = $"/Trace/{nameof(TraceController.TraceStackTrace)}/{_testId}";

            using var server = GetTestServer<TraceTestTinyBufferHighQpsApplication>(testServerConfigurator);
            using var client = server.CreateClient();
            // Make a trace with a small span that will not cause the buffer to flush.
            await client.GetAsync(traceUri);
            Assert.Null(TraceEntryPolling.NoEntry.GetTrace(traceUri, _startTime, expectTrace: false));

            // Make a large trace that will flush the buffer.
            await client.GetAsync(traceStackTraceUri);

            Assert.NotNull(TraceEntryPolling.Default.GetTrace(traceUri, _startTime));
            Assert.NotNull(TraceEntryPolling.Default.GetTrace(traceStackTraceUri, _startTime));
        }

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace_Exception(Action<IWebHostBuilder> testServerConfigurator)
        {
            var uri = $"/Trace/{nameof(TraceController.ThrowException)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.ThrowException), _testId);

            using var server = GetTestServer<TraceTestNoBufferHighQpsApplication>(testServerConfigurator);
            using var client = server.CreateClient();
            await Assert.ThrowsAnyAsync<Exception>(() => client.GetAsync(uri));

            var trace = TraceEntryPolling.Default.GetTrace(uri, _startTime);

            TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);
            TraceEntryVerifiers.AssertContainsStackTrace(trace.Spans.First(s => s.Name == uri),
                nameof(TraceController), nameof(TraceController.ThrowException));
        }

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace_IgnoreHealthChecks(Action<IWebHostBuilder> testServerConfigurator)
        {
            var uri = "/_ah/health";

            using var server = GetTestServer<TraceTestNoBufferHighQpsApplication>(testServerConfigurator);
            using var client = server.CreateClient();
            var response = await client.GetAsync(uri);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var trace = TraceEntryPolling.NoEntry.GetTrace(uri, _startTime, expectTrace: false);
            Assert.Null(trace);
        }

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace_TimedBuffer_Stress(Action<IWebHostBuilder> testServerConfigurator)
        {
            var uri = $"/Trace/{_testId}";
            // Not the best ever stress test but we are limited by read quotas anyway.
            var requests = 300;
            // Entry availability SLO is 90% in 10 seconds and 99% in 5 minutes. We are waiting for 10
            // seconds max so let's only expect 90% of entries to be visible.
            var minExpectedRequests = 9 * requests / 10;
            IList<Task<HttpResponseMessage>> responseTasks = new List<Task<HttpResponseMessage>>(300);
            using (var server = GetTestServer<TraceTestTimedBufferHighQpsApplication>(testServerConfigurator))
            using (var client = server.CreateClient())
            {
                for (int i = 0; i < requests; i++)
                {
                    responseTasks.Add(client.GetAsync(uri));
                }

                await Task.WhenAll(responseTasks);
            }

            var traces = TraceEntryPolling.Default.GetTraces(uri, _startTime, minEntries: minExpectedRequests);
            Assert.InRange(traces.Count(), minExpectedRequests, requests);
        }

        [Theory]
        [MemberData(nameof(ConfigurationData))]
        public async Task Trace_SizedBufferMedium_Stress(Action<IWebHostBuilder> testServerConfigurator)
        {
            var uri = $"/Trace/{_testId}";
            // Not the best ever stress test but we are limited by read quotas anyway.
            var requests = 300;
            IList<Task<HttpResponseMessage>> responseTasks = new List<Task<HttpResponseMessage>>(300);
            using (var server = GetTestServer<TraceTestMediumBufferHighQpsApplication>(testServerConfigurator))
            using (var client = server.CreateClient())
            {
                for (int i = 0; i < requests; i++)
                {
                    responseTasks.Add(client.GetAsync(uri));
                }

                await Task.WhenAll(responseTasks);
            }

            // We expect only around 85% of traces to have been sent to the backend because of the
            // size of the buffer, i.e. the last buffer won't flush because it won't reach the
            // maximum buffer size during this test. That's entirely expected.
            var minTraces = (int)((8.5 / 10) * requests);
            var traces = TraceEntryPolling.Default.GetTraces(uri, _startTime, minEntries: minTraces);
            Assert.InRange(traces.Count(), minTraces, requests);
        }

        private static void AssertNoTraceHeaders(HttpResponseMessage response)
        {
            // We check both Google and custom headers to make sure that
            // we are not adding anything (Google's in particular) by default.
            AssertNoGoogleTraceHeader(response);
            AssertNoCustomTraceHeader(response);
        }

        private static void AssertNoGoogleTraceHeader(HttpResponseMessage response) =>
            Assert.False(response.Headers.Contains(TraceHeaderContext.TraceHeader));

        private static void AssertNoCustomTraceHeader(HttpResponseMessage response)
        {
            Assert.False(response.Headers.Contains(CustromTraceIdHeader));
            Assert.False(response.Headers.Contains(CustromSpanIdHeader));
            Assert.False(response.Headers.Contains(CustromShouldTraceHeader));
        }

        private static void AssertGoogleTraceHeader(HttpResponseMessage response, string traceId, ulong? spanId, bool? shouldTrace)
        {
            string headerValue = Assert.Single(response.Headers.GetValues(TraceHeaderContext.TraceHeader));
            var header = TraceHeaderContext.FromHeader(headerValue);
            Assert.Equal(traceId, header.TraceId);
            Assert.Equal(spanId, header.SpanId);
            Assert.Equal(shouldTrace, header.ShouldTrace);

            AssertNoCustomTraceHeader(response);
        }

        private static void AssertCustomTraceHeader(HttpResponseMessage response, string traceId, ulong? spanId, bool? shouldTrace)
        {
            string actualTraceId = response.Headers.GetValues(CustromTraceIdHeader).FirstOrDefault();
            ulong? actualSpanId = response.Headers.GetValues(CustromSpanIdHeader).FirstOrDefault() is string rawSpanId ? ulong.Parse(rawSpanId) : (ulong?)null;
            bool? actualShouldTrace = response.Headers.GetValues(CustromShouldTraceHeader).FirstOrDefault() is string rawShouldTrace ? bool.Parse(rawShouldTrace) : (bool?)null;

            Assert.Equal(traceId, actualTraceId);
            Assert.Equal(spanId, actualSpanId);
            Assert.Equal(shouldTrace, actualShouldTrace);

            AssertNoGoogleTraceHeader(response);
        }

        private static void GoogleTraceContextEmitter(HttpRequestHeaders headers, string traceId, ulong? spanId, bool? shouldTrace) =>
            // To mimic incoming requests with the Google trace header.
            headers.Add(TraceHeaderContext.TraceHeader, TraceHeaderContext.Create(traceId, spanId, shouldTrace).ToString());

        private static void CustomTraceContextEmitter(HttpRequestHeaders headers, string traceId, ulong? spanId, bool? shouldTrace)
        {
            // To mimic incoming requests with the custom trace header.
            SetHeaderValue(CustromTraceIdHeader, traceId);
            SetHeaderValue(CustromSpanIdHeader, spanId?.ToString());
            SetHeaderValue(CustromShouldTraceHeader, shouldTrace?.ToString());

            void SetHeaderValue(string headerKey, string headerValue)
            {
                if (!string.IsNullOrEmpty(headerValue))
                {
                    headers.Add(headerKey, headerValue);
                }
            }
        }

        private static ITraceContext CustomTraceContextProvider(IServiceProvider serviceProvider)
        {
            var accessor = serviceProvider.GetRequiredService<IHttpContextAccessor>();

            string traceId = GetHeaderValue(CustromTraceIdHeader);
            ulong? spanId = GetHeaderValue(CustromSpanIdHeader) is string rawSpanId && ulong.TryParse(rawSpanId, out ulong parsedSpanId) ? parsedSpanId : (ulong?)null;
            bool? shouldTrace = GetHeaderValue(CustromShouldTraceHeader) is string rawShouldTrace && bool.TryParse(rawShouldTrace, out bool parsedShouldTrace) ? parsedShouldTrace : (bool?)null;

            return new SimpleTraceContext(traceId, spanId, shouldTrace);

            string GetHeaderValue(string headerKey)
            {
                string header = accessor.HttpContext?.Request?.Headers[headerKey];
                if (header == string.Empty)
                {
                    return null;
                }
                return header;
            }
        }

        private static void CustomTraceContextResponsePropagator(HttpResponse response, ITraceContext traceContext)
        {
            SetHeaderValue(CustromTraceIdHeader, traceContext?.TraceId);
            SetHeaderValue(CustromSpanIdHeader, traceContext?.SpanId?.ToString());
            SetHeaderValue(CustromShouldTraceHeader, traceContext?.ShouldTrace?.ToString());

            void SetHeaderValue(string headerKey, string headerValue)
            {
                if (!string.IsNullOrEmpty(headerValue))
                {
                    response.Headers.Append(headerKey, headerValue);
                }
            }
        }

        private static void CustomTraceContextOutgoingPropagator(HttpRequestMessage request, ITraceContext traceContext)
        {
            SetHeaderValue(CustromTraceIdHeader, traceContext?.TraceId);
            SetHeaderValue(CustromSpanIdHeader, traceContext?.SpanId?.ToString());
            SetHeaderValue(CustromShouldTraceHeader, traceContext?.ShouldTrace?.ToString());

            void SetHeaderValue(string headerKey, string headerValue)
            {
                if (!string.IsNullOrEmpty(headerValue))
                {
                    request.Headers.Add(headerKey, headerValue);
                }
            }
        }

        private static void ConfigureCustomTraceContext(IWebHostBuilder hostBuilder) =>
            hostBuilder.ConfigureServices(services => services
                .AddScoped(CustomTraceContextProvider)
                .AddSingleton(CustomTraceContextResponsePropagator)
                .AddSingleton(CustomTraceContextOutgoingPropagator));
    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app uses a size buffer (500 bytes) and will sample 1,000,000 QPS.
    /// </summary>
    public class TraceTestTinyBufferHighQpsApplication : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => 1_000_000;
        public override BufferOptions GetBufferOptions() => BufferOptions.SizedBuffer(500);
    }

    public class TraceTestTinyBufferHighQpsPropagateApplication : TraceTestTinyBufferHighQpsApplication
    {
        public override RetryOptions GetRetryOptions() => RetryOptions.NoRetry(ExceptionHandling.Propagate);
    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app uses a size buffer (default size / 4) and will sample 1,000,000 QPS.
    /// </summary>
    public class TraceTestMediumBufferHighQpsApplication : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => 1_000_000;
        public override BufferOptions GetBufferOptions() => BufferOptions.SizedBuffer(BufferOptions.DefaultBufferSize / 4);
    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app does not use a buffer and will sample .5 QPS.
    /// </summary>
    public class TraceTestNoBufferApplication : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => .5;
        public override BufferOptions GetBufferOptions() => BufferOptions.NoBuffer();
    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app does not use a buffer and will sample 1,000,000 QPS.
    /// This will allow all calls to be traced and push them to the Trace API immediately.
    /// </summary>
    public class TraceTestNoBufferHighQpsApplication : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => 1_000_000;
        public override BufferOptions GetBufferOptions() => BufferOptions.NoBuffer();
    }

    public class TraceTestFallbackPredicate : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => double.PositiveInfinity;
        public override BufferOptions GetBufferOptions() => BufferOptions.NoBuffer();
        public override RetryOptions GetRetryOptions() => RetryOptions.NoRetry(ExceptionHandling.Propagate);
        public override TraceDecisionPredicate GetTraceDecisionPredicate() => TraceDecisionPredicate.Create(request => request.Path.ToString().Contains("fallback"));
    }

    public class TraceTestCustomClient : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => double.PositiveInfinity;
        public override BufferOptions GetBufferOptions() => BufferOptions.NoBuffer();
        public override RetryOptions GetRetryOptions() => RetryOptions.NoRetry(ExceptionHandling.Propagate);
        public override TraceServiceClient GetTraceServiceClient() =>
            new TraceServiceClientBuilder
            {
                Credential = GoogleCredential.FromAccessToken("very_fake_token")
            }.Build();

    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app does not use a buffer and will sample 1,000,000 QPS.
    /// This will allow all calls to be traced and push them to the Trace API immediately.
    /// And it overrides the default trace name provider with a useless dummy
    /// </summary>
    public class TraceTestCustomNameProviderNoBufferHighQpsApplication : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => 1_000_000;
        public override BufferOptions GetBufferOptions() => BufferOptions.NoBuffer();

        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            services.Replace(
                new ServiceDescriptor(
                    typeof(ICloudTraceNameProvider),
                    typeof(DummyCloudTraceNameProvider),
                    ServiceLifetime.Transient)
            );
        }
    }

    /// <summary>
    /// Useless dummy cloud trace name provider that simply prefixes the
    /// route with /Dummy
    /// </summary>
    public class DummyCloudTraceNameProvider : ICloudTraceNameProvider
    {
        public Task<string> GetTraceNameAsync(HttpContext httpContext)
        {
            return Task.FromResult($"/Dummy{httpContext.Request.Path}");
        }
    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app does not use a buffer and traces will be pushed to the Trace API inmediately.
    /// This app will no trace unless requests have a trace header.
    /// </summary>
    public class TraceTestNoBufferLowQpsApplication : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => 0;
        public override BufferOptions GetBufferOptions() => BufferOptions.NoBuffer();
    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app uses a timed buffer and will sample 1,000,000 QPS.
    /// This will allow all calls to be traced.
    /// </summary>
    public class TraceTestTimedBufferHighQpsApplication : AbstractTraceTestApplication
    {
        public override BufferOptions GetBufferOptions() => BufferOptions.TimedBuffer(TimeSpan.FromMilliseconds(500));

        public override double GetSampleRate() => 1_000_000;
    }

    /// <summary>
    /// A base web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// </summary>
    public abstract class AbstractTraceTestApplication : BaseStartup
    {
        public abstract double GetSampleRate();

        public abstract BufferOptions GetBufferOptions();

        public virtual RetryOptions GetRetryOptions() => null;

        public virtual TraceDecisionPredicate GetTraceDecisionPredicate() => null;

        public virtual TraceServiceClient GetTraceServiceClient() => null;

        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddGoogleTraceForAspNetCore(new AspNetCoreTraceOptions
            {
                ServiceOptions = new Common.TraceServiceOptions
                {
                    ProjectId = TestEnvironment.GetTestProjectId(),
                    Options = TraceOptions.Create(GetSampleRate(), GetBufferOptions(), GetRetryOptions()),
                    Client = GetTraceServiceClient(),
                },
                TraceFallbackPredicate = GetTraceDecisionPredicate()
            });

            services
                .AddHttpClient("google", c => c.BaseAddress = new Uri("https://google.com/"))
                .AddOutgoingGoogleTraceHandler();

            base.ConfigureServices(services);
        }
    }

    [Route("_ah")]
    public class HealthCheckController : Controller
    {
        [HttpGet("health")]
        public string Health([FromServices] IManagedTracer tracer)
        {
            string message = "/_ah/health";
            using (tracer.StartSpan(message))
            {
                Thread.Sleep(10);
            }
            return message;
        }
    }

    /// <summary>
    /// A controller for the <see cref="AbstractTraceTestApplication"/> used to trace calls.
    /// </summary>
    public class TraceController : Controller
    {
        public TraceController() { }

        /// <summary>Sleeps for 10ms before returning.</summary>
        public string Index(string id)
        {
            Thread.Sleep(10);
            return nameof(Index);
        }

        /// <summary>Traces a 10ms sleep.</summary>
        public string Trace(string id, [FromServices] IManagedTracer tracer)
        {
            string message = EntryData.GetMessage(nameof(Trace), id);
            using (tracer.StartSpan(message))
            {
                Thread.Sleep(10);
            }
            return message;
        }

        /// <summary>Traces a 10ms sleep and adds an annotation.</summary>
        public string TraceLabels(string id, [FromServices] IManagedTracer tracer)
        {
            string message = EntryData.GetMessage(nameof(TraceLabels), id);
            using (tracer.StartSpan(message))
            {
                Thread.Sleep(10);
                tracer.AnnotateSpan(new Dictionary<string, string> { { TraceEntryData.TraceLabel, TraceEntryData.TraceLabelValue } });
                return message;
            }
        }

        /// <summary>Traces a 10ms sleep and adds a stacktrace.</summary>
        public string TraceStackTrace(string id, [FromServices] IManagedTracer tracer)
        {
            string message = EntryData.GetMessage(nameof(TraceStackTrace), id);
            using (tracer.StartSpan(message))
            {
                Thread.Sleep(10);
                tracer.SetStackTrace(TraceEntryData.CreateStackTrace());
            }
            return message;
        }

        public async Task<string> TraceOutgoingClientFactory(string id, [FromServices] IManagedTracer tracer, [FromServices] IHttpClientFactory httpClientFactory)
        {
            string message = EntryData.GetMessage(nameof(TraceOutgoingClientFactory), id);
            using (tracer.StartSpan(message))
            {
                var httpClient = httpClientFactory.CreateClient("google");
                await httpClient.GetAsync("");
            }
            return message;
        }

        public async Task<string> TraceOutgoingClientFactoryWithLabels(string id, [FromServices] IManagedTracer tracer, [FromServices] IHttpClientFactory httpClientFactory)
        {
            string message = EntryData.GetMessage(nameof(TraceOutgoingClientFactory), id);
            using (tracer.StartSpan(message))
            {
                var httpClient = httpClientFactory.CreateClient("outgoing_with_labels");
                await httpClient.GetAsync("");
            }
            return message;
        }

        /// <summary>Traces a 10ms sleep and throws an exception.</summary>
        public string ThrowException(string id, [FromServices] IManagedTracer tracer)
        {
            // Add a span with the test id to allow for the trace to be found.
            string message = EntryData.GetMessage(nameof(ThrowException), id);
            using (tracer.StartSpan(message))
            {
                Thread.Sleep(10);
                throw new DivideByZeroException();
            }
        }
    }

    public class PropagationController : Controller
    {
        public static TestServer FirstCallServer;
        public static TestServer SecondCallServer;

        private readonly IManagedTracer _tracer;
        private readonly DelegatingHandler _propagatingHandler;

        public PropagationController([FromServices] IManagedTracer tracer, [FromServices] IServiceProvider serviceProvider)
        {
            _tracer = tracer;
            var propagatingHandlerFactory = serviceProvider.GetRequiredService<OutgoingGoogleTraceHandlerFactory>();
            _propagatingHandler = propagatingHandlerFactory.Create(serviceProvider, labelsProvider: null);
        }

        public async Task<string> CreateFirstSpan(string id)
        {
            string createNoSpanUri = $"/Propagation/{nameof(CreateNoSpan)}/{id}";
            string createSecondSpanUri = $"/Propagation/{nameof(CreatesSecondSpan)}/{id}";
            string message = EntryData.GetMessage(nameof(CreateFirstSpan), id);

            // This will guarantee that our requests are to the first server instead
            // of to a published app in localhost.
            using (_propagatingHandler.InnerHandler = FirstCallServer.CreateHandler())
            using (var client = new HttpClient(_propagatingHandler, false))
            using (_tracer.StartSpan(message))
            {
                client.BaseAddress = new Uri("http://localhost");
                await client.GetAsync(createNoSpanUri);
                await client.GetAsync(createSecondSpanUri);
            }
            return message;
        }

        public async Task<string> CreatesSecondSpan(string id)
        {
            string uri = $"/Propagation/{nameof(CreateNoSpan)}/{id}";
            string message = EntryData.GetMessage(nameof(CreatesSecondSpan), id);

            // This will guarantee that our request is to the second server instead
            // of to a published app in localhost.
            using (_propagatingHandler.InnerHandler = SecondCallServer.CreateHandler())
            using (var client = new HttpClient(_propagatingHandler, false))
            using (_tracer.StartSpan(message))
            {
                client.BaseAddress = new Uri("http://localhost");
                await client.GetAsync(uri);
            }
            return message;
        }

        public string CreateNoSpan(string id)
        {
            string message = EntryData.GetMessage(nameof(CreateNoSpan), id);
            _tracer.AnnotateSpan(
                new Dictionary<string, string>
                {
                    { "Message", message }
                });
            return message;
        }
    }
}
