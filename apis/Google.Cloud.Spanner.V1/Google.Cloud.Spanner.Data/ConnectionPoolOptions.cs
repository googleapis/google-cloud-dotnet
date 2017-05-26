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
using Google.Cloud.Spanner.V1.Logging;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// </summary>
    public sealed class ConnectionPoolOptions
    {
        private ConnectionPoolOptions()
        {
        }

        /// <summary>
        /// The default instance of connection pool options.
        /// </summary>
        public static ConnectionPoolOptions Instance { get; } = new ConnectionPoolOptions();

        /// <summary>
        /// </summary>
        public int MaximumPooledSessions
        {
            get { return SessionPool.MaximumPooledSessions; }
            set { SessionPool.MaximumPooledSessions = value; }
        }

        /// <summary>
        /// </summary>
        public int MaximumActiveSessions
        {
            get { return SessionPool.MaximumActiveSessions; }
            set { SessionPool.MaximumActiveSessions = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public TimeSpan KeepAliveInterval { get; set; } = TimeSpan.FromMinutes(55);

        /// <summary>
        /// Sets the log level for diagnostic logs sent to Trace (for desktop) or stderr (for .Net Core).
        /// </summary>
        public LogLevel LogLevel
        {
            get
            {
                int underlyingLevel = (int)Logger.LogLevel;
                if (Enum.IsDefined(typeof(LogLevel), underlyingLevel))
                {
                    return (LogLevel) underlyingLevel;
                }
                // ReSharper disable once NotResolvedInText
                throw new ArgumentOutOfRangeException("LogLevel");
            }
            set
            {
                int underlyingLevel = (int)value;
                if (Enum.IsDefined(typeof(V1.Logging.LogLevel), underlyingLevel))
                {
                    Logger.LogLevel = (V1.Logging.LogLevel)underlyingLevel;
                }
                // ReSharper disable once NotResolvedInText
                throw new ArgumentOutOfRangeException("LogLevel");
            }
        }

        /// <summary>
        /// </summary>
        public bool LogPerformanceTraces
        {
            get { return Logger.LogPerformanceTraces; }
            set { Logger.LogPerformanceTraces = value; }
        }

        /// <summary>
        /// </summary>
        public int PerformanceTraceLogInterval
        {
            get { return Logger.PerformanceTraceLogInterval; }
            set { Logger.PerformanceTraceLogInterval = value; }
        }

        /// <summary>
        /// </summary>
        public TimeSpan PoolEvictionDelay
        {
            get { return SessionPool.PoolEvictionDelay; }
            set { SessionPool.PoolEvictionDelay = value; }
        }

        /// <summary>
        /// </summary>
        public bool ResetPerformanceTracesEachInterval
        {
            get { return Logger.ResetPerformanceTracesEachInterval; }
            set { Logger.ResetPerformanceTracesEachInterval = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public ResourcesExhaustedBehavior ResourcesExhaustedBehavior
        {
            get
            {
                return SessionPool.WaitOnResourcesExhausted
                    ? ResourcesExhaustedBehavior.Block
                    : ResourcesExhaustedBehavior.Fail;
            }
            set { SessionPool.WaitOnResourcesExhausted = value == ResourcesExhaustedBehavior.Block; }
        }

        /// <summary>
        /// </summary>
        public TimeSpan Timeout
        {
            get { return SessionPool.Timeout; }
            set { SessionPool.Timeout = value; }
        }
    }
}