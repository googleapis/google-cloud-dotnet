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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="UserServiceClient"/> instances.</summary>
    public sealed partial class UserServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UserServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UserServiceSettings"/>.</returns>
        public static UserServiceSettings GetDefault() => new UserServiceSettings();

        /// <summary>Constructs a new <see cref="UserServiceSettings"/> object with default settings.</summary>
        public UserServiceSettings()
        {
        }

        private UserServiceSettings(UserServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetUserSettings = existing.GetUserSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UserServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>UserServiceClient.GetUser</c>
        ///  and <c>UserServiceClient.GetUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUserSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserServiceSettings"/> object.</returns>
        public UserServiceSettings Clone() => new UserServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class UserServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public UserServiceClientBuilder() : base(UserServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref UserServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UserServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UserServiceClient Build()
        {
            UserServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UserServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UserServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UserServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UserServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<UserServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserServiceClient.ChannelPool;
    }

    /// <summary>UserService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling User objects.
    /// </remarks>
    public abstract partial class UserServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserService service, which is a host of "admanager.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default UserService scopes.</summary>
        /// <remarks>
        /// The default UserService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(UserService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="UserServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UserServiceClient"/>.</returns>
        public static stt::Task<UserServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UserServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UserServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UserServiceClient"/>.</returns>
        public static UserServiceClient Create() => new UserServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UserServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UserServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="UserServiceClient"/>.</returns>
        internal static UserServiceClient Create(grpccore::CallInvoker callInvoker, UserServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserService.UserServiceClient grpcClient = new UserService.UserServiceClient(callInvoker);
            return new UserServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC UserService client</summary>
        public virtual UserService.UserServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a User object.
        /// 
        /// To get the current user, the resource name
        /// `networks/{networkCode}/users/me` can be used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User GetUser(GetUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a User object.
        /// 
        /// To get the current user, the resource name
        /// `networks/{networkCode}/users/me` can be used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(GetUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a User object.
        /// 
        /// To get the current user, the resource name
        /// `networks/{networkCode}/users/me` can be used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(GetUserRequest request, st::CancellationToken cancellationToken) =>
            GetUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a User object.
        /// 
        /// To get the current user, the resource name
        /// `networks/{networkCode}/users/me` can be used.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the User.
        /// Format: `networks/{network_code}/users/{user_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User GetUser(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUser(new GetUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a User object.
        /// 
        /// To get the current user, the resource name
        /// `networks/{networkCode}/users/me` can be used.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the User.
        /// Format: `networks/{network_code}/users/{user_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserAsync(new GetUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a User object.
        /// 
        /// To get the current user, the resource name
        /// `networks/{networkCode}/users/me` can be used.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the User.
        /// Format: `networks/{network_code}/users/{user_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(string name, st::CancellationToken cancellationToken) =>
            GetUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a User object.
        /// 
        /// To get the current user, the resource name
        /// `networks/{networkCode}/users/me` can be used.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the User.
        /// Format: `networks/{network_code}/users/{user_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User GetUser(UserName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUser(new GetUserRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a User object.
        /// 
        /// To get the current user, the resource name
        /// `networks/{networkCode}/users/me` can be used.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the User.
        /// Format: `networks/{network_code}/users/{user_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(UserName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserAsync(new GetUserRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a User object.
        /// 
        /// To get the current user, the resource name
        /// `networks/{networkCode}/users/me` can be used.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the User.
        /// Format: `networks/{network_code}/users/{user_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(UserName name, st::CancellationToken cancellationToken) =>
            GetUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>UserService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling User objects.
    /// </remarks>
    public sealed partial class UserServiceClientImpl : UserServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetUserRequest, User> _callGetUser;

        /// <summary>
        /// Constructs a client wrapper for the UserService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UserServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public UserServiceClientImpl(UserService.UserServiceClient grpcClient, UserServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            UserServiceSettings effectiveSettings = settings ?? UserServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetUser = clientHelper.BuildApiCall<GetUserRequest, User>("GetUser", grpcClient.GetUserAsync, grpcClient.GetUser, effectiveSettings.GetUserSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUser);
            Modify_GetUserApiCall(ref _callGetUser);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetUserApiCall(ref gaxgrpc::ApiCall<GetUserRequest, User> call);

        partial void OnConstruction(UserService.UserServiceClient grpcClient, UserServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserService client</summary>
        public override UserService.UserServiceClient GrpcClient { get; }

        partial void Modify_GetUserRequest(ref GetUserRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a User object.
        /// 
        /// To get the current user, the resource name
        /// `networks/{networkCode}/users/me` can be used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override User GetUser(GetUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserRequest(ref request, ref callSettings);
            return _callGetUser.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a User object.
        /// 
        /// To get the current user, the resource name
        /// `networks/{networkCode}/users/me` can be used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<User> GetUserAsync(GetUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserRequest(ref request, ref callSettings);
            return _callGetUser.Async(request, callSettings);
        }
    }
}
