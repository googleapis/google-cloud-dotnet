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

using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.IntegrationTests
{
    public class TraceTest
    {
        private static readonly TraceIdFactory _traceIdFactory = TraceIdFactory.Create();
        private static readonly SpanIdFactory _spanIdFactory = SpanIdFactory.Create();

        private static readonly TraceEntryPolling _polling = new TraceEntryPolling();

        private readonly string _testId;
        private readonly Timestamp _startTime;

        public TraceTest()
        {
            // The rate limiter instance is static and only set once.  If we do not reset it at the
            // beginning of each tests the qps will not change.  This is dependent on the tests not
            // running in parallel.
            RateLimiter.Reset();

            _testId = IdGenerator.FromDateTime();
            _startTime = Timestamp.FromDateTime(DateTime.UtcNow);
        }

        [Fact]
        public async Task Trace()
        {
            var uri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.Trace), _testId);

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                var response = await client.GetAsync(uri);

                var trace = _polling.GetTrace(uri, _startTime);

                TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);
                TraceEntryVerifiers.AssertSpanLabelsContains(
                    trace.Spans.First(s => s.Name == uri), TraceEntryData.HttpGetSuccessLabels);

                Assert.False(response.Headers.Contains(TraceHeaderContext.TraceHeader));
            }
        }

        [Fact]
        public async Task Trace_Label()
        {
            var uri = $"/Trace/{nameof(TraceController.TraceLabels)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.TraceLabels), _testId);

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                await client.GetAsync(uri);

                var trace = _polling.GetTrace(uri, _startTime);

                TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);
                TraceEntryVerifiers.AssertSpanLabelsContains(trace.Spans.First(s => s.Name == childSpanName),
                    new Dictionary<string, string>
                    {
                        {TraceEntryData.TraceLabel, TraceEntryData.TraceLabelValue }
                    });
            }
        }

        [Fact]
        public async Task Trace_StackTrace()
        {
            var uri = $"/Trace/{nameof(TraceController.TraceStackTrace)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.TraceStackTrace), _testId);

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                await client.GetAsync(uri);

                var trace = _polling.GetTrace(uri, _startTime);

                TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);
                TraceEntryVerifiers.AssertContainsStackTrace(trace.Spans.First(s => s.Name == childSpanName),
                    nameof(TraceController), nameof(TraceController.TraceStackTrace),
                    nameof(TraceEntryData), nameof(TraceEntryData.CreateStackTrace));
            }
        }

        [Fact]
        public async Task Trace_Header()
        {
            string traceId = _traceIdFactory.NextId();
            ulong spanId = _spanIdFactory.NextId();

            var uri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.Trace), _testId);

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferLowQpsApplication>()))
            using (var client = server.CreateClient())
            {
                var header = TraceHeaderContext.Create(traceId, spanId, shouldTrace: true);
                client.DefaultRequestHeaders.Add(TraceHeaderContext.TraceHeader, header.ToString());

                var response = await client.GetAsync(uri);

                var trace = _polling.GetTrace(uri, _startTime);

                TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);

                Assert.Equal(traceId, trace.TraceId);
                var parentSpan = trace.Spans.First(s => s.Name == uri);
                Assert.Equal(spanId, parentSpan.ParentSpanId);

                Assert.True(response.Headers.Contains(TraceHeaderContext.TraceHeader));
                var returnedHeader = response.Headers.GetValues(TraceHeaderContext.TraceHeader).Single();
                var headerContext = TraceHeaderContext.FromHeader(returnedHeader);
                Assert.Equal(traceId, headerContext.TraceId);
                Assert.Equal(spanId, headerContext.SpanId);
                Assert.True(headerContext.ShouldTrace);
            }
        }

        [Fact]
        public void Trace_QPS()
        {
            var traceUri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";
            var traceLabelUri = $"/Trace/{nameof(TraceController.TraceLabels)}/{_testId}";

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferApplication>()))
            using (var client = server.CreateClient())
            {
                // Make two requests, one of the two should be traced as they both occur at nearly the same time.
                var traceTask = client.GetAsync(traceUri);
                var traceLabelsTask = client.GetAsync(traceLabelUri);
                Task.WaitAll(traceTask, traceLabelsTask);

                var trace = _polling.GetTrace(traceUri, _startTime);
                var traceLabel = _polling.GetTrace(traceLabelUri, _startTime);

                Assert.True((trace == null && traceLabel != null) || (trace != null && traceLabel == null));
            }
        }

        [Fact]
        public async Task Trace_Buffer()
        {
            var traceUri = $"/Trace/{nameof(TraceController.Trace)}/{_testId}";
            var traceStackTraceUri = $"/Trace/{nameof(TraceController.TraceStackTrace)}/{_testId}";

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                // Make a trace with a small span that will not cause the buffer to flush.
                await client.GetAsync(traceUri);
                Assert.Null(_polling.GetTrace(traceUri, _startTime, expectTrace: false));

                // Make a large trace that will flush the buffer.
                await client.GetAsync(traceStackTraceUri);

                Assert.NotNull(_polling.GetTrace(traceUri, _startTime));
                Assert.NotNull(_polling.GetTrace(traceStackTraceUri, _startTime));
            }
        }

        [Fact]
        public async Task Trace_Exception()
        {
            var uri = $"/Trace/{nameof(TraceController.ThrowException)}/{_testId}";
            var childSpanName = EntryData.GetMessage(nameof(TraceController.ThrowException), _testId);

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                await Assert.ThrowsAnyAsync<Exception>(() => client.GetAsync(uri));

                var trace = _polling.GetTrace(uri, _startTime);

                TraceEntryVerifiers.AssertParentChildSpan(trace, uri, childSpanName);
                TraceEntryVerifiers.AssertContainsStackTrace(trace.Spans.First(s => s.Name == uri),
                    nameof(TraceController), nameof(TraceController.ThrowException));
            }
        }

        [Fact]
        public async Task Trace_IgnoreHealthChecks()
        {
            var uri = "/_ah/health";

            using (var server = new TestServer(new WebHostBuilder().UseStartup<TraceTestNoBufferHighQpsApplication>()))
            using (var client = server.CreateClient())
            {
                await client.GetAsync(uri);

                var trace = _polling.GetTrace(uri, _startTime, expectTrace: false);
                Assert.Null(trace);
            }
        }
    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app uses a size buffer (500 bytes) and will sample 1000000 QPS.
    /// </summary>
    public class TraceTestBufferHighQpsApplication : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => 1000000;
        public override BufferOptions GetBufferOptions() => BufferOptions.SizedBuffer(500);
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
        public override double GetSampleRate() => 1000000;
        public override BufferOptions GetBufferOptions() => BufferOptions.NoBuffer();
    }

    /// <summary>
    /// A web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// This app does not use a buffer and will sample 0.0000001 QPS.
    /// This will allow no calls to be traced (unless they have a trace header) and
    /// push them to the Trace API immediately.
    /// </summary>
    public class TraceTestNoBufferLowQpsApplication : AbstractTraceTestApplication
    {
        public override double GetSampleRate() => 0.0000001;
        public override BufferOptions GetBufferOptions() => BufferOptions.NoBuffer();
    }

    /// <summary>
    /// A base web application to test <see cref="CloudTraceMiddleware"/> and associated classes.
    /// </summary>
    public abstract class AbstractTraceTestApplication
    {
        public abstract double GetSampleRate();

        public abstract BufferOptions GetBufferOptions();

        public void ConfigureServices(IServiceCollection services)
        {
            var traceOptions = Common.TraceOptions.Create(GetSampleRate(), GetBufferOptions());
            services.AddGoogleTrace(options =>
            {
                options.ProjectId = TestEnvironment.GetTestProjectId();
                options.Options = traceOptions;
            });
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseGoogleTrace();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Trace}/{action=Index}/{id}");

                routes.MapRoute(
                   name: "_ah",
                   template: "{controller=Health}/{action=Health}");
            });
        }
    }

    [Route("_ah")]
    public class HealthCheckController : Controller
    {
        [HttpGet(Name = "health")]
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
}
