// Copyright 2024 Google LLC
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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Shopping.Merchant.Accounts.V1Beta
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
            CreateUserSettings = existing.CreateUserSettings;
            DeleteUserSettings = existing.DeleteUserSettings;
            UpdateUserSettings = existing.UpdateUserSettings;
            ListUsersSettings = existing.ListUsersSettings;
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

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserServiceClient.CreateUser</c> and <c>UserServiceClient.CreateUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUserSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserServiceClient.DeleteUser</c> and <c>UserServiceClient.DeleteUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteUserSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserServiceClient.UpdateUser</c> and <c>UserServiceClient.UpdateUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUserSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>UserServiceClient.ListUsers</c>
        ///  and <c>UserServiceClient.ListUsersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUsersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
    /// Service to support user API.
    /// </remarks>
    public abstract partial class UserServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserService service, which is a host of "merchantapi.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default UserService scopes.</summary>
        /// <remarks>
        /// The default UserService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(UserService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

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
        /// Retrieves a Merchant Center account user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User GetUser(GetUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Merchant Center account user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(GetUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a Merchant Center account user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(GetUserRequest request, st::CancellationToken cancellationToken) =>
            GetUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Merchant Center account user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user to retrieve.
        /// Format: `accounts/{account}/users/{email}`
        /// 
        /// It is also possible to retrieve the user corresponding to the caller by
        /// using `me` rather than an email address as in
        /// `accounts/{account}/users/me`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User GetUser(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUser(new GetUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Merchant Center account user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user to retrieve.
        /// Format: `accounts/{account}/users/{email}`
        /// 
        /// It is also possible to retrieve the user corresponding to the caller by
        /// using `me` rather than an email address as in
        /// `accounts/{account}/users/me`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserAsync(new GetUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Merchant Center account user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user to retrieve.
        /// Format: `accounts/{account}/users/{email}`
        /// 
        /// It is also possible to retrieve the user corresponding to the caller by
        /// using `me` rather than an email address as in
        /// `accounts/{account}/users/me`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(string name, st::CancellationToken cancellationToken) =>
            GetUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a Merchant Center account user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user to retrieve.
        /// Format: `accounts/{account}/users/{email}`
        /// 
        /// It is also possible to retrieve the user corresponding to the caller by
        /// using `me` rather than an email address as in
        /// `accounts/{account}/users/me`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User GetUser(UserName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUser(new GetUserRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Merchant Center account user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user to retrieve.
        /// Format: `accounts/{account}/users/{email}`
        /// 
        /// It is also possible to retrieve the user corresponding to the caller by
        /// using `me` rather than an email address as in
        /// `accounts/{account}/users/me`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(UserName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserAsync(new GetUserRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a Merchant Center account user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user to retrieve.
        /// Format: `accounts/{account}/users/{email}`
        /// 
        /// It is also possible to retrieve the user corresponding to the caller by
        /// using `me` rather than an email address as in
        /// `accounts/{account}/users/me`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> GetUserAsync(UserName name, st::CancellationToken cancellationToken) =>
            GetUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User CreateUser(CreateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(CreateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(CreateUserRequest request, st::CancellationToken cancellationToken) =>
            CreateUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the account for which a user will be
        /// created. Format: `accounts/{account}`
        /// </param>
        /// <param name="user">
        /// Required. The user to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User CreateUser(string parent, User user, gaxgrpc::CallSettings callSettings = null) =>
            CreateUser(new CreateUserRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Creates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the account for which a user will be
        /// created. Format: `accounts/{account}`
        /// </param>
        /// <param name="user">
        /// Required. The user to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(string parent, User user, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserAsync(new CreateUserRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Creates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the account for which a user will be
        /// created. Format: `accounts/{account}`
        /// </param>
        /// <param name="user">
        /// Required. The user to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(string parent, User user, st::CancellationToken cancellationToken) =>
            CreateUserAsync(parent, user, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the account for which a user will be
        /// created. Format: `accounts/{account}`
        /// </param>
        /// <param name="user">
        /// Required. The user to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User CreateUser(AccountName parent, User user, gaxgrpc::CallSettings callSettings = null) =>
            CreateUser(new CreateUserRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Creates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the account for which a user will be
        /// created. Format: `accounts/{account}`
        /// </param>
        /// <param name="user">
        /// Required. The user to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(AccountName parent, User user, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserAsync(new CreateUserRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Creates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the account for which a user will be
        /// created. Format: `accounts/{account}`
        /// </param>
        /// <param name="user">
        /// Required. The user to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(AccountName parent, User user, st::CancellationToken cancellationToken) =>
            CreateUserAsync(parent, user, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUser(DeleteUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserAsync(DeleteUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserAsync(DeleteUserRequest request, st::CancellationToken cancellationToken) =>
            DeleteUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user to delete.
        /// Format: `accounts/{account}/users/{email}`
        /// 
        /// It is also possible to delete the user corresponding to the caller by using
        /// `me` rather than an email address as in `accounts/{account}/users/me`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUser(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUser(new DeleteUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user to delete.
        /// Format: `accounts/{account}/users/{email}`
        /// 
        /// It is also possible to delete the user corresponding to the caller by using
        /// `me` rather than an email address as in `accounts/{account}/users/me`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserAsync(new DeleteUserRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user to delete.
        /// Format: `accounts/{account}/users/{email}`
        /// 
        /// It is also possible to delete the user corresponding to the caller by using
        /// `me` rather than an email address as in `accounts/{account}/users/me`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user to delete.
        /// Format: `accounts/{account}/users/{email}`
        /// 
        /// It is also possible to delete the user corresponding to the caller by using
        /// `me` rather than an email address as in `accounts/{account}/users/me`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUser(UserName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUser(new DeleteUserRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user to delete.
        /// Format: `accounts/{account}/users/{email}`
        /// 
        /// It is also possible to delete the user corresponding to the caller by using
        /// `me` rather than an email address as in `accounts/{account}/users/me`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserAsync(UserName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserAsync(new DeleteUserRequest
            {
                UserName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user to delete.
        /// Format: `accounts/{account}/users/{email}`
        /// 
        /// It is also possible to delete the user corresponding to the caller by using
        /// `me` rather than an email address as in `accounts/{account}/users/me`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserAsync(UserName name, st::CancellationToken cancellationToken) =>
            DeleteUserAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User UpdateUser(UpdateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> UpdateUserAsync(UpdateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> UpdateUserAsync(UpdateUserRequest request, st::CancellationToken cancellationToken) =>
            UpdateUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="user">
        /// Required. The new version of the user.
        /// 
        /// Use `me` to refer to your own email address, for example
        /// `accounts/{account}/users/me`.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User UpdateUser(User user, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUser(new UpdateUserRequest
            {
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="user">
        /// Required. The new version of the user.
        /// 
        /// Use `me` to refer to your own email address, for example
        /// `accounts/{account}/users/me`.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> UpdateUserAsync(User user, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserAsync(new UpdateUserRequest
            {
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="user">
        /// Required. The new version of the user.
        /// 
        /// Use `me` to refer to your own email address, for example
        /// `accounts/{account}/users/me`.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> UpdateUserAsync(User user, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUserAsync(user, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all users of a Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsersResponse, User> ListUsers(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all users of a Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all users of a Merchant Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of users.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsersResponse, User> ListUsers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsersRequest request = new ListUsersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUsers(request, callSettings);
        }

        /// <summary>
        /// Lists all users of a Merchant Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of users.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsersRequest request = new ListUsersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUsersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all users of a Merchant Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of users.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsersResponse, User> ListUsers(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUsers(request, callSettings);
        }

        /// <summary>
        /// Lists all users of a Merchant Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of users.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUsersAsync(request, callSettings);
        }
    }

    /// <summary>UserService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to support user API.
    /// </remarks>
    public sealed partial class UserServiceClientImpl : UserServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetUserRequest, User> _callGetUser;

        private readonly gaxgrpc::ApiCall<CreateUserRequest, User> _callCreateUser;

        private readonly gaxgrpc::ApiCall<DeleteUserRequest, wkt::Empty> _callDeleteUser;

        private readonly gaxgrpc::ApiCall<UpdateUserRequest, User> _callUpdateUser;

        private readonly gaxgrpc::ApiCall<ListUsersRequest, ListUsersResponse> _callListUsers;

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
            _callCreateUser = clientHelper.BuildApiCall<CreateUserRequest, User>("CreateUser", grpcClient.CreateUserAsync, grpcClient.CreateUser, effectiveSettings.CreateUserSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUser);
            Modify_CreateUserApiCall(ref _callCreateUser);
            _callDeleteUser = clientHelper.BuildApiCall<DeleteUserRequest, wkt::Empty>("DeleteUser", grpcClient.DeleteUserAsync, grpcClient.DeleteUser, effectiveSettings.DeleteUserSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUser);
            Modify_DeleteUserApiCall(ref _callDeleteUser);
            _callUpdateUser = clientHelper.BuildApiCall<UpdateUserRequest, User>("UpdateUser", grpcClient.UpdateUserAsync, grpcClient.UpdateUser, effectiveSettings.UpdateUserSettings).WithGoogleRequestParam("user.name", request => request.User?.Name);
            Modify_ApiCall(ref _callUpdateUser);
            Modify_UpdateUserApiCall(ref _callUpdateUser);
            _callListUsers = clientHelper.BuildApiCall<ListUsersRequest, ListUsersResponse>("ListUsers", grpcClient.ListUsersAsync, grpcClient.ListUsers, effectiveSettings.ListUsersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUsers);
            Modify_ListUsersApiCall(ref _callListUsers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetUserApiCall(ref gaxgrpc::ApiCall<GetUserRequest, User> call);

        partial void Modify_CreateUserApiCall(ref gaxgrpc::ApiCall<CreateUserRequest, User> call);

        partial void Modify_DeleteUserApiCall(ref gaxgrpc::ApiCall<DeleteUserRequest, wkt::Empty> call);

        partial void Modify_UpdateUserApiCall(ref gaxgrpc::ApiCall<UpdateUserRequest, User> call);

        partial void Modify_ListUsersApiCall(ref gaxgrpc::ApiCall<ListUsersRequest, ListUsersResponse> call);

        partial void OnConstruction(UserService.UserServiceClient grpcClient, UserServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserService client</summary>
        public override UserService.UserServiceClient GrpcClient { get; }

        partial void Modify_GetUserRequest(ref GetUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUserRequest(ref CreateUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUserRequest(ref DeleteUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUserRequest(ref UpdateUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUsersRequest(ref ListUsersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a Merchant Center account user.
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
        /// Retrieves a Merchant Center account user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<User> GetUserAsync(GetUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserRequest(ref request, ref callSettings);
            return _callGetUser.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override User CreateUser(CreateUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserRequest(ref request, ref callSettings);
            return _callCreateUser.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<User> CreateUserAsync(CreateUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserRequest(ref request, ref callSettings);
            return _callCreateUser.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteUser(DeleteUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserRequest(ref request, ref callSettings);
            _callDeleteUser.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteUserAsync(DeleteUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserRequest(ref request, ref callSettings);
            return _callDeleteUser.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override User UpdateUser(UpdateUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserRequest(ref request, ref callSettings);
            return _callUpdateUser.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a Merchant Center account user. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<User> UpdateUserAsync(UpdateUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserRequest(ref request, ref callSettings);
            return _callUpdateUser.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all users of a Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="User"/> resources.</returns>
        public override gax::PagedEnumerable<ListUsersResponse, User> ListUsers(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUsersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUsersRequest, ListUsersResponse, User>(_callListUsers, request, callSettings);
        }

        /// <summary>
        /// Lists all users of a Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="User"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUsersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUsersRequest, ListUsersResponse, User>(_callListUsers, request, callSettings);
        }
    }

    public partial class ListUsersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUsersResponse : gaxgrpc::IPageResponse<User>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<User> GetEnumerator() => Users.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
