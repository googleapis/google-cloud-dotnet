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
    /// <summary>Settings for <see cref="AssistantServiceClient"/> instances.</summary>
    public sealed partial class AssistantServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AssistantServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AssistantServiceSettings"/>.</returns>
        public static AssistantServiceSettings GetDefault() => new AssistantServiceSettings();

        /// <summary>Constructs a new <see cref="AssistantServiceSettings"/> object with default settings.</summary>
        public AssistantServiceSettings()
        {
        }

        private AssistantServiceSettings(AssistantServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            StreamAssistSettings = existing.StreamAssistSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AssistantServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssistantServiceClient.StreamAssist</c> and <c>AssistantServiceClient.StreamAssistAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 300 seconds.</remarks>
        public gaxgrpc::CallSettings StreamAssistSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AssistantServiceSettings"/> object.</returns>
        public AssistantServiceSettings Clone() => new AssistantServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AssistantServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AssistantServiceClientBuilder : gaxgrpc::ClientBuilderBase<AssistantServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AssistantServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AssistantServiceClientBuilder() : base(AssistantServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AssistantServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AssistantServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AssistantServiceClient Build()
        {
            AssistantServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AssistantServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AssistantServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AssistantServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AssistantServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AssistantServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AssistantServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AssistantServiceClient.ChannelPool;
    }

    /// <summary>AssistantService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Assistant configuration and assisting users.
    /// </remarks>
    public abstract partial class AssistantServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssistantService service, which is a host of "discoveryengine.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default AssistantService scopes.</summary>
        /// <remarks>
        /// The default AssistantService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AssistantService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AssistantServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AssistantServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AssistantServiceClient"/>.</returns>
        public static stt::Task<AssistantServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AssistantServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AssistantServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AssistantServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AssistantServiceClient"/>.</returns>
        public static AssistantServiceClient Create() => new AssistantServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AssistantServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AssistantServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AssistantServiceClient"/>.</returns>
        internal static AssistantServiceClient Create(grpccore::CallInvoker callInvoker, AssistantServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AssistantService.AssistantServiceClient grpcClient = new AssistantService.AssistantServiceClient(callInvoker);
            return new AssistantServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AssistantService client</summary>
        public virtual AssistantService.AssistantServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Server streaming methods for <see cref="StreamAssist(StreamAssistRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class StreamAssistStream : gaxgrpc::ServerStreamingBase<StreamAssistResponse>
        {
        }

        /// <summary>
        /// Assists the user with a query in a streaming fashion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual StreamAssistStream StreamAssist(StreamAssistRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>AssistantService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Assistant configuration and assisting users.
    /// </remarks>
    public sealed partial class AssistantServiceClientImpl : AssistantServiceClient
    {
        private readonly gaxgrpc::ApiServerStreamingCall<StreamAssistRequest, StreamAssistResponse> _callStreamAssist;

        /// <summary>
        /// Constructs a client wrapper for the AssistantService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AssistantServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AssistantServiceClientImpl(AssistantService.AssistantServiceClient grpcClient, AssistantServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AssistantServiceSettings effectiveSettings = settings ?? AssistantServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callStreamAssist = clientHelper.BuildApiCall<StreamAssistRequest, StreamAssistResponse>("StreamAssist", grpcClient.StreamAssist, effectiveSettings.StreamAssistSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStreamAssist);
            Modify_StreamAssistApiCall(ref _callStreamAssist);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_StreamAssistApiCall(ref gaxgrpc::ApiServerStreamingCall<StreamAssistRequest, StreamAssistResponse> call);

        partial void OnConstruction(AssistantService.AssistantServiceClient grpcClient, AssistantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssistantService client</summary>
        public override AssistantService.AssistantServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_StreamAssistRequest(ref StreamAssistRequest request, ref gaxgrpc::CallSettings settings);

        internal sealed partial class StreamAssistStreamImpl : StreamAssistStream
        {
            /// <summary>Construct the server streaming method for <c>StreamAssist</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public StreamAssistStreamImpl(grpccore::AsyncServerStreamingCall<StreamAssistResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<StreamAssistResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Assists the user with a query in a streaming fashion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override AssistantServiceClient.StreamAssistStream StreamAssist(StreamAssistRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StreamAssistRequest(ref request, ref callSettings);
            return new StreamAssistStreamImpl(_callStreamAssist.Call(request, callSettings));
        }
    }

    public static partial class AssistantService
    {
        public partial class AssistantServiceClient
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
