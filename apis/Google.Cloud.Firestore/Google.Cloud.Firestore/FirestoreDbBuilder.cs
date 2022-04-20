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
using Grpc.Core;
using System;
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
        private const string s_emulatorHostVariable = "FIRESTORE_EMULATOR_HOST";
        private static readonly string[] s_emulatorEnvironmentVariables = { s_emulatorHostVariable };
        private static readonly CallSettings BearerOwnerSettings = CallSettings.FromHeader("Authorization", "Bearer owner");

        private static readonly FirestoreSettings s_defaultSettings = AddGcclVersionHeader(new FirestoreSettings());

        // FIXME: we need to work out whether we want to expose the ServiceMetadata.

        /// <summary>Creates a new builder with default settings.</summary>
        public FirestoreDbBuilder() : base(FirestoreClient.PublicServiceMetadata)
        {
        }

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
        /// The client to use, or null to build a new one.
        /// </summary>
        internal FirestoreClient Client { get; set; }

        /// <summary>
        /// Specifies how the builder responds to the presence of the FIRESTORE_EMULATOR_HOST emulator environment variable.
        /// </summary>
        /// <remarks>
        /// This property defaults to <see cref="EmulatorDetection.None"/>, meaning that the environment variable is
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
            var client = Client;
            if (client == null)
            {
                var clientBuilder = FirestoreClientBuilder.FromOtherBuilder(this);
                clientBuilder.Settings = GetEffectiveSettings();
                client = clientBuilder.Build();
            }
            return BuildFromClient(projectId, client);
        }

        /// <inheritdoc />
        public override async Task<FirestoreDb> BuildAsync(CancellationToken cancellationToken = default)
        {
            var emulatorBuilder = MaybeUseEmulator();
            if (emulatorBuilder is object)
            {
                return await emulatorBuilder.BuildAsync(cancellationToken).ConfigureAwait(false);
            }

            var projectId = ProjectId ?? (await Platform.InstanceAsync().ConfigureAwait(false)).ProjectId;

            var client = Client;
            if (client == null)
            {
                var clientBuilder = FirestoreClientBuilder.FromOtherBuilder(this);
                clientBuilder.Settings = GetEffectiveSettings();
                client = await clientBuilder.BuildAsync(cancellationToken).ConfigureAwait(false);
            }
            return BuildFromClient(projectId, client);
        }

        // We never end up using this method, at least with the current implementation
        /// <inheritdoc />
        protected override ChannelPool GetChannelPool() =>
            throw new InvalidOperationException($"This method should never execute in {nameof(FirestoreDbBuilder)}");

        private FirestoreDb BuildFromClient(string projectId, FirestoreClient client) =>
            FirestoreDb.Create(projectId, DatabaseId, client, WarningLogger, ConverterRegistry);

        /// <summary>
        /// Returns the effective settings for a new client, including the "gccl" version header.
        /// We maintain a single settings object which is "the default settings with gccl version added" for the
        /// common case where no extra settings have been specified; otherwise, we need to clone those settings and
        /// add the header.
        /// </summary>
        private FirestoreSettings GetEffectiveSettings() => Settings == null ? s_defaultSettings : AddGcclVersionHeader(Settings);

        /// <summary>
        /// Returns a new FirestoreSettings based on the specified one, which has the "gccl" version
        /// header (part of the x-goog-api-client header) added to specify the version of the Google.Cloud.Firestore library.
        /// </summary>
        private static FirestoreSettings AddGcclVersionHeader(FirestoreSettings settings)
        {
            var clone = settings.Clone();
            clone.VersionHeaderBuilder.AppendAssemblyVersion("gccl", typeof(FirestoreDb));
            return clone;
        }

        private FirestoreDbBuilder MaybeUseEmulator()
        {
            var environment = GetEmulatorEnvironment(s_emulatorEnvironmentVariables, s_emulatorEnvironmentVariables);
            if (environment is null)
            {
                return null;
            }
            // The emulator output includes something like this:
            // export FIRESTORE_EMULATOR_HOST=::1:8918
            // We need to translate that into "ipv6:[::1]:8918" for gRPC
            string hostAndPort = environment[s_emulatorHostVariable];
            if (hostAndPort.StartsWith("::"))
            {
                int colonPortIndex = hostAndPort.LastIndexOf(':');
                string host = hostAndPort.Substring(0, colonPortIndex);
                string colonPort = hostAndPort.Substring(colonPortIndex);
                hostAndPort = $"ipv6:[{host}]{colonPort}";
            }

            var settings = Settings?.Clone() ?? new FirestoreSettings();
            settings.CallSettings = settings.CallSettings.MergedWith(BearerOwnerSettings);

            // Note: we don't set EmulatorDetection here, so it defaults to None - if we
            // copied our existing value in here, we'd recurse infinitely (until we overflowed the stack).
            var builder = new FirestoreDbBuilder
            {
                // Properties used to build the FirestoreClient
                Endpoint = hostAndPort,
                Settings = settings,
                ChannelCredentials = ChannelCredentials.Insecure,
                // FirestoreDb-specific properties
                ProjectId = ProjectId,
                DatabaseId = DatabaseId,
                ConverterRegistry = ConverterRegistry,
                WarningLogger = WarningLogger
            };
            builder.CopySettingsForEmulator(this);
            return builder;
        }
    }
}
