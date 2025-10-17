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
        // Internal for testing purposes
        internal SpannerClientBuilder ClientBuilder { get; }

        internal bool UsesEmulator { get; }

        internal SpannerClientCreationOptions(SpannerConnectionStringBuilder builder)
        {
            var clientBuilder = new SpannerClientBuilder
            {
                EmulatorDetection = builder.EmulatorDetection,
                EnvironmentVariableProvider = builder.EnvironmentVariableProvider,
                Endpoint = builder.ContainsKey(nameof(builder.Host)) || builder.ContainsKey(nameof(builder.Port)) ? builder.EndPoint : null,
#pragma warning disable CS0618 // Temporarily disable warnings for obsolete methods. See b/453009677 for more details.
                CredentialsPath = builder.CredentialFile == "" ? null: builder.CredentialFile,
#pragma warning restore CS0618
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

            clientBuilder.UniverseDomain = clientBuilder.Endpoint is null && builder.ContainsKey(nameof(builder.UniverseDomain)) ? builder.UniverseDomain : null;

            var emulatorBuilder = clientBuilder.MaybeCreateEmulatorClientBuilder();

            UsesEmulator = emulatorBuilder is not null;
            ClientBuilder = emulatorBuilder ?? clientBuilder;
        }

        internal Task<SpannerClient> CreateSpannerClientAsync(SpannerSettings settings) =>
            // TODO: Consider implementing clone in SpannerClientBuilder.
            new SpannerClientBuilder
            {
                // Note we don't copy emulator detection properties because we already took care
                // of emulator detection on the constructor.
                Endpoint = ClientBuilder.Endpoint,
#pragma warning disable CS0618 // Temporarily disable warnings for obsolete methods. See b/453009677 for more details.
                CredentialsPath = ClientBuilder.CredentialsPath,
#pragma warning disable CS0618
                ChannelCredentials = ClientBuilder.ChannelCredentials,
                GoogleCredential = ClientBuilder.GoogleCredential,
                AffinityChannelPoolConfiguration = ClientBuilder.AffinityChannelPoolConfiguration,
                LeaderRoutingEnabled = ClientBuilder.LeaderRoutingEnabled,
                DirectedReadOptions = ClientBuilder.DirectedReadOptions,
                // If we ever have settings of our own, we need to merge those with these.
                Settings = settings,
                UniverseDomain = ClientBuilder.UniverseDomain,
            }.BuildAsync();

        internal DatabaseAdminClientBuilder CreateDatabaseAdminClientBuilder()
        {
            return new DatabaseAdminClientBuilder
            {
                // Note we don't copy emulator detection properties because we already took care
                // of emulator detection on the constructor.
                Endpoint = ClientBuilder.Endpoint,
#pragma warning disable CS0618 // Temporarily disable warnings for obsolete methods. See b/453009677 for more details.
                CredentialsPath = ClientBuilder.CredentialsPath,
#pragma warning restore CS0618
                ChannelCredentials = ClientBuilder.ChannelCredentials,
                GoogleCredential = ClientBuilder.GoogleCredential,
                // If we ever have settings of our own, we need to merge those with these.
                Settings = CreateDatabaseAdminSettings(),
                UniverseDomain = ClientBuilder.UniverseDomain,
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
            Equals(ClientBuilder.Endpoint, other.ClientBuilder.Endpoint) &&
#pragma warning disable CS0618 // Temporarily disable warnings for obsolete methods. See b/453009677 for more details.
            Equals(ClientBuilder.CredentialsPath, other.ClientBuilder.CredentialsPath) &&
#pragma warning restore CS0618
            Equals(ClientBuilder.ChannelCredentials, other.ClientBuilder.ChannelCredentials) &&
            Equals(ClientBuilder.GoogleCredential, other.ClientBuilder.GoogleCredential) &&
            Equals(ClientBuilder.AffinityChannelPoolConfiguration, other.ClientBuilder.AffinityChannelPoolConfiguration) &&
            ClientBuilder.LeaderRoutingEnabled == other.ClientBuilder.LeaderRoutingEnabled &&
            Equals(ClientBuilder.DirectedReadOptions, other.ClientBuilder.DirectedReadOptions) &&
            Equals(ClientBuilder.GrpcAdapter, other.ClientBuilder.GrpcAdapter);

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 31;
                hash = hash * 23 + (ClientBuilder.Endpoint?.GetHashCode() ?? 0);
#pragma warning disable CS0618 // Temporarily disable warnings for obsolete methods. See b/453009677 for more details.
                hash = hash * 23 + (ClientBuilder.CredentialsPath?.GetHashCode() ?? 0);
#pragma warning restore CS0618
                hash = hash * 23 + (ClientBuilder.ChannelCredentials?.GetHashCode() ?? 0);
                hash = hash * 23 + (ClientBuilder.GoogleCredential?.GetHashCode() ?? 0);
                hash = hash * 23 + UsesEmulator.GetHashCode();
                hash = hash * 23 + (ClientBuilder.AffinityChannelPoolConfiguration?.GetHashCode() ?? 0);
                hash = hash * 23 + (ClientBuilder.LeaderRoutingEnabled.GetHashCode());
                hash = hash * 23 + (ClientBuilder.DirectedReadOptions?.GetHashCode() ?? 0);
                hash = hash * 23 + (ClientBuilder.GrpcAdapter?.GetHashCode() ?? 0);
                return hash;
            }
        }

        /// <summary>
        /// Provides a diagnostic string representation of the channel options. The format may change over time.
        /// </summary>
        /// <returns>A diagnostic string representation of this value.</returns>
        public override string ToString()
        {
            var builder = new StringBuilder($"EndPoint: {ClientBuilder.Endpoint ?? "Default"}");
#pragma warning disable CS0618 // Temporarily disable warnings for obsolete methods. See b/453009677 for more details.
            if (!string.IsNullOrEmpty(ClientBuilder.CredentialsPath))
            {
                builder.Append($"; CredentialsFile: {ClientBuilder.CredentialsPath}");
            }
#pragma warning restore CS0618
            if (ClientBuilder.ChannelCredentials is not null)
            {
                builder.Append($"; CredentialsOverride: True");
            }
            if (ClientBuilder.GoogleCredential is not null)
            {
                builder.Append($"; GoogleCredential: True");
            }
            builder.Append($"; UniverseDomain: {ClientBuilder.UniverseDomain ?? SpannerConnectionStringBuilder.DefaultDomain}");
            builder.Append($"; UsesEmulator: {UsesEmulator}");
            builder.Append($"; AffinityChannelPoolConfiguration: {ClientBuilder.AffinityChannelPoolConfiguration?.ToString() ?? "None"}");
            builder.Append($"; LeaderRoutingEnabled: {ClientBuilder.LeaderRoutingEnabled}");
            builder.Append($"; DirectedReadOptions: {ClientBuilder.DirectedReadOptions?.ToString() ?? "None"}");
            builder.Append($"; GrpcAdapter: {ClientBuilder.GrpcAdapter?.GetType().Name ?? "None"}");
            return builder.ToString();
        }
    }
}
