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

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Settings for <see cref="GbpAccountsServiceClient"/> instances.</summary>
    public sealed partial class GbpAccountsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GbpAccountsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GbpAccountsServiceSettings"/>.</returns>
        public static GbpAccountsServiceSettings GetDefault() => new GbpAccountsServiceSettings();

        /// <summary>Constructs a new <see cref="GbpAccountsServiceSettings"/> object with default settings.</summary>
        public GbpAccountsServiceSettings()
        {
        }

        private GbpAccountsServiceSettings(GbpAccountsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListGbpAccountsSettings = existing.ListGbpAccountsSettings;
            LinkGbpAccountSettings = existing.LinkGbpAccountSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GbpAccountsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GbpAccountsServiceClient.ListGbpAccounts</c> and <c>GbpAccountsServiceClient.ListGbpAccountsAsync</c>.
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
        public gaxgrpc::CallSettings ListGbpAccountsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GbpAccountsServiceClient.LinkGbpAccount</c> and <c>GbpAccountsServiceClient.LinkGbpAccountAsync</c>.
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
        public gaxgrpc::CallSettings LinkGbpAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GbpAccountsServiceSettings"/> object.</returns>
        public GbpAccountsServiceSettings Clone() => new GbpAccountsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GbpAccountsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class GbpAccountsServiceClientBuilder : gaxgrpc::ClientBuilderBase<GbpAccountsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GbpAccountsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GbpAccountsServiceClientBuilder() : base(GbpAccountsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GbpAccountsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GbpAccountsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GbpAccountsServiceClient Build()
        {
            GbpAccountsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GbpAccountsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GbpAccountsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GbpAccountsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GbpAccountsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GbpAccountsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GbpAccountsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GbpAccountsServiceClient.ChannelPool;
    }

    /// <summary>GbpAccountsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service facilitates the management of a merchant's Google Business
    /// Profile (GBP) account settings. This API defines the following resource
    /// model:
    /// - [GbpAccount][google.shopping.merchant.accounts.v1.GbpAccount]
    /// </remarks>
    public abstract partial class GbpAccountsServiceClient
    {
        /// <summary>
        /// The default endpoint for the GbpAccountsService service, which is a host of "merchantapi.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default GbpAccountsService scopes.</summary>
        /// <remarks>
        /// The default GbpAccountsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GbpAccountsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GbpAccountsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GbpAccountsServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GbpAccountsServiceClient"/>.</returns>
        public static stt::Task<GbpAccountsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GbpAccountsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GbpAccountsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GbpAccountsServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="GbpAccountsServiceClient"/>.</returns>
        public static GbpAccountsServiceClient Create() => new GbpAccountsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GbpAccountsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GbpAccountsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GbpAccountsServiceClient"/>.</returns>
        internal static GbpAccountsServiceClient Create(grpccore::CallInvoker callInvoker, GbpAccountsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GbpAccountsService.GbpAccountsServiceClient grpcClient = new GbpAccountsService.GbpAccountsServiceClient(callInvoker);
            return new GbpAccountsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GbpAccountsService client</summary>
        public virtual GbpAccountsService.GbpAccountsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// List the GBP accounts for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GbpAccount"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGbpAccountsResponse, GbpAccount> ListGbpAccounts(ListGbpAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the GBP accounts for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GbpAccount"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGbpAccountsResponse, GbpAccount> ListGbpAccountsAsync(ListGbpAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the GBP accounts for a given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource under which the GBP accounts are
        /// listed. Format: `accounts/{account}`.
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
        /// <returns>A pageable sequence of <see cref="GbpAccount"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGbpAccountsResponse, GbpAccount> ListGbpAccounts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGbpAccountsRequest request = new ListGbpAccountsRequest
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
            return ListGbpAccounts(request, callSettings);
        }

        /// <summary>
        /// List the GBP accounts for a given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource under which the GBP accounts are
        /// listed. Format: `accounts/{account}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GbpAccount"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGbpAccountsResponse, GbpAccount> ListGbpAccountsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGbpAccountsRequest request = new ListGbpAccountsRequest
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
            return ListGbpAccountsAsync(request, callSettings);
        }

        /// <summary>
        /// List the GBP accounts for a given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource under which the GBP accounts are
        /// listed. Format: `accounts/{account}`.
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
        /// <returns>A pageable sequence of <see cref="GbpAccount"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGbpAccountsResponse, GbpAccount> ListGbpAccounts(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGbpAccountsRequest request = new ListGbpAccountsRequest
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
            return ListGbpAccounts(request, callSettings);
        }

        /// <summary>
        /// List the GBP accounts for a given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource under which the GBP accounts are
        /// listed. Format: `accounts/{account}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GbpAccount"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGbpAccountsResponse, GbpAccount> ListGbpAccountsAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGbpAccountsRequest request = new ListGbpAccountsRequest
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
            return ListGbpAccountsAsync(request, callSettings);
        }

        /// <summary>
        /// Link the specified merchant to a GBP account for all countries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LinkGbpAccountResponse LinkGbpAccount(LinkGbpAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Link the specified merchant to a GBP account for all countries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LinkGbpAccountResponse> LinkGbpAccountAsync(LinkGbpAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Link the specified merchant to a GBP account for all countries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LinkGbpAccountResponse> LinkGbpAccountAsync(LinkGbpAccountRequest request, st::CancellationToken cancellationToken) =>
            LinkGbpAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Link the specified merchant to a GBP account for all countries.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource to which the GBP account is
        /// linked. Format: `accounts/{account}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LinkGbpAccountResponse LinkGbpAccount(string parent, gaxgrpc::CallSettings callSettings = null) =>
            LinkGbpAccount(new LinkGbpAccountRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Link the specified merchant to a GBP account for all countries.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource to which the GBP account is
        /// linked. Format: `accounts/{account}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LinkGbpAccountResponse> LinkGbpAccountAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            LinkGbpAccountAsync(new LinkGbpAccountRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Link the specified merchant to a GBP account for all countries.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource to which the GBP account is
        /// linked. Format: `accounts/{account}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LinkGbpAccountResponse> LinkGbpAccountAsync(string parent, st::CancellationToken cancellationToken) =>
            LinkGbpAccountAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Link the specified merchant to a GBP account for all countries.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource to which the GBP account is
        /// linked. Format: `accounts/{account}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LinkGbpAccountResponse LinkGbpAccount(AccountName parent, gaxgrpc::CallSettings callSettings = null) =>
            LinkGbpAccount(new LinkGbpAccountRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Link the specified merchant to a GBP account for all countries.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource to which the GBP account is
        /// linked. Format: `accounts/{account}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LinkGbpAccountResponse> LinkGbpAccountAsync(AccountName parent, gaxgrpc::CallSettings callSettings = null) =>
            LinkGbpAccountAsync(new LinkGbpAccountRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Link the specified merchant to a GBP account for all countries.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource to which the GBP account is
        /// linked. Format: `accounts/{account}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LinkGbpAccountResponse> LinkGbpAccountAsync(AccountName parent, st::CancellationToken cancellationToken) =>
            LinkGbpAccountAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GbpAccountsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service facilitates the management of a merchant's Google Business
    /// Profile (GBP) account settings. This API defines the following resource
    /// model:
    /// - [GbpAccount][google.shopping.merchant.accounts.v1.GbpAccount]
    /// </remarks>
    public sealed partial class GbpAccountsServiceClientImpl : GbpAccountsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListGbpAccountsRequest, ListGbpAccountsResponse> _callListGbpAccounts;

        private readonly gaxgrpc::ApiCall<LinkGbpAccountRequest, LinkGbpAccountResponse> _callLinkGbpAccount;

        /// <summary>
        /// Constructs a client wrapper for the GbpAccountsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GbpAccountsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GbpAccountsServiceClientImpl(GbpAccountsService.GbpAccountsServiceClient grpcClient, GbpAccountsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GbpAccountsServiceSettings effectiveSettings = settings ?? GbpAccountsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListGbpAccounts = clientHelper.BuildApiCall<ListGbpAccountsRequest, ListGbpAccountsResponse>("ListGbpAccounts", grpcClient.ListGbpAccountsAsync, grpcClient.ListGbpAccounts, effectiveSettings.ListGbpAccountsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGbpAccounts);
            Modify_ListGbpAccountsApiCall(ref _callListGbpAccounts);
            _callLinkGbpAccount = clientHelper.BuildApiCall<LinkGbpAccountRequest, LinkGbpAccountResponse>("LinkGbpAccount", grpcClient.LinkGbpAccountAsync, grpcClient.LinkGbpAccount, effectiveSettings.LinkGbpAccountSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callLinkGbpAccount);
            Modify_LinkGbpAccountApiCall(ref _callLinkGbpAccount);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListGbpAccountsApiCall(ref gaxgrpc::ApiCall<ListGbpAccountsRequest, ListGbpAccountsResponse> call);

        partial void Modify_LinkGbpAccountApiCall(ref gaxgrpc::ApiCall<LinkGbpAccountRequest, LinkGbpAccountResponse> call);

        partial void OnConstruction(GbpAccountsService.GbpAccountsServiceClient grpcClient, GbpAccountsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GbpAccountsService client</summary>
        public override GbpAccountsService.GbpAccountsServiceClient GrpcClient { get; }

        partial void Modify_ListGbpAccountsRequest(ref ListGbpAccountsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LinkGbpAccountRequest(ref LinkGbpAccountRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// List the GBP accounts for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GbpAccount"/> resources.</returns>
        public override gax::PagedEnumerable<ListGbpAccountsResponse, GbpAccount> ListGbpAccounts(ListGbpAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGbpAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGbpAccountsRequest, ListGbpAccountsResponse, GbpAccount>(_callListGbpAccounts, request, callSettings);
        }

        /// <summary>
        /// List the GBP accounts for a given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GbpAccount"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGbpAccountsResponse, GbpAccount> ListGbpAccountsAsync(ListGbpAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGbpAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGbpAccountsRequest, ListGbpAccountsResponse, GbpAccount>(_callListGbpAccounts, request, callSettings);
        }

        /// <summary>
        /// Link the specified merchant to a GBP account for all countries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LinkGbpAccountResponse LinkGbpAccount(LinkGbpAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LinkGbpAccountRequest(ref request, ref callSettings);
            return _callLinkGbpAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Link the specified merchant to a GBP account for all countries.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LinkGbpAccountResponse> LinkGbpAccountAsync(LinkGbpAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LinkGbpAccountRequest(ref request, ref callSettings);
            return _callLinkGbpAccount.Async(request, callSettings);
        }
    }

    public partial class ListGbpAccountsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGbpAccountsResponse : gaxgrpc::IPageResponse<GbpAccount>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GbpAccount> GetEnumerator() => GbpAccounts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
