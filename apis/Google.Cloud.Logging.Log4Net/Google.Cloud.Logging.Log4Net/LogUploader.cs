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
using Google.Cloud.Logging.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Logging.Log4Net
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
            _uploaderTaskCancellation = new CancellationTokenSource();
            _uploaderTask = Task.Run(() => RunUploader(_uploaderTaskCancellation.Token));
        }

        private readonly object _lock = new object();
        private readonly LoggingServiceV2Client _client;
        private readonly IScheduler _scheduler;
        private readonly IClock _clock;
        private readonly ILogQueue _logQ;
        private readonly LogEntry _logsLostWarningTemplate;
        private readonly int _maxUploadBatchSize;
        private readonly BackoffSettings _serverErrorBackoffSettings;

        private readonly Task _uploaderTask;
        private readonly CancellationTokenSource _uploaderTaskCancellation;

        // Set whenever new data is available for upload.
        private readonly AsyncAutoResetEvent _uploadReadyEvent = new AsyncAutoResetEvent();
        // Set whenever data has just been uploaded and locally removed.
        private readonly AsyncAutoResetEvent _uploadCompleteEvent = new AsyncAutoResetEvent();

        private long _maxConfirmedSentId = -1;

        public void TriggerUpload()
        {
            _uploadReadyEvent.Set();
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

        // Note: calls to ConfigureAwait(false) aren't strictly required here,
        // as this method is only ever called in Task.Run, so there won't be a synchronization
        // context, but it's simple and harmless to make it "obviously okay".
        private async Task RunUploader(CancellationToken cancellationToken)
        {
            TimeSpan errorDelay = _serverErrorBackoffSettings.Delay;
            while (true)
            {
                List<LogEntryExtra> entries;
                // Wait/loop until there are some log entries that need uploading.
                while (true)
                {
                    var peek = await _logQ.PeekAsync(_maxUploadBatchSize, cancellationToken).ConfigureAwait(false);
                    var logEntriesLost = peek.Lost;
                    entries = peek.Entries;
                    if (logEntriesLost != null)
                    {
                        var lostEntryExtra = new LogEntryExtra(-1, MakeLostEntry(logEntriesLost));
                        entries = (new[] { lostEntryExtra }).Concat(entries ?? Enumerable.Empty<LogEntryExtra>()).ToList();
                    }
                    if (entries != null && entries.Count() > 0)
                    {
                        // There are log entries that need uploading, so do that now.
                        break;
                    }
                    await _uploadReadyEvent.WaitAsync(cancellationToken).ConfigureAwait(false);
                }
                // Upload entries to the Cloud Logging server
                try
                {
                    await _client.WriteLogEntriesAsync(null, null, s_emptyLabels, entries.Select(x => x.Entry), cancellationToken).ConfigureAwait(false);
                    await _logQ.RemoveUntilAsync(entries.Last().Id, cancellationToken).ConfigureAwait(false);
                    lock (_lock)
                    {
                        _maxConfirmedSentId = entries.Last().Id;
                    }
                    _uploadCompleteEvent.Set();
                    errorDelay = _serverErrorBackoffSettings.Delay;
                }
                catch (Exception e)
                {
                    // Always retry, regardless of error, as there's nothing much else to be done.
                    await _scheduler.Delay(errorDelay, cancellationToken).ConfigureAwait(false);
                    errorDelay = new TimeSpan((long)(errorDelay.Ticks * _serverErrorBackoffSettings.DelayMultiplier));
                    if (errorDelay > _serverErrorBackoffSettings.MaxDelay)
                    {
                        errorDelay = _serverErrorBackoffSettings.MaxDelay;
                    }
                    // Use log4net internal logging to warn user of upload error.
                    // Internal logging can be enabled as described in the "Troubleshooting" section of the log4net FAQ.
                    log4net.Util.LogLog.Warn(typeof(LogUploader), "Error uploading log messages to server.", e);
                }
            }
        }

        public async Task<bool> FlushAsync(long untilId, TimeSpan timeout, CancellationToken cancellationToken)
        {
            // Record the most recently sent id, and attempt to flush until that point.
            var timeoutTask = Task.Delay(timeout);
            while (true)
            {
                lock (_lock)
                {
                    if (_maxConfirmedSentId >= untilId)
                    {
                        return true;
                    }
                }
                // Include waiting on the _uploaderTask so an exception can be thrown if it fails during the flush.
                Task completed = await Task.WhenAny(_uploaderTask, _uploadCompleteEvent.WaitAsync(cancellationToken), timeoutTask).ConfigureAwait(false);
                cancellationToken.ThrowIfCancellationRequested();
                if (completed.Exception != null)
                {
                    throw completed.Exception;
                }
                if (timeoutTask.IsCompleted)
                {
                    return false;
                }
            }
        }

        internal void Close()
        {
            _uploaderTaskCancellation.Cancel();
        }
    }
}
