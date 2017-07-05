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

using System;

namespace Google.Cloud.Spanner.V1
{
    internal sealed class SessionPoolOptions
    {
        /// <summary>
        /// Maximum number of active sessions that can be in use by the application at any one time.
        /// </summary>
        public int MaximumActiveSessions { get; set; } = 400;

        /// <summary>
        /// The maximum number of sessions that can be held in the session pool.
        /// </summary>
        public int MaximumPooledSessions { get; set; } = 400;

        /// <summary>
        /// If true, then CreateSessionFromPoolAsync will block until CurrentActiveSessions is less than MaximumActiveSessions
        /// If false, then CreateSessionFromPoolAsync will throw an exception if CurrentActiveSessions is equal to or greater than
        /// MaximumActiveSessions
        /// </summary>
        public bool WaitOnResourcesExhausted { get; set; } = true;

        /// <summary>
        /// The amount of time before sessions get forcibly evicted from the session pool.
        /// A lower value will cause the process to free sessions more aggressively when they get released
        /// at the cost of performance due to lower reuse of sessions.
        /// This value must be less than the expire timer on the Spanner server which is currently set at 60 minutes.
        /// </summary>
        public TimeSpan PoolEvictionDelay { get; set; } = TimeSpan.FromMinutes(15);

        /// <summary>
        /// If set to true, Sessions placed back into the pool will have a new transaction created in the background with
        /// the same settings that were just used.  This will allow a later consumer of this session to skip creating a new
        /// transaction if the options were identical.
        /// </summary>
        public bool UseTransactionWarming { get; set; } = true;

        /// <summary>
        /// The total time allowed for a network call to the Cloud Spanner server, including retries.
        /// </summary>
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(60);
    }
}
