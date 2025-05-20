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

namespace Google.Cloud.Support.V2Beta
{
    /// <summary>Settings for <see cref="FeedServiceClient"/> instances.</summary>
    public sealed partial class FeedServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FeedServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FeedServiceSettings"/>.</returns>
        public static FeedServiceSettings GetDefault() => new FeedServiceSettings();

        /// <summary>Constructs a new <see cref="FeedServiceSettings"/> object with default settings.</summary>
        public FeedServiceSettings()
        {
        }

        private FeedServiceSettings(FeedServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ShowFeedSettings = existing.ShowFeedSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeedServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FeedServiceClient.ShowFeed</c>
        ///  and <c>FeedServiceClient.ShowFeedAsync</c>.
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
        public gaxgrpc::CallSettings ShowFeedSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FeedServiceSettings"/> object.</returns>
        public FeedServiceSettings Clone() => new FeedServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeedServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class FeedServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeedServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeedServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FeedServiceClientBuilder() : base(FeedServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FeedServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeedServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeedServiceClient Build()
        {
            FeedServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeedServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeedServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeedServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeedServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FeedServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeedServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeedServiceClient.ChannelPool;
    }

    /// <summary>FeedService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service to view case feed items.
    /// </remarks>
    public abstract partial class FeedServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeedService service, which is a host of "cloudsupport.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudsupport.googleapis.com:443";

        /// <summary>The default FeedService scopes.</summary>
        /// <remarks>
        /// The default FeedService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FeedService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FeedServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FeedServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FeedServiceClient"/>.</returns>
        public static stt::Task<FeedServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeedServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeedServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FeedServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FeedServiceClient"/>.</returns>
        public static FeedServiceClient Create() => new FeedServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeedServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeedServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FeedServiceClient"/>.</returns>
        internal static FeedServiceClient Create(grpccore::CallInvoker callInvoker, FeedServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeedService.FeedServiceClient grpcClient = new FeedService.FeedServiceClient(callInvoker);
            return new FeedServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FeedService client</summary>
        public virtual FeedService.FeedServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Show items in the feed of this case, including case emails,
        /// attachments, and comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeedItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ShowFeedResponse, FeedItem> ShowFeed(ShowFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Show items in the feed of this case, including case emails,
        /// attachments, and comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeedItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ShowFeedResponse, FeedItem> ShowFeedAsync(ShowFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Show items in the feed of this case, including case emails,
        /// attachments, and comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the case for which feed items should be
        /// listed.
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
        /// <returns>A pageable sequence of <see cref="FeedItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ShowFeedResponse, FeedItem> ShowFeed(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ShowFeedRequest request = new ShowFeedRequest
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
            return ShowFeed(request, callSettings);
        }

        /// <summary>
        /// Show items in the feed of this case, including case emails,
        /// attachments, and comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the case for which feed items should be
        /// listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FeedItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ShowFeedResponse, FeedItem> ShowFeedAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ShowFeedRequest request = new ShowFeedRequest
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
            return ShowFeedAsync(request, callSettings);
        }

        /// <summary>
        /// Show items in the feed of this case, including case emails,
        /// attachments, and comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the case for which feed items should be
        /// listed.
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
        /// <returns>A pageable sequence of <see cref="FeedItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ShowFeedResponse, FeedItem> ShowFeed(CaseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ShowFeedRequest request = new ShowFeedRequest
            {
                ParentAsCaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ShowFeed(request, callSettings);
        }

        /// <summary>
        /// Show items in the feed of this case, including case emails,
        /// attachments, and comments.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the case for which feed items should be
        /// listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FeedItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ShowFeedResponse, FeedItem> ShowFeedAsync(CaseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ShowFeedRequest request = new ShowFeedRequest
            {
                ParentAsCaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ShowFeedAsync(request, callSettings);
        }
    }

    /// <summary>FeedService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service to view case feed items.
    /// </remarks>
    public sealed partial class FeedServiceClientImpl : FeedServiceClient
    {
        private readonly gaxgrpc::ApiCall<ShowFeedRequest, ShowFeedResponse> _callShowFeed;

        /// <summary>
        /// Constructs a client wrapper for the FeedService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FeedServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FeedServiceClientImpl(FeedService.FeedServiceClient grpcClient, FeedServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FeedServiceSettings effectiveSettings = settings ?? FeedServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callShowFeed = clientHelper.BuildApiCall<ShowFeedRequest, ShowFeedResponse>("ShowFeed", grpcClient.ShowFeedAsync, grpcClient.ShowFeed, effectiveSettings.ShowFeedSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callShowFeed);
            Modify_ShowFeedApiCall(ref _callShowFeed);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ShowFeedApiCall(ref gaxgrpc::ApiCall<ShowFeedRequest, ShowFeedResponse> call);

        partial void OnConstruction(FeedService.FeedServiceClient grpcClient, FeedServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeedService client</summary>
        public override FeedService.FeedServiceClient GrpcClient { get; }

        partial void Modify_ShowFeedRequest(ref ShowFeedRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Show items in the feed of this case, including case emails,
        /// attachments, and comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeedItem"/> resources.</returns>
        public override gax::PagedEnumerable<ShowFeedResponse, FeedItem> ShowFeed(ShowFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ShowFeedRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ShowFeedRequest, ShowFeedResponse, FeedItem>(_callShowFeed, request, callSettings);
        }

        /// <summary>
        /// Show items in the feed of this case, including case emails,
        /// attachments, and comments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeedItem"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ShowFeedResponse, FeedItem> ShowFeedAsync(ShowFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ShowFeedRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ShowFeedRequest, ShowFeedResponse, FeedItem>(_callShowFeed, request, callSettings);
        }
    }

    public partial class ShowFeedRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ShowFeedResponse : gaxgrpc::IPageResponse<FeedItem>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FeedItem> GetEnumerator() => FeedItems.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
