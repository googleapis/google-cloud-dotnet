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
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// A builder for <see cref="StorageClient"/>, allowing simple client customization.
    /// </summary>
    public sealed class StorageClientBuilder : ClientBuilderBase<StorageClient>
    {
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

        /// <inheritdoc />
        public override StorageClient Build()
        {
            Validate();
            var initializer = CreateServiceInitializer();
            var service = new StorageService(initializer);
            return new StorageClientImpl(service, EncryptionKey);
        }

        /// <inheritdoc />
        public override async Task<StorageClient> BuildAsync(CancellationToken cancellationToken = default)
        {
            Validate();
            var initializer = await CreateServiceInitializerAsync(cancellationToken).ConfigureAwait(false);
            var service = new StorageService(initializer);
            return new StorageClientImpl(service, EncryptionKey);
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
            GaxPreconditions.CheckState(!UnauthenticatedAccess || (ApiKey == null && Credential == null && CredentialsPath == null && JsonCredentials == null),
                "When requesting unauthenticated access, don't specify any other credentials.");
        }
    }
}
