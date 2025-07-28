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

using Google.Api.Gax.Grpc.Gcp;
using Google.Cloud.Spanner.Admin.Database.V1;
using Google.Cloud.Spanner.V1;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Every option from the connection string that affects the creation of a channel/client. This is used
    /// from SessionPoolManager to create separate pools per endpoint/credential/options combination.
    /// </summary>
    internal sealed class SpannerClientCreationOptions : IEquatable<SpannerClientCreationOptions>
    {
        private readonly SpannerClientBuilder _clientBuilder;

        internal bool UsesEmulator { get; }

        internal SpannerClientCreationOptions(SpannerConnectionStringBuilder builder)
        {
            var clientBuilder = new SpannerClientBuilder
            {
                EmulatorDetection = builder.EmulatorDetection,
                EnvironmentVariableProvider = builder.EnvironmentVariableProvider,
                Endpoint = builder.Host == SpannerConnectionStringBuilder.DefaultHost && builder.Port == SpannerConnectionStringBuilder.DefaultPort ? null : builder.EndPoint,
                CredentialsPath = builder.CredentialFile == "" ? null: builder.CredentialFile,
                ChannelCredentials = builder.CredentialOverride,
                GoogleCredential = builder.GoogleCredential,
                AffinityChannelPoolConfiguration = new ChannelPoolConfig
                {
                    MaxSize = (uint) builder.MaximumGrpcChannels,
                    MaxConcurrentStreamsLowWatermark = (uint) builder.MaxConcurrentStreamsLowWatermark,
                },
                LeaderRoutingEnabled = builder.EnableLeaderRouting,
                DirectedReadOptions = builder.DirectedReadOptions,
            };

            var emulatorBuilder = clientBuilder.MaybeCreateEmulatorClientBuilder();

            UsesEmulator = emulatorBuilder is not null;
            _clientBuilder = emulatorBuilder ?? clientBuilder;
        }

        internal Task<SpannerClient> CreateSpannerClientAsync(SpannerSettings settings) =>
            // TODO: Consider implementing clone in SpannerClientBuilder.
            new SpannerClientBuilder
            {
                // Note we don't copy emulator detection properties because we already took care
                // of emulator detection on the constructor.
                Endpoint = _clientBuilder.Endpoint,
                CredentialsPath = _clientBuilder.CredentialsPath,
                ChannelCredentials = _clientBuilder.ChannelCredentials,
                GoogleCredential = _clientBuilder.GoogleCredential,
                AffinityChannelPoolConfiguration = _clientBuilder.AffinityChannelPoolConfiguration,
                LeaderRoutingEnabled = _clientBuilder.LeaderRoutingEnabled,
                DirectedReadOptions = _clientBuilder.DirectedReadOptions,
                // If we ever have settings of our own, we need to merge those with these.
                Settings = settings,
            }.BuildAsync();

        internal DatabaseAdminClientBuilder CreateDatabaseAdminClientBuilder()
        {
            return new DatabaseAdminClientBuilder
            {
                // Note we don't copy emulator detection properties because we already took care
                // of emulator detection on the constructor.
                Endpoint = _clientBuilder.Endpoint,
                CredentialsPath = _clientBuilder.CredentialsPath,
                ChannelCredentials = _clientBuilder.ChannelCredentials,
                GoogleCredential = _clientBuilder.GoogleCredential,
                // If we ever have settings of our own, we need to merge those with these.
                Settings = CreateDatabaseAdminSettings(),
            };

            DatabaseAdminSettings CreateDatabaseAdminSettings()
            {
                var settings = new DatabaseAdminSettings();
                settings.VersionHeaderBuilder.AppendAssemblyVersion("gccl", typeof(SpannerCommand));
                return settings;
            }
        }

        public override bool Equals(object obj) => Equals(obj as SpannerClientCreationOptions);

        public bool Equals(SpannerClientCreationOptions other) =>
            other is not null &&
            UsesEmulator == other.UsesEmulator &&
            // TODO: Consider overriding ClientBuilderBase and SpannerClientBuilder Equals, etc.
            Equals(_clientBuilder.Endpoint, other._clientBuilder.Endpoint) &&
            Equals(_clientBuilder.CredentialsPath, other._clientBuilder.CredentialsPath) &&
            Equals(_clientBuilder.ChannelCredentials, other._clientBuilder.ChannelCredentials) &&
            Equals(_clientBuilder.GoogleCredential, other._clientBuilder.GoogleCredential) &&
            Equals(_clientBuilder.AffinityChannelPoolConfiguration, other._clientBuilder.AffinityChannelPoolConfiguration) &&
            _clientBuilder.LeaderRoutingEnabled == other._clientBuilder.LeaderRoutingEnabled &&
            Equals(_clientBuilder.DirectedReadOptions, other._clientBuilder.DirectedReadOptions) &&
            Equals(_clientBuilder.GrpcAdapter, other._clientBuilder.GrpcAdapter);

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 31;
                hash = hash * 23 + (_clientBuilder.Endpoint?.GetHashCode() ?? 0);
                hash = hash * 23 + (_clientBuilder.CredentialsPath?.GetHashCode() ?? 0);
                hash = hash * 23 + (_clientBuilder.ChannelCredentials?.GetHashCode() ?? 0);
                hash = hash * 23 + (_clientBuilder.GoogleCredential?.GetHashCode() ?? 0);
                hash = hash * 23 + UsesEmulator.GetHashCode();
                hash = hash * 23 + (_clientBuilder.AffinityChannelPoolConfiguration?.GetHashCode() ?? 0);
                hash = hash * 23 + (_clientBuilder.LeaderRoutingEnabled.GetHashCode());
                hash = hash * 23 + (_clientBuilder.DirectedReadOptions?.GetHashCode() ?? 0);
                hash = hash * 23 + (_clientBuilder.GrpcAdapter?.GetHashCode() ?? 0);
                return hash;
            }
        }

        /// <summary>
        /// Provides a diagnostic string representation of the channel options. The format may change over time.
        /// </summary>
        /// <returns>A diagnostic string representation of this value.</returns>
        public override string ToString()
        {
            var builder = new StringBuilder($"EndPoint: {_clientBuilder.Endpoint}");
            if (!string.IsNullOrEmpty(_clientBuilder.CredentialsPath))
            {
                builder.Append($"; CredentialsFile: {_clientBuilder.CredentialsPath}");
            }
            if (_clientBuilder.ChannelCredentials is not null)
            {
                builder.Append($"; CredentialsOverride: True");
            }
            if (_clientBuilder.GoogleCredential is not null)
            {
                builder.Append($"; GoogleCredential: True");
            }
            builder.Append($"; UsesEmulator: {UsesEmulator}");
            builder.Append($"; AffinityChannelPoolConfiguration: {_clientBuilder.AffinityChannelPoolConfiguration?.ToString() ?? "None"}");
            builder.Append($"; LeaderRoutingEnabled: {_clientBuilder.LeaderRoutingEnabled}");
            builder.Append($"; DirectedReadOptions: {_clientBuilder.DirectedReadOptions?.ToString() ?? "None"}");
            builder.Append($"; GrpcAdapter: {_clientBuilder.GrpcAdapter?.GetType().Name ?? "None"}");
            return builder.ToString();
        }
    }
}
