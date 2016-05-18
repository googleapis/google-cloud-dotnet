using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Logging.Log4Net
{
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
            File,
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
        /// The local persistance mechanism, used before the log is sent to Google logging.
        /// Defaults to <see cref="LocalQueueType.Memory"/>.
        /// </summary>
        /// <remarks>[TODO: Explaination + various warnings]</remarks>
        public LocalQueueType LocalPersistance { get; set; } = LocalQueueType.Memory;

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
