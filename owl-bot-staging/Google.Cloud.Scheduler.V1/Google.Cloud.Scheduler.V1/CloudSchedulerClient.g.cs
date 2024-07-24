// Copyright 2024 Google LLC
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
using gcl = Google.Cloud.Location;
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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Scheduler.V1
{
    /// <summary>Settings for <see cref="CloudSchedulerClient"/> instances.</summary>
    public sealed partial class CloudSchedulerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudSchedulerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudSchedulerSettings"/>.</returns>
        public static CloudSchedulerSettings GetDefault() => new CloudSchedulerSettings();

        /// <summary>Constructs a new <see cref="CloudSchedulerSettings"/> object with default settings.</summary>
        public CloudSchedulerSettings()
        {
        }

        private CloudSchedulerSettings(CloudSchedulerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListJobsSettings = existing.ListJobsSettings;
            GetJobSettings = existing.GetJobSettings;
            CreateJobSettings = existing.CreateJobSettings;
            UpdateJobSettings = existing.UpdateJobSettings;
            DeleteJobSettings = existing.DeleteJobSettings;
            PauseJobSettings = existing.PauseJobSettings;
            ResumeJobSettings = existing.ResumeJobSettings;
            RunJobSettings = existing.RunJobSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudSchedulerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudSchedulerClient.ListJobs</c> and <c>CloudSchedulerClient.ListJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListJobsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudSchedulerClient.GetJob</c>
        ///  and <c>CloudSchedulerClient.GetJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudSchedulerClient.CreateJob</c> and <c>CloudSchedulerClient.CreateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudSchedulerClient.UpdateJob</c> and <c>CloudSchedulerClient.UpdateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudSchedulerClient.DeleteJob</c> and <c>CloudSchedulerClient.DeleteJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudSchedulerClient.PauseJob</c> and <c>CloudSchedulerClient.PauseJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PauseJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudSchedulerClient.ResumeJob</c> and <c>CloudSchedulerClient.ResumeJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudSchedulerClient.RunJob</c>
        ///  and <c>CloudSchedulerClient.RunJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudSchedulerSettings"/> object.</returns>
        public CloudSchedulerSettings Clone() => new CloudSchedulerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudSchedulerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CloudSchedulerClientBuilder : gaxgrpc::ClientBuilderBase<CloudSchedulerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudSchedulerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudSchedulerClientBuilder() : base(CloudSchedulerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudSchedulerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudSchedulerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudSchedulerClient Build()
        {
            CloudSchedulerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudSchedulerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudSchedulerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudSchedulerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudSchedulerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudSchedulerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudSchedulerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudSchedulerClient.ChannelPool;
    }

    /// <summary>CloudScheduler client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Cloud Scheduler API allows external entities to reliably
    /// schedule asynchronous jobs.
    /// </remarks>
    public abstract partial class CloudSchedulerClient
    {
        /// <summary>
        /// The default endpoint for the CloudScheduler service, which is a host of "cloudscheduler.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudscheduler.googleapis.com:443";

        /// <summary>The default CloudScheduler scopes.</summary>
        /// <remarks>
        /// The default CloudScheduler scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudScheduler.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudSchedulerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudSchedulerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudSchedulerClient"/>.</returns>
        public static stt::Task<CloudSchedulerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudSchedulerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudSchedulerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudSchedulerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudSchedulerClient"/>.</returns>
        public static CloudSchedulerClient Create() => new CloudSchedulerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudSchedulerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudSchedulerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudSchedulerClient"/>.</returns>
        internal static CloudSchedulerClient Create(grpccore::CallInvoker callInvoker, CloudSchedulerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudScheduler.CloudSchedulerClient grpcClient = new CloudScheduler.CloudSchedulerClient(callInvoker);
            return new CloudSchedulerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudScheduler client</summary>
        public virtual CloudScheduler.CloudSchedulerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
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
        /// Lists jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
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
        /// Lists jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
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
        /// Lists jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
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
        /// Gets a job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, st::CancellationToken cancellationToken) =>
            GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a job.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJob(new GetJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a job.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobAsync(new GetJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a job.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a job.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJob(new GetJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a job.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobAsync(new GetJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a job.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            GetJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job CreateJob(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(CreateJobRequest request, st::CancellationToken cancellationToken) =>
            CreateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a job.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
        /// </param>
        /// <param name="job">
        /// Required. The job to add. The user can optionally specify a name for the
        /// job in [name][google.cloud.scheduler.v1.Job.name].
        /// [name][google.cloud.scheduler.v1.Job.name] cannot be the same as an
        /// existing job. If a name is not specified then the system will
        /// generate a random unique name that will be returned
        /// ([name][google.cloud.scheduler.v1.Job.name]) in the response.
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
        /// Creates a job.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
        /// </param>
        /// <param name="job">
        /// Required. The job to add. The user can optionally specify a name for the
        /// job in [name][google.cloud.scheduler.v1.Job.name].
        /// [name][google.cloud.scheduler.v1.Job.name] cannot be the same as an
        /// existing job. If a name is not specified then the system will
        /// generate a random unique name that will be returned
        /// ([name][google.cloud.scheduler.v1.Job.name]) in the response.
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
        /// Creates a job.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
        /// </param>
        /// <param name="job">
        /// Required. The job to add. The user can optionally specify a name for the
        /// job in [name][google.cloud.scheduler.v1.Job.name].
        /// [name][google.cloud.scheduler.v1.Job.name] cannot be the same as an
        /// existing job. If a name is not specified then the system will
        /// generate a random unique name that will be returned
        /// ([name][google.cloud.scheduler.v1.Job.name]) in the response.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(string parent, Job job, st::CancellationToken cancellationToken) =>
            CreateJobAsync(parent, job, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a job.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
        /// </param>
        /// <param name="job">
        /// Required. The job to add. The user can optionally specify a name for the
        /// job in [name][google.cloud.scheduler.v1.Job.name].
        /// [name][google.cloud.scheduler.v1.Job.name] cannot be the same as an
        /// existing job. If a name is not specified then the system will
        /// generate a random unique name that will be returned
        /// ([name][google.cloud.scheduler.v1.Job.name]) in the response.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job CreateJob(gagr::LocationName parent, Job job, gaxgrpc::CallSettings callSettings = null) =>
            CreateJob(new CreateJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Creates a job.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
        /// </param>
        /// <param name="job">
        /// Required. The job to add. The user can optionally specify a name for the
        /// job in [name][google.cloud.scheduler.v1.Job.name].
        /// [name][google.cloud.scheduler.v1.Job.name] cannot be the same as an
        /// existing job. If a name is not specified then the system will
        /// generate a random unique name that will be returned
        /// ([name][google.cloud.scheduler.v1.Job.name]) in the response.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(gagr::LocationName parent, Job job, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobAsync(new CreateJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Creates a job.
        /// </summary>
        /// <param name="parent">
        /// Required. The location name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID`.
        /// </param>
        /// <param name="job">
        /// Required. The job to add. The user can optionally specify a name for the
        /// job in [name][google.cloud.scheduler.v1.Job.name].
        /// [name][google.cloud.scheduler.v1.Job.name] cannot be the same as an
        /// existing job. If a name is not specified then the system will
        /// generate a random unique name that will be returned
        /// ([name][google.cloud.scheduler.v1.Job.name]) in the response.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(gagr::LocationName parent, Job job, st::CancellationToken cancellationToken) =>
            CreateJobAsync(parent, job, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a job.
        /// 
        /// If successful, the updated [Job][google.cloud.scheduler.v1.Job] is
        /// returned. If the job does not exist, `NOT_FOUND` is returned.
        /// 
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an
        /// [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1.Job.State.UPDATE_FAILED]
        /// state. A job in this state may not be executed. If this happens, retry the
        /// UpdateJob request until a successful response is received.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job UpdateJob(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a job.
        /// 
        /// If successful, the updated [Job][google.cloud.scheduler.v1.Job] is
        /// returned. If the job does not exist, `NOT_FOUND` is returned.
        /// 
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an
        /// [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1.Job.State.UPDATE_FAILED]
        /// state. A job in this state may not be executed. If this happens, retry the
        /// UpdateJob request until a successful response is received.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(UpdateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a job.
        /// 
        /// If successful, the updated [Job][google.cloud.scheduler.v1.Job] is
        /// returned. If the job does not exist, `NOT_FOUND` is returned.
        /// 
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an
        /// [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1.Job.State.UPDATE_FAILED]
        /// state. A job in this state may not be executed. If this happens, retry the
        /// UpdateJob request until a successful response is received.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(UpdateJobRequest request, st::CancellationToken cancellationToken) =>
            UpdateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a job.
        /// 
        /// If successful, the updated [Job][google.cloud.scheduler.v1.Job] is
        /// returned. If the job does not exist, `NOT_FOUND` is returned.
        /// 
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an
        /// [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1.Job.State.UPDATE_FAILED]
        /// state. A job in this state may not be executed. If this happens, retry the
        /// UpdateJob request until a successful response is received.
        /// </summary>
        /// <param name="job">
        /// Required. The new job properties.
        /// [name][google.cloud.scheduler.v1.Job.name] must be specified.
        /// 
        /// Output only fields cannot be modified using UpdateJob.
        /// Any value specified for an output only field will be ignored.
        /// </param>
        /// <param name="updateMask">
        /// A  mask used to specify which fields of the job are being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job UpdateJob(Job job, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateJob(new UpdateJobRequest
            {
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a job.
        /// 
        /// If successful, the updated [Job][google.cloud.scheduler.v1.Job] is
        /// returned. If the job does not exist, `NOT_FOUND` is returned.
        /// 
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an
        /// [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1.Job.State.UPDATE_FAILED]
        /// state. A job in this state may not be executed. If this happens, retry the
        /// UpdateJob request until a successful response is received.
        /// </summary>
        /// <param name="job">
        /// Required. The new job properties.
        /// [name][google.cloud.scheduler.v1.Job.name] must be specified.
        /// 
        /// Output only fields cannot be modified using UpdateJob.
        /// Any value specified for an output only field will be ignored.
        /// </param>
        /// <param name="updateMask">
        /// A  mask used to specify which fields of the job are being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(Job job, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateJobAsync(new UpdateJobRequest
            {
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a job.
        /// 
        /// If successful, the updated [Job][google.cloud.scheduler.v1.Job] is
        /// returned. If the job does not exist, `NOT_FOUND` is returned.
        /// 
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an
        /// [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1.Job.State.UPDATE_FAILED]
        /// state. A job in this state may not be executed. If this happens, retry the
        /// UpdateJob request until a successful response is received.
        /// </summary>
        /// <param name="job">
        /// Required. The new job properties.
        /// [name][google.cloud.scheduler.v1.Job.name] must be specified.
        /// 
        /// Output only fields cannot be modified using UpdateJob.
        /// Any value specified for an output only field will be ignored.
        /// </param>
        /// <param name="updateMask">
        /// A  mask used to specify which fields of the job are being updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> UpdateJobAsync(Job job, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateJobAsync(job, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteJob(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(DeleteJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(DeleteJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJob(new DeleteJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobAsync(new DeleteJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJob(new DeleteJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobAsync(new DeleteJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses a job.
        /// 
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via
        /// [ResumeJob][google.cloud.scheduler.v1.CloudScheduler.ResumeJob]. The state
        /// of the job is stored in [state][google.cloud.scheduler.v1.Job.state]; if
        /// paused it will be set to
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. A job must
        /// be in [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED] to
        /// be paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job PauseJob(PauseJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses a job.
        /// 
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via
        /// [ResumeJob][google.cloud.scheduler.v1.CloudScheduler.ResumeJob]. The state
        /// of the job is stored in [state][google.cloud.scheduler.v1.Job.state]; if
        /// paused it will be set to
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. A job must
        /// be in [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED] to
        /// be paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> PauseJobAsync(PauseJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses a job.
        /// 
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via
        /// [ResumeJob][google.cloud.scheduler.v1.CloudScheduler.ResumeJob]. The state
        /// of the job is stored in [state][google.cloud.scheduler.v1.Job.state]; if
        /// paused it will be set to
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. A job must
        /// be in [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED] to
        /// be paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> PauseJobAsync(PauseJobRequest request, st::CancellationToken cancellationToken) =>
            PauseJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses a job.
        /// 
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via
        /// [ResumeJob][google.cloud.scheduler.v1.CloudScheduler.ResumeJob]. The state
        /// of the job is stored in [state][google.cloud.scheduler.v1.Job.state]; if
        /// paused it will be set to
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. A job must
        /// be in [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED] to
        /// be paused.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job PauseJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseJob(new PauseJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses a job.
        /// 
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via
        /// [ResumeJob][google.cloud.scheduler.v1.CloudScheduler.ResumeJob]. The state
        /// of the job is stored in [state][google.cloud.scheduler.v1.Job.state]; if
        /// paused it will be set to
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. A job must
        /// be in [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED] to
        /// be paused.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> PauseJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseJobAsync(new PauseJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses a job.
        /// 
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via
        /// [ResumeJob][google.cloud.scheduler.v1.CloudScheduler.ResumeJob]. The state
        /// of the job is stored in [state][google.cloud.scheduler.v1.Job.state]; if
        /// paused it will be set to
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. A job must
        /// be in [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED] to
        /// be paused.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> PauseJobAsync(string name, st::CancellationToken cancellationToken) =>
            PauseJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses a job.
        /// 
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via
        /// [ResumeJob][google.cloud.scheduler.v1.CloudScheduler.ResumeJob]. The state
        /// of the job is stored in [state][google.cloud.scheduler.v1.Job.state]; if
        /// paused it will be set to
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. A job must
        /// be in [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED] to
        /// be paused.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job PauseJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseJob(new PauseJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses a job.
        /// 
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via
        /// [ResumeJob][google.cloud.scheduler.v1.CloudScheduler.ResumeJob]. The state
        /// of the job is stored in [state][google.cloud.scheduler.v1.Job.state]; if
        /// paused it will be set to
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. A job must
        /// be in [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED] to
        /// be paused.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> PauseJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseJobAsync(new PauseJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses a job.
        /// 
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via
        /// [ResumeJob][google.cloud.scheduler.v1.CloudScheduler.ResumeJob]. The state
        /// of the job is stored in [state][google.cloud.scheduler.v1.Job.state]; if
        /// paused it will be set to
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. A job must
        /// be in [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED] to
        /// be paused.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> PauseJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            PauseJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resume a job.
        /// 
        /// This method reenables a job after it has been
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. The state
        /// of a job is stored in [Job.state][google.cloud.scheduler.v1.Job.state];
        /// after calling this method it will be set to
        /// [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED]. A job
        /// must be in [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]
        /// to be resumed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job ResumeJob(ResumeJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resume a job.
        /// 
        /// This method reenables a job after it has been
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. The state
        /// of a job is stored in [Job.state][google.cloud.scheduler.v1.Job.state];
        /// after calling this method it will be set to
        /// [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED]. A job
        /// must be in [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]
        /// to be resumed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> ResumeJobAsync(ResumeJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resume a job.
        /// 
        /// This method reenables a job after it has been
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. The state
        /// of a job is stored in [Job.state][google.cloud.scheduler.v1.Job.state];
        /// after calling this method it will be set to
        /// [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED]. A job
        /// must be in [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]
        /// to be resumed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> ResumeJobAsync(ResumeJobRequest request, st::CancellationToken cancellationToken) =>
            ResumeJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resume a job.
        /// 
        /// This method reenables a job after it has been
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. The state
        /// of a job is stored in [Job.state][google.cloud.scheduler.v1.Job.state];
        /// after calling this method it will be set to
        /// [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED]. A job
        /// must be in [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]
        /// to be resumed.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job ResumeJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeJob(new ResumeJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resume a job.
        /// 
        /// This method reenables a job after it has been
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. The state
        /// of a job is stored in [Job.state][google.cloud.scheduler.v1.Job.state];
        /// after calling this method it will be set to
        /// [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED]. A job
        /// must be in [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]
        /// to be resumed.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> ResumeJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeJobAsync(new ResumeJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resume a job.
        /// 
        /// This method reenables a job after it has been
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. The state
        /// of a job is stored in [Job.state][google.cloud.scheduler.v1.Job.state];
        /// after calling this method it will be set to
        /// [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED]. A job
        /// must be in [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]
        /// to be resumed.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> ResumeJobAsync(string name, st::CancellationToken cancellationToken) =>
            ResumeJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resume a job.
        /// 
        /// This method reenables a job after it has been
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. The state
        /// of a job is stored in [Job.state][google.cloud.scheduler.v1.Job.state];
        /// after calling this method it will be set to
        /// [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED]. A job
        /// must be in [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]
        /// to be resumed.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job ResumeJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeJob(new ResumeJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resume a job.
        /// 
        /// This method reenables a job after it has been
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. The state
        /// of a job is stored in [Job.state][google.cloud.scheduler.v1.Job.state];
        /// after calling this method it will be set to
        /// [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED]. A job
        /// must be in [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]
        /// to be resumed.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> ResumeJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeJobAsync(new ResumeJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resume a job.
        /// 
        /// This method reenables a job after it has been
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. The state
        /// of a job is stored in [Job.state][google.cloud.scheduler.v1.Job.state];
        /// after calling this method it will be set to
        /// [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED]. A job
        /// must be in [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]
        /// to be resumed.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> ResumeJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            ResumeJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Forces a job to run now.
        /// 
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job RunJob(RunJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Forces a job to run now.
        /// 
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> RunJobAsync(RunJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Forces a job to run now.
        /// 
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> RunJobAsync(RunJobRequest request, st::CancellationToken cancellationToken) =>
            RunJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Forces a job to run now.
        /// 
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job RunJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            RunJob(new RunJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Forces a job to run now.
        /// 
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> RunJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RunJobAsync(new RunJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Forces a job to run now.
        /// 
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> RunJobAsync(string name, st::CancellationToken cancellationToken) =>
            RunJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Forces a job to run now.
        /// 
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job RunJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            RunJob(new RunJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Forces a job to run now.
        /// 
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> RunJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            RunJobAsync(new RunJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Forces a job to run now.
        /// 
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
        /// </summary>
        /// <param name="name">
        /// Required. The job name. For example:
        /// `projects/PROJECT_ID/locations/LOCATION_ID/jobs/JOB_ID`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> RunJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            RunJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CloudScheduler client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Cloud Scheduler API allows external entities to reliably
    /// schedule asynchronous jobs.
    /// </remarks>
    public sealed partial class CloudSchedulerClientImpl : CloudSchedulerClient
    {
        private readonly gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> _callListJobs;

        private readonly gaxgrpc::ApiCall<GetJobRequest, Job> _callGetJob;

        private readonly gaxgrpc::ApiCall<CreateJobRequest, Job> _callCreateJob;

        private readonly gaxgrpc::ApiCall<UpdateJobRequest, Job> _callUpdateJob;

        private readonly gaxgrpc::ApiCall<DeleteJobRequest, wkt::Empty> _callDeleteJob;

        private readonly gaxgrpc::ApiCall<PauseJobRequest, Job> _callPauseJob;

        private readonly gaxgrpc::ApiCall<ResumeJobRequest, Job> _callResumeJob;

        private readonly gaxgrpc::ApiCall<RunJobRequest, Job> _callRunJob;

        /// <summary>
        /// Constructs a client wrapper for the CloudScheduler service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudSchedulerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudSchedulerClientImpl(CloudScheduler.CloudSchedulerClient grpcClient, CloudSchedulerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudSchedulerSettings effectiveSettings = settings ?? CloudSchedulerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListJobs = clientHelper.BuildApiCall<ListJobsRequest, ListJobsResponse>("ListJobs", grpcClient.ListJobsAsync, grpcClient.ListJobs, effectiveSettings.ListJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListJobs);
            Modify_ListJobsApiCall(ref _callListJobs);
            _callGetJob = clientHelper.BuildApiCall<GetJobRequest, Job>("GetJob", grpcClient.GetJobAsync, grpcClient.GetJob, effectiveSettings.GetJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetJob);
            Modify_GetJobApiCall(ref _callGetJob);
            _callCreateJob = clientHelper.BuildApiCall<CreateJobRequest, Job>("CreateJob", grpcClient.CreateJobAsync, grpcClient.CreateJob, effectiveSettings.CreateJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateJob);
            Modify_CreateJobApiCall(ref _callCreateJob);
            _callUpdateJob = clientHelper.BuildApiCall<UpdateJobRequest, Job>("UpdateJob", grpcClient.UpdateJobAsync, grpcClient.UpdateJob, effectiveSettings.UpdateJobSettings).WithGoogleRequestParam("job.name", request => request.Job?.Name);
            Modify_ApiCall(ref _callUpdateJob);
            Modify_UpdateJobApiCall(ref _callUpdateJob);
            _callDeleteJob = clientHelper.BuildApiCall<DeleteJobRequest, wkt::Empty>("DeleteJob", grpcClient.DeleteJobAsync, grpcClient.DeleteJob, effectiveSettings.DeleteJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteJob);
            Modify_DeleteJobApiCall(ref _callDeleteJob);
            _callPauseJob = clientHelper.BuildApiCall<PauseJobRequest, Job>("PauseJob", grpcClient.PauseJobAsync, grpcClient.PauseJob, effectiveSettings.PauseJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPauseJob);
            Modify_PauseJobApiCall(ref _callPauseJob);
            _callResumeJob = clientHelper.BuildApiCall<ResumeJobRequest, Job>("ResumeJob", grpcClient.ResumeJobAsync, grpcClient.ResumeJob, effectiveSettings.ResumeJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumeJob);
            Modify_ResumeJobApiCall(ref _callResumeJob);
            _callRunJob = clientHelper.BuildApiCall<RunJobRequest, Job>("RunJob", grpcClient.RunJobAsync, grpcClient.RunJob, effectiveSettings.RunJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRunJob);
            Modify_RunJobApiCall(ref _callRunJob);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListJobsApiCall(ref gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> call);

        partial void Modify_GetJobApiCall(ref gaxgrpc::ApiCall<GetJobRequest, Job> call);

        partial void Modify_CreateJobApiCall(ref gaxgrpc::ApiCall<CreateJobRequest, Job> call);

        partial void Modify_UpdateJobApiCall(ref gaxgrpc::ApiCall<UpdateJobRequest, Job> call);

        partial void Modify_DeleteJobApiCall(ref gaxgrpc::ApiCall<DeleteJobRequest, wkt::Empty> call);

        partial void Modify_PauseJobApiCall(ref gaxgrpc::ApiCall<PauseJobRequest, Job> call);

        partial void Modify_ResumeJobApiCall(ref gaxgrpc::ApiCall<ResumeJobRequest, Job> call);

        partial void Modify_RunJobApiCall(ref gaxgrpc::ApiCall<RunJobRequest, Job> call);

        partial void OnConstruction(CloudScheduler.CloudSchedulerClient grpcClient, CloudSchedulerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudScheduler client</summary>
        public override CloudScheduler.CloudSchedulerClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListJobsRequest(ref ListJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetJobRequest(ref GetJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateJobRequest(ref CreateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateJobRequest(ref UpdateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteJobRequest(ref DeleteJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PauseJobRequest(ref PauseJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeJobRequest(ref ResumeJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunJobRequest(ref RunJobRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists jobs.
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
        /// Lists jobs.
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
        /// Gets a job.
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
        /// Gets a job.
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
        /// Creates a job.
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
        /// Creates a job.
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
        /// Updates a job.
        /// 
        /// If successful, the updated [Job][google.cloud.scheduler.v1.Job] is
        /// returned. If the job does not exist, `NOT_FOUND` is returned.
        /// 
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an
        /// [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1.Job.State.UPDATE_FAILED]
        /// state. A job in this state may not be executed. If this happens, retry the
        /// UpdateJob request until a successful response is received.
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
        /// Updates a job.
        /// 
        /// If successful, the updated [Job][google.cloud.scheduler.v1.Job] is
        /// returned. If the job does not exist, `NOT_FOUND` is returned.
        /// 
        /// If UpdateJob does not successfully return, it is possible for the
        /// job to be in an
        /// [Job.State.UPDATE_FAILED][google.cloud.scheduler.v1.Job.State.UPDATE_FAILED]
        /// state. A job in this state may not be executed. If this happens, retry the
        /// UpdateJob request until a successful response is received.
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
        /// Deletes a job.
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
        /// Deletes a job.
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
        /// Pauses a job.
        /// 
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via
        /// [ResumeJob][google.cloud.scheduler.v1.CloudScheduler.ResumeJob]. The state
        /// of the job is stored in [state][google.cloud.scheduler.v1.Job.state]; if
        /// paused it will be set to
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. A job must
        /// be in [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED] to
        /// be paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Job PauseJob(PauseJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseJobRequest(ref request, ref callSettings);
            return _callPauseJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Pauses a job.
        /// 
        /// If a job is paused then the system will stop executing the job
        /// until it is re-enabled via
        /// [ResumeJob][google.cloud.scheduler.v1.CloudScheduler.ResumeJob]. The state
        /// of the job is stored in [state][google.cloud.scheduler.v1.Job.state]; if
        /// paused it will be set to
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. A job must
        /// be in [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED] to
        /// be paused.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> PauseJobAsync(PauseJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseJobRequest(ref request, ref callSettings);
            return _callPauseJob.Async(request, callSettings);
        }

        /// <summary>
        /// Resume a job.
        /// 
        /// This method reenables a job after it has been
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. The state
        /// of a job is stored in [Job.state][google.cloud.scheduler.v1.Job.state];
        /// after calling this method it will be set to
        /// [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED]. A job
        /// must be in [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]
        /// to be resumed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Job ResumeJob(ResumeJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeJobRequest(ref request, ref callSettings);
            return _callResumeJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Resume a job.
        /// 
        /// This method reenables a job after it has been
        /// [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]. The state
        /// of a job is stored in [Job.state][google.cloud.scheduler.v1.Job.state];
        /// after calling this method it will be set to
        /// [Job.State.ENABLED][google.cloud.scheduler.v1.Job.State.ENABLED]. A job
        /// must be in [Job.State.PAUSED][google.cloud.scheduler.v1.Job.State.PAUSED]
        /// to be resumed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> ResumeJobAsync(ResumeJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeJobRequest(ref request, ref callSettings);
            return _callResumeJob.Async(request, callSettings);
        }

        /// <summary>
        /// Forces a job to run now.
        /// 
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Job RunJob(RunJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunJobRequest(ref request, ref callSettings);
            return _callRunJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Forces a job to run now.
        /// 
        /// When this method is called, Cloud Scheduler will dispatch the job, even
        /// if the job is already running.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> RunJobAsync(RunJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunJobRequest(ref request, ref callSettings);
            return _callRunJob.Async(request, callSettings);
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

    public static partial class CloudScheduler
    {
        public partial class CloudSchedulerClient
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
