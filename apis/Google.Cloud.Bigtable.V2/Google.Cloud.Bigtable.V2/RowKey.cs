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

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// The key of a row.
    /// </summary>
    public sealed class RowKey : IEquatable<RowKey>
    {
        /// <summary>
        /// Creates a new <see cref="RowKey"/> instance from the UTF8 encoding of a string.
        /// </summary>
        /// <param name="keyAsUtf8">The key whose UTF8 representation should be used to initialize the key.</param>
        public RowKey(string keyAsUtf8)
        {
            ByteString = ByteString.CopyFromUtf8(keyAsUtf8);
        }

        /// <summary>
        /// Creates a new <see cref="RowKey"/> instance from an array of bytes.
        /// </summary>
        /// <param name="key">The bytes making up the key.</param>
        public RowKey(params byte[] key)
        {
            ByteString = ByteString.CopyFrom(key);
        }

        /// <summary>
        /// Creates a new <see cref="RowKey"/> instance from a byte string.
        /// </summary>
        /// <param name="key">The byte string making up the key.</param>
        public RowKey(ByteString key)
        {
            ByteString = key;
        }

        /// <summary>
        /// Gets the string of bytes making up the key.
        /// </summary>
        public ByteString ByteString { get; }

        // TODO: Docs

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(RowKey other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator ==(RowKey x, RowKey y)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator !=(RowKey x, RowKey y)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyAsUtf8"></param>
        public static implicit operator RowKey(string keyAsUtf8)
        {
            return new RowKey(keyAsUtf8);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        public static implicit operator RowKey(byte[] key)
        {
            return new RowKey(key);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        public static implicit operator RowKey(ByteString key)
        {
            return new RowKey(key);
        }
    }
}
