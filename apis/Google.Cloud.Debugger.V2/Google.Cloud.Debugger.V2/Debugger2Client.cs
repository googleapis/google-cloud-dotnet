// Copyright 2019 Google LLC
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

namespace Google.Cloud.Debugger.V2
{
    /// <summary>
    /// Settings for a <see cref="Debugger2Client"/>.
    /// </summary>
    public sealed partial class Debugger2Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="Debugger2Settings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="Debugger2Settings"/>.
        /// </returns>
        public static Debugger2Settings GetDefault() => new Debugger2Settings();

        /// <summary>
        /// Constructs a new <see cref="Debugger2Settings"/> object with default settings.
        /// </summary>
        public Debugger2Settings() { }

        private Debugger2Settings(Debugger2Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SetBreakpointSettings = existing.SetBreakpointSettings;
            GetBreakpointSettings = existing.GetBreakpointSettings;
            DeleteBreakpointSettings = existing.DeleteBreakpointSettings;
            ListBreakpointsSettings = existing.ListBreakpointsSettings;
            ListDebuggeesSettings = existing.ListDebuggeesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(Debugger2Settings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="Debugger2Client"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="Debugger2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="Debugger2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="Debugger2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="Debugger2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="Debugger2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="Debugger2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="Debugger2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.SetBreakpoint</c> and <c>Debugger2Client.SetBreakpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Debugger2Client.SetBreakpoint</c> and
        /// <c>Debugger2Client.SetBreakpointAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SetBreakpointSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.GetBreakpoint</c> and <c>Debugger2Client.GetBreakpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Debugger2Client.GetBreakpoint</c> and
        /// <c>Debugger2Client.GetBreakpointAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetBreakpointSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.DeleteBreakpoint</c> and <c>Debugger2Client.DeleteBreakpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Debugger2Client.DeleteBreakpoint</c> and
        /// <c>Debugger2Client.DeleteBreakpointAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteBreakpointSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.ListBreakpoints</c> and <c>Debugger2Client.ListBreakpointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Debugger2Client.ListBreakpoints</c> and
        /// <c>Debugger2Client.ListBreakpointsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListBreakpointsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.ListDebuggees</c> and <c>Debugger2Client.ListDebuggeesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Debugger2Client.ListDebuggees</c> and
        /// <c>Debugger2Client.ListDebuggeesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListDebuggeesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="Debugger2Settings"/> object.</returns>
        public Debugger2Settings Clone() => new Debugger2Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="Debugger2Client"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class Debugger2ClientBuilder : gaxgrpc::ClientBuilderBase<Debugger2Client>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public Debugger2Settings Settings { get; set; }

        /// <inheritdoc/>
        public override Debugger2Client Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return Debugger2Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<Debugger2Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return Debugger2Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => Debugger2Client.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => Debugger2Client.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => Debugger2Client.ChannelPool;
    }

    /// <summary>
    /// Debugger2 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class Debugger2Client
    {
        /// <summary>
        /// The default endpoint for the Debugger2 service, which is a host of "clouddebugger.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("clouddebugger.googleapis.com", 443);

        /// <summary>
        /// The default Debugger2 scopes.
        /// </summary>
        /// <remarks>
        /// The default Debugger2 scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud_debugger"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud_debugger",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="Debugger2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Debugger.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// Debugger2Client client = await Debugger2Client.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Debugger.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     Debugger2Client.DefaultEndpoint.Host, Debugger2Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// Debugger2Client client = Debugger2Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="Debugger2Settings"/>.</param>
        /// <returns>The task representing the created <see cref="Debugger2Client"/>.</returns>
        public static async stt::Task<Debugger2Client> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, Debugger2Settings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="Debugger2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Debugger.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// Debugger2Client client = Debugger2Client.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Debugger.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     Debugger2Client.DefaultEndpoint.Host, Debugger2Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// Debugger2Client client = Debugger2Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="Debugger2Settings"/>.</param>
        /// <returns>The created <see cref="Debugger2Client"/>.</returns>
        public static Debugger2Client Create(gaxgrpc::ServiceEndpoint endpoint = null, Debugger2Settings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="Debugger2Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="Debugger2Settings"/>.</param>
        /// <returns>The created <see cref="Debugger2Client"/>.</returns>
        public static Debugger2Client Create(grpccore::Channel channel, Debugger2Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="Debugger2Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="Debugger2Settings"/>.</param>
        /// <returns>The created <see cref="Debugger2Client"/>.</returns>
        public static Debugger2Client Create(grpccore::CallInvoker callInvoker, Debugger2Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Debugger2.Debugger2Client grpcClient = new Debugger2.Debugger2Client(callInvoker);
            return new Debugger2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, Debugger2Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, Debugger2Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, Debugger2Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, Debugger2Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Debugger2 client.
        /// </summary>
        public virtual Debugger2.Debugger2Client GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Sets the breakpoint to the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// Required. ID of the debuggee where the breakpoint is to be set.
        /// </param>
        /// <param name="breakpoint">
        /// Required. Breakpoint specification to set.
        /// The field `location` of the breakpoint must be set.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SetBreakpointResponse> SetBreakpointAsync(
            string debuggeeId,
            Breakpoint breakpoint,
            string clientVersion,
            gaxgrpc::CallSettings callSettings = null) => SetBreakpointAsync(
                new SetBreakpointRequest
                {
                    DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    Breakpoint = gax::GaxPreconditions.CheckNotNull(breakpoint, nameof(breakpoint)),
                    ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Sets the breakpoint to the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// Required. ID of the debuggee where the breakpoint is to be set.
        /// </param>
        /// <param name="breakpoint">
        /// Required. Breakpoint specification to set.
        /// The field `location` of the breakpoint must be set.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SetBreakpointResponse> SetBreakpointAsync(
            string debuggeeId,
            Breakpoint breakpoint,
            string clientVersion,
            st::CancellationToken cancellationToken) => SetBreakpointAsync(
                debuggeeId,
                breakpoint,
                clientVersion,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the breakpoint to the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// Required. ID of the debuggee where the breakpoint is to be set.
        /// </param>
        /// <param name="breakpoint">
        /// Required. Breakpoint specification to set.
        /// The field `location` of the breakpoint must be set.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SetBreakpointResponse SetBreakpoint(
            string debuggeeId,
            Breakpoint breakpoint,
            string clientVersion,
            gaxgrpc::CallSettings callSettings = null) => SetBreakpoint(
                new SetBreakpointRequest
                {
                    DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    Breakpoint = gax::GaxPreconditions.CheckNotNull(breakpoint, nameof(breakpoint)),
                    ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Sets the breakpoint to the debuggee.
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
        public virtual stt::Task<SetBreakpointResponse> SetBreakpointAsync(
            SetBreakpointRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Sets the breakpoint to the debuggee.
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
        public virtual stt::Task<SetBreakpointResponse> SetBreakpointAsync(
            SetBreakpointRequest request,
            st::CancellationToken cancellationToken) => SetBreakpointAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the breakpoint to the debuggee.
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
        public virtual SetBreakpointResponse SetBreakpoint(
            SetBreakpointRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets breakpoint information.
        /// </summary>
        /// <param name="debuggeeId">
        /// Required. ID of the debuggee whose breakpoint to get.
        /// </param>
        /// <param name="breakpointId">
        /// Required. ID of the breakpoint to get.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GetBreakpointResponse> GetBreakpointAsync(
            string debuggeeId,
            string breakpointId,
            string clientVersion,
            gaxgrpc::CallSettings callSettings = null) => GetBreakpointAsync(
                new GetBreakpointRequest
                {
                    DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    BreakpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(breakpointId, nameof(breakpointId)),
                    ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Gets breakpoint information.
        /// </summary>
        /// <param name="debuggeeId">
        /// Required. ID of the debuggee whose breakpoint to get.
        /// </param>
        /// <param name="breakpointId">
        /// Required. ID of the breakpoint to get.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GetBreakpointResponse> GetBreakpointAsync(
            string debuggeeId,
            string breakpointId,
            string clientVersion,
            st::CancellationToken cancellationToken) => GetBreakpointAsync(
                debuggeeId,
                breakpointId,
                clientVersion,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets breakpoint information.
        /// </summary>
        /// <param name="debuggeeId">
        /// Required. ID of the debuggee whose breakpoint to get.
        /// </param>
        /// <param name="breakpointId">
        /// Required. ID of the breakpoint to get.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual GetBreakpointResponse GetBreakpoint(
            string debuggeeId,
            string breakpointId,
            string clientVersion,
            gaxgrpc::CallSettings callSettings = null) => GetBreakpoint(
                new GetBreakpointRequest
                {
                    DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    BreakpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(breakpointId, nameof(breakpointId)),
                    ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Gets breakpoint information.
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
        public virtual stt::Task<GetBreakpointResponse> GetBreakpointAsync(
            GetBreakpointRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets breakpoint information.
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
        public virtual stt::Task<GetBreakpointResponse> GetBreakpointAsync(
            GetBreakpointRequest request,
            st::CancellationToken cancellationToken) => GetBreakpointAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets breakpoint information.
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
        public virtual GetBreakpointResponse GetBreakpoint(
            GetBreakpointRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// Required. ID of the debuggee whose breakpoint to delete.
        /// </param>
        /// <param name="breakpointId">
        /// Required. ID of the breakpoint to delete.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteBreakpointAsync(
            string debuggeeId,
            string breakpointId,
            string clientVersion,
            gaxgrpc::CallSettings callSettings = null) => DeleteBreakpointAsync(
                new DeleteBreakpointRequest
                {
                    DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    BreakpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(breakpointId, nameof(breakpointId)),
                    ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// Required. ID of the debuggee whose breakpoint to delete.
        /// </param>
        /// <param name="breakpointId">
        /// Required. ID of the breakpoint to delete.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteBreakpointAsync(
            string debuggeeId,
            string breakpointId,
            string clientVersion,
            st::CancellationToken cancellationToken) => DeleteBreakpointAsync(
                debuggeeId,
                breakpointId,
                clientVersion,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// Required. ID of the debuggee whose breakpoint to delete.
        /// </param>
        /// <param name="breakpointId">
        /// Required. ID of the breakpoint to delete.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteBreakpoint(
            string debuggeeId,
            string breakpointId,
            string clientVersion,
            gaxgrpc::CallSettings callSettings = null) => DeleteBreakpoint(
                new DeleteBreakpointRequest
                {
                    DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    BreakpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(breakpointId, nameof(breakpointId)),
                    ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
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
        public virtual stt::Task DeleteBreakpointAsync(
            DeleteBreakpointRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
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
        public virtual stt::Task DeleteBreakpointAsync(
            DeleteBreakpointRequest request,
            st::CancellationToken cancellationToken) => DeleteBreakpointAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteBreakpoint(
            DeleteBreakpointRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all breakpoints for the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// Required. ID of the debuggee whose breakpoints to list.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListBreakpointsResponse> ListBreakpointsAsync(
            string debuggeeId,
            string clientVersion,
            gaxgrpc::CallSettings callSettings = null) => ListBreakpointsAsync(
                new ListBreakpointsRequest
                {
                    DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Lists all breakpoints for the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// Required. ID of the debuggee whose breakpoints to list.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListBreakpointsResponse> ListBreakpointsAsync(
            string debuggeeId,
            string clientVersion,
            st::CancellationToken cancellationToken) => ListBreakpointsAsync(
                debuggeeId,
                clientVersion,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all breakpoints for the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// Required. ID of the debuggee whose breakpoints to list.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListBreakpointsResponse ListBreakpoints(
            string debuggeeId,
            string clientVersion,
            gaxgrpc::CallSettings callSettings = null) => ListBreakpoints(
                new ListBreakpointsRequest
                {
                    DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Lists all breakpoints for the debuggee.
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
        public virtual stt::Task<ListBreakpointsResponse> ListBreakpointsAsync(
            ListBreakpointsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all breakpoints for the debuggee.
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
        public virtual stt::Task<ListBreakpointsResponse> ListBreakpointsAsync(
            ListBreakpointsRequest request,
            st::CancellationToken cancellationToken) => ListBreakpointsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all breakpoints for the debuggee.
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
        public virtual ListBreakpointsResponse ListBreakpoints(
            ListBreakpointsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all the debuggees that the user has access to.
        /// </summary>
        /// <param name="project">
        /// Required. Project number of a Google Cloud project whose debuggees to list.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListDebuggeesResponse> ListDebuggeesAsync(
            string project,
            string clientVersion,
            gaxgrpc::CallSettings callSettings = null) => ListDebuggeesAsync(
                new ListDebuggeesRequest
                {
                    Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                    ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Lists all the debuggees that the user has access to.
        /// </summary>
        /// <param name="project">
        /// Required. Project number of a Google Cloud project whose debuggees to list.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListDebuggeesResponse> ListDebuggeesAsync(
            string project,
            string clientVersion,
            st::CancellationToken cancellationToken) => ListDebuggeesAsync(
                project,
                clientVersion,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the debuggees that the user has access to.
        /// </summary>
        /// <param name="project">
        /// Required. Project number of a Google Cloud project whose debuggees to list.
        /// </param>
        /// <param name="clientVersion">
        /// Required. The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListDebuggeesResponse ListDebuggees(
            string project,
            string clientVersion,
            gaxgrpc::CallSettings callSettings = null) => ListDebuggees(
                new ListDebuggeesRequest
                {
                    Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                    ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Lists all the debuggees that the user has access to.
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
        public virtual stt::Task<ListDebuggeesResponse> ListDebuggeesAsync(
            ListDebuggeesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all the debuggees that the user has access to.
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
        public virtual stt::Task<ListDebuggeesResponse> ListDebuggeesAsync(
            ListDebuggeesRequest request,
            st::CancellationToken cancellationToken) => ListDebuggeesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the debuggees that the user has access to.
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
        public virtual ListDebuggeesResponse ListDebuggees(
            ListDebuggeesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// Debugger2 client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class Debugger2ClientImpl : Debugger2Client
    {
        private readonly gaxgrpc::ApiCall<SetBreakpointRequest, SetBreakpointResponse> _callSetBreakpoint;
        private readonly gaxgrpc::ApiCall<GetBreakpointRequest, GetBreakpointResponse> _callGetBreakpoint;
        private readonly gaxgrpc::ApiCall<DeleteBreakpointRequest, pbwkt::Empty> _callDeleteBreakpoint;
        private readonly gaxgrpc::ApiCall<ListBreakpointsRequest, ListBreakpointsResponse> _callListBreakpoints;
        private readonly gaxgrpc::ApiCall<ListDebuggeesRequest, ListDebuggeesResponse> _callListDebuggees;

        /// <summary>
        /// Constructs a client wrapper for the Debugger2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="Debugger2Settings"/> used within this client </param>
        public Debugger2ClientImpl(Debugger2.Debugger2Client grpcClient, Debugger2Settings settings)
        {
            GrpcClient = grpcClient;
            Debugger2Settings effectiveSettings = settings ?? Debugger2Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callSetBreakpoint = clientHelper.BuildApiCall<SetBreakpointRequest, SetBreakpointResponse>(
                GrpcClient.SetBreakpointAsync, GrpcClient.SetBreakpoint, effectiveSettings.SetBreakpointSettings)
                .WithGoogleRequestParam("debuggee_id", request => request.DebuggeeId);
            _callGetBreakpoint = clientHelper.BuildApiCall<GetBreakpointRequest, GetBreakpointResponse>(
                GrpcClient.GetBreakpointAsync, GrpcClient.GetBreakpoint, effectiveSettings.GetBreakpointSettings);
            _callDeleteBreakpoint = clientHelper.BuildApiCall<DeleteBreakpointRequest, pbwkt::Empty>(
                GrpcClient.DeleteBreakpointAsync, GrpcClient.DeleteBreakpoint, effectiveSettings.DeleteBreakpointSettings);
            _callListBreakpoints = clientHelper.BuildApiCall<ListBreakpointsRequest, ListBreakpointsResponse>(
                GrpcClient.ListBreakpointsAsync, GrpcClient.ListBreakpoints, effectiveSettings.ListBreakpointsSettings)
                .WithGoogleRequestParam("debuggee_id", request => request.DebuggeeId);
            _callListDebuggees = clientHelper.BuildApiCall<ListDebuggeesRequest, ListDebuggeesResponse>(
                GrpcClient.ListDebuggeesAsync, GrpcClient.ListDebuggees, effectiveSettings.ListDebuggeesSettings);
            Modify_ApiCall(ref _callSetBreakpoint);
            Modify_SetBreakpointApiCall(ref _callSetBreakpoint);
            Modify_ApiCall(ref _callGetBreakpoint);
            Modify_GetBreakpointApiCall(ref _callGetBreakpoint);
            Modify_ApiCall(ref _callDeleteBreakpoint);
            Modify_DeleteBreakpointApiCall(ref _callDeleteBreakpoint);
            Modify_ApiCall(ref _callListBreakpoints);
            Modify_ListBreakpointsApiCall(ref _callListBreakpoints);
            Modify_ApiCall(ref _callListDebuggees);
            Modify_ListDebuggeesApiCall(ref _callListDebuggees);
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
        partial void Modify_SetBreakpointApiCall(ref gaxgrpc::ApiCall<SetBreakpointRequest, SetBreakpointResponse> call);
        partial void Modify_GetBreakpointApiCall(ref gaxgrpc::ApiCall<GetBreakpointRequest, GetBreakpointResponse> call);
        partial void Modify_DeleteBreakpointApiCall(ref gaxgrpc::ApiCall<DeleteBreakpointRequest, pbwkt::Empty> call);
        partial void Modify_ListBreakpointsApiCall(ref gaxgrpc::ApiCall<ListBreakpointsRequest, ListBreakpointsResponse> call);
        partial void Modify_ListDebuggeesApiCall(ref gaxgrpc::ApiCall<ListDebuggeesRequest, ListDebuggeesResponse> call);
        partial void OnConstruction(Debugger2.Debugger2Client grpcClient, Debugger2Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Debugger2 client.
        /// </summary>
        public override Debugger2.Debugger2Client GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_SetBreakpointRequest(ref SetBreakpointRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetBreakpointRequest(ref GetBreakpointRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteBreakpointRequest(ref DeleteBreakpointRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListBreakpointsRequest(ref ListBreakpointsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListDebuggeesRequest(ref ListDebuggeesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Sets the breakpoint to the debuggee.
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
        public override stt::Task<SetBreakpointResponse> SetBreakpointAsync(
            SetBreakpointRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetBreakpointRequest(ref request, ref callSettings);
            return _callSetBreakpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the breakpoint to the debuggee.
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
        public override SetBreakpointResponse SetBreakpoint(
            SetBreakpointRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetBreakpointRequest(ref request, ref callSettings);
            return _callSetBreakpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets breakpoint information.
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
        public override stt::Task<GetBreakpointResponse> GetBreakpointAsync(
            GetBreakpointRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBreakpointRequest(ref request, ref callSettings);
            return _callGetBreakpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Gets breakpoint information.
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
        public override GetBreakpointResponse GetBreakpoint(
            GetBreakpointRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBreakpointRequest(ref request, ref callSettings);
            return _callGetBreakpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
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
        public override stt::Task DeleteBreakpointAsync(
            DeleteBreakpointRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBreakpointRequest(ref request, ref callSettings);
            return _callDeleteBreakpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteBreakpoint(
            DeleteBreakpointRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBreakpointRequest(ref request, ref callSettings);
            _callDeleteBreakpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all breakpoints for the debuggee.
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
        public override stt::Task<ListBreakpointsResponse> ListBreakpointsAsync(
            ListBreakpointsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBreakpointsRequest(ref request, ref callSettings);
            return _callListBreakpoints.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all breakpoints for the debuggee.
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
        public override ListBreakpointsResponse ListBreakpoints(
            ListBreakpointsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBreakpointsRequest(ref request, ref callSettings);
            return _callListBreakpoints.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all the debuggees that the user has access to.
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
        public override stt::Task<ListDebuggeesResponse> ListDebuggeesAsync(
            ListDebuggeesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDebuggeesRequest(ref request, ref callSettings);
            return _callListDebuggees.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the debuggees that the user has access to.
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
        public override ListDebuggeesResponse ListDebuggees(
            ListDebuggeesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDebuggeesRequest(ref request, ref callSettings);
            return _callListDebuggees.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
