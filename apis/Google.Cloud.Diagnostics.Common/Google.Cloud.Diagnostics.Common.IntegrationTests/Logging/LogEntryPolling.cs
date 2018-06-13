// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Cloud.Diagnostics.Common.Tests;
using Google.Cloud.Logging.Type;
using Google.Cloud.Logging.V2;
using System;
using System.Collections.Generic;
using System.Xml;

namespace Google.Cloud.Diagnostics.Common.IntegrationTests
{
    /// <summary>
    /// An implementation of <see cref="BaseEntryPolling{T}"/> for <see cref="LogEntry"/>s.
    /// </summary>
    internal class LogEntryPolling : BaseEntryPolling<LogEntry>
    {
        /// <summary>
        /// Default total time to spend sleeping when looking for entries.
        /// More than what <see cref="BaseEntryPolling{T}._defaultTimeout"/>
        /// because logs are taking longer to process.
        /// </summary>
        private static readonly TimeSpan _defaultTimeout = TimeSpan.FromSeconds(180);

        /// <summary>
        /// Default time to sleep between checks for entries.
        /// Consistent with the <see cref="_defaultTimeout"/>.
        /// </summary>
        private static readonly TimeSpan _defaultSleepInterval = TimeSpan.FromSeconds(40);

        /// <summary>Project id to run the test on.</summary>
        private readonly string _projectId = Utils.GetProjectIdFromEnvironment();

        /// <summary>Client to use to send RPCs.</summary>
        private readonly LoggingServiceV2Client _client = LoggingServiceV2Client.Create();

        internal LogEntryPolling(TimeSpan timeout = default) 
            : base(timeout == default ? _defaultTimeout : timeout, timeout == default ? _defaultSleepInterval : default)
        { }

        /// <summary>
        /// Gets log entries that contain the passed in testId in the log message.  Will poll
        /// and wait for the entries to appear.
        /// </summary>
        /// <param name="startTime">The earliest log entry time that will be looked at.</param>
        /// <param name="testId">The test id to filter log entries on.</param>
        /// <param name="minEntries">The minimum number of logs entries that should be waited for.
        ///     If minEntries is zero this method will wait the full timeout before checking for the
        ///     entries.</param>
        /// <param name="minSeverity">The minimum severity a log can be.</param>
        public IEnumerable<LogEntry> GetEntries(DateTime startTime, string testId, int minEntries, LogSeverity minSeverity)
        {
            return GetEntries(minEntries, () =>
            {
                // Convert the time to RFC3339 UTC format.
                string time = XmlConvert.ToString(startTime, XmlDateTimeSerializationMode.Utc);
                var request = new ListLogEntriesRequest
                {
                    ResourceNames = { $"projects/{_projectId}" },
                    Filter = $"timestamp >= \"{time}\" AND jsonPayload.message:\"{testId}\" AND severity >= {minSeverity} AND logName=\"projects/{_projectId}/logs/aspnetcore\"",
                    PageSize = 1000,
                };
                return _client.ListLogEntries(request);
            });
        }
    }
}
