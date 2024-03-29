﻿// Copyright 2017 Google Inc. All Rights Reserved.
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
    /// A file format used for load/extract operations.
    /// </summary>
    public enum FileFormat
    {
        /// <summary>
        /// A CSV file.
        /// </summary>
        [ApiValue("CSV")]
        Csv,
        /// <summary>
        /// A file where each line is a JSON object.
        /// </summary>
        [ApiValue("NEWLINE_DELIMITED_JSON")]
        NewlineDelimitedJson,

        /// <summary>
        /// A file in Avro format
        /// </summary>
        [ApiValue("AVRO")]
        Avro,

        /// <summary>
        /// A Datastore backup file. This option is not supported
        /// for all operations.
        /// </summary>
        [ApiValue("DATASTORE_BACKUP")]
        DatastoreBackup,

        /// <summary>
        /// A Parquet file.
        /// </summary>
        [ApiValue("PARQUET")]
        Parquet,

        /// <summary>
        /// An ORC file.
        /// </summary>
        [ApiValue("ORC")]
        Orc
    }
}
