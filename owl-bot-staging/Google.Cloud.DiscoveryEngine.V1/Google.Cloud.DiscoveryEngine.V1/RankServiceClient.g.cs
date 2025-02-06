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

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Settings for <see cref="RankServiceClient"/> instances.</summary>
    public sealed partial class RankServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RankServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RankServiceSettings"/>.</returns>
        public static RankServiceSettings GetDefault() => new RankServiceSettings();

        /// <summary>Constructs a new <see cref="RankServiceSettings"/> object with default settings.</summary>
        public RankServiceSettings()
        {
        }

        private RankServiceSettings(RankServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RankSettings = existing.RankSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RankServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RankServiceClient.Rank</c>
        /// and <c>RankServiceClient.RankAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RankSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RankServiceSettings"/> object.</returns>
        public RankServiceSettings Clone() => new RankServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RankServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class RankServiceClientBuilder : gaxgrpc::ClientBuilderBase<RankServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RankServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RankServiceClientBuilder() : base(RankServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RankServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RankServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RankServiceClient Build()
        {
            RankServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RankServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RankServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RankServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RankServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RankServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RankServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RankServiceClient.ChannelPool;
    }

    /// <summary>RankService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for ranking text records.
    /// </remarks>
    public abstract partial class RankServiceClient
    {
        /// <summary>
        /// The default endpoint for the RankService service, which is a host of "discoveryengine.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default RankService scopes.</summary>
        /// <remarks>
        /// The default RankService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RankService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RankServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RankServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RankServiceClient"/>.</returns>
        public static stt::Task<RankServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RankServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RankServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RankServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RankServiceClient"/>.</returns>
        public static RankServiceClient Create() => new RankServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RankServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RankServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RankServiceClient"/>.</returns>
        internal static RankServiceClient Create(grpccore::CallInvoker callInvoker, RankServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RankService.RankServiceClient grpcClient = new RankService.RankServiceClient(callInvoker);
            return new RankServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RankService client</summary>
        public virtual RankService.RankServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Ranks a list of text records based on the given input query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RankResponse Rank(RankRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Ranks a list of text records based on the given input query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RankResponse> RankAsync(RankRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Ranks a list of text records based on the given input query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RankResponse> RankAsync(RankRequest request, st::CancellationToken cancellationToken) =>
            RankAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RankService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for ranking text records.
    /// </remarks>
    public sealed partial class RankServiceClientImpl : RankServiceClient
    {
        private readonly gaxgrpc::ApiCall<RankRequest, RankResponse> _callRank;

        /// <summary>
        /// Constructs a client wrapper for the RankService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RankServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RankServiceClientImpl(RankService.RankServiceClient grpcClient, RankServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RankServiceSettings effectiveSettings = settings ?? RankServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callRank = clientHelper.BuildApiCall<RankRequest, RankResponse>("Rank", grpcClient.RankAsync, grpcClient.Rank, effectiveSettings.RankSettings).WithGoogleRequestParam("ranking_config", request => request.RankingConfig);
            Modify_ApiCall(ref _callRank);
            Modify_RankApiCall(ref _callRank);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RankApiCall(ref gaxgrpc::ApiCall<RankRequest, RankResponse> call);

        partial void OnConstruction(RankService.RankServiceClient grpcClient, RankServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RankService client</summary>
        public override RankService.RankServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_RankRequest(ref RankRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Ranks a list of text records based on the given input query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RankResponse Rank(RankRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RankRequest(ref request, ref callSettings);
            return _callRank.Sync(request, callSettings);
        }

        /// <summary>
        /// Ranks a list of text records based on the given input query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RankResponse> RankAsync(RankRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RankRequest(ref request, ref callSettings);
            return _callRank.Async(request, callSettings);
        }
    }

    public static partial class RankService
    {
        public partial class RankServiceClient
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
