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
using Google.Api.Gax.Grpc;
using Google.Api.Gax.Grpc.Gcp;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.V1;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Every option from the connection string that affects the creation of a channel/client. This is used
    /// from SessionPoolManager to create separate pools per endpoint/credential/options combination.
    /// </summary>
    internal sealed class SpannerClientCreationOptions : IEquatable<SpannerClientCreationOptions>
    {
        private static readonly Lazy<Task<ChannelCredentials>> s_defaultCredentialsTaskProvider = new Lazy<Task<ChannelCredentials>>(CreatedScopedDefaultCredentials);

        private static async Task<ChannelCredentials> CreatedScopedDefaultCredentials()
        {
            var appDefaultCredentials = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
            return ConvertGoogleCredential(appDefaultCredentials);
        }

        /// <summary>
        /// The gRPC adapter to create clients with; never null.
        /// </summary>
        internal GrpcAdapter GrpcAdapter { get; }

        /// <summary>
        /// The end-point to connect to; never null.
        /// </summary>
        internal string Endpoint { get; }

        /// <summary>
        /// The number of gRPC channels to use (passed to Grpc.Gcp)
        /// </summary>
        internal int MaximumGrpcChannels { get; }

        /// <summary>
        /// A complicated setting used by Grpc.Gcp :)
        /// (This is used to determine when to use a new channel).
        /// </summary>
        internal uint MaximumConcurrentStreamsLowWatermark { get; }

        internal bool UsesEmulator { get; }

        internal bool LeaderRoutingEnabled { get; }

        internal DirectedReadOptions DirectedReadOptions { get; }

        // Credential-related fields; not properties as GetCredentials is used to
        // obtain properties where necessary.

        // May be null
        private readonly string _credentialsFile;
        // May be null
        private readonly ChannelCredentials _credentialsOverride;
        // May be null; _credentialsOverride takes precedence if both this and _credentialsOverride
        // are non-null (which should only happen when connecting to the emulator)
        private readonly GoogleCredential _googleCredential;

        private string EffectiveUniverseEndpoint { get; }
        internal string UniverseDomain { get; }

        internal SpannerClientCreationOptions(SpannerConnectionStringBuilder builder)
        {
            var emulatorBuilder = new SpannerClientBuilder
            {
                EmulatorDetection = builder.EmulatorDetection,
                EnvironmentVariableProvider = builder.EnvironmentVariableProvider
            }.MaybeCreateEmulatorClientBuilder();
            UsesEmulator = emulatorBuilder is object;
            // If the client connects to the emulator use its endpoint (regardless of builder.Endpoint)
            Endpoint = emulatorBuilder?.Endpoint ?? builder.EndPoint;
            _credentialsFile = builder.CredentialFile;

            // If the client connects to the emulator, use its credentials (regardless of builder.CredentialOverride)
            _credentialsOverride = emulatorBuilder?.ChannelCredentials ?? builder.CredentialOverride;
            _googleCredential = builder.GoogleCredential;
            MaximumGrpcChannels = builder.MaximumGrpcChannels;
            MaximumConcurrentStreamsLowWatermark = (uint) builder.MaxConcurrentStreamsLowWatermark;
            LeaderRoutingEnabled = builder.EnableLeaderRouting;
            DirectedReadOptions = builder.DirectedReadOptions;

            // TODO: add a way of setting this from the SpannerConnectionStringBuilder.
            GrpcAdapter = GrpcAdapter.GetFallbackAdapter(SpannerClient.ServiceMetadata);
        }

        internal async Task<GcpCallInvoker> GetGcpCallInvoker(MethodConfig[] methodConfigs, GrpcChannelOptions grpcChannelOptions)
        {
            var credentials = await GetCredentialsAsync().ConfigureAwait(false);

            var apiConfig = new ApiConfig
            {
                ChannelPool = new ChannelPoolConfig
                {
                    MaxSize = (uint)MaximumGrpcChannels,
                    MaxConcurrentStreamsLowWatermark = MaximumConcurrentStreamsLowWatermark
                },
                Method = { methodConfigs }
            };

            return new GcpCallInvoker(SpannerClient.ServiceMetadata, Endpoint, credentials, grpcChannelOptions, apiConfig, GrpcAdapter);
        }

        internal Task<ChannelCredentials> EffectiveChannelCredentials
        {
            get;
            set;
        }

        public override bool Equals(object obj) => Equals(obj as SpannerClientCreationOptions);

        public bool Equals(SpannerClientCreationOptions other) =>
            other != null &&
            Endpoint.Equals(other.Endpoint) &&
            Equals(_credentialsFile, other._credentialsFile) &&
            Equals(_credentialsOverride, other._credentialsOverride) &&
            Equals(_googleCredential, other._googleCredential) &&
            UsesEmulator == other.UsesEmulator &&
            MaximumGrpcChannels == other.MaximumGrpcChannels &&
            MaximumConcurrentStreamsLowWatermark == other.MaximumConcurrentStreamsLowWatermark &&
            LeaderRoutingEnabled == other.LeaderRoutingEnabled &&
            Equals(DirectedReadOptions, other.DirectedReadOptions) &&
            GrpcAdapter.Equals(other.GrpcAdapter);

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 31;
                hash = hash * 23 + Endpoint.GetHashCode();
                hash = hash * 23 + (_credentialsFile?.GetHashCode() ?? 0);
                hash = hash * 23 + (_credentialsOverride?.GetHashCode() ?? 0);
                hash = hash * 23 + (_googleCredential?.GetHashCode() ?? 0);
                hash = hash * 23 + UsesEmulator.GetHashCode();
                hash = hash * 23 + MaximumGrpcChannels;
                hash = hash * 23 + (int) MaximumConcurrentStreamsLowWatermark;
                hash = hash * 23 + LeaderRoutingEnabled.GetHashCode();
                hash = hash * 23 + (DirectedReadOptions?.GetHashCode() ?? 0);
                hash = hash * 23 + GrpcAdapter.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// Provides a diagnostic string representation of the channel options. The format may change over time.
        /// </summary>
        /// <returns>A diagnostic string representation of this value.</returns>
        public override string ToString()
        {
            var builder = new StringBuilder($"EndPoint: {Endpoint}");
            if (!string.IsNullOrEmpty(_credentialsFile))
            {
                builder.Append($"; CredentialsFile: {_credentialsFile}");
            }
            if (_credentialsOverride is not null)
            {
                builder.Append($"; CredentialsOverride: True");
            }
            if (_googleCredential is not null)
            {
                builder.Append($"; GoogleCredential: True");
            }
            builder.Append($"; UsesEmulator: {UsesEmulator}");
            builder.Append($"; MaximumGrpcChannels: {MaximumGrpcChannels}");
            builder.Append($"; MaximumConcurrentStreamsLowWatermark: {MaximumConcurrentStreamsLowWatermark}");
            builder.Append($"; LeaderRoutingEnabled: {LeaderRoutingEnabled}");
            builder.Append($"; DirectedReadOptions: {DirectedReadOptions?.ToString() ?? "None"}");
            builder.Append($"; GrpcAdapter: {GrpcAdapter.GetType().Name}");
            return builder.ToString();
        }

        /// <summary>
        /// Returns the credentials specified in the options, or the application default credentials if no credentials are in the options.
        /// This performs no caching; avoid calling it repeatedly if possible.
        /// </summary>
        internal async Task<ChannelCredentials> GetCredentialsAsync()
        {
            if (_credentialsOverride is not null)
            {
                return _credentialsOverride;
            }
            if (_googleCredential is not null)
            {
                return ConvertGoogleCredential(_googleCredential);
            }
            if (string.IsNullOrEmpty(_credentialsFile))
            {
                return await s_defaultCredentialsTaskProvider.Value.ConfigureAwait(false);
            }

            string file = _credentialsFile;
            string extension = Path.GetExtension(file);
            if (!extension.Equals(".json", StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException($"{nameof(SpannerConnectionStringBuilder.CredentialFile)} should only be set to a JSON file.");
            }

            if (!File.Exists(file) && !Path.IsPathRooted(file))
            {
                string applicationFolder = AppDomain.CurrentDomain.BaseDirectory;

                // Try to find a file relative to the application's base directory.
                file = Path.Combine(applicationFolder, file);
                if (!File.Exists(file))
                {
                    // throw a meaningful error that tells the developer where we looked.
                    throw new FileNotFoundException($"Could not find {_credentialsFile}. (Also looked for {file})");
                }
            }

            var credential = await GoogleCredential.FromFileAsync(file, cancellationToken: default).ConfigureAwait(false);
            return ConvertGoogleCredential(credential);
        }

        private static ChannelCredentials ConvertGoogleCredential(GoogleCredential credential)
        {
            credential = credential.CreateScoped(SpannerClient.DefaultScopes);
            // Use self-signed JWTs for service accounts.
            if (credential.UnderlyingCredential is ServiceAccountCredential serviceCredential)
            {
                credential = GoogleCredential.FromServiceAccountCredential(serviceCredential.WithUseJwtAccessWithScopes(true));
            }
            return credential.ToChannelCredentials();
        }

        internal class GcpCallInvokerBuilder : ClientBuilderBase<SpannerClient>
        {
            private const string s_emulatorHostEnvironmentVariable = "SPANNER_EMULATOR_HOST";
            private static readonly string[] s_emulatorEnvironmentVariables = { s_emulatorHostEnvironmentVariable };
            public GcpCallInvokerBuilder() : base(SpannerClient.ServiceMetadata)
            {
            }

            public override SpannerClient Build() => throw new NotImplementedException();

            internal string InvokerEffectiveEndpoint => base.EffectiveEndpoint;

            internal new EmulatorDetection EmulatorDetection
            {
                get => base.EmulatorDetection;
                set => base.EmulatorDetection = value;
            }

            internal Boolean UseEmulator { get; set; }

            internal Func<string, string> EnvironmentVariableProvider { get; set; }

            internal async Task<ChannelCredentials> CheckAndGetChannelCredentials()
            {
                return await base.GetChannelCredentialsAsync(CancellationToken.None).ConfigureAwait(false);
            }

            public override Task<SpannerClient> BuildAsync(CancellationToken cancellationToken = default) => throw new NotImplementedException();
            protected override ChannelPool GetChannelPool() => throw new NotImplementedException();

            internal void MaybeSetEmulatorProperties()
            {
                var emulatorEnvironment = GetEmulatorEnvironment(s_emulatorEnvironmentVariables, s_emulatorEnvironmentVariables, EnvironmentVariableProvider);
                if (emulatorEnvironment is null)
                {
                    UseEmulator = false;
                    return;
                }

                // Set Emulator based properties on this builder object
                UseEmulator = true;
                Endpoint = emulatorEnvironment[s_emulatorHostEnvironmentVariable];
                ChannelCredentials = Grpc.Core.ChannelCredentials.Insecure;

                // TODO: Check if we need to set any more SpannerSettings for the Emulator here. From previous implementation there is no explicit use of the SpannerSettings set in the Builder created for the Emulator.
            }
        }
    }
}
