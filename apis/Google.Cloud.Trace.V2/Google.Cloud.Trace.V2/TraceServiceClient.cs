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
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Trace.V2
{
    /// <summary>
    /// Settings for a <see cref="TraceServiceClient"/>.
    /// </summary>
    public sealed partial class TraceServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="TraceServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="TraceServiceSettings"/>.
        /// </returns>
        public static TraceServiceSettings GetDefault() => new TraceServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="TraceServiceSettings"/> object with default settings.
        /// </summary>
        public TraceServiceSettings() { }

        private TraceServiceSettings(TraceServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            BatchWriteSpansSettings = existing.BatchWriteSpansSettings;
            CreateSpanSettings = existing.CreateSpanSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TraceServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="TraceServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="TraceServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="TraceServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="TraceServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="TraceServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.2</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(1000),
            delayMultiplier: 1.2
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="TraceServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="TraceServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="TraceServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(30000),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.5
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TraceServiceClient.BatchWriteSpans</c> and <c>TraceServiceClient.BatchWriteSpansAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TraceServiceClient.BatchWriteSpans</c> and
        /// <c>TraceServiceClient.BatchWriteSpansAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 120000 milliseconds.
        /// </remarks>
        public CallSettings BatchWriteSpansSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(120000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TraceServiceClient.CreateSpan</c> and <c>TraceServiceClient.CreateSpanAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TraceServiceClient.CreateSpan</c> and
        /// <c>TraceServiceClient.CreateSpanAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 30000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 120000 milliseconds.
        /// </remarks>
        public CallSettings CreateSpanSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(120000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="TraceServiceSettings"/> object.</returns>
        public TraceServiceSettings Clone() => new TraceServiceSettings(this);
    }

    /// <summary>
    /// TraceService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class TraceServiceClient
    {
        /// <summary>
        /// The default endpoint for the TraceService service, which is a host of "cloudtrace.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("cloudtrace.googleapis.com", 443);

        /// <summary>
        /// The default TraceService scopes.
        /// </summary>
        /// <remarks>
        /// The default TraceService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/trace.append"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/trace.append",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="TraceServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="TraceServiceClient"/>.</returns>
        public static async Task<TraceServiceClient> CreateAsync(ServiceEndpoint endpoint = null, TraceServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="TraceServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <returns>The created <see cref="TraceServiceClient"/>.</returns>
        public static TraceServiceClient Create(ServiceEndpoint endpoint = null, TraceServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="TraceServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <returns>The created <see cref="TraceServiceClient"/>.</returns>
        public static TraceServiceClient Create(Channel channel, TraceServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            TraceService.TraceServiceClient grpcClient = new TraceService.TraceServiceClient(channel);
            return new TraceServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, TraceServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, TraceServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, TraceServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, TraceServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC TraceService client.
        /// </summary>
        public virtual TraceService.TraceServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// A list of new spans. The span names must not match existing
        /// spans, or the results are undefined.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task BatchWriteSpansAsync(
            ProjectName name,
            IEnumerable<Span> spans,
            CallSettings callSettings = null) => BatchWriteSpansAsync(
                new BatchWriteSpansRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Spans = { GaxPreconditions.CheckNotNull(spans, nameof(spans)) },
                },
                callSettings);

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// A list of new spans. The span names must not match existing
        /// spans, or the results are undefined.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task BatchWriteSpansAsync(
            ProjectName name,
            IEnumerable<Span> spans,
            CancellationToken cancellationToken) => BatchWriteSpansAsync(
                name,
                spans,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// A list of new spans. The span names must not match existing
        /// spans, or the results are undefined.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void BatchWriteSpans(
            ProjectName name,
            IEnumerable<Span> spans,
            CallSettings callSettings = null) => BatchWriteSpans(
                new BatchWriteSpansRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Spans = { GaxPreconditions.CheckNotNull(spans, nameof(spans)) },
                },
                callSettings);

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task BatchWriteSpansAsync(
            BatchWriteSpansRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void BatchWriteSpans(
            BatchWriteSpansRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new span.
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
        public virtual Task<Span> CreateSpanAsync(
            Span request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new span.
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
        public virtual Span CreateSpan(
            Span request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// TraceService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class TraceServiceClientImpl : TraceServiceClient
    {
        private readonly ApiCall<BatchWriteSpansRequest, Empty> _callBatchWriteSpans;
        private readonly ApiCall<Span, Span> _callCreateSpan;

        /// <summary>
        /// Constructs a client wrapper for the TraceService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TraceServiceSettings"/> used within this client </param>
        public TraceServiceClientImpl(TraceService.TraceServiceClient grpcClient, TraceServiceSettings settings)
        {
            GrpcClient = grpcClient;
            TraceServiceSettings effectiveSettings = settings ?? TraceServiceSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callBatchWriteSpans = clientHelper.BuildApiCall<BatchWriteSpansRequest, Empty>(
                GrpcClient.BatchWriteSpansAsync, GrpcClient.BatchWriteSpans, effectiveSettings.BatchWriteSpansSettings);
            _callCreateSpan = clientHelper.BuildApiCall<Span, Span>(
                GrpcClient.CreateSpanAsync, GrpcClient.CreateSpan, effectiveSettings.CreateSpanSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(TraceService.TraceServiceClient grpcClient, TraceServiceSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC TraceService client.
        /// </summary>
        public override TraceService.TraceServiceClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_BatchWriteSpansRequest(ref BatchWriteSpansRequest request, ref CallSettings settings);
        partial void Modify_Span(ref Span request, ref CallSettings settings);

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override Task BatchWriteSpansAsync(
            BatchWriteSpansRequest request,
            CallSettings callSettings = null)
        {
            Modify_BatchWriteSpansRequest(ref request, ref callSettings);
            return _callBatchWriteSpans.Async(request, callSettings);
        }

        /// <summary>
        /// Sends new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void BatchWriteSpans(
            BatchWriteSpansRequest request,
            CallSettings callSettings = null)
        {
            Modify_BatchWriteSpansRequest(ref request, ref callSettings);
            _callBatchWriteSpans.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new span.
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
        public override Task<Span> CreateSpanAsync(
            Span request,
            CallSettings callSettings = null)
        {
            Modify_Span(ref request, ref callSettings);
            return _callCreateSpan.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new span.
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
        public override Span CreateSpan(
            Span request,
            CallSettings callSettings = null)
        {
            Modify_Span(ref request, ref callSettings);
            return _callCreateSpan.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
