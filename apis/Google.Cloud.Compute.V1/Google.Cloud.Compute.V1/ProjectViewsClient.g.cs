// Copyright 2026 Google LLC
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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="ProjectViewsClient"/> instances.</summary>
    public sealed partial class ProjectViewsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProjectViewsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProjectViewsSettings"/>.</returns>
        public static ProjectViewsSettings GetDefault() => new ProjectViewsSettings();

        /// <summary>Constructs a new <see cref="ProjectViewsSettings"/> object with default settings.</summary>
        public ProjectViewsSettings()
        {
        }

        private ProjectViewsSettings(ProjectViewsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProjectViewsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ProjectViewsClient.Get</c>
        /// and <c>ProjectViewsClient.GetAsync</c>.
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
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProjectViewsSettings"/> object.</returns>
        public ProjectViewsSettings Clone() => new ProjectViewsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProjectViewsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ProjectViewsClientBuilder : gaxgrpc::ClientBuilderBase<ProjectViewsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProjectViewsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProjectViewsClientBuilder() : base(ProjectViewsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProjectViewsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProjectViewsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProjectViewsClient Build()
        {
            ProjectViewsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProjectViewsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProjectViewsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProjectViewsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProjectViewsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProjectViewsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProjectViewsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProjectViewsClient.ChannelPool;
    }

    /// <summary>
    /// ProjectViews client wrapper, for convenient use. This client implements API version 2026-09-01.
    /// </summary>
    /// <remarks>
    /// The ProjectViews API.
    /// </remarks>
    public abstract partial class ProjectViewsClient
    {
        /// <summary>
        /// The default endpoint for the ProjectViews service, which is a host of "compute.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default ProjectViews scopes.</summary>
        /// <remarks>
        /// The default ProjectViews scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute.readonly",
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ProjectViews.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProjectViewsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProjectViewsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProjectViewsClient"/>.</returns>
        public static stt::Task<ProjectViewsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProjectViewsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProjectViewsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProjectViewsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProjectViewsClient"/>.</returns>
        public static ProjectViewsClient Create() => new ProjectViewsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProjectViewsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProjectViewsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProjectViewsClient"/>.</returns>
        internal static ProjectViewsClient Create(grpccore::CallInvoker callInvoker, ProjectViewsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProjectViews.ProjectViewsClient grpcClient = new ProjectViews.ProjectViewsClient(callInvoker);
            return new ProjectViewsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ProjectViews client</summary>
        public virtual ProjectViews.ProjectViewsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified global ProjectViews resource, with a regional
        /// context.
        /// This regional API endpoint reads resource metadata from regional
        /// read-only replicas. Because changes are copied to these regional replicas
        /// asynchronously, for real-time resource reads or any write operations
        /// (creating, updating, or deleting resources), use the global
        /// [projects.get](https://cloud.google.com/compute/docs/reference/rest/v1/projects/get)
        /// endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectView Get(GetProjectViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified global ProjectViews resource, with a regional
        /// context.
        /// This regional API endpoint reads resource metadata from regional
        /// read-only replicas. Because changes are copied to these regional replicas
        /// asynchronously, for real-time resource reads or any write operations
        /// (creating, updating, or deleting resources), use the global
        /// [projects.get](https://cloud.google.com/compute/docs/reference/rest/v1/projects/get)
        /// endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectView> GetAsync(GetProjectViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified global ProjectViews resource, with a regional
        /// context.
        /// This regional API endpoint reads resource metadata from regional
        /// read-only replicas. Because changes are copied to these regional replicas
        /// asynchronously, for real-time resource reads or any write operations
        /// (creating, updating, or deleting resources), use the global
        /// [projects.get](https://cloud.google.com/compute/docs/reference/rest/v1/projects/get)
        /// endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectView> GetAsync(GetProjectViewRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified global ProjectViews resource, with a regional
        /// context.
        /// This regional API endpoint reads resource metadata from regional
        /// read-only replicas. Because changes are copied to these regional replicas
        /// asynchronously, for real-time resource reads or any write operations
        /// (creating, updating, or deleting resources), use the global
        /// [projects.get](https://cloud.google.com/compute/docs/reference/rest/v1/projects/get)
        /// endpoint.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID for this request. This is part of the URL path.
        /// </param>
        /// <param name="region">
        /// Required. Name of the region for this request. This is part of the URL path.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectView Get(string project, string region, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetProjectViewRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified global ProjectViews resource, with a regional
        /// context.
        /// This regional API endpoint reads resource metadata from regional
        /// read-only replicas. Because changes are copied to these regional replicas
        /// asynchronously, for real-time resource reads or any write operations
        /// (creating, updating, or deleting resources), use the global
        /// [projects.get](https://cloud.google.com/compute/docs/reference/rest/v1/projects/get)
        /// endpoint.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID for this request. This is part of the URL path.
        /// </param>
        /// <param name="region">
        /// Required. Name of the region for this request. This is part of the URL path.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectView> GetAsync(string project, string region, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetProjectViewRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified global ProjectViews resource, with a regional
        /// context.
        /// This regional API endpoint reads resource metadata from regional
        /// read-only replicas. Because changes are copied to these regional replicas
        /// asynchronously, for real-time resource reads or any write operations
        /// (creating, updating, or deleting resources), use the global
        /// [projects.get](https://cloud.google.com/compute/docs/reference/rest/v1/projects/get)
        /// endpoint.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID for this request. This is part of the URL path.
        /// </param>
        /// <param name="region">
        /// Required. Name of the region for this request. This is part of the URL path.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectView> GetAsync(string project, string region, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ProjectViews client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The ProjectViews API.
    /// </remarks>
    public sealed partial class ProjectViewsClientImpl : ProjectViewsClient
    {
        private readonly gaxgrpc::ApiCall<GetProjectViewRequest, ProjectView> _callGet;

        /// <summary>
        /// Constructs a client wrapper for the ProjectViews service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProjectViewsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProjectViewsClientImpl(ProjectViews.ProjectViewsClient grpcClient, ProjectViewsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProjectViewsSettings effectiveSettings = settings ?? ProjectViewsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
                ApiVersion = "2026-09-01",
            });
            _callGet = clientHelper.BuildApiCall<GetProjectViewRequest, ProjectView>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetProjectViewRequest, ProjectView> call);

        partial void OnConstruction(ProjectViews.ProjectViewsClient grpcClient, ProjectViewsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProjectViews client</summary>
        public override ProjectViews.ProjectViewsClient GrpcClient { get; }

        partial void Modify_GetProjectViewRequest(ref GetProjectViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the specified global ProjectViews resource, with a regional
        /// context.
        /// This regional API endpoint reads resource metadata from regional
        /// read-only replicas. Because changes are copied to these regional replicas
        /// asynchronously, for real-time resource reads or any write operations
        /// (creating, updating, or deleting resources), use the global
        /// [projects.get](https://cloud.google.com/compute/docs/reference/rest/v1/projects/get)
        /// endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProjectView Get(GetProjectViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProjectViewRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified global ProjectViews resource, with a regional
        /// context.
        /// This regional API endpoint reads resource metadata from regional
        /// read-only replicas. Because changes are copied to these regional replicas
        /// asynchronously, for real-time resource reads or any write operations
        /// (creating, updating, or deleting resources), use the global
        /// [projects.get](https://cloud.google.com/compute/docs/reference/rest/v1/projects/get)
        /// endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProjectView> GetAsync(GetProjectViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProjectViewRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }
    }
}
