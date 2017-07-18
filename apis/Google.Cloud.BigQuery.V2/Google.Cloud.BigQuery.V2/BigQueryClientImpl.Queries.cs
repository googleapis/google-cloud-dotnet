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
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    public partial class BigQueryClientImpl
    {
        private sealed class TableRowPageManager : IPageManager<TabledataResource.ListRequest, TableDataList, BigQueryRow>
        {
            private readonly BigQueryClient _client;
            private readonly TableSchema _schema;

            internal TableRowPageManager(BigQueryClient client, TableSchema schema)
            {
                _client = client;
                _schema = schema;
            }

            public string GetNextPageToken(TableDataList response) => response.PageToken;
            public IEnumerable<BigQueryRow> GetResources(TableDataList response) => response.Rows?.Select(row => new BigQueryRow(row, _schema));
            public void SetPageSize(TabledataResource.ListRequest request, int pageSize) => request.MaxResults = pageSize;
            public void SetPageToken(TabledataResource.ListRequest request, string pageToken)
            {
                // If there's a non-null StartIndex, the page token is ignored, so we'd get the same page again.
                request.StartIndex = null;
                request.PageToken = pageToken;
            }
        }

        /// <inheritdoc />
        public override BigQueryJob CreateQueryJob(string sql, QueryOptions options = null)
        {
            GaxPreconditions.CheckNotNull(sql, nameof(sql));
            var query = new JobConfigurationQuery { Query = sql, UseLegacySql = false };
            var job = CreateInsertQueryJobRequest(query, options).Execute();
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override BigQueryJob CreateQueryJob(BigQueryCommand command, QueryOptions options = null)
        {
            GaxPreconditions.CheckNotNull(command, nameof(command));
            var query = new JobConfigurationQuery { UseLegacySql = false };
            command.PopulateJobConfigurationQuery(query);
            var job = CreateInsertQueryJobRequest(query, options).Execute();
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override BigQueryResults GetQueryResults(JobReference jobReference, GetQueryResultsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            var job = GetJob(jobReference);
            return job.GetQueryResults(options);
        }

        internal override BigQueryResults GetQueryResults(JobReference jobReference, TableReference tableReference, GetQueryResultsOptions options)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            // This validates the options before we make any RPCs
            var listRowsOptions = options?.ToListRowsOptions();

            DateTime start = Clock.GetCurrentDateTimeUtc();
            while (true)
            {
                // This will throw if the query has timed out.
                var request = CreateGetQueryResultsRequest(jobReference, options, start);
                var response = request.Execute();
                if (response.JobComplete == true)
                {
                    return new BigQueryResults(this, response, tableReference, listRowsOptions);
                }
            }
        }

        /// <inheritdoc />
        public override PagedEnumerable<TableDataList, BigQueryRow> ListRows(TableReference tableReference, TableSchema schema = null, ListRowsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            schema = schema ?? GetSchema(tableReference);

            var pageManager = new TableRowPageManager(this, schema);

            Func<TabledataResource.ListRequest> requestProvider = () =>
            {
                var request = Service.Tabledata.List(tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
                request.ModifyRequest += _versionHeaderAction;
                options?.ModifyRequest(request);
                return request;
            };
            return new RestPagedEnumerable<TabledataResource.ListRequest, TableDataList, BigQueryRow>(
                requestProvider,
                pageManager);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> CreateQueryJobAsync(string sql, QueryOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(sql, nameof(sql));
            var query = new JobConfigurationQuery { Query = sql, UseLegacySql = false };
            var job = await CreateInsertQueryJobRequest(query, options).ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> CreateQueryJobAsync(BigQueryCommand command, QueryOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(command, nameof(command));
            var query = new JobConfigurationQuery { UseLegacySql = false };
            command.PopulateJobConfigurationQuery(query);
            var job = await CreateInsertQueryJobRequest(query, options).ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override async Task<BigQueryResults> GetQueryResultsAsync(JobReference jobReference, GetQueryResultsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            var job = await GetJobAsync(jobReference, cancellationToken: cancellationToken).ConfigureAwait(false);
            return await job.GetQueryResultsAsync(options, cancellationToken).ConfigureAwait(false);
        }

        internal override async Task<BigQueryResults> GetQueryResultsAsync(JobReference jobReference, TableReference tableReference, GetQueryResultsOptions options, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            // This validates the options before we make any RPCs
            var listRowsOptions = options?.ToListRowsOptions();

            DateTime start = Clock.GetCurrentDateTimeUtc();
            while (true)
            {
                // This will throw if the query has timed out.
                var request = CreateGetQueryResultsRequest(jobReference, options, start);
                var response = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
                if (response.JobComplete == true)
                {
                    return new BigQueryResults(this, response, tableReference, listRowsOptions);
                }
            }
        }

        /// <inheritdoc />
        public override PagedAsyncEnumerable<TableDataList, BigQueryRow> ListRowsAsync(TableReference tableReference, TableSchema schema = null, ListRowsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            schema = schema ?? GetSchema(tableReference);

            var pageManager = new TableRowPageManager(this, schema);

            Func<TabledataResource.ListRequest> requestProvider = () =>
            {
                var request = Service.Tabledata.List(tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
                request.ModifyRequest += _versionHeaderAction;
                options?.ModifyRequest(request);
                return request;
            };
            return new RestPagedAsyncEnumerable<TabledataResource.ListRequest, TableDataList, BigQueryRow>(
                requestProvider,
                pageManager);
        }

        private JobsResource.InsertRequest CreateInsertQueryJobRequest(JobConfigurationQuery query, QueryOptions options)
        {
            options?.ModifyRequest(query);
            return CreateInsertJobRequest(new JobConfiguration { Query = query, DryRun = options?.DryRun }, options);
        }

        private static readonly long s_maxGetQueryResultsRequestTimeout = (long) TimeSpan.FromMinutes(1).TotalMilliseconds;
        private JobsResource.GetQueryResultsRequest CreateGetQueryResultsRequest(JobReference jobReference, GetQueryResultsOptions options, DateTime loopStart)
        {
            var timeSoFar = Clock.GetCurrentDateTimeUtc() - loopStart;
            var timeout = options?.Timeout ?? GetQueryResultsOptions.DefaultTimeout;
            var timeRemainingMs = (long) (timeout - timeSoFar).TotalMilliseconds;
            if (timeRemainingMs < 1)
            {
                // TODO: Check this is correct
                throw new TimeoutException("Query timed out");
            }
            var requestTimeoutMs = Math.Min(timeRemainingMs, s_maxGetQueryResultsRequestTimeout);
            var request = Service.Jobs.GetQueryResults(jobReference.ProjectId, jobReference.JobId);
            // We never use the results within the first response; instead, we're just checking that the job has
            // completed and using the statistics and schema from it.
            request.MaxResults = 0;
            request.ModifyRequest += _versionHeaderAction;
            request.TimeoutMs = requestTimeoutMs;
            options?.ModifyRequest(request);
            return request;
        }
    }
}
