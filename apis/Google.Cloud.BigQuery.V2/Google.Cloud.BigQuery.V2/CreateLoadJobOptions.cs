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
using System.Collections.Generic;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Options for <c>CreateLoadJob</c> operations.
    /// </summary>
    public sealed class CreateLoadJobOptions : JobCreationOptions
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
        /// Whether or not to accept rows with extra values that are not represented in the table schema.
        /// If not set, this is effectively false.
        /// </summary>
        public bool? IgnoreUnknownValues { get; set; }

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
        /// Specifies the behavior if the destination table exists and is non-empty.
        /// If not set, this is effectively <see cref="WriteDisposition.WriteAppend"/>.
        /// </summary>
        public WriteDisposition? WriteDisposition { get; set; }

        /// <summary>
        /// Specifies whether or not the options and schema for CSV and JSON sources
        /// should automatically be inferred.
        /// </summary>
        public bool? Autodetect { get; set; }

        /// <summary>
        /// Specifies a string that represents a null value in a CSV file. For example,
        /// if you specify "\N", BigQuery interprets "\N" as a null value when loading
        /// a CSV file. The default value is the empty string. If you set this property
        /// to a custom value, BigQuery throws an error if an empty string is present for
        /// all data types except for STRING and BYTE. For STRING and BYTE columns,
        /// BigQuery interprets the empty string as an empty value.
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
        /// If sourceFormat is set to <see cref="FileFormat.DatastoreBackup"/>, indicates which entity properties
        /// to load into BigQuery from a Cloud Datastore backup. Property names are case
        /// sensitive and must be top-level properties. If no properties are specified,
        /// BigQuery loads all properties. If any named property isn't found in the Cloud
        /// Datastore backup, an invalid error is returned in the job result.
        /// </summary>
        public IList<string> ProjectionFields { get; set; }

        /// <summary>
        /// The format of the source files.
        /// </summary>
        public FileFormat? SourceFormat { get; set; }

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

        /// <summary>
        /// For Avro sources, this indicates whether to enable interpreting logical types
        /// into their corresponding types (ie. TIMESTAMP), instead of only using their raw types
        /// (ie. INTEGER). If unset, the server default will be used.
        /// </summary>
        public bool? UseAvroLogicalTypes { get; set; }

        /// <summary>
        /// Optional action to perform after preparing the request. If this property is non-null,
        /// the <see cref="JobConfigurationLoad"/> used for a request will be passed to the delegate
        /// before the request is executed. This allows for fine-grained modifications which aren't
        /// otherwise directly supported by the properties in this options type.
        /// </summary>
        /// <remarks>
        /// Prefer the properties on this type over this modifier to prepare the request.
        /// Only use this modifier to configure aspects for which there are no properties available.
        /// This modifier is applied to the request after all properties on this type have been applied.
        /// The delegate is only called once per operation, even if the request is automatically retried.
        /// </remarks>
        public Action<JobConfigurationLoad> ConfigurationModifier { get; set; }

        ///<summary>
        /// The reservation that job would use. User can specify a reservation to execute the
        /// job.If reservation is not set, reservation is determined based on the rules defined by the
        /// reservation assignments.The expected format is
        /// `projects/{project}/locations/{location}/reservations/{reservation}`.
        /// </summary>
        public string Reservation { get; set; }

        internal void ModifyRequest(JobConfigurationLoad load)
        {
            if (SkipLeadingRows != null)
            {
                load.SkipLeadingRows = SkipLeadingRows;
            }
            if (Quote != null)
            {
                load.Quote = Quote;
            }
            if (AllowQuotedNewlines != null)
            {
                load.AllowQuotedNewlines = AllowQuotedNewlines;
            }
            if (AllowJaggedRows != null)
            {
                load.AllowJaggedRows = AllowJaggedRows;
            }
            if (FieldDelimiter != null)
            {
                load.FieldDelimiter = FieldDelimiter;
            }
            if (IgnoreUnknownValues != null)
            {
                load.IgnoreUnknownValues = IgnoreUnknownValues;
            }
            if (MaxBadRecords != null)
            {
                load.MaxBadRecords = MaxBadRecords;
            }
            if (CreateDisposition != null)
            {
                load.CreateDisposition = EnumMap.ToApiValue(CreateDisposition.Value);
            }
            if (WriteDisposition != null)
            {
                load.WriteDisposition = EnumMap.ToApiValue(WriteDisposition.Value);
            }
            if (Autodetect != null)
            {
                load.Autodetect = Autodetect;
            }
            if (ProjectionFields != null)
            {
                load.ProjectionFields = ProjectionFields;
            }
            if (NullMarker != null)
            {
                load.NullMarker = NullMarker;
            }
            if (SourceFormat != null)
            {
                load.SourceFormat = EnumMap.ToApiValue(SourceFormat.Value);
            }
            if (TimePartitioning != null)
            {
                load.TimePartitioning = TimePartitioning;
            }
            if (DestinationEncryptionConfiguration != null)
            {
                load.DestinationEncryptionConfiguration = DestinationEncryptionConfiguration;
            }
            if (DestinationSchemaUpdateOptions != null)
            {
                load.SchemaUpdateOptions = new List<string>(EnumMap.ToApiValues(DestinationSchemaUpdateOptions.Value));
            }
            if (UseAvroLogicalTypes != null)
            {
                load.UseAvroLogicalTypes = UseAvroLogicalTypes;
            }
            if (Encoding != null)
            {
                load.Encoding = Encoding;
            }
            ConfigurationModifier?.Invoke(load);
        }
    }
}
