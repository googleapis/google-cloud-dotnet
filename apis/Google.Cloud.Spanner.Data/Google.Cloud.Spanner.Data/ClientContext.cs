// Copyright 2026 Google LLC
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

using System;
using Google.Cloud.Spanner.V1;
using Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Container for various pieces of client-owned context attached to a request.
    /// </summary>
    public sealed class ClientContext
    {
        /// <summary>
        /// Optional action to perform after preparing the request options. If this property is non-null,
        /// the underlying <see cref="RequestOptions.Types.ClientContext"/> used for a request will be passed to the delegate
        /// before the request is executed. This allows for fine-grained modifications which aren't
        /// otherwise directly supported by the properties in this options type.
        /// </summary>
        /// <remarks>
        /// Prefer the properties on this type over this modifier to prepare the request.
        /// Only use this modifier to configure aspects for which there are no properties available.
        /// This modifier is applied to the request after all properties on this type have been applied.
        /// The delegate is only called once per operation, even if the request is automatically retried.
        /// </remarks>
        public Action<RequestOptions.Types.ClientContext> ClientContextModifier { get; set; }

        internal RequestOptions.Types.ClientContext ToProto()
        {
            var proto = new RequestOptions.Types.ClientContext();
            ClientContextModifier?.Invoke(proto);
            return proto;
        }

        internal ClientContext Clone()
        {
            return new ClientContext { ClientContextModifier = ClientContextModifier };
        }
    }
}
