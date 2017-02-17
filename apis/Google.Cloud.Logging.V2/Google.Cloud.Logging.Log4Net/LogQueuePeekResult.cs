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

namespace Google.Cloud.Logging.Log4Net
{
    /// <summary>
    /// Contains the result of peeking the local log queue:
    /// Log entries to send; and the datetime-range of lost log entries, if relevant.
    /// </summary>
    internal sealed class LogQueuePeekResult
    {
        internal LogQueuePeekResult(List<LogEntryExtra> entries, DateTimeRange lost)
        {
            Entries = entries;
            Lost = lost;
        }

        /// <summary>
        /// Log entries to send.
        /// </summary>
        internal List<LogEntryExtra> Entries { get; }

        /// <summary>
        /// If not <c>null</c>, the datetime-range of lost log entries;
        /// <c>null</c> if no log entries have been lost.
        /// </summary>
        internal DateTimeRange Lost { get; }
    }
}
