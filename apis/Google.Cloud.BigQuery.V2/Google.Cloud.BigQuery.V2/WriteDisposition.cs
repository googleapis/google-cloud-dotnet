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

using System;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Indicates the desired behavior when writing to a table which already contains data.
    /// </summary>
    public enum WriteDisposition
    {
        /// <summary>
        /// The additional data is appended to the table.
        /// </summary>
        [ApiValue("WRITE_APPEND")]
        WriteAppend,
        /// <summary>
        /// The table is truncated before the additional data is inserted.
        /// </summary>
        [ApiValue("WRITE_TRUNCATE")]
        WriteTruncate,
        /// <summary>
        /// Attempting to write data to a non-empty table fails with an error.
        /// </summary>
        [ApiValue("WRITE_EMPTY")]
        WriteIfEmpty,
        /// <summary>
        /// If the table already exists, BigQuery overwrites the
        /// data, but keeps the constraints and schema of the existing table.
        /// </summary>
        [ApiValue("WRITE_TRUNCATE_DATA")]
        WriteTruncateData
    }
}
