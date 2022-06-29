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

using Google.Apis.Auth.OAuth2;
using Google.Cloud.ClientTesting;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Diagnostics.Common.IntegrationTests;
using Google.Cloud.Logging.V2;
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore3.IntegrationTests
{
    using static TestServerHelpers;
    using TraceOptions = TraceOptions;

    public class ErrorReportingTest : IClassFixture<LogValidatingFixture>
    {
        private readonly string _testId;

        // The only way to validate trace context information on an error entry
        // is to check the corresponding log entry.
        private readonly LogValidatingFixture _fixture;

        public ErrorReportingTest(LogValidatingFixture fixture)
        {
            // The rate limiter instance is static and only set once.  If we do not reset it at the
            // beginning of each test the qps will not change.  This is dependent on the tests not
            // running in parallel, which they don't.
            RateLimiter.Reset();

            _testId = IdGenerator.FromDateTime();

            _fixture = fixture;
        }

        private void AssertTraceContext(LogEntry entry)
        {
            Assert.NotNull(entry.Trace);
            Assert.NotEmpty(entry.Trace);
            Assert.NotNull(entry.SpanId);
            Assert.NotEmpty(entry.SpanId);
            Assert.True(entry.TraceSampled);
        }

        [Fact]
        public async Task ManualLog()
        {
            using var server = GetTestServer<ErrorReportingTestApplication>();
            using var client = server.CreateClient();

            var response = await client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowCatchLog)}/{_testId}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            _fixture.AddValidator(_testId, results =>
            {
                var entry = Assert.Single(results);
                AssertTraceContext(entry);

                var errorEvent = ErrorEventEntryVerifiers.VerifySingle(ErrorEventEntryPolling.NoRetry, _testId);
                ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, nameof(ErrorReportingController.ThrowCatchLog));
            });
        }

        [Fact]
        public async Task ManualLog_CustomClient()
        {
            using var server = GetTestServer<ErrorReportingCustomClientTestApplication>();
            using var client = server.CreateClient();

            // We are using a client with a bad credential.
            var exception = await Assert.ThrowsAsync<AggregateException>(() => client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowCatchLog)}/{_testId}"));
            var rpcException = Assert.IsType<RpcException>(exception.InnerException);
            Assert.Equal(StatusCode.Unauthenticated, rpcException.StatusCode);
        }

        [Fact]
        public async Task LogsException()
        {
            using var server = GetTestServer<ErrorReportingTestApplication>();
            using var client = server.CreateClient();

            await Assert.ThrowsAsync<Exception>(() =>
                client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}"));

            _fixture.AddValidator(_testId, results =>
            {
                var entry = Assert.Single(results);
                AssertTraceContext(entry);

                var errorEvent = ErrorEventEntryVerifiers.VerifySingle(ErrorEventEntryPolling.NoRetry, _testId);
                ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(errorEvent, _testId, nameof(ErrorReportingController.ThrowsException));
            });
        }

        [Fact]
        public async Task LogsMultipleExceptions()
        {
            using var server = GetTestServer<ErrorReportingTestApplication>();
            using var client = server.CreateClient();

            await Assert.ThrowsAsync<Exception>(() =>
                client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}_0"));
            await Assert.ThrowsAsync<ArgumentException>(() =>
                client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsArgumentException)}/{_testId}"));
            await Assert.ThrowsAsync<Exception>(() =>
                client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}_1"));
            await Assert.ThrowsAsync<Exception>(() =>
                client.GetAsync($"/ErrorReporting/{nameof(ErrorReportingController.ThrowsException)}/{_testId}_2"));

            _fixture.AddValidator(_testId, results =>
            {
                Assert.Equal(4, results.Count);
                Assert.All(results, AssertTraceContext);

                var errorEvents = ErrorEventEntryVerifiers.VerifyMany(ErrorEventEntryPolling.NoRetry, _testId, 4);

                var exceptionEvents = errorEvents.Where(e => e.Message.Contains(nameof(ErrorReportingController.ThrowsException))).ToList();
                Assert.Equal(3, exceptionEvents.Count);
                Assert.All(exceptionEvents, e => ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(e, _testId, nameof(ErrorReportingController.ThrowsException)));

                var argumentExceptionEvent = errorEvents.Where(e => e.Message.Contains(nameof(ErrorReportingController.ThrowsArgumentException))).Single();
                ErrorEventEntryVerifiers.VerifyFullErrorEventLogged(argumentExceptionEvent, _testId, nameof(ErrorReportingController.ThrowsArgumentException));
            });
        }

        /// <summary>
        /// A simple web application base to test the <see cref="GoogleExceptionLogger"/>
        /// and associated classes.
        /// </summary>
        private class ErrorReportingTestApplication : BaseStartup
        {
            private static string ProjectId = TestEnvironment.GetTestProjectId();

            public override void ConfigureServices(IServiceCollection services) =>
                base.ConfigureServices(services
                    .AddGoogleTraceForAspNetCore(new AspNetCoreTraceOptions
                    {
                        ServiceOptions = new Common.TraceServiceOptions
                        {
                            ProjectId = ProjectId,
                            Options = TraceOptions.Create(
                                double.PositiveInfinity, BufferOptions.NoBuffer(), RetryOptions.NoRetry(ExceptionHandling.Propagate))
                        }
                    })
                    .AddGoogleErrorReportingForAspNetCore(new ErrorReportingServiceOptions
                    {
                        ProjectId = ProjectId,
                        ServiceName = EntryData.Service,
                        Version = EntryData.Version,
                        // This is just so that our validator finds the log entries associated to errors.
                        Options = ErrorReportingOptions.Create(
                            logName: "aspnetcore",
                            bufferOptions: BufferOptions.NoBuffer(),
                            retryOptions: RetryOptions.NoRetry(ExceptionHandling.Propagate))
                    }));
        }

        private class ErrorReportingCustomClientTestApplication : BaseStartup
        {
            private static string ProjectId = TestEnvironment.GetTestProjectId();

            public override void ConfigureServices(IServiceCollection services) =>
                base.ConfigureServices(services
                    .AddGoogleErrorReportingForAspNetCore(new ErrorReportingServiceOptions
                    {
                        ProjectId = ProjectId,
                        ServiceName = EntryData.Service,
                        Version = EntryData.Version,
                        Client = new LoggingServiceV2ClientBuilder
                        {
                            Credential = GoogleCredential.FromAccessToken("very_bad_token")
                        }.Build(),
                        // This is just so that our validator finds the log entries associated to errors.
                        Options = ErrorReportingOptions.Create(
                            logName: "aspnetcore",
                            bufferOptions: BufferOptions.NoBuffer(),
                            retryOptions: RetryOptions.NoRetry(ExceptionHandling.Propagate))
                    }));
        }
    }

    /// <summary>
    /// A controller for the <see cref="ErrorReportingTestApplication"/> used to log exceptions.
    /// </summary>
    public class ErrorReportingController : Controller
    {
        private readonly IExceptionLogger _exceptionLogger;
        public ErrorReportingController(IExceptionLogger exceptionLogger)
        {
            _exceptionLogger = exceptionLogger;
        }

        /// <summary>Catches and handles a thrown <see cref="Exception"/>.</summary>
        public string Index(string id)
        {
            var message = EntryData.GetMessage(nameof(Index), id);
            try
            {
                throw new Exception(message);
            }
            catch
            {
                // Do nothing.
            }
            return message;
        }

        /// <summary>Throws an <see cref="Exception"/>.</summary>
        public string ThrowsException(string id)
        {
            string message = EntryData.GetMessage(nameof(ThrowsException), id);
            throw new Exception(message);
        }

        /// <summary>Throws an <see cref="ArgumentException"/>.</summary>
        public string ThrowsArgumentException(string id)
        {
            string message = EntryData.GetMessage(nameof(ThrowsArgumentException), id);
            throw new ArgumentException(message);
        }

        /// <summary>Catches and logs a thrown <see cref="Exception"/>.</summary>
        public string ThrowCatchLog(string id)
        {
            var message = EntryData.GetMessage(nameof(Index), id);
            try
            {
                throw new Exception(message);
            }
            catch (Exception e)
            {
                _exceptionLogger.Log(e);
            }
            return message;
        }
    }
}
