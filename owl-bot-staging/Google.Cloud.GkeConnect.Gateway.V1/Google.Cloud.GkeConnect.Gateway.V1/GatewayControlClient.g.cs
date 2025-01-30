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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.GkeConnect.Gateway.V1
{
    /// <summary>Settings for <see cref="GatewayControlClient"/> instances.</summary>
    public sealed partial class GatewayControlSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GatewayControlSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GatewayControlSettings"/>.</returns>
        public static GatewayControlSettings GetDefault() => new GatewayControlSettings();

        /// <summary>Constructs a new <see cref="GatewayControlSettings"/> object with default settings.</summary>
        public GatewayControlSettings()
        {
        }

        private GatewayControlSettings(GatewayControlSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateCredentialsSettings = existing.GenerateCredentialsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GatewayControlSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GatewayControlClient.GenerateCredentials</c> and <c>GatewayControlClient.GenerateCredentialsAsync</c>.
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
        public gaxgrpc::CallSettings GenerateCredentialsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GatewayControlSettings"/> object.</returns>
        public GatewayControlSettings Clone() => new GatewayControlSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GatewayControlClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class GatewayControlClientBuilder : gaxgrpc::ClientBuilderBase<GatewayControlClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GatewayControlSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GatewayControlClientBuilder() : base(GatewayControlClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GatewayControlClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GatewayControlClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GatewayControlClient Build()
        {
            GatewayControlClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GatewayControlClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GatewayControlClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GatewayControlClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GatewayControlClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GatewayControlClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GatewayControlClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GatewayControlClient.ChannelPool;
    }

    /// <summary>GatewayControl client wrapper, for convenient use.</summary>
    /// <remarks>
    /// GatewayControl is the control plane API for Connect Gateway.
    /// </remarks>
    public abstract partial class GatewayControlClient
    {
        /// <summary>
        /// The default endpoint for the GatewayControl service, which is a host of "connectgateway.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "connectgateway.googleapis.com:443";

        /// <summary>The default GatewayControl scopes.</summary>
        /// <remarks>
        /// The default GatewayControl scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GatewayControl.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GatewayControlClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GatewayControlClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GatewayControlClient"/>.</returns>
        public static stt::Task<GatewayControlClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GatewayControlClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GatewayControlClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GatewayControlClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GatewayControlClient"/>.</returns>
        public static GatewayControlClient Create() => new GatewayControlClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GatewayControlClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GatewayControlSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GatewayControlClient"/>.</returns>
        internal static GatewayControlClient Create(grpccore::CallInvoker callInvoker, GatewayControlSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GatewayControl.GatewayControlClient grpcClient = new GatewayControl.GatewayControlClient(callInvoker);
            return new GatewayControlClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GatewayControl client</summary>
        public virtual GatewayControl.GatewayControlClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// GenerateCredentials provides connection information that allows a user to
        /// access the specified membership using Connect Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateCredentialsResponse GenerateCredentials(GenerateCredentialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GenerateCredentials provides connection information that allows a user to
        /// access the specified membership using Connect Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateCredentialsResponse> GenerateCredentialsAsync(GenerateCredentialsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GenerateCredentials provides connection information that allows a user to
        /// access the specified membership using Connect Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateCredentialsResponse> GenerateCredentialsAsync(GenerateCredentialsRequest request, st::CancellationToken cancellationToken) =>
            GenerateCredentialsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GatewayControl client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// GatewayControl is the control plane API for Connect Gateway.
    /// </remarks>
    public sealed partial class GatewayControlClientImpl : GatewayControlClient
    {
        private readonly gaxgrpc::ApiCall<GenerateCredentialsRequest, GenerateCredentialsResponse> _callGenerateCredentials;

        /// <summary>
        /// Constructs a client wrapper for the GatewayControl service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GatewayControlSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GatewayControlClientImpl(GatewayControl.GatewayControlClient grpcClient, GatewayControlSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GatewayControlSettings effectiveSettings = settings ?? GatewayControlSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGenerateCredentials = clientHelper.BuildApiCall<GenerateCredentialsRequest, GenerateCredentialsResponse>("GenerateCredentials", grpcClient.GenerateCredentialsAsync, grpcClient.GenerateCredentials, effectiveSettings.GenerateCredentialsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateCredentials);
            Modify_GenerateCredentialsApiCall(ref _callGenerateCredentials);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateCredentialsApiCall(ref gaxgrpc::ApiCall<GenerateCredentialsRequest, GenerateCredentialsResponse> call);

        partial void OnConstruction(GatewayControl.GatewayControlClient grpcClient, GatewayControlSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GatewayControl client</summary>
        public override GatewayControl.GatewayControlClient GrpcClient { get; }

        partial void Modify_GenerateCredentialsRequest(ref GenerateCredentialsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// GenerateCredentials provides connection information that allows a user to
        /// access the specified membership using Connect Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateCredentialsResponse GenerateCredentials(GenerateCredentialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateCredentialsRequest(ref request, ref callSettings);
            return _callGenerateCredentials.Sync(request, callSettings);
        }

        /// <summary>
        /// GenerateCredentials provides connection information that allows a user to
        /// access the specified membership using Connect Gateway.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateCredentialsResponse> GenerateCredentialsAsync(GenerateCredentialsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateCredentialsRequest(ref request, ref callSettings);
            return _callGenerateCredentials.Async(request, callSettings);
        }
    }
}
