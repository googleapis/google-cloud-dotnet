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

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Immutable class representing request options.
    /// </summary>
    internal class RequestOptions : IEquatable<RequestOptions>
    {
        /// <summary>
        /// The request tag configured in the options.
        /// </summary>
        internal string RequestTag { get => Proto.RequestTag; }

        /// <summary>
        /// The transaction tag configured in the options.
        /// </summary>
        internal string TransactionTag { get => Proto.TransactionTag; }

        /// <summary>
        /// Clones the options and sets the request tag to the given value.
        /// </summary>
        /// <returns>
        /// A clone of the options with the updated request tag.
        /// </returns>
        /// <param name="tag">Request tag to set.</param>
        internal RequestOptions WithRequestTag(string tag)
        {
           var protoCopy = Proto.Clone();
           protoCopy.RequestTag = tag ?? "";
           return new RequestOptions(protoCopy);
        }

        /// <summary>
        /// Clones the options and sets the transaction tag to the given value.
        /// </summary>
        /// <returns>
        /// A clone of the options with the updated transaction tag.
        /// </returns>
        /// <param name="tag">Transaction tag to set.</param>
        internal RequestOptions WithTransactionTag(string tag)
        {
            var protoCopy = Proto.Clone();
            protoCopy.TransactionTag = tag ?? "";
            return new RequestOptions(protoCopy);
        }

        /// <summary>
        /// The proto representation of the request options. Must not be mutated
        /// or exposed publicly.
        /// </summary>
        internal V1.RequestOptions Proto { get; }

        private RequestOptions(V1.RequestOptions proto) => Proto = proto;

        /// <summary>
        /// Creates request options without specifying any options.
        /// </summary>
        internal static RequestOptions Empty { get; } = new RequestOptions(new V1.RequestOptions());

        /// <summary>
        /// Set request options from the given proto.
        /// </summary>
        /// <remarks>
        /// The given proto should not be null. The given proto is cloned.
        /// </remarks>
        /// <param name="proto">The proto to construct <see cref="RequestOptions"/> from.</param>
        internal static RequestOptions FromProto(V1.RequestOptions proto)
        {
            GaxPreconditions.CheckNotNull(proto, nameof(proto));
            return new RequestOptions(proto.Clone());
        }

        /// <summary>
        /// Get proto version of the request options.
        /// </summary>
        internal V1.RequestOptions ToProto() => Proto.Clone();

        /// <inheritdoc />
        public bool Equals(RequestOptions other) => other is object
            && RequestTag == other.RequestTag
            && TransactionTag == other.TransactionTag;

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as RequestOptions);

        /// <inheritdoc />
        public override int GetHashCode() => Proto.GetHashCode();
    }
}
