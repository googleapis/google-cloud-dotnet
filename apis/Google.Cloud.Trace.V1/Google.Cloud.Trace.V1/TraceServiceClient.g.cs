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

namespace Google.Cloud.Trace.V1
{
    /// <summary>Settings for <see cref="TraceServiceClient"/> instances.</summary>
    public sealed partial class TraceServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TraceServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TraceServiceSettings"/>.</returns>
        public static TraceServiceSettings GetDefault() => new TraceServiceSettings();

        /// <summary>Constructs a new <see cref="TraceServiceSettings"/> object with default settings.</summary>
        public TraceServiceSettings()
        {
        }

        private TraceServiceSettings(TraceServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListTracesSettings = existing.ListTracesSettings;
            GetTraceSettings = existing.GetTraceSettings;
            PatchTracesSettings = existing.PatchTracesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TraceServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TraceServiceClient.ListTraces</c> and <c>TraceServiceClient.ListTracesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 45 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTracesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(45000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(1000), backoffMultiplier: 1.2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TraceServiceClient.GetTrace</c>
        ///  and <c>TraceServiceClient.GetTraceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 45 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTraceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(45000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(1000), backoffMultiplier: 1.2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TraceServiceClient.PatchTraces</c> and <c>TraceServiceClient.PatchTracesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 45 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchTracesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(45000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(1000), backoffMultiplier: 1.2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TraceServiceSettings"/> object.</returns>
        public TraceServiceSettings Clone() => new TraceServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TraceServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TraceServiceClientBuilder : gaxgrpc::ClientBuilderBase<TraceServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TraceServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TraceServiceClientBuilder() : base(TraceServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TraceServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TraceServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TraceServiceClient Build()
        {
            TraceServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TraceServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TraceServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TraceServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TraceServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TraceServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TraceServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TraceServiceClient.ChannelPool;
    }

    /// <summary>TraceService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This file describes an API for collecting and viewing traces and spans
    /// within a trace.  A Trace is a collection of spans corresponding to a single
    /// operation or set of operations for an application. A span is an individual
    /// timed event which forms a node of the trace tree. Spans for a single trace
    /// may span multiple services.
    /// </remarks>
    public abstract partial class TraceServiceClient
    {
        /// <summary>
        /// The default endpoint for the TraceService service, which is a host of "cloudtrace.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudtrace.googleapis.com:443";

        /// <summary>The default TraceService scopes.</summary>
        /// <remarks>
        /// The default TraceService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/trace.append</description></item>
        /// <item><description>https://www.googleapis.com/auth/trace.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/trace.append",
            "https://www.googleapis.com/auth/trace.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TraceService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TraceServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TraceServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TraceServiceClient"/>.</returns>
        public static stt::Task<TraceServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TraceServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TraceServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TraceServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TraceServiceClient"/>.</returns>
        public static TraceServiceClient Create() => new TraceServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TraceServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TraceServiceClient"/>.</returns>
        internal static TraceServiceClient Create(grpccore::CallInvoker callInvoker, TraceServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TraceService.TraceServiceClient grpcClient = new TraceService.TraceServiceClient(callInvoker);
            return new TraceServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TraceService client</summary>
        public virtual TraceService.TraceServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns of a list of traces that match the specified filter conditions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Trace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTracesResponse, Trace> ListTraces(ListTracesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns of a list of traces that match the specified filter conditions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Trace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTracesResponse, Trace> ListTracesAsync(ListTracesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns of a list of traces that match the specified filter conditions.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the Cloud project where the trace data is stored.
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
        /// <returns>A pageable sequence of <see cref="Trace"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTracesResponse, Trace> ListTraces(string projectId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTracesRequest request = new ListTracesRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTraces(request, callSettings);
        }

        /// <summary>
        /// Returns of a list of traces that match the specified filter conditions.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the Cloud project where the trace data is stored.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Trace"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTracesResponse, Trace> ListTracesAsync(string projectId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTracesRequest request = new ListTracesRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTracesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a single trace by its ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trace GetTrace(GetTraceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single trace by its ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trace> GetTraceAsync(GetTraceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single trace by its ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trace> GetTraceAsync(GetTraceRequest request, st::CancellationToken cancellationToken) =>
            GetTraceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single trace by its ID.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the Cloud project where the trace data is stored.
        /// </param>
        /// <param name="traceId">
        /// Required. ID of the trace to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trace GetTrace(string projectId, string traceId, gaxgrpc::CallSettings callSettings = null) =>
            GetTrace(new GetTraceRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                TraceId = gax::GaxPreconditions.CheckNotNullOrEmpty(traceId, nameof(traceId)),
            }, callSettings);

        /// <summary>
        /// Gets a single trace by its ID.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the Cloud project where the trace data is stored.
        /// </param>
        /// <param name="traceId">
        /// Required. ID of the trace to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trace> GetTraceAsync(string projectId, string traceId, gaxgrpc::CallSettings callSettings = null) =>
            GetTraceAsync(new GetTraceRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                TraceId = gax::GaxPreconditions.CheckNotNullOrEmpty(traceId, nameof(traceId)),
            }, callSettings);

        /// <summary>
        /// Gets a single trace by its ID.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the Cloud project where the trace data is stored.
        /// </param>
        /// <param name="traceId">
        /// Required. ID of the trace to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trace> GetTraceAsync(string projectId, string traceId, st::CancellationToken cancellationToken) =>
            GetTraceAsync(projectId, traceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void PatchTraces(PatchTracesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PatchTracesAsync(PatchTracesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PatchTracesAsync(PatchTracesRequest request, st::CancellationToken cancellationToken) =>
            PatchTracesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the Cloud project where the trace data is stored.
        /// </param>
        /// <param name="traces">
        /// Required. The body of the message.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void PatchTraces(string projectId, Traces traces, gaxgrpc::CallSettings callSettings = null) =>
            PatchTraces(new PatchTracesRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Traces = gax::GaxPreconditions.CheckNotNull(traces, nameof(traces)),
            }, callSettings);

        /// <summary>
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the Cloud project where the trace data is stored.
        /// </param>
        /// <param name="traces">
        /// Required. The body of the message.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PatchTracesAsync(string projectId, Traces traces, gaxgrpc::CallSettings callSettings = null) =>
            PatchTracesAsync(new PatchTracesRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Traces = gax::GaxPreconditions.CheckNotNull(traces, nameof(traces)),
            }, callSettings);

        /// <summary>
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the Cloud project where the trace data is stored.
        /// </param>
        /// <param name="traces">
        /// Required. The body of the message.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PatchTracesAsync(string projectId, Traces traces, st::CancellationToken cancellationToken) =>
            PatchTracesAsync(projectId, traces, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TraceService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This file describes an API for collecting and viewing traces and spans
    /// within a trace.  A Trace is a collection of spans corresponding to a single
    /// operation or set of operations for an application. A span is an individual
    /// timed event which forms a node of the trace tree. Spans for a single trace
    /// may span multiple services.
    /// </remarks>
    public sealed partial class TraceServiceClientImpl : TraceServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListTracesRequest, ListTracesResponse> _callListTraces;

        private readonly gaxgrpc::ApiCall<GetTraceRequest, Trace> _callGetTrace;

        private readonly gaxgrpc::ApiCall<PatchTracesRequest, wkt::Empty> _callPatchTraces;

        /// <summary>
        /// Constructs a client wrapper for the TraceService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TraceServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TraceServiceClientImpl(TraceService.TraceServiceClient grpcClient, TraceServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TraceServiceSettings effectiveSettings = settings ?? TraceServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListTraces = clientHelper.BuildApiCall<ListTracesRequest, ListTracesResponse>("ListTraces", grpcClient.ListTracesAsync, grpcClient.ListTraces, effectiveSettings.ListTracesSettings).WithGoogleRequestParam("project_id", request => request.ProjectId);
            Modify_ApiCall(ref _callListTraces);
            Modify_ListTracesApiCall(ref _callListTraces);
            _callGetTrace = clientHelper.BuildApiCall<GetTraceRequest, Trace>("GetTrace", grpcClient.GetTraceAsync, grpcClient.GetTrace, effectiveSettings.GetTraceSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("trace_id", request => request.TraceId);
            Modify_ApiCall(ref _callGetTrace);
            Modify_GetTraceApiCall(ref _callGetTrace);
            _callPatchTraces = clientHelper.BuildApiCall<PatchTracesRequest, wkt::Empty>("PatchTraces", grpcClient.PatchTracesAsync, grpcClient.PatchTraces, effectiveSettings.PatchTracesSettings).WithGoogleRequestParam("project_id", request => request.ProjectId);
            Modify_ApiCall(ref _callPatchTraces);
            Modify_PatchTracesApiCall(ref _callPatchTraces);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListTracesApiCall(ref gaxgrpc::ApiCall<ListTracesRequest, ListTracesResponse> call);

        partial void Modify_GetTraceApiCall(ref gaxgrpc::ApiCall<GetTraceRequest, Trace> call);

        partial void Modify_PatchTracesApiCall(ref gaxgrpc::ApiCall<PatchTracesRequest, wkt::Empty> call);

        partial void OnConstruction(TraceService.TraceServiceClient grpcClient, TraceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TraceService client</summary>
        public override TraceService.TraceServiceClient GrpcClient { get; }

        partial void Modify_ListTracesRequest(ref ListTracesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTraceRequest(ref GetTraceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchTracesRequest(ref PatchTracesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns of a list of traces that match the specified filter conditions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Trace"/> resources.</returns>
        public override gax::PagedEnumerable<ListTracesResponse, Trace> ListTraces(ListTracesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTracesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTracesRequest, ListTracesResponse, Trace>(_callListTraces, request, callSettings);
        }

        /// <summary>
        /// Returns of a list of traces that match the specified filter conditions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Trace"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTracesResponse, Trace> ListTracesAsync(ListTracesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTracesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTracesRequest, ListTracesResponse, Trace>(_callListTraces, request, callSettings);
        }

        /// <summary>
        /// Gets a single trace by its ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Trace GetTrace(GetTraceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTraceRequest(ref request, ref callSettings);
            return _callGetTrace.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single trace by its ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Trace> GetTraceAsync(GetTraceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTraceRequest(ref request, ref callSettings);
            return _callGetTrace.Async(request, callSettings);
        }

        /// <summary>
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void PatchTraces(PatchTracesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchTracesRequest(ref request, ref callSettings);
            _callPatchTraces.Sync(request, callSettings);
        }

        /// <summary>
        /// Sends new traces to Stackdriver Trace or updates existing traces. If the ID
        /// of a trace that you send matches that of an existing trace, any fields
        /// in the existing trace and its spans are overwritten by the provided values,
        /// and any new fields provided are merged with the existing trace data. If the
        /// ID does not match, a new trace is created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task PatchTracesAsync(PatchTracesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchTracesRequest(ref request, ref callSettings);
            return _callPatchTraces.Async(request, callSettings);
        }
    }

    public partial class ListTracesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTracesResponse : gaxgrpc::IPageResponse<Trace>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Trace> GetEnumerator() => Traces.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
