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

namespace Google.Cloud.ApigeeConnect.V1
{
    /// <summary>Settings for <see cref="TetherClient"/> instances.</summary>
    public sealed partial class TetherSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TetherSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TetherSettings"/>.</returns>
        public static TetherSettings GetDefault() => new TetherSettings();

        /// <summary>Constructs a new <see cref="TetherSettings"/> object with default settings.</summary>
        public TetherSettings()
        {
        }

        private TetherSettings(TetherSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            EgressSettings = existing.EgressSettings;
            EgressStreamingSettings = existing.EgressStreamingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TetherSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TetherClient.Egress</c> and
        /// <c>TetherClient.EgressAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EgressSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>TetherClient.Egress</c> and
        /// <c>TetherClient.EgressAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings EgressStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TetherSettings"/> object.</returns>
        public TetherSettings Clone() => new TetherSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TetherClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TetherClientBuilder : gaxgrpc::ClientBuilderBase<TetherClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TetherSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TetherClientBuilder() : base(TetherClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TetherClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TetherClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TetherClient Build()
        {
            TetherClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TetherClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TetherClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TetherClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TetherClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TetherClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TetherClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TetherClient.ChannelPool;
    }

    /// <summary>Tether client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Tether provides a way for the control plane to send HTTP API requests to
    /// services in data planes that runs in a remote datacenter without
    /// requiring customers to open firewalls on their runtime plane.
    /// </remarks>
    public abstract partial class TetherClient
    {
        /// <summary>
        /// The default endpoint for the Tether service, which is a host of "apigeeconnect.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apigeeconnect.googleapis.com:443";

        /// <summary>The default Tether scopes.</summary>
        /// <remarks>
        /// The default Tether scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Tether.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TetherClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="TetherClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TetherClient"/>.</returns>
        public static stt::Task<TetherClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TetherClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TetherClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="TetherClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TetherClient"/>.</returns>
        public static TetherClient Create() => new TetherClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TetherClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TetherSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TetherClient"/>.</returns>
        internal static TetherClient Create(grpccore::CallInvoker callInvoker, TetherSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Tether.TetherClient grpcClient = new Tether.TetherClient(callInvoker);
            return new TetherClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Tether client</summary>
        public virtual Tether.TetherClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="Egress(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class EgressStream : gaxgrpc::BidirectionalStreamingBase<EgressResponse, EgressRequest>
        {
        }

        /// <summary>
        /// Egress streams egress requests and responses. Logically, this is not
        /// actually a streaming request, but uses streaming as a mechanism to flip
        /// the client-server relationship of gRPC so that the server can act as a
        /// client.
        /// The listener, the RPC server, accepts connections from the dialer,
        /// the RPC client.
        /// The listener streams http requests and the dialer streams http responses.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual EgressStream Egress(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>Tether client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Tether provides a way for the control plane to send HTTP API requests to
    /// services in data planes that runs in a remote datacenter without
    /// requiring customers to open firewalls on their runtime plane.
    /// </remarks>
    public sealed partial class TetherClientImpl : TetherClient
    {
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<EgressResponse, EgressRequest> _callEgress;

        /// <summary>
        /// Constructs a client wrapper for the Tether service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TetherSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TetherClientImpl(Tether.TetherClient grpcClient, TetherSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TetherSettings effectiveSettings = settings ?? TetherSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callEgress = clientHelper.BuildApiCall<EgressResponse, EgressRequest>("Egress", grpcClient.Egress, effectiveSettings.EgressSettings, effectiveSettings.EgressStreamingSettings);
            Modify_ApiCall(ref _callEgress);
            Modify_EgressApiCall(ref _callEgress);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_EgressApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<EgressResponse, EgressRequest> call);

        partial void OnConstruction(Tether.TetherClient grpcClient, TetherSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Tether client</summary>
        public override Tether.TetherClient GrpcClient { get; }

        partial void Modify_EgressResponseCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_EgressResponseRequest(ref EgressResponse request);

        internal sealed partial class EgressStreamImpl : EgressStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>Egress</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{EgressResponse}"/> instance associated with this
            /// streaming call.
            /// </param>
            public EgressStreamImpl(TetherClientImpl service, grpccore::AsyncDuplexStreamingCall<EgressResponse, EgressRequest> call, gaxgrpc::BufferedClientStreamWriter<EgressResponse> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private TetherClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<EgressResponse> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<EgressResponse, EgressRequest> GrpcCall { get; }

            private EgressResponse ModifyRequest(EgressResponse request)
            {
                _service.Modify_EgressResponseRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(EgressResponse message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(EgressResponse message) => _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(EgressResponse message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(EgressResponse message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Egress streams egress requests and responses. Logically, this is not
        /// actually a streaming request, but uses streaming as a mechanism to flip
        /// the client-server relationship of gRPC so that the server can act as a
        /// client.
        /// The listener, the RPC server, accepts connections from the dialer,
        /// the RPC client.
        /// The listener streams http requests and the dialer streams http responses.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override TetherClient.EgressStream Egress(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_EgressResponseCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callEgress.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<EgressResponse, EgressRequest> call = _callEgress.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<EgressResponse> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<EgressResponse>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new EgressStreamImpl(this, call, writeBuffer);
        }
    }
}
