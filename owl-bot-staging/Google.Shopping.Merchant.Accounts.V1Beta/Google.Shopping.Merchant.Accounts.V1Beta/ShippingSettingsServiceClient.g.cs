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

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Settings for <see cref="ShippingSettingsServiceClient"/> instances.</summary>
    public sealed partial class ShippingSettingsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ShippingSettingsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ShippingSettingsServiceSettings"/>.</returns>
        public static ShippingSettingsServiceSettings GetDefault() => new ShippingSettingsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ShippingSettingsServiceSettings"/> object with default settings.
        /// </summary>
        public ShippingSettingsServiceSettings()
        {
        }

        private ShippingSettingsServiceSettings(ShippingSettingsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetShippingSettingsSettings = existing.GetShippingSettingsSettings;
            InsertShippingSettingsSettings = existing.InsertShippingSettingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ShippingSettingsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ShippingSettingsServiceClient.GetShippingSettings</c> and
        /// <c>ShippingSettingsServiceClient.GetShippingSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetShippingSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ShippingSettingsServiceClient.InsertShippingSettings</c> and
        /// <c>ShippingSettingsServiceClient.InsertShippingSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertShippingSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ShippingSettingsServiceSettings"/> object.</returns>
        public ShippingSettingsServiceSettings Clone() => new ShippingSettingsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ShippingSettingsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ShippingSettingsServiceClientBuilder : gaxgrpc::ClientBuilderBase<ShippingSettingsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ShippingSettingsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ShippingSettingsServiceClientBuilder() : base(ShippingSettingsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ShippingSettingsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ShippingSettingsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ShippingSettingsServiceClient Build()
        {
            ShippingSettingsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ShippingSettingsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ShippingSettingsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ShippingSettingsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ShippingSettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ShippingSettingsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ShippingSettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ShippingSettingsServiceClient.ChannelPool;
    }

    /// <summary>ShippingSettingsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to get method call shipping setting information per Merchant API
    /// method.
    /// </remarks>
    public abstract partial class ShippingSettingsServiceClient
    {
        /// <summary>
        /// The default endpoint for the ShippingSettingsService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default ShippingSettingsService scopes.</summary>
        /// <remarks>
        /// The default ShippingSettingsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ShippingSettingsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ShippingSettingsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ShippingSettingsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ShippingSettingsServiceClient"/>.</returns>
        public static stt::Task<ShippingSettingsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ShippingSettingsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ShippingSettingsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ShippingSettingsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ShippingSettingsServiceClient"/>.</returns>
        public static ShippingSettingsServiceClient Create() => new ShippingSettingsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ShippingSettingsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ShippingSettingsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ShippingSettingsServiceClient"/>.</returns>
        internal static ShippingSettingsServiceClient Create(grpccore::CallInvoker callInvoker, ShippingSettingsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ShippingSettingsService.ShippingSettingsServiceClient grpcClient = new ShippingSettingsService.ShippingSettingsServiceClient(callInvoker);
            return new ShippingSettingsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ShippingSettingsService client</summary>
        public virtual ShippingSettingsService.ShippingSettingsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve shipping setting information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ShippingSettings GetShippingSettings(GetShippingSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve shipping setting information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShippingSettings> GetShippingSettingsAsync(GetShippingSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve shipping setting information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShippingSettings> GetShippingSettingsAsync(GetShippingSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetShippingSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve shipping setting information.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the shipping setting to retrieve.
        /// Format: `accounts/{account}/shippingsetting`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ShippingSettings GetShippingSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetShippingSettings(new GetShippingSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve shipping setting information.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the shipping setting to retrieve.
        /// Format: `accounts/{account}/shippingsetting`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShippingSettings> GetShippingSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetShippingSettingsAsync(new GetShippingSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve shipping setting information.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the shipping setting to retrieve.
        /// Format: `accounts/{account}/shippingsetting`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShippingSettings> GetShippingSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetShippingSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve shipping setting information.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the shipping setting to retrieve.
        /// Format: `accounts/{account}/shippingsetting`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ShippingSettings GetShippingSettings(ShippingSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetShippingSettings(new GetShippingSettingsRequest
            {
                ShippingSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve shipping setting information.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the shipping setting to retrieve.
        /// Format: `accounts/{account}/shippingsetting`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShippingSettings> GetShippingSettingsAsync(ShippingSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetShippingSettingsAsync(new GetShippingSettingsRequest
            {
                ShippingSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve shipping setting information.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the shipping setting to retrieve.
        /// Format: `accounts/{account}/shippingsetting`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShippingSettings> GetShippingSettingsAsync(ShippingSettingsName name, st::CancellationToken cancellationToken) =>
            GetShippingSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replace the shipping setting of a merchant with the request shipping
        /// setting. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ShippingSettings InsertShippingSettings(InsertShippingSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replace the shipping setting of a merchant with the request shipping
        /// setting. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShippingSettings> InsertShippingSettingsAsync(InsertShippingSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replace the shipping setting of a merchant with the request shipping
        /// setting. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ShippingSettings> InsertShippingSettingsAsync(InsertShippingSettingsRequest request, st::CancellationToken cancellationToken) =>
            InsertShippingSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ShippingSettingsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to get method call shipping setting information per Merchant API
    /// method.
    /// </remarks>
    public sealed partial class ShippingSettingsServiceClientImpl : ShippingSettingsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetShippingSettingsRequest, ShippingSettings> _callGetShippingSettings;

        private readonly gaxgrpc::ApiCall<InsertShippingSettingsRequest, ShippingSettings> _callInsertShippingSettings;

        /// <summary>
        /// Constructs a client wrapper for the ShippingSettingsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ShippingSettingsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ShippingSettingsServiceClientImpl(ShippingSettingsService.ShippingSettingsServiceClient grpcClient, ShippingSettingsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ShippingSettingsServiceSettings effectiveSettings = settings ?? ShippingSettingsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetShippingSettings = clientHelper.BuildApiCall<GetShippingSettingsRequest, ShippingSettings>("GetShippingSettings", grpcClient.GetShippingSettingsAsync, grpcClient.GetShippingSettings, effectiveSettings.GetShippingSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetShippingSettings);
            Modify_GetShippingSettingsApiCall(ref _callGetShippingSettings);
            _callInsertShippingSettings = clientHelper.BuildApiCall<InsertShippingSettingsRequest, ShippingSettings>("InsertShippingSettings", grpcClient.InsertShippingSettingsAsync, grpcClient.InsertShippingSettings, effectiveSettings.InsertShippingSettingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callInsertShippingSettings);
            Modify_InsertShippingSettingsApiCall(ref _callInsertShippingSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetShippingSettingsApiCall(ref gaxgrpc::ApiCall<GetShippingSettingsRequest, ShippingSettings> call);

        partial void Modify_InsertShippingSettingsApiCall(ref gaxgrpc::ApiCall<InsertShippingSettingsRequest, ShippingSettings> call);

        partial void OnConstruction(ShippingSettingsService.ShippingSettingsServiceClient grpcClient, ShippingSettingsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ShippingSettingsService client</summary>
        public override ShippingSettingsService.ShippingSettingsServiceClient GrpcClient { get; }

        partial void Modify_GetShippingSettingsRequest(ref GetShippingSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertShippingSettingsRequest(ref InsertShippingSettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieve shipping setting information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ShippingSettings GetShippingSettings(GetShippingSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetShippingSettingsRequest(ref request, ref callSettings);
            return _callGetShippingSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve shipping setting information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ShippingSettings> GetShippingSettingsAsync(GetShippingSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetShippingSettingsRequest(ref request, ref callSettings);
            return _callGetShippingSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Replace the shipping setting of a merchant with the request shipping
        /// setting. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ShippingSettings InsertShippingSettings(InsertShippingSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertShippingSettingsRequest(ref request, ref callSettings);
            return _callInsertShippingSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Replace the shipping setting of a merchant with the request shipping
        /// setting. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ShippingSettings> InsertShippingSettingsAsync(InsertShippingSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertShippingSettingsRequest(ref request, ref callSettings);
            return _callInsertShippingSettings.Async(request, callSettings);
        }
    }
}
