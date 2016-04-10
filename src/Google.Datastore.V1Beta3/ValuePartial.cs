// Copyright 2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Google.Type;
using System;

namespace Google.Datastore.V1Beta3
{
    // Additional helper members.
    public partial class Value
    {
        // TODO:
        // - Documentation!
        // - Cloning?
        // - Array handling? (either in ArrayValuePartial or here, or both...)

        public static explicit operator string(Value value) => value?.CheckKind(ValueTypeOneofCase.StringValue).StringValue;
        public static explicit operator long(Value value) => value.CheckKind(ValueTypeOneofCase.IntegerValue).IntegerValue;
        public static explicit operator long?(Value value) => value?.CheckKind(ValueTypeOneofCase.IntegerValue).IntegerValue;
        public static explicit operator Key(Value value) => value?.CheckKind(ValueTypeOneofCase.KeyValue).KeyValue;
        public static explicit operator double(Value value) => value.CheckKind(ValueTypeOneofCase.DoubleValue).DoubleValue;
        public static explicit operator double?(Value value) => value?.CheckKind(ValueTypeOneofCase.DoubleValue).DoubleValue;
        public static explicit operator bool(Value value) => value.CheckKind(ValueTypeOneofCase.BooleanValue).BooleanValue;
        public static explicit operator bool?(Value value) => value?.CheckKind(ValueTypeOneofCase.BooleanValue).BooleanValue;
        public static explicit operator ArrayValue(Value value) => value?.CheckKind(ValueTypeOneofCase.ArrayValue).ArrayValue;
        public static explicit operator ByteString(Value value) => value?.CheckKind(ValueTypeOneofCase.BlobValue).BlobValue;
        public static explicit operator byte[](Value value) => value?.CheckKind(ValueTypeOneofCase.BlobValue).BlobValue.ToByteArray();
        public static explicit operator Entity(Value value) => value?.CheckKind(ValueTypeOneofCase.EntityValue).EntityValue;
        public static explicit operator LatLng(Value value) => value?.CheckKind(ValueTypeOneofCase.GeoPointValue).GeoPointValue;
        public static explicit operator Timestamp(Value value) => value?.CheckKind(ValueTypeOneofCase.TimestampValue).TimestampValue;
        public static explicit operator DateTime(Value value) => ((Timestamp) value).ToDateTime();
        public static explicit operator DateTime?(Value value) => ((Timestamp) value)?.ToDateTime();
        public static explicit operator DateTimeOffset(Value value) => ((Timestamp)value).ToDateTimeOffset();
        public static explicit operator DateTimeOffset? (Value value) => ((Timestamp)value)?.ToDateTimeOffset();

        private Value CheckKind(ValueTypeOneofCase expectedCase)
        {
            if (ValueTypeCase != expectedCase)
            {
                throw new InvalidOperationException($"Cannot convert value; expected kind {expectedCase}; was {ValueTypeCase}");
            }
            return this;
        }

        public static implicit operator Value(string value) => value == null ? null : new Value { StringValue = value };
        public static implicit operator Value(long value) => new Value { IntegerValue = value };
        public static implicit operator Value(long? value) => value == null ? null : new Value { IntegerValue = value.Value };
        public static implicit operator Value(Key value) => value == null ? null : new Value { KeyValue = value };
        public static implicit operator Value(double value) => new Value { DoubleValue = value };
        public static implicit operator Value(double? value) => value == null ? null : new Value { DoubleValue = value.Value };
        public static implicit operator Value(bool value) => new Value { BooleanValue = value };
        public static implicit operator Value(bool? value) => value == null ? null : new Value { BooleanValue = value.Value };
        public static implicit operator Value(ArrayValue value) => value == null ? null : new Value { ArrayValue = value };
        public static implicit operator Value(ByteString value) => value == null ? null : new Value { BlobValue = value };
        public static implicit operator Value(byte[] value) => value == null ? null : new Value { BlobValue = ByteString.CopyFrom(value) };
        public static implicit operator Value(Entity value) => value == null ? null : new Value { EntityValue = value };
        public static implicit operator Value(LatLng value) => value == null ? null : new Value { GeoPointValue = value };
        public static implicit operator Value(Timestamp value) => value == null ? null : new Value { TimestampValue = value };
        public static implicit operator Value(DateTime value) => new Value { TimestampValue = Timestamp.FromDateTime(value) };
        public static implicit operator Value(DateTime? value) => value == null ? null : new Value { TimestampValue = Timestamp.FromDateTime(value.Value) };
        public static implicit operator Value(DateTimeOffset value) => new Value { TimestampValue = Timestamp.FromDateTimeOffset(value) };
        public static implicit operator Value(DateTimeOffset? value) => value == null ? null : new Value { TimestampValue = Timestamp.FromDateTimeOffset(value.Value) };

        /// <summary>
        /// Creates a new <see cref="Value"/> with a type of <c>NullValue</c>.
        /// </summary>
        /// <returns>A value with a type of <c>NullValue</c>.</returns>
        public static Value ForNull() => new Value { NullValue = NullValue.NULL_VALUE };
    }
}
