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

namespace Google.Cloud.Recommender.V1
{
    /// <summary>Settings for <see cref="RecommenderClient"/> instances.</summary>
    public sealed partial class RecommenderSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RecommenderSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RecommenderSettings"/>.</returns>
        public static RecommenderSettings GetDefault() => new RecommenderSettings();

        /// <summary>Constructs a new <see cref="RecommenderSettings"/> object with default settings.</summary>
        public RecommenderSettings()
        {
        }

        private RecommenderSettings(RecommenderSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInsightsSettings = existing.ListInsightsSettings;
            GetInsightSettings = existing.GetInsightSettings;
            MarkInsightAcceptedSettings = existing.MarkInsightAcceptedSettings;
            ListRecommendationsSettings = existing.ListRecommendationsSettings;
            GetRecommendationSettings = existing.GetRecommendationSettings;
            MarkRecommendationDismissedSettings = existing.MarkRecommendationDismissedSettings;
            MarkRecommendationClaimedSettings = existing.MarkRecommendationClaimedSettings;
            MarkRecommendationSucceededSettings = existing.MarkRecommendationSucceededSettings;
            MarkRecommendationFailedSettings = existing.MarkRecommendationFailedSettings;
            GetRecommenderConfigSettings = existing.GetRecommenderConfigSettings;
            UpdateRecommenderConfigSettings = existing.UpdateRecommenderConfigSettings;
            GetInsightTypeConfigSettings = existing.GetInsightTypeConfigSettings;
            UpdateInsightTypeConfigSettings = existing.UpdateInsightTypeConfigSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RecommenderSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.ListInsights</c> and <c>RecommenderClient.ListInsightsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInsightsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.GetInsight</c> and <c>RecommenderClient.GetInsightAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInsightSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.MarkInsightAccepted</c> and <c>RecommenderClient.MarkInsightAcceptedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MarkInsightAcceptedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.ListRecommendations</c> and <c>RecommenderClient.ListRecommendationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRecommendationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.GetRecommendation</c> and <c>RecommenderClient.GetRecommendationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRecommendationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.MarkRecommendationDismissed</c> and
        /// <c>RecommenderClient.MarkRecommendationDismissedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MarkRecommendationDismissedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.MarkRecommendationClaimed</c> and <c>RecommenderClient.MarkRecommendationClaimedAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MarkRecommendationClaimedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.MarkRecommendationSucceeded</c> and
        /// <c>RecommenderClient.MarkRecommendationSucceededAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MarkRecommendationSucceededSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.MarkRecommendationFailed</c> and <c>RecommenderClient.MarkRecommendationFailedAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MarkRecommendationFailedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.GetRecommenderConfig</c> and <c>RecommenderClient.GetRecommenderConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRecommenderConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.UpdateRecommenderConfig</c> and <c>RecommenderClient.UpdateRecommenderConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRecommenderConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.GetInsightTypeConfig</c> and <c>RecommenderClient.GetInsightTypeConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInsightTypeConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommenderClient.UpdateInsightTypeConfig</c> and <c>RecommenderClient.UpdateInsightTypeConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInsightTypeConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RecommenderSettings"/> object.</returns>
        public RecommenderSettings Clone() => new RecommenderSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RecommenderClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class RecommenderClientBuilder : gaxgrpc::ClientBuilderBase<RecommenderClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RecommenderSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RecommenderClientBuilder() : base(RecommenderClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RecommenderClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RecommenderClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RecommenderClient Build()
        {
            RecommenderClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RecommenderClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RecommenderClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RecommenderClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RecommenderClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RecommenderClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RecommenderClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RecommenderClient.ChannelPool;
    }

    /// <summary>Recommender client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides insights and recommendations for cloud customers for various
    /// categories like performance optimization, cost savings, reliability, feature
    /// discovery, etc. Insights and recommendations are generated automatically
    /// based on analysis of user resources, configuration and monitoring metrics.
    /// </remarks>
    public abstract partial class RecommenderClient
    {
        /// <summary>
        /// The default endpoint for the Recommender service, which is a host of "recommender.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "recommender.googleapis.com:443";

        /// <summary>The default Recommender scopes.</summary>
        /// <remarks>
        /// The default Recommender scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Recommender.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RecommenderClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RecommenderClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RecommenderClient"/>.</returns>
        public static stt::Task<RecommenderClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RecommenderClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RecommenderClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RecommenderClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RecommenderClient"/>.</returns>
        public static RecommenderClient Create() => new RecommenderClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RecommenderClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RecommenderSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RecommenderClient"/>.</returns>
        internal static RecommenderClient Create(grpccore::CallInvoker callInvoker, RecommenderSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Recommender.RecommenderClient grpcClient = new Recommender.RecommenderClient(callInvoker);
            return new RecommenderClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Recommender client</summary>
        public virtual Recommender.RecommenderClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists insights for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified insight type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Insight"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInsightsResponse, Insight> ListInsights(ListInsightsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists insights for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified insight type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Insight"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInsightsResponse, Insight> ListInsightsAsync(ListInsightsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists insights for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified insight type.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `folders/[FOLDER_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// INSIGHT_TYPE_ID refers to supported insight types:
        /// https://cloud.google.com/recommender/docs/insights/insight-types.
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
        /// <returns>A pageable sequence of <see cref="Insight"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInsightsResponse, Insight> ListInsights(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInsightsRequest request = new ListInsightsRequest
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
            return ListInsights(request, callSettings);
        }

        /// <summary>
        /// Lists insights for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified insight type.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `folders/[FOLDER_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// INSIGHT_TYPE_ID refers to supported insight types:
        /// https://cloud.google.com/recommender/docs/insights/insight-types.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Insight"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInsightsResponse, Insight> ListInsightsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInsightsRequest request = new ListInsightsRequest
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
            return ListInsightsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists insights for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified insight type.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `folders/[FOLDER_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// INSIGHT_TYPE_ID refers to supported insight types:
        /// https://cloud.google.com/recommender/docs/insights/insight-types.
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
        /// <returns>A pageable sequence of <see cref="Insight"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInsightsResponse, Insight> ListInsights(InsightTypeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInsightsRequest request = new ListInsightsRequest
            {
                ParentAsInsightTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInsights(request, callSettings);
        }

        /// <summary>
        /// Lists insights for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified insight type.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `folders/[FOLDER_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]`
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// INSIGHT_TYPE_ID refers to supported insight types:
        /// https://cloud.google.com/recommender/docs/insights/insight-types.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Insight"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInsightsResponse, Insight> ListInsightsAsync(InsightTypeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInsightsRequest request = new ListInsightsRequest
            {
                ParentAsInsightTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInsightsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the requested insight. Requires the recommender.*.get IAM permission
        /// for the specified insight type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Insight GetInsight(GetInsightRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the requested insight. Requires the recommender.*.get IAM permission
        /// for the specified insight type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Insight> GetInsightAsync(GetInsightRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the requested insight. Requires the recommender.*.get IAM permission
        /// for the specified insight type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Insight> GetInsightAsync(GetInsightRequest request, st::CancellationToken cancellationToken) =>
            GetInsightAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the requested insight. Requires the recommender.*.get IAM permission
        /// for the specified insight type.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the insight.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Insight GetInsight(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInsight(new GetInsightRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested insight. Requires the recommender.*.get IAM permission
        /// for the specified insight type.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the insight.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Insight> GetInsightAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInsightAsync(new GetInsightRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested insight. Requires the recommender.*.get IAM permission
        /// for the specified insight type.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the insight.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Insight> GetInsightAsync(string name, st::CancellationToken cancellationToken) =>
            GetInsightAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the requested insight. Requires the recommender.*.get IAM permission
        /// for the specified insight type.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the insight.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Insight GetInsight(InsightName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInsight(new GetInsightRequest
            {
                InsightName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested insight. Requires the recommender.*.get IAM permission
        /// for the specified insight type.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the insight.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Insight> GetInsightAsync(InsightName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInsightAsync(new GetInsightRequest
            {
                InsightName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested insight. Requires the recommender.*.get IAM permission
        /// for the specified insight type.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the insight.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Insight> GetInsightAsync(InsightName name, st::CancellationToken cancellationToken) =>
            GetInsightAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks the Insight State as Accepted. Users can use this method to
        /// indicate to the Recommender API that they have applied some action based
        /// on the insight. This stops the insight content from being updated.
        /// 
        /// MarkInsightAccepted can be applied to insights in ACTIVE state. Requires
        /// the recommender.*.update IAM permission for the specified insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Insight MarkInsightAccepted(MarkInsightAcceptedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks the Insight State as Accepted. Users can use this method to
        /// indicate to the Recommender API that they have applied some action based
        /// on the insight. This stops the insight content from being updated.
        /// 
        /// MarkInsightAccepted can be applied to insights in ACTIVE state. Requires
        /// the recommender.*.update IAM permission for the specified insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Insight> MarkInsightAcceptedAsync(MarkInsightAcceptedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks the Insight State as Accepted. Users can use this method to
        /// indicate to the Recommender API that they have applied some action based
        /// on the insight. This stops the insight content from being updated.
        /// 
        /// MarkInsightAccepted can be applied to insights in ACTIVE state. Requires
        /// the recommender.*.update IAM permission for the specified insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Insight> MarkInsightAcceptedAsync(MarkInsightAcceptedRequest request, st::CancellationToken cancellationToken) =>
            MarkInsightAcceptedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks the Insight State as Accepted. Users can use this method to
        /// indicate to the Recommender API that they have applied some action based
        /// on the insight. This stops the insight content from being updated.
        /// 
        /// MarkInsightAccepted can be applied to insights in ACTIVE state. Requires
        /// the recommender.*.update IAM permission for the specified insight.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the insight.
        /// </param>
        /// <param name="stateMetadata">
        /// Optional. State properties user wish to include with this state.  Full
        /// replace of the current state_metadata.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Insight. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Insight MarkInsightAccepted(string name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkInsightAccepted(new MarkInsightAcceptedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Insight State as Accepted. Users can use this method to
        /// indicate to the Recommender API that they have applied some action based
        /// on the insight. This stops the insight content from being updated.
        /// 
        /// MarkInsightAccepted can be applied to insights in ACTIVE state. Requires
        /// the recommender.*.update IAM permission for the specified insight.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the insight.
        /// </param>
        /// <param name="stateMetadata">
        /// Optional. State properties user wish to include with this state.  Full
        /// replace of the current state_metadata.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Insight. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Insight> MarkInsightAcceptedAsync(string name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkInsightAcceptedAsync(new MarkInsightAcceptedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Insight State as Accepted. Users can use this method to
        /// indicate to the Recommender API that they have applied some action based
        /// on the insight. This stops the insight content from being updated.
        /// 
        /// MarkInsightAccepted can be applied to insights in ACTIVE state. Requires
        /// the recommender.*.update IAM permission for the specified insight.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the insight.
        /// </param>
        /// <param name="stateMetadata">
        /// Optional. State properties user wish to include with this state.  Full
        /// replace of the current state_metadata.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Insight. Provides optimistic locking.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Insight> MarkInsightAcceptedAsync(string name, scg::IDictionary<string, string> stateMetadata, string etag, st::CancellationToken cancellationToken) =>
            MarkInsightAcceptedAsync(name, stateMetadata, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks the Insight State as Accepted. Users can use this method to
        /// indicate to the Recommender API that they have applied some action based
        /// on the insight. This stops the insight content from being updated.
        /// 
        /// MarkInsightAccepted can be applied to insights in ACTIVE state. Requires
        /// the recommender.*.update IAM permission for the specified insight.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the insight.
        /// </param>
        /// <param name="stateMetadata">
        /// Optional. State properties user wish to include with this state.  Full
        /// replace of the current state_metadata.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Insight. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Insight MarkInsightAccepted(InsightName name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkInsightAccepted(new MarkInsightAcceptedRequest
            {
                InsightName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Insight State as Accepted. Users can use this method to
        /// indicate to the Recommender API that they have applied some action based
        /// on the insight. This stops the insight content from being updated.
        /// 
        /// MarkInsightAccepted can be applied to insights in ACTIVE state. Requires
        /// the recommender.*.update IAM permission for the specified insight.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the insight.
        /// </param>
        /// <param name="stateMetadata">
        /// Optional. State properties user wish to include with this state.  Full
        /// replace of the current state_metadata.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Insight. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Insight> MarkInsightAcceptedAsync(InsightName name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkInsightAcceptedAsync(new MarkInsightAcceptedRequest
            {
                InsightName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Insight State as Accepted. Users can use this method to
        /// indicate to the Recommender API that they have applied some action based
        /// on the insight. This stops the insight content from being updated.
        /// 
        /// MarkInsightAccepted can be applied to insights in ACTIVE state. Requires
        /// the recommender.*.update IAM permission for the specified insight.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the insight.
        /// </param>
        /// <param name="stateMetadata">
        /// Optional. State properties user wish to include with this state.  Full
        /// replace of the current state_metadata.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Insight. Provides optimistic locking.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Insight> MarkInsightAcceptedAsync(InsightName name, scg::IDictionary<string, string> stateMetadata, string etag, st::CancellationToken cancellationToken) =>
            MarkInsightAcceptedAsync(name, stateMetadata, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists recommendations for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendations(ListRecommendationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists recommendations for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendationsAsync(ListRecommendationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists recommendations for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// RECOMMENDER_ID refers to supported recommenders:
        /// https://cloud.google.com/recommender/docs/recommenders.
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
        /// <returns>A pageable sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecommendationsRequest request = new ListRecommendationsRequest
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
            return ListRecommendations(request, callSettings);
        }

        /// <summary>
        /// Lists recommendations for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// RECOMMENDER_ID refers to supported recommenders:
        /// https://cloud.google.com/recommender/docs/recommenders.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecommendationsRequest request = new ListRecommendationsRequest
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
            return ListRecommendationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists recommendations for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// RECOMMENDER_ID refers to supported recommenders:
        /// https://cloud.google.com/recommender/docs/recommenders.
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
        /// <returns>A pageable sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendations(RecommenderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecommendationsRequest request = new ListRecommendationsRequest
            {
                ParentAsRecommenderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRecommendations(request, callSettings);
        }

        /// <summary>
        /// Lists recommendations for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// RECOMMENDER_ID refers to supported recommenders:
        /// https://cloud.google.com/recommender/docs/recommenders.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendationsAsync(RecommenderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecommendationsRequest request = new ListRecommendationsRequest
            {
                ParentAsRecommenderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRecommendationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists recommendations for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// RECOMMENDER_ID refers to supported recommenders:
        /// https://cloud.google.com/recommender/docs/recommenders.
        /// </param>
        /// <param name="filter">
        /// Filter expression to restrict the recommendations returned. Supported
        /// filter fields:
        /// 
        /// * `state_info.state`
        /// 
        /// * `recommenderSubtype`
        /// 
        /// * `priority`
        /// 
        /// * `targetResources`
        /// 
        /// Examples:
        /// 
        /// * `stateInfo.state = ACTIVE OR stateInfo.state = DISMISSED`
        /// 
        /// * `recommenderSubtype = REMOVE_ROLE OR recommenderSubtype = REPLACE_ROLE`
        /// 
        /// * `priority = P1 OR priority = P2`
        /// 
        /// * `targetResources :
        /// //compute.googleapis.com/projects/1234/zones/us-central1-a/instances/instance-1`
        /// 
        /// * `stateInfo.state = ACTIVE AND (priority = P1 OR priority = P2)`
        /// 
        /// The max allowed filter length is 500 characters.
        /// 
        /// (These expressions are based on the filter language described at
        /// https://google.aip.dev/160)
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
        /// <returns>A pageable sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendations(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecommendationsRequest request = new ListRecommendationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRecommendations(request, callSettings);
        }

        /// <summary>
        /// Lists recommendations for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// RECOMMENDER_ID refers to supported recommenders:
        /// https://cloud.google.com/recommender/docs/recommenders.
        /// </param>
        /// <param name="filter">
        /// Filter expression to restrict the recommendations returned. Supported
        /// filter fields:
        /// 
        /// * `state_info.state`
        /// 
        /// * `recommenderSubtype`
        /// 
        /// * `priority`
        /// 
        /// * `targetResources`
        /// 
        /// Examples:
        /// 
        /// * `stateInfo.state = ACTIVE OR stateInfo.state = DISMISSED`
        /// 
        /// * `recommenderSubtype = REMOVE_ROLE OR recommenderSubtype = REPLACE_ROLE`
        /// 
        /// * `priority = P1 OR priority = P2`
        /// 
        /// * `targetResources :
        /// //compute.googleapis.com/projects/1234/zones/us-central1-a/instances/instance-1`
        /// 
        /// * `stateInfo.state = ACTIVE AND (priority = P1 OR priority = P2)`
        /// 
        /// The max allowed filter length is 500 characters.
        /// 
        /// (These expressions are based on the filter language described at
        /// https://google.aip.dev/160)
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
        /// <returns>A pageable asynchronous sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendationsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecommendationsRequest request = new ListRecommendationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRecommendationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists recommendations for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// RECOMMENDER_ID refers to supported recommenders:
        /// https://cloud.google.com/recommender/docs/recommenders.
        /// </param>
        /// <param name="filter">
        /// Filter expression to restrict the recommendations returned. Supported
        /// filter fields:
        /// 
        /// * `state_info.state`
        /// 
        /// * `recommenderSubtype`
        /// 
        /// * `priority`
        /// 
        /// * `targetResources`
        /// 
        /// Examples:
        /// 
        /// * `stateInfo.state = ACTIVE OR stateInfo.state = DISMISSED`
        /// 
        /// * `recommenderSubtype = REMOVE_ROLE OR recommenderSubtype = REPLACE_ROLE`
        /// 
        /// * `priority = P1 OR priority = P2`
        /// 
        /// * `targetResources :
        /// //compute.googleapis.com/projects/1234/zones/us-central1-a/instances/instance-1`
        /// 
        /// * `stateInfo.state = ACTIVE AND (priority = P1 OR priority = P2)`
        /// 
        /// The max allowed filter length is 500 characters.
        /// 
        /// (These expressions are based on the filter language described at
        /// https://google.aip.dev/160)
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
        /// <returns>A pageable sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendations(RecommenderName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecommendationsRequest request = new ListRecommendationsRequest
            {
                ParentAsRecommenderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRecommendations(request, callSettings);
        }

        /// <summary>
        /// Lists recommendations for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified recommender.
        /// </summary>
        /// <param name="parent">
        /// Required. The container resource on which to execute the request.
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `folders/[FOLDER_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]`
        /// 
        /// LOCATION here refers to GCP Locations:
        /// https://cloud.google.com/about/locations/
        /// RECOMMENDER_ID refers to supported recommenders:
        /// https://cloud.google.com/recommender/docs/recommenders.
        /// </param>
        /// <param name="filter">
        /// Filter expression to restrict the recommendations returned. Supported
        /// filter fields:
        /// 
        /// * `state_info.state`
        /// 
        /// * `recommenderSubtype`
        /// 
        /// * `priority`
        /// 
        /// * `targetResources`
        /// 
        /// Examples:
        /// 
        /// * `stateInfo.state = ACTIVE OR stateInfo.state = DISMISSED`
        /// 
        /// * `recommenderSubtype = REMOVE_ROLE OR recommenderSubtype = REPLACE_ROLE`
        /// 
        /// * `priority = P1 OR priority = P2`
        /// 
        /// * `targetResources :
        /// //compute.googleapis.com/projects/1234/zones/us-central1-a/instances/instance-1`
        /// 
        /// * `stateInfo.state = ACTIVE AND (priority = P1 OR priority = P2)`
        /// 
        /// The max allowed filter length is 500 characters.
        /// 
        /// (These expressions are based on the filter language described at
        /// https://google.aip.dev/160)
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
        /// <returns>A pageable asynchronous sequence of <see cref="Recommendation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendationsAsync(RecommenderName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecommendationsRequest request = new ListRecommendationsRequest
            {
                ParentAsRecommenderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRecommendationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation GetRecommendation(GetRecommendationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> GetRecommendationAsync(GetRecommendationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> GetRecommendationAsync(GetRecommendationRequest request, st::CancellationToken cancellationToken) =>
            GetRecommendationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation GetRecommendation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecommendation(new GetRecommendationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> GetRecommendationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecommendationAsync(new GetRecommendationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> GetRecommendationAsync(string name, st::CancellationToken cancellationToken) =>
            GetRecommendationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation GetRecommendation(RecommendationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecommendation(new GetRecommendationRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> GetRecommendationAsync(RecommendationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecommendationAsync(new GetRecommendationRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> GetRecommendationAsync(RecommendationName name, st::CancellationToken cancellationToken) =>
            GetRecommendationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mark the Recommendation State as Dismissed. Users can use this method to
        /// indicate to the Recommender API that an ACTIVE recommendation has to
        /// be marked back as DISMISSED.
        /// 
        /// MarkRecommendationDismissed can be applied to recommendations in ACTIVE
        /// state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationDismissed(MarkRecommendationDismissedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mark the Recommendation State as Dismissed. Users can use this method to
        /// indicate to the Recommender API that an ACTIVE recommendation has to
        /// be marked back as DISMISSED.
        /// 
        /// MarkRecommendationDismissed can be applied to recommendations in ACTIVE
        /// state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationDismissedAsync(MarkRecommendationDismissedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mark the Recommendation State as Dismissed. Users can use this method to
        /// indicate to the Recommender API that an ACTIVE recommendation has to
        /// be marked back as DISMISSED.
        /// 
        /// MarkRecommendationDismissed can be applied to recommendations in ACTIVE
        /// state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationDismissedAsync(MarkRecommendationDismissedRequest request, st::CancellationToken cancellationToken) =>
            MarkRecommendationDismissedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated. Associated insights are frozen and placed in the ACCEPTED state.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationClaimed(MarkRecommendationClaimedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated. Associated insights are frozen and placed in the ACCEPTED state.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationClaimedAsync(MarkRecommendationClaimedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated. Associated insights are frozen and placed in the ACCEPTED state.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationClaimedAsync(MarkRecommendationClaimedRequest request, st::CancellationToken cancellationToken) =>
            MarkRecommendationClaimedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated. Associated insights are frozen and placed in the ACCEPTED state.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationClaimed(string name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationClaimed(new MarkRecommendationClaimedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated. Associated insights are frozen and placed in the ACCEPTED state.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationClaimedAsync(string name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationClaimedAsync(new MarkRecommendationClaimedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated. Associated insights are frozen and placed in the ACCEPTED state.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationClaimedAsync(string name, scg::IDictionary<string, string> stateMetadata, string etag, st::CancellationToken cancellationToken) =>
            MarkRecommendationClaimedAsync(name, stateMetadata, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated. Associated insights are frozen and placed in the ACCEPTED state.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationClaimed(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationClaimed(new MarkRecommendationClaimedRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated. Associated insights are frozen and placed in the ACCEPTED state.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationClaimedAsync(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationClaimedAsync(new MarkRecommendationClaimedRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated. Associated insights are frozen and placed in the ACCEPTED state.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationClaimedAsync(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, st::CancellationToken cancellationToken) =>
            MarkRecommendationClaimedAsync(name, stateMetadata, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated. Associated insights are frozen and placed in
        /// the ACCEPTED state.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationSucceeded(MarkRecommendationSucceededRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated. Associated insights are frozen and placed in
        /// the ACCEPTED state.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationSucceededAsync(MarkRecommendationSucceededRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated. Associated insights are frozen and placed in
        /// the ACCEPTED state.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationSucceededAsync(MarkRecommendationSucceededRequest request, st::CancellationToken cancellationToken) =>
            MarkRecommendationSucceededAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated. Associated insights are frozen and placed in
        /// the ACCEPTED state.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationSucceeded(string name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationSucceeded(new MarkRecommendationSucceededRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated. Associated insights are frozen and placed in
        /// the ACCEPTED state.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationSucceededAsync(string name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationSucceededAsync(new MarkRecommendationSucceededRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated. Associated insights are frozen and placed in
        /// the ACCEPTED state.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationSucceededAsync(string name, scg::IDictionary<string, string> stateMetadata, string etag, st::CancellationToken cancellationToken) =>
            MarkRecommendationSucceededAsync(name, stateMetadata, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated. Associated insights are frozen and placed in
        /// the ACCEPTED state.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationSucceeded(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationSucceeded(new MarkRecommendationSucceededRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated. Associated insights are frozen and placed in
        /// the ACCEPTED state.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationSucceededAsync(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationSucceededAsync(new MarkRecommendationSucceededRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated. Associated insights are frozen and placed in
        /// the ACCEPTED state.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationSucceededAsync(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, st::CancellationToken cancellationToken) =>
            MarkRecommendationSucceededAsync(name, stateMetadata, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated. Associated insights are frozen and placed in the
        /// ACCEPTED state.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationFailed(MarkRecommendationFailedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated. Associated insights are frozen and placed in the
        /// ACCEPTED state.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationFailedAsync(MarkRecommendationFailedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Marks the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated. Associated insights are frozen and placed in the
        /// ACCEPTED state.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationFailedAsync(MarkRecommendationFailedRequest request, st::CancellationToken cancellationToken) =>
            MarkRecommendationFailedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated. Associated insights are frozen and placed in the
        /// ACCEPTED state.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationFailed(string name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationFailed(new MarkRecommendationFailedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated. Associated insights are frozen and placed in the
        /// ACCEPTED state.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationFailedAsync(string name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationFailedAsync(new MarkRecommendationFailedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated. Associated insights are frozen and placed in the
        /// ACCEPTED state.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationFailedAsync(string name, scg::IDictionary<string, string> stateMetadata, string etag, st::CancellationToken cancellationToken) =>
            MarkRecommendationFailedAsync(name, stateMetadata, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Marks the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated. Associated insights are frozen and placed in the
        /// ACCEPTED state.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recommendation MarkRecommendationFailed(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationFailed(new MarkRecommendationFailedRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated. Associated insights are frozen and placed in the
        /// ACCEPTED state.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationFailedAsync(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, gaxgrpc::CallSettings callSettings = null) =>
            MarkRecommendationFailedAsync(new MarkRecommendationFailedRequest
            {
                RecommendationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                StateMetadata =
                {
                    stateMetadata ?? new scg::Dictionary<string, string>(),
                },
                Etag = gax::GaxPreconditions.CheckNotNullOrEmpty(etag, nameof(etag)),
            }, callSettings);

        /// <summary>
        /// Marks the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated. Associated insights are frozen and placed in the
        /// ACCEPTED state.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the recommendation.
        /// </param>
        /// <param name="stateMetadata">
        /// State properties to include with this state. Overwrites any existing
        /// `state_metadata`.
        /// Keys must match the regex `/^[a-z0-9][a-z0-9_.-]{0,62}$/`.
        /// Values must match the regex `/^[a-zA-Z0-9_./-]{0,255}$/`.
        /// </param>
        /// <param name="etag">
        /// Required. Fingerprint of the Recommendation. Provides optimistic locking.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recommendation> MarkRecommendationFailedAsync(RecommendationName name, scg::IDictionary<string, string> stateMetadata, string etag, st::CancellationToken cancellationToken) =>
            MarkRecommendationFailedAsync(name, stateMetadata, etag, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the requested Recommender Config. There is only one instance of the
        /// config for each Recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RecommenderConfig GetRecommenderConfig(GetRecommenderConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the requested Recommender Config. There is only one instance of the
        /// config for each Recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecommenderConfig> GetRecommenderConfigAsync(GetRecommenderConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the requested Recommender Config. There is only one instance of the
        /// config for each Recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecommenderConfig> GetRecommenderConfigAsync(GetRecommenderConfigRequest request, st::CancellationToken cancellationToken) =>
            GetRecommenderConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the requested Recommender Config. There is only one instance of the
        /// config for each Recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Recommendation Config to get.
        /// 
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RecommenderConfig GetRecommenderConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecommenderConfig(new GetRecommenderConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested Recommender Config. There is only one instance of the
        /// config for each Recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Recommendation Config to get.
        /// 
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecommenderConfig> GetRecommenderConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecommenderConfigAsync(new GetRecommenderConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested Recommender Config. There is only one instance of the
        /// config for each Recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Recommendation Config to get.
        /// 
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecommenderConfig> GetRecommenderConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetRecommenderConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the requested Recommender Config. There is only one instance of the
        /// config for each Recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Recommendation Config to get.
        /// 
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RecommenderConfig GetRecommenderConfig(RecommenderConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecommenderConfig(new GetRecommenderConfigRequest
            {
                RecommenderConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested Recommender Config. There is only one instance of the
        /// config for each Recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Recommendation Config to get.
        /// 
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecommenderConfig> GetRecommenderConfigAsync(RecommenderConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecommenderConfigAsync(new GetRecommenderConfigRequest
            {
                RecommenderConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested Recommender Config. There is only one instance of the
        /// config for each Recommender.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Recommendation Config to get.
        /// 
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/recommenders/[RECOMMENDER_ID]/config`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecommenderConfig> GetRecommenderConfigAsync(RecommenderConfigName name, st::CancellationToken cancellationToken) =>
            GetRecommenderConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Recommender Config. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RecommenderConfig UpdateRecommenderConfig(UpdateRecommenderConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Recommender Config. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecommenderConfig> UpdateRecommenderConfigAsync(UpdateRecommenderConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Recommender Config. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecommenderConfig> UpdateRecommenderConfigAsync(UpdateRecommenderConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateRecommenderConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Recommender Config. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="recommenderConfig">
        /// Required. The RecommenderConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RecommenderConfig UpdateRecommenderConfig(RecommenderConfig recommenderConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRecommenderConfig(new UpdateRecommenderConfigRequest
            {
                RecommenderConfig = gax::GaxPreconditions.CheckNotNull(recommenderConfig, nameof(recommenderConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a Recommender Config. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="recommenderConfig">
        /// Required. The RecommenderConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecommenderConfig> UpdateRecommenderConfigAsync(RecommenderConfig recommenderConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRecommenderConfigAsync(new UpdateRecommenderConfigRequest
            {
                RecommenderConfig = gax::GaxPreconditions.CheckNotNull(recommenderConfig, nameof(recommenderConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a Recommender Config. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="recommenderConfig">
        /// Required. The RecommenderConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecommenderConfig> UpdateRecommenderConfigAsync(RecommenderConfig recommenderConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRecommenderConfigAsync(recommenderConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the requested InsightTypeConfig. There is only one instance of the
        /// config for each InsightType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InsightTypeConfig GetInsightTypeConfig(GetInsightTypeConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the requested InsightTypeConfig. There is only one instance of the
        /// config for each InsightType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightTypeConfig> GetInsightTypeConfigAsync(GetInsightTypeConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the requested InsightTypeConfig. There is only one instance of the
        /// config for each InsightType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightTypeConfig> GetInsightTypeConfigAsync(GetInsightTypeConfigRequest request, st::CancellationToken cancellationToken) =>
            GetInsightTypeConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the requested InsightTypeConfig. There is only one instance of the
        /// config for each InsightType.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the InsightTypeConfig to get.
        /// 
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InsightTypeConfig GetInsightTypeConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInsightTypeConfig(new GetInsightTypeConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested InsightTypeConfig. There is only one instance of the
        /// config for each InsightType.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the InsightTypeConfig to get.
        /// 
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightTypeConfig> GetInsightTypeConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInsightTypeConfigAsync(new GetInsightTypeConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested InsightTypeConfig. There is only one instance of the
        /// config for each InsightType.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the InsightTypeConfig to get.
        /// 
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightTypeConfig> GetInsightTypeConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetInsightTypeConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the requested InsightTypeConfig. There is only one instance of the
        /// config for each InsightType.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the InsightTypeConfig to get.
        /// 
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InsightTypeConfig GetInsightTypeConfig(InsightTypeConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInsightTypeConfig(new GetInsightTypeConfigRequest
            {
                InsightTypeConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested InsightTypeConfig. There is only one instance of the
        /// config for each InsightType.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the InsightTypeConfig to get.
        /// 
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightTypeConfig> GetInsightTypeConfigAsync(InsightTypeConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInsightTypeConfigAsync(new GetInsightTypeConfigRequest
            {
                InsightTypeConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the requested InsightTypeConfig. There is only one instance of the
        /// config for each InsightType.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the InsightTypeConfig to get.
        /// 
        /// Acceptable formats:
        /// 
        /// * `projects/[PROJECT_NUMBER]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// 
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION]/insightTypes/[INSIGHT_TYPE_ID]/config`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightTypeConfig> GetInsightTypeConfigAsync(InsightTypeConfigName name, st::CancellationToken cancellationToken) =>
            GetInsightTypeConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an InsightTypeConfig change. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InsightTypeConfig UpdateInsightTypeConfig(UpdateInsightTypeConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an InsightTypeConfig change. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightTypeConfig> UpdateInsightTypeConfigAsync(UpdateInsightTypeConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an InsightTypeConfig change. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightTypeConfig> UpdateInsightTypeConfigAsync(UpdateInsightTypeConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateInsightTypeConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an InsightTypeConfig change. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="insightTypeConfig">
        /// Required. The InsightTypeConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InsightTypeConfig UpdateInsightTypeConfig(InsightTypeConfig insightTypeConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInsightTypeConfig(new UpdateInsightTypeConfigRequest
            {
                InsightTypeConfig = gax::GaxPreconditions.CheckNotNull(insightTypeConfig, nameof(insightTypeConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an InsightTypeConfig change. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="insightTypeConfig">
        /// Required. The InsightTypeConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightTypeConfig> UpdateInsightTypeConfigAsync(InsightTypeConfig insightTypeConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInsightTypeConfigAsync(new UpdateInsightTypeConfigRequest
            {
                InsightTypeConfig = gax::GaxPreconditions.CheckNotNull(insightTypeConfig, nameof(insightTypeConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an InsightTypeConfig change. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="insightTypeConfig">
        /// Required. The InsightTypeConfig to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InsightTypeConfig> UpdateInsightTypeConfigAsync(InsightTypeConfig insightTypeConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInsightTypeConfigAsync(insightTypeConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Recommender client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides insights and recommendations for cloud customers for various
    /// categories like performance optimization, cost savings, reliability, feature
    /// discovery, etc. Insights and recommendations are generated automatically
    /// based on analysis of user resources, configuration and monitoring metrics.
    /// </remarks>
    public sealed partial class RecommenderClientImpl : RecommenderClient
    {
        private readonly gaxgrpc::ApiCall<ListInsightsRequest, ListInsightsResponse> _callListInsights;

        private readonly gaxgrpc::ApiCall<GetInsightRequest, Insight> _callGetInsight;

        private readonly gaxgrpc::ApiCall<MarkInsightAcceptedRequest, Insight> _callMarkInsightAccepted;

        private readonly gaxgrpc::ApiCall<ListRecommendationsRequest, ListRecommendationsResponse> _callListRecommendations;

        private readonly gaxgrpc::ApiCall<GetRecommendationRequest, Recommendation> _callGetRecommendation;

        private readonly gaxgrpc::ApiCall<MarkRecommendationDismissedRequest, Recommendation> _callMarkRecommendationDismissed;

        private readonly gaxgrpc::ApiCall<MarkRecommendationClaimedRequest, Recommendation> _callMarkRecommendationClaimed;

        private readonly gaxgrpc::ApiCall<MarkRecommendationSucceededRequest, Recommendation> _callMarkRecommendationSucceeded;

        private readonly gaxgrpc::ApiCall<MarkRecommendationFailedRequest, Recommendation> _callMarkRecommendationFailed;

        private readonly gaxgrpc::ApiCall<GetRecommenderConfigRequest, RecommenderConfig> _callGetRecommenderConfig;

        private readonly gaxgrpc::ApiCall<UpdateRecommenderConfigRequest, RecommenderConfig> _callUpdateRecommenderConfig;

        private readonly gaxgrpc::ApiCall<GetInsightTypeConfigRequest, InsightTypeConfig> _callGetInsightTypeConfig;

        private readonly gaxgrpc::ApiCall<UpdateInsightTypeConfigRequest, InsightTypeConfig> _callUpdateInsightTypeConfig;

        /// <summary>
        /// Constructs a client wrapper for the Recommender service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RecommenderSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RecommenderClientImpl(Recommender.RecommenderClient grpcClient, RecommenderSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RecommenderSettings effectiveSettings = settings ?? RecommenderSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListInsights = clientHelper.BuildApiCall<ListInsightsRequest, ListInsightsResponse>("ListInsights", grpcClient.ListInsightsAsync, grpcClient.ListInsights, effectiveSettings.ListInsightsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInsights);
            Modify_ListInsightsApiCall(ref _callListInsights);
            _callGetInsight = clientHelper.BuildApiCall<GetInsightRequest, Insight>("GetInsight", grpcClient.GetInsightAsync, grpcClient.GetInsight, effectiveSettings.GetInsightSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInsight);
            Modify_GetInsightApiCall(ref _callGetInsight);
            _callMarkInsightAccepted = clientHelper.BuildApiCall<MarkInsightAcceptedRequest, Insight>("MarkInsightAccepted", grpcClient.MarkInsightAcceptedAsync, grpcClient.MarkInsightAccepted, effectiveSettings.MarkInsightAcceptedSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMarkInsightAccepted);
            Modify_MarkInsightAcceptedApiCall(ref _callMarkInsightAccepted);
            _callListRecommendations = clientHelper.BuildApiCall<ListRecommendationsRequest, ListRecommendationsResponse>("ListRecommendations", grpcClient.ListRecommendationsAsync, grpcClient.ListRecommendations, effectiveSettings.ListRecommendationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRecommendations);
            Modify_ListRecommendationsApiCall(ref _callListRecommendations);
            _callGetRecommendation = clientHelper.BuildApiCall<GetRecommendationRequest, Recommendation>("GetRecommendation", grpcClient.GetRecommendationAsync, grpcClient.GetRecommendation, effectiveSettings.GetRecommendationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRecommendation);
            Modify_GetRecommendationApiCall(ref _callGetRecommendation);
            _callMarkRecommendationDismissed = clientHelper.BuildApiCall<MarkRecommendationDismissedRequest, Recommendation>("MarkRecommendationDismissed", grpcClient.MarkRecommendationDismissedAsync, grpcClient.MarkRecommendationDismissed, effectiveSettings.MarkRecommendationDismissedSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMarkRecommendationDismissed);
            Modify_MarkRecommendationDismissedApiCall(ref _callMarkRecommendationDismissed);
            _callMarkRecommendationClaimed = clientHelper.BuildApiCall<MarkRecommendationClaimedRequest, Recommendation>("MarkRecommendationClaimed", grpcClient.MarkRecommendationClaimedAsync, grpcClient.MarkRecommendationClaimed, effectiveSettings.MarkRecommendationClaimedSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMarkRecommendationClaimed);
            Modify_MarkRecommendationClaimedApiCall(ref _callMarkRecommendationClaimed);
            _callMarkRecommendationSucceeded = clientHelper.BuildApiCall<MarkRecommendationSucceededRequest, Recommendation>("MarkRecommendationSucceeded", grpcClient.MarkRecommendationSucceededAsync, grpcClient.MarkRecommendationSucceeded, effectiveSettings.MarkRecommendationSucceededSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMarkRecommendationSucceeded);
            Modify_MarkRecommendationSucceededApiCall(ref _callMarkRecommendationSucceeded);
            _callMarkRecommendationFailed = clientHelper.BuildApiCall<MarkRecommendationFailedRequest, Recommendation>("MarkRecommendationFailed", grpcClient.MarkRecommendationFailedAsync, grpcClient.MarkRecommendationFailed, effectiveSettings.MarkRecommendationFailedSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMarkRecommendationFailed);
            Modify_MarkRecommendationFailedApiCall(ref _callMarkRecommendationFailed);
            _callGetRecommenderConfig = clientHelper.BuildApiCall<GetRecommenderConfigRequest, RecommenderConfig>("GetRecommenderConfig", grpcClient.GetRecommenderConfigAsync, grpcClient.GetRecommenderConfig, effectiveSettings.GetRecommenderConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRecommenderConfig);
            Modify_GetRecommenderConfigApiCall(ref _callGetRecommenderConfig);
            _callUpdateRecommenderConfig = clientHelper.BuildApiCall<UpdateRecommenderConfigRequest, RecommenderConfig>("UpdateRecommenderConfig", grpcClient.UpdateRecommenderConfigAsync, grpcClient.UpdateRecommenderConfig, effectiveSettings.UpdateRecommenderConfigSettings).WithGoogleRequestParam("recommender_config.name", request => request.RecommenderConfig?.Name);
            Modify_ApiCall(ref _callUpdateRecommenderConfig);
            Modify_UpdateRecommenderConfigApiCall(ref _callUpdateRecommenderConfig);
            _callGetInsightTypeConfig = clientHelper.BuildApiCall<GetInsightTypeConfigRequest, InsightTypeConfig>("GetInsightTypeConfig", grpcClient.GetInsightTypeConfigAsync, grpcClient.GetInsightTypeConfig, effectiveSettings.GetInsightTypeConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInsightTypeConfig);
            Modify_GetInsightTypeConfigApiCall(ref _callGetInsightTypeConfig);
            _callUpdateInsightTypeConfig = clientHelper.BuildApiCall<UpdateInsightTypeConfigRequest, InsightTypeConfig>("UpdateInsightTypeConfig", grpcClient.UpdateInsightTypeConfigAsync, grpcClient.UpdateInsightTypeConfig, effectiveSettings.UpdateInsightTypeConfigSettings).WithGoogleRequestParam("insight_type_config.name", request => request.InsightTypeConfig?.Name);
            Modify_ApiCall(ref _callUpdateInsightTypeConfig);
            Modify_UpdateInsightTypeConfigApiCall(ref _callUpdateInsightTypeConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInsightsApiCall(ref gaxgrpc::ApiCall<ListInsightsRequest, ListInsightsResponse> call);

        partial void Modify_GetInsightApiCall(ref gaxgrpc::ApiCall<GetInsightRequest, Insight> call);

        partial void Modify_MarkInsightAcceptedApiCall(ref gaxgrpc::ApiCall<MarkInsightAcceptedRequest, Insight> call);

        partial void Modify_ListRecommendationsApiCall(ref gaxgrpc::ApiCall<ListRecommendationsRequest, ListRecommendationsResponse> call);

        partial void Modify_GetRecommendationApiCall(ref gaxgrpc::ApiCall<GetRecommendationRequest, Recommendation> call);

        partial void Modify_MarkRecommendationDismissedApiCall(ref gaxgrpc::ApiCall<MarkRecommendationDismissedRequest, Recommendation> call);

        partial void Modify_MarkRecommendationClaimedApiCall(ref gaxgrpc::ApiCall<MarkRecommendationClaimedRequest, Recommendation> call);

        partial void Modify_MarkRecommendationSucceededApiCall(ref gaxgrpc::ApiCall<MarkRecommendationSucceededRequest, Recommendation> call);

        partial void Modify_MarkRecommendationFailedApiCall(ref gaxgrpc::ApiCall<MarkRecommendationFailedRequest, Recommendation> call);

        partial void Modify_GetRecommenderConfigApiCall(ref gaxgrpc::ApiCall<GetRecommenderConfigRequest, RecommenderConfig> call);

        partial void Modify_UpdateRecommenderConfigApiCall(ref gaxgrpc::ApiCall<UpdateRecommenderConfigRequest, RecommenderConfig> call);

        partial void Modify_GetInsightTypeConfigApiCall(ref gaxgrpc::ApiCall<GetInsightTypeConfigRequest, InsightTypeConfig> call);

        partial void Modify_UpdateInsightTypeConfigApiCall(ref gaxgrpc::ApiCall<UpdateInsightTypeConfigRequest, InsightTypeConfig> call);

        partial void OnConstruction(Recommender.RecommenderClient grpcClient, RecommenderSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Recommender client</summary>
        public override Recommender.RecommenderClient GrpcClient { get; }

        partial void Modify_ListInsightsRequest(ref ListInsightsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInsightRequest(ref GetInsightRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MarkInsightAcceptedRequest(ref MarkInsightAcceptedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRecommendationsRequest(ref ListRecommendationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRecommendationRequest(ref GetRecommendationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MarkRecommendationDismissedRequest(ref MarkRecommendationDismissedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MarkRecommendationClaimedRequest(ref MarkRecommendationClaimedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MarkRecommendationSucceededRequest(ref MarkRecommendationSucceededRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MarkRecommendationFailedRequest(ref MarkRecommendationFailedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRecommenderConfigRequest(ref GetRecommenderConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRecommenderConfigRequest(ref UpdateRecommenderConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInsightTypeConfigRequest(ref GetInsightTypeConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInsightTypeConfigRequest(ref UpdateInsightTypeConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists insights for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified insight type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Insight"/> resources.</returns>
        public override gax::PagedEnumerable<ListInsightsResponse, Insight> ListInsights(ListInsightsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInsightsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInsightsRequest, ListInsightsResponse, Insight>(_callListInsights, request, callSettings);
        }

        /// <summary>
        /// Lists insights for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified insight type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Insight"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInsightsResponse, Insight> ListInsightsAsync(ListInsightsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInsightsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInsightsRequest, ListInsightsResponse, Insight>(_callListInsights, request, callSettings);
        }

        /// <summary>
        /// Gets the requested insight. Requires the recommender.*.get IAM permission
        /// for the specified insight type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Insight GetInsight(GetInsightRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInsightRequest(ref request, ref callSettings);
            return _callGetInsight.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the requested insight. Requires the recommender.*.get IAM permission
        /// for the specified insight type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Insight> GetInsightAsync(GetInsightRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInsightRequest(ref request, ref callSettings);
            return _callGetInsight.Async(request, callSettings);
        }

        /// <summary>
        /// Marks the Insight State as Accepted. Users can use this method to
        /// indicate to the Recommender API that they have applied some action based
        /// on the insight. This stops the insight content from being updated.
        /// 
        /// MarkInsightAccepted can be applied to insights in ACTIVE state. Requires
        /// the recommender.*.update IAM permission for the specified insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Insight MarkInsightAccepted(MarkInsightAcceptedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkInsightAcceptedRequest(ref request, ref callSettings);
            return _callMarkInsightAccepted.Sync(request, callSettings);
        }

        /// <summary>
        /// Marks the Insight State as Accepted. Users can use this method to
        /// indicate to the Recommender API that they have applied some action based
        /// on the insight. This stops the insight content from being updated.
        /// 
        /// MarkInsightAccepted can be applied to insights in ACTIVE state. Requires
        /// the recommender.*.update IAM permission for the specified insight.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Insight> MarkInsightAcceptedAsync(MarkInsightAcceptedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkInsightAcceptedRequest(ref request, ref callSettings);
            return _callMarkInsightAccepted.Async(request, callSettings);
        }

        /// <summary>
        /// Lists recommendations for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Recommendation"/> resources.</returns>
        public override gax::PagedEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendations(ListRecommendationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRecommendationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRecommendationsRequest, ListRecommendationsResponse, Recommendation>(_callListRecommendations, request, callSettings);
        }

        /// <summary>
        /// Lists recommendations for the specified Cloud Resource. Requires the
        /// recommender.*.list IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Recommendation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRecommendationsResponse, Recommendation> ListRecommendationsAsync(ListRecommendationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRecommendationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRecommendationsRequest, ListRecommendationsResponse, Recommendation>(_callListRecommendations, request, callSettings);
        }

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Recommendation GetRecommendation(GetRecommendationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRecommendationRequest(ref request, ref callSettings);
            return _callGetRecommendation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the requested recommendation. Requires the recommender.*.get
        /// IAM permission for the specified recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Recommendation> GetRecommendationAsync(GetRecommendationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRecommendationRequest(ref request, ref callSettings);
            return _callGetRecommendation.Async(request, callSettings);
        }

        /// <summary>
        /// Mark the Recommendation State as Dismissed. Users can use this method to
        /// indicate to the Recommender API that an ACTIVE recommendation has to
        /// be marked back as DISMISSED.
        /// 
        /// MarkRecommendationDismissed can be applied to recommendations in ACTIVE
        /// state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Recommendation MarkRecommendationDismissed(MarkRecommendationDismissedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkRecommendationDismissedRequest(ref request, ref callSettings);
            return _callMarkRecommendationDismissed.Sync(request, callSettings);
        }

        /// <summary>
        /// Mark the Recommendation State as Dismissed. Users can use this method to
        /// indicate to the Recommender API that an ACTIVE recommendation has to
        /// be marked back as DISMISSED.
        /// 
        /// MarkRecommendationDismissed can be applied to recommendations in ACTIVE
        /// state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Recommendation> MarkRecommendationDismissedAsync(MarkRecommendationDismissedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkRecommendationDismissedRequest(ref request, ref callSettings);
            return _callMarkRecommendationDismissed.Async(request, callSettings);
        }

        /// <summary>
        /// Marks the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated. Associated insights are frozen and placed in the ACCEPTED state.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Recommendation MarkRecommendationClaimed(MarkRecommendationClaimedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkRecommendationClaimedRequest(ref request, ref callSettings);
            return _callMarkRecommendationClaimed.Sync(request, callSettings);
        }

        /// <summary>
        /// Marks the Recommendation State as Claimed. Users can use this method to
        /// indicate to the Recommender API that they are starting to apply the
        /// recommendation themselves. This stops the recommendation content from being
        /// updated. Associated insights are frozen and placed in the ACCEPTED state.
        /// 
        /// MarkRecommendationClaimed can be applied to recommendations in CLAIMED,
        /// SUCCEEDED, FAILED, or ACTIVE state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Recommendation> MarkRecommendationClaimedAsync(MarkRecommendationClaimedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkRecommendationClaimedRequest(ref request, ref callSettings);
            return _callMarkRecommendationClaimed.Async(request, callSettings);
        }

        /// <summary>
        /// Marks the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated. Associated insights are frozen and placed in
        /// the ACCEPTED state.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Recommendation MarkRecommendationSucceeded(MarkRecommendationSucceededRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkRecommendationSucceededRequest(ref request, ref callSettings);
            return _callMarkRecommendationSucceeded.Sync(request, callSettings);
        }

        /// <summary>
        /// Marks the Recommendation State as Succeeded. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation was successful. This stops the recommendation
        /// content from being updated. Associated insights are frozen and placed in
        /// the ACCEPTED state.
        /// 
        /// MarkRecommendationSucceeded can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Recommendation> MarkRecommendationSucceededAsync(MarkRecommendationSucceededRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkRecommendationSucceededRequest(ref request, ref callSettings);
            return _callMarkRecommendationSucceeded.Async(request, callSettings);
        }

        /// <summary>
        /// Marks the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated. Associated insights are frozen and placed in the
        /// ACCEPTED state.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Recommendation MarkRecommendationFailed(MarkRecommendationFailedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkRecommendationFailedRequest(ref request, ref callSettings);
            return _callMarkRecommendationFailed.Sync(request, callSettings);
        }

        /// <summary>
        /// Marks the Recommendation State as Failed. Users can use this method to
        /// indicate to the Recommender API that they have applied the recommendation
        /// themselves, and the operation failed. This stops the recommendation content
        /// from being updated. Associated insights are frozen and placed in the
        /// ACCEPTED state.
        /// 
        /// MarkRecommendationFailed can be applied to recommendations in ACTIVE,
        /// CLAIMED, SUCCEEDED, or FAILED state.
        /// 
        /// Requires the recommender.*.update IAM permission for the specified
        /// recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Recommendation> MarkRecommendationFailedAsync(MarkRecommendationFailedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MarkRecommendationFailedRequest(ref request, ref callSettings);
            return _callMarkRecommendationFailed.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the requested Recommender Config. There is only one instance of the
        /// config for each Recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RecommenderConfig GetRecommenderConfig(GetRecommenderConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRecommenderConfigRequest(ref request, ref callSettings);
            return _callGetRecommenderConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the requested Recommender Config. There is only one instance of the
        /// config for each Recommender.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RecommenderConfig> GetRecommenderConfigAsync(GetRecommenderConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRecommenderConfigRequest(ref request, ref callSettings);
            return _callGetRecommenderConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a Recommender Config. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RecommenderConfig UpdateRecommenderConfig(UpdateRecommenderConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRecommenderConfigRequest(ref request, ref callSettings);
            return _callUpdateRecommenderConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a Recommender Config. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RecommenderConfig> UpdateRecommenderConfigAsync(UpdateRecommenderConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRecommenderConfigRequest(ref request, ref callSettings);
            return _callUpdateRecommenderConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the requested InsightTypeConfig. There is only one instance of the
        /// config for each InsightType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InsightTypeConfig GetInsightTypeConfig(GetInsightTypeConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInsightTypeConfigRequest(ref request, ref callSettings);
            return _callGetInsightTypeConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the requested InsightTypeConfig. There is only one instance of the
        /// config for each InsightType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InsightTypeConfig> GetInsightTypeConfigAsync(GetInsightTypeConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInsightTypeConfigRequest(ref request, ref callSettings);
            return _callGetInsightTypeConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an InsightTypeConfig change. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InsightTypeConfig UpdateInsightTypeConfig(UpdateInsightTypeConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInsightTypeConfigRequest(ref request, ref callSettings);
            return _callUpdateInsightTypeConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an InsightTypeConfig change. This will create a new revision of the
        /// config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InsightTypeConfig> UpdateInsightTypeConfigAsync(UpdateInsightTypeConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInsightTypeConfigRequest(ref request, ref callSettings);
            return _callUpdateInsightTypeConfig.Async(request, callSettings);
        }
    }

    public partial class ListInsightsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRecommendationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInsightsResponse : gaxgrpc::IPageResponse<Insight>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Insight> GetEnumerator() => Insights.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRecommendationsResponse : gaxgrpc::IPageResponse<Recommendation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Recommendation> GetEnumerator() => Recommendations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
