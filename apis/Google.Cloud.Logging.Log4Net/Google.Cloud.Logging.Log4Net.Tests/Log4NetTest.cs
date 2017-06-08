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
using Google.Api.Gax.Testing;
using Google.Cloud.Logging.V2;
using Grpc.Core;
using log4net;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Logging.Log4Net.Tests
{
    public class Log4NetTest
    {
        // At the top of the file to minimize line number changes.
        [MethodImpl(MethodImplOptions.NoInlining)]
        private void LogInfo(IEnumerable<string> messages)
        {
            ILog log = LogManager.GetLogger(GetType().GetTypeInfo().Assembly, "testlogger");
            foreach (string message in messages)
            {
                log.Info(message);
            }
        }

        private void LogInfo(params string[] messages) => LogInfo((IEnumerable<string>)messages);

        private static readonly TimeSpan s_testTimeout = TimeSpan.FromSeconds(3);
        private static readonly string s_lostMsg = GoogleStackdriverAppender.s_logsLostWarningMessage;
        private const string s_projectId = "projectId";
        private const string s_logId = "logId";

        // TODO:
        // * Test retry timing behaviour.
        // * Add integration tests to check correct logging on various platforms.

        private class LoggingErrorException : Exception
        {
            public LoggingErrorException(string message) : base(message) { }
        }

        private class ThrowingErrorHandler : IErrorHandler
        {
            public void Error(string message)
            {
                throw new LoggingErrorException(message);
            }

            public void Error(string message, Exception e)
            {
                throw e;
            }

            public void Error(string message, Exception e, ErrorCode errorCode)
            {
                throw e;
            }
        }

        /// <summary>
        /// Scheduler implementation that does everything instantly, with no delay.
        /// </summary>
        private class NoDelayScheduler : IScheduler
        {
            public Task Delay(TimeSpan delay, CancellationToken cancellationToken) => Task.FromResult(0);
        }

        private async Task RunTest(
            Func<IEnumerable<LogEntry>, Task<WriteLogEntriesResponse>> handlerFn,
            Func<GoogleStackdriverAppender, Task> testFn,
            IClock clock = null, IScheduler scheduler = null, Platform platform = null,
            int? maxMemoryCount = null, long? maxMemorySize = null, int? maxUploadBatchSize = null,
            IEnumerable<MetaDataType> withMetadata = null, bool enableResourceTypeDetection = false,
            bool requiresLog4Net = false)
        {
            Hierarchy hierarchy = null;
            if (requiresLog4Net)
            {
                hierarchy = (Hierarchy)LogManager.GetRepository(GetType().GetTypeInfo().Assembly);
            }
            try
            {
                var fakeClient = new Mock<LoggingServiceV2Client>(MockBehavior.Strict);
                fakeClient.Setup(x => x.WriteLogEntriesAsync(
                    null, null, It.IsAny<IDictionary<string, string>>(), It.IsAny<IEnumerable<LogEntry>>(), It.IsAny<CancellationToken>()))
                    .Returns<LogNameOneof, MonitoredResource, IDictionary<string, string>, IEnumerable<LogEntry>, CancellationToken>((a, b, c, entries, d) => handlerFn(entries));
                var appender = new GoogleStackdriverAppender(fakeClient.Object,
                    scheduler ?? new NoDelayScheduler(), clock ?? new FakeClock(), platform)
                {
                    ErrorHandler = new ThrowingErrorHandler(),
                    Layout = new PatternLayout { ConversionPattern = "%message" },
                    ProjectId = s_projectId,
                    LogId = s_logId,
                };
                if (!enableResourceTypeDetection)
                {
                    appender.DisableResourceTypeDetection = true;
                    appender.ResourceType = "global";
                }
                if (maxMemoryCount != null) appender.MaxMemoryCount = maxMemoryCount.Value;
                if (maxMemorySize != null) appender.MaxMemorySize = maxMemorySize.Value;
                if (maxUploadBatchSize != null) appender.MaxUploadBatchSize = maxUploadBatchSize.Value;
                foreach (var metadata in withMetadata ?? Enumerable.Empty<MetaDataType>())
                {
                    appender.AddWithMetaData(metadata);
                }
                appender.ActivateOptions();
                if (hierarchy != null)
                {
                    hierarchy.Root.AddAppender(appender);
                    hierarchy.Root.Level = Level.Info;
                    hierarchy.Configured = true;
                }
                await testFn(appender);
            }
            finally
            {
                if (hierarchy != null)
                {
                    hierarchy.Clear();
                }
            }
        }

        private async Task<List<LogEntry>> RunTestWorkingServer(
            Func<GoogleStackdriverAppender, Task> testFn,
            IClock clock = null, IScheduler scheduler = null, Platform platform = null,
            int? maxMemoryCount = null, long? maxMemorySize = null, int? maxUploadBatchSize = null,
            IEnumerable<MetaDataType> withMetadata = null, bool enableResourceTypeDetection = false,
            bool requiresLog4Net = false)
        {
            List<LogEntry> uploadedEntries = new List<LogEntry>();
            await RunTest(entries =>
            {
                uploadedEntries.AddRange(entries);
                return Task.FromResult(new WriteLogEntriesResponse());
            }, testFn, clock, scheduler, platform, maxMemoryCount, maxMemorySize, maxUploadBatchSize,
                withMetadata, enableResourceTypeDetection, requiresLog4Net);
            return uploadedEntries;
        }

        private static readonly DateTime s_time0 = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private LoggingEvent CreateLog(Level level, string msg, int secondsOfs = 0)
        {
            var loggingData = new LoggingEventData
            {
                Level = level,
                Message = msg,
                TimeStampUtc = s_time0 + TimeSpan.FromSeconds(secondsOfs),
            };
            return new LoggingEvent(loggingData);
        }

        private string TimeOfs(int secondsOfs) =>
            (s_time0 + TimeSpan.FromSeconds(secondsOfs))
            .ToString(GoogleStackdriverAppender.s_lostDateTimeFmt);

        [Fact]
        public async Task PostActivationChangeThrow()
        {
            await RunTestWorkingServer(appender =>
            {
                Assert.Throws<InvalidOperationException>(() => appender.DisableResourceTypeDetection = true);
                Assert.Throws<InvalidOperationException>(() => appender.ResourceType = "");
                Assert.Throws<InvalidOperationException>(() => appender.AddResourceLabel(new GoogleStackdriverAppender.Label { Key = "a", Value = "b" }));
                Assert.Throws<InvalidOperationException>(() => appender.ProjectId = "");
                Assert.Throws<InvalidOperationException>(() => appender.LogId = "");
                Assert.Throws<InvalidOperationException>(() => appender.MaxUploadBatchSize = 0);
                Assert.Throws<InvalidOperationException>(() => appender.LocalQueueType = LocalQueueType.Memory);
                Assert.Throws<InvalidOperationException>(() => appender.MaxMemorySize = 0);
                Assert.Throws<InvalidOperationException>(() => appender.MaxMemoryCount = 0);
                Assert.Throws<InvalidOperationException>(() => appender.AddCustomLabel(new GoogleStackdriverAppender.Label { Key = "a", Value = "b" }));
                Assert.Throws<InvalidOperationException>(() => appender.AddWithMetaData(MetaDataType.Domain));
                Assert.Throws<InvalidOperationException>(() => appender.ServerErrorBackoffDelaySeconds = 0);
                Assert.Throws<InvalidOperationException>(() => appender.ServerErrorBackoffMultiplier = 0);
                Assert.Throws<InvalidOperationException>(() => appender.ServerErrorBackoffMaxDelaySeconds = 0);
                Assert.Throws<InvalidOperationException>(() => appender.DisposeTimeoutSeconds = 0);
                return Task.FromResult(0);
            });
        }

        [Fact]
        public void PreActivationChangeDoesntThrow()
        {
            // Assert nothing throws
            var appender = new GoogleStackdriverAppender();
            appender.DisableResourceTypeDetection = true;
            appender.ResourceType = "";
            appender.AddResourceLabel(new GoogleStackdriverAppender.Label { Key = "a", Value = "b" });
            appender.ProjectId = "";
            appender.LogId = "";
            appender.MaxUploadBatchSize = 0;
            appender.LocalQueueType = LocalQueueType.Memory;
            appender.MaxMemorySize = 0;
            appender.MaxMemoryCount = 0;
            appender.AddCustomLabel(new GoogleStackdriverAppender.Label { Key = "a", Value = "b" });
            appender.AddWithMetaData(MetaDataType.Domain);
            appender.ServerErrorBackoffDelaySeconds = 0;
            appender.ServerErrorBackoffMultiplier = 0;
            appender.ServerErrorBackoffMaxDelaySeconds = 0;
            appender.DisposeTimeoutSeconds = 0;
        }

        [Fact]
        public async Task UninitialisedBehaviour()
        {
            var fakeClient = new Mock<LoggingServiceV2Client>(MockBehavior.Strict);
            var appender = new GoogleStackdriverAppender(fakeClient.Object, new NoDelayScheduler(), new FakeClock())
            {
                ErrorHandler = new ThrowingErrorHandler(),
                Layout = new PatternLayout { ConversionPattern = "%message" },
                ProjectId = s_projectId,
                LogId = s_logId,
            };
            // ActivateOptions() has not been called, so appending throws.
            Assert.Throws<InvalidOperationException>(() => appender.DoAppend(CreateLog(Level.Info, "Message0")));
            Assert.Throws<InvalidOperationException>(() => appender.Flush(TimeSpan.FromSeconds(1)));
            await Assert.ThrowsAsync<InvalidOperationException>(() => appender.FlushAsync(TimeSpan.FromSeconds(1)));
            // But close and dispose can be called fine.
            // They silently do nothing if the appender is not activated.
            appender.Close();
            appender.Dispose();
        }

        [Fact]
        public void UninitialisedGced()
        {
            var fakeClient = new Mock<LoggingServiceV2Client>(MockBehavior.Strict);
            var appender = new GoogleStackdriverAppender(fakeClient.Object, new NoDelayScheduler(), new FakeClock())
            {
                ErrorHandler = new ThrowingErrorHandler(),
                Layout = new PatternLayout { ConversionPattern = "%message" },
                ProjectId = s_projectId,
                LogId = s_logId,
            };
            appender = null;
            // This should not cause an error on AppenderSkeleton finalization.
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        [Fact]
        public async Task SingleLogEntry()
        {
            var uploadedEntries = await RunTestWorkingServer(
                async appender =>
                {
                    LogInfo("Message0");
                    Assert.True(await appender.FlushAsync(s_testTimeout));
                },
                requiresLog4Net: true);
            Assert.Equal(1, uploadedEntries.Count);
            Assert.Equal("Message0", uploadedEntries[0].TextPayload.Trim());
        }

        [Fact]
        public async Task SingleLogEntryWithLocation()
        {
            var uploadedEntries = await RunTestWorkingServer(
                async appender =>
                {
                    LogInfo("Message0");
                    Assert.True(await appender.FlushAsync(s_testTimeout));
                },
                withMetadata: new[] { MetaDataType.Location },
                requiresLog4Net: true);
            Assert.Equal(1, uploadedEntries.Count);
            var entry0 = uploadedEntries[0];
            Assert.Equal("Message0", entry0.TextPayload.Trim());

            if (entry0.SourceLocation != null)
            {
                Assert.True(string.IsNullOrEmpty(entry0.SourceLocation.File) || entry0.SourceLocation.File.EndsWith("Log4NetTest.cs"),
                $"Actual 'entry0.SourceLocation.File' = '{entry0.SourceLocation.File}'");
                // Line 44 on dev machine, line 42 on AppVeyor. Don't ask, I don't understand.
                Assert.True(entry0.SourceLocation.Line == 0L || entry0.SourceLocation.Line == 45L || entry0.SourceLocation.Line == 43L,
                    $"Actual 'entry0.SourceLocation.Line' = '{entry0.SourceLocation.Line}'"); // This may change when this file is edited ;)
                Assert.Matches(@"\[Google\.Cloud\.Logging\.Log4Net\.Tests\.Log4NetTest, Google\.Cloud\.Logging\.Log4Net\.Tests, .*]\.LogInfo", entry0.SourceLocation.Function);
            }
        }

        [Fact]
        public async Task MultipleLogEntries()
        {
            var logs = Enumerable.Range(1, 5).Select(i => $"Message{i}");
            var uploadedEntries = await RunTestWorkingServer(
                async appender =>
                {
                    LogInfo(logs.Take(2));
                    Assert.True(await appender.FlushAsync(s_testTimeout));
                    LogInfo(logs.Skip(2));
                    Assert.True(await appender.FlushAsync(s_testTimeout));
                },
                requiresLog4Net: true);
            Assert.Equal(5, uploadedEntries.Count);
            Assert.Equal(logs, uploadedEntries.Select(x => x.TextPayload.Trim()));
        }

        [Fact]
        public async Task LogEntriesLostSingleAppend_OnCount()
        {
            var uploadedEntries = await RunTestWorkingServer(
                async appender =>
                {
                    var logs = Enumerable.Range(0, 5).Select(i => CreateLog(Level.Info, $"Message{i}", i)).ToArray();
                    appender.DoAppend(logs);
                    Assert.True(await appender.FlushAsync(s_testTimeout));
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
                    Assert.True(await appender.FlushAsync(s_testTimeout));
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
                    Assert.True(await appender.FlushAsync(s_testTimeout));
                    appender.DoAppend(logs.Skip(1).Take(3).ToArray());
                    Assert.True(await appender.FlushAsync(s_testTimeout));
                    appender.DoAppend(logs.Skip(4).Take(1).ToArray());
                    Assert.True(await appender.FlushAsync(s_testTimeout));
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
                    Assert.True(await appender.FlushAsync(s_testTimeout));
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
                    Assert.True(await appender.FlushAsync(s_testTimeout));
                },
                maxUploadBatchSize: 1);
            Assert.Equal(10, uploadCount);
            Assert.Equal(5, failedUploadCount);
            Assert.Equal(5, uploadedEntries.Count);
            Assert.Equal(logs.Select(x => x.RenderedMessage), uploadedEntries.Select(x => x.TextPayload.Trim()));
        }

        [Fact]
        public async Task ErrorAfterDispose_NoLogEntries()
        {
            var uploadedEntries = await RunTestWorkingServer(appender =>
            {
                appender.Dispose();
                Assert.Throws<LoggingErrorException>(() => appender.DoAppend(CreateLog(Level.Info, "Won't work, already disposed.")));
                return Task.FromResult(0);
            });
            Assert.Empty(uploadedEntries);
        }

        [Fact]
        public async Task ErrorAfterDispose_WithLogEntry()
        {
            var uploadedEntries = await RunTestWorkingServer(appender =>
            {
                appender.DoAppend(CreateLog(Level.Info, "0"));
                appender.Dispose();
                Assert.Throws<LoggingErrorException>(() => appender.DoAppend(CreateLog(Level.Info, "Won't work, already disposed.")));
                return Task.FromResult(0);
            });
            Assert.NotEmpty(uploadedEntries);
        }

        [Fact]
        public async Task FlushCancellation()
        {
            var t0 = DateTime.UtcNow;
            var tcs = new CancellationTokenSource(TimeSpan.FromSeconds(0.1));
            var task = RunTest(async entries =>
            {
                await Task.Delay(TimeSpan.FromSeconds(60));
                return new WriteLogEntriesResponse();
            },
            async appender =>
            {
                appender.DoAppend(CreateLog(Level.Info, "0"));
                Assert.False(await appender.FlushAsync(TimeSpan.FromSeconds(60), tcs.Token));
                var t1 = DateTime.UtcNow;
                Assert.InRange(t1 - t0, TimeSpan.FromSeconds(0.0), TimeSpan.FromSeconds(1.0));
            });
            await Assert.ThrowsAsync<OperationCanceledException>(() => task);
        }

        [Fact]
        public async Task UnknownPlatform()
        {
            var uploadedEntries = await RunTestWorkingServer(async appender =>
            {
                appender.DoAppend(CreateLog(Level.Info, "0"));
                Assert.True(await appender.FlushAsync(s_testTimeout));
            }, platform: new Platform(), enableResourceTypeDetection: true);
            Assert.Equal(1, uploadedEntries.Count);
            var r = uploadedEntries[0].Resource;
            Assert.Equal("global", r.Type);
            Assert.Equal(1, r.Labels.Count);
            Assert.Equal(s_projectId, r.Labels["project_id"]);
        }

        [Fact]
        public async Task GcePlatform()
        {
            const string json = @"
{
  'project': {
    'projectId': '" + s_projectId + @"'
  },
  'instance': {
    'id': 'FakeInstanceId',
    'zone': 'FakeZone'
  }
}
";
            var platform = new Platform(GcePlatformDetails.TryLoad(json));
            var uploadedEntries = await RunTestWorkingServer(async appender =>
            {
                appender.DoAppend(CreateLog(Level.Info, "0"));
                Assert.True(await appender.FlushAsync(s_testTimeout));
            }, platform: platform, enableResourceTypeDetection: true);
            Assert.Equal(1, uploadedEntries.Count);
            var r = uploadedEntries[0].Resource;
            Assert.Equal("gce_instance", r.Type);
            Assert.Equal(3, r.Labels.Count);
            Assert.Equal(s_projectId, r.Labels["project_id"]);
            Assert.Equal("FakeInstanceId", r.Labels["instance_id"]);
            Assert.Equal("FakeZone", r.Labels["zone"]);
        }

        [Fact]
        public async Task GaePlatform()
        {
            var platform = new Platform(new GaePlatformDetails(s_projectId, "FakeInstanceId", "FakeService", "FakeVersion"));
            var uploadedEntries = await RunTestWorkingServer(async appender =>
            {
                appender.DoAppend(CreateLog(Level.Info, "0"));
                Assert.True(await appender.FlushAsync(s_testTimeout));
            }, platform: platform, enableResourceTypeDetection: true);
            Assert.Equal(1, uploadedEntries.Count);
            var r = uploadedEntries[0].Resource;
            Assert.Equal("gae_app", r.Type);
            Assert.Equal(3, r.Labels.Count);
            Assert.Equal(s_projectId, r.Labels["project_id"]);
            Assert.Equal("FakeService", r.Labels["module_id"]);
            Assert.Equal("FakeVersion", r.Labels["version_id"]);
        }

        [Fact]
        public async Task GaePlatformMismatchedProjectId()
        {
            var platform = new Platform(new GaePlatformDetails("PlatformProjectId", "FakeInstanceId", "FakeService", "FakeVersion"));
            var uploadedEntries = await RunTestWorkingServer(async appender =>
            {
                appender.DoAppend(CreateLog(Level.Info, "0"));
                Assert.True(await appender.FlushAsync(s_testTimeout));
            }, platform: platform, enableResourceTypeDetection: true);
            Assert.Equal(2, uploadedEntries.Count);
            Assert.Equal(GoogleStackdriverAppender.s_mismatchedProjectIdMessage, uploadedEntries[0].TextPayload.Trim());
            Assert.Equal("0", uploadedEntries[1].TextPayload.Trim());
            var r = uploadedEntries[1].Resource;
            Assert.Equal("gae_app", r.Type);
            Assert.Equal(3, r.Labels.Count);
            Assert.Equal("PlatformProjectId", r.Labels["project_id"]);
            Assert.Equal("FakeService", r.Labels["module_id"]);
            Assert.Equal("FakeVersion", r.Labels["version_id"]);
        }
    }
}
