// Copyright 2017 Google Inc. All rights reserved.
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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Google.Cloud.Bigtable.Common.V2
{
    /// <summary>
    /// A sequence of bytes which can be used for a row key, column qualifier, or cell value.
    /// </summary>
    public struct BigtableByteString : IComparable, IComparable<BigtableByteString>, IEquatable<BigtableByteString>, IEnumerable<byte>, IEnumerable
    {
        private readonly ByteString _value;

        /// <summary>
        /// Creates a <see cref="BigtableByteString"/> value from the UTF-8 encoding of a string.
        /// </summary>
        /// <param name="valueAsUtf8">
        /// The value whose UTF-8 representation should be used to initialize the byte string.
        /// May be null in which case the empty byte string is used.
        /// </param>
        public BigtableByteString(string valueAsUtf8)
        {
            _value = valueAsUtf8 != null ? ByteString.CopyFromUtf8(valueAsUtf8) : ByteString.Empty;
        }

        /// <summary>
        /// Creates a <see cref="BigtableByteString"/> value from the big-endian encoding of a signed 64-bit value.
        /// </summary>
        /// <param name="value">The 64-bit value which should be used to initialize the byte string.</param>
        public BigtableByteString(long value)
        {
            var bytes = BitConverter.GetBytes(value);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            _value = ByteString.CopyFrom(bytes);
        }

        /// <summary>
        /// Creates a <see cref="BigtableByteString"/> value from an array of bytes.
        /// </summary>
        /// <param name="value">
        /// The bytes making up the byte string. May be null in which case the empty byte string is used.
        /// </param>
        public BigtableByteString(params byte[] value)
        {
            _value = value != null ? ByteString.CopyFrom(value) : ByteString.Empty;
        }

        /// <summary>
        /// Creates a <see cref="BigtableByteString"/> value from a byte string.
        /// </summary>
        /// <param name="value">
        /// The byte string making up the value. May be null in which case the empty byte string is used.
        /// </param>
        public BigtableByteString(ByteString value)
        {
            _value = value ?? ByteString.Empty;
        }

        /// <summary>
        /// Returns true if the byte string is empty, false otherwise.
        /// </summary>
        public bool IsEmpty => Value.IsEmpty;

        /// <summary>
        /// Gets the number of bytes in the byte string.
        /// </summary>
        public int Length => Value.Length;

        /// <summary>
        /// Gets the underlying byte string.
        /// </summary>
        public ByteString Value => _value ?? ByteString.Empty;

        /// <summary>
        /// Returns the byte at index <paramref name="index"/>.
        /// </summary>
        /// <param name="index">
        /// The index in the byte string to return. Must be greater than or equal to 0, and less than <see cref="Length"/>.
        /// </param>
        /// <returns>The byte at index <paramref name="index"/>.</returns>
        public byte this[int index] => Value[index];

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is BigtableByteString other && Equals(other);

        IEnumerator IEnumerable.GetEnumerator() => Value.GetEnumerator();

        /// <inheritdoc />
        public IEnumerator<byte> GetEnumerator() => Value.GetEnumerator();

        /// <inheritdoc />
        public override int GetHashCode() => Value.GetHashCode();

        /// <inheritdoc />
        public override string ToString()
        {
            var value = Value;
            var builder = new StringBuilder($"{nameof(BigtableByteString)}: Length={value.Length}; Hex");
            if (value.Length > 32)
            {
                builder.Append(" (first 32 bytes only)");
            }
            builder.Append('=');
            for (int i = 0; i < Math.Min(value.Length, 32); i++)
            {
                if (i != 0)
                {
                    builder.Append(" ");
                }
                builder.Append(value[i].ToString("X2"));
            }
            return builder.ToString();
        }

        /// <summary>
        /// Compares two <see cref="BigtableByteString"/> values lexicographically.
        /// </summary>
        /// <param name="x">Left value to compare</param>
        /// <param name="y">Right value to compare</param>
        /// <returns>true if <paramref name="x"/> is less than <paramref name="y"/>; otherwise false.</returns>
        public static int Compare(BigtableByteString x, BigtableByteString y)
        {
            ByteString xVal = x.Value;
            ByteString yVal = y.Value;
            for (int i = 0, length = Math.Min(xVal.Length, yVal.Length); i < length; ++i)
            {
                int result = xVal[i].CompareTo(yVal[i]);
                if (result != 0)
                {
                    return result;
                }
            }

            return xVal.Length.CompareTo(yVal.Length);
        }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if (obj is BigtableByteString other)
            {
                return CompareTo(other);
            }
            throw new ArgumentException($"The specified object cannot be compared with {nameof(BigtableByteString)}", nameof(obj));
        }

        /// <inheritdoc />
        public int CompareTo(BigtableByteString other) => Compare(this, other);

        /// <inheritdoc />
        public bool Equals(BigtableByteString other) => Length == other.Length && Compare(this, other) == 0;

        /// <summary>
        /// Operator overload to compare two <see cref="BigtableByteString"/> values.
        /// </summary>
        /// <param name="x">Left value to compare</param>
        /// <param name="y">Right value to compare</param>
        /// <returns>true if <paramref name="x"/> is less than <paramref name="y"/>; otherwise false.</returns>
        public static bool operator <(BigtableByteString x, BigtableByteString y) => Compare(x, y) < 0;

        /// <summary>
        /// Operator overload to compare two <see cref="BigtableByteString"/> values.
        /// </summary>
        /// <param name="x">Left value to compare</param>
        /// <param name="y">Right value to compare</param>
        /// <returns>true if <paramref name="x"/> is less than or equal <paramref name="y"/>; otherwise false.</returns>
        public static bool operator <=(BigtableByteString x, BigtableByteString y) => Compare(x, y) <= 0;

        /// <summary>
        /// Operator overload to compare two <see cref="BigtableByteString"/> values for equality.
        /// </summary>
        /// <param name="x">Left value to compare</param>
        /// <param name="y">Right value to compare</param>
        /// <returns>true if <paramref name="x"/> is equal to <paramref name="y"/>; otherwise false.</returns>
        public static bool operator ==(BigtableByteString x, BigtableByteString y) => x.Equals(y);

        /// <summary>
        /// Operator overload to compare two <see cref="BigtableByteString"/> values for inequality.
        /// </summary>
        /// <param name="x">Left value to compare</param>
        /// <param name="y">Right value to compare</param>
        /// <returns>true if <paramref name="x"/> is not equal to <paramref name="y"/>; otherwise false.</returns>
        public static bool operator !=(BigtableByteString x, BigtableByteString y) => !x.Equals(y);

        /// <summary>
        /// Operator overload to compare two <see cref="BigtableByteString"/> values.
        /// </summary>
        /// <param name="x">Left value to compare</param>
        /// <param name="y">Right value to compare</param>
        /// <returns>true if <paramref name="x"/> is greater than or equal <paramref name="y"/>; otherwise false.</returns>
        public static bool operator >=(BigtableByteString x, BigtableByteString y) => Compare(x, y) >= 0;

        /// <summary>
        /// Operator overload to compare two <see cref="BigtableByteString"/> values.
        /// </summary>
        /// <param name="x">Left value to compare</param>
        /// <param name="y">Right value to compare</param>
        /// <returns>true if <paramref name="x"/> is greater than <paramref name="y"/>; otherwise false.</returns>
        public static bool operator >(BigtableByteString x, BigtableByteString y) => Compare(x, y) > 0;

        /// <summary>
        /// Converts the UTF-8 encoding of a string to a <see cref="BigtableByteString"/> value.
        /// </summary>
        /// <param name="valueAsUtf8">
        /// The value whose UTF-8 representation should be used to initialize the byte string.
        /// May be null in which case the empty byte string is used.
        /// </param>
        public static implicit operator BigtableByteString(string valueAsUtf8) => new BigtableByteString(valueAsUtf8);

        /// <summary>
        /// Converts the <see cref="BigtableByteString"/> value to a string assuming it is UTF-8 encoded.
        /// </summary>
        /// <param name="value">
        /// The BigtableByteString value to convert.
        /// </param>
        public static explicit operator string(BigtableByteString value) => value.Value.ToStringUtf8();

        /// <summary>
        /// Converts the big-endian encoding of a signed 64-bit value to a <see cref="BigtableByteString"/> value.
        /// </summary>
        /// <param name="value">
        /// The 64-bit value which should be used to initialize the byte string.
        /// </param>
        public static implicit operator BigtableByteString(long value) => new BigtableByteString(value);

        /// <summary>
        /// Converts the <see cref="BigtableByteString"/> value to its a signed 64-bit value assuming it is big-endian encoded.
        /// </summary>
        /// <param name="value">
        /// The BigtableByteString value to convert.
        /// </param>
        public static explicit operator long(BigtableByteString value)
        {
            var bytes = value.Value.ToByteArray();
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            return BitConverter.ToInt64(bytes, 0);
        }

        /// <summary>
        /// Converts a byte array to a <see cref="BigtableByteString"/> value.
        /// </summary>
        /// <param name="value">
        /// The bytes making up the byte string. May be null in which case the empty byte string is used.
        /// </param>
        public static implicit operator BigtableByteString(byte[] value) => new BigtableByteString(value);

        /// <summary>
        /// Converts the <see cref="BigtableByteString"/> value to its underlying byte array.
        /// </summary>
        /// <param name="value">
        /// The BigtableByteString value to convert.
        /// </param>
        public static explicit operator byte[] (BigtableByteString value) => value.Value.ToByteArray();

        /// <summary>
        /// Converts a byte string to a <see cref="BigtableByteString"/> value.
        /// </summary>
        /// <param name="value">
        /// The byte string making up the value. May be null in which case the empty byte string is used.
        /// </param>
        public static implicit operator BigtableByteString(ByteString value) => new BigtableByteString(value);

        /// <summary>
        /// Converts the <see cref="BigtableByteString"/> value to its underlying byte string.
        /// </summary>
        /// <param name="value">
        /// The BigtableByteString value to convert.
        /// </param>
        public static explicit operator ByteString(BigtableByteString value) => value.Value;
    }
}
