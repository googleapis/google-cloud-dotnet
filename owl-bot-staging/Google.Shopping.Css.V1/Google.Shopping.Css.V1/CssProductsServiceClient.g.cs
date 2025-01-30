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

namespace Google.Shopping.Css.V1
{
    /// <summary>Settings for <see cref="CssProductsServiceClient"/> instances.</summary>
    public sealed partial class CssProductsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CssProductsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CssProductsServiceSettings"/>.</returns>
        public static CssProductsServiceSettings GetDefault() => new CssProductsServiceSettings();

        /// <summary>Constructs a new <see cref="CssProductsServiceSettings"/> object with default settings.</summary>
        public CssProductsServiceSettings()
        {
        }

        private CssProductsServiceSettings(CssProductsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCssProductSettings = existing.GetCssProductSettings;
            ListCssProductsSettings = existing.ListCssProductsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CssProductsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CssProductsServiceClient.GetCssProduct</c> and <c>CssProductsServiceClient.GetCssProductAsync</c>.
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
        public gaxgrpc::CallSettings GetCssProductSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CssProductsServiceClient.ListCssProducts</c> and <c>CssProductsServiceClient.ListCssProductsAsync</c>.
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
        public gaxgrpc::CallSettings ListCssProductsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CssProductsServiceSettings"/> object.</returns>
        public CssProductsServiceSettings Clone() => new CssProductsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CssProductsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CssProductsServiceClientBuilder : gaxgrpc::ClientBuilderBase<CssProductsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CssProductsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CssProductsServiceClientBuilder() : base(CssProductsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CssProductsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CssProductsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CssProductsServiceClient Build()
        {
            CssProductsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CssProductsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CssProductsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CssProductsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CssProductsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CssProductsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CssProductsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CssProductsServiceClient.ChannelPool;
    }

    /// <summary>CssProductsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for doing get and list on Css Products(a.k.a Aggregate Offers
    /// internally).
    /// </remarks>
    public abstract partial class CssProductsServiceClient
    {
        /// <summary>
        /// The default endpoint for the CssProductsService service, which is a host of "css.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "css.googleapis.com:443";

        /// <summary>The default CssProductsService scopes.</summary>
        /// <remarks>
        /// The default CssProductsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CssProductsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CssProductsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CssProductsServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CssProductsServiceClient"/>.</returns>
        public static stt::Task<CssProductsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CssProductsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CssProductsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CssProductsServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="CssProductsServiceClient"/>.</returns>
        public static CssProductsServiceClient Create() => new CssProductsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CssProductsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CssProductsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CssProductsServiceClient"/>.</returns>
        internal static CssProductsServiceClient Create(grpccore::CallInvoker callInvoker, CssProductsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CssProductsService.CssProductsServiceClient grpcClient = new CssProductsService.CssProductsServiceClient(callInvoker);
            return new CssProductsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CssProductsService client</summary>
        public virtual CssProductsService.CssProductsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the processed CSS Product from your CSS Center account. After
        /// inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CssProduct GetCssProduct(GetCssProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the processed CSS Product from your CSS Center account. After
        /// inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CssProduct> GetCssProductAsync(GetCssProductRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the processed CSS Product from your CSS Center account. After
        /// inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CssProduct> GetCssProductAsync(GetCssProductRequest request, st::CancellationToken cancellationToken) =>
            GetCssProductAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the processed CSS Product from your CSS Center account. After
        /// inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CSS product to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CssProduct GetCssProduct(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCssProduct(new GetCssProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the processed CSS Product from your CSS Center account. After
        /// inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CSS product to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CssProduct> GetCssProductAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCssProductAsync(new GetCssProductRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the processed CSS Product from your CSS Center account. After
        /// inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CSS product to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CssProduct> GetCssProductAsync(string name, st::CancellationToken cancellationToken) =>
            GetCssProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the processed CSS Product from your CSS Center account. After
        /// inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CSS product to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CssProduct GetCssProduct(CssProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCssProduct(new GetCssProductRequest
            {
                CssProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the processed CSS Product from your CSS Center account. After
        /// inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CSS product to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CssProduct> GetCssProductAsync(CssProductName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCssProductAsync(new GetCssProductRequest
            {
                CssProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the processed CSS Product from your CSS Center account. After
        /// inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CSS product to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CssProduct> GetCssProductAsync(CssProductName name, st::CancellationToken cancellationToken) =>
            GetCssProductAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the processed CSS Products in your CSS Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a CSS product input, it may
        /// take several minutes before the updated processed CSS product can be
        /// retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CssProduct"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCssProductsResponse, CssProduct> ListCssProducts(ListCssProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the processed CSS Products in your CSS Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a CSS product input, it may
        /// take several minutes before the updated processed CSS product can be
        /// retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CssProduct"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCssProductsResponse, CssProduct> ListCssProductsAsync(ListCssProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the processed CSS Products in your CSS Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a CSS product input, it may
        /// take several minutes before the updated processed CSS product can be
        /// retrieved.
        /// </summary>
        /// <param name="parent">
        /// Required. The account/domain to list processed CSS Products for.
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
        /// <returns>A pageable sequence of <see cref="CssProduct"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCssProductsResponse, CssProduct> ListCssProducts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCssProductsRequest request = new ListCssProductsRequest
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
            return ListCssProducts(request, callSettings);
        }

        /// <summary>
        /// Lists the processed CSS Products in your CSS Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a CSS product input, it may
        /// take several minutes before the updated processed CSS product can be
        /// retrieved.
        /// </summary>
        /// <param name="parent">
        /// Required. The account/domain to list processed CSS Products for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CssProduct"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCssProductsResponse, CssProduct> ListCssProductsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCssProductsRequest request = new ListCssProductsRequest
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
            return ListCssProductsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the processed CSS Products in your CSS Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a CSS product input, it may
        /// take several minutes before the updated processed CSS product can be
        /// retrieved.
        /// </summary>
        /// <param name="parent">
        /// Required. The account/domain to list processed CSS Products for.
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
        /// <returns>A pageable sequence of <see cref="CssProduct"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCssProductsResponse, CssProduct> ListCssProducts(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCssProductsRequest request = new ListCssProductsRequest
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
            return ListCssProducts(request, callSettings);
        }

        /// <summary>
        /// Lists the processed CSS Products in your CSS Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a CSS product input, it may
        /// take several minutes before the updated processed CSS product can be
        /// retrieved.
        /// </summary>
        /// <param name="parent">
        /// Required. The account/domain to list processed CSS Products for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CssProduct"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCssProductsResponse, CssProduct> ListCssProductsAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCssProductsRequest request = new ListCssProductsRequest
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
            return ListCssProductsAsync(request, callSettings);
        }
    }

    /// <summary>CssProductsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for doing get and list on Css Products(a.k.a Aggregate Offers
    /// internally).
    /// </remarks>
    public sealed partial class CssProductsServiceClientImpl : CssProductsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCssProductRequest, CssProduct> _callGetCssProduct;

        private readonly gaxgrpc::ApiCall<ListCssProductsRequest, ListCssProductsResponse> _callListCssProducts;

        /// <summary>
        /// Constructs a client wrapper for the CssProductsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CssProductsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CssProductsServiceClientImpl(CssProductsService.CssProductsServiceClient grpcClient, CssProductsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CssProductsServiceSettings effectiveSettings = settings ?? CssProductsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetCssProduct = clientHelper.BuildApiCall<GetCssProductRequest, CssProduct>("GetCssProduct", grpcClient.GetCssProductAsync, grpcClient.GetCssProduct, effectiveSettings.GetCssProductSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCssProduct);
            Modify_GetCssProductApiCall(ref _callGetCssProduct);
            _callListCssProducts = clientHelper.BuildApiCall<ListCssProductsRequest, ListCssProductsResponse>("ListCssProducts", grpcClient.ListCssProductsAsync, grpcClient.ListCssProducts, effectiveSettings.ListCssProductsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCssProducts);
            Modify_ListCssProductsApiCall(ref _callListCssProducts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCssProductApiCall(ref gaxgrpc::ApiCall<GetCssProductRequest, CssProduct> call);

        partial void Modify_ListCssProductsApiCall(ref gaxgrpc::ApiCall<ListCssProductsRequest, ListCssProductsResponse> call);

        partial void OnConstruction(CssProductsService.CssProductsServiceClient grpcClient, CssProductsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CssProductsService client</summary>
        public override CssProductsService.CssProductsServiceClient GrpcClient { get; }

        partial void Modify_GetCssProductRequest(ref GetCssProductRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCssProductsRequest(ref ListCssProductsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the processed CSS Product from your CSS Center account. After
        /// inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CssProduct GetCssProduct(GetCssProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCssProductRequest(ref request, ref callSettings);
            return _callGetCssProduct.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the processed CSS Product from your CSS Center account. After
        /// inserting, updating, or deleting a product input, it may take several
        /// minutes before the updated final product can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CssProduct> GetCssProductAsync(GetCssProductRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCssProductRequest(ref request, ref callSettings);
            return _callGetCssProduct.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the processed CSS Products in your CSS Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a CSS product input, it may
        /// take several minutes before the updated processed CSS product can be
        /// retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CssProduct"/> resources.</returns>
        public override gax::PagedEnumerable<ListCssProductsResponse, CssProduct> ListCssProducts(ListCssProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCssProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCssProductsRequest, ListCssProductsResponse, CssProduct>(_callListCssProducts, request, callSettings);
        }

        /// <summary>
        /// Lists the processed CSS Products in your CSS Center account. The response
        /// might contain fewer items than specified by pageSize. Rely on pageToken to
        /// determine if there are more items to be requested.
        /// 
        /// After inserting, updating, or deleting a CSS product input, it may
        /// take several minutes before the updated processed CSS product can be
        /// retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CssProduct"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCssProductsResponse, CssProduct> ListCssProductsAsync(ListCssProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCssProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCssProductsRequest, ListCssProductsResponse, CssProduct>(_callListCssProducts, request, callSettings);
        }
    }

    public partial class ListCssProductsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCssProductsResponse : gaxgrpc::IPageResponse<CssProduct>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CssProduct> GetEnumerator() => CssProducts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
