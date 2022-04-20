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
        internal const string s_emulatorHostVariable = "DATASTORE_EMULATOR_HOST";
        internal const string s_emulatorProjectVariable = "DATASTORE_PROJECT_ID";
        private static readonly string[] s_requiredEmulatorVariables = { s_emulatorHostVariable };
        private static readonly string[] s_allEmulatorVariables = { s_emulatorHostVariable, s_emulatorProjectVariable };

        /// <summary>Creates a new builder with default settings.</summary>
        public DatastoreDbBuilder() : base(DatastoreClient.ServiceMetadata)
        {
        }

        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public DatastoreSettings Settings { get; set; }

        /// <summary>
        /// Specifies how the builder responds to the presence of emulator environment variables as described
        /// by https://cloud.google.com/datastore/docs/tools/datastore-emulator.
        /// </summary>
        /// <remarks>
        /// This property defaults to <see cref="EmulatorDetection.None"/>, meaning that environment variables are
        /// ignored.
        /// </remarks>
        public new EmulatorDetection EmulatorDetection
        {
            get => base.EmulatorDetection;
            set => base.EmulatorDetection = value;
        }

        /// <summary>
        /// The project ID, or null if this has not yet been configured. Note that a project ID must be configured
        /// (or detected via an emulator environment variable) before building the <see cref="DatastoreDb"/>.
        /// </summary>
        public string ProjectId { get; set; }
        
        /// <summary>
        /// The namespace ID, or null to use the default.
        /// </summary>
        public string NamespaceId { get; set; }

        /// <inheritdoc />
        public override DatastoreDb Build() => PrepareBuilder().Build();

        /// <inheritdoc />
        public override Task<DatastoreDb> BuildAsync(CancellationToken cancellationToken = default) =>
            PrepareBuilder().BuildAsync(cancellationToken);

        // We never end up using this method, at least with the current implementation
        /// <inheritdoc />
        protected override ChannelPool GetChannelPool() =>
            throw new InvalidOperationException($"This method should never execute in {nameof(DatastoreDbBuilder)}");

        /// <summary>
        /// Common code for handling project ID, namespace ID and emulator detection.
        /// </summary>
        private ConfiguredBuilder PrepareBuilder()
        {
            var environment = GetEmulatorEnvironment(s_requiredEmulatorVariables, s_allEmulatorVariables);
            if (environment is object)
            {
                // Note: this is a recursive call, but because EmulatorDetection defaults to None,
                // it will only recurse once.
                var builder = new DatastoreDbBuilder
                {
                    Endpoint = environment[s_emulatorHostVariable],
                    Settings = Settings,
                    ProjectId = ProjectId ?? environment[s_emulatorProjectVariable],
                    NamespaceId = NamespaceId,
                    ChannelCredentials = Grpc.Core.ChannelCredentials.Insecure
                };
                builder.CopySettingsForEmulator(this);
                return builder.PrepareBuilder();
            }
            GaxPreconditions.CheckState(!string.IsNullOrEmpty(ProjectId), "The project ID must be configured");

            var clientBuilder = new DatastoreClientBuilder(this);
            clientBuilder.Settings = Settings;
            return new ConfiguredBuilder(ProjectId, NamespaceId, clientBuilder);
        }

        // Convenience class for storing the project ID, namespace ID and a DatastoreClientBuilder for sync/async building.
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
