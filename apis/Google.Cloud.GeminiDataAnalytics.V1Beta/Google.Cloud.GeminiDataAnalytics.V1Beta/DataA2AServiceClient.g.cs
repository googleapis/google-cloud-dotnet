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

namespace Google.Cloud.GeminiDataAnalytics.V1Beta
{
    /// <summary>Settings for <see cref="DataA2AServiceClient"/> instances.</summary>
    public sealed partial class DataA2AServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataA2AServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataA2AServiceSettings"/>.</returns>
        public static DataA2AServiceSettings GetDefault() => new DataA2AServiceSettings();

        /// <summary>Constructs a new <see cref="DataA2AServiceSettings"/> object with default settings.</summary>
        public DataA2AServiceSettings()
        {
        }

        private DataA2AServiceSettings(DataA2AServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SendMessageSettings = existing.SendMessageSettings;
            SendStreamingMessageSettings = existing.SendStreamingMessageSettings;
            GetAgentCardSettings = existing.GetAgentCardSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataA2AServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataA2AServiceClient.SendMessage</c> and <c>DataA2AServiceClient.SendMessageAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SendMessageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataA2AServiceClient.SendStreamingMessage</c> and <c>DataA2AServiceClient.SendStreamingMessageAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 600 seconds.</remarks>
        public gaxgrpc::CallSettings SendStreamingMessageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataA2AServiceClient.GetAgentCard</c> and <c>DataA2AServiceClient.GetAgentCardAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAgentCardSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataA2AServiceSettings"/> object.</returns>
        public DataA2AServiceSettings Clone() => new DataA2AServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataA2AServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DataA2AServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataA2AServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataA2AServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataA2AServiceClientBuilder() : base(DataA2AServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataA2AServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataA2AServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataA2AServiceClient Build()
        {
            DataA2AServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataA2AServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataA2AServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataA2AServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataA2AServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataA2AServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataA2AServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataA2AServiceClient.ChannelPool;
    }

    /// <summary>DataA2AService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// DataA2AService defines the Agent-to-Agent (A2A) protocol service for Gemini
    /// Data Analytics.
    /// </remarks>
    public abstract partial class DataA2AServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataA2AService service, which is a host of "geminidataanalytics.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "geminidataanalytics.googleapis.com:443";

        /// <summary>The default DataA2AService scopes.</summary>
        /// <remarks>
        /// The default DataA2AService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataA2AService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataA2AServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataA2AServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataA2AServiceClient"/>.</returns>
        public static stt::Task<DataA2AServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataA2AServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataA2AServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataA2AServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataA2AServiceClient"/>.</returns>
        public static DataA2AServiceClient Create() => new DataA2AServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataA2AServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataA2AServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataA2AServiceClient"/>.</returns>
        internal static DataA2AServiceClient Create(grpccore::CallInvoker callInvoker, DataA2AServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataA2AService.DataA2AServiceClient grpcClient = new DataA2AService.DataA2AServiceClient(callInvoker);
            return new DataA2AServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataA2AService client</summary>
        public virtual DataA2AService.DataA2AServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Send a message to the agent. This is a blocking call that will return the
        /// task once it is completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SendMessageResponse SendMessage(SendMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Send a message to the agent. This is a blocking call that will return the
        /// task once it is completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Send a message to the agent. This is a blocking call that will return the
        /// task once it is completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, st::CancellationToken cancellationToken) =>
            SendMessageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Send a message to the agent. This is a blocking call that will return the
        /// task once it is completed.
        /// </summary>
        /// <param name="tenant">
        /// Optional. Optional tenant, provided as a path parameter.
        /// </param>
        /// <param name="message">
        /// Required. The message to send to the agent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SendMessageResponse SendMessage(string tenant, A2AMessage message, gaxgrpc::CallSettings callSettings = null) =>
            SendMessage(new SendMessageRequest
            {
                Message = gax::GaxPreconditions.CheckNotNull(message, nameof(message)),
                Tenant = tenant ?? "",
            }, callSettings);

        /// <summary>
        /// Send a message to the agent. This is a blocking call that will return the
        /// task once it is completed.
        /// </summary>
        /// <param name="tenant">
        /// Optional. Optional tenant, provided as a path parameter.
        /// </param>
        /// <param name="message">
        /// Required. The message to send to the agent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendMessageResponse> SendMessageAsync(string tenant, A2AMessage message, gaxgrpc::CallSettings callSettings = null) =>
            SendMessageAsync(new SendMessageRequest
            {
                Message = gax::GaxPreconditions.CheckNotNull(message, nameof(message)),
                Tenant = tenant ?? "",
            }, callSettings);

        /// <summary>
        /// Send a message to the agent. This is a blocking call that will return the
        /// task once it is completed.
        /// </summary>
        /// <param name="tenant">
        /// Optional. Optional tenant, provided as a path parameter.
        /// </param>
        /// <param name="message">
        /// Required. The message to send to the agent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SendMessageResponse> SendMessageAsync(string tenant, A2AMessage message, st::CancellationToken cancellationToken) =>
            SendMessageAsync(tenant, message, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for <see cref="SendStreamingMessage(SendMessageRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class SendStreamingMessageStream : gaxgrpc::ServerStreamingBase<StreamResponse>
        {
        }

        /// <summary>
        /// SendStreamingMessage is a streaming call that will return a stream of
        /// task update events until the Task is in an interrupted or terminal state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual SendStreamingMessageStream SendStreamingMessage(SendMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// SendStreamingMessage is a streaming call that will return a stream of
        /// task update events until the Task is in an interrupted or terminal state.
        /// </summary>
        /// <param name="tenant">
        /// Optional. Optional tenant, provided as a path parameter.
        /// </param>
        /// <param name="message">
        /// Required. The message to send to the agent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual SendStreamingMessageStream SendStreamingMessage(string tenant, A2AMessage message, gaxgrpc::CallSettings callSettings = null) =>
            SendStreamingMessage(new SendMessageRequest
            {
                Message = gax::GaxPreconditions.CheckNotNull(message, nameof(message)),
                Tenant = tenant ?? "",
            }, callSettings);

        /// <summary>
        /// GetAgentCard returns the agent card for the agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentCard GetAgentCard(GetAgentCardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GetAgentCard returns the agent card for the agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentCard> GetAgentCardAsync(GetAgentCardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GetAgentCard returns the agent card for the agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentCard> GetAgentCardAsync(GetAgentCardRequest request, st::CancellationToken cancellationToken) =>
            GetAgentCardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// GetAgentCard returns the agent card for the agent.
        /// </summary>
        /// <param name="tenant">
        /// Optional. Optional tenant, provided as a path parameter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentCard GetAgentCard(string tenant, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentCard(new GetAgentCardRequest { Tenant = tenant ?? "", }, callSettings);

        /// <summary>
        /// GetAgentCard returns the agent card for the agent.
        /// </summary>
        /// <param name="tenant">
        /// Optional. Optional tenant, provided as a path parameter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentCard> GetAgentCardAsync(string tenant, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentCardAsync(new GetAgentCardRequest { Tenant = tenant ?? "", }, callSettings);

        /// <summary>
        /// GetAgentCard returns the agent card for the agent.
        /// </summary>
        /// <param name="tenant">
        /// Optional. Optional tenant, provided as a path parameter.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentCard> GetAgentCardAsync(string tenant, st::CancellationToken cancellationToken) =>
            GetAgentCardAsync(tenant, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataA2AService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// DataA2AService defines the Agent-to-Agent (A2A) protocol service for Gemini
    /// Data Analytics.
    /// </remarks>
    public sealed partial class DataA2AServiceClientImpl : DataA2AServiceClient
    {
        private readonly gaxgrpc::ApiCall<SendMessageRequest, SendMessageResponse> _callSendMessage;

        private readonly gaxgrpc::ApiServerStreamingCall<SendMessageRequest, StreamResponse> _callSendStreamingMessage;

        private readonly gaxgrpc::ApiCall<GetAgentCardRequest, AgentCard> _callGetAgentCard;

        /// <summary>
        /// Constructs a client wrapper for the DataA2AService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataA2AServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataA2AServiceClientImpl(DataA2AService.DataA2AServiceClient grpcClient, DataA2AServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataA2AServiceSettings effectiveSettings = settings ?? DataA2AServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callSendMessage = clientHelper.BuildApiCall<SendMessageRequest, SendMessageResponse>("SendMessage", grpcClient.SendMessageAsync, grpcClient.SendMessage, effectiveSettings.SendMessageSettings).WithGoogleRequestParam("tenant", request => request.Tenant);
            Modify_ApiCall(ref _callSendMessage);
            Modify_SendMessageApiCall(ref _callSendMessage);
            _callSendStreamingMessage = clientHelper.BuildApiCall<SendMessageRequest, StreamResponse>("SendStreamingMessage", grpcClient.SendStreamingMessage, effectiveSettings.SendStreamingMessageSettings).WithGoogleRequestParam("tenant", request => request.Tenant);
            Modify_ApiCall(ref _callSendStreamingMessage);
            Modify_SendStreamingMessageApiCall(ref _callSendStreamingMessage);
            _callGetAgentCard = clientHelper.BuildApiCall<GetAgentCardRequest, AgentCard>("GetAgentCard", grpcClient.GetAgentCardAsync, grpcClient.GetAgentCard, effectiveSettings.GetAgentCardSettings).WithGoogleRequestParam("tenant", request => request.Tenant);
            Modify_ApiCall(ref _callGetAgentCard);
            Modify_GetAgentCardApiCall(ref _callGetAgentCard);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SendMessageApiCall(ref gaxgrpc::ApiCall<SendMessageRequest, SendMessageResponse> call);

        partial void Modify_SendStreamingMessageApiCall(ref gaxgrpc::ApiServerStreamingCall<SendMessageRequest, StreamResponse> call);

        partial void Modify_GetAgentCardApiCall(ref gaxgrpc::ApiCall<GetAgentCardRequest, AgentCard> call);

        partial void OnConstruction(DataA2AService.DataA2AServiceClient grpcClient, DataA2AServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataA2AService client</summary>
        public override DataA2AService.DataA2AServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_SendMessageRequest(ref SendMessageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAgentCardRequest(ref GetAgentCardRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Send a message to the agent. This is a blocking call that will return the
        /// task once it is completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SendMessageResponse SendMessage(SendMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SendMessageRequest(ref request, ref callSettings);
            return _callSendMessage.Sync(request, callSettings);
        }

        /// <summary>
        /// Send a message to the agent. This is a blocking call that will return the
        /// task once it is completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SendMessageRequest(ref request, ref callSettings);
            return _callSendMessage.Async(request, callSettings);
        }

        internal sealed partial class SendStreamingMessageStreamImpl : SendStreamingMessageStream
        {
            /// <summary>Construct the server streaming method for <c>SendStreamingMessage</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public SendStreamingMessageStreamImpl(grpccore::AsyncServerStreamingCall<StreamResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<StreamResponse> GrpcCall { get; }
        }

        /// <summary>
        /// SendStreamingMessage is a streaming call that will return a stream of
        /// task update events until the Task is in an interrupted or terminal state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override DataA2AServiceClient.SendStreamingMessageStream SendStreamingMessage(SendMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SendMessageRequest(ref request, ref callSettings);
            return new SendStreamingMessageStreamImpl(_callSendStreamingMessage.Call(request, callSettings));
        }

        /// <summary>
        /// GetAgentCard returns the agent card for the agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AgentCard GetAgentCard(GetAgentCardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentCardRequest(ref request, ref callSettings);
            return _callGetAgentCard.Sync(request, callSettings);
        }

        /// <summary>
        /// GetAgentCard returns the agent card for the agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AgentCard> GetAgentCardAsync(GetAgentCardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentCardRequest(ref request, ref callSettings);
            return _callGetAgentCard.Async(request, callSettings);
        }
    }

    public static partial class DataA2AService
    {
        public partial class DataA2AServiceClient
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
