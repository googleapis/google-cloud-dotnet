// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Dataflow.V1Beta3
{
    /// <summary>Settings for <see cref="JobsV1Beta3Client"/> instances.</summary>
    public sealed partial class JobsV1Beta3Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="JobsV1Beta3Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="JobsV1Beta3Settings"/>.</returns>
        public static JobsV1Beta3Settings GetDefault() => new JobsV1Beta3Settings();

        /// <summary>Constructs a new <see cref="JobsV1Beta3Settings"/> object with default settings.</summary>
        public JobsV1Beta3Settings()
        {
        }

        private JobsV1Beta3Settings(JobsV1Beta3Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateJobSettings = existing.CreateJobSettings;
            GetJobSettings = existing.GetJobSettings;
            UpdateJobSettings = existing.UpdateJobSettings;
            ListJobsSettings = existing.ListJobsSettings;
            AggregatedListJobsSettings = existing.AggregatedListJobsSettings;
            CheckActiveJobsSettings = existing.CheckActiveJobsSettings;
            SnapshotJobSettings = existing.SnapshotJobSettings;
            OnCopy(existing);
        }

        partial void OnCopy(JobsV1Beta3Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobsV1Beta3Client.CreateJob</c>
        ///  and <c>JobsV1Beta3Client.CreateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobsV1Beta3Client.GetJob</c>
        ///  and <c>JobsV1Beta3Client.GetJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobsV1Beta3Client.UpdateJob</c>
        ///  and <c>JobsV1Beta3Client.UpdateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobsV1Beta3Client.ListJobs</c>
        ///  and <c>JobsV1Beta3Client.ListJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobsV1Beta3Client.AggregatedListJobs</c> and <c>JobsV1Beta3Client.AggregatedListJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AggregatedListJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobsV1Beta3Client.CheckActiveJobs</c> and <c>JobsV1Beta3Client.CheckActiveJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CheckActiveJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobsV1Beta3Client.SnapshotJob</c> and <c>JobsV1Beta3Client.SnapshotJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SnapshotJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="JobsV1Beta3Settings"/> object.</returns>
        public JobsV1Beta3Settings Clone() => new JobsV1Beta3Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="JobsV1Beta3Client"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class JobsV1Beta3ClientBuilder : gaxgrpc::ClientBuilderBase<JobsV1Beta3Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public JobsV1Beta3Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public JobsV1Beta3ClientBuilder() : base(JobsV1Beta3Client.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref JobsV1Beta3Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<JobsV1Beta3Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override JobsV1Beta3Client Build()
        {
            JobsV1Beta3Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<JobsV1Beta3Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<JobsV1Beta3Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private JobsV1Beta3Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return JobsV1Beta3Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<JobsV1Beta3Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return JobsV1Beta3Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => JobsV1Beta3Client.ChannelPool;
    }

    /// <summary>JobsV1Beta3 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides a method to create and modify Google Cloud Dataflow jobs.
    /// A Job is a multi-stage computation graph run by the Cloud Dataflow service.
    /// </remarks>
    public abstract partial class JobsV1Beta3Client
    {
        /// <summary>
        /// The default endpoint for the JobsV1Beta3 service, which is a host of "dataflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataflow.googleapis.com:443";

        /// <summary>The default JobsV1Beta3 scopes.</summary>
        /// <remarks>
        /// The default JobsV1Beta3 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/compute",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(JobsV1Beta3.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="JobsV1Beta3Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="JobsV1Beta3ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="JobsV1Beta3Client"/>.</returns>
        public static stt::Task<JobsV1Beta3Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new JobsV1Beta3ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="JobsV1Beta3Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="JobsV1Beta3ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="JobsV1Beta3Client"/>.</returns>
        public static JobsV1Beta3Client Create() => new JobsV1Beta3ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="JobsV1Beta3Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="JobsV1Beta3Settings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="JobsV1Beta3Client"/>.</returns>
        internal static JobsV1Beta3Client Create(grpccore::CallInvoker callInvoker, JobsV1Beta3Settings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            JobsV1Beta3.JobsV1Beta3Client grpcClient = new JobsV1Beta3.JobsV1Beta3Client(callInvoker);
            return new JobsV1Beta3ClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC JobsV1Beta3 client</summary>
        public virtual JobsV1Beta3.JobsV1Beta3Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Cloud Dataflow job.
        /// 
        /// To create a job, we recommend using `projects.locations.jobs.create` with a
        /// [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.create` is not recommended, as your job will always start
        /// in `us-central1`.
        /// 
        /// Do not enter confidential information when you supply string values using
        /// the API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job CreateJob(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Cloud Dataflow job.
        /// 
        /// To create a job, we recommend using `projects.locations.jobs.create` with a
        /// [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.create` is not recommended, as your job will always start
        /// in `us-central1`.
        /// 
        /// Do not enter confidential information when you supply string values using
        /// the API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Cloud Dataflow job.
        /// 
        /// To create a job, we recommend using `projects.locations.jobs.create` with a
        /// [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.create` is not recommended, as your job will always start
        /// in `us-central1`.
        /// 
        /// Do not enter confidential information when you supply string values using
        /// the API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(CreateJobRequest request, st::CancellationToken cancellationToken) =>
            CreateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the state of the specified Cloud Dataflow job.
        /// 
        /// To get the state of a job, we recommend using `projects.locations.jobs.get`
        /// with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.get` is not recommended, as you can only get the state of
        /// jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the state of the specified Cloud Dataflow job.
        /// 
        /// To get the state of a job, we recommend using `projects.locations.jobs.get`
        /// with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.get` is not recommended, as you can only get the state of
        /// jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the state of the specified Cloud Dataflow job.
        /// 
        /// To get the state of a job, we recommend using `projects.locations.jobs.get`
        /// with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.get` is not recommended, as you can only get the state of
        /// jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, st::CancellationToken cancellationToken) =>
            GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the state of an existing Cloud Dataflow job.
        /// 
        /// To update the state of an existing job, we recommend using
        /// `projects.locations.jobs.update` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.update` is not recommended, as you can only update the state
        /// of jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job UpdateJob(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the state of an existing Cloud Dataflow job.
        /// 
        /// To update the state of an existing job, we recommend using
        /// `projects.locations.jobs.update` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.update` is not recommended, as you can only update the state
        /// of jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the state of an existing Cloud Dataflow job.
        /// 
        /// To update the state of an existing job, we recommend using
        /// `projects.locations.jobs.update` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.update` is not recommended, as you can only update the state
        /// of jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(UpdateJobRequest request, st::CancellationToken cancellationToken) =>
            UpdateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List the jobs of a project.
        /// 
        /// To list the jobs of a project in a region, we recommend using
        /// `projects.locations.jobs.list` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). To
        /// list the all jobs across all regions, use `projects.jobs.aggregated`. Using
        /// `projects.jobs.list` is not recommended, because you can only get the list
        /// of jobs that are running in `us-central1`.
        /// 
        /// `projects.locations.jobs.list` and `projects.jobs.list` support filtering
        /// the list of jobs by name. Filtering by name isn't supported by
        /// `projects.jobs.aggregated`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the jobs of a project.
        /// 
        /// To list the jobs of a project in a region, we recommend using
        /// `projects.locations.jobs.list` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). To
        /// list the all jobs across all regions, use `projects.jobs.aggregated`. Using
        /// `projects.jobs.list` is not recommended, because you can only get the list
        /// of jobs that are running in `us-central1`.
        /// 
        /// `projects.locations.jobs.list` and `projects.jobs.list` support filtering
        /// the list of jobs by name. Filtering by name isn't supported by
        /// `projects.jobs.aggregated`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the jobs of a project across all regions.
        /// 
        /// **Note:** This method doesn't support filtering the list of
        /// jobs by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> AggregatedListJobs(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the jobs of a project across all regions.
        /// 
        /// **Note:** This method doesn't support filtering the list of
        /// jobs by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> AggregatedListJobsAsync(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Check for existence of active jobs in the given project across all regions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckActiveJobsResponse CheckActiveJobs(CheckActiveJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Check for existence of active jobs in the given project across all regions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckActiveJobsResponse> CheckActiveJobsAsync(CheckActiveJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Check for existence of active jobs in the given project across all regions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckActiveJobsResponse> CheckActiveJobsAsync(CheckActiveJobsRequest request, st::CancellationToken cancellationToken) =>
            CheckActiveJobsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Snapshot the state of a streaming job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot SnapshotJob(SnapshotJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Snapshot the state of a streaming job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> SnapshotJobAsync(SnapshotJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Snapshot the state of a streaming job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> SnapshotJobAsync(SnapshotJobRequest request, st::CancellationToken cancellationToken) =>
            SnapshotJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>JobsV1Beta3 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides a method to create and modify Google Cloud Dataflow jobs.
    /// A Job is a multi-stage computation graph run by the Cloud Dataflow service.
    /// </remarks>
    public sealed partial class JobsV1Beta3ClientImpl : JobsV1Beta3Client
    {
        private readonly gaxgrpc::ApiCall<CreateJobRequest, Job> _callCreateJob;

        private readonly gaxgrpc::ApiCall<GetJobRequest, Job> _callGetJob;

        private readonly gaxgrpc::ApiCall<UpdateJobRequest, Job> _callUpdateJob;

        private readonly gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> _callListJobs;

        private readonly gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> _callAggregatedListJobs;

        private readonly gaxgrpc::ApiCall<CheckActiveJobsRequest, CheckActiveJobsResponse> _callCheckActiveJobs;

        private readonly gaxgrpc::ApiCall<SnapshotJobRequest, Snapshot> _callSnapshotJob;

        /// <summary>
        /// Constructs a client wrapper for the JobsV1Beta3 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="JobsV1Beta3Settings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public JobsV1Beta3ClientImpl(JobsV1Beta3.JobsV1Beta3Client grpcClient, JobsV1Beta3Settings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            JobsV1Beta3Settings effectiveSettings = settings ?? JobsV1Beta3Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateJob = clientHelper.BuildApiCall<CreateJobRequest, Job>("CreateJob", grpcClient.CreateJobAsync, grpcClient.CreateJob, effectiveSettings.CreateJobSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callCreateJob);
            Modify_CreateJobApiCall(ref _callCreateJob);
            _callGetJob = clientHelper.BuildApiCall<GetJobRequest, Job>("GetJob", grpcClient.GetJobAsync, grpcClient.GetJob, effectiveSettings.GetJobSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("location", request => request.Location).WithGoogleRequestParam("job_id", request => request.JobId);
            Modify_ApiCall(ref _callGetJob);
            Modify_GetJobApiCall(ref _callGetJob);
            _callUpdateJob = clientHelper.BuildApiCall<UpdateJobRequest, Job>("UpdateJob", grpcClient.UpdateJobAsync, grpcClient.UpdateJob, effectiveSettings.UpdateJobSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("location", request => request.Location).WithGoogleRequestParam("job_id", request => request.JobId);
            Modify_ApiCall(ref _callUpdateJob);
            Modify_UpdateJobApiCall(ref _callUpdateJob);
            _callListJobs = clientHelper.BuildApiCall<ListJobsRequest, ListJobsResponse>("ListJobs", grpcClient.ListJobsAsync, grpcClient.ListJobs, effectiveSettings.ListJobsSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callListJobs);
            Modify_ListJobsApiCall(ref _callListJobs);
            _callAggregatedListJobs = clientHelper.BuildApiCall<ListJobsRequest, ListJobsResponse>("AggregatedListJobs", grpcClient.AggregatedListJobsAsync, grpcClient.AggregatedListJobs, effectiveSettings.AggregatedListJobsSettings).WithGoogleRequestParam("project_id", request => request.ProjectId);
            Modify_ApiCall(ref _callAggregatedListJobs);
            Modify_AggregatedListJobsApiCall(ref _callAggregatedListJobs);
            _callCheckActiveJobs = clientHelper.BuildApiCall<CheckActiveJobsRequest, CheckActiveJobsResponse>("CheckActiveJobs", grpcClient.CheckActiveJobsAsync, grpcClient.CheckActiveJobs, effectiveSettings.CheckActiveJobsSettings);
            Modify_ApiCall(ref _callCheckActiveJobs);
            Modify_CheckActiveJobsApiCall(ref _callCheckActiveJobs);
            _callSnapshotJob = clientHelper.BuildApiCall<SnapshotJobRequest, Snapshot>("SnapshotJob", grpcClient.SnapshotJobAsync, grpcClient.SnapshotJob, effectiveSettings.SnapshotJobSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("location", request => request.Location).WithGoogleRequestParam("job_id", request => request.JobId);
            Modify_ApiCall(ref _callSnapshotJob);
            Modify_SnapshotJobApiCall(ref _callSnapshotJob);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateJobApiCall(ref gaxgrpc::ApiCall<CreateJobRequest, Job> call);

        partial void Modify_GetJobApiCall(ref gaxgrpc::ApiCall<GetJobRequest, Job> call);

        partial void Modify_UpdateJobApiCall(ref gaxgrpc::ApiCall<UpdateJobRequest, Job> call);

        partial void Modify_ListJobsApiCall(ref gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> call);

        partial void Modify_AggregatedListJobsApiCall(ref gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> call);

        partial void Modify_CheckActiveJobsApiCall(ref gaxgrpc::ApiCall<CheckActiveJobsRequest, CheckActiveJobsResponse> call);

        partial void Modify_SnapshotJobApiCall(ref gaxgrpc::ApiCall<SnapshotJobRequest, Snapshot> call);

        partial void OnConstruction(JobsV1Beta3.JobsV1Beta3Client grpcClient, JobsV1Beta3Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC JobsV1Beta3 client</summary>
        public override JobsV1Beta3.JobsV1Beta3Client GrpcClient { get; }

        partial void Modify_CreateJobRequest(ref CreateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetJobRequest(ref GetJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateJobRequest(ref UpdateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListJobsRequest(ref ListJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CheckActiveJobsRequest(ref CheckActiveJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SnapshotJobRequest(ref SnapshotJobRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a Cloud Dataflow job.
        /// 
        /// To create a job, we recommend using `projects.locations.jobs.create` with a
        /// [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.create` is not recommended, as your job will always start
        /// in `us-central1`.
        /// 
        /// Do not enter confidential information when you supply string values using
        /// the API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Job CreateJob(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobRequest(ref request, ref callSettings);
            return _callCreateJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Cloud Dataflow job.
        /// 
        /// To create a job, we recommend using `projects.locations.jobs.create` with a
        /// [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.create` is not recommended, as your job will always start
        /// in `us-central1`.
        /// 
        /// Do not enter confidential information when you supply string values using
        /// the API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> CreateJobAsync(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobRequest(ref request, ref callSettings);
            return _callCreateJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the state of the specified Cloud Dataflow job.
        /// 
        /// To get the state of a job, we recommend using `projects.locations.jobs.get`
        /// with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.get` is not recommended, as you can only get the state of
        /// jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Job GetJob(GetJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobRequest(ref request, ref callSettings);
            return _callGetJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the state of the specified Cloud Dataflow job.
        /// 
        /// To get the state of a job, we recommend using `projects.locations.jobs.get`
        /// with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.get` is not recommended, as you can only get the state of
        /// jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> GetJobAsync(GetJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobRequest(ref request, ref callSettings);
            return _callGetJob.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the state of an existing Cloud Dataflow job.
        /// 
        /// To update the state of an existing job, we recommend using
        /// `projects.locations.jobs.update` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.update` is not recommended, as you can only update the state
        /// of jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Job UpdateJob(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateJobRequest(ref request, ref callSettings);
            return _callUpdateJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the state of an existing Cloud Dataflow job.
        /// 
        /// To update the state of an existing job, we recommend using
        /// `projects.locations.jobs.update` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.update` is not recommended, as you can only update the state
        /// of jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> UpdateJobAsync(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateJobRequest(ref request, ref callSettings);
            return _callUpdateJob.Async(request, callSettings);
        }

        /// <summary>
        /// List the jobs of a project.
        /// 
        /// To list the jobs of a project in a region, we recommend using
        /// `projects.locations.jobs.list` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). To
        /// list the all jobs across all regions, use `projects.jobs.aggregated`. Using
        /// `projects.jobs.list` is not recommended, because you can only get the list
        /// of jobs that are running in `us-central1`.
        /// 
        /// `projects.locations.jobs.list` and `projects.jobs.list` support filtering
        /// the list of jobs by name. Filtering by name isn't supported by
        /// `projects.jobs.aggregated`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public override gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListJobsRequest, ListJobsResponse, Job>(_callListJobs, request, callSettings);
        }

        /// <summary>
        /// List the jobs of a project.
        /// 
        /// To list the jobs of a project in a region, we recommend using
        /// `projects.locations.jobs.list` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). To
        /// list the all jobs across all regions, use `projects.jobs.aggregated`. Using
        /// `projects.jobs.list` is not recommended, because you can only get the list
        /// of jobs that are running in `us-central1`.
        /// 
        /// `projects.locations.jobs.list` and `projects.jobs.list` support filtering
        /// the list of jobs by name. Filtering by name isn't supported by
        /// `projects.jobs.aggregated`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListJobsRequest, ListJobsResponse, Job>(_callListJobs, request, callSettings);
        }

        /// <summary>
        /// List the jobs of a project across all regions.
        /// 
        /// **Note:** This method doesn't support filtering the list of
        /// jobs by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public override gax::PagedEnumerable<ListJobsResponse, Job> AggregatedListJobs(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListJobsRequest, ListJobsResponse, Job>(_callAggregatedListJobs, request, callSettings);
        }

        /// <summary>
        /// List the jobs of a project across all regions.
        /// 
        /// **Note:** This method doesn't support filtering the list of
        /// jobs by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListJobsResponse, Job> AggregatedListJobsAsync(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListJobsRequest, ListJobsResponse, Job>(_callAggregatedListJobs, request, callSettings);
        }

        /// <summary>
        /// Check for existence of active jobs in the given project across all regions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckActiveJobsResponse CheckActiveJobs(CheckActiveJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckActiveJobsRequest(ref request, ref callSettings);
            return _callCheckActiveJobs.Sync(request, callSettings);
        }

        /// <summary>
        /// Check for existence of active jobs in the given project across all regions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckActiveJobsResponse> CheckActiveJobsAsync(CheckActiveJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckActiveJobsRequest(ref request, ref callSettings);
            return _callCheckActiveJobs.Async(request, callSettings);
        }

        /// <summary>
        /// Snapshot the state of a streaming job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Snapshot SnapshotJob(SnapshotJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SnapshotJobRequest(ref request, ref callSettings);
            return _callSnapshotJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Snapshot the state of a streaming job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Snapshot> SnapshotJobAsync(SnapshotJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SnapshotJobRequest(ref request, ref callSettings);
            return _callSnapshotJob.Async(request, callSettings);
        }
    }

    public partial class ListJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListJobsResponse : gaxgrpc::IPageResponse<Job>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Job> GetEnumerator() => Jobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
