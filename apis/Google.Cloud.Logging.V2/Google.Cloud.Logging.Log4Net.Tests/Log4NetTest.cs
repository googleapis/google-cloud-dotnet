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
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.Testing;
using Google.Cloud.Logging.V2;
using Grpc.Core;
using log4net.Core;
using log4net.Layout;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Logging.Log4Net.Tests
{
    public class Log4NetTest
    {
        private static readonly TimeSpan s_testTimeout = TimeSpan.FromSeconds(3);
        private static readonly string s_lostMsg = GoogleStackdriverAppender.s_logsLostWarningMessage;
        private const string s_projectId = "projectId";
        private const string s_logId = "logId";

        // TODO:
        // * Test retry timing behaviour

        private class LoggingErrorException : Exception
        {
            public LoggingErrorException(string message) : base(message) { }
            public LoggingErrorException(string message, Exception e) : base(message, e) { }
        }

        private class ThrowingErrorHandler : IErrorHandler
        {
            public void Error(string message)
            {
                throw new LoggingErrorException(message);
            }

            public void Error(string message, Exception e)
            {
                throw new LoggingErrorException(message, e);
            }

            public void Error(string message, Exception e, ErrorCode errorCode)
            {
                throw new LoggingErrorException($"{message} [errorCode={errorCode}]", e);
            }
        }

        /// <summary>
        /// Scheduler implementation that does everything instantly, with no delay.
        /// </summary>
        private class NoDelayScheduler : IScheduler
        {
            public Task Delay(TimeSpan delay, CancellationToken cancellationToken) => Task.FromResult(0);
        }

        private Task RunTest(
            Func<IEnumerable<LogEntry>,
            Task<WriteLogEntriesResponse>> handlerFn,
            Func<GoogleStackdriverAppender, Task> testFn,
            IClock clock = null, IScheduler scheduler = null,
            int? maxMemoryCount = null, long? maxMemorySize = null, int? maxUploadBatchSize = null)
        {
            var fakeClient = new Mock<LoggingServiceV2Client>(MockBehavior.Strict);
            fakeClient.Setup(x => x.WriteLogEntriesAsync(LogNameOneof.From(new LogName(s_projectId, s_logId)),
                null, It.IsAny<IDictionary<string, string>>(), It.IsAny<IEnumerable<LogEntry>>(), null))
                .Returns<LogNameOneof, MonitoredResource, IDictionary<string, string>, IEnumerable<LogEntry>, CallSettings>((a, b, c, entries, d) => handlerFn(entries));
            var appender = new GoogleStackdriverAppender(fakeClient.Object,
                scheduler ?? new NoDelayScheduler(), clock ?? new FakeClock())
            {
                ErrorHandler = new ThrowingErrorHandler(),
                Layout = new PatternLayout { ConversionPattern = "%message" },
                ProjectId = s_projectId,
                LogId = s_logId,
            };
            if (maxMemoryCount != null) appender.MaxMemoryCount = maxMemoryCount.Value;
            if (maxMemorySize != null) appender.MaxMemorySize = maxMemorySize.Value;
            if (maxUploadBatchSize != null) appender.MaxUploadBatchSize = maxUploadBatchSize.Value;
            appender.ActivateOptions();
            return testFn(appender);
        }

        private async Task<List<LogEntry>> RunTestWorkingServer(
            Func<GoogleStackdriverAppender, Task> testFn,
            IClock clock = null, IScheduler scheduler = null,
            int? maxMemoryCount = null, long? maxMemorySize = null)
        {
            List<LogEntry> uploadedEntries = new List<LogEntry>();
            await RunTest(entries =>
            {
                uploadedEntries.AddRange(entries);
                return Task.FromResult(new WriteLogEntriesResponse());
            }, testFn, clock, scheduler, maxMemoryCount, maxMemorySize);
            return uploadedEntries;
        }

        private static readonly DateTime s_time0 = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private LoggingEvent CreateLog(Level level, string msg, int secondsOfs = 0)
        {
            var loggingData = new LoggingEventData
            {
                Level = level,
                Message = msg,
                TimeStamp = s_time0 + TimeSpan.FromSeconds(secondsOfs),
            };
            return new LoggingEvent(loggingData);
        }

        private string TimeOfs(int secondsOfs) =>
            (s_time0 + TimeSpan.FromSeconds(secondsOfs))
            .ToString(GoogleStackdriverAppender.s_lostDateTimeFmt);

        [Fact]
        public async Task SingleLogEntry()
        {
            var uploadedEntries = await RunTestWorkingServer(
                async appender =>
                {
                    var log = CreateLog(Level.Info, "Message0");
                    appender.DoAppend(log);
                    await appender.WaitUntilEmptyAsync(s_testTimeout);
                });
            Assert.Equal(1, uploadedEntries.Count);
            Assert.Equal("Message0", uploadedEntries[0].TextPayload.Trim());
        }

        [Fact]
        public async Task MultipleLogEntries()
        {
            var logs = Enumerable.Range(1, 5).Select(i => CreateLog(Level.Info, $"Message{i}")).ToArray();
            var uploadedEntries = await RunTestWorkingServer(
                async appender =>
                {
                    appender.DoAppend(logs.Take(2).ToArray());
                    await appender.WaitUntilEmptyAsync(s_testTimeout);
                    appender.DoAppend(logs.Skip(2).ToArray());
                    await appender.WaitUntilEmptyAsync(s_testTimeout);
                });
            Assert.Equal(5, uploadedEntries.Count);
            Assert.Equal(logs.Select(x => x.RenderedMessage), uploadedEntries.Select(x => x.TextPayload.Trim()));
        }

        [Fact]
        public async Task LogEntriesLostSingleAppend_OnCount()
        {
            var uploadedEntries = await RunTestWorkingServer(
                async appender =>
                {
                    var logs = Enumerable.Range(0, 5).Select(i => CreateLog(Level.Info, $"Message{i}", i)).ToArray();
                    appender.DoAppend(logs);
                    await appender.WaitUntilEmptyAsync(s_testTimeout);
                }, maxMemoryCount: 1);
            // Expect logs-loss warning, and the last log entry
            Assert.Equal(2, uploadedEntries.Count);
            Assert.Equal(string.Format(s_lostMsg, TimeOfs(0), TimeOfs(3)), uploadedEntries[0].TextPayload);
            Assert.Equal("Message4", uploadedEntries[1].TextPayload.Trim());
        }

        [Fact]
        public async Task LogEntriesLostSingleAppend_OnSize()
        {
            var uploadedEntries = await RunTestWorkingServer(
                async appender =>
                {
                    var logs = Enumerable.Range(0, 5).Select(i => CreateLog(Level.Info, $"Message{i}", i)).ToArray();
                    appender.DoAppend(logs);
                    await appender.WaitUntilEmptyAsync(s_testTimeout);
                }, maxMemorySize: 1);
            // Expect logs-loss warning, and various log entries
            Assert.Equal(2, uploadedEntries.Count);
            Assert.Equal(string.Format(s_lostMsg, TimeOfs(0), TimeOfs(3)), uploadedEntries[0].TextPayload);
            Assert.Equal("Message4", uploadedEntries[1].TextPayload.Trim());
        }

        [Fact]
        public async Task LogEntriesLostMultiAppends()
        {
            var uploadedEntries = await RunTestWorkingServer(
                async appender =>
                {
                    var logs = Enumerable.Range(0, 5).Select(i => CreateLog(Level.Info, $"Message{i}", i)).ToArray();
                    appender.DoAppend(logs.Take(1).ToArray());
                    await appender.WaitUntilEmptyAsync(s_testTimeout);
                    appender.DoAppend(logs.Skip(1).Take(3).ToArray());
                    await appender.WaitUntilEmptyAsync(s_testTimeout);
                    appender.DoAppend(logs.Skip(4).Take(1).ToArray());
                    await appender.WaitUntilEmptyAsync(s_testTimeout);
                }, maxMemoryCount: 1);
            // Expect logs-loss warning, and various log entries
            Assert.Equal(4, uploadedEntries.Count);
            Assert.Equal("Message0", uploadedEntries[0].TextPayload.Trim());
            Assert.Equal(string.Format(s_lostMsg, TimeOfs(1), TimeOfs(2)), uploadedEntries[1].TextPayload);
            Assert.Equal("Message3", uploadedEntries[2].TextPayload.Trim());
            Assert.Equal("Message4", uploadedEntries[3].TextPayload.Trim());
        }

        [Fact]
        public async Task LogEntriesLostSingleAppend_CheckTimestamps()
        {
            var fakeClock = new FakeClock(new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            var uploadedEntries = await RunTestWorkingServer(
                async appender =>
                {
                    var logs = Enumerable.Range(0, 5).Select(i => CreateLog(Level.Info, $"Message{i}", i)).ToArray();
                    appender.DoAppend(logs);
                    await appender.WaitUntilEmptyAsync(s_testTimeout);
                },
                clock: fakeClock,
                maxMemoryCount: 1);
            // Expect logs-loss warning, and the last log entry
            Assert.Equal(2, uploadedEntries.Count);
            // Check the "lost-entries" payload text and timestamp are correct
            Assert.Equal(string.Format(s_lostMsg, TimeOfs(0), TimeOfs(3)), uploadedEntries[0].TextPayload);
            Assert.Equal(fakeClock.GetCurrentDateTimeUtc(), uploadedEntries[0].Timestamp.ToDateTime());
            // Check the single successfully logged message is correct
            Assert.Equal("Message4", uploadedEntries[1].TextPayload.Trim());
        }

        [Fact]
        public async Task LogEntriesFlakyServer()
        {
            List<LogEntry> uploadedEntries = new List<LogEntry>();
            var logs = Enumerable.Range(0, 5).Select(i => CreateLog(Level.Info, $"Message{i}")).ToArray();
            int uploadCount = 0;
            int failedUploadCount = 0;
            await RunTest(
                entries =>
                {
                    uploadCount += 1;
                    if (uploadCount % 2 != 0)
                    {
                        failedUploadCount += 1;
                        var tcs = new TaskCompletionSource<WriteLogEntriesResponse>();
                        tcs.SetException(new RpcException(new Status(StatusCode.DeadlineExceeded, "Deadline exceeded")));
                        return tcs.Task;
                    }
                    else
                    {
                        uploadedEntries.AddRange(entries);
                        return Task.FromResult(new WriteLogEntriesResponse());
                    }
                },
                async appender =>
                {
                    appender.DoAppend(logs);
                    await appender.WaitUntilEmptyAsync(s_testTimeout);
                },
                maxUploadBatchSize: 1);
            Assert.Equal(10, uploadCount);
            Assert.Equal(5, failedUploadCount);
            Assert.Equal(5, uploadedEntries.Count);
            Assert.Equal(logs.Select(x => x.RenderedMessage), uploadedEntries.Select(x => x.TextPayload.Trim()));
        }
    }
}
