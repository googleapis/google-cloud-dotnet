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

using Google.Api.Gax.Grpc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Datastore.V1
{
    // Note: this file would be generated.

    public partial class DatastoreClient
    {
        /// <summary>
        /// Creates a new <see cref="DatastoreClientBuilder"/> instance. This method is primarily present for discoverability.
        /// </summary>
        /// <returns>A new <see cref="DatastoreClientBuilder"/> instance.</returns>
        public DatastoreClientBuilder CreateBuilder() => new DatastoreClientBuilder();

    }

    /// <summary>
    /// Builder class for <see cref="DatastoreClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DatastoreClientBuilder : ClientBuilder<DatastoreClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public DatastoreSettings Settings { get; set; }

        /// <inheritdoc />
        protected override DatastoreClient BuildImpl() => DatastoreClient.Create(CreateCallInvoker(), Settings);

        /// <inheritdoc />
        protected override async Task<DatastoreClient> BuildImplAsync(CancellationToken cancellationToken = default) =>
            DatastoreClient.Create(await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false), Settings);

        /// <inheritdoc />
        protected override ServiceEndpoint GetDefaultEndpoint() => DatastoreClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override IReadOnlyList<string> GetDefaultScopes() => DatastoreClient.DefaultScopes;
    }
}
