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
using System;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>CreateExtractJob</c> operations.
    /// </summary>
    public sealed class CreateExtractJobOptions : JobCreationOptions
    {
        /// <summary>
        /// The file format to use for output. If this is unspecified,
        /// the default is to create CSV files.
        /// </summary>
        public FileFormat? DestinationFormat { get; set; }

        /// <summary>
        /// The compression to apply for output. If this is unspecified,
        /// the default is not to compress the output.
        /// </summary>
        public CompressionType? Compression { get; set; }

        /// <summary>
        /// The delimiter to use between fields in the exported data.
        /// If this is unspecified, the default is a comma.
        /// </summary>
        public string FieldDelimiter { get; set; }

        /// <summary>
        /// Whether to print out a header row in the results. If this
        /// is unspecified, the default is true.
        /// </summary>
        public bool? PrintHeader { get; set; }

        internal void ModifyRequest(JobConfigurationExtract extract)
        {
            if (DestinationFormat != null)
            {
                if (DestinationFormat == FileFormat.DatastoreBackup)
                {
                    throw new ArgumentException($"{nameof(FileFormat.DatastoreBackup)} is not supported for extract operations", "options");
                }
                extract.DestinationFormat = EnumMap.ToApiValue(DestinationFormat.Value);
            }
            if (Compression != null)
            {
                extract.Compression = EnumMap.ToApiValue(Compression.Value);
            }
            if (FieldDelimiter != null)
            {
                extract.FieldDelimiter = FieldDelimiter;
            }
            if (PrintHeader != null)
            {
                extract.PrintHeader = PrintHeader;
            }
        }
    }
}
