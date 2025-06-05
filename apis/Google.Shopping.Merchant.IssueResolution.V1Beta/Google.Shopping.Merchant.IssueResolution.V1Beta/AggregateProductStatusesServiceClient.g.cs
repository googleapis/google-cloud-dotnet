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

namespace Google.Shopping.Merchant.IssueResolution.V1Beta
{
    /// <summary>Settings for <see cref="AggregateProductStatusesServiceClient"/> instances.</summary>
    public sealed partial class AggregateProductStatusesServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AggregateProductStatusesServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AggregateProductStatusesServiceSettings"/>.</returns>
        public static AggregateProductStatusesServiceSettings GetDefault() => new AggregateProductStatusesServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AggregateProductStatusesServiceSettings"/> object with default settings.
        /// </summary>
        public AggregateProductStatusesServiceSettings()
        {
        }

        private AggregateProductStatusesServiceSettings(AggregateProductStatusesServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAggregateProductStatusesSettings = existing.ListAggregateProductStatusesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AggregateProductStatusesServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AggregateProductStatusesServiceClient.ListAggregateProductStatuses</c> and
        /// <c>AggregateProductStatusesServiceClient.ListAggregateProductStatusesAsync</c>.
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
        public gaxgrpc::CallSettings ListAggregateProductStatusesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AggregateProductStatusesServiceSettings"/> object.</returns>
        public AggregateProductStatusesServiceSettings Clone() => new AggregateProductStatusesServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AggregateProductStatusesServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class AggregateProductStatusesServiceClientBuilder : gaxgrpc::ClientBuilderBase<AggregateProductStatusesServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AggregateProductStatusesServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AggregateProductStatusesServiceClientBuilder() : base(AggregateProductStatusesServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AggregateProductStatusesServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AggregateProductStatusesServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AggregateProductStatusesServiceClient Build()
        {
            AggregateProductStatusesServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AggregateProductStatusesServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AggregateProductStatusesServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AggregateProductStatusesServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AggregateProductStatusesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AggregateProductStatusesServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AggregateProductStatusesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AggregateProductStatusesServiceClient.ChannelPool;
    }

    /// <summary>AggregateProductStatusesService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage aggregate product statuses.
    /// </remarks>
    public abstract partial class AggregateProductStatusesServiceClient
    {
        /// <summary>
        /// The default endpoint for the AggregateProductStatusesService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default AggregateProductStatusesService scopes.</summary>
        /// <remarks>
        /// The default AggregateProductStatusesService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AggregateProductStatusesService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AggregateProductStatusesServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AggregateProductStatusesServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AggregateProductStatusesServiceClient"/>.</returns>
        public static stt::Task<AggregateProductStatusesServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AggregateProductStatusesServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AggregateProductStatusesServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AggregateProductStatusesServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AggregateProductStatusesServiceClient"/>.</returns>
        public static AggregateProductStatusesServiceClient Create() =>
            new AggregateProductStatusesServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AggregateProductStatusesServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AggregateProductStatusesServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AggregateProductStatusesServiceClient"/>.</returns>
        internal static AggregateProductStatusesServiceClient Create(grpccore::CallInvoker callInvoker, AggregateProductStatusesServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AggregateProductStatusesService.AggregateProductStatusesServiceClient grpcClient = new AggregateProductStatusesService.AggregateProductStatusesServiceClient(callInvoker);
            return new AggregateProductStatusesServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AggregateProductStatusesService client</summary>
        public virtual AggregateProductStatusesService.AggregateProductStatusesServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `AggregateProductStatuses` resources for your merchant account.
        /// The response might contain fewer items than specified by `pageSize`.
        /// If `pageToken` was returned in previous request, it can be used to obtain
        /// additional results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AggregateProductStatus"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAggregateProductStatusesResponse, AggregateProductStatus> ListAggregateProductStatuses(ListAggregateProductStatusesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `AggregateProductStatuses` resources for your merchant account.
        /// The response might contain fewer items than specified by `pageSize`.
        /// If `pageToken` was returned in previous request, it can be used to obtain
        /// additional results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AggregateProductStatus"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAggregateProductStatusesResponse, AggregateProductStatus> ListAggregateProductStatusesAsync(ListAggregateProductStatusesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `AggregateProductStatuses` resources for your merchant account.
        /// The response might contain fewer items than specified by `pageSize`.
        /// If `pageToken` was returned in previous request, it can be used to obtain
        /// additional results.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list aggregate product statuses for.
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
        /// <returns>A pageable sequence of <see cref="AggregateProductStatus"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAggregateProductStatusesResponse, AggregateProductStatus> ListAggregateProductStatuses(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAggregateProductStatusesRequest request = new ListAggregateProductStatusesRequest
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
            return ListAggregateProductStatuses(request, callSettings);
        }

        /// <summary>
        /// Lists the `AggregateProductStatuses` resources for your merchant account.
        /// The response might contain fewer items than specified by `pageSize`.
        /// If `pageToken` was returned in previous request, it can be used to obtain
        /// additional results.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list aggregate product statuses for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AggregateProductStatus"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAggregateProductStatusesResponse, AggregateProductStatus> ListAggregateProductStatusesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAggregateProductStatusesRequest request = new ListAggregateProductStatusesRequest
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
            return ListAggregateProductStatusesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the `AggregateProductStatuses` resources for your merchant account.
        /// The response might contain fewer items than specified by `pageSize`.
        /// If `pageToken` was returned in previous request, it can be used to obtain
        /// additional results.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list aggregate product statuses for.
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
        /// <returns>A pageable sequence of <see cref="AggregateProductStatus"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAggregateProductStatusesResponse, AggregateProductStatus> ListAggregateProductStatuses(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAggregateProductStatusesRequest request = new ListAggregateProductStatusesRequest
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
            return ListAggregateProductStatuses(request, callSettings);
        }

        /// <summary>
        /// Lists the `AggregateProductStatuses` resources for your merchant account.
        /// The response might contain fewer items than specified by `pageSize`.
        /// If `pageToken` was returned in previous request, it can be used to obtain
        /// additional results.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list aggregate product statuses for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AggregateProductStatus"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAggregateProductStatusesResponse, AggregateProductStatus> ListAggregateProductStatusesAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAggregateProductStatusesRequest request = new ListAggregateProductStatusesRequest
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
            return ListAggregateProductStatusesAsync(request, callSettings);
        }
    }

    /// <summary>AggregateProductStatusesService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage aggregate product statuses.
    /// </remarks>
    public sealed partial class AggregateProductStatusesServiceClientImpl : AggregateProductStatusesServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListAggregateProductStatusesRequest, ListAggregateProductStatusesResponse> _callListAggregateProductStatuses;

        /// <summary>
        /// Constructs a client wrapper for the AggregateProductStatusesService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AggregateProductStatusesServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AggregateProductStatusesServiceClientImpl(AggregateProductStatusesService.AggregateProductStatusesServiceClient grpcClient, AggregateProductStatusesServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AggregateProductStatusesServiceSettings effectiveSettings = settings ?? AggregateProductStatusesServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListAggregateProductStatuses = clientHelper.BuildApiCall<ListAggregateProductStatusesRequest, ListAggregateProductStatusesResponse>("ListAggregateProductStatuses", grpcClient.ListAggregateProductStatusesAsync, grpcClient.ListAggregateProductStatuses, effectiveSettings.ListAggregateProductStatusesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAggregateProductStatuses);
            Modify_ListAggregateProductStatusesApiCall(ref _callListAggregateProductStatuses);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAggregateProductStatusesApiCall(ref gaxgrpc::ApiCall<ListAggregateProductStatusesRequest, ListAggregateProductStatusesResponse> call);

        partial void OnConstruction(AggregateProductStatusesService.AggregateProductStatusesServiceClient grpcClient, AggregateProductStatusesServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AggregateProductStatusesService client</summary>
        public override AggregateProductStatusesService.AggregateProductStatusesServiceClient GrpcClient { get; }

        partial void Modify_ListAggregateProductStatusesRequest(ref ListAggregateProductStatusesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the `AggregateProductStatuses` resources for your merchant account.
        /// The response might contain fewer items than specified by `pageSize`.
        /// If `pageToken` was returned in previous request, it can be used to obtain
        /// additional results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AggregateProductStatus"/> resources.</returns>
        public override gax::PagedEnumerable<ListAggregateProductStatusesResponse, AggregateProductStatus> ListAggregateProductStatuses(ListAggregateProductStatusesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAggregateProductStatusesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAggregateProductStatusesRequest, ListAggregateProductStatusesResponse, AggregateProductStatus>(_callListAggregateProductStatuses, request, callSettings);
        }

        /// <summary>
        /// Lists the `AggregateProductStatuses` resources for your merchant account.
        /// The response might contain fewer items than specified by `pageSize`.
        /// If `pageToken` was returned in previous request, it can be used to obtain
        /// additional results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AggregateProductStatus"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAggregateProductStatusesResponse, AggregateProductStatus> ListAggregateProductStatusesAsync(ListAggregateProductStatusesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAggregateProductStatusesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAggregateProductStatusesRequest, ListAggregateProductStatusesResponse, AggregateProductStatus>(_callListAggregateProductStatuses, request, callSettings);
        }
    }

    public partial class ListAggregateProductStatusesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAggregateProductStatusesResponse : gaxgrpc::IPageResponse<AggregateProductStatus>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AggregateProductStatus> GetEnumerator() => AggregateProductStatuses.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
