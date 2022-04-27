// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Settings for <see cref="FeaturestoreOnlineServingServiceClient"/> instances.</summary>
    public sealed partial class FeaturestoreOnlineServingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FeaturestoreOnlineServingServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FeaturestoreOnlineServingServiceSettings"/>.</returns>
        public static FeaturestoreOnlineServingServiceSettings GetDefault() => new FeaturestoreOnlineServingServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="FeaturestoreOnlineServingServiceSettings"/> object with default settings.
        /// </summary>
        public FeaturestoreOnlineServingServiceSettings()
        {
        }

        private FeaturestoreOnlineServingServiceSettings(FeaturestoreOnlineServingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ReadFeatureValuesSettings = existing.ReadFeatureValuesSettings;
            StreamingReadFeatureValuesSettings = existing.StreamingReadFeatureValuesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeaturestoreOnlineServingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreOnlineServingServiceClient.ReadFeatureValues</c> and
        /// <c>FeaturestoreOnlineServingServiceClient.ReadFeatureValuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReadFeatureValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturestoreOnlineServingServiceClient.StreamingReadFeatureValues</c> and
        /// <c>FeaturestoreOnlineServingServiceClient.StreamingReadFeatureValuesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamingReadFeatureValuesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FeaturestoreOnlineServingServiceSettings"/> object.</returns>
        public FeaturestoreOnlineServingServiceSettings Clone() => new FeaturestoreOnlineServingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeaturestoreOnlineServingServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class FeaturestoreOnlineServingServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeaturestoreOnlineServingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeaturestoreOnlineServingServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FeaturestoreOnlineServingServiceClientBuilder() : base(FeaturestoreOnlineServingServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FeaturestoreOnlineServingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeaturestoreOnlineServingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeaturestoreOnlineServingServiceClient Build()
        {
            FeaturestoreOnlineServingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeaturestoreOnlineServingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeaturestoreOnlineServingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeaturestoreOnlineServingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeaturestoreOnlineServingServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<FeaturestoreOnlineServingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeaturestoreOnlineServingServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeaturestoreOnlineServingServiceClient.ChannelPool;
    }

    /// <summary>FeaturestoreOnlineServingService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for serving online feature values.
    /// </remarks>
    public abstract partial class FeaturestoreOnlineServingServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeaturestoreOnlineServingService service, which is a host of
        /// "aiplatform.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default FeaturestoreOnlineServingService scopes.</summary>
        /// <remarks>
        /// The default FeaturestoreOnlineServingService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FeaturestoreOnlineServingService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FeaturestoreOnlineServingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="FeaturestoreOnlineServingServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FeaturestoreOnlineServingServiceClient"/>.</returns>
        public static stt::Task<FeaturestoreOnlineServingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeaturestoreOnlineServingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeaturestoreOnlineServingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="FeaturestoreOnlineServingServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FeaturestoreOnlineServingServiceClient"/>.</returns>
        public static FeaturestoreOnlineServingServiceClient Create() =>
            new FeaturestoreOnlineServingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeaturestoreOnlineServingServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeaturestoreOnlineServingServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FeaturestoreOnlineServingServiceClient"/>.</returns>
        internal static FeaturestoreOnlineServingServiceClient Create(grpccore::CallInvoker callInvoker, FeaturestoreOnlineServingServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient grpcClient = new FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient(callInvoker);
            return new FeaturestoreOnlineServingServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FeaturestoreOnlineServingService client</summary>
        public virtual FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Reads Feature values of a specific entity of an EntityType. For reading
        /// feature values of multiple entities of an EntityType, please use
        /// StreamingReadFeatureValues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadFeatureValuesResponse ReadFeatureValues(ReadFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads Feature values of a specific entity of an EntityType. For reading
        /// feature values of multiple entities of an EntityType, please use
        /// StreamingReadFeatureValues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadFeatureValuesResponse> ReadFeatureValuesAsync(ReadFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads Feature values of a specific entity of an EntityType. For reading
        /// feature values of multiple entities of an EntityType, please use
        /// StreamingReadFeatureValues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadFeatureValuesResponse> ReadFeatureValuesAsync(ReadFeatureValuesRequest request, st::CancellationToken cancellationToken) =>
            ReadFeatureValuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads Feature values of a specific entity of an EntityType. For reading
        /// feature values of multiple entities of an EntityType, please use
        /// StreamingReadFeatureValues.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType for the entity being read.
        /// Value format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`.
        /// For example, for a machine learning model predicting user clicks on a
        /// website, an EntityType ID could be `user`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadFeatureValuesResponse ReadFeatureValues(string entityType, gaxgrpc::CallSettings callSettings = null) =>
            ReadFeatureValues(new ReadFeatureValuesRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNullOrEmpty(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Reads Feature values of a specific entity of an EntityType. For reading
        /// feature values of multiple entities of an EntityType, please use
        /// StreamingReadFeatureValues.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType for the entity being read.
        /// Value format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`.
        /// For example, for a machine learning model predicting user clicks on a
        /// website, an EntityType ID could be `user`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadFeatureValuesResponse> ReadFeatureValuesAsync(string entityType, gaxgrpc::CallSettings callSettings = null) =>
            ReadFeatureValuesAsync(new ReadFeatureValuesRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNullOrEmpty(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Reads Feature values of a specific entity of an EntityType. For reading
        /// feature values of multiple entities of an EntityType, please use
        /// StreamingReadFeatureValues.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType for the entity being read.
        /// Value format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`.
        /// For example, for a machine learning model predicting user clicks on a
        /// website, an EntityType ID could be `user`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadFeatureValuesResponse> ReadFeatureValuesAsync(string entityType, st::CancellationToken cancellationToken) =>
            ReadFeatureValuesAsync(entityType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads Feature values of a specific entity of an EntityType. For reading
        /// feature values of multiple entities of an EntityType, please use
        /// StreamingReadFeatureValues.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType for the entity being read.
        /// Value format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`.
        /// For example, for a machine learning model predicting user clicks on a
        /// website, an EntityType ID could be `user`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadFeatureValuesResponse ReadFeatureValues(EntityTypeName entityType, gaxgrpc::CallSettings callSettings = null) =>
            ReadFeatureValues(new ReadFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Reads Feature values of a specific entity of an EntityType. For reading
        /// feature values of multiple entities of an EntityType, please use
        /// StreamingReadFeatureValues.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType for the entity being read.
        /// Value format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`.
        /// For example, for a machine learning model predicting user clicks on a
        /// website, an EntityType ID could be `user`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadFeatureValuesResponse> ReadFeatureValuesAsync(EntityTypeName entityType, gaxgrpc::CallSettings callSettings = null) =>
            ReadFeatureValuesAsync(new ReadFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Reads Feature values of a specific entity of an EntityType. For reading
        /// feature values of multiple entities of an EntityType, please use
        /// StreamingReadFeatureValues.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the EntityType for the entity being read.
        /// Value format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`.
        /// For example, for a machine learning model predicting user clicks on a
        /// website, an EntityType ID could be `user`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadFeatureValuesResponse> ReadFeatureValuesAsync(EntityTypeName entityType, st::CancellationToken cancellationToken) =>
            ReadFeatureValuesAsync(entityType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for
        /// <see cref="StreamingReadFeatureValues(StreamingReadFeatureValuesRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class StreamingReadFeatureValuesStream : gaxgrpc::ServerStreamingBase<ReadFeatureValuesResponse>
        {
        }

        /// <summary>
        /// Reads Feature values for multiple entities. Depending on their size, data
        /// for different entities may be broken
        /// up across multiple responses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual StreamingReadFeatureValuesStream StreamingReadFeatureValues(StreamingReadFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads Feature values for multiple entities. Depending on their size, data
        /// for different entities may be broken
        /// up across multiple responses.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the entities' type.
        /// Value format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`.
        /// For example,
        /// for a machine learning model predicting user clicks on a website, an
        /// EntityType ID could be `user`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual StreamingReadFeatureValuesStream StreamingReadFeatureValues(string entityType, gaxgrpc::CallSettings callSettings = null) =>
            StreamingReadFeatureValues(new StreamingReadFeatureValuesRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNullOrEmpty(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Reads Feature values for multiple entities. Depending on their size, data
        /// for different entities may be broken
        /// up across multiple responses.
        /// </summary>
        /// <param name="entityType">
        /// Required. The resource name of the entities' type.
        /// Value format:
        /// `projects/{project}/locations/{location}/featurestores/{featurestore}/entityTypes/{entityType}`.
        /// For example,
        /// for a machine learning model predicting user clicks on a website, an
        /// EntityType ID could be `user`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual StreamingReadFeatureValuesStream StreamingReadFeatureValues(EntityTypeName entityType, gaxgrpc::CallSettings callSettings = null) =>
            StreamingReadFeatureValues(new StreamingReadFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);
    }

    /// <summary>FeaturestoreOnlineServingService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for serving online feature values.
    /// </remarks>
    public sealed partial class FeaturestoreOnlineServingServiceClientImpl : FeaturestoreOnlineServingServiceClient
    {
        private readonly gaxgrpc::ApiCall<ReadFeatureValuesRequest, ReadFeatureValuesResponse> _callReadFeatureValues;

        private readonly gaxgrpc::ApiServerStreamingCall<StreamingReadFeatureValuesRequest, ReadFeatureValuesResponse> _callStreamingReadFeatureValues;

        /// <summary>
        /// Constructs a client wrapper for the FeaturestoreOnlineServingService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="FeaturestoreOnlineServingServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FeaturestoreOnlineServingServiceClientImpl(FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient grpcClient, FeaturestoreOnlineServingServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FeaturestoreOnlineServingServiceSettings effectiveSettings = settings ?? FeaturestoreOnlineServingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callReadFeatureValues = clientHelper.BuildApiCall<ReadFeatureValuesRequest, ReadFeatureValuesResponse>("ReadFeatureValues", grpcClient.ReadFeatureValuesAsync, grpcClient.ReadFeatureValues, effectiveSettings.ReadFeatureValuesSettings).WithGoogleRequestParam("entity_type", request => request.EntityType);
            Modify_ApiCall(ref _callReadFeatureValues);
            Modify_ReadFeatureValuesApiCall(ref _callReadFeatureValues);
            _callStreamingReadFeatureValues = clientHelper.BuildApiCall<StreamingReadFeatureValuesRequest, ReadFeatureValuesResponse>("StreamingReadFeatureValues", grpcClient.StreamingReadFeatureValues, effectiveSettings.StreamingReadFeatureValuesSettings).WithGoogleRequestParam("entity_type", request => request.EntityType);
            Modify_ApiCall(ref _callStreamingReadFeatureValues);
            Modify_StreamingReadFeatureValuesApiCall(ref _callStreamingReadFeatureValues);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ReadFeatureValuesApiCall(ref gaxgrpc::ApiCall<ReadFeatureValuesRequest, ReadFeatureValuesResponse> call);

        partial void Modify_StreamingReadFeatureValuesApiCall(ref gaxgrpc::ApiServerStreamingCall<StreamingReadFeatureValuesRequest, ReadFeatureValuesResponse> call);

        partial void OnConstruction(FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient grpcClient, FeaturestoreOnlineServingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeaturestoreOnlineServingService client</summary>
        public override FeaturestoreOnlineServingService.FeaturestoreOnlineServingServiceClient GrpcClient { get; }

        partial void Modify_ReadFeatureValuesRequest(ref ReadFeatureValuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingReadFeatureValuesRequest(ref StreamingReadFeatureValuesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Reads Feature values of a specific entity of an EntityType. For reading
        /// feature values of multiple entities of an EntityType, please use
        /// StreamingReadFeatureValues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReadFeatureValuesResponse ReadFeatureValues(ReadFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadFeatureValuesRequest(ref request, ref callSettings);
            return _callReadFeatureValues.Sync(request, callSettings);
        }

        /// <summary>
        /// Reads Feature values of a specific entity of an EntityType. For reading
        /// feature values of multiple entities of an EntityType, please use
        /// StreamingReadFeatureValues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReadFeatureValuesResponse> ReadFeatureValuesAsync(ReadFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadFeatureValuesRequest(ref request, ref callSettings);
            return _callReadFeatureValues.Async(request, callSettings);
        }

        internal sealed partial class StreamingReadFeatureValuesStreamImpl : StreamingReadFeatureValuesStream
        {
            /// <summary>Construct the server streaming method for <c>StreamingReadFeatureValues</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public StreamingReadFeatureValuesStreamImpl(grpccore::AsyncServerStreamingCall<ReadFeatureValuesResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ReadFeatureValuesResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Reads Feature values for multiple entities. Depending on their size, data
        /// for different entities may be broken
        /// up across multiple responses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override FeaturestoreOnlineServingServiceClient.StreamingReadFeatureValuesStream StreamingReadFeatureValues(StreamingReadFeatureValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StreamingReadFeatureValuesRequest(ref request, ref callSettings);
            return new StreamingReadFeatureValuesStreamImpl(_callStreamingReadFeatureValues.Call(request, callSettings));
        }
    }
}
