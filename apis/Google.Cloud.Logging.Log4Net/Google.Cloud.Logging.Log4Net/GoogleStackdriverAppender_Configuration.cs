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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Logging.Log4Net
{
    /// <summary>
    /// Types of metadata that can be attached to log events.
    /// </summary>
    public enum MetaDataType
    {
        /// <summary>
        /// The code location of the log entry.
        /// </summary>
        /// <remarks>
        /// This will add the following to labels to every log entry (if available):
        /// <list type="bullet">
        /// <item><description>Location.FileName</description></item>
        /// <item><description>Location.ClassName</description></item>
        /// <item><description>Location.LineNumber</description></item>
        /// </list>
        /// </remarks>
        Location,

        /// <summary>
        /// The string name of the identity of the current thread principal; with the label "Identity".
        /// </summary>
        Identity,

        /// <summary>
        /// The name of the current thread, or the thread ID when the name is not avaible; with the label "ThreadName".
        /// </summary>
        ThreadName,

        /// <summary>
        /// The name of the current user, or "NOT AVAILABLE"; with the label "UserName".
        /// </summary>
        UserName,

        /// <summary>
        /// The AppDomain friendly name; with the label "Domain".
        /// </summary>
        Domain,

        /// <summary>
        /// The name of the logger that logged the event; with the label "LoggerName".
        /// </summary>
        LoggerName,

        /// <summary>
        /// The Level of the logging event; with the label "Level".
        /// </summary>
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

        // TODO: File-base log queue.
    }

    public partial class GoogleStackdriverAppender
    {
        /// <summary>
        /// Custom label attached to log events.
        /// </summary>
        public class Label
        {
            /// <summary>
            /// Label key.
            /// </summary>
            public string Key { get; set; }

            /// <summary>
            /// Label value.
            /// </summary>
            public string Value { get; set; }
        }

        private bool _disableResourceTypeDetection = false;
        /// <summary>
        /// If set, disables resource-type detection based on platform,
        /// so ResourceType will default to "global" if not manually set. 
        /// </summary>
        public bool DisableResourceTypeDetection
        {
            get => _disableResourceTypeDetection;
            set => _disableResourceTypeDetection = ThrowIfActivated(value, nameof(DisableResourceTypeDetection));
        }

        private string _resourceType = null;
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
        /// Unknown: ResourceType "global", with project_id set from this configuration.
        /// </description></item>
        /// </list>
        /// If <see cref="DisableResourceTypeDetection"/> is <c>true</c>, then this platform detection
        /// is not performed, and this ResourceType defaults to "global" if not set.
        /// </remarks>
        public string ResourceType
        {
            get => _resourceType;
            set => _resourceType = ThrowIfActivated(value, nameof(ResourceType));
        }

        /// <summary>
        /// Specify labels for the resource type;
        /// only used if platform detection is disabled or detects an unknown platform.
        /// </summary>
        /// <param name="label">The resource type label.</param>
        public void AddResourceLabel(Label label) => _resourceLabels.Add(ThrowIfActivated(label, nameof(AddResourceLabel)));

        private string _projectId;
        /// <summary>
        /// The project ID for all log entries.
        /// Must be configured in not executing on Google Compute Engine or Google App Engine.
        /// If running on GCE or GAE, the ProjectId will be automatically detected if not set.
        /// </summary>
        public string ProjectId
        {
            get => _projectId;
            set => _projectId = ThrowIfActivated(value, nameof(ProjectId));
        }

        private string _logId;
        /// <summary>
        /// LogID for all log entries. Must be configured.
        /// </summary>
        public string LogId
        {
            get => _logId;
            set => _logId = ThrowIfActivated(value, nameof(LogId));
        }

        private int _maxUploadBatchSize = 100;
        /// <summary>
        /// The maximum batch size when uploading to Google Cloud Logging.
        /// Default value is 100.
        /// </summary>
        public int MaxUploadBatchSize
        {
            get => _maxUploadBatchSize;
            set => _maxUploadBatchSize = ThrowIfActivated(value, nameof(MaxUploadBatchSize));
        }

        private LocalQueueType _localQueueType = LocalQueueType.Memory;
        /// <summary>
        /// The local queuing mechanism, used before the log is sent to Google Logging.
        /// Defaults to <see cref="LocalQueueType.Memory"/>.
        /// </summary>
        /// <remarks>
        /// <para>All log entries are temporarily queued locally before being uploaded to Google Logging.
        /// This is usually for a very brief duration; but if there are problems connecting to Google Logging
        /// this local queue allows the application to continue functioning as normal, without blocking
        /// on log events or immediately throwing aware log entries.</para>
        /// <para>One queue type is provided:
        /// <list type="bullet">
        /// <item><description>
        /// <see cref="LocalQueueType.Memory"/>: Log entries are queued locally in memory. The maximum amount of memory and/or the maximum
        /// number of log entries to queue can be configured. If the application exits or crashes before in-memory log entries have
        /// been uploaded to Google Logging, then these log entries are permanently lost. If Google Logging becomes temporarily unavailable
        /// then the number of log entries queued until Google Logging becomes available again will be limited by the configure maximum sizes;
        /// log entries in excess of this configured maximum will cause the oldest queued log entries to be permanently lost.
        /// </description></item>
        /// </list>
        /// </para>
        /// </remarks>
        public LocalQueueType LocalQueueType
        {
            get => _localQueueType;
            set => _localQueueType = ThrowIfActivated(value, nameof(LocalQueueType));
        }

        private long _maxMemorySize = 0;
        /// <summary>
        /// The maximum bytes of memory used by in-memory logging queue.
        /// Default value is 0 (unconfigured).
        /// Not used for file-based queuing.
        /// </summary>
        public long MaxMemorySize
        {
            get => _maxMemorySize;
            set => _maxMemorySize = ThrowIfActivated(value, nameof(MaxMemorySize));
        }

        private int _maxMemoryCount = 1000;
        /// <summary>
        /// The maximum count of log entries allowed in the in-memory logging queue.
        /// Default value is 1,000
        /// Not used for file-based queueing.
        /// </summary>
        public int MaxMemoryCount
        {
            get => _maxMemoryCount;
            set => _maxMemoryCount = ThrowIfActivated(value, nameof(MaxMemoryCount));
        }

        /// <summary>
        /// Specify custom labels for all log entries.
        /// </summary>
        /// <param name="label">The custom label.</param>
        public void AddCustomLabel(Label label) => _customLabels.Add(ThrowIfActivated(label, nameof(AddCustomLabel)));

        /// <summary>
        /// Specify additional metadata to include in all log entries.
        /// </summary>
        /// <param name="enable">The additional metadata to enable.</param>
        public void AddWithMetaData(MetaDataType enable) => _withMetaData.Add(ThrowIfActivated(enable, nameof(AddWithMetaData)));

        private int _serverErrorBackoffDelaySeconds = 1;
        /// <summary>
        /// On receiving a server error during log upload, the initial delay in seconds before retry.
        /// Defaults value is 1 second.
        /// </summary>
        public int ServerErrorBackoffDelaySeconds
        {
            get => _serverErrorBackoffDelaySeconds;
            set => _serverErrorBackoffDelaySeconds = ThrowIfActivated(value, nameof(ServerErrorBackoffDelaySeconds));
        }

        private double _serverErrorBackoffMultiplier = 1.5;
        /// <summary>
        /// The multiplier applied to the retry delay when receiving multiple consecutive server errors during log upload.
        /// Default value is 1.5
        /// </summary>
        public double ServerErrorBackoffMultiplier
        {
            get => _serverErrorBackoffMultiplier;
            set => _serverErrorBackoffMultiplier = ThrowIfActivated(value, nameof(ServerErrorBackoffMultiplier));
        }

        private int _serverErrorBackoffMaxDelaySeconds = 60;
        /// <summary>
        /// The maxmimum retry delay when receiving multiple consecutive server errors during log upload.
        /// Default value is 60 seconds.
        /// </summary>
        public int ServerErrorBackoffMaxDelaySeconds
        {
            get => _serverErrorBackoffMaxDelaySeconds;
            set => _serverErrorBackoffMaxDelaySeconds = ThrowIfActivated(value, nameof(ServerErrorBackoffMaxDelaySeconds));
        }

        private int _disposeTimeoutSeconds = 30;
        /// <summary>
        /// The maximum time the <c>Dispose()</c> call of <see cref="GoogleStackdriverAppender"/> may take. 
        /// Default value is 30 seconds.
        /// </summary>
        public int DisposeTimeoutSeconds
        {
            get => _disposeTimeoutSeconds;
            set => _disposeTimeoutSeconds = ThrowIfActivated(value, nameof(DisposeTimeoutSeconds));
        }

        private T ThrowIfActivated<T>(T value, string name)
        {
            GaxPreconditions.CheckState(!_isActivated, "Appender already activated; cannot modify '{0}'", name);
            return value;
        }
    }
}
