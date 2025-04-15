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

namespace Google.Shopping.Merchant.Lfp.V1Beta
{
    /// <summary>Settings for <see cref="LfpMerchantStateServiceClient"/> instances.</summary>
    public sealed partial class LfpMerchantStateServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LfpMerchantStateServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LfpMerchantStateServiceSettings"/>.</returns>
        public static LfpMerchantStateServiceSettings GetDefault() => new LfpMerchantStateServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="LfpMerchantStateServiceSettings"/> object with default settings.
        /// </summary>
        public LfpMerchantStateServiceSettings()
        {
        }

        private LfpMerchantStateServiceSettings(LfpMerchantStateServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetLfpMerchantStateSettings = existing.GetLfpMerchantStateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LfpMerchantStateServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LfpMerchantStateServiceClient.GetLfpMerchantState</c> and
        /// <c>LfpMerchantStateServiceClient.GetLfpMerchantStateAsync</c>.
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
        public gaxgrpc::CallSettings GetLfpMerchantStateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LfpMerchantStateServiceSettings"/> object.</returns>
        public LfpMerchantStateServiceSettings Clone() => new LfpMerchantStateServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LfpMerchantStateServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class LfpMerchantStateServiceClientBuilder : gaxgrpc::ClientBuilderBase<LfpMerchantStateServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LfpMerchantStateServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LfpMerchantStateServiceClientBuilder() : base(LfpMerchantStateServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LfpMerchantStateServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LfpMerchantStateServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LfpMerchantStateServiceClient Build()
        {
            LfpMerchantStateServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LfpMerchantStateServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LfpMerchantStateServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LfpMerchantStateServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LfpMerchantStateServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LfpMerchantStateServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LfpMerchantStateServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LfpMerchantStateServiceClient.ChannelPool;
    }

    /// <summary>LfpMerchantStateService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for a [LFP
    /// partner](https://support.google.com/merchants/answer/7676652) to get the
    /// state of a merchant.
    /// </remarks>
    public abstract partial class LfpMerchantStateServiceClient
    {
        /// <summary>
        /// The default endpoint for the LfpMerchantStateService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default LfpMerchantStateService scopes.</summary>
        /// <remarks>
        /// The default LfpMerchantStateService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LfpMerchantStateService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LfpMerchantStateServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="LfpMerchantStateServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LfpMerchantStateServiceClient"/>.</returns>
        public static stt::Task<LfpMerchantStateServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LfpMerchantStateServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LfpMerchantStateServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="LfpMerchantStateServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LfpMerchantStateServiceClient"/>.</returns>
        public static LfpMerchantStateServiceClient Create() => new LfpMerchantStateServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LfpMerchantStateServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LfpMerchantStateServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LfpMerchantStateServiceClient"/>.</returns>
        internal static LfpMerchantStateServiceClient Create(grpccore::CallInvoker callInvoker, LfpMerchantStateServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LfpMerchantStateService.LfpMerchantStateServiceClient grpcClient = new LfpMerchantStateService.LfpMerchantStateServiceClient(callInvoker);
            return new LfpMerchantStateServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LfpMerchantStateService client</summary>
        public virtual LfpMerchantStateService.LfpMerchantStateServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the LFP state of a merchant
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LfpMerchantState GetLfpMerchantState(GetLfpMerchantStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the LFP state of a merchant
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpMerchantState> GetLfpMerchantStateAsync(GetLfpMerchantStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the LFP state of a merchant
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpMerchantState> GetLfpMerchantStateAsync(GetLfpMerchantStateRequest request, st::CancellationToken cancellationToken) =>
            GetLfpMerchantStateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the LFP state of a merchant
        /// </summary>
        /// <param name="name">
        /// Required. The name of the state to retrieve.
        /// Format: `accounts/{account}/lfpMerchantStates/{target_merchant}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LfpMerchantState GetLfpMerchantState(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLfpMerchantState(new GetLfpMerchantStateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the LFP state of a merchant
        /// </summary>
        /// <param name="name">
        /// Required. The name of the state to retrieve.
        /// Format: `accounts/{account}/lfpMerchantStates/{target_merchant}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpMerchantState> GetLfpMerchantStateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLfpMerchantStateAsync(new GetLfpMerchantStateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the LFP state of a merchant
        /// </summary>
        /// <param name="name">
        /// Required. The name of the state to retrieve.
        /// Format: `accounts/{account}/lfpMerchantStates/{target_merchant}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpMerchantState> GetLfpMerchantStateAsync(string name, st::CancellationToken cancellationToken) =>
            GetLfpMerchantStateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the LFP state of a merchant
        /// </summary>
        /// <param name="name">
        /// Required. The name of the state to retrieve.
        /// Format: `accounts/{account}/lfpMerchantStates/{target_merchant}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LfpMerchantState GetLfpMerchantState(LfpMerchantStateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLfpMerchantState(new GetLfpMerchantStateRequest
            {
                LfpMerchantStateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the LFP state of a merchant
        /// </summary>
        /// <param name="name">
        /// Required. The name of the state to retrieve.
        /// Format: `accounts/{account}/lfpMerchantStates/{target_merchant}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpMerchantState> GetLfpMerchantStateAsync(LfpMerchantStateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLfpMerchantStateAsync(new GetLfpMerchantStateRequest
            {
                LfpMerchantStateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the LFP state of a merchant
        /// </summary>
        /// <param name="name">
        /// Required. The name of the state to retrieve.
        /// Format: `accounts/{account}/lfpMerchantStates/{target_merchant}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpMerchantState> GetLfpMerchantStateAsync(LfpMerchantStateName name, st::CancellationToken cancellationToken) =>
            GetLfpMerchantStateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LfpMerchantStateService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for a [LFP
    /// partner](https://support.google.com/merchants/answer/7676652) to get the
    /// state of a merchant.
    /// </remarks>
    public sealed partial class LfpMerchantStateServiceClientImpl : LfpMerchantStateServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetLfpMerchantStateRequest, LfpMerchantState> _callGetLfpMerchantState;

        /// <summary>
        /// Constructs a client wrapper for the LfpMerchantStateService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="LfpMerchantStateServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LfpMerchantStateServiceClientImpl(LfpMerchantStateService.LfpMerchantStateServiceClient grpcClient, LfpMerchantStateServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LfpMerchantStateServiceSettings effectiveSettings = settings ?? LfpMerchantStateServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetLfpMerchantState = clientHelper.BuildApiCall<GetLfpMerchantStateRequest, LfpMerchantState>("GetLfpMerchantState", grpcClient.GetLfpMerchantStateAsync, grpcClient.GetLfpMerchantState, effectiveSettings.GetLfpMerchantStateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLfpMerchantState);
            Modify_GetLfpMerchantStateApiCall(ref _callGetLfpMerchantState);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetLfpMerchantStateApiCall(ref gaxgrpc::ApiCall<GetLfpMerchantStateRequest, LfpMerchantState> call);

        partial void OnConstruction(LfpMerchantStateService.LfpMerchantStateServiceClient grpcClient, LfpMerchantStateServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LfpMerchantStateService client</summary>
        public override LfpMerchantStateService.LfpMerchantStateServiceClient GrpcClient { get; }

        partial void Modify_GetLfpMerchantStateRequest(ref GetLfpMerchantStateRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the LFP state of a merchant
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LfpMerchantState GetLfpMerchantState(GetLfpMerchantStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLfpMerchantStateRequest(ref request, ref callSettings);
            return _callGetLfpMerchantState.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the LFP state of a merchant
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LfpMerchantState> GetLfpMerchantStateAsync(GetLfpMerchantStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLfpMerchantStateRequest(ref request, ref callSettings);
            return _callGetLfpMerchantState.Async(request, callSettings);
        }
    }
}
