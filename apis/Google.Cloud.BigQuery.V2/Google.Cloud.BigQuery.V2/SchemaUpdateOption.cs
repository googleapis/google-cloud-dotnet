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

using System;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// How to update the schema when performing load/extract operations.
    /// </summary>
    [Flags]
    public enum SchemaUpdateOption
    {
        /// <summary>
        /// Allows adding a nullable field to the schema.
        /// </summary>
        [ApiValue("ALLOW_FIELD_ADDITION")]
        AllowFieldAddition = 1,

        /// <summary>
        /// Allows relaxing a required field in the original schema to nullable.
        /// </summary>
        [ApiValue("ALLOW_FIELD_RELAXATION")]
        AllowFieldRelaxation = 2
    }
}
