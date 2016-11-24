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

        internal void ModifyRequest(TableDataInsertAllRequest body)
        {
            if (AllowUnknownFields != null)
            {
                body.IgnoreUnknownValues = AllowUnknownFields;
            }
        }
    }
}
