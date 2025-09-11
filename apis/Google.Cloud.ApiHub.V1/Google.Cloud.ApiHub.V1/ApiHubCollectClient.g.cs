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
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.ApiHub.V1
{
    /// <summary>Settings for <see cref="ApiHubCollectClient"/> instances.</summary>
    public sealed partial class ApiHubCollectSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ApiHubCollectSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ApiHubCollectSettings"/>.</returns>
        public static ApiHubCollectSettings GetDefault() => new ApiHubCollectSettings();

        /// <summary>Constructs a new <see cref="ApiHubCollectSettings"/> object with default settings.</summary>
        public ApiHubCollectSettings()
        {
        }

        private ApiHubCollectSettings(ApiHubCollectSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CollectApiDataSettings = existing.CollectApiDataSettings;
            CollectApiDataOperationsSettings = existing.CollectApiDataOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ApiHubCollectSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubCollectClient.CollectApiData</c> and <c>ApiHubCollectClient.CollectApiDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CollectApiDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ApiHubCollectClient.CollectApiData</c> and
        /// <c>ApiHubCollectClient.CollectApiDataAsync</c>.
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
        public lro::OperationsSettings CollectApiDataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ApiHubCollectSettings"/> object.</returns>
        public ApiHubCollectSettings Clone() => new ApiHubCollectSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ApiHubCollectClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ApiHubCollectClientBuilder : gaxgrpc::ClientBuilderBase<ApiHubCollectClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ApiHubCollectSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ApiHubCollectClientBuilder() : base(ApiHubCollectClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ApiHubCollectClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ApiHubCollectClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ApiHubCollectClient Build()
        {
            ApiHubCollectClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ApiHubCollectClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ApiHubCollectClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ApiHubCollectClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ApiHubCollectClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ApiHubCollectClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ApiHubCollectClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ApiHubCollectClient.ChannelPool;
    }

    /// <summary>ApiHubCollect client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service exposes methods used for collecting various types of data from
    /// different first party and third party sources and push it to Hub's collect
    /// layer.
    /// </remarks>
    public abstract partial class ApiHubCollectClient
    {
        /// <summary>
        /// The default endpoint for the ApiHubCollect service, which is a host of "apihub.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apihub.googleapis.com:443";

        /// <summary>The default ApiHubCollect scopes.</summary>
        /// <remarks>
        /// The default ApiHubCollect scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ApiHubCollect.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ApiHubCollectClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApiHubCollectClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ApiHubCollectClient"/>.</returns>
        public static stt::Task<ApiHubCollectClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ApiHubCollectClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ApiHubCollectClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApiHubCollectClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ApiHubCollectClient"/>.</returns>
        public static ApiHubCollectClient Create() => new ApiHubCollectClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ApiHubCollectClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ApiHubCollectSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ApiHubCollectClient"/>.</returns>
        internal static ApiHubCollectClient Create(grpccore::CallInvoker callInvoker, ApiHubCollectSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ApiHubCollect.ApiHubCollectClient grpcClient = new ApiHubCollect.ApiHubCollectClient(callInvoker);
            return new ApiHubCollectClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ApiHubCollect client</summary>
        public virtual ApiHubCollect.ApiHubCollectClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Collect API data from a source and push it to Hub's collect layer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CollectApiDataResponse, OperationMetadata> CollectApiData(CollectApiDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Collect API data from a source and push it to Hub's collect layer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CollectApiDataResponse, OperationMetadata>> CollectApiDataAsync(CollectApiDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Collect API data from a source and push it to Hub's collect layer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CollectApiDataResponse, OperationMetadata>> CollectApiDataAsync(CollectApiDataRequest request, st::CancellationToken cancellationToken) =>
            CollectApiDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CollectApiData</c>.</summary>
        public virtual lro::OperationsClient CollectApiDataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CollectApiData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CollectApiDataResponse, OperationMetadata> PollOnceCollectApiData(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CollectApiDataResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CollectApiDataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CollectApiData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CollectApiDataResponse, OperationMetadata>> PollOnceCollectApiDataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CollectApiDataResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CollectApiDataOperationsClient, callSettings);

        /// <summary>
        /// Collect API data from a source and push it to Hub's collect layer.
        /// </summary>
        /// <param name="location">
        /// Required. The regional location of the API hub instance and its resources.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="collectionType">
        /// Required. The type of collection. Applies to all entries in
        /// [api_data][google.cloud.apihub.v1.CollectApiDataRequest.api_data].
        /// </param>
        /// <param name="apiData">
        /// Required. The API data to be collected.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CollectApiDataResponse, OperationMetadata> CollectApiData(string location, CollectionType collectionType, ApiData apiData, gaxgrpc::CallSettings callSettings = null) =>
            CollectApiData(new CollectApiDataRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
                CollectionType = collectionType,
                ApiData = gax::GaxPreconditions.CheckNotNull(apiData, nameof(apiData)),
            }, callSettings);

        /// <summary>
        /// Collect API data from a source and push it to Hub's collect layer.
        /// </summary>
        /// <param name="location">
        /// Required. The regional location of the API hub instance and its resources.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="collectionType">
        /// Required. The type of collection. Applies to all entries in
        /// [api_data][google.cloud.apihub.v1.CollectApiDataRequest.api_data].
        /// </param>
        /// <param name="apiData">
        /// Required. The API data to be collected.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CollectApiDataResponse, OperationMetadata>> CollectApiDataAsync(string location, CollectionType collectionType, ApiData apiData, gaxgrpc::CallSettings callSettings = null) =>
            CollectApiDataAsync(new CollectApiDataRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
                CollectionType = collectionType,
                ApiData = gax::GaxPreconditions.CheckNotNull(apiData, nameof(apiData)),
            }, callSettings);

        /// <summary>
        /// Collect API data from a source and push it to Hub's collect layer.
        /// </summary>
        /// <param name="location">
        /// Required. The regional location of the API hub instance and its resources.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="collectionType">
        /// Required. The type of collection. Applies to all entries in
        /// [api_data][google.cloud.apihub.v1.CollectApiDataRequest.api_data].
        /// </param>
        /// <param name="apiData">
        /// Required. The API data to be collected.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CollectApiDataResponse, OperationMetadata>> CollectApiDataAsync(string location, CollectionType collectionType, ApiData apiData, st::CancellationToken cancellationToken) =>
            CollectApiDataAsync(location, collectionType, apiData, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Collect API data from a source and push it to Hub's collect layer.
        /// </summary>
        /// <param name="location">
        /// Required. The regional location of the API hub instance and its resources.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="collectionType">
        /// Required. The type of collection. Applies to all entries in
        /// [api_data][google.cloud.apihub.v1.CollectApiDataRequest.api_data].
        /// </param>
        /// <param name="apiData">
        /// Required. The API data to be collected.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CollectApiDataResponse, OperationMetadata> CollectApiData(gagr::LocationName location, CollectionType collectionType, ApiData apiData, gaxgrpc::CallSettings callSettings = null) =>
            CollectApiData(new CollectApiDataRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
                CollectionType = collectionType,
                ApiData = gax::GaxPreconditions.CheckNotNull(apiData, nameof(apiData)),
            }, callSettings);

        /// <summary>
        /// Collect API data from a source and push it to Hub's collect layer.
        /// </summary>
        /// <param name="location">
        /// Required. The regional location of the API hub instance and its resources.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="collectionType">
        /// Required. The type of collection. Applies to all entries in
        /// [api_data][google.cloud.apihub.v1.CollectApiDataRequest.api_data].
        /// </param>
        /// <param name="apiData">
        /// Required. The API data to be collected.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CollectApiDataResponse, OperationMetadata>> CollectApiDataAsync(gagr::LocationName location, CollectionType collectionType, ApiData apiData, gaxgrpc::CallSettings callSettings = null) =>
            CollectApiDataAsync(new CollectApiDataRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
                CollectionType = collectionType,
                ApiData = gax::GaxPreconditions.CheckNotNull(apiData, nameof(apiData)),
            }, callSettings);

        /// <summary>
        /// Collect API data from a source and push it to Hub's collect layer.
        /// </summary>
        /// <param name="location">
        /// Required. The regional location of the API hub instance and its resources.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="collectionType">
        /// Required. The type of collection. Applies to all entries in
        /// [api_data][google.cloud.apihub.v1.CollectApiDataRequest.api_data].
        /// </param>
        /// <param name="apiData">
        /// Required. The API data to be collected.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CollectApiDataResponse, OperationMetadata>> CollectApiDataAsync(gagr::LocationName location, CollectionType collectionType, ApiData apiData, st::CancellationToken cancellationToken) =>
            CollectApiDataAsync(location, collectionType, apiData, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ApiHubCollect client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service exposes methods used for collecting various types of data from
    /// different first party and third party sources and push it to Hub's collect
    /// layer.
    /// </remarks>
    public sealed partial class ApiHubCollectClientImpl : ApiHubCollectClient
    {
        private readonly gaxgrpc::ApiCall<CollectApiDataRequest, lro::Operation> _callCollectApiData;

        /// <summary>
        /// Constructs a client wrapper for the ApiHubCollect service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ApiHubCollectSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ApiHubCollectClientImpl(ApiHubCollect.ApiHubCollectClient grpcClient, ApiHubCollectSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ApiHubCollectSettings effectiveSettings = settings ?? ApiHubCollectSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CollectApiDataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CollectApiDataOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCollectApiData = clientHelper.BuildApiCall<CollectApiDataRequest, lro::Operation>("CollectApiData", grpcClient.CollectApiDataAsync, grpcClient.CollectApiData, effectiveSettings.CollectApiDataSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callCollectApiData);
            Modify_CollectApiDataApiCall(ref _callCollectApiData);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CollectApiDataApiCall(ref gaxgrpc::ApiCall<CollectApiDataRequest, lro::Operation> call);

        partial void OnConstruction(ApiHubCollect.ApiHubCollectClient grpcClient, ApiHubCollectSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ApiHubCollect client</summary>
        public override ApiHubCollect.ApiHubCollectClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CollectApiDataRequest(ref CollectApiDataRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CollectApiData</c>.</summary>
        public override lro::OperationsClient CollectApiDataOperationsClient { get; }

        /// <summary>
        /// Collect API data from a source and push it to Hub's collect layer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CollectApiDataResponse, OperationMetadata> CollectApiData(CollectApiDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CollectApiDataRequest(ref request, ref callSettings);
            return new lro::Operation<CollectApiDataResponse, OperationMetadata>(_callCollectApiData.Sync(request, callSettings), CollectApiDataOperationsClient);
        }

        /// <summary>
        /// Collect API data from a source and push it to Hub's collect layer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CollectApiDataResponse, OperationMetadata>> CollectApiDataAsync(CollectApiDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CollectApiDataRequest(ref request, ref callSettings);
            return new lro::Operation<CollectApiDataResponse, OperationMetadata>(await _callCollectApiData.Async(request, callSettings).ConfigureAwait(false), CollectApiDataOperationsClient);
        }
    }

    public static partial class ApiHubCollect
    {
        public partial class ApiHubCollectClient
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

    public static partial class ApiHubCollect
    {
        public partial class ApiHubCollectClient
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
