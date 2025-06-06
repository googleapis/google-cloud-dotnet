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

using Google.Cloud.Firestore.V1;
using System.Linq;
using WKT = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Tests
{
    /// <summary>
    /// Helper methods to create protos in a more convenient fashion.
    /// Initially just timestamps, but potentially CreateValue with multiple overloads, too.
    /// </summary>
    internal static class ProtoHelpers
    {
        internal static WKT::Timestamp CreateProtoTimestamp(long seconds, int nanos) =>
            new WKT::Timestamp { Seconds = seconds, Nanos = nanos };

        // Allows tests to use dynamic calls to CreateValue but still use previously-constructed Value references.
        internal static Value CreateValue(Value value) => value;

        internal static Value CreateValue(Blob value) => new Value { BytesValue = value.ByteString };
        internal static Value CreateValue(GeoPoint value) => new Value { GeoPointValue = value.ToProto() };
        internal static Value CreateValue(Timestamp value) => new Value { TimestampValue = value.ToProto() };
        internal static Value CreateValue(bool value) => new Value { BooleanValue = value };
        internal static Value CreateValue(double value) => new Value { DoubleValue = value };
        internal static Value CreateValue(long value) => new Value { IntegerValue = value };
        internal static Value CreateValue(string value) => new Value { StringValue = value };
        internal static Value CreateValue(DocumentReference reference) => new Value { ReferenceValue = reference.Path };

        internal static Value CreateNullValue() => new Value { NullValue = WKT.NullValue.NullValue };

        internal static Value CreateReference(string value) => new Value { ReferenceValue = value };

        internal static Value CreateMap(string name, Value value) => CreateMap((name, value));
        internal static Value CreateMap(params (string name, Value value)[] fields) =>
            new Value { MapValue = new MapValue { Fields = { fields.ToDictionary(field => field.name, field => field.value) } } };
        internal static Value CreateArray(params Value[] values) => new Value { ArrayValue = new ArrayValue { Values = { values } } };
    }
}
