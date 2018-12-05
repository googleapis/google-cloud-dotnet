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

using Google.Api.Gax.Grpc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Datastore.V1
{
    // Note: the generator would just generate an internal property to start with, so there'd be no need for this
    // partial.
    public partial class DatastoreClient
    {
        internal static ChannelPool ChannelPool => s_channelPool;
    }

    // Note: this partial class would be generated.
    /// <summary>
    /// Builder class for <see cref="DatastoreClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DatastoreClientBuilder : ClientBuilderBase<DatastoreClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public DatastoreSettings Settings { get; set; }

        /// <inheritdoc />
        public override DatastoreClient Build()
        {
            Validate();
            var callInvoker = CreateCallInvoker();
            return DatastoreClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async Task<DatastoreClient> BuildAsync(CancellationToken cancellationToken = default)
        {
            Validate();
            var callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DatastoreClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override ServiceEndpoint GetDefaultEndpoint() => DatastoreClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override IReadOnlyList<string> GetDefaultScopes() => DatastoreClient.DefaultScopes;

        /// <inheritdoc />
        protected override ChannelPool GetChannelPool() => DatastoreClient.ChannelPool;
    }

    // Note: this partial class wouldn't be generated
    public sealed partial class DatastoreClientBuilder : ClientBuilderBase<DatastoreClient>
    {
        /// <summary>
        /// Creates a new instance with no settings.
        /// </summary>
        public DatastoreClientBuilder()
        {
        }

        internal DatastoreClientBuilder(DatastoreDbBuilder builder)
        {
            Settings = builder.Settings;
            CopyCommonSettings(builder);
        }
    }
}
