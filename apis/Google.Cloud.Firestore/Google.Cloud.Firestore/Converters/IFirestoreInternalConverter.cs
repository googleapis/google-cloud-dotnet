// Copyright 2018, Google LLC
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

using Google.Cloud.Firestore.V1;
using System.Collections.Generic;

namespace Google.Cloud.Firestore.Converters
{
    /// <summary>
    /// Internal interface all converters support.
    /// </summary>
    internal interface IFirestoreInternalConverter
    {
        /// <summary>
        /// Deserializes a single (possibly map- or list-based) Firestore value to a POCO.
        /// </summary>
        /// <param name="context">The context for the deserialization operation. Never null.</param>
        /// <param name="value">The Firestore value to deserialize. Never null.</param>
        /// <returns>The deserialized value. Should never be null.</returns>
        object DeserializeValue(IDeserializationContext context, Value value);

        /// <summary>
        /// Deserializes a map (as a dictionary of name/value pairs) to a POCO.
        /// </summary>
        /// <param name="context">The context for the deserialization operation. Never null.</param>
        /// <param name="values">The name/value pairs to deserialize. Never null.</param>
        /// <returns>The deserialized value. Should never be null.</returns>
        object DeserializeMap(IDeserializationContext context, IDictionary<string, Value> values);

        /// <summary>
        /// Serializes a single POCO to a Firestore representation.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="value">The value to serialize. Never null.</param>
        /// <returns>The serialized value. Should never be null.</returns>
        Value Serialize(SerializationContext context, object value);

        /// <summary>
        /// Populates a map based on the serialized form of a POCO.
        /// </summary>
        /// <remarks>
        /// Logically this could return a dictionary instead, but it's more efficient to populate an existing map.
        /// </remarks>
        /// <param name="context"></param>
        /// <param name="value">The value to serialize. Never null.</param>
        /// <param name="map">The map to populate. Never null.</param>
        void SerializeMap(SerializationContext context, object value, IDictionary<string, Value> map);
    }
}
