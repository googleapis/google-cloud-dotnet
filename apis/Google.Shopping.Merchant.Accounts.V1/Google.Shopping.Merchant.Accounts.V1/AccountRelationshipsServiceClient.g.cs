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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Shopping.Merchant.Accounts.V1
{
    /// <summary>Settings for <see cref="AccountRelationshipsServiceClient"/> instances.</summary>
    public sealed partial class AccountRelationshipsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AccountRelationshipsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AccountRelationshipsServiceSettings"/>.</returns>
        public static AccountRelationshipsServiceSettings GetDefault() => new AccountRelationshipsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AccountRelationshipsServiceSettings"/> object with default settings.
        /// </summary>
        public AccountRelationshipsServiceSettings()
        {
        }

        private AccountRelationshipsServiceSettings(AccountRelationshipsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAccountRelationshipSettings = existing.GetAccountRelationshipSettings;
            UpdateAccountRelationshipSettings = existing.UpdateAccountRelationshipSettings;
            ListAccountRelationshipsSettings = existing.ListAccountRelationshipsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccountRelationshipsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountRelationshipsServiceClient.GetAccountRelationship</c> and
        /// <c>AccountRelationshipsServiceClient.GetAccountRelationshipAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAccountRelationshipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountRelationshipsServiceClient.UpdateAccountRelationship</c> and
        /// <c>AccountRelationshipsServiceClient.UpdateAccountRelationshipAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAccountRelationshipSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountRelationshipsServiceClient.ListAccountRelationships</c> and
        /// <c>AccountRelationshipsServiceClient.ListAccountRelationshipsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAccountRelationshipsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AccountRelationshipsServiceSettings"/> object.</returns>
        public AccountRelationshipsServiceSettings Clone() => new AccountRelationshipsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AccountRelationshipsServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class AccountRelationshipsServiceClientBuilder : gaxgrpc::ClientBuilderBase<AccountRelationshipsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AccountRelationshipsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AccountRelationshipsServiceClientBuilder() : base(AccountRelationshipsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AccountRelationshipsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AccountRelationshipsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AccountRelationshipsServiceClient Build()
        {
            AccountRelationshipsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AccountRelationshipsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AccountRelationshipsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AccountRelationshipsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AccountRelationshipsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AccountRelationshipsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AccountRelationshipsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AccountRelationshipsServiceClient.ChannelPool;
    }

    /// <summary>AccountRelationshipsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to support AccountRelationship API.
    /// </remarks>
    public abstract partial class AccountRelationshipsServiceClient
    {
        /// <summary>
        /// The default endpoint for the AccountRelationshipsService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default AccountRelationshipsService scopes.</summary>
        /// <remarks>
        /// The default AccountRelationshipsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AccountRelationshipsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AccountRelationshipsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AccountRelationshipsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AccountRelationshipsServiceClient"/>.</returns>
        public static stt::Task<AccountRelationshipsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AccountRelationshipsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AccountRelationshipsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AccountRelationshipsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AccountRelationshipsServiceClient"/>.</returns>
        public static AccountRelationshipsServiceClient Create() => new AccountRelationshipsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AccountRelationshipsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AccountRelationshipsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AccountRelationshipsServiceClient"/>.</returns>
        internal static AccountRelationshipsServiceClient Create(grpccore::CallInvoker callInvoker, AccountRelationshipsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccountRelationshipsService.AccountRelationshipsServiceClient grpcClient = new AccountRelationshipsService.AccountRelationshipsServiceClient(callInvoker);
            return new AccountRelationshipsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AccountRelationshipsService client</summary>
        public virtual AccountRelationshipsService.AccountRelationshipsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve an account relationship.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountRelationship GetAccountRelationship(GetAccountRelationshipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve an account relationship.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountRelationship> GetAccountRelationshipAsync(GetAccountRelationshipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve an account relationship.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountRelationship> GetAccountRelationshipAsync(GetAccountRelationshipRequest request, st::CancellationToken cancellationToken) =>
            GetAccountRelationshipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve an account relationship.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account relationship to get.
        /// Format: `accounts/{account}/relationships/{relationship}`. For example,
        /// `accounts/123456/relationships/567890`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountRelationship GetAccountRelationship(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountRelationship(new GetAccountRelationshipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve an account relationship.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account relationship to get.
        /// Format: `accounts/{account}/relationships/{relationship}`. For example,
        /// `accounts/123456/relationships/567890`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountRelationship> GetAccountRelationshipAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountRelationshipAsync(new GetAccountRelationshipRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve an account relationship.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account relationship to get.
        /// Format: `accounts/{account}/relationships/{relationship}`. For example,
        /// `accounts/123456/relationships/567890`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountRelationship> GetAccountRelationshipAsync(string name, st::CancellationToken cancellationToken) =>
            GetAccountRelationshipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve an account relationship.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account relationship to get.
        /// Format: `accounts/{account}/relationships/{relationship}`. For example,
        /// `accounts/123456/relationships/567890`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountRelationship GetAccountRelationship(AccountRelationshipName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountRelationship(new GetAccountRelationshipRequest
            {
                AccountRelationshipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve an account relationship.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account relationship to get.
        /// Format: `accounts/{account}/relationships/{relationship}`. For example,
        /// `accounts/123456/relationships/567890`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountRelationship> GetAccountRelationshipAsync(AccountRelationshipName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountRelationshipAsync(new GetAccountRelationshipRequest
            {
                AccountRelationshipName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve an account relationship.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account relationship to get.
        /// Format: `accounts/{account}/relationships/{relationship}`. For example,
        /// `accounts/123456/relationships/567890`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountRelationship> GetAccountRelationshipAsync(AccountRelationshipName name, st::CancellationToken cancellationToken) =>
            GetAccountRelationshipAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the account relationship. Executing this method requires admin
        /// access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountRelationship UpdateAccountRelationship(UpdateAccountRelationshipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the account relationship. Executing this method requires admin
        /// access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountRelationship> UpdateAccountRelationshipAsync(UpdateAccountRelationshipRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the account relationship. Executing this method requires admin
        /// access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountRelationship> UpdateAccountRelationshipAsync(UpdateAccountRelationshipRequest request, st::CancellationToken cancellationToken) =>
            UpdateAccountRelationshipAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the account relationship. Executing this method requires admin
        /// access.
        /// </summary>
        /// <param name="accountRelationship">
        /// Required. The new version of the account relationship.
        /// </param>
        /// <param name="updateMask">
        /// Optional. List of fields being updated.
        /// 
        /// The following fields are supported (in both `snake_case` and
        /// `lowerCamelCase`):
        /// 
        /// - `account_id_alias`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountRelationship UpdateAccountRelationship(AccountRelationship accountRelationship, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccountRelationship(new UpdateAccountRelationshipRequest
            {
                AccountRelationship = gax::GaxPreconditions.CheckNotNull(accountRelationship, nameof(accountRelationship)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the account relationship. Executing this method requires admin
        /// access.
        /// </summary>
        /// <param name="accountRelationship">
        /// Required. The new version of the account relationship.
        /// </param>
        /// <param name="updateMask">
        /// Optional. List of fields being updated.
        /// 
        /// The following fields are supported (in both `snake_case` and
        /// `lowerCamelCase`):
        /// 
        /// - `account_id_alias`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountRelationship> UpdateAccountRelationshipAsync(AccountRelationship accountRelationship, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccountRelationshipAsync(new UpdateAccountRelationshipRequest
            {
                AccountRelationship = gax::GaxPreconditions.CheckNotNull(accountRelationship, nameof(accountRelationship)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the account relationship. Executing this method requires admin
        /// access.
        /// </summary>
        /// <param name="accountRelationship">
        /// Required. The new version of the account relationship.
        /// </param>
        /// <param name="updateMask">
        /// Optional. List of fields being updated.
        /// 
        /// The following fields are supported (in both `snake_case` and
        /// `lowerCamelCase`):
        /// 
        /// - `account_id_alias`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountRelationship> UpdateAccountRelationshipAsync(AccountRelationship accountRelationship, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAccountRelationshipAsync(accountRelationship, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List account relationships for the specified account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccountRelationship"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountRelationshipsResponse, AccountRelationship> ListAccountRelationships(ListAccountRelationshipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List account relationships for the specified account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccountRelationship"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountRelationshipsResponse, AccountRelationship> ListAccountRelationshipsAsync(ListAccountRelationshipsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List account relationships for the specified account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account of the account relationship to filter by.
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
        /// <returns>A pageable sequence of <see cref="AccountRelationship"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountRelationshipsResponse, AccountRelationship> ListAccountRelationships(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountRelationshipsRequest request = new ListAccountRelationshipsRequest
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
            return ListAccountRelationships(request, callSettings);
        }

        /// <summary>
        /// List account relationships for the specified account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account of the account relationship to filter by.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccountRelationship"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountRelationshipsResponse, AccountRelationship> ListAccountRelationshipsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountRelationshipsRequest request = new ListAccountRelationshipsRequest
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
            return ListAccountRelationshipsAsync(request, callSettings);
        }

        /// <summary>
        /// List account relationships for the specified account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account of the account relationship to filter by.
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
        /// <returns>A pageable sequence of <see cref="AccountRelationship"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountRelationshipsResponse, AccountRelationship> ListAccountRelationships(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountRelationshipsRequest request = new ListAccountRelationshipsRequest
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
            return ListAccountRelationships(request, callSettings);
        }

        /// <summary>
        /// List account relationships for the specified account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account of the account relationship to filter by.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccountRelationship"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountRelationshipsResponse, AccountRelationship> ListAccountRelationshipsAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountRelationshipsRequest request = new ListAccountRelationshipsRequest
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
            return ListAccountRelationshipsAsync(request, callSettings);
        }
    }

    /// <summary>AccountRelationshipsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to support AccountRelationship API.
    /// </remarks>
    public sealed partial class AccountRelationshipsServiceClientImpl : AccountRelationshipsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAccountRelationshipRequest, AccountRelationship> _callGetAccountRelationship;

        private readonly gaxgrpc::ApiCall<UpdateAccountRelationshipRequest, AccountRelationship> _callUpdateAccountRelationship;

        private readonly gaxgrpc::ApiCall<ListAccountRelationshipsRequest, ListAccountRelationshipsResponse> _callListAccountRelationships;

        /// <summary>
        /// Constructs a client wrapper for the AccountRelationshipsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AccountRelationshipsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AccountRelationshipsServiceClientImpl(AccountRelationshipsService.AccountRelationshipsServiceClient grpcClient, AccountRelationshipsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AccountRelationshipsServiceSettings effectiveSettings = settings ?? AccountRelationshipsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetAccountRelationship = clientHelper.BuildApiCall<GetAccountRelationshipRequest, AccountRelationship>("GetAccountRelationship", grpcClient.GetAccountRelationshipAsync, grpcClient.GetAccountRelationship, effectiveSettings.GetAccountRelationshipSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAccountRelationship);
            Modify_GetAccountRelationshipApiCall(ref _callGetAccountRelationship);
            _callUpdateAccountRelationship = clientHelper.BuildApiCall<UpdateAccountRelationshipRequest, AccountRelationship>("UpdateAccountRelationship", grpcClient.UpdateAccountRelationshipAsync, grpcClient.UpdateAccountRelationship, effectiveSettings.UpdateAccountRelationshipSettings).WithGoogleRequestParam("account_relationship.name", request => request.AccountRelationship?.Name);
            Modify_ApiCall(ref _callUpdateAccountRelationship);
            Modify_UpdateAccountRelationshipApiCall(ref _callUpdateAccountRelationship);
            _callListAccountRelationships = clientHelper.BuildApiCall<ListAccountRelationshipsRequest, ListAccountRelationshipsResponse>("ListAccountRelationships", grpcClient.ListAccountRelationshipsAsync, grpcClient.ListAccountRelationships, effectiveSettings.ListAccountRelationshipsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAccountRelationships);
            Modify_ListAccountRelationshipsApiCall(ref _callListAccountRelationships);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAccountRelationshipApiCall(ref gaxgrpc::ApiCall<GetAccountRelationshipRequest, AccountRelationship> call);

        partial void Modify_UpdateAccountRelationshipApiCall(ref gaxgrpc::ApiCall<UpdateAccountRelationshipRequest, AccountRelationship> call);

        partial void Modify_ListAccountRelationshipsApiCall(ref gaxgrpc::ApiCall<ListAccountRelationshipsRequest, ListAccountRelationshipsResponse> call);

        partial void OnConstruction(AccountRelationshipsService.AccountRelationshipsServiceClient grpcClient, AccountRelationshipsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccountRelationshipsService client</summary>
        public override AccountRelationshipsService.AccountRelationshipsServiceClient GrpcClient { get; }

        partial void Modify_GetAccountRelationshipRequest(ref GetAccountRelationshipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAccountRelationshipRequest(ref UpdateAccountRelationshipRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAccountRelationshipsRequest(ref ListAccountRelationshipsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieve an account relationship.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccountRelationship GetAccountRelationship(GetAccountRelationshipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountRelationshipRequest(ref request, ref callSettings);
            return _callGetAccountRelationship.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve an account relationship.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccountRelationship> GetAccountRelationshipAsync(GetAccountRelationshipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountRelationshipRequest(ref request, ref callSettings);
            return _callGetAccountRelationship.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the account relationship. Executing this method requires admin
        /// access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccountRelationship UpdateAccountRelationship(UpdateAccountRelationshipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccountRelationshipRequest(ref request, ref callSettings);
            return _callUpdateAccountRelationship.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the account relationship. Executing this method requires admin
        /// access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccountRelationship> UpdateAccountRelationshipAsync(UpdateAccountRelationshipRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccountRelationshipRequest(ref request, ref callSettings);
            return _callUpdateAccountRelationship.Async(request, callSettings);
        }

        /// <summary>
        /// List account relationships for the specified account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccountRelationship"/> resources.</returns>
        public override gax::PagedEnumerable<ListAccountRelationshipsResponse, AccountRelationship> ListAccountRelationships(ListAccountRelationshipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountRelationshipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAccountRelationshipsRequest, ListAccountRelationshipsResponse, AccountRelationship>(_callListAccountRelationships, request, callSettings);
        }

        /// <summary>
        /// List account relationships for the specified account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccountRelationship"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAccountRelationshipsResponse, AccountRelationship> ListAccountRelationshipsAsync(ListAccountRelationshipsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountRelationshipsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAccountRelationshipsRequest, ListAccountRelationshipsResponse, AccountRelationship>(_callListAccountRelationships, request, callSettings);
        }
    }

    public partial class ListAccountRelationshipsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAccountRelationshipsResponse : gaxgrpc::IPageResponse<AccountRelationship>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AccountRelationship> GetEnumerator() => AccountRelationships.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
