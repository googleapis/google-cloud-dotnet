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
        private static readonly IReadOnlyList<string> EmulatorVariableList = new List<string> { EmulatorHostVariable }.AsReadOnly();
        private static readonly CallSettings BearerOwnerSettings = CallSettings.FromHeader("Authorization", "Bearer owner");

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

        /// <inheritdoc />
        public override FirestoreDb Build()
        {
            var emulatorBuilder = MaybeUseEmulator();
            if (emulatorBuilder is object)
            {
                return emulatorBuilder.Build();
            }

            var projectId = ProjectId ?? Platform.Instance().ProjectId;
            var clientBuilder = FirestoreClientBuilder.FromOtherBuilder(this);
            clientBuilder.Settings = Settings;
            var client = clientBuilder.Build();
            return BuildFromClient(projectId, client);
        }

        /// <inheritdoc />
        public override async Task<FirestoreDb> BuildAsync(CancellationToken cancellationToken = default)
        {
            var emulatorBuilder = MaybeUseEmulator();
            if (emulatorBuilder is object)
            {
                return emulatorBuilder.Build();
            }

            var projectId = ProjectId ?? (await Platform.InstanceAsync().ConfigureAwait(false)).ProjectId;
            var clientBuilder = FirestoreClientBuilder.FromOtherBuilder(this);
            clientBuilder.Settings = Settings;
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

        private FirestoreDb BuildFromClient(string projectId, FirestoreClient client) =>
            FirestoreDb.Create(projectId, DatabaseId, client, WarningLogger, ConverterRegistry);

        /// <inheritdoc />
        protected override IReadOnlyList<string> RequiredEmulatorEnvironmentVariables => EmulatorVariableList;

        /// <inheritdoc />
        protected override IReadOnlyList<string> AllEmulatorEnvironmentVariables => EmulatorVariableList;

        /// <inheritdoc />
        protected override ClientBuilderBase<FirestoreDb> BuildEmulatorClientBuilder(Dictionary<string, string> environment)
        {
            string hostAndPort = environment[EmulatorHostVariable];
            if (hostAndPort.StartsWith("::"))
            {
                int colonPortIndex = hostAndPort.LastIndexOf(':');
                string host = hostAndPort.Substring(0, colonPortIndex);
                string colonPort = hostAndPort.Substring(colonPortIndex);
                hostAndPort = $"ipv6:[{host}]{colonPort}";
            }
            var settings = Settings?.Clone() ?? new FirestoreSettings();
            settings.CallSettings = settings.CallSettings.MergedWith(BearerOwnerSettings);
            return new FirestoreDbBuilder
            {
                Endpoint = hostAndPort,
                Settings = settings,
                ProjectId = ProjectId,
                ChannelCredentials = Grpc.Core.ChannelCredentials.Insecure
            };
        }
    }
}
