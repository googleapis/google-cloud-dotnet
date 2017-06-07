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
using Google.Api.Gax;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Logging;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// </summary>
    public sealed class ConnectionPoolOptions
    {
        /// <summary>
        /// The default instance of connection pool options.
        /// </summary>
        public static ConnectionPoolOptions Instance { get; } = new ConnectionPoolOptions();

        /// <summary>
        /// </summary>
        public int MaximumPooledSessions
        {
            get => SessionPool.MaximumPooledSessions;
            set => SessionPool.MaximumPooledSessions = value;
        }

        /// <summary>
        /// </summary>
        public int MaximumActiveSessions
        {
            get => SessionPool.MaximumActiveSessions;
            set => SessionPool.MaximumActiveSessions = value;
        }

        /// <summary>
        /// </summary>
        public TimeSpan KeepAliveInterval { get; set; } = TimeSpan.FromMinutes(55);

        /// <summary>
        /// Sets the log level for diagnostic logs sent to Trace (for desktop) or stderr (for .Net Core).
        /// </summary>
        public LogLevel LogLevel
        {
            get
            {
                var underlyingLevel = (int) Logger.LogLevel;
                return GaxPreconditions.CheckEnumValue((LogLevel) underlyingLevel, nameof(LogLevel));
            }
            set
            {
                var underlyingLevel = (int) value;
                Logger.LogLevel = GaxPreconditions.CheckEnumValue((V1.Logging.LogLevel) underlyingLevel,
                    nameof(LogLevel));
            }
        }

        /// <summary>
        /// </summary>
        public bool LogPerformanceTraces
        {
            get => Logger.LogPerformanceTraces;
            set => Logger.LogPerformanceTraces = value;
        }

        /// <summary>
        /// </summary>
        public int PerformanceTraceLogInterval
        {
            get => Logger.PerformanceTraceLogInterval;
            set => Logger.PerformanceTraceLogInterval = value;
        }

        /// <summary>
        /// </summary>
        public TimeSpan PoolEvictionDelay
        {
            get => SessionPool.PoolEvictionDelay;
            set => SessionPool.PoolEvictionDelay = value;
        }

        /// <summary>
        /// </summary>
        public bool ResetPerformanceTracesEachInterval
        {
            get => Logger.ResetPerformanceTracesEachInterval;
            set => Logger.ResetPerformanceTracesEachInterval = value;
        }

        /// <summary>
        /// </summary>
        public ResourcesExhaustedBehavior ResourcesExhaustedBehavior
        {
            get => SessionPool.WaitOnResourcesExhausted
                ? ResourcesExhaustedBehavior.Block
                : ResourcesExhaustedBehavior.Fail;
            set => SessionPool.WaitOnResourcesExhausted = value == ResourcesExhaustedBehavior.Block;
        }

        /// <summary>
        /// </summary>
        public TimeSpan Timeout
        {
            get => SessionPool.Timeout;
            set => SessionPool.Timeout = value;
        }

        private ConnectionPoolOptions() { }
    }
}
