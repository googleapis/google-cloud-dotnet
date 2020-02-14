// Copyright 2019 Google LLC
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
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Datastore.V1
{
    /// <summary>
    /// Builder class for <see cref="DatastoreDb"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DatastoreDbBuilder : ClientBuilderBase<DatastoreDb>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public DatastoreSettings Settings { get; set; }

        private EmulatorDetection _emulatorDetection;

        /// <summary>
        /// Specifies how the builder responds to the presence of emulator environment variables as described
        /// by https://cloud.google.com/datastore/docs/tools/datastore-emulator.
        /// </summary>
        /// <remarks>
        /// This property defaults to <see cref="EmulatorDetection.None"/>, meaning that environment variables are
        /// ignored.
        /// </remarks>
        public EmulatorDetection EmulatorDetection
        {
            get => _emulatorDetection;
            set => _emulatorDetection = GaxPreconditions.CheckEnumValue(value, nameof(value));
        }

        /// <summary>
        /// The project ID, or null if this has not yet been configured. Note that a project ID must be configured
        /// (or detected via an emulator environment variable) before building the <see cref="DatastoreDb"/>.
        /// </summary>
        public string ProjectId { get; set; }
        
        /// <summary>
        /// Common code for handling the emulator configuration.
        /// </summary>
        private ConfiguredBuilder PrepareBuilder()
        {
            var clientBuilder = new DatastoreClientBuilder(this);
            clientBuilder.Settings = Settings;
            string projectId = ProjectId;

            if (EmulatorDetection != EmulatorDetection.None)
            {
                var emulatorConfig = EmulatorConfiguration.FromEnvironment();
                switch (EmulatorDetection)
                {
                    case EmulatorDetection.ProductionOnly:
                        GaxPreconditions.CheckState(
                            emulatorConfig.ProjectId == null && emulatorConfig.Endpoint == null,
                            "Emulator environment variables are set, contrary to use of {0}.{1}",
                            nameof(EmulatorDetection), nameof(EmulatorDetection.ProductionOnly));
                        break;
                    case EmulatorDetection.EmulatorOnly:
                        GaxPreconditions.CheckState(
                            emulatorConfig.Endpoint != null,
                            "Expected {0} environment variable to be set", EmulatorConfiguration.EmulatorHostVariable);
                        ApplyEmulatorConfiguration();
                        break;
                    case EmulatorDetection.EmulatorOrProduction:
                        if (emulatorConfig.Endpoint != null)
                        {
                            ApplyEmulatorConfiguration();
                        }
                        else
                        {
                            GaxPreconditions.CheckState(emulatorConfig.ProjectId == null, "{0} should not be set when {1} is not", EmulatorConfiguration.EmulatorProjectVariable, EmulatorConfiguration.EmulatorHostVariable);
                        }
                        break;
                }

                void ApplyEmulatorConfiguration()
                {
                    // TODO: Do we want to require this? Or should a configured emulator override any credentials?
                    GaxPreconditions.CheckState(clientBuilder.Endpoint == null, "{0} should not be set when connecting to an emulator", nameof(clientBuilder.Endpoint));
                    GaxPreconditions.CheckState(clientBuilder.CallInvoker == null, "{0} should not be set when connecting to an emulator", nameof(clientBuilder.CallInvoker));
                    GaxPreconditions.CheckState(clientBuilder.ChannelCredentials == null, "{0} should not be set when connecting to an emulator", nameof(clientBuilder.ChannelCredentials));
                    GaxPreconditions.CheckState(clientBuilder.CredentialsPath == null, "{0} should not be set when connecting to an emulator", nameof(clientBuilder.CredentialsPath));
                    GaxPreconditions.CheckState(clientBuilder.JsonCredentials == null, "{0} should not be set when connecting to an emulator", nameof(clientBuilder.JsonCredentials));
                    GaxPreconditions.CheckState(clientBuilder.Scopes == null, "{0} should not be set when connecting to an emulator", nameof(clientBuilder.Scopes));
                    GaxPreconditions.CheckState(clientBuilder.TokenAccessMethod == null, "{0} should not be set when connecting to an emulator", nameof(clientBuilder.TokenAccessMethod));
                    clientBuilder.Endpoint = emulatorConfig.Endpoint;
                    clientBuilder.ChannelCredentials = Grpc.Core.ChannelCredentials.Insecure;
                    projectId = projectId ?? emulatorConfig.ProjectId;
                }
            }
            GaxPreconditions.CheckState(!string.IsNullOrEmpty(projectId), "The project ID must be configured");
            return new ConfiguredBuilder(projectId, NamespaceId, clientBuilder);
        }

        /// <summary>
        /// The namespace ID, or null to use the default.
        /// </summary>
        public string NamespaceId { get; set; }

        /// <inheritdoc />
        public override DatastoreDb Build() =>
            PrepareBuilder().Build();

        /// <inheritdoc />
        public override Task<DatastoreDb> BuildAsync(CancellationToken cancellationToken = default) =>
            PrepareBuilder().BuildAsync(cancellationToken);

        // We never end up using these methods, at least with the current implementation
        /// <inheritdoc />
        protected override string GetDefaultEndpoint() =>
            throw new InvalidOperationException($"This method should never execute in {nameof(DatastoreDbBuilder)}");

        /// <inheritdoc />
        protected override IReadOnlyList<string> GetDefaultScopes() =>
            throw new InvalidOperationException($"This method should never execute in {nameof(DatastoreDbBuilder)}");

        /// <inheritdoc />
        protected override ChannelPool GetChannelPool() =>
            throw new InvalidOperationException($"This method should never execute in {nameof(DatastoreDbBuilder)}");

        /// <inheritdoc />
        protected override GrpcAdapter DefaultGrpcAdapter =>
            throw new InvalidOperationException($"This property should never execute in {nameof(DatastoreDbBuilder)}");

        private class EmulatorConfiguration
        {
            internal const string EmulatorHostVariable = "DATASTORE_EMULATOR_HOST";
            internal const string EmulatorProjectVariable = "DATASTORE_PROJECT_ID";
            internal string Endpoint { get; }
            internal string ProjectId { get; }

            private EmulatorConfiguration(string endpoint, string projectId)
            {
                Endpoint = endpoint;
                ProjectId = projectId;
            }

            internal static EmulatorConfiguration FromEnvironment()
            {
                // Note: we treat present-but-empty environment variables as if they were absent.
                string hostAndPort = Environment.GetEnvironmentVariable(EmulatorHostVariable)?.Trim();
                string projectId = Environment.GetEnvironmentVariable(EmulatorProjectVariable)?.Trim();
                var endpoint = string.IsNullOrEmpty(hostAndPort) ? null : hostAndPort;
                return new EmulatorConfiguration(endpoint, projectId == "" ? null : projectId);
            }
        }

        private class ConfiguredBuilder
        {
            private string _projectId;
            private string _namespaceId;
            private DatastoreClientBuilder _clientBuilder;

            internal ConfiguredBuilder(string projectId, string namespaceId, DatastoreClientBuilder clientBuilder)
            {
                _projectId = projectId;
                _namespaceId = namespaceId;
                _clientBuilder = clientBuilder;
            }

            internal DatastoreDb Build()
            {
                var client = _clientBuilder.Build();
                return DatastoreDb.Create(_projectId, _namespaceId ?? DatastoreDb.DefaultNamespaceId, client);
            }

            internal async Task<DatastoreDb> BuildAsync(CancellationToken cancellationToken)
            {
                var client = await _clientBuilder.BuildAsync(cancellationToken).ConfigureAwait(false);
                return DatastoreDb.Create(_projectId, _namespaceId ?? DatastoreDb.DefaultNamespaceId, client);
            }
        }
    }
}
