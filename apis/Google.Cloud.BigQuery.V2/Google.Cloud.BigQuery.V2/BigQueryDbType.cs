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

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// The type of a field within a schema.
    /// </summary>
    public enum BigQueryDbType
    {
        /// <summary>
        /// An 64-bit signed integer value.
        /// </summary>
        Integer,
        /// <summary>
        /// Binary data.
        /// </summary>
        Bytes,
        /// <summary>
        /// A text value, up to 2MB when encoded in UTF-8.
        /// </summary>
        String,
        /// <summary>
        /// A timestamp with microsecond precision.
        /// </summary>
        Timestamp,
        /// <summary>
        /// A civil date in the Gregorian calendar.
        /// </summary>
        Date,
        /// <summary>
        /// A civil time-of-day with microsecond precision.
        /// </summary>
        Time,
        /// <summary>
        /// A civil date and time with microsecond precision.
        /// </summary>
        DateTime,
        /// <summary>
        /// A 64-bit IEEE binary floating-point value.
        /// </summary>
        Float,
        /// <summary>
        /// A Boolean value.
        /// </summary>
        Boolean,
        /// <summary>
        /// A record type with a nested schema.
        /// </summary>
        Record,
    }
}
