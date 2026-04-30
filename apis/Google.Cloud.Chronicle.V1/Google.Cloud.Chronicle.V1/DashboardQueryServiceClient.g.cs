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

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Settings for <see cref="DashboardQueryServiceClient"/> instances.</summary>
    public sealed partial class DashboardQueryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DashboardQueryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DashboardQueryServiceSettings"/>.</returns>
        public static DashboardQueryServiceSettings GetDefault() => new DashboardQueryServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DashboardQueryServiceSettings"/> object with default settings.
        /// </summary>
        public DashboardQueryServiceSettings()
        {
        }

        private DashboardQueryServiceSettings(DashboardQueryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDashboardQuerySettings = existing.GetDashboardQuerySettings;
            ExecuteDashboardQuerySettings = existing.ExecuteDashboardQuerySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DashboardQueryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DashboardQueryServiceClient.GetDashboardQuery</c> and
        /// <c>DashboardQueryServiceClient.GetDashboardQueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDashboardQuerySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DashboardQueryServiceClient.ExecuteDashboardQuery</c> and
        /// <c>DashboardQueryServiceClient.ExecuteDashboardQueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 1800 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteDashboardQuerySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(1800000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DashboardQueryServiceSettings"/> object.</returns>
        public DashboardQueryServiceSettings Clone() => new DashboardQueryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DashboardQueryServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DashboardQueryServiceClientBuilder : gaxgrpc::ClientBuilderBase<DashboardQueryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DashboardQueryServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DashboardQueryServiceClientBuilder() : base(DashboardQueryServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DashboardQueryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DashboardQueryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DashboardQueryServiceClient Build()
        {
            DashboardQueryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DashboardQueryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DashboardQueryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DashboardQueryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DashboardQueryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DashboardQueryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DashboardQueryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DashboardQueryServiceClient.ChannelPool;
    }

    /// <summary>DashboardQueryService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service providing functionality for managing dashboards' queries.
    /// </remarks>
    public abstract partial class DashboardQueryServiceClient
    {
        /// <summary>
        /// The default endpoint for the DashboardQueryService service, which is a host of "chronicle.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chronicle.googleapis.com:443";

        /// <summary>The default DashboardQueryService scopes.</summary>
        /// <remarks>
        /// The default DashboardQueryService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/chronicle</description></item>
        /// <item><description>https://www.googleapis.com/auth/chronicle.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/chronicle",
            "https://www.googleapis.com/auth/chronicle.readonly",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DashboardQueryService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DashboardQueryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DashboardQueryServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DashboardQueryServiceClient"/>.</returns>
        public static stt::Task<DashboardQueryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DashboardQueryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DashboardQueryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DashboardQueryServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DashboardQueryServiceClient"/>.</returns>
        public static DashboardQueryServiceClient Create() => new DashboardQueryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DashboardQueryServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DashboardQueryServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DashboardQueryServiceClient"/>.</returns>
        internal static DashboardQueryServiceClient Create(grpccore::CallInvoker callInvoker, DashboardQueryServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DashboardQueryService.DashboardQueryServiceClient grpcClient = new DashboardQueryService.DashboardQueryServiceClient(callInvoker);
            return new DashboardQueryServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DashboardQueryService client</summary>
        public virtual DashboardQueryService.DashboardQueryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get a dashboard query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DashboardQuery GetDashboardQuery(GetDashboardQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a dashboard query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DashboardQuery> GetDashboardQueryAsync(GetDashboardQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a dashboard query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DashboardQuery> GetDashboardQueryAsync(GetDashboardQueryRequest request, st::CancellationToken cancellationToken) =>
            GetDashboardQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a dashboard query.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dashboardQuery to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dashboardQueries/{query}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DashboardQuery GetDashboardQuery(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDashboardQuery(new GetDashboardQueryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dashboard query.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dashboardQuery to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dashboardQueries/{query}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DashboardQuery> GetDashboardQueryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDashboardQueryAsync(new GetDashboardQueryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dashboard query.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dashboardQuery to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dashboardQueries/{query}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DashboardQuery> GetDashboardQueryAsync(string name, st::CancellationToken cancellationToken) =>
            GetDashboardQueryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a dashboard query.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dashboardQuery to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dashboardQueries/{query}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DashboardQuery GetDashboardQuery(DashboardQueryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDashboardQuery(new GetDashboardQueryRequest
            {
                DashboardQueryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dashboard query.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dashboardQuery to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dashboardQueries/{query}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DashboardQuery> GetDashboardQueryAsync(DashboardQueryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDashboardQueryAsync(new GetDashboardQueryRequest
            {
                DashboardQueryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dashboard query.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dashboardQuery to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dashboardQueries/{query}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DashboardQuery> GetDashboardQueryAsync(DashboardQueryName name, st::CancellationToken cancellationToken) =>
            GetDashboardQueryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Execute a query and return the data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExecuteDashboardQueryResponse ExecuteDashboardQuery(ExecuteDashboardQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Execute a query and return the data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteDashboardQueryResponse> ExecuteDashboardQueryAsync(ExecuteDashboardQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Execute a query and return the data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteDashboardQueryResponse> ExecuteDashboardQueryAsync(ExecuteDashboardQueryRequest request, st::CancellationToken cancellationToken) =>
            ExecuteDashboardQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Execute a query and return the data.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, under which to run this dashboardQuery.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="query">
        /// Required. The query to execute and get results back for.
        /// QueryID or 'query', 'input.time_window' fields will be used. Use
        /// 'native_dashboard' and 'dashboard_chart' fields if it is an in-dashboard
        /// query.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExecuteDashboardQueryResponse ExecuteDashboardQuery(string parent, DashboardQuery query, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteDashboardQuery(new ExecuteDashboardQueryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNull(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Execute a query and return the data.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, under which to run this dashboardQuery.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="query">
        /// Required. The query to execute and get results back for.
        /// QueryID or 'query', 'input.time_window' fields will be used. Use
        /// 'native_dashboard' and 'dashboard_chart' fields if it is an in-dashboard
        /// query.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteDashboardQueryResponse> ExecuteDashboardQueryAsync(string parent, DashboardQuery query, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteDashboardQueryAsync(new ExecuteDashboardQueryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNull(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Execute a query and return the data.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, under which to run this dashboardQuery.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="query">
        /// Required. The query to execute and get results back for.
        /// QueryID or 'query', 'input.time_window' fields will be used. Use
        /// 'native_dashboard' and 'dashboard_chart' fields if it is an in-dashboard
        /// query.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteDashboardQueryResponse> ExecuteDashboardQueryAsync(string parent, DashboardQuery query, st::CancellationToken cancellationToken) =>
            ExecuteDashboardQueryAsync(parent, query, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Execute a query and return the data.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, under which to run this dashboardQuery.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="query">
        /// Required. The query to execute and get results back for.
        /// QueryID or 'query', 'input.time_window' fields will be used. Use
        /// 'native_dashboard' and 'dashboard_chart' fields if it is an in-dashboard
        /// query.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExecuteDashboardQueryResponse ExecuteDashboardQuery(InstanceName parent, DashboardQuery query, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteDashboardQuery(new ExecuteDashboardQueryRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNull(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Execute a query and return the data.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, under which to run this dashboardQuery.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="query">
        /// Required. The query to execute and get results back for.
        /// QueryID or 'query', 'input.time_window' fields will be used. Use
        /// 'native_dashboard' and 'dashboard_chart' fields if it is an in-dashboard
        /// query.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteDashboardQueryResponse> ExecuteDashboardQueryAsync(InstanceName parent, DashboardQuery query, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteDashboardQueryAsync(new ExecuteDashboardQueryRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Query = gax::GaxPreconditions.CheckNotNull(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Execute a query and return the data.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, under which to run this dashboardQuery.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="query">
        /// Required. The query to execute and get results back for.
        /// QueryID or 'query', 'input.time_window' fields will be used. Use
        /// 'native_dashboard' and 'dashboard_chart' fields if it is an in-dashboard
        /// query.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteDashboardQueryResponse> ExecuteDashboardQueryAsync(InstanceName parent, DashboardQuery query, st::CancellationToken cancellationToken) =>
            ExecuteDashboardQueryAsync(parent, query, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DashboardQueryService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service providing functionality for managing dashboards' queries.
    /// </remarks>
    public sealed partial class DashboardQueryServiceClientImpl : DashboardQueryServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDashboardQueryRequest, DashboardQuery> _callGetDashboardQuery;

        private readonly gaxgrpc::ApiCall<ExecuteDashboardQueryRequest, ExecuteDashboardQueryResponse> _callExecuteDashboardQuery;

        /// <summary>
        /// Constructs a client wrapper for the DashboardQueryService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DashboardQueryServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DashboardQueryServiceClientImpl(DashboardQueryService.DashboardQueryServiceClient grpcClient, DashboardQueryServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DashboardQueryServiceSettings effectiveSettings = settings ?? DashboardQueryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetDashboardQuery = clientHelper.BuildApiCall<GetDashboardQueryRequest, DashboardQuery>("GetDashboardQuery", grpcClient.GetDashboardQueryAsync, grpcClient.GetDashboardQuery, effectiveSettings.GetDashboardQuerySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDashboardQuery);
            Modify_GetDashboardQueryApiCall(ref _callGetDashboardQuery);
            _callExecuteDashboardQuery = clientHelper.BuildApiCall<ExecuteDashboardQueryRequest, ExecuteDashboardQueryResponse>("ExecuteDashboardQuery", grpcClient.ExecuteDashboardQueryAsync, grpcClient.ExecuteDashboardQuery, effectiveSettings.ExecuteDashboardQuerySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExecuteDashboardQuery);
            Modify_ExecuteDashboardQueryApiCall(ref _callExecuteDashboardQuery);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDashboardQueryApiCall(ref gaxgrpc::ApiCall<GetDashboardQueryRequest, DashboardQuery> call);

        partial void Modify_ExecuteDashboardQueryApiCall(ref gaxgrpc::ApiCall<ExecuteDashboardQueryRequest, ExecuteDashboardQueryResponse> call);

        partial void OnConstruction(DashboardQueryService.DashboardQueryServiceClient grpcClient, DashboardQueryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DashboardQueryService client</summary>
        public override DashboardQueryService.DashboardQueryServiceClient GrpcClient { get; }

        partial void Modify_GetDashboardQueryRequest(ref GetDashboardQueryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExecuteDashboardQueryRequest(ref ExecuteDashboardQueryRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get a dashboard query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DashboardQuery GetDashboardQuery(GetDashboardQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDashboardQueryRequest(ref request, ref callSettings);
            return _callGetDashboardQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a dashboard query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DashboardQuery> GetDashboardQueryAsync(GetDashboardQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDashboardQueryRequest(ref request, ref callSettings);
            return _callGetDashboardQuery.Async(request, callSettings);
        }

        /// <summary>
        /// Execute a query and return the data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExecuteDashboardQueryResponse ExecuteDashboardQuery(ExecuteDashboardQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteDashboardQueryRequest(ref request, ref callSettings);
            return _callExecuteDashboardQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// Execute a query and return the data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExecuteDashboardQueryResponse> ExecuteDashboardQueryAsync(ExecuteDashboardQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteDashboardQueryRequest(ref request, ref callSettings);
            return _callExecuteDashboardQuery.Async(request, callSettings);
        }
    }
}
