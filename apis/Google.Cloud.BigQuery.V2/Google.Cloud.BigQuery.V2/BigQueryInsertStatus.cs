// Copyright 2020 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Specifies the status of an insert attempt depending on the validity of the rows.
    /// Note that the validity of a row is determined by whether <see cref="InsertOptions.AllowUnknownFields"/>
    /// is set to true or not.
    /// If <see cref="InsertOptions.AllowUnknownFields"/> is set to true, then rows containing fields
    /// that do not match any on the destination table will, otherwise, be considered valid rows.
    /// All matching fields in these rows will be inserted, while unmatching fields will be silently skipped.
    /// If <see cref="InsertOptions.AllowUnknownFields"/> is not set to true, then rows containing fields
    /// that do not match any on the destination table will be considered invalid and won't be inserted.
    /// </summary>
    public enum BigQueryInsertStatus
    {
        /// <summary>
        /// All rows were inserted successfully.
        /// This only happens if all rows are valid rows.
        /// </summary>
        AllRowsInserted,

        /// <summary>
        /// Some rows were inserted but not others. In that case the <see cref="BigQueryInsertResults"/>
        /// returned by the insert operation will contain error information about the rows that were not inserted.
        /// This happens only when <see cref="InsertOptions.SkipInvalidRows"/> is set to true and some, 
        /// but not all of the rows, are invalid.
        /// </summary>
        SomeRowsInserted,

        /// <summary>
        /// No rows were inserted. In that case the <see cref="BigQueryInsertResults"/>
        /// returned by the insert operation will contain error information about the invalid rows.
        /// This can happen when:
        /// <list type="bullet">
        /// <item><description>No rows are valid.</description></item>
        /// <item><description><see cref="InsertOptions.SkipInvalidRows"/> is not set to true and at least
        /// one row is invalid.</description></item>
        /// </list>
        /// </summary>
        NoRowsInserted
    }
}
