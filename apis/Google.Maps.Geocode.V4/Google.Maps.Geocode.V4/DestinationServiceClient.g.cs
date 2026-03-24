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

namespace Google.Maps.Geocode.V4
{
    /// <summary>Settings for <see cref="DestinationServiceClient"/> instances.</summary>
    public sealed partial class DestinationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DestinationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DestinationServiceSettings"/>.</returns>
        public static DestinationServiceSettings GetDefault() => new DestinationServiceSettings();

        /// <summary>Constructs a new <see cref="DestinationServiceSettings"/> object with default settings.</summary>
        public DestinationServiceSettings()
        {
        }

        private DestinationServiceSettings(DestinationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchDestinationsSettings = existing.SearchDestinationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DestinationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DestinationServiceClient.SearchDestinations</c> and <c>DestinationServiceClient.SearchDestinationsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchDestinationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DestinationServiceSettings"/> object.</returns>
        public DestinationServiceSettings Clone() => new DestinationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DestinationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DestinationServiceClientBuilder : gaxgrpc::ClientBuilderBase<DestinationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DestinationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DestinationServiceClientBuilder() : base(DestinationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DestinationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DestinationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DestinationServiceClient Build()
        {
            DestinationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DestinationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DestinationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DestinationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DestinationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DestinationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DestinationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DestinationServiceClient.ChannelPool;
    }

    /// <summary>DestinationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for retrieving destinations.
    /// 
    /// A destination provides hierarchical context about a place, which
    /// allows you to, for example, find apartment buildings within a larger
    /// apartment complex and vice versa. It also provides navigation points suitable
    /// for use cases such as ridesharing or delivery.
    /// </remarks>
    public abstract partial class DestinationServiceClient
    {
        /// <summary>
        /// The default endpoint for the DestinationService service, which is a host of
        /// "geocoding-backend.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "geocoding-backend.googleapis.com:443";

        /// <summary>The default DestinationService scopes.</summary>
        /// <remarks>
        /// The default DestinationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/maps-platform.destinations</description></item>
        /// <item><description>https://www.googleapis.com/auth/maps-platform.geocode</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/maps-platform.destinations",
            "https://www.googleapis.com/auth/maps-platform.geocode",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DestinationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DestinationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DestinationServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DestinationServiceClient"/>.</returns>
        public static stt::Task<DestinationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DestinationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DestinationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DestinationServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="DestinationServiceClient"/>.</returns>
        public static DestinationServiceClient Create() => new DestinationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DestinationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DestinationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DestinationServiceClient"/>.</returns>
        internal static DestinationServiceClient Create(grpccore::CallInvoker callInvoker, DestinationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DestinationService.DestinationServiceClient grpcClient = new DestinationService.DestinationServiceClient(callInvoker);
            return new DestinationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DestinationService client</summary>
        public virtual DestinationService.DestinationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// This method performs a destination lookup and returns a list of
        /// destinations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchDestinationsResponse SearchDestinations(SearchDestinationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method performs a destination lookup and returns a list of
        /// destinations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchDestinationsResponse> SearchDestinationsAsync(SearchDestinationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method performs a destination lookup and returns a list of
        /// destinations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchDestinationsResponse> SearchDestinationsAsync(SearchDestinationsRequest request, st::CancellationToken cancellationToken) =>
            SearchDestinationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DestinationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for retrieving destinations.
    /// 
    /// A destination provides hierarchical context about a place, which
    /// allows you to, for example, find apartment buildings within a larger
    /// apartment complex and vice versa. It also provides navigation points suitable
    /// for use cases such as ridesharing or delivery.
    /// </remarks>
    public sealed partial class DestinationServiceClientImpl : DestinationServiceClient
    {
        private readonly gaxgrpc::ApiCall<SearchDestinationsRequest, SearchDestinationsResponse> _callSearchDestinations;

        /// <summary>
        /// Constructs a client wrapper for the DestinationService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DestinationServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DestinationServiceClientImpl(DestinationService.DestinationServiceClient grpcClient, DestinationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DestinationServiceSettings effectiveSettings = settings ?? DestinationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callSearchDestinations = clientHelper.BuildApiCall<SearchDestinationsRequest, SearchDestinationsResponse>("SearchDestinations", grpcClient.SearchDestinationsAsync, grpcClient.SearchDestinations, effectiveSettings.SearchDestinationsSettings);
            Modify_ApiCall(ref _callSearchDestinations);
            Modify_SearchDestinationsApiCall(ref _callSearchDestinations);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SearchDestinationsApiCall(ref gaxgrpc::ApiCall<SearchDestinationsRequest, SearchDestinationsResponse> call);

        partial void OnConstruction(DestinationService.DestinationServiceClient grpcClient, DestinationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DestinationService client</summary>
        public override DestinationService.DestinationServiceClient GrpcClient { get; }

        partial void Modify_SearchDestinationsRequest(ref SearchDestinationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// This method performs a destination lookup and returns a list of
        /// destinations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchDestinationsResponse SearchDestinations(SearchDestinationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchDestinationsRequest(ref request, ref callSettings);
            return _callSearchDestinations.Sync(request, callSettings);
        }

        /// <summary>
        /// This method performs a destination lookup and returns a list of
        /// destinations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchDestinationsResponse> SearchDestinationsAsync(SearchDestinationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchDestinationsRequest(ref request, ref callSettings);
            return _callSearchDestinations.Async(request, callSettings);
        }
    }
}
