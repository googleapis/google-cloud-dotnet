// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Case = Google.Cloud.Firestore.V1Beta1.Precondition.ConditionTypeOneofCase;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Immutable class representing a precondition for an update operation.
    /// </summary>
    public sealed class Precondition : IEquatable<Precondition>
    {
        /// <summary>
        /// No precondition.
        /// </summary>
        public static Precondition None { get; } = new Precondition(null);

        /// <summary>
        /// Precondition that the document must exist, but with any last update time.
        /// </summary>
        public static Precondition MustExist { get; } = new Precondition(new V1Beta1.Precondition { Exists = true });

        /// <summary>
        /// Precondition that the document must not exist. (This is internal for now; we don't believe there's
        /// a reason for clients to specify this anywhere.)
        /// </summary>
        internal static Precondition MustNotExist { get; } = new Precondition(new V1Beta1.Precondition { Exists = false });

        /// <summary>
        /// Creates a precondition that the document has the specified last update time.
        /// </summary>
        public static Precondition LastUpdated(Timestamp timestamp) =>
            new Precondition(new V1Beta1.Precondition { UpdateTime = timestamp.ToProto()});

        /// <summary>
        /// Condition that the document was last updated at the specified timestamp, if specified.
        /// If this is non-null, <see cref="Exists"/> will be null.
        /// </summary>
        public Timestamp? LastUpdateTime => Timestamp.FromProtoOrNull(Proto?.UpdateTime);

        /// <summary>
        /// True if the document must exist; false if the document must not exist.
        /// If this is non-null, <see cref="LastUpdateTime"/> will be null.
        /// </summary>
        public bool? Exists => Proto?.ConditionTypeCase == Case.Exists ? Proto.Exists : (bool?) null;

        /// <summary>
        /// The proto representation of the precondition. Must not be mutated or exposed publicly.
        /// Will be null for <see cref="None"/>.
        /// </summary>
        internal V1Beta1.Precondition Proto { get; }

        private Precondition(V1Beta1.Precondition proto) => Proto = proto;

        // Only used by tests
        internal static Precondition FromProto(V1Beta1.Precondition proto) => proto == null ? null : new Precondition(proto);

        /// <summary>
        /// Compares this precondition with another for equality.
        /// </summary>
        /// <param name="other">The precondition to compare this one with</param>
        /// <returns><c>true</c> if this precondition is equal to <paramref name="other"/>; <c>false</c> otherwise.</returns>
        public bool Equals(Precondition other) => other != null && Equals(Proto, other.Proto);

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as Precondition);

        // The value returned when Proto is null is chosen to avoid conflicting with either
        // MustExist or MustNotExist.
        /// <inheritdoc />
        public override int GetHashCode() => Proto?.GetHashCode() ?? 5172;
    }
}
