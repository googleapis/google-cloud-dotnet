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

namespace Google.Cloud.Debugger.V2
{
    /// <summary>
    /// Settings for a <see cref="Debugger2Client"/>.
    /// </summary>
    public sealed partial class Debugger2Settings : ServiceSettingsBase
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
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SetBreakpointSettings = existing.SetBreakpointSettings;
            GetBreakpointSettings = existing.GetBreakpointSettings;
            DeleteBreakpointSettings = existing.DeleteBreakpointSettings;
            ListBreakpointsSettings = existing.ListBreakpointsSettings;
            ListDebuggeesSettings = existing.ListDebuggeesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(Debugger2Settings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="Debugger2Client"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="Debugger2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

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
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
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
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(60000),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.SetBreakpoint</c> and <c>Debugger2Client.SetBreakpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Debugger2Client.SetBreakpoint</c> and
        /// <c>Debugger2Client.SetBreakpointAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings SetBreakpointSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.GetBreakpoint</c> and <c>Debugger2Client.GetBreakpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Debugger2Client.GetBreakpoint</c> and
        /// <c>Debugger2Client.GetBreakpointAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetBreakpointSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.DeleteBreakpoint</c> and <c>Debugger2Client.DeleteBreakpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Debugger2Client.DeleteBreakpoint</c> and
        /// <c>Debugger2Client.DeleteBreakpointAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteBreakpointSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.ListBreakpoints</c> and <c>Debugger2Client.ListBreakpointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Debugger2Client.ListBreakpoints</c> and
        /// <c>Debugger2Client.ListBreakpointsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListBreakpointsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.ListDebuggees</c> and <c>Debugger2Client.ListDebuggeesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Debugger2Client.ListDebuggees</c> and
        /// <c>Debugger2Client.ListDebuggeesAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListDebuggeesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="Debugger2Settings"/> object.</returns>
        public Debugger2Settings Clone() => new Debugger2Settings(this);
    }

    /// <summary>
    /// Debugger2 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class Debugger2Client
    {
        /// <summary>
        /// The default endpoint for the Debugger2 service, which is a host of "clouddebugger.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("clouddebugger.googleapis.com", 443);

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
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud_debugger",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="Debugger2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="Debugger2Settings"/>.</param>
        /// <returns>The task representing the created <see cref="Debugger2Client"/>.</returns>
        public static async Task<Debugger2Client> CreateAsync(ServiceEndpoint endpoint = null, Debugger2Settings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="Debugger2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="Debugger2Settings"/>.</param>
        /// <returns>The created <see cref="Debugger2Client"/>.</returns>
        public static Debugger2Client Create(ServiceEndpoint endpoint = null, Debugger2Settings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="Debugger2Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="Debugger2Settings"/>.</param>
        /// <returns>The created <see cref="Debugger2Client"/>.</returns>
        public static Debugger2Client Create(Channel channel, Debugger2Settings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            Debugger2.Debugger2Client grpcClient = new Debugger2.Debugger2Client(channel);
            return new Debugger2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, Debugger2Settings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, Debugger2Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, Debugger2Settings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, Debugger2Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Debugger2 client.
        /// </summary>
        public virtual Debugger2.Debugger2Client GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Sets the breakpoint to the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// ID of the debuggee where the breakpoint is to be set.
        /// </param>
        /// <param name="breakpoint">
        /// Breakpoint specification to set.
        /// The field `location` of the breakpoint must be set.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<SetBreakpointResponse> SetBreakpointAsync(
            string debuggeeId,
            Breakpoint breakpoint,
            string clientVersion,
            CallSettings callSettings = null) => SetBreakpointAsync(
                new SetBreakpointRequest
                {
                    DebuggeeId = GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    Breakpoint = GaxPreconditions.CheckNotNull(breakpoint, nameof(breakpoint)),
                    ClientVersion = GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Sets the breakpoint to the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// ID of the debuggee where the breakpoint is to be set.
        /// </param>
        /// <param name="breakpoint">
        /// Breakpoint specification to set.
        /// The field `location` of the breakpoint must be set.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<SetBreakpointResponse> SetBreakpointAsync(
            string debuggeeId,
            Breakpoint breakpoint,
            string clientVersion,
            CancellationToken cancellationToken) => SetBreakpointAsync(
                debuggeeId,
                breakpoint,
                clientVersion,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the breakpoint to the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// ID of the debuggee where the breakpoint is to be set.
        /// </param>
        /// <param name="breakpoint">
        /// Breakpoint specification to set.
        /// The field `location` of the breakpoint must be set.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
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
            CallSettings callSettings = null) => SetBreakpoint(
                new SetBreakpointRequest
                {
                    DebuggeeId = GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    Breakpoint = GaxPreconditions.CheckNotNull(breakpoint, nameof(breakpoint)),
                    ClientVersion = GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
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
        public virtual Task<SetBreakpointResponse> SetBreakpointAsync(
            SetBreakpointRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual SetBreakpointResponse SetBreakpoint(
            SetBreakpointRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets breakpoint information.
        /// </summary>
        /// <param name="debuggeeId">
        /// ID of the debuggee whose breakpoint to get.
        /// </param>
        /// <param name="breakpointId">
        /// ID of the breakpoint to get.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<GetBreakpointResponse> GetBreakpointAsync(
            string debuggeeId,
            string breakpointId,
            string clientVersion,
            CallSettings callSettings = null) => GetBreakpointAsync(
                new GetBreakpointRequest
                {
                    DebuggeeId = GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    BreakpointId = GaxPreconditions.CheckNotNullOrEmpty(breakpointId, nameof(breakpointId)),
                    ClientVersion = GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Gets breakpoint information.
        /// </summary>
        /// <param name="debuggeeId">
        /// ID of the debuggee whose breakpoint to get.
        /// </param>
        /// <param name="breakpointId">
        /// ID of the breakpoint to get.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<GetBreakpointResponse> GetBreakpointAsync(
            string debuggeeId,
            string breakpointId,
            string clientVersion,
            CancellationToken cancellationToken) => GetBreakpointAsync(
                debuggeeId,
                breakpointId,
                clientVersion,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets breakpoint information.
        /// </summary>
        /// <param name="debuggeeId">
        /// ID of the debuggee whose breakpoint to get.
        /// </param>
        /// <param name="breakpointId">
        /// ID of the breakpoint to get.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
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
            CallSettings callSettings = null) => GetBreakpoint(
                new GetBreakpointRequest
                {
                    DebuggeeId = GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    BreakpointId = GaxPreconditions.CheckNotNullOrEmpty(breakpointId, nameof(breakpointId)),
                    ClientVersion = GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
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
        public virtual Task<GetBreakpointResponse> GetBreakpointAsync(
            GetBreakpointRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual GetBreakpointResponse GetBreakpoint(
            GetBreakpointRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// ID of the debuggee whose breakpoint to delete.
        /// </param>
        /// <param name="breakpointId">
        /// ID of the breakpoint to delete.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteBreakpointAsync(
            string debuggeeId,
            string breakpointId,
            string clientVersion,
            CallSettings callSettings = null) => DeleteBreakpointAsync(
                new DeleteBreakpointRequest
                {
                    DebuggeeId = GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    BreakpointId = GaxPreconditions.CheckNotNullOrEmpty(breakpointId, nameof(breakpointId)),
                    ClientVersion = GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// ID of the debuggee whose breakpoint to delete.
        /// </param>
        /// <param name="breakpointId">
        /// ID of the breakpoint to delete.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteBreakpointAsync(
            string debuggeeId,
            string breakpointId,
            string clientVersion,
            CancellationToken cancellationToken) => DeleteBreakpointAsync(
                debuggeeId,
                breakpointId,
                clientVersion,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// ID of the debuggee whose breakpoint to delete.
        /// </param>
        /// <param name="breakpointId">
        /// ID of the breakpoint to delete.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteBreakpoint(
            string debuggeeId,
            string breakpointId,
            string clientVersion,
            CallSettings callSettings = null) => DeleteBreakpoint(
                new DeleteBreakpointRequest
                {
                    DebuggeeId = GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    BreakpointId = GaxPreconditions.CheckNotNullOrEmpty(breakpointId, nameof(breakpointId)),
                    ClientVersion = GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
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
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteBreakpointAsync(
            DeleteBreakpointRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        /// The RPC response.
        /// </returns>
        public virtual void DeleteBreakpoint(
            DeleteBreakpointRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all breakpoints for the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// ID of the debuggee whose breakpoints to list.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListBreakpointsResponse> ListBreakpointsAsync(
            string debuggeeId,
            string clientVersion,
            CallSettings callSettings = null) => ListBreakpointsAsync(
                new ListBreakpointsRequest
                {
                    DebuggeeId = GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    ClientVersion = GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Lists all breakpoints for the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// ID of the debuggee whose breakpoints to list.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListBreakpointsResponse> ListBreakpointsAsync(
            string debuggeeId,
            string clientVersion,
            CancellationToken cancellationToken) => ListBreakpointsAsync(
                debuggeeId,
                clientVersion,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all breakpoints for the debuggee.
        /// </summary>
        /// <param name="debuggeeId">
        /// ID of the debuggee whose breakpoints to list.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
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
            CallSettings callSettings = null) => ListBreakpoints(
                new ListBreakpointsRequest
                {
                    DebuggeeId = GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    ClientVersion = GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
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
        public virtual Task<ListBreakpointsResponse> ListBreakpointsAsync(
            ListBreakpointsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual ListBreakpointsResponse ListBreakpoints(
            ListBreakpointsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all the debuggees that the user has access to.
        /// </summary>
        /// <param name="project">
        /// Project number of a Google Cloud project whose debuggees to list.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListDebuggeesResponse> ListDebuggeesAsync(
            string project,
            string clientVersion,
            CallSettings callSettings = null) => ListDebuggeesAsync(
                new ListDebuggeesRequest
                {
                    Project = GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                    ClientVersion = GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
                },
                callSettings);

        /// <summary>
        /// Lists all the debuggees that the user has access to.
        /// </summary>
        /// <param name="project">
        /// Project number of a Google Cloud project whose debuggees to list.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
        /// Schema: `domain/type/version` (e.g., `google.com/intellij/v1`).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListDebuggeesResponse> ListDebuggeesAsync(
            string project,
            string clientVersion,
            CancellationToken cancellationToken) => ListDebuggeesAsync(
                project,
                clientVersion,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the debuggees that the user has access to.
        /// </summary>
        /// <param name="project">
        /// Project number of a Google Cloud project whose debuggees to list.
        /// </param>
        /// <param name="clientVersion">
        /// The client version making the call.
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
            CallSettings callSettings = null) => ListDebuggees(
                new ListDebuggeesRequest
                {
                    Project = GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                    ClientVersion = GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
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
        public virtual Task<ListDebuggeesResponse> ListDebuggeesAsync(
            ListDebuggeesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual ListDebuggeesResponse ListDebuggees(
            ListDebuggeesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// Debugger2 client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class Debugger2ClientImpl : Debugger2Client
    {
        private readonly ApiCall<SetBreakpointRequest, SetBreakpointResponse> _callSetBreakpoint;
        private readonly ApiCall<GetBreakpointRequest, GetBreakpointResponse> _callGetBreakpoint;
        private readonly ApiCall<DeleteBreakpointRequest, Empty> _callDeleteBreakpoint;
        private readonly ApiCall<ListBreakpointsRequest, ListBreakpointsResponse> _callListBreakpoints;
        private readonly ApiCall<ListDebuggeesRequest, ListDebuggeesResponse> _callListDebuggees;

        /// <summary>
        /// Constructs a client wrapper for the Debugger2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="Debugger2Settings"/> used within this client </param>
        public Debugger2ClientImpl(Debugger2.Debugger2Client grpcClient, Debugger2Settings settings)
        {
            GrpcClient = grpcClient;
            Debugger2Settings effectiveSettings = settings ?? Debugger2Settings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callSetBreakpoint = clientHelper.BuildApiCall<SetBreakpointRequest, SetBreakpointResponse>(
                GrpcClient.SetBreakpointAsync, GrpcClient.SetBreakpoint, effectiveSettings.SetBreakpointSettings);
            _callGetBreakpoint = clientHelper.BuildApiCall<GetBreakpointRequest, GetBreakpointResponse>(
                GrpcClient.GetBreakpointAsync, GrpcClient.GetBreakpoint, effectiveSettings.GetBreakpointSettings);
            _callDeleteBreakpoint = clientHelper.BuildApiCall<DeleteBreakpointRequest, Empty>(
                GrpcClient.DeleteBreakpointAsync, GrpcClient.DeleteBreakpoint, effectiveSettings.DeleteBreakpointSettings);
            _callListBreakpoints = clientHelper.BuildApiCall<ListBreakpointsRequest, ListBreakpointsResponse>(
                GrpcClient.ListBreakpointsAsync, GrpcClient.ListBreakpoints, effectiveSettings.ListBreakpointsSettings);
            _callListDebuggees = clientHelper.BuildApiCall<ListDebuggeesRequest, ListDebuggeesResponse>(
                GrpcClient.ListDebuggeesAsync, GrpcClient.ListDebuggees, effectiveSettings.ListDebuggeesSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(Debugger2.Debugger2Client grpcClient, Debugger2Settings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Debugger2 client.
        /// </summary>
        public override Debugger2.Debugger2Client GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_SetBreakpointRequest(ref SetBreakpointRequest request, ref CallSettings settings);
        partial void Modify_GetBreakpointRequest(ref GetBreakpointRequest request, ref CallSettings settings);
        partial void Modify_DeleteBreakpointRequest(ref DeleteBreakpointRequest request, ref CallSettings settings);
        partial void Modify_ListBreakpointsRequest(ref ListBreakpointsRequest request, ref CallSettings settings);
        partial void Modify_ListDebuggeesRequest(ref ListDebuggeesRequest request, ref CallSettings settings);

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
        public override Task<SetBreakpointResponse> SetBreakpointAsync(
            SetBreakpointRequest request,
            CallSettings callSettings = null)
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
            CallSettings callSettings = null)
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
        public override Task<GetBreakpointResponse> GetBreakpointAsync(
            GetBreakpointRequest request,
            CallSettings callSettings = null)
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
            CallSettings callSettings = null)
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
        /// A Task containing the RPC response.
        /// </returns>
        public override Task DeleteBreakpointAsync(
            DeleteBreakpointRequest request,
            CallSettings callSettings = null)
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
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void DeleteBreakpoint(
            DeleteBreakpointRequest request,
            CallSettings callSettings = null)
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
        public override Task<ListBreakpointsResponse> ListBreakpointsAsync(
            ListBreakpointsRequest request,
            CallSettings callSettings = null)
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
            CallSettings callSettings = null)
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
        public override Task<ListDebuggeesResponse> ListDebuggeesAsync(
            ListDebuggeesRequest request,
            CallSettings callSettings = null)
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
            CallSettings callSettings = null)
        {
            Modify_ListDebuggeesRequest(ref request, ref callSettings);
            return _callListDebuggees.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
