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
    /// A column qualifier.
    /// </summary>
    public sealed class ColumnQualifier : IEquatable<ColumnQualifier>
    {
        /// <summary>
        /// Creates a new <see cref="ColumnQualifier"/> instance from the UTF8 encoding of a string.
        /// </summary>
        /// <param name="qualifierAsUtf8">The qualifier whose UTF8 representation should be used to initialize the qualifier.</param>
        public ColumnQualifier(string qualifierAsUtf8)
        {
            ByteString = ByteString.CopyFromUtf8(qualifierAsUtf8);
        }

        /// <summary>
        /// Creates a new <see cref="ColumnQualifier"/> instance from an array of bytes.
        /// </summary>
        /// <param name="qualifier">The bytes making up the qualifier.</param>
        public ColumnQualifier(params byte[] qualifier)
        {
            ByteString = ByteString.CopyFrom(qualifier);
        }

        /// <summary>
        /// Creates a new <see cref="ColumnQualifier"/> instance from a byte string.
        /// </summary>
        /// <param name="qualifier">The byte string making up the qualifier.</param>
        public ColumnQualifier(ByteString qualifier)
        {
            ByteString = qualifier;
        }

        /// <summary>
        /// Gets the string of bytes making up the qualifier.
        /// </summary>
        public ByteString ByteString { get; }

        // TODO: Docs

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(ColumnQualifier other)
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
        public static bool operator ==(ColumnQualifier x, ColumnQualifier y)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator !=(ColumnQualifier x, ColumnQualifier y)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="qualifierAsUtf8"></param>
        public static implicit operator ColumnQualifier(string qualifierAsUtf8)
        {
            return new ColumnQualifier(qualifierAsUtf8);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="qualifier"></param>
        public static implicit operator ColumnQualifier(byte[] qualifier)
        {
            return new ColumnQualifier(qualifier);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="qualifier"></param>
        public static implicit operator ColumnQualifier(ByteString qualifier)
        {
            return new ColumnQualifier(qualifier);
        }
    }
}