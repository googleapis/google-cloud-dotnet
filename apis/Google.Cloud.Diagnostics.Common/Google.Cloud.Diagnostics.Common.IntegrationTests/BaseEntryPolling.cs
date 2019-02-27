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
        /// <summary>Default total time to spend sleeping when looking for entries.</summary>
        private static readonly TimeSpan _defaultTimeout = TimeSpan.FromSeconds(10);

        /// <summary>Default time to sleep between checks for entries.</summary>
        private static readonly TimeSpan _defaultSleepInterval = TimeSpan.FromSeconds(5);

        /// <summary>Total time to spend sleeping when looking for entries.</summary>
        private readonly TimeSpan _timeout;

        /// <summary>Time to sleep between checks for entries.</summary>
        private readonly TimeSpan _sleepInterval;

        /// <param name="timeout">Optional, total time to spend sleeping when looking for entries.
        ///     Defaults to <see cref="_defaultTimeout"/>.</param>
        /// <param name="sleepInterval">Optional, time to sleep between checks for entries.
        ///     Defaults to <see cref="_defaultSleepInterval"/></param>
        protected BaseEntryPolling(TimeSpan timeout = default, TimeSpan sleepInterval = default)
        {
            _timeout = timeout == default ? _defaultTimeout : timeout;
            _sleepInterval = sleepInterval == default ?  _defaultSleepInterval : sleepInterval;
        }

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
            List<T> lastFoundEntries = new List<T>();
            while (totalSleepTime < _timeout)
            {
                TimeSpan sleepTime = minEntries > 0 ? _sleepInterval : _timeout;
                totalSleepTime += sleepTime;
                Thread.Sleep(sleepTime);

                lastFoundEntries = getEntries().ToList();
                if (lastFoundEntries.Count >= minEntries)
                {
                    return lastFoundEntries;
                }
            }

            throw new Exception($"Expected to find at least {minEntries} entries. Found {lastFoundEntries.Count} entries.");
        }
    }
}
