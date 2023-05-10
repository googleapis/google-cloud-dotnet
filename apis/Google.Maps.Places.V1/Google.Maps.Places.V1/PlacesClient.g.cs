// Copyright 2023 Google LLC
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
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Maps.Places.V1
{
    /// <summary>Settings for <see cref="PlacesClient"/> instances.</summary>
    public sealed partial class PlacesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PlacesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PlacesSettings"/>.</returns>
        public static PlacesSettings GetDefault() => new PlacesSettings();

        /// <summary>Constructs a new <see cref="PlacesSettings"/> object with default settings.</summary>
        public PlacesSettings()
        {
        }

        private PlacesSettings(PlacesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchTextSettings = existing.SearchTextSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PlacesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PlacesClient.SearchText</c>
        /// and <c>PlacesClient.SearchTextAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchTextSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PlacesSettings"/> object.</returns>
        public PlacesSettings Clone() => new PlacesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PlacesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class PlacesClientBuilder : gaxgrpc::ClientBuilderBase<PlacesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PlacesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PlacesClientBuilder() : base(PlacesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PlacesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PlacesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PlacesClient Build()
        {
            PlacesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PlacesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PlacesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PlacesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PlacesClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<PlacesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PlacesClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PlacesClient.ChannelPool;
    }

    /// <summary>Places client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service definition for the Places API.
    /// </remarks>
    public abstract partial class PlacesClient
    {
        /// <summary>
        /// The default endpoint for the Places service, which is a host of "places.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "places.googleapis.com:443";

        /// <summary>The default Places scopes.</summary>
        /// <remarks>The default Places scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Places.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PlacesClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="PlacesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PlacesClient"/>.</returns>
        public static stt::Task<PlacesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PlacesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PlacesClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="PlacesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PlacesClient"/>.</returns>
        public static PlacesClient Create() => new PlacesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PlacesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PlacesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PlacesClient"/>.</returns>
        internal static PlacesClient Create(grpccore::CallInvoker callInvoker, PlacesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Places.PlacesClient grpcClient = new Places.PlacesClient(callInvoker);
            return new PlacesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Places client</summary>
        public virtual Places.PlacesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Text query based place search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchTextResponse SearchText(SearchTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Text query based place search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchTextResponse> SearchTextAsync(SearchTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Text query based place search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchTextResponse> SearchTextAsync(SearchTextRequest request, st::CancellationToken cancellationToken) =>
            SearchTextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Places client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service definition for the Places API.
    /// </remarks>
    public sealed partial class PlacesClientImpl : PlacesClient
    {
        private readonly gaxgrpc::ApiCall<SearchTextRequest, SearchTextResponse> _callSearchText;

        /// <summary>
        /// Constructs a client wrapper for the Places service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PlacesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PlacesClientImpl(Places.PlacesClient grpcClient, PlacesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PlacesSettings effectiveSettings = settings ?? PlacesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callSearchText = clientHelper.BuildApiCall<SearchTextRequest, SearchTextResponse>("SearchText", grpcClient.SearchTextAsync, grpcClient.SearchText, effectiveSettings.SearchTextSettings);
            Modify_ApiCall(ref _callSearchText);
            Modify_SearchTextApiCall(ref _callSearchText);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SearchTextApiCall(ref gaxgrpc::ApiCall<SearchTextRequest, SearchTextResponse> call);

        partial void OnConstruction(Places.PlacesClient grpcClient, PlacesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Places client</summary>
        public override Places.PlacesClient GrpcClient { get; }

        partial void Modify_SearchTextRequest(ref SearchTextRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Text query based place search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchTextResponse SearchText(SearchTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchTextRequest(ref request, ref callSettings);
            return _callSearchText.Sync(request, callSettings);
        }

        /// <summary>
        /// Text query based place search.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchTextResponse> SearchTextAsync(SearchTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchTextRequest(ref request, ref callSettings);
            return _callSearchText.Async(request, callSettings);
        }
    }
}
