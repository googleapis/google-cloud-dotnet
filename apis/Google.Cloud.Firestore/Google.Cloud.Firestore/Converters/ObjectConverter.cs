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

using Google.Cloud.Firestore.V1Beta1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Firestore.Converters
{
    /// <summary>
    /// A converter for a target type of <see cref="Object"/>. This is a deserialize-only converter
    /// (as there's nothing in Object to serialize to a value). It's effectively a "default deserializer",
    /// picking the most appropriate type to deserialize to.
    /// </summary>
    internal sealed class ObjectConverter : IFirestoreInternalConverter
    {
        public object DeserializeMap(FirestoreDb db, IDictionary<string, Value> values) =>
            values.ToDictionary(pair => pair.Key, pair => DeserializeValue(db, pair.Value));

        public object DeserializeValue(FirestoreDb db, Value value)
        {
            switch (value.ValueTypeCase)
            {
                case Value.ValueTypeOneofCase.ArrayValue:
                    return value.ArrayValue.Values.Select(element => DeserializeValue(db, element)).ToList();
                case Value.ValueTypeOneofCase.BooleanValue:
                    return value.BooleanValue;
                case Value.ValueTypeOneofCase.BytesValue:
                    return Blob.FromByteString(value.BytesValue);
                case Value.ValueTypeOneofCase.DoubleValue:
                    return value.DoubleValue;
                case Value.ValueTypeOneofCase.GeoPointValue:
                    return GeoPoint.FromProto(value.GeoPointValue);
                case Value.ValueTypeOneofCase.IntegerValue:
                    return value.IntegerValue;
                case Value.ValueTypeOneofCase.MapValue:
                    return DeserializeMap(db, value.MapValue.Fields);
                case Value.ValueTypeOneofCase.ReferenceValue:
                    return db.GetDocumentReferenceFromResourceName(value.ReferenceValue);
                case Value.ValueTypeOneofCase.StringValue:
                    return value.StringValue;
                case Value.ValueTypeOneofCase.TimestampValue:
                    return Timestamp.FromProto(value.TimestampValue);
                default:
                    throw new ArgumentException($"Unable to convert value type {value.ValueTypeCase} to System.Object");
            }
        }

        public Value Serialize(object value) =>
            throw new ArgumentException($"Unable to serialize System.Object as a value");

        public void SerializeMap(object value, IDictionary<string, Value> map) =>
            throw new ArgumentException($"Unable to serialize System.Object as a map");
    }
}
