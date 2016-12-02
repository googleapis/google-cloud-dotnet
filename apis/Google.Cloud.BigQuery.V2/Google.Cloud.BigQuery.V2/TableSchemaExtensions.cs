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

using System.Collections.Generic;
using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Extension methods over table schemas.
    /// </summary>
    public static class TableSchemaExtensions
    {
        /// <summary>
        /// Retrieves the index of a field given its name.
        /// </summary>
        public static int GetFieldIndex(this TableSchema schema, string fieldName)
        {
            GaxPreconditions.CheckNotNull(schema, nameof(schema));
            GaxPreconditions.CheckNotNull(fieldName, nameof(fieldName));

            for (int i = 0; i < schema.Fields.Count; i++)
            {
                if (schema.Fields[i].Name == fieldName)
                {
                    return i;
                }
            }
            throw new KeyNotFoundException($"No such field: '{fieldName}'");
        }
    }
}
