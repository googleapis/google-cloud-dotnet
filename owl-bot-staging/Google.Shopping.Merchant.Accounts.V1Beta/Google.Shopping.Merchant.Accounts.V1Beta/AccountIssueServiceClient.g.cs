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
    /// <summary>Settings for <see cref="AccountIssueServiceClient"/> instances.</summary>
    public sealed partial class AccountIssueServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AccountIssueServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AccountIssueServiceSettings"/>.</returns>
        public static AccountIssueServiceSettings GetDefault() => new AccountIssueServiceSettings();

        /// <summary>Constructs a new <see cref="AccountIssueServiceSettings"/> object with default settings.</summary>
        public AccountIssueServiceSettings()
        {
        }

        private AccountIssueServiceSettings(AccountIssueServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAccountIssuesSettings = existing.ListAccountIssuesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccountIssueServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountIssueServiceClient.ListAccountIssues</c> and <c>AccountIssueServiceClient.ListAccountIssuesAsync</c>
        /// .
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
        public gaxgrpc::CallSettings ListAccountIssuesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AccountIssueServiceSettings"/> object.</returns>
        public AccountIssueServiceSettings Clone() => new AccountIssueServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AccountIssueServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AccountIssueServiceClientBuilder : gaxgrpc::ClientBuilderBase<AccountIssueServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AccountIssueServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AccountIssueServiceClientBuilder() : base(AccountIssueServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AccountIssueServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AccountIssueServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AccountIssueServiceClient Build()
        {
            AccountIssueServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AccountIssueServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AccountIssueServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AccountIssueServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AccountIssueServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AccountIssueServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AccountIssueServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AccountIssueServiceClient.ChannelPool;
    }

    /// <summary>AccountIssueService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to support `AccountIssueService` API.
    /// </remarks>
    public abstract partial class AccountIssueServiceClient
    {
        /// <summary>
        /// The default endpoint for the AccountIssueService service, which is a host of "merchantapi.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default AccountIssueService scopes.</summary>
        /// <remarks>
        /// The default AccountIssueService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AccountIssueService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AccountIssueServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AccountIssueServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AccountIssueServiceClient"/>.</returns>
        public static stt::Task<AccountIssueServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AccountIssueServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AccountIssueServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AccountIssueServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AccountIssueServiceClient"/>.</returns>
        public static AccountIssueServiceClient Create() => new AccountIssueServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AccountIssueServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AccountIssueServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AccountIssueServiceClient"/>.</returns>
        internal static AccountIssueServiceClient Create(grpccore::CallInvoker callInvoker, AccountIssueServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccountIssueService.AccountIssueServiceClient grpcClient = new AccountIssueService.AccountIssueServiceClient(callInvoker);
            return new AccountIssueServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AccountIssueService client</summary>
        public virtual AccountIssueService.AccountIssueServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all account issues of a Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccountIssue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountIssuesResponse, AccountIssue> ListAccountIssues(ListAccountIssuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all account issues of a Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccountIssue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountIssuesResponse, AccountIssue> ListAccountIssuesAsync(ListAccountIssuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all account issues of a Merchant Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of issues.
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
        /// <returns>A pageable sequence of <see cref="AccountIssue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountIssuesResponse, AccountIssue> ListAccountIssues(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountIssuesRequest request = new ListAccountIssuesRequest
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
            return ListAccountIssues(request, callSettings);
        }

        /// <summary>
        /// Lists all account issues of a Merchant Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of issues.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccountIssue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountIssuesResponse, AccountIssue> ListAccountIssuesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountIssuesRequest request = new ListAccountIssuesRequest
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
            return ListAccountIssuesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all account issues of a Merchant Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of issues.
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
        /// <returns>A pageable sequence of <see cref="AccountIssue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountIssuesResponse, AccountIssue> ListAccountIssues(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountIssuesRequest request = new ListAccountIssuesRequest
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
            return ListAccountIssues(request, callSettings);
        }

        /// <summary>
        /// Lists all account issues of a Merchant Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of issues.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccountIssue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountIssuesResponse, AccountIssue> ListAccountIssuesAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountIssuesRequest request = new ListAccountIssuesRequest
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
            return ListAccountIssuesAsync(request, callSettings);
        }
    }

    /// <summary>AccountIssueService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to support `AccountIssueService` API.
    /// </remarks>
    public sealed partial class AccountIssueServiceClientImpl : AccountIssueServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListAccountIssuesRequest, ListAccountIssuesResponse> _callListAccountIssues;

        /// <summary>
        /// Constructs a client wrapper for the AccountIssueService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AccountIssueServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AccountIssueServiceClientImpl(AccountIssueService.AccountIssueServiceClient grpcClient, AccountIssueServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AccountIssueServiceSettings effectiveSettings = settings ?? AccountIssueServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListAccountIssues = clientHelper.BuildApiCall<ListAccountIssuesRequest, ListAccountIssuesResponse>("ListAccountIssues", grpcClient.ListAccountIssuesAsync, grpcClient.ListAccountIssues, effectiveSettings.ListAccountIssuesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAccountIssues);
            Modify_ListAccountIssuesApiCall(ref _callListAccountIssues);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAccountIssuesApiCall(ref gaxgrpc::ApiCall<ListAccountIssuesRequest, ListAccountIssuesResponse> call);

        partial void OnConstruction(AccountIssueService.AccountIssueServiceClient grpcClient, AccountIssueServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccountIssueService client</summary>
        public override AccountIssueService.AccountIssueServiceClient GrpcClient { get; }

        partial void Modify_ListAccountIssuesRequest(ref ListAccountIssuesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all account issues of a Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccountIssue"/> resources.</returns>
        public override gax::PagedEnumerable<ListAccountIssuesResponse, AccountIssue> ListAccountIssues(ListAccountIssuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountIssuesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAccountIssuesRequest, ListAccountIssuesResponse, AccountIssue>(_callListAccountIssues, request, callSettings);
        }

        /// <summary>
        /// Lists all account issues of a Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccountIssue"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAccountIssuesResponse, AccountIssue> ListAccountIssuesAsync(ListAccountIssuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountIssuesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAccountIssuesRequest, ListAccountIssuesResponse, AccountIssue>(_callListAccountIssues, request, callSettings);
        }
    }

    public partial class ListAccountIssuesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAccountIssuesResponse : gaxgrpc::IPageResponse<AccountIssue>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AccountIssue> GetEnumerator() => AccountIssues.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
