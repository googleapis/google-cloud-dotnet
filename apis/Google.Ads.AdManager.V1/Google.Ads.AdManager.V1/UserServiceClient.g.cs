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
            ListUsersSettings = existing.ListUsersSettings;
            CreateUserSettings = existing.CreateUserSettings;
            BatchCreateUsersSettings = existing.BatchCreateUsersSettings;
            BatchActivateUsersSettings = existing.BatchActivateUsersSettings;
            BatchDeactivateUsersSettings = existing.BatchDeactivateUsersSettings;
            UpdateUserSettings = existing.UpdateUserSettings;
            BatchUpdateUsersSettings = existing.BatchUpdateUsersSettings;
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
        /// <c>UserServiceClient.BatchCreateUsers</c> and <c>UserServiceClient.BatchCreateUsersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateUsersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserServiceClient.BatchActivateUsers</c> and <c>UserServiceClient.BatchActivateUsersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateUsersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserServiceClient.BatchDeactivateUsers</c> and <c>UserServiceClient.BatchDeactivateUsersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateUsersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserServiceClient.BatchUpdateUsers</c> and <c>UserServiceClient.BatchUpdateUsersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateUsersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
        /// <item><description>https://www.googleapis.com/auth/admanager.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
            "https://www.googleapis.com/auth/admanager.readonly",
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
        /// Retrieves a `User` object.
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
        /// Retrieves a `User` object.
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
        /// Retrieves a `User` object.
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
        /// Retrieves a `User` object.
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
        /// Retrieves a `User` object.
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
        /// Retrieves a `User` object.
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
        /// Retrieves a `User` object.
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
        /// Retrieves a `User` object.
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
        /// Retrieves a `User` object.
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

        /// <summary>
        /// Lists `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUsersResponse, User> ListUsers(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="User"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Users.
        /// Format: `networks/{network_code}`
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
        /// Lists `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Users.
        /// Format: `networks/{network_code}`
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
        /// Lists `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Users.
        /// Format: `networks/{network_code}`
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
        public virtual gax::PagedEnumerable<ListUsersResponse, User> ListUsers(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Users.
        /// Format: `networks/{network_code}`
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
        public virtual gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Creates a `User` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User CreateUser(CreateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `User` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(CreateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `User` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(CreateUserRequest request, st::CancellationToken cancellationToken) =>
            CreateUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `User` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `User` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="user">
        /// Required. The `User` to create.
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
        /// Creates a `User` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `User` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="user">
        /// Required. The `User` to create.
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
        /// Creates a `User` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `User` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="user">
        /// Required. The `User` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(string parent, User user, st::CancellationToken cancellationToken) =>
            CreateUserAsync(parent, user, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `User` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `User` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="user">
        /// Required. The `User` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User CreateUser(NetworkName parent, User user, gaxgrpc::CallSettings callSettings = null) =>
            CreateUser(new CreateUserRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Creates a `User` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `User` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="user">
        /// Required. The `User` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(NetworkName parent, User user, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserAsync(new CreateUserRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
            }, callSettings);

        /// <summary>
        /// Creates a `User` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `User` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="user">
        /// Required. The `User` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> CreateUserAsync(NetworkName parent, User user, st::CancellationToken cancellationToken) =>
            CreateUserAsync(parent, user, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateUsersResponse BatchCreateUsers(BatchCreateUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateUsersResponse> BatchCreateUsersAsync(BatchCreateUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateUsersResponse> BatchCreateUsersAsync(BatchCreateUsersRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateUsersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Users` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateUserRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `User` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateUsersResponse BatchCreateUsers(string parent, scg::IEnumerable<CreateUserRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateUsers(new BatchCreateUsersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Users` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateUserRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `User` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateUsersResponse> BatchCreateUsersAsync(string parent, scg::IEnumerable<CreateUserRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateUsersAsync(new BatchCreateUsersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Users` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateUserRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `User` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateUsersResponse> BatchCreateUsersAsync(string parent, scg::IEnumerable<CreateUserRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateUsersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Users` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateUserRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `User` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateUsersResponse BatchCreateUsers(NetworkName parent, scg::IEnumerable<CreateUserRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateUsers(new BatchCreateUsersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Users` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateUserRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `User` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateUsersResponse> BatchCreateUsersAsync(NetworkName parent, scg::IEnumerable<CreateUserRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateUsersAsync(new BatchCreateUsersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Users` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateUserRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `User` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateUsersResponse> BatchCreateUsersAsync(NetworkName parent, scg::IEnumerable<CreateUserRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateUsersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateUsersResponse BatchActivateUsers(BatchActivateUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a list of `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateUsersResponse> BatchActivateUsersAsync(BatchActivateUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a list of `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateUsersResponse> BatchActivateUsersAsync(BatchActivateUsersRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateUsersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `User` objects to activate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateUsersResponse BatchActivateUsers(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateUsers(new BatchActivateUsersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `User` objects to activate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateUsersResponse> BatchActivateUsersAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateUsersAsync(new BatchActivateUsersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `User` objects to activate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateUsersResponse> BatchActivateUsersAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateUsersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `User` objects to activate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateUsersResponse BatchActivateUsers(NetworkName parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateUsers(new BatchActivateUsersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `User` objects to activate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateUsersResponse> BatchActivateUsersAsync(NetworkName parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateUsersAsync(new BatchActivateUsersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `User` objects to activate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateUsersResponse> BatchActivateUsersAsync(NetworkName parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateUsersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateUsersResponse BatchDeactivateUsers(BatchDeactivateUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateUsersResponse> BatchDeactivateUsersAsync(BatchDeactivateUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateUsersResponse> BatchDeactivateUsersAsync(BatchDeactivateUsersRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateUsersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `User` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateUsersResponse BatchDeactivateUsers(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateUsers(new BatchDeactivateUsersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `User` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateUsersResponse> BatchDeactivateUsersAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateUsersAsync(new BatchDeactivateUsersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `User` objects to deactivate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateUsersResponse> BatchDeactivateUsersAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateUsersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `User` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateUsersResponse BatchDeactivateUsers(NetworkName parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateUsers(new BatchDeactivateUsersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `User` objects to deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateUsersResponse> BatchDeactivateUsersAsync(NetworkName parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateUsersAsync(new BatchDeactivateUsersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `User` objects to deactivate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateUsersResponse> BatchDeactivateUsersAsync(NetworkName parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateUsersAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `User` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User UpdateUser(UpdateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `User` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> UpdateUserAsync(UpdateUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `User` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> UpdateUserAsync(UpdateUserRequest request, st::CancellationToken cancellationToken) =>
            UpdateUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `User` object.
        /// </summary>
        /// <param name="user">
        /// Required. The `User` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual User UpdateUser(User user, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUser(new UpdateUserRequest
            {
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `User` object.
        /// </summary>
        /// <param name="user">
        /// Required. The `User` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> UpdateUserAsync(User user, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserAsync(new UpdateUserRequest
            {
                User = gax::GaxPreconditions.CheckNotNull(user, nameof(user)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `User` object.
        /// </summary>
        /// <param name="user">
        /// Required. The `User` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<User> UpdateUserAsync(User user, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUserAsync(user, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateUsersResponse BatchUpdateUsers(BatchUpdateUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateUsersResponse> BatchUpdateUsersAsync(BatchUpdateUsersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateUsersResponse> BatchUpdateUsersAsync(BatchUpdateUsersRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateUsersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Users` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateUserRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `User` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateUsersResponse BatchUpdateUsers(string parent, scg::IEnumerable<UpdateUserRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateUsers(new BatchUpdateUsersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Users` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateUserRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `User` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateUsersResponse> BatchUpdateUsersAsync(string parent, scg::IEnumerable<UpdateUserRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateUsersAsync(new BatchUpdateUsersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Users` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateUserRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `User` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateUsersResponse> BatchUpdateUsersAsync(string parent, scg::IEnumerable<UpdateUserRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateUsersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Users` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateUserRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `User` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateUsersResponse BatchUpdateUsers(NetworkName parent, scg::IEnumerable<UpdateUserRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateUsers(new BatchUpdateUsersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Users` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateUserRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `User` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateUsersResponse> BatchUpdateUsersAsync(NetworkName parent, scg::IEnumerable<UpdateUserRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateUsersAsync(new BatchUpdateUsersRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `User` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Users` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateUserRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `User` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateUsersResponse> BatchUpdateUsersAsync(NetworkName parent, scg::IEnumerable<UpdateUserRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateUsersAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>UserService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling User objects.
    /// </remarks>
    public sealed partial class UserServiceClientImpl : UserServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetUserRequest, User> _callGetUser;

        private readonly gaxgrpc::ApiCall<ListUsersRequest, ListUsersResponse> _callListUsers;

        private readonly gaxgrpc::ApiCall<CreateUserRequest, User> _callCreateUser;

        private readonly gaxgrpc::ApiCall<BatchCreateUsersRequest, BatchCreateUsersResponse> _callBatchCreateUsers;

        private readonly gaxgrpc::ApiCall<BatchActivateUsersRequest, BatchActivateUsersResponse> _callBatchActivateUsers;

        private readonly gaxgrpc::ApiCall<BatchDeactivateUsersRequest, BatchDeactivateUsersResponse> _callBatchDeactivateUsers;

        private readonly gaxgrpc::ApiCall<UpdateUserRequest, User> _callUpdateUser;

        private readonly gaxgrpc::ApiCall<BatchUpdateUsersRequest, BatchUpdateUsersResponse> _callBatchUpdateUsers;

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
            _callListUsers = clientHelper.BuildApiCall<ListUsersRequest, ListUsersResponse>("ListUsers", grpcClient.ListUsersAsync, grpcClient.ListUsers, effectiveSettings.ListUsersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUsers);
            Modify_ListUsersApiCall(ref _callListUsers);
            _callCreateUser = clientHelper.BuildApiCall<CreateUserRequest, User>("CreateUser", grpcClient.CreateUserAsync, grpcClient.CreateUser, effectiveSettings.CreateUserSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUser);
            Modify_CreateUserApiCall(ref _callCreateUser);
            _callBatchCreateUsers = clientHelper.BuildApiCall<BatchCreateUsersRequest, BatchCreateUsersResponse>("BatchCreateUsers", grpcClient.BatchCreateUsersAsync, grpcClient.BatchCreateUsers, effectiveSettings.BatchCreateUsersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateUsers);
            Modify_BatchCreateUsersApiCall(ref _callBatchCreateUsers);
            _callBatchActivateUsers = clientHelper.BuildApiCall<BatchActivateUsersRequest, BatchActivateUsersResponse>("BatchActivateUsers", grpcClient.BatchActivateUsersAsync, grpcClient.BatchActivateUsers, effectiveSettings.BatchActivateUsersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateUsers);
            Modify_BatchActivateUsersApiCall(ref _callBatchActivateUsers);
            _callBatchDeactivateUsers = clientHelper.BuildApiCall<BatchDeactivateUsersRequest, BatchDeactivateUsersResponse>("BatchDeactivateUsers", grpcClient.BatchDeactivateUsersAsync, grpcClient.BatchDeactivateUsers, effectiveSettings.BatchDeactivateUsersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateUsers);
            Modify_BatchDeactivateUsersApiCall(ref _callBatchDeactivateUsers);
            _callUpdateUser = clientHelper.BuildApiCall<UpdateUserRequest, User>("UpdateUser", grpcClient.UpdateUserAsync, grpcClient.UpdateUser, effectiveSettings.UpdateUserSettings).WithGoogleRequestParam("user.name", request => request.User?.Name);
            Modify_ApiCall(ref _callUpdateUser);
            Modify_UpdateUserApiCall(ref _callUpdateUser);
            _callBatchUpdateUsers = clientHelper.BuildApiCall<BatchUpdateUsersRequest, BatchUpdateUsersResponse>("BatchUpdateUsers", grpcClient.BatchUpdateUsersAsync, grpcClient.BatchUpdateUsers, effectiveSettings.BatchUpdateUsersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateUsers);
            Modify_BatchUpdateUsersApiCall(ref _callBatchUpdateUsers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetUserApiCall(ref gaxgrpc::ApiCall<GetUserRequest, User> call);

        partial void Modify_ListUsersApiCall(ref gaxgrpc::ApiCall<ListUsersRequest, ListUsersResponse> call);

        partial void Modify_CreateUserApiCall(ref gaxgrpc::ApiCall<CreateUserRequest, User> call);

        partial void Modify_BatchCreateUsersApiCall(ref gaxgrpc::ApiCall<BatchCreateUsersRequest, BatchCreateUsersResponse> call);

        partial void Modify_BatchActivateUsersApiCall(ref gaxgrpc::ApiCall<BatchActivateUsersRequest, BatchActivateUsersResponse> call);

        partial void Modify_BatchDeactivateUsersApiCall(ref gaxgrpc::ApiCall<BatchDeactivateUsersRequest, BatchDeactivateUsersResponse> call);

        partial void Modify_UpdateUserApiCall(ref gaxgrpc::ApiCall<UpdateUserRequest, User> call);

        partial void Modify_BatchUpdateUsersApiCall(ref gaxgrpc::ApiCall<BatchUpdateUsersRequest, BatchUpdateUsersResponse> call);

        partial void OnConstruction(UserService.UserServiceClient grpcClient, UserServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserService client</summary>
        public override UserService.UserServiceClient GrpcClient { get; }

        partial void Modify_GetUserRequest(ref GetUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUsersRequest(ref ListUsersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUserRequest(ref CreateUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateUsersRequest(ref BatchCreateUsersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateUsersRequest(ref BatchActivateUsersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateUsersRequest(ref BatchDeactivateUsersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUserRequest(ref UpdateUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateUsersRequest(ref BatchUpdateUsersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `User` object.
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
        /// Retrieves a `User` object.
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

        /// <summary>
        /// Lists `User` objects.
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
        /// Lists `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="User"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUsersResponse, User> ListUsersAsync(ListUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUsersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUsersRequest, ListUsersResponse, User>(_callListUsers, request, callSettings);
        }

        /// <summary>
        /// Creates a `User` object.
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
        /// Creates a `User` object.
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
        /// Creates `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateUsersResponse BatchCreateUsers(BatchCreateUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateUsersRequest(ref request, ref callSettings);
            return _callBatchCreateUsers.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateUsersResponse> BatchCreateUsersAsync(BatchCreateUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateUsersRequest(ref request, ref callSettings);
            return _callBatchCreateUsers.Async(request, callSettings);
        }

        /// <summary>
        /// Activates a list of `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateUsersResponse BatchActivateUsers(BatchActivateUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateUsersRequest(ref request, ref callSettings);
            return _callBatchActivateUsers.Sync(request, callSettings);
        }

        /// <summary>
        /// Activates a list of `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateUsersResponse> BatchActivateUsersAsync(BatchActivateUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateUsersRequest(ref request, ref callSettings);
            return _callBatchActivateUsers.Async(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateUsersResponse BatchDeactivateUsers(BatchDeactivateUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateUsersRequest(ref request, ref callSettings);
            return _callBatchDeactivateUsers.Sync(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateUsersResponse> BatchDeactivateUsersAsync(BatchDeactivateUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateUsersRequest(ref request, ref callSettings);
            return _callBatchDeactivateUsers.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `User` object.
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
        /// Updates a `User` object.
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
        /// Batch updates `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateUsersResponse BatchUpdateUsers(BatchUpdateUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateUsersRequest(ref request, ref callSettings);
            return _callBatchUpdateUsers.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `User` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateUsersResponse> BatchUpdateUsersAsync(BatchUpdateUsersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateUsersRequest(ref request, ref callSettings);
            return _callBatchUpdateUsers.Async(request, callSettings);
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
