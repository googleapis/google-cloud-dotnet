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
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// Builder class for <see cref="BigtableClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class BigtableClientBuilder : ClientBuilderBase<BigtableClient>
    {
        // Note: emulator support is actually provided by BigtableServiceApiClientBuilder; this proxies through.

        /// <summary>
        /// Specifies how the builder responds to the presence of emulator environment variables.
        /// </summary>
        /// <remarks>
        /// This property defaults to <see cref="EmulatorDetection.None"/>, meaning that
        /// environment variables are ignored.
        /// </remarks>
        public new EmulatorDetection EmulatorDetection
        {
            get => base.EmulatorDetection;
            set => base.EmulatorDetection = value;
        }

        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public BigtableServiceApiSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BigtableClientBuilder() : base(BigtableServiceApiClient.ServiceMetadata)
        {
        }

        /// <inheritdoc/>
        public override BigtableClient Build()
        {
            var builder = new BigtableServiceApiClientBuilder(this);
            var client = BigtableClient.Create(builder.Build());
            LastCreatedChannel = builder.LastCreatedChannel;
            return client;
        }

        /// <inheritdoc />
        public override async Task<BigtableClient> BuildAsync(CancellationToken cancellationToken = default)
        {
            var builder = new BigtableServiceApiClientBuilder(this);
            var client = BigtableClient.Create(await builder.BuildAsync(cancellationToken).ConfigureAwait(false));
            LastCreatedChannel = builder.LastCreatedChannel;
            return client;
        }

        // Overrides for abstract methods that will never actually be called.

        /// <inheritdoc />
        protected override ChannelPool GetChannelPool() => throw new NotImplementedException();
    }
}
