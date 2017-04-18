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
using Google.Cloud.Spanner.V1;

namespace Google.Cloud.Spanner
{
    /// <summary>
    /// </summary>
    public sealed class ConnectionPoolOptions
    {
        /// <summary>
        ///     The default instance of connection pool options.
        /// </summary>
        public static readonly ConnectionPoolOptions s_instance = new ConnectionPoolOptions();

        private ConnectionPoolOptions()
        {
        }

        /// <summary>
        ///     The default instance of connection pool options.
        /// </summary>
        public static ConnectionPoolOptions Instance => s_instance;

        /// <summary>
        /// </summary>
        public TimeSpan KeepAliveIntervalMinutes
        {
            get { return Session.KeepAliveIntervalMinutes; }
            set { Session.KeepAliveIntervalMinutes = value; }
        }

        /// <summary>
        /// </summary>
        public int MaxIdleSessionPoolSize
        {
            get { return SessionPool.MaxIdleSessionPoolSize; }
            set { SessionPool.MaxIdleSessionPoolSize = value; }
        }

        /// <summary>
        /// </summary>
        public int MaxSessionCount
        {
            get { return Session.MaximumActiveSessions; }
            set { Session.MaximumActiveSessions = value; }
        }

        /// <summary>
        /// </summary>
        public ResourcesExhaustedBehavior ResourcesExhaustedBehavior
        {
            get
            {
                return Session.WaitOnResourcesExhausted
                    ? ResourcesExhaustedBehavior.Block
                    : ResourcesExhaustedBehavior.Fail;
            }
            set { Session.WaitOnResourcesExhausted = value == ResourcesExhaustedBehavior.Block; }
        }

        /// <summary>
        /// </summary>
        public int TimeoutMilliseconds { get; set; } = 600000;
    }
}