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

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>Settings for <see cref="QueryServiceClient"/> instances.</summary>
    public sealed partial class QueryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="QueryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="QueryServiceSettings"/>.</returns>
        public static QueryServiceSettings GetDefault() => new QueryServiceSettings();

        /// <summary>Constructs a new <see cref="QueryServiceSettings"/> object with default settings.</summary>
        public QueryServiceSettings()
        {
        }

        private QueryServiceSettings(QueryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            QueryTimeSeriesSettings = existing.QueryTimeSeriesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(QueryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>QueryServiceClient.QueryTimeSeries</c> and <c>QueryServiceClient.QueryTimeSeriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryTimeSeriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="QueryServiceSettings"/> object.</returns>
        public QueryServiceSettings Clone() => new QueryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="QueryServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class QueryServiceClientBuilder : gaxgrpc::ClientBuilderBase<QueryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public QueryServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public QueryServiceClientBuilder() : base(QueryServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref QueryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<QueryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override QueryServiceClient Build()
        {
            QueryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<QueryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<QueryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private QueryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return QueryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<QueryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return QueryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => QueryServiceClient.ChannelPool;
    }

    /// <summary>QueryService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The QueryService API is used to manage time series data in Cloud
    /// Monitoring. Time series data is a collection of data points that describes
    /// the time-varying values of a metric.
    /// </remarks>
    public abstract partial class QueryServiceClient
    {
        /// <summary>
        /// The default endpoint for the QueryService service, which is a host of "monitoring.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "monitoring.googleapis.com:443";

        /// <summary>The default QueryService scopes.</summary>
        /// <remarks>
        /// The default QueryService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring.read</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(QueryService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="QueryServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="QueryServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="QueryServiceClient"/>.</returns>
        public static stt::Task<QueryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new QueryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="QueryServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="QueryServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="QueryServiceClient"/>.</returns>
        public static QueryServiceClient Create() => new QueryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="QueryServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="QueryServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="QueryServiceClient"/>.</returns>
        internal static QueryServiceClient Create(grpccore::CallInvoker callInvoker, QueryServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            QueryService.QueryServiceClient grpcClient = new QueryService.QueryServiceClient(callInvoker);
            return new QueryServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC QueryService client</summary>
        public virtual QueryService.QueryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Queries time series using Monitoring Query Language.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TimeSeriesData"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryTimeSeriesResponse, TimeSeriesData> QueryTimeSeries(QueryTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Queries time series using Monitoring Query Language.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TimeSeriesData"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryTimeSeriesResponse, TimeSeriesData> QueryTimeSeriesAsync(QueryTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>QueryService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The QueryService API is used to manage time series data in Cloud
    /// Monitoring. Time series data is a collection of data points that describes
    /// the time-varying values of a metric.
    /// </remarks>
    public sealed partial class QueryServiceClientImpl : QueryServiceClient
    {
        private readonly gaxgrpc::ApiCall<QueryTimeSeriesRequest, QueryTimeSeriesResponse> _callQueryTimeSeries;

        /// <summary>
        /// Constructs a client wrapper for the QueryService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="QueryServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public QueryServiceClientImpl(QueryService.QueryServiceClient grpcClient, QueryServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            QueryServiceSettings effectiveSettings = settings ?? QueryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callQueryTimeSeries = clientHelper.BuildApiCall<QueryTimeSeriesRequest, QueryTimeSeriesResponse>("QueryTimeSeries", grpcClient.QueryTimeSeriesAsync, grpcClient.QueryTimeSeries, effectiveSettings.QueryTimeSeriesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callQueryTimeSeries);
            Modify_QueryTimeSeriesApiCall(ref _callQueryTimeSeries);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_QueryTimeSeriesApiCall(ref gaxgrpc::ApiCall<QueryTimeSeriesRequest, QueryTimeSeriesResponse> call);

        partial void OnConstruction(QueryService.QueryServiceClient grpcClient, QueryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC QueryService client</summary>
        public override QueryService.QueryServiceClient GrpcClient { get; }

        partial void Modify_QueryTimeSeriesRequest(ref QueryTimeSeriesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Queries time series using Monitoring Query Language.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TimeSeriesData"/> resources.</returns>
        public override gax::PagedEnumerable<QueryTimeSeriesResponse, TimeSeriesData> QueryTimeSeries(QueryTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryTimeSeriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryTimeSeriesRequest, QueryTimeSeriesResponse, TimeSeriesData>(_callQueryTimeSeries, request, callSettings);
        }

        /// <summary>
        /// Queries time series using Monitoring Query Language.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TimeSeriesData"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<QueryTimeSeriesResponse, TimeSeriesData> QueryTimeSeriesAsync(QueryTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryTimeSeriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryTimeSeriesRequest, QueryTimeSeriesResponse, TimeSeriesData>(_callQueryTimeSeries, request, callSettings);
        }
    }

    public partial class QueryTimeSeriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryTimeSeriesResponse : gaxgrpc::IPageResponse<TimeSeriesData>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TimeSeriesData> GetEnumerator() => TimeSeriesData.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
