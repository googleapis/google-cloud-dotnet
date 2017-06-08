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
    /// Indicates the type of <see cref="SpannerCommand"/> that will be executed.
    /// </summary>
    public enum SpannerCommandType
    {
        /// <summary>
        /// A SQL Query.
        /// </summary>
        Select = 0,

        /// <summary>
        /// Updates rows in a table.
        /// </summary>
        Update = 1,

        /// <summary>
        /// Deletes rows from a table.
        /// </summary>
        Delete = 2,

        /// <summary>
        /// Inserts rows into a table.
        /// </summary>
        Insert = 3,

        /// <summary>
        /// Inserts or updates rows in a table.
        /// </summary>
        InsertOrUpdate = 4,

        /// <summary>
        /// A DDL statement (e.g. a statement to create or modify table schema).
        /// </summary>
        Ddl
    }
}
