// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Api;
using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Google.Cloud.Logging.Type;
using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using DateTime = System.DateTime;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3.IntegrationTests
#elif NETCOREAPP2_1 || NET461
namespace Google.Cloud.Diagnostics.AspNetCore.IntegrationTests
#else
#error unknown target framework
#endif
{
    using static TestServerHelpers;

    public class LoggingTest : IClassFixture<LogValidatingFixture>
    {
        // Used in tests that check logs are properly associated to traces.
        private static readonly TraceIdFactory s_traceIdFactory = TraceIdFactory.Create();
        private static readonly SpanIdFactory s_spanIdFactory = SpanIdFactory.Create();
        private static readonly TraceEntryPolling s_tracePolling = new TraceEntryPolling();

        private readonly LogValidatingFixture _fixture;

        public LoggingTest(LogValidatingFixture fixture)
        {
            _fixture = fixture;

            // The rate limiter instance is static and only set once.  If we do not reset it at the
            // beginning of each test the qps will not change.  This is dependent on the tests not
            // running in parallel, which they don't.
            RateLimiter.Reset();
        }

        [Fact]
        public async Task Logging_WarningPlus()
        {
            string testId = IdGenerator.FromGuid();

            using (TestServer server = GetTestServer<NoBufferWarningLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Debug/{testId}");
                await client.GetAsync($"/Main/Info/{testId}");
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");
            }

            // NoBufferLoggerTestApplication does not support debug or info logs.
            _fixture.AddValidator(testId, results =>
            {
                Assert.Equal(3, results.Count());
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Warning));
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Error));
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Critical));
            });
        }

        [Fact]
        public async Task Logging_ManyEntries()
        {
            string testId = IdGenerator.FromGuid();

            using (TestServer server = GetTestServer<NoBufferWarningLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                for (int i = 0; i < 250; i++)
                {
                    await client.GetAsync($"/Main/Debug/{testId}");
                    await client.GetAsync($"/Main/Info/{testId}");
                    await client.GetAsync($"/Main/Warning/{testId}");
                    await client.GetAsync($"/Main/Error/{testId}");
                    await client.GetAsync($"/Main/Critical/{testId}");
                    await client.GetAsync($"/Main/Exception/{testId}");
                }
            }
            _fixture.AddValidator(testId, results =>
            {
                Assert.Equal(1000, results.Count);
                Assert.All(results, l =>
                {
                    Assert.NotEqual(LogSeverity.Debug, l.Severity);
                    Assert.NotEqual(LogSeverity.Info, l.Severity);
                });
                Assert.Equal(250, results.Count(l => l.Severity == LogSeverity.Warning));
                Assert.Equal(250, results.Count(l => l.Severity == LogSeverity.Error));
                Assert.Equal(500, results.Count(l => l.Severity == LogSeverity.Critical)); // Exception and Critical
            });
        }

        [Fact]
        public async Task Logging_MonitoredResource()
        {
            string testId = IdGenerator.FromDateTime();

            using (TestServer server = GetTestServer<NoBufferResourceLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");

            }

            _fixture.AddValidator(testId, results =>
            {
                Assert.Equal(3, results.Count());
                var resourceType = NoBufferResourceLoggerTestApplication.Resource.Type;
                var buildResources = results.Where(e => e.Resource.Type.Equals(resourceType));
                Assert.Equal(3, buildResources.Count());
            });
        }

        [Fact]
        public async Task Logging_Scope()
        {
            string testId = IdGenerator.FromGuid();
            DateTime startTime = DateTime.UtcNow;

            using (var server = GetTestServer<NoBufferWarningLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Scope/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                var message = EntryData.GetMessage(nameof(MainController.Scope), testId);
                Assert.Equal(message, results.Single().JsonPayload.Fields["message"].StringValue);
                Assert.Contains("Scope", results.Single().JsonPayload.Fields["scope"].StringValue);
            });
        }

        [Fact]
        public async Task Logging_FormatParameter()
        {
            string testId = IdGenerator.FromGuid();
            DateTime startTime = DateTime.UtcNow;

            using (var server = GetTestServer<NoBufferWarningLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/FormatParameters/{testId}");
            }
            _fixture.AddValidator(testId, results =>
            {
                var message = EntryData.GetMessage(nameof(MainController.FormatParameters), testId);
                var json = results.Single().JsonPayload.Fields;
                Assert.Equal(message, json["message"].StringValue);
                var formatParams = json["format_parameters"]?.StructValue?.Fields;
                Assert.NotNull(formatParams);
                Assert.Equal(3, formatParams.Count);
                Assert.Equal(nameof(MainController.FormatParameters), formatParams["message"].StringValue);
                Assert.Equal(testId, formatParams["id"].StringValue);
                Assert.Equal("{message} - {id}", formatParams["{OriginalFormat}"].StringValue);
            });
        }

        [Fact]
        public async Task Logging_ScopeFormatParameter()
        {
            string testId = IdGenerator.FromGuid();

            using (var server = GetTestServer<NoBufferWarningLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/ScopeFormatParameters/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                var message = EntryData.GetMessage(nameof(MainController.ScopeFormatParameters), testId);
                var json = results.Single().JsonPayload.Fields;
                Assert.Equal(message, json["message"].StringValue);

                var parentScopes = json["parent_scopes"]?.ListValue?.Values;
                Assert.NotNull(parentScopes);
                var expectedScope = Value.ForStruct(new Struct
                {
                    Fields =
                    {
                        { "id", Value.ForString(testId) },
                        { "{OriginalFormat}", Value.ForString(nameof(MainController.ScopeFormatParameters) + " - {id}") }
                    }
                });
                Assert.Single(parentScopes, expectedScope);
            });
        }

        [Fact]
        public async Task Logging_AugmentedWithLabels()
        {
            string testId = IdGenerator.FromGuid();

            using (var server = GetTestServer<NoBufferWarningLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/AugmentWithLabels/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                var message = EntryData.GetMessage(nameof(MainController.AugmentWithLabels), testId);
                var entry = results.Single();
                var json = entry.JsonPayload.Fields;
                Assert.Equal(message, json["message"].StringValue);

                Assert.Equal(1, entry.Labels.Count);
                Assert.Equal(testId, entry.Labels["test_id"]);
            });
        }

        [Fact]
        public async Task Logging_Trace_FromHeader_Implicit()
        {
            string traceId = s_traceIdFactory.NextId();
            ulong spanId = s_spanIdFactory.NextId();
            string testId = IdGenerator.FromGuid();

            using (var server = GetTestServer<NoBufferWarningLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                client.DefaultRequestHeaders.Add(TraceHeaderContext.TraceHeader,
                    TraceHeaderContext.Create(traceId, spanId, true).ToString());
                await client.GetAsync($"/Main/Critical/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                // We only have one log entry.
                LogEntry entry = Assert.Single(results);

                // And the resource name of the trace associated to it points to the trace
                // we specified on the header.
                Assert.Contains(TestEnvironment.GetTestProjectId(), entry.Trace);
                Assert.Contains(traceId, entry.Trace);

                // Let's get our trace.
                var trace = s_tracePolling.GetTrace(traceId);
                Assert.NotNull(trace);

                // The span associated to our entry needs to be part of that trace.
                // (We created this span on the middleware to encompass the whole request)
                var entrySpan = Assert.Single(trace.Spans, s => EntryData.SpanIdToHex(s.SpanId) == entry.SpanId);
                // And its parent needs to be the span specified in the header
                Assert.Equal(spanId, entrySpan.ParentSpanId);
            });
        }

        [Fact]
        public async Task Logging_Trace_FromHeader()
        {
            string traceId = s_traceIdFactory.NextId();
            ulong spanId = s_spanIdFactory.NextId();
            string testId = IdGenerator.FromGuid();

            using (var server = GetTestServer<NoBufferWarningLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                client.DefaultRequestHeaders.Add(TraceHeaderContext.TraceHeader,
                    TraceHeaderContext.Create(traceId, spanId, true).ToString());
                await client.GetAsync($"/Main/{nameof(MainController.LogsInOneSpan)}/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                // We only have one log entry.
                LogEntry entry = Assert.Single(results);

                // And the resource name of the trace associated to it points to the trace
                // we specified on the header.
                Assert.Contains(TestEnvironment.GetTestProjectId(), entry.Trace);
                Assert.Contains(traceId, entry.Trace);

                // Let's get our trace.
                var trace = s_tracePolling.GetTrace(traceId);
                Assert.NotNull(trace);

                // The span associated to our entry needs to be part of that trace.
                // (We created this span on the action call)
                var entrySpan = Assert.Single(trace.Spans, s => EntryData.SpanIdToHex(s.SpanId) == entry.SpanId);
                // And its grandparent needs to be the span specified in the header
                // (We created a span in the middleware that will encompass the whole request).
                var parentSpan = Assert.Single(trace.Spans, s => s.SpanId == entrySpan.ParentSpanId);
                Assert.Equal(spanId, parentSpan.ParentSpanId);
            });
        }

        [Fact]
        public async Task Logging_Trace_FromHeader_MultipleSpans()
        {
            string traceId = s_traceIdFactory.NextId();
            ulong spanId = s_spanIdFactory.NextId();
            string testId = IdGenerator.FromGuid();

            using (var server = GetTestServer<NoBufferWarningLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                client.DefaultRequestHeaders.Add(TraceHeaderContext.TraceHeader,
                    TraceHeaderContext.Create(traceId, spanId, true).ToString());
                await client.GetAsync($"/Main/{nameof(MainController.LogsInDifferentSpans)}/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                // Span: span-1
                //       Log: span-1
                //       Span: span-1-2
                //             Log: span-1-2
                // Span: span-2
                //       Log: span-2

                string projectId = TestEnvironment.GetTestProjectId();

                // We have 3 logs.
                Assert.Equal(3, results.Count);
                // And the resource name of the trace associated to all of them points to the trace
                // we specified on the header.
                Assert.All(results, entry =>
                {
                    Assert.Contains(projectId, entry.Trace);
                    Assert.Contains(traceId, entry.Trace);
                });

                // Let's get our trace.
                var trace = s_tracePolling.GetTrace(traceId);
                Assert.NotNull(trace);

                // Let's check that all the entries are associated to the correct spans.
                var logEntry1 = Assert.Single(results, e => e.JsonPayload.Fields["message"].StringValue.EndsWith("log-1"));
                var logEntry12 = Assert.Single(results, e => e.JsonPayload.Fields["message"].StringValue.EndsWith("log-1-2"));
                var logEntry2 = Assert.Single(results, e => e.JsonPayload.Fields["message"].StringValue.EndsWith("log-2"));

                var span1 = Assert.Single(trace.Spans, s => EntryData.SpanIdToHex(s.SpanId) == logEntry1.SpanId);
                Assert.EndsWith("span-1", span1.Name);
                var span12 = Assert.Single(trace.Spans, s => EntryData.SpanIdToHex(s.SpanId) == logEntry12.SpanId);
                Assert.EndsWith("span-1-2", span12.Name);
                var span2 = Assert.Single(trace.Spans, s => EntryData.SpanIdToHex(s.SpanId) == logEntry2.SpanId);
                Assert.EndsWith("span-2", span2.Name);

                // Let's check that the spans are correctly created and descend from the span we specified in the header.
                // span-1-2 is a child of span-1
                Assert.Equal(span12.ParentSpanId, span1.SpanId);
                // span-1 and span-2 have the same parent
                Assert.Equal(span1.ParentSpanId, span2.ParentSpanId);
                // The grandparent of span-1 and span-2 is the span we specified on the header.
                var parentSpan = Assert.Single(trace.Spans, s => s.SpanId == span1.ParentSpanId);
                Assert.Equal(spanId, parentSpan.ParentSpanId);
            });
        }

        [Fact]
        public async Task Logging_Trace_Implicit()
        {
            Timestamp startTime = Timestamp.FromDateTime(DateTime.UtcNow);
            string testId = IdGenerator.FromGuid();

            string url = $"/Main/Critical/{testId}";
            using (var server = GetTestServer<NoBufferWarningLoggerTracesAllTestApplication>())
            using (var client = server.CreateClient())
            {
                await client.GetAsync(url);
            }

            _fixture.AddValidator(testId, results =>
            {
                // Let's get our trace.
                var trace = s_tracePolling.GetTrace(url, startTime);
                Assert.NotNull(trace);

                // We only have one log entry.
                LogEntry entry = Assert.Single(results);

                // And the resource name of the trace associated to it points to the trace
                // created during the call.
                Assert.Contains(TestEnvironment.GetTestProjectId(), entry.Trace);
                Assert.Contains(trace.TraceId, entry.Trace);

                // The span associated to our entry needs to be part of that trace.
                // (We created this span on the middleware to encompass the whole request)
                var entrySpan = Assert.Single(trace.Spans, s => EntryData.SpanIdToHex(s.SpanId) == entry.SpanId);
                // And it shouldn't have a span parent.
                Assert.Equal((ulong)0, entrySpan.ParentSpanId);
            });
        }

        [Fact]
        public async Task Logging_Trace()
        {
            Timestamp startTime = Timestamp.FromDateTime(DateTime.UtcNow);
            string testId = IdGenerator.FromGuid();

            string spanPrefix;
            using (var server = GetTestServer<NoBufferWarningLoggerTracesAllTestApplication>())
            using (var client = server.CreateClient())
            {
                spanPrefix = await client.GetStringAsync($"/Main/{nameof(MainController.LogsInOneSpan)}/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                // Let's get our trace.
                var trace = s_tracePolling.GetTrace(spanPrefix, startTime);
                Assert.NotNull(trace);

                // We only have one log entry.
                LogEntry entry = Assert.Single(results);

                // And the resource name of the trace associated to it points to the trace
                // created during the call.
                Assert.Contains(TestEnvironment.GetTestProjectId(), entry.Trace);
                Assert.Contains(trace.TraceId, entry.Trace);

                // The span associated to our entry needs to be part of that trace.
                // (We created this span on the action call)
                var entrySpan = Assert.Single(trace.Spans, s => EntryData.SpanIdToHex(s.SpanId) == entry.SpanId);
                // And its parent is a span we create on the middleware to encompass the whole request
                Assert.NotEqual((ulong)0, entrySpan.ParentSpanId);
            });
        }

        [Fact]
        public async Task Logging_Trace_MultipleSpans()
        {
            Timestamp startTime = Timestamp.FromDateTime(DateTime.UtcNow);
            string testId = IdGenerator.FromGuid();

            string spanPrefix;
            using (var server = GetTestServer<NoBufferWarningLoggerTracesAllTestApplication>())
            using (var client = server.CreateClient())
            {
                spanPrefix = await client.GetStringAsync($"/Main/{nameof(MainController.LogsInDifferentSpans)}/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                // Span: span-1
                //       Log: span-1
                //       Span: span-1-2
                //             Log: span-1-2
                // Span: span-2
                //       Log: span-2

                string projectId = TestEnvironment.GetTestProjectId();

                // Let's get our trace.
                var trace = s_tracePolling.GetTrace(spanPrefix, startTime);
                Assert.NotNull(trace);

                // We have 3 logs.
                Assert.Equal(3, results.Count);
                // And the resource name of the trace associated to all of them points to the trace
                // created during the call.
                Assert.All(results, entry =>
                {
                    Assert.Contains(projectId, entry.Trace);
                    Assert.Contains(trace.TraceId, entry.Trace);
                });

                // Let's check that all the entries are associated to the correct spans.
                var logEntry1 = Assert.Single(results, e => e.JsonPayload.Fields["message"].StringValue.EndsWith("log-1"));
                var logEntry12 = Assert.Single(results, e => e.JsonPayload.Fields["message"].StringValue.EndsWith("log-1-2"));
                var logEntry2 = Assert.Single(results, e => e.JsonPayload.Fields["message"].StringValue.EndsWith("log-2"));

                var span1 = Assert.Single(trace.Spans, s => EntryData.SpanIdToHex(s.SpanId) == logEntry1.SpanId);
                Assert.EndsWith("span-1", span1.Name);
                var span12 = Assert.Single(trace.Spans, s => EntryData.SpanIdToHex(s.SpanId) == logEntry12.SpanId);
                Assert.EndsWith("span-1-2", span12.Name);
                var span2 = Assert.Single(trace.Spans, s => EntryData.SpanIdToHex(s.SpanId) == logEntry2.SpanId);
                Assert.EndsWith("span-2", span2.Name);

                // Let's check that the spans are correctly created.
                // span-1-2 is a child of span-1
                Assert.Equal(span12.ParentSpanId, span1.SpanId);
                // span-1 and span-2 have the same parent
                Assert.Equal(span1.ParentSpanId, span2.ParentSpanId);
                // The parent of span-1 and span-2 exists, it's the span we created on the middleware
                // to encompass the whole request.
                Assert.NotEqual((ulong)0, span1.ParentSpanId);
            });
        }

        public static object[][] ExternalTraceBuilders
        {
            get
            {
                return new object[][]
                {
                    new object[] { GetTestServer<ObsoleteNoBufferWarningLoggerExternalTraceTestApplication>() },
                    new object[] { GetTestServer<ObsoleteExternalTracingTestApplication>() },
                    new object[] { GetTestServer<NoBufferWarningLoggerExternalTraceTestApplication>() },
                    new object[] { GetTestServer<ExternalTracingTestApplication>() }
                };
            }
        }

        [Theory]
        [MemberData(nameof(ExternalTraceBuilders))]
        public async Task Logging_Trace_External_OneEntry(TestServer server)
        {
            Timestamp startTime = Timestamp.FromDateTime(DateTime.UtcNow);
            string testId = IdGenerator.FromGuid();

            string url = $"/Main/Critical/{testId}";
            using (var client = server.CreateClient())
            {
                await client.GetAsync(url);
            }
            server.Dispose();

            _fixture.AddValidator(testId, results =>
            {
                // We only have one log entry.
                LogEntry entry = Assert.Single(results);

                // And the resource name of the trace associated to it contains the external trace id.
                Assert.Contains(TestEnvironment.GetTestProjectId(), entry.Trace);
                Assert.Contains("105445aa7843bc8bf206b12000100f00", entry.Trace);

                // The span associated to our entry is the external span.
                Assert.Equal("0000000000000001", entry.SpanId);
            });
        }

        [Theory]
        [MemberData(nameof(ExternalTraceBuilders))]
        public async Task Logging_Trace_External_MultipleEntries(TestServer server)
        {
            Timestamp startTime = Timestamp.FromDateTime(DateTime.UtcNow);
            string testId = IdGenerator.FromGuid();

            string url = $"/Main/LogsThreeEntries/{testId}";
            using (var client = server.CreateClient())
            {
                await client.GetAsync(url);
            }
            server.Dispose();

            _fixture.AddValidator(testId, results =>
            {
                string projectId = TestEnvironment.GetTestProjectId();

                // We have three log entries.
                Assert.Equal(3, results.Count);

                // And the resource name of the trace associated to them contains the external trace id.
                Assert.All(results, entry =>
                {
                    Assert.Contains(projectId, entry.Trace);
                    Assert.Contains("105445aa7843bc8bf206b12000100f00", entry.Trace);
                });

                // The span associated to our entry is the external span, and is the same span number
                // as the log entry.
                Assert.All(results, entry => Assert.Equal($"{ExpectedSpanId(entry):x16}", entry.SpanId));
                static ulong ExpectedSpanId(LogEntry entry) =>
                   Convert.ToUInt64(int.Parse($"{entry.JsonPayload.Fields["message"].StringValue.Last()}"));
            });
        }

        [Fact]
        public async Task Logging_Trace_GoogleExternal()
        {
            Timestamp startTime = Timestamp.FromDateTime(DateTime.UtcNow);
            string testId = IdGenerator.FromGuid();

            string traceId = "105445aa7843bc8bf206b12000100f00";
            ulong spanId = 0x12D687;
            // The spanId set on the log entry should confirm to x16
            // format so that the backend can really associate the log entry
            // to the span.
            string expectedSpanId = "000000000012d687";

            string url = $"/Main/Critical/{testId}";
            using (var server = GetTestServer<GoogleTraceAsExternalTracingTestApplication>())
            using (var client = server.CreateClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);
                // Set the Google tracing header so that it can be read by the
                // GoogleTraceProvider. This is the same that GCP would do.
                // Note that we are actually not creating the trace on Google Trace,
                // which is fine for the purposes of this test.
                string traceHeaderValue = $"{traceId}/{spanId};o=1";
                request.Headers.Add("X-Cloud-Trace-Context", traceHeaderValue);
                await client.SendAsync(request);
            }

            _fixture.AddValidator(testId, results =>
            {
                // We only have one log entry.
                LogEntry entry = Assert.Single(results);

                // And the resource name of the trace associated to it contains the external trace id.
                Assert.Contains(TestEnvironment.GetTestProjectId(), entry.Trace);
                Assert.Contains(traceId, entry.Trace);

                // The span associated to our entry is the external span.
                Assert.Equal(expectedSpanId, entry.SpanId);
            });
        }

        [Fact]
        public async Task Logging_Trace_GoogleExternal_NoTraceHeader()
        {
            Timestamp startTime = Timestamp.FromDateTime(DateTime.UtcNow);
            string testId = IdGenerator.FromGuid();

            string url = $"/Main/Critical/{testId}";
            using (var server = GetTestServer<GoogleTraceAsExternalTracingTestApplication>())
            using (var client = server.CreateClient())
            {
                await client.GetAsync(url);
            }

            _fixture.AddValidator(testId, results =>
            {
                // We only have one log entry.
                LogEntry entry = Assert.Single(results);

                // The entry does not have any trace information.
                // These are empty strings instead of null.
                Assert.Equal("", entry.Trace);
                Assert.Equal("", entry.SpanId);
            });
        }

        [Fact]
        public async Task Logging_Labels()
        {
            string testId = IdGenerator.FromGuid();
            DateTime startTime = DateTime.UtcNow;

            using (var server = GetTestServer<WarningWithLabelsLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Warning/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                var entry = results.Single();
                Assert.Equal(4, entry.Labels.Count);
                Assert.Equal("some-value", entry.Labels["some-key"]);
                Assert.Equal("Hello, World!", entry.Labels["Foo"]);
                Assert.Equal("Hello, World!", entry.Labels["Bar"]);
                Assert.NotEmpty(entry.Labels["trace_identifier"]);
            });
        }

        [Fact]
        public async Task Logging_DiagnosticsOutput()
        {
            StringWriter writer;
            using (var server = GetTestServer<DiagnosticsOutputLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                writer = GetServices(server).GetRequiredService<TextWriter>() as StringWriter;
                Assert.NotNull(writer);

                await client.GetAsync($"/Main/Warning/{IdGenerator.FromGuid()}");
                await client.GetAsync($"/Main/Warning/{IdGenerator.FromGuid()}");
                await client.GetAsync($"/Main/Warning/{IdGenerator.FromGuid()}");
            }

            // Despite multiple log entries (several per call), we should only have one diagnostic log.
            var diagnostics = writer.ToString();
            var lines = diagnostics.Split('\n');
            Assert.Equal(2, lines.Length);
            Assert.Contains("GoogleLogger will write logs", lines[0]);
            Assert.Empty(lines[1]);
        }

        [Fact]
        public async Task Logging_NoServiceProvider()
        {
            string testId = IdGenerator.FromDateTime();

            var builder = GetHostBuilder<VanillaApplication>(webHostBuilder =>
                webHostBuilder.ConfigureLogging(loggingBuilder =>
                {
                    var projectId = TestEnvironment.GetTestProjectId();
                    var provider = GoogleLoggerProvider.Create(serviceProvider: null, projectId, LoggerOptions.Create(LogLevel.Warning));
                    loggingBuilder.AddProvider(provider);
                }));
            using (TestServer server = GetTestServer(builder))
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Warning/{testId}");
                await client.GetAsync($"/Main/Error/{testId}");
                await client.GetAsync($"/Main/Critical/{testId}");

            }
            _fixture.AddValidator(testId, results =>
            {
                Assert.Equal(3, results.Count());
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Warning));
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Error));
                Assert.NotNull(results.FirstOrDefault(l => l.Severity == LogSeverity.Critical));
            });
        }

        [Fact]
        public async Task Logging_ServiceContext()
        {
            string testId = IdGenerator.FromGuid();
            DateTime startTime = DateTime.UtcNow;

            using (var server = GetTestServer<NoBufferWarningServiceContextLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Warning/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                var jsonFields = results.Single().JsonPayload.Fields;
                Assert.Equal("my.test.service", jsonFields["serviceContext"].StructValue.Fields["service"].StringValue);
                Assert.Equal("v1.0.0-alpha01", jsonFields["serviceContext"].StructValue.Fields["version"].StringValue);
            });
        }

        [Fact]
        public async Task Logging_ServiceContext_Exception()
        {
            string testId = IdGenerator.FromGuid();
            DateTime startTime = DateTime.UtcNow;

            using (var server = GetTestServer<NoBufferWarningServiceContextLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Exception/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                var jsonFields = results.Single().JsonPayload.Fields;
                Assert.Equal("my.test.service", jsonFields["serviceContext"].StructValue.Fields["service"].StringValue);
                Assert.Equal("v1.0.0-alpha01", jsonFields["serviceContext"].StructValue.Fields["version"].StringValue);
            });
        }

        [Fact]
        public async Task Logging_ServiceContext_ServiceNameOnly_Exception()
        {
            string testId = IdGenerator.FromGuid();
            DateTime startTime = DateTime.UtcNow;

            using (var server = GetTestServer<NoBufferWarningServiceContextServiceNameOnlyLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Exception/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                var jsonFields = results.Single().JsonPayload.Fields;
                Assert.Equal("my.test.service", jsonFields["serviceContext"].StructValue.Fields["service"].StringValue);
                Assert.False(jsonFields["serviceContext"].StructValue.Fields.ContainsKey("version"));
            });
        }

        [Fact]
        public async Task Logging_ServiceContext_VersionOnly_Exception()
        {
            string testId = IdGenerator.FromGuid();
            DateTime startTime = DateTime.UtcNow;

            using (var server = GetTestServer<NoBufferWarningServiceContextVersionOnlyLoggerTestApplication>())
            using (var client = server.CreateClient())
            {
                await client.GetAsync($"/Main/Exception/{testId}");
            }

            _fixture.AddValidator(testId, results =>
            {
                var jsonFields = results.Single().JsonPayload.Fields;
                Assert.False(jsonFields["serviceContext"].StructValue.Fields.ContainsKey("service"));
                Assert.Equal("v1.0.0-alpha01", jsonFields["serviceContext"].StructValue.Fields["version"].StringValue);
            });
        }
    }

    /// <summary>
    /// Application that doesn't perform any diagnostic configuration itself.
    /// </summary>
    public class VanillaApplication : BaseStartup
    { }

    /// <summary>
    /// A simple web application to test the <see cref="GoogleLogger"/> and associated classes.
    /// </summary>
    public abstract class LoggerNoTracingActivatedTestApplication : BaseStartup
    {
        protected readonly string _projectId = TestEnvironment.GetTestProjectId();

        public override void ConfigureServices(IServiceCollection services) => base.ConfigureServices(services.AddHttpContextAccessor());

        public override void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory) =>
            base.Configure(app, loggerFactory.AddGoogle(
                app.ApplicationServices, _projectId, LoggerOptions.Create(logLevel: LogLevel.Warning, bufferOptions: BufferOptions.NoBuffer())));
    }

    public class ObsoleteExternalTracingTestApplication : LoggerNoTracingActivatedTestApplication
    {
        public override void ConfigureServices(IServiceCollection services) =>
#pragma warning disable CS0618 // Type or member is obsolete
            base.ConfigureServices(services.AddSingleton<IExternalTraceProvider, SpanCountingExternalTraceProvider>());
#pragma warning restore CS0618 // Type or member is obsolete
    }

    public class ExternalTracingTestApplication : LoggerNoTracingActivatedTestApplication
    {
        public override void ConfigureServices(IServiceCollection services) =>
            base.ConfigureServices(services
                // We start counting at -1 here because of the call we make on the middleware to
                // try and obtain the context. We don't care about that one.
                .AddSingleton(new SpanCountingITraceContextFactory(0))
                .AddTransient(sp => sp.GetRequiredService<SpanCountingITraceContextFactory>().GetCurrentTraceContext()));
    }

    public class GoogleTraceAsExternalTracingTestApplication : LoggerNoTracingActivatedTestApplication
    {
        public override void ConfigureServices(IServiceCollection services) =>
            base.ConfigureServices(services.TryAddGoogleTraceContextProvider());
    }

    /// <summary>
    /// A simple web application to test the <see cref="GoogleLogger"/> and associated classes.
    /// </summary>
    public abstract class LoggerTestApplication : BaseStartup
    {
        protected readonly string _projectId = TestEnvironment.GetTestProjectId();
        protected readonly double _traceQps;

        public LoggerTestApplication()
            // Don't actually trace anything unless there's a header that forces tracing.
            : this(0)
        { }

        public LoggerTestApplication(double traceQps) => _traceQps = traceQps;

        public override void ConfigureServices(IServiceCollection services) =>
            base.ConfigureServices(services
                .AddHttpContextAccessor()
                .AddGoogleTrace(options =>
                {
                    options.ProjectId = _projectId;
                    options.Options = TraceOptions.Create(_traceQps, BufferOptions.NoBuffer(), RetryOptions.NoRetry(ExceptionHandling.Propagate));
                }));

        public override void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory) =>
            base.Configure(app.UseGoogleTrace(), loggerFactory);
    }

    /// <summary>
    /// An application that has a <see cref="GoogleLogger"/> with no buffer that will accept all logs
    /// of level warning or above.
    /// </summary>
    public class NoBufferWarningLoggerTestApplication : LoggerTestApplication
    {
        public NoBufferWarningLoggerTestApplication()
            : base()
        { }

        public NoBufferWarningLoggerTestApplication(double traceQps)
            : base(traceQps)
        { }

        public override void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory) =>
            base.Configure(app, loggerFactory.AddGoogle(
                app.ApplicationServices, _projectId, LoggerOptions.Create(logLevel: LogLevel.Warning, bufferOptions: BufferOptions.NoBuffer())));
    }

    public class NoBufferWarningLoggerTracesAllTestApplication : NoBufferWarningLoggerTestApplication
    {
        public NoBufferWarningLoggerTracesAllTestApplication()
            : base(double.PositiveInfinity)
        { }
    }

    public class ObsoleteNoBufferWarningLoggerExternalTraceTestApplication : NoBufferWarningLoggerTestApplication
    {
        public override void ConfigureServices(IServiceCollection services) =>
#pragma warning disable CS0618 // Type or member is obsolete
            base.ConfigureServices(services.AddSingleton<IExternalTraceProvider>(new SpanCountingExternalTraceProvider()));
#pragma warning restore CS0618 // Type or member is obsolete
    }

    public class NoBufferWarningLoggerExternalTraceTestApplication : NoBufferWarningLoggerTestApplication
    {
        public override void ConfigureServices(IServiceCollection services) =>
            base.ConfigureServices(services
                // We start counting at -1 here because of the call we make on the middleware to
                // try and obtain the context. We don't care about that one.
                .AddSingleton(new SpanCountingITraceContextFactory(-1))
                .AddTransient(sp => sp.GetRequiredService<SpanCountingITraceContextFactory>().GetCurrentTraceContext()));
    }

    /// <summary>
    /// An application that has a <see cref="GoogleLogger"/> with no buffer that will accept all logs
    /// of level warning or above and has a <see cref="MonitoredResource"/> of 'build'.
    /// </summary>
    public class NoBufferResourceLoggerTestApplication : LoggerTestApplication
    {
        public static readonly MonitoredResource Resource = new MonitoredResource
        {
            Type = "build",
            Labels =
            {
                { "project_id", "some-pid" },
                { "build_id", "some-build-id" }
            }
        };

        public override void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory) =>
            base.Configure(app, loggerFactory.AddGoogle(
                app.ApplicationServices,
                _projectId,
                LoggerOptions.Create(logLevel: LogLevel.Warning, monitoredResource: Resource, bufferOptions: BufferOptions.NoBuffer())));
    }

    /// <summary>
    /// An application that has a <see cref="GoogleLogger"/> and a <see cref="Common.ILogEntryLabelProvider"/>,
    /// that accept all logs of level warning or above.
    /// </summary>
    public class WarningWithLabelsLoggerTestApplication : LoggerTestApplication
    {
        public override void ConfigureServices(IServiceCollection services) =>
            base.ConfigureServices(services
                .AddLogEntryLabelProvider<FooLogEntryLabelProvider>()
                .AddLogEntryLabelProvider<TraceIdLogEntryLabelProvider>()
#pragma warning disable CS0618 // Type or member is obsolete
                .AddSingleton<ILogEntryLabelProvider, BarLogEntryLabelProvider>());
#pragma warning restore CS0618 // Type or member is obsolete

        public override void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory) =>
            base.Configure(app, loggerFactory.AddGoogle(
                app.ApplicationServices,
                _projectId,
                LoggerOptions.Create(
                    logLevel: LogLevel.Warning,
                    labels: new Dictionary<string, string> { { "some-key", "some-value" } },
                    bufferOptions: BufferOptions.NoBuffer())));
    }

    public class DiagnosticsOutputLoggerTestApplication : LoggerTestApplication
    {
        public override void ConfigureServices(IServiceCollection services) =>
            base.ConfigureServices(services.AddSingleton<TextWriter, StringWriter>());

        public override void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory) =>
            base.Configure(app, loggerFactory.AddGoogle(
                app.ApplicationServices, _projectId, LoggerOptions.Create(loggerDiagnosticsOutput: app.ApplicationServices.GetRequiredService<TextWriter>())));
    }

    /// <summary>
    /// An application that has a <see cref="GoogleLogger"/> with no buffer that will accept all logs
    /// of level warning or above and sets a service name and version that will be included as the serviceContext
    /// field in the json payload.
    /// </summary>
    public class NoBufferWarningServiceContextLoggerTestApplication : LoggerTestApplication
    {
        public override void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory) =>
            base.Configure(app, loggerFactory.AddGoogle(
                app.ApplicationServices,
                _projectId,
                LoggerOptions.CreateWithServiceContext(
                    logLevel: LogLevel.Warning,
                    bufferOptions: BufferOptions.NoBuffer(),
                    serviceName: "my.test.service",
                    version: "v1.0.0-alpha01")));
    }

    /// <summary>
    /// An application that has a <see cref="GoogleLogger"/> with no buffer that will accept all logs
    /// of level warning or above and sets a service name that will be included as the serviceContext
    /// field in the json payload.
    /// </summary>
    public class NoBufferWarningServiceContextServiceNameOnlyLoggerTestApplication : LoggerTestApplication
    {
        public override void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory) =>
            base.Configure(app, loggerFactory.AddGoogle(
                app.ApplicationServices,
                _projectId,
                LoggerOptions.CreateWithServiceContext(
                    logLevel: LogLevel.Warning,
                    bufferOptions: BufferOptions.NoBuffer(),
                    serviceName: "my.test.service")));
    }

    /// <summary>
    /// An application that has a <see cref="GoogleLogger"/> with no buffer that will accept all logs
    /// of level warning or above and sets a version that will be included as the serviceContext
    /// field in the json payload.
    /// </summary>
    public class NoBufferWarningServiceContextVersionOnlyLoggerTestApplication : LoggerTestApplication
    {
        public override void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory) =>
            base.Configure(app, loggerFactory.AddGoogle(
                app.ApplicationServices,
                _projectId,
                LoggerOptions.CreateWithServiceContext(
                    logLevel: LogLevel.Warning,
                    bufferOptions: BufferOptions.NoBuffer(),
                    version: "v1.0.0-alpha01")));
    }

    /// <summary>
    /// A controller for the <see cref="LoggerTestApplication"/> used to generate simple log entries.
    /// </summary>
    public class MainController : Controller
    {
        private readonly ILogger _logger;

        public MainController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger(nameof(_logger));
        }

        public string Debug(string id)
        {
            string message = EntryData.GetMessage(nameof(Debug), id);
            _logger.LogDebug(message);
            return message;
        }

        public string Info(string id)
        {
            string message = EntryData.GetMessage(nameof(Info), id);
            _logger.LogInformation(message);
            return message;
        }

        public string Warning(string id)
        {
            string message = EntryData.GetMessage(nameof(Warning), id);
            _logger.LogWarning(message);
            return message;
        }

        public string Error(string id)
        {
            string message = EntryData.GetMessage(nameof(Error), id);
            _logger.LogError(message);
            return message;
        }

        public string Critical(string id)
        {
            string message = EntryData.GetMessage(nameof(Critical), id);
            _logger.LogCritical(message);
            return message;
        }

        public string Scope(string id)
        {
            using (_logger.BeginScope(nameof(Scope)))
            {
                string message = EntryData.GetMessage(nameof(Scope), id);
                _logger.LogCritical(message);
                return message;
            }
        }

        public string FormatParameters(string id)
        {
            string message = "{message} - {id}";
            _logger.LogCritical(message, nameof(FormatParameters), id);
            return message;
        }

        public string ScopeFormatParameters(string id)
        {
            using (_logger.BeginScope(nameof(ScopeFormatParameters) + " - {id}", id))
            {
                string message = EntryData.GetMessage(nameof(ScopeFormatParameters), id);
                _logger.LogCritical(message);
                return message;
            }
        }

        public string AugmentWithLabels(string id)
        {
            string message = EntryData.GetMessage(nameof(AugmentWithLabels), id);
            _logger.WithLabels(new KeyValuePair<string, string>("test_id", id)).LogCritical(message);
            return message;
        }

        public string Exception(string id)
        {
            string message = EntryData.GetMessage(nameof(Exception), id);
            try
            {
                throw new Exception("Exception to throw.");
            }
            catch (Exception e)
            {
                _logger.LogCritical(e, message);
            }
            return message;
        }

        public string LogsInOneSpan(string id, [FromServices] IManagedTracer tracer)
        {
            string message = EntryData.GetMessage(nameof(LogsInOneSpan), id);
            using (tracer.StartSpan(message))
            {
                _logger.LogWarning(message);
            }

            return message;
        }

        public string LogsInDifferentSpans(string id, [FromServices] IManagedTracer tracer)
        {
            string message = EntryData.GetMessage(nameof(LogsInDifferentSpans), id);
            using (tracer.StartSpan($"{message}-span-1"))
            {
                _logger.LogWarning($"{message}-log-1");
                using (tracer.StartSpan($"{message}-span-1-2"))
                {
                    _logger.LogWarning($"{message}-log-1-2");
                }
            }
            using (tracer.StartSpan($"{message}-span-2"))
            {
                _logger.LogWarning($"{message}-log-2");
            }

            return message;
        }

        public string LogsThreeEntries(string id)
        {
            string message = EntryData.GetMessage(nameof(LogsInDifferentSpans), id);
            _logger.LogWarning($"{message}-log-1");
            _logger.LogWarning($"{message}-log-2");
            _logger.LogWarning($"{message}-log-3");
            return message;
        }
    }

    internal class FooLogEntryLabelProvider : Common.ILogEntryLabelProvider
    {
        public void Invoke(Dictionary<string, string> labels)
        {
            labels["Foo"] = "Hello, World!";
        }
    }

    [Obsolete("Added to test that we still support the obsolete Google.Cloud.Diagnostics.AspNetCore.ILogEntryLabelProvider.")]
    internal class BarLogEntryLabelProvider : ILogEntryLabelProvider
    {
        public void Invoke(Dictionary<string, string> labels)
        {
            labels["Bar"] = "Hello, World!";
        }
    }

    internal class SpanCountingITraceContextFactory
    {
        public SpanCountingITraceContextFactory(int startAt) => _callCount = startAt;
        private int _callCount = 0;
        internal ITraceContext GetCurrentTraceContext() =>
            new SimpleTraceContext("105445aa7843bc8bf206b12000100f00", Convert.ToUInt64(Interlocked.Increment(ref _callCount)), false);
    }

#pragma warning disable CS0618 // Type or member is obsolete
    internal class SpanCountingExternalTraceProvider : IExternalTraceProvider
    {
        internal int _callCount = 0;
        public TraceContextForLogEntry GetCurrentTraceContext(IServiceProvider serviceProvider) =>
            new TraceContextForLogEntry("105445aa7843bc8bf206b12000100f00", $"{Convert.ToUInt64(Interlocked.Increment(ref _callCount)):x16}");
    }
#pragma warning restore CS0618 // Type or member is obsolete
}
