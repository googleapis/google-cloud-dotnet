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
using Google.Cloud.Logging.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Google.Cloud.Diagnostics.Common.IntegrationTests
{
    /// <summary>
    /// An implementation of <see cref="BaseEntryPolling{T}"/> for <see cref="LogEntry"/>s.
    /// </summary>
    internal class LogEntryPolling : BaseEntryPolling<LogEntry>
    {
        /// <summary>Project id to run the test on.</summary>
        private readonly string _projectId = Utils.GetProjectIdFromEnvironment();

        /// <summary>Client to use to send RPCs.</summary>
        private readonly LoggingServiceV2Client _client = LoggingServiceV2Client.Create();

        /// <summary>
        /// Gets log entries that contain the passed in testId in the log message.  Will poll
        /// and wait for the entries to appear.
        /// </summary>
        /// <param name="startTime">The earliest log entry time that will be looked at.</param>
        /// <param name="testId">The test id to filter log entries on.</param>
        /// <param name="minEntries">The minimum number of logs entries that should be waited for.
        ///     If minEntries is zero this method will wait the full timeout before checking for the
        ///     entries.</param>
        public IEnumerable<LogEntry> GetEntries(DateTime startTime, string testId, int minEntries)
        {
            return GetEntries(minEntries, () =>
            {
                // Convert the time to RFC3339 UTC format.
                string time = XmlConvert.ToString(startTime, XmlDateTimeSerializationMode.Utc);
                var request = new ListLogEntriesRequest
                {
                    ResourceNames = { $"projects/{_projectId}" },
                    Filter = $"timestamp >= \"{time}\""
                };

                var results = _client.ListLogEntries(request);
                return results.Where(p => p.TextPayload.Contains(testId)).ToList();
            });
        }
    }
}
