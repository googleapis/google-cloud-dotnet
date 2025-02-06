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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Run.V2
{
    /// <summary>Settings for <see cref="JobsClient"/> instances.</summary>
    public sealed partial class JobsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="JobsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="JobsSettings"/>.</returns>
        public static JobsSettings GetDefault() => new JobsSettings();

        /// <summary>Constructs a new <see cref="JobsSettings"/> object with default settings.</summary>
        public JobsSettings()
        {
        }

        private JobsSettings(JobsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateJobSettings = existing.CreateJobSettings;
            CreateJobOperationsSettings = existing.CreateJobOperationsSettings.Clone();
            GetJobSettings = existing.GetJobSettings;
            ListJobsSettings = existing.ListJobsSettings;
            UpdateJobSettings = existing.UpdateJobSettings;
            UpdateJobOperationsSettings = existing.UpdateJobOperationsSettings.Clone();
            DeleteJobSettings = existing.DeleteJobSettings;
            DeleteJobOperationsSettings = existing.DeleteJobOperationsSettings.Clone();
            RunJobSettings = existing.RunJobSettings;
            RunJobOperationsSettings = existing.RunJobOperationsSettings.Clone();
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(JobsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobsClient.CreateJob</c>
        /// and <c>JobsClient.CreateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobsClient.CreateJob</c> and <c>JobsClient.CreateJobAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobsClient.GetJob</c> and
        /// <c>JobsClient.GetJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobsClient.ListJobs</c> and
        /// <c>JobsClient.ListJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobsClient.UpdateJob</c>
        /// and <c>JobsClient.UpdateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobsClient.UpdateJob</c> and <c>JobsClient.UpdateJobAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobsClient.DeleteJob</c>
        /// and <c>JobsClient.DeleteJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobsClient.DeleteJob</c> and <c>JobsClient.DeleteJobAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobsClient.RunJob</c> and
        /// <c>JobsClient.RunJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobsClient.RunJob</c> and <c>JobsClient.RunJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RunJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobsClient.GetIamPolicy</c>
        /// and <c>JobsClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobsClient.SetIamPolicy</c>
        /// and <c>JobsClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobsClient.TestIamPermissions</c> and <c>JobsClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="JobsSettings"/> object.</returns>
        public JobsSettings Clone() => new JobsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="JobsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class JobsClientBuilder : gaxgrpc::ClientBuilderBase<JobsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public JobsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public JobsClientBuilder() : base(JobsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref JobsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<JobsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override JobsClient Build()
        {
            JobsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<JobsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<JobsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private JobsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return JobsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<JobsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return JobsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => JobsClient.ChannelPool;
    }

    /// <summary>Jobs client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Cloud Run Job Control Plane API.
    /// </remarks>
    public abstract partial class JobsClient
    {
        /// <summary>
        /// The default endpoint for the Jobs service, which is a host of "run.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "run.googleapis.com:443";

        /// <summary>The default Jobs scopes.</summary>
        /// <remarks>
        /// The default Jobs scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Jobs.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="JobsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="JobsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="JobsClient"/>.</returns>
        public static stt::Task<JobsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new JobsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="JobsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="JobsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="JobsClient"/>.</returns>
        public static JobsClient Create() => new JobsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="JobsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="JobsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="JobsClient"/>.</returns>
        internal static JobsClient Create(grpccore::CallInvoker callInvoker, JobsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Jobs.JobsClient grpcClient = new Jobs.JobsClient(callInvoker);
            return new JobsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Jobs client</summary>
        public virtual Jobs.JobsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Job, Job> CreateJob(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> CreateJobAsync(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> CreateJobAsync(CreateJobRequest request, st::CancellationToken cancellationToken) =>
            CreateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateJob</c>.</summary>
        public virtual lro::OperationsClient CreateJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Job, Job> PollOnceCreateJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Job, Job>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> PollOnceCreateJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Job, Job>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateJobOperationsClient, callSettings);

        /// <summary>
        /// Creates a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project in which this Job should be created.
        /// Format: projects/{project}/locations/{location}, where {project} can be
        /// project id or number.
        /// </param>
        /// <param name="job">
        /// Required. The Job instance to create.
        /// </param>
        /// <param name="jobId">
        /// Required. The unique identifier for the Job. The name of the job becomes
        /// {parent}/jobs/{job_id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Job, Job> CreateJob(string parent, Job job, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateJob(new CreateJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

        /// <summary>
        /// Creates a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project in which this Job should be created.
        /// Format: projects/{project}/locations/{location}, where {project} can be
        /// project id or number.
        /// </param>
        /// <param name="job">
        /// Required. The Job instance to create.
        /// </param>
        /// <param name="jobId">
        /// Required. The unique identifier for the Job. The name of the job becomes
        /// {parent}/jobs/{job_id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> CreateJobAsync(string parent, Job job, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobAsync(new CreateJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

        /// <summary>
        /// Creates a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project in which this Job should be created.
        /// Format: projects/{project}/locations/{location}, where {project} can be
        /// project id or number.
        /// </param>
        /// <param name="job">
        /// Required. The Job instance to create.
        /// </param>
        /// <param name="jobId">
        /// Required. The unique identifier for the Job. The name of the job becomes
        /// {parent}/jobs/{job_id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> CreateJobAsync(string parent, Job job, string jobId, st::CancellationToken cancellationToken) =>
            CreateJobAsync(parent, job, jobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project in which this Job should be created.
        /// Format: projects/{project}/locations/{location}, where {project} can be
        /// project id or number.
        /// </param>
        /// <param name="job">
        /// Required. The Job instance to create.
        /// </param>
        /// <param name="jobId">
        /// Required. The unique identifier for the Job. The name of the job becomes
        /// {parent}/jobs/{job_id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Job, Job> CreateJob(gagr::LocationName parent, Job job, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateJob(new CreateJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

        /// <summary>
        /// Creates a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project in which this Job should be created.
        /// Format: projects/{project}/locations/{location}, where {project} can be
        /// project id or number.
        /// </param>
        /// <param name="job">
        /// Required. The Job instance to create.
        /// </param>
        /// <param name="jobId">
        /// Required. The unique identifier for the Job. The name of the job becomes
        /// {parent}/jobs/{job_id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> CreateJobAsync(gagr::LocationName parent, Job job, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobAsync(new CreateJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

        /// <summary>
        /// Creates a Job.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project in which this Job should be created.
        /// Format: projects/{project}/locations/{location}, where {project} can be
        /// project id or number.
        /// </param>
        /// <param name="job">
        /// Required. The Job instance to create.
        /// </param>
        /// <param name="jobId">
        /// Required. The unique identifier for the Job. The name of the job becomes
        /// {parent}/jobs/{job_id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> CreateJobAsync(gagr::LocationName parent, Job job, string jobId, st::CancellationToken cancellationToken) =>
            CreateJobAsync(parent, job, jobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, st::CancellationToken cancellationToken) =>
            GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJob(new GetJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobAsync(new GetJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJob(new GetJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobAsync(new GetJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            GetJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Jobs. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Jobs. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Jobs. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project to list resources on.
        /// Format: projects/{project}/locations/{location}, where {project} can be
        /// project id or number.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListJobs(request, callSettings);
        }

        /// <summary>
        /// Lists Jobs. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project to list resources on.
        /// Format: projects/{project}/locations/{location}, where {project} can be
        /// project id or number.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Jobs. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project to list resources on.
        /// Format: projects/{project}/locations/{location}, where {project} can be
        /// project id or number.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListJobs(request, callSettings);
        }

        /// <summary>
        /// Lists Jobs. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="parent">
        /// Required. The location and project to list resources on.
        /// Format: projects/{project}/locations/{location}, where {project} can be
        /// project id or number.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Job, Job> UpdateJob(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> UpdateJobAsync(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> UpdateJobAsync(UpdateJobRequest request, st::CancellationToken cancellationToken) =>
            UpdateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateJob</c>.</summary>
        public virtual lro::OperationsClient UpdateJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Job, Job> PollOnceUpdateJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Job, Job>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> PollOnceUpdateJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Job, Job>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateJobOperationsClient, callSettings);

        /// <summary>
        /// Updates a Job.
        /// </summary>
        /// <param name="job">
        /// Required. The Job to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Job, Job> UpdateJob(Job job, gaxgrpc::CallSettings callSettings = null) =>
            UpdateJob(new UpdateJobRequest
            {
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Updates a Job.
        /// </summary>
        /// <param name="job">
        /// Required. The Job to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> UpdateJobAsync(Job job, gaxgrpc::CallSettings callSettings = null) =>
            UpdateJobAsync(new UpdateJobRequest
            {
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Updates a Job.
        /// </summary>
        /// <param name="job">
        /// Required. The Job to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> UpdateJobAsync(Job job, st::CancellationToken cancellationToken) =>
            UpdateJobAsync(job, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Job, Job> DeleteJob(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> DeleteJobAsync(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> DeleteJobAsync(DeleteJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteJob</c>.</summary>
        public virtual lro::OperationsClient DeleteJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Job, Job> PollOnceDeleteJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Job, Job>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> PollOnceDeleteJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Job, Job>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteJobOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Job, Job> DeleteJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJob(new DeleteJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> DeleteJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobAsync(new DeleteJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> DeleteJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Job, Job> DeleteJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJob(new DeleteJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> DeleteJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobAsync(new DeleteJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Job, Job>> DeleteJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Triggers creation of a new Execution of this Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Execution, Execution> RunJob(RunJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Triggers creation of a new Execution of this Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, Execution>> RunJobAsync(RunJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Triggers creation of a new Execution of this Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, Execution>> RunJobAsync(RunJobRequest request, st::CancellationToken cancellationToken) =>
            RunJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunJob</c>.</summary>
        public virtual lro::OperationsClient RunJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Execution, Execution> PollOnceRunJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Execution, Execution>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Execution, Execution>> PollOnceRunJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Execution, Execution>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunJobOperationsClient, callSettings);

        /// <summary>
        /// Triggers creation of a new Execution of this Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Execution, Execution> RunJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            RunJob(new RunJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Triggers creation of a new Execution of this Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, Execution>> RunJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RunJobAsync(new RunJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Triggers creation of a new Execution of this Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, Execution>> RunJobAsync(string name, st::CancellationToken cancellationToken) =>
            RunJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Triggers creation of a new Execution of this Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Execution, Execution> RunJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            RunJob(new RunJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Triggers creation of a new Execution of this Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, Execution>> RunJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            RunJobAsync(new RunJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Triggers creation of a new Execution of this Job.
        /// </summary>
        /// <param name="name">
        /// Required. The full name of the Job.
        /// Format: projects/{project}/locations/{location}/jobs/{job}, where {project}
        /// can be project id or number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, Execution>> RunJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            RunJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM Access Control policy currently in effect for the given Job.
        /// This result does not include any inherited policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM Access Control policy currently in effect for the given Job.
        /// This result does not include any inherited policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM Access Control policy currently in effect for the given Job.
        /// This result does not include any inherited policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM Access control policy for the specified Job. Overwrites
        /// any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM Access control policy for the specified Job. Overwrites
        /// any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM Access control policy for the specified Job. Overwrites
        /// any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified Project.
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified Project.
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified Project.
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Jobs client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Cloud Run Job Control Plane API.
    /// </remarks>
    public sealed partial class JobsClientImpl : JobsClient
    {
        private readonly gaxgrpc::ApiCall<CreateJobRequest, lro::Operation> _callCreateJob;

        private readonly gaxgrpc::ApiCall<GetJobRequest, Job> _callGetJob;

        private readonly gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> _callListJobs;

        private readonly gaxgrpc::ApiCall<UpdateJobRequest, lro::Operation> _callUpdateJob;

        private readonly gaxgrpc::ApiCall<DeleteJobRequest, lro::Operation> _callDeleteJob;

        private readonly gaxgrpc::ApiCall<RunJobRequest, lro::Operation> _callRunJob;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the Jobs service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="JobsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public JobsClientImpl(Jobs.JobsClient grpcClient, JobsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            JobsSettings effectiveSettings = settings ?? JobsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateJobOperationsSettings, logger);
            UpdateJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateJobOperationsSettings, logger);
            DeleteJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteJobOperationsSettings, logger);
            RunJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunJobOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateJob = clientHelper.BuildApiCall<CreateJobRequest, lro::Operation>("CreateJob", grpcClient.CreateJobAsync, grpcClient.CreateJob, effectiveSettings.CreateJobSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CreateJobRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callCreateJob);
            Modify_CreateJobApiCall(ref _callCreateJob);
            _callGetJob = clientHelper.BuildApiCall<GetJobRequest, Job>("GetJob", grpcClient.GetJobAsync, grpcClient.GetJob, effectiveSettings.GetJobSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetJobRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callGetJob);
            Modify_GetJobApiCall(ref _callGetJob);
            _callListJobs = clientHelper.BuildApiCall<ListJobsRequest, ListJobsResponse>("ListJobs", grpcClient.ListJobsAsync, grpcClient.ListJobs, effectiveSettings.ListJobsSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ListJobsRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callListJobs);
            Modify_ListJobsApiCall(ref _callListJobs);
            _callUpdateJob = clientHelper.BuildApiCall<UpdateJobRequest, lro::Operation>("UpdateJob", grpcClient.UpdateJobAsync, grpcClient.UpdateJob, effectiveSettings.UpdateJobSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<UpdateJobRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)(?:/.*)?$", request => request.Job?.Name));
            Modify_ApiCall(ref _callUpdateJob);
            Modify_UpdateJobApiCall(ref _callUpdateJob);
            _callDeleteJob = clientHelper.BuildApiCall<DeleteJobRequest, lro::Operation>("DeleteJob", grpcClient.DeleteJobAsync, grpcClient.DeleteJob, effectiveSettings.DeleteJobSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<DeleteJobRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callDeleteJob);
            Modify_DeleteJobApiCall(ref _callDeleteJob);
            _callRunJob = clientHelper.BuildApiCall<RunJobRequest, lro::Operation>("RunJob", grpcClient.RunJobAsync, grpcClient.RunJob, effectiveSettings.RunJobSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<RunJobRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)(?:/.*)?$", request => request.Name));
            Modify_ApiCall(ref _callRunJob);
            Modify_RunJobApiCall(ref _callRunJob);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateJobApiCall(ref gaxgrpc::ApiCall<CreateJobRequest, lro::Operation> call);

        partial void Modify_GetJobApiCall(ref gaxgrpc::ApiCall<GetJobRequest, Job> call);

        partial void Modify_ListJobsApiCall(ref gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> call);

        partial void Modify_UpdateJobApiCall(ref gaxgrpc::ApiCall<UpdateJobRequest, lro::Operation> call);

        partial void Modify_DeleteJobApiCall(ref gaxgrpc::ApiCall<DeleteJobRequest, lro::Operation> call);

        partial void Modify_RunJobApiCall(ref gaxgrpc::ApiCall<RunJobRequest, lro::Operation> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(Jobs.JobsClient grpcClient, JobsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Jobs client</summary>
        public override Jobs.JobsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateJobRequest(ref CreateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetJobRequest(ref GetJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListJobsRequest(ref ListJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateJobRequest(ref UpdateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteJobRequest(ref DeleteJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunJobRequest(ref RunJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateJob</c>.</summary>
        public override lro::OperationsClient CreateJobOperationsClient { get; }

        /// <summary>
        /// Creates a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Job, Job> CreateJob(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobRequest(ref request, ref callSettings);
            return new lro::Operation<Job, Job>(_callCreateJob.Sync(request, callSettings), CreateJobOperationsClient);
        }

        /// <summary>
        /// Creates a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Job, Job>> CreateJobAsync(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobRequest(ref request, ref callSettings);
            return new lro::Operation<Job, Job>(await _callCreateJob.Async(request, callSettings).ConfigureAwait(false), CreateJobOperationsClient);
        }

        /// <summary>
        /// Gets information about a Job.
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
        /// Gets information about a Job.
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
        /// Lists Jobs. Results are sorted by creation time, descending.
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
        /// Lists Jobs. Results are sorted by creation time, descending.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListJobsRequest, ListJobsResponse, Job>(_callListJobs, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateJob</c>.</summary>
        public override lro::OperationsClient UpdateJobOperationsClient { get; }

        /// <summary>
        /// Updates a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Job, Job> UpdateJob(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateJobRequest(ref request, ref callSettings);
            return new lro::Operation<Job, Job>(_callUpdateJob.Sync(request, callSettings), UpdateJobOperationsClient);
        }

        /// <summary>
        /// Updates a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Job, Job>> UpdateJobAsync(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateJobRequest(ref request, ref callSettings);
            return new lro::Operation<Job, Job>(await _callUpdateJob.Async(request, callSettings).ConfigureAwait(false), UpdateJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteJob</c>.</summary>
        public override lro::OperationsClient DeleteJobOperationsClient { get; }

        /// <summary>
        /// Deletes a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Job, Job> DeleteJob(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobRequest(ref request, ref callSettings);
            return new lro::Operation<Job, Job>(_callDeleteJob.Sync(request, callSettings), DeleteJobOperationsClient);
        }

        /// <summary>
        /// Deletes a Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Job, Job>> DeleteJobAsync(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobRequest(ref request, ref callSettings);
            return new lro::Operation<Job, Job>(await _callDeleteJob.Async(request, callSettings).ConfigureAwait(false), DeleteJobOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RunJob</c>.</summary>
        public override lro::OperationsClient RunJobOperationsClient { get; }

        /// <summary>
        /// Triggers creation of a new Execution of this Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Execution, Execution> RunJob(RunJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunJobRequest(ref request, ref callSettings);
            return new lro::Operation<Execution, Execution>(_callRunJob.Sync(request, callSettings), RunJobOperationsClient);
        }

        /// <summary>
        /// Triggers creation of a new Execution of this Job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Execution, Execution>> RunJobAsync(RunJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunJobRequest(ref request, ref callSettings);
            return new lro::Operation<Execution, Execution>(await _callRunJob.Async(request, callSettings).ConfigureAwait(false), RunJobOperationsClient);
        }

        /// <summary>
        /// Gets the IAM Access Control policy currently in effect for the given Job.
        /// This result does not include any inherited policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM Access Control policy currently in effect for the given Job.
        /// This result does not include any inherited policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM Access control policy for the specified Job. Overwrites
        /// any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM Access control policy for the specified Job. Overwrites
        /// any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Project.
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Project.
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
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

    public static partial class Jobs
    {
        public partial class JobsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }

    public static partial class Jobs
    {
        public partial class JobsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
