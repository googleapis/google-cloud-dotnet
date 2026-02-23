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
    /// <summary>Settings for <see cref="UserListGlobalLicenseServiceClient"/> instances.</summary>
    public sealed partial class UserListGlobalLicenseServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UserListGlobalLicenseServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UserListGlobalLicenseServiceSettings"/>.</returns>
        public static UserListGlobalLicenseServiceSettings GetDefault() => new UserListGlobalLicenseServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="UserListGlobalLicenseServiceSettings"/> object with default settings.
        /// </summary>
        public UserListGlobalLicenseServiceSettings()
        {
        }

        private UserListGlobalLicenseServiceSettings(UserListGlobalLicenseServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateUserListGlobalLicenseSettings = existing.CreateUserListGlobalLicenseSettings;
            UpdateUserListGlobalLicenseSettings = existing.UpdateUserListGlobalLicenseSettings;
            GetUserListGlobalLicenseSettings = existing.GetUserListGlobalLicenseSettings;
            ListUserListGlobalLicensesSettings = existing.ListUserListGlobalLicensesSettings;
            ListUserListGlobalLicenseCustomerInfosSettings = existing.ListUserListGlobalLicenseCustomerInfosSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UserListGlobalLicenseServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListGlobalLicenseServiceClient.CreateUserListGlobalLicense</c> and
        /// <c>UserListGlobalLicenseServiceClient.CreateUserListGlobalLicenseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUserListGlobalLicenseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListGlobalLicenseServiceClient.UpdateUserListGlobalLicense</c> and
        /// <c>UserListGlobalLicenseServiceClient.UpdateUserListGlobalLicenseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUserListGlobalLicenseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListGlobalLicenseServiceClient.GetUserListGlobalLicense</c> and
        /// <c>UserListGlobalLicenseServiceClient.GetUserListGlobalLicenseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUserListGlobalLicenseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListGlobalLicenseServiceClient.ListUserListGlobalLicenses</c> and
        /// <c>UserListGlobalLicenseServiceClient.ListUserListGlobalLicensesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUserListGlobalLicensesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListGlobalLicenseServiceClient.ListUserListGlobalLicenseCustomerInfos</c> and
        /// <c>UserListGlobalLicenseServiceClient.ListUserListGlobalLicenseCustomerInfosAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUserListGlobalLicenseCustomerInfosSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserListGlobalLicenseServiceSettings"/> object.</returns>
        public UserListGlobalLicenseServiceSettings Clone() => new UserListGlobalLicenseServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserListGlobalLicenseServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class UserListGlobalLicenseServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserListGlobalLicenseServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserListGlobalLicenseServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public UserListGlobalLicenseServiceClientBuilder() : base(UserListGlobalLicenseServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref UserListGlobalLicenseServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UserListGlobalLicenseServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UserListGlobalLicenseServiceClient Build()
        {
            UserListGlobalLicenseServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UserListGlobalLicenseServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UserListGlobalLicenseServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UserListGlobalLicenseServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UserListGlobalLicenseServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<UserListGlobalLicenseServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserListGlobalLicenseServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserListGlobalLicenseServiceClient.ChannelPool;
    }

    /// <summary>UserListGlobalLicenseService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing user list global licenses. Delete is not a supported
    /// operation for UserListGlobalLicenses.  Callers should update the
    /// license status to DISABLED to instead to deactivate a license.
    /// 
    /// This feature is only available to data partners.
    /// </remarks>
    public abstract partial class UserListGlobalLicenseServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserListGlobalLicenseService service, which is a host of
        /// "datamanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datamanager.googleapis.com:443";

        /// <summary>The default UserListGlobalLicenseService scopes.</summary>
        /// <remarks>
        /// The default UserListGlobalLicenseService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/datamanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/datamanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(UserListGlobalLicenseService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="UserListGlobalLicenseServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="UserListGlobalLicenseServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UserListGlobalLicenseServiceClient"/>.</returns>
        public static stt::Task<UserListGlobalLicenseServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UserListGlobalLicenseServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UserListGlobalLicenseServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="UserListGlobalLicenseServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UserListGlobalLicenseServiceClient"/>.</returns>
        public static UserListGlobalLicenseServiceClient Create() => new UserListGlobalLicenseServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UserListGlobalLicenseServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UserListGlobalLicenseServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="UserListGlobalLicenseServiceClient"/>.</returns>
        internal static UserListGlobalLicenseServiceClient Create(grpccore::CallInvoker callInvoker, UserListGlobalLicenseServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserListGlobalLicenseService.UserListGlobalLicenseServiceClient grpcClient = new UserListGlobalLicenseService.UserListGlobalLicenseServiceClient(callInvoker);
            return new UserListGlobalLicenseServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC UserListGlobalLicenseService client</summary>
        public virtual UserListGlobalLicenseService.UserListGlobalLicenseServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListGlobalLicense CreateUserListGlobalLicense(CreateUserListGlobalLicenseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> CreateUserListGlobalLicenseAsync(CreateUserListGlobalLicenseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> CreateUserListGlobalLicenseAsync(CreateUserListGlobalLicenseRequest request, st::CancellationToken cancellationToken) =>
            CreateUserListGlobalLicenseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account that owns the user list being licensed. Should be in
        /// the format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
        /// </param>
        /// <param name="userListGlobalLicense">
        /// Required. The user list global license to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListGlobalLicense CreateUserListGlobalLicense(string parent, UserListGlobalLicense userListGlobalLicense, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserListGlobalLicense(new CreateUserListGlobalLicenseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserListGlobalLicense = gax::GaxPreconditions.CheckNotNull(userListGlobalLicense, nameof(userListGlobalLicense)),
            }, callSettings);

        /// <summary>
        /// Creates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account that owns the user list being licensed. Should be in
        /// the format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
        /// </param>
        /// <param name="userListGlobalLicense">
        /// Required. The user list global license to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> CreateUserListGlobalLicenseAsync(string parent, UserListGlobalLicense userListGlobalLicense, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserListGlobalLicenseAsync(new CreateUserListGlobalLicenseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserListGlobalLicense = gax::GaxPreconditions.CheckNotNull(userListGlobalLicense, nameof(userListGlobalLicense)),
            }, callSettings);

        /// <summary>
        /// Creates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account that owns the user list being licensed. Should be in
        /// the format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
        /// </param>
        /// <param name="userListGlobalLicense">
        /// Required. The user list global license to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> CreateUserListGlobalLicenseAsync(string parent, UserListGlobalLicense userListGlobalLicense, st::CancellationToken cancellationToken) =>
            CreateUserListGlobalLicenseAsync(parent, userListGlobalLicense, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account that owns the user list being licensed. Should be in
        /// the format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
        /// </param>
        /// <param name="userListGlobalLicense">
        /// Required. The user list global license to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListGlobalLicense CreateUserListGlobalLicense(AccountName parent, UserListGlobalLicense userListGlobalLicense, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserListGlobalLicense(new CreateUserListGlobalLicenseRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserListGlobalLicense = gax::GaxPreconditions.CheckNotNull(userListGlobalLicense, nameof(userListGlobalLicense)),
            }, callSettings);

        /// <summary>
        /// Creates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account that owns the user list being licensed. Should be in
        /// the format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
        /// </param>
        /// <param name="userListGlobalLicense">
        /// Required. The user list global license to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> CreateUserListGlobalLicenseAsync(AccountName parent, UserListGlobalLicense userListGlobalLicense, gaxgrpc::CallSettings callSettings = null) =>
            CreateUserListGlobalLicenseAsync(new CreateUserListGlobalLicenseRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserListGlobalLicense = gax::GaxPreconditions.CheckNotNull(userListGlobalLicense, nameof(userListGlobalLicense)),
            }, callSettings);

        /// <summary>
        /// Creates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The account that owns the user list being licensed. Should be in
        /// the format accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}
        /// </param>
        /// <param name="userListGlobalLicense">
        /// Required. The user list global license to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> CreateUserListGlobalLicenseAsync(AccountName parent, UserListGlobalLicense userListGlobalLicense, st::CancellationToken cancellationToken) =>
            CreateUserListGlobalLicenseAsync(parent, userListGlobalLicense, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListGlobalLicense UpdateUserListGlobalLicense(UpdateUserListGlobalLicenseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> UpdateUserListGlobalLicenseAsync(UpdateUserListGlobalLicenseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> UpdateUserListGlobalLicenseAsync(UpdateUserListGlobalLicenseRequest request, st::CancellationToken cancellationToken) =>
            UpdateUserListGlobalLicenseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="userListGlobalLicense">
        /// Required. The licenses' `name` field is used to identify the license to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. The special character `*` is not
        /// supported and an `INVALID_UPDATE_MASK` error will be thrown if used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListGlobalLicense UpdateUserListGlobalLicense(UserListGlobalLicense userListGlobalLicense, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserListGlobalLicense(new UpdateUserListGlobalLicenseRequest
            {
                UserListGlobalLicense = gax::GaxPreconditions.CheckNotNull(userListGlobalLicense, nameof(userListGlobalLicense)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="userListGlobalLicense">
        /// Required. The licenses' `name` field is used to identify the license to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. The special character `*` is not
        /// supported and an `INVALID_UPDATE_MASK` error will be thrown if used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> UpdateUserListGlobalLicenseAsync(UserListGlobalLicense userListGlobalLicense, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUserListGlobalLicenseAsync(new UpdateUserListGlobalLicenseRequest
            {
                UserListGlobalLicense = gax::GaxPreconditions.CheckNotNull(userListGlobalLicense, nameof(userListGlobalLicense)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="userListGlobalLicense">
        /// Required. The licenses' `name` field is used to identify the license to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. The special character `*` is not
        /// supported and an `INVALID_UPDATE_MASK` error will be thrown if used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> UpdateUserListGlobalLicenseAsync(UserListGlobalLicense userListGlobalLicense, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateUserListGlobalLicenseAsync(userListGlobalLicense, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListGlobalLicense GetUserListGlobalLicense(GetUserListGlobalLicenseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> GetUserListGlobalLicenseAsync(GetUserListGlobalLicenseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> GetUserListGlobalLicenseAsync(GetUserListGlobalLicenseRequest request, st::CancellationToken cancellationToken) =>
            GetUserListGlobalLicenseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the user list global license.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListGlobalLicense GetUserListGlobalLicense(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserListGlobalLicense(new GetUserListGlobalLicenseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the user list global license.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> GetUserListGlobalLicenseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserListGlobalLicenseAsync(new GetUserListGlobalLicenseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the user list global license.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> GetUserListGlobalLicenseAsync(string name, st::CancellationToken cancellationToken) =>
            GetUserListGlobalLicenseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the user list global license.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserListGlobalLicense GetUserListGlobalLicense(UserListGlobalLicenseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserListGlobalLicense(new GetUserListGlobalLicenseRequest
            {
                UserListGlobalLicenseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the user list global license.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> GetUserListGlobalLicenseAsync(UserListGlobalLicenseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUserListGlobalLicenseAsync(new GetUserListGlobalLicenseRequest
            {
                UserListGlobalLicenseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the user list global license.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserListGlobalLicense> GetUserListGlobalLicenseAsync(UserListGlobalLicenseName name, st::CancellationToken cancellationToken) =>
            GetUserListGlobalLicenseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all user list global licenses owned by the parent account.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserListGlobalLicense"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserListGlobalLicensesResponse, UserListGlobalLicense> ListUserListGlobalLicenses(ListUserListGlobalLicensesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all user list global licenses owned by the parent account.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserListGlobalLicense"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserListGlobalLicensesResponse, UserListGlobalLicense> ListUserListGlobalLicensesAsync(ListUserListGlobalLicensesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all user list global licenses owned by the parent account.
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
        /// <returns>A pageable sequence of <see cref="UserListGlobalLicense"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserListGlobalLicensesResponse, UserListGlobalLicense> ListUserListGlobalLicenses(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListGlobalLicensesRequest request = new ListUserListGlobalLicensesRequest
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
            return ListUserListGlobalLicenses(request, callSettings);
        }

        /// <summary>
        /// Lists all user list global licenses owned by the parent account.
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserListGlobalLicense"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserListGlobalLicensesResponse, UserListGlobalLicense> ListUserListGlobalLicensesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListGlobalLicensesRequest request = new ListUserListGlobalLicensesRequest
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
            return ListUserListGlobalLicensesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all user list global licenses owned by the parent account.
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
        /// <returns>A pageable sequence of <see cref="UserListGlobalLicense"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserListGlobalLicensesResponse, UserListGlobalLicense> ListUserListGlobalLicenses(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListGlobalLicensesRequest request = new ListUserListGlobalLicensesRequest
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
            return ListUserListGlobalLicenses(request, callSettings);
        }

        /// <summary>
        /// Lists all user list global licenses owned by the parent account.
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserListGlobalLicense"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserListGlobalLicensesResponse, UserListGlobalLicense> ListUserListGlobalLicensesAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListGlobalLicensesRequest request = new ListUserListGlobalLicensesRequest
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
            return ListUserListGlobalLicensesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all customer info for a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserListGlobalLicenseCustomerInfo"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo> ListUserListGlobalLicenseCustomerInfos(ListUserListGlobalLicenseCustomerInfosRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all customer info for a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="UserListGlobalLicenseCustomerInfo"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo> ListUserListGlobalLicenseCustomerInfosAsync(ListUserListGlobalLicenseCustomerInfosRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all customer info for a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The global license whose customer info are being queried. Should
        /// be in the format
        /// `accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}/userListGlobalLicenses/{USER_LIST_GLOBAL_LICENSE_ID}`.
        /// To list all global license customer info under an account, replace the user
        /// list global license id with a '-' (for example,
        /// `accountTypes/DATA_PARTNER/accounts/123/userListGlobalLicenses/-`)
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
        /// <returns>A pageable sequence of <see cref="UserListGlobalLicenseCustomerInfo"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo> ListUserListGlobalLicenseCustomerInfos(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListGlobalLicenseCustomerInfosRequest request = new ListUserListGlobalLicenseCustomerInfosRequest
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
            return ListUserListGlobalLicenseCustomerInfos(request, callSettings);
        }

        /// <summary>
        /// Lists all customer info for a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The global license whose customer info are being queried. Should
        /// be in the format
        /// `accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}/userListGlobalLicenses/{USER_LIST_GLOBAL_LICENSE_ID}`.
        /// To list all global license customer info under an account, replace the user
        /// list global license id with a '-' (for example,
        /// `accountTypes/DATA_PARTNER/accounts/123/userListGlobalLicenses/-`)
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="UserListGlobalLicenseCustomerInfo"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo> ListUserListGlobalLicenseCustomerInfosAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListGlobalLicenseCustomerInfosRequest request = new ListUserListGlobalLicenseCustomerInfosRequest
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
            return ListUserListGlobalLicenseCustomerInfosAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all customer info for a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The global license whose customer info are being queried. Should
        /// be in the format
        /// `accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}/userListGlobalLicenses/{USER_LIST_GLOBAL_LICENSE_ID}`.
        /// To list all global license customer info under an account, replace the user
        /// list global license id with a '-' (for example,
        /// `accountTypes/DATA_PARTNER/accounts/123/userListGlobalLicenses/-`)
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
        /// <returns>A pageable sequence of <see cref="UserListGlobalLicenseCustomerInfo"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo> ListUserListGlobalLicenseCustomerInfos(UserListGlobalLicenseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListGlobalLicenseCustomerInfosRequest request = new ListUserListGlobalLicenseCustomerInfosRequest
            {
                ParentAsUserListGlobalLicenseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserListGlobalLicenseCustomerInfos(request, callSettings);
        }

        /// <summary>
        /// Lists all customer info for a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The global license whose customer info are being queried. Should
        /// be in the format
        /// `accountTypes/{ACCOUNT_TYPE}/accounts/{ACCOUNT_ID}/userListGlobalLicenses/{USER_LIST_GLOBAL_LICENSE_ID}`.
        /// To list all global license customer info under an account, replace the user
        /// list global license id with a '-' (for example,
        /// `accountTypes/DATA_PARTNER/accounts/123/userListGlobalLicenses/-`)
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="UserListGlobalLicenseCustomerInfo"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo> ListUserListGlobalLicenseCustomerInfosAsync(UserListGlobalLicenseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserListGlobalLicenseCustomerInfosRequest request = new ListUserListGlobalLicenseCustomerInfosRequest
            {
                ParentAsUserListGlobalLicenseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserListGlobalLicenseCustomerInfosAsync(request, callSettings);
        }
    }

    /// <summary>UserListGlobalLicenseService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing user list global licenses. Delete is not a supported
    /// operation for UserListGlobalLicenses.  Callers should update the
    /// license status to DISABLED to instead to deactivate a license.
    /// 
    /// This feature is only available to data partners.
    /// </remarks>
    public sealed partial class UserListGlobalLicenseServiceClientImpl : UserListGlobalLicenseServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateUserListGlobalLicenseRequest, UserListGlobalLicense> _callCreateUserListGlobalLicense;

        private readonly gaxgrpc::ApiCall<UpdateUserListGlobalLicenseRequest, UserListGlobalLicense> _callUpdateUserListGlobalLicense;

        private readonly gaxgrpc::ApiCall<GetUserListGlobalLicenseRequest, UserListGlobalLicense> _callGetUserListGlobalLicense;

        private readonly gaxgrpc::ApiCall<ListUserListGlobalLicensesRequest, ListUserListGlobalLicensesResponse> _callListUserListGlobalLicenses;

        private readonly gaxgrpc::ApiCall<ListUserListGlobalLicenseCustomerInfosRequest, ListUserListGlobalLicenseCustomerInfosResponse> _callListUserListGlobalLicenseCustomerInfos;

        /// <summary>
        /// Constructs a client wrapper for the UserListGlobalLicenseService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="UserListGlobalLicenseServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public UserListGlobalLicenseServiceClientImpl(UserListGlobalLicenseService.UserListGlobalLicenseServiceClient grpcClient, UserListGlobalLicenseServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            UserListGlobalLicenseServiceSettings effectiveSettings = settings ?? UserListGlobalLicenseServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateUserListGlobalLicense = clientHelper.BuildApiCall<CreateUserListGlobalLicenseRequest, UserListGlobalLicense>("CreateUserListGlobalLicense", grpcClient.CreateUserListGlobalLicenseAsync, grpcClient.CreateUserListGlobalLicense, effectiveSettings.CreateUserListGlobalLicenseSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUserListGlobalLicense);
            Modify_CreateUserListGlobalLicenseApiCall(ref _callCreateUserListGlobalLicense);
            _callUpdateUserListGlobalLicense = clientHelper.BuildApiCall<UpdateUserListGlobalLicenseRequest, UserListGlobalLicense>("UpdateUserListGlobalLicense", grpcClient.UpdateUserListGlobalLicenseAsync, grpcClient.UpdateUserListGlobalLicense, effectiveSettings.UpdateUserListGlobalLicenseSettings).WithGoogleRequestParam("user_list_global_license.name", request => request.UserListGlobalLicense?.Name);
            Modify_ApiCall(ref _callUpdateUserListGlobalLicense);
            Modify_UpdateUserListGlobalLicenseApiCall(ref _callUpdateUserListGlobalLicense);
            _callGetUserListGlobalLicense = clientHelper.BuildApiCall<GetUserListGlobalLicenseRequest, UserListGlobalLicense>("GetUserListGlobalLicense", grpcClient.GetUserListGlobalLicenseAsync, grpcClient.GetUserListGlobalLicense, effectiveSettings.GetUserListGlobalLicenseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUserListGlobalLicense);
            Modify_GetUserListGlobalLicenseApiCall(ref _callGetUserListGlobalLicense);
            _callListUserListGlobalLicenses = clientHelper.BuildApiCall<ListUserListGlobalLicensesRequest, ListUserListGlobalLicensesResponse>("ListUserListGlobalLicenses", grpcClient.ListUserListGlobalLicensesAsync, grpcClient.ListUserListGlobalLicenses, effectiveSettings.ListUserListGlobalLicensesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUserListGlobalLicenses);
            Modify_ListUserListGlobalLicensesApiCall(ref _callListUserListGlobalLicenses);
            _callListUserListGlobalLicenseCustomerInfos = clientHelper.BuildApiCall<ListUserListGlobalLicenseCustomerInfosRequest, ListUserListGlobalLicenseCustomerInfosResponse>("ListUserListGlobalLicenseCustomerInfos", grpcClient.ListUserListGlobalLicenseCustomerInfosAsync, grpcClient.ListUserListGlobalLicenseCustomerInfos, effectiveSettings.ListUserListGlobalLicenseCustomerInfosSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUserListGlobalLicenseCustomerInfos);
            Modify_ListUserListGlobalLicenseCustomerInfosApiCall(ref _callListUserListGlobalLicenseCustomerInfos);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateUserListGlobalLicenseApiCall(ref gaxgrpc::ApiCall<CreateUserListGlobalLicenseRequest, UserListGlobalLicense> call);

        partial void Modify_UpdateUserListGlobalLicenseApiCall(ref gaxgrpc::ApiCall<UpdateUserListGlobalLicenseRequest, UserListGlobalLicense> call);

        partial void Modify_GetUserListGlobalLicenseApiCall(ref gaxgrpc::ApiCall<GetUserListGlobalLicenseRequest, UserListGlobalLicense> call);

        partial void Modify_ListUserListGlobalLicensesApiCall(ref gaxgrpc::ApiCall<ListUserListGlobalLicensesRequest, ListUserListGlobalLicensesResponse> call);

        partial void Modify_ListUserListGlobalLicenseCustomerInfosApiCall(ref gaxgrpc::ApiCall<ListUserListGlobalLicenseCustomerInfosRequest, ListUserListGlobalLicenseCustomerInfosResponse> call);

        partial void OnConstruction(UserListGlobalLicenseService.UserListGlobalLicenseServiceClient grpcClient, UserListGlobalLicenseServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserListGlobalLicenseService client</summary>
        public override UserListGlobalLicenseService.UserListGlobalLicenseServiceClient GrpcClient { get; }

        partial void Modify_CreateUserListGlobalLicenseRequest(ref CreateUserListGlobalLicenseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUserListGlobalLicenseRequest(ref UpdateUserListGlobalLicenseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUserListGlobalLicenseRequest(ref GetUserListGlobalLicenseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUserListGlobalLicensesRequest(ref ListUserListGlobalLicensesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUserListGlobalLicenseCustomerInfosRequest(ref ListUserListGlobalLicenseCustomerInfosRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserListGlobalLicense CreateUserListGlobalLicense(CreateUserListGlobalLicenseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserListGlobalLicenseRequest(ref request, ref callSettings);
            return _callCreateUserListGlobalLicense.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserListGlobalLicense> CreateUserListGlobalLicenseAsync(CreateUserListGlobalLicenseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUserListGlobalLicenseRequest(ref request, ref callSettings);
            return _callCreateUserListGlobalLicense.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserListGlobalLicense UpdateUserListGlobalLicense(UpdateUserListGlobalLicenseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserListGlobalLicenseRequest(ref request, ref callSettings);
            return _callUpdateUserListGlobalLicense.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserListGlobalLicense> UpdateUserListGlobalLicenseAsync(UpdateUserListGlobalLicenseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUserListGlobalLicenseRequest(ref request, ref callSettings);
            return _callUpdateUserListGlobalLicense.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserListGlobalLicense GetUserListGlobalLicense(GetUserListGlobalLicenseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserListGlobalLicenseRequest(ref request, ref callSettings);
            return _callGetUserListGlobalLicense.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserListGlobalLicense> GetUserListGlobalLicenseAsync(GetUserListGlobalLicenseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserListGlobalLicenseRequest(ref request, ref callSettings);
            return _callGetUserListGlobalLicense.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all user list global licenses owned by the parent account.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserListGlobalLicense"/> resources.</returns>
        public override gax::PagedEnumerable<ListUserListGlobalLicensesResponse, UserListGlobalLicense> ListUserListGlobalLicenses(ListUserListGlobalLicensesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserListGlobalLicensesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUserListGlobalLicensesRequest, ListUserListGlobalLicensesResponse, UserListGlobalLicense>(_callListUserListGlobalLicenses, request, callSettings);
        }

        /// <summary>
        /// Lists all user list global licenses owned by the parent account.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserListGlobalLicense"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUserListGlobalLicensesResponse, UserListGlobalLicense> ListUserListGlobalLicensesAsync(ListUserListGlobalLicensesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserListGlobalLicensesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUserListGlobalLicensesRequest, ListUserListGlobalLicensesResponse, UserListGlobalLicense>(_callListUserListGlobalLicenses, request, callSettings);
        }

        /// <summary>
        /// Lists all customer info for a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserListGlobalLicenseCustomerInfo"/> resources.</returns>
        public override gax::PagedEnumerable<ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo> ListUserListGlobalLicenseCustomerInfos(ListUserListGlobalLicenseCustomerInfosRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserListGlobalLicenseCustomerInfosRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUserListGlobalLicenseCustomerInfosRequest, ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo>(_callListUserListGlobalLicenseCustomerInfos, request, callSettings);
        }

        /// <summary>
        /// Lists all customer info for a user list global license.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="UserListGlobalLicenseCustomerInfo"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo> ListUserListGlobalLicenseCustomerInfosAsync(ListUserListGlobalLicenseCustomerInfosRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserListGlobalLicenseCustomerInfosRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUserListGlobalLicenseCustomerInfosRequest, ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo>(_callListUserListGlobalLicenseCustomerInfos, request, callSettings);
        }
    }

    public partial class ListUserListGlobalLicensesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUserListGlobalLicenseCustomerInfosRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUserListGlobalLicensesResponse : gaxgrpc::IPageResponse<UserListGlobalLicense>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UserListGlobalLicense> GetEnumerator() => UserListGlobalLicenses.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUserListGlobalLicenseCustomerInfosResponse : gaxgrpc::IPageResponse<UserListGlobalLicenseCustomerInfo>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UserListGlobalLicenseCustomerInfo> GetEnumerator() =>
            UserListGlobalLicenseCustomerInfos.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
