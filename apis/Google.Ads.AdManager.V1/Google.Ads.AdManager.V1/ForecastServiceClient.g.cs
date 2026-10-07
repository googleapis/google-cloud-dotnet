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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="ForecastServiceClient"/> instances.</summary>
    public sealed partial class ForecastServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ForecastServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ForecastServiceSettings"/>.</returns>
        public static ForecastServiceSettings GetDefault() => new ForecastServiceSettings();

        /// <summary>Constructs a new <see cref="ForecastServiceSettings"/> object with default settings.</summary>
        public ForecastServiceSettings()
        {
        }

        private ForecastServiceSettings(ForecastServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RunAvailabilityForecastSettings = existing.RunAvailabilityForecastSettings;
            RunDeliveryForecastSettings = existing.RunDeliveryForecastSettings;
            RunTrafficDataSettings = existing.RunTrafficDataSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ForecastServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ForecastServiceClient.RunAvailabilityForecast</c> and
        /// <c>ForecastServiceClient.RunAvailabilityForecastAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunAvailabilityForecastSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ForecastServiceClient.RunDeliveryForecast</c> and <c>ForecastServiceClient.RunDeliveryForecastAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunDeliveryForecastSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ForecastServiceClient.RunTrafficData</c> and <c>ForecastServiceClient.RunTrafficDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunTrafficDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ForecastServiceSettings"/> object.</returns>
        public ForecastServiceSettings Clone() => new ForecastServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ForecastServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ForecastServiceClientBuilder : gaxgrpc::ClientBuilderBase<ForecastServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ForecastServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ForecastServiceClientBuilder() : base(ForecastServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ForecastServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ForecastServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ForecastServiceClient Build()
        {
            ForecastServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ForecastServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ForecastServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ForecastServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ForecastServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ForecastServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ForecastServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ForecastServiceClient.ChannelPool;
    }

    /// <summary>ForecastService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling forecasting actions.
    /// </remarks>
    public abstract partial class ForecastServiceClient
    {
        /// <summary>
        /// The default endpoint for the ForecastService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default ForecastService scopes.</summary>
        /// <remarks>
        /// The default ForecastService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// <item><description>https://www.googleapis.com/auth/admanager.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
            "https://www.googleapis.com/auth/admanager.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ForecastService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ForecastServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ForecastServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ForecastServiceClient"/>.</returns>
        public static stt::Task<ForecastServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ForecastServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ForecastServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ForecastServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ForecastServiceClient"/>.</returns>
        public static ForecastServiceClient Create() => new ForecastServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ForecastServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ForecastServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ForecastServiceClient"/>.</returns>
        internal static ForecastServiceClient Create(grpccore::CallInvoker callInvoker, ForecastServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ForecastService.ForecastServiceClient grpcClient = new ForecastService.ForecastServiceClient(callInvoker);
            return new ForecastServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ForecastService client</summary>
        public virtual ForecastService.ForecastServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the availability forecast for a [ProposalLineItem][] or
        /// [LineItem][google.ads.admanager.v1.LineItem]. An availability forecast
        /// reports the maximum number of available units that the line item can book,
        /// and the total number of units matching the line item's targeting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunAvailabilityForecastResponse RunAvailabilityForecast(RunAvailabilityForecastRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the availability forecast for a [ProposalLineItem][] or
        /// [LineItem][google.ads.admanager.v1.LineItem]. An availability forecast
        /// reports the maximum number of available units that the line item can book,
        /// and the total number of units matching the line item's targeting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunAvailabilityForecastResponse> RunAvailabilityForecastAsync(RunAvailabilityForecastRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the availability forecast for a [ProposalLineItem][] or
        /// [LineItem][google.ads.admanager.v1.LineItem]. An availability forecast
        /// reports the maximum number of available units that the line item can book,
        /// and the total number of units matching the line item's targeting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunAvailabilityForecastResponse> RunAvailabilityForecastAsync(RunAvailabilityForecastRequest request, st::CancellationToken cancellationToken) =>
            RunAvailabilityForecastAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the availability forecast for a [ProposalLineItem][] or
        /// [LineItem][google.ads.admanager.v1.LineItem]. An availability forecast
        /// reports the maximum number of available units that the line item can book,
        /// and the total number of units matching the line item's targeting.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunAvailabilityForecastResponse RunAvailabilityForecast(string parent, gaxgrpc::CallSettings callSettings = null) =>
            RunAvailabilityForecast(new RunAvailabilityForecastRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets the availability forecast for a [ProposalLineItem][] or
        /// [LineItem][google.ads.admanager.v1.LineItem]. An availability forecast
        /// reports the maximum number of available units that the line item can book,
        /// and the total number of units matching the line item's targeting.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunAvailabilityForecastResponse> RunAvailabilityForecastAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            RunAvailabilityForecastAsync(new RunAvailabilityForecastRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets the availability forecast for a [ProposalLineItem][] or
        /// [LineItem][google.ads.admanager.v1.LineItem]. An availability forecast
        /// reports the maximum number of available units that the line item can book,
        /// and the total number of units matching the line item's targeting.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunAvailabilityForecastResponse> RunAvailabilityForecastAsync(string parent, st::CancellationToken cancellationToken) =>
            RunAvailabilityForecastAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the availability forecast for a [ProposalLineItem][] or
        /// [LineItem][google.ads.admanager.v1.LineItem]. An availability forecast
        /// reports the maximum number of available units that the line item can book,
        /// and the total number of units matching the line item's targeting.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunAvailabilityForecastResponse RunAvailabilityForecast(NetworkName parent, gaxgrpc::CallSettings callSettings = null) =>
            RunAvailabilityForecast(new RunAvailabilityForecastRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets the availability forecast for a [ProposalLineItem][] or
        /// [LineItem][google.ads.admanager.v1.LineItem]. An availability forecast
        /// reports the maximum number of available units that the line item can book,
        /// and the total number of units matching the line item's targeting.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunAvailabilityForecastResponse> RunAvailabilityForecastAsync(NetworkName parent, gaxgrpc::CallSettings callSettings = null) =>
            RunAvailabilityForecastAsync(new RunAvailabilityForecastRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets the availability forecast for a [ProposalLineItem][] or
        /// [LineItem][google.ads.admanager.v1.LineItem]. An availability forecast
        /// reports the maximum number of available units that the line item can book,
        /// and the total number of units matching the line item's targeting.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunAvailabilityForecastResponse> RunAvailabilityForecastAsync(NetworkName parent, st::CancellationToken cancellationToken) =>
            RunAvailabilityForecastAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs a delivery simulation forecast for existing or prospective line items.
        /// A delivery forecast reports the number of units that will be delivered to
        /// each line item given the line item goals. The simulation considers
        /// contentions from other line items, including the other prospective line
        /// items in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunDeliveryForecastResponse RunDeliveryForecast(RunDeliveryForecastRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs a delivery simulation forecast for existing or prospective line items.
        /// A delivery forecast reports the number of units that will be delivered to
        /// each line item given the line item goals. The simulation considers
        /// contentions from other line items, including the other prospective line
        /// items in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunDeliveryForecastResponse> RunDeliveryForecastAsync(RunDeliveryForecastRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs a delivery simulation forecast for existing or prospective line items.
        /// A delivery forecast reports the number of units that will be delivered to
        /// each line item given the line item goals. The simulation considers
        /// contentions from other line items, including the other prospective line
        /// items in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunDeliveryForecastResponse> RunDeliveryForecastAsync(RunDeliveryForecastRequest request, st::CancellationToken cancellationToken) =>
            RunDeliveryForecastAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs a delivery simulation forecast for existing or prospective line items.
        /// A delivery forecast reports the number of units that will be delivered to
        /// each line item given the line item goals. The simulation considers
        /// contentions from other line items, including the other prospective line
        /// items in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunDeliveryForecastResponse RunDeliveryForecast(string parent, gaxgrpc::CallSettings callSettings = null) =>
            RunDeliveryForecast(new RunDeliveryForecastRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Runs a delivery simulation forecast for existing or prospective line items.
        /// A delivery forecast reports the number of units that will be delivered to
        /// each line item given the line item goals. The simulation considers
        /// contentions from other line items, including the other prospective line
        /// items in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunDeliveryForecastResponse> RunDeliveryForecastAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            RunDeliveryForecastAsync(new RunDeliveryForecastRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Runs a delivery simulation forecast for existing or prospective line items.
        /// A delivery forecast reports the number of units that will be delivered to
        /// each line item given the line item goals. The simulation considers
        /// contentions from other line items, including the other prospective line
        /// items in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunDeliveryForecastResponse> RunDeliveryForecastAsync(string parent, st::CancellationToken cancellationToken) =>
            RunDeliveryForecastAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs a delivery simulation forecast for existing or prospective line items.
        /// A delivery forecast reports the number of units that will be delivered to
        /// each line item given the line item goals. The simulation considers
        /// contentions from other line items, including the other prospective line
        /// items in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunDeliveryForecastResponse RunDeliveryForecast(NetworkName parent, gaxgrpc::CallSettings callSettings = null) =>
            RunDeliveryForecast(new RunDeliveryForecastRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Runs a delivery simulation forecast for existing or prospective line items.
        /// A delivery forecast reports the number of units that will be delivered to
        /// each line item given the line item goals. The simulation considers
        /// contentions from other line items, including the other prospective line
        /// items in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunDeliveryForecastResponse> RunDeliveryForecastAsync(NetworkName parent, gaxgrpc::CallSettings callSettings = null) =>
            RunDeliveryForecastAsync(new RunDeliveryForecastRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Runs a delivery simulation forecast for existing or prospective line items.
        /// A delivery forecast reports the number of units that will be delivered to
        /// each line item given the line item goals. The simulation considers
        /// contentions from other line items, including the other prospective line
        /// items in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunDeliveryForecastResponse> RunDeliveryForecastAsync(NetworkName parent, st::CancellationToken cancellationToken) =>
            RunDeliveryForecastAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets forecasted and historical traffic data for the segment of
        /// traffic specified by the provided request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunTrafficDataResponse RunTrafficData(RunTrafficDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets forecasted and historical traffic data for the segment of
        /// traffic specified by the provided request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunTrafficDataResponse> RunTrafficDataAsync(RunTrafficDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets forecasted and historical traffic data for the segment of
        /// traffic specified by the provided request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunTrafficDataResponse> RunTrafficDataAsync(RunTrafficDataRequest request, st::CancellationToken cancellationToken) =>
            RunTrafficDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets forecasted and historical traffic data for the segment of
        /// traffic specified by the provided request.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunTrafficDataResponse RunTrafficData(string parent, gaxgrpc::CallSettings callSettings = null) =>
            RunTrafficData(new RunTrafficDataRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets forecasted and historical traffic data for the segment of
        /// traffic specified by the provided request.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunTrafficDataResponse> RunTrafficDataAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            RunTrafficDataAsync(new RunTrafficDataRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets forecasted and historical traffic data for the segment of
        /// traffic specified by the provided request.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunTrafficDataResponse> RunTrafficDataAsync(string parent, st::CancellationToken cancellationToken) =>
            RunTrafficDataAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets forecasted and historical traffic data for the segment of
        /// traffic specified by the provided request.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunTrafficDataResponse RunTrafficData(NetworkName parent, gaxgrpc::CallSettings callSettings = null) =>
            RunTrafficData(new RunTrafficDataRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets forecasted and historical traffic data for the segment of
        /// traffic specified by the provided request.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunTrafficDataResponse> RunTrafficDataAsync(NetworkName parent, gaxgrpc::CallSettings callSettings = null) =>
            RunTrafficDataAsync(new RunTrafficDataRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets forecasted and historical traffic data for the segment of
        /// traffic specified by the provided request.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunTrafficDataResponse> RunTrafficDataAsync(NetworkName parent, st::CancellationToken cancellationToken) =>
            RunTrafficDataAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ForecastService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling forecasting actions.
    /// </remarks>
    public sealed partial class ForecastServiceClientImpl : ForecastServiceClient
    {
        private readonly gaxgrpc::ApiCall<RunAvailabilityForecastRequest, RunAvailabilityForecastResponse> _callRunAvailabilityForecast;

        private readonly gaxgrpc::ApiCall<RunDeliveryForecastRequest, RunDeliveryForecastResponse> _callRunDeliveryForecast;

        private readonly gaxgrpc::ApiCall<RunTrafficDataRequest, RunTrafficDataResponse> _callRunTrafficData;

        /// <summary>
        /// Constructs a client wrapper for the ForecastService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ForecastServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ForecastServiceClientImpl(ForecastService.ForecastServiceClient grpcClient, ForecastServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ForecastServiceSettings effectiveSettings = settings ?? ForecastServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callRunAvailabilityForecast = clientHelper.BuildApiCall<RunAvailabilityForecastRequest, RunAvailabilityForecastResponse>("RunAvailabilityForecast", grpcClient.RunAvailabilityForecastAsync, grpcClient.RunAvailabilityForecast, effectiveSettings.RunAvailabilityForecastSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRunAvailabilityForecast);
            Modify_RunAvailabilityForecastApiCall(ref _callRunAvailabilityForecast);
            _callRunDeliveryForecast = clientHelper.BuildApiCall<RunDeliveryForecastRequest, RunDeliveryForecastResponse>("RunDeliveryForecast", grpcClient.RunDeliveryForecastAsync, grpcClient.RunDeliveryForecast, effectiveSettings.RunDeliveryForecastSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRunDeliveryForecast);
            Modify_RunDeliveryForecastApiCall(ref _callRunDeliveryForecast);
            _callRunTrafficData = clientHelper.BuildApiCall<RunTrafficDataRequest, RunTrafficDataResponse>("RunTrafficData", grpcClient.RunTrafficDataAsync, grpcClient.RunTrafficData, effectiveSettings.RunTrafficDataSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRunTrafficData);
            Modify_RunTrafficDataApiCall(ref _callRunTrafficData);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RunAvailabilityForecastApiCall(ref gaxgrpc::ApiCall<RunAvailabilityForecastRequest, RunAvailabilityForecastResponse> call);

        partial void Modify_RunDeliveryForecastApiCall(ref gaxgrpc::ApiCall<RunDeliveryForecastRequest, RunDeliveryForecastResponse> call);

        partial void Modify_RunTrafficDataApiCall(ref gaxgrpc::ApiCall<RunTrafficDataRequest, RunTrafficDataResponse> call);

        partial void OnConstruction(ForecastService.ForecastServiceClient grpcClient, ForecastServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ForecastService client</summary>
        public override ForecastService.ForecastServiceClient GrpcClient { get; }

        partial void Modify_RunAvailabilityForecastRequest(ref RunAvailabilityForecastRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunDeliveryForecastRequest(ref RunDeliveryForecastRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunTrafficDataRequest(ref RunTrafficDataRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the availability forecast for a [ProposalLineItem][] or
        /// [LineItem][google.ads.admanager.v1.LineItem]. An availability forecast
        /// reports the maximum number of available units that the line item can book,
        /// and the total number of units matching the line item's targeting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunAvailabilityForecastResponse RunAvailabilityForecast(RunAvailabilityForecastRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunAvailabilityForecastRequest(ref request, ref callSettings);
            return _callRunAvailabilityForecast.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the availability forecast for a [ProposalLineItem][] or
        /// [LineItem][google.ads.admanager.v1.LineItem]. An availability forecast
        /// reports the maximum number of available units that the line item can book,
        /// and the total number of units matching the line item's targeting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunAvailabilityForecastResponse> RunAvailabilityForecastAsync(RunAvailabilityForecastRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunAvailabilityForecastRequest(ref request, ref callSettings);
            return _callRunAvailabilityForecast.Async(request, callSettings);
        }

        /// <summary>
        /// Runs a delivery simulation forecast for existing or prospective line items.
        /// A delivery forecast reports the number of units that will be delivered to
        /// each line item given the line item goals. The simulation considers
        /// contentions from other line items, including the other prospective line
        /// items in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunDeliveryForecastResponse RunDeliveryForecast(RunDeliveryForecastRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunDeliveryForecastRequest(ref request, ref callSettings);
            return _callRunDeliveryForecast.Sync(request, callSettings);
        }

        /// <summary>
        /// Runs a delivery simulation forecast for existing or prospective line items.
        /// A delivery forecast reports the number of units that will be delivered to
        /// each line item given the line item goals. The simulation considers
        /// contentions from other line items, including the other prospective line
        /// items in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunDeliveryForecastResponse> RunDeliveryForecastAsync(RunDeliveryForecastRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunDeliveryForecastRequest(ref request, ref callSettings);
            return _callRunDeliveryForecast.Async(request, callSettings);
        }

        /// <summary>
        /// Gets forecasted and historical traffic data for the segment of
        /// traffic specified by the provided request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunTrafficDataResponse RunTrafficData(RunTrafficDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunTrafficDataRequest(ref request, ref callSettings);
            return _callRunTrafficData.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets forecasted and historical traffic data for the segment of
        /// traffic specified by the provided request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunTrafficDataResponse> RunTrafficDataAsync(RunTrafficDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunTrafficDataRequest(ref request, ref callSettings);
            return _callRunTrafficData.Async(request, callSettings);
        }
    }
}
