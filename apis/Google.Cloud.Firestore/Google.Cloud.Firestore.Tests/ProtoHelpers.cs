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
using System.Linq;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Tests
{
    /// <summary>
    /// Helper methods to create protos in a more convenient fashion.
    /// Initially just timestamps, but potentially CreateValue with multiple overloads, too.
    /// </summary>
    internal static class ProtoHelpers
    {
        internal static wkt::Timestamp CreateProtoTimestamp(long seconds, int nanos) =>
            new wkt::Timestamp { Seconds = seconds, Nanos = nanos };

        internal static Value CreateValue(long integer) => new Value { IntegerValue = integer };

        internal static Value CreateValue(string text) => new Value { StringValue = text };

        internal static Value CreateNullValue() => new Value { NullValue = wkt.NullValue.NullValue };

        internal static Value CreateMap(string name, Value value) => CreateMap((name, value));
        internal static Value CreateMap(params (string name, Value value)[] fields) =>
            new Value { MapValue = new MapValue { Fields = { fields.ToDictionary(field => field.name, field => field.value) } } };
    }
}
