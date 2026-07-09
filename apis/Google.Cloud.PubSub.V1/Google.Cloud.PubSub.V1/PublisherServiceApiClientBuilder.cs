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
using Grpc.Core;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1
{
    // Partial class to enable emulator support for the low-level client.

    public partial class PublisherServiceApiClientBuilder
    {
        private const string s_emulatorHostEnvironmentVariable = "PUBSUB_EMULATOR_HOST";
        private static readonly string[] s_emulatorEnvironmentVariables = { s_emulatorHostEnvironmentVariable };

        /// <summary>
        /// Additional channel options to use, if any.
        /// </summary>
        private GrpcChannelOptions ChannelOptions { get; set; }

        /// <inheritdoc />
        protected override GrpcChannelOptions GetChannelOptions() => base.GetChannelOptions().MergedWith(ChannelOptions ?? GrpcChannelOptions.Empty);

        private bool ChannelPoolDisabled { get; set; } = false;

        /// <inheritdoc />
        protected override bool CanUseChannelPool => !ChannelPoolDisabled && base.CanUseChannelPool;

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

        internal PublisherServiceApiClientBuilder(PublisherClientBuilder otherBuilder, GrpcChannelOptions extraChannelOptions) : this()
        {
            CopyCommonSettings(otherBuilder);
            Settings = otherBuilder.ApiSettings;
            ChannelPoolDisabled = true;
            ChannelOptions = extraChannelOptions;
        }

        partial void InterceptBuild(ref PublisherServiceApiClient client)
        {
            // Warm up the Application Default Credentials (ADC) if no explicit credentials
            // have been configured. This prevents thread pool starvation during high-load startup
            // scenarios (e.g., rapid scaling on Cloud Run), resolving issue #11092.
            if (Credential is null && ChannelCredentials is null)
            {
                try
                {
                    Google.Apis.Auth.OAuth2.GoogleCredential.GetApplicationDefault();
                }
                catch (System.Exception)
                {
                    // Silence exceptions to let the standard initialization flow or
                    // emulator detection handle any credential validation errors.
                }
            }

            client = MaybeCreateEmulatorClientBuilder()?.Build();
        }

        partial void InterceptBuildAsync(CancellationToken cancellationToken, ref Task<PublisherServiceApiClient> task)
        {
            // Ensure credentials are warm and cached before initiating asynchronous channel build,
            // avoiding potential sync-over-async blocking patterns down the line.
            if (Credential is null && ChannelCredentials is null)
            {
                try
                {
                    // Pre-populates the static credentials cache synchronously but safely
                    // to avoid thread pool deadlocks inside the generated async pipeline initialization.
                    Google.Apis.Auth.OAuth2.GoogleCredential.GetApplicationDefault();
                }
                catch (System.Exception)
                {
                    // Fallback to standard pipeline error handling
                }
            }

            // Let the original emulator logic handle the task assignment if applicable.
            // If the emulator is not needed, letting 'task' remain unmodified allows the
            // concrete generated asynchronous BuildAsync flow to execute normally.
            var emulatorBuilder = MaybeCreateEmulatorClientBuilder();
            if (emulatorBuilder is not null)
            {
                task = emulatorBuilder.BuildAsync(cancellationToken);
            }
        }

        private PublisherServiceApiClientBuilder MaybeCreateEmulatorClientBuilder()
        {
            var emulatorEnvironment = GetEmulatorEnvironment(s_emulatorEnvironmentVariables, s_emulatorEnvironmentVariables);
            if (emulatorEnvironment is null)
            {
                return null;
            }
            // We don't set the EmulatorDetection property here to avoid recursively calling
            // MaybeCreateEmulatorClientBuilder().
            var builder = new PublisherServiceApiClientBuilder
            {
                Settings = Settings,
                Endpoint = emulatorEnvironment[s_emulatorHostEnvironmentVariable],
                ChannelCredentials = ChannelCredentials.Insecure,
                ChannelOptions = ChannelOptions
            };
            builder.CopySettingsForEmulator(this);
            return builder;
        }
    }
}
