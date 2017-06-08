// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
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

namespace Google.Cloud.Trace.V1
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
            PatchTracesSettings = existing.PatchTracesSettings;
            GetTraceSettings = existing.GetTraceSettings;
            ListTracesSettings = existing.ListTracesSettings;
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
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Maximum timeout: 30000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(20000),
            maxDelay: TimeSpan.FromMilliseconds(30000),
            delayMultiplier: 1.5
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TraceServiceClient.PatchTraces</c> and <c>TraceServiceClient.PatchTracesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TraceServiceClient.PatchTraces</c> and
        /// <c>TraceServiceClient.PatchTracesAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings PatchTracesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TraceServiceClient.GetTrace</c> and <c>TraceServiceClient.GetTraceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TraceServiceClient.GetTrace</c> and
        /// <c>TraceServiceClient.GetTraceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings GetTraceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TraceServiceClient.ListTraces</c> and <c>TraceServiceClient.ListTracesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TraceServiceClient.ListTraces</c> and
        /// <c>TraceServiceClient.ListTracesAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings ListTracesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
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
        /// <item><description>"https://www.googleapis.com/auth/trace.readonly"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/trace.append",
            "https://www.googleapis.com/auth/trace.readonly",
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
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
        /// </summary>
        /// <param name="projectId">
        /// ID of the Cloud project where the trace data is stored.
        /// </param>
        /// <param name="traces">
        /// The body of the message.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task PatchTracesAsync(
            string projectId,
            Traces traces,
            CallSettings callSettings = null) => PatchTracesAsync(
                new PatchTracesRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Traces = GaxPreconditions.CheckNotNull(traces, nameof(traces)),
                },
                callSettings);

        /// <summary>
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
        /// </summary>
        /// <param name="projectId">
        /// ID of the Cloud project where the trace data is stored.
        /// </param>
        /// <param name="traces">
        /// The body of the message.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task PatchTracesAsync(
            string projectId,
            Traces traces,
            CancellationToken cancellationToken) => PatchTracesAsync(
                projectId,
                traces,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
        /// </summary>
        /// <param name="projectId">
        /// ID of the Cloud project where the trace data is stored.
        /// </param>
        /// <param name="traces">
        /// The body of the message.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void PatchTraces(
            string projectId,
            Traces traces,
            CallSettings callSettings = null) => PatchTraces(
                new PatchTracesRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Traces = GaxPreconditions.CheckNotNull(traces, nameof(traces)),
                },
                callSettings);

        /// <summary>
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
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
        public virtual Task PatchTracesAsync(
            PatchTracesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
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
        public virtual void PatchTraces(
            PatchTracesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single trace by its ID.
        /// </summary>
        /// <param name="projectId">
        /// ID of the Cloud project where the trace data is stored.
        /// </param>
        /// <param name="traceId">
        /// ID of the trace to return.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Trace> GetTraceAsync(
            string projectId,
            string traceId,
            CallSettings callSettings = null) => GetTraceAsync(
                new GetTraceRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    TraceId = GaxPreconditions.CheckNotNullOrEmpty(traceId, nameof(traceId)),
                },
                callSettings);

        /// <summary>
        /// Gets a single trace by its ID.
        /// </summary>
        /// <param name="projectId">
        /// ID of the Cloud project where the trace data is stored.
        /// </param>
        /// <param name="traceId">
        /// ID of the trace to return.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Trace> GetTraceAsync(
            string projectId,
            string traceId,
            CancellationToken cancellationToken) => GetTraceAsync(
                projectId,
                traceId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single trace by its ID.
        /// </summary>
        /// <param name="projectId">
        /// ID of the Cloud project where the trace data is stored.
        /// </param>
        /// <param name="traceId">
        /// ID of the trace to return.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Trace GetTrace(
            string projectId,
            string traceId,
            CallSettings callSettings = null) => GetTrace(
                new GetTraceRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    TraceId = GaxPreconditions.CheckNotNullOrEmpty(traceId, nameof(traceId)),
                },
                callSettings);

        /// <summary>
        /// Gets a single trace by its ID.
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
        public virtual Task<Trace> GetTraceAsync(
            GetTraceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single trace by its ID.
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
        public virtual Trace GetTrace(
            GetTraceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns of a list of traces that match the specified filter conditions.
        /// </summary>
        /// <param name="projectId">
        /// ID of the Cloud project where the trace data is stored.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Trace"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTracesResponse, Trace> ListTracesAsync(
            string projectId,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTracesAsync(
                new ListTracesRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns of a list of traces that match the specified filter conditions.
        /// </summary>
        /// <param name="projectId">
        /// ID of the Cloud project where the trace data is stored.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Trace"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTracesResponse, Trace> ListTraces(
            string projectId,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTraces(
                new ListTracesRequest
                {
                    ProjectId = GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns of a list of traces that match the specified filter conditions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Trace"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListTracesResponse, Trace> ListTracesAsync(
            ListTracesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns of a list of traces that match the specified filter conditions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Trace"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListTracesResponse, Trace> ListTraces(
            ListTracesRequest request,
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
        private readonly ApiCall<PatchTracesRequest, Empty> _callPatchTraces;
        private readonly ApiCall<GetTraceRequest, Trace> _callGetTrace;
        private readonly ApiCall<ListTracesRequest, ListTracesResponse> _callListTraces;

        /// <summary>
        /// Constructs a client wrapper for the TraceService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TraceServiceSettings"/> used within this client </param>
        public TraceServiceClientImpl(TraceService.TraceServiceClient grpcClient, TraceServiceSettings settings)
        {
            this.GrpcClient = grpcClient;
            TraceServiceSettings effectiveSettings = settings ?? TraceServiceSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callPatchTraces = clientHelper.BuildApiCall<PatchTracesRequest, Empty>(
                GrpcClient.PatchTracesAsync, GrpcClient.PatchTraces, effectiveSettings.PatchTracesSettings);
            _callGetTrace = clientHelper.BuildApiCall<GetTraceRequest, Trace>(
                GrpcClient.GetTraceAsync, GrpcClient.GetTrace, effectiveSettings.GetTraceSettings);
            _callListTraces = clientHelper.BuildApiCall<ListTracesRequest, ListTracesResponse>(
                GrpcClient.ListTracesAsync, GrpcClient.ListTraces, effectiveSettings.ListTracesSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(TraceService.TraceServiceClient grpcClient, TraceServiceSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC TraceService client.
        /// </summary>
        public override TraceService.TraceServiceClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_PatchTracesRequest(ref PatchTracesRequest request, ref CallSettings settings);
        partial void Modify_GetTraceRequest(ref GetTraceRequest request, ref CallSettings settings);
        partial void Modify_ListTracesRequest(ref ListTracesRequest request, ref CallSettings settings);

        /// <summary>
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
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
        public override Task PatchTracesAsync(
            PatchTracesRequest request,
            CallSettings callSettings = null)
        {
            Modify_PatchTracesRequest(ref request, ref callSettings);
            return _callPatchTraces.Async(request, callSettings);
        }

        /// <summary>
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
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
        public override void PatchTraces(
            PatchTracesRequest request,
            CallSettings callSettings = null)
        {
            Modify_PatchTracesRequest(ref request, ref callSettings);
            _callPatchTraces.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single trace by its ID.
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
        public override Task<Trace> GetTraceAsync(
            GetTraceRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetTraceRequest(ref request, ref callSettings);
            return _callGetTrace.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a single trace by its ID.
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
        public override Trace GetTrace(
            GetTraceRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetTraceRequest(ref request, ref callSettings);
            return _callGetTrace.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns of a list of traces that match the specified filter conditions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Trace"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListTracesResponse, Trace> ListTracesAsync(
            ListTracesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTracesRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListTracesRequest, ListTracesResponse, Trace>(_callListTraces, request, callSettings);
        }

        /// <summary>
        /// Returns of a list of traces that match the specified filter conditions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Trace"/> resources.
        /// </returns>
        public override PagedEnumerable<ListTracesResponse, Trace> ListTraces(
            ListTracesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTracesRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListTracesRequest, ListTracesResponse, Trace>(_callListTraces, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListTracesRequest : IPageRequest { }
    public partial class ListTracesResponse : IPageResponse<Trace>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Trace> GetEnumerator() => Traces.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
