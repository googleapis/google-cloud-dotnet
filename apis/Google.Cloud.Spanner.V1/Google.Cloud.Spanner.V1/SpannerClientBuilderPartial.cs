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
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1
{
    public partial class SpannerClientBuilder
    {
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

        private const string s_emulatorHostEnvironmentVariable = "SPANNER_EMULATOR_HOST";
        private static readonly string[] s_emulatorEnvironmentVariables = { s_emulatorHostEnvironmentVariable };

        partial void InterceptBuild(ref SpannerClient client) => client = MaybeCreateEmulatorClientBuilder()?.Build();

        partial void InterceptBuildAsync(CancellationToken cancellationToken, ref Task<SpannerClient> task) =>
            task = MaybeCreateEmulatorClientBuilder()?.BuildAsync(cancellationToken);

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
                ChannelCredentials = Grpc.Core.ChannelCredentials.Insecure
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
