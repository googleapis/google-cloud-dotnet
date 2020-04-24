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

using Google.Api.Gax;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class UrlSigner
    {
        /// <summary>
        /// The result of signing a <see cref="PostPolicy"/>
        /// containing the fields that should be including when
        /// making the post request.
        /// </summary>
        public sealed class SignedPostPolicy
        {
            private const string SignatureElementName = "x-goog-signature";
            private const string PolicyElementName = "policy";

            internal SignedPostPolicy(PostPolicy source, string encodedPolicy, string signature, DateTimeOffset expiration, Uri url)
            {
                Source = GaxPreconditions.CheckNotNull(source, nameof(source));
                PostUrl = GaxPreconditions.CheckNotNull(url, nameof(url));
                EncodedPolicy = GaxPreconditions.CheckNotNull(encodedPolicy, nameof(encodedPolicy));
                Signature = GaxPreconditions.CheckNotNull(signature, nameof(signature));
                Expiration = expiration;
            }

            internal PostPolicy Source { get; }

            internal string EncodedPolicy { get; }

            internal string Signature { get; }

            internal DateTimeOffset Expiration { get; }

            /// <summary>
            /// The URL where the post request enforced by this signed policy should be made.
            /// </summary>
            public Uri PostUrl { get; }

            /// <summary>
            /// Collection of fields as defined by this policy.
            /// Post requests enforced by this policy should set, for each
            /// pair in this sequence, the given element to the exact given value.
            /// </summary>
            public IReadOnlyDictionary<string, object> Fields
            {
                get
                {
                    IDictionary<string, object> fields = new Dictionary<string, object>();
                    foreach (var field in Source.Fields)
                    {
                        fields.Add(field);
                    }
                    fields.Add(PolicyElementName, EncodedPolicy);
                    fields.Add(SignatureElementName, Signature);
                    return new ReadOnlyDictionary<string, object>(fields);
                }
            }
        }
    }
}
