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

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Attribute indicating that a property should be included in Firestore conversions.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class FirestorePropertyAttribute : Attribute
    {
        /// <summary>
        /// The name to use within the Firestore document. If not set, the name
        /// of the property is used directly.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A custom converter type to use for the attributed property.
        /// </summary>
        public System.Type ConverterType { get; set; }

        /// <summary>
        /// Creates an instance with no specified name.
        /// </summary>
        public FirestorePropertyAttribute()
        {
        }

        /// <summary>
        /// Creates an instance with the specified name.
        /// </summary>
        /// <param name="name">The name to use within the Firestore document.</param>
        public FirestorePropertyAttribute(string name)
        {
            Name = name;
        }
    }
}
