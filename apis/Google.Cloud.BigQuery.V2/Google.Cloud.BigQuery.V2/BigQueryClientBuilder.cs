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
using Google.Apis.Bigquery.v2;
using Google.Apis.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// A builder for <see cref="BigQueryClient"/>, allowing simple client customization.
    /// </summary>
    public sealed class BigQueryClientBuilder : ClientBuilderBase<BigQueryClient>
    {
        /// <summary>
        /// The project ID, which must be set before building the client.
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// The default location to use for location-specific operations.
        /// </summary>
        public string DefaultLocation { get; set; }

        /// <inheritdoc />
        public override BigQueryClient Build()
        {
            Validate();
            var initializer = CreateServiceInitializer();
            initializer.Serializer = new NewtonsoftJsonSerializer(BigQueryClient.CreateJsonSerializersSettings());
            var service = new BigqueryService(initializer);
            return new BigQueryClientImpl(ProjectId, service, DefaultLocation);
        }

        /// <inheritdoc />
        public override async Task<BigQueryClient> BuildAsync(CancellationToken cancellationToken = default)
        {
            Validate();
            var initializer = await CreateServiceInitializerAsync(cancellationToken).ConfigureAwait(false);
            initializer.Serializer = new NewtonsoftJsonSerializer(BigQueryClient.CreateJsonSerializersSettings());
            var service = new BigqueryService(initializer);
            return new BigQueryClientImpl(ProjectId, service, DefaultLocation);
        }

        /// <inheritdoc />
        protected override string GetDefaultApplicationName() => BigQueryClientImpl.ApplicationName;

        /// <inheritdoc />
        protected override ScopedCredentialProvider GetScopedCredentialProvider() => BigQueryClient.ScopedCredentialProvider;

        /// <inheritdoc />
        protected override void Validate()
        {
            base.Validate();
            GaxPreconditions.CheckState(ProjectId != null, "The project ID must be set before building a client.");
        }
    }
}
