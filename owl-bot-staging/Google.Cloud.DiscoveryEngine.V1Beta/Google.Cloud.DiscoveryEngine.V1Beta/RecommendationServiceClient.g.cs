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
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Settings for <see cref="RecommendationServiceClient"/> instances.</summary>
    public sealed partial class RecommendationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RecommendationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RecommendationServiceSettings"/>.</returns>
        public static RecommendationServiceSettings GetDefault() => new RecommendationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="RecommendationServiceSettings"/> object with default settings.
        /// </summary>
        public RecommendationServiceSettings()
        {
        }

        private RecommendationServiceSettings(RecommendationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RecommendSettings = existing.RecommendSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RecommendationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommendationServiceClient.Recommend</c> and <c>RecommendationServiceClient.RecommendAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RecommendSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RecommendationServiceSettings"/> object.</returns>
        public RecommendationServiceSettings Clone() => new RecommendationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RecommendationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class RecommendationServiceClientBuilder : gaxgrpc::ClientBuilderBase<RecommendationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RecommendationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RecommendationServiceClientBuilder() : base(RecommendationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RecommendationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RecommendationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RecommendationServiceClient Build()
        {
            RecommendationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RecommendationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RecommendationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RecommendationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RecommendationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RecommendationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RecommendationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RecommendationServiceClient.ChannelPool;
    }

    /// <summary>RecommendationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for making recommendations.
    /// </remarks>
    public abstract partial class RecommendationServiceClient
    {
        /// <summary>
        /// The default endpoint for the RecommendationService service, which is a host of
        /// "discoveryengine.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default RecommendationService scopes.</summary>
        /// <remarks>
        /// The default RecommendationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RecommendationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RecommendationServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="RecommendationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RecommendationServiceClient"/>.</returns>
        public static stt::Task<RecommendationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RecommendationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RecommendationServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="RecommendationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RecommendationServiceClient"/>.</returns>
        public static RecommendationServiceClient Create() => new RecommendationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RecommendationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RecommendationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RecommendationServiceClient"/>.</returns>
        internal static RecommendationServiceClient Create(grpccore::CallInvoker callInvoker, RecommendationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RecommendationService.RecommendationServiceClient grpcClient = new RecommendationService.RecommendationServiceClient(callInvoker);
            return new RecommendationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RecommendationService client</summary>
        public virtual RecommendationService.RecommendationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Makes a recommendation, which requires a contextual user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RecommendResponse Recommend(RecommendRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Makes a recommendation, which requires a contextual user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecommendResponse> RecommendAsync(RecommendRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Makes a recommendation, which requires a contextual user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecommendResponse> RecommendAsync(RecommendRequest request, st::CancellationToken cancellationToken) =>
            RecommendAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RecommendationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for making recommendations.
    /// </remarks>
    public sealed partial class RecommendationServiceClientImpl : RecommendationServiceClient
    {
        private readonly gaxgrpc::ApiCall<RecommendRequest, RecommendResponse> _callRecommend;

        /// <summary>
        /// Constructs a client wrapper for the RecommendationService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RecommendationServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RecommendationServiceClientImpl(RecommendationService.RecommendationServiceClient grpcClient, RecommendationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RecommendationServiceSettings effectiveSettings = settings ?? RecommendationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callRecommend = clientHelper.BuildApiCall<RecommendRequest, RecommendResponse>("Recommend", grpcClient.RecommendAsync, grpcClient.Recommend, effectiveSettings.RecommendSettings).WithGoogleRequestParam("serving_config", request => request.ServingConfig);
            Modify_ApiCall(ref _callRecommend);
            Modify_RecommendApiCall(ref _callRecommend);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RecommendApiCall(ref gaxgrpc::ApiCall<RecommendRequest, RecommendResponse> call);

        partial void OnConstruction(RecommendationService.RecommendationServiceClient grpcClient, RecommendationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RecommendationService client</summary>
        public override RecommendationService.RecommendationServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_RecommendRequest(ref RecommendRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Makes a recommendation, which requires a contextual user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RecommendResponse Recommend(RecommendRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RecommendRequest(ref request, ref callSettings);
            return _callRecommend.Sync(request, callSettings);
        }

        /// <summary>
        /// Makes a recommendation, which requires a contextual user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RecommendResponse> RecommendAsync(RecommendRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RecommendRequest(ref request, ref callSettings);
            return _callRecommend.Async(request, callSettings);
        }
    }

    public static partial class RecommendationService
    {
        public partial class RecommendationServiceClient
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
