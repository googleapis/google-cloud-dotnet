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

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// These types come from Google.Cloud.Spanner.V1.TypeCode
    /// </summary>
    public enum SpannerDbType
    {
        /// <summary>
        /// Not specified.
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Encoded as JSON `true` or `false`.
        /// </summary>
        Bool = 1,

        /// <summary>
        /// Encoded as `string`, in decimal format.
        /// </summary>
        Int64 = 2,

        /// <summary>
        /// Encoded as `number`, or the strings `"NaN"`, `"Infinity"`, or
        /// `"-Infinity"`.
        /// </summary>
        Float64 = 3,

        /// <summary>
        /// Encoded as `string` in RFC 3339 timestamp format. The time zone
        /// must be present, and must be `"Z"`.
        /// </summary>
        Timestamp = 4,

        /// <summary>
        /// Encoded as `string` in RFC 3339 date format.
        /// </summary>
        Date = 5,

        /// <summary>
        /// Encoded as `string`.
        /// </summary>
        String = 6,

        /// <summary>
        /// Encoded as a base64-encoded `string`, as described in RFC 4648,
        /// section 4.
        /// </summary>
        Bytes = 7,

        /// <summary>
        /// Encoded as `list`, where the list elements are represented
        /// according to [array_element_type][google.spanner.v1.Type.array_element_type].
        /// </summary>
        Array = 8,

        /// <summary>
        /// Encoded as `list`, where list element `i` is represented according
        /// to [struct_type.fields[i]][google.spanner.v1.StructType.fields].
        /// </summary>
        Struct = 9
    }
}