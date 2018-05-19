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
using NLog.Config;
using NLog.Targets;
using NLog.Common;
using NLog.Layouts;
using System.Threading.Tasks;
using System.Threading;

namespace Google.Cloud.Logging.NLog
{
    /// <summary>
    /// 
    /// </summary>
    [Target("GoogleStackdriver")]
    public class GoogleStackdriverTarget : TargetWithContext
    {
        /// <summary>
        /// The file path of a service account JSON file to use for authenitication.
        /// Not necessary if running on GCE, GAE or GKE, or if the GOOGLE_APPLICATION_CREDENTIALS environment variable has been set.
        /// </summary>
        public Layout CredentialFile { get; set; }

        /// <summary>
        /// If set, disables resource-type detection based on platform,
        /// so ResourceType will default to "global" if not manually set. 
        /// </summary>
        public bool DisableResourceTypeDetection { get; set; }

        /// <summary>
        /// Configures how many outstanding write tasks before starting to throttle 
        /// </summary>
        public int TaskPendingLimit { get; set; }

        /// <summary>
        /// The resource type of log entries.
        /// Default value depends on the detected platform. See the remarks section for details.
        /// </summary>
        /// <remarks>
        /// If this is not set, then Resource type is set depending on the detected execution platform:
        /// <list type="bullet">
        /// <item><description>
        /// Google App Engine: ResourceType "gae_app", with project_id, module_id, and version_id set approprately.
        /// </description></item>
        /// <item><description>
        /// Google Compute Engine: ResourceType "gce_instance", with project_id, instance_id, and zone set approprately.
        /// </description></item>
        /// <item><description>
        /// Google Kubernetes Engine: ResourceType "container", with project_id and other labels set approprately.
        /// </description></item>
        /// <item><description>
        /// Unknown: ResourceType "global", with project_id set from this configuration.
        /// </description></item>
        /// </list>
        /// If <see cref="DisableResourceTypeDetection"/> is <c>true</c>, then this platform detection
        /// is not performed, and this ResourceType defaults to "global" if not set.
        /// </remarks>
        public string ResourceType { get; set; }

        /// <summary>
        /// The project ID for all log entries.
        /// Must be configured if not executing on Google Compute Engine, Google App Engine or Google Kubernetes Engine.
        /// If running on GCE, GAE or GKE, the ProjectId will be automatically detected if not set.
        /// </summary>
        public Layout ProjectId { get; set; }

        /// <summary>
        /// LogID for all log entries. Must be configured.
        /// </summary>
        public Layout LogId { get; set; }

        /// <summary>
        /// Specify labels for the resource type;
        /// only used if platform detection is disabled or detects an unknown platform.
        /// </summary>
        [ArrayParameter(typeof(TargetPropertyWithContext), "resourcelabel")]
        public IList<TargetPropertyWithContext> ResourceLabels { get; }

        /// <summary>
        /// Allows custom labels to be added to the log entries as extra metadata
        /// </summary>
        [ArrayParameter(typeof(TargetPropertyWithContext), "contextproperty")]
        public override IList<TargetPropertyWithContext> ContextProperties { get { return _contextProperties; } }
        readonly List<TargetPropertyWithContext> _contextProperties;

        private LoggingServiceV2Client _client;
        private Platform _platform;
        private MonitoredResource _resource;
        private string _logName;
        private LogNameOneof _logNameToWrite;
        private Task _prevTask;
        private int _pendingTaskCount;
        private CancellationTokenSource _cancelTokenSource;
        private Func<Task, object, Task> _writeLogEntriesBegin;
        private Action<Task, object> _writeLogEntriesCompleted;

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
            LogId = "Default";
            TaskPendingLimit = 5;
            _writeLogEntriesBegin = WriteLogEntriesBegin;
            _writeLogEntriesCompleted = WriteLogEntriesCompleted;
        }

        /// <summary>
        /// Initializes Target
        /// </summary>
        protected override void InitializeTarget()
        {
            _cancelTokenSource = new CancellationTokenSource();

            _platform = _platform ?? Platform.Instance();
            string logId = LogId?.Render(LogEventInfo.CreateNullEvent());
            GaxPreconditions.CheckNotNullOrEmpty(logId, nameof(LogId));

            ActivateLogIdAndResource(logId);

            _client = _client ?? BuildLoggingServiceClient();

            base.InitializeTarget();
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

        /// <summary>
        /// Flushes the Target
        /// </summary>
        protected override void FlushAsync(AsyncContinuation asyncContinuation)
        {
            if (_prevTask != null)
                _prevTask.ContinueWith((prevTask) => asyncContinuation(null), TaskScheduler.Default);
            else
                asyncContinuation(null);    // Nothing to flush
        }

        private LoggingServiceV2Client BuildLoggingServiceClient()
        {
            GoogleCredential credential = GetCredentialFromFile();
            if (credential == null)
            {
                return LoggingServiceV2Client.Create();
            }

            Grpc.Core.Channel channel = new Grpc.Core.Channel(
                LoggingServiceV2Client.DefaultEndpoint.Host,
                LoggingServiceV2Client.DefaultEndpoint.Port,
                Grpc.Auth.GoogleGrpcCredentials.ToChannelCredentials(credential)
            );

            return LoggingServiceV2Client.Create(channel);
        }

        private GoogleCredential GetCredentialFromFile()
        {
            var credentialFile = CredentialFile?.Render(LogEventInfo.CreateNullEvent());
            if (string.IsNullOrWhiteSpace(credentialFile))
            {
                return null;
            }

            GoogleCredential credential = GoogleCredential.FromFile(credentialFile);

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
                // Either platform detection is disabled, or it detected an unknown platform
                // So use the manually configured projectId and override the resource
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
            _logNameToWrite = LogNameOneof.From(logName);
        }

        /// <summary>
        /// 
        /// </summary>
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
        /// 
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
            bool belowTaskLimit = Interlocked.Increment(ref _pendingTaskCount) < TaskPendingLimit;

            try
            {
                if (!belowTaskLimit)
                {
                    InternalLogger.Debug("GoogleStackdriver(Name={0}): Throttle started because {1} tasks are pending", Name, _pendingTaskCount);
                    belowTaskLimit = _prevTask?.Wait(1000, _cancelTokenSource.Token) ?? true; // Throttle
                    if (!belowTaskLimit)
                        InternalLogger.Info("GoogleStackdriver(Name={0}): Throttle timeout but {1} tasks are still pending", Name, _pendingTaskCount);
                    else
                        _pendingTaskCount = 1;
                }

                if (belowTaskLimit && _prevTask != null)
                    _prevTask = _prevTask.ContinueWith(_writeLogEntriesBegin, logEntries, _cancelTokenSource.Token);
                else
                    _prevTask = WriteLogEntriesBegin(null, logEntries);
                _prevTask = _prevTask.ContinueWith(_writeLogEntriesCompleted, continuationList, _cancelTokenSource.Token);
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
                TextPayload = RenderLogEvent(Layout, loggingEvent),
                Severity = s_levelMap[loggingEvent.Level],
                Timestamp = ConvertToTimestamp(loggingEvent.TimeStamp),
                LogName = _logName,
                Resource = _resource,
            };

            foreach (var combinedProperty in GetAllProperties(loggingEvent))
            {
                if (string.IsNullOrEmpty(combinedProperty.Key))
                    continue;

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
