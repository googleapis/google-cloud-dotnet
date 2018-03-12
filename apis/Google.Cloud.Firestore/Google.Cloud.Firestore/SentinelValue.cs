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

using Google.Cloud.Firestore.V1Beta1;
using System;
using System.Reflection;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Internal representation of sentinel values. These are 
    /// </summary>
    internal sealed class SentinelValue
    {
        // These sentinel values are invalid "null" values - the NullValue enum only has a single entry (0), but we're
        // using the fact that there enums are just named numbers to hide extra information there.
        // This is deeply unpleasant, but:
        // - It's extensible to future later sentinel values without any parameters
        // - Parameterized sentinel values will need a more sophisticated approach, probably relying on unknown fields.
        // - It's "clone-safe" - when you clone a sentinel value, you get the equivalent value. (We clone in a few places,
        //   which means we can't use reference identity to distinguish sentinel values.)
        // - The values are only ever in memory temporarily; they're not exposed to users or included in an RPC.
        private const wkt::NullValue ServerTimestampSentinelNullValue = (wkt::NullValue) SentinelKind.ServerTimestamp;
        private const wkt::NullValue DeleteSentinelNullValue = (wkt::NullValue) SentinelKind.Delete;

        private readonly Func<Value> _protoFactory;

        internal static SentinelValue ServerTimestamp { get; } =
            new SentinelValue(SentinelKind.ServerTimestamp, () => new Value { NullValue = ServerTimestampSentinelNullValue });
        internal static SentinelValue Delete { get; } =
            new SentinelValue(SentinelKind.Delete, () => new Value { NullValue = DeleteSentinelNullValue });

        // There will be other sentinels with more parameters.

        private SentinelValue(SentinelKind kind, Func<Value> protoFactory)
        {
            Kind = kind;
            _protoFactory = protoFactory;
        }

        internal Value ToProtoValue() => _protoFactory();

        internal SentinelKind Kind { get; }
        
        /// <summary>
        /// Returns the detected kind of a serialized sentinel value, or None if it's not a sentinel value.
        /// </summary>
        /// <param name="value">The serialized value to inspect.</param>
        /// <returns>The kind of sentinel serialized in <paramref name="value"/> or None if it's not a sentinel value.</returns>
        internal static SentinelKind GetKind(Value value)
        {
            if (value.ValueTypeCase != Value.ValueTypeOneofCase.NullValue)
            {
                return SentinelKind.None;
            }
            wkt::NullValue nullValue = value.NullValue;
            return nullValue == ServerTimestampSentinelNullValue ? SentinelKind.ServerTimestamp
                : nullValue == DeleteSentinelNullValue ? SentinelKind.Delete
                : SentinelKind.None;
        }

        internal static SentinelValue FromPropertyAttributes(PropertyInfo property)
        {
            if (property.GetCustomAttribute<ServerTimestampAttribute>() != null)
            {
                return ServerTimestamp;
            }
            // (No attribute for deleted fields)

            // No attribute detected.
            return null;
        }

        internal enum SentinelKind
        {
            None,
            ServerTimestamp,
            Delete
        }
    }
}
