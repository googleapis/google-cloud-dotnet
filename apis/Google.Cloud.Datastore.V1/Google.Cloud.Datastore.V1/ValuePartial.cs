// Copyright 2016 Google Inc. All Rights Reserved.
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
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Google.Type;
using System;

namespace Google.Cloud.Datastore.V1
{
    /// <summary>
    /// Extension methods on <see cref="Value"/>.
    /// </summary>
    public static class ValueExtensions
    {
        /// <summary>
        /// Returns <paramref name="value"/> if it has a kind other than <c>NullValue</c>,
        /// or <c>null</c> otherwise. If <paramref name="value"/> is null, this method returns <c>null</c>.
        /// </summary>
        /// <remarks>
        /// The reverse of this operation would simply be <c>value ?? Value.ForNull()</c> using the
        /// null-coalescing operator.
        /// </remarks>
        /// <param name="value">A <see cref="Value"/> reference, which may be null.</param>
        /// <returns><paramref name="value"/> if it is a non-null reference to a value with a kind
        /// other than <c>NullValue</c>; <c>null</c> otherwise</returns>
        public static Value OrNull(this Value value) => value?.IsNull == false ? value : null;
    }

    // Additional helper members.
    public partial class Value
    {
        // TODO:
        // - Cloning?

        /// <summary>
        /// Extracts the string value from a <see cref="Value"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="StringValue"/>, or null if <paramref name="value"/> is null
        /// or has a kind of <c>NullValue</c>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        public static explicit operator string(Value value) => value?.CheckKind(ValueTypeOneofCase.StringValue)?.StringValue;

        /// <summary>
        /// Extracts the integer value from a <see cref="Value"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="IntegerValue"/>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>        
        public static explicit operator long(Value value) => CheckKindForNonNullable(value, ValueTypeOneofCase.IntegerValue).IntegerValue;

        /// <summary>
        /// Extracts the integer value from a <see cref="Value"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="IntegerValue"/>, or null if <paramref name="value"/> is null
        /// or has a kind of <c>NullValue</c>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        public static explicit operator long?(Value value) => value?.CheckKind(ValueTypeOneofCase.IntegerValue)?.IntegerValue;

        /// <summary>
        /// Extracts the key value from a <see cref="Value"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="KeyValue"/>, or null if <paramref name="value"/> is null
        /// or has a kind of <c>NullValue</c>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        public static explicit operator Key(Value value) => value?.CheckKind(ValueTypeOneofCase.KeyValue)?.KeyValue;

        /// <summary>
        /// Extracts the floating point value from a <see cref="Value"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="DoubleValue"/>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>        
        public static explicit operator double(Value value) => CheckKindForNonNullable(value, ValueTypeOneofCase.DoubleValue).DoubleValue;

        /// <summary>
        /// Extracts the floating point value from a <see cref="Value"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="DoubleValue"/>, or null if <paramref name="value"/> is null
        /// or has a kind of <c>NullValue</c>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        public static explicit operator double?(Value value) => value?.CheckKind(ValueTypeOneofCase.DoubleValue)?.DoubleValue;

        /// <summary>
        /// Extracts the Boolean value from a <see cref="Value"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="BooleanValue"/>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>        
        public static explicit operator bool(Value value) => CheckKindForNonNullable(value, ValueTypeOneofCase.BooleanValue).BooleanValue;

        /// <summary>
        /// Extracts the Boolean value from a <see cref="Value"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="BooleanValue"/>, or null if <paramref name="value"/> is null
        /// or has a kind of <c>NullValue</c>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        public static explicit operator bool?(Value value) => value?.CheckKind(ValueTypeOneofCase.BooleanValue)?.BooleanValue;

        /// <summary>
        /// Extracts the array value from a <see cref="Value"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="ArrayValue"/>, or null if <paramref name="value"/> is null
        /// or has a kind of <c>NullValue</c>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        public static explicit operator ArrayValue(Value value) => value?.CheckKind(ValueTypeOneofCase.ArrayValue)?.ArrayValue;

        /// <summary>
        /// Extracts the blob value from a <see cref="Value"/> as a <see cref="ByteString"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="BlobValue"/>, or null if <paramref name="value"/> is null
        /// or has a kind of <c>NullValue</c>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        public static explicit operator ByteString(Value value) => value?.CheckKind(ValueTypeOneofCase.BlobValue)?.BlobValue;

        /// <summary>
        /// Extracts the blob value from a <see cref="Value"/> as a byte array
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="BlobValue"/>, or null if <paramref name="value"/> is null
        /// or has a kind of <c>NullValue</c>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        public static explicit operator byte[](Value value) => value?.CheckKind(ValueTypeOneofCase.BlobValue)?.BlobValue.ToByteArray();

        /// <summary>
        /// Extracts the array value from a <see cref="Value"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="EntityValue"/>, or null if <paramref name="value"/> is null.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        public static explicit operator Entity(Value value) => value?.CheckKind(ValueTypeOneofCase.EntityValue)?.EntityValue;

        /// <summary>
        /// Extracts the geolocation value from a <see cref="Value"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="GeoPointValue"/>, or null if <paramref name="value"/> is null
        /// or has a kind of <c>NullValue</c>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        public static explicit operator LatLng(Value value) => value?.CheckKind(ValueTypeOneofCase.GeoPointValue)?.GeoPointValue;

        /// <summary>
        /// Extracts the timestamp value from a <see cref="Value"/> as a <see cref="Timestamp"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="TimestampValue"/>, or null if <paramref name="value"/> is null
        /// or has a kind of <c>NullValue</c>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        public static explicit operator Timestamp(Value value) => value?.CheckKind(ValueTypeOneofCase.TimestampValue)?.TimestampValue;

        /// <summary>
        /// Extracts the timestamp value from a <see cref="Value"/> as a <see cref="DateTime"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="TimestampValue"/> as a <see cref="DateTime"/> with a <see cref="DateTimeKind"/> of <c>Utc</c>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>        
        public static explicit operator DateTime(Value value) => ((Timestamp) value).ToDateTime();

        /// <summary>
        /// Extracts the timestamp value from a <see cref="Value"/> as a nullable <see cref="DateTime"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="TimestampValue"/> as a <see cref="DateTime"/> with a <see cref="DateTimeKind"/> of <c>Utc</c>,
        /// or null if <paramref name="value"/> is null or has a kind of <c>NullValue</c>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        public static explicit operator DateTime?(Value value) => ((Timestamp) value)?.ToDateTime();

        /// <summary>
        /// Extracts the timestamp value from a <see cref="Value"/> as a <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="TimestampValue"/> as a <see cref="DateTimeOffset"/> with an offset of zero.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="value"/> is null.</exception>        
        public static explicit operator DateTimeOffset(Value value) => ((Timestamp)value).ToDateTimeOffset();

        /// <summary>
        /// Extracts the timestamp value from a <see cref="Value"/> as a nullable <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The embedded <see cref="TimestampValue"/> as a <see cref="DateTimeOffset"/> with an offset of zero,
        /// or null if <paramref name="value"/> is null or has a kind of <c>NullValue</c>.</returns>
        /// <exception cref="InvalidOperationException">The value does not have the expected kind.</exception>
        public static explicit operator DateTimeOffset? (Value value) => ((Timestamp)value)?.ToDateTimeOffset();

        private Value CheckKind(ValueTypeOneofCase expectedCase)
        {
            var typeCase = ValueTypeCase;
            // Treat a value of type Null as if it were a null reference.
            if (typeCase == ValueTypeOneofCase.NullValue)
            {
                return null;
            }
            if (typeCase != expectedCase)
            {
                throw new InvalidOperationException($"Cannot convert value; expected kind {expectedCase}; was {ValueTypeCase}");
            }
            return this;
        }

        private static Value CheckKindForNonNullable(Value value, ValueTypeOneofCase expectedCase)
        {
            GaxPreconditions.CheckNotNull(value, nameof(value));
            if (value.ValueTypeCase != expectedCase)
            {
                throw new InvalidOperationException($"Cannot convert value; expected kind {expectedCase}; was {value.ValueTypeCase}");
            }
            return value;
        }

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>StringValue</c> and the given data, or a null
        /// reference of <paramref name="value"/> is null.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(string value) => value == null ? null : new Value { StringValue = value };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>IntegerValue</c> and the given data.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(long value) => new Value { IntegerValue = value };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>IntegerValue</c> and the given data, or a null
        /// reference of <paramref name="value"/> is null.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(long? value) => value == null ? null : new Value { IntegerValue = value.Value };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>KeyValue</c> and the given data, or a null
        /// reference of <paramref name="value"/> is null.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(Key value) => value == null ? null : new Value { KeyValue = value };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>DoubleValue</c> and the given data.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(double value) => new Value { DoubleValue = value };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>DoubleValue</c> and the given data, or a null
        /// reference of <paramref name="value"/> is null.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(double? value) => value == null ? null : new Value { DoubleValue = value.Value };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>BooleanValue</c> and the given data.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(bool value) => new Value { BooleanValue = value };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>BooleanValue</c> and the given data, or a null
        /// reference of <paramref name="value"/> is null.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(bool? value) => value == null ? null : new Value { BooleanValue = value.Value };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>ArrayValue</c> and the given data, or a null
        /// reference of <paramref name="value"/> is null.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(ArrayValue value) => value == null ? null : new Value { ArrayValue = value };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>BlobValue</c> and the given data, or a null
        /// reference of <paramref name="value"/> is null.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(ByteString value) => value == null ? null : new Value { BlobValue = value };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>BlobValue</c> and the given data, or a null
        /// reference of <paramref name="value"/> is null.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(byte[] value) => value == null ? null : new Value { BlobValue = ByteString.CopyFrom(value) };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>EntityValue</c> and the given data, or a null
        /// reference of <paramref name="value"/> is null.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(Entity value) => value == null ? null : new Value { EntityValue = value };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>GeoPointValue</c> and the given data, or a null
        /// reference of <paramref name="value"/> is null.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(LatLng value) => value == null ? null : new Value { GeoPointValue = value };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>TimestampValue</c> and the given data, or a null
        /// reference of <paramref name="value"/> is null.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(Timestamp value) => value == null ? null : new Value { TimestampValue = value };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>TimestampValue</c> and the given data.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(DateTime value) => new Value { TimestampValue = Timestamp.FromDateTime(value) };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>TimestampValue</c> and the given data, or a null
        /// reference of <paramref name="value"/> is null.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(DateTime? value) => value == null ? null : new Value { TimestampValue = Timestamp.FromDateTime(value.Value) };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>TimestampValue</c> and the given data.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(DateTimeOffset value) => new Value { TimestampValue = Timestamp.FromDateTimeOffset(value) };

        /// <summary>
        /// Returns a <see cref="Value"/> with a kind of <c>TimestampValue</c> and the given data, or a null
        /// reference of <paramref name="value"/> is null.
        /// </summary>
        /// <returns>A <see cref="Value"/> corresponding to <paramref name="value"/>.</returns>
        /// <param name="value">The value to convert.</param>
        public static implicit operator Value(DateTimeOffset? value) => value == null ? null : new Value { TimestampValue = Timestamp.FromDateTimeOffset(value.Value) };

        /// <summary>
        /// Creates a new <see cref="Value"/> with a type of <c>NullValue</c>.
        /// </summary>
        /// <returns>A value with a type of <c>NullValue</c>.</returns>
        public static Value ForNull() => new Value { NullValue = NullValue.NullValue };

        /// <summary>
        /// Convenience property to determine whether this value has a type of <c>NullValue</c>.
        /// </summary>
        /// <value><c>true</c> if the type is <c>NullValue</c>; <c>false</c> otherwise.</value>
        public bool IsNull => ValueTypeCase == ValueTypeOneofCase.NullValue;

        // Implicit conversions via ArrayValue
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(string[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(long[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(long?[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(Key[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(double[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(double?[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(bool[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(bool?[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(ArrayValue[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(ByteString[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(byte[][] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(Entity[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(LatLng[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(Timestamp[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(DateTime[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(DateTime?[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(DateTimeOffset[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(DateTimeOffset?[] values) => (ArrayValue) values;
        /// <summary>
        /// Converts an array to a <see cref="Value"/>, by first converting to an <see cref="ArrayValue"/>
        /// and then converting the result to a <see cref="Value"/>.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>The converted array as a <see cref="Value"/>, or <c>null</c> if <paramref name="values"/> is <c>null</c>.</returns>
        public static implicit operator Value(Value[] values) => (ArrayValue)values;

        // Explicit conversions via ArrayValue
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator string[] (Value value) => (string[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator long[] (Value value) => (long[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator long?[] (Value value) => (long?[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator Key[] (Value value) => (Key[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator double[] (Value value) => (double[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator double?[] (Value value) => (double?[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator bool[] (Value value) => (bool[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator bool?[] (Value value) => (bool?[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator ArrayValue[] (Value value) => (ArrayValue[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator ByteString[] (Value value) => (ByteString[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator byte[][] (Value value) => (byte[][]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator Entity[] (Value value) => (Entity[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator LatLng[] (Value value) => (LatLng[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator Timestamp[] (Value value) => (Timestamp[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator DateTime[] (Value value) => (DateTime[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator DateTime?[] (Value value) => (DateTime?[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator DateTimeOffset[] (Value value) => (DateTimeOffset[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array, or any value within it does not have the expected kind.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator DateTimeOffset?[] (Value value) => (DateTimeOffset?[]) (ArrayValue) value;
        /// <summary>
        /// Converts a <see cref="Value"/> to an array using first the conversion to <see cref="ArrayValue"/> and then the
        /// conversion to the array type.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <exception cref="InvalidOperationException">The value does not represent an array.</exception>
        /// <returns>The converted array, or <c>null</c> if <paramref name="value"/> is <c>null</c>.</returns>
        public static explicit operator Value[] (Value value) => (Value[])(ArrayValue)value;
    }
}
