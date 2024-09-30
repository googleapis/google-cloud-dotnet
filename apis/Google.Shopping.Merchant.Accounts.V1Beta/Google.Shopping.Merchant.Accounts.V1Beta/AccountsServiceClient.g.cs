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
            GetAccountSettings = existing.GetAccountSettings;
            CreateAndConfigureAccountSettings = existing.CreateAndConfigureAccountSettings;
            DeleteAccountSettings = existing.DeleteAccountSettings;
            UpdateAccountSettings = existing.UpdateAccountSettings;
            ListAccountsSettings = existing.ListAccountsSettings;
            ListSubAccountsSettings = existing.ListSubAccountsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccountsServiceSettings existing);

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
        /// <c>AccountsServiceClient.CreateAndConfigureAccount</c> and
        /// <c>AccountsServiceClient.CreateAndConfigureAccountAsync</c>.
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
        public gaxgrpc::CallSettings CreateAndConfigureAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountsServiceClient.DeleteAccount</c> and <c>AccountsServiceClient.DeleteAccountAsync</c>.
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
        public gaxgrpc::CallSettings DeleteAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountsServiceClient.UpdateAccount</c> and <c>AccountsServiceClient.UpdateAccountAsync</c>.
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
        public gaxgrpc::CallSettings UpdateAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountsServiceClient.ListAccounts</c> and <c>AccountsServiceClient.ListAccountsAsync</c>.
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
        public gaxgrpc::CallSettings ListAccountsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountsServiceClient.ListSubAccounts</c> and <c>AccountsServiceClient.ListSubAccountsAsync</c>.
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
        public gaxgrpc::CallSettings ListSubAccountsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

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
    /// Service to support Accounts API.
    /// </remarks>
    public abstract partial class AccountsServiceClient
    {
        /// <summary>
        /// The default endpoint for the AccountsService service, which is a host of "merchantapi.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

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
        /// Retrieves an account from your Merchant Center account.
        /// After inserting, updating, or deleting an account, it may take several
        /// minutes before changes take effect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account GetAccount(GetAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an account from your Merchant Center account.
        /// After inserting, updating, or deleting an account, it may take several
        /// minutes before changes take effect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(GetAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an account from your Merchant Center account.
        /// After inserting, updating, or deleting an account, it may take several
        /// minutes before changes take effect.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(GetAccountRequest request, st::CancellationToken cancellationToken) =>
            GetAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an account from your Merchant Center account.
        /// After inserting, updating, or deleting an account, it may take several
        /// minutes before changes take effect.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to retrieve.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account GetAccount(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccount(new GetAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an account from your Merchant Center account.
        /// After inserting, updating, or deleting an account, it may take several
        /// minutes before changes take effect.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to retrieve.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountAsync(new GetAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an account from your Merchant Center account.
        /// After inserting, updating, or deleting an account, it may take several
        /// minutes before changes take effect.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to retrieve.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(string name, st::CancellationToken cancellationToken) =>
            GetAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an account from your Merchant Center account.
        /// After inserting, updating, or deleting an account, it may take several
        /// minutes before changes take effect.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to retrieve.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account GetAccount(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccount(new GetAccountRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an account from your Merchant Center account.
        /// After inserting, updating, or deleting an account, it may take several
        /// minutes before changes take effect.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to retrieve.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountAsync(new GetAccountRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an account from your Merchant Center account.
        /// After inserting, updating, or deleting an account, it may take several
        /// minutes before changes take effect.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to retrieve.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> GetAccountAsync(AccountName name, st::CancellationToken cancellationToken) =>
            GetAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a standalone Merchant Center account with additional configuration.
        /// Adds the user that makes the request as an admin for the new account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account CreateAndConfigureAccount(CreateAndConfigureAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a standalone Merchant Center account with additional configuration.
        /// Adds the user that makes the request as an admin for the new account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> CreateAndConfigureAccountAsync(CreateAndConfigureAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a standalone Merchant Center account with additional configuration.
        /// Adds the user that makes the request as an admin for the new account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> CreateAndConfigureAccountAsync(CreateAndConfigureAccountRequest request, st::CancellationToken cancellationToken) =>
            CreateAndConfigureAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified account regardless of its type: standalone, MCA or
        /// sub-account. Deleting an MCA leads to the deletion of all of its
        /// sub-accounts. Executing this method requires admin access.
        /// The deletion succeeds only if the account does not provide services
        /// to any other account and has no processed offers. You can use the `force`
        /// parameter to override this.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAccount(DeleteAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified account regardless of its type: standalone, MCA or
        /// sub-account. Deleting an MCA leads to the deletion of all of its
        /// sub-accounts. Executing this method requires admin access.
        /// The deletion succeeds only if the account does not provide services
        /// to any other account and has no processed offers. You can use the `force`
        /// parameter to override this.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountAsync(DeleteAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified account regardless of its type: standalone, MCA or
        /// sub-account. Deleting an MCA leads to the deletion of all of its
        /// sub-accounts. Executing this method requires admin access.
        /// The deletion succeeds only if the account does not provide services
        /// to any other account and has no processed offers. You can use the `force`
        /// parameter to override this.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountAsync(DeleteAccountRequest request, st::CancellationToken cancellationToken) =>
            DeleteAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified account regardless of its type: standalone, MCA or
        /// sub-account. Deleting an MCA leads to the deletion of all of its
        /// sub-accounts. Executing this method requires admin access.
        /// The deletion succeeds only if the account does not provide services
        /// to any other account and has no processed offers. You can use the `force`
        /// parameter to override this.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to delete.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAccount(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccount(new DeleteAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified account regardless of its type: standalone, MCA or
        /// sub-account. Deleting an MCA leads to the deletion of all of its
        /// sub-accounts. Executing this method requires admin access.
        /// The deletion succeeds only if the account does not provide services
        /// to any other account and has no processed offers. You can use the `force`
        /// parameter to override this.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to delete.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccountAsync(new DeleteAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified account regardless of its type: standalone, MCA or
        /// sub-account. Deleting an MCA leads to the deletion of all of its
        /// sub-accounts. Executing this method requires admin access.
        /// The deletion succeeds only if the account does not provide services
        /// to any other account and has no processed offers. You can use the `force`
        /// parameter to override this.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to delete.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified account regardless of its type: standalone, MCA or
        /// sub-account. Deleting an MCA leads to the deletion of all of its
        /// sub-accounts. Executing this method requires admin access.
        /// The deletion succeeds only if the account does not provide services
        /// to any other account and has no processed offers. You can use the `force`
        /// parameter to override this.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to delete.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAccount(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccount(new DeleteAccountRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified account regardless of its type: standalone, MCA or
        /// sub-account. Deleting an MCA leads to the deletion of all of its
        /// sub-accounts. Executing this method requires admin access.
        /// The deletion succeeds only if the account does not provide services
        /// to any other account and has no processed offers. You can use the `force`
        /// parameter to override this.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to delete.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountAsync(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccountAsync(new DeleteAccountRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified account regardless of its type: standalone, MCA or
        /// sub-account. Deleting an MCA leads to the deletion of all of its
        /// sub-accounts. Executing this method requires admin access.
        /// The deletion succeeds only if the account does not provide services
        /// to any other account and has no processed offers. You can use the `force`
        /// parameter to override this.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the account to delete.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountAsync(AccountName name, st::CancellationToken cancellationToken) =>
            DeleteAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an account regardless of its type: standalone, MCA or sub-account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account UpdateAccount(UpdateAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an account regardless of its type: standalone, MCA or sub-account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> UpdateAccountAsync(UpdateAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an account regardless of its type: standalone, MCA or sub-account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> UpdateAccountAsync(UpdateAccountRequest request, st::CancellationToken cancellationToken) =>
            UpdateAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an account regardless of its type: standalone, MCA or sub-account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="account">
        /// Required. The new version of the account.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Account UpdateAccount(Account account, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccount(new UpdateAccountRequest
            {
                Account = gax::GaxPreconditions.CheckNotNull(account, nameof(account)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an account regardless of its type: standalone, MCA or sub-account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="account">
        /// Required. The new version of the account.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> UpdateAccountAsync(Account account, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccountAsync(new UpdateAccountRequest
            {
                Account = gax::GaxPreconditions.CheckNotNull(account, nameof(account)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an account regardless of its type: standalone, MCA or sub-account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="account">
        /// Required. The new version of the account.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Account> UpdateAccountAsync(Account account, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAccountAsync(account, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists accounts accessible to the calling user and matching the
        /// constraints of the request such as page size or filters.
        /// This is not just listing the sub-accounts of an MCA, but all accounts the
        /// calling user has access to including other MCAs, linked accounts,
        /// standalone accounts and so on. If no filter is provided, then it returns
        /// accounts the user is directly added to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountsResponse, Account> ListAccounts(ListAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists accounts accessible to the calling user and matching the
        /// constraints of the request such as page size or filters.
        /// This is not just listing the sub-accounts of an MCA, but all accounts the
        /// calling user has access to including other MCAs, linked accounts,
        /// standalone accounts and so on. If no filter is provided, then it returns
        /// accounts the user is directly added to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountsResponse, Account> ListAccountsAsync(ListAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all sub-accounts for a given multi client account. This is a
        /// convenience wrapper for the more powerful `ListAccounts` method. This
        /// method will produce the same results as calling `ListsAccounts` with the
        /// following filter:
        /// `relationship(providerId={parent} AND service(type="ACCOUNT_AGGREGATION"))`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubAccountsResponse, Account> ListSubAccounts(ListSubAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all sub-accounts for a given multi client account. This is a
        /// convenience wrapper for the more powerful `ListAccounts` method. This
        /// method will produce the same results as calling `ListsAccounts` with the
        /// following filter:
        /// `relationship(providerId={parent} AND service(type="ACCOUNT_AGGREGATION"))`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubAccountsResponse, Account> ListSubAccountsAsync(ListSubAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all sub-accounts for a given multi client account. This is a
        /// convenience wrapper for the more powerful `ListAccounts` method. This
        /// method will produce the same results as calling `ListsAccounts` with the
        /// following filter:
        /// `relationship(providerId={parent} AND service(type="ACCOUNT_AGGREGATION"))`
        /// </summary>
        /// <param name="provider">
        /// Required. The parent account.
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
        /// <returns>A pageable sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubAccountsResponse, Account> ListSubAccounts(string provider, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubAccountsRequest request = new ListSubAccountsRequest
            {
                Provider = gax::GaxPreconditions.CheckNotNullOrEmpty(provider, nameof(provider)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSubAccounts(request, callSettings);
        }

        /// <summary>
        /// List all sub-accounts for a given multi client account. This is a
        /// convenience wrapper for the more powerful `ListAccounts` method. This
        /// method will produce the same results as calling `ListsAccounts` with the
        /// following filter:
        /// `relationship(providerId={parent} AND service(type="ACCOUNT_AGGREGATION"))`
        /// </summary>
        /// <param name="provider">
        /// Required. The parent account.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubAccountsResponse, Account> ListSubAccountsAsync(string provider, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubAccountsRequest request = new ListSubAccountsRequest
            {
                Provider = gax::GaxPreconditions.CheckNotNullOrEmpty(provider, nameof(provider)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSubAccountsAsync(request, callSettings);
        }

        /// <summary>
        /// List all sub-accounts for a given multi client account. This is a
        /// convenience wrapper for the more powerful `ListAccounts` method. This
        /// method will produce the same results as calling `ListsAccounts` with the
        /// following filter:
        /// `relationship(providerId={parent} AND service(type="ACCOUNT_AGGREGATION"))`
        /// </summary>
        /// <param name="provider">
        /// Required. The parent account.
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
        /// <returns>A pageable sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubAccountsResponse, Account> ListSubAccounts(AccountName provider, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubAccountsRequest request = new ListSubAccountsRequest
            {
                ProviderAsAccountName = gax::GaxPreconditions.CheckNotNull(provider, nameof(provider)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSubAccounts(request, callSettings);
        }

        /// <summary>
        /// List all sub-accounts for a given multi client account. This is a
        /// convenience wrapper for the more powerful `ListAccounts` method. This
        /// method will produce the same results as calling `ListsAccounts` with the
        /// following filter:
        /// `relationship(providerId={parent} AND service(type="ACCOUNT_AGGREGATION"))`
        /// </summary>
        /// <param name="provider">
        /// Required. The parent account.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Account"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubAccountsResponse, Account> ListSubAccountsAsync(AccountName provider, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubAccountsRequest request = new ListSubAccountsRequest
            {
                ProviderAsAccountName = gax::GaxPreconditions.CheckNotNull(provider, nameof(provider)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSubAccountsAsync(request, callSettings);
        }
    }

    /// <summary>AccountsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to support Accounts API.
    /// </remarks>
    public sealed partial class AccountsServiceClientImpl : AccountsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAccountRequest, Account> _callGetAccount;

        private readonly gaxgrpc::ApiCall<CreateAndConfigureAccountRequest, Account> _callCreateAndConfigureAccount;

        private readonly gaxgrpc::ApiCall<DeleteAccountRequest, wkt::Empty> _callDeleteAccount;

        private readonly gaxgrpc::ApiCall<UpdateAccountRequest, Account> _callUpdateAccount;

        private readonly gaxgrpc::ApiCall<ListAccountsRequest, ListAccountsResponse> _callListAccounts;

        private readonly gaxgrpc::ApiCall<ListSubAccountsRequest, ListSubAccountsResponse> _callListSubAccounts;

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
            _callGetAccount = clientHelper.BuildApiCall<GetAccountRequest, Account>("GetAccount", grpcClient.GetAccountAsync, grpcClient.GetAccount, effectiveSettings.GetAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAccount);
            Modify_GetAccountApiCall(ref _callGetAccount);
            _callCreateAndConfigureAccount = clientHelper.BuildApiCall<CreateAndConfigureAccountRequest, Account>("CreateAndConfigureAccount", grpcClient.CreateAndConfigureAccountAsync, grpcClient.CreateAndConfigureAccount, effectiveSettings.CreateAndConfigureAccountSettings);
            Modify_ApiCall(ref _callCreateAndConfigureAccount);
            Modify_CreateAndConfigureAccountApiCall(ref _callCreateAndConfigureAccount);
            _callDeleteAccount = clientHelper.BuildApiCall<DeleteAccountRequest, wkt::Empty>("DeleteAccount", grpcClient.DeleteAccountAsync, grpcClient.DeleteAccount, effectiveSettings.DeleteAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAccount);
            Modify_DeleteAccountApiCall(ref _callDeleteAccount);
            _callUpdateAccount = clientHelper.BuildApiCall<UpdateAccountRequest, Account>("UpdateAccount", grpcClient.UpdateAccountAsync, grpcClient.UpdateAccount, effectiveSettings.UpdateAccountSettings).WithGoogleRequestParam("account.name", request => request.Account?.Name);
            Modify_ApiCall(ref _callUpdateAccount);
            Modify_UpdateAccountApiCall(ref _callUpdateAccount);
            _callListAccounts = clientHelper.BuildApiCall<ListAccountsRequest, ListAccountsResponse>("ListAccounts", grpcClient.ListAccountsAsync, grpcClient.ListAccounts, effectiveSettings.ListAccountsSettings);
            Modify_ApiCall(ref _callListAccounts);
            Modify_ListAccountsApiCall(ref _callListAccounts);
            _callListSubAccounts = clientHelper.BuildApiCall<ListSubAccountsRequest, ListSubAccountsResponse>("ListSubAccounts", grpcClient.ListSubAccountsAsync, grpcClient.ListSubAccounts, effectiveSettings.ListSubAccountsSettings).WithGoogleRequestParam("provider", request => request.Provider);
            Modify_ApiCall(ref _callListSubAccounts);
            Modify_ListSubAccountsApiCall(ref _callListSubAccounts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAccountApiCall(ref gaxgrpc::ApiCall<GetAccountRequest, Account> call);

        partial void Modify_CreateAndConfigureAccountApiCall(ref gaxgrpc::ApiCall<CreateAndConfigureAccountRequest, Account> call);

        partial void Modify_DeleteAccountApiCall(ref gaxgrpc::ApiCall<DeleteAccountRequest, wkt::Empty> call);

        partial void Modify_UpdateAccountApiCall(ref gaxgrpc::ApiCall<UpdateAccountRequest, Account> call);

        partial void Modify_ListAccountsApiCall(ref gaxgrpc::ApiCall<ListAccountsRequest, ListAccountsResponse> call);

        partial void Modify_ListSubAccountsApiCall(ref gaxgrpc::ApiCall<ListSubAccountsRequest, ListSubAccountsResponse> call);

        partial void OnConstruction(AccountsService.AccountsServiceClient grpcClient, AccountsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccountsService client</summary>
        public override AccountsService.AccountsServiceClient GrpcClient { get; }

        partial void Modify_GetAccountRequest(ref GetAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAndConfigureAccountRequest(ref CreateAndConfigureAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAccountRequest(ref DeleteAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAccountRequest(ref UpdateAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAccountsRequest(ref ListAccountsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSubAccountsRequest(ref ListSubAccountsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves an account from your Merchant Center account.
        /// After inserting, updating, or deleting an account, it may take several
        /// minutes before changes take effect.
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
        /// Retrieves an account from your Merchant Center account.
        /// After inserting, updating, or deleting an account, it may take several
        /// minutes before changes take effect.
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
        /// Creates a standalone Merchant Center account with additional configuration.
        /// Adds the user that makes the request as an admin for the new account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Account CreateAndConfigureAccount(CreateAndConfigureAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAndConfigureAccountRequest(ref request, ref callSettings);
            return _callCreateAndConfigureAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a standalone Merchant Center account with additional configuration.
        /// Adds the user that makes the request as an admin for the new account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Account> CreateAndConfigureAccountAsync(CreateAndConfigureAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAndConfigureAccountRequest(ref request, ref callSettings);
            return _callCreateAndConfigureAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified account regardless of its type: standalone, MCA or
        /// sub-account. Deleting an MCA leads to the deletion of all of its
        /// sub-accounts. Executing this method requires admin access.
        /// The deletion succeeds only if the account does not provide services
        /// to any other account and has no processed offers. You can use the `force`
        /// parameter to override this.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAccount(DeleteAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccountRequest(ref request, ref callSettings);
            _callDeleteAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified account regardless of its type: standalone, MCA or
        /// sub-account. Deleting an MCA leads to the deletion of all of its
        /// sub-accounts. Executing this method requires admin access.
        /// The deletion succeeds only if the account does not provide services
        /// to any other account and has no processed offers. You can use the `force`
        /// parameter to override this.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAccountAsync(DeleteAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccountRequest(ref request, ref callSettings);
            return _callDeleteAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an account regardless of its type: standalone, MCA or sub-account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Account UpdateAccount(UpdateAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccountRequest(ref request, ref callSettings);
            return _callUpdateAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an account regardless of its type: standalone, MCA or sub-account.
        /// Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Account> UpdateAccountAsync(UpdateAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccountRequest(ref request, ref callSettings);
            return _callUpdateAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Lists accounts accessible to the calling user and matching the
        /// constraints of the request such as page size or filters.
        /// This is not just listing the sub-accounts of an MCA, but all accounts the
        /// calling user has access to including other MCAs, linked accounts,
        /// standalone accounts and so on. If no filter is provided, then it returns
        /// accounts the user is directly added to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Account"/> resources.</returns>
        public override gax::PagedEnumerable<ListAccountsResponse, Account> ListAccounts(ListAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAccountsRequest, ListAccountsResponse, Account>(_callListAccounts, request, callSettings);
        }

        /// <summary>
        /// Lists accounts accessible to the calling user and matching the
        /// constraints of the request such as page size or filters.
        /// This is not just listing the sub-accounts of an MCA, but all accounts the
        /// calling user has access to including other MCAs, linked accounts,
        /// standalone accounts and so on. If no filter is provided, then it returns
        /// accounts the user is directly added to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Account"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAccountsResponse, Account> ListAccountsAsync(ListAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAccountsRequest, ListAccountsResponse, Account>(_callListAccounts, request, callSettings);
        }

        /// <summary>
        /// List all sub-accounts for a given multi client account. This is a
        /// convenience wrapper for the more powerful `ListAccounts` method. This
        /// method will produce the same results as calling `ListsAccounts` with the
        /// following filter:
        /// `relationship(providerId={parent} AND service(type="ACCOUNT_AGGREGATION"))`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Account"/> resources.</returns>
        public override gax::PagedEnumerable<ListSubAccountsResponse, Account> ListSubAccounts(ListSubAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSubAccountsRequest, ListSubAccountsResponse, Account>(_callListSubAccounts, request, callSettings);
        }

        /// <summary>
        /// List all sub-accounts for a given multi client account. This is a
        /// convenience wrapper for the more powerful `ListAccounts` method. This
        /// method will produce the same results as calling `ListsAccounts` with the
        /// following filter:
        /// `relationship(providerId={parent} AND service(type="ACCOUNT_AGGREGATION"))`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Account"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSubAccountsResponse, Account> ListSubAccountsAsync(ListSubAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSubAccountsRequest, ListSubAccountsResponse, Account>(_callListSubAccounts, request, callSettings);
        }
    }

    public partial class ListAccountsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSubAccountsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAccountsResponse : gaxgrpc::IPageResponse<Account>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Account> GetEnumerator() => Accounts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSubAccountsResponse : gaxgrpc::IPageResponse<Account>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Account> GetEnumerator() => Accounts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
