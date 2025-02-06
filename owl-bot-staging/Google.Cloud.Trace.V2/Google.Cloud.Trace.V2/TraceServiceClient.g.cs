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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Trace.V2
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
            BatchWriteSpansSettings = existing.BatchWriteSpansSettings;
            CreateSpanSettings = existing.CreateSpanSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TraceServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TraceServiceClient.BatchWriteSpans</c> and <c>TraceServiceClient.BatchWriteSpansAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchWriteSpansSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TraceServiceClient.CreateSpan</c> and <c>TraceServiceClient.CreateSpanAsync</c>.
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
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSpanSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(1000), backoffMultiplier: 1.2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

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
    /// Service for collecting and viewing traces and spans within a trace.
    /// 
    /// A trace is a collection of spans corresponding to a single
    /// operation or a set of operations in an application.
    /// 
    /// A span is an individual timed event which forms a node of the trace tree.
    /// A single trace can contain spans from multiple services.
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
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/trace.append",
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
        /// Batch writes new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchWriteSpans(BatchWriteSpansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch writes new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchWriteSpansAsync(BatchWriteSpansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch writes new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchWriteSpansAsync(BatchWriteSpansRequest request, st::CancellationToken cancellationToken) =>
            BatchWriteSpansAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch writes new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// Required. A list of new spans. The span names must not match existing
        /// spans, otherwise the results are undefined.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchWriteSpans(string name, scg::IEnumerable<Span> spans, gaxgrpc::CallSettings callSettings = null) =>
            BatchWriteSpans(new BatchWriteSpansRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Spans =
                {
                    gax::GaxPreconditions.CheckNotNull(spans, nameof(spans)),
                },
            }, callSettings);

        /// <summary>
        /// Batch writes new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// Required. A list of new spans. The span names must not match existing
        /// spans, otherwise the results are undefined.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchWriteSpansAsync(string name, scg::IEnumerable<Span> spans, gaxgrpc::CallSettings callSettings = null) =>
            BatchWriteSpansAsync(new BatchWriteSpansRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Spans =
                {
                    gax::GaxPreconditions.CheckNotNull(spans, nameof(spans)),
                },
            }, callSettings);

        /// <summary>
        /// Batch writes new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// Required. A list of new spans. The span names must not match existing
        /// spans, otherwise the results are undefined.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchWriteSpansAsync(string name, scg::IEnumerable<Span> spans, st::CancellationToken cancellationToken) =>
            BatchWriteSpansAsync(name, spans, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch writes new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// Required. A list of new spans. The span names must not match existing
        /// spans, otherwise the results are undefined.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void BatchWriteSpans(gagr::ProjectName name, scg::IEnumerable<Span> spans, gaxgrpc::CallSettings callSettings = null) =>
            BatchWriteSpans(new BatchWriteSpansRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Spans =
                {
                    gax::GaxPreconditions.CheckNotNull(spans, nameof(spans)),
                },
            }, callSettings);

        /// <summary>
        /// Batch writes new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// Required. A list of new spans. The span names must not match existing
        /// spans, otherwise the results are undefined.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchWriteSpansAsync(gagr::ProjectName name, scg::IEnumerable<Span> spans, gaxgrpc::CallSettings callSettings = null) =>
            BatchWriteSpansAsync(new BatchWriteSpansRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Spans =
                {
                    gax::GaxPreconditions.CheckNotNull(spans, nameof(spans)),
                },
            }, callSettings);

        /// <summary>
        /// Batch writes new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the project where the spans belong. The format is
        /// `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="spans">
        /// Required. A list of new spans. The span names must not match existing
        /// spans, otherwise the results are undefined.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task BatchWriteSpansAsync(gagr::ProjectName name, scg::IEnumerable<Span> spans, st::CancellationToken cancellationToken) =>
            BatchWriteSpansAsync(name, spans, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new span.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Span CreateSpan(Span request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new span.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Span> CreateSpanAsync(Span request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new span.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Span> CreateSpanAsync(Span request, st::CancellationToken cancellationToken) =>
            CreateSpanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TraceService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for collecting and viewing traces and spans within a trace.
    /// 
    /// A trace is a collection of spans corresponding to a single
    /// operation or a set of operations in an application.
    /// 
    /// A span is an individual timed event which forms a node of the trace tree.
    /// A single trace can contain spans from multiple services.
    /// </remarks>
    public sealed partial class TraceServiceClientImpl : TraceServiceClient
    {
        private readonly gaxgrpc::ApiCall<BatchWriteSpansRequest, wkt::Empty> _callBatchWriteSpans;

        private readonly gaxgrpc::ApiCall<Span, Span> _callCreateSpan;

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
            _callBatchWriteSpans = clientHelper.BuildApiCall<BatchWriteSpansRequest, wkt::Empty>("BatchWriteSpans", grpcClient.BatchWriteSpansAsync, grpcClient.BatchWriteSpans, effectiveSettings.BatchWriteSpansSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callBatchWriteSpans);
            Modify_BatchWriteSpansApiCall(ref _callBatchWriteSpans);
            _callCreateSpan = clientHelper.BuildApiCall<Span, Span>("CreateSpan", grpcClient.CreateSpanAsync, grpcClient.CreateSpan, effectiveSettings.CreateSpanSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCreateSpan);
            Modify_CreateSpanApiCall(ref _callCreateSpan);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_BatchWriteSpansApiCall(ref gaxgrpc::ApiCall<BatchWriteSpansRequest, wkt::Empty> call);

        partial void Modify_CreateSpanApiCall(ref gaxgrpc::ApiCall<Span, Span> call);

        partial void OnConstruction(TraceService.TraceServiceClient grpcClient, TraceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TraceService client</summary>
        public override TraceService.TraceServiceClient GrpcClient { get; }

        partial void Modify_BatchWriteSpansRequest(ref BatchWriteSpansRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_Span(ref Span request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Batch writes new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void BatchWriteSpans(BatchWriteSpansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchWriteSpansRequest(ref request, ref callSettings);
            _callBatchWriteSpans.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch writes new spans to new or existing traces. You cannot update
        /// existing spans.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task BatchWriteSpansAsync(BatchWriteSpansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchWriteSpansRequest(ref request, ref callSettings);
            return _callBatchWriteSpans.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new span.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Span CreateSpan(Span request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Span(ref request, ref callSettings);
            return _callCreateSpan.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new span.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Span> CreateSpanAsync(Span request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Span(ref request, ref callSettings);
            return _callCreateSpan.Async(request, callSettings);
        }
    }
}
