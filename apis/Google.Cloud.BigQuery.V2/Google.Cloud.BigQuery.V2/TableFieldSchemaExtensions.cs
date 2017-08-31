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
using System.Collections.Generic;
using Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Extension methods over table schema fields. We may want to expose these as public methods
    /// at some point.
    /// </summary>
    internal static class TableFieldSchemaExtensions
    {
        /// <summary>
        /// Returns the type of a field as a <see cref="BigQueryDbType"/>.
        /// </summary>
        internal static BigQueryDbType GetFieldType(this TableFieldSchema field) =>
            EnumMap<BigQueryDbType>.ToValue(field.Type);

        /// <summary>
        /// Returns the mode of a field as a <see cref="BigQueryFieldMode"/>.
        /// </summary>
        internal static BigQueryFieldMode GetFieldMode(this TableFieldSchema field) =>
            EnumMap<BigQueryFieldMode>.ToValue(field.Mode);

        internal static Type ToClrType(this TableFieldSchema field)
        {
            var fieldType = field.GetFieldType().ToClrType();
            if (field.GetFieldMode() == BigQueryFieldMode.Repeated)
            {
                return fieldType.MakeArrayType();
            }
            return fieldType;
        }
    }
}
