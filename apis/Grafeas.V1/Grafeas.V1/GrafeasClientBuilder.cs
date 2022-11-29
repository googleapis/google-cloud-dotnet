// Copyright 2020 Google LLC
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
using System;

namespace Grafeas.V1
{
    // Partial class for GrafeasClientBuilder, to work around there being no default endpoint/scopes.
    public partial class GrafeasClientBuilder
    {
        /// <inheritdoc />
        protected override void Validate()
        {
            base.Validate();
            // If an endpoint is specified but no scopes, it's still possible that the credentials
            // will work. We let that fail normally if the credentials turn out to be inappropriate.
            // (Note that it won't use the channel pool, but that's okay.)
            // But we definitely need to either have a CallInvoker or Endpoint, as otherwise we
            // have nowhere to connect to.
            if (Endpoint is object || CallInvoker is object)
            {
                return;
            }
            throw new InvalidOperationException($"Either Endpoint or CallInvoker must be set");
        }

        // We can't use a channel pool as we have no scopes.
        // This prevents GetChannelPool from being called; we may use more channels than we'd
        // want, but at least we don't fail unnecessarily.

        /// <inheritdoc />
        protected override bool CanUseChannelPool => false;

        /// <inheritdoc />
        protected override ChannelPool GetChannelPool() =>
            throw new InvalidOperationException("GrafeasClient has no channel pool");
    }
}
