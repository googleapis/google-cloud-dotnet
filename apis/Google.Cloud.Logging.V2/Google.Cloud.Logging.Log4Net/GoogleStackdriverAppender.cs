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
using Google.Cloud.Logging.Type;
using Google.Cloud.Logging.V2;
using log4net.Appender;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Logging.Log4Net
{
    /// <summary>
    /// Appends logging events to Google Stackdriver Logging.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Logging events are sent to Google Stackdriver Logging asychronously,
    /// via a local buffer. This  is to ensure that server errors or increased
    /// network/server latency don't cause slow-downs in the program being logged.
    /// </para>
    /// <para>
    /// <c>GoogleStackdriverAppender</c> provides two methods of flushing this local buffer.
    /// <list type="bullet">
    /// <item><description>
    /// The <see cref="Flush(TimeSpan, CancellationToken)"/> and <see cref="FlushAsync(TimeSpan, CancellationToken)"/>
    /// flush local buffer entries to Google Stackdriver, waiting a maximum of the specified
    /// <see cref="TimeSpan"/>. These methods return <c>true</c> if all locally buffered
    /// entries were successfully flushed, or <c>false</c> otherwise.
    /// </description></item>
    /// <item><description>
    /// <c>GoogleStackdriverAppender</c> implements <see cref="IDisposable"/>. This calls
    /// <see cref="Flush(TimeSpan, CancellationToken)"/> with the timeout configured in
    /// <see cref="DisposeTimeoutSeconds"/>, then closes the appender so no further logging
    /// can be performed. It is not generally necessary to call <see cref="Dispose"/>.
    /// </description></item>
    /// </list>
    /// </para>
    /// </remarks>
    public sealed partial class GoogleStackdriverAppender : AppenderSkeleton, IDisposable
    {
        // TODO:
        // * Various argument validations
        // * Send unsent logs on program exit? Using AppDomain.ProcessExit
        //   - Note this only allows 2 seconds 

        internal const string s_logsLostWarningMessage = "Logs lost due to insufficient process-local storage: {0} -> {1}";
        internal const string s_lostDateTimeFmt = "yyyy-MM-dd' 'HH:mm:ss'Z'";

        /// <summary>
        /// Construct a Google Stackdriver appender.
        /// </summary>
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
        private Task<long?> _initIdTask;
        private long _currentId = -1; // Initialised here, in case Flush() is called before any log entries written.

        private List<Label> _customLabels = new List<Label>();
        private HashSet<MetaDataType> _withMetaData = new HashSet<MetaDataType>();

        /// <inheritdoc/>
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
            _logName = new LogName(ProjectId, LogId).ToString();
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
            _initIdTask = Task.Run(_logQ.GetPreviousExecutionIdAsync);
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
            var serverErrorBackoffSettings = new BackoffSettings(
                delay: TimeSpan.FromSeconds(ServerErrorBackoffDelaySeconds),
                delayMultiplier: ServerErrorBackoffMultiplier,
                maxDelay: TimeSpan.FromSeconds(ServerErrorBackoffMaxDelaySeconds)
            );
            _logUploader = new LogUploader(
                _client, _scheduler, _clock,
                _logQ, logsLostWarningEntry, MaxUploadBatchSize,
                serverErrorBackoffSettings);
        }

        private LogEntry BuildLogEntry(LoggingEvent loggingEvent)
        {
            const string unknown = "[unknown]";
            var labels = new Dictionary<string, string>();
            if (_withMetaData.Contains(MetaDataType.Location))
            {
                labels.Add(nameof(MetaDataType.Location) + ".FileName", loggingEvent.LocationInformation?.FileName ?? unknown);
                labels.Add(nameof(MetaDataType.Location) + ".ClassName", loggingEvent.LocationInformation?.ClassName ?? unknown);
                labels.Add(nameof(MetaDataType.Location) + ".LineNumber", loggingEvent.LocationInformation?.LineNumber ?? unknown);
            }
            if (_withMetaData.Contains(MetaDataType.Identity))
            {
                labels.Add(nameof(MetaDataType.Identity), loggingEvent.Identity ?? unknown);
            }
            if (_withMetaData.Contains(MetaDataType.ThreadName))
            {
                labels.Add(nameof(MetaDataType.ThreadName), loggingEvent.ThreadName ?? unknown);
            }
            if (_withMetaData.Contains(MetaDataType.UserName))
            {
                labels.Add(nameof(MetaDataType.UserName), loggingEvent.UserName ?? unknown);
            }
            if (_withMetaData.Contains(MetaDataType.Domain))
            {
                labels.Add(nameof(MetaDataType.Domain), loggingEvent.Domain ?? unknown);
            }
            if (_withMetaData.Contains(MetaDataType.LoggerName))
            {
                labels.Add(nameof(MetaDataType.LoggerName), loggingEvent.LoggerName ?? unknown);
            }
            if (_withMetaData.Contains(MetaDataType.Level))
            {
                labels.Add(nameof(MetaDataType.Level), loggingEvent.Level?.Name ?? unknown);
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
                if (_initIdTask != null)
                {
                    _currentId = _initIdTask.Result ?? -1;
                    _initIdTask = null;
                }
                var logEntriesExtra = logEntries
                    .Select(entry =>
                    {
                        long id = ++_currentId;
                        entry.InsertId = $"{_instanceId}:{id}";
                        return new LogEntryExtra(id, entry);
                    })
                    .ToList();
                logEntriesLost = _logQ.Enqueue(logEntriesExtra);
            }
            _logUploader.TriggerUpload(logEntriesLost);
        }

        /// <inheritdoc/>
        protected override void Append(LoggingEvent loggingEvent)
        {
            var entries = new[] { BuildLogEntry(loggingEvent) };
            Write(entries);
        }

        /// <inheritdoc/>
        protected override void Append(LoggingEvent[] loggingEvents)
        {
            var entries = loggingEvents.Select(x => BuildLogEntry(x)).ToList();
            Write(entries);
        }

        /// <summary>
        /// Flush locally buffered log entries to the server.
        /// </summary>
        /// <param name="timeout">The maxmimum time to spend waiting for the flush to complete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.
        /// The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns>A task representing whether the flush completed within the timeout.</returns>
        public Task<bool> FlushAsync(TimeSpan timeout, CancellationToken cancellationToken = default(CancellationToken))
        {
            long untilId;
            lock (_enqueueLock)
            {
                untilId = _currentId;
            }
            return _logUploader.FlushAsync(untilId, timeout, cancellationToken);
        }

        /// <summary>
        /// Flush locally buffered log entries to the server.
        /// </summary>
        /// <param name="timeout">The maxmimum time to spend waiting for the flush to complete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.
        /// The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns>Whether the flush completed within the timeout.</returns>
        public bool Flush(TimeSpan timeout, CancellationToken cancellationToken = default(CancellationToken)) =>
            Task.Run(async () => await FlushAsync(timeout, cancellationToken).ConfigureAwait(false)).Result;

        /// <summary>
        /// Dispose of this appender, by flushing locally buffer entries then closing the appender.
        /// </summary>
        /// <remarks>
        /// The flush timeout is configured using the <c>DisposeTimeoutSeconds</c> configuration option.
        /// This defaults to 30 seconds if not set.
        /// </remarks>
        public void Dispose()
        {
            bool flushSucceeded = Flush(TimeSpan.FromSeconds(DisposeTimeoutSeconds));
            if (!flushSucceeded)
            {
                log4net.Util.LogLog.Warn(typeof(LogUploader), "Dispose() failed to flush log.");
            }
            Close();
        }

        /// <inheritdoc/>
        protected override void OnClose()
        {
            base.OnClose();
            _logUploader.Close();
        }
    }
}
