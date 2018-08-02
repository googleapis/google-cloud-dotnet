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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Trace.V1
{
    /// <summary>
    /// Settings for a <see cref="TraceServiceClient"/>.
    /// </summary>
    public sealed partial class TraceServiceSettings : gaxgrpc::ServiceSettingsBase
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
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            PatchTracesSettings = existing.PatchTracesSettings;
            GetTraceSettings = existing.GetTraceSettings;
            ListTracesSettings = existing.ListTracesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TraceServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="TraceServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="TraceServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

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
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(1000),
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
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(30000),
            delayMultiplier: 1.5
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TraceServiceClient.PatchTraces</c> and <c>TraceServiceClient.PatchTracesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TraceServiceClient.PatchTraces</c> and
        /// <c>TraceServiceClient.PatchTracesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings PatchTracesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(45000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TraceServiceClient.GetTrace</c> and <c>TraceServiceClient.GetTraceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TraceServiceClient.GetTrace</c> and
        /// <c>TraceServiceClient.GetTraceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetTraceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(45000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TraceServiceClient.ListTraces</c> and <c>TraceServiceClient.ListTracesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TraceServiceClient.ListTraces</c> and
        /// <c>TraceServiceClient.ListTracesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListTracesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(45000)),
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
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("cloudtrace.googleapis.com", 443);

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
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/trace.append",
            "https://www.googleapis.com/auth/trace.readonly",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="TraceServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Trace.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// TraceServiceClient client = await TraceServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Trace.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     TraceServiceClient.DefaultEndpoint.Host, TraceServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// TraceServiceClient client = TraceServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="TraceServiceClient"/>.</returns>
        public static async stt::Task<TraceServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, TraceServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="TraceServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Trace.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// TraceServiceClient client = TraceServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Trace.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     TraceServiceClient.DefaultEndpoint.Host, TraceServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// TraceServiceClient client = TraceServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <returns>The created <see cref="TraceServiceClient"/>.</returns>
        public static TraceServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, TraceServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="TraceServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <returns>The created <see cref="TraceServiceClient"/>.</returns>
        public static TraceServiceClient Create(grpccore::Channel channel, TraceServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="TraceServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="TraceServiceSettings"/>.</param>
        /// <returns>The created <see cref="TraceServiceClient"/>.</returns>
        public static TraceServiceClient Create(grpccore::CallInvoker callInvoker, TraceServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TraceService.TraceServiceClient grpcClient = new TraceService.TraceServiceClient(callInvoker);
            return new TraceServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, TraceServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, TraceServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, TraceServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, TraceServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC TraceService client.
        /// </summary>
        public virtual TraceService.TraceServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task PatchTracesAsync(
            string projectId,
            Traces traces,
            gaxgrpc::CallSettings callSettings = null) => PatchTracesAsync(
                new PatchTracesRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Traces = gax::GaxPreconditions.CheckNotNull(traces, nameof(traces)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task PatchTracesAsync(
            string projectId,
            Traces traces,
            st::CancellationToken cancellationToken) => PatchTracesAsync(
                projectId,
                traces,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void PatchTraces(
            string projectId,
            Traces traces,
            gaxgrpc::CallSettings callSettings = null) => PatchTraces(
                new PatchTracesRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    Traces = gax::GaxPreconditions.CheckNotNull(traces, nameof(traces)),
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task PatchTracesAsync(
            PatchTracesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task PatchTracesAsync(
            PatchTracesRequest request,
            st::CancellationToken cancellationToken) => PatchTracesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void PatchTraces(
            PatchTracesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<Trace> GetTraceAsync(
            string projectId,
            string traceId,
            gaxgrpc::CallSettings callSettings = null) => GetTraceAsync(
                new GetTraceRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    TraceId = gax::GaxPreconditions.CheckNotNullOrEmpty(traceId, nameof(traceId)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Trace> GetTraceAsync(
            string projectId,
            string traceId,
            st::CancellationToken cancellationToken) => GetTraceAsync(
                projectId,
                traceId,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => GetTrace(
                new GetTraceRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                    TraceId = gax::GaxPreconditions.CheckNotNullOrEmpty(traceId, nameof(traceId)),
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
        public virtual stt::Task<Trace> GetTraceAsync(
            GetTraceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single trace by its ID.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Trace> GetTraceAsync(
            GetTraceRequest request,
            st::CancellationToken cancellationToken) => GetTraceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual gax::PagedAsyncEnumerable<ListTracesResponse, Trace> ListTracesAsync(
            string projectId,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTracesAsync(
                new ListTracesRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
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
        public virtual gax::PagedEnumerable<ListTracesResponse, Trace> ListTraces(
            string projectId,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTraces(
                new ListTracesRequest
                {
                    ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
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
        public virtual gax::PagedAsyncEnumerable<ListTracesResponse, Trace> ListTracesAsync(
            ListTracesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual gax::PagedEnumerable<ListTracesResponse, Trace> ListTraces(
            ListTracesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// TraceService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class TraceServiceClientImpl : TraceServiceClient
    {
        private readonly gaxgrpc::ApiCall<PatchTracesRequest, pbwkt::Empty> _callPatchTraces;
        private readonly gaxgrpc::ApiCall<GetTraceRequest, Trace> _callGetTrace;
        private readonly gaxgrpc::ApiCall<ListTracesRequest, ListTracesResponse> _callListTraces;

        /// <summary>
        /// Constructs a client wrapper for the TraceService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TraceServiceSettings"/> used within this client </param>
        public TraceServiceClientImpl(TraceService.TraceServiceClient grpcClient, TraceServiceSettings settings)
        {
            GrpcClient = grpcClient;
            TraceServiceSettings effectiveSettings = settings ?? TraceServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callPatchTraces = clientHelper.BuildApiCall<PatchTracesRequest, pbwkt::Empty>(
                GrpcClient.PatchTracesAsync, GrpcClient.PatchTraces, effectiveSettings.PatchTracesSettings);
            _callGetTrace = clientHelper.BuildApiCall<GetTraceRequest, Trace>(
                GrpcClient.GetTraceAsync, GrpcClient.GetTrace, effectiveSettings.GetTraceSettings);
            _callListTraces = clientHelper.BuildApiCall<ListTracesRequest, ListTracesResponse>(
                GrpcClient.ListTracesAsync, GrpcClient.ListTraces, effectiveSettings.ListTracesSettings);
            Modify_ApiCall(ref _callPatchTraces);
            Modify_PatchTracesApiCall(ref _callPatchTraces);
            Modify_ApiCall(ref _callGetTrace);
            Modify_GetTraceApiCall(ref _callGetTrace);
            Modify_ApiCall(ref _callListTraces);
            Modify_ListTracesApiCall(ref _callListTraces);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_PatchTracesApiCall(ref gaxgrpc::ApiCall<PatchTracesRequest, pbwkt::Empty> call);
        partial void Modify_GetTraceApiCall(ref gaxgrpc::ApiCall<GetTraceRequest, Trace> call);
        partial void Modify_ListTracesApiCall(ref gaxgrpc::ApiCall<ListTracesRequest, ListTracesResponse> call);
        partial void OnConstruction(TraceService.TraceServiceClient grpcClient, TraceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC TraceService client.
        /// </summary>
        public override TraceService.TraceServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_PatchTracesRequest(ref PatchTracesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetTraceRequest(ref GetTraceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListTracesRequest(ref ListTracesRequest request, ref gaxgrpc::CallSettings settings);

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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task PatchTracesAsync(
            PatchTracesRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override void PatchTraces(
            PatchTracesRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<Trace> GetTraceAsync(
            GetTraceRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override gax::PagedAsyncEnumerable<ListTracesResponse, Trace> ListTracesAsync(
            ListTracesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTracesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTracesRequest, ListTracesResponse, Trace>(_callListTraces, request, callSettings);
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
        public override gax::PagedEnumerable<ListTracesResponse, Trace> ListTraces(
            ListTracesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTracesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTracesRequest, ListTracesResponse, Trace>(_callListTraces, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListTracesRequest : gaxgrpc::IPageRequest { }
    public partial class ListTracesResponse : gaxgrpc::IPageResponse<Trace>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Trace> GetEnumerator() => Traces.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
