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

using System;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// </summary>
    public static class TypeCodeExtensions
    {
        /// <summary>
        /// </summary>
        /// <param name="typeCode"></param>
        /// <returns></returns>
        public static string GetOriginalName(this TypeCode typeCode)
        {
            switch (typeCode)
            {
                case TypeCode.Unspecified:
                    return "UKNOWN";
                case TypeCode.Bool:
                    return "BOOL";
                case TypeCode.Int64:
                    return "INT64";
                case TypeCode.Float64:
                    return "FLOAT64";
                case TypeCode.Timestamp:
                    return "TIMESTAMP";
                case TypeCode.Date:
                    return "DATE";
                case TypeCode.String:
                    return "STRING";
                case TypeCode.Bytes:
                    return "BYTES";
                case TypeCode.Array:
                    return "ARRAY";
                case TypeCode.Struct:
                    return "STRUCT";
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeCode), typeCode, null);
            }
        }
    }
}
