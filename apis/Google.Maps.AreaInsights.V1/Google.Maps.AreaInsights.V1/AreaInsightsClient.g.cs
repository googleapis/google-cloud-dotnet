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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Maps.AreaInsights.V1
{
    /// <summary>Settings for <see cref="AreaInsightsClient"/> instances.</summary>
    public sealed partial class AreaInsightsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AreaInsightsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AreaInsightsSettings"/>.</returns>
        public static AreaInsightsSettings GetDefault() => new AreaInsightsSettings();

        /// <summary>Constructs a new <see cref="AreaInsightsSettings"/> object with default settings.</summary>
        public AreaInsightsSettings()
        {
        }

        private AreaInsightsSettings(AreaInsightsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ComputeInsightsSettings = existing.ComputeInsightsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AreaInsightsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AreaInsightsClient.ComputeInsights</c> and <c>AreaInsightsClient.ComputeInsightsAsync</c>.
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
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ComputeInsightsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AreaInsightsSettings"/> object.</returns>
        public AreaInsightsSettings Clone() => new AreaInsightsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AreaInsightsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AreaInsightsClientBuilder : gaxgrpc::ClientBuilderBase<AreaInsightsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AreaInsightsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AreaInsightsClientBuilder() : base(AreaInsightsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AreaInsightsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AreaInsightsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AreaInsightsClient Build()
        {
            AreaInsightsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AreaInsightsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AreaInsightsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AreaInsightsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AreaInsightsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AreaInsightsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AreaInsightsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AreaInsightsClient.ChannelPool;
    }

    /// <summary>AreaInsights client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service definition for the Places Insights API.
    /// </remarks>
    public abstract partial class AreaInsightsClient
    {
        /// <summary>
        /// The default endpoint for the AreaInsights service, which is a host of "areainsights.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "areainsights.googleapis.com:443";

        /// <summary>The default AreaInsights scopes.</summary>
        /// <remarks>
        /// The default AreaInsights scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AreaInsights.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AreaInsightsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AreaInsightsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AreaInsightsClient"/>.</returns>
        public static stt::Task<AreaInsightsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AreaInsightsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AreaInsightsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AreaInsightsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AreaInsightsClient"/>.</returns>
        public static AreaInsightsClient Create() => new AreaInsightsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AreaInsightsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AreaInsightsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AreaInsightsClient"/>.</returns>
        internal static AreaInsightsClient Create(grpccore::CallInvoker callInvoker, AreaInsightsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AreaInsights.AreaInsightsClient grpcClient = new AreaInsights.AreaInsightsClient(callInvoker);
            return new AreaInsightsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AreaInsights client</summary>
        public virtual AreaInsights.AreaInsightsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Compute Insights RPC
        /// 
        /// This method lets you retrieve insights about areas using a variaty of
        /// filter such as: area, place type, operating status, price level
        /// and ratings. Currently "count" and "places" insights are supported. With
        /// "count" insights you can answer questions such as "How many restaurant are
        /// located in California that are operational, are inexpensive and have an
        /// average rating of at least 4 stars" (see `insight` enum for more details).
        /// With "places" insights, you can determine which places match the
        /// requested filter. Clients can then use those place resource names to fetch
        /// more details about each individual place using the Places API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeInsightsResponse ComputeInsights(ComputeInsightsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Compute Insights RPC
        /// 
        /// This method lets you retrieve insights about areas using a variaty of
        /// filter such as: area, place type, operating status, price level
        /// and ratings. Currently "count" and "places" insights are supported. With
        /// "count" insights you can answer questions such as "How many restaurant are
        /// located in California that are operational, are inexpensive and have an
        /// average rating of at least 4 stars" (see `insight` enum for more details).
        /// With "places" insights, you can determine which places match the
        /// requested filter. Clients can then use those place resource names to fetch
        /// more details about each individual place using the Places API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeInsightsResponse> ComputeInsightsAsync(ComputeInsightsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Compute Insights RPC
        /// 
        /// This method lets you retrieve insights about areas using a variaty of
        /// filter such as: area, place type, operating status, price level
        /// and ratings. Currently "count" and "places" insights are supported. With
        /// "count" insights you can answer questions such as "How many restaurant are
        /// located in California that are operational, are inexpensive and have an
        /// average rating of at least 4 stars" (see `insight` enum for more details).
        /// With "places" insights, you can determine which places match the
        /// requested filter. Clients can then use those place resource names to fetch
        /// more details about each individual place using the Places API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeInsightsResponse> ComputeInsightsAsync(ComputeInsightsRequest request, st::CancellationToken cancellationToken) =>
            ComputeInsightsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AreaInsights client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service definition for the Places Insights API.
    /// </remarks>
    public sealed partial class AreaInsightsClientImpl : AreaInsightsClient
    {
        private readonly gaxgrpc::ApiCall<ComputeInsightsRequest, ComputeInsightsResponse> _callComputeInsights;

        /// <summary>
        /// Constructs a client wrapper for the AreaInsights service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AreaInsightsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AreaInsightsClientImpl(AreaInsights.AreaInsightsClient grpcClient, AreaInsightsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AreaInsightsSettings effectiveSettings = settings ?? AreaInsightsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callComputeInsights = clientHelper.BuildApiCall<ComputeInsightsRequest, ComputeInsightsResponse>("ComputeInsights", grpcClient.ComputeInsightsAsync, grpcClient.ComputeInsights, effectiveSettings.ComputeInsightsSettings);
            Modify_ApiCall(ref _callComputeInsights);
            Modify_ComputeInsightsApiCall(ref _callComputeInsights);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ComputeInsightsApiCall(ref gaxgrpc::ApiCall<ComputeInsightsRequest, ComputeInsightsResponse> call);

        partial void OnConstruction(AreaInsights.AreaInsightsClient grpcClient, AreaInsightsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AreaInsights client</summary>
        public override AreaInsights.AreaInsightsClient GrpcClient { get; }

        partial void Modify_ComputeInsightsRequest(ref ComputeInsightsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Compute Insights RPC
        /// 
        /// This method lets you retrieve insights about areas using a variaty of
        /// filter such as: area, place type, operating status, price level
        /// and ratings. Currently "count" and "places" insights are supported. With
        /// "count" insights you can answer questions such as "How many restaurant are
        /// located in California that are operational, are inexpensive and have an
        /// average rating of at least 4 stars" (see `insight` enum for more details).
        /// With "places" insights, you can determine which places match the
        /// requested filter. Clients can then use those place resource names to fetch
        /// more details about each individual place using the Places API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ComputeInsightsResponse ComputeInsights(ComputeInsightsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeInsightsRequest(ref request, ref callSettings);
            return _callComputeInsights.Sync(request, callSettings);
        }

        /// <summary>
        /// Compute Insights RPC
        /// 
        /// This method lets you retrieve insights about areas using a variaty of
        /// filter such as: area, place type, operating status, price level
        /// and ratings. Currently "count" and "places" insights are supported. With
        /// "count" insights you can answer questions such as "How many restaurant are
        /// located in California that are operational, are inexpensive and have an
        /// average rating of at least 4 stars" (see `insight` enum for more details).
        /// With "places" insights, you can determine which places match the
        /// requested filter. Clients can then use those place resource names to fetch
        /// more details about each individual place using the Places API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ComputeInsightsResponse> ComputeInsightsAsync(ComputeInsightsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeInsightsRequest(ref request, ref callSettings);
            return _callComputeInsights.Async(request, callSettings);
        }
    }
}
