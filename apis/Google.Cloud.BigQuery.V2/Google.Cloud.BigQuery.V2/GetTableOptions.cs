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

using static Google.Apis.Bigquery.v2.TablesResource;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>GetTable</c> operations.
    /// </summary>
    public sealed class GetTableOptions
    {
        /// <summary>
        /// Comma separated list of schema fields to return.
        /// When set allows to obtain a partial table schema.
        /// When this property is null or empty the full table schema is returned.
        /// </summary>
        public string SelectedFields { get; set; }

        internal void ModifyRequest(GetRequest request)
        {
            if (SelectedFields != null)
            {
                request.SelectedFields = SelectedFields;
            }
        }
    }
}
