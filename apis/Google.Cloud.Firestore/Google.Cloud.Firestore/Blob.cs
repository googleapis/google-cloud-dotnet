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
using Google.Protobuf;
using System;
using System.Text;

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// An immutable sequence of bytes.
    /// </summary>
    /// <remarks>
    /// Although this is a struct, it's effectively just a wrapper around a Protobuf ByteString.
    /// <c>default(Blob)</c> acts as if it had been constructed with <see cref="ByteString.Empty"/>.
    /// </remarks>
    public struct Blob : IEquatable<Blob>
    {
        private readonly ByteString _byteString;

        /// <summary>
        /// The underlying Protobuf ByteString.
        /// </summary>
        public ByteString ByteString => _byteString ?? ByteString.Empty;

        /// <summary>
        /// The length of the blob, in bytes.
        /// </summary>
        public int Length => ByteString.Length;

        /// <summary>
        /// Returns the byte at index <paramref name="index"/>.
        /// </summary>
        /// <param name="index">The index in the blob to return. Must be greater than or equal to 0, and less than <see cref="Length"/>.</param>
        /// <returns>The byte at index <paramref name="index"/>.</returns>
        public byte this[int index] => ByteString[index];

        private Blob(ByteString byteString) => _byteString = GaxPreconditions.CheckNotNull(byteString, nameof(byteString));

        /// <summary>
        /// Constructs a new <see cref="Blob"/> wrapping the given <see cref="ByteString"/>.
        /// </summary>
        /// <param name="byteString">The ByteString to wrap. Must not be null.</param>
        /// <returns>A new blob wrapping <paramref name="byteString"/>.</returns>
        public static Blob FromByteString(ByteString byteString) => new Blob(byteString);

        /// <summary>
        /// Constructs a new <see cref="Blob"/> by copying the current content of <paramref name="bytes"/>.
        /// </summary>
        /// <param name="bytes">Byte array to copy.</param>
        /// <returns>A new blob containing a copy of <paramref name="bytes"/>.</returns>
        public static Blob CopyFrom(byte[] bytes) => new Blob(ByteString.CopyFrom(bytes));

        /// <inheritdoc />
        public override bool Equals(object obj) => obj is Blob blob && Equals(blob);

        /// <inheritdoc />
        public override int GetHashCode() => ByteString.GetHashCode();

        /// <inheritdoc />
        public bool Equals(Blob other) => ByteString == other.ByteString;

        /// <summary>
        /// Operator overload to compare two Blob values for equality.
        /// </summary>
        /// <param name="lhs">Left value to compare</param>
        /// <param name="rhs">Right value to compare</param>
        /// <returns>true if <paramref name="lhs"/> is equal to <paramref name="rhs"/>; otherwise false.</returns>
        public static bool operator ==(Blob lhs, Blob rhs) => lhs.Equals(rhs);

        /// <summary>
        /// Operator overload to compare two Blob values for inequality.
        /// </summary>
        /// <param name="lhs">Left value to compare</param>
        /// <param name="rhs">Right value to compare</param>
        /// <returns>false if <paramref name="lhs"/> is equal to <paramref name="rhs"/>; otherwise true.</returns>
        public static bool operator !=(Blob lhs, Blob rhs) => !lhs.Equals(rhs);

        /// <inheritdoc />
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("Blob: Length=");
            builder.Append(ByteString.Length);
            builder.Append(ByteString.Length > 32 ? "; Hex (first 32 bytes only)=" : "; Hex=");
            for (int i = 0; i < Math.Min(ByteString.Length, 32); i++)
            {
                if (i != 0)
                {
                    builder.Append(" ");
                }
                builder.Append(ByteString[i].ToString("X2"));
            }
            return builder.ToString();
        }
    }
}
