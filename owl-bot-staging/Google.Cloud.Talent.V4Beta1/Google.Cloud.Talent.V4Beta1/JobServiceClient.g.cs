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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Talent.V4Beta1
{
    /// <summary>Settings for <see cref="JobServiceClient"/> instances.</summary>
    public sealed partial class JobServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="JobServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="JobServiceSettings"/>.</returns>
        public static JobServiceSettings GetDefault() => new JobServiceSettings();

        /// <summary>Constructs a new <see cref="JobServiceSettings"/> object with default settings.</summary>
        public JobServiceSettings()
        {
        }

        private JobServiceSettings(JobServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateJobSettings = existing.CreateJobSettings;
            BatchCreateJobsSettings = existing.BatchCreateJobsSettings;
            BatchCreateJobsOperationsSettings = existing.BatchCreateJobsOperationsSettings.Clone();
            GetJobSettings = existing.GetJobSettings;
            UpdateJobSettings = existing.UpdateJobSettings;
            BatchUpdateJobsSettings = existing.BatchUpdateJobsSettings;
            BatchUpdateJobsOperationsSettings = existing.BatchUpdateJobsOperationsSettings.Clone();
            DeleteJobSettings = existing.DeleteJobSettings;
            BatchDeleteJobsSettings = existing.BatchDeleteJobsSettings;
            ListJobsSettings = existing.ListJobsSettings;
            SearchJobsSettings = existing.SearchJobsSettings;
            SearchJobsForAlertSettings = existing.SearchJobsForAlertSettings;
            OnCopy(existing);
        }

        partial void OnCopy(JobServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobServiceClient.CreateJob</c>
        ///  and <c>JobServiceClient.CreateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.BatchCreateJobs</c> and <c>JobServiceClient.BatchCreateJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobServiceClient.BatchCreateJobs</c> and
        /// <c>JobServiceClient.BatchCreateJobsAsync</c>.
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
        public lro::OperationsSettings BatchCreateJobsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobServiceClient.GetJob</c>
        /// and <c>JobServiceClient.GetJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobServiceClient.UpdateJob</c>
        ///  and <c>JobServiceClient.UpdateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.BatchUpdateJobs</c> and <c>JobServiceClient.BatchUpdateJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>JobServiceClient.BatchUpdateJobs</c> and
        /// <c>JobServiceClient.BatchUpdateJobsAsync</c>.
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
        public lro::OperationsSettings BatchUpdateJobsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobServiceClient.DeleteJob</c>
        ///  and <c>JobServiceClient.DeleteJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.BatchDeleteJobs</c> and <c>JobServiceClient.BatchDeleteJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeleteJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobServiceClient.ListJobs</c>
        ///  and <c>JobServiceClient.ListJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListJobsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>JobServiceClient.SearchJobs</c>
        ///  and <c>JobServiceClient.SearchJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchJobsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>JobServiceClient.SearchJobsForAlert</c> and <c>JobServiceClient.SearchJobsForAlertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchJobsForAlertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="JobServiceSettings"/> object.</returns>
        public JobServiceSettings Clone() => new JobServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="JobServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class JobServiceClientBuilder : gaxgrpc::ClientBuilderBase<JobServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public JobServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public JobServiceClientBuilder() : base(JobServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref JobServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<JobServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override JobServiceClient Build()
        {
            JobServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<JobServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<JobServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private JobServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return JobServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<JobServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return JobServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => JobServiceClient.ChannelPool;
    }

    /// <summary>JobService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service handles job management, including job CRUD, enumeration and search.
    /// </remarks>
    public abstract partial class JobServiceClient
    {
        /// <summary>
        /// The default endpoint for the JobService service, which is a host of "jobs.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "jobs.googleapis.com:443";

        /// <summary>The default JobService scopes.</summary>
        /// <remarks>
        /// The default JobService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/jobs</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/jobs",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(JobService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="JobServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="JobServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="JobServiceClient"/>.</returns>
        public static stt::Task<JobServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new JobServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="JobServiceClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="JobServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="JobServiceClient"/>.</returns>
        public static JobServiceClient Create() => new JobServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="JobServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="JobServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="JobServiceClient"/>.</returns>
        internal static JobServiceClient Create(grpccore::CallInvoker callInvoker, JobServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            JobService.JobServiceClient grpcClient = new JobService.JobServiceClient(callInvoker);
            return new JobServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC JobService client</summary>
        public virtual JobService.JobServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new job.
        /// 
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job CreateJob(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new job.
        /// 
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new job.
        /// 
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(CreateJobRequest request, st::CancellationToken cancellationToken) =>
            CreateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new job.
        /// 
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job CreateJob(string parent, Job job, gaxgrpc::CallSettings callSettings = null) =>
            CreateJob(new CreateJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Creates a new job.
        /// 
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(string parent, Job job, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobAsync(new CreateJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Creates a new job.
        /// 
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(string parent, Job job, st::CancellationToken cancellationToken) =>
            CreateJobAsync(parent, job, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new job.
        /// 
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job CreateJob(TenantName parent, Job job, gaxgrpc::CallSettings callSettings = null) =>
            CreateJob(new CreateJobRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Creates a new job.
        /// 
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(TenantName parent, Job job, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobAsync(new CreateJobRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Creates a new job.
        /// 
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(TenantName parent, Job job, st::CancellationToken cancellationToken) =>
            CreateJobAsync(parent, job, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new job.
        /// 
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job CreateJob(gagr::ProjectName parent, Job job, gaxgrpc::CallSettings callSettings = null) =>
            CreateJob(new CreateJobRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Creates a new job.
        /// 
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(gagr::ProjectName parent, Job job, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobAsync(new CreateJobRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Creates a new job.
        /// 
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="job">
        /// Required. The Job to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(gagr::ProjectName parent, Job job, st::CancellationToken cancellationToken) =>
            CreateJobAsync(parent, job, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> BatchCreateJobs(BatchCreateJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchCreateJobsAsync(BatchCreateJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchCreateJobsAsync(BatchCreateJobsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateJobsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchCreateJobs</c>.</summary>
        public virtual lro::OperationsClient BatchCreateJobsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchCreateJobs</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> PollOnceBatchCreateJobs(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<JobOperationResult, BatchOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchCreateJobsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchCreateJobs</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> PollOnceBatchCreateJobsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<JobOperationResult, BatchOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchCreateJobsOperationsClient, callSettings);

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> BatchCreateJobs(string parent, scg::IEnumerable<Job> jobs, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateJobs(new BatchCreateJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Jobs =
                {
                    gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)),
                },
            }, callSettings);

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchCreateJobsAsync(string parent, scg::IEnumerable<Job> jobs, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateJobsAsync(new BatchCreateJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Jobs =
                {
                    gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)),
                },
            }, callSettings);

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchCreateJobsAsync(string parent, scg::IEnumerable<Job> jobs, st::CancellationToken cancellationToken) =>
            BatchCreateJobsAsync(parent, jobs, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> BatchCreateJobs(TenantName parent, scg::IEnumerable<Job> jobs, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateJobs(new BatchCreateJobsRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Jobs =
                {
                    gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)),
                },
            }, callSettings);

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchCreateJobsAsync(TenantName parent, scg::IEnumerable<Job> jobs, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateJobsAsync(new BatchCreateJobsRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Jobs =
                {
                    gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)),
                },
            }, callSettings);

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchCreateJobsAsync(TenantName parent, scg::IEnumerable<Job> jobs, st::CancellationToken cancellationToken) =>
            BatchCreateJobsAsync(parent, jobs, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> BatchCreateJobs(gagr::ProjectName parent, scg::IEnumerable<Job> jobs, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateJobs(new BatchCreateJobsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Jobs =
                {
                    gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)),
                },
            }, callSettings);

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchCreateJobsAsync(gagr::ProjectName parent, scg::IEnumerable<Job> jobs, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateJobsAsync(new BatchCreateJobsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Jobs =
                {
                    gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)),
                },
            }, callSettings);

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchCreateJobsAsync(gagr::ProjectName parent, scg::IEnumerable<Job> jobs, st::CancellationToken cancellationToken) =>
            BatchCreateJobsAsync(parent, jobs, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, st::CancellationToken cancellationToken) =>
            GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to retrieve.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        /// 
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJob(new GetJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to retrieve.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        /// 
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobAsync(new GetJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to retrieve.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        /// 
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to retrieve.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        /// 
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJob(new GetJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to retrieve.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        /// 
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobAsync(new GetJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to retrieve.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        /// 
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            GetJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified job.
        /// 
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job UpdateJob(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates specified job.
        /// 
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates specified job.
        /// 
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(UpdateJobRequest request, st::CancellationToken cancellationToken) =>
            UpdateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates specified job.
        /// 
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
        /// </summary>
        /// <param name="job">
        /// Required. The Job to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job UpdateJob(Job job, gaxgrpc::CallSettings callSettings = null) =>
            UpdateJob(new UpdateJobRequest
            {
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Updates specified job.
        /// 
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
        /// </summary>
        /// <param name="job">
        /// Required. The Job to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(Job job, gaxgrpc::CallSettings callSettings = null) =>
            UpdateJobAsync(new UpdateJobRequest
            {
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Updates specified job.
        /// 
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
        /// </summary>
        /// <param name="job">
        /// Required. The Job to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(Job job, st::CancellationToken cancellationToken) =>
            UpdateJobAsync(job, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> BatchUpdateJobs(BatchUpdateJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchUpdateJobsAsync(BatchUpdateJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchUpdateJobsAsync(BatchUpdateJobsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateJobsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchUpdateJobs</c>.</summary>
        public virtual lro::OperationsClient BatchUpdateJobsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchUpdateJobs</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> PollOnceBatchUpdateJobs(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<JobOperationResult, BatchOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchUpdateJobsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchUpdateJobs</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> PollOnceBatchUpdateJobsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<JobOperationResult, BatchOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchUpdateJobsOperationsClient, callSettings);

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> BatchUpdateJobs(string parent, scg::IEnumerable<Job> jobs, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateJobs(new BatchUpdateJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Jobs =
                {
                    gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)),
                },
            }, callSettings);

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchUpdateJobsAsync(string parent, scg::IEnumerable<Job> jobs, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateJobsAsync(new BatchUpdateJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Jobs =
                {
                    gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)),
                },
            }, callSettings);

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchUpdateJobsAsync(string parent, scg::IEnumerable<Job> jobs, st::CancellationToken cancellationToken) =>
            BatchUpdateJobsAsync(parent, jobs, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> BatchUpdateJobs(TenantName parent, scg::IEnumerable<Job> jobs, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateJobs(new BatchUpdateJobsRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Jobs =
                {
                    gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)),
                },
            }, callSettings);

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchUpdateJobsAsync(TenantName parent, scg::IEnumerable<Job> jobs, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateJobsAsync(new BatchUpdateJobsRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Jobs =
                {
                    gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)),
                },
            }, callSettings);

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchUpdateJobsAsync(TenantName parent, scg::IEnumerable<Job> jobs, st::CancellationToken cancellationToken) =>
            BatchUpdateJobsAsync(parent, jobs, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<JobOperationResult, BatchOperationMetadata> BatchUpdateJobs(gagr::ProjectName parent, scg::IEnumerable<Job> jobs, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateJobs(new BatchUpdateJobsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Jobs =
                {
                    gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)),
                },
            }, callSettings);

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchUpdateJobsAsync(gagr::ProjectName parent, scg::IEnumerable<Job> jobs, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateJobsAsync(new BatchUpdateJobsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Jobs =
                {
                    gax::GaxPreconditions.CheckNotNull(jobs, nameof(jobs)),
                },
            }, callSettings);

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="jobs">
        /// Required. The jobs to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchUpdateJobsAsync(gagr::ProjectName parent, scg::IEnumerable<Job> jobs, st::CancellationToken cancellationToken) =>
            BatchUpdateJobsAsync(parent, jobs, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified job.
        /// 
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteJob(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified job.
        /// 
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified job.
        /// 
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(DeleteJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified job.
        /// 
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        /// 
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJob(new DeleteJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified job.
        /// 
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        /// 
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobAsync(new DeleteJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified job.
        /// 
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        /// 
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified job.
        /// 
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        /// 
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJob(new DeleteJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified job.
        /// 
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        /// 
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobAsync(new DeleteJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified job.
        /// 
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the job to be deleted.
        /// 
        /// The format is
        /// "projects/{project_id}/tenants/{tenant_id}/jobs/{job_id}". For
        /// example, "projects/foo/tenants/bar/jobs/baz".
        /// 
        /// If tenant id is unspecified, the default tenant is used. For
        /// example, "projects/foo/jobs/bar".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteJobs(BatchDeleteJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteJobsAsync(BatchDeleteJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteJobsAsync(BatchDeleteJobsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteJobsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        /// 
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteJobs(string parent, string filter, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteJobs(new BatchDeleteJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            }, callSettings);

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        /// 
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteJobsAsync(string parent, string filter, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteJobsAsync(new BatchDeleteJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            }, callSettings);

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        /// 
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteJobsAsync(string parent, string filter, st::CancellationToken cancellationToken) =>
            BatchDeleteJobsAsync(parent, filter, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        /// 
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteJobs(TenantName parent, string filter, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteJobs(new BatchDeleteJobsRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            }, callSettings);

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        /// 
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteJobsAsync(TenantName parent, string filter, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteJobsAsync(new BatchDeleteJobsRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            }, callSettings);

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        /// 
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteJobsAsync(TenantName parent, string filter, st::CancellationToken cancellationToken) =>
            BatchDeleteJobsAsync(parent, filter, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        /// 
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchDeleteJobs(gagr::ProjectName parent, string filter, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteJobs(new BatchDeleteJobsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            }, callSettings);

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        /// 
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteJobsAsync(gagr::ProjectName parent, string filter, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteJobsAsync(new BatchDeleteJobsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            }, callSettings);

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be deleted.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName` (Required)
        /// * `requisitionId` (Required)
        /// 
        /// Sample Query: companyName = "projects/foo/companies/bar" AND
        /// requisitionId = "req-1"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchDeleteJobsAsync(gagr::ProjectName parent, string filter, st::CancellationToken cancellationToken) =>
            BatchDeleteJobsAsync(parent, filter, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists jobs by filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists jobs by filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists jobs by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be enumerated.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName`
        /// * `requisitionId`
        /// * `status` Available values: OPEN, EXPIRED, ALL. Defaults to
        /// OPEN if no value is specified.
        /// 
        /// At least one of `companyName` and `requisitionId` must present or an
        /// INVALID_ARGUMENT error is thrown.
        /// 
        /// Sample Query:
        /// 
        /// * companyName = "projects/foo/tenants/bar/companies/baz"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// requisitionId = "req-1"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// status = "EXPIRED"
        /// * requisitionId = "req-1"
        /// * requisitionId = "req-1" AND status = "EXPIRED"
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
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
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
        /// Lists jobs by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be enumerated.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName`
        /// * `requisitionId`
        /// * `status` Available values: OPEN, EXPIRED, ALL. Defaults to
        /// OPEN if no value is specified.
        /// 
        /// At least one of `companyName` and `requisitionId` must present or an
        /// INVALID_ARGUMENT error is thrown.
        /// 
        /// Sample Query:
        /// 
        /// * companyName = "projects/foo/tenants/bar/companies/baz"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// requisitionId = "req-1"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// status = "EXPIRED"
        /// * requisitionId = "req-1"
        /// * requisitionId = "req-1" AND status = "EXPIRED"
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
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
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
        /// Lists jobs by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be enumerated.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName`
        /// * `requisitionId`
        /// * `status` Available values: OPEN, EXPIRED, ALL. Defaults to
        /// OPEN if no value is specified.
        /// 
        /// At least one of `companyName` and `requisitionId` must present or an
        /// INVALID_ARGUMENT error is thrown.
        /// 
        /// Sample Query:
        /// 
        /// * companyName = "projects/foo/tenants/bar/companies/baz"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// requisitionId = "req-1"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// status = "EXPIRED"
        /// * requisitionId = "req-1"
        /// * requisitionId = "req-1" AND status = "EXPIRED"
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
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(TenantName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
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
        /// Lists jobs by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be enumerated.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName`
        /// * `requisitionId`
        /// * `status` Available values: OPEN, EXPIRED, ALL. Defaults to
        /// OPEN if no value is specified.
        /// 
        /// At least one of `companyName` and `requisitionId` must present or an
        /// INVALID_ARGUMENT error is thrown.
        /// 
        /// Sample Query:
        /// 
        /// * companyName = "projects/foo/tenants/bar/companies/baz"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// requisitionId = "req-1"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// status = "EXPIRED"
        /// * requisitionId = "req-1"
        /// * requisitionId = "req-1" AND status = "EXPIRED"
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
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(TenantName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsTenantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
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
        /// Lists jobs by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be enumerated.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName`
        /// * `requisitionId`
        /// * `status` Available values: OPEN, EXPIRED, ALL. Defaults to
        /// OPEN if no value is specified.
        /// 
        /// At least one of `companyName` and `requisitionId` must present or an
        /// INVALID_ARGUMENT error is thrown.
        /// 
        /// Sample Query:
        /// 
        /// * companyName = "projects/foo/tenants/bar/companies/baz"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// requisitionId = "req-1"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// status = "EXPIRED"
        /// * requisitionId = "req-1"
        /// * requisitionId = "req-1" AND status = "EXPIRED"
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
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(gagr::ProjectName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
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
        /// Lists jobs by filter.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the tenant under which the job is created.
        /// 
        /// The format is "projects/{project_id}/tenants/{tenant_id}". For example,
        /// "projects/foo/tenant/bar". If tenant id is unspecified, a default tenant
        /// is created. For example, "projects/foo".
        /// </param>
        /// <param name="filter">
        /// Required. The filter string specifies the jobs to be enumerated.
        /// 
        /// Supported operator: =, AND
        /// 
        /// The fields eligible for filtering are:
        /// 
        /// * `companyName`
        /// * `requisitionId`
        /// * `status` Available values: OPEN, EXPIRED, ALL. Defaults to
        /// OPEN if no value is specified.
        /// 
        /// At least one of `companyName` and `requisitionId` must present or an
        /// INVALID_ARGUMENT error is thrown.
        /// 
        /// Sample Query:
        /// 
        /// * companyName = "projects/foo/tenants/bar/companies/baz"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// requisitionId = "req-1"
        /// * companyName = "projects/foo/tenants/bar/companies/baz" AND
        /// status = "EXPIRED"
        /// * requisitionId = "req-1"
        /// * requisitionId = "req-1" AND status = "EXPIRED"
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
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(gagr::ProjectName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
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
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        /// 
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs that the caller has permission to
        /// search against.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchJobsResponse SearchJobs(SearchJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        /// 
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs that the caller has permission to
        /// search against.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchJobsResponse> SearchJobsAsync(SearchJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        /// 
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs that the caller has permission to
        /// search against.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchJobsResponse> SearchJobsAsync(SearchJobsRequest request, st::CancellationToken cancellationToken) =>
            SearchJobsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        /// 
        /// This API call is intended for the use case of targeting passive job
        /// seekers (for example, job seekers who have signed up to receive email
        /// alerts about potential job opportunities), and has different algorithmic
        /// adjustments that are targeted to passive job seekers.
        /// 
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs the caller has permission to search
        /// against.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchJobsResponse.Types.MatchingJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchJobsResponse, SearchJobsResponse.Types.MatchingJob> SearchJobsForAlert(SearchJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        /// 
        /// This API call is intended for the use case of targeting passive job
        /// seekers (for example, job seekers who have signed up to receive email
        /// alerts about potential job opportunities), and has different algorithmic
        /// adjustments that are targeted to passive job seekers.
        /// 
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs the caller has permission to search
        /// against.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SearchJobsResponse.Types.MatchingJob"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchJobsResponse, SearchJobsResponse.Types.MatchingJob> SearchJobsForAlertAsync(SearchJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>JobService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service handles job management, including job CRUD, enumeration and search.
    /// </remarks>
    public sealed partial class JobServiceClientImpl : JobServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateJobRequest, Job> _callCreateJob;

        private readonly gaxgrpc::ApiCall<BatchCreateJobsRequest, lro::Operation> _callBatchCreateJobs;

        private readonly gaxgrpc::ApiCall<GetJobRequest, Job> _callGetJob;

        private readonly gaxgrpc::ApiCall<UpdateJobRequest, Job> _callUpdateJob;

        private readonly gaxgrpc::ApiCall<BatchUpdateJobsRequest, lro::Operation> _callBatchUpdateJobs;

        private readonly gaxgrpc::ApiCall<DeleteJobRequest, wkt::Empty> _callDeleteJob;

        private readonly gaxgrpc::ApiCall<BatchDeleteJobsRequest, wkt::Empty> _callBatchDeleteJobs;

        private readonly gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> _callListJobs;

        private readonly gaxgrpc::ApiCall<SearchJobsRequest, SearchJobsResponse> _callSearchJobs;

        private readonly gaxgrpc::ApiCall<SearchJobsRequest, SearchJobsResponse> _callSearchJobsForAlert;

        /// <summary>
        /// Constructs a client wrapper for the JobService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="JobServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public JobServiceClientImpl(JobService.JobServiceClient grpcClient, JobServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            JobServiceSettings effectiveSettings = settings ?? JobServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            BatchCreateJobsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchCreateJobsOperationsSettings, logger);
            BatchUpdateJobsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchUpdateJobsOperationsSettings, logger);
            _callCreateJob = clientHelper.BuildApiCall<CreateJobRequest, Job>("CreateJob", grpcClient.CreateJobAsync, grpcClient.CreateJob, effectiveSettings.CreateJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateJob);
            Modify_CreateJobApiCall(ref _callCreateJob);
            _callBatchCreateJobs = clientHelper.BuildApiCall<BatchCreateJobsRequest, lro::Operation>("BatchCreateJobs", grpcClient.BatchCreateJobsAsync, grpcClient.BatchCreateJobs, effectiveSettings.BatchCreateJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateJobs);
            Modify_BatchCreateJobsApiCall(ref _callBatchCreateJobs);
            _callGetJob = clientHelper.BuildApiCall<GetJobRequest, Job>("GetJob", grpcClient.GetJobAsync, grpcClient.GetJob, effectiveSettings.GetJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetJob);
            Modify_GetJobApiCall(ref _callGetJob);
            _callUpdateJob = clientHelper.BuildApiCall<UpdateJobRequest, Job>("UpdateJob", grpcClient.UpdateJobAsync, grpcClient.UpdateJob, effectiveSettings.UpdateJobSettings).WithGoogleRequestParam("job.name", request => request.Job?.Name);
            Modify_ApiCall(ref _callUpdateJob);
            Modify_UpdateJobApiCall(ref _callUpdateJob);
            _callBatchUpdateJobs = clientHelper.BuildApiCall<BatchUpdateJobsRequest, lro::Operation>("BatchUpdateJobs", grpcClient.BatchUpdateJobsAsync, grpcClient.BatchUpdateJobs, effectiveSettings.BatchUpdateJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateJobs);
            Modify_BatchUpdateJobsApiCall(ref _callBatchUpdateJobs);
            _callDeleteJob = clientHelper.BuildApiCall<DeleteJobRequest, wkt::Empty>("DeleteJob", grpcClient.DeleteJobAsync, grpcClient.DeleteJob, effectiveSettings.DeleteJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteJob);
            Modify_DeleteJobApiCall(ref _callDeleteJob);
            _callBatchDeleteJobs = clientHelper.BuildApiCall<BatchDeleteJobsRequest, wkt::Empty>("BatchDeleteJobs", grpcClient.BatchDeleteJobsAsync, grpcClient.BatchDeleteJobs, effectiveSettings.BatchDeleteJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteJobs);
            Modify_BatchDeleteJobsApiCall(ref _callBatchDeleteJobs);
            _callListJobs = clientHelper.BuildApiCall<ListJobsRequest, ListJobsResponse>("ListJobs", grpcClient.ListJobsAsync, grpcClient.ListJobs, effectiveSettings.ListJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListJobs);
            Modify_ListJobsApiCall(ref _callListJobs);
            _callSearchJobs = clientHelper.BuildApiCall<SearchJobsRequest, SearchJobsResponse>("SearchJobs", grpcClient.SearchJobsAsync, grpcClient.SearchJobs, effectiveSettings.SearchJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchJobs);
            Modify_SearchJobsApiCall(ref _callSearchJobs);
            _callSearchJobsForAlert = clientHelper.BuildApiCall<SearchJobsRequest, SearchJobsResponse>("SearchJobsForAlert", grpcClient.SearchJobsForAlertAsync, grpcClient.SearchJobsForAlert, effectiveSettings.SearchJobsForAlertSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchJobsForAlert);
            Modify_SearchJobsForAlertApiCall(ref _callSearchJobsForAlert);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateJobApiCall(ref gaxgrpc::ApiCall<CreateJobRequest, Job> call);

        partial void Modify_BatchCreateJobsApiCall(ref gaxgrpc::ApiCall<BatchCreateJobsRequest, lro::Operation> call);

        partial void Modify_GetJobApiCall(ref gaxgrpc::ApiCall<GetJobRequest, Job> call);

        partial void Modify_UpdateJobApiCall(ref gaxgrpc::ApiCall<UpdateJobRequest, Job> call);

        partial void Modify_BatchUpdateJobsApiCall(ref gaxgrpc::ApiCall<BatchUpdateJobsRequest, lro::Operation> call);

        partial void Modify_DeleteJobApiCall(ref gaxgrpc::ApiCall<DeleteJobRequest, wkt::Empty> call);

        partial void Modify_BatchDeleteJobsApiCall(ref gaxgrpc::ApiCall<BatchDeleteJobsRequest, wkt::Empty> call);

        partial void Modify_ListJobsApiCall(ref gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> call);

        partial void Modify_SearchJobsApiCall(ref gaxgrpc::ApiCall<SearchJobsRequest, SearchJobsResponse> call);

        partial void Modify_SearchJobsForAlertApiCall(ref gaxgrpc::ApiCall<SearchJobsRequest, SearchJobsResponse> call);

        partial void OnConstruction(JobService.JobServiceClient grpcClient, JobServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC JobService client</summary>
        public override JobService.JobServiceClient GrpcClient { get; }

        partial void Modify_CreateJobRequest(ref CreateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateJobsRequest(ref BatchCreateJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetJobRequest(ref GetJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateJobRequest(ref UpdateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateJobsRequest(ref BatchUpdateJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteJobRequest(ref DeleteJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteJobsRequest(ref BatchDeleteJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListJobsRequest(ref ListJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchJobsRequest(ref SearchJobsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new job.
        /// 
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
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
        /// Creates a new job.
        /// 
        /// Typically, the job becomes searchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> CreateJobAsync(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobRequest(ref request, ref callSettings);
            return _callCreateJob.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchCreateJobs</c>.</summary>
        public override lro::OperationsClient BatchCreateJobsOperationsClient { get; }

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<JobOperationResult, BatchOperationMetadata> BatchCreateJobs(BatchCreateJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateJobsRequest(ref request, ref callSettings);
            return new lro::Operation<JobOperationResult, BatchOperationMetadata>(_callBatchCreateJobs.Sync(request, callSettings), BatchCreateJobsOperationsClient);
        }

        /// <summary>
        /// Begins executing a batch create jobs operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchCreateJobsAsync(BatchCreateJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateJobsRequest(ref request, ref callSettings);
            return new lro::Operation<JobOperationResult, BatchOperationMetadata>(await _callBatchCreateJobs.Async(request, callSettings).ConfigureAwait(false), BatchCreateJobsOperationsClient);
        }

        /// <summary>
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
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
        /// Retrieves the specified job, whose status is OPEN or recently EXPIRED
        /// within the last 90 days.
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
        /// Updates specified job.
        /// 
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
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
        /// Updates specified job.
        /// 
        /// Typically, updated contents become visible in search results within 10
        /// seconds, but it may take up to 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> UpdateJobAsync(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateJobRequest(ref request, ref callSettings);
            return _callUpdateJob.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchUpdateJobs</c>.</summary>
        public override lro::OperationsClient BatchUpdateJobsOperationsClient { get; }

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<JobOperationResult, BatchOperationMetadata> BatchUpdateJobs(BatchUpdateJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateJobsRequest(ref request, ref callSettings);
            return new lro::Operation<JobOperationResult, BatchOperationMetadata>(_callBatchUpdateJobs.Sync(request, callSettings), BatchUpdateJobsOperationsClient);
        }

        /// <summary>
        /// Begins executing a batch update jobs operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<JobOperationResult, BatchOperationMetadata>> BatchUpdateJobsAsync(BatchUpdateJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateJobsRequest(ref request, ref callSettings);
            return new lro::Operation<JobOperationResult, BatchOperationMetadata>(await _callBatchUpdateJobs.Async(request, callSettings).ConfigureAwait(false), BatchUpdateJobsOperationsClient);
        }

        /// <summary>
        /// Deletes the specified job.
        /// 
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteJob(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobRequest(ref request, ref callSettings);
            _callDeleteJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified job.
        /// 
        /// Typically, the job becomes unsearchable within 10 seconds, but it may take
        /// up to 5 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteJobAsync(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobRequest(ref request, ref callSettings);
            return _callDeleteJob.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void BatchDeleteJobs(BatchDeleteJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteJobsRequest(ref request, ref callSettings);
            _callBatchDeleteJobs.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a list of [Job][google.cloud.talent.v4beta1.Job]s by filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task BatchDeleteJobsAsync(BatchDeleteJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteJobsRequest(ref request, ref callSettings);
            return _callBatchDeleteJobs.Async(request, callSettings);
        }

        /// <summary>
        /// Lists jobs by filter.
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
        /// Lists jobs by filter.
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
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        /// 
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs that the caller has permission to
        /// search against.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchJobsResponse SearchJobs(SearchJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchJobsRequest(ref request, ref callSettings);
            return _callSearchJobs.Sync(request, callSettings);
        }

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        /// 
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs that the caller has permission to
        /// search against.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchJobsResponse> SearchJobsAsync(SearchJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchJobsRequest(ref request, ref callSettings);
            return _callSearchJobs.Async(request, callSettings);
        }

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        /// 
        /// This API call is intended for the use case of targeting passive job
        /// seekers (for example, job seekers who have signed up to receive email
        /// alerts about potential job opportunities), and has different algorithmic
        /// adjustments that are targeted to passive job seekers.
        /// 
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs the caller has permission to search
        /// against.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchJobsResponse.Types.MatchingJob"/> resources.</returns>
        public override gax::PagedEnumerable<SearchJobsResponse, SearchJobsResponse.Types.MatchingJob> SearchJobsForAlert(SearchJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchJobsRequest, SearchJobsResponse, SearchJobsResponse.Types.MatchingJob>(_callSearchJobsForAlert, request, callSettings);
        }

        /// <summary>
        /// Searches for jobs using the provided
        /// [SearchJobsRequest][google.cloud.talent.v4beta1.SearchJobsRequest].
        /// 
        /// This API call is intended for the use case of targeting passive job
        /// seekers (for example, job seekers who have signed up to receive email
        /// alerts about potential job opportunities), and has different algorithmic
        /// adjustments that are targeted to passive job seekers.
        /// 
        /// This call constrains the
        /// [visibility][google.cloud.talent.v4beta1.Job.visibility] of jobs present in
        /// the database, and only returns jobs the caller has permission to search
        /// against.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SearchJobsResponse.Types.MatchingJob"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<SearchJobsResponse, SearchJobsResponse.Types.MatchingJob> SearchJobsForAlertAsync(SearchJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchJobsRequest, SearchJobsResponse, SearchJobsResponse.Types.MatchingJob>(_callSearchJobsForAlert, request, callSettings);
        }
    }

    public partial class ListJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListJobsResponse : gaxgrpc::IPageResponse<Job>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Job> GetEnumerator() => Jobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchJobsResponse : gaxgrpc::IPageResponse<SearchJobsResponse.Types.MatchingJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.MatchingJob> GetEnumerator() => MatchingJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class JobService
    {
        public partial class JobServiceClient
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
}
