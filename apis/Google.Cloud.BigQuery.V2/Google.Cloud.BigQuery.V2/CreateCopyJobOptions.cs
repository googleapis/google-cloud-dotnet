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

using Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>CreateCopyJob</c> operations.
    /// </summary>
    public sealed class CreateCopyJobOptions
    {
        /// <summary>
        /// The behavior if the destination table doesn't exist. If this
        /// is unspecified, the default is to create a new table.
        /// </summary>
        public CreateDisposition? CreateDisposition { get; set; }

        /// <summary>
        /// Specifies the behavior if the destination table exists.
        /// If not set, this is effectively <see cref="WriteDisposition.WriteIfEmpty"/>.
        /// </summary>
        public WriteDisposition? WriteDisposition { get; set; }

        internal void ModifyRequest(JobConfigurationTableCopy copy)
        {
            if (CreateDisposition != null)
            {
                copy.CreateDisposition = EnumMap.ToApiValue(CreateDisposition.Value);
            }
            if (WriteDisposition != null)
            {
                copy.WriteDisposition = EnumMap.ToApiValue(WriteDisposition.Value);
            }
        }
    }
}
