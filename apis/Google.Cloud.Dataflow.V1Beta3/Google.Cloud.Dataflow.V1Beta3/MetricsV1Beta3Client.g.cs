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
    /// <summary>Settings for <see cref="MetricsV1Beta3Client"/> instances.</summary>
    public sealed partial class MetricsV1Beta3Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MetricsV1Beta3Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MetricsV1Beta3Settings"/>.</returns>
        public static MetricsV1Beta3Settings GetDefault() => new MetricsV1Beta3Settings();

        /// <summary>Constructs a new <see cref="MetricsV1Beta3Settings"/> object with default settings.</summary>
        public MetricsV1Beta3Settings()
        {
        }

        private MetricsV1Beta3Settings(MetricsV1Beta3Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetJobMetricsSettings = existing.GetJobMetricsSettings;
            GetJobExecutionDetailsSettings = existing.GetJobExecutionDetailsSettings;
            GetStageExecutionDetailsSettings = existing.GetStageExecutionDetailsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MetricsV1Beta3Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsV1Beta3Client.GetJobMetrics</c> and <c>MetricsV1Beta3Client.GetJobMetricsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetJobMetricsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsV1Beta3Client.GetJobExecutionDetails</c> and <c>MetricsV1Beta3Client.GetJobExecutionDetailsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetJobExecutionDetailsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsV1Beta3Client.GetStageExecutionDetails</c> and
        /// <c>MetricsV1Beta3Client.GetStageExecutionDetailsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetStageExecutionDetailsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MetricsV1Beta3Settings"/> object.</returns>
        public MetricsV1Beta3Settings Clone() => new MetricsV1Beta3Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MetricsV1Beta3Client"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class MetricsV1Beta3ClientBuilder : gaxgrpc::ClientBuilderBase<MetricsV1Beta3Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MetricsV1Beta3Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MetricsV1Beta3ClientBuilder() : base(MetricsV1Beta3Client.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MetricsV1Beta3Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MetricsV1Beta3Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override MetricsV1Beta3Client Build()
        {
            MetricsV1Beta3Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MetricsV1Beta3Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MetricsV1Beta3Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MetricsV1Beta3Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MetricsV1Beta3Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MetricsV1Beta3Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MetricsV1Beta3Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MetricsV1Beta3Client.ChannelPool;
    }

    /// <summary>MetricsV1Beta3 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Dataflow Metrics API lets you monitor the progress of Dataflow
    /// jobs.
    /// </remarks>
    public abstract partial class MetricsV1Beta3Client
    {
        /// <summary>
        /// The default endpoint for the MetricsV1Beta3 service, which is a host of "dataflow.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataflow.googleapis.com:443";

        /// <summary>The default MetricsV1Beta3 scopes.</summary>
        /// <remarks>
        /// The default MetricsV1Beta3 scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MetricsV1Beta3.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MetricsV1Beta3Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MetricsV1Beta3ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MetricsV1Beta3Client"/>.</returns>
        public static stt::Task<MetricsV1Beta3Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MetricsV1Beta3ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MetricsV1Beta3Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MetricsV1Beta3ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MetricsV1Beta3Client"/>.</returns>
        public static MetricsV1Beta3Client Create() => new MetricsV1Beta3ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MetricsV1Beta3Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MetricsV1Beta3Settings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MetricsV1Beta3Client"/>.</returns>
        internal static MetricsV1Beta3Client Create(grpccore::CallInvoker callInvoker, MetricsV1Beta3Settings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MetricsV1Beta3.MetricsV1Beta3Client grpcClient = new MetricsV1Beta3.MetricsV1Beta3Client(callInvoker);
            return new MetricsV1Beta3ClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MetricsV1Beta3 client</summary>
        public virtual MetricsV1Beta3.MetricsV1Beta3Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Request the job status.
        /// 
        /// To request the status of a job, we recommend using
        /// `projects.locations.jobs.getMetrics` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.getMetrics` is not recommended, as you can only request the
        /// status of jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobMetrics GetJobMetrics(GetJobMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Request the job status.
        /// 
        /// To request the status of a job, we recommend using
        /// `projects.locations.jobs.getMetrics` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.getMetrics` is not recommended, as you can only request the
        /// status of jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobMetrics> GetJobMetricsAsync(GetJobMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Request the job status.
        /// 
        /// To request the status of a job, we recommend using
        /// `projects.locations.jobs.getMetrics` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.getMetrics` is not recommended, as you can only request the
        /// status of jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobMetrics> GetJobMetricsAsync(GetJobMetricsRequest request, st::CancellationToken cancellationToken) =>
            GetJobMetricsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Request detailed information about the execution status of the job.
        /// 
        /// EXPERIMENTAL.  This API is subject to change or removal without notice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StageSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<JobExecutionDetails, StageSummary> GetJobExecutionDetails(GetJobExecutionDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Request detailed information about the execution status of the job.
        /// 
        /// EXPERIMENTAL.  This API is subject to change or removal without notice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StageSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<JobExecutionDetails, StageSummary> GetJobExecutionDetailsAsync(GetJobExecutionDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Request detailed information about the execution status of a stage of the
        /// job.
        /// 
        /// EXPERIMENTAL.  This API is subject to change or removal without notice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkerDetails"/> resources.</returns>
        public virtual gax::PagedEnumerable<StageExecutionDetails, WorkerDetails> GetStageExecutionDetails(GetStageExecutionDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Request detailed information about the execution status of a stage of the
        /// job.
        /// 
        /// EXPERIMENTAL.  This API is subject to change or removal without notice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkerDetails"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<StageExecutionDetails, WorkerDetails> GetStageExecutionDetailsAsync(GetStageExecutionDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>MetricsV1Beta3 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Dataflow Metrics API lets you monitor the progress of Dataflow
    /// jobs.
    /// </remarks>
    public sealed partial class MetricsV1Beta3ClientImpl : MetricsV1Beta3Client
    {
        private readonly gaxgrpc::ApiCall<GetJobMetricsRequest, JobMetrics> _callGetJobMetrics;

        private readonly gaxgrpc::ApiCall<GetJobExecutionDetailsRequest, JobExecutionDetails> _callGetJobExecutionDetails;

        private readonly gaxgrpc::ApiCall<GetStageExecutionDetailsRequest, StageExecutionDetails> _callGetStageExecutionDetails;

        /// <summary>
        /// Constructs a client wrapper for the MetricsV1Beta3 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MetricsV1Beta3Settings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MetricsV1Beta3ClientImpl(MetricsV1Beta3.MetricsV1Beta3Client grpcClient, MetricsV1Beta3Settings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MetricsV1Beta3Settings effectiveSettings = settings ?? MetricsV1Beta3Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetJobMetrics = clientHelper.BuildApiCall<GetJobMetricsRequest, JobMetrics>("GetJobMetrics", grpcClient.GetJobMetricsAsync, grpcClient.GetJobMetrics, effectiveSettings.GetJobMetricsSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("location", request => request.Location).WithGoogleRequestParam("job_id", request => request.JobId);
            Modify_ApiCall(ref _callGetJobMetrics);
            Modify_GetJobMetricsApiCall(ref _callGetJobMetrics);
            _callGetJobExecutionDetails = clientHelper.BuildApiCall<GetJobExecutionDetailsRequest, JobExecutionDetails>("GetJobExecutionDetails", grpcClient.GetJobExecutionDetailsAsync, grpcClient.GetJobExecutionDetails, effectiveSettings.GetJobExecutionDetailsSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("location", request => request.Location).WithGoogleRequestParam("job_id", request => request.JobId);
            Modify_ApiCall(ref _callGetJobExecutionDetails);
            Modify_GetJobExecutionDetailsApiCall(ref _callGetJobExecutionDetails);
            _callGetStageExecutionDetails = clientHelper.BuildApiCall<GetStageExecutionDetailsRequest, StageExecutionDetails>("GetStageExecutionDetails", grpcClient.GetStageExecutionDetailsAsync, grpcClient.GetStageExecutionDetails, effectiveSettings.GetStageExecutionDetailsSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("location", request => request.Location).WithGoogleRequestParam("job_id", request => request.JobId).WithGoogleRequestParam("stage_id", request => request.StageId);
            Modify_ApiCall(ref _callGetStageExecutionDetails);
            Modify_GetStageExecutionDetailsApiCall(ref _callGetStageExecutionDetails);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetJobMetricsApiCall(ref gaxgrpc::ApiCall<GetJobMetricsRequest, JobMetrics> call);

        partial void Modify_GetJobExecutionDetailsApiCall(ref gaxgrpc::ApiCall<GetJobExecutionDetailsRequest, JobExecutionDetails> call);

        partial void Modify_GetStageExecutionDetailsApiCall(ref gaxgrpc::ApiCall<GetStageExecutionDetailsRequest, StageExecutionDetails> call);

        partial void OnConstruction(MetricsV1Beta3.MetricsV1Beta3Client grpcClient, MetricsV1Beta3Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MetricsV1Beta3 client</summary>
        public override MetricsV1Beta3.MetricsV1Beta3Client GrpcClient { get; }

        partial void Modify_GetJobMetricsRequest(ref GetJobMetricsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetJobExecutionDetailsRequest(ref GetJobExecutionDetailsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStageExecutionDetailsRequest(ref GetStageExecutionDetailsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Request the job status.
        /// 
        /// To request the status of a job, we recommend using
        /// `projects.locations.jobs.getMetrics` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.getMetrics` is not recommended, as you can only request the
        /// status of jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override JobMetrics GetJobMetrics(GetJobMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobMetricsRequest(ref request, ref callSettings);
            return _callGetJobMetrics.Sync(request, callSettings);
        }

        /// <summary>
        /// Request the job status.
        /// 
        /// To request the status of a job, we recommend using
        /// `projects.locations.jobs.getMetrics` with a [regional endpoint]
        /// (https://cloud.google.com/dataflow/docs/concepts/regional-endpoints). Using
        /// `projects.jobs.getMetrics` is not recommended, as you can only request the
        /// status of jobs that are running in `us-central1`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<JobMetrics> GetJobMetricsAsync(GetJobMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobMetricsRequest(ref request, ref callSettings);
            return _callGetJobMetrics.Async(request, callSettings);
        }

        /// <summary>
        /// Request detailed information about the execution status of the job.
        /// 
        /// EXPERIMENTAL.  This API is subject to change or removal without notice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StageSummary"/> resources.</returns>
        public override gax::PagedEnumerable<JobExecutionDetails, StageSummary> GetJobExecutionDetails(GetJobExecutionDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobExecutionDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<GetJobExecutionDetailsRequest, JobExecutionDetails, StageSummary>(_callGetJobExecutionDetails, request, callSettings);
        }

        /// <summary>
        /// Request detailed information about the execution status of the job.
        /// 
        /// EXPERIMENTAL.  This API is subject to change or removal without notice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StageSummary"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<JobExecutionDetails, StageSummary> GetJobExecutionDetailsAsync(GetJobExecutionDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobExecutionDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<GetJobExecutionDetailsRequest, JobExecutionDetails, StageSummary>(_callGetJobExecutionDetails, request, callSettings);
        }

        /// <summary>
        /// Request detailed information about the execution status of a stage of the
        /// job.
        /// 
        /// EXPERIMENTAL.  This API is subject to change or removal without notice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkerDetails"/> resources.</returns>
        public override gax::PagedEnumerable<StageExecutionDetails, WorkerDetails> GetStageExecutionDetails(GetStageExecutionDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStageExecutionDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<GetStageExecutionDetailsRequest, StageExecutionDetails, WorkerDetails>(_callGetStageExecutionDetails, request, callSettings);
        }

        /// <summary>
        /// Request detailed information about the execution status of a stage of the
        /// job.
        /// 
        /// EXPERIMENTAL.  This API is subject to change or removal without notice.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkerDetails"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<StageExecutionDetails, WorkerDetails> GetStageExecutionDetailsAsync(GetStageExecutionDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStageExecutionDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<GetStageExecutionDetailsRequest, StageExecutionDetails, WorkerDetails>(_callGetStageExecutionDetails, request, callSettings);
        }
    }

    public partial class GetJobExecutionDetailsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class GetStageExecutionDetailsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class JobExecutionDetails : gaxgrpc::IPageResponse<StageSummary>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<StageSummary> GetEnumerator() => Stages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class StageExecutionDetails : gaxgrpc::IPageResponse<WorkerDetails>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<WorkerDetails> GetEnumerator() => Workers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
