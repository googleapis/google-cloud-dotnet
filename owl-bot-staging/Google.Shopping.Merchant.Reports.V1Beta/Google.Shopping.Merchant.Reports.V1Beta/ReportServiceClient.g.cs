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

namespace Google.Shopping.Merchant.Reports.V1Beta
{
    /// <summary>Settings for <see cref="ReportServiceClient"/> instances.</summary>
    public sealed partial class ReportServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReportServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReportServiceSettings"/>.</returns>
        public static ReportServiceSettings GetDefault() => new ReportServiceSettings();

        /// <summary>Constructs a new <see cref="ReportServiceSettings"/> object with default settings.</summary>
        public ReportServiceSettings()
        {
        }

        private ReportServiceSettings(ReportServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchSettings = existing.SearchSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReportServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ReportServiceClient.Search</c>
        ///  and <c>ReportServiceClient.SearchAsync</c>.
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
        public gaxgrpc::CallSettings SearchSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReportServiceSettings"/> object.</returns>
        public ReportServiceSettings Clone() => new ReportServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReportServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ReportServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReportServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReportServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReportServiceClientBuilder() : base(ReportServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReportServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReportServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReportServiceClient Build()
        {
            ReportServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReportServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReportServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReportServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReportServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReportServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReportServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReportServiceClient.ChannelPool;
    }

    /// <summary>ReportService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for retrieving reports and insights about your products, their
    /// performance, and their competitive environment on Google.
    /// </remarks>
    public abstract partial class ReportServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReportService service, which is a host of "merchantapi.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default ReportService scopes.</summary>
        /// <remarks>
        /// The default ReportService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReportService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReportServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReportServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReportServiceClient"/>.</returns>
        public static stt::Task<ReportServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReportServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReportServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReportServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ReportServiceClient"/>.</returns>
        public static ReportServiceClient Create() => new ReportServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReportServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReportServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReportServiceClient"/>.</returns>
        internal static ReportServiceClient Create(grpccore::CallInvoker callInvoker, ReportServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReportService.ReportServiceClient grpcClient = new ReportService.ReportServiceClient(callInvoker);
            return new ReportServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ReportService client</summary>
        public virtual ReportService.ReportServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a report defined by a search query. The response might contain
        /// fewer rows than specified by `page_size`. Rely on `next_page_token` to
        /// determine if there are more rows to be requested.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReportRow"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchResponse, ReportRow> Search(SearchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a report defined by a search query. The response might contain
        /// fewer rows than specified by `page_size`. Rely on `next_page_token` to
        /// determine if there are more rows to be requested.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReportRow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchResponse, ReportRow> SearchAsync(SearchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a report defined by a search query. The response might contain
        /// fewer rows than specified by `page_size`. Rely on `next_page_token` to
        /// determine if there are more rows to be requested.
        /// </summary>
        /// <param name="parent">
        /// Required. Id of the account making the call. Must be a standalone account
        /// or an MCA subaccount. Format: accounts/{account}
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
        /// <returns>A pageable sequence of <see cref="ReportRow"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchResponse, ReportRow> Search(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchRequest request = new SearchRequest
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
            return Search(request, callSettings);
        }

        /// <summary>
        /// Retrieves a report defined by a search query. The response might contain
        /// fewer rows than specified by `page_size`. Rely on `next_page_token` to
        /// determine if there are more rows to be requested.
        /// </summary>
        /// <param name="parent">
        /// Required. Id of the account making the call. Must be a standalone account
        /// or an MCA subaccount. Format: accounts/{account}
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReportRow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchResponse, ReportRow> SearchAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchRequest request = new SearchRequest
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
            return SearchAsync(request, callSettings);
        }
    }

    /// <summary>ReportService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for retrieving reports and insights about your products, their
    /// performance, and their competitive environment on Google.
    /// </remarks>
    public sealed partial class ReportServiceClientImpl : ReportServiceClient
    {
        private readonly gaxgrpc::ApiCall<SearchRequest, SearchResponse> _callSearch;

        /// <summary>
        /// Constructs a client wrapper for the ReportService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReportServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReportServiceClientImpl(ReportService.ReportServiceClient grpcClient, ReportServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReportServiceSettings effectiveSettings = settings ?? ReportServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callSearch = clientHelper.BuildApiCall<SearchRequest, SearchResponse>("Search", grpcClient.SearchAsync, grpcClient.Search, effectiveSettings.SearchSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearch);
            Modify_SearchApiCall(ref _callSearch);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SearchApiCall(ref gaxgrpc::ApiCall<SearchRequest, SearchResponse> call);

        partial void OnConstruction(ReportService.ReportServiceClient grpcClient, ReportServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReportService client</summary>
        public override ReportService.ReportServiceClient GrpcClient { get; }

        partial void Modify_SearchRequest(ref SearchRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a report defined by a search query. The response might contain
        /// fewer rows than specified by `page_size`. Rely on `next_page_token` to
        /// determine if there are more rows to be requested.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReportRow"/> resources.</returns>
        public override gax::PagedEnumerable<SearchResponse, ReportRow> Search(SearchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchRequest, SearchResponse, ReportRow>(_callSearch, request, callSettings);
        }

        /// <summary>
        /// Retrieves a report defined by a search query. The response might contain
        /// fewer rows than specified by `page_size`. Rely on `next_page_token` to
        /// determine if there are more rows to be requested.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReportRow"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchResponse, ReportRow> SearchAsync(SearchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchRequest, SearchResponse, ReportRow>(_callSearch, request, callSettings);
        }
    }

    public partial class SearchRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchResponse : gaxgrpc::IPageResponse<ReportRow>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReportRow> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
