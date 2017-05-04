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

using Google.Api.Gax;
using System;
using System.Linq;
using System.Threading;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    public static class BigQueryTableExtensions
    {
        private static readonly PollSettings s_defaultStreamingBufferPollSettings =
            new PollSettings(Expiration.FromTimeout(TimeSpan.FromSeconds(30)), TimeSpan.FromSeconds(2));

        /// <summary>
        /// Polls until this table contains at least the given number of rows. This should be used carefully, only where we know the table won't be huge.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method is designed to make integration tests more reliable: after an insert, data fetching (with queries or ListRows)
        /// may not see the new data.
        /// </para>
        /// <para>
        /// We've tried using the data in BigQueryTable.Resource.NumRows and BigQueryTable.Resource.StreamingBuffer, but they're not as reliable as
        /// just reading the rows.
        /// </para>
        /// </remarks>
        /// <param name="expectedRows">The number of rows expected.</param>
        /// <param name="pollSettings">The poll settings to use, or null to use the defaults (poll once every 2 seconds, 30 second timeout)</param>
        /// <returns>The actual number of rows in the table.</returns>
        /// <exception cref="TimeoutException">The timeout specified in the poll settings elapsed before the streaming buffer became empty.</exception>
        public static int PollUntilRowCountIsAtLeast(this BigQueryTable table, int expectedRows, PollSettings pollSettings = null) =>
            Polling.PollRepeatedly(
                ignoredDeadline => table.ListRows().Count(),
                count => count >= expectedRows,
                SystemClock.Instance,
                SystemScheduler.Instance,
                pollSettings ?? s_defaultStreamingBufferPollSettings,
                CancellationToken.None);
    }
}
