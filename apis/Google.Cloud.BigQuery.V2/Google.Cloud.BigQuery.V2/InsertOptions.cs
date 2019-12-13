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

using Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.V2
{


    /// <summary>
    /// Options for <c>Insert</c> operations.
    /// </summary>
    public sealed class InsertOptions
    {
        /// <summary>
        /// Whether or not to accept rows with fields that are not specified in the schema,
        /// ignoring the extra fields.
        /// If not set, this is effectively false.
        /// </summary>
        public bool? AllowUnknownFields { get; set; }

        /// <summary>
        /// Insert all valid rows of a request, even if invalid rows exist.
        /// If false, the entire request will fail if any invalid rows exist.
        /// If not set, this is effectively false. This property is unset by default.
        /// </summary>
        public bool? SkipInvalidRows { get; set; }

        /// <summary>
        /// If true, insert errors don't lead to an exception.
        /// This property has no effect on which rows are inserted and which are not.
        /// The default value is false.
        /// </summary>
        public bool SuppressInsertErrors { get; set; }

        /// <summary>
        /// If specified, treats the destination table as a base template, and inserts the
        /// rows into an instance table named "{destination}{templateSuffix}". BigQuery will
        /// manage creation of the instance table, using the schema of the base template
        /// table. See https://cloud.google.com/bigquery/streaming-data-into-bigquery#template-tables
        /// for considerations when working with templates tables.
        /// </summary>
        public string TemplateSuffix { get; set; }

        /// <summary>
        /// When true allows <see cref="BigQueryInsertRow.InsertId"/> to be
        /// unspecified. This in turns allows for faster inserts, at the expense
        /// of possible record duplication if the operation needs to be retried.
        /// See https://cloud.google.com/bigquery/quotas#streaming_inserts for
        /// more information.
        /// The default value is false.
        /// </summary>
        public bool AllowEmptyInsertIds { get; set; }

        internal void ModifyRequest(TableDataInsertAllRequest body)
        {
            if (AllowUnknownFields != null)
            {
                body.IgnoreUnknownValues = AllowUnknownFields;
            }
            if (SkipInvalidRows != null)
            {
                body.SkipInvalidRows = SkipInvalidRows;
            }
            if (TemplateSuffix != null)
            {
                body.TemplateSuffix = TemplateSuffix;
            }
        }
    }
}
