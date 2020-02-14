// Copyright 2019, Google LLC
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
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Builder class for <see cref="FirestoreDb"/>, providing simple configuration of credentials,
    /// endpoint, project ID etc.
    /// </summary>
    public sealed class FirestoreDbBuilder : ClientBuilderBase<FirestoreDb>
    {
        private const string EmulatorHostVariable = "FIRESTORE_EMULATOR_HOST";

        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public FirestoreSettings Settings { get; set; }

        /// <summary>
        /// The ID of the Google Cloud Platform project that contains the database. May be null, in which case
        /// the project will be automatically detected if possible.
        /// </summary>
        public string ProjectId { get; set; }

        // Note: currently internal as only the default database is supported.
        /// <summary>
        /// The ID of the database within the project. May be null, in which case the default database will be used.
        /// </summary>
        internal string DatabaseId { get; set; }

        /// <summary>
        /// Action to receive warning messages. May be null, in which case warnings will be ignored.
        /// </summary>
        public Action<string> WarningLogger { get; set; }

        /// <summary>
        /// A registry for custom converters. May be null.
        /// </summary>
        public ConverterRegistry ConverterRegistry { get; set; }

        private EmulatorDetection _emulatorDetection;

        /// <summary>
        /// Specifies how the builder responds to the presence of the FIRESTORE_EMULATOR_HOST emulator environment variable.
        /// </summary>
        /// <remarks>
        /// This property defaults to <see cref="EmulatorDetection.None"/>, meaning that the environment variable is
        /// ignored.
        /// </remarks>
        public EmulatorDetection EmulatorDetection
        {
            get => _emulatorDetection;
            set => _emulatorDetection = GaxPreconditions.CheckEnumValue(value, nameof(value));
        }

        /// <inheritdoc />
        public override FirestoreDb Build()
        {
            var projectId = ProjectId ?? Platform.Instance().ProjectId;
            var clientBuilder = FirestoreClientBuilder.FromOtherBuilder(this);
            clientBuilder.Settings = Settings;
            ApplyEmulatorSettings(clientBuilder);
            var client = clientBuilder.Build();
            return BuildFromClient(projectId, client);
        }

        /// <inheritdoc />
        public override async Task<FirestoreDb> BuildAsync(CancellationToken cancellationToken = default)
        {
            var projectId = ProjectId ?? (await Platform.InstanceAsync().ConfigureAwait(false)).ProjectId;
            var clientBuilder = FirestoreClientBuilder.FromOtherBuilder(this);
            clientBuilder.Settings = Settings;
            ApplyEmulatorSettings(clientBuilder);
            var client = await clientBuilder.BuildAsync(cancellationToken).ConfigureAwait(false);
            return BuildFromClient(projectId, client);
        }

        // We never end up using these methods, at least with the current implementation
        /// <inheritdoc />
        protected override string GetDefaultEndpoint() =>
            throw new InvalidOperationException($"This method should never execute in {nameof(FirestoreDbBuilder)}");

        /// <inheritdoc />
        protected override IReadOnlyList<string> GetDefaultScopes() =>
            throw new InvalidOperationException($"This method should never execute in {nameof(FirestoreDbBuilder)}");

        /// <inheritdoc />
        protected override ChannelPool GetChannelPool() =>
            throw new InvalidOperationException($"This method should never execute in {nameof(FirestoreDbBuilder)}");

        /// <inheritdoc />
        protected override GrpcAdapter DefaultGrpcAdapter =>
            throw new InvalidOperationException($"This property should never execute in {nameof(FirestoreDbBuilder)}");

        private FirestoreDb BuildFromClient(string projectId, FirestoreClient client) =>
            FirestoreDb.Create(projectId, DatabaseId, client, WarningLogger, ConverterRegistry);

        private void ApplyEmulatorSettings(FirestoreClientBuilder clientBuilder)
        {
            if (EmulatorDetection == EmulatorDetection.None)
            {
                return;
            }

            // Note: we treat present-but-empty environment variables as if they were absent.
            string hostAndPort = Environment.GetEnvironmentVariable(EmulatorHostVariable)?.Trim() ?? "";

            // The emulator output includes something like this:
            // export FIRESTORE_EMULATOR_HOST=::1:8918
            // We need to translate that into "ipv6:[::1]:8918" for gRPC
            if (hostAndPort.StartsWith("::"))
            {
                int colonPortIndex = hostAndPort.LastIndexOf(':');
                string host = hostAndPort.Substring(0, colonPortIndex);
                string colonPort = hostAndPort.Substring(colonPortIndex);
                hostAndPort = $"ipv6:[{host}]{colonPort}";
            }

            var endpoint = string.IsNullOrEmpty(hostAndPort) ? null : hostAndPort;

            // Possibly return early or fail, based on whether or not we've got an endpoint.
            switch (EmulatorDetection)
            {
                case EmulatorDetection.ProductionOnly:
                    GaxPreconditions.CheckState(endpoint == null,
                        "Emulator environment variable is set, contrary to use of {0}.{1}",
                        nameof(EmulatorDetection), nameof(EmulatorDetection.ProductionOnly));
                    return;
                case EmulatorDetection.EmulatorOnly:
                    GaxPreconditions.CheckState(
                        endpoint != null,
                        "Expected {0} environment variable to be set", EmulatorHostVariable);
                    break;
                case EmulatorDetection.EmulatorOrProduction:
                    if (endpoint == null)
                    {
                        return;
                    }
                    break;
            }

            // Check the user hasn't specified anything they shouldn't.
            GaxPreconditions.CheckState(clientBuilder.Endpoint == null, "{0} should not be set when connecting to an emulator", nameof(clientBuilder.Endpoint));
            GaxPreconditions.CheckState(clientBuilder.CallInvoker == null, "{0} should not be set when connecting to an emulator", nameof(clientBuilder.CallInvoker));
            GaxPreconditions.CheckState(clientBuilder.ChannelCredentials == null, "{0} should not be set when connecting to an emulator", nameof(clientBuilder.ChannelCredentials));
            GaxPreconditions.CheckState(clientBuilder.CredentialsPath == null, "{0} should not be set when connecting to an emulator", nameof(clientBuilder.CredentialsPath));
            GaxPreconditions.CheckState(clientBuilder.JsonCredentials == null, "{0} should not be set when connecting to an emulator", nameof(clientBuilder.JsonCredentials));
            GaxPreconditions.CheckState(clientBuilder.Scopes == null, "{0} should not be set when connecting to an emulator", nameof(clientBuilder.Scopes));
            GaxPreconditions.CheckState(clientBuilder.TokenAccessMethod == null, "{0} should not be set when connecting to an emulator", nameof(clientBuilder.TokenAccessMethod));

            // Set the endpoint, channel credentials and header mutation.
            clientBuilder.Endpoint = endpoint;
            clientBuilder.ChannelCredentials = Grpc.Core.ChannelCredentials.Insecure;
            if (clientBuilder.Settings == null)
            {
                clientBuilder.Settings = new FirestoreSettings();
            }
            clientBuilder.Settings.CallSettings = clientBuilder.Settings.CallSettings.MergedWith(CallSettings.FromHeader("Authorization", "Bearer owner"));
        }
    }
}
