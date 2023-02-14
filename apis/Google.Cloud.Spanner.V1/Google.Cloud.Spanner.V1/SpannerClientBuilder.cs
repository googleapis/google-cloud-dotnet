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
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1
{
    // Partial class to support emulators
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
    }
}
