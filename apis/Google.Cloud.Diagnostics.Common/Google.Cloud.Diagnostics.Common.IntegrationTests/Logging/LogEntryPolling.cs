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

using Google.Cloud.ClientTesting;
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
        /// <summary>Project id to run the test on.</summary>
        private readonly string _projectId = TestEnvironment.GetTestProjectId();

        /// <summary>Client to use to send RPCs.</summary>
        private readonly LoggingServiceV2Client _client = LoggingServiceV2Client.Create();

        private LogEntryPolling(TimeSpan? timeout, TimeSpan? sleepInterval)
            : base(timeout, sleepInterval)
        { }

        public static LogEntryPolling Default { get; } = new LogEntryPolling(null, null);

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
        public IEnumerable<LogEntry> GetEntries(DateTimeOffset startTime, string testId, int minEntries, LogSeverity minSeverity)
        {
            return GetEntries(minEntries, () =>
            {
                // Convert the time to RFC3339 UTC format.
                // We substract 5 minutes because on occasion we were polling too fast after startTime
                // and the backend clock was a little behind, we were getting InvalidArgument.
                string time = XmlConvert.ToString(startTime.DateTime - TimeSpan.FromMinutes(5), XmlDateTimeSerializationMode.Utc);
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
