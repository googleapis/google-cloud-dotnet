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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.ErrorReporting.V1Beta1
{
    /// <summary>Settings for <see cref="ReportErrorsServiceClient"/> instances.</summary>
    public sealed partial class ReportErrorsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReportErrorsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReportErrorsServiceSettings"/>.</returns>
        public static ReportErrorsServiceSettings GetDefault() => new ReportErrorsServiceSettings();

        /// <summary>Constructs a new <see cref="ReportErrorsServiceSettings"/> object with default settings.</summary>
        public ReportErrorsServiceSettings()
        {
        }

        private ReportErrorsServiceSettings(ReportErrorsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ReportErrorEventSettings = existing.ReportErrorEventSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReportErrorsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReportErrorsServiceClient.ReportErrorEvent</c> and <c>ReportErrorsServiceClient.ReportErrorEventAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReportErrorEventSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReportErrorsServiceSettings"/> object.</returns>
        public ReportErrorsServiceSettings Clone() => new ReportErrorsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReportErrorsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ReportErrorsServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReportErrorsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReportErrorsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReportErrorsServiceClientBuilder() : base(ReportErrorsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReportErrorsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReportErrorsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReportErrorsServiceClient Build()
        {
            ReportErrorsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReportErrorsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReportErrorsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReportErrorsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReportErrorsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReportErrorsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReportErrorsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReportErrorsServiceClient.ChannelPool;
    }

    /// <summary>ReportErrorsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// An API for reporting error events.
    /// </remarks>
    public abstract partial class ReportErrorsServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReportErrorsService service, which is a host of
        /// "clouderrorreporting.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "clouderrorreporting.googleapis.com:443";

        /// <summary>The default ReportErrorsService scopes.</summary>
        /// <remarks>
        /// The default ReportErrorsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReportErrorsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReportErrorsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ReportErrorsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReportErrorsServiceClient"/>.</returns>
        public static stt::Task<ReportErrorsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReportErrorsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReportErrorsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ReportErrorsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ReportErrorsServiceClient"/>.</returns>
        public static ReportErrorsServiceClient Create() => new ReportErrorsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReportErrorsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReportErrorsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReportErrorsServiceClient"/>.</returns>
        internal static ReportErrorsServiceClient Create(grpccore::CallInvoker callInvoker, ReportErrorsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReportErrorsService.ReportErrorsServiceClient grpcClient = new ReportErrorsService.ReportErrorsServiceClient(callInvoker);
            return new ReportErrorsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ReportErrorsService client</summary>
        public virtual ReportErrorsService.ReportErrorsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Report an individual error event and record the event to a log.
        /// 
        /// This endpoint accepts **either** an OAuth token,
        /// **or** an [API key](https://support.google.com/cloud/answer/6158862)
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// 
        /// `POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/{projectName}/events:report?key=123ABC456`
        /// 
        /// **Note:** [Error Reporting] (https://cloud.google.com/error-reporting)
        /// is a service built on Cloud Logging and can analyze log entries when all of
        /// the following are true:
        /// 
        /// * Customer-managed encryption keys (CMEK) are disabled on the log bucket.
        /// * The log bucket satisfies one of the following:
        /// * The log bucket is stored in the same project where the logs
        /// originated.
        /// * The logs were routed to a project, and then that project stored those
        /// logs in a log bucket that it owns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportErrorEventResponse ReportErrorEvent(ReportErrorEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Report an individual error event and record the event to a log.
        /// 
        /// This endpoint accepts **either** an OAuth token,
        /// **or** an [API key](https://support.google.com/cloud/answer/6158862)
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// 
        /// `POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/{projectName}/events:report?key=123ABC456`
        /// 
        /// **Note:** [Error Reporting] (https://cloud.google.com/error-reporting)
        /// is a service built on Cloud Logging and can analyze log entries when all of
        /// the following are true:
        /// 
        /// * Customer-managed encryption keys (CMEK) are disabled on the log bucket.
        /// * The log bucket satisfies one of the following:
        /// * The log bucket is stored in the same project where the logs
        /// originated.
        /// * The logs were routed to a project, and then that project stored those
        /// logs in a log bucket that it owns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportErrorEventResponse> ReportErrorEventAsync(ReportErrorEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Report an individual error event and record the event to a log.
        /// 
        /// This endpoint accepts **either** an OAuth token,
        /// **or** an [API key](https://support.google.com/cloud/answer/6158862)
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// 
        /// `POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/{projectName}/events:report?key=123ABC456`
        /// 
        /// **Note:** [Error Reporting] (https://cloud.google.com/error-reporting)
        /// is a service built on Cloud Logging and can analyze log entries when all of
        /// the following are true:
        /// 
        /// * Customer-managed encryption keys (CMEK) are disabled on the log bucket.
        /// * The log bucket satisfies one of the following:
        /// * The log bucket is stored in the same project where the logs
        /// originated.
        /// * The logs were routed to a project, and then that project stored those
        /// logs in a log bucket that it owns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportErrorEventResponse> ReportErrorEventAsync(ReportErrorEventRequest request, st::CancellationToken cancellationToken) =>
            ReportErrorEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Report an individual error event and record the event to a log.
        /// 
        /// This endpoint accepts **either** an OAuth token,
        /// **or** an [API key](https://support.google.com/cloud/answer/6158862)
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// 
        /// `POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/{projectName}/events:report?key=123ABC456`
        /// 
        /// **Note:** [Error Reporting] (https://cloud.google.com/error-reporting)
        /// is a service built on Cloud Logging and can analyze log entries when all of
        /// the following are true:
        /// 
        /// * Customer-managed encryption keys (CMEK) are disabled on the log bucket.
        /// * The log bucket satisfies one of the following:
        /// * The log bucket is stored in the same project where the logs
        /// originated.
        /// * The logs were routed to a project, and then that project stored those
        /// logs in a log bucket that it owns.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectId}`, where `{projectId}` is the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// 
        /// Example: // `projects/my-project-123`.
        /// </param>
        /// <param name="event">
        /// Required. The error event to be reported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportErrorEventResponse ReportErrorEvent(string projectName, ReportedErrorEvent @event, gaxgrpc::CallSettings callSettings = null) =>
            ReportErrorEvent(new ReportErrorEventRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
            }, callSettings);

        /// <summary>
        /// Report an individual error event and record the event to a log.
        /// 
        /// This endpoint accepts **either** an OAuth token,
        /// **or** an [API key](https://support.google.com/cloud/answer/6158862)
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// 
        /// `POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/{projectName}/events:report?key=123ABC456`
        /// 
        /// **Note:** [Error Reporting] (https://cloud.google.com/error-reporting)
        /// is a service built on Cloud Logging and can analyze log entries when all of
        /// the following are true:
        /// 
        /// * Customer-managed encryption keys (CMEK) are disabled on the log bucket.
        /// * The log bucket satisfies one of the following:
        /// * The log bucket is stored in the same project where the logs
        /// originated.
        /// * The logs were routed to a project, and then that project stored those
        /// logs in a log bucket that it owns.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectId}`, where `{projectId}` is the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// 
        /// Example: // `projects/my-project-123`.
        /// </param>
        /// <param name="event">
        /// Required. The error event to be reported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportErrorEventResponse> ReportErrorEventAsync(string projectName, ReportedErrorEvent @event, gaxgrpc::CallSettings callSettings = null) =>
            ReportErrorEventAsync(new ReportErrorEventRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNullOrEmpty(projectName, nameof(projectName)),
                Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
            }, callSettings);

        /// <summary>
        /// Report an individual error event and record the event to a log.
        /// 
        /// This endpoint accepts **either** an OAuth token,
        /// **or** an [API key](https://support.google.com/cloud/answer/6158862)
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// 
        /// `POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/{projectName}/events:report?key=123ABC456`
        /// 
        /// **Note:** [Error Reporting] (https://cloud.google.com/error-reporting)
        /// is a service built on Cloud Logging and can analyze log entries when all of
        /// the following are true:
        /// 
        /// * Customer-managed encryption keys (CMEK) are disabled on the log bucket.
        /// * The log bucket satisfies one of the following:
        /// * The log bucket is stored in the same project where the logs
        /// originated.
        /// * The logs were routed to a project, and then that project stored those
        /// logs in a log bucket that it owns.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectId}`, where `{projectId}` is the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// 
        /// Example: // `projects/my-project-123`.
        /// </param>
        /// <param name="event">
        /// Required. The error event to be reported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportErrorEventResponse> ReportErrorEventAsync(string projectName, ReportedErrorEvent @event, st::CancellationToken cancellationToken) =>
            ReportErrorEventAsync(projectName, @event, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Report an individual error event and record the event to a log.
        /// 
        /// This endpoint accepts **either** an OAuth token,
        /// **or** an [API key](https://support.google.com/cloud/answer/6158862)
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// 
        /// `POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/{projectName}/events:report?key=123ABC456`
        /// 
        /// **Note:** [Error Reporting] (https://cloud.google.com/error-reporting)
        /// is a service built on Cloud Logging and can analyze log entries when all of
        /// the following are true:
        /// 
        /// * Customer-managed encryption keys (CMEK) are disabled on the log bucket.
        /// * The log bucket satisfies one of the following:
        /// * The log bucket is stored in the same project where the logs
        /// originated.
        /// * The logs were routed to a project, and then that project stored those
        /// logs in a log bucket that it owns.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectId}`, where `{projectId}` is the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// 
        /// Example: // `projects/my-project-123`.
        /// </param>
        /// <param name="event">
        /// Required. The error event to be reported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportErrorEventResponse ReportErrorEvent(gagr::ProjectName projectName, ReportedErrorEvent @event, gaxgrpc::CallSettings callSettings = null) =>
            ReportErrorEvent(new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
            }, callSettings);

        /// <summary>
        /// Report an individual error event and record the event to a log.
        /// 
        /// This endpoint accepts **either** an OAuth token,
        /// **or** an [API key](https://support.google.com/cloud/answer/6158862)
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// 
        /// `POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/{projectName}/events:report?key=123ABC456`
        /// 
        /// **Note:** [Error Reporting] (https://cloud.google.com/error-reporting)
        /// is a service built on Cloud Logging and can analyze log entries when all of
        /// the following are true:
        /// 
        /// * Customer-managed encryption keys (CMEK) are disabled on the log bucket.
        /// * The log bucket satisfies one of the following:
        /// * The log bucket is stored in the same project where the logs
        /// originated.
        /// * The logs were routed to a project, and then that project stored those
        /// logs in a log bucket that it owns.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectId}`, where `{projectId}` is the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// 
        /// Example: // `projects/my-project-123`.
        /// </param>
        /// <param name="event">
        /// Required. The error event to be reported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportErrorEventResponse> ReportErrorEventAsync(gagr::ProjectName projectName, ReportedErrorEvent @event, gaxgrpc::CallSettings callSettings = null) =>
            ReportErrorEventAsync(new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName)),
                Event = gax::GaxPreconditions.CheckNotNull(@event, nameof(@event)),
            }, callSettings);

        /// <summary>
        /// Report an individual error event and record the event to a log.
        /// 
        /// This endpoint accepts **either** an OAuth token,
        /// **or** an [API key](https://support.google.com/cloud/answer/6158862)
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// 
        /// `POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/{projectName}/events:report?key=123ABC456`
        /// 
        /// **Note:** [Error Reporting] (https://cloud.google.com/error-reporting)
        /// is a service built on Cloud Logging and can analyze log entries when all of
        /// the following are true:
        /// 
        /// * Customer-managed encryption keys (CMEK) are disabled on the log bucket.
        /// * The log bucket satisfies one of the following:
        /// * The log bucket is stored in the same project where the logs
        /// originated.
        /// * The logs were routed to a project, and then that project stored those
        /// logs in a log bucket that it owns.
        /// </summary>
        /// <param name="projectName">
        /// Required. The resource name of the Google Cloud Platform project. Written
        /// as `projects/{projectId}`, where `{projectId}` is the
        /// [Google Cloud Platform project
        /// ID](https://support.google.com/cloud/answer/6158840).
        /// 
        /// Example: // `projects/my-project-123`.
        /// </param>
        /// <param name="event">
        /// Required. The error event to be reported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportErrorEventResponse> ReportErrorEventAsync(gagr::ProjectName projectName, ReportedErrorEvent @event, st::CancellationToken cancellationToken) =>
            ReportErrorEventAsync(projectName, @event, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ReportErrorsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// An API for reporting error events.
    /// </remarks>
    public sealed partial class ReportErrorsServiceClientImpl : ReportErrorsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ReportErrorEventRequest, ReportErrorEventResponse> _callReportErrorEvent;

        /// <summary>
        /// Constructs a client wrapper for the ReportErrorsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReportErrorsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReportErrorsServiceClientImpl(ReportErrorsService.ReportErrorsServiceClient grpcClient, ReportErrorsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReportErrorsServiceSettings effectiveSettings = settings ?? ReportErrorsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callReportErrorEvent = clientHelper.BuildApiCall<ReportErrorEventRequest, ReportErrorEventResponse>("ReportErrorEvent", grpcClient.ReportErrorEventAsync, grpcClient.ReportErrorEvent, effectiveSettings.ReportErrorEventSettings).WithGoogleRequestParam("project_name", request => request.ProjectName);
            Modify_ApiCall(ref _callReportErrorEvent);
            Modify_ReportErrorEventApiCall(ref _callReportErrorEvent);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ReportErrorEventApiCall(ref gaxgrpc::ApiCall<ReportErrorEventRequest, ReportErrorEventResponse> call);

        partial void OnConstruction(ReportErrorsService.ReportErrorsServiceClient grpcClient, ReportErrorsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReportErrorsService client</summary>
        public override ReportErrorsService.ReportErrorsServiceClient GrpcClient { get; }

        partial void Modify_ReportErrorEventRequest(ref ReportErrorEventRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Report an individual error event and record the event to a log.
        /// 
        /// This endpoint accepts **either** an OAuth token,
        /// **or** an [API key](https://support.google.com/cloud/answer/6158862)
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// 
        /// `POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/{projectName}/events:report?key=123ABC456`
        /// 
        /// **Note:** [Error Reporting] (https://cloud.google.com/error-reporting)
        /// is a service built on Cloud Logging and can analyze log entries when all of
        /// the following are true:
        /// 
        /// * Customer-managed encryption keys (CMEK) are disabled on the log bucket.
        /// * The log bucket satisfies one of the following:
        /// * The log bucket is stored in the same project where the logs
        /// originated.
        /// * The logs were routed to a project, and then that project stored those
        /// logs in a log bucket that it owns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportErrorEventResponse ReportErrorEvent(ReportErrorEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportErrorEventRequest(ref request, ref callSettings);
            return _callReportErrorEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Report an individual error event and record the event to a log.
        /// 
        /// This endpoint accepts **either** an OAuth token,
        /// **or** an [API key](https://support.google.com/cloud/answer/6158862)
        /// for authentication. To use an API key, append it to the URL as the value of
        /// a `key` parameter. For example:
        /// 
        /// `POST
        /// https://clouderrorreporting.googleapis.com/v1beta1/{projectName}/events:report?key=123ABC456`
        /// 
        /// **Note:** [Error Reporting] (https://cloud.google.com/error-reporting)
        /// is a service built on Cloud Logging and can analyze log entries when all of
        /// the following are true:
        /// 
        /// * Customer-managed encryption keys (CMEK) are disabled on the log bucket.
        /// * The log bucket satisfies one of the following:
        /// * The log bucket is stored in the same project where the logs
        /// originated.
        /// * The logs were routed to a project, and then that project stored those
        /// logs in a log bucket that it owns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportErrorEventResponse> ReportErrorEventAsync(ReportErrorEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportErrorEventRequest(ref request, ref callSettings);
            return _callReportErrorEvent.Async(request, callSettings);
        }
    }
}
