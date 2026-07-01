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

namespace Google.Maps.Isochrones.V1
{
    /// <summary>Settings for <see cref="IsochroneServiceClient"/> instances.</summary>
    public sealed partial class IsochroneServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IsochroneServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IsochroneServiceSettings"/>.</returns>
        public static IsochroneServiceSettings GetDefault() => new IsochroneServiceSettings();

        /// <summary>Constructs a new <see cref="IsochroneServiceSettings"/> object with default settings.</summary>
        public IsochroneServiceSettings()
        {
        }

        private IsochroneServiceSettings(IsochroneServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateIsochroneSettings = existing.GenerateIsochroneSettings;
            OnCopy(existing);
        }

        partial void OnCopy(IsochroneServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IsochroneServiceClient.GenerateIsochrone</c> and <c>IsochroneServiceClient.GenerateIsochroneAsync</c>.
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
        public gaxgrpc::CallSettings GenerateIsochroneSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IsochroneServiceSettings"/> object.</returns>
        public IsochroneServiceSettings Clone() => new IsochroneServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IsochroneServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class IsochroneServiceClientBuilder : gaxgrpc::ClientBuilderBase<IsochroneServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IsochroneServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IsochroneServiceClientBuilder() : base(IsochroneServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref IsochroneServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IsochroneServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IsochroneServiceClient Build()
        {
            IsochroneServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IsochroneServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IsochroneServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IsochroneServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IsochroneServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<IsochroneServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IsochroneServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IsochroneServiceClient.ChannelPool;
    }

    /// <summary>IsochroneService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for calculating isochrones. An isochrone is an area of reachability
    /// from a given origin point within a specified travel time.
    /// </remarks>
    public abstract partial class IsochroneServiceClient
    {
        /// <summary>
        /// The default endpoint for the IsochroneService service, which is a host of "isochrones.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "isochrones.googleapis.com:443";

        /// <summary>The default IsochroneService scopes.</summary>
        /// <remarks>
        /// The default IsochroneService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/maps-platform.isochrones</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/maps-platform.isochrones",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(IsochroneService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="IsochroneServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="IsochroneServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IsochroneServiceClient"/>.</returns>
        public static stt::Task<IsochroneServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IsochroneServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IsochroneServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="IsochroneServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IsochroneServiceClient"/>.</returns>
        public static IsochroneServiceClient Create() => new IsochroneServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IsochroneServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IsochroneServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="IsochroneServiceClient"/>.</returns>
        internal static IsochroneServiceClient Create(grpccore::CallInvoker callInvoker, IsochroneServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IsochroneService.IsochroneServiceClient grpcClient = new IsochroneService.IsochroneServiceClient(callInvoker);
            return new IsochroneServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC IsochroneService client</summary>
        public virtual IsochroneService.IsochroneServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Calculates and returns a single isochrone for a given set of parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateIsochroneResponse GenerateIsochrone(GenerateIsochroneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Calculates and returns a single isochrone for a given set of parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateIsochroneResponse> GenerateIsochroneAsync(GenerateIsochroneRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Calculates and returns a single isochrone for a given set of parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateIsochroneResponse> GenerateIsochroneAsync(GenerateIsochroneRequest request, st::CancellationToken cancellationToken) =>
            GenerateIsochroneAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IsochroneService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for calculating isochrones. An isochrone is an area of reachability
    /// from a given origin point within a specified travel time.
    /// </remarks>
    public sealed partial class IsochroneServiceClientImpl : IsochroneServiceClient
    {
        private readonly gaxgrpc::ApiCall<GenerateIsochroneRequest, GenerateIsochroneResponse> _callGenerateIsochrone;

        /// <summary>
        /// Constructs a client wrapper for the IsochroneService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="IsochroneServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public IsochroneServiceClientImpl(IsochroneService.IsochroneServiceClient grpcClient, IsochroneServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            IsochroneServiceSettings effectiveSettings = settings ?? IsochroneServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGenerateIsochrone = clientHelper.BuildApiCall<GenerateIsochroneRequest, GenerateIsochroneResponse>("GenerateIsochrone", grpcClient.GenerateIsochroneAsync, grpcClient.GenerateIsochrone, effectiveSettings.GenerateIsochroneSettings);
            Modify_ApiCall(ref _callGenerateIsochrone);
            Modify_GenerateIsochroneApiCall(ref _callGenerateIsochrone);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateIsochroneApiCall(ref gaxgrpc::ApiCall<GenerateIsochroneRequest, GenerateIsochroneResponse> call);

        partial void OnConstruction(IsochroneService.IsochroneServiceClient grpcClient, IsochroneServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IsochroneService client</summary>
        public override IsochroneService.IsochroneServiceClient GrpcClient { get; }

        partial void Modify_GenerateIsochroneRequest(ref GenerateIsochroneRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Calculates and returns a single isochrone for a given set of parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateIsochroneResponse GenerateIsochrone(GenerateIsochroneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateIsochroneRequest(ref request, ref callSettings);
            return _callGenerateIsochrone.Sync(request, callSettings);
        }

        /// <summary>
        /// Calculates and returns a single isochrone for a given set of parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateIsochroneResponse> GenerateIsochroneAsync(GenerateIsochroneRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateIsochroneRequest(ref request, ref callSettings);
            return _callGenerateIsochrone.Async(request, callSettings);
        }
    }
}
