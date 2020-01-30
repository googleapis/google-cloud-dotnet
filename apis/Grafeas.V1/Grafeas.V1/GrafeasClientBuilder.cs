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
            // We can handle Endpoint + (credentials or scopes), or a CallInvoker
            if (Endpoint is object && (ChannelCredentials is object || Scopes is object))
            {
                return;
            }
            if (CallInvoker is object)
            {
                return;
            }
            throw new InvalidOperationException($"Either Endpoint or CallInvoker must be set");
        }

        /// <inheritdoc />
        protected override ChannelPool GetChannelPool() =>
            throw new InvalidOperationException("GrafeasClient has no channel pool");

        /// <inheritdoc />
        protected override string GetDefaultEndpoint() =>
            throw new InvalidOperationException("Grafeas has no default endpoint");
    }
}
