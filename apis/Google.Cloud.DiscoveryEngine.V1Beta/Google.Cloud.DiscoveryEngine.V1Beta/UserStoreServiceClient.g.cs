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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Settings for <see cref="UserStoreServiceClient"/> instances.</summary>
    public sealed partial class UserStoreServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UserStoreServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UserStoreServiceSettings"/>.</returns>
        public static UserStoreServiceSettings GetDefault() => new UserStoreServiceSettings();

        /// <summary>Constructs a new <see cref="UserStoreServiceSettings"/> object with default settings.</summary>
        public UserStoreServiceSettings()
        {
        }

        private UserStoreServiceSettings(UserStoreServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetUserStoreSettings = existing.GetUserStoreSettings;
            UpdateUserStoreSettings = existing.UpdateUserStoreSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UserStoreServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserStoreServiceClient.GetUserStore</c> and <c>UserStoreServiceClient.GetUserStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUserStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserStoreServiceClient.UpdateUserStore</c> and <c>UserStoreServiceClient.UpdateUserStoreAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUserStoreSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserStoreServiceSettings"/> object.</returns>
        public UserStoreServiceSettings Clone() => new UserStoreServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserStoreServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class UserStoreServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserStoreServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserStoreServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public UserStoreServiceClientBuilder() : base(UserStoreServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref UserStoreServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UserStoreServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UserStoreServiceClient Build()
        {
            UserStoreServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UserStoreServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UserStoreServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UserStoreServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UserStoreServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<UserStoreServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserStoreServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserStoreServiceClient.ChannelPool;
    }

    /// <summary>UserStoreService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing User Stores.
    /// </remarks>
    public abstract partial class UserStoreServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserStoreService service, which is a host of "discoveryengine.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default UserStoreService scopes.</summary>
        /// <remarks>
        /// The default UserStoreService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.readwrite</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.serving.readwrite</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/discoveryengine.readwrite",
            "https://www.googleapis.com/auth/discoveryengine.serving.readwrite",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(UserStoreService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="UserStoreServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserStoreServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UserStoreServiceClient"/>.</returns>
        public static stt::Task<UserStoreServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UserStoreServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UserStoreServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserStoreServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UserStoreServiceClient"/>.</returns>
        public static UserStoreServiceClient Create() => new UserStoreServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UserStoreServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UserStoreServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="UserStoreServiceClient"/>.</returns>
        internal static UserStoreServiceClient Create(grpccore::CallInvoker callInvoker, UserStoreServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserStoreService.UserStoreServiceClient grpcClient = new UserStoreService.UserStoreServiceClient(callInvoker);
            return new UserStoreServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC UserStoreService client</summary>
        public virtual UserStoreService.UserStoreServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the User Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserStore GetUserStore(GetUserStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the User Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserStore> GetUserStoreAsync(GetUserStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the User Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserStore> GetUserStoreAsync(GetUserStoreRequest request, st::CancellationToken cancellationToken) =>
            GetUserStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the User Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the User Store to get.
        /// Format:
        /// `projects/{project}/locations/{location}/userStores/{user_store_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserStore GetUserStore(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserStore(new GetUserStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the User Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the User Store to get.
        /// Format:
        /// `projects/{project}/locations/{location}/userStores/{user_store_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserStore> GetUserStoreAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserStoreAsync(new GetUserStoreRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the User Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the User Store to get.
        /// Format:
        /// `projects/{project}/locations/{location}/userStores/{user_store_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserStore> GetUserStoreAsync(string name, st::CancellationToken cancellationToken) =>
            GetUserStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the User Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the User Store to get.
        /// Format:
        /// `projects/{project}/locations/{location}/userStores/{user_store_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserStore GetUserStore(UserStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserStore(new GetUserStoreRequest
            {
                UserStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the User Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the User Store to get.
        /// Format:
        /// `projects/{project}/locations/{location}/userStores/{user_store_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserStore> GetUserStoreAsync(UserStoreName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserStoreAsync(new GetUserStoreRequest
            {
                UserStoreName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the User Store.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the User Store to get.
        /// Format:
        /// `projects/{project}/locations/{location}/userStores/{user_store_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserStore> GetUserStoreAsync(UserStoreName name, st::CancellationToken cancellationToken) =>
            GetUserStoreAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the User Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserStore UpdateUserStore(UpdateUserStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the User Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserStore> UpdateUserStoreAsync(UpdateUserStoreRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the User Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserStore> UpdateUserStoreAsync(UpdateUserStoreRequest request, st::CancellationToken cancellationToken) =>
            UpdateUserStoreAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the User Store.
        /// </summary>
        /// <param name="userStore">
        /// Required. The User Store to update.
        /// Format:
        /// `projects/{project}/locations/{location}/userStores/{user_store_id}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserStore UpdateUserStore(UserStore userStore, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserStore(new UpdateUserStoreRequest
            {
                UserStore = gax::GaxPreconditions.CheckNotNull(userStore, nameof(userStore)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the User Store.
        /// </summary>
        /// <param name="userStore">
        /// Required. The User Store to update.
        /// Format:
        /// `projects/{project}/locations/{location}/userStores/{user_store_id}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserStore> UpdateUserStoreAsync(UserStore userStore, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserStoreAsync(new UpdateUserStoreRequest
            {
                UserStore = gax::GaxPreconditions.CheckNotNull(userStore, nameof(userStore)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the User Store.
        /// </summary>
        /// <param name="userStore">
        /// Required. The User Store to update.
        /// Format:
        /// `projects/{project}/locations/{location}/userStores/{user_store_id}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserStore> UpdateUserStoreAsync(UserStore userStore, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUserStoreAsync(userStore, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>UserStoreService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing User Stores.
    /// </remarks>
    public sealed partial class UserStoreServiceClientImpl : UserStoreServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetUserStoreRequest, UserStore> _callGetUserStore;

        private readonly gaxgrpc::ApiCall<UpdateUserStoreRequest, UserStore> _callUpdateUserStore;

        /// <summary>
        /// Constructs a client wrapper for the UserStoreService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UserStoreServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public UserStoreServiceClientImpl(UserStoreService.UserStoreServiceClient grpcClient, UserStoreServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            UserStoreServiceSettings effectiveSettings = settings ?? UserStoreServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetUserStore = clientHelper.BuildApiCall<GetUserStoreRequest, UserStore>("GetUserStore", grpcClient.GetUserStoreAsync, grpcClient.GetUserStore, effectiveSettings.GetUserStoreSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUserStore);
            Modify_GetUserStoreApiCall(ref _callGetUserStore);
            _callUpdateUserStore = clientHelper.BuildApiCall<UpdateUserStoreRequest, UserStore>("UpdateUserStore", grpcClient.UpdateUserStoreAsync, grpcClient.UpdateUserStore, effectiveSettings.UpdateUserStoreSettings).WithGoogleRequestParam("user_store.name", request => request.UserStore?.Name);
            Modify_ApiCall(ref _callUpdateUserStore);
            Modify_UpdateUserStoreApiCall(ref _callUpdateUserStore);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetUserStoreApiCall(ref gaxgrpc::ApiCall<GetUserStoreRequest, UserStore> call);

        partial void Modify_UpdateUserStoreApiCall(ref gaxgrpc::ApiCall<UpdateUserStoreRequest, UserStore> call);

        partial void OnConstruction(UserStoreService.UserStoreServiceClient grpcClient, UserStoreServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserStoreService client</summary>
        public override UserStoreService.UserStoreServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetUserStoreRequest(ref GetUserStoreRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUserStoreRequest(ref UpdateUserStoreRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the User Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserStore GetUserStore(GetUserStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserStoreRequest(ref request, ref callSettings);
            return _callGetUserStore.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the User Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserStore> GetUserStoreAsync(GetUserStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserStoreRequest(ref request, ref callSettings);
            return _callGetUserStore.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the User Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserStore UpdateUserStore(UpdateUserStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserStoreRequest(ref request, ref callSettings);
            return _callUpdateUserStore.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the User Store.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserStore> UpdateUserStoreAsync(UpdateUserStoreRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserStoreRequest(ref request, ref callSettings);
            return _callUpdateUserStore.Async(request, callSettings);
        }
    }

    public static partial class UserStoreService
    {
        public partial class UserStoreServiceClient
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
