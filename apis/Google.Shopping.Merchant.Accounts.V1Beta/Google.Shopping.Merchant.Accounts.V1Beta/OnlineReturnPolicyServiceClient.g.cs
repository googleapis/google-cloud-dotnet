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

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Settings for <see cref="OnlineReturnPolicyServiceClient"/> instances.</summary>
    public sealed partial class OnlineReturnPolicyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OnlineReturnPolicyServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OnlineReturnPolicyServiceSettings"/>.</returns>
        public static OnlineReturnPolicyServiceSettings GetDefault() => new OnlineReturnPolicyServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="OnlineReturnPolicyServiceSettings"/> object with default settings.
        /// </summary>
        public OnlineReturnPolicyServiceSettings()
        {
        }

        private OnlineReturnPolicyServiceSettings(OnlineReturnPolicyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetOnlineReturnPolicySettings = existing.GetOnlineReturnPolicySettings;
            ListOnlineReturnPoliciesSettings = existing.ListOnlineReturnPoliciesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OnlineReturnPolicyServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OnlineReturnPolicyServiceClient.GetOnlineReturnPolicy</c> and
        /// <c>OnlineReturnPolicyServiceClient.GetOnlineReturnPolicyAsync</c>.
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
        public gaxgrpc::CallSettings GetOnlineReturnPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OnlineReturnPolicyServiceClient.ListOnlineReturnPolicies</c> and
        /// <c>OnlineReturnPolicyServiceClient.ListOnlineReturnPoliciesAsync</c>.
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
        public gaxgrpc::CallSettings ListOnlineReturnPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OnlineReturnPolicyServiceSettings"/> object.</returns>
        public OnlineReturnPolicyServiceSettings Clone() => new OnlineReturnPolicyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OnlineReturnPolicyServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class OnlineReturnPolicyServiceClientBuilder : gaxgrpc::ClientBuilderBase<OnlineReturnPolicyServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OnlineReturnPolicyServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OnlineReturnPolicyServiceClientBuilder() : base(OnlineReturnPolicyServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OnlineReturnPolicyServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OnlineReturnPolicyServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OnlineReturnPolicyServiceClient Build()
        {
            OnlineReturnPolicyServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OnlineReturnPolicyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OnlineReturnPolicyServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OnlineReturnPolicyServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OnlineReturnPolicyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OnlineReturnPolicyServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OnlineReturnPolicyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OnlineReturnPolicyServiceClient.ChannelPool;
    }

    /// <summary>OnlineReturnPolicyService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service facilitates the management of a merchant's remorse return policy
    /// configuration, encompassing return policies for both ads and free listings
    /// ## programs. This API defines the following resource model:
    /// 
    /// [OnlineReturnPolicy][google.shopping.merchant.accounts.v1.OnlineReturnPolicy]
    /// </remarks>
    public abstract partial class OnlineReturnPolicyServiceClient
    {
        /// <summary>
        /// The default endpoint for the OnlineReturnPolicyService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default OnlineReturnPolicyService scopes.</summary>
        /// <remarks>
        /// The default OnlineReturnPolicyService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(OnlineReturnPolicyService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OnlineReturnPolicyServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OnlineReturnPolicyServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OnlineReturnPolicyServiceClient"/>.</returns>
        public static stt::Task<OnlineReturnPolicyServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OnlineReturnPolicyServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OnlineReturnPolicyServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OnlineReturnPolicyServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OnlineReturnPolicyServiceClient"/>.</returns>
        public static OnlineReturnPolicyServiceClient Create() => new OnlineReturnPolicyServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OnlineReturnPolicyServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OnlineReturnPolicyServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OnlineReturnPolicyServiceClient"/>.</returns>
        internal static OnlineReturnPolicyServiceClient Create(grpccore::CallInvoker callInvoker, OnlineReturnPolicyServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OnlineReturnPolicyService.OnlineReturnPolicyServiceClient grpcClient = new OnlineReturnPolicyService.OnlineReturnPolicyServiceClient(callInvoker);
            return new OnlineReturnPolicyServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC OnlineReturnPolicyService client</summary>
        public virtual OnlineReturnPolicyService.OnlineReturnPolicyServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an existing return policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OnlineReturnPolicy GetOnlineReturnPolicy(GetOnlineReturnPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an existing return policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OnlineReturnPolicy> GetOnlineReturnPolicyAsync(GetOnlineReturnPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an existing return policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OnlineReturnPolicy> GetOnlineReturnPolicyAsync(GetOnlineReturnPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetOnlineReturnPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an existing return policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the return policy to retrieve.
        /// Format: `accounts/{account}/onlineReturnPolicies/{return_policy}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OnlineReturnPolicy GetOnlineReturnPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOnlineReturnPolicy(new GetOnlineReturnPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an existing return policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the return policy to retrieve.
        /// Format: `accounts/{account}/onlineReturnPolicies/{return_policy}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OnlineReturnPolicy> GetOnlineReturnPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOnlineReturnPolicyAsync(new GetOnlineReturnPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an existing return policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the return policy to retrieve.
        /// Format: `accounts/{account}/onlineReturnPolicies/{return_policy}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OnlineReturnPolicy> GetOnlineReturnPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetOnlineReturnPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an existing return policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the return policy to retrieve.
        /// Format: `accounts/{account}/onlineReturnPolicies/{return_policy}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OnlineReturnPolicy GetOnlineReturnPolicy(OnlineReturnPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOnlineReturnPolicy(new GetOnlineReturnPolicyRequest
            {
                OnlineReturnPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an existing return policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the return policy to retrieve.
        /// Format: `accounts/{account}/onlineReturnPolicies/{return_policy}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OnlineReturnPolicy> GetOnlineReturnPolicyAsync(OnlineReturnPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOnlineReturnPolicyAsync(new GetOnlineReturnPolicyRequest
            {
                OnlineReturnPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an existing return policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the return policy to retrieve.
        /// Format: `accounts/{account}/onlineReturnPolicies/{return_policy}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OnlineReturnPolicy> GetOnlineReturnPolicyAsync(OnlineReturnPolicyName name, st::CancellationToken cancellationToken) =>
            GetOnlineReturnPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all existing return policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OnlineReturnPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOnlineReturnPoliciesResponse, OnlineReturnPolicy> ListOnlineReturnPolicies(ListOnlineReturnPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all existing return policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OnlineReturnPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOnlineReturnPoliciesResponse, OnlineReturnPolicy> ListOnlineReturnPoliciesAsync(ListOnlineReturnPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all existing return policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account for which to list return policies.
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
        /// <returns>A pageable sequence of <see cref="OnlineReturnPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOnlineReturnPoliciesResponse, OnlineReturnPolicy> ListOnlineReturnPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOnlineReturnPoliciesRequest request = new ListOnlineReturnPoliciesRequest
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
            return ListOnlineReturnPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists all existing return policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account for which to list return policies.
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
        /// <returns>A pageable asynchronous sequence of <see cref="OnlineReturnPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOnlineReturnPoliciesResponse, OnlineReturnPolicy> ListOnlineReturnPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOnlineReturnPoliciesRequest request = new ListOnlineReturnPoliciesRequest
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
            return ListOnlineReturnPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all existing return policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account for which to list return policies.
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
        /// <returns>A pageable sequence of <see cref="OnlineReturnPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOnlineReturnPoliciesResponse, OnlineReturnPolicy> ListOnlineReturnPolicies(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOnlineReturnPoliciesRequest request = new ListOnlineReturnPoliciesRequest
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
            return ListOnlineReturnPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists all existing return policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account for which to list return policies.
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
        /// <returns>A pageable asynchronous sequence of <see cref="OnlineReturnPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOnlineReturnPoliciesResponse, OnlineReturnPolicy> ListOnlineReturnPoliciesAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOnlineReturnPoliciesRequest request = new ListOnlineReturnPoliciesRequest
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
            return ListOnlineReturnPoliciesAsync(request, callSettings);
        }
    }

    /// <summary>OnlineReturnPolicyService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service facilitates the management of a merchant's remorse return policy
    /// configuration, encompassing return policies for both ads and free listings
    /// ## programs. This API defines the following resource model:
    /// 
    /// [OnlineReturnPolicy][google.shopping.merchant.accounts.v1.OnlineReturnPolicy]
    /// </remarks>
    public sealed partial class OnlineReturnPolicyServiceClientImpl : OnlineReturnPolicyServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetOnlineReturnPolicyRequest, OnlineReturnPolicy> _callGetOnlineReturnPolicy;

        private readonly gaxgrpc::ApiCall<ListOnlineReturnPoliciesRequest, ListOnlineReturnPoliciesResponse> _callListOnlineReturnPolicies;

        /// <summary>
        /// Constructs a client wrapper for the OnlineReturnPolicyService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="OnlineReturnPolicyServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OnlineReturnPolicyServiceClientImpl(OnlineReturnPolicyService.OnlineReturnPolicyServiceClient grpcClient, OnlineReturnPolicyServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OnlineReturnPolicyServiceSettings effectiveSettings = settings ?? OnlineReturnPolicyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetOnlineReturnPolicy = clientHelper.BuildApiCall<GetOnlineReturnPolicyRequest, OnlineReturnPolicy>("GetOnlineReturnPolicy", grpcClient.GetOnlineReturnPolicyAsync, grpcClient.GetOnlineReturnPolicy, effectiveSettings.GetOnlineReturnPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOnlineReturnPolicy);
            Modify_GetOnlineReturnPolicyApiCall(ref _callGetOnlineReturnPolicy);
            _callListOnlineReturnPolicies = clientHelper.BuildApiCall<ListOnlineReturnPoliciesRequest, ListOnlineReturnPoliciesResponse>("ListOnlineReturnPolicies", grpcClient.ListOnlineReturnPoliciesAsync, grpcClient.ListOnlineReturnPolicies, effectiveSettings.ListOnlineReturnPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOnlineReturnPolicies);
            Modify_ListOnlineReturnPoliciesApiCall(ref _callListOnlineReturnPolicies);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetOnlineReturnPolicyApiCall(ref gaxgrpc::ApiCall<GetOnlineReturnPolicyRequest, OnlineReturnPolicy> call);

        partial void Modify_ListOnlineReturnPoliciesApiCall(ref gaxgrpc::ApiCall<ListOnlineReturnPoliciesRequest, ListOnlineReturnPoliciesResponse> call);

        partial void OnConstruction(OnlineReturnPolicyService.OnlineReturnPolicyServiceClient grpcClient, OnlineReturnPolicyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OnlineReturnPolicyService client</summary>
        public override OnlineReturnPolicyService.OnlineReturnPolicyServiceClient GrpcClient { get; }

        partial void Modify_GetOnlineReturnPolicyRequest(ref GetOnlineReturnPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOnlineReturnPoliciesRequest(ref ListOnlineReturnPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets an existing return policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OnlineReturnPolicy GetOnlineReturnPolicy(GetOnlineReturnPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOnlineReturnPolicyRequest(ref request, ref callSettings);
            return _callGetOnlineReturnPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an existing return policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OnlineReturnPolicy> GetOnlineReturnPolicyAsync(GetOnlineReturnPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOnlineReturnPolicyRequest(ref request, ref callSettings);
            return _callGetOnlineReturnPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all existing return policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OnlineReturnPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListOnlineReturnPoliciesResponse, OnlineReturnPolicy> ListOnlineReturnPolicies(ListOnlineReturnPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOnlineReturnPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOnlineReturnPoliciesRequest, ListOnlineReturnPoliciesResponse, OnlineReturnPolicy>(_callListOnlineReturnPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists all existing return policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OnlineReturnPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOnlineReturnPoliciesResponse, OnlineReturnPolicy> ListOnlineReturnPoliciesAsync(ListOnlineReturnPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOnlineReturnPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOnlineReturnPoliciesRequest, ListOnlineReturnPoliciesResponse, OnlineReturnPolicy>(_callListOnlineReturnPolicies, request, callSettings);
        }
    }

    public partial class ListOnlineReturnPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOnlineReturnPoliciesResponse : gaxgrpc::IPageResponse<OnlineReturnPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<OnlineReturnPolicy> GetEnumerator() => OnlineReturnPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
