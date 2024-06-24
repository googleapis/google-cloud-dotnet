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
    /// Attribute indicating that a type is intended to be used with Firestore.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate | AttributeTargets.Interface)]
    public sealed class FirestoreDataAttribute : Attribute
    {
        /// <summary>
        /// The strategy to use when handling unknown properties. The default is
        /// <see cref="UnknownPropertyHandling.Warn"/>.
        /// </summary>
        public UnknownPropertyHandling UnknownPropertyHandling { get; set; }

        /// <summary>
        /// A custom converter type to use for serializing and deserializing the attributed type.
        /// </summary>
        public System.Type ConverterType { get; set; }

        /// <summary>
        /// Constructs a new instance with default values for options.
        /// </summary>
        public FirestoreDataAttribute() : this(UnknownPropertyHandling.Warn)
        {
        }

        /// <summary>
        /// Constructs a new instance with the given handling for unknown properties.
        /// </summary>
        /// <param name="unknownPropertyHandling">The unknown property handling strategy to use.</param>
        public FirestoreDataAttribute(UnknownPropertyHandling unknownPropertyHandling)
        {
            UnknownPropertyHandling = unknownPropertyHandling;
        }
    }
}
