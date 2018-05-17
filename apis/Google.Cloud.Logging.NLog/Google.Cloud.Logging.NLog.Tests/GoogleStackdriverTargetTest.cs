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
using Google.Cloud.Logging.V2;
using Moq;
using NLog;
using NLog.Config;
using NLog.Targets;
using NLog.Targets.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Logging.NLog.Tests
{
    public class GoogleStackdriverTargetTest
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
            Func<GoogleStackdriverTarget, Task> testFn,
            IEnumerable<KeyValuePair<string, string>> withMetadata = null,
            Platform platform = null,
            bool enableResourceTypeDetection = false,
            bool includeCallSiteStackTrace = false,
            bool includeEventProperties = false)
        {
            try
            {
                var fakeClient = new Mock<LoggingServiceV2Client>(MockBehavior.Strict);
                fakeClient.Setup(x => x.WriteLogEntriesAsync(
                    It.IsAny<LogNameOneof>(), It.IsAny<MonitoredResource>(), It.IsAny<IDictionary<string, string>>(), It.IsAny<IEnumerable<LogEntry>>(), It.IsAny<CancellationToken>()))
                    .Returns<LogNameOneof, MonitoredResource, IDictionary<string, string>, IEnumerable<LogEntry>, CancellationToken>((a, b, c, entries, d) => handlerFn(entries));
                var googleTarget = new GoogleStackdriverTarget(fakeClient.Object, platform)
                {
                    ProjectId = s_projectId,
                    LogId = s_logId,
                    Layout = "${message}",
                    IncludeCallSiteStackTrace = includeCallSiteStackTrace,
                    IncludeEventProperties = includeEventProperties,
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
            Func<GoogleStackdriverTarget, Task> testFn,
            IEnumerable<KeyValuePair<string,string>> withMetadata = null,
            Platform platform = null,
            bool enableResourceTypeDetection = false,
            bool includeCallSiteStackTrace = false,
            bool includeEventProperties = false)
        {
            List<LogEntry> uploadedEntries = new List<LogEntry>();
            await RunTest(entries =>
            {
                uploadedEntries.AddRange(entries);
                return Task.FromResult(new WriteLogEntriesResponse());
            }, testFn, withMetadata, platform, enableResourceTypeDetection, includeCallSiteStackTrace, includeEventProperties);
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
                googleTarget =>
                {
                    LogInfo("Message0");
                    return Task.FromResult(0);
                });
            Assert.Single(uploadedEntries);
            Assert.Equal("Message0", uploadedEntries[0].TextPayload);
            Assert.Null(uploadedEntries[0].SourceLocation);
        }

        [Fact]
        public async Task SingleLogEntryWithLocation()
        {
            var uploadedEntries = await RunTestWorkingServer(
                googleTarget =>
                {
                    LogInfo("Message0");
                    return Task.FromResult(0);
                }, includeCallSiteStackTrace: true);
            Assert.Single(uploadedEntries);
            var entry0 = uploadedEntries[0];
            Assert.Contains("Message0", entry0.TextPayload.Trim());

            Assert.NotNull(entry0.SourceLocation);
            Assert.True(string.IsNullOrEmpty(entry0.SourceLocation.File) || entry0.SourceLocation.File.EndsWith("GoogleStackdriverTargetTest.cs"),
                $"Actual 'entry0.SourceLocation.File' = '{entry0.SourceLocation.File}'");
            Assert.NotEqual(0, entry0.SourceLocation.Line);
            Assert.Equal("Google.Cloud.Logging.NLog.Tests.GoogleStackdriverTargetTest.LogInfo", entry0.SourceLocation.Function);
        }

        [Fact]
        public async Task SingleLogEntryWithProperties()
        {
            var uploadedEntries = await RunTestWorkingServer(
                googleTarget =>
                {
                    googleTarget.ContextProperties.Add(new TargetPropertyWithContext() { Name = "Galaxy", Layout = "Milky way" });
                    LogManager.GetLogger("testlogger").Info("Hello {Planet}", "Earth");
                    return Task.FromResult(0);
                }, includeEventProperties: true);
            Assert.Single(uploadedEntries);
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
                googleTarget =>
                {
                    LogInfo(logs.Take(2));
                    googleTarget.Flush((ex) => { });
                    LogInfo(logs.Skip(2));
                    return Task.FromResult(0);
                });
            Assert.Equal(5, uploadedEntries.Count);
            Assert.Equal(logs, uploadedEntries.Select(x => x.TextPayload.Trim()));
        }

        [Fact]
        public async Task MultipleLogEntriesAsync()
        {
            var logs = Enumerable.Range(1, 5).Select(i => $"Message{i}");
            var uploadedEntries = await RunTestWorkingServer(
                googleTarget =>
                {
                    AsyncTargetWrapper asyncWrapper = new AsyncTargetWrapper(googleTarget) { TimeToSleepBetweenBatches = 500 };
                    LogManager.Configuration.LoggingRules.Clear();
                    LogManager.Configuration.AddRuleForAllLevels(asyncWrapper, "*");
                    LogManager.ReconfigExistingLoggers();
                    LogInfo(logs.Take(2));
                    asyncWrapper.Flush((ex) => { });
                    LogInfo(logs.Skip(2));
                    return Task.FromResult(0);
                });
            Assert.Equal(5, uploadedEntries.Count);
            Assert.Equal(logs, uploadedEntries.Select(x => x.TextPayload.Trim()));
        }

        [Fact]
        public async Task UnknownPlatform()
        {
            var uploadedEntries = await RunTestWorkingServer(
                googleTarget =>
                {
                    LogInfo("Message0");
                    return Task.FromResult(0);
                }, platform: new Platform(), enableResourceTypeDetection: true);
            Assert.Single(uploadedEntries);
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
            var uploadedEntries = await RunTestWorkingServer(
                googleTarget =>
                {
                    LogInfo("Message0");
                    return Task.FromResult(0);
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
            var uploadedEntries = await RunTestWorkingServer(
                googleTarget =>
                {
                    LogInfo("Message0");
                    return Task.FromResult(0);
                }, platform: platform, enableResourceTypeDetection: true);
            Assert.Equal(1, uploadedEntries.Count);
            var r = uploadedEntries[0].Resource;
            Assert.Equal("gae_app", r.Type);
            Assert.Equal(3, r.Labels.Count);
            Assert.Equal(s_projectId, r.Labels["project_id"]);
            Assert.Equal("FakeService", r.Labels["module_id"]);
            Assert.Equal("FakeVersion", r.Labels["version_id"]);
        }
    }
}
