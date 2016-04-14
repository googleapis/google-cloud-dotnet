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
        public override Job UploadCsv(TableReference tableReference, TableSchema schema, Stream input)
        {
            Preconditions.CheckNotNull(tableReference, nameof(tableReference));
            Preconditions.CheckNotNull(input, nameof(input));
            schema = schema ?? GetSchema(tableReference);

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "CSV",
                Schema = schema,
                SkipLeadingRows = 1 // TODO: Parameterize this!   
            };

            return UploadData(configuration, input, "text/csv");
        }

        // Load it from a TextReader? Tricky, but useful.
        /// <inheritdoc />
        public override Job UploadJson(TableReference tableReference, TableSchema schema, Stream input)
        {
            Preconditions.CheckNotNull(tableReference, nameof(tableReference));
            Preconditions.CheckNotNull(input, nameof(input));
            schema = schema ?? GetSchema(tableReference);

            var configuration = new JobConfigurationLoad
            {
                DestinationTable = tableReference,
                SourceFormat = "NEWLINE_DELIMITED_JSON",
                Schema = schema
            };
            return UploadData(configuration, input, "text/json");
        }

        private TableSchema GetSchema(TableReference tableReference)
        {
            // TODO: Handle "table doesn't exist" more reasonably.
            var table = GetTable(tableReference);
            return table.Schema;
        }

        private Job UploadData(JobConfigurationLoad loadConfiguration, Stream input, string contentType)
        {
            var job = new Job { Configuration = new JobConfiguration { Load = loadConfiguration } };
            var mediaUpload = Service.Jobs.Insert(job, ProjectId, input, contentType);

            var finalProgress = mediaUpload.Upload();
            if (finalProgress.Exception != null)
            {
                throw finalProgress.Exception;
            }
            return mediaUpload.ResponseBody;
        }

        /// <inheritdoc />
        public override void InsertRow(TableReference tableReference, IDictionary<string, object> rowData, string insertId = null)
        {
            Preconditions.CheckNotNull(tableReference, nameof(tableReference));
            Preconditions.CheckNotNull(rowData, nameof(rowData));

            var body = new TableDataInsertAllRequest
            {
                Rows = new[] { new TableDataInsertAllRequest.RowsData { InsertId = insertId, Json = rowData } }
            };
            var response = Service.Tabledata.InsertAll(body, tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId).Execute();
            HandleInsertAllResponse(response);
        }

        // TODO: Insert IDs?
        /// <inheritdoc />
        public override void InsertRows(TableReference tableReference, IEnumerable<IDictionary<string, object>> rowData)
        {
            Preconditions.CheckNotNull(tableReference, nameof(tableReference));
            Preconditions.CheckNotNull(rowData, nameof(rowData));

            var body = new TableDataInsertAllRequest
            {
                Rows = rowData.Select(row => new TableDataInsertAllRequest.RowsData { Json = ConvertRowData(row) }).ToList()
            };
            var response = Service.Tabledata.InsertAll(body, tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId).Execute();
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

        // TOOD: Maybe create a view over the original dictionary?
        private static IDictionary<string, object> ConvertRowData(IDictionary<string, object> original) =>
            original.ToDictionary(pair => pair.Key, pair => ConvertRowValue(pair.Value));

        private static object ConvertRowValue(object value)
        {
            if (value == null)
            {
                return value;
            }
            if (value is int || value is long || value is string || value is byte[] || value is float || value is double || value is decimal)
            {
                return value;
            }
            if (value is DateTime)
            {
                DateTime dt = (DateTime)value;
                // TODO: Maybe enforce universal only?
                return dt.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.FFFFFF'Z'", CultureInfo.InvariantCulture);
            }
            if (value is DateTimeOffset)
            {
                DateTimeOffset dto = (DateTimeOffset)value;
                return dto.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss.FFFFFF'Z'", CultureInfo.InvariantCulture);
            }
            // TODO: Transform IList<T> and T[] to handle repeated values?
            throw new ArgumentException($"Unable to represent value of type {value.GetType()} in insert request");
        }
    }
}
