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
    /// <summary>Settings for <see cref="AccountServicesServiceClient"/> instances.</summary>
    public sealed partial class AccountServicesServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AccountServicesServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AccountServicesServiceSettings"/>.</returns>
        public static AccountServicesServiceSettings GetDefault() => new AccountServicesServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AccountServicesServiceSettings"/> object with default settings.
        /// </summary>
        public AccountServicesServiceSettings()
        {
        }

        private AccountServicesServiceSettings(AccountServicesServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAccountServiceSettings = existing.GetAccountServiceSettings;
            ListAccountServicesSettings = existing.ListAccountServicesSettings;
            ProposeAccountServiceSettings = existing.ProposeAccountServiceSettings;
            ApproveAccountServiceSettings = existing.ApproveAccountServiceSettings;
            RejectAccountServiceSettings = existing.RejectAccountServiceSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccountServicesServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountServicesServiceClient.GetAccountService</c> and
        /// <c>AccountServicesServiceClient.GetAccountServiceAsync</c>.
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
        public gaxgrpc::CallSettings GetAccountServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountServicesServiceClient.ListAccountServices</c> and
        /// <c>AccountServicesServiceClient.ListAccountServicesAsync</c>.
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
        public gaxgrpc::CallSettings ListAccountServicesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountServicesServiceClient.ProposeAccountService</c> and
        /// <c>AccountServicesServiceClient.ProposeAccountServiceAsync</c>.
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
        public gaxgrpc::CallSettings ProposeAccountServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountServicesServiceClient.ApproveAccountService</c> and
        /// <c>AccountServicesServiceClient.ApproveAccountServiceAsync</c>.
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
        public gaxgrpc::CallSettings ApproveAccountServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountServicesServiceClient.RejectAccountService</c> and
        /// <c>AccountServicesServiceClient.RejectAccountServiceAsync</c>.
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
        public gaxgrpc::CallSettings RejectAccountServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AccountServicesServiceSettings"/> object.</returns>
        public AccountServicesServiceSettings Clone() => new AccountServicesServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AccountServicesServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AccountServicesServiceClientBuilder : gaxgrpc::ClientBuilderBase<AccountServicesServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AccountServicesServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AccountServicesServiceClientBuilder() : base(AccountServicesServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AccountServicesServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AccountServicesServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AccountServicesServiceClient Build()
        {
            AccountServicesServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AccountServicesServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AccountServicesServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AccountServicesServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AccountServicesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AccountServicesServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AccountServicesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AccountServicesServiceClient.ChannelPool;
    }

    /// <summary>AccountServicesService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to support AccountService API.
    /// </remarks>
    public abstract partial class AccountServicesServiceClient
    {
        /// <summary>
        /// The default endpoint for the AccountServicesService service, which is a host of "merchantapi.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default AccountServicesService scopes.</summary>
        /// <remarks>
        /// The default AccountServicesService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AccountServicesService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AccountServicesServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AccountServicesServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AccountServicesServiceClient"/>.</returns>
        public static stt::Task<AccountServicesServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AccountServicesServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AccountServicesServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AccountServicesServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AccountServicesServiceClient"/>.</returns>
        public static AccountServicesServiceClient Create() => new AccountServicesServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AccountServicesServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AccountServicesServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AccountServicesServiceClient"/>.</returns>
        internal static AccountServicesServiceClient Create(grpccore::CallInvoker callInvoker, AccountServicesServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccountServicesService.AccountServicesServiceClient grpcClient = new AccountServicesService.AccountServicesServiceClient(callInvoker);
            return new AccountServicesServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AccountServicesService client</summary>
        public virtual AccountServicesService.AccountServicesServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve an account service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountService GetAccountService(GetAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve an account service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> GetAccountServiceAsync(GetAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve an account service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> GetAccountServiceAsync(GetAccountServiceRequest request, st::CancellationToken cancellationToken) =>
            GetAccountServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve an account service.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to get.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountService GetAccountService(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountService(new GetAccountServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve an account service.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to get.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> GetAccountServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountServiceAsync(new GetAccountServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve an account service.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to get.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> GetAccountServiceAsync(string name, st::CancellationToken cancellationToken) =>
            GetAccountServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve an account service.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to get.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountService GetAccountService(AccountServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountService(new GetAccountServiceRequest
            {
                AccountServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve an account service.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to get.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> GetAccountServiceAsync(AccountServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountServiceAsync(new GetAccountServiceRequest
            {
                AccountServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve an account service.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to get.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> GetAccountServiceAsync(AccountServiceName name, st::CancellationToken cancellationToken) =>
            GetAccountServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List account services for the specified accounts. Supports filtering.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccountService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountServicesResponse, AccountService> ListAccountServices(ListAccountServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List account services for the specified accounts. Supports filtering.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccountService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountServicesResponse, AccountService> ListAccountServicesAsync(ListAccountServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List account services for the specified accounts. Supports filtering.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account of the account service to filter by.
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
        /// <returns>A pageable sequence of <see cref="AccountService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountServicesResponse, AccountService> ListAccountServices(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountServicesRequest request = new ListAccountServicesRequest
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
            return ListAccountServices(request, callSettings);
        }

        /// <summary>
        /// List account services for the specified accounts. Supports filtering.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account of the account service to filter by.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccountService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountServicesResponse, AccountService> ListAccountServicesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountServicesRequest request = new ListAccountServicesRequest
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
            return ListAccountServicesAsync(request, callSettings);
        }

        /// <summary>
        /// List account services for the specified accounts. Supports filtering.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account of the account service to filter by.
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
        /// <returns>A pageable sequence of <see cref="AccountService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountServicesResponse, AccountService> ListAccountServices(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountServicesRequest request = new ListAccountServicesRequest
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
            return ListAccountServices(request, callSettings);
        }

        /// <summary>
        /// List account services for the specified accounts. Supports filtering.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account of the account service to filter by.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccountService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountServicesResponse, AccountService> ListAccountServicesAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountServicesRequest request = new ListAccountServicesRequest
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
            return ListAccountServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Propose an account service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountService ProposeAccountService(ProposeAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Propose an account service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> ProposeAccountServiceAsync(ProposeAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Propose an account service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> ProposeAccountServiceAsync(ProposeAccountServiceRequest request, st::CancellationToken cancellationToken) =>
            ProposeAccountServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Propose an account service.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent account for the service.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="provider">
        /// Required. The provider of the service. Either the reference to an account
        /// such as `providers/123` or a well-known service provider (one of
        /// `providers/GOOGLE_ADS` or `providers/GOOGLE_BUSINESS_PROFILE`).
        /// </param>
        /// <param name="accountService">
        /// Required. The account service to propose.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountService ProposeAccountService(string parent, string provider, AccountService accountService, gaxgrpc::CallSettings callSettings = null) =>
            ProposeAccountService(new ProposeAccountServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Provider = gax::GaxPreconditions.CheckNotNullOrEmpty(provider, nameof(provider)),
                AccountService = gax::GaxPreconditions.CheckNotNull(accountService, nameof(accountService)),
            }, callSettings);

        /// <summary>
        /// Propose an account service.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent account for the service.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="provider">
        /// Required. The provider of the service. Either the reference to an account
        /// such as `providers/123` or a well-known service provider (one of
        /// `providers/GOOGLE_ADS` or `providers/GOOGLE_BUSINESS_PROFILE`).
        /// </param>
        /// <param name="accountService">
        /// Required. The account service to propose.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> ProposeAccountServiceAsync(string parent, string provider, AccountService accountService, gaxgrpc::CallSettings callSettings = null) =>
            ProposeAccountServiceAsync(new ProposeAccountServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Provider = gax::GaxPreconditions.CheckNotNullOrEmpty(provider, nameof(provider)),
                AccountService = gax::GaxPreconditions.CheckNotNull(accountService, nameof(accountService)),
            }, callSettings);

        /// <summary>
        /// Propose an account service.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent account for the service.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="provider">
        /// Required. The provider of the service. Either the reference to an account
        /// such as `providers/123` or a well-known service provider (one of
        /// `providers/GOOGLE_ADS` or `providers/GOOGLE_BUSINESS_PROFILE`).
        /// </param>
        /// <param name="accountService">
        /// Required. The account service to propose.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> ProposeAccountServiceAsync(string parent, string provider, AccountService accountService, st::CancellationToken cancellationToken) =>
            ProposeAccountServiceAsync(parent, provider, accountService, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Propose an account service.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent account for the service.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="provider">
        /// Required. The provider of the service. Either the reference to an account
        /// such as `providers/123` or a well-known service provider (one of
        /// `providers/GOOGLE_ADS` or `providers/GOOGLE_BUSINESS_PROFILE`).
        /// </param>
        /// <param name="accountService">
        /// Required. The account service to propose.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountService ProposeAccountService(AccountName parent, string provider, AccountService accountService, gaxgrpc::CallSettings callSettings = null) =>
            ProposeAccountService(new ProposeAccountServiceRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Provider = gax::GaxPreconditions.CheckNotNullOrEmpty(provider, nameof(provider)),
                AccountService = gax::GaxPreconditions.CheckNotNull(accountService, nameof(accountService)),
            }, callSettings);

        /// <summary>
        /// Propose an account service.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent account for the service.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="provider">
        /// Required. The provider of the service. Either the reference to an account
        /// such as `providers/123` or a well-known service provider (one of
        /// `providers/GOOGLE_ADS` or `providers/GOOGLE_BUSINESS_PROFILE`).
        /// </param>
        /// <param name="accountService">
        /// Required. The account service to propose.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> ProposeAccountServiceAsync(AccountName parent, string provider, AccountService accountService, gaxgrpc::CallSettings callSettings = null) =>
            ProposeAccountServiceAsync(new ProposeAccountServiceRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Provider = gax::GaxPreconditions.CheckNotNullOrEmpty(provider, nameof(provider)),
                AccountService = gax::GaxPreconditions.CheckNotNull(accountService, nameof(accountService)),
            }, callSettings);

        /// <summary>
        /// Propose an account service.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent account for the service.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="provider">
        /// Required. The provider of the service. Either the reference to an account
        /// such as `providers/123` or a well-known service provider (one of
        /// `providers/GOOGLE_ADS` or `providers/GOOGLE_BUSINESS_PROFILE`).
        /// </param>
        /// <param name="accountService">
        /// Required. The account service to propose.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> ProposeAccountServiceAsync(AccountName parent, string provider, AccountService accountService, st::CancellationToken cancellationToken) =>
            ProposeAccountServiceAsync(parent, provider, accountService, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approve an account service proposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountService ApproveAccountService(ApproveAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approve an account service proposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> ApproveAccountServiceAsync(ApproveAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approve an account service proposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> ApproveAccountServiceAsync(ApproveAccountServiceRequest request, st::CancellationToken cancellationToken) =>
            ApproveAccountServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approve an account service proposal.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to approve.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountService ApproveAccountService(string name, gaxgrpc::CallSettings callSettings = null) =>
            ApproveAccountService(new ApproveAccountServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Approve an account service proposal.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to approve.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> ApproveAccountServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ApproveAccountServiceAsync(new ApproveAccountServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Approve an account service proposal.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to approve.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> ApproveAccountServiceAsync(string name, st::CancellationToken cancellationToken) =>
            ApproveAccountServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approve an account service proposal.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to approve.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountService ApproveAccountService(AccountServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            ApproveAccountService(new ApproveAccountServiceRequest
            {
                AccountServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Approve an account service proposal.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to approve.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> ApproveAccountServiceAsync(AccountServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            ApproveAccountServiceAsync(new ApproveAccountServiceRequest
            {
                AccountServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Approve an account service proposal.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to approve.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountService> ApproveAccountServiceAsync(AccountServiceName name, st::CancellationToken cancellationToken) =>
            ApproveAccountServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reject an account service (both proposed and approve services can be
        /// rejected).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void RejectAccountService(RejectAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reject an account service (both proposed and approve services can be
        /// rejected).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RejectAccountServiceAsync(RejectAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reject an account service (both proposed and approve services can be
        /// rejected).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RejectAccountServiceAsync(RejectAccountServiceRequest request, st::CancellationToken cancellationToken) =>
            RejectAccountServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reject an account service (both proposed and approve services can be
        /// rejected).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to reject.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void RejectAccountService(string name, gaxgrpc::CallSettings callSettings = null) =>
            RejectAccountService(new RejectAccountServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reject an account service (both proposed and approve services can be
        /// rejected).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to reject.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RejectAccountServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RejectAccountServiceAsync(new RejectAccountServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reject an account service (both proposed and approve services can be
        /// rejected).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to reject.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RejectAccountServiceAsync(string name, st::CancellationToken cancellationToken) =>
            RejectAccountServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reject an account service (both proposed and approve services can be
        /// rejected).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to reject.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void RejectAccountService(AccountServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            RejectAccountService(new RejectAccountServiceRequest
            {
                AccountServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reject an account service (both proposed and approve services can be
        /// rejected).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to reject.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RejectAccountServiceAsync(AccountServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            RejectAccountServiceAsync(new RejectAccountServiceRequest
            {
                AccountServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reject an account service (both proposed and approve services can be
        /// rejected).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the account service to reject.
        /// Format: `accounts/{account}/services/{service}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RejectAccountServiceAsync(AccountServiceName name, st::CancellationToken cancellationToken) =>
            RejectAccountServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AccountServicesService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to support AccountService API.
    /// </remarks>
    public sealed partial class AccountServicesServiceClientImpl : AccountServicesServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAccountServiceRequest, AccountService> _callGetAccountService;

        private readonly gaxgrpc::ApiCall<ListAccountServicesRequest, ListAccountServicesResponse> _callListAccountServices;

        private readonly gaxgrpc::ApiCall<ProposeAccountServiceRequest, AccountService> _callProposeAccountService;

        private readonly gaxgrpc::ApiCall<ApproveAccountServiceRequest, AccountService> _callApproveAccountService;

        private readonly gaxgrpc::ApiCall<RejectAccountServiceRequest, wkt::Empty> _callRejectAccountService;

        /// <summary>
        /// Constructs a client wrapper for the AccountServicesService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AccountServicesServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AccountServicesServiceClientImpl(AccountServicesService.AccountServicesServiceClient grpcClient, AccountServicesServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AccountServicesServiceSettings effectiveSettings = settings ?? AccountServicesServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetAccountService = clientHelper.BuildApiCall<GetAccountServiceRequest, AccountService>("GetAccountService", grpcClient.GetAccountServiceAsync, grpcClient.GetAccountService, effectiveSettings.GetAccountServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAccountService);
            Modify_GetAccountServiceApiCall(ref _callGetAccountService);
            _callListAccountServices = clientHelper.BuildApiCall<ListAccountServicesRequest, ListAccountServicesResponse>("ListAccountServices", grpcClient.ListAccountServicesAsync, grpcClient.ListAccountServices, effectiveSettings.ListAccountServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAccountServices);
            Modify_ListAccountServicesApiCall(ref _callListAccountServices);
            _callProposeAccountService = clientHelper.BuildApiCall<ProposeAccountServiceRequest, AccountService>("ProposeAccountService", grpcClient.ProposeAccountServiceAsync, grpcClient.ProposeAccountService, effectiveSettings.ProposeAccountServiceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callProposeAccountService);
            Modify_ProposeAccountServiceApiCall(ref _callProposeAccountService);
            _callApproveAccountService = clientHelper.BuildApiCall<ApproveAccountServiceRequest, AccountService>("ApproveAccountService", grpcClient.ApproveAccountServiceAsync, grpcClient.ApproveAccountService, effectiveSettings.ApproveAccountServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callApproveAccountService);
            Modify_ApproveAccountServiceApiCall(ref _callApproveAccountService);
            _callRejectAccountService = clientHelper.BuildApiCall<RejectAccountServiceRequest, wkt::Empty>("RejectAccountService", grpcClient.RejectAccountServiceAsync, grpcClient.RejectAccountService, effectiveSettings.RejectAccountServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRejectAccountService);
            Modify_RejectAccountServiceApiCall(ref _callRejectAccountService);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAccountServiceApiCall(ref gaxgrpc::ApiCall<GetAccountServiceRequest, AccountService> call);

        partial void Modify_ListAccountServicesApiCall(ref gaxgrpc::ApiCall<ListAccountServicesRequest, ListAccountServicesResponse> call);

        partial void Modify_ProposeAccountServiceApiCall(ref gaxgrpc::ApiCall<ProposeAccountServiceRequest, AccountService> call);

        partial void Modify_ApproveAccountServiceApiCall(ref gaxgrpc::ApiCall<ApproveAccountServiceRequest, AccountService> call);

        partial void Modify_RejectAccountServiceApiCall(ref gaxgrpc::ApiCall<RejectAccountServiceRequest, wkt::Empty> call);

        partial void OnConstruction(AccountServicesService.AccountServicesServiceClient grpcClient, AccountServicesServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccountServicesService client</summary>
        public override AccountServicesService.AccountServicesServiceClient GrpcClient { get; }

        partial void Modify_GetAccountServiceRequest(ref GetAccountServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAccountServicesRequest(ref ListAccountServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ProposeAccountServiceRequest(ref ProposeAccountServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApproveAccountServiceRequest(ref ApproveAccountServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RejectAccountServiceRequest(ref RejectAccountServiceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieve an account service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccountService GetAccountService(GetAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountServiceRequest(ref request, ref callSettings);
            return _callGetAccountService.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve an account service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccountService> GetAccountServiceAsync(GetAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountServiceRequest(ref request, ref callSettings);
            return _callGetAccountService.Async(request, callSettings);
        }

        /// <summary>
        /// List account services for the specified accounts. Supports filtering.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccountService"/> resources.</returns>
        public override gax::PagedEnumerable<ListAccountServicesResponse, AccountService> ListAccountServices(ListAccountServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAccountServicesRequest, ListAccountServicesResponse, AccountService>(_callListAccountServices, request, callSettings);
        }

        /// <summary>
        /// List account services for the specified accounts. Supports filtering.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccountService"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAccountServicesResponse, AccountService> ListAccountServicesAsync(ListAccountServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAccountServicesRequest, ListAccountServicesResponse, AccountService>(_callListAccountServices, request, callSettings);
        }

        /// <summary>
        /// Propose an account service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccountService ProposeAccountService(ProposeAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProposeAccountServiceRequest(ref request, ref callSettings);
            return _callProposeAccountService.Sync(request, callSettings);
        }

        /// <summary>
        /// Propose an account service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccountService> ProposeAccountServiceAsync(ProposeAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProposeAccountServiceRequest(ref request, ref callSettings);
            return _callProposeAccountService.Async(request, callSettings);
        }

        /// <summary>
        /// Approve an account service proposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccountService ApproveAccountService(ApproveAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveAccountServiceRequest(ref request, ref callSettings);
            return _callApproveAccountService.Sync(request, callSettings);
        }

        /// <summary>
        /// Approve an account service proposal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccountService> ApproveAccountServiceAsync(ApproveAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveAccountServiceRequest(ref request, ref callSettings);
            return _callApproveAccountService.Async(request, callSettings);
        }

        /// <summary>
        /// Reject an account service (both proposed and approve services can be
        /// rejected).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void RejectAccountService(RejectAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RejectAccountServiceRequest(ref request, ref callSettings);
            _callRejectAccountService.Sync(request, callSettings);
        }

        /// <summary>
        /// Reject an account service (both proposed and approve services can be
        /// rejected).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task RejectAccountServiceAsync(RejectAccountServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RejectAccountServiceRequest(ref request, ref callSettings);
            return _callRejectAccountService.Async(request, callSettings);
        }
    }

    public partial class ListAccountServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAccountServicesResponse : gaxgrpc::IPageResponse<AccountService>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AccountService> GetEnumerator() => AccountServices.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
