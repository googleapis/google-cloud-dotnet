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

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Requests;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Bigquery.v2.TabledataResource;

namespace Google.Cloud.BigQuery.V2
{
    public partial class BigQueryClientImpl
    {
        // TODO: Allow JSON and CSV to be loaded from a TextReader? Tricky, but useful.

        /// <inheritdoc />
        public override BigQueryJob UploadCsv(TableReference tableReference, TableSchema schema, Stream input, UploadCsvOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(input, nameof(input));
            schema = schema ?? (options?.Autodetect == true ? null : GetSchema(tableReference));

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "CSV",
                Schema = schema,
            };
            options?.ModifyConfiguration(configuration);

            return UploadData(configuration, input, "text/csv", options);
        }

        /// <inheritdoc />
        public override BigQueryJob UploadAvro(TableReference tableReference, TableSchema schema, Stream input, UploadAvroOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(input, nameof(input));

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "AVRO"
            };
            options?.ModifyConfiguration(configuration);

            return UploadData(configuration, input, "application/vnd.apache.avro+binary", options);
        }

        /// <inheritdoc />
        public override BigQueryJob UploadParquet(TableReference tableReference, Stream input, UploadParquetOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(input, nameof(input));

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "PARQUET"
            };
            options?.ModifyConfiguration(configuration);

            return UploadData(configuration, input, "application/vnd.apache.parquet+binary", options);
        }

        /// <inheritdoc />
        public override BigQueryJob UploadOrc(TableReference tableReference, Stream input, UploadOrcOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(input, nameof(input));

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "ORC"
            };
            options?.ModifyConfiguration(configuration);

            return UploadData(configuration, input, "application/octet-stream", options);
        }

        /// <inheritdoc />
        public override BigQueryJob UploadJson(TableReference tableReference, TableSchema schema, IEnumerable<string> rows, UploadJsonOptions options = null)
            => UploadJson(tableReference, schema, CreateJsonStream(rows), options);

        /// <inheritdoc />
        public override BigQueryJob UploadJson(TableReference tableReference, TableSchema schema, Stream input, UploadJsonOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(input, nameof(input));
            schema = schema ?? (options?.Autodetect == true ? null : GetSchema(tableReference));

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "NEWLINE_DELIMITED_JSON",
                Schema = schema
            };
            options?.ModifyConfiguration(configuration);

            return UploadData(configuration, input, "text/json", options);
        }

        private TableSchema GetSchema(TableReference tableReference)
        {
            // TODO: Handle "table doesn't exist" more reasonably.
            var table = GetTable(tableReference);
            return table.Schema;
        }

        private BigQueryJob UploadData(JobConfigurationLoad loadConfiguration, Stream input, string contentType, JobCreationOptions options)
        {
            var job = CreateJob(new JobConfiguration { Load = loadConfiguration }, options);
            var mediaUpload = new CustomMediaUpload(Service, job, job.JobReference.ProjectId, input, contentType);
            var finalProgress = mediaUpload.Upload();
            if (finalProgress.Exception != null)
            {
                throw finalProgress.Exception;
            }
            return new BigQueryJob(this, mediaUpload.ResponseBody);
        }

        /// <inheritdoc />
        public override void InsertRows(TableReference tableReference, IEnumerable<BigQueryInsertRow> rows, InsertOptions options = null)
        {
            var request = CreateInsertAllRequest(tableReference, rows, options, out bool hasRows);
            if (!hasRows)
            {
                return;
            }
            var response = request.Execute();
            HandleInsertAllResponse(response, options);
        }

        private void HandleInsertAllResponse(TableDataInsertAllResponse response, InsertOptions options)
        {
            var errors = response.InsertErrors;
            bool shouldThrow = options == null || !options.SuppressInsertErrors;
            if (errors?.Count > 0 && shouldThrow)
            {
                var exception = new GoogleApiException(Service.Name, "Error inserting data")
                {
                    Error = new RequestError
                    {
                        Errors = response.InsertErrors
                            .SelectMany(rowErrors => (rowErrors.Errors ?? Enumerable.Empty<ErrorProto>()).Select(error => new SingleError
                            {
                                Location = error.Location,
                                Reason = error.Reason,
                                Message = $"Row {rowErrors.Index}: {error.Message}"
                            }))
                            .ToList()
                    }
                };
                throw exception;
            }
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> UploadCsvAsync(TableReference tableReference, TableSchema schema, Stream input, UploadCsvOptions options = null, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(input, nameof(input));
            schema = schema ?? (options?.Autodetect == true ? null : await GetSchemaAsync(tableReference, cancellationToken).ConfigureAwait(false));

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "CSV",
                Schema = schema,
            };
            options?.ModifyConfiguration(configuration);

            return await UploadDataAsync(configuration, input, "text/csv", options, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> UploadAvroAsync(TableReference tableReference, TableSchema schema, Stream input, UploadAvroOptions options = null, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(input, nameof(input));

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "AVRO"
            };
            options?.ModifyConfiguration(configuration);

            return await UploadDataAsync(configuration, input, "application/vnd.apache.avro+binary", options, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> UploadParquetAsync(TableReference tableReference, Stream input, UploadParquetOptions options = null, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(input, nameof(input));

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "PARQUET"
            };
            options?.ModifyConfiguration(configuration);

            return await UploadDataAsync(configuration, input, "application/vnd.apache.parquet+binary", options, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> UploadOrcAsync(TableReference tableReference, Stream input, UploadOrcOptions options = null, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(input, nameof(input));

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "ORC"
            };
            options?.ModifyConfiguration(configuration);

            return await UploadDataAsync(configuration, input, "application/octet-stream", options, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public override Task<BigQueryJob> UploadJsonAsync(TableReference tableReference, TableSchema schema, IEnumerable<string> rows,
            UploadJsonOptions options = null, CancellationToken cancellationToken = default)
            => UploadJsonAsync(tableReference, schema, CreateJsonStream(rows), options, cancellationToken);

        /// <inheritdoc />
        public override async Task<BigQueryJob> UploadJsonAsync(TableReference tableReference, TableSchema schema, Stream input,
            UploadJsonOptions options = null, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(input, nameof(input));
            schema = schema ?? (options?.Autodetect == true ? null : await GetSchemaAsync(tableReference, cancellationToken).ConfigureAwait(false));

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "NEWLINE_DELIMITED_JSON",
                Schema = schema
            };
            options?.ModifyConfiguration(configuration);

            return await UploadDataAsync(configuration, input, "text/json", options, cancellationToken).ConfigureAwait(false);
        }

        private async Task<TableSchema> GetSchemaAsync(TableReference tableReference, CancellationToken cancellationToken)
        {
            // TODO: Handle "table doesn't exist" more reasonably.
            var table = await GetTableAsync(tableReference, cancellationToken: cancellationToken).ConfigureAwait(false);
            return table.Schema;
        }

        private async Task<BigQueryJob> UploadDataAsync(JobConfigurationLoad loadConfiguration, Stream input, string contentType, JobCreationOptions options, CancellationToken cancellationToken)
        {
            var job = CreateJob(new JobConfiguration { Load = loadConfiguration }, options);
            var mediaUpload = new CustomMediaUpload(Service, job, job.JobReference.ProjectId, input, contentType);
            var finalProgress = await mediaUpload.UploadAsync(cancellationToken).ConfigureAwait(false);
            if (finalProgress.Exception != null)
            {
                throw finalProgress.Exception;
            }
            return new BigQueryJob(this, mediaUpload.ResponseBody);
        }

        /// <inheritdoc />
        public override async Task InsertRowsAsync(TableReference tableReference, IEnumerable<BigQueryInsertRow> rows,
            InsertOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateInsertAllRequest(tableReference, rows, options, out bool hasRows);
            if (!hasRows)
            {
                return;
            }
            var response = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            HandleInsertAllResponse(response, options);
        }

        /// <summary>
        /// Creates a stream containing JSON data from the given rows. Each row is sanitized to a single
        /// line by replacing CR and LF with space. The stream contains UTF-8, LF-separated lines.
        /// </summary>
        private static Stream CreateJsonStream(IEnumerable<string> rows)
        {
            GaxPreconditions.CheckNotNull(rows, nameof(rows));
            var stream = new MemoryStream();
            // No using statement here, as we want the stream to stay open. StreamWriter.Dispose()
            // will dispose of the underlying stream in this case.
            var writer = new StreamWriter(stream);
            foreach (var row in rows)
            {
                GaxPreconditions.CheckArgument(row != null, nameof(rows), "JSON string sequence cannot contain null elements");
                var sanitized = row.Replace('\n', ' ').Replace('\r', ' ');
                writer.Write(sanitized);
                writer.Write('\n');
            }
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        private InsertAllRequest CreateInsertAllRequest(TableReference tableReference, IEnumerable<BigQueryInsertRow> rows, InsertOptions options, out bool hasRows)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(rows, nameof(rows));

            var insertRows = rows.Select(row =>
            {
                GaxPreconditions.CheckArgument(row != null, nameof(rows), "Entries must not be null");
                return row.ToRowsData(options?.AllowEmptyInsertIds ?? false);
            }).ToList();
            var body = new TableDataInsertAllRequest
            {
                Rows = insertRows
            };
            // It's annoying to use an out parameter for this, but InsertAllRequest doesn't allow access to the body.
            hasRows = body.Rows.Any();
            options?.ModifyRequest(body);
            var request = Service.Tabledata.InsertAll(body, tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
            // Even though empty InsertIds might be allowed, this can be retried as per guidance from
            // the API team. Previous de-duplicating was on a best effort basis anyways and client code
            // needs to explicitly allow for empty InsertId and should be aware that doing so will be at
            // the expense of de-duplication efforts.
            RetryHandler.MarkAsRetriable(request);
            return request;
        }
    }
}
