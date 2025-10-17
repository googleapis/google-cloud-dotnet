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
using Google.Api.Gax.Rest;
using Google.Apis.Http;
using Google.Apis.Services;
using Google.Apis.Storage.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// A builder for <see cref="StorageClient"/>, allowing simple client customization.
    /// </summary>
    public sealed class StorageClientBuilder : ClientBuilderBase<StorageClient>
    {
        private const string s_emulatorHostVariable = "STORAGE_EMULATOR_HOST";
        private static readonly string[] s_emulatorEnvironmentVariables = { s_emulatorHostVariable };

        /// <summary>
        /// If set to true, no credentials are created when the client is built.
        /// </summary>
        public bool UnauthenticatedAccess { get; set; }

        /// <summary>
        /// The customer-supplied encryption key used by default for all relevant object-based operations.
        /// </summary>
        public EncryptionKey EncryptionKey { get; set; }

        /// <summary>
        /// Whether GZip should be enabled for the underlying client. This is currently internal
        /// so that we are able to modify it for retry conformance testing, but if we want to expose
        /// it publicly we should probably do so in ClientBuilderBase.
        /// </summary>
        internal bool GZipEnabled { get; set; } = true;

        /// <summary>
        /// The scheduler to use for delays (e.g. in retry), for the sake of testability.
        /// </summary>
        internal IScheduler Scheduler { get; set; }

        /// <summary>
        /// Specifies how the builder responds to the presence of the STORAGE_EMULATOR_HOST emulator environment variable.
        /// </summary>
        /// <remarks>
        /// This property defaults to <see cref="EmulatorDetection.None"/>, meaning that the environment variable is
        /// ignored.
        /// </remarks>
        public EmulatorDetection EmulatorDetection { get; set; } = EmulatorDetection.None;

        /// <summary>
        /// Creates a new builder with default settings.
        /// </summary>
        public StorageClientBuilder()
        {
            UseJwtAccessWithScopes = true;
        }

        /// <inheritdoc />
        public override StorageClient Build()
        {
            var emulatorBuilder = MaybeUseEmulator();
            if (emulatorBuilder is object)
            {
                var ret = emulatorBuilder.Build();
                return ret;
            }
            Validate();
            var initializer = CreateServiceInitializer();
            var service = new StorageService(initializer);
            return new StorageClientImpl(service, EncryptionKey, Scheduler);
        }

        /// <inheritdoc />
        public override async Task<StorageClient> BuildAsync(CancellationToken cancellationToken = default)
        {
            var emulatorBuilder = MaybeUseEmulator();
            if (emulatorBuilder is object)
            {
                var ret = await emulatorBuilder.BuildAsync().ConfigureAwait(false);
                return ret;
            }
            Validate();
            var initializer = await CreateServiceInitializerAsync(cancellationToken).ConfigureAwait(false);
            var service = new StorageService(initializer);
            return new StorageClientImpl(service, EncryptionKey, Scheduler);
        }

        /// <inheritdoc />
        protected override BaseClientService.Initializer CreateServiceInitializer()
        {
            var initializer = base.CreateServiceInitializer();
            initializer.GZipEnabled = GZipEnabled;
            initializer.DefaultExponentialBackOffPolicy = ExponentialBackOffPolicy.None;
            return initializer;
        }

        /// <inheritdoc />
        protected override async Task<BaseClientService.Initializer> CreateServiceInitializerAsync(CancellationToken cancellationToken)
        {
            var initializer = await base.CreateServiceInitializerAsync(cancellationToken).ConfigureAwait(false);
            initializer.GZipEnabled = GZipEnabled;
            initializer.DefaultExponentialBackOffPolicy = ExponentialBackOffPolicy.None;
            return initializer;
        }

        /// <inheritdoc />
        protected override IConfigurableHttpClientInitializer GetHttpClientInitializer() =>
            UnauthenticatedAccess ? null : base.GetHttpClientInitializer();

        /// <inheritdoc />
        protected override Task<IConfigurableHttpClientInitializer> GetHttpClientInitializerAsync(CancellationToken cancellationToken) =>
            UnauthenticatedAccess ? Task.FromResult<IConfigurableHttpClientInitializer>(null): base.GetHttpClientInitializerAsync(cancellationToken);

        /// <inheritdoc />
        protected override string GetDefaultApplicationName() => StorageClientImpl.ApplicationName;

        /// <inheritdoc />
        protected override ScopedCredentialProvider GetScopedCredentialProvider() => StorageClient.ScopedCredentialProvider;

        /// <inheritdoc />
        protected override void Validate()
        {
            base.Validate();
#pragma warning disable CS0618 // Temporarily disable warnings for obsolete methods.
            GaxPreconditions.CheckState(!UnauthenticatedAccess || (ApiKey == null && Credential == null && CredentialsPath == null && JsonCredentials == null),
                "When requesting unauthenticated access, don't specify any other credentials.");
#pragma warning restore CS0618
        }

        private StorageClientBuilder MaybeUseEmulator()
        {
            var environment = GetEmulatorEnvironment(s_emulatorEnvironmentVariables, s_emulatorEnvironmentVariables);
            if (environment is null)
            {
                return null;
            }
            var host = environment[s_emulatorHostVariable];

            // Allow the host to be specified as a URI or just a name/port.
            if (!host.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !host.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                host = "http://" + host;
            }

            var builder = new StorageClientBuilder();
            builder.CopySettingsForEmulator(this);
            builder.BaseUri = host;
            builder.UnauthenticatedAccess = true;
            return builder;
        }

        // Copied and adapted from Google.Api.Gax.Grpc.ClientBuilderBase<T>, so that
        // if we want to move the code to the Google.Api.Gax.Rest.ClientBuilderBase<T> it will be minimally disruptive.
        private Dictionary<string, string> GetEmulatorEnvironment(
            IEnumerable<string> requiredEmulatorEnvironmentVariables,
            IEnumerable<string> allEmulatorEnvironmentVariables,
            Func<string, string> environmentVariableProvider = null)
        {
            environmentVariableProvider ??= Environment.GetEnvironmentVariable;
            var environment = allEmulatorEnvironmentVariables.ToDictionary(key => key, key => GetEnvironmentVariableOrNull(key));

            switch (EmulatorDetection)
            {
                case EmulatorDetection.None:
                    return default;
                case EmulatorDetection.ProductionOnly:
                    foreach (var variable in allEmulatorEnvironmentVariables)
                    {
                        GaxPreconditions.CheckState(
                            environment[variable] is null,
                            "Emulator environment variable '{0}' is set, contrary to use of {1}.{2}",
                            variable, nameof(EmulatorDetection), nameof(EmulatorDetection.ProductionOnly));
                    }
                    return default;
                case EmulatorDetection.EmulatorOnly:
                    foreach (var variable in requiredEmulatorEnvironmentVariables)
                    {
                        GaxPreconditions.CheckState(
                            environment[variable] is object,
                            "Emulator environment variable '{0}' is not set, contrary to use of {1}.{2}",
                            variable, nameof(EmulatorDetection), nameof(EmulatorDetection.EmulatorOnly));
                    }
                    // When the settings *only* support the use of an emulator, the other properties shouldn't be set.
                    CheckNotSet(BaseUri, nameof(BaseUri));
#pragma warning disable CS0618 // Temporarily disable warnings for obsolete methods.
                    CheckNotSet(CredentialsPath, nameof(CredentialsPath));
                    CheckNotSet(JsonCredentials, nameof(JsonCredentials));
#pragma warning restore CS0618
                    CheckNotSet(QuotaProject, nameof(QuotaProject));
                    CheckNotSet(Credential, nameof(Credential));
                    CheckNotSet(ApiKey, nameof(ApiKey));
                    CheckNotSet(GoogleCredential, nameof(GoogleCredential));

                    void CheckNotSet(object obj, string name)
                    {
                        GaxPreconditions.CheckState(obj is null, "{0} is set, contrary to use of {1}.{2}",
                            name, nameof(EmulatorDetection), nameof(EmulatorDetection.EmulatorOnly));
                    }
                    return environment;
                case EmulatorDetection.EmulatorOrProduction:
                    bool anySet = allEmulatorEnvironmentVariables.Any(v => environment[v] is object);
                    if (!anySet)
                    {
                        return default;
                    }
                    bool allRequiredSet = requiredEmulatorEnvironmentVariables.All(v => environment[v] is object);
                    if (!allRequiredSet)
                    {
                        var sampleSet = allEmulatorEnvironmentVariables.First(v => environment[v] is object);
                        var sampleNotSet = requiredEmulatorEnvironmentVariables.First(v => environment[v] is null);
                        GaxPreconditions.CheckState(false,
                            "Emulator environment variable '{0}' is set, but '{1}' is not set.",
                            sampleSet, sampleNotSet);
                    }
                    // We allow other properties such as the endpoint to be set, although we expect them to be ignored
                    // by the calling code. This allows users to write code that has customizations in settings, but still doesn't need
                    // to be changed at all in order to use the emulator.
                    return environment;
                default:
                    throw new InvalidOperationException($"Invalid emulator detection value: {EmulatorDetection}");
            }

            // Retrieves an environment variable from <see cref="EnvrionmentVariableProvider"/>, mapping empty or whitespace-only strings to null.
            string GetEnvironmentVariableOrNull(string variable)
            {
                var value = environmentVariableProvider(variable);
                return string.IsNullOrWhiteSpace(value) ? null : value;
            }
        }

        // Copies common settings from the specified builder, expecting that any settings around
        // credentials and endpoints will be set by the caller, along with any client-specific settings.
        // Emulator detection is not copied, to avoid infinite recursion when building.
        // This code is adapted from Google.Api.Gax.Grpc.ClientBuilderBase<T>.
        private void CopySettingsForEmulator(StorageClientBuilder source)
        {
            GaxPreconditions.CheckNotNull(source, nameof(source));
            // From ClientBuilderBase
            HttpClientFactory = source.HttpClientFactory;
            ApplicationName = source.ApplicationName;

            // Storage-specific
            EncryptionKey = source.EncryptionKey;
            GZipEnabled = source.GZipEnabled;
            Scheduler = source.Scheduler;
        }
    }
}
