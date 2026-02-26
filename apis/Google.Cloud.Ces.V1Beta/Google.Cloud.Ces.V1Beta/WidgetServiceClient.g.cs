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

namespace Google.Cloud.Ces.V1Beta
{
    /// <summary>Settings for <see cref="WidgetServiceClient"/> instances.</summary>
    public sealed partial class WidgetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WidgetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WidgetServiceSettings"/>.</returns>
        public static WidgetServiceSettings GetDefault() => new WidgetServiceSettings();

        /// <summary>Constructs a new <see cref="WidgetServiceSettings"/> object with default settings.</summary>
        public WidgetServiceSettings()
        {
        }

        private WidgetServiceSettings(WidgetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateChatTokenSettings = existing.GenerateChatTokenSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(WidgetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WidgetServiceClient.GenerateChatToken</c> and <c>WidgetServiceClient.GenerateChatTokenAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateChatTokenSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WidgetServiceSettings"/> object.</returns>
        public WidgetServiceSettings Clone() => new WidgetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WidgetServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class WidgetServiceClientBuilder : gaxgrpc::ClientBuilderBase<WidgetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WidgetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WidgetServiceClientBuilder() : base(WidgetServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref WidgetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WidgetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WidgetServiceClient Build()
        {
            WidgetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WidgetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WidgetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WidgetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WidgetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<WidgetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WidgetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WidgetServiceClient.ChannelPool;
    }

    /// <summary>WidgetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides APIs for widgets to interact with CES APIs.
    /// </remarks>
    public abstract partial class WidgetServiceClient
    {
        /// <summary>
        /// The default endpoint for the WidgetService service, which is a host of "ces.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "ces.googleapis.com:443";

        /// <summary>The default WidgetService scopes.</summary>
        /// <remarks>
        /// The default WidgetService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/ces</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/ces",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(WidgetService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="WidgetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WidgetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WidgetServiceClient"/>.</returns>
        public static stt::Task<WidgetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WidgetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WidgetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WidgetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WidgetServiceClient"/>.</returns>
        public static WidgetServiceClient Create() => new WidgetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WidgetServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WidgetServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="WidgetServiceClient"/>.</returns>
        internal static WidgetServiceClient Create(grpccore::CallInvoker callInvoker, WidgetServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            WidgetService.WidgetServiceClient grpcClient = new WidgetService.WidgetServiceClient(callInvoker);
            return new WidgetServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC WidgetService client</summary>
        public virtual WidgetService.WidgetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a session scoped token for chat widget to authenticate with
        /// Session APIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateChatTokenResponse GenerateChatToken(GenerateChatTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a session scoped token for chat widget to authenticate with
        /// Session APIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateChatTokenResponse> GenerateChatTokenAsync(GenerateChatTokenRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a session scoped token for chat widget to authenticate with
        /// Session APIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateChatTokenResponse> GenerateChatTokenAsync(GenerateChatTokenRequest request, st::CancellationToken cancellationToken) =>
            GenerateChatTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>WidgetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides APIs for widgets to interact with CES APIs.
    /// </remarks>
    public sealed partial class WidgetServiceClientImpl : WidgetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GenerateChatTokenRequest, GenerateChatTokenResponse> _callGenerateChatToken;

        /// <summary>
        /// Constructs a client wrapper for the WidgetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WidgetServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public WidgetServiceClientImpl(WidgetService.WidgetServiceClient grpcClient, WidgetServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            WidgetServiceSettings effectiveSettings = settings ?? WidgetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGenerateChatToken = clientHelper.BuildApiCall<GenerateChatTokenRequest, GenerateChatTokenResponse>("GenerateChatToken", grpcClient.GenerateChatTokenAsync, grpcClient.GenerateChatToken, effectiveSettings.GenerateChatTokenSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateChatToken);
            Modify_GenerateChatTokenApiCall(ref _callGenerateChatToken);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateChatTokenApiCall(ref gaxgrpc::ApiCall<GenerateChatTokenRequest, GenerateChatTokenResponse> call);

        partial void OnConstruction(WidgetService.WidgetServiceClient grpcClient, WidgetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC WidgetService client</summary>
        public override WidgetService.WidgetServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GenerateChatTokenRequest(ref GenerateChatTokenRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Generates a session scoped token for chat widget to authenticate with
        /// Session APIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateChatTokenResponse GenerateChatToken(GenerateChatTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateChatTokenRequest(ref request, ref callSettings);
            return _callGenerateChatToken.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a session scoped token for chat widget to authenticate with
        /// Session APIs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateChatTokenResponse> GenerateChatTokenAsync(GenerateChatTokenRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateChatTokenRequest(ref request, ref callSettings);
            return _callGenerateChatToken.Async(request, callSettings);
        }
    }

    public static partial class WidgetService
    {
        public partial class WidgetServiceClient
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
