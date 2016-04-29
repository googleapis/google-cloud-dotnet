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
using static Google.Apis.Bigquery.v2.JobsResource;

namespace Google.Bigquery.V2
{
    public partial class BigqueryClientImpl
    {
        private static readonly PageStreamer<TableRow, GetQueryResultsRequest, GetQueryResultsResponse, string> s_queryResultPageStreamer =
            new PageStreamer<TableRow, GetQueryResultsRequest, GetQueryResultsResponse, string>(
                (request, token) => request.PageToken = token,
                response => response.PageToken,
                response => response.Rows);

        /// <inheritdoc />
        public override BigqueryResult ExecuteQuery(string sql)
        {
            Preconditions.CheckNotNull(sql, nameof(sql));

            var queryResponse = Service.Jobs.Query(new Apis.Bigquery.v2.Data.QueryRequest { Query = sql }, ProjectId).Execute();
            return new BigqueryResult(this, queryResponse);
        }

        /// <inheritdoc />
        public override BigqueryJob CreateQueryJob(string sql, TableReference destinationTable = null)
        {
            Preconditions.CheckNotNull(sql, nameof(sql));

            var job = Service.Jobs.Insert(new Job
            {
                Configuration = new JobConfiguration
                {
                    Query = new JobConfigurationQuery
                    {
                        Query = sql,
                        DestinationTable = destinationTable
                    },
                },
            }, ProjectId).Execute();
            return new BigqueryJob(this, job);
        }

        /// <inheritdoc />
        public override BigqueryResult GetQueryResult(JobReference jobReference)
        {
            Preconditions.CheckNotNull(jobReference, nameof(jobReference));

            var firstResponse = Service.Jobs.GetQueryResults(jobReference.ProjectId, jobReference.JobId).Execute();
            return new BigqueryResult(this, firstResponse, () => Service.Jobs.GetQueryResults(jobReference.ProjectId, jobReference.JobId));
        }

        /// <inheritdoc />
        public override BigqueryResult ListRows(TableReference tableReference, TableSchema schema = null)
        {
            Preconditions.CheckNotNull(tableReference, nameof(tableReference));
            schema = schema ?? GetSchema(tableReference);
            var firstResponse = Service.Tabledata.List(tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId).Execute();
            return new BigqueryResult(this, firstResponse, schema, () => Service.Tabledata.List(tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId));
        }
    }
}
