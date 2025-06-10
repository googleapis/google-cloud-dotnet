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
using MethodConfig = Google.Api.Gax.Grpc.Gcp.MethodConfig;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Every option from the connection string that affects the creation of a channel/client. This is used
    /// from SessionPoolManager to create separate pools per endpoint/credential/options combination.
    /// </summary>
    internal sealed class SpannerClientCreationOptions : IEquatable<SpannerClientCreationOptions>
    {
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

        internal string UniverseDomain { get; }

        // Credential-related fields; not properties as GetCredentials is used to
        // obtain properties where necessary.

        // May be null
        private readonly string _credentialsFile;
        // May be null
        private readonly ChannelCredentials _credentialsOverride;
        // May be null; _credentialsOverride takes precedence if both this and _credentialsOverride
        // are non-null (which should only happen when connecting to the emulator)
        private readonly GoogleCredential _googleCredential;
        private readonly GcpCallInvokerBuilder _gcpCallInvokerBuilder;

        internal SpannerClientCreationOptions(SpannerConnectionStringBuilder builder)
        {
            _gcpCallInvokerBuilder = new GcpCallInvokerBuilder
            {
                UniverseDomain = builder.UniverseDomain,
                GoogleCredential = builder.GoogleCredential,
                ChannelCredentials = builder.CredentialOverride,
                // If Host and Port are default (i.e. not set by the customer),
                // then set it to null and let EffectiveEndpoint in ClientBuilderBase figure out the endpoint
                Endpoint = SpannerConnectionStringBuilder.DefaultHost.Equals(builder.Host)
                && SpannerConnectionStringBuilder.DefaultPort.Equals(builder.Port) ? null : builder.EndPoint,
                CredentialsPath = !string.IsNullOrEmpty(builder.CredentialFile) ? builder.CredentialFile : null,
                UseJwtAccessWithScopes = true,
                EmulatorDetection = builder.EmulatorDetection,
                EnvironmentVariableProvider = builder.EnvironmentVariableProvider,
                MaximumGrpcChannels = builder.MaximumGrpcChannels,
                MaxConcurrentStreamsLowWatermark = (uint) builder.MaxConcurrentStreamsLowWatermark
            }.MaybeSetEmulatorProperties();

            // Set UniverseDomain related properties
            UniverseDomain = _gcpCallInvokerBuilder.UniverseDomain;

            // Set special emulator properties if necessary
            UsesEmulator = _gcpCallInvokerBuilder.UseEmulator;

            // If the client connects to the emulator use its endpoint (regardless of builder.Endpoint)
            Endpoint = _gcpCallInvokerBuilder.InvokerEffectiveEndpoint;
            _credentialsFile = builder.CredentialFile;

            // If the client connects to the emulator, its credentials will be used (regardless of builder.CredentialOverride)
            _credentialsOverride = _gcpCallInvokerBuilder.ChannelCredentials;
            _googleCredential = _gcpCallInvokerBuilder.GoogleCredential;
            MaximumGrpcChannels = _gcpCallInvokerBuilder.MaximumGrpcChannels;
            MaximumConcurrentStreamsLowWatermark = _gcpCallInvokerBuilder.MaxConcurrentStreamsLowWatermark;
            LeaderRoutingEnabled = builder.EnableLeaderRouting;
            DirectedReadOptions = builder.DirectedReadOptions;

            // TODO: add a way of setting this from the SpannerConnectionStringBuilder.
            GrpcAdapter = GrpcAdapter.GetFallbackAdapter(SpannerClient.ServiceMetadata);

            _gcpCallInvokerBuilder.GrpcAdapter = GrpcAdapter;
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
            // ClientBuilderBase should take care of fetching right creds GoogleCredentials, file based creds or application default creds
            var creds = await _gcpCallInvokerBuilder.CheckAndGetChannelCredentialsAsync().ConfigureAwait(false);
            return creds;
        }

        internal GcpCallInvokerBuilder GetGcpCallInvokerBuilder()
        {
            return _gcpCallInvokerBuilder;
        }

        internal class GcpCallInvokerBuilder : ClientBuilderBase<GcpCallInvoker>
        {
            private const string s_emulatorHostEnvironmentVariable = "SPANNER_EMULATOR_HOST";
            private static readonly string[] s_emulatorEnvironmentVariables = { s_emulatorHostEnvironmentVariable };
            internal int MaximumGrpcChannels { get; set; }
            internal uint MaxConcurrentStreamsLowWatermark { get; set; }
            internal MethodConfig[] MethodConfigs { private get; set; }
            public GcpCallInvokerBuilder() : base(SpannerClient.ServiceMetadata)
            {
            }

            public override GcpCallInvoker Build() => BuildAsync().Result;

            internal string InvokerEffectiveEndpoint => UseEmulator ? Endpoint : EffectiveEndpoint;

            internal new EmulatorDetection EmulatorDetection
            {
                get => base.EmulatorDetection;
                set => base.EmulatorDetection = value;
            }

            internal Boolean UseEmulator { get; set; }

            internal Func<string, string> EnvironmentVariableProvider { get; set; }

            internal async Task<ChannelCredentials> CheckAndGetChannelCredentialsAsync(CancellationToken cancellationToken=default)
            {
                return await base.GetChannelCredentialsAsync(cancellationToken).ConfigureAwait(false);
            }

            public override async Task<GcpCallInvoker> BuildAsync(CancellationToken cancellationToken = default)
            {
                var endpoint = UseEmulator ? Endpoint : EffectiveEndpoint;
                var credentials = await CheckAndGetChannelCredentialsAsync().ConfigureAwait(false);

                var apiConfig = new ApiConfig
                {
                    ChannelPool = new ChannelPoolConfig
                    {
                        MaxSize = (uint)MaximumGrpcChannels,
                        MaxConcurrentStreamsLowWatermark = MaxConcurrentStreamsLowWatermark
                    },
                    Method = { MethodConfigs }
                };

                var callInvoker = new GcpCallInvoker(SpannerClient.ServiceMetadata, endpoint, credentials, GrpcChannelOptions, apiConfig, GrpcAdapter);
                return callInvoker;
            }
            protected override ChannelPool GetChannelPool() => throw new NotImplementedException();

            internal GcpCallInvokerBuilder MaybeSetEmulatorProperties()
            {
                var emulatorEnvironment = GetEmulatorEnvironment(s_emulatorEnvironmentVariables, s_emulatorEnvironmentVariables, EnvironmentVariableProvider);
                if (emulatorEnvironment is null)
                {
                    UseEmulator = false;
                }
                else
                {
                    // Set Emulator based properties on this builder object
                    UseEmulator = true;
                    Endpoint = emulatorEnvironment[s_emulatorHostEnvironmentVariable];
                    ChannelCredentials = Grpc.Core.ChannelCredentials.Insecure;
                }

                return this;
            }
        }
    }
}
