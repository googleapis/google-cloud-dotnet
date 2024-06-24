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

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Attribute indicating that a property should be populated with the Firestore document ID.
    /// </summary>
    /// <remarks>
    /// This attribute must only be applied to properties of string or <see cref="DocumentReference" />.
    /// This attribute is ignored when serializing a document to Firestore.
    /// This attribute must not be applied on a property which also has <see cref="FirestorePropertyAttribute"/>.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class FirestoreDocumentIdAttribute : Attribute
    {
        /// <summary>
        /// Creates an instance of the attribute.
        /// </summary>
        public FirestoreDocumentIdAttribute()
        {
        }
    }
}
