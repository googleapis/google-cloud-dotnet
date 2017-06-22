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
    /// Options for <c>UploadAvro</c> operations.
    /// </summary>
    public sealed class UploadAvroOptions
    {
        /// <summary>
        /// Whether or not to accept rows with fields that are not specified in the schema,
        /// ignoring the extra fields.
        /// If not set, this is effectively false.
        /// </summary>
        public bool? AllowUnknownFields { get; set; }

        /// <summary>
        /// The maximum number of bad records that are ignored before the overall job fails.
        /// If not set, this is effectively 0.
        /// </summary>
        public int? MaxBadRecords { get; set; }

        /// <summary>
        /// Specifies whether the operation is allowed to create new tables.
        /// If not set, this is effectively <see cref="CreateDisposition.CreateIfNeeded"/>.
        /// </summary>
        public CreateDisposition? CreateDisposition { get; set; }

        /// <summary>
        /// Specifies the behavior if the destination table exists.
        /// If not set, this is effectively <see cref="WriteDisposition.WriteAppend"/>.
        /// </summary>
        public WriteDisposition? WriteDisposition { get; set; }

        internal void ModifyConfiguration(JobConfigurationLoad loadRequest)
        {
            if (AllowUnknownFields != null)
            {
                loadRequest.IgnoreUnknownValues = AllowUnknownFields;
            }
            if (MaxBadRecords != null)
            {
                loadRequest.MaxBadRecords = MaxBadRecords;
            }
            if (CreateDisposition != null)
            {
                loadRequest.CreateDisposition = EnumMap.ToApiValue(CreateDisposition.Value);
            }
            if (WriteDisposition != null)
            {
                loadRequest.WriteDisposition = EnumMap.ToApiValue(WriteDisposition.Value);
            }
        }
    }
}
