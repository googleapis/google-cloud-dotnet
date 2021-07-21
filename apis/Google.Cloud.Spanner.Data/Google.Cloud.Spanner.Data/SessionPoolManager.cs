// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Grpc.Core;
using Grpc.Gcp;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Grpc.Gcp.AffinityConfig.Types;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Manages sessions used by <see cref="SpannerConnection"/>. This is rarely used
    /// directly by user code; it's public to provide flexibility when custom options are
    /// required.
    /// </summary>
    public sealed class SessionPoolManager
    {
        /// <summary>
        /// Static constructor to ensure that the static initializers aren't run before the first explicit
        /// reference to the class. This in turn ensures that a call to <see cref="Logger.SetDefaultLogger(Logger)" />
        /// before any other code will result in the new logger being picked up by <see cref="SessionPoolManager.Default"/>.
        /// </summary>
        static SessionPoolManager()
        {
        }

        /// <summary>
        /// The default session pool manager, used by <see cref="SpannerConnection"/> unless a different pool
        /// is specified on construction.
        /// </summary>
        public static SessionPoolManager Default { get; } =
            new SessionPoolManager(new SessionPoolOptions(), DefaultSpannerSettings(), Logger.DefaultLogger, CreateClientAsync);

        private readonly Func<SpannerClientCreationOptions, SpannerSettings, Logger, Task<SpannerClient>> _clientFactory;

        private readonly ConcurrentDictionary<SpannerClientCreationOptions, TargetedPool> _targetedPools =
            new ConcurrentDictionary<SpannerClientCreationOptions, TargetedPool>();
        private readonly ConcurrentDictionary<SessionPool, TargetedPool> _poolReverseLookup =
            new ConcurrentDictionary<SessionPool, TargetedPool>();

        /// <summary>
        /// The session pool options used for every <see cref="SessionPool"/> created by this session pool manager.
        /// </summary>
        public SessionPoolOptions SessionPoolOptions { get; }

        /// <summary>
        /// The logger used by this SessionPoolManager and the session pools it creates.
        /// </summary>
        internal Logger Logger { get; }

        /// <summary>
        /// The SpannerSettings used by this SessionPoolManager. These are expected to remain unaltered for the lifetime of the manager.
        /// Currently the default settings are used in all cases, but with the "gccl" version header added to specify the version of Google.Cloud.Spanner.Data
        /// being used.
        /// </summary>
        internal SpannerSettings SpannerSettings { get; }

        private static SpannerSettings AppendVersionHeader(SpannerSettings settings)
        {
            settings.VersionHeaderBuilder.AppendAssemblyVersion("gccl", typeof(SessionPoolManager));
            return settings;
        }

        internal static SpannerSettings DefaultSpannerSettings() => new SpannerSettings();

        /// <summary>
        /// Constructor for test purposes, allowing the SpannerClient creation to be customized (e.g. for
        /// fake clients).
        /// </summary>
        /// <param name="options">The session pool options to use. Must not be null.</param>
        /// <param name="spannerSettings">The SpannerSettings to use. Must not be null.</param>
        /// <param name="logger">The logger to use. Must not be null.</param>
        /// <param name="clientFactory">The client factory delegate to use. Must not be null.</param>
        internal SessionPoolManager(
            SessionPoolOptions options,
            SpannerSettings spannerSettings,
            Logger logger,
            Func<SpannerClientCreationOptions, SpannerSettings, Logger, Task<SpannerClient>> clientFactory)
        {
            SessionPoolOptions = GaxPreconditions.CheckNotNull(options, nameof(options));
            SpannerSettings = AppendVersionHeader(GaxPreconditions.CheckNotNull(spannerSettings, nameof(spannerSettings)));
            Logger = GaxPreconditions.CheckNotNull(logger, nameof(logger));
            _clientFactory = GaxPreconditions.CheckNotNull(clientFactory, nameof(clientFactory));
        }

        /// <summary>
        /// Creates a <see cref="SessionPoolManager"/> with the specified options.
        /// </summary>
        /// <param name="options">The options to use. Must not be null.</param>
        /// <param name="logger">The logger to use. May be null, in which case the default logger is used.</param>
        /// <returns>A <see cref="SessionPoolManager"/> with the given options.</returns>
        public static SessionPoolManager Create(SessionPoolOptions options, Logger logger = null) =>
            new SessionPoolManager(options, DefaultSpannerSettings(), logger ?? Logger.DefaultLogger, CreateClientAsync);

        /// <summary>
        /// Creates a <see cref="SessionPoolManager"/> with the specified SpannerSettings and options.
        /// </summary>
        /// <param name="spannerSettings">The SpannerSettings to use. May be null, in which case the default settings are used.</param>
        /// <param name="options">The options to use. Must not be null.</param>
        /// <param name="logger">The logger to use. May be null, in which case the logger returned by spannerSettings.Logger will be used.
        /// If that is also null, the default logger is used.</param>
        /// <returns>A <see cref="SessionPoolManager"/> with the given options.</returns>
        public static SessionPoolManager Create(SessionPoolOptions options, SpannerSettings spannerSettings, Logger logger = null) =>
            new SessionPoolManager(options, spannerSettings ?? DefaultSpannerSettings(), logger ?? spannerSettings?.Logger ?? Logger.DefaultLogger, CreateClientAsync);

        internal Task<SessionPool> AcquireSessionPoolAsync(SpannerClientCreationOptions options)
        {
            GaxPreconditions.CheckNotNull(options, nameof(options));
            var targetedPool = _targetedPools.GetOrAdd(options, key => new TargetedPool(this, key));
            targetedPool.IncrementConnectionCount();
            return targetedPool.SessionPoolTask;
        }

        /// <summary>
        /// Decrements the connection count associated with a client session pool.
        /// </summary>
        internal void Release(SessionPool sessionPool)
        {
            if (_poolReverseLookup.TryGetValue(sessionPool, out var targetedPool))
            {
                targetedPool.DecrementConnectionCount();
            }
            else
            {
                Logger.Warn("Attempt to release a session pool to the wrong session pool manager");
            }
        }

        /// <summary>
        /// Provides a diagnostic summary of this session pool manager.
        /// </summary>
        /// <returns></returns>
        internal string ToDiagnosticSummary() => string.Join(Environment.NewLine, GetStatistics());

        internal IReadOnlyList<Statistics> GetStatistics() =>
            _targetedPools.ToArray().Select(tp => tp.Value.GetStatisticsSnapshot()).ToList().AsReadOnly();

        internal SessionPool.DatabaseStatistics GetDatabaseStatistics(SpannerClientCreationOptions options, DatabaseName databaseName)
        {
            GaxPreconditions.CheckNotNull(options, nameof(options));
            GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            _targetedPools.TryGetValue(options, out var targetedPool);
            return targetedPool?.SessionPoolOrNull?.GetStatisticsSnapshot(databaseName);
        }

        // TODO: We *may* want a method to get the session pool statistics for a specific database,
        // e.g. GetStatistics(SessionPoolOptions, DatabaseName) but we don't currently have a need for it.
        // It would only be for convenience.

        /// <summary>
        /// A session pool manager that works with a specific target server and credentials.
        /// This class is mostly an implementation detail. It allows the asynchrony of credential aquisition to be handled
        /// cleanly, and implements mostly-diagnostic reference counting.
        /// </summary>
        internal class TargetedPool
        {
            private readonly string _diagnosticName;
            private int _activeConnections;
            internal Task<SessionPool> SessionPoolTask { get; }

            internal TargetedPool(SessionPoolManager parent, SpannerClientCreationOptions channelOptions)
            {
                _diagnosticName = channelOptions.ToString();
                SessionPoolTask = CreateSessionPoolAsync();

                async Task<SessionPool> CreateSessionPoolAsync()
                {
                    var client = await parent._clientFactory.Invoke(channelOptions, parent.SpannerSettings, parent.Logger).ConfigureAwait(false);
                    var pool = new SessionPool(client, parent.SessionPoolOptions);
                    parent._poolReverseLookup.TryAdd(pool, this);
                    return pool;
                }
            }

            internal void IncrementConnectionCount() => Interlocked.Increment(ref _activeConnections);
                
            internal void DecrementConnectionCount() => Interlocked.Decrement(ref _activeConnections);

            internal int ActiveConnections => Interlocked.CompareExchange(ref _activeConnections, 0, 0);

            internal SessionPool SessionPoolOrNull => SessionPoolTask.Status == TaskStatus.RanToCompletion ? SessionPoolTask.Result : null;

            /// <summary>
            /// Returns a snapshot of statistics for all session pools managed by this instance.
            /// </summary>
            internal Statistics GetStatisticsSnapshot()
            {
                SessionPool.Statistics sessionPoolStatistics = SessionPoolOrNull?.GetStatisticsSnapshot();
                return new Statistics(_diagnosticName, ActiveConnections, sessionPoolStatistics);
            }
        }

        internal sealed class Statistics
        {
            internal string DiagnosticName { get; }
            internal int ActiveConnectionCount { get; }
            /// <summary>
            /// Session pool statistics, or null if the session pool has not yet been created.
            /// </summary>
            internal SessionPool.Statistics SessionPoolStatistics { get; }

            internal Statistics(string diagnosticName, int activeConnectionCount, SessionPool.Statistics sessionPoolStatistics)
            {
                DiagnosticName = diagnosticName;
                ActiveConnectionCount = activeConnectionCount;
                SessionPoolStatistics = sessionPoolStatistics;
            }

            public override string ToString()
            {
                var builder = new StringBuilder();
                builder.AppendLine($"Pool for {DiagnosticName}: {ActiveConnectionCount} active SpannerConnections");
                if (SessionPoolStatistics == null)
                {
                    builder.AppendLine("  (SessionPool not created yet.)");
                }
                else
                {
                    foreach (var databaseStatistics in SessionPoolStatistics.PerDatabaseStatistics)
                    {
                        builder.AppendLine($"  {databaseStatistics}");
                    }
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// The Grpc.Gcp method configurations for pool options. These are here rather than at the top of the file
        /// as they're only used in CreateClientAsync.
        /// </summary>
        private static readonly MethodConfig[] s_methodConfigs = new[]
        {
            // Note: Can't use nameof for affinity keys, as we need the original proto field name.

            // Creating a session isn't bound to a channel, but binds the resulting session to that channel
            new MethodConfig
            {
                Name = { "/google.spanner.v1.Spanner/CreateSession" },
                Affinity = new AffinityConfig { AffinityKey = "name", Command = Command.Bind }
            },

            // Batch creating sessions isn't bound to a channel, but binds the resulting sessions to that channel
            new MethodConfig
            {
                Name = { "/google.spanner.v1.Spanner/BatchCreateSessions" },
                Affinity = new AffinityConfig { AffinityKey = "session.name", Command = Command.Bind }
            },

            // Most methods are bound by the session within the request
            new MethodConfig
            {
                // We don't currently use this, but include it for completeness...
                Name = { "/google.spanner.v1.Spanner/GetSession" },
                Affinity = new AffinityConfig { AffinityKey = "name", Command = Command.Bound }
            },
            new MethodConfig
            {
                Name =
                {
                    "/google.spanner.v1.Spanner/ExecuteSql",
                    "/google.spanner.v1.Spanner/ExecuteStreamingSql",
                    "/google.spanner.v1.Spanner/Read",
                    "/google.spanner.v1.Spanner/StreamingRead",
                    "/google.spanner.v1.Spanner/BeginTransaction",
                    "/google.spanner.v1.Spanner/Commit",
                    "/google.spanner.v1.Spanner/Rollback",
                    "/google.spanner.v1.Spanner/PartitionQuery",
                    "/google.spanner.v1.Spanner/PartitionRead",
                },
                Affinity = new AffinityConfig { AffinityKey = "session", Command = Command.Bound }
            },

            // DeleteSession is bound by the session within the request, and removes the key afterwards
            new MethodConfig
            {
                Name = { "/google.spanner.v1.Spanner/DeleteSession" },
                Affinity = new AffinityConfig { AffinityKey = "name", Command = Command.Unbind }
            }
        };

        /// <inheritdoc />
        private static async Task<SpannerClient> CreateClientAsync(SpannerClientCreationOptions channelOptions, SpannerSettings spannerSettings, Logger logger)
        {
            var credentials = await channelOptions.GetCredentialsAsync().ConfigureAwait(false);

            var apiConfig = new ApiConfig
            {
                ChannelPool = new ChannelPoolConfig
                {
                    MaxSize = (uint)channelOptions.MaximumGrpcChannels,
                    MaxConcurrentStreamsLowWatermark = channelOptions.MaximumConcurrentStreamsLowWatermark
                },
                Method = { s_methodConfigs }
            };

            var grpcOptions = new List<ChannelOption>
            {
                // Keep the channel alive for streaming requests.
                new ChannelOption("grpc.keepalive_time_ms", 60_000),
                new ChannelOption(GcpCallInvoker.ApiConfigChannelArg, apiConfig.ToString())
            };

            var callInvoker = new GcpCallInvoker(channelOptions.Endpoint, credentials, grpcOptions);

            return new SpannerClientBuilder
            {
                CallInvoker = callInvoker,
                Settings = spannerSettings
            }.Build();
        }
    }
}
