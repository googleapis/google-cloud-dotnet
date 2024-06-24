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

using Google.Api.Gax;
using Google.Cloud.Firestore.V1;
using System.Collections.Generic;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore
{
    // TODO: Serialize some other types, e.g. Guid?
    // TODO: Protect against stack overflows?
    // TODO: Deliberate pass through of Value to Value (and maps/collections) to make it easier to plug in other mappers?

    /// <summary>
    /// Provides conversions from .NET types to Firestore Value protos.
    /// </summary>
    internal static class ValueSerializer
    {
        /// <summary>
        /// Serializes a single input to a Value.
        /// </summary>
        /// <remarks>
        /// It's important that this always clones any mutable values - which is really only
        /// relevant when the input is already a proto. That allows the caller to then mutate the result
        /// where appropriate.
        /// </remarks>
        /// <param name="context"></param>
        /// <param name="value">The value to serialize.</param>
        /// <returns>A Firestore Value proto.</returns>
        internal static Value Serialize(SerializationContext context, object value)
        {
            if (value == null)
            {
                return new Value { NullValue = wkt::NullValue.NullValue };
            }
            return context.GetConverter(value.GetType()).Serialize(context, value);
        }

        /// <summary>
        /// Serializes a map-based input to a dictionary of fields to values.
        /// This is effectively the map-only part of <see cref="Serialize"/>, but without wrapping the
        /// result in a Value.
        /// </summary>
        internal static Dictionary<string, Value> SerializeMap(SerializationContext context, object value)
        {
            GaxPreconditions.CheckNotNull(value, nameof(value));
            var map = new Dictionary<string, Value>();
            context.GetConverter(value.GetType()).SerializeMap(context, value, map);
            return map;
        }
    }
}
