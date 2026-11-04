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

namespace Google.Cloud.Sql.V1Beta4
{
    /// <summary>Settings for <see cref="SqlDataServiceClient"/> instances.</summary>
    public sealed partial class SqlDataServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SqlDataServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SqlDataServiceSettings"/>.</returns>
        public static SqlDataServiceSettings GetDefault() => new SqlDataServiceSettings();

        /// <summary>Constructs a new <see cref="SqlDataServiceSettings"/> object with default settings.</summary>
        public SqlDataServiceSettings()
        {
        }

        private SqlDataServiceSettings(SqlDataServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            StreamSqlDataSettings = existing.StreamSqlDataSettings;
            StreamSqlDataStreamingSettings = existing.StreamSqlDataStreamingSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SqlDataServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SqlDataServiceClient.StreamSqlData</c> and <c>SqlDataServiceClient.StreamSqlDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamSqlDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>SqlDataServiceClient.StreamSqlData</c>
        /// and <c>SqlDataServiceClient.StreamSqlDataAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamSqlDataStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SqlDataServiceSettings"/> object.</returns>
        public SqlDataServiceSettings Clone() => new SqlDataServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SqlDataServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SqlDataServiceClientBuilder : gaxgrpc::ClientBuilderBase<SqlDataServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SqlDataServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SqlDataServiceClientBuilder() : base(SqlDataServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SqlDataServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SqlDataServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SqlDataServiceClient Build()
        {
            SqlDataServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SqlDataServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SqlDataServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SqlDataServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SqlDataServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SqlDataServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SqlDataServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SqlDataServiceClient.ChannelPool;
    }

    /// <summary>SqlDataService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for streaming data to and from Cloud SQL instances.
    /// </remarks>
    public abstract partial class SqlDataServiceClient
    {
        /// <summary>
        /// The default endpoint for the SqlDataService service, which is a host of "sqladmin.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "sqladmin.googleapis.com:443";

        /// <summary>The default SqlDataService scopes.</summary>
        /// <remarks>
        /// The default SqlDataService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/sqlservice.admin</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/sqlservice.admin",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SqlDataService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SqlDataServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SqlDataServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SqlDataServiceClient"/>.</returns>
        public static stt::Task<SqlDataServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SqlDataServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SqlDataServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SqlDataServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SqlDataServiceClient"/>.</returns>
        public static SqlDataServiceClient Create() => new SqlDataServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SqlDataServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SqlDataServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SqlDataServiceClient"/>.</returns>
        internal static SqlDataServiceClient Create(grpccore::CallInvoker callInvoker, SqlDataServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SqlDataService.SqlDataServiceClient grpcClient = new SqlDataService.SqlDataServiceClient(callInvoker);
            return new SqlDataServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SqlDataService client</summary>
        public virtual SqlDataService.SqlDataServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamSqlData(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamSqlDataStream : gaxgrpc::BidirectionalStreamingBase<StreamSqlDataRequest, StreamSqlDataResponse>
        {
        }

        /// <summary>
        /// `StreamSqlData` establishes a bidirectional stream to a Cloud SQL instance,
        /// and then streams data to and from the instance.
        /// 
        /// The first message from the client MUST be a `StreamSqlDataRequest` request
        /// with configuration settings, including required values for the
        /// `connection_settings` field. Subsequent messages from the client may
        /// contain the `payload` field.
        /// 
        /// Messages from the server may contain the `payload` field.
        /// 
        /// The `payload` fields of the request and response streams contain the raw
        /// data of the database's native wire protocol (e.g., PostgreSQL wire
        /// protocol). The database client is responsible for generating and parsing
        /// this data.
        /// 
        /// Any errors on initial connection (e.g., connection failure, authorization
        /// issues, network problems) will result in the stream being terminated with
        /// an appropriate RPC status exception.
        /// 
        /// After a successful connection is made, if an error occurs, then the server
        /// terminates connection and returns the appropriate RPC status exception.
        /// 
        /// Add the request params headers to the request to ensure that
        /// the streaming request is routed to the correct service for your database.
        /// 
        /// Use this format for the request params header:
        /// 
        /// `x-goog-request-params`:
        /// location_id={location_path}&amp;instance_id={instance_path}`
        /// 
        /// `location_path` is `locations/{location_name}`
        /// `instance_path` is `projects/{project_name}/instances/{instance_name}`
        /// 
        /// for example:
        /// `x-goog-request-params`:
        /// `location_id=locations/us-central1&amp;instance_id=projects/myproject/instances/instancename`
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamSqlDataStream StreamSqlData(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>SqlDataService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for streaming data to and from Cloud SQL instances.
    /// </remarks>
    public sealed partial class SqlDataServiceClientImpl : SqlDataServiceClient
    {
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamSqlDataRequest, StreamSqlDataResponse> _callStreamSqlData;

        /// <summary>
        /// Constructs a client wrapper for the SqlDataService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SqlDataServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SqlDataServiceClientImpl(SqlDataService.SqlDataServiceClient grpcClient, SqlDataServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SqlDataServiceSettings effectiveSettings = settings ?? SqlDataServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callStreamSqlData = clientHelper.BuildApiCall<StreamSqlDataRequest, StreamSqlDataResponse>("StreamSqlData", grpcClient.StreamSqlData, effectiveSettings.StreamSqlDataSettings, effectiveSettings.StreamSqlDataStreamingSettings);
            Modify_ApiCall(ref _callStreamSqlData);
            Modify_StreamSqlDataApiCall(ref _callStreamSqlData);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_StreamSqlDataApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamSqlDataRequest, StreamSqlDataResponse> call);

        partial void OnConstruction(SqlDataService.SqlDataServiceClient grpcClient, SqlDataServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SqlDataService client</summary>
        public override SqlDataService.SqlDataServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_StreamSqlDataRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamSqlDataRequestRequest(ref StreamSqlDataRequest request);

        internal sealed partial class StreamSqlDataStreamImpl : StreamSqlDataStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamSqlData</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamSqlDataRequest}"/> instance associated with
            /// this streaming call.
            /// </param>
            public StreamSqlDataStreamImpl(SqlDataServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamSqlDataRequest, StreamSqlDataResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamSqlDataRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private SqlDataServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamSqlDataRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamSqlDataRequest, StreamSqlDataResponse> GrpcCall { get; }

            private StreamSqlDataRequest ModifyRequest(StreamSqlDataRequest request)
            {
                _service.Modify_StreamSqlDataRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamSqlDataRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamSqlDataRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamSqlDataRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamSqlDataRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// `StreamSqlData` establishes a bidirectional stream to a Cloud SQL instance,
        /// and then streams data to and from the instance.
        /// 
        /// The first message from the client MUST be a `StreamSqlDataRequest` request
        /// with configuration settings, including required values for the
        /// `connection_settings` field. Subsequent messages from the client may
        /// contain the `payload` field.
        /// 
        /// Messages from the server may contain the `payload` field.
        /// 
        /// The `payload` fields of the request and response streams contain the raw
        /// data of the database's native wire protocol (e.g., PostgreSQL wire
        /// protocol). The database client is responsible for generating and parsing
        /// this data.
        /// 
        /// Any errors on initial connection (e.g., connection failure, authorization
        /// issues, network problems) will result in the stream being terminated with
        /// an appropriate RPC status exception.
        /// 
        /// After a successful connection is made, if an error occurs, then the server
        /// terminates connection and returns the appropriate RPC status exception.
        /// 
        /// Add the request params headers to the request to ensure that
        /// the streaming request is routed to the correct service for your database.
        /// 
        /// Use this format for the request params header:
        /// 
        /// `x-goog-request-params`:
        /// location_id={location_path}&amp;instance_id={instance_path}`
        /// 
        /// `location_path` is `locations/{location_name}`
        /// `instance_path` is `projects/{project_name}/instances/{instance_name}`
        /// 
        /// for example:
        /// `x-goog-request-params`:
        /// `location_id=locations/us-central1&amp;instance_id=projects/myproject/instances/instancename`
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override SqlDataServiceClient.StreamSqlDataStream StreamSqlData(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamSqlDataRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamSqlData.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamSqlDataRequest, StreamSqlDataResponse> call = _callStreamSqlData.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamSqlDataRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamSqlDataRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamSqlDataStreamImpl(this, call, writeBuffer);
        }
    }

    public static partial class SqlDataService
    {
        public partial class SqlDataServiceClient
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
