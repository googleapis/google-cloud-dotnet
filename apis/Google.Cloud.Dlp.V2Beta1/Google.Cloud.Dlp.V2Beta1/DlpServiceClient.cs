// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.LongRunning;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Dlp.V2Beta1
{
    /// <summary>
    /// Settings for a <see cref="DlpServiceClient"/>.
    /// </summary>
    public sealed partial class DlpServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="DlpServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="DlpServiceSettings"/>.
        /// </returns>
        public static DlpServiceSettings GetDefault() => new DlpServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DlpServiceSettings"/> object with default settings.
        /// </summary>
        public DlpServiceSettings() { }

        private DlpServiceSettings(DlpServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            InspectContentSettings = existing.InspectContentSettings;
            RedactContentSettings = existing.RedactContentSettings;
            DeidentifyContentSettings = existing.DeidentifyContentSettings;
            AnalyzeDataSourceRiskSettings = existing.AnalyzeDataSourceRiskSettings;
            AnalyzeDataSourceRiskOperationsSettings = existing.AnalyzeDataSourceRiskOperationsSettings?.Clone();
            CreateInspectOperationSettings = existing.CreateInspectOperationSettings;
            CreateInspectOperationOperationsSettings = existing.CreateInspectOperationOperationsSettings?.Clone();
            ListInspectFindingsSettings = existing.ListInspectFindingsSettings;
            ListInfoTypesSettings = existing.ListInfoTypesSettings;
            ListRootCategoriesSettings = existing.ListRootCategoriesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DlpServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="DlpServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="DlpServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="DlpServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="DlpServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="DlpServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="DlpServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="DlpServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="DlpServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(20000),
            maxDelay: TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.InspectContent</c> and <c>DlpServiceClient.InspectContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.InspectContent</c> and
        /// <c>DlpServiceClient.InspectContentAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings InspectContentSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.RedactContent</c> and <c>DlpServiceClient.RedactContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.RedactContent</c> and
        /// <c>DlpServiceClient.RedactContentAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings RedactContentSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeidentifyContent</c> and <c>DlpServiceClient.DeidentifyContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.DeidentifyContent</c> and
        /// <c>DlpServiceClient.DeidentifyContentAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeidentifyContentSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.AnalyzeDataSourceRisk</c> and <c>DlpServiceClient.AnalyzeDataSourceRiskAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.AnalyzeDataSourceRisk</c> and
        /// <c>DlpServiceClient.AnalyzeDataSourceRiskAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings AnalyzeDataSourceRiskSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DlpServiceClient.AnalyzeDataSourceRisk</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45000 milliseconds</description></item>
        /// <item><description>Total timeout: 86400000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings AnalyzeDataSourceRiskOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(86400000L)),
                TimeSpan.FromMilliseconds(20000L),
                1.5,
                TimeSpan.FromMilliseconds(45000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateInspectOperation</c> and <c>DlpServiceClient.CreateInspectOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.CreateInspectOperation</c> and
        /// <c>DlpServiceClient.CreateInspectOperationAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CreateInspectOperationSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DlpServiceClient.CreateInspectOperation</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45000 milliseconds</description></item>
        /// <item><description>Total timeout: 86400000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings CreateInspectOperationOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(86400000L)),
                TimeSpan.FromMilliseconds(20000L),
                1.5,
                TimeSpan.FromMilliseconds(45000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListInspectFindings</c> and <c>DlpServiceClient.ListInspectFindingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ListInspectFindings</c> and
        /// <c>DlpServiceClient.ListInspectFindingsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListInspectFindingsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListInfoTypes</c> and <c>DlpServiceClient.ListInfoTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ListInfoTypes</c> and
        /// <c>DlpServiceClient.ListInfoTypesAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListInfoTypesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListRootCategories</c> and <c>DlpServiceClient.ListRootCategoriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DlpServiceClient.ListRootCategories</c> and
        /// <c>DlpServiceClient.ListRootCategoriesAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListRootCategoriesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="DlpServiceSettings"/> object.</returns>
        public DlpServiceSettings Clone() => new DlpServiceSettings(this);
    }

    /// <summary>
    /// DlpService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class DlpServiceClient
    {
        /// <summary>
        /// The default endpoint for the DlpService service, which is a host of "dlp.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("dlp.googleapis.com", 443);

        /// <summary>
        /// The default DlpService scopes.
        /// </summary>
        /// <remarks>
        /// The default DlpService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="DlpServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DlpServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="DlpServiceClient"/>.</returns>
        public static async Task<DlpServiceClient> CreateAsync(ServiceEndpoint endpoint = null, DlpServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="DlpServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DlpServiceSettings"/>.</param>
        /// <returns>The created <see cref="DlpServiceClient"/>.</returns>
        public static DlpServiceClient Create(ServiceEndpoint endpoint = null, DlpServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="DlpServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DlpServiceSettings"/>.</param>
        /// <returns>The created <see cref="DlpServiceClient"/>.</returns>
        public static DlpServiceClient Create(Channel channel, DlpServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            DlpService.DlpServiceClient grpcClient = new DlpService.DlpServiceClient(channel);
            return new DlpServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, DlpServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, DlpServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, DlpServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, DlpServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC DlpService client.
        /// </summary>
        public virtual DlpService.DlpServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Finds potentially sensitive info in a list of strings.
        /// This method has limits on input size, processing time, and output size.
        /// </summary>
        /// <param name="inspectConfig">
        /// Configuration for the inspector.
        /// </param>
        /// <param name="items">
        /// The list of items to inspect. Items in a single request are
        /// considered "related" unless inspect_config.independent_inputs is true.
        /// Up to 100 are allowed per request.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<InspectContentResponse> InspectContentAsync(
            InspectConfig inspectConfig,
            IEnumerable<ContentItem> items,
            CallSettings callSettings = null) => InspectContentAsync(
                new InspectContentRequest
                {
                    InspectConfig = GaxPreconditions.CheckNotNull(inspectConfig, nameof(inspectConfig)),
                    Items = { GaxPreconditions.CheckNotNull(items, nameof(items)) },
                },
                callSettings);

        /// <summary>
        /// Finds potentially sensitive info in a list of strings.
        /// This method has limits on input size, processing time, and output size.
        /// </summary>
        /// <param name="inspectConfig">
        /// Configuration for the inspector.
        /// </param>
        /// <param name="items">
        /// The list of items to inspect. Items in a single request are
        /// considered "related" unless inspect_config.independent_inputs is true.
        /// Up to 100 are allowed per request.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<InspectContentResponse> InspectContentAsync(
            InspectConfig inspectConfig,
            IEnumerable<ContentItem> items,
            CancellationToken cancellationToken) => InspectContentAsync(
                inspectConfig,
                items,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds potentially sensitive info in a list of strings.
        /// This method has limits on input size, processing time, and output size.
        /// </summary>
        /// <param name="inspectConfig">
        /// Configuration for the inspector.
        /// </param>
        /// <param name="items">
        /// The list of items to inspect. Items in a single request are
        /// considered "related" unless inspect_config.independent_inputs is true.
        /// Up to 100 are allowed per request.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual InspectContentResponse InspectContent(
            InspectConfig inspectConfig,
            IEnumerable<ContentItem> items,
            CallSettings callSettings = null) => InspectContent(
                new InspectContentRequest
                {
                    InspectConfig = GaxPreconditions.CheckNotNull(inspectConfig, nameof(inspectConfig)),
                    Items = { GaxPreconditions.CheckNotNull(items, nameof(items)) },
                },
                callSettings);

        /// <summary>
        /// Finds potentially sensitive info in a list of strings.
        /// This method has limits on input size, processing time, and output size.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<InspectContentResponse> InspectContentAsync(
            InspectContentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds potentially sensitive info in a list of strings.
        /// This method has limits on input size, processing time, and output size.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual InspectContentResponse InspectContent(
            InspectContentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Redacts potentially sensitive info from a list of strings.
        /// This method has limits on input size, processing time, and output size.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<RedactContentResponse> RedactContentAsync(
            RedactContentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Redacts potentially sensitive info from a list of strings.
        /// This method has limits on input size, processing time, and output size.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual RedactContentResponse RedactContent(
            RedactContentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// De-identifies potentially sensitive info from a list of strings.
        /// This method has limits on input size and output size.
        /// </summary>
        /// <param name="deidentifyConfig">
        /// Configuration for the de-identification of the list of content items.
        /// </param>
        /// <param name="inspectConfig">
        /// Configuration for the inspector.
        /// </param>
        /// <param name="items">
        /// The list of items to inspect. Up to 100 are allowed per request.
        /// All items will be treated as text/*.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<DeidentifyContentResponse> DeidentifyContentAsync(
            DeidentifyConfig deidentifyConfig,
            InspectConfig inspectConfig,
            IEnumerable<ContentItem> items,
            CallSettings callSettings = null) => DeidentifyContentAsync(
                new DeidentifyContentRequest
                {
                    DeidentifyConfig = GaxPreconditions.CheckNotNull(deidentifyConfig, nameof(deidentifyConfig)),
                    InspectConfig = GaxPreconditions.CheckNotNull(inspectConfig, nameof(inspectConfig)),
                    Items = { GaxPreconditions.CheckNotNull(items, nameof(items)) },
                },
                callSettings);

        /// <summary>
        /// De-identifies potentially sensitive info from a list of strings.
        /// This method has limits on input size and output size.
        /// </summary>
        /// <param name="deidentifyConfig">
        /// Configuration for the de-identification of the list of content items.
        /// </param>
        /// <param name="inspectConfig">
        /// Configuration for the inspector.
        /// </param>
        /// <param name="items">
        /// The list of items to inspect. Up to 100 are allowed per request.
        /// All items will be treated as text/*.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<DeidentifyContentResponse> DeidentifyContentAsync(
            DeidentifyConfig deidentifyConfig,
            InspectConfig inspectConfig,
            IEnumerable<ContentItem> items,
            CancellationToken cancellationToken) => DeidentifyContentAsync(
                deidentifyConfig,
                inspectConfig,
                items,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// De-identifies potentially sensitive info from a list of strings.
        /// This method has limits on input size and output size.
        /// </summary>
        /// <param name="deidentifyConfig">
        /// Configuration for the de-identification of the list of content items.
        /// </param>
        /// <param name="inspectConfig">
        /// Configuration for the inspector.
        /// </param>
        /// <param name="items">
        /// The list of items to inspect. Up to 100 are allowed per request.
        /// All items will be treated as text/*.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DeidentifyContentResponse DeidentifyContent(
            DeidentifyConfig deidentifyConfig,
            InspectConfig inspectConfig,
            IEnumerable<ContentItem> items,
            CallSettings callSettings = null) => DeidentifyContent(
                new DeidentifyContentRequest
                {
                    DeidentifyConfig = GaxPreconditions.CheckNotNull(deidentifyConfig, nameof(deidentifyConfig)),
                    InspectConfig = GaxPreconditions.CheckNotNull(inspectConfig, nameof(inspectConfig)),
                    Items = { GaxPreconditions.CheckNotNull(items, nameof(items)) },
                },
                callSettings);

        /// <summary>
        /// De-identifies potentially sensitive info from a list of strings.
        /// This method has limits on input size and output size.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<DeidentifyContentResponse> DeidentifyContentAsync(
            DeidentifyContentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// De-identifies potentially sensitive info from a list of strings.
        /// This method has limits on input size and output size.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DeidentifyContentResponse DeidentifyContent(
            DeidentifyContentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Schedules a job to compute risk analysis metrics over content in a Google
        /// Cloud Platform repository.
        /// </summary>
        /// <param name="privacyMetric">
        /// Privacy metric to compute.
        /// </param>
        /// <param name="sourceTable">
        /// Input dataset to compute metrics over.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata>> AnalyzeDataSourceRiskAsync(
            PrivacyMetric privacyMetric,
            BigQueryTable sourceTable,
            CallSettings callSettings = null) => AnalyzeDataSourceRiskAsync(
                new AnalyzeDataSourceRiskRequest
                {
                    PrivacyMetric = GaxPreconditions.CheckNotNull(privacyMetric, nameof(privacyMetric)),
                    SourceTable = GaxPreconditions.CheckNotNull(sourceTable, nameof(sourceTable)),
                },
                callSettings);

        /// <summary>
        /// Schedules a job to compute risk analysis metrics over content in a Google
        /// Cloud Platform repository.
        /// </summary>
        /// <param name="privacyMetric">
        /// Privacy metric to compute.
        /// </param>
        /// <param name="sourceTable">
        /// Input dataset to compute metrics over.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata>> AnalyzeDataSourceRiskAsync(
            PrivacyMetric privacyMetric,
            BigQueryTable sourceTable,
            CancellationToken cancellationToken) => AnalyzeDataSourceRiskAsync(
                privacyMetric,
                sourceTable,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Schedules a job to compute risk analysis metrics over content in a Google
        /// Cloud Platform repository.
        /// </summary>
        /// <param name="privacyMetric">
        /// Privacy metric to compute.
        /// </param>
        /// <param name="sourceTable">
        /// Input dataset to compute metrics over.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> AnalyzeDataSourceRisk(
            PrivacyMetric privacyMetric,
            BigQueryTable sourceTable,
            CallSettings callSettings = null) => AnalyzeDataSourceRisk(
                new AnalyzeDataSourceRiskRequest
                {
                    PrivacyMetric = GaxPreconditions.CheckNotNull(privacyMetric, nameof(privacyMetric)),
                    SourceTable = GaxPreconditions.CheckNotNull(sourceTable, nameof(sourceTable)),
                },
                callSettings);

        /// <summary>
        /// Schedules a job to compute risk analysis metrics over content in a Google
        /// Cloud Platform repository.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata>> AnalyzeDataSourceRiskAsync(
            AnalyzeDataSourceRiskRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AnalyzeDataSourceRiskAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata>> PollOnceAnalyzeDataSourceRiskAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                AnalyzeDataSourceRiskOperationsClient,
                callSettings);

        /// <summary>
        /// Schedules a job to compute risk analysis metrics over content in a Google
        /// Cloud Platform repository.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> AnalyzeDataSourceRisk(
            AnalyzeDataSourceRiskRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>AnalyzeDataSourceRisk</c>.
        /// </summary>
        public virtual OperationsClient AnalyzeDataSourceRiskOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AnalyzeDataSourceRisk</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> PollOnceAnalyzeDataSourceRisk(
            string operationName,
            CallSettings callSettings = null) => Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                AnalyzeDataSourceRiskOperationsClient,
                callSettings);

        /// <summary>
        /// Schedules a job scanning content in a Google Cloud Platform data
        /// repository.
        /// </summary>
        /// <param name="inspectConfig">
        /// Configuration for the inspector.
        /// </param>
        /// <param name="storageConfig">
        /// Specification of the data set to process.
        /// </param>
        /// <param name="outputConfig">
        /// Optional location to store findings.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<InspectOperationResult, InspectOperationMetadata>> CreateInspectOperationAsync(
            InspectConfig inspectConfig,
            StorageConfig storageConfig,
            OutputStorageConfig outputConfig,
            CallSettings callSettings = null) => CreateInspectOperationAsync(
                new CreateInspectOperationRequest
                {
                    InspectConfig = GaxPreconditions.CheckNotNull(inspectConfig, nameof(inspectConfig)),
                    StorageConfig = GaxPreconditions.CheckNotNull(storageConfig, nameof(storageConfig)),
                    OutputConfig = GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
                },
                callSettings);

        /// <summary>
        /// Schedules a job scanning content in a Google Cloud Platform data
        /// repository.
        /// </summary>
        /// <param name="inspectConfig">
        /// Configuration for the inspector.
        /// </param>
        /// <param name="storageConfig">
        /// Specification of the data set to process.
        /// </param>
        /// <param name="outputConfig">
        /// Optional location to store findings.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<InspectOperationResult, InspectOperationMetadata>> CreateInspectOperationAsync(
            InspectConfig inspectConfig,
            StorageConfig storageConfig,
            OutputStorageConfig outputConfig,
            CancellationToken cancellationToken) => CreateInspectOperationAsync(
                inspectConfig,
                storageConfig,
                outputConfig,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Schedules a job scanning content in a Google Cloud Platform data
        /// repository.
        /// </summary>
        /// <param name="inspectConfig">
        /// Configuration for the inspector.
        /// </param>
        /// <param name="storageConfig">
        /// Specification of the data set to process.
        /// </param>
        /// <param name="outputConfig">
        /// Optional location to store findings.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<InspectOperationResult, InspectOperationMetadata> CreateInspectOperation(
            InspectConfig inspectConfig,
            StorageConfig storageConfig,
            OutputStorageConfig outputConfig,
            CallSettings callSettings = null) => CreateInspectOperation(
                new CreateInspectOperationRequest
                {
                    InspectConfig = GaxPreconditions.CheckNotNull(inspectConfig, nameof(inspectConfig)),
                    StorageConfig = GaxPreconditions.CheckNotNull(storageConfig, nameof(storageConfig)),
                    OutputConfig = GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
                },
                callSettings);

        /// <summary>
        /// Schedules a job scanning content in a Google Cloud Platform data
        /// repository.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<InspectOperationResult, InspectOperationMetadata>> CreateInspectOperationAsync(
            CreateInspectOperationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInspectOperationAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<InspectOperationResult, InspectOperationMetadata>> PollOnceCreateInspectOperationAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<InspectOperationResult, InspectOperationMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateInspectOperationOperationsClient,
                callSettings);

        /// <summary>
        /// Schedules a job scanning content in a Google Cloud Platform data
        /// repository.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<InspectOperationResult, InspectOperationMetadata> CreateInspectOperation(
            CreateInspectOperationRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateInspectOperation</c>.
        /// </summary>
        public virtual OperationsClient CreateInspectOperationOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInspectOperation</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<InspectOperationResult, InspectOperationMetadata> PollOnceCreateInspectOperation(
            string operationName,
            CallSettings callSettings = null) => Operation<InspectOperationResult, InspectOperationMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateInspectOperationOperationsClient,
                callSettings);

        /// <summary>
        /// Returns list of results for given inspect operation result set id.
        /// </summary>
        /// <param name="name">
        /// Identifier of the results set returned as metadata of
        /// the longrunning operation created by a call to InspectDataSource.
        /// Should be in the format of `inspect/results/{id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListInspectFindingsResponse> ListInspectFindingsAsync(
            ResultName name,
            CallSettings callSettings = null) => ListInspectFindingsAsync(
                new ListInspectFindingsRequest
                {
                    ResultName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns list of results for given inspect operation result set id.
        /// </summary>
        /// <param name="name">
        /// Identifier of the results set returned as metadata of
        /// the longrunning operation created by a call to InspectDataSource.
        /// Should be in the format of `inspect/results/{id}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListInspectFindingsResponse> ListInspectFindingsAsync(
            ResultName name,
            CancellationToken cancellationToken) => ListInspectFindingsAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns list of results for given inspect operation result set id.
        /// </summary>
        /// <param name="name">
        /// Identifier of the results set returned as metadata of
        /// the longrunning operation created by a call to InspectDataSource.
        /// Should be in the format of `inspect/results/{id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListInspectFindingsResponse ListInspectFindings(
            ResultName name,
            CallSettings callSettings = null) => ListInspectFindings(
                new ListInspectFindingsRequest
                {
                    ResultName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns list of results for given inspect operation result set id.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListInspectFindingsResponse> ListInspectFindingsAsync(
            ListInspectFindingsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns list of results for given inspect operation result set id.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListInspectFindingsResponse ListInspectFindings(
            ListInspectFindingsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns sensitive information types for given category.
        /// </summary>
        /// <param name="category">
        /// Category name as returned by ListRootCategories.
        /// </param>
        /// <param name="languageCode">
        /// Optional BCP-47 language code for localized info type friendly
        /// names. If omitted, or if localized strings are not available,
        /// en-US strings will be returned.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListInfoTypesResponse> ListInfoTypesAsync(
            string category,
            string languageCode,
            CallSettings callSettings = null) => ListInfoTypesAsync(
                new ListInfoTypesRequest
                {
                    Category = GaxPreconditions.CheckNotNullOrEmpty(category, nameof(category)),
                    LanguageCode = GaxPreconditions.CheckNotNullOrEmpty(languageCode, nameof(languageCode)),
                },
                callSettings);

        /// <summary>
        /// Returns sensitive information types for given category.
        /// </summary>
        /// <param name="category">
        /// Category name as returned by ListRootCategories.
        /// </param>
        /// <param name="languageCode">
        /// Optional BCP-47 language code for localized info type friendly
        /// names. If omitted, or if localized strings are not available,
        /// en-US strings will be returned.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListInfoTypesResponse> ListInfoTypesAsync(
            string category,
            string languageCode,
            CancellationToken cancellationToken) => ListInfoTypesAsync(
                category,
                languageCode,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns sensitive information types for given category.
        /// </summary>
        /// <param name="category">
        /// Category name as returned by ListRootCategories.
        /// </param>
        /// <param name="languageCode">
        /// Optional BCP-47 language code for localized info type friendly
        /// names. If omitted, or if localized strings are not available,
        /// en-US strings will be returned.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListInfoTypesResponse ListInfoTypes(
            string category,
            string languageCode,
            CallSettings callSettings = null) => ListInfoTypes(
                new ListInfoTypesRequest
                {
                    Category = GaxPreconditions.CheckNotNullOrEmpty(category, nameof(category)),
                    LanguageCode = GaxPreconditions.CheckNotNullOrEmpty(languageCode, nameof(languageCode)),
                },
                callSettings);

        /// <summary>
        /// Returns sensitive information types for given category.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListInfoTypesResponse> ListInfoTypesAsync(
            ListInfoTypesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns sensitive information types for given category.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListInfoTypesResponse ListInfoTypes(
            ListInfoTypesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the list of root categories of sensitive information.
        /// </summary>
        /// <param name="languageCode">
        /// Optional language code for localized friendly category names.
        /// If omitted or if localized strings are not available,
        /// en-US strings will be returned.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListRootCategoriesResponse> ListRootCategoriesAsync(
            string languageCode,
            CallSettings callSettings = null) => ListRootCategoriesAsync(
                new ListRootCategoriesRequest
                {
                    LanguageCode = GaxPreconditions.CheckNotNullOrEmpty(languageCode, nameof(languageCode)),
                },
                callSettings);

        /// <summary>
        /// Returns the list of root categories of sensitive information.
        /// </summary>
        /// <param name="languageCode">
        /// Optional language code for localized friendly category names.
        /// If omitted or if localized strings are not available,
        /// en-US strings will be returned.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListRootCategoriesResponse> ListRootCategoriesAsync(
            string languageCode,
            CancellationToken cancellationToken) => ListRootCategoriesAsync(
                languageCode,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of root categories of sensitive information.
        /// </summary>
        /// <param name="languageCode">
        /// Optional language code for localized friendly category names.
        /// If omitted or if localized strings are not available,
        /// en-US strings will be returned.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListRootCategoriesResponse ListRootCategories(
            string languageCode,
            CallSettings callSettings = null) => ListRootCategories(
                new ListRootCategoriesRequest
                {
                    LanguageCode = GaxPreconditions.CheckNotNullOrEmpty(languageCode, nameof(languageCode)),
                },
                callSettings);

        /// <summary>
        /// Returns the list of root categories of sensitive information.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListRootCategoriesResponse> ListRootCategoriesAsync(
            ListRootCategoriesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the list of root categories of sensitive information.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListRootCategoriesResponse ListRootCategories(
            ListRootCategoriesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// DlpService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class DlpServiceClientImpl : DlpServiceClient
    {
        private readonly ApiCall<InspectContentRequest, InspectContentResponse> _callInspectContent;
        private readonly ApiCall<RedactContentRequest, RedactContentResponse> _callRedactContent;
        private readonly ApiCall<DeidentifyContentRequest, DeidentifyContentResponse> _callDeidentifyContent;
        private readonly ApiCall<AnalyzeDataSourceRiskRequest, Operation> _callAnalyzeDataSourceRisk;
        private readonly ApiCall<CreateInspectOperationRequest, Operation> _callCreateInspectOperation;
        private readonly ApiCall<ListInspectFindingsRequest, ListInspectFindingsResponse> _callListInspectFindings;
        private readonly ApiCall<ListInfoTypesRequest, ListInfoTypesResponse> _callListInfoTypes;
        private readonly ApiCall<ListRootCategoriesRequest, ListRootCategoriesResponse> _callListRootCategories;

        /// <summary>
        /// Constructs a client wrapper for the DlpService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DlpServiceSettings"/> used within this client </param>
        public DlpServiceClientImpl(DlpService.DlpServiceClient grpcClient, DlpServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DlpServiceSettings effectiveSettings = settings ?? DlpServiceSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            AnalyzeDataSourceRiskOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.AnalyzeDataSourceRiskOperationsSettings);
            CreateInspectOperationOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateInspectOperationOperationsSettings);
            _callInspectContent = clientHelper.BuildApiCall<InspectContentRequest, InspectContentResponse>(
                GrpcClient.InspectContentAsync, GrpcClient.InspectContent, effectiveSettings.InspectContentSettings);
            _callRedactContent = clientHelper.BuildApiCall<RedactContentRequest, RedactContentResponse>(
                GrpcClient.RedactContentAsync, GrpcClient.RedactContent, effectiveSettings.RedactContentSettings);
            _callDeidentifyContent = clientHelper.BuildApiCall<DeidentifyContentRequest, DeidentifyContentResponse>(
                GrpcClient.DeidentifyContentAsync, GrpcClient.DeidentifyContent, effectiveSettings.DeidentifyContentSettings);
            _callAnalyzeDataSourceRisk = clientHelper.BuildApiCall<AnalyzeDataSourceRiskRequest, Operation>(
                GrpcClient.AnalyzeDataSourceRiskAsync, GrpcClient.AnalyzeDataSourceRisk, effectiveSettings.AnalyzeDataSourceRiskSettings);
            _callCreateInspectOperation = clientHelper.BuildApiCall<CreateInspectOperationRequest, Operation>(
                GrpcClient.CreateInspectOperationAsync, GrpcClient.CreateInspectOperation, effectiveSettings.CreateInspectOperationSettings);
            _callListInspectFindings = clientHelper.BuildApiCall<ListInspectFindingsRequest, ListInspectFindingsResponse>(
                GrpcClient.ListInspectFindingsAsync, GrpcClient.ListInspectFindings, effectiveSettings.ListInspectFindingsSettings);
            _callListInfoTypes = clientHelper.BuildApiCall<ListInfoTypesRequest, ListInfoTypesResponse>(
                GrpcClient.ListInfoTypesAsync, GrpcClient.ListInfoTypes, effectiveSettings.ListInfoTypesSettings);
            _callListRootCategories = clientHelper.BuildApiCall<ListRootCategoriesRequest, ListRootCategoriesResponse>(
                GrpcClient.ListRootCategoriesAsync, GrpcClient.ListRootCategories, effectiveSettings.ListRootCategoriesSettings);
            Modify_ApiCall(ref _callInspectContent);
            Modify_InspectContentApiCall(ref _callInspectContent);
            Modify_ApiCall(ref _callRedactContent);
            Modify_RedactContentApiCall(ref _callRedactContent);
            Modify_ApiCall(ref _callDeidentifyContent);
            Modify_DeidentifyContentApiCall(ref _callDeidentifyContent);
            Modify_ApiCall(ref _callAnalyzeDataSourceRisk);
            Modify_AnalyzeDataSourceRiskApiCall(ref _callAnalyzeDataSourceRisk);
            Modify_ApiCall(ref _callCreateInspectOperation);
            Modify_CreateInspectOperationApiCall(ref _callCreateInspectOperation);
            Modify_ApiCall(ref _callListInspectFindings);
            Modify_ListInspectFindingsApiCall(ref _callListInspectFindings);
            Modify_ApiCall(ref _callListInfoTypes);
            Modify_ListInfoTypesApiCall(ref _callListInfoTypes);
            Modify_ApiCall(ref _callListRootCategories);
            Modify_ListRootCategoriesApiCall(ref _callListRootCategories);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref ApiCall<TRequest, TResponse> call)
            where TRequest : class, IMessage<TRequest>
            where TResponse : class, IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_InspectContentApiCall(ref ApiCall<InspectContentRequest, InspectContentResponse> call);
        partial void Modify_RedactContentApiCall(ref ApiCall<RedactContentRequest, RedactContentResponse> call);
        partial void Modify_DeidentifyContentApiCall(ref ApiCall<DeidentifyContentRequest, DeidentifyContentResponse> call);
        partial void Modify_AnalyzeDataSourceRiskApiCall(ref ApiCall<AnalyzeDataSourceRiskRequest, Operation> call);
        partial void Modify_CreateInspectOperationApiCall(ref ApiCall<CreateInspectOperationRequest, Operation> call);
        partial void Modify_ListInspectFindingsApiCall(ref ApiCall<ListInspectFindingsRequest, ListInspectFindingsResponse> call);
        partial void Modify_ListInfoTypesApiCall(ref ApiCall<ListInfoTypesRequest, ListInfoTypesResponse> call);
        partial void Modify_ListRootCategoriesApiCall(ref ApiCall<ListRootCategoriesRequest, ListRootCategoriesResponse> call);
        partial void OnConstruction(DlpService.DlpServiceClient grpcClient, DlpServiceSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC DlpService client.
        /// </summary>
        public override DlpService.DlpServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_InspectContentRequest(ref InspectContentRequest request, ref CallSettings settings);
        partial void Modify_RedactContentRequest(ref RedactContentRequest request, ref CallSettings settings);
        partial void Modify_DeidentifyContentRequest(ref DeidentifyContentRequest request, ref CallSettings settings);
        partial void Modify_AnalyzeDataSourceRiskRequest(ref AnalyzeDataSourceRiskRequest request, ref CallSettings settings);
        partial void Modify_CreateInspectOperationRequest(ref CreateInspectOperationRequest request, ref CallSettings settings);
        partial void Modify_ListInspectFindingsRequest(ref ListInspectFindingsRequest request, ref CallSettings settings);
        partial void Modify_ListInfoTypesRequest(ref ListInfoTypesRequest request, ref CallSettings settings);
        partial void Modify_ListRootCategoriesRequest(ref ListRootCategoriesRequest request, ref CallSettings settings);

        /// <summary>
        /// Finds potentially sensitive info in a list of strings.
        /// This method has limits on input size, processing time, and output size.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<InspectContentResponse> InspectContentAsync(
            InspectContentRequest request,
            CallSettings callSettings = null)
        {
            Modify_InspectContentRequest(ref request, ref callSettings);
            return _callInspectContent.Async(request, callSettings);
        }

        /// <summary>
        /// Finds potentially sensitive info in a list of strings.
        /// This method has limits on input size, processing time, and output size.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override InspectContentResponse InspectContent(
            InspectContentRequest request,
            CallSettings callSettings = null)
        {
            Modify_InspectContentRequest(ref request, ref callSettings);
            return _callInspectContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Redacts potentially sensitive info from a list of strings.
        /// This method has limits on input size, processing time, and output size.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<RedactContentResponse> RedactContentAsync(
            RedactContentRequest request,
            CallSettings callSettings = null)
        {
            Modify_RedactContentRequest(ref request, ref callSettings);
            return _callRedactContent.Async(request, callSettings);
        }

        /// <summary>
        /// Redacts potentially sensitive info from a list of strings.
        /// This method has limits on input size, processing time, and output size.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override RedactContentResponse RedactContent(
            RedactContentRequest request,
            CallSettings callSettings = null)
        {
            Modify_RedactContentRequest(ref request, ref callSettings);
            return _callRedactContent.Sync(request, callSettings);
        }

        /// <summary>
        /// De-identifies potentially sensitive info from a list of strings.
        /// This method has limits on input size and output size.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<DeidentifyContentResponse> DeidentifyContentAsync(
            DeidentifyContentRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeidentifyContentRequest(ref request, ref callSettings);
            return _callDeidentifyContent.Async(request, callSettings);
        }

        /// <summary>
        /// De-identifies potentially sensitive info from a list of strings.
        /// This method has limits on input size and output size.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override DeidentifyContentResponse DeidentifyContent(
            DeidentifyContentRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeidentifyContentRequest(ref request, ref callSettings);
            return _callDeidentifyContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Schedules a job to compute risk analysis metrics over content in a Google
        /// Cloud Platform repository.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override async Task<Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata>> AnalyzeDataSourceRiskAsync(
            AnalyzeDataSourceRiskRequest request,
            CallSettings callSettings = null)
        {
            Modify_AnalyzeDataSourceRiskRequest(ref request, ref callSettings);
            return new Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata>(
                await _callAnalyzeDataSourceRisk.Async(request, callSettings).ConfigureAwait(false), AnalyzeDataSourceRiskOperationsClient);
        }

        /// <summary>
        /// Schedules a job to compute risk analysis metrics over content in a Google
        /// Cloud Platform repository.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata> AnalyzeDataSourceRisk(
            AnalyzeDataSourceRiskRequest request,
            CallSettings callSettings = null)
        {
            Modify_AnalyzeDataSourceRiskRequest(ref request, ref callSettings);
            return new Operation<RiskAnalysisOperationResult, RiskAnalysisOperationMetadata>(
                _callAnalyzeDataSourceRisk.Sync(request, callSettings), AnalyzeDataSourceRiskOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>AnalyzeDataSourceRisk</c>.
        /// </summary>
        public override OperationsClient AnalyzeDataSourceRiskOperationsClient { get; }

        /// <summary>
        /// Schedules a job scanning content in a Google Cloud Platform data
        /// repository.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override async Task<Operation<InspectOperationResult, InspectOperationMetadata>> CreateInspectOperationAsync(
            CreateInspectOperationRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateInspectOperationRequest(ref request, ref callSettings);
            return new Operation<InspectOperationResult, InspectOperationMetadata>(
                await _callCreateInspectOperation.Async(request, callSettings).ConfigureAwait(false), CreateInspectOperationOperationsClient);
        }

        /// <summary>
        /// Schedules a job scanning content in a Google Cloud Platform data
        /// repository.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Operation<InspectOperationResult, InspectOperationMetadata> CreateInspectOperation(
            CreateInspectOperationRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateInspectOperationRequest(ref request, ref callSettings);
            return new Operation<InspectOperationResult, InspectOperationMetadata>(
                _callCreateInspectOperation.Sync(request, callSettings), CreateInspectOperationOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateInspectOperation</c>.
        /// </summary>
        public override OperationsClient CreateInspectOperationOperationsClient { get; }

        /// <summary>
        /// Returns list of results for given inspect operation result set id.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<ListInspectFindingsResponse> ListInspectFindingsAsync(
            ListInspectFindingsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInspectFindingsRequest(ref request, ref callSettings);
            return _callListInspectFindings.Async(request, callSettings);
        }

        /// <summary>
        /// Returns list of results for given inspect operation result set id.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ListInspectFindingsResponse ListInspectFindings(
            ListInspectFindingsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInspectFindingsRequest(ref request, ref callSettings);
            return _callListInspectFindings.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns sensitive information types for given category.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<ListInfoTypesResponse> ListInfoTypesAsync(
            ListInfoTypesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInfoTypesRequest(ref request, ref callSettings);
            return _callListInfoTypes.Async(request, callSettings);
        }

        /// <summary>
        /// Returns sensitive information types for given category.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ListInfoTypesResponse ListInfoTypes(
            ListInfoTypesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInfoTypesRequest(ref request, ref callSettings);
            return _callListInfoTypes.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of root categories of sensitive information.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<ListRootCategoriesResponse> ListRootCategoriesAsync(
            ListRootCategoriesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListRootCategoriesRequest(ref request, ref callSettings);
            return _callListRootCategories.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of root categories of sensitive information.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ListRootCategoriesResponse ListRootCategories(
            ListRootCategoriesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListRootCategoriesRequest(ref request, ref callSettings);
            return _callListRootCategories.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    // Partial Grpc class to enable LRO client creation
    public static partial class DlpService
    {
        public partial class DlpServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual Operations.OperationsClient CreateOperationsClient() => new Operations.OperationsClient(CallInvoker);
        }
    }


}
