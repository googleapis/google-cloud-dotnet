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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Google.Cloud.Diagnostics.Common.IntegrationTests
{
    /// <summary>
    /// Abstract class with functions to poll for a list of types.
    /// </summary>
    internal abstract class BaseEntryPolling<T>
    {
        /// <summary>Total time to spend sleeping when looking for entries.</summary>
        private static readonly TimeSpan _timeout = TimeSpan.FromSeconds(10);

        /// <summary>Time to sleep between checks for entries.</summary>
        private static readonly TimeSpan _sleepInterval = TimeSpan.FromSeconds(5);

        /// <summary>
        /// Polls for entries of type <see cref="T"/>.  Will continue to poll until
        /// there are at least the minimum number of entries or the polling times out.
        /// </summary>
        /// <param name="minEntries">The minimum number of entries needed.</param>
        /// <param name="getEntries">Function that will return a <see cref="IEnumerable{T}"/></param>
        /// <returns>The entries or an empty list if not enough entries are found or polling times out.</returns>
        protected IEnumerable<T> GetEntries(int minEntries, Func<IEnumerable<T>> getEntries)
        {
            TimeSpan totalSleepTime = TimeSpan.Zero;
            while (totalSleepTime < _timeout)
            {
                TimeSpan sleepTime = minEntries > 0 ? _sleepInterval : _timeout;
                totalSleepTime += sleepTime;
                Thread.Sleep(sleepTime);

                IEnumerable<T> entries = getEntries();
                if (minEntries == 0 || entries.Count() >= minEntries)
                {
                    return entries;
                }
            }
            return new List<T>();
        }
    }
}
