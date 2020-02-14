// Copyright 2018 Google Inc. All rights reserved.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using Google.Api;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Logging.Type;
using Google.Cloud.Logging.V2;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using NLog;
using NLog.Targets;
using NLog.Common;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;
using Newtonsoft.Json.Linq;
using Grpc.Auth;

namespace Google.Cloud.Logging.NLog
{
    /// <summary>
    /// Appends logging events to Google Stackdriver Logging.
    /// </summary>
    [Target("GoogleStackdriver")]
    public partial class GoogleStackdriverTarget : TargetWithContext
    {
        private static readonly string[] s_oAuthScopes = new string[] { "https://www.googleapis.com/auth/logging.write" };
        private static readonly Dictionary<string, string> s_emptyLabels = new Dictionary<string, string>();
        private static readonly Dictionary<LogLevel, LogSeverity> s_levelMap = new Dictionary<LogLevel, LogSeverity>
        {
            // Map NLog levels to Stackdriver LogSeveritys.
            { LogLevel.Fatal, LogSeverity.Emergency },
            { LogLevel.Error, LogSeverity.Error },
            { LogLevel.Warn, LogSeverity.Warning },
            { LogLevel.Info, LogSeverity.Info },
            { LogLevel.Debug, LogSeverity.Debug },
            { LogLevel.Trace, LogSeverity.Debug },
        };

        private LoggingServiceV2Client _client;
        private Platform _platform;
        private MonitoredResource _resource;
        private string _logName;
        private LogName _logNameToWrite;
        private Task _prevTask;
        private long _pendingTaskCount;
        private CancellationTokenSource _cancelTokenSource;
        private Func<object, Value> _jsonConvertFunction;
        private readonly Func<Task, object, Task> _writeLogEntriesBegin;
        private readonly Action<Task, object> _writeLogEntriesCompleted;

        /// <summary>
        /// Construct a Google Cloud loggin target.
        /// </summary>
        public GoogleStackdriverTarget() : this(null, null)
        {
        }

        // For testing only.
        internal GoogleStackdriverTarget(LoggingServiceV2Client client, Platform platform)
        {
            OptimizeBufferReuse = true;
            ResourceLabels = new List<TargetPropertyWithContext>();
            _contextProperties = new List<TargetPropertyWithContext>();
            _client = client;
            _platform = platform;
            _writeLogEntriesBegin = WriteLogEntriesBegin;
            _writeLogEntriesCompleted = WriteLogEntriesCompleted;
        }

        /// <summary>
        /// Initializes the target.
        /// </summary>
        protected override void InitializeTarget()
        {
            _cancelTokenSource = new CancellationTokenSource();

            _platform = _platform ?? Platform.Instance();
            string logId = LogId?.Render(LogEventInfo.CreateNullEvent());
            GaxPreconditions.CheckNotNullOrEmpty(logId, nameof(LogId));

            if (SendJsonPayload)
            {
                if (JsonConverter != null)
                {
                    // Use the function provided directly.
                    GaxPreconditions.CheckState(
                        string.IsNullOrWhiteSpace(JsonConverterTypeName) && string.IsNullOrWhiteSpace(JsonConverterMethodName),
                        $"{nameof(JsonConverterTypeName)} and {nameof(JsonConverterMethodName)} must not be set along with {nameof(JsonConverter)}.");
                    _jsonConvertFunction = JsonConverter;
                }
                else if (!string.IsNullOrWhiteSpace(JsonConverterTypeName) || !string.IsNullOrWhiteSpace(JsonConverterMethodName))
                {
                    // Use the method refered to by type-name and method-name.
                    GaxPreconditions.CheckState(
                        !string.IsNullOrWhiteSpace(JsonConverterTypeName) && !string.IsNullOrWhiteSpace(JsonConverterMethodName),
                        $"Either both or neither of {nameof(JsonConverterTypeName)} and {nameof(JsonConverterMethodName)} must be specified.");
                    _jsonConvertFunction = BuildAndVerifyJsonConverter();
                }
                else
                {
                    // Use default json.net based converter.
                    _jsonConvertFunction = BuildProtoConverter();
                }
            }

            ActivateLogIdAndResource(logId);

            _client = _client ?? BuildLoggingServiceClient();

            base.InitializeTarget();
        }

        private Func<object, Value> BuildProtoConverter()
        {
            // Create reusable JsonSerializer to reduce allocations
            var jsonSettings = new Newtonsoft.Json.JsonSerializerSettings()
            {
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            };
            jsonSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            jsonSettings.Error = (sender, args) =>
            {
                // Serialization of properties that throws exceptions should not break everything
                InternalLogger.Warn(args.ErrorContext.Error, "GoogleStackdriver(Name={0}): Error serializing exception property: {1}", Name, args.ErrorContext.Member);
                args.ErrorContext.Handled = true;
            };
            var jsonSerializer = Newtonsoft.Json.JsonSerializer.CreateDefault(jsonSettings);
            return o => {
                try
                {
                    switch (Convert.GetTypeCode(o))
                    {
                        case TypeCode.Empty: 
                            return Value.ForNull();
                        case TypeCode.Boolean:
                            return Value.ForBool(Convert.ToBoolean(o));
                        case TypeCode.Decimal:
                        case TypeCode.Double:
                        case TypeCode.Single:
                            return Value.ForNumber(Convert.ToDouble(o));
                        case TypeCode.Byte:
                        case TypeCode.SByte:
                        case TypeCode.Int16:
                        case TypeCode.UInt16:
                        case TypeCode.Int32:
                        case TypeCode.UInt32:
                        case TypeCode.Int64:
                        case TypeCode.UInt64:
                            if (o is System.Enum)
                            {
                                break;  // Let StringEnumConverter handle formatting
                            }
                            return Value.ForNumber(Convert.ToDouble(o));
                        case TypeCode.String:
                        case TypeCode.Char:
                            return Value.ForString(o.ToString());
                    }
                    return ProtoConverter.Convert(JToken.FromObject(o, jsonSerializer));
                }
                catch
                {
                    // Reset the JsonSerializer as it now can be in a bad state
                    jsonSerializer = Newtonsoft.Json.JsonSerializer.CreateDefault(jsonSettings);
                    throw;
                }
            };
        }

        private Func<object, Value> BuildAndVerifyJsonConverter()
        {
            var type = System.Type.GetType(JsonConverterTypeName, throwOnError: false);
            GaxPreconditions.CheckState(type != null, "A type with the specified name cannot be found: '{0}'", JsonConverterTypeName);
            var methodInfo = type.GetTypeInfo()
                .GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance)
                .Where(m => m.Name == JsonConverterMethodName && !m.IsAbstract && !m.IsGenericMethod &&
                    m.GetParameters().Length == 1 && m.GetParameters()[0].ParameterType == typeof(object) &&
                    (m.ReturnType == typeof(Value) || typeof(JToken).IsAssignableFrom(m.ReturnType)))
                .FirstOrDefault();
            GaxPreconditions.CheckState(methodInfo != null,
                $"A suitable public method named '{JsonConverterMethodName}' cannot be found in type '{JsonConverterTypeName}'. " +
                "The public method must have a single parameter of type 'object', and a return type of 'Value' or 'JToken'");
            object instance = null;
            if (!methodInfo.IsStatic)
            {
                try
                {
                    instance = Activator.CreateInstance(type);
                }
                catch (Exception e)
                {
                    // Acticator.CreateInstance can throw many different exceptions, so catch them all.
                    throw new InvalidOperationException(
                        $"Type '{JsonConverterTypeName}' must have a parameterless constructor so it can be instantiated.", e);
                }
            }
            if (methodInfo.ReturnType == typeof(Value))
            {
                return (Func<object, Value>)methodInfo.CreateDelegate(typeof(Func<object, Value>), instance);
            }
            else
            {
                var fn = (Func<object, JToken>)methodInfo.CreateDelegate(typeof(Func<object, JToken>), instance);
                return o => ProtoConverter.Convert(fn(o));
            }
        }

        /// <summary>
        /// Closes / Disposes the Target
        /// </summary>
        protected override void CloseTarget()
        {
            _cancelTokenSource.Cancel();
            _prevTask = null;
            _pendingTaskCount = 0;
            base.CloseTarget();
        }

        /// <inheritdoc/>
        protected override void FlushAsync(AsyncContinuation asyncContinuation)
        {
            if (_prevTask != null)
            {
                // Continue after last write is complete.
                _prevTask.ContinueWith(_ => asyncContinuation(null), TaskScheduler.Default);
            }
            else
            {
                // Nothing to flush.
                asyncContinuation(null);
            }
        }

        private LoggingServiceV2Client BuildLoggingServiceClient()
        {
            GoogleCredential credential = GetCredentialFromConfiguration();
            if (credential == null)
            {
                return LoggingServiceV2Client.Create();
            }

            if (credential.IsCreateScopedRequired)
            {
                credential = credential.CreateScoped(s_oAuthScopes);
            }

            return new LoggingServiceV2ClientBuilder { ChannelCredentials = credential.ToChannelCredentials() }.Build();
        }

        private GoogleCredential GetCredentialFromConfiguration()
        {
            var nullLogEvent = LogEventInfo.CreateNullEvent();
            var credentialFile = CredentialFile?.Render(nullLogEvent);
            var credentialJson = CredentialJson?.Render(nullLogEvent);
            GaxPreconditions.CheckState(string.IsNullOrWhiteSpace(credentialFile) || string.IsNullOrWhiteSpace(credentialJson),
                $"{nameof(CredentialFile)} and {nameof(CredentialJson)} must not both be set.");
            var credential =
                !string.IsNullOrWhiteSpace(credentialFile) ? GoogleCredential.FromFile(credentialFile) :
                !string.IsNullOrWhiteSpace(credentialJson) ? GoogleCredential.FromJson(credentialJson) :
                null;
            if (credential == null)
            {
                return null;
            }
            if (credential.IsCreateScopedRequired)
            {
                credential = credential.CreateScoped(s_oAuthScopes);
            }
            return credential;
        }

        private void ActivateLogIdAndResource(string logId)
        {
            string projectId = null;
            MonitoredResource resource = null;
            if (!DisableResourceTypeDetection)
            {
                resource = MonitoredResourceBuilder.FromPlatform(_platform);
                resource.Labels.TryGetValue("project_id", out projectId);
            }

            if (projectId == null)
            {
                // Either platform detection is disabled, or it detected an unknown platform.
                // So use the manually configured projectId and override the resource.
                projectId = GaxPreconditions.CheckNotNull(ProjectId?.Render(LogEventInfo.CreateNullEvent()), nameof(ProjectId));
                if (ResourceType == null)
                {
                    resource = new MonitoredResource { Type = "global", Labels = { { "project_id", projectId } } };
                }
                else
                {
                    resource = new MonitoredResource { Type = ResourceType,
                        Labels = { ResourceLabels.ToDictionary(x => x.Name, x => x.Layout.Render(LogEventInfo.CreateNullEvent())) } };
                }
            }

            _resource = resource;
            var logName = new LogName(projectId, logId);
            _logName = logName.ToString();
            _logNameToWrite = logName;
        }

        /// <summary>
        /// Writes async log event to the log target.
        /// </summary>
        /// /// <param name="logEvent">Logging event to be written out.</param>
        protected override void Write(AsyncLogEventInfo logEvent)
        {
            LogEntry logEntry = null;

            try
            {
                logEntry = BuildLogEntry(logEvent.LogEvent);
            }
            catch (Exception ex)
            {
                InternalLogger.Error(ex, "GoogleStackdriver(Name={0}): Failed to create LogEntry, marked as failed", Name);
                logEvent.Continuation(ex);
            }

            if (logEntry != null)
            {
                WriteLogEntries(new[] { logEntry }, logEvent.Continuation);
            }
        }

        /// <summary>
        /// Writes a list of logging events to the log target.
        /// </summary>
        protected override void Write(IList<AsyncLogEventInfo> logEvents)
        {
            List<LogEntry> logEntries = new List<LogEntry>(logEvents.Count);
            List<AsyncContinuation> continuationList = new List<AsyncContinuation>(logEvents.Count);
            for (int i = 0; i < logEvents.Count; ++i)
            {
                var logEvent = logEvents[i];

                try
                {
                    var logEntry = BuildLogEntry(logEvent.LogEvent);
                    logEntries.Add(logEntry);
                    continuationList.Add(logEvent.Continuation);
                }
                catch (Exception ex)
                {
                    InternalLogger.Error(ex, "GoogleStackdriver(Name={0}): Failed to create LogEntry, marked as failed", Name);
                    logEvent.Continuation(ex);
                }
            }

            if (logEntries.Count > 0)
            {
                WriteLogEntries(logEntries, continuationList);
            }
        }

        private void WriteLogEntries(IList<LogEntry> logEntries, object continuationList)
        {
            bool withinTaskLimit = Interlocked.Increment(ref _pendingTaskCount) <= TaskPendingLimit;

            try
            {
                if (!withinTaskLimit)
                {
                    // The task queue has become too long. We will throttle, and wait for the task-queue to become shorter
                    InternalLogger.Debug("GoogleStackdriver(Name={0}): Throttle started because {1} tasks are pending", Name, _pendingTaskCount);
                    for (int i = -100; i < TimeoutSeconds * 1000; i += 100)
                    {
                        withinTaskLimit = _prevTask?.Wait(100, _cancelTokenSource.Token) ?? true; // Throttle
                        if (withinTaskLimit)
                        {
                            _pendingTaskCount = 1;  // All pending tasks has completed
                            break;
                        }
                        if (Interlocked.Read(ref _pendingTaskCount) < TaskPendingLimit)
                        {
                            withinTaskLimit = true;  // Some pending tasks has completed
                            break;
                        }
                    }
                    if (!withinTaskLimit)
                    {
                        // The tasks queue is not moving. We start a new task queue and ignores the old one
                        InternalLogger.Info("GoogleStackdriver(Name={0}): Throttle timeout but {1} tasks are still pending", Name, _pendingTaskCount);
                    }
                }

                if (withinTaskLimit && _prevTask != null)
                {
                    _prevTask = _prevTask.ContinueWith(_writeLogEntriesBegin, logEntries, _cancelTokenSource.Token);
                }
                else
                {
                    _prevTask = WriteLogEntriesBegin(null, logEntries);
                }

                _prevTask = _prevTask.ContinueWith(_writeLogEntriesCompleted, continuationList);
            }
            catch (Exception ex)
            {
                Interlocked.Decrement(ref _pendingTaskCount);
                InternalLogger.Error(ex, "GoogleStackdriver(Name={0}): Failed to begin writing {1} LogEntries", Name, logEntries.Count);
                throw;
            }
        }

        private async Task WriteLogEntriesBegin(Task _, object state)
        {
            var logEntries = state as IList<LogEntry>;
            await _client.WriteLogEntriesAsync(_logNameToWrite, _resource, s_emptyLabels, logEntries, _cancelTokenSource.Token).ConfigureAwait(false);
        }

        private void WriteLogEntriesCompleted(Task prevTask, object state)
        {
            Interlocked.Decrement(ref _pendingTaskCount);

            var singleContinuation = state as AsyncContinuation;
            if (singleContinuation != null)
            {
                if (prevTask.Exception != null)
                {
                    InternalLogger.Error(prevTask.Exception, "GoogleStackdriver(Name={0}): Failed to write LogEntry", Name);
                }

                singleContinuation(prevTask.Exception);
            }
            else
            {
                var continuationList = state as List<AsyncContinuation>;
                if (continuationList != null)
                {
                    if (prevTask.Exception != null)
                    {
                        InternalLogger.Error(prevTask.Exception, "GoogleStackdriver(Name={0}): Failed to write {1} LogEntries", Name, continuationList.Count);
                    }

                    foreach (var continuation in continuationList)
                    {
                        continuation(prevTask.Exception);
                    }
                }
            }
        }

        private LogEntry BuildLogEntry(LogEventInfo loggingEvent)
        {
            var logEntry = new LogEntry
            {
                Severity = s_levelMap[loggingEvent.Level],
                Timestamp = ConvertToTimestamp(loggingEvent.TimeStamp),
                LogName = _logName,
                Resource = _resource,
            };

            if (SendJsonPayload)
            {
                var jsonStruct = new Struct();
                jsonStruct.Fields.Add("message", Value.ForString(RenderLogEvent(Layout, loggingEvent)));
                if (ServiceContextName != null)
                {
                    var serviceName = RenderLogEvent(ServiceContextName, loggingEvent);
                    if (!string.IsNullOrEmpty(serviceName))
                    {
                        // Include ServiceContext to allow errors to be automatically forwarded
                        var serviceVersion = RenderLogEvent(ServiceContextVersion, loggingEvent);
                        if (string.IsNullOrEmpty(serviceVersion))
                        {
                            serviceVersion = "0.0.0.0";
                        }

                        var serviceContext = new Struct();
                        jsonStruct.Fields.Add("serviceContext", Value.ForStruct(serviceContext));
                        serviceContext.Fields.Add("service", Value.ForString(serviceName));
                        serviceContext.Fields.Add("version", Value.ForString(serviceVersion));
                    }
                }

                var propertiesStruct = new Struct();
                jsonStruct.Fields.Add("properties", Value.ForStruct(propertiesStruct));

                foreach (var combinedProperty in GetAllProperties(loggingEvent).Where(x => !string.IsNullOrEmpty(x.Key)))
                {
                    Value jsonValue;
                    try
                    {
                        jsonValue = _jsonConvertFunction(combinedProperty.Value);
                    }
                    catch (Exception ex)
                    {
                        InternalLogger.Warn(ex,
                            "GoogleStackdriver(Name={0}): Exception at BuildLogEntry with Key={1}", Name, combinedProperty.Key);
                        jsonValue = Value.ForString($"<Exception: '{ex.Message}'>");
                    }
                    propertiesStruct.Fields.Add(combinedProperty.Key, jsonValue);
                }
                logEntry.JsonPayload = jsonStruct;
            }
            else
            {
                logEntry.TextPayload = RenderLogEvent(Layout, loggingEvent);

                foreach (var combinedProperty in GetAllProperties(loggingEvent).Where(x => !string.IsNullOrEmpty(x.Key)))
                {
                    try
                    {
                        logEntry.Labels[combinedProperty.Key] = combinedProperty.Value?.ToString() ?? "null";
                    }
                    catch (Exception ex)
                    {
                        InternalLogger.Warn(ex, "GoogleStackdriver(Name={0}): Exception at BuildLogEntry with Key={1}", Name, combinedProperty.Key);
                        logEntry.Labels[combinedProperty.Key] = "null";
                    }
                }
            }

            TryAddGitRevisionId(logEntry.Labels);

            var callsiteMethod = loggingEvent.CallerMemberName;
            if (!string.IsNullOrEmpty(callsiteMethod))
            {
                logEntry.SourceLocation = new LogEntrySourceLocation()
                {
                    Function = string.Concat(loggingEvent.CallerClassName, ".", callsiteMethod),
                    File = loggingEvent.CallerFilePath,
                    Line = loggingEvent.CallerLineNumber,
                };
            }
     
            return logEntry;
        }

        private static Timestamp ConvertToTimestamp(DateTime dt)
        {
            switch (dt.Kind)
            {
                case DateTimeKind.Local:
                    dt = dt.ToUniversalTime();
                    break;
                case DateTimeKind.Unspecified:
                    dt = DateTime.SpecifyKind(dt, DateTimeKind.Utc);
                    break;
            }
            return Timestamp.FromDateTime(dt);
        }

        private void TryAddGitRevisionId(Protobuf.Collections.MapField<string, string> labels)
        {
            try
            {
                var gitId = DevTools.Source.V1.SourceContext.AppSourceContext?.Git?.RevisionId;
                if (!String.IsNullOrWhiteSpace(gitId))
                {
                    labels.Add(DevTools.Source.V1.SourceContext.GitRevisionIdLogLabel, gitId);
                }
            }
            catch (Exception ex) when (
                ex is SecurityException
                || ex is InvalidProtocolBufferException
                || ex is InvalidJsonException
                || ex is UnauthorizedAccessException)
            {
                // This is best-effort only, exceptions from reading/parsing the source_context.json are ignored.
                InternalLogger.Warn(ex, "GoogleStackdriver(Name={0}): Exception at TryAddGitRevisionId", Name);
            }
        }
    }
}
