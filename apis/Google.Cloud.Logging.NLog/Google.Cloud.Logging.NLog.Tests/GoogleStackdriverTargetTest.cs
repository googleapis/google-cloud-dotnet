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

using Google.Api;
using Google.Api.Gax;
using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using Moq;
using Newtonsoft.Json.Linq;
using NLog;
using NLog.Common;
using NLog.Config;
using NLog.Layouts;
using NLog.Targets;
using NLog.Targets.Wrappers;
using System;
using System.Collections.Concurrent;
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
            bool includeEventProperties = false,
            Action<GoogleStackdriverTarget> configFn = null)
        {
            try
            {
                var fakeClient = new Mock<LoggingServiceV2Client>(MockBehavior.Strict);
                fakeClient.Setup(x => x.WriteLogEntriesAsync(
                    It.IsAny<LogName>(), It.IsAny<MonitoredResource>(), It.IsAny<IDictionary<string, string>>(), It.IsAny<IEnumerable<LogEntry>>(), It.IsAny<CancellationToken>()))
                    .Returns<LogName, MonitoredResource, IDictionary<string, string>, IEnumerable<LogEntry>, CancellationToken>((a, b, c, entries, d) => handlerFn(entries));
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
                configFn?.Invoke(googleTarget);
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
            bool includeEventProperties = false,
            Action<GoogleStackdriverTarget> configFn = null)
        {
            List<LogEntry> uploadedEntries = new List<LogEntry>();
            await RunTest(entries =>
            {
                uploadedEntries.AddRange(entries);
                return Task.FromResult(new WriteLogEntriesResponse());
            }, testFn, withMetadata, platform, enableResourceTypeDetection, includeCallSiteStackTrace, includeEventProperties, configFn);
            return uploadedEntries;
        }

        private Task ActivateTargetAsync(Target target)
        {
            // ConfigureForTargetLogging() and a write are both required to trigger target initialization.
            SimpleConfigurator.ConfigureForTargetLogging(target);
            var tcs = new TaskCompletionSource<int>();
            void Continuation(Exception ex)
            {
                if (ex != null)
                {
                    tcs.SetException(ex);
                }
                else
                {
                    tcs.SetResult(0);
                }
            };
            target.WriteAsyncLogEvent(new AsyncLogEventInfo(LogEventInfo.CreateNullEvent(), Continuation));
            return tcs.Task;
        }

        [Fact]
        public async Task InvalidOptions_MultipleCredentials()
        {
            var target = new GoogleStackdriverTarget
            {
                ProjectId = "a_project_id",
                CredentialFile = Layout.FromString("not_empty"),
                CredentialJson = Layout.FromString("not_empty"),
            };
            var nlogEx = await Assert.ThrowsAsync<NLogRuntimeException>(() => ActivateTargetAsync(target));
            var innerEx = nlogEx.InnerException;
            Assert.IsType<InvalidOperationException>(innerEx);
            Assert.True(innerEx.Message.Contains("CredentialFile") && innerEx.Message.Contains("CredentialJson"));
        }

        [Fact]
        public async Task InvalidOptions_MultipleJsonConverters()
        {
            var target = new GoogleStackdriverTarget
            {
                ProjectId = "a_project_id",
                SendJsonPayload = true,
                JsonConverter = o => Value.ForNull(),
                JsonConverterTypeName = "a_type_name",
            };
            var nlogEx = await Assert.ThrowsAsync<NLogRuntimeException>(() => ActivateTargetAsync(target));
            Assert.IsType<InvalidOperationException>(nlogEx.InnerException);
        }

        [Fact]
        public async Task InvalidOptions_BadJsonConverterType()
        {
            var target = new GoogleStackdriverTarget
            {
                ProjectId = "a_project_id",
                SendJsonPayload = true,
                JsonConverterTypeName = "a_type_name",
                JsonConverterMethodName = "a_method_name",
            };
            var nlogEx = await Assert.ThrowsAsync<NLogRuntimeException>(() => ActivateTargetAsync(target));
            Assert.IsType<InvalidOperationException>(nlogEx.InnerException);
            Assert.Contains("a_type_name", nlogEx.InnerException.Message);
        }

        private class TestJsonConverter
        {
            public static ConcurrentBag<string> SeenItems { get; } = new ConcurrentBag<string>();

            public static Value TestJsonConverterMethod_Value_Static(object o)
            {
                SeenItems.Add(JToken.FromObject(o).Value<string>());
                return Value.ForNull();
            }

            public Value TestJsonConverterMethod_Value_Instance(object o)
            {
                SeenItems.Add(JToken.FromObject(o).Value<string>());
                return Value.ForNull();
            }
            public static JToken TestJsonConverterMethod_JToken_Static(object o)
            {
                SeenItems.Add(JToken.FromObject(o).Value<string>());
                return null;
            }

            public JObject TestJsonConverterMethod_JObject_Instance(object o)
            {
                SeenItems.Add(JToken.FromObject(o).Value<string>());
                return null;
            }
        }

        [Fact]
        public async Task InvalidOptions_BadJsonConverterMethod()
        {
            var target = new GoogleStackdriverTarget
            {
                ProjectId = "a_project_id",
                SendJsonPayload = true,
                JsonConverterTypeName = typeof(TestJsonConverter).AssemblyQualifiedName,
                JsonConverterMethodName = "a_method_name",
            };
            var nlogEx = await Assert.ThrowsAsync<NLogRuntimeException>(() => ActivateTargetAsync(target));
            Assert.IsType<InvalidOperationException>(nlogEx.InnerException);
            Assert.Contains("a_method_name", nlogEx.InnerException.Message);
        }

        [Fact]
        public async Task CustomJsonConverter()
        {
            async Task TestTarget(string methodName)
            {
                Assert.DoesNotContain(methodName, TestJsonConverter.SeenItems);
                await RunTestWorkingServer(configFn: target =>
                {
                    target.IncludeEventProperties = true;
                    target.SendJsonPayload = true;
                    target.JsonConverterTypeName = typeof(TestJsonConverter).AssemblyQualifiedName;
                    target.JsonConverterMethodName = methodName;
                }, testFn: target =>
                {
                    LogManager.GetLogger("testlogger").Info("Method:{Method}", methodName);
                    return Task.FromResult(0);
                });
                Assert.Contains(methodName, TestJsonConverter.SeenItems);
            }

            await TestTarget(nameof(TestJsonConverter.TestJsonConverterMethod_Value_Static));
            await TestTarget(nameof(TestJsonConverter.TestJsonConverterMethod_Value_Instance));
            await TestTarget(nameof(TestJsonConverter.TestJsonConverterMethod_JToken_Static));
            await TestTarget(nameof(TestJsonConverter.TestJsonConverterMethod_JObject_Instance));
        }

        [Fact]
        public async Task CustomJsonConverter_Exception()
        {
            var uploadedEntries = await RunTestWorkingServer(configFn: target =>
            {
                target.IncludeEventProperties = true;
                target.SendJsonPayload = true;
                target.JsonConverter = _ => throw new Exception("CustomError");
            }, testFn: target =>
            {
                LogManager.GetLogger("testlogger").Info("{field}", "content (ignored in this test)");
                return Task.FromResult(0);
            });
            Assert.Single(uploadedEntries);
            Assert.Contains("CustomError", uploadedEntries[0].JsonPayload.Fields["properties"].StructValue.Fields["field"].StringValue);
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

        public enum PlanetType
        {
            None,
            Gas,
            Ocean,
            Ice,
        }

        [Fact]
        public async Task SingleLogEntryWithJsonProperties()
        {
            var uploadedEntries = await RunTestWorkingServer(
                googleTarget =>
                {
                    googleTarget.ContextProperties.Add(new TargetPropertyWithContext() { Name = "Galaxy", Layout = "Milky way" });
                    LogManager.GetLogger("testlogger").Info("Hello {Planet}, width: {Radius} km, life: {Habitable}, type: {PlanetType}", "Earth", 6371, true, PlanetType.Ocean);
                    return Task.FromResult(0);
                }, includeEventProperties: true, configFn: googleTarget => googleTarget.SendJsonPayload = true);
            Assert.Single(uploadedEntries);
            var entry0 = uploadedEntries[0];
            Assert.Equal("", entry0.TextPayload?.Trim() ?? "");
            Assert.Equal("Hello \"Earth\", width: 6371 km, life: true, type: Ocean", entry0.JsonPayload.Fields["message"].StringValue);

            var properties = entry0.JsonPayload.Fields["properties"].StructValue;

            Assert.Equal(5, properties.Fields.Count);
            Assert.Equal("Milky way", properties.Fields["Galaxy"].StringValue);
            Assert.Equal("Earth", properties.Fields["Planet"].StringValue);
            Assert.Equal(true, properties.Fields["Habitable"].BoolValue);
            Assert.Equal(6371, properties.Fields["Radius"].NumberValue);
            Assert.Equal("Ocean", properties.Fields["PlanetType"].StringValue);
        }

        [Fact]
        public async Task SingleLogEntryWithJsonCollectionProperties()
        {
            var uploadedEntries = await RunTestWorkingServer(
                googleTarget =>
                {
                    LogManager.GetLogger("testlogger").Info(
                        "Favorite {Colors} and {Devices}",
                        new string[] { "Red", "Green", "Blue" },
                        new Dictionary<string,int>{ ["NTSC"] = 1953, ["PAL"] = 1962, ["SECAM"] = 1956 });
                    return Task.FromResult(0);
                }, includeEventProperties: true, configFn: googleTarget => googleTarget.SendJsonPayload = true);
            Assert.Single(uploadedEntries);
            var entry0 = uploadedEntries[0];
            Assert.Equal("", entry0.TextPayload?.Trim() ?? "");
            Assert.Equal("Favorite \"Red\", \"Green\", \"Blue\" and \"NTSC\"=1953, \"PAL\"=1962, \"SECAM\"=1956", entry0.JsonPayload.Fields["message"].StringValue);

            var properties = entry0.JsonPayload.Fields["properties"].StructValue;
            Assert.Equal(2, properties.Fields.Count);

            var colorListValues = properties.Fields["Colors"].ListValue.Values;
            Assert.Equal(3, colorListValues.Count);
            Assert.Equal("Red", colorListValues[0].StringValue);
            Assert.Equal("Green", colorListValues[1].StringValue);
            Assert.Equal("Blue", colorListValues[2].StringValue);

            var deviceDictionary = properties.Fields["Devices"].StructValue;
            Assert.Equal(3, deviceDictionary.Fields.Count);
            Assert.Equal(1953, deviceDictionary.Fields["NTSC"].NumberValue);
            Assert.Equal(1962, deviceDictionary.Fields["PAL"].NumberValue);
            Assert.Equal(1956, deviceDictionary.Fields["SECAM"].NumberValue);
        }

        [Fact]
        public async Task SingleLogEntryWithJsonObjectProperties()
        {
            var uploadedEntries = await RunTestWorkingServer(
                googleTarget =>
                {
                    googleTarget.SendJsonPayload = true;
                    LogManager.GetLogger("testlogger").Info("Favorite {Planet}", new { Name = "Earth", Galaxy = "Milky way", Colors = new[] { "Red", "Green", "Blue" }, PlanetType = PlanetType.Ocean });
                    return Task.FromResult(0);
                }, includeEventProperties: true, configFn: googleTarget => googleTarget.SendJsonPayload = true);
            Assert.Single(uploadedEntries);
            var entry0 = uploadedEntries[0];
            Assert.Equal("", entry0.TextPayload?.Trim() ?? "");

            var properties = entry0.JsonPayload.Fields["properties"].StructValue;

            Assert.Equal(1, properties.Fields.Count);
            Assert.Equal(4, properties.Fields["Planet"].StructValue.Fields.Count);
            Assert.Equal("Earth", properties.Fields["Planet"].StructValue.Fields["Name"].StringValue);
            Assert.Equal("Milky way", properties.Fields["Planet"].StructValue.Fields["Galaxy"].StringValue);

            var colorListValues = properties.Fields["Planet"].StructValue.Fields["Colors"].ListValue.Values;
            Assert.Equal(3, colorListValues.Count);
            Assert.Equal("Red", colorListValues[0].StringValue);
            Assert.Equal("Green", colorListValues[1].StringValue);
            Assert.Equal("Blue", colorListValues[2].StringValue);

            Assert.Equal("Ocean", properties.Fields["Planet"].StructValue.Fields["PlanetType"].StringValue);
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
        public async Task MultipleLogEntriesThrottle()
        {
            var logs = Enumerable.Range(1, 5).Select(i => $"Message{i}");
            var uploadedEntries = await RunTestWorkingServer(
                googleTarget =>
                {
                    googleTarget.TaskPendingLimit = 2;
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

        // Note: This test blocks for 1 second.
        [Fact]
        public async Task RetryWrites()
        {
            var incompleteTcs = new TaskCompletionSource<WriteLogEntriesResponse>();
            List<LogEntry> uploadedEntries = new List<LogEntry>();
            await RunTest(
                entries =>
                {
                    lock (uploadedEntries)
                    {
                        uploadedEntries.AddRange(entries);
                    }
                    return incompleteTcs.Task;
                },
                googleTarget =>
                {
                    googleTarget.TimeoutSeconds = 1;
                    googleTarget.TaskPendingLimit = 2;
                    LogInfo("1");
                    LogInfo("2");
                    LogInfo("3");
                    return Task.FromResult(0);
                });
            // "2" is missing because it's queued after "1", but "1" never completes.
            // "3" is present because the initial task-pending queue times-out, "3" is sent on a new queue.
            Assert.Equal(new[] { "1", "3" }, uploadedEntries.Select(x => x.TextPayload));
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
    'zone': 'projects/12345/zones/FakeZone'
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
