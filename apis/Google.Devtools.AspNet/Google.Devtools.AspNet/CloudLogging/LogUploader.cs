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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Logging.V2;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Devtools.AspNet
{
    /// <summary>
    /// Background task that uploads log entries to Google Logging from the local queue.
    /// </summary>
    /// <remarks>
    /// LogUploader waits for log entries to be available in the queue, then retrieves a batch of log entries
    /// from the queue and attempts to upload them to Google Logging. When it is confirmed that these entries
    /// have been uploaded successfully, the entries are removed from the queue.
    /// If Google Logging is unavailable for any reason, upload is retried indefinitely will exponential
    /// backoff up to a configured maxmimum.
    /// </remarks>
    internal sealed class LogUploader
    {
        private static readonly Dictionary<string, string> s_emptyLabels = new Dictionary<string, string>();

        public LogUploader(
            LoggingServiceV2Client client,
            IScheduler scheduler,
            IClock clock,
            ILogQueue logQ,
            LogEntry logsLostWarningTemplate,
            int maxUploadBatchSize,
            BackoffSettings serverErrorBackoffSettings)
        {
            _client = client;
            _scheduler = scheduler;
            _clock = clock;
            _logQ = logQ;
            _logsLostWarningTemplate = logsLostWarningTemplate;
            _maxUploadBatchSize = maxUploadBatchSize;
            _serverErrorBackoffSettings = serverErrorBackoffSettings;
            _uploaderTask = Task.Run(RunUploader);
        }

        private readonly object _lockObj = new object();
        private readonly LoggingServiceV2Client _client;
        private readonly IScheduler _scheduler;
        private readonly IClock _clock;
        private readonly ILogQueue _logQ;
        private readonly LogEntry _logsLostWarningTemplate;
        private readonly int _maxUploadBatchSize;
        private readonly BackoffSettings _serverErrorBackoffSettings;

        private readonly Task _uploaderTask;

        private readonly AsyncAutoResetEvent _uploadReadyEvent = new AsyncAutoResetEvent();
        private readonly AsyncAutoResetEvent _emptyEvent = new AsyncAutoResetEvent();

        private DateTimeRange _logEntriesLost = null;

        public void TriggerUpload(DateTimeRange logEntriesLost)
        {
            lock (_lockObj)
            {
                _logEntriesLost = _logEntriesLost != null ? _logEntriesLost.Union(logEntriesLost) : logEntriesLost;
                _uploadReadyEvent.Set();
            }
        }

        private LogEntry MakeLostEntry(DateTimeRange lostRange)
        {
            var lostEntry = _logsLostWarningTemplate.Clone();
            lostEntry.Timestamp = _clock.GetCurrentDateTimeUtc().ToTimestamp();
            lostEntry.TextPayload = string.Format(lostEntry.TextPayload,
                lostRange.From.ToString(GoogleStackdriverAppender.s_lostDateTimeFmt),
                lostRange.To.ToString(GoogleStackdriverAppender.s_lostDateTimeFmt));
            return lostEntry;
        }

        private async Task RunUploader()
        {
            TimeSpan errorDelay = _serverErrorBackoffSettings.Delay;
            while (true)
            {
                IEnumerable<LogEntryExtra> entries;
                // Wait/loop until there are some log entries that need uploading.
                // TODO: See if log4net can be shutdown. If so, then this loop needs to terminate after
                // all log entries have been uploaded.
                while (true)
                {
                    DateTimeRange logEntriesLost;
                    lock (_lockObj)
                    {
                        logEntriesLost = _logEntriesLost;
                        _logEntriesLost = null;
                    }
                    entries = await _logQ.PeekAsync(_maxUploadBatchSize - (logEntriesLost != null ? 1 : 0));
                    if (logEntriesLost != null)
                    {
                        var lostEntryExtra = new LogEntryExtra(-1, MakeLostEntry(logEntriesLost));
                        entries = (new[] { lostEntryExtra }).Concat(entries ?? Enumerable.Empty<LogEntryExtra>());
                    }
                    if (entries != null && entries.Count() > 0)
                    {
                        // There are log entries that need uploading, so do that now.
                        break;
                    }
                    await _uploadReadyEvent.WaitAsync();
                }
                // Upload entries to the Cloud Logging server
                try
                {
                    await _client.WriteLogEntriesAsync("", null, s_emptyLabels, entries.Select(x => x.Entry));
                    await _logQ.RemoveUntilAsync(entries.Last().Id);
                    _emptyEvent.Set();
                    errorDelay = _serverErrorBackoffSettings.Delay;
                }
                catch (Exception)
                {
                    // Always retry, regardless of error, as there's nothing much else to be done.
                    await _scheduler.Delay(errorDelay);
                    errorDelay = new TimeSpan((long)(errorDelay.Ticks * _serverErrorBackoffSettings.DelayMultiplier));
                    if (errorDelay > _serverErrorBackoffSettings.MaxDelay)
                    {
                        errorDelay = _serverErrorBackoffSettings.MaxDelay;
                    }
                }
            }
        }

        // For testing only.
        public async Task WaitUntilEmptyAsync(TimeSpan timeout)
        {
            var timeoutTask = Task.Delay(timeout);
            while (true)
            {
                if (_logQ.IsEmpty())
                {
                    return;
                }
                Task completed = await Task.WhenAny(_uploaderTask, _emptyEvent.WaitAsync(), timeoutTask);
                if (completed.Exception != null)
                {
                    throw completed.Exception;
                }
                if (timeoutTask.IsCompleted)
                {
                    throw new TimeoutException("Timed-out waiting for log queue to empty.");
                }
            }
        }
    }
}
