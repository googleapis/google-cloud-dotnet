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

        internal static string BuildSelectedFields(this TableSchema schema)
        {
            // Althouhg null and empty SelectedFields mean the same, that is to return
            // whole rows, let's return null for a null schema and string.Empty for an
            // empty schema, just in case these get diferentiated in the future. And also
            // it's clearer.
            if (schema == null)
            {
                return null;
            }
            if (!(schema.Fields?.Count > 0))
            {
                return string.Empty;
            }

            // This list will contain the paths to all terminal fields that we have found.
            // In the end this list will contain all selected fields.
            var built = new List<string>();
            // This list will contain the path to the field we are currently traversing.
            // If it is a terminal field (no nested fields) then we build the path to it
            // and backtrack to the previous level.
            // If it is not terminal, then we just traverse (in depth) its nested fields.
            var currentPath = new List<string>();
            BuildSelectedFields(schema.Fields, currentPath, built);
            return string.Join(",", built);
        }

        private static void BuildSelectedFields(IList<TableFieldSchema> fieldSchemas, IList<string> currentPath, IList<string> built)
        {
            if (!(fieldSchemas?.Count > 0))
            {
                // Whatever we have in currentPath is terminal.
                // Build that and we are done.
                built.Add(string.Join(".", currentPath));
            }
            else
            {
                // For each field at this level, we'll add it to the current path
                // and then go in depth into its possible nested fields.
                // When we return from the recursive call, we can remove this field
                // from the current path. It will always be at the last index, which
                // will always be one more than what we have right now.
                int removeAtIndex = currentPath.Count;
                foreach (var field in fieldSchemas)
                {
                    currentPath.Add(field.Name);
                    BuildSelectedFields(field.Fields, currentPath, built);
                    currentPath.RemoveAt(removeAtIndex);
                }
            }
        }
    }
}
