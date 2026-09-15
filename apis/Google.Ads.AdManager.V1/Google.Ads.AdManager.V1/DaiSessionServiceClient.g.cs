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
    /// <summary>Settings for <see cref="DaiSessionServiceClient"/> instances.</summary>
    public sealed partial class DaiSessionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DaiSessionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DaiSessionServiceSettings"/>.</returns>
        public static DaiSessionServiceSettings GetDefault() => new DaiSessionServiceSettings();

        /// <summary>Constructs a new <see cref="DaiSessionServiceSettings"/> object with default settings.</summary>
        public DaiSessionServiceSettings()
        {
        }

        private DaiSessionServiceSettings(DaiSessionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDaiSessionSettings = existing.GetDaiSessionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DaiSessionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiSessionServiceClient.GetDaiSession</c> and <c>DaiSessionServiceClient.GetDaiSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDaiSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DaiSessionServiceSettings"/> object.</returns>
        public DaiSessionServiceSettings Clone() => new DaiSessionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DaiSessionServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DaiSessionServiceClientBuilder : gaxgrpc::ClientBuilderBase<DaiSessionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DaiSessionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DaiSessionServiceClientBuilder() : base(DaiSessionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DaiSessionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DaiSessionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DaiSessionServiceClient Build()
        {
            DaiSessionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DaiSessionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DaiSessionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DaiSessionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DaiSessionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DaiSessionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DaiSessionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DaiSessionServiceClient.ChannelPool;
    }

    /// <summary>DaiSessionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `DaiSession` objects.
    /// </remarks>
    public abstract partial class DaiSessionServiceClient
    {
        /// <summary>
        /// The default endpoint for the DaiSessionService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default DaiSessionService scopes.</summary>
        /// <remarks>
        /// The default DaiSessionService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DaiSessionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DaiSessionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DaiSessionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DaiSessionServiceClient"/>.</returns>
        public static stt::Task<DaiSessionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DaiSessionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DaiSessionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DaiSessionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DaiSessionServiceClient"/>.</returns>
        public static DaiSessionServiceClient Create() => new DaiSessionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DaiSessionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DaiSessionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DaiSessionServiceClient"/>.</returns>
        internal static DaiSessionServiceClient Create(grpccore::CallInvoker callInvoker, DaiSessionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DaiSessionService.DaiSessionServiceClient grpcClient = new DaiSessionService.DaiSessionServiceClient(callInvoker);
            return new DaiSessionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DaiSessionService client</summary>
        public virtual DaiSessionService.DaiSessionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `DaiSession` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiSession GetDaiSession(GetDaiSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `DaiSession` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiSession> GetDaiSessionAsync(GetDaiSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `DaiSession` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiSession> GetDaiSessionAsync(GetDaiSessionRequest request, st::CancellationToken cancellationToken) =>
            GetDaiSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `DaiSession` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DaiSession. The dai_session can be
        /// either the session ID or debug key, that DAI returns on stream create. For
        /// details, see [Locate a DAI session ID or debug
        /// key](https://support.google.com/admanager/answer/7257678).
        /// 
        /// Format: `networks/{network_code}/daiSessions/{dai_session}`
        /// Format: `networks/{network_code}/daiSessions/{session_id}`
        /// Format: `networks/{network_code}/daiSessions/{debug_key}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiSession GetDaiSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDaiSession(new GetDaiSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `DaiSession` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DaiSession. The dai_session can be
        /// either the session ID or debug key, that DAI returns on stream create. For
        /// details, see [Locate a DAI session ID or debug
        /// key](https://support.google.com/admanager/answer/7257678).
        /// 
        /// Format: `networks/{network_code}/daiSessions/{dai_session}`
        /// Format: `networks/{network_code}/daiSessions/{session_id}`
        /// Format: `networks/{network_code}/daiSessions/{debug_key}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiSession> GetDaiSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDaiSessionAsync(new GetDaiSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `DaiSession` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DaiSession. The dai_session can be
        /// either the session ID or debug key, that DAI returns on stream create. For
        /// details, see [Locate a DAI session ID or debug
        /// key](https://support.google.com/admanager/answer/7257678).
        /// 
        /// Format: `networks/{network_code}/daiSessions/{dai_session}`
        /// Format: `networks/{network_code}/daiSessions/{session_id}`
        /// Format: `networks/{network_code}/daiSessions/{debug_key}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiSession> GetDaiSessionAsync(string name, st::CancellationToken cancellationToken) =>
            GetDaiSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `DaiSession` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DaiSession. The dai_session can be
        /// either the session ID or debug key, that DAI returns on stream create. For
        /// details, see [Locate a DAI session ID or debug
        /// key](https://support.google.com/admanager/answer/7257678).
        /// 
        /// Format: `networks/{network_code}/daiSessions/{dai_session}`
        /// Format: `networks/{network_code}/daiSessions/{session_id}`
        /// Format: `networks/{network_code}/daiSessions/{debug_key}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiSession GetDaiSession(DaiSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDaiSession(new GetDaiSessionRequest
            {
                DaiSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `DaiSession` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DaiSession. The dai_session can be
        /// either the session ID or debug key, that DAI returns on stream create. For
        /// details, see [Locate a DAI session ID or debug
        /// key](https://support.google.com/admanager/answer/7257678).
        /// 
        /// Format: `networks/{network_code}/daiSessions/{dai_session}`
        /// Format: `networks/{network_code}/daiSessions/{session_id}`
        /// Format: `networks/{network_code}/daiSessions/{debug_key}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiSession> GetDaiSessionAsync(DaiSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDaiSessionAsync(new GetDaiSessionRequest
            {
                DaiSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `DaiSession` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DaiSession. The dai_session can be
        /// either the session ID or debug key, that DAI returns on stream create. For
        /// details, see [Locate a DAI session ID or debug
        /// key](https://support.google.com/admanager/answer/7257678).
        /// 
        /// Format: `networks/{network_code}/daiSessions/{dai_session}`
        /// Format: `networks/{network_code}/daiSessions/{session_id}`
        /// Format: `networks/{network_code}/daiSessions/{debug_key}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiSession> GetDaiSessionAsync(DaiSessionName name, st::CancellationToken cancellationToken) =>
            GetDaiSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DaiSessionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `DaiSession` objects.
    /// </remarks>
    public sealed partial class DaiSessionServiceClientImpl : DaiSessionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDaiSessionRequest, DaiSession> _callGetDaiSession;

        /// <summary>
        /// Constructs a client wrapper for the DaiSessionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DaiSessionServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DaiSessionServiceClientImpl(DaiSessionService.DaiSessionServiceClient grpcClient, DaiSessionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DaiSessionServiceSettings effectiveSettings = settings ?? DaiSessionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetDaiSession = clientHelper.BuildApiCall<GetDaiSessionRequest, DaiSession>("GetDaiSession", grpcClient.GetDaiSessionAsync, grpcClient.GetDaiSession, effectiveSettings.GetDaiSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDaiSession);
            Modify_GetDaiSessionApiCall(ref _callGetDaiSession);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDaiSessionApiCall(ref gaxgrpc::ApiCall<GetDaiSessionRequest, DaiSession> call);

        partial void OnConstruction(DaiSessionService.DaiSessionServiceClient grpcClient, DaiSessionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DaiSessionService client</summary>
        public override DaiSessionService.DaiSessionServiceClient GrpcClient { get; }

        partial void Modify_GetDaiSessionRequest(ref GetDaiSessionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `DaiSession` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DaiSession GetDaiSession(GetDaiSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDaiSessionRequest(ref request, ref callSettings);
            return _callGetDaiSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `DaiSession` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DaiSession> GetDaiSessionAsync(GetDaiSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDaiSessionRequest(ref request, ref callSettings);
            return _callGetDaiSession.Async(request, callSettings);
        }
    }
}
