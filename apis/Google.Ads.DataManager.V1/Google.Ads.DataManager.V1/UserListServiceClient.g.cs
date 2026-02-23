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

namespace Google.Ads.DataManager.V1
{
    /// <summary>Settings for <see cref="UserListServiceClient"/> instances.</summary>
    public sealed partial class UserListServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UserListServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UserListServiceSettings"/>.</returns>
        public static UserListServiceSettings GetDefault() => new UserListServiceSettings();

        /// <summary>Constructs a new <see cref="UserListServiceSettings"/> object with default settings.</summary>
        public UserListServiceSettings()
        {
        }

        private UserListServiceSettings(UserListServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetUserListSettings = existing.GetUserListSettings;
            ListUserListsSettings = existing.ListUserListsSettings;
            CreateUserListSettings = existing.CreateUserListSettings;
            UpdateUserListSettings = existing.UpdateUserListSettings;
            DeleteUserListSettings = existing.DeleteUserListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UserListServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListServiceClient.GetUserList</c> and <c>UserListServiceClient.GetUserListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUserListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListServiceClient.ListUserLists</c> and <c>UserListServiceClient.ListUserListsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUserListsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListServiceClient.CreateUserList</c> and <c>UserListServiceClient.CreateUserListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUserListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListServiceClient.UpdateUserList</c> and <c>UserListServiceClient.UpdateUserListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUserListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListServiceClient.DeleteUserList</c> and <c>UserListServiceClient.DeleteUserListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteUserListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserListServiceSettings"/> object.</returns>
        public UserListServiceSettings Clone() => new UserListServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserListServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class UserListServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserListServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserListServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public UserListServiceClientBuilder() : base(UserListServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref UserListServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UserListServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UserListServiceClient Build()
        {
            UserListServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UserListServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UserListServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UserListServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UserListServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<UserListServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserListServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserListServiceClient.ChannelPool;
    }

    /// <summary>UserListService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing UserList resources.
    /// </remarks>
    public abstract partial class UserListServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserListService service, which is a host of "datamanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datamanager.googleapis.com:443";

        /// <summary>The default UserListService scopes.</summary>
        /// <remarks>
        /// The default UserListService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/datamanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/datamanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(UserListService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="UserListServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserListServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UserListServiceClient"/>.</returns>
        public static stt::Task<UserListServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UserListServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UserListServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserListServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UserListServiceClient"/>.</returns>
        public static UserListServiceClient Create() => new UserListServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UserListServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UserListServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="UserListServiceClient"/>.</returns>
        internal static UserListServiceClient Create(grpccore::CallInvoker callInvoker, UserListServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserListService.UserListServiceClient grpcClient = new UserListService.UserListServiceClient(callInvoker);
            return new UserListServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC UserListService client</summary>
        public virtual UserListService.UserListServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserList GetUserList(GetUserListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> GetUserListAsync(GetUserListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> GetUserListAsync(GetUserListRequest request, st::CancellationToken cancellationToken) =>
            GetUserListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the UserList to retrieve.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserList GetUserList(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserList(new GetUserListRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the UserList to retrieve.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> GetUserListAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserListAsync(new GetUserListRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the UserList to retrieve.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> GetUserListAsync(string name, st::CancellationToken cancellationToken) =>
            GetUserListAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the UserList to retrieve.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserList GetUserList(UserListName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserList(new GetUserListRequest
            {
                UserListName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the UserList to retrieve.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> GetUserListAsync(UserListName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserListAsync(new GetUserListRequest
            {
                UserListName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the UserList to retrieve.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> GetUserListAsync(UserListName name, st::CancellationToken cancellationToken) =>
            GetUserListAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists UserLists.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserList"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserListsResponse, UserList> ListUserLists(ListUserListsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists UserLists.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserList"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserListsResponse, UserList> ListUserListsAsync(ListUserListsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists UserLists.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account which owns this collection of user lists.
        /// Format: accountTypes/{account_type}/accounts/{account}
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
        /// <returns>A pageable sequence of <see cref="UserList"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserListsResponse, UserList> ListUserLists(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListsRequest request = new ListUserListsRequest
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
            return ListUserLists(request, callSettings);
        }

        /// <summary>
        /// Lists UserLists.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account which owns this collection of user lists.
        /// Format: accountTypes/{account_type}/accounts/{account}
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserList"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserListsResponse, UserList> ListUserListsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListsRequest request = new ListUserListsRequest
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
            return ListUserListsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists UserLists.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account which owns this collection of user lists.
        /// Format: accountTypes/{account_type}/accounts/{account}
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
        /// <returns>A pageable sequence of <see cref="UserList"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserListsResponse, UserList> ListUserLists(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListsRequest request = new ListUserListsRequest
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
            return ListUserLists(request, callSettings);
        }

        /// <summary>
        /// Lists UserLists.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account which owns this collection of user lists.
        /// Format: accountTypes/{account_type}/accounts/{account}
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserList"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserListsResponse, UserList> ListUserListsAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListsRequest request = new ListUserListsRequest
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
            return ListUserListsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserList CreateUserList(CreateUserListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> CreateUserListAsync(CreateUserListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> CreateUserListAsync(CreateUserListRequest request, st::CancellationToken cancellationToken) =>
            CreateUserListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account where this user list will be created.
        /// Format: accountTypes/{account_type}/accounts/{account}
        /// </param>
        /// <param name="userList">
        /// Required. The user list to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserList CreateUserList(string parent, UserList userList, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserList(new CreateUserListRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserList = gax::GaxPreconditions.CheckNotNull(userList, nameof(userList)),
            }, callSettings);

        /// <summary>
        /// Creates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account where this user list will be created.
        /// Format: accountTypes/{account_type}/accounts/{account}
        /// </param>
        /// <param name="userList">
        /// Required. The user list to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> CreateUserListAsync(string parent, UserList userList, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserListAsync(new CreateUserListRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserList = gax::GaxPreconditions.CheckNotNull(userList, nameof(userList)),
            }, callSettings);

        /// <summary>
        /// Creates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account where this user list will be created.
        /// Format: accountTypes/{account_type}/accounts/{account}
        /// </param>
        /// <param name="userList">
        /// Required. The user list to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> CreateUserListAsync(string parent, UserList userList, st::CancellationToken cancellationToken) =>
            CreateUserListAsync(parent, userList, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account where this user list will be created.
        /// Format: accountTypes/{account_type}/accounts/{account}
        /// </param>
        /// <param name="userList">
        /// Required. The user list to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserList CreateUserList(AccountName parent, UserList userList, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserList(new CreateUserListRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserList = gax::GaxPreconditions.CheckNotNull(userList, nameof(userList)),
            }, callSettings);

        /// <summary>
        /// Creates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account where this user list will be created.
        /// Format: accountTypes/{account_type}/accounts/{account}
        /// </param>
        /// <param name="userList">
        /// Required. The user list to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> CreateUserListAsync(AccountName parent, UserList userList, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserListAsync(new CreateUserListRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserList = gax::GaxPreconditions.CheckNotNull(userList, nameof(userList)),
            }, callSettings);

        /// <summary>
        /// Creates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account where this user list will be created.
        /// Format: accountTypes/{account_type}/accounts/{account}
        /// </param>
        /// <param name="userList">
        /// Required. The user list to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> CreateUserListAsync(AccountName parent, UserList userList, st::CancellationToken cancellationToken) =>
            CreateUserListAsync(parent, userList, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserList UpdateUserList(UpdateUserListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> UpdateUserListAsync(UpdateUserListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> UpdateUserListAsync(UpdateUserListRequest request, st::CancellationToken cancellationToken) =>
            UpdateUserListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="userList">
        /// Required. The user list to update.
        /// 
        /// The user list's `name` field is used to identify the user list to update.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserList UpdateUserList(UserList userList, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserList(new UpdateUserListRequest
            {
                UserList = gax::GaxPreconditions.CheckNotNull(userList, nameof(userList)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="userList">
        /// Required. The user list to update.
        /// 
        /// The user list's `name` field is used to identify the user list to update.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> UpdateUserListAsync(UserList userList, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserListAsync(new UpdateUserListRequest
            {
                UserList = gax::GaxPreconditions.CheckNotNull(userList, nameof(userList)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="userList">
        /// Required. The user list to update.
        /// 
        /// The user list's `name` field is used to identify the user list to update.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserList> UpdateUserListAsync(UserList userList, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUserListAsync(userList, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserList(DeleteUserListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserListAsync(DeleteUserListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserListAsync(DeleteUserListRequest request, st::CancellationToken cancellationToken) =>
            DeleteUserListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user list to delete.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserList(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserList(new DeleteUserListRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user list to delete.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserListAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserListAsync(new DeleteUserListRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user list to delete.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserListAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUserListAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user list to delete.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUserList(UserListName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserList(new DeleteUserListRequest
            {
                UserListName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user list to delete.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserListAsync(UserListName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUserListAsync(new DeleteUserListRequest
            {
                UserListName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The name of the user list to delete.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/userLists/{user_list}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUserListAsync(UserListName name, st::CancellationToken cancellationToken) =>
            DeleteUserListAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>UserListService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing UserList resources.
    /// </remarks>
    public sealed partial class UserListServiceClientImpl : UserListServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetUserListRequest, UserList> _callGetUserList;

        private readonly gaxgrpc::ApiCall<ListUserListsRequest, ListUserListsResponse> _callListUserLists;

        private readonly gaxgrpc::ApiCall<CreateUserListRequest, UserList> _callCreateUserList;

        private readonly gaxgrpc::ApiCall<UpdateUserListRequest, UserList> _callUpdateUserList;

        private readonly gaxgrpc::ApiCall<DeleteUserListRequest, wkt::Empty> _callDeleteUserList;

        /// <summary>
        /// Constructs a client wrapper for the UserListService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UserListServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public UserListServiceClientImpl(UserListService.UserListServiceClient grpcClient, UserListServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            UserListServiceSettings effectiveSettings = settings ?? UserListServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetUserList = clientHelper.BuildApiCall<GetUserListRequest, UserList>("GetUserList", grpcClient.GetUserListAsync, grpcClient.GetUserList, effectiveSettings.GetUserListSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUserList);
            Modify_GetUserListApiCall(ref _callGetUserList);
            _callListUserLists = clientHelper.BuildApiCall<ListUserListsRequest, ListUserListsResponse>("ListUserLists", grpcClient.ListUserListsAsync, grpcClient.ListUserLists, effectiveSettings.ListUserListsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUserLists);
            Modify_ListUserListsApiCall(ref _callListUserLists);
            _callCreateUserList = clientHelper.BuildApiCall<CreateUserListRequest, UserList>("CreateUserList", grpcClient.CreateUserListAsync, grpcClient.CreateUserList, effectiveSettings.CreateUserListSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUserList);
            Modify_CreateUserListApiCall(ref _callCreateUserList);
            _callUpdateUserList = clientHelper.BuildApiCall<UpdateUserListRequest, UserList>("UpdateUserList", grpcClient.UpdateUserListAsync, grpcClient.UpdateUserList, effectiveSettings.UpdateUserListSettings).WithGoogleRequestParam("user_list.name", request => request.UserList?.Name);
            Modify_ApiCall(ref _callUpdateUserList);
            Modify_UpdateUserListApiCall(ref _callUpdateUserList);
            _callDeleteUserList = clientHelper.BuildApiCall<DeleteUserListRequest, wkt::Empty>("DeleteUserList", grpcClient.DeleteUserListAsync, grpcClient.DeleteUserList, effectiveSettings.DeleteUserListSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUserList);
            Modify_DeleteUserListApiCall(ref _callDeleteUserList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetUserListApiCall(ref gaxgrpc::ApiCall<GetUserListRequest, UserList> call);

        partial void Modify_ListUserListsApiCall(ref gaxgrpc::ApiCall<ListUserListsRequest, ListUserListsResponse> call);

        partial void Modify_CreateUserListApiCall(ref gaxgrpc::ApiCall<CreateUserListRequest, UserList> call);

        partial void Modify_UpdateUserListApiCall(ref gaxgrpc::ApiCall<UpdateUserListRequest, UserList> call);

        partial void Modify_DeleteUserListApiCall(ref gaxgrpc::ApiCall<DeleteUserListRequest, wkt::Empty> call);

        partial void OnConstruction(UserListService.UserListServiceClient grpcClient, UserListServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserListService client</summary>
        public override UserListService.UserListServiceClient GrpcClient { get; }

        partial void Modify_GetUserListRequest(ref GetUserListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUserListsRequest(ref ListUserListsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUserListRequest(ref CreateUserListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUserListRequest(ref UpdateUserListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUserListRequest(ref DeleteUserListRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserList GetUserList(GetUserListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserListRequest(ref request, ref callSettings);
            return _callGetUserList.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserList> GetUserListAsync(GetUserListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserListRequest(ref request, ref callSettings);
            return _callGetUserList.Async(request, callSettings);
        }

        /// <summary>
        /// Lists UserLists.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserList"/> resources.</returns>
        public override gax::PagedEnumerable<ListUserListsResponse, UserList> ListUserLists(ListUserListsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserListsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUserListsRequest, ListUserListsResponse, UserList>(_callListUserLists, request, callSettings);
        }

        /// <summary>
        /// Lists UserLists.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserList"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUserListsResponse, UserList> ListUserListsAsync(ListUserListsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserListsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUserListsRequest, ListUserListsResponse, UserList>(_callListUserLists, request, callSettings);
        }

        /// <summary>
        /// Creates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserList CreateUserList(CreateUserListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserListRequest(ref request, ref callSettings);
            return _callCreateUserList.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserList> CreateUserListAsync(CreateUserListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserListRequest(ref request, ref callSettings);
            return _callCreateUserList.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserList UpdateUserList(UpdateUserListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserListRequest(ref request, ref callSettings);
            return _callUpdateUserList.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserList> UpdateUserListAsync(UpdateUserListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserListRequest(ref request, ref callSettings);
            return _callUpdateUserList.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteUserList(DeleteUserListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserListRequest(ref request, ref callSettings);
            _callDeleteUserList.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a UserList.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteUserListAsync(DeleteUserListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUserListRequest(ref request, ref callSettings);
            return _callDeleteUserList.Async(request, callSettings);
        }
    }

    public partial class ListUserListsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUserListsResponse : gaxgrpc::IPageResponse<UserList>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UserList> GetEnumerator() => UserLists.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
