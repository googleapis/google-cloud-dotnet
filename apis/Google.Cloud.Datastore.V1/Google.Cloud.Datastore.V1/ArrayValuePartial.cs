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

using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Google.Type;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Datastore.V1
{
    // Additional helper members.
    public partial class ArrayValue
    {
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion. Any null input values are converted
        /// to instances of <see cref="Value"/> with a kind of Null.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(string[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(long[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion. Any null input values are converted
        /// to instances of <see cref="Value"/> with a kind of Null.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(long?[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion. Any null input values are converted
        /// to instances of <see cref="Value"/> with a kind of Null.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(Key[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(double[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion. Any null input values are converted
        /// to instances of <see cref="Value"/> with a kind of Null.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(double?[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(bool[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion. Any null input values are converted
        /// to instances of <see cref="Value"/> with a kind of Null.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(bool?[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion. Any null input values are converted
        /// to instances of <see cref="Value"/> with a kind of Null.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(ArrayValue[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion. Any null input values are converted
        /// to instances of <see cref="Value"/> with a kind of Null.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(ByteString[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion. Any null input values are converted
        /// to instances of <see cref="Value"/> with a kind of Null.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(byte[][] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion. Any null input values are converted
        /// to instances of <see cref="Value"/> with a kind of Null.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(Entity[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion. Any null input values are converted
        /// to instances of <see cref="Value"/> with a kind of Null.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(LatLng[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion. Any null input values are converted
        /// to instances of <see cref="Value"/> with a kind of Null.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(Timestamp[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(DateTime[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion. Any null input values are converted
        /// to instances of <see cref="Value"/> with a kind of Null.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(DateTime?[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(DateTimeOffset[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Each value within <paramref name="values"/> is converted
        /// to a <see cref="Value"/> using the individual implicit conversion. Any null input values are converted
        /// to instances of <see cref="Value"/> with a kind of Null.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(DateTimeOffset?[] values) => ToArrayValue(values, x => x);
        /// <summary>
        /// Converts an array to an <see cref="ArrayValue"/> instance. Any null input values are converted
        /// to instances of <see cref="Value"/> with a kind of Null.
        /// </summary>
        /// <param name="values">The array to convert.</param>
        /// <returns>An <see cref="ArrayValue"/> with converted values, or <c>null</c> if <paramref name="values"/> is null.</returns>
        public static implicit operator ArrayValue(Value[] values) => ToArrayValue(values, x => x);

        private static ArrayValue ToArrayValue<T>(T[] values, Func<T, Value> converter) =>
            values == null ? null : new ArrayValue { Values = { values.Select(x => converter(x) ?? Value.ForNull()) } };

        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion. Any <see cref="Value"/> elements with a kind of
        /// Null are converted to null values in the resulting array.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator string[](ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (string) x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator long[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (long)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion. Any <see cref="Value"/> elements with a kind of
        /// Null are converted to null values in the resulting array.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator long?[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (long?)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion. Any <see cref="Value"/> elements with a kind of
        /// Null are converted to null values in the resulting array.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator Key[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (Key)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator double[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (double)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion. Any <see cref="Value"/> elements with a kind of
        /// Null are converted to null values in the resulting array.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator double?[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (double?)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator bool[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (bool)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion. Any <see cref="Value"/> elements with a kind of
        /// Null are converted to null values in the resulting array.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator bool?[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (bool?)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion. Any <see cref="Value"/> elements with a kind of
        /// Null are converted to null values in the resulting array.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator ArrayValue[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (ArrayValue)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion. Any <see cref="Value"/> elements with a kind of
        /// Null are converted to null values in the resulting array.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator ByteString[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (ByteString)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion. Any <see cref="Value"/> elements with a kind of
        /// Null are converted to null values in the resulting array.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator byte[][] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (byte[])x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion. Any <see cref="Value"/> elements with a kind of
        /// Null are converted to null values in the resulting array.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator Entity[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (Entity)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion. Any <see cref="Value"/> elements with a kind of
        /// Null are converted to null values in the resulting array.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator LatLng[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (LatLng)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion. Any <see cref="Value"/> elements with a kind of
        /// Null are converted to null values in the resulting array.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator Timestamp[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (Timestamp)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator DateTime[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (DateTime)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion. Any <see cref="Value"/> elements with a kind of
        /// Null are converted to null values in the resulting array.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator DateTime?[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (DateTime?)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator DateTimeOffset[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (DateTimeOffset)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion. Any <see cref="Value"/> elements with a kind of
        /// Null are converted to null values in the resulting array.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        /// <exception cref="InvalidOperationException">An element in the array value does not have the expected kind.</exception>
        public static explicit operator DateTimeOffset?[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => (DateTimeOffset?)x);
        /// <summary>
        /// Converts an <see cref="ArrayValue"/> to an array. Each value within <paramref name="arrayValue"/> is converted
        /// to a <see cref="Value"/> using the individual explicit conversion. Any <see cref="Value"/> elements with a kind of
        /// Null are converted to null values in the resulting array.
        /// </summary>
        /// <param name="arrayValue">The array value to convert.</param>
        /// <returns>An array with converted values, or <c>null</c> if <paramref name="arrayValue"/> is null.</returns>
        public static explicit operator Value[] (ArrayValue arrayValue) => FromArrayValue(arrayValue, x => x.OrNull());

        private static T[] FromArrayValue<T>(ArrayValue arrayValue, Func<Value, T> converter) =>
            arrayValue == null ? null : arrayValue.Values.Select(x => converter(x)).ToArray();
    }
}
