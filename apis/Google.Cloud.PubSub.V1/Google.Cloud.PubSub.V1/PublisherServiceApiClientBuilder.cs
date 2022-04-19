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
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1
{
    // Partial class to enable emulator support for the low-level client.

    public partial class PublisherServiceApiClientBuilder
    {
        /// <summary>
        /// Additional channel options to use, if any.
        /// </summary>
        internal GrpcChannelOptions ChannelOptions { get; set; }

        /// <inheritdoc />
        protected override GrpcChannelOptions GetChannelOptions() => base.GetChannelOptions().MergedWith(ChannelOptions ?? GrpcChannelOptions.Empty);

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

        private const string s_emulatorHostEnvironmentVariable = "PUBSUB_EMULATOR_HOST";
        private static readonly string[] s_emulatorEnvironmentVariables = { s_emulatorHostEnvironmentVariable };

        partial void InterceptBuild(ref PublisherServiceApiClient client) => client = MaybeCreateEmulatorClientBuilder()?.Build();

        partial void InterceptBuildAsync(CancellationToken cancellationToken, ref Task<PublisherServiceApiClient> task) =>
            task = MaybeCreateEmulatorClientBuilder()?.BuildAsync(cancellationToken);

        private PublisherServiceApiClientBuilder MaybeCreateEmulatorClientBuilder()
        {
            var emulatorEnvironment = GetEmulatorEnvironment(s_emulatorEnvironmentVariables, s_emulatorEnvironmentVariables);
            if (emulatorEnvironment is null)
            {
                return null;
            }
            // We don't set the EmulatorDetection property here to avoid recursively calling
            // MaybeCreateEmulatorClientBuilder().
            var builder =  new PublisherServiceApiClientBuilder
            {
                Settings = Settings,
                Endpoint = emulatorEnvironment[s_emulatorHostEnvironmentVariable],
                ChannelCredentials = ChannelCredentials.Insecure,
                ChannelOptions = ChannelOptions
            };
            builder.CopySettingsForEmulator(this);
            return builder;
        }

        /// <summary>
        /// Creates a channel for this builder, observing any emulator configuration that has been set.
        /// This method is used by PublisherClient, which needs the channel for shutdown purposes.
        /// </summary>
        internal async Task<ChannelBase> CreateChannelAsync(CancellationToken cancellationToken)
        {
            // Note: no need to try to detect the channel pool here, as we know we don't want to use it.
            var effectiveBuilder = MaybeCreateEmulatorClientBuilder() ?? this;
            var endpoint = effectiveBuilder.Endpoint ?? ServiceMetadata.DefaultEndpoint;
            var credentials = await effectiveBuilder.GetChannelCredentialsAsync(cancellationToken).ConfigureAwait(false);
            // FIXME: we don't currently expose enough in GrpcAdapter or ClientBuilderBase to make this work.
            return null;
        }

        /// <summary>
        /// Creates a channel for this builder, observing any emulator configuration that has been set.
        /// This method is used by PublisherClient, which needs the channel for shutdown purposes.
        /// </summary>
        internal ChannelBase CreateChannel()
        {
            // Note: no need to try to detect the channel pool here, as we know we don't want to use it.
            var effectiveBuilder = MaybeCreateEmulatorClientBuilder() ?? this;
            var endpoint = effectiveBuilder.Endpoint ?? ServiceMetadata.DefaultEndpoint;
            var credentials = effectiveBuilder.GetChannelCredentials();
            // FIXME: we don't currently expose enough in GrpcAdapter or ClientBuilderBase to make this work.
            return null;
        }
    }
}
