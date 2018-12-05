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

    /// <summary>
    /// Builder class for <see cref="DatastoreClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DatastoreClientBuilder : ClientBuilder<DatastoreClientBuilder, DatastoreClient>
    {
        private DatastoreSettings _settings;

        /// <summary>
        /// Creates a new builder with default options.
        /// </summary>
        public DatastoreClientBuilder() : base()
        {
        }

        /// <summary>
        /// Returns a clone of the settings in this builder, or null if no settings have been set. Changes to the
        /// returned object do not affect the settings in this builder.
        /// </summary>
        /// <returns>A clone of the settings in this builder, or null.</returns>
        public DatastoreSettings CloneSettings() => _settings?.Clone();

        private DatastoreClientBuilder(DatastoreClientBuilder builder) : base(builder)
        {
            _settings = builder._settings;
        }

        /// <inheritdoc />
        public override DatastoreClient Build() => DatastoreClient.Create(CreateCallInvoker(), _settings);
        
        /// <inheritdoc />
        public override async Task<DatastoreClient> BuildAsync(CancellationToken cancellationToken = default) =>
            DatastoreClient.Create(await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false), _settings);

        /// <inheritdoc />
        public DatastoreClientBuilder WithSettings(DatastoreSettings settings)
        {
            var clone = Clone();
            clone._settings = settings?.Clone();
            return clone;
        }

        /// <inheritdoc />
        protected override DatastoreClientBuilder Clone() => new DatastoreClientBuilder(this);
        
        /// <inheritdoc />
        protected override ServiceEndpoint GetDefaultEndpoint() => DatastoreClient.DefaultEndpoint;
        
        /// <inheritdoc />
        protected override IReadOnlyList<string> GetDefaultScopes() => DatastoreClient.DefaultScopes;
    }
}
