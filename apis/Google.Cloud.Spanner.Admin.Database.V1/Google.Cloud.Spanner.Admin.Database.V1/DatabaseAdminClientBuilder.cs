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
using Grpc.Core;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Admin.Database.V1
{
    // Partial class to support emulators
    partial class DatabaseAdminClientBuilder
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

        private const string s_emulatorHostEnvironmentVariable = "SPANNER_EMULATOR_HOST";
        private static readonly string[] s_emulatorEnvironmentVariables = { s_emulatorHostEnvironmentVariable };

        partial void InterceptBuild(ref DatabaseAdminClient client) => client = MaybeCreateEmulatorClientBuilder()?.Build();

        partial void InterceptBuildAsync(CancellationToken cancellationToken, ref Task<DatabaseAdminClient> task) =>
            task = MaybeCreateEmulatorClientBuilder()?.BuildAsync(cancellationToken);

        private DatabaseAdminClientBuilder MaybeCreateEmulatorClientBuilder()
        {
            var emulatorEnvironment = GetEmulatorEnvironment(s_emulatorEnvironmentVariables, s_emulatorEnvironmentVariables);
            if (emulatorEnvironment is null)
            {
                return null;
            }
            // We don't set the EmulatorDetection property here to avoid recursively calling
            // MaybeCreateEmulatorClientBuilder().
            var builder = new DatabaseAdminClientBuilder
            {
                Settings = Settings,
                Endpoint = emulatorEnvironment[s_emulatorHostEnvironmentVariable],
                ChannelCredentials = Grpc.Core.ChannelCredentials.Insecure
            };
            builder.CopySettingsForEmulator(this);
            return builder;
        }

        /// <summary>
        /// Creates a gRPC channel for the given endpoint and credentials, using other aspects
        /// specified in this builder (channel options and gRPC adapter).
        /// </summary>
        /// <remarks>This is very rarely needed by user code.</remarks>
        /// <param name="endpoint">The endpoint for the channel.</param>
        /// <param name="credentials">The credentials for the channel.</param>
        /// <returns>A gRPC channel for the specified endpoint and credentials.</returns>
        public new ChannelBase CreateChannel(string endpoint, ChannelCredentials credentials) =>
            base.CreateChannel(endpoint, credentials);
    }
}
