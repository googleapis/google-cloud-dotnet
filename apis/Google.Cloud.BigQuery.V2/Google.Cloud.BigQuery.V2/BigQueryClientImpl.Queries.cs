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
        public override BigQueryResults ExecuteQuery(string sql, ExecuteQueryOptions options = null)
        {
            GaxPreconditions.CheckNotNull(sql, nameof(sql));
            var queryRequest = new QueryRequest { Query = sql, UseLegacySql = false };
            options?.ModifyRequest(queryRequest);
            var request = Service.Jobs.Query(queryRequest, ProjectId);
            request.ModifyRequest += _versionHeaderAction;
            var queryResponse = request.Execute();
            return new BigQueryResults(this, queryResponse, options);
        }

        /// <inheritdoc />
        public override BigQueryResults ExecuteQuery(BigQueryCommand command, ExecuteQueryOptions options = null)
        {
            GaxPreconditions.CheckNotNull(command, nameof(command));
            var queryRequest = new QueryRequest { UseLegacySql = false };
            command.PopulateQueryRequest(queryRequest);
            options?.ModifyRequest(queryRequest);
            var request = Service.Jobs.Query(queryRequest, ProjectId);
            request.ModifyRequest += _versionHeaderAction;
            var queryResponse = request.Execute();
            return new BigQueryResults(this, queryResponse, options);
        }

        /// <inheritdoc />
        public override BigQueryJob CreateQueryJob(string sql, CreateQueryJobOptions options = null)
        {
            GaxPreconditions.CheckNotNull(sql, nameof(sql));
            var query = new JobConfigurationQuery { Query = sql, UseLegacySql = false };
            var job = CreateInsertQueryJobRequest(query, options).Execute();
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override BigQueryJob CreateQueryJob(BigQueryCommand command, CreateQueryJobOptions options = null)
        {
            GaxPreconditions.CheckNotNull(command, nameof(command));
            var query = new JobConfigurationQuery { UseLegacySql = false };
            command.PopulateJobConfigurationQuery(query);
            var job = CreateInsertQueryJobRequest(query, options).Execute();
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override BigQueryResults PollQueryUntilCompleted(JobReference jobReference, GetQueryResultsOptions options = null, PollSettings pollSettings = null)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            return Polling.PollRepeatedly(ignoredDeadline => GetQueryResults(jobReference, options),
                job => job.Completed, Clock, Scheduler, pollSettings ?? s_defaultPollSettings, CancellationToken.None);
        }

        /// <inheritdoc />
        public override BigQueryResults GetQueryResults(JobReference jobReference, GetQueryResultsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));

            var request = Service.Jobs.GetQueryResults(jobReference.ProjectId, jobReference.JobId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            var firstResponse = request.Execute();
            return new BigQueryResults(this, firstResponse, options);
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
        public override async Task<BigQueryResults> ExecuteQueryAsync(string sql, ExecuteQueryOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(sql, nameof(sql));
            var queryRequest = new QueryRequest { Query = sql, UseLegacySql = false };
            options?.ModifyRequest(queryRequest);
            var request = Service.Jobs.Query(queryRequest, ProjectId);
            request.ModifyRequest += _versionHeaderAction;
            var queryResponse = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryResults(this, queryResponse, options);
        }

        /// <inheritdoc />
        public override async Task<BigQueryResults> ExecuteQueryAsync(BigQueryCommand command, ExecuteQueryOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(command, nameof(command));
            var queryRequest = new QueryRequest { UseLegacySql = false };
            command.PopulateQueryRequest(queryRequest);
            options?.ModifyRequest(queryRequest);
            var request = Service.Jobs.Query(queryRequest, ProjectId);
            request.ModifyRequest += _versionHeaderAction;
            var queryResponse = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryResults(this, queryResponse, options);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> CreateQueryJobAsync(string sql, CreateQueryJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(sql, nameof(sql));
            var query = new JobConfigurationQuery { Query = sql, UseLegacySql = false };
            var job = await CreateInsertQueryJobRequest(query, options).ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> CreateQueryJobAsync(BigQueryCommand command, CreateQueryJobOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(command, nameof(command));
            var query = new JobConfigurationQuery { UseLegacySql = false };
            command.PopulateJobConfigurationQuery(query);
            var job = await CreateInsertQueryJobRequest(query, options).ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override Task<BigQueryResults> PollQueryUntilCompletedAsync(JobReference jobReference, GetQueryResultsOptions options = null, PollSettings pollSettings = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            return Polling.PollRepeatedlyAsync(ignoredDeadline => GetQueryResultsAsync(jobReference, options, cancellationToken),
                job => job.Completed, Clock, Scheduler, pollSettings ?? s_defaultPollSettings, cancellationToken);
        }

        /// <inheritdoc />
        public override async Task<BigQueryResults> GetQueryResultsAsync(JobReference jobReference, GetQueryResultsOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));

            var request = Service.Jobs.GetQueryResults(jobReference.ProjectId, jobReference.JobId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            var firstResponse = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryResults(this, firstResponse, options);
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

        private JobsResource.InsertRequest CreateInsertQueryJobRequest(JobConfigurationQuery query, CreateQueryJobOptions options)
        {
            options?.ModifyRequest(query);
            var request = Service.Jobs.Insert(new Job
            {
                Configuration = new JobConfiguration
                {
                    Query = query,
                    // It's slightly annoying that this is set here rather than in ModifyRequest, but at least it's in a single place.
                    DryRun = options?.DryRun
                },
            }, ProjectId);
            request.ModifyRequest += _versionHeaderAction;
            return request;
        }
    }
}
