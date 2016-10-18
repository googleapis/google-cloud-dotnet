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

using System.Collections.Generic;

namespace Google.Bigquery.V2
{
    /// <summary>
    /// The type of a query parameter.
    /// </summary>
    /// <remarks>
    /// This is separate from <see cref="BigqueryDbType"/>
    /// </remarks>
    public enum BigqueryParameterType
    {
        /// <summary>
        /// An 64-bit signed integer value.
        /// </summary>
        Int64,
        /// <summary>
        /// Variable-length binary data.
        /// </summary>
        Bytes,
        /// <summary>
        /// Variable-length character (Unicode) data.
        /// </summary>
        String,
        /// <summary>
        /// Represents a logical calendar date. Values range between the years 1 and 9999, inclusive.
        /// </summary>
        Date,
        /// <summary>
        /// Represents a year, month, day, hour, minute, second, and subsecond (microsecond precision).
        /// </summary>
        DateTime,
        /// <summary>
        /// Represents a time, independent of a specific date, to microsecond precision.
        /// </summary>
        Time,
        /// <summary>
        /// Represents an absolute point in time, with microsecond precision. Values range between the years 1 and 9999, inclusive.
        /// </summary>
        Timestamp,
        /// <summary>
        /// A 64-bit IEEE binary floating-point value.
        /// </summary>
        Float64,
        /// <summary>
        /// A Boolean value (true or false).
        /// </summary>
        Bool,
        /// <summary>
        /// Ordered list of zero or more elements of any non-array type.
        /// </summary>
        Array,
        /// <summary>
        /// Container of ordered fields each with a type (required) and field name (optional).
        /// </summary>
        Struct
    }
}
