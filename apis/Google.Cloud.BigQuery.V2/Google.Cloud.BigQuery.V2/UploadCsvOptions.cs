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
using System.Collections.Generic;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>UploadCsv</c> operations.
    /// </summary>
    public sealed class UploadCsvOptions : JobCreationOptions
    {
        /// <summary>
        /// The number of rows to skip, usually for headers.
        /// </summary>
        public int? SkipLeadingRows { get; set; }

        /// <summary>
        /// The value used to quote data sections in a CSV file.
        /// If not set, a double quote (") is used.
        /// </summary>
        public string Quote { get; set; }

        /// <summary>
        /// Indicates if quoted data sections can contain newline characters.
        /// If not set, this is effectively false.
        /// </summary>
        public bool? AllowQuotedNewlines { get; set; }

        /// <summary>
        /// Whether or not to accept rows missing trailing optional columns.
        /// If not set, this is effectively false.
        /// </summary>
        public bool? AllowJaggedRows { get; set; }

        /// <summary>
        /// The delimiter between fields in the data.
        /// If not set, a comma (,) is used.
        /// </summary>
        public string FieldDelimiter { get; set; }

        /// <summary>
        /// Whether or not to accept rows with more columns than are specified in the schema.
        /// If not set, this is effectively false.
        /// </summary>
        public bool? AllowTrailingColumns { get; set; }

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

        /// <summary>
        /// Specifies whether or not the options (including schema) should automatically be inferred.
        /// If not set, this is effectively false.
        /// </summary>
        public bool? Autodetect { get; set; }

        /// <summary>
        /// Specifies a string that represents a null value in a CSV file.
        /// If not set, this is effectively the empty string.
        /// </summary>
        public string NullMarker { get; set; }

        /// <summary>
        /// The character encoding of the data. The default value is UTF-8. BigQuery decodes the data after the
        /// raw, binary data has been split using the values of the <see cref="Quote"/> and <see cref="FieldDelimiter"/>
        /// properties.
        /// See https://cloud.google.com/bigquery/docs/reference/rest/v2/Job#JobConfigurationLoad.FIELDS.encoding for more details.
        /// </summary>
        public string Encoding { get; set; }

        /// <summary>
        /// The time partitioning to apply, if any. See <see cref="TimePartition"/> to create instances of <see cref="TimePartitioning"/>.
        /// </summary>
        public TimePartitioning TimePartitioning { get; set; }

        /// <summary>
        /// The encryption configuration to apply to the destination table, if any.
        /// </summary>
        public EncryptionConfiguration DestinationEncryptionConfiguration { get; set; }

        /// <summary>
        /// Allows the schema of the destination table to be updated as a side effect 
        /// of the load job if a schema is autodetected or supplied in the job configuration.
        /// Schema update options are supported in two cases:
        /// when <see cref="WriteDisposition"/> is <see cref="WriteDisposition.WriteAppend"/>;
        /// when <see cref="WriteDisposition"/> is <see cref="WriteDisposition.WriteTruncate"/>
        /// and the destination table is a partition of a table, specified by partition decorators.
        /// <see cref="SchemaUpdateOption"/> is marked with the <see cref="System.FlagsAttribute"/>
        /// so several flags can be specified.
        /// </summary>
        public SchemaUpdateOption? DestinationSchemaUpdateOptions { get; set; }

        internal void ModifyConfiguration(JobConfigurationLoad loadRequest)
        {
            if (SkipLeadingRows != null)
            {
                loadRequest.SkipLeadingRows = SkipLeadingRows;
            }
            if (Quote != null)
            {
                loadRequest.Quote = Quote;
            }
            if (AllowQuotedNewlines != null)
            {
                loadRequest.AllowQuotedNewlines = AllowQuotedNewlines;
            }
            if (AllowJaggedRows != null)
            {
                loadRequest.AllowJaggedRows = AllowJaggedRows;
            }
            if (FieldDelimiter != null)
            {
                loadRequest.FieldDelimiter = FieldDelimiter;
            }
            if (AllowTrailingColumns != null)
            {
                loadRequest.IgnoreUnknownValues = AllowTrailingColumns;
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
            if (Autodetect != null)
            {
                loadRequest.Autodetect = Autodetect;
            }
            if (NullMarker != null)
            {
                loadRequest.NullMarker = NullMarker;
            }
            if (TimePartitioning != null)
            {
                loadRequest.TimePartitioning = TimePartitioning;
            }
            if (DestinationEncryptionConfiguration != null)
            {
                loadRequest.DestinationEncryptionConfiguration = DestinationEncryptionConfiguration;
            }
            if (DestinationSchemaUpdateOptions != null)
            {
                loadRequest.SchemaUpdateOptions = new List<string>(EnumMap.ToApiValues(DestinationSchemaUpdateOptions.Value));
            }
            if (Encoding != null)
            {
                loadRequest.Encoding = Encoding;
            }
        }
    }
}
