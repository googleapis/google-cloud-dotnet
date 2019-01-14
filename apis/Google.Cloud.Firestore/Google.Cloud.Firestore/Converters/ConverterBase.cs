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
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Type;
using System;
using System.Collections.Generic;
using BclType = System.Type;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.Converters
{
    /// <summary>
    /// A base class for many converters, allowing them to simply override the method for the one
    /// deserialization case required. Serializing to a single value has to be implemented; serializing
    /// to a map will fail with an exception unless <see cref="SerializeMap(object, IDictionary{string, Value})"/>
    /// is overridden.
    /// </summary>
    internal abstract class ConverterBase : IFirestoreInternalConverter
    {
        protected BclType TargetType { get; }

        protected ConverterBase(BclType targetType)
        {
            TargetType = targetType;
        }

        public virtual object DeserializeMap(FirestoreDb db, IDictionary<string, Value> values) =>
            throw new ArgumentException($"Unable to convert map value to {TargetType}");

        public virtual object DeserializeValue(FirestoreDb db, Value value)
        {
            switch (value.ValueTypeCase)
            {
                case Value.ValueTypeOneofCase.ArrayValue:
                    return DeserializeArray(db, value.ArrayValue.Values);
                case Value.ValueTypeOneofCase.BooleanValue:
                    return DeserializeBoolean(db, value.BooleanValue);
                case Value.ValueTypeOneofCase.BytesValue:
                    return DeserializeBytes(db, value.BytesValue);
                case Value.ValueTypeOneofCase.DoubleValue:
                    return DeserializeDouble(db, value.DoubleValue);
                case Value.ValueTypeOneofCase.GeoPointValue:
                    return DeserializeGeoPoint(db, value.GeoPointValue);
                case Value.ValueTypeOneofCase.IntegerValue:
                    return DeserializeInteger(db, value.IntegerValue);
                case Value.ValueTypeOneofCase.MapValue:
                    return DeserializeMap(db, value.MapValue.Fields);
                case Value.ValueTypeOneofCase.ReferenceValue:
                    return DeserializeReference(db, value.ReferenceValue);
                case Value.ValueTypeOneofCase.StringValue:
                    return DeserializeString(db, value.StringValue);
                case Value.ValueTypeOneofCase.TimestampValue:
                    return DeserializeTimestamp(db, value.TimestampValue);
                default:
                    throw new ArgumentException($"Unable to convert value type {value.ValueTypeCase}");
            }
        }

        public abstract Value Serialize(object value);

        public virtual void SerializeMap(object value, IDictionary<string, Value> map) =>
            throw new ArgumentException($"Unable to convert {TargetType} to a map");

        protected virtual object DeserializeArray(FirestoreDb db, RepeatedField<Value> values) =>
            throw new ArgumentException($"Unable to convert array value to {TargetType}");

        protected virtual object DeserializeBoolean(FirestoreDb db, bool value) =>
            throw new ArgumentException($"Unable to convert Boolean value to {TargetType}");

        protected virtual object DeserializeBytes(FirestoreDb db, ByteString value) =>
            throw new ArgumentException($"Unable to convert bytes value to {TargetType}");

        protected virtual object DeserializeDouble(FirestoreDb db, double value) =>
            throw new ArgumentException($"Unable to convert double value to {TargetType}");

        protected virtual object DeserializeGeoPoint(FirestoreDb db, LatLng value) =>
            throw new ArgumentException($"Unable to convert LatLng value to {TargetType}");

        protected virtual object DeserializeInteger(FirestoreDb db, long value) =>
            throw new ArgumentException($"Unable to convert integer value to {TargetType}");

        protected virtual object DeserializeReference(FirestoreDb db, string value) =>
            throw new ArgumentException($"Unable to convert reference value to {TargetType}");

        protected virtual object DeserializeString(FirestoreDb db, string value) =>
            throw new ArgumentException($"Unable to convert string value to {TargetType}");

        protected virtual object DeserializeTimestamp(FirestoreDb db, wkt::Timestamp value) =>
            throw new ArgumentException($"Unable to convert Timestamp value to {TargetType}");
    }
}
