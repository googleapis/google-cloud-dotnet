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

namespace Google.Cloud.Retail.V2
{
    /// <summary>Settings for <see cref="ConversationalSearchServiceClient"/> instances.</summary>
    public sealed partial class ConversationalSearchServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConversationalSearchServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConversationalSearchServiceSettings"/>.</returns>
        public static ConversationalSearchServiceSettings GetDefault() => new ConversationalSearchServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConversationalSearchServiceSettings"/> object with default settings.
        /// </summary>
        public ConversationalSearchServiceSettings()
        {
        }

        private ConversationalSearchServiceSettings(ConversationalSearchServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ConversationalSearchSettings = existing.ConversationalSearchSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversationalSearchServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationalSearchServiceClient.ConversationalSearch</c> and
        /// <c>ConversationalSearchServiceClient.ConversationalSearchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ConversationalSearchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConversationalSearchServiceSettings"/> object.</returns>
        public ConversationalSearchServiceSettings Clone() => new ConversationalSearchServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversationalSearchServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class ConversationalSearchServiceClientBuilder : gaxgrpc::ClientBuilderBase<ConversationalSearchServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConversationalSearchServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConversationalSearchServiceClientBuilder() : base(ConversationalSearchServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConversationalSearchServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConversationalSearchServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConversationalSearchServiceClient Build()
        {
            ConversationalSearchServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConversationalSearchServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConversationalSearchServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConversationalSearchServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversationalSearchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConversationalSearchServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversationalSearchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversationalSearchServiceClient.ChannelPool;
    }

    /// <summary>ConversationalSearchService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for retail conversational search.
    /// 
    /// This feature is only available for users who have Retail Conversational
    /// Search enabled. Enable Retail Conversational Search on Cloud Console
    /// before using this feature.
    /// </remarks>
    public abstract partial class ConversationalSearchServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConversationalSearchService service, which is a host of "retail.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "retail.googleapis.com:443";

        /// <summary>The default ConversationalSearchService scopes.</summary>
        /// <remarks>
        /// The default ConversationalSearchService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ConversationalSearchService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConversationalSearchServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversationalSearchServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConversationalSearchServiceClient"/>.</returns>
        public static stt::Task<ConversationalSearchServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConversationalSearchServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConversationalSearchServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversationalSearchServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConversationalSearchServiceClient"/>.</returns>
        public static ConversationalSearchServiceClient Create() => new ConversationalSearchServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConversationalSearchServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConversationalSearchServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConversationalSearchServiceClient"/>.</returns>
        internal static ConversationalSearchServiceClient Create(grpccore::CallInvoker callInvoker, ConversationalSearchServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversationalSearchService.ConversationalSearchServiceClient grpcClient = new ConversationalSearchService.ConversationalSearchServiceClient(callInvoker);
            return new ConversationalSearchServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ConversationalSearchService client</summary>
        public virtual ConversationalSearchService.ConversationalSearchServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Server streaming methods for
        /// <see cref="ConversationalSearch(ConversationalSearchRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ConversationalSearchStream : gaxgrpc::ServerStreamingBase<ConversationalSearchResponse>
        {
        }

        /// <summary>
        /// Performs a conversational search.
        /// 
        /// This feature is only available for users who have Conversational Search
        /// enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ConversationalSearchStream ConversationalSearch(ConversationalSearchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>ConversationalSearchService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for retail conversational search.
    /// 
    /// This feature is only available for users who have Retail Conversational
    /// Search enabled. Enable Retail Conversational Search on Cloud Console
    /// before using this feature.
    /// </remarks>
    public sealed partial class ConversationalSearchServiceClientImpl : ConversationalSearchServiceClient
    {
        private readonly gaxgrpc::ApiServerStreamingCall<ConversationalSearchRequest, ConversationalSearchResponse> _callConversationalSearch;

        /// <summary>
        /// Constructs a client wrapper for the ConversationalSearchService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ConversationalSearchServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConversationalSearchServiceClientImpl(ConversationalSearchService.ConversationalSearchServiceClient grpcClient, ConversationalSearchServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConversationalSearchServiceSettings effectiveSettings = settings ?? ConversationalSearchServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callConversationalSearch = clientHelper.BuildApiCall<ConversationalSearchRequest, ConversationalSearchResponse>("ConversationalSearch", grpcClient.ConversationalSearch, effectiveSettings.ConversationalSearchSettings).WithGoogleRequestParam("placement", request => request.Placement);
            Modify_ApiCall(ref _callConversationalSearch);
            Modify_ConversationalSearchApiCall(ref _callConversationalSearch);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ConversationalSearchApiCall(ref gaxgrpc::ApiServerStreamingCall<ConversationalSearchRequest, ConversationalSearchResponse> call);

        partial void OnConstruction(ConversationalSearchService.ConversationalSearchServiceClient grpcClient, ConversationalSearchServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConversationalSearchService client</summary>
        public override ConversationalSearchService.ConversationalSearchServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ConversationalSearchRequest(ref ConversationalSearchRequest request, ref gaxgrpc::CallSettings settings);

        internal sealed partial class ConversationalSearchStreamImpl : ConversationalSearchStream
        {
            /// <summary>Construct the server streaming method for <c>ConversationalSearch</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ConversationalSearchStreamImpl(grpccore::AsyncServerStreamingCall<ConversationalSearchResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ConversationalSearchResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Performs a conversational search.
        /// 
        /// This feature is only available for users who have Conversational Search
        /// enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override ConversationalSearchServiceClient.ConversationalSearchStream ConversationalSearch(ConversationalSearchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConversationalSearchRequest(ref request, ref callSettings);
            return new ConversationalSearchStreamImpl(_callConversationalSearch.Call(request, callSettings));
        }
    }

    public static partial class ConversationalSearchService
    {
        public partial class ConversationalSearchServiceClient
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
