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

namespace Google.Shopping.Merchant.Reviews.V1Beta
{
    /// <summary>Settings for <see cref="MerchantReviewsServiceClient"/> instances.</summary>
    public sealed partial class MerchantReviewsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MerchantReviewsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MerchantReviewsServiceSettings"/>.</returns>
        public static MerchantReviewsServiceSettings GetDefault() => new MerchantReviewsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="MerchantReviewsServiceSettings"/> object with default settings.
        /// </summary>
        public MerchantReviewsServiceSettings()
        {
        }

        private MerchantReviewsServiceSettings(MerchantReviewsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetMerchantReviewSettings = existing.GetMerchantReviewSettings;
            ListMerchantReviewsSettings = existing.ListMerchantReviewsSettings;
            InsertMerchantReviewSettings = existing.InsertMerchantReviewSettings;
            DeleteMerchantReviewSettings = existing.DeleteMerchantReviewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MerchantReviewsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MerchantReviewsServiceClient.GetMerchantReview</c> and
        /// <c>MerchantReviewsServiceClient.GetMerchantReviewAsync</c>.
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
        public gaxgrpc::CallSettings GetMerchantReviewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MerchantReviewsServiceClient.ListMerchantReviews</c> and
        /// <c>MerchantReviewsServiceClient.ListMerchantReviewsAsync</c>.
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
        public gaxgrpc::CallSettings ListMerchantReviewsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MerchantReviewsServiceClient.InsertMerchantReview</c> and
        /// <c>MerchantReviewsServiceClient.InsertMerchantReviewAsync</c>.
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
        public gaxgrpc::CallSettings InsertMerchantReviewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MerchantReviewsServiceClient.DeleteMerchantReview</c> and
        /// <c>MerchantReviewsServiceClient.DeleteMerchantReviewAsync</c>.
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
        public gaxgrpc::CallSettings DeleteMerchantReviewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MerchantReviewsServiceSettings"/> object.</returns>
        public MerchantReviewsServiceSettings Clone() => new MerchantReviewsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MerchantReviewsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class MerchantReviewsServiceClientBuilder : gaxgrpc::ClientBuilderBase<MerchantReviewsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MerchantReviewsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MerchantReviewsServiceClientBuilder() : base(MerchantReviewsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MerchantReviewsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MerchantReviewsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MerchantReviewsServiceClient Build()
        {
            MerchantReviewsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MerchantReviewsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MerchantReviewsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MerchantReviewsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MerchantReviewsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MerchantReviewsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MerchantReviewsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MerchantReviewsServiceClient.ChannelPool;
    }

    /// <summary>MerchantReviewsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage merchant reviews.
    /// </remarks>
    public abstract partial class MerchantReviewsServiceClient
    {
        /// <summary>
        /// The default endpoint for the MerchantReviewsService service, which is a host of "merchantapi.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default MerchantReviewsService scopes.</summary>
        /// <remarks>
        /// The default MerchantReviewsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MerchantReviewsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MerchantReviewsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="MerchantReviewsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MerchantReviewsServiceClient"/>.</returns>
        public static stt::Task<MerchantReviewsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MerchantReviewsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MerchantReviewsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="MerchantReviewsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MerchantReviewsServiceClient"/>.</returns>
        public static MerchantReviewsServiceClient Create() => new MerchantReviewsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MerchantReviewsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MerchantReviewsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MerchantReviewsServiceClient"/>.</returns>
        internal static MerchantReviewsServiceClient Create(grpccore::CallInvoker callInvoker, MerchantReviewsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MerchantReviewsService.MerchantReviewsServiceClient grpcClient = new MerchantReviewsService.MerchantReviewsServiceClient(callInvoker);
            return new MerchantReviewsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MerchantReviewsService client</summary>
        public virtual MerchantReviewsService.MerchantReviewsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a merchant review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MerchantReview GetMerchantReview(GetMerchantReviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a merchant review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MerchantReview> GetMerchantReviewAsync(GetMerchantReviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a merchant review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MerchantReview> GetMerchantReviewAsync(GetMerchantReviewRequest request, st::CancellationToken cancellationToken) =>
            GetMerchantReviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a merchant review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/merchantReviews/{merchantReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MerchantReview GetMerchantReview(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMerchantReview(new GetMerchantReviewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a merchant review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/merchantReviews/{merchantReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MerchantReview> GetMerchantReviewAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMerchantReviewAsync(new GetMerchantReviewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a merchant review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/merchantReviews/{merchantReview}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MerchantReview> GetMerchantReviewAsync(string name, st::CancellationToken cancellationToken) =>
            GetMerchantReviewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a merchant review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/merchantReviews/{merchantReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MerchantReview GetMerchantReview(MerchantReviewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMerchantReview(new GetMerchantReviewRequest
            {
                MerchantReviewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a merchant review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/merchantReviews/{merchantReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MerchantReview> GetMerchantReviewAsync(MerchantReviewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMerchantReviewAsync(new GetMerchantReviewRequest
            {
                MerchantReviewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a merchant review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/merchantReviews/{merchantReview}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MerchantReview> GetMerchantReviewAsync(MerchantReviewName name, st::CancellationToken cancellationToken) =>
            GetMerchantReviewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists merchant reviews.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MerchantReview"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMerchantReviewsResponse, MerchantReview> ListMerchantReviews(ListMerchantReviewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists merchant reviews.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MerchantReview"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMerchantReviewsResponse, MerchantReview> ListMerchantReviewsAsync(ListMerchantReviewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists merchant reviews.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list merchant reviews for.
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
        /// <returns>A pageable sequence of <see cref="MerchantReview"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMerchantReviewsResponse, MerchantReview> ListMerchantReviews(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMerchantReviewsRequest request = new ListMerchantReviewsRequest
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
            return ListMerchantReviews(request, callSettings);
        }

        /// <summary>
        /// Lists merchant reviews.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list merchant reviews for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MerchantReview"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMerchantReviewsResponse, MerchantReview> ListMerchantReviewsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMerchantReviewsRequest request = new ListMerchantReviewsRequest
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
            return ListMerchantReviewsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists merchant reviews.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list merchant reviews for.
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
        /// <returns>A pageable sequence of <see cref="MerchantReview"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMerchantReviewsResponse, MerchantReview> ListMerchantReviews(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMerchantReviewsRequest request = new ListMerchantReviewsRequest
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
            return ListMerchantReviews(request, callSettings);
        }

        /// <summary>
        /// Lists merchant reviews.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list merchant reviews for.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MerchantReview"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMerchantReviewsResponse, MerchantReview> ListMerchantReviewsAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMerchantReviewsRequest request = new ListMerchantReviewsRequest
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
            return ListMerchantReviewsAsync(request, callSettings);
        }

        /// <summary>
        /// Inserts a review for your Merchant Center account. If the review
        /// already exists, then the review is replaced with the new instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MerchantReview InsertMerchantReview(InsertMerchantReviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a review for your Merchant Center account. If the review
        /// already exists, then the review is replaced with the new instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MerchantReview> InsertMerchantReviewAsync(InsertMerchantReviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a review for your Merchant Center account. If the review
        /// already exists, then the review is replaced with the new instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MerchantReview> InsertMerchantReviewAsync(InsertMerchantReviewRequest request, st::CancellationToken cancellationToken) =>
            InsertMerchantReviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes merchant review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMerchantReview(DeleteMerchantReviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes merchant review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMerchantReviewAsync(DeleteMerchantReviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes merchant review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMerchantReviewAsync(DeleteMerchantReviewRequest request, st::CancellationToken cancellationToken) =>
            DeleteMerchantReviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes merchant review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/merchantReviews/{merchantReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMerchantReview(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMerchantReview(new DeleteMerchantReviewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes merchant review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/merchantReviews/{merchantReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMerchantReviewAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMerchantReviewAsync(new DeleteMerchantReviewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes merchant review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/merchantReviews/{merchantReview}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMerchantReviewAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMerchantReviewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes merchant review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/merchantReviews/{merchantReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMerchantReview(MerchantReviewName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMerchantReview(new DeleteMerchantReviewRequest
            {
                MerchantReviewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes merchant review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/merchantReviews/{merchantReview}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMerchantReviewAsync(MerchantReviewName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMerchantReviewAsync(new DeleteMerchantReviewRequest
            {
                MerchantReviewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes merchant review.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the merchant review.
        /// Format: accounts/{account}/merchantReviews/{merchantReview}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMerchantReviewAsync(MerchantReviewName name, st::CancellationToken cancellationToken) =>
            DeleteMerchantReviewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MerchantReviewsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage merchant reviews.
    /// </remarks>
    public sealed partial class MerchantReviewsServiceClientImpl : MerchantReviewsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetMerchantReviewRequest, MerchantReview> _callGetMerchantReview;

        private readonly gaxgrpc::ApiCall<ListMerchantReviewsRequest, ListMerchantReviewsResponse> _callListMerchantReviews;

        private readonly gaxgrpc::ApiCall<InsertMerchantReviewRequest, MerchantReview> _callInsertMerchantReview;

        private readonly gaxgrpc::ApiCall<DeleteMerchantReviewRequest, wkt::Empty> _callDeleteMerchantReview;

        /// <summary>
        /// Constructs a client wrapper for the MerchantReviewsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="MerchantReviewsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MerchantReviewsServiceClientImpl(MerchantReviewsService.MerchantReviewsServiceClient grpcClient, MerchantReviewsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MerchantReviewsServiceSettings effectiveSettings = settings ?? MerchantReviewsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetMerchantReview = clientHelper.BuildApiCall<GetMerchantReviewRequest, MerchantReview>("GetMerchantReview", grpcClient.GetMerchantReviewAsync, grpcClient.GetMerchantReview, effectiveSettings.GetMerchantReviewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMerchantReview);
            Modify_GetMerchantReviewApiCall(ref _callGetMerchantReview);
            _callListMerchantReviews = clientHelper.BuildApiCall<ListMerchantReviewsRequest, ListMerchantReviewsResponse>("ListMerchantReviews", grpcClient.ListMerchantReviewsAsync, grpcClient.ListMerchantReviews, effectiveSettings.ListMerchantReviewsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMerchantReviews);
            Modify_ListMerchantReviewsApiCall(ref _callListMerchantReviews);
            _callInsertMerchantReview = clientHelper.BuildApiCall<InsertMerchantReviewRequest, MerchantReview>("InsertMerchantReview", grpcClient.InsertMerchantReviewAsync, grpcClient.InsertMerchantReview, effectiveSettings.InsertMerchantReviewSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callInsertMerchantReview);
            Modify_InsertMerchantReviewApiCall(ref _callInsertMerchantReview);
            _callDeleteMerchantReview = clientHelper.BuildApiCall<DeleteMerchantReviewRequest, wkt::Empty>("DeleteMerchantReview", grpcClient.DeleteMerchantReviewAsync, grpcClient.DeleteMerchantReview, effectiveSettings.DeleteMerchantReviewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMerchantReview);
            Modify_DeleteMerchantReviewApiCall(ref _callDeleteMerchantReview);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetMerchantReviewApiCall(ref gaxgrpc::ApiCall<GetMerchantReviewRequest, MerchantReview> call);

        partial void Modify_ListMerchantReviewsApiCall(ref gaxgrpc::ApiCall<ListMerchantReviewsRequest, ListMerchantReviewsResponse> call);

        partial void Modify_InsertMerchantReviewApiCall(ref gaxgrpc::ApiCall<InsertMerchantReviewRequest, MerchantReview> call);

        partial void Modify_DeleteMerchantReviewApiCall(ref gaxgrpc::ApiCall<DeleteMerchantReviewRequest, wkt::Empty> call);

        partial void OnConstruction(MerchantReviewsService.MerchantReviewsServiceClient grpcClient, MerchantReviewsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MerchantReviewsService client</summary>
        public override MerchantReviewsService.MerchantReviewsServiceClient GrpcClient { get; }

        partial void Modify_GetMerchantReviewRequest(ref GetMerchantReviewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMerchantReviewsRequest(ref ListMerchantReviewsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertMerchantReviewRequest(ref InsertMerchantReviewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMerchantReviewRequest(ref DeleteMerchantReviewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a merchant review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MerchantReview GetMerchantReview(GetMerchantReviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMerchantReviewRequest(ref request, ref callSettings);
            return _callGetMerchantReview.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a merchant review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MerchantReview> GetMerchantReviewAsync(GetMerchantReviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMerchantReviewRequest(ref request, ref callSettings);
            return _callGetMerchantReview.Async(request, callSettings);
        }

        /// <summary>
        /// Lists merchant reviews.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MerchantReview"/> resources.</returns>
        public override gax::PagedEnumerable<ListMerchantReviewsResponse, MerchantReview> ListMerchantReviews(ListMerchantReviewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMerchantReviewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMerchantReviewsRequest, ListMerchantReviewsResponse, MerchantReview>(_callListMerchantReviews, request, callSettings);
        }

        /// <summary>
        /// Lists merchant reviews.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MerchantReview"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMerchantReviewsResponse, MerchantReview> ListMerchantReviewsAsync(ListMerchantReviewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMerchantReviewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMerchantReviewsRequest, ListMerchantReviewsResponse, MerchantReview>(_callListMerchantReviews, request, callSettings);
        }

        /// <summary>
        /// Inserts a review for your Merchant Center account. If the review
        /// already exists, then the review is replaced with the new instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MerchantReview InsertMerchantReview(InsertMerchantReviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertMerchantReviewRequest(ref request, ref callSettings);
            return _callInsertMerchantReview.Sync(request, callSettings);
        }

        /// <summary>
        /// Inserts a review for your Merchant Center account. If the review
        /// already exists, then the review is replaced with the new instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MerchantReview> InsertMerchantReviewAsync(InsertMerchantReviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertMerchantReviewRequest(ref request, ref callSettings);
            return _callInsertMerchantReview.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes merchant review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteMerchantReview(DeleteMerchantReviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMerchantReviewRequest(ref request, ref callSettings);
            _callDeleteMerchantReview.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes merchant review.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteMerchantReviewAsync(DeleteMerchantReviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMerchantReviewRequest(ref request, ref callSettings);
            return _callDeleteMerchantReview.Async(request, callSettings);
        }
    }

    public partial class ListMerchantReviewsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMerchantReviewsResponse : gaxgrpc::IPageResponse<MerchantReview>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MerchantReview> GetEnumerator() => MerchantReviews.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
