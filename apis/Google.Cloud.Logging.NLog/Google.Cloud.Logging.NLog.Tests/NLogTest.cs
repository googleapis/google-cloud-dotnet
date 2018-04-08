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
using NLog;
using NLog.Config;
using NLog.Targets;
using NLog.Targets.Wrappers;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Logging.NLog.Tests
{
    public class NLogTest
    {
        // At the top of the file to minimize line number changes.
        [MethodImpl(MethodImplOptions.NoInlining)]
        private void LogInfo(IEnumerable<string> messages)
        {
            var logger = LogManager.GetLogger("testlogger");
            foreach (string message in messages)
            {
                logger.Info(message);
            }
        }

        private void LogInfo(params string[] messages) => LogInfo((IEnumerable<string>)messages);

        private const string s_projectId = "projectId";
        private const string s_logId = "logId";

        private async Task RunTest(
            Func<IEnumerable<LogEntry>, Task<WriteLogEntriesResponse>> handlerFn,
            Func<GoogleCloudLoggingTarget, Task> testFn,
            IEnumerable<KeyValuePair<string, string>> withMetadata = null, bool enableResourceTypeDetection = false)
        {
            try
            {
                var fakeClient = new Mock<LoggingServiceV2Client>(MockBehavior.Strict);
                fakeClient.Setup(x => x.WriteLogEntriesAsync(
                    It.IsAny<LogNameOneof>(), It.IsAny<MonitoredResource>(), It.IsAny<IDictionary<string, string>>(), It.IsAny<IEnumerable<LogEntry>>(), It.IsAny<CancellationToken>()))
                    .Returns<LogNameOneof, MonitoredResource, IDictionary<string, string>, IEnumerable<LogEntry>, CancellationToken>((a, b, c, entries, d) => handlerFn(entries));
                var googleTarget = new GoogleCloudLoggingTarget(fakeClient.Object)
                {
                    ProjectId = s_projectId,
                    LogId = s_logId,
                    Layout = "${message}",
                    IncludeCallSiteStackTrace = true,
                    IncludeEventProperties = true,
                };
                if (!enableResourceTypeDetection)
                {
                    googleTarget.DisableResourceTypeDetection = true;
                    googleTarget.ResourceType = "global";
                }
                foreach (var metadata in withMetadata ?? Enumerable.Empty<KeyValuePair<string, string>>())
                {
                    googleTarget.ContextProperties.Add(new TargetPropertyWithContext() { Name = metadata.Key, Layout = metadata.Value });
                }
                SimpleConfigurator.ConfigureForTargetLogging(googleTarget);
                await testFn(googleTarget);
            }
            finally
            {
                LogManager.Configuration = null;
            }
        }

        private async Task<List<LogEntry>> RunTestWorkingServer(
            Func<GoogleCloudLoggingTarget, Task> testFn,
            IEnumerable<KeyValuePair<string,string>> withMetadata = null, bool enableResourceTypeDetection = false)
        {
            List<LogEntry> uploadedEntries = new List<LogEntry>();
            await RunTest(entries =>
            {
                uploadedEntries.AddRange(entries);
                return Task.FromResult(new WriteLogEntriesResponse());
            }, testFn, withMetadata, enableResourceTypeDetection);
            return uploadedEntries;
        }

        private LogEventInfo CreateLog(LogLevel level, string msg)
        {
            return new LogEventInfo { Level = level, Message = msg };
        }

        [Fact]
        public async Task SingleLogEntry()
        {
            var uploadedEntries = await RunTestWorkingServer(
                async googleTarget =>
                {
                    LogInfo("Message0");
                    await Task.Yield();
                });
            Assert.Equal(1, uploadedEntries.Count);
            Assert.Equal("Message0", uploadedEntries[0].TextPayload);
        }

        [Fact]
        public async Task SingleLogEntryWithLocation()
        {
            var uploadedEntries = await RunTestWorkingServer(
                async googleTarget =>
                {
                    LogInfo("Message0");
                    await Task.Yield();
                });
            Assert.Equal(1, uploadedEntries.Count);
            var entry0 = uploadedEntries[0];
            Assert.Contains("Message0", entry0.TextPayload.Trim());

            Assert.NotNull(entry0.SourceLocation);
            Assert.True(string.IsNullOrEmpty(entry0.SourceLocation.File) || entry0.SourceLocation.File.EndsWith("NLogTest.cs"),
            $"Actual 'entry0.SourceLocation.File' = '{entry0.SourceLocation.File}'");
            // Line 44 on dev machine, line 42 on AppVeyor. Don't ask, I don't understand.
            Assert.NotEqual(0, entry0.SourceLocation.Line);
            Assert.Equal("Google.Cloud.Logging.NLog.Tests.NLogTest.LogInfo", entry0.SourceLocation.Function);
        }

        [Fact]
        public async Task SingleLogEntryWithProperties()
        {
            var uploadedEntries = await RunTestWorkingServer(
                async googleTarget =>
                {
                    googleTarget.ContextProperties.Add(new TargetPropertyWithContext() { Name = "Galaxy", Layout = "Milky way" });
                    LogManager.GetLogger("testlogger").Info("Hello {Planet}", "Earth");
                    await Task.Yield();
                });
            Assert.Equal(1, uploadedEntries.Count);
            var entry0 = uploadedEntries[0];
            Assert.Equal("Hello \"Earth\"", entry0.TextPayload.Trim());
            Assert.Equal(2, entry0.Labels.Count);
            Assert.Equal("Earth", entry0.Labels["Planet"]);
            Assert.Equal("Milky way", entry0.Labels["Galaxy"]);
        }

        [Fact]
        public async Task MultipleLogEntries()
        {
            var logs = Enumerable.Range(1, 5).Select(i => $"Message{i}");
            var uploadedEntries = await RunTestWorkingServer(
                async googleTarget =>
                {
                    LogInfo(logs.Take(2));
                    googleTarget.Flush((ex) => { });
                    LogInfo(logs.Skip(2));
                    await Task.Yield();
                });
            Assert.Equal(5, uploadedEntries.Count);
            Assert.Equal(logs, uploadedEntries.Select(x => x.TextPayload.Trim()));
        }

        [Fact]
        public async Task MultipleLogEntriesAsync()
        {
            var logs = Enumerable.Range(1, 5).Select(i => $"Message{i}");
            var uploadedEntries = await RunTestWorkingServer(
                async googleTarget =>
                {
                    AsyncTargetWrapper asyncWrapper = new AsyncTargetWrapper(googleTarget) { TimeToSleepBetweenBatches = 500 };
                    LogManager.Configuration.LoggingRules.Clear();
                    LogManager.Configuration.AddRuleForAllLevels(asyncWrapper, "*");
                    LogManager.ReconfigExistingLoggers();
                    LogInfo(logs.Take(2));
                    asyncWrapper.Flush((ex) => { });
                    LogInfo(logs.Skip(2));
                    await Task.Yield();
                });
            Assert.Equal(5, uploadedEntries.Count);
            Assert.Equal(logs, uploadedEntries.Select(x => x.TextPayload.Trim()));
        }
    }
}
