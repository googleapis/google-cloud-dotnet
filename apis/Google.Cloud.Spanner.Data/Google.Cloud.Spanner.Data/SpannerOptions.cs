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
using Google.Cloud.Spanner.V1.Internal.Logging;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Settings for <see cref="SpannerConnection"/>.
    /// </summary>
    public sealed class SpannerOptions
    {
        /// <summary>
        /// The singleton instance of <see cref="SpannerOptions"/>.
        /// </summary>
        public static SpannerOptions Instance { get; } = new SpannerOptions();

        /// <summary>
        /// The maximum number of Spanner sessions that are kept in a pool.
        /// If the number of pooled sessions reaches this level, then additional
        /// Sessions released to the pool will be deleted immediately.
        /// </summary>
        public int MaximumPooledSessions
        {
            get => SessionPool.Default.Options.MaximumPooledSessions;
            set => SessionPool.Default.Options.MaximumPooledSessions = value;
        }

        /// <summary>
        /// The maximum number of sessions that can be in active use by the application.
        /// If this number is reached, then any additional allocations from
        /// the internal session pool will act according to
        /// <see cref="ResourcesExhaustedBehavior"/>. If <see>
        /// <cref>ResourcesExhaustedBehavior.Block</cref>
        /// </see>
        /// , the operation will block until other operations have completed.
        /// If <see>
        /// <cref>ResourcesExhaustedBehavior.Fail</cref>
        /// </see>
        /// , the operation will immediately throw a <see cref="SpannerException"/> with
        /// an error code <see>
        /// <cref>ErrorCode.ResourceExhausted</cref>
        /// </see>.
        /// This number will be similar to the maximum number of simultaneous operations.
        /// </summary>
        public int MaximumActiveSessions
        {
            get => SessionPool.Default.Options.MaximumActiveSessions;
            set => SessionPool.Default.Options.MaximumActiveSessions = value;
        }

        /// <summary>
        /// The maximum number of grpc channels used per credential.
        /// Grpc channels are used in round robin fashion and are assigned to
        /// <see cref="SpannerConnection"/> instances on creation.
        /// </summary>
        public int MaximumGrpcChannels { get; set; } = 4;

        /// <summary>
        /// Spanner sessions expire on the server after 60 minutes. However,
        /// <see cref="SpannerConnection"/> reserves a session for indefinite use
        /// and preserves the session by sending keepalive messages according to this
        /// interval.
        /// It should be set below the session expiry (currently 60 minutes) on the server.
        /// </summary>
        public TimeSpan KeepAliveInterval { get; set; } = TimeSpan.FromMinutes(55);

        /// <summary>
        /// Sets the log level for diagnostic logs sent to Trace (for desktop) or stderr (for .Net Core).
        /// </summary>
        public LogLevel LogLevel
        {
            get
            {
                var underlyingLevel = (int) Logger.DefaultLogger.LogLevel;
                return GaxPreconditions.CheckEnumValue((LogLevel) underlyingLevel, nameof(LogLevel));
            }
            set
            {
                var underlyingLevel = (int) value;
                Logger.DefaultLogger.LogLevel = GaxPreconditions.CheckEnumValue((V1.Internal.Logging.LogLevel) underlyingLevel,
                    nameof(LogLevel));
            }
        }

        /// <summary>
        /// If true, then log messages will be displayed indicating the duration and
        /// count of various internal metrics, which can help identify bottlenecks in an
        /// application.
        /// </summary>
        internal bool LogPerformanceTraces
        {
            get => Logger.DefaultLogger.LogPerformanceTraces;
            set => Logger.DefaultLogger.LogPerformanceTraces = value;
        }

        /// <summary>
        /// Controls the duration between periodic performance trace logs.
        /// </summary>
        internal TimeSpan PerformanceTraceLogInterval
        {
            get => Logger.DefaultLogger.PerformanceTraceLogInterval;
            set => Logger.DefaultLogger.PerformanceTraceLogInterval = value;
        }

        /// <summary>
        /// Specifies the duration which Spanner sessions will remain in the
        /// internal session pool.
        /// After this time expires, the session will be removed from the pool
        /// and deleted.
        /// </summary>
        public TimeSpan PoolEvictionDelay
        {
            get => SessionPool.Default.Options.PoolEvictionDelay;
            set => SessionPool.Default.Options.PoolEvictionDelay = value;
        }

        internal bool ResetPerformanceTracesEachInterval
        {
            get => Logger.DefaultLogger.ResetPerformanceTracesEachInterval;
            set => Logger.DefaultLogger.ResetPerformanceTracesEachInterval = value;
        }

        /// <summary>
        /// Defines the behavior once <see cref="MaximumActiveSessions"/> has been reached.
        /// If <see>
        /// <cref>ResourcesExhaustedBehavior.Block</cref>
        /// </see>
        /// , the operation will block until other operations have completed.
        /// If <see>
        /// <cref>ResourcesExhaustedBehavior.Fail</cref>
        /// </see>
        /// , the operation will immediately throw a <see cref="SpannerException"/> with
        /// an error code <see>
        /// <cref>ErrorCode.ResourceExhausted</cref></see>.
        /// </summary>
        public ResourcesExhaustedBehavior ResourcesExhaustedBehavior
        {
            get => SessionPool.Default.Options.WaitOnResourcesExhausted
                ? ResourcesExhaustedBehavior.Block
                : ResourcesExhaustedBehavior.Fail;
            set => SessionPool.Default.Options.WaitOnResourcesExhausted = value == ResourcesExhaustedBehavior.Block;
        }

        /// <summary>
        /// Defines the default values for <see cref="SpannerCommand.CommandTimeout"/> and
        /// <see cref="SpannerTransaction.CommitTimeout"/> along with all network operations to a Cloud
        /// Spanner database.
        /// Operations sent to the server that take greater than this duration will fail
        /// with a <see cref="SpannerException"/> and error code <see cref="ErrorCode.DeadlineExceeded"/>.
        /// A value of '0' normally indicates that no timeout should be used (it waits an infinite amount of time).
        /// However, if you specify AllowImmediateTimeouts=true in the connection string, '0' will cause a timeout
        /// that expires immediately. This is normally used only for testing purposes.
        /// </summary>
        public int Timeout
        {
            get => SessionPool.Default.Options.Timeout;
            set => SessionPool.Default.Options.Timeout = value;
        }

        /// <summary>
        /// The maximum number of session create operations allowed to occur simultaneously.
        /// Spanner has limits on the number of sessions that can be created concurrently without affecting performance.
        /// This value is not typically changed.
        /// </summary>
        public int MaximumConcurrentSessionCreates
        {
            get => SessionPool.Default.Options.MaximumConcurrentSessionCreates;
            set => SessionPool.Default.Options.MaximumConcurrentSessionCreates = value;
        }

        private SpannerOptions() { }
    }
}
