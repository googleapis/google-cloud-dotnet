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
    /// <summary>Settings for <see cref="GroundedGenerationServiceClient"/> instances.</summary>
    public sealed partial class GroundedGenerationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GroundedGenerationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GroundedGenerationServiceSettings"/>.</returns>
        public static GroundedGenerationServiceSettings GetDefault() => new GroundedGenerationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GroundedGenerationServiceSettings"/> object with default settings.
        /// </summary>
        public GroundedGenerationServiceSettings()
        {
        }

        private GroundedGenerationServiceSettings(GroundedGenerationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            StreamGenerateGroundedContentSettings = existing.StreamGenerateGroundedContentSettings;
            StreamGenerateGroundedContentStreamingSettings = existing.StreamGenerateGroundedContentStreamingSettings;
            GenerateGroundedContentSettings = existing.GenerateGroundedContentSettings;
            CheckGroundingSettings = existing.CheckGroundingSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GroundedGenerationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroundedGenerationServiceClient.StreamGenerateGroundedContent</c> and
        /// <c>GroundedGenerationServiceClient.StreamGenerateGroundedContentAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 5 seconds.</remarks>
        public gaxgrpc::CallSettings StreamGenerateGroundedContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>GroundedGenerationServiceClient.StreamGenerateGroundedContent</c> and
        /// <c>GroundedGenerationServiceClient.StreamGenerateGroundedContentAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamGenerateGroundedContentStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroundedGenerationServiceClient.GenerateGroundedContent</c> and
        /// <c>GroundedGenerationServiceClient.GenerateGroundedContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateGroundedContentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroundedGenerationServiceClient.CheckGrounding</c> and
        /// <c>GroundedGenerationServiceClient.CheckGroundingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 5000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CheckGroundingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(5000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GroundedGenerationServiceSettings"/> object.</returns>
        public GroundedGenerationServiceSettings Clone() => new GroundedGenerationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GroundedGenerationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class GroundedGenerationServiceClientBuilder : gaxgrpc::ClientBuilderBase<GroundedGenerationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GroundedGenerationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GroundedGenerationServiceClientBuilder() : base(GroundedGenerationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GroundedGenerationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GroundedGenerationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GroundedGenerationServiceClient Build()
        {
            GroundedGenerationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GroundedGenerationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GroundedGenerationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GroundedGenerationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GroundedGenerationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GroundedGenerationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GroundedGenerationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GroundedGenerationServiceClient.ChannelPool;
    }

    /// <summary>GroundedGenerationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for grounded generation.
    /// </remarks>
    public abstract partial class GroundedGenerationServiceClient
    {
        /// <summary>
        /// The default endpoint for the GroundedGenerationService service, which is a host of
        /// "discoveryengine.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default GroundedGenerationService scopes.</summary>
        /// <remarks>
        /// The default GroundedGenerationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GroundedGenerationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GroundedGenerationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GroundedGenerationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GroundedGenerationServiceClient"/>.</returns>
        public static stt::Task<GroundedGenerationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GroundedGenerationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GroundedGenerationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GroundedGenerationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GroundedGenerationServiceClient"/>.</returns>
        public static GroundedGenerationServiceClient Create() => new GroundedGenerationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GroundedGenerationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GroundedGenerationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GroundedGenerationServiceClient"/>.</returns>
        internal static GroundedGenerationServiceClient Create(grpccore::CallInvoker callInvoker, GroundedGenerationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GroundedGenerationService.GroundedGenerationServiceClient grpcClient = new GroundedGenerationService.GroundedGenerationServiceClient(callInvoker);
            return new GroundedGenerationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GroundedGenerationService client</summary>
        public virtual GroundedGenerationService.GroundedGenerationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamGenerateGroundedContent(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamGenerateGroundedContentStream : gaxgrpc::BidirectionalStreamingBase<GenerateGroundedContentRequest, GenerateGroundedContentResponse>
        {
        }

        /// <summary>
        /// Generates grounded content in a streaming fashion.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamGenerateGroundedContentStream StreamGenerateGroundedContent(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates grounded content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateGroundedContentResponse GenerateGroundedContent(GenerateGroundedContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates grounded content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateGroundedContentResponse> GenerateGroundedContentAsync(GenerateGroundedContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates grounded content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateGroundedContentResponse> GenerateGroundedContentAsync(GenerateGroundedContentRequest request, st::CancellationToken cancellationToken) =>
            GenerateGroundedContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs a grounding check.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckGroundingResponse CheckGrounding(CheckGroundingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs a grounding check.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckGroundingResponse> CheckGroundingAsync(CheckGroundingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs a grounding check.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckGroundingResponse> CheckGroundingAsync(CheckGroundingRequest request, st::CancellationToken cancellationToken) =>
            CheckGroundingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GroundedGenerationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for grounded generation.
    /// </remarks>
    public sealed partial class GroundedGenerationServiceClientImpl : GroundedGenerationServiceClient
    {
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<GenerateGroundedContentRequest, GenerateGroundedContentResponse> _callStreamGenerateGroundedContent;

        private readonly gaxgrpc::ApiCall<GenerateGroundedContentRequest, GenerateGroundedContentResponse> _callGenerateGroundedContent;

        private readonly gaxgrpc::ApiCall<CheckGroundingRequest, CheckGroundingResponse> _callCheckGrounding;

        /// <summary>
        /// Constructs a client wrapper for the GroundedGenerationService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="GroundedGenerationServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GroundedGenerationServiceClientImpl(GroundedGenerationService.GroundedGenerationServiceClient grpcClient, GroundedGenerationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GroundedGenerationServiceSettings effectiveSettings = settings ?? GroundedGenerationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callStreamGenerateGroundedContent = clientHelper.BuildApiCall<GenerateGroundedContentRequest, GenerateGroundedContentResponse>("StreamGenerateGroundedContent", grpcClient.StreamGenerateGroundedContent, effectiveSettings.StreamGenerateGroundedContentSettings, effectiveSettings.StreamGenerateGroundedContentStreamingSettings);
            Modify_ApiCall(ref _callStreamGenerateGroundedContent);
            Modify_StreamGenerateGroundedContentApiCall(ref _callStreamGenerateGroundedContent);
            _callGenerateGroundedContent = clientHelper.BuildApiCall<GenerateGroundedContentRequest, GenerateGroundedContentResponse>("GenerateGroundedContent", grpcClient.GenerateGroundedContentAsync, grpcClient.GenerateGroundedContent, effectiveSettings.GenerateGroundedContentSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callGenerateGroundedContent);
            Modify_GenerateGroundedContentApiCall(ref _callGenerateGroundedContent);
            _callCheckGrounding = clientHelper.BuildApiCall<CheckGroundingRequest, CheckGroundingResponse>("CheckGrounding", grpcClient.CheckGroundingAsync, grpcClient.CheckGrounding, effectiveSettings.CheckGroundingSettings).WithGoogleRequestParam("grounding_config", request => request.GroundingConfig);
            Modify_ApiCall(ref _callCheckGrounding);
            Modify_CheckGroundingApiCall(ref _callCheckGrounding);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_StreamGenerateGroundedContentApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<GenerateGroundedContentRequest, GenerateGroundedContentResponse> call);

        partial void Modify_GenerateGroundedContentApiCall(ref gaxgrpc::ApiCall<GenerateGroundedContentRequest, GenerateGroundedContentResponse> call);

        partial void Modify_CheckGroundingApiCall(ref gaxgrpc::ApiCall<CheckGroundingRequest, CheckGroundingResponse> call);

        partial void OnConstruction(GroundedGenerationService.GroundedGenerationServiceClient grpcClient, GroundedGenerationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GroundedGenerationService client</summary>
        public override GroundedGenerationService.GroundedGenerationServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GenerateGroundedContentRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateGroundedContentRequestRequest(ref GenerateGroundedContentRequest request);

        partial void Modify_GenerateGroundedContentRequest(ref GenerateGroundedContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CheckGroundingRequest(ref CheckGroundingRequest request, ref gaxgrpc::CallSettings settings);

        internal sealed partial class StreamGenerateGroundedContentStreamImpl : StreamGenerateGroundedContentStream
        {
            /// <summary>
            /// Construct the bidirectional streaming method for <c>StreamGenerateGroundedContent</c>.
            /// </summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{GenerateGroundedContentRequest}"/> instance
            /// associated with this streaming call.
            /// </param>
            public StreamGenerateGroundedContentStreamImpl(GroundedGenerationServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<GenerateGroundedContentRequest, GenerateGroundedContentResponse> call, gaxgrpc::BufferedClientStreamWriter<GenerateGroundedContentRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private GroundedGenerationServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<GenerateGroundedContentRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<GenerateGroundedContentRequest, GenerateGroundedContentResponse> GrpcCall { get; }

            private GenerateGroundedContentRequest ModifyRequest(GenerateGroundedContentRequest request)
            {
                _service.Modify_GenerateGroundedContentRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(GenerateGroundedContentRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(GenerateGroundedContentRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(GenerateGroundedContentRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(GenerateGroundedContentRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Generates grounded content in a streaming fashion.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override GroundedGenerationServiceClient.StreamGenerateGroundedContentStream StreamGenerateGroundedContent(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_GenerateGroundedContentRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamGenerateGroundedContent.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<GenerateGroundedContentRequest, GenerateGroundedContentResponse> call = _callStreamGenerateGroundedContent.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<GenerateGroundedContentRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<GenerateGroundedContentRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamGenerateGroundedContentStreamImpl(this, call, writeBuffer);
        }

        /// <summary>
        /// Generates grounded content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateGroundedContentResponse GenerateGroundedContent(GenerateGroundedContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateGroundedContentRequest(ref request, ref callSettings);
            return _callGenerateGroundedContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates grounded content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateGroundedContentResponse> GenerateGroundedContentAsync(GenerateGroundedContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateGroundedContentRequest(ref request, ref callSettings);
            return _callGenerateGroundedContent.Async(request, callSettings);
        }

        /// <summary>
        /// Performs a grounding check.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckGroundingResponse CheckGrounding(CheckGroundingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckGroundingRequest(ref request, ref callSettings);
            return _callCheckGrounding.Sync(request, callSettings);
        }

        /// <summary>
        /// Performs a grounding check.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckGroundingResponse> CheckGroundingAsync(CheckGroundingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckGroundingRequest(ref request, ref callSettings);
            return _callCheckGrounding.Async(request, callSettings);
        }
    }

    public static partial class GroundedGenerationService
    {
        public partial class GroundedGenerationServiceClient
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
