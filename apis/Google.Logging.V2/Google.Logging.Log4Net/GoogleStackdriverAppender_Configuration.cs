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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Logging.Log4Net
{
    /// <summary>
    /// Types of metadata that can be attached to log events.
    /// </summary>
    public enum MetaDataType
    {
        Location,
        Identity,
        ThreadName,
        UserName,
        Domain,
        LoggerName,
        Level,
    }

    /// <summary>
    /// Whether log events are queued in memory or to disk. Only in-memory is currently supported. 
    /// </summary>
    public enum LocalQueueType
    {
        /// <summary>
        /// Queue log events in memory before sending to Cloud Logging.
        /// Unsent log events will be lost on program crash.
        /// </summary>
        Memory,

        /// <summary>
        /// Queue log events to disk before sending to Cloud Logging.
        /// Unsent log events will be sent on next program re-start.
        /// Not yet implemented.
        /// </summary>
        Disk,
    }

    public partial class GoogleStackdriverAppender
    {
        /// <summary>
        /// Custom label attached to log events.
        /// </summary>
        public class Label
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }

        /// <summary>
        /// The resource type of log entries. Defaults to "global".
        /// </summary>
        public string ResourceType { get; set; } = "global";

        /// <summary>
        /// The project ID for all log entries. Must be configured.
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// LogID for all log entries. Must be configured.
        /// </summary>
        public string LogId { get; set; }

        /// <summary>
        /// The maximum batch size when uploading to Google Cloud Logging. Defaults to 100.
        /// </summary>
        public int MaxUploadBatchSize { get; set; } = 100;

        /// <summary>
        /// The local queuing mechanism, used before the log is sent to Google Logging.
        /// Defaults to <see cref="LocalQueueType.Memory"/>.
        /// </summary>
        /// <remarks>
        /// <para>All log entries are temporarily queued locally before being uploaded to Google Logging.
        /// This is usually for a very brief duration; but if there are problems connecting to Google Logging
        /// this local queue allows the application to continue functioning as normal, without blocking
        /// on log events or immediately throwing aware log entries.</para>
        /// <para>Two queue types are provided:
        /// <list type="bullet">
        /// <item><description>
        /// <see cref="LocalQueueType.Memory"/>: Log entries are queued locally in memory. The maximum amount of memory and/or the maximum
        /// number of log entries to queue can be configured. If the application exits or crashes before in-memory log entries have
        /// been uploaded to Google Logging, then these log entries are permanently lost. If Google Logging becomes temporarily unavailable
        /// then the number of log entries queued until Google Logging becomes available again will be limited by the configure maximum sizes;
        /// log entries in excess of this configured maximum will cause the oldest queued log entries to be permanently lost.
        /// </description></item>
        /// <item><description>
        /// <see cref="LocalQueueType.Disk"/>: Log entries are queued locally on disk. The maximum file size and file counts can be
        /// configured. If the application exits or crashes before on-disk entries have been uplaoded to Google Logging, then these log
        /// entries will be uploaded to Google Logging on program re-start (assuming the logging disk location is unchanged). If Google
        /// Logging becomes temporarily unavailable then the number of log entries queued until Google Logging becomes available again will
        /// be limited by the configured maximum file size and maxmimum file count. Log entries in excess of this configured maximum will
        /// cause the oldest queued log entries to be permanently lost.
        /// </description></item>
        /// </list>
        /// </para>
        /// </remarks>
        public LocalQueueType LocalQueueType { get; set; } = LocalQueueType.Memory;

        /// <summary>
        /// The maximum bytes of memory used by in-memory logging queue. Defaults to unconfigured.
        /// Not used for file-based queuing.
        /// </summary>
        public long MaxMemorySize { get; set; }

        /// <summary>
        /// The maximum count of log entries allowed in the in-memory logging queue. Defaults to 1,000
        /// Not used for file-based queueing.
        /// </summary>
        public int MaxMemoryCount { get; set; } = 1000;

        /// <summary>
        /// The path prefix to the files that logging will be written to.
        /// </summary>
        public string File { get; set; }

        /// <summary>
        /// The maximum size in bytes that each log file is allowed to reach, before being rolled over. Defaults to 10Mb.
        /// </summary>
        public long MaxFileSize { get; set; } = 10 * 1024 * 1024;

        /// <summary>
        /// The maximum number of backup files that are kept before the oldest is erased. Defaults to 10.
        /// </summary>
        public int MaxSizeRollBackups { get; set; } = 10;

        public void AddCustomLabel(Label label)
        {
            _customLabels.Add(label);
        }

        public void AddWithMetaData(MetaDataType enable)
        {
            _withMetaData.Add(enable);
        }

        /// <summary>
        /// On receiving a server error during log upload, the initial delay in seconds before retry.
        /// </summary>
        public int ServerErrorBackoffDelaySeconds { get; set; } = 1;

        /// <summary>
        /// The multiplier applied to the retry delay when receiving multiple consecutive server errors during log upload.
        /// </summary>
        public double ServerErrorBackoffMultiplier { get; set; } = 1.5;

        /// <summary>
        /// The maxmimum retry delay when receiving multiple consecutive server errors during log upload.
        /// </summary>
        public int ServerErrorBackoffMaxDelaySeconds { get; set; } = 60;
    }
}
