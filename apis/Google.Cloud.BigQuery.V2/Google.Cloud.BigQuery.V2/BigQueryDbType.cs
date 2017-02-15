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

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// A BigQuery database type, used for schemas and parameters.
    /// </summary>
    public enum BigQueryDbType
    {
        /// <summary>
        /// An 64-bit signed integer value.
        /// This is known as Integer in Legacy SQL data types.
        /// </summary>
        [ApiValue("INTEGER")]
        Int64,
        /// <summary>
        /// A 64-bit IEEE binary floating-point value.
        /// This is known as Float in Legacy SQL data types.
        /// </summary>
        [ApiValue("FLOAT")]
        Float64,
        /// <summary>
        /// A Boolean value.
        /// </summary>
        [ApiValue("BOOLEAN")]
        Bool,
        /// <summary>
        /// A text value, up to 2MB when encoded in UTF-8.
        /// </summary>
        String,
        /// <summary>
        /// Binary data.
        /// </summary>
        Bytes,
        /// <summary>
        /// A civil date in the Gregorian calendar.
        /// </summary>
        Date,
        /// <summary>
        /// A civil date and time with microsecond precision.
        /// </summary>
        DateTime,
        /// <summary>
        /// A civil time-of-day with microsecond precision.
        /// </summary>
        Time,
        /// <summary>
        /// A timestamp with microsecond precision.
        /// </summary>
        Timestamp,
        /// <summary>
        /// An ordered list of zero or more elements of non-array values.
        /// </summary>
        /// <remarks>
        /// This type cannot be used when creating tables; instead, create
        /// a field with a mode of <see cref="BigQueryFieldMode.Repeated"/>.
        /// </remarks>
        Array,
        /// <summary>
        /// An ordered collection of fields. Each field has a
        /// type, and may optionally have a name. This is known
        /// as a record in Legacy SQL data types.
        /// </summary>
        [ApiValue("RECORD")]
        Struct
    }

    internal static class BigQueryDbTypeExtensions
    {
        // The names given in query parameters aren't always the same as the names in the rest of the API.
        // (BOOL is BOOLEAN elsewhere, for example.) We could use another attribute, but a dictionary
        // is a bit simpler.
        private static Dictionary<BigQueryDbType, string> s_typeToNameMapping = new Dictionary<BigQueryDbType, string>
        {
            { BigQueryDbType.Int64, "INTEGER" },
            { BigQueryDbType.Float64, "FLOAT" },
            { BigQueryDbType.Bool, "BOOL" },
            { BigQueryDbType.String, "STRING" },
            { BigQueryDbType.Bytes, "BYTES" },
            { BigQueryDbType.Date, "DATE" },
            { BigQueryDbType.DateTime, "DATETIME" },
            { BigQueryDbType.Time, "TIME" },
            { BigQueryDbType.Timestamp, "TIMESTAMP" },
            { BigQueryDbType.Array, "ARRAY" },
            { BigQueryDbType.Struct, "STRUCT" }
        };

        internal static string ToParameterApiType(this BigQueryDbType type) => s_typeToNameMapping[type];
    }
}
