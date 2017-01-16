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

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// The partitioning type used for tables which are partitioned
    /// based on time. Currently only "day" is supported, but this enum
    /// exists to allow for future expansion. See
    /// https://cloud.google.com/bigquery/docs/creating-partitioned-tables for
    /// more details on partitioned tables.
    /// </summary>
    public enum TimePartitionType
    {
        /// <summary>
        /// The table is not partitioned by time.
        /// </summary>
        None = 0,

        /// <summary>
        /// The table is partitioned by day; each day's data resides
        /// in a different table.
        /// </summary>
        Day = 1
    }
}
