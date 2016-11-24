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
    /// Specifies whether a job is allowed to create new tables.
    /// </summary>
    public enum CreateDisposition
    {
        /// <summary>
        /// If the table does not exist, BigQuery creates the table.
        /// </summary>
        [ApiValue("CREATE_IF_NEEDED")]
        CreateIfNeeded,

        /// <summary>
        /// The table must already exist. If it does not, a 'notFound' error is
        /// returned in the job result.
        /// </summary>
        [ApiValue("CREATE_NEVER")]
        CreateNever
    }
}
