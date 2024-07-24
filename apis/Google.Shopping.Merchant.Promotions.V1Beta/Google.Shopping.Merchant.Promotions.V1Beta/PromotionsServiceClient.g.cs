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

namespace Google.Shopping.Merchant.Promotions.V1Beta
{
    /// <summary>Settings for <see cref="PromotionsServiceClient"/> instances.</summary>
    public sealed partial class PromotionsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PromotionsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PromotionsServiceSettings"/>.</returns>
        public static PromotionsServiceSettings GetDefault() => new PromotionsServiceSettings();

        /// <summary>Constructs a new <see cref="PromotionsServiceSettings"/> object with default settings.</summary>
        public PromotionsServiceSettings()
        {
        }

        private PromotionsServiceSettings(PromotionsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            InsertPromotionSettings = existing.InsertPromotionSettings;
            GetPromotionSettings = existing.GetPromotionSettings;
            ListPromotionsSettings = existing.ListPromotionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PromotionsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PromotionsServiceClient.InsertPromotion</c> and <c>PromotionsServiceClient.InsertPromotionAsync</c>.
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
        public gaxgrpc::CallSettings InsertPromotionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PromotionsServiceClient.GetPromotion</c> and <c>PromotionsServiceClient.GetPromotionAsync</c>.
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
        public gaxgrpc::CallSettings GetPromotionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PromotionsServiceClient.ListPromotions</c> and <c>PromotionsServiceClient.ListPromotionsAsync</c>.
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
        public gaxgrpc::CallSettings ListPromotionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PromotionsServiceSettings"/> object.</returns>
        public PromotionsServiceSettings Clone() => new PromotionsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PromotionsServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class PromotionsServiceClientBuilder : gaxgrpc::ClientBuilderBase<PromotionsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PromotionsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PromotionsServiceClientBuilder() : base(PromotionsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PromotionsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PromotionsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PromotionsServiceClient Build()
        {
            PromotionsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PromotionsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PromotionsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PromotionsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PromotionsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PromotionsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PromotionsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PromotionsServiceClient.ChannelPool;
    }

    /// <summary>PromotionsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage promotions for products.
    /// </remarks>
    public abstract partial class PromotionsServiceClient
    {
        /// <summary>
        /// The default endpoint for the PromotionsService service, which is a host of "merchantapi.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default PromotionsService scopes.</summary>
        /// <remarks>
        /// The default PromotionsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PromotionsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PromotionsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PromotionsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PromotionsServiceClient"/>.</returns>
        public static stt::Task<PromotionsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PromotionsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PromotionsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PromotionsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PromotionsServiceClient"/>.</returns>
        public static PromotionsServiceClient Create() => new PromotionsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PromotionsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PromotionsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PromotionsServiceClient"/>.</returns>
        internal static PromotionsServiceClient Create(grpccore::CallInvoker callInvoker, PromotionsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PromotionsService.PromotionsServiceClient grpcClient = new PromotionsService.PromotionsServiceClient(callInvoker);
            return new PromotionsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PromotionsService client</summary>
        public virtual PromotionsService.PromotionsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a promotion for your Merchant Center account. If the promotion
        /// already exists, then it updates the promotion instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Promotion InsertPromotion(InsertPromotionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a promotion for your Merchant Center account. If the promotion
        /// already exists, then it updates the promotion instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Promotion> InsertPromotionAsync(InsertPromotionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a promotion for your Merchant Center account. If the promotion
        /// already exists, then it updates the promotion instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Promotion> InsertPromotionAsync(InsertPromotionRequest request, st::CancellationToken cancellationToken) =>
            InsertPromotionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the promotion from your Merchant Center account.
        /// 
        /// After inserting or updating a promotion input, it may take several
        /// minutes before the updated promotion can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Promotion GetPromotion(GetPromotionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the promotion from your Merchant Center account.
        /// 
        /// After inserting or updating a promotion input, it may take several
        /// minutes before the updated promotion can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Promotion> GetPromotionAsync(GetPromotionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the promotion from your Merchant Center account.
        /// 
        /// After inserting or updating a promotion input, it may take several
        /// minutes before the updated promotion can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Promotion> GetPromotionAsync(GetPromotionRequest request, st::CancellationToken cancellationToken) =>
            GetPromotionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the promotion from your Merchant Center account.
        /// 
        /// After inserting or updating a promotion input, it may take several
        /// minutes before the updated promotion can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the promotion to retrieve.
        /// Format: `accounts/{account}/promotions/{promotions}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Promotion GetPromotion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPromotion(new GetPromotionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the promotion from your Merchant Center account.
        /// 
        /// After inserting or updating a promotion input, it may take several
        /// minutes before the updated promotion can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the promotion to retrieve.
        /// Format: `accounts/{account}/promotions/{promotions}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Promotion> GetPromotionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPromotionAsync(new GetPromotionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the promotion from your Merchant Center account.
        /// 
        /// After inserting or updating a promotion input, it may take several
        /// minutes before the updated promotion can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the promotion to retrieve.
        /// Format: `accounts/{account}/promotions/{promotions}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Promotion> GetPromotionAsync(string name, st::CancellationToken cancellationToken) =>
            GetPromotionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the promotion from your Merchant Center account.
        /// 
        /// After inserting or updating a promotion input, it may take several
        /// minutes before the updated promotion can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the promotion to retrieve.
        /// Format: `accounts/{account}/promotions/{promotions}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Promotion GetPromotion(PromotionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPromotion(new GetPromotionRequest
            {
                PromotionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the promotion from your Merchant Center account.
        /// 
        /// After inserting or updating a promotion input, it may take several
        /// minutes before the updated promotion can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the promotion to retrieve.
        /// Format: `accounts/{account}/promotions/{promotions}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Promotion> GetPromotionAsync(PromotionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPromotionAsync(new GetPromotionRequest
            {
                PromotionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the promotion from your Merchant Center account.
        /// 
        /// After inserting or updating a promotion input, it may take several
        /// minutes before the updated promotion can be retrieved.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the promotion to retrieve.
        /// Format: `accounts/{account}/promotions/{promotions}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Promotion> GetPromotionAsync(PromotionName name, st::CancellationToken cancellationToken) =>
            GetPromotionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the promotions in your Merchant Center account. The
        /// response might contain fewer items than specified by `pageSize`. Rely on
        /// `pageToken` to determine if there are more items to be requested.
        /// 
        /// After inserting or updating a promotion, it may take several minutes before
        /// the updated processed promotion can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Promotion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPromotionsResponse, Promotion> ListPromotions(ListPromotionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the promotions in your Merchant Center account. The
        /// response might contain fewer items than specified by `pageSize`. Rely on
        /// `pageToken` to determine if there are more items to be requested.
        /// 
        /// After inserting or updating a promotion, it may take several minutes before
        /// the updated processed promotion can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Promotion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPromotionsResponse, Promotion> ListPromotionsAsync(ListPromotionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the promotions in your Merchant Center account. The
        /// response might contain fewer items than specified by `pageSize`. Rely on
        /// `pageToken` to determine if there are more items to be requested.
        /// 
        /// After inserting or updating a promotion, it may take several minutes before
        /// the updated processed promotion can be retrieved.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list processed promotions for.
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
        /// <returns>A pageable sequence of <see cref="Promotion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPromotionsResponse, Promotion> ListPromotions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPromotionsRequest request = new ListPromotionsRequest
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
            return ListPromotions(request, callSettings);
        }

        /// <summary>
        /// Lists the promotions in your Merchant Center account. The
        /// response might contain fewer items than specified by `pageSize`. Rely on
        /// `pageToken` to determine if there are more items to be requested.
        /// 
        /// After inserting or updating a promotion, it may take several minutes before
        /// the updated processed promotion can be retrieved.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list processed promotions for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Promotion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPromotionsResponse, Promotion> ListPromotionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPromotionsRequest request = new ListPromotionsRequest
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
            return ListPromotionsAsync(request, callSettings);
        }
    }

    /// <summary>PromotionsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage promotions for products.
    /// </remarks>
    public sealed partial class PromotionsServiceClientImpl : PromotionsServiceClient
    {
        private readonly gaxgrpc::ApiCall<InsertPromotionRequest, Promotion> _callInsertPromotion;

        private readonly gaxgrpc::ApiCall<GetPromotionRequest, Promotion> _callGetPromotion;

        private readonly gaxgrpc::ApiCall<ListPromotionsRequest, ListPromotionsResponse> _callListPromotions;

        /// <summary>
        /// Constructs a client wrapper for the PromotionsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PromotionsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PromotionsServiceClientImpl(PromotionsService.PromotionsServiceClient grpcClient, PromotionsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PromotionsServiceSettings effectiveSettings = settings ?? PromotionsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callInsertPromotion = clientHelper.BuildApiCall<InsertPromotionRequest, Promotion>("InsertPromotion", grpcClient.InsertPromotionAsync, grpcClient.InsertPromotion, effectiveSettings.InsertPromotionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callInsertPromotion);
            Modify_InsertPromotionApiCall(ref _callInsertPromotion);
            _callGetPromotion = clientHelper.BuildApiCall<GetPromotionRequest, Promotion>("GetPromotion", grpcClient.GetPromotionAsync, grpcClient.GetPromotion, effectiveSettings.GetPromotionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPromotion);
            Modify_GetPromotionApiCall(ref _callGetPromotion);
            _callListPromotions = clientHelper.BuildApiCall<ListPromotionsRequest, ListPromotionsResponse>("ListPromotions", grpcClient.ListPromotionsAsync, grpcClient.ListPromotions, effectiveSettings.ListPromotionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPromotions);
            Modify_ListPromotionsApiCall(ref _callListPromotions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_InsertPromotionApiCall(ref gaxgrpc::ApiCall<InsertPromotionRequest, Promotion> call);

        partial void Modify_GetPromotionApiCall(ref gaxgrpc::ApiCall<GetPromotionRequest, Promotion> call);

        partial void Modify_ListPromotionsApiCall(ref gaxgrpc::ApiCall<ListPromotionsRequest, ListPromotionsResponse> call);

        partial void OnConstruction(PromotionsService.PromotionsServiceClient grpcClient, PromotionsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PromotionsService client</summary>
        public override PromotionsService.PromotionsServiceClient GrpcClient { get; }

        partial void Modify_InsertPromotionRequest(ref InsertPromotionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPromotionRequest(ref GetPromotionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPromotionsRequest(ref ListPromotionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Inserts a promotion for your Merchant Center account. If the promotion
        /// already exists, then it updates the promotion instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Promotion InsertPromotion(InsertPromotionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertPromotionRequest(ref request, ref callSettings);
            return _callInsertPromotion.Sync(request, callSettings);
        }

        /// <summary>
        /// Inserts a promotion for your Merchant Center account. If the promotion
        /// already exists, then it updates the promotion instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Promotion> InsertPromotionAsync(InsertPromotionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertPromotionRequest(ref request, ref callSettings);
            return _callInsertPromotion.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the promotion from your Merchant Center account.
        /// 
        /// After inserting or updating a promotion input, it may take several
        /// minutes before the updated promotion can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Promotion GetPromotion(GetPromotionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPromotionRequest(ref request, ref callSettings);
            return _callGetPromotion.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the promotion from your Merchant Center account.
        /// 
        /// After inserting or updating a promotion input, it may take several
        /// minutes before the updated promotion can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Promotion> GetPromotionAsync(GetPromotionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPromotionRequest(ref request, ref callSettings);
            return _callGetPromotion.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the promotions in your Merchant Center account. The
        /// response might contain fewer items than specified by `pageSize`. Rely on
        /// `pageToken` to determine if there are more items to be requested.
        /// 
        /// After inserting or updating a promotion, it may take several minutes before
        /// the updated processed promotion can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Promotion"/> resources.</returns>
        public override gax::PagedEnumerable<ListPromotionsResponse, Promotion> ListPromotions(ListPromotionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPromotionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPromotionsRequest, ListPromotionsResponse, Promotion>(_callListPromotions, request, callSettings);
        }

        /// <summary>
        /// Lists the promotions in your Merchant Center account. The
        /// response might contain fewer items than specified by `pageSize`. Rely on
        /// `pageToken` to determine if there are more items to be requested.
        /// 
        /// After inserting or updating a promotion, it may take several minutes before
        /// the updated processed promotion can be retrieved.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Promotion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPromotionsResponse, Promotion> ListPromotionsAsync(ListPromotionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPromotionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPromotionsRequest, ListPromotionsResponse, Promotion>(_callListPromotions, request, callSettings);
        }
    }

    public partial class ListPromotionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPromotionsResponse : gaxgrpc::IPageResponse<Promotion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Promotion> GetEnumerator() => Promotions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
