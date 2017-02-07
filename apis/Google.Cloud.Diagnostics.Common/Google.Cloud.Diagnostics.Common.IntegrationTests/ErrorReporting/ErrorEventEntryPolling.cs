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
using Google.Cloud.ErrorReporting.V1Beta1;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Cloud.ErrorReporting.V1Beta1.QueryTimeRange.Types;

namespace Google.Cloud.Diagnostics.Common.IntegrationTests
{
    /// <summary>
    /// An implementation of <see cref="BaseEntryPolling{T}"/> for <see cref="ErrorEvent"/>s.
    /// </summary>
    internal class ErrorEventEntryPolling : BaseEntryPolling<ErrorEvent>
    {
        /// <summary>A query time range of one hour.</summary>
        private static readonly QueryTimeRange s_oneHour = new QueryTimeRange { Period = Period._1Hour };

        /// <summary>Client to use to send RPCs.</summary>
        private readonly ErrorStatsServiceClient _client = ErrorStatsServiceClient.Create();

        /// <summary>Project to run the test on.</summary>
        private readonly ProjectName _projectName = new ProjectName(Utils.GetProjectIdFromEnvironment());

        /// <summary>
        /// Gets error events that contain the passed in testId in the message.  Will poll
        /// and wait for the entries to appear.
        /// </summary>
        /// <param name="startTime">The earliest error event time that will be looked at.</param>
        /// <param name="testId">The test id to filter error events on.</param>
        /// <param name="minEntries">The minimum number of error events that should be waited for.
        ///     If minEntries is zero this method will wait the full timeout before checking for the
        ///     entries.</param>
        public IEnumerable<ErrorEvent> GetEvents(DateTime startTime, string testId, int minEntries)
        {
            return GetEntries(minEntries, () =>
            {
                List<ErrorEvent> errorEvents = new List<ErrorEvent>();
                var groups = _client.ListGroupStats(_projectName, s_oneHour);
                foreach (var group in groups)
                {
                    ListEventsRequest request = new ListEventsRequest
                    {
                        ProjectName = _projectName.ToString(),
                        GroupId = group.Group.GroupId,
                        TimeRange = s_oneHour
                    };

                    var events = _client.ListEvents(request);
                    errorEvents.AddRange(events.Where(e => e.Message.Contains(testId)));
                }
                return errorEvents;
            });
        }
    }
}
