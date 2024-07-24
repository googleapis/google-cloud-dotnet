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

namespace Google.Cloud.Video.Transcoder.V1
{
    /// <summary>Settings for <see cref="TranscoderServiceClient"/> instances.</summary>
    public sealed partial class TranscoderServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TranscoderServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TranscoderServiceSettings"/>.</returns>
        public static TranscoderServiceSettings GetDefault() => new TranscoderServiceSettings();

        /// <summary>Constructs a new <see cref="TranscoderServiceSettings"/> object with default settings.</summary>
        public TranscoderServiceSettings()
        {
        }

        private TranscoderServiceSettings(TranscoderServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateJobSettings = existing.CreateJobSettings;
            ListJobsSettings = existing.ListJobsSettings;
            GetJobSettings = existing.GetJobSettings;
            DeleteJobSettings = existing.DeleteJobSettings;
            CreateJobTemplateSettings = existing.CreateJobTemplateSettings;
            ListJobTemplatesSettings = existing.ListJobTemplatesSettings;
            GetJobTemplateSettings = existing.GetJobTemplateSettings;
            DeleteJobTemplateSettings = existing.DeleteJobTemplateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TranscoderServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranscoderServiceClient.CreateJob</c> and <c>TranscoderServiceClient.CreateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranscoderServiceClient.ListJobs</c> and <c>TranscoderServiceClient.ListJobsAsync</c>.
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
        /// <c>TranscoderServiceClient.GetJob</c> and <c>TranscoderServiceClient.GetJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranscoderServiceClient.DeleteJob</c> and <c>TranscoderServiceClient.DeleteJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranscoderServiceClient.CreateJobTemplate</c> and <c>TranscoderServiceClient.CreateJobTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateJobTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranscoderServiceClient.ListJobTemplates</c> and <c>TranscoderServiceClient.ListJobTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListJobTemplatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranscoderServiceClient.GetJobTemplate</c> and <c>TranscoderServiceClient.GetJobTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetJobTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranscoderServiceClient.DeleteJobTemplate</c> and <c>TranscoderServiceClient.DeleteJobTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteJobTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TranscoderServiceSettings"/> object.</returns>
        public TranscoderServiceSettings Clone() => new TranscoderServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TranscoderServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class TranscoderServiceClientBuilder : gaxgrpc::ClientBuilderBase<TranscoderServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TranscoderServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TranscoderServiceClientBuilder() : base(TranscoderServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TranscoderServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TranscoderServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TranscoderServiceClient Build()
        {
            TranscoderServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TranscoderServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TranscoderServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TranscoderServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TranscoderServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TranscoderServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TranscoderServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TranscoderServiceClient.ChannelPool;
    }

    /// <summary>TranscoderService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Using the Transcoder API, you can queue asynchronous jobs for transcoding
    /// media into various output formats. Output formats may include different
    /// streaming standards such as HTTP Live Streaming (HLS) and Dynamic Adaptive
    /// Streaming over HTTP (DASH). You can also customize jobs using advanced
    /// features such as Digital Rights Management (DRM), audio equalization, content
    /// concatenation, and digital ad-stitch ready content generation.
    /// </remarks>
    public abstract partial class TranscoderServiceClient
    {
        /// <summary>
        /// The default endpoint for the TranscoderService service, which is a host of "transcoder.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "transcoder.googleapis.com:443";

        /// <summary>The default TranscoderService scopes.</summary>
        /// <remarks>
        /// The default TranscoderService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TranscoderService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TranscoderServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TranscoderServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TranscoderServiceClient"/>.</returns>
        public static stt::Task<TranscoderServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TranscoderServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TranscoderServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TranscoderServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TranscoderServiceClient"/>.</returns>
        public static TranscoderServiceClient Create() => new TranscoderServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TranscoderServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TranscoderServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TranscoderServiceClient"/>.</returns>
        internal static TranscoderServiceClient Create(grpccore::CallInvoker callInvoker, TranscoderServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TranscoderService.TranscoderServiceClient grpcClient = new TranscoderService.TranscoderServiceClient(callInvoker);
            return new TranscoderServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TranscoderService client</summary>
        public virtual TranscoderService.TranscoderServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a job in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job CreateJob(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a job in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(CreateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a job in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(CreateJobRequest request, st::CancellationToken cancellationToken) =>
            CreateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a job in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to create and process this job.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="job">
        /// Required. Parameters for creating transcoding job.
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
        /// Creates a job in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to create and process this job.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="job">
        /// Required. Parameters for creating transcoding job.
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
        /// Creates a job in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to create and process this job.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="job">
        /// Required. Parameters for creating transcoding job.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(string parent, Job job, st::CancellationToken cancellationToken) =>
            CreateJobAsync(parent, job, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a job in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to create and process this job.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="job">
        /// Required. Parameters for creating transcoding job.
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
        /// Creates a job in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to create and process this job.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="job">
        /// Required. Parameters for creating transcoding job.
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
        /// Creates a job in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to create and process this job.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="job">
        /// Required. Parameters for creating transcoding job.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobAsync(gagr::LocationName parent, Job job, st::CancellationToken cancellationToken) =>
            CreateJobAsync(parent, job, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists jobs in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobsResponse, Job> ListJobs(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists jobs in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Job"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobsResponse, Job> ListJobsAsync(ListJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists jobs in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project}/locations/{location}`
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
        /// Lists jobs in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project}/locations/{location}`
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
        /// Lists jobs in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project}/locations/{location}`
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
        /// Lists jobs in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project}/locations/{location}`
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
        /// Returns the job data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the job data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the job data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(GetJobRequest request, st::CancellationToken cancellationToken) =>
            GetJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the job data.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job to retrieve.
        /// Format: `projects/{project}/locations/{location}/jobs/{job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJob(new GetJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the job data.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job to retrieve.
        /// Format: `projects/{project}/locations/{location}/jobs/{job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobAsync(new GetJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the job data.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job to retrieve.
        /// Format: `projects/{project}/locations/{location}/jobs/{job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the job data.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job to retrieve.
        /// Format: `projects/{project}/locations/{location}/jobs/{job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job GetJob(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJob(new GetJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the job data.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job to retrieve.
        /// Format: `projects/{project}/locations/{location}/jobs/{job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(JobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobAsync(new GetJobRequest
            {
                JobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the job data.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job to retrieve.
        /// Format: `projects/{project}/locations/{location}/jobs/{job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> GetJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            GetJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. The name of the job to delete.
        /// Format: `projects/{project}/locations/{location}/jobs/{job}`
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
        /// Required. The name of the job to delete.
        /// Format: `projects/{project}/locations/{location}/jobs/{job}`
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
        /// Required. The name of the job to delete.
        /// Format: `projects/{project}/locations/{location}/jobs/{job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a job.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job to delete.
        /// Format: `projects/{project}/locations/{location}/jobs/{job}`
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
        /// Required. The name of the job to delete.
        /// Format: `projects/{project}/locations/{location}/jobs/{job}`
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
        /// Required. The name of the job to delete.
        /// Format: `projects/{project}/locations/{location}/jobs/{job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobAsync(JobName name, st::CancellationToken cancellationToken) =>
            DeleteJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a job template in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTemplate CreateJobTemplate(CreateJobTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a job template in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTemplate> CreateJobTemplateAsync(CreateJobTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a job template in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTemplate> CreateJobTemplateAsync(CreateJobTemplateRequest request, st::CancellationToken cancellationToken) =>
            CreateJobTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a job template in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to create this job template.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="jobTemplate">
        /// Required. Parameters for creating job template.
        /// </param>
        /// <param name="jobTemplateId">
        /// Required. The ID to use for the job template, which will become the final
        /// component of the job template's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters must match the
        /// regular expression `[a-zA-Z][a-zA-Z0-9_-]*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTemplate CreateJobTemplate(string parent, JobTemplate jobTemplate, string jobTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobTemplate(new CreateJobTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                JobTemplate = gax::GaxPreconditions.CheckNotNull(jobTemplate, nameof(jobTemplate)),
                JobTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobTemplateId, nameof(jobTemplateId)),
            }, callSettings);

        /// <summary>
        /// Creates a job template in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to create this job template.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="jobTemplate">
        /// Required. Parameters for creating job template.
        /// </param>
        /// <param name="jobTemplateId">
        /// Required. The ID to use for the job template, which will become the final
        /// component of the job template's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters must match the
        /// regular expression `[a-zA-Z][a-zA-Z0-9_-]*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTemplate> CreateJobTemplateAsync(string parent, JobTemplate jobTemplate, string jobTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobTemplateAsync(new CreateJobTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                JobTemplate = gax::GaxPreconditions.CheckNotNull(jobTemplate, nameof(jobTemplate)),
                JobTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobTemplateId, nameof(jobTemplateId)),
            }, callSettings);

        /// <summary>
        /// Creates a job template in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to create this job template.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="jobTemplate">
        /// Required. Parameters for creating job template.
        /// </param>
        /// <param name="jobTemplateId">
        /// Required. The ID to use for the job template, which will become the final
        /// component of the job template's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters must match the
        /// regular expression `[a-zA-Z][a-zA-Z0-9_-]*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTemplate> CreateJobTemplateAsync(string parent, JobTemplate jobTemplate, string jobTemplateId, st::CancellationToken cancellationToken) =>
            CreateJobTemplateAsync(parent, jobTemplate, jobTemplateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a job template in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to create this job template.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="jobTemplate">
        /// Required. Parameters for creating job template.
        /// </param>
        /// <param name="jobTemplateId">
        /// Required. The ID to use for the job template, which will become the final
        /// component of the job template's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters must match the
        /// regular expression `[a-zA-Z][a-zA-Z0-9_-]*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTemplate CreateJobTemplate(gagr::LocationName parent, JobTemplate jobTemplate, string jobTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobTemplate(new CreateJobTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                JobTemplate = gax::GaxPreconditions.CheckNotNull(jobTemplate, nameof(jobTemplate)),
                JobTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobTemplateId, nameof(jobTemplateId)),
            }, callSettings);

        /// <summary>
        /// Creates a job template in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to create this job template.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="jobTemplate">
        /// Required. Parameters for creating job template.
        /// </param>
        /// <param name="jobTemplateId">
        /// Required. The ID to use for the job template, which will become the final
        /// component of the job template's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters must match the
        /// regular expression `[a-zA-Z][a-zA-Z0-9_-]*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTemplate> CreateJobTemplateAsync(gagr::LocationName parent, JobTemplate jobTemplate, string jobTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobTemplateAsync(new CreateJobTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                JobTemplate = gax::GaxPreconditions.CheckNotNull(jobTemplate, nameof(jobTemplate)),
                JobTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobTemplateId, nameof(jobTemplateId)),
            }, callSettings);

        /// <summary>
        /// Creates a job template in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to create this job template.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="jobTemplate">
        /// Required. Parameters for creating job template.
        /// </param>
        /// <param name="jobTemplateId">
        /// Required. The ID to use for the job template, which will become the final
        /// component of the job template's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters must match the
        /// regular expression `[a-zA-Z][a-zA-Z0-9_-]*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTemplate> CreateJobTemplateAsync(gagr::LocationName parent, JobTemplate jobTemplate, string jobTemplateId, st::CancellationToken cancellationToken) =>
            CreateJobTemplateAsync(parent, jobTemplate, jobTemplateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists job templates in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="JobTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobTemplatesResponse, JobTemplate> ListJobTemplates(ListJobTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists job templates in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="JobTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobTemplatesResponse, JobTemplate> ListJobTemplatesAsync(ListJobTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists job templates in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location from which to retrieve the collection of job
        /// templates. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="JobTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobTemplatesResponse, JobTemplate> ListJobTemplates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobTemplatesRequest request = new ListJobTemplatesRequest
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
            return ListJobTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists job templates in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location from which to retrieve the collection of job
        /// templates. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="JobTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobTemplatesResponse, JobTemplate> ListJobTemplatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobTemplatesRequest request = new ListJobTemplatesRequest
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
            return ListJobTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists job templates in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location from which to retrieve the collection of job
        /// templates. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="JobTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobTemplatesResponse, JobTemplate> ListJobTemplates(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobTemplatesRequest request = new ListJobTemplatesRequest
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
            return ListJobTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists job templates in the specified region.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location from which to retrieve the collection of job
        /// templates. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="JobTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobTemplatesResponse, JobTemplate> ListJobTemplatesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobTemplatesRequest request = new ListJobTemplatesRequest
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
            return ListJobTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the job template data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTemplate GetJobTemplate(GetJobTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the job template data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTemplate> GetJobTemplateAsync(GetJobTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the job template data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTemplate> GetJobTemplateAsync(GetJobTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetJobTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the job template data.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job template to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTemplate GetJobTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobTemplate(new GetJobTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the job template data.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job template to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTemplate> GetJobTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobTemplateAsync(new GetJobTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the job template data.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job template to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTemplate> GetJobTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetJobTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the job template data.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job template to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTemplate GetJobTemplate(JobTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobTemplate(new GetJobTemplateRequest
            {
                JobTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the job template data.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job template to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTemplate> GetJobTemplateAsync(JobTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobTemplateAsync(new GetJobTemplateRequest
            {
                JobTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the job template data.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job template to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTemplate> GetJobTemplateAsync(JobTemplateName name, st::CancellationToken cancellationToken) =>
            GetJobTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a job template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteJobTemplate(DeleteJobTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a job template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobTemplateAsync(DeleteJobTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a job template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobTemplateAsync(DeleteJobTemplateRequest request, st::CancellationToken cancellationToken) =>
            DeleteJobTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a job template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job template to delete.
        /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteJobTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobTemplate(new DeleteJobTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a job template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job template to delete.
        /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobTemplateAsync(new DeleteJobTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a job template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job template to delete.
        /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteJobTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a job template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job template to delete.
        /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteJobTemplate(JobTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobTemplate(new DeleteJobTemplateRequest
            {
                JobTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a job template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job template to delete.
        /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobTemplateAsync(JobTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobTemplateAsync(new DeleteJobTemplateRequest
            {
                JobTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a job template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the job template to delete.
        /// `projects/{project}/locations/{location}/jobTemplates/{job_template}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobTemplateAsync(JobTemplateName name, st::CancellationToken cancellationToken) =>
            DeleteJobTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TranscoderService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Using the Transcoder API, you can queue asynchronous jobs for transcoding
    /// media into various output formats. Output formats may include different
    /// streaming standards such as HTTP Live Streaming (HLS) and Dynamic Adaptive
    /// Streaming over HTTP (DASH). You can also customize jobs using advanced
    /// features such as Digital Rights Management (DRM), audio equalization, content
    /// concatenation, and digital ad-stitch ready content generation.
    /// </remarks>
    public sealed partial class TranscoderServiceClientImpl : TranscoderServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateJobRequest, Job> _callCreateJob;

        private readonly gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> _callListJobs;

        private readonly gaxgrpc::ApiCall<GetJobRequest, Job> _callGetJob;

        private readonly gaxgrpc::ApiCall<DeleteJobRequest, wkt::Empty> _callDeleteJob;

        private readonly gaxgrpc::ApiCall<CreateJobTemplateRequest, JobTemplate> _callCreateJobTemplate;

        private readonly gaxgrpc::ApiCall<ListJobTemplatesRequest, ListJobTemplatesResponse> _callListJobTemplates;

        private readonly gaxgrpc::ApiCall<GetJobTemplateRequest, JobTemplate> _callGetJobTemplate;

        private readonly gaxgrpc::ApiCall<DeleteJobTemplateRequest, wkt::Empty> _callDeleteJobTemplate;

        /// <summary>
        /// Constructs a client wrapper for the TranscoderService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TranscoderServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TranscoderServiceClientImpl(TranscoderService.TranscoderServiceClient grpcClient, TranscoderServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TranscoderServiceSettings effectiveSettings = settings ?? TranscoderServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateJob = clientHelper.BuildApiCall<CreateJobRequest, Job>("CreateJob", grpcClient.CreateJobAsync, grpcClient.CreateJob, effectiveSettings.CreateJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateJob);
            Modify_CreateJobApiCall(ref _callCreateJob);
            _callListJobs = clientHelper.BuildApiCall<ListJobsRequest, ListJobsResponse>("ListJobs", grpcClient.ListJobsAsync, grpcClient.ListJobs, effectiveSettings.ListJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListJobs);
            Modify_ListJobsApiCall(ref _callListJobs);
            _callGetJob = clientHelper.BuildApiCall<GetJobRequest, Job>("GetJob", grpcClient.GetJobAsync, grpcClient.GetJob, effectiveSettings.GetJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetJob);
            Modify_GetJobApiCall(ref _callGetJob);
            _callDeleteJob = clientHelper.BuildApiCall<DeleteJobRequest, wkt::Empty>("DeleteJob", grpcClient.DeleteJobAsync, grpcClient.DeleteJob, effectiveSettings.DeleteJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteJob);
            Modify_DeleteJobApiCall(ref _callDeleteJob);
            _callCreateJobTemplate = clientHelper.BuildApiCall<CreateJobTemplateRequest, JobTemplate>("CreateJobTemplate", grpcClient.CreateJobTemplateAsync, grpcClient.CreateJobTemplate, effectiveSettings.CreateJobTemplateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateJobTemplate);
            Modify_CreateJobTemplateApiCall(ref _callCreateJobTemplate);
            _callListJobTemplates = clientHelper.BuildApiCall<ListJobTemplatesRequest, ListJobTemplatesResponse>("ListJobTemplates", grpcClient.ListJobTemplatesAsync, grpcClient.ListJobTemplates, effectiveSettings.ListJobTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListJobTemplates);
            Modify_ListJobTemplatesApiCall(ref _callListJobTemplates);
            _callGetJobTemplate = clientHelper.BuildApiCall<GetJobTemplateRequest, JobTemplate>("GetJobTemplate", grpcClient.GetJobTemplateAsync, grpcClient.GetJobTemplate, effectiveSettings.GetJobTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetJobTemplate);
            Modify_GetJobTemplateApiCall(ref _callGetJobTemplate);
            _callDeleteJobTemplate = clientHelper.BuildApiCall<DeleteJobTemplateRequest, wkt::Empty>("DeleteJobTemplate", grpcClient.DeleteJobTemplateAsync, grpcClient.DeleteJobTemplate, effectiveSettings.DeleteJobTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteJobTemplate);
            Modify_DeleteJobTemplateApiCall(ref _callDeleteJobTemplate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateJobApiCall(ref gaxgrpc::ApiCall<CreateJobRequest, Job> call);

        partial void Modify_ListJobsApiCall(ref gaxgrpc::ApiCall<ListJobsRequest, ListJobsResponse> call);

        partial void Modify_GetJobApiCall(ref gaxgrpc::ApiCall<GetJobRequest, Job> call);

        partial void Modify_DeleteJobApiCall(ref gaxgrpc::ApiCall<DeleteJobRequest, wkt::Empty> call);

        partial void Modify_CreateJobTemplateApiCall(ref gaxgrpc::ApiCall<CreateJobTemplateRequest, JobTemplate> call);

        partial void Modify_ListJobTemplatesApiCall(ref gaxgrpc::ApiCall<ListJobTemplatesRequest, ListJobTemplatesResponse> call);

        partial void Modify_GetJobTemplateApiCall(ref gaxgrpc::ApiCall<GetJobTemplateRequest, JobTemplate> call);

        partial void Modify_DeleteJobTemplateApiCall(ref gaxgrpc::ApiCall<DeleteJobTemplateRequest, wkt::Empty> call);

        partial void OnConstruction(TranscoderService.TranscoderServiceClient grpcClient, TranscoderServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TranscoderService client</summary>
        public override TranscoderService.TranscoderServiceClient GrpcClient { get; }

        partial void Modify_CreateJobRequest(ref CreateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListJobsRequest(ref ListJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetJobRequest(ref GetJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteJobRequest(ref DeleteJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateJobTemplateRequest(ref CreateJobTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListJobTemplatesRequest(ref ListJobTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetJobTemplateRequest(ref GetJobTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteJobTemplateRequest(ref DeleteJobTemplateRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a job in the specified region.
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
        /// Creates a job in the specified region.
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
        /// Lists jobs in the specified region.
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
        /// Lists jobs in the specified region.
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
        /// Returns the job data.
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
        /// Returns the job data.
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
        /// Creates a job template in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override JobTemplate CreateJobTemplate(CreateJobTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobTemplateRequest(ref request, ref callSettings);
            return _callCreateJobTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a job template in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<JobTemplate> CreateJobTemplateAsync(CreateJobTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobTemplateRequest(ref request, ref callSettings);
            return _callCreateJobTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists job templates in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="JobTemplate"/> resources.</returns>
        public override gax::PagedEnumerable<ListJobTemplatesResponse, JobTemplate> ListJobTemplates(ListJobTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListJobTemplatesRequest, ListJobTemplatesResponse, JobTemplate>(_callListJobTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists job templates in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="JobTemplate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListJobTemplatesResponse, JobTemplate> ListJobTemplatesAsync(ListJobTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListJobTemplatesRequest, ListJobTemplatesResponse, JobTemplate>(_callListJobTemplates, request, callSettings);
        }

        /// <summary>
        /// Returns the job template data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override JobTemplate GetJobTemplate(GetJobTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobTemplateRequest(ref request, ref callSettings);
            return _callGetJobTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the job template data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<JobTemplate> GetJobTemplateAsync(GetJobTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobTemplateRequest(ref request, ref callSettings);
            return _callGetJobTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a job template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteJobTemplate(DeleteJobTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobTemplateRequest(ref request, ref callSettings);
            _callDeleteJobTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a job template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteJobTemplateAsync(DeleteJobTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobTemplateRequest(ref request, ref callSettings);
            return _callDeleteJobTemplate.Async(request, callSettings);
        }
    }

    public partial class ListJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListJobTemplatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListJobsResponse : gaxgrpc::IPageResponse<Job>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Job> GetEnumerator() => Jobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListJobTemplatesResponse : gaxgrpc::IPageResponse<JobTemplate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<JobTemplate> GetEnumerator() => JobTemplates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
