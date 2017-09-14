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
using System;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Extension methods over table schemas.
    /// </summary>
    internal static class TableSchemaExtensions
    {
        internal static Dictionary<string, int> IndexFieldNames(this TableSchema schema)
        {
            // Could use LINQ, but there's no overload for ToDictionary that gives us the index,
            // using Select to get it feels annoying.
            // While Fields is unlikely to be null in realistic use cases, it does no harm to handle it.
            var fields = schema.Fields ?? new TableFieldSchema[0];
            var ret = new Dictionary<string, int>(fields.Count, StringComparer.Ordinal);
            for (int i = 0; i < fields.Count; i++)
            {
                // This will throw on duplicate field names. This should never happen in real life,
                // and if it does, it's better to have an exception than silently start returning
                // unexpected data.
                ret.Add(fields[i].Name, i);
            }
            return ret;
        }
    }
}
