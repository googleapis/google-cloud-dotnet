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

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Logging.Log4Net
{
    internal interface ILogQueue
    {
        /// <summary>
        /// Get the latest ID used in a possible previous execution.
        /// </summary>
        /// <returns>The latest ID from a previous exeuction, or <c>null</c> if not relevant.</returns>
        Task<long?> GetPreviousExecutionIdAsync();

        /// <summary>
        /// Enqueue the given log entries.
        /// </summary>
        /// <param name="logEntries"></param>
        /// <remarks>
        /// This enqueues log entries in a local buffer, which are then asynchronously uploaded to Google
        /// Stackdriver. If the local buffer is full, then the oldest locally buffered log entries will
        /// be purged to allow these newer entries to be buffered.
        /// </remarks>
        void Enqueue(IEnumerable<LogEntryExtra> logEntries);

        /// <summary>
        /// Peek up to the specified maximum number of items.
        /// </summary>
        /// <param name="maximumCount">The maximum number of items to retrieve.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the async operation.
        /// The result of the task contains the enumerable of requested items, and any lost datetime-range.</returns>
        Task<LogQueuePeekResult> PeekAsync(int maximumCount, CancellationToken cancellationToken);

        /// <summary>
        /// Remove items up to and including the specified internal sequential ID.
        /// </summary>
        /// <param name="id">The internal sequential ID to remove until.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task that completes when the removal operation is complete.</returns>
        Task RemoveUntilAsync(long id, CancellationToken cancellationToken);
    }
}
