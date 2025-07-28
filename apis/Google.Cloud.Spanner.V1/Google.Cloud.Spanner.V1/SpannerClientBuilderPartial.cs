// Copyright 2020 Google LLC
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
using Google.Api.Gax.Grpc;
using Google.Api.Gax.Grpc.Gcp;
using Grpc.Core;
using System;
using System.Threading;
using System.Threading.Tasks;
using static Google.Api.Gax.Grpc.Gcp.AffinityConfig.Types;

namespace Google.Cloud.Spanner.V1
{
    public partial class SpannerClientBuilder
    {
        /// <summary>
        /// The Grpc.Gcp method configurations for pool options.
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

        /// <summary>
        /// Specifies how the builder responds to the presence of emulator environment variables.
        /// </summary>
        /// <remarks>
        /// This property defaults to <see cref="EmulatorDetection.None"/>, meaning that
        /// environment variables are ignored.
        /// </remarks>
        public new EmulatorDetection EmulatorDetection
        {
            get => base.EmulatorDetection;
            set => base.EmulatorDetection = value;
        }

        /// <summary>
        /// Specifies whether leader routing is enabled or not. This is true by default.
        /// </summary>
        /// <remarks>
        /// If this value is true some operations will always be explicitly routed to the leader,
        /// some operations will never be explicitly routed to the leader, and some operations will
        /// be routed to the leader depending on the transaction type they are using.
        /// </remarks>
        public bool LeaderRoutingEnabled { get; set; } = true;

        /// <summary>
        /// Specifies which replicas or regions should be used for non-transactional reads or queries.
        /// </summary>
        /// <remarks>
        /// These options will be applied to ExecuteSql, ExecuteStreamingSql, Read and StreamingRead
        /// operations being executed within a single use or read-only transaction. Otherwise, they will
        /// be ignored.
        /// For these options to be automatically applied to requests, use <see cref="PooledSession"/> to execute
        /// operations instead of <see cref="SpannerClient"/> directly.
        /// </remarks>
        public DirectedReadOptions DirectedReadOptions { get; set; }

        /// <summary>
        /// Specifies the configuration to use for the affinity channel pool.
        /// When set, each session will be bound to a gRPC channel meaning that
        /// all commands executed on that session will be executed on that gRPC channel.
        /// May be null, in which case there will be no channel affinity.
        /// Defaults to null.
        /// </summary>
        /// <remarks>
        /// Each client built will hold its own copy of <see cref="AffinityChannelPoolConfiguration"/>,
        /// which means changes made to this value affect clients built after the change but not clients
        /// already built when the change happens.
        /// </remarks>
        public ChannelPoolConfig AffinityChannelPoolConfiguration {  get; set; }

        /// <inheritdoc/>
        /// <remarks>The default channel pool cannot be used when <see cref="AffinityChannelPoolConfiguration"/> is set.</remarks>
        protected override bool CanUseChannelPool => base.CanUseChannelPool && AffinityChannelPoolConfiguration is null;

        private const string s_emulatorHostEnvironmentVariable = "SPANNER_EMULATOR_HOST";
        private static readonly string[] s_emulatorEnvironmentVariables = { s_emulatorHostEnvironmentVariable };

        /// <inheritdoc/>>
        /// <remarks>
        /// Setting <see cref="AffinityChannelPoolConfiguration"/> to true is not compatible with specifying a <see cref="CallInvoker"/>.
        /// </remarks>
        protected override void Validate()
        {
            base.Validate();
            GaxPreconditions.CheckState(CallInvoker is null || AffinityChannelPoolConfiguration is null, "Channel affinity cannot be configured with a custom CallInvoker.");
        }

        partial void InterceptBuild(ref SpannerClient client) => client = MaybeCreateEmulatorClientBuilder()?.Build();

        partial void InterceptBuildAsync(CancellationToken cancellationToken, ref Task<SpannerClient> task) =>
            task = MaybeCreateEmulatorClientBuilder()?.BuildAsync(cancellationToken);

        /// <inheritdoc/>
        protected override CallInvoker CreateCallInvoker() =>
            AffinityChannelPoolConfiguration is null
                ? base.CreateCallInvoker()
                : new GcpCallInvoker(
                    ServiceMetadata,
                    EffectiveEndpoint,
                    GetChannelCredentials(),
                    GetChannelOptions(),
                    GetApiConfig(),
                    EffectiveGrpcAdapter);

        /// <inheritdoc/>
        protected override async Task<CallInvoker> CreateCallInvokerAsync(CancellationToken cancellationToken) =>
            AffinityChannelPoolConfiguration is null
                ? await base.CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false)
                : new GcpCallInvoker(
                    ServiceMetadata,
                    EffectiveEndpoint,
                    await GetChannelCredentialsAsync(cancellationToken).ConfigureAwait(false),
                    GetChannelOptions(),
                    GetApiConfig(),
                    EffectiveGrpcAdapter);

        private ApiConfig GetApiConfig() => new ApiConfig
        {
            // Note: We don't clone AffinityChannelPoolConfiguration because we just pass ApiConfig
            // to the GcpCallInvoker constructor and that clones it.
            ChannelPool = AffinityChannelPoolConfiguration,
            Method = { s_methodConfigs }
        };

        /// <summary>
        /// An environment variable provider function (variable -> value) that is used during
        /// emulator environment detection. This is provided for testability, so that clients are able to test
        /// how they would connect based on emulator environment variables. This is not expected to be used in
        /// production code. The default value of null indicates "use the regular process environment variables".
        /// </summary>
        public Func<string, string> EnvironmentVariableProvider { get; set; }

        /// <summary>
        /// May return a builder that will connect to the emulator under certain conditions.
        /// </summary>
        /// <remarks>
        /// It returns null if the emulator should not be used, e.g. if <see cref="EmulatorDetection"/> is
        /// <see cref="EmulatorDetection.EmulatorOrProduction"/> but the environment variable isn't configured.
        /// Otherwise, returns a builder with the endpoint and credentials set appropriately for the emulator.
        /// </remarks>
        public SpannerClientBuilder MaybeCreateEmulatorClientBuilder()
        {
            var emulatorEnvironment = GetEmulatorEnvironment(s_emulatorEnvironmentVariables, s_emulatorEnvironmentVariables, EnvironmentVariableProvider);
            if (emulatorEnvironment is null)
            {
                return null;
            }
            // We don't set the EmulatorDetection property here to avoid recursively calling
            // MaybeCreateEmulatorClientBuilder().
            var builder = new SpannerClientBuilder
            {
                Settings = Settings,
                Endpoint = emulatorEnvironment[s_emulatorHostEnvironmentVariable],
                ChannelCredentials = ChannelCredentials.Insecure
            };
            builder.CopySettingsForEmulator(this);
            return builder;
        }

        /// <summary>
        /// Copies emulator relevant settings from <paramref name="clientBuilder"/> to this instance.
        /// </summary>
        /// <remarks>
        /// Note that this method effectively hides
        /// <see cref="ClientBuilderBase{TClient}.CopySettingsForEmulator(ClientBuilderBase{TClient})"/>.
        /// </remarks>
        private void CopySettingsForEmulator(SpannerClientBuilder clientBuilder)
        {
            base.CopySettingsForEmulator(clientBuilder);
            LeaderRoutingEnabled = clientBuilder.LeaderRoutingEnabled;
            DirectedReadOptions = clientBuilder.DirectedReadOptions;
            AffinityChannelPoolConfiguration = clientBuilder.AffinityChannelPoolConfiguration;
        }

        internal new T GetEffectiveSettings<T>(T settings) where T : ServiceSettingsBase, new()
        {
            settings = base.GetEffectiveSettings<T>(settings);
            settings ??= new T();

            // settings will always be a SpannerSettings here.
            var spannerSettings = settings as SpannerSettings;
            spannerSettings.LeaderRoutingEnabled = LeaderRoutingEnabled;
            spannerSettings.DirectedReadOptions = DirectedReadOptions?.Clone();

            return settings;
        }
    }
}
