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

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Settings for <see cref="AccountTaxServiceClient"/> instances.</summary>
    public sealed partial class AccountTaxServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AccountTaxServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AccountTaxServiceSettings"/>.</returns>
        public static AccountTaxServiceSettings GetDefault() => new AccountTaxServiceSettings();

        /// <summary>Constructs a new <see cref="AccountTaxServiceSettings"/> object with default settings.</summary>
        public AccountTaxServiceSettings()
        {
        }

        private AccountTaxServiceSettings(AccountTaxServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAccountTaxSettings = existing.GetAccountTaxSettings;
            ListAccountTaxSettings = existing.ListAccountTaxSettings;
            UpdateAccountTaxSettings = existing.UpdateAccountTaxSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccountTaxServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountTaxServiceClient.GetAccountTax</c> and <c>AccountTaxServiceClient.GetAccountTaxAsync</c>.
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
        public gaxgrpc::CallSettings GetAccountTaxSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountTaxServiceClient.ListAccountTax</c> and <c>AccountTaxServiceClient.ListAccountTaxAsync</c>.
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
        public gaxgrpc::CallSettings ListAccountTaxSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountTaxServiceClient.UpdateAccountTax</c> and <c>AccountTaxServiceClient.UpdateAccountTaxAsync</c>.
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
        public gaxgrpc::CallSettings UpdateAccountTaxSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AccountTaxServiceSettings"/> object.</returns>
        public AccountTaxServiceSettings Clone() => new AccountTaxServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AccountTaxServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AccountTaxServiceClientBuilder : gaxgrpc::ClientBuilderBase<AccountTaxServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AccountTaxServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AccountTaxServiceClientBuilder() : base(AccountTaxServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AccountTaxServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AccountTaxServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AccountTaxServiceClient Build()
        {
            AccountTaxServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AccountTaxServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AccountTaxServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AccountTaxServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AccountTaxServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AccountTaxServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AccountTaxServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AccountTaxServiceClient.ChannelPool;
    }

    /// <summary>AccountTaxService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages account level tax setting data.
    /// 
    /// This API defines the following resource model:
    /// 
    /// - [AccountTax][google.shopping.merchant.accounts.v1main.AccountTax]
    /// </remarks>
    public abstract partial class AccountTaxServiceClient
    {
        /// <summary>
        /// The default endpoint for the AccountTaxService service, which is a host of "merchantapi.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default AccountTaxService scopes.</summary>
        /// <remarks>
        /// The default AccountTaxService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AccountTaxService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AccountTaxServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AccountTaxServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AccountTaxServiceClient"/>.</returns>
        public static stt::Task<AccountTaxServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AccountTaxServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AccountTaxServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AccountTaxServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AccountTaxServiceClient"/>.</returns>
        public static AccountTaxServiceClient Create() => new AccountTaxServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AccountTaxServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AccountTaxServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AccountTaxServiceClient"/>.</returns>
        internal static AccountTaxServiceClient Create(grpccore::CallInvoker callInvoker, AccountTaxServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccountTaxService.AccountTaxServiceClient grpcClient = new AccountTaxService.AccountTaxServiceClient(callInvoker);
            return new AccountTaxServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AccountTaxService client</summary>
        public virtual AccountTaxService.AccountTaxServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the tax rules that match the conditions of GetAccountTaxRequest
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountTax GetAccountTax(GetAccountTaxRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the tax rules that match the conditions of GetAccountTaxRequest
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountTax> GetAccountTaxAsync(GetAccountTaxRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the tax rules that match the conditions of GetAccountTaxRequest
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountTax> GetAccountTaxAsync(GetAccountTaxRequest request, st::CancellationToken cancellationToken) =>
            GetAccountTaxAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the tax rules that match the conditions of GetAccountTaxRequest
        /// </summary>
        /// <param name="name">
        /// Required. The name from which tax settings will be retrieved
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountTax GetAccountTax(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountTax(new GetAccountTaxRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the tax rules that match the conditions of GetAccountTaxRequest
        /// </summary>
        /// <param name="name">
        /// Required. The name from which tax settings will be retrieved
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountTax> GetAccountTaxAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountTaxAsync(new GetAccountTaxRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the tax rules that match the conditions of GetAccountTaxRequest
        /// </summary>
        /// <param name="name">
        /// Required. The name from which tax settings will be retrieved
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountTax> GetAccountTaxAsync(string name, st::CancellationToken cancellationToken) =>
            GetAccountTaxAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the tax rules that match the conditions of GetAccountTaxRequest
        /// </summary>
        /// <param name="name">
        /// Required. The name from which tax settings will be retrieved
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountTax GetAccountTax(AccountTaxName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountTax(new GetAccountTaxRequest
            {
                AccountTaxName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the tax rules that match the conditions of GetAccountTaxRequest
        /// </summary>
        /// <param name="name">
        /// Required. The name from which tax settings will be retrieved
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountTax> GetAccountTaxAsync(AccountTaxName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountTaxAsync(new GetAccountTaxRequest
            {
                AccountTaxName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the tax rules that match the conditions of GetAccountTaxRequest
        /// </summary>
        /// <param name="name">
        /// Required. The name from which tax settings will be retrieved
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountTax> GetAccountTaxAsync(AccountTaxName name, st::CancellationToken cancellationToken) =>
            GetAccountTaxAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the tax settings of the sub-accounts only in your
        /// Merchant Center account.
        /// This method can only be called on a multi-client account, otherwise it'll
        /// return an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccountTax"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountTaxResponse, AccountTax> ListAccountTax(ListAccountTaxRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the tax settings of the sub-accounts only in your
        /// Merchant Center account.
        /// This method can only be called on a multi-client account, otherwise it'll
        /// return an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccountTax"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountTaxResponse, AccountTax> ListAccountTaxAsync(ListAccountTaxRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the tax settings of the sub-accounts only in your
        /// Merchant Center account.
        /// This method can only be called on a multi-client account, otherwise it'll
        /// return an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of account tax.
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
        /// <returns>A pageable sequence of <see cref="AccountTax"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountTaxResponse, AccountTax> ListAccountTax(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountTaxRequest request = new ListAccountTaxRequest
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
            return ListAccountTax(request, callSettings);
        }

        /// <summary>
        /// Lists the tax settings of the sub-accounts only in your
        /// Merchant Center account.
        /// This method can only be called on a multi-client account, otherwise it'll
        /// return an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of account tax.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccountTax"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountTaxResponse, AccountTax> ListAccountTaxAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountTaxRequest request = new ListAccountTaxRequest
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
            return ListAccountTaxAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the tax settings of the sub-accounts only in your
        /// Merchant Center account.
        /// This method can only be called on a multi-client account, otherwise it'll
        /// return an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of account tax.
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
        /// <returns>A pageable sequence of <see cref="AccountTax"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountTaxResponse, AccountTax> ListAccountTax(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountTaxRequest request = new ListAccountTaxRequest
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
            return ListAccountTax(request, callSettings);
        }

        /// <summary>
        /// Lists the tax settings of the sub-accounts only in your
        /// Merchant Center account.
        /// This method can only be called on a multi-client account, otherwise it'll
        /// return an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of account tax.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccountTax"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountTaxResponse, AccountTax> ListAccountTaxAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountTaxRequest request = new ListAccountTaxRequest
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
            return ListAccountTaxAsync(request, callSettings);
        }

        /// <summary>
        /// Updates the tax settings of the account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountTax UpdateAccountTax(UpdateAccountTaxRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the tax settings of the account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountTax> UpdateAccountTaxAsync(UpdateAccountTaxRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the tax settings of the account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountTax> UpdateAccountTaxAsync(UpdateAccountTaxRequest request, st::CancellationToken cancellationToken) =>
            UpdateAccountTaxAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the tax settings of the account.
        /// </summary>
        /// <param name="accountTax">
        /// Required. The tax setting that will be updated
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountTax UpdateAccountTax(AccountTax accountTax, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccountTax(new UpdateAccountTaxRequest
            {
                AccountTax = gax::GaxPreconditions.CheckNotNull(accountTax, nameof(accountTax)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the tax settings of the account.
        /// </summary>
        /// <param name="accountTax">
        /// Required. The tax setting that will be updated
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountTax> UpdateAccountTaxAsync(AccountTax accountTax, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccountTaxAsync(new UpdateAccountTaxRequest
            {
                AccountTax = gax::GaxPreconditions.CheckNotNull(accountTax, nameof(accountTax)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the tax settings of the account.
        /// </summary>
        /// <param name="accountTax">
        /// Required. The tax setting that will be updated
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountTax> UpdateAccountTaxAsync(AccountTax accountTax, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAccountTaxAsync(accountTax, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the tax settings of the account.
        /// </summary>
        /// <param name="accountTax">
        /// Required. The tax setting that will be updated
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountTax UpdateAccountTax(AccountTax accountTax, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccountTax(new UpdateAccountTaxRequest
            {
                AccountTax = gax::GaxPreconditions.CheckNotNull(accountTax, nameof(accountTax)),
            }, callSettings);

        /// <summary>
        /// Updates the tax settings of the account.
        /// </summary>
        /// <param name="accountTax">
        /// Required. The tax setting that will be updated
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountTax> UpdateAccountTaxAsync(AccountTax accountTax, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccountTaxAsync(new UpdateAccountTaxRequest
            {
                AccountTax = gax::GaxPreconditions.CheckNotNull(accountTax, nameof(accountTax)),
            }, callSettings);

        /// <summary>
        /// Updates the tax settings of the account.
        /// </summary>
        /// <param name="accountTax">
        /// Required. The tax setting that will be updated
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountTax> UpdateAccountTaxAsync(AccountTax accountTax, st::CancellationToken cancellationToken) =>
            UpdateAccountTaxAsync(accountTax, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AccountTaxService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages account level tax setting data.
    /// 
    /// This API defines the following resource model:
    /// 
    /// - [AccountTax][google.shopping.merchant.accounts.v1main.AccountTax]
    /// </remarks>
    public sealed partial class AccountTaxServiceClientImpl : AccountTaxServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAccountTaxRequest, AccountTax> _callGetAccountTax;

        private readonly gaxgrpc::ApiCall<ListAccountTaxRequest, ListAccountTaxResponse> _callListAccountTax;

        private readonly gaxgrpc::ApiCall<UpdateAccountTaxRequest, AccountTax> _callUpdateAccountTax;

        /// <summary>
        /// Constructs a client wrapper for the AccountTaxService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AccountTaxServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AccountTaxServiceClientImpl(AccountTaxService.AccountTaxServiceClient grpcClient, AccountTaxServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AccountTaxServiceSettings effectiveSettings = settings ?? AccountTaxServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetAccountTax = clientHelper.BuildApiCall<GetAccountTaxRequest, AccountTax>("GetAccountTax", grpcClient.GetAccountTaxAsync, grpcClient.GetAccountTax, effectiveSettings.GetAccountTaxSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAccountTax);
            Modify_GetAccountTaxApiCall(ref _callGetAccountTax);
            _callListAccountTax = clientHelper.BuildApiCall<ListAccountTaxRequest, ListAccountTaxResponse>("ListAccountTax", grpcClient.ListAccountTaxAsync, grpcClient.ListAccountTax, effectiveSettings.ListAccountTaxSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAccountTax);
            Modify_ListAccountTaxApiCall(ref _callListAccountTax);
            _callUpdateAccountTax = clientHelper.BuildApiCall<UpdateAccountTaxRequest, AccountTax>("UpdateAccountTax", grpcClient.UpdateAccountTaxAsync, grpcClient.UpdateAccountTax, effectiveSettings.UpdateAccountTaxSettings).WithGoogleRequestParam("account_tax.name", request => request.AccountTax?.Name);
            Modify_ApiCall(ref _callUpdateAccountTax);
            Modify_UpdateAccountTaxApiCall(ref _callUpdateAccountTax);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAccountTaxApiCall(ref gaxgrpc::ApiCall<GetAccountTaxRequest, AccountTax> call);

        partial void Modify_ListAccountTaxApiCall(ref gaxgrpc::ApiCall<ListAccountTaxRequest, ListAccountTaxResponse> call);

        partial void Modify_UpdateAccountTaxApiCall(ref gaxgrpc::ApiCall<UpdateAccountTaxRequest, AccountTax> call);

        partial void OnConstruction(AccountTaxService.AccountTaxServiceClient grpcClient, AccountTaxServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccountTaxService client</summary>
        public override AccountTaxService.AccountTaxServiceClient GrpcClient { get; }

        partial void Modify_GetAccountTaxRequest(ref GetAccountTaxRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAccountTaxRequest(ref ListAccountTaxRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAccountTaxRequest(ref UpdateAccountTaxRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the tax rules that match the conditions of GetAccountTaxRequest
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccountTax GetAccountTax(GetAccountTaxRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountTaxRequest(ref request, ref callSettings);
            return _callGetAccountTax.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the tax rules that match the conditions of GetAccountTaxRequest
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccountTax> GetAccountTaxAsync(GetAccountTaxRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountTaxRequest(ref request, ref callSettings);
            return _callGetAccountTax.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the tax settings of the sub-accounts only in your
        /// Merchant Center account.
        /// This method can only be called on a multi-client account, otherwise it'll
        /// return an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccountTax"/> resources.</returns>
        public override gax::PagedEnumerable<ListAccountTaxResponse, AccountTax> ListAccountTax(ListAccountTaxRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountTaxRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAccountTaxRequest, ListAccountTaxResponse, AccountTax>(_callListAccountTax, request, callSettings);
        }

        /// <summary>
        /// Lists the tax settings of the sub-accounts only in your
        /// Merchant Center account.
        /// This method can only be called on a multi-client account, otherwise it'll
        /// return an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccountTax"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAccountTaxResponse, AccountTax> ListAccountTaxAsync(ListAccountTaxRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountTaxRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAccountTaxRequest, ListAccountTaxResponse, AccountTax>(_callListAccountTax, request, callSettings);
        }

        /// <summary>
        /// Updates the tax settings of the account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccountTax UpdateAccountTax(UpdateAccountTaxRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccountTaxRequest(ref request, ref callSettings);
            return _callUpdateAccountTax.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the tax settings of the account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccountTax> UpdateAccountTaxAsync(UpdateAccountTaxRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccountTaxRequest(ref request, ref callSettings);
            return _callUpdateAccountTax.Async(request, callSettings);
        }
    }

    public partial class ListAccountTaxRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAccountTaxResponse : gaxgrpc::IPageResponse<AccountTax>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AccountTax> GetEnumerator() => AccountTaxes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
