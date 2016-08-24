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
using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Requests;
using System;
using static Google.Apis.Bigquery.v2.JobsResource;

namespace Google.Bigquery.V2
{
    public partial class BigqueryClientImpl
    {
        /// <inheritdoc />
        public override BigqueryResult ExecuteQuery(string sql, ExecuteQueryOptions options = null)
        {
            GaxRestPreconditions.CheckNotNull(sql, nameof(sql));

            var queryRequest = new Apis.Bigquery.v2.Data.QueryRequest { Query = sql };
            options?.ModifyRequest(queryRequest);
            var request = Service.Jobs.Query(queryRequest, ProjectId);
            var queryResponse = request.Execute();
            return new BigqueryResult(this, queryResponse);
        }

        /// <inheritdoc />
        public override BigqueryJob CreateQueryJob(string sql, CreateQueryJobOptions options = null)
        {
            GaxRestPreconditions.CheckNotNull(sql, nameof(sql));
            var query = new JobConfigurationQuery { Query = sql };
            options?.ModifyRequest(query);
            var job = Service.Jobs.Insert(new Job
            {
                Configuration = new JobConfiguration
                {
                    Query = query
                },
            }, ProjectId).Execute();
            return new BigqueryJob(this, job);
        }

        /// <inheritdoc />
        public override BigqueryResult GetQueryResults(JobReference jobReference, GetQueryResultsOptions options = null)
        {
            GaxRestPreconditions.CheckNotNull(jobReference, nameof(jobReference));

            Func<GetQueryResultsRequest> requestProvider = () =>
            {
                var request = Service.Jobs.GetQueryResults(jobReference.ProjectId, jobReference.JobId);
                options?.ModifyRequest(request);
                return request;
            };
            var firstResponse = requestProvider().Execute();
            return new BigqueryResult(this, firstResponse, requestProvider);
        }

        /// <inheritdoc />
        public override BigqueryResult ListRows(TableReference tableReference, TableSchema schema = null, ListRowsOptions options = null)
        {
            GaxRestPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            schema = schema ?? GetSchema(tableReference);
            
            Func<TabledataResource.ListRequest> requestProvider = () =>
            {
                var request = Service.Tabledata.List(tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
                options?.ModifyRequest(request);
                return request;
            };
            var firstResponse = requestProvider().Execute();
            return new BigqueryResult(this, firstResponse, schema, requestProvider);
        }
    }
}
