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

namespace Google.Shopping.Css.V1
{
    /// <summary>Settings for <see cref="AccountsServiceClient"/> instances.</summary>
    public sealed partial class AccountsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AccountsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AccountsServiceSettings"/>.</returns>
        public static AccountsServiceSettings GetDefault() => new AccountsServiceSettings();

        /// <summary>Constructs a new <see cref="AccountsServiceSettings"/> object with default settings.</summary>
        public AccountsServiceSettings()
        {
        }

        private AccountsServiceSettings(AccountsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListChildAccountsSettings = existing.ListChildAccountsSettings;
            GetAccountSettings = existing.GetAccountSettings;
            UpdateLabelsSettings = existing.UpdateLabelsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccountsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountsServiceClient.ListChildAccounts</c> and <c>AccountsServiceClient.ListChildAccountsAsync</c>.
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
        public gaxgrpc::CallSettings ListChildAccountsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountsServiceClient.GetAccount</c> and <c>AccountsServiceClient.GetAccountAsync</c>.
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
        public gaxgrpc::CallSettings GetAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountsServiceClient.UpdateLabels</c> and <c>AccountsServiceClient.UpdateLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AccountsServiceSettings"/> object.</returns>
        public AccountsServiceSettings Clone() => new AccountsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AccountsServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AccountsServiceClientBuilder : gaxgrpc::ClientBuilderBase<AccountsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AccountsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AccountsServiceClientBuilder() : base(AccountsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AccountsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AccountsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AccountsServiceClient Build()
        {
            AccountsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AccountsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AccountsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AccountsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AccountsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AccountsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AccountsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AccountsServiceClient.ChannelPool;
    }

    /// <summary>AccountsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing CSS/MC account information.
    /// </remarks>
    public abstract partial class AccountsServiceClient
    {
        /// <summary>
        /// The default endpoint for the AccountsService service, which is a host of "css.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "css.googleapis.com:443";

        /// <summary>The default AccountsService scopes.</summary>
        /// <remarks>
        /// The default AccountsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AccountsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AccountsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AccountsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AccountsServiceClient"/>.</returns>
        public static stt::Task<AccountsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AccountsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AccountsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AccountsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AccountsServiceClient"/>.</returns>
        public static AccountsServiceClient Create() => new AccountsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AccountsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AccountsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AccountsServiceClient"/>.</returns>
        internal static AccountsServiceClient Create(grpccore::CallInvoker callInvoker, AccountsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccountsService.AccountsServiceClient grpcClient = new AccountsService.AccountsServiceClient(callInvoker);
            return new AccountsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AccountsService client</summary>
        public virtual AccountsService.AccountsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the accounts under the specified CSS account ID, and
        /// optionally filters by label ID and account name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChildAccountsResponse, Account> ListChildAccounts(ListChildAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the accounts under the specified CSS account ID, and
        /// optionally filters by label ID and account name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChildAccountsResponse, Account> ListChildAccountsAsync(ListChildAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the accounts under the specified CSS account ID, and
        /// optionally filters by label ID and account name.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account. Must be a CSS group or domain.
        /// Format: accounts/{account}
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
        /// <returns>A pageable sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChildAccountsResponse, Account> ListChildAccounts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChildAccountsRequest request = new ListChildAccountsRequest
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
            return ListChildAccounts(request, callSettings);
        }

        /// <summary>
        /// Lists all the accounts under the specified CSS account ID, and
        /// optionally filters by label ID and account name.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account. Must be a CSS group or domain.
        /// Format: accounts/{account}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChildAccountsResponse, Account> ListChildAccountsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChildAccountsRequest request = new ListChildAccountsRequest
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
            return ListChildAccountsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the accounts under the specified CSS account ID, and
        /// optionally filters by label ID and account name.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account. Must be a CSS group or domain.
        /// Format: accounts/{account}
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
        /// <returns>A pageable sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChildAccountsResponse, Account> ListChildAccounts(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChildAccountsRequest request = new ListChildAccountsRequest
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
            return ListChildAccounts(request, callSettings);
        }

        /// <summary>
        /// Lists all the accounts under the specified CSS account ID, and
        /// optionally filters by label ID and account name.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account. Must be a CSS group or domain.
        /// Format: accounts/{account}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChildAccountsResponse, Account> ListChildAccountsAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChildAccountsRequest request = new ListChildAccountsRequest
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
            return ListChildAccountsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a single CSS/MC account by ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account GetAccount(GetAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a single CSS/MC account by ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(GetAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a single CSS/MC account by ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(GetAccountRequest request, st::CancellationToken cancellationToken) =>
            GetAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a single CSS/MC account by ID.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the managed CSS/MC account.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account GetAccount(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccount(new GetAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a single CSS/MC account by ID.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the managed CSS/MC account.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountAsync(new GetAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a single CSS/MC account by ID.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the managed CSS/MC account.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(string name, st::CancellationToken cancellationToken) =>
            GetAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a single CSS/MC account by ID.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the managed CSS/MC account.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account GetAccount(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccount(new GetAccountRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a single CSS/MC account by ID.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the managed CSS/MC account.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountAsync(new GetAccountRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a single CSS/MC account by ID.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the managed CSS/MC account.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(AccountName name, st::CancellationToken cancellationToken) =>
            GetAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates labels assigned to CSS/MC accounts by a CSS domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account UpdateLabels(UpdateAccountLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates labels assigned to CSS/MC accounts by a CSS domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> UpdateLabelsAsync(UpdateAccountLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates labels assigned to CSS/MC accounts by a CSS domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> UpdateLabelsAsync(UpdateAccountLabelsRequest request, st::CancellationToken cancellationToken) =>
            UpdateLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates labels assigned to CSS/MC accounts by a CSS domain.
        /// </summary>
        /// <param name="name">
        /// Required. The label resource name.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account UpdateLabels(string name, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLabels(new UpdateAccountLabelsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Updates labels assigned to CSS/MC accounts by a CSS domain.
        /// </summary>
        /// <param name="name">
        /// Required. The label resource name.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> UpdateLabelsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLabelsAsync(new UpdateAccountLabelsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Updates labels assigned to CSS/MC accounts by a CSS domain.
        /// </summary>
        /// <param name="name">
        /// Required. The label resource name.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> UpdateLabelsAsync(string name, st::CancellationToken cancellationToken) =>
            UpdateLabelsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates labels assigned to CSS/MC accounts by a CSS domain.
        /// </summary>
        /// <param name="name">
        /// Required. The label resource name.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account UpdateLabels(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLabels(new UpdateAccountLabelsRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Updates labels assigned to CSS/MC accounts by a CSS domain.
        /// </summary>
        /// <param name="name">
        /// Required. The label resource name.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> UpdateLabelsAsync(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLabelsAsync(new UpdateAccountLabelsRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Updates labels assigned to CSS/MC accounts by a CSS domain.
        /// </summary>
        /// <param name="name">
        /// Required. The label resource name.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> UpdateLabelsAsync(AccountName name, st::CancellationToken cancellationToken) =>
            UpdateLabelsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AccountsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing CSS/MC account information.
    /// </remarks>
    public sealed partial class AccountsServiceClientImpl : AccountsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListChildAccountsRequest, ListChildAccountsResponse> _callListChildAccounts;

        private readonly gaxgrpc::ApiCall<GetAccountRequest, Account> _callGetAccount;

        private readonly gaxgrpc::ApiCall<UpdateAccountLabelsRequest, Account> _callUpdateLabels;

        /// <summary>
        /// Constructs a client wrapper for the AccountsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AccountsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AccountsServiceClientImpl(AccountsService.AccountsServiceClient grpcClient, AccountsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AccountsServiceSettings effectiveSettings = settings ?? AccountsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListChildAccounts = clientHelper.BuildApiCall<ListChildAccountsRequest, ListChildAccountsResponse>("ListChildAccounts", grpcClient.ListChildAccountsAsync, grpcClient.ListChildAccounts, effectiveSettings.ListChildAccountsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListChildAccounts);
            Modify_ListChildAccountsApiCall(ref _callListChildAccounts);
            _callGetAccount = clientHelper.BuildApiCall<GetAccountRequest, Account>("GetAccount", grpcClient.GetAccountAsync, grpcClient.GetAccount, effectiveSettings.GetAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAccount);
            Modify_GetAccountApiCall(ref _callGetAccount);
            _callUpdateLabels = clientHelper.BuildApiCall<UpdateAccountLabelsRequest, Account>("UpdateLabels", grpcClient.UpdateLabelsAsync, grpcClient.UpdateLabels, effectiveSettings.UpdateLabelsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateLabels);
            Modify_UpdateLabelsApiCall(ref _callUpdateLabels);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListChildAccountsApiCall(ref gaxgrpc::ApiCall<ListChildAccountsRequest, ListChildAccountsResponse> call);

        partial void Modify_GetAccountApiCall(ref gaxgrpc::ApiCall<GetAccountRequest, Account> call);

        partial void Modify_UpdateLabelsApiCall(ref gaxgrpc::ApiCall<UpdateAccountLabelsRequest, Account> call);

        partial void OnConstruction(AccountsService.AccountsServiceClient grpcClient, AccountsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccountsService client</summary>
        public override AccountsService.AccountsServiceClient GrpcClient { get; }

        partial void Modify_ListChildAccountsRequest(ref ListChildAccountsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAccountRequest(ref GetAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAccountLabelsRequest(ref UpdateAccountLabelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all the accounts under the specified CSS account ID, and
        /// optionally filters by label ID and account name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Account"/> resources.</returns>
        public override gax::PagedEnumerable<ListChildAccountsResponse, Account> ListChildAccounts(ListChildAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChildAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListChildAccountsRequest, ListChildAccountsResponse, Account>(_callListChildAccounts, request, callSettings);
        }

        /// <summary>
        /// Lists all the accounts under the specified CSS account ID, and
        /// optionally filters by label ID and account name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Account"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListChildAccountsResponse, Account> ListChildAccountsAsync(ListChildAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChildAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListChildAccountsRequest, ListChildAccountsResponse, Account>(_callListChildAccounts, request, callSettings);
        }

        /// <summary>
        /// Retrieves a single CSS/MC account by ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Account GetAccount(GetAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountRequest(ref request, ref callSettings);
            return _callGetAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a single CSS/MC account by ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Account> GetAccountAsync(GetAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountRequest(ref request, ref callSettings);
            return _callGetAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Updates labels assigned to CSS/MC accounts by a CSS domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Account UpdateLabels(UpdateAccountLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccountLabelsRequest(ref request, ref callSettings);
            return _callUpdateLabels.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates labels assigned to CSS/MC accounts by a CSS domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Account> UpdateLabelsAsync(UpdateAccountLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccountLabelsRequest(ref request, ref callSettings);
            return _callUpdateLabels.Async(request, callSettings);
        }
    }

    public partial class ListChildAccountsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListChildAccountsResponse : gaxgrpc::IPageResponse<Account>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Account> GetEnumerator() => Accounts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
