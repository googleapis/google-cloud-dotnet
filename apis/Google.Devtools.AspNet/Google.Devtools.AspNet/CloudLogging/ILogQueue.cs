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
using System.Threading.Tasks;

namespace Google.Devtools.AspNet
{
    internal interface ILogQueue
    {
        /// <summary>
        /// Get the next ID to use for sequential log entry numbering.
        /// </summary>
        /// <returns></returns>
        Task<long> GetNextIdAsync();

        /// <summary>
        /// Enqueue the given log entries
        /// </summary>
        /// <param name="logEntries"></param>
        /// <returns>The daterange lost, or null if nothing lost.</returns>
        DateTimeRange EnqueueAsync(IEnumerable<LogEntryExtra> logEntries);

        /// <summary>
        /// Peek up to the specified maximum number of items.
        /// </summary>
        /// <param name="maximumCount"></param>
        /// <returns></returns>
        Task<IEnumerable<LogEntryExtra>> PeekAsync(int maximumCount);

        /// <summary>
        /// Remove items upto and including the specified ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task RemoveUntilAsync(long id);

        /// <summary>
        /// Is this queue currently empty? For testing only.
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
    }
}
