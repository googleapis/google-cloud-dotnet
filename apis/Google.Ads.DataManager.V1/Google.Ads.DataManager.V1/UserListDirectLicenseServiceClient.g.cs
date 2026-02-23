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
    /// <summary>Settings for <see cref="UserListDirectLicenseServiceClient"/> instances.</summary>
    public sealed partial class UserListDirectLicenseServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UserListDirectLicenseServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UserListDirectLicenseServiceSettings"/>.</returns>
        public static UserListDirectLicenseServiceSettings GetDefault() => new UserListDirectLicenseServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="UserListDirectLicenseServiceSettings"/> object with default settings.
        /// </summary>
        public UserListDirectLicenseServiceSettings()
        {
        }

        private UserListDirectLicenseServiceSettings(UserListDirectLicenseServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateUserListDirectLicenseSettings = existing.CreateUserListDirectLicenseSettings;
            GetUserListDirectLicenseSettings = existing.GetUserListDirectLicenseSettings;
            UpdateUserListDirectLicenseSettings = existing.UpdateUserListDirectLicenseSettings;
            ListUserListDirectLicensesSettings = existing.ListUserListDirectLicensesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UserListDirectLicenseServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListDirectLicenseServiceClient.CreateUserListDirectLicense</c> and
        /// <c>UserListDirectLicenseServiceClient.CreateUserListDirectLicenseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUserListDirectLicenseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListDirectLicenseServiceClient.GetUserListDirectLicense</c> and
        /// <c>UserListDirectLicenseServiceClient.GetUserListDirectLicenseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUserListDirectLicenseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListDirectLicenseServiceClient.UpdateUserListDirectLicense</c> and
        /// <c>UserListDirectLicenseServiceClient.UpdateUserListDirectLicenseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUserListDirectLicenseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListDirectLicenseServiceClient.ListUserListDirectLicenses</c> and
        /// <c>UserListDirectLicenseServiceClient.ListUserListDirectLicensesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUserListDirectLicensesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserListDirectLicenseServiceSettings"/> object.</returns>
        public UserListDirectLicenseServiceSettings Clone() => new UserListDirectLicenseServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserListDirectLicenseServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class UserListDirectLicenseServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserListDirectLicenseServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserListDirectLicenseServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public UserListDirectLicenseServiceClientBuilder() : base(UserListDirectLicenseServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref UserListDirectLicenseServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UserListDirectLicenseServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UserListDirectLicenseServiceClient Build()
        {
            UserListDirectLicenseServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UserListDirectLicenseServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UserListDirectLicenseServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UserListDirectLicenseServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UserListDirectLicenseServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<UserListDirectLicenseServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserListDirectLicenseServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserListDirectLicenseServiceClient.ChannelPool;
    }

    /// <summary>UserListDirectLicenseService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing user list direct licenses. Delete is not a supported
    /// operation for UserListDirectLicenses.  Callers should update the
    /// license status to DISABLED to instead to deactivate a license.
    /// 
    /// This feature is only available to data partners.
    /// </remarks>
    public abstract partial class UserListDirectLicenseServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserListDirectLicenseService service, which is a host of
        /// "datamanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datamanager.googleapis.com:443";

        /// <summary>The default UserListDirectLicenseService scopes.</summary>
        /// <remarks>
        /// The default UserListDirectLicenseService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/datamanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/datamanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(UserListDirectLicenseService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="UserListDirectLicenseServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="UserListDirectLicenseServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UserListDirectLicenseServiceClient"/>.</returns>
        public static stt::Task<UserListDirectLicenseServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UserListDirectLicenseServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UserListDirectLicenseServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="UserListDirectLicenseServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UserListDirectLicenseServiceClient"/>.</returns>
        public static UserListDirectLicenseServiceClient Create() => new UserListDirectLicenseServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UserListDirectLicenseServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UserListDirectLicenseServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="UserListDirectLicenseServiceClient"/>.</returns>
        internal static UserListDirectLicenseServiceClient Create(grpccore::CallInvoker callInvoker, UserListDirectLicenseServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserListDirectLicenseService.UserListDirectLicenseServiceClient grpcClient = new UserListDirectLicenseService.UserListDirectLicenseServiceClient(callInvoker);
            return new UserListDirectLicenseServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC UserListDirectLicenseService client</summary>
        public virtual UserListDirectLicenseService.UserListDirectLicenseServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListDirectLicense CreateUserListDirectLicense(CreateUserListDirectLicenseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> CreateUserListDirectLicenseAsync(CreateUserListDirectLicenseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> CreateUserListDirectLicenseAsync(CreateUserListDirectLicenseRequest request, st::CancellationToken cancellationToken) =>
            CreateUserListDirectLicenseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account that owns the user list being licensed. Should be in
        /// the format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
        /// </param>
        /// <param name="userListDirectLicense">
        /// Required. The user list direct license to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListDirectLicense CreateUserListDirectLicense(string parent, UserListDirectLicense userListDirectLicense, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserListDirectLicense(new CreateUserListDirectLicenseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserListDirectLicense = gax::GaxPreconditions.CheckNotNull(userListDirectLicense, nameof(userListDirectLicense)),
            }, callSettings);

        /// <summary>
        /// Creates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account that owns the user list being licensed. Should be in
        /// the format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
        /// </param>
        /// <param name="userListDirectLicense">
        /// Required. The user list direct license to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> CreateUserListDirectLicenseAsync(string parent, UserListDirectLicense userListDirectLicense, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserListDirectLicenseAsync(new CreateUserListDirectLicenseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserListDirectLicense = gax::GaxPreconditions.CheckNotNull(userListDirectLicense, nameof(userListDirectLicense)),
            }, callSettings);

        /// <summary>
        /// Creates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account that owns the user list being licensed. Should be in
        /// the format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
        /// </param>
        /// <param name="userListDirectLicense">
        /// Required. The user list direct license to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> CreateUserListDirectLicenseAsync(string parent, UserListDirectLicense userListDirectLicense, st::CancellationToken cancellationToken) =>
            CreateUserListDirectLicenseAsync(parent, userListDirectLicense, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account that owns the user list being licensed. Should be in
        /// the format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
        /// </param>
        /// <param name="userListDirectLicense">
        /// Required. The user list direct license to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListDirectLicense CreateUserListDirectLicense(AccountName parent, UserListDirectLicense userListDirectLicense, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserListDirectLicense(new CreateUserListDirectLicenseRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserListDirectLicense = gax::GaxPreconditions.CheckNotNull(userListDirectLicense, nameof(userListDirectLicense)),
            }, callSettings);

        /// <summary>
        /// Creates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account that owns the user list being licensed. Should be in
        /// the format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
        /// </param>
        /// <param name="userListDirectLicense">
        /// Required. The user list direct license to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> CreateUserListDirectLicenseAsync(AccountName parent, UserListDirectLicense userListDirectLicense, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserListDirectLicenseAsync(new CreateUserListDirectLicenseRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserListDirectLicense = gax::GaxPreconditions.CheckNotNull(userListDirectLicense, nameof(userListDirectLicense)),
            }, callSettings);

        /// <summary>
        /// Creates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account that owns the user list being licensed. Should be in
        /// the format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
        /// </param>
        /// <param name="userListDirectLicense">
        /// Required. The user list direct license to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> CreateUserListDirectLicenseAsync(AccountName parent, UserListDirectLicense userListDirectLicense, st::CancellationToken cancellationToken) =>
            CreateUserListDirectLicenseAsync(parent, userListDirectLicense, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListDirectLicense GetUserListDirectLicense(GetUserListDirectLicenseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> GetUserListDirectLicenseAsync(GetUserListDirectLicenseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> GetUserListDirectLicenseAsync(GetUserListDirectLicenseRequest request, st::CancellationToken cancellationToken) =>
            GetUserListDirectLicenseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the user list direct license.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListDirectLicense GetUserListDirectLicense(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserListDirectLicense(new GetUserListDirectLicenseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the user list direct license.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> GetUserListDirectLicenseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserListDirectLicenseAsync(new GetUserListDirectLicenseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the user list direct license.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> GetUserListDirectLicenseAsync(string name, st::CancellationToken cancellationToken) =>
            GetUserListDirectLicenseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the user list direct license.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListDirectLicense GetUserListDirectLicense(UserListDirectLicenseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserListDirectLicense(new GetUserListDirectLicenseRequest
            {
                UserListDirectLicenseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the user list direct license.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> GetUserListDirectLicenseAsync(UserListDirectLicenseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserListDirectLicenseAsync(new GetUserListDirectLicenseRequest
            {
                UserListDirectLicenseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the user list direct license.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> GetUserListDirectLicenseAsync(UserListDirectLicenseName name, st::CancellationToken cancellationToken) =>
            GetUserListDirectLicenseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListDirectLicense UpdateUserListDirectLicense(UpdateUserListDirectLicenseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> UpdateUserListDirectLicenseAsync(UpdateUserListDirectLicenseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> UpdateUserListDirectLicenseAsync(UpdateUserListDirectLicenseRequest request, st::CancellationToken cancellationToken) =>
            UpdateUserListDirectLicenseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="userListDirectLicense">
        /// Required. The licenses' `name` field is used to identify the license to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. The special character `*` is not
        /// supported and an `INVALID_UPDATE_MASK` error will be thrown if used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListDirectLicense UpdateUserListDirectLicense(UserListDirectLicense userListDirectLicense, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserListDirectLicense(new UpdateUserListDirectLicenseRequest
            {
                UserListDirectLicense = gax::GaxPreconditions.CheckNotNull(userListDirectLicense, nameof(userListDirectLicense)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="userListDirectLicense">
        /// Required. The licenses' `name` field is used to identify the license to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. The special character `*` is not
        /// supported and an `INVALID_UPDATE_MASK` error will be thrown if used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> UpdateUserListDirectLicenseAsync(UserListDirectLicense userListDirectLicense, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserListDirectLicenseAsync(new UpdateUserListDirectLicenseRequest
            {
                UserListDirectLicense = gax::GaxPreconditions.CheckNotNull(userListDirectLicense, nameof(userListDirectLicense)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="userListDirectLicense">
        /// Required. The licenses' `name` field is used to identify the license to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. The special character `*` is not
        /// supported and an `INVALID_UPDATE_MASK` error will be thrown if used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListDirectLicense> UpdateUserListDirectLicenseAsync(UserListDirectLicense userListDirectLicense, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUserListDirectLicenseAsync(userListDirectLicense, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all user list direct licenses owned by the parent account.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserListDirectLicense"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserListDirectLicensesResponse, UserListDirectLicense> ListUserListDirectLicenses(ListUserListDirectLicensesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all user list direct licenses owned by the parent account.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserListDirectLicense"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserListDirectLicensesResponse, UserListDirectLicense> ListUserListDirectLicensesAsync(ListUserListDirectLicensesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all user list direct licenses owned by the parent account.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account whose licenses are being queried. Should be in the
        /// format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
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
        /// <returns>A pageable sequence of <see cref="UserListDirectLicense"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserListDirectLicensesResponse, UserListDirectLicense> ListUserListDirectLicenses(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListDirectLicensesRequest request = new ListUserListDirectLicensesRequest
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
            return ListUserListDirectLicenses(request, callSettings);
        }

        /// <summary>
        /// Lists all user list direct licenses owned by the parent account.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account whose licenses are being queried. Should be in the
        /// format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserListDirectLicense"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserListDirectLicensesResponse, UserListDirectLicense> ListUserListDirectLicensesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListDirectLicensesRequest request = new ListUserListDirectLicensesRequest
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
            return ListUserListDirectLicensesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all user list direct licenses owned by the parent account.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account whose licenses are being queried. Should be in the
        /// format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
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
        /// <returns>A pageable sequence of <see cref="UserListDirectLicense"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserListDirectLicensesResponse, UserListDirectLicense> ListUserListDirectLicenses(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListDirectLicensesRequest request = new ListUserListDirectLicensesRequest
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
            return ListUserListDirectLicenses(request, callSettings);
        }

        /// <summary>
        /// Lists all user list direct licenses owned by the parent account.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account whose licenses are being queried. Should be in the
        /// format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserListDirectLicense"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserListDirectLicensesResponse, UserListDirectLicense> ListUserListDirectLicensesAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListDirectLicensesRequest request = new ListUserListDirectLicensesRequest
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
            return ListUserListDirectLicensesAsync(request, callSettings);
        }
    }

    /// <summary>UserListDirectLicenseService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing user list direct licenses. Delete is not a supported
    /// operation for UserListDirectLicenses.  Callers should update the
    /// license status to DISABLED to instead to deactivate a license.
    /// 
    /// This feature is only available to data partners.
    /// </remarks>
    public sealed partial class UserListDirectLicenseServiceClientImpl : UserListDirectLicenseServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateUserListDirectLicenseRequest, UserListDirectLicense> _callCreateUserListDirectLicense;

        private readonly gaxgrpc::ApiCall<GetUserListDirectLicenseRequest, UserListDirectLicense> _callGetUserListDirectLicense;

        private readonly gaxgrpc::ApiCall<UpdateUserListDirectLicenseRequest, UserListDirectLicense> _callUpdateUserListDirectLicense;

        private readonly gaxgrpc::ApiCall<ListUserListDirectLicensesRequest, ListUserListDirectLicensesResponse> _callListUserListDirectLicenses;

        /// <summary>
        /// Constructs a client wrapper for the UserListDirectLicenseService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="UserListDirectLicenseServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public UserListDirectLicenseServiceClientImpl(UserListDirectLicenseService.UserListDirectLicenseServiceClient grpcClient, UserListDirectLicenseServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            UserListDirectLicenseServiceSettings effectiveSettings = settings ?? UserListDirectLicenseServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateUserListDirectLicense = clientHelper.BuildApiCall<CreateUserListDirectLicenseRequest, UserListDirectLicense>("CreateUserListDirectLicense", grpcClient.CreateUserListDirectLicenseAsync, grpcClient.CreateUserListDirectLicense, effectiveSettings.CreateUserListDirectLicenseSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUserListDirectLicense);
            Modify_CreateUserListDirectLicenseApiCall(ref _callCreateUserListDirectLicense);
            _callGetUserListDirectLicense = clientHelper.BuildApiCall<GetUserListDirectLicenseRequest, UserListDirectLicense>("GetUserListDirectLicense", grpcClient.GetUserListDirectLicenseAsync, grpcClient.GetUserListDirectLicense, effectiveSettings.GetUserListDirectLicenseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUserListDirectLicense);
            Modify_GetUserListDirectLicenseApiCall(ref _callGetUserListDirectLicense);
            _callUpdateUserListDirectLicense = clientHelper.BuildApiCall<UpdateUserListDirectLicenseRequest, UserListDirectLicense>("UpdateUserListDirectLicense", grpcClient.UpdateUserListDirectLicenseAsync, grpcClient.UpdateUserListDirectLicense, effectiveSettings.UpdateUserListDirectLicenseSettings).WithGoogleRequestParam("user_list_direct_license.name", request => request.UserListDirectLicense?.Name);
            Modify_ApiCall(ref _callUpdateUserListDirectLicense);
            Modify_UpdateUserListDirectLicenseApiCall(ref _callUpdateUserListDirectLicense);
            _callListUserListDirectLicenses = clientHelper.BuildApiCall<ListUserListDirectLicensesRequest, ListUserListDirectLicensesResponse>("ListUserListDirectLicenses", grpcClient.ListUserListDirectLicensesAsync, grpcClient.ListUserListDirectLicenses, effectiveSettings.ListUserListDirectLicensesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUserListDirectLicenses);
            Modify_ListUserListDirectLicensesApiCall(ref _callListUserListDirectLicenses);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateUserListDirectLicenseApiCall(ref gaxgrpc::ApiCall<CreateUserListDirectLicenseRequest, UserListDirectLicense> call);

        partial void Modify_GetUserListDirectLicenseApiCall(ref gaxgrpc::ApiCall<GetUserListDirectLicenseRequest, UserListDirectLicense> call);

        partial void Modify_UpdateUserListDirectLicenseApiCall(ref gaxgrpc::ApiCall<UpdateUserListDirectLicenseRequest, UserListDirectLicense> call);

        partial void Modify_ListUserListDirectLicensesApiCall(ref gaxgrpc::ApiCall<ListUserListDirectLicensesRequest, ListUserListDirectLicensesResponse> call);

        partial void OnConstruction(UserListDirectLicenseService.UserListDirectLicenseServiceClient grpcClient, UserListDirectLicenseServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserListDirectLicenseService client</summary>
        public override UserListDirectLicenseService.UserListDirectLicenseServiceClient GrpcClient { get; }

        partial void Modify_CreateUserListDirectLicenseRequest(ref CreateUserListDirectLicenseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUserListDirectLicenseRequest(ref GetUserListDirectLicenseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUserListDirectLicenseRequest(ref UpdateUserListDirectLicenseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUserListDirectLicensesRequest(ref ListUserListDirectLicensesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserListDirectLicense CreateUserListDirectLicense(CreateUserListDirectLicenseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserListDirectLicenseRequest(ref request, ref callSettings);
            return _callCreateUserListDirectLicense.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserListDirectLicense> CreateUserListDirectLicenseAsync(CreateUserListDirectLicenseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserListDirectLicenseRequest(ref request, ref callSettings);
            return _callCreateUserListDirectLicense.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserListDirectLicense GetUserListDirectLicense(GetUserListDirectLicenseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserListDirectLicenseRequest(ref request, ref callSettings);
            return _callGetUserListDirectLicense.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserListDirectLicense> GetUserListDirectLicenseAsync(GetUserListDirectLicenseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserListDirectLicenseRequest(ref request, ref callSettings);
            return _callGetUserListDirectLicense.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserListDirectLicense UpdateUserListDirectLicense(UpdateUserListDirectLicenseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserListDirectLicenseRequest(ref request, ref callSettings);
            return _callUpdateUserListDirectLicense.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a user list direct license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserListDirectLicense> UpdateUserListDirectLicenseAsync(UpdateUserListDirectLicenseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserListDirectLicenseRequest(ref request, ref callSettings);
            return _callUpdateUserListDirectLicense.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all user list direct licenses owned by the parent account.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserListDirectLicense"/> resources.</returns>
        public override gax::PagedEnumerable<ListUserListDirectLicensesResponse, UserListDirectLicense> ListUserListDirectLicenses(ListUserListDirectLicensesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserListDirectLicensesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUserListDirectLicensesRequest, ListUserListDirectLicensesResponse, UserListDirectLicense>(_callListUserListDirectLicenses, request, callSettings);
        }

        /// <summary>
        /// Lists all user list direct licenses owned by the parent account.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserListDirectLicense"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUserListDirectLicensesResponse, UserListDirectLicense> ListUserListDirectLicensesAsync(ListUserListDirectLicensesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserListDirectLicensesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUserListDirectLicensesRequest, ListUserListDirectLicensesResponse, UserListDirectLicense>(_callListUserListDirectLicenses, request, callSettings);
        }
    }

    public partial class ListUserListDirectLicensesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUserListDirectLicensesResponse : gaxgrpc::IPageResponse<UserListDirectLicense>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UserListDirectLicense> GetEnumerator() => UserListDirectLicenses.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
