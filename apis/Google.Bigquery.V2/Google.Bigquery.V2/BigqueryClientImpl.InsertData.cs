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

using Google.Api.Gax.Rest;
using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Requests;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Google.Bigquery.V2
{
    public partial class BigqueryClientImpl
    {
        /// <inheritdoc />
        public override BigqueryJob UploadCsv(TableReference tableReference, TableSchema schema, Stream input, UploadCsvOptions options = null)
        {
            GaxRestPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxRestPreconditions.CheckNotNull(input, nameof(input));
            schema = schema ?? GetSchema(tableReference);

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "CSV",
                Schema = schema,
            };
            options?.ModifyConfiguration(configuration);

            return UploadData(configuration, input, "text/csv");
        }

        // Load it from a TextReader? Tricky, but useful.
        /// <inheritdoc />
        public override BigqueryJob UploadJson(TableReference tableReference, TableSchema schema, Stream input, UploadJsonOptions options = null)
        {
            GaxRestPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxRestPreconditions.CheckNotNull(input, nameof(input));
            schema = schema ?? GetSchema(tableReference);

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "NEWLINE_DELIMITED_JSON",
                Schema = schema
            };
            options?.ModifyConfiguration(configuration);

            return UploadData(configuration, input, "text/json");
        }

        private TableSchema GetSchema(TableReference tableReference)
        {
            // TODO: Handle "table doesn't exist" more reasonably.
            var table = GetTable(tableReference);
            return table.Schema;
        }

        private BigqueryJob UploadData(JobConfigurationLoad loadConfiguration, Stream input, string contentType)
        {
            var job = new Job { Configuration = new JobConfiguration { Load = loadConfiguration } };
            var mediaUpload = Service.Jobs.Insert(job, ProjectId, input, contentType);
            var finalProgress = mediaUpload.Upload();
            if (finalProgress.Exception != null)
            {
                throw finalProgress.Exception;
            }
            return new BigqueryJob(this, mediaUpload.ResponseBody);
        }

        /// <inheritdoc />
        public override void Insert(TableReference tableReference, IEnumerable<InsertRow> rows, InsertOptions options = null)
        {
            GaxRestPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxRestPreconditions.CheckNotNull(rows, nameof(rows));

            var body = new TableDataInsertAllRequest
            {
                Rows = rows.Select(row =>
                {
                    GaxRestPreconditions.CheckArgument(row != null, nameof(rows), "Entries must not be null");
                    return row.ToRowsData();
                }).ToList()
            };
            options?.ModifyRequest(body);
            var request = Service.Tabledata.InsertAll(body, tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
            var response = request.Execute();
            HandleInsertAllResponse(response);
        }

        private void HandleInsertAllResponse(TableDataInsertAllResponse response)
        {
            if (response.InsertErrors != null)
            {
                var exception = new GoogleApiException(Service.Name, "Error inserting data")
                {
                    Error = new RequestError
                    {
                        Errors = response.InsertErrors
                            .SelectMany(errors => (errors.Errors ?? Enumerable.Empty<ErrorProto>()).Select(error => new SingleError
                            {
                                Location = error.Location,
                                Reason = error.Reason,
                                Message = $"Row {errors.Index}: {error.Message}"
                            }))
                            .ToList()
                    }
                };
                throw exception;
            }
        }
    }
}
