// Copyright 2017 Google Inc. All Rights Reserved.
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

using System.Collections.Generic;
using Google.Api.Gax;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// </summary>
    public static class TypeCodeExtensions
    {
        private static readonly Dictionary<string, TypeCode> s_originalNameToCode
            = new Dictionary<string, TypeCode>
            {
                {TypeCode.Bool.ToString().ToUpperInvariant(), TypeCode.Bool},
                {TypeCode.Unspecified.ToString().ToUpperInvariant(), TypeCode.Unspecified},
                {TypeCode.Int64.ToString().ToUpperInvariant(), TypeCode.Int64},
                {TypeCode.Float64.ToString().ToUpperInvariant(), TypeCode.Float64},
                {TypeCode.Timestamp.ToString().ToUpperInvariant(), TypeCode.Timestamp},
                {TypeCode.Date.ToString().ToUpperInvariant(), TypeCode.Date},
                {TypeCode.String.ToString().ToUpperInvariant(), TypeCode.String},
                {TypeCode.Bytes.ToString().ToUpperInvariant(), TypeCode.Bytes},
                {TypeCode.Array.ToString().ToUpperInvariant(), TypeCode.Array},
                {TypeCode.Struct.ToString().ToUpperInvariant(), TypeCode.Struct},
            };

        /// <summary>
        /// </summary>
        /// <param name="typeCode"></param>
        /// <returns></returns>
        public static string GetOriginalName(this TypeCode typeCode)
        {
            return typeCode.ToString().ToUpperInvariant();
        }

        /// <summary>
        /// Returns a TypeCode given its original string representation.
        /// </summary>
        /// <param name="originalName"></param>
        /// <returns></returns>
        public static TypeCode GetTypeCode(string originalName)
        {
            GaxPreconditions.CheckNotNull(originalName, nameof(originalName));
            return s_originalNameToCode.TryGetValue(originalName.Trim(), out var typeCode)
                ? typeCode
                : TypeCode.Unspecified;
        }
    }
}
