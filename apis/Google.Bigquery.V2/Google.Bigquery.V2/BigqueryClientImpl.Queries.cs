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
using Google.Api.Gax.Rest;
using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Google.Bigquery.V2
{
    public partial class BigqueryClientImpl
    {
        private sealed class TableRowPageManager : IPageManager<TabledataResource.ListRequest, TableDataList, BigqueryRow>
        {
            private readonly BigqueryClient _client;
            private readonly TableSchema _schema;

            internal TableRowPageManager(BigqueryClient client, TableSchema schema)
            {
                _client = client;
                _schema = schema;
            }

            public string GetNextPageToken(TableDataList response) => response.PageToken;
            public IEnumerable<BigqueryRow> GetResources(TableDataList response) => response.Rows?.Select(row => new BigqueryRow(row, _schema));
            public void SetPageSize(TabledataResource.ListRequest request, int pageSize) => request.MaxResults = pageSize;
            public void SetPageToken(TabledataResource.ListRequest request, string pageToken) => request.PageToken = pageToken;
        }

        /// <inheritdoc />
        public override BigqueryQueryJob ExecuteQuery(string sql, ExecuteQueryOptions options = null)
        {
            GaxPreconditions.CheckNotNull(sql, nameof(sql));

            var queryRequest = new QueryRequest { Query = sql, UseLegacySql = false };
            options?.ModifyRequest(queryRequest);
            var request = Service.Jobs.Query(queryRequest, ProjectId);
            var queryResponse = request.Execute();
            return new BigqueryQueryJob(this, queryResponse, options);
        }

        /// <inheritdoc />
        public override BigqueryJob CreateQueryJob(string sql, CreateQueryJobOptions options = null)
        {
            GaxPreconditions.CheckNotNull(sql, nameof(sql));
            var query = new JobConfigurationQuery { Query = sql, UseLegacySql = false };
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
        public override BigqueryQueryJob PollQueryUntilCompleted(JobReference jobReference, GetQueryResultsOptions options = null, PollJobOptions pollOptions = null)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            pollOptions?.Validate();

            DateTime? deadline = pollOptions?.GetEffectiveDeadline() ?? DateTime.SpecifyKind(DateTime.MaxValue, DateTimeKind.Utc);
            long maxRequests = pollOptions?.MaxRequests ?? long.MaxValue;
            TimeSpan interval = pollOptions?.Interval ?? TimeSpan.FromSeconds(1);

            for (long i = 0; i < maxRequests && DateTime.UtcNow < deadline; i++)
            {
                var job = GetQueryJob(jobReference, options);
                if (job.Completed)
                {
                    return job;
                }
                Thread.Sleep(interval);
            }
            throw new TimeoutException($"Job {jobReference.JobId} did not complete in time.");
        }

        /// <inheritdoc />
        public override BigqueryQueryJob GetQueryJob(JobReference jobReference, GetQueryResultsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));

            var request = Service.Jobs.GetQueryResults(jobReference.ProjectId, jobReference.JobId);
            options?.ModifyRequest(request);
            var firstResponse = request.Execute();
            return new BigqueryQueryJob(this, firstResponse, options);
        }

        /// <inheritdoc />
        public override IPagedEnumerable<TableDataList, BigqueryRow> ListRows(TableReference tableReference, TableSchema schema = null, ListRowsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            schema = schema ?? GetSchema(tableReference);

            var pageManager = new TableRowPageManager(this, schema);

            Func<TabledataResource.ListRequest> requestProvider = () =>
            {
                var request = Service.Tabledata.List(tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
                options?.ModifyRequest(request);
                return request;
            };
            return new PagedEnumerable<TabledataResource.ListRequest, TableDataList, BigqueryRow>(
                requestProvider,
                pageManager);
        }
    }
}
