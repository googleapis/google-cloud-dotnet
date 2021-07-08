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
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.V1;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.IO;
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
        private static Lazy<Task<ChannelCredentials>> s_defaultCredentialsTaskProvider = new Lazy<Task<ChannelCredentials>>(CreatedScopedDefaultCredentials);

        private static async Task<ChannelCredentials> CreatedScopedDefaultCredentials()
        {
            var appDefaultCredentials = await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false);
            // TODO: Use a JWT, so no scoping?
            return appDefaultCredentials.CreateScoped(SpannerClient.DefaultScopes).ToChannelCredentials();
        }

        /// <summary>
        /// The end-point to connect to; never null.
        /// </summary>
        internal string Endpoint { get; }

        /// <summary>
        /// Any additional version header to add to the Spanner client.
        /// This should only be set by frameworks that are developed by Google and not by normal end user applications.
        /// </summary>
        internal string AdditionalVersionHeaderName { get; }
        internal string AdditionalVersionHeaderVersion { get; }

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

        // Credential-related fields; not properties as GetCredentials is used to
        // obtain properties where necessary.

        // May be null
        private readonly string _credentialsFile;
        // May be null 
        private readonly ChannelCredentials _credentialsOverride;

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
            AdditionalVersionHeaderName = builder.VersionHeaderName;
            AdditionalVersionHeaderVersion = builder.VersionHeaderVersion;

            // If the client connects to the emulator, use its credentials (regardless of builder.CredentialOverride)
            _credentialsOverride = emulatorBuilder?.ChannelCredentials ?? builder.CredentialOverride;
            MaximumGrpcChannels = builder.MaximumGrpcChannels;
            MaximumConcurrentStreamsLowWatermark = (uint) builder.MaxConcurrentStreamsLowWatermark;
        }

        public override bool Equals(object obj) => Equals(obj as SpannerClientCreationOptions);

        public bool Equals(SpannerClientCreationOptions other) =>
            other != null &&
            Endpoint.Equals(other.Endpoint) &&
            Equals(_credentialsFile, other._credentialsFile) &&
            Equals(_credentialsOverride, other._credentialsOverride) &&
            UsesEmulator == other.UsesEmulator &&
            MaximumGrpcChannels == other.MaximumGrpcChannels &&
            MaximumConcurrentStreamsLowWatermark == other.MaximumConcurrentStreamsLowWatermark &&
            AdditionalVersionHeaderName == other.AdditionalVersionHeaderName &&
            AdditionalVersionHeaderVersion == other.AdditionalVersionHeaderVersion;

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 31;
                hash = hash * 23 + Endpoint.GetHashCode();
                hash = hash * 23 + (_credentialsFile?.GetHashCode() ?? 0);
                hash = hash * 23 + (_credentialsOverride?.GetHashCode() ?? 0);
                hash = hash * 23 + UsesEmulator.GetHashCode();
                hash = hash * 23 + MaximumGrpcChannels;
                hash = hash * 23 + (int) MaximumConcurrentStreamsLowWatermark;
                hash = hash * 23 + (AdditionalVersionHeaderName?.GetHashCode() ?? 0);
                hash = hash * 23 + (AdditionalVersionHeaderVersion?.GetHashCode() ?? 0);
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
            if (_credentialsOverride != null)
            {
                builder.Append($"; CredentialsOverride: True");
            }
            builder.Append($"; UsesEmulator: {UsesEmulator}");
            if (!string.IsNullOrEmpty(AdditionalVersionHeaderName))
            {
                builder.Append($"; AdditionalVersionHeader: {AdditionalVersionHeaderName}/{AdditionalVersionHeaderVersion}");
            }
            return builder.ToString();
        }

        /// <summary>
        /// Returns the credentials specified in the options, or the application default credentials if no credentials are in the options.
        /// This performs no caching; avoid calling it repeatedly if possible.
        /// </summary>
        internal async Task<ChannelCredentials> GetCredentialsAsync()
        {
            if (_credentialsOverride != null)
            {
                return _credentialsOverride;
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

            // TODO: Use JWT instead? (No scopes.)
            // TODO: Use an async overload
            return GoogleCredential.FromFile(file).CreateScoped(SpannerClient.DefaultScopes).ToChannelCredentials();
        }
    }
}
