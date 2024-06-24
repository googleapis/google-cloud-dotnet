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
using Google.Protobuf;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Internal representation of sentinel values such as "server timestamp", "delete this field"
    /// and array operations. They are opaque to user code. A sentinel value can be converted to a protobuf Value,
    /// using somewhat ugly means: the resulting Value should never be sent on the wire as-is.
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

        private SentinelValue(AugmentedValue augmentedValue)
        {
            Kind = augmentedValue.Kind;
            var byteString = augmentedValue.ToByteString();
            _protoFactory = () => Value.Parser.ParseFrom(byteString);
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
            // If it's not a null value to start with, fetching NullValue returns NullValue.None
            // so we'll drop out to the right place.
            SentinelKind sentinelKind = (SentinelKind) value.NullValue;
            return sentinelKind > SentinelKind.None && sentinelKind <= s_maxSentinelKind
                ? sentinelKind : SentinelKind.None;
        }

        internal static SentinelValue FromPropertyAttributes(PropertyInfo property)
        {
            if (property.GetCustomAttribute<ServerTimestampAttribute>() != null)
            {
                return ServerTimestamp;
            }
            // (No attribute for deleted fields or array remove/union)

            // No attribute detected.
            return null;
        }

        internal static SentinelValue ForArrayValue(SerializationContext context, SentinelKind sentinelKind, object[] values)
        {
            GaxPreconditions.CheckNotNull(values, nameof(values));
            ArrayValue array = ValueSerializer.Serialize(context, values).ArrayValue;
            // This is just checking that the simple approach we've taken in the previous line
            // really did what we expect.
            GaxPreconditions.CheckState(array != null, "Input wasn't serialized as an array");
            GaxPreconditions.CheckState(!array.Values.Any(FindNestedSentinels), "Sentinel values cannot be nested in array union/remove values.");
            AugmentedValue augmented = new AugmentedValue { Kind = sentinelKind, Array = array };
            return new SentinelValue(augmented);
        }

        internal static SentinelValue ForIncrement(Value value)
        {
            GaxPreconditions.CheckNotNull(value, nameof(value));
            AugmentedValue augmented = new AugmentedValue { Kind = SentinelKind.NumericIncrement, Increment = value };
            return new SentinelValue(augmented);
        }

        private static bool FindNestedSentinels(Value value)
        {
            switch (value.ValueTypeCase)
            {
                case Value.ValueTypeOneofCase.NullValue:
                    return GetKind(value) != SentinelKind.None;
                case Value.ValueTypeOneofCase.ArrayValue:
                    return value.ArrayValue.Values.Any(FindNestedSentinels);
                case Value.ValueTypeOneofCase.MapValue:
                    return value.MapValue.Fields.Values.Any(FindNestedSentinels);
                default:
                    return false;
            }
        }

        internal static ArrayValue GetArrayValue(Value value)
        {
            var kind = GetKind(value);
            GaxPreconditions.CheckArgument(kind == SentinelKind.ArrayRemove || kind == SentinelKind.ArrayUnion,
                nameof(value),
                "Value does not represent an array-oriented sentinel");
            return ReserializeToAugmentedValue(value).Array;
        }

        internal static Value GetIncrement(Value value)
        {
            var kind = GetKind(value);
            GaxPreconditions.CheckArgument(kind == SentinelKind.NumericIncrement, nameof(value),
                "Value does not represent a numeric increment");
            return ReserializeToAugmentedValue(value).Increment;
        }

        // TODO: it would be nice to be able to avoid this, but it's unlikely to be a bottleneck
        // in real code.
        private static AugmentedValue ReserializeToAugmentedValue(Value value)
        {
            // Reusing a stream at least avoids copying the binary data.
            using (var stream = new MemoryStream())
            {
                value.WriteTo(stream);
                stream.Position = 0;
                CodedInputStream inputStream = new CodedInputStream(stream);
                return AugmentedValue.Parser.ParseFrom(inputStream);
            }
        }

        // Sentinel kinds, which are represented using a corresponding wkt::NullValue
        private const SentinelKind s_maxSentinelKind = SentinelKind.NumericIncrement;
    }
}
