// Copyright 2019, Google LLC
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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Attribute indicating that a property should be populated with the read timestamp from a Firestore document snapshot.
    /// </summary>
    /// <remarks>
    /// This attribute must only be applied to properties of <see cref="DateTime"/>, <see cref="DateTimeOffset"/>, <see cref="Timestamp" />,
    /// or the nullable equivalents, or a <see cref="wkt::Timestamp">protobuf Timestamp</see>.
    /// This attribute is ignored when serializing a document to Firestore.
    /// This attribute must not be applied on a property which also has <see cref="FirestorePropertyAttribute"/>.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class FirestoreDocumentReadTimestampAttribute : Attribute
    {
        /// <summary>
        /// Creates an instance of the attribute.
        /// </summary>
        public FirestoreDocumentReadTimestampAttribute()
        {
        }
    }
}
