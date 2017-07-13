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
    /// Represents a column in a Spanner database.
    /// A SpannerColumn is treated as a parameter whose name matches the column name.
    /// </summary>
    public class SpannerColumn : SpannerParameter
    {
        /// <summary>
        /// Initializes a new instance of the SpannerColumn class.
        /// </summary>
        public SpannerColumn() { }

        /// <summary>
        /// Initializes a new instance of the SpannerColumn class.
        /// </summary>
        /// <param name="columnName">
        /// The name of the column. This name should be the name of a valid column in a Spanner
        /// table. This value is case sensitive. Must not be null.
        /// </param>
        /// <param name="type">
        /// One of the <see cref="SpannerDbType" /> values that indicates the type of the column.
        /// Must not be null.
        /// </param>
        /// <param name="value">An object that is the value of the SpannerColumn. May be null.</param>
        /// <param name="sourceColumn">
        /// The name of the DataTable source column (SourceColumn) if this SpannerColumn is
        /// used in a call to Update. May be null.
        /// </param>
        /// <param name="size">The length of the column. The value is for informational purposes only.</param>
        public SpannerColumn(
            string columnName,
            SpannerDbType type,
            object value = null,
            string sourceColumn = null,
            int size = 0) : base(columnName, type, value, sourceColumn, size) { }
    }
}
