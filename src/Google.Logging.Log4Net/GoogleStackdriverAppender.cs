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
using Google.Logging.Type;
using Google.Logging.V2;
using log4net.Appender;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Logging.Log4Net
{
    /// <summary>
    /// Appends logging events to <see cref="https://cloud.google.com/stackdriver/">Google Stackdriver Logging</see>.
    /// </summary>
    /// <remarks>
    /// Logging events are sent to
    /// <see cref="https://cloud.google.com/stackdriver/">Google Stackdriver Logging</see>
    /// asychronously, via a local buffer. This  is to ensure that server errors or increased
    /// network/server latency don't cause slow-downs in the program being logged.
    /// TODO: Explain all the configuration options.
    /// </remarks>
    public sealed partial class GoogleStackdriverAppender : AppenderSkeleton
    {
        // TODO:
        // * Various argument validations
        // * Send unsent logs on program exit? Using AppDomain.ProcessExit
        //   - Note this only allows 2 seconds 

        internal const string s_logsLostWarningMessage = "Logs lost due to insufficient process-local storage: {0} -> {1}";
        internal const string s_lostDateTimeFmt = "yyyy-MM-dd' 'HH:mm:ss'Z'";

        public GoogleStackdriverAppender() { }

        // For testing only.
        internal GoogleStackdriverAppender(LoggingServiceV2Client client,
            IScheduler scheduler, IClock clock)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            _scheduler = GaxPreconditions.CheckNotNull(scheduler, nameof(scheduler));
            _clock = GaxPreconditions.CheckNotNull(clock, nameof(clock));
        }

        private static readonly Dictionary<Level, LogSeverity> s_levelMap = new Dictionary<Level, LogSeverity>
        {
            // Map Log4net levels to Stackdriver LogSeveritys.
            // The following levels are missing from the map:
            //   Level.Off => This is not for use as a logging level
            //   Level.All => This is not for use as a logging level
            //   Level.Log4Net_Debug => Duplicate of Level.Emergency
            //   Level.Fine => Duplicate of Level.Debug
            //   Level.Finer => Duplicate of Level.Trace
            //   Level.Finest => Duplicate of Level.Verbose
            { Level.Emergency, LogSeverity.Emergency },
            { Level.Fatal, LogSeverity.Emergency },
            { Level.Alert, LogSeverity.Alert },
            { Level.Critical, LogSeverity.Critical },
            { Level.Severe, LogSeverity.Critical },
            { Level.Error, LogSeverity.Error },
            { Level.Warn, LogSeverity.Warning },
            { Level.Notice, LogSeverity.Notice },
            { Level.Info, LogSeverity.Info },
            { Level.Debug, LogSeverity.Debug },
            { Level.Trace, LogSeverity.Debug },
            { Level.Verbose, LogSeverity.Debug },
        };

        private object _enqueueLock = new object();
        private string _instanceId = Guid.NewGuid().ToString();
        private LoggingServiceV2Client _client;
        private IScheduler _scheduler;
        private IClock _clock;
        private MonitoredResource _resource;
        private string _logName;
        private ILogQueue _logQ;
        private LogUploader _logUploader;
        private Task _initNextIdTask;
        private long _nextId;

        private List<Label> _customLabels = new List<Label>();
        private HashSet<MetaDataType> _withMetaData = new HashSet<MetaDataType>();

        public override void ActivateOptions()
        {
            base.ActivateOptions();

            // Initialise services if not already initialised for testing
            _client = _client ?? LoggingServiceV2Client.Create();
            _scheduler = _scheduler ?? SystemScheduler.Instance;
            _clock = _clock ?? SystemClock.Instance;

            // Validate configuration
            GaxPreconditions.CheckState(!string.IsNullOrEmpty(ResourceType), $"{nameof(ResourceType)} must be set.");
            GaxPreconditions.CheckState(!string.IsNullOrEmpty(ProjectId), $"{nameof(ProjectId)} must be set.");
            GaxPreconditions.CheckState(!string.IsNullOrEmpty(LogId), $"{nameof(LogId)} must be set.");
            GaxPreconditions.CheckState(MaxUploadBatchSize > 0, $"{nameof(MaxUploadBatchSize)} must be > 0");
            GaxPreconditions.CheckEnumValue<LocalQueueType>(LocalQueueType, nameof(LocalQueueType));
            switch (LocalQueueType)
            {
                case LocalQueueType.Memory:
                    GaxPreconditions.CheckState(MaxMemoryCount > 0 || MaxMemorySize > 0,
                        $"Either {nameof(MaxMemoryCount)} or {nameof(MaxFileSize)} must be configured to be > 0");
                    break;
                case LocalQueueType.Disk:
                    GaxPreconditions.CheckState(!string.IsNullOrEmpty(File), $"{nameof(File)} must be set.");
                    GaxPreconditions.CheckState(MaxFileSize > 0, $"{nameof(MaxFileSize)} must be > 0");
                    GaxPreconditions.CheckState(MaxSizeRollBackups > 0, $"{nameof(MaxSizeRollBackups)} must be > 0");
                    break;
                default:
                    throw new InvalidOperationException("Inconceivable!");
            }
            GaxPreconditions.CheckState(ServerErrorBackoffDelaySeconds >= 1,
                $"{nameof(ServerErrorBackoffDelaySeconds)} must be >= 1 second.");
            GaxPreconditions.CheckState(ServerErrorBackoffMultiplier > 1.1999999,
                $"{nameof(ServerErrorBackoffMultiplier)} must be >= 1.2");
            GaxPreconditions.CheckState(ServerErrorBackoffMaxDelaySeconds >= 20,
                $"{nameof(ServerErrorBackoffMaxDelaySeconds)} must be >= 20 seconds.");

            // Configure the logger from the given configuration
            _logName = LoggingServiceV2Client.FormatLogName(ProjectId, LogId);
            _resource = new MonitoredResource
            {
                Type = ResourceType
            };
            switch (LocalQueueType)
            {
                case LocalQueueType.Memory:
                    _logQ = new MemoryLogQueue(MaxMemorySize, MaxMemoryCount);
                    break;
                case LocalQueueType.Disk:
                    throw new NotImplementedException("File-base local queues not implemented.");
                default:
                    throw new InvalidOperationException("Inconceivable!");
            }
            _initNextIdTask = Task.Run(InitNextId);
            var labels = new Dictionary<string, string>();
            foreach (var customLabel in _customLabels)
            {
                labels.Add(customLabel.Key, customLabel.Value);
            }
            var logsLostWarningEntry = new LogEntry
            {
                TextPayload = s_logsLostWarningMessage,
                Severity = LogSeverity.Warning,
                LogName = _logName,
                Resource = _resource,
                Labels = { labels },
            };
            var serverErrorBackoffSettings = new BackoffSettings
            {
                Delay = TimeSpan.FromSeconds(ServerErrorBackoffDelaySeconds),
                DelayMultiplier = ServerErrorBackoffMultiplier,
                MaxDelay = TimeSpan.FromSeconds(ServerErrorBackoffMaxDelaySeconds),
            };
            _logUploader = new LogUploader(
                _client, _scheduler, _clock,
                _logQ, logsLostWarningEntry, MaxUploadBatchSize,
                serverErrorBackoffSettings);
        }

        private async Task InitNextId()
        {
            _nextId = await _logQ.GetNextIdAsync();
        }

        private LogEntry BuildLogEntry(LoggingEvent loggingEvent)
        {
            var labels = new Dictionary<string, string>();
            if (_withMetaData.Contains(MetaDataType.Location))
            {
                labels.Add(nameof(MetaDataType.Location) + ".FileName", loggingEvent.LocationInformation.FileName);
                labels.Add(nameof(MetaDataType.Location) + ".ClassName", loggingEvent.LocationInformation.ClassName);
                labels.Add(nameof(MetaDataType.Location) + ".LineNumber", loggingEvent.LocationInformation.LineNumber);
            }
            if (_withMetaData.Contains(MetaDataType.Identity))
            {
                labels.Add(nameof(MetaDataType.Identity), loggingEvent.Identity);
            }
            if (_withMetaData.Contains(MetaDataType.ThreadName))
            {
                labels.Add(nameof(MetaDataType.ThreadName), loggingEvent.ThreadName);
            }
            if (_withMetaData.Contains(MetaDataType.UserName))
            {
                labels.Add(nameof(MetaDataType.UserName), loggingEvent.UserName);
            }
            if (_withMetaData.Contains(MetaDataType.Domain))
            {
                labels.Add(nameof(MetaDataType.Domain), loggingEvent.Domain);
            }
            if (_withMetaData.Contains(MetaDataType.LoggerName))
            {
                labels.Add(nameof(MetaDataType.LoggerName), loggingEvent.LoggerName);
            }
            if (_withMetaData.Contains(MetaDataType.Level))
            {
                labels.Add(nameof(MetaDataType.Level), loggingEvent.Level.Name);
            }
            foreach (var customLabel in _customLabels)
            {
                labels.Add(customLabel.Key, customLabel.Value);
            }
            return new LogEntry
            {
                TextPayload = RenderLoggingEvent(loggingEvent),
                Severity = s_levelMap[loggingEvent.Level],
                Timestamp = loggingEvent.TimeStamp.ToTimestamp(),
                LogName = _logName,
                Resource = _resource,
                Labels = { labels },
            };
        }

        private void Write(IEnumerable<LogEntry> logEntries)
        {
            DateTimeRange logEntriesLost;
            lock (_enqueueLock)
            {
                if (_initNextIdTask != null)
                {
                    _initNextIdTask.Wait();
                    _initNextIdTask.Dispose();
                    _initNextIdTask = null;
                }
                var logEntriesExtra = logEntries
                    .Select(entry =>
                    {
                        long id = _nextId++;
                        entry.InsertId = $"{_instanceId}:{id}";
                        return new LogEntryExtra(id, entry);
                    })
                    .ToList();
                logEntriesLost = _logQ.EnqueueAsync(logEntriesExtra);
            }
            _logUploader.TriggerUpload(logEntriesLost);
        }

        protected override void Append(LoggingEvent loggingEvent)
        {
            var entries = new[] { BuildLogEntry(loggingEvent) };
            Write(entries);
        }

        protected override void Append(LoggingEvent[] loggingEvents)
        {
            var entries = loggingEvents.Select(x => BuildLogEntry(x)).ToList();
            Write(entries);
        }

        public Task WaitUntilEmptyAsync(TimeSpan timeout) => _logUploader.WaitUntilEmptyAsync(timeout);
    }
}
