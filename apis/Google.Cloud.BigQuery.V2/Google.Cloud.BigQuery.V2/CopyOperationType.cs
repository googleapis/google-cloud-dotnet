// Copyright 2023 Google Inc. All Rights Reserved.
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
    /// Indicates different operation types supported in table copy job.
    /// </summary>
    public enum CopyOperationType
    {
        /// <summary>
        /// Operation not specified.
        /// </summary>
        [ApiValue("OPERATION_TYPE_UNSPECIFIED")]
        Unspecified,

        /// <summary>
        /// The source and destination table have the same table type.
        /// </summary>
        [ApiValue("COPY")]
        Copy,

        /// <summary>
        /// The source table type is TABLE and the destination table type is SNAPSHOT.
        /// </summary>
        [ApiValue("SNAPSHOT")]
        Snapshot,

        /// <summary>
        /// The source table type is SNAPSHOT and the destination table type is TABLE.
        /// </summary>
        [ApiValue("RESTORE")]
        Restore,

        /// <summary>
        /// The source and destination table have the same table type, 
        /// but we charge only for the delta bytes.
        /// </summary>
        [ApiValue("CLONE")]
        Clone,
    }
}
