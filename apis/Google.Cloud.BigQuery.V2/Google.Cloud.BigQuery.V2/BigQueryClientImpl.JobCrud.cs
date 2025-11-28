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
using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Bigquery.v2.JobsResource;

namespace Google.Cloud.BigQuery.V2
{
    public partial class BigQueryClientImpl
    {
        private static readonly PollSettings s_defaultPollSettings = new PollSettings(Expiration.None, TimeSpan.FromSeconds(5));

        private sealed class JobPageManager : IPageManager<ListRequest, JobList, BigQueryJob>
        {
            private readonly BigQueryClient _client;

            internal JobPageManager(BigQueryClient client)
            {
                _client = client;
            }

            public string GetNextPageToken(JobList response) => response.NextPageToken;
            public IEnumerable<BigQueryJob> GetResources(JobList response) => response.Jobs?.Select(resource => new BigQueryJob(_client, resource));
            public void SetPageSize(ListRequest request, int pageSize) => request.MaxResults = pageSize;
            public void SetPageToken(ListRequest request, string pageToken) => request.PageToken = pageToken;
        }

        /// <inheritdoc />
        public override PagedEnumerable<JobList, BigQueryJob> ListJobs(ProjectReference projectReference, ListJobsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(projectReference, nameof(projectReference));

            var pageManager = new JobPageManager(this);
            return new RestPagedEnumerable<ListRequest, JobList, BigQueryJob>(
                () => CreateListJobsRequest(projectReference, options),
                pageManager);
        }

        /// <inheritdoc />
        public override PagedAsyncEnumerable<JobList, BigQueryJob> ListJobsAsync(ProjectReference projectReference, ListJobsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(projectReference, nameof(projectReference));

            var pageManager = new JobPageManager(this);
            return new RestPagedAsyncEnumerable<ListRequest, JobList, BigQueryJob>(
                () => CreateListJobsRequest(projectReference, options),
                pageManager);
        }

        /// <inheritdoc />
        public override BigQueryJob PollJobUntilCompleted(JobReference jobReference, GetJobOptions options = null, PollSettings pollSettings = null)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            return Polling.PollRepeatedly(ignoredDeadline => GetJob(jobReference, options),
                job => job.State == JobState.Done,
                Clock, Scheduler, pollSettings ?? s_defaultPollSettings, CancellationToken.None);
        }

        /// <inheritdoc />
        public override Task<BigQueryJob> PollJobUntilCompletedAsync(JobReference jobReference, GetJobOptions options = null,
            PollSettings pollSettings = null, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            return Polling.PollRepeatedlyAsync(ignoredDeadline => GetJobAsync(jobReference, options, cancellationToken),
                job => job.State == JobState.Done,
                Clock, Scheduler, pollSettings ?? s_defaultPollSettings, cancellationToken);
        }

        /// <inheritdoc />
        public override BigQueryJob GetJob(JobReference jobReference, GetJobOptions options = null)
        {
            var request = CreateGetJobRequest(jobReference, options);
            var job = request.Execute();
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> GetJobAsync(JobReference jobReference, GetJobOptions options = null,
            CancellationToken cancellationToken = default)
        {
            var request = CreateGetJobRequest(jobReference, options);
            var job = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override BigQueryJob CancelJob(JobReference jobReference, CancelJobOptions options = null)
        {
            var request = CreateCancelJobRequest(jobReference, options);
            var result = request.Execute();
            return new BigQueryJob(this, result.Job);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> CancelJobAsync(JobReference jobReference, CancelJobOptions options = null,
            CancellationToken cancellationToken = default)
        {
            var request = CreateCancelJobRequest(jobReference, options);
            var result = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, result.Job);
        }

        /// <inheritdoc />
        public override BigQueryJob CreateExtractJob(TableReference tableReference, IEnumerable<string> destinationUris, CreateExtractJobOptions options = null)
        {
            var job = CreateExtractJobRequest(tableReference, destinationUris, options).Execute();
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> CreateExtractJobAsync(TableReference tableReference, IEnumerable<string> destinationUris, CreateExtractJobOptions options = null, CancellationToken cancellationToken = default)
        {
            var job = await CreateExtractJobRequest(tableReference, destinationUris, options).ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override BigQueryJob CreateCopyJob(IEnumerable<TableReference> sources, TableReference destination, CreateCopyJobOptions options = null)
        {
            var job = CreateCopyJobRequest(sources, destination, options).Execute();
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> CreateCopyJobAsync(IEnumerable<TableReference> sources, TableReference destination, CreateCopyJobOptions options = null, CancellationToken cancellationToken = default)
        {
            var job = await CreateCopyJobRequest(sources, destination, options).ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override BigQueryJob CreateLoadJob(IEnumerable<string> sourceUris, TableReference destination, TableSchema schema, CreateLoadJobOptions options = null)
        {
            var job = CreateLoadJobRequest(sourceUris, destination, schema, options).Execute();
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> CreateLoadJobAsync(IEnumerable<string> sourceUris, TableReference destination, TableSchema schema, CreateLoadJobOptions options = null, CancellationToken cancellationToken = default)
        {
            var job = await CreateLoadJobRequest(sourceUris, destination, schema, options).ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override BigQueryJob CreateModelExtractJob(ModelReference modelReference, IEnumerable<string> destinationUris, CreateModelExtractJobOptions options = null)
        {
            var job = CreateModelExtractJobRequest(modelReference, destinationUris, options).Execute();
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override async Task<BigQueryJob> CreateModelExtractJobAsync(ModelReference modelReference, IEnumerable<string> destinationUris, CreateModelExtractJobOptions options = null, CancellationToken cancellationToken = default)
        {
            var job = await CreateModelExtractJobRequest(modelReference, destinationUris, options).ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryJob(this, job);
        }

        /// <inheritdoc />
        public override void DeleteJob(JobReference jobReference, DeleteJobOptions options = null)
        {
            var request = CreateDeleteJobRequest(jobReference, options);
            request.Execute();
        }

        /// <inheritdoc />
        public override async Task DeleteJobAsync(JobReference jobReference, DeleteJobOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateDeleteJobRequest(jobReference, options);
            await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
        }

        internal const string DefaultJobIdPrefix = "job_";

        /// <summary>
        /// Creates a <see cref="Job"/> with a client-generated <see cref="JobReference"/> based on
        /// <paramref name="options"/> and containing the given job configuration.
        /// </summary>
        /// <remarks>This method is internal for test purposes.</remarks>
        /// <param name="configuration">Configuration for the job. Must not be null.</param>
        /// <param name="options">Options for job creation. May be null.</param>
        internal Job CreateJob(JobConfiguration configuration, JobCreationOptions options)
        {
            GaxPreconditions.CheckNotNull(configuration, nameof(configuration));

            string projectId = options?.ProjectId ?? ProjectId;
            string jobId = options?.JobId;
            string jobIdPrefix = options?.JobIdPrefix;
            if (jobId != null && jobIdPrefix != null)
            {
                throw new ArgumentException("Only one of JobId or JobIdPrefix can be specified for a single operation.");
            }
            if (jobId == null)
            {
                var prefix = jobIdPrefix ?? DefaultJobIdPrefix;
                jobId = prefix + Guid.NewGuid().ToString().Replace("-", "_");
            }
            string location = options?.JobLocation ?? DefaultLocation;

            options?.ModifyJobConfiguration(configuration);
            return new Job { Configuration = configuration, JobReference = GetJobReference(projectId, jobId, location) };
        }

        // Request creation
        private GetRequest CreateGetJobRequest(JobReference jobReference, GetJobOptions options)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));

            var request = Service.Jobs.Get(jobReference.ProjectId, jobReference.JobId);
            request.Location = jobReference.Location;
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private ListRequest CreateListJobsRequest(ProjectReference projectReference, ListJobsOptions options)
        {
            var request = Service.Jobs.List(projectReference.ProjectId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private CancelRequest CreateCancelJobRequest(JobReference jobReference, CancelJobOptions options)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            var request = Service.Jobs.Cancel(jobReference.ProjectId, jobReference.JobId);
            request.Location = jobReference.Location;
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private InsertRequest CreateExtractJobRequest(TableReference tableReference, IEnumerable<string> destinationUris, CreateExtractJobOptions options)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(destinationUris, nameof(destinationUris));
            List<string> destinationUriList = destinationUris.ToList();
            GaxPreconditions.CheckArgument(destinationUriList.Count != 0, nameof(destinationUris), "Destination URIs cannot be empty");

            var extract = new JobConfigurationExtract { DestinationUris = destinationUriList, SourceTable = tableReference };
            options?.ModifyRequest(extract);
            return CreateInsertJobRequest(new JobConfiguration { Extract = extract }, options);
        }

        private InsertRequest CreateCopyJobRequest(IEnumerable<TableReference> sources, TableReference destination, CreateCopyJobOptions options)
        {
            GaxPreconditions.CheckNotNull(sources, nameof(sources));
            GaxPreconditions.CheckNotNull(destination, nameof(destination));
            List<TableReference> sourceList = sources.ToList();
            GaxPreconditions.CheckArgument(sourceList.Count != 0, nameof(sources), "Sources cannot be empty");

            var copy = new JobConfigurationTableCopy { SourceTables = sourceList, DestinationTable = destination };
            options?.ModifyRequest(copy);
            return CreateInsertJobRequest(new JobConfiguration { Copy = copy }, options);
        }

        private InsertRequest CreateLoadJobRequest(IEnumerable<string> sourceUris, TableReference destination, TableSchema schema, CreateLoadJobOptions options)
        {
            GaxPreconditions.CheckNotNull(sourceUris, nameof(sourceUris));
            GaxPreconditions.CheckNotNull(destination, nameof(destination));
            List<string> sourceList = sourceUris.ToList();
            GaxPreconditions.CheckArgument(sourceList.Count != 0, nameof(sourceUris), "Source URIs collection cannot be empty");

            var load = new JobConfigurationLoad { SourceUris = sourceList, DestinationTable = destination, Schema = schema };
            options?.ModifyRequest(load);
            var request = CreateInsertJobRequest(new JobConfiguration { Load = load }, options);
            return request;
        }

        private InsertRequest CreateInsertJobRequest(JobConfiguration configuration, JobCreationOptions options)
        {
            var job = CreateJob(configuration, options);
            var request = Service.Jobs.Insert(job, job.JobReference.ProjectId);

            // It's safe to retry job inserts when they include a job ID, which ours always do.
            RetryHandler.MarkAsRetriable(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private InsertRequest CreateModelExtractJobRequest(ModelReference modelReference, IEnumerable<string> destinationUris, CreateModelExtractJobOptions options)
        {
            GaxPreconditions.CheckNotNull(modelReference, nameof(modelReference));
            GaxPreconditions.CheckNotNull(destinationUris, nameof(destinationUris));
            List<string> destinationUriList = destinationUris.ToList();
            GaxPreconditions.CheckArgument(destinationUriList.Count != 0, nameof(destinationUris), "Destination URIs cannot be empty");

            var extract = new JobConfigurationExtract { DestinationUris = destinationUriList, SourceModel = modelReference };
            options?.ModifyRequest(extract);
            return CreateInsertJobRequest(new JobConfiguration { Extract = extract }, options);
        }

        private DeleteRequest CreateDeleteJobRequest(JobReference jobReference, DeleteJobOptions options)
        {
            GaxPreconditions.CheckNotNull(jobReference, nameof(jobReference));
            var request = Service.Jobs.Delete(jobReference.ProjectId, jobReference.JobId);
            request.Location = jobReference.Location;
            options?.ModifyRequest(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }
    }
}
