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
using ga = Google.Api;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Settings for <see cref="ReasoningEngineExecutionServiceClient"/> instances.</summary>
    public sealed partial class ReasoningEngineExecutionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReasoningEngineExecutionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReasoningEngineExecutionServiceSettings"/>.</returns>
        public static ReasoningEngineExecutionServiceSettings GetDefault() => new ReasoningEngineExecutionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ReasoningEngineExecutionServiceSettings"/> object with default settings.
        /// </summary>
        public ReasoningEngineExecutionServiceSettings()
        {
        }

        private ReasoningEngineExecutionServiceSettings(ReasoningEngineExecutionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            QueryReasoningEngineSettings = existing.QueryReasoningEngineSettings;
            StreamQueryReasoningEngineSettings = existing.StreamQueryReasoningEngineSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReasoningEngineExecutionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReasoningEngineExecutionServiceClient.QueryReasoningEngine</c> and
        /// <c>ReasoningEngineExecutionServiceClient.QueryReasoningEngineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryReasoningEngineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReasoningEngineExecutionServiceClient.StreamQueryReasoningEngine</c> and
        /// <c>ReasoningEngineExecutionServiceClient.StreamQueryReasoningEngineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamQueryReasoningEngineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReasoningEngineExecutionServiceSettings"/> object.</returns>
        public ReasoningEngineExecutionServiceSettings Clone() => new ReasoningEngineExecutionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReasoningEngineExecutionServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class ReasoningEngineExecutionServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReasoningEngineExecutionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReasoningEngineExecutionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReasoningEngineExecutionServiceClientBuilder() : base(ReasoningEngineExecutionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReasoningEngineExecutionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReasoningEngineExecutionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReasoningEngineExecutionServiceClient Build()
        {
            ReasoningEngineExecutionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReasoningEngineExecutionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReasoningEngineExecutionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReasoningEngineExecutionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReasoningEngineExecutionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReasoningEngineExecutionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReasoningEngineExecutionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReasoningEngineExecutionServiceClient.ChannelPool;
    }

    /// <summary>ReasoningEngineExecutionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for executing queries on Reasoning Engine.
    /// </remarks>
    public abstract partial class ReasoningEngineExecutionServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReasoningEngineExecutionService service, which is a host of
        /// "aiplatform.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default ReasoningEngineExecutionService scopes.</summary>
        /// <remarks>
        /// The default ReasoningEngineExecutionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReasoningEngineExecutionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReasoningEngineExecutionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ReasoningEngineExecutionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReasoningEngineExecutionServiceClient"/>.</returns>
        public static stt::Task<ReasoningEngineExecutionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReasoningEngineExecutionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReasoningEngineExecutionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ReasoningEngineExecutionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ReasoningEngineExecutionServiceClient"/>.</returns>
        public static ReasoningEngineExecutionServiceClient Create() =>
            new ReasoningEngineExecutionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReasoningEngineExecutionServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReasoningEngineExecutionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReasoningEngineExecutionServiceClient"/>.</returns>
        internal static ReasoningEngineExecutionServiceClient Create(grpccore::CallInvoker callInvoker, ReasoningEngineExecutionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReasoningEngineExecutionService.ReasoningEngineExecutionServiceClient grpcClient = new ReasoningEngineExecutionService.ReasoningEngineExecutionServiceClient(callInvoker);
            return new ReasoningEngineExecutionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ReasoningEngineExecutionService client</summary>
        public virtual ReasoningEngineExecutionService.ReasoningEngineExecutionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Queries using a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryReasoningEngineResponse QueryReasoningEngine(QueryReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Queries using a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryReasoningEngineResponse> QueryReasoningEngineAsync(QueryReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Queries using a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryReasoningEngineResponse> QueryReasoningEngineAsync(QueryReasoningEngineRequest request, st::CancellationToken cancellationToken) =>
            QueryReasoningEngineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for
        /// <see cref="StreamQueryReasoningEngine(StreamQueryReasoningEngineRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class StreamQueryReasoningEngineStream : gaxgrpc::ServerStreamingBase<ga::HttpBody>
        {
        }

        /// <summary>
        /// Streams queries using a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual StreamQueryReasoningEngineStream StreamQueryReasoningEngine(StreamQueryReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>ReasoningEngineExecutionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for executing queries on Reasoning Engine.
    /// </remarks>
    public sealed partial class ReasoningEngineExecutionServiceClientImpl : ReasoningEngineExecutionServiceClient
    {
        private readonly gaxgrpc::ApiCall<QueryReasoningEngineRequest, QueryReasoningEngineResponse> _callQueryReasoningEngine;

        private readonly gaxgrpc::ApiServerStreamingCall<StreamQueryReasoningEngineRequest, ga::HttpBody> _callStreamQueryReasoningEngine;

        /// <summary>
        /// Constructs a client wrapper for the ReasoningEngineExecutionService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ReasoningEngineExecutionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReasoningEngineExecutionServiceClientImpl(ReasoningEngineExecutionService.ReasoningEngineExecutionServiceClient grpcClient, ReasoningEngineExecutionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReasoningEngineExecutionServiceSettings effectiveSettings = settings ?? ReasoningEngineExecutionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callQueryReasoningEngine = clientHelper.BuildApiCall<QueryReasoningEngineRequest, QueryReasoningEngineResponse>("QueryReasoningEngine", grpcClient.QueryReasoningEngineAsync, grpcClient.QueryReasoningEngine, effectiveSettings.QueryReasoningEngineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callQueryReasoningEngine);
            Modify_QueryReasoningEngineApiCall(ref _callQueryReasoningEngine);
            _callStreamQueryReasoningEngine = clientHelper.BuildApiCall<StreamQueryReasoningEngineRequest, ga::HttpBody>("StreamQueryReasoningEngine", grpcClient.StreamQueryReasoningEngine, effectiveSettings.StreamQueryReasoningEngineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStreamQueryReasoningEngine);
            Modify_StreamQueryReasoningEngineApiCall(ref _callStreamQueryReasoningEngine);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_QueryReasoningEngineApiCall(ref gaxgrpc::ApiCall<QueryReasoningEngineRequest, QueryReasoningEngineResponse> call);

        partial void Modify_StreamQueryReasoningEngineApiCall(ref gaxgrpc::ApiServerStreamingCall<StreamQueryReasoningEngineRequest, ga::HttpBody> call);

        partial void OnConstruction(ReasoningEngineExecutionService.ReasoningEngineExecutionServiceClient grpcClient, ReasoningEngineExecutionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReasoningEngineExecutionService client</summary>
        public override ReasoningEngineExecutionService.ReasoningEngineExecutionServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_QueryReasoningEngineRequest(ref QueryReasoningEngineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamQueryReasoningEngineRequest(ref StreamQueryReasoningEngineRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Queries using a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QueryReasoningEngineResponse QueryReasoningEngine(QueryReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryReasoningEngineRequest(ref request, ref callSettings);
            return _callQueryReasoningEngine.Sync(request, callSettings);
        }

        /// <summary>
        /// Queries using a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QueryReasoningEngineResponse> QueryReasoningEngineAsync(QueryReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryReasoningEngineRequest(ref request, ref callSettings);
            return _callQueryReasoningEngine.Async(request, callSettings);
        }

        internal sealed partial class StreamQueryReasoningEngineStreamImpl : StreamQueryReasoningEngineStream
        {
            /// <summary>Construct the server streaming method for <c>StreamQueryReasoningEngine</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public StreamQueryReasoningEngineStreamImpl(grpccore::AsyncServerStreamingCall<ga::HttpBody> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ga::HttpBody> GrpcCall { get; }
        }

        /// <summary>
        /// Streams queries using a reasoning engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override ReasoningEngineExecutionServiceClient.StreamQueryReasoningEngineStream StreamQueryReasoningEngine(StreamQueryReasoningEngineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StreamQueryReasoningEngineRequest(ref request, ref callSettings);
            return new StreamQueryReasoningEngineStreamImpl(_callStreamQueryReasoningEngine.Call(request, callSettings));
        }
    }

    public static partial class ReasoningEngineExecutionService
    {
        public partial class ReasoningEngineExecutionServiceClient
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

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
