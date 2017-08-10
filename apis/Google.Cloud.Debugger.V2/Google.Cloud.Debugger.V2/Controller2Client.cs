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
    /// Settings for a <see cref="Controller2Client"/>.
    /// </summary>
    public sealed partial class Controller2Settings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="Controller2Settings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="Controller2Settings"/>.
        /// </returns>
        public static Controller2Settings GetDefault() => new Controller2Settings();

        /// <summary>
        /// Constructs a new <see cref="Controller2Settings"/> object with default settings.
        /// </summary>
        public Controller2Settings() { }

        private Controller2Settings(Controller2Settings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RegisterDebuggeeSettings = existing.RegisterDebuggeeSettings;
            ListActiveBreakpointsSettings = existing.ListActiveBreakpointsSettings;
            UpdateActiveBreakpointSettings = existing.UpdateActiveBreakpointSettings;
            OnCopy(existing);
        }

        partial void OnCopy(Controller2Settings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="Controller2Client"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="Controller2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="Controller2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="Controller2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="Controller2Client"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="Controller2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="Controller2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="Controller2Client"/> RPC methods is defined as:
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
        /// <c>Controller2Client.RegisterDebuggee</c> and <c>Controller2Client.RegisterDebuggeeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Controller2Client.RegisterDebuggee</c> and
        /// <c>Controller2Client.RegisterDebuggeeAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings RegisterDebuggeeSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Controller2Client.ListActiveBreakpoints</c> and <c>Controller2Client.ListActiveBreakpointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Controller2Client.ListActiveBreakpoints</c> and
        /// <c>Controller2Client.ListActiveBreakpointsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListActiveBreakpointsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Controller2Client.UpdateActiveBreakpoint</c> and <c>Controller2Client.UpdateActiveBreakpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Controller2Client.UpdateActiveBreakpoint</c> and
        /// <c>Controller2Client.UpdateActiveBreakpointAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateActiveBreakpointSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="Controller2Settings"/> object.</returns>
        public Controller2Settings Clone() => new Controller2Settings(this);
    }

    /// <summary>
    /// Controller2 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class Controller2Client
    {
        /// <summary>
        /// The default endpoint for the Controller2 service, which is a host of "clouddebugger.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("clouddebugger.googleapis.com", 443);

        /// <summary>
        /// The default Controller2 scopes.
        /// </summary>
        /// <remarks>
        /// The default Controller2 scopes are:
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
        /// Asynchronously creates a <see cref="Controller2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="Controller2Settings"/>.</param>
        /// <returns>The task representing the created <see cref="Controller2Client"/>.</returns>
        public static async Task<Controller2Client> CreateAsync(ServiceEndpoint endpoint = null, Controller2Settings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="Controller2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="Controller2Settings"/>.</param>
        /// <returns>The created <see cref="Controller2Client"/>.</returns>
        public static Controller2Client Create(ServiceEndpoint endpoint = null, Controller2Settings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="Controller2Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="Controller2Settings"/>.</param>
        /// <returns>The created <see cref="Controller2Client"/>.</returns>
        public static Controller2Client Create(Channel channel, Controller2Settings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            Controller2.Controller2Client grpcClient = new Controller2.Controller2Client(channel);
            return new Controller2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, Controller2Settings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, Controller2Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, Controller2Settings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, Controller2Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Controller2 client.
        /// </summary>
        public virtual Controller2.Controller2Client GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Registers the debuggee with the controller service.
        ///
        /// All agents attached to the same application must call this method with
        /// exactly the same request content to get back the same stable `debuggee_id`.
        /// Agents should call this method again whenever `google.rpc.Code.NOT_FOUND`
        /// is returned from any controller method.
        ///
        /// This protocol allows the controller service to disable debuggees, recover
        /// from data loss, or change the `debuggee_id` format. Agents must handle
        /// `debuggee_id` value changing upon re-registration.
        /// </summary>
        /// <param name="debuggee">
        /// Debuggee information to register.
        /// The fields `project`, `uniquifier`, `description` and `agent_version`
        /// of the debuggee must be set.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<RegisterDebuggeeResponse> RegisterDebuggeeAsync(
            Debuggee debuggee,
            CallSettings callSettings = null) => RegisterDebuggeeAsync(
                new RegisterDebuggeeRequest
                {
                    Debuggee = GaxPreconditions.CheckNotNull(debuggee, nameof(debuggee)),
                },
                callSettings);

        /// <summary>
        /// Registers the debuggee with the controller service.
        ///
        /// All agents attached to the same application must call this method with
        /// exactly the same request content to get back the same stable `debuggee_id`.
        /// Agents should call this method again whenever `google.rpc.Code.NOT_FOUND`
        /// is returned from any controller method.
        ///
        /// This protocol allows the controller service to disable debuggees, recover
        /// from data loss, or change the `debuggee_id` format. Agents must handle
        /// `debuggee_id` value changing upon re-registration.
        /// </summary>
        /// <param name="debuggee">
        /// Debuggee information to register.
        /// The fields `project`, `uniquifier`, `description` and `agent_version`
        /// of the debuggee must be set.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<RegisterDebuggeeResponse> RegisterDebuggeeAsync(
            Debuggee debuggee,
            CancellationToken cancellationToken) => RegisterDebuggeeAsync(
                debuggee,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Registers the debuggee with the controller service.
        ///
        /// All agents attached to the same application must call this method with
        /// exactly the same request content to get back the same stable `debuggee_id`.
        /// Agents should call this method again whenever `google.rpc.Code.NOT_FOUND`
        /// is returned from any controller method.
        ///
        /// This protocol allows the controller service to disable debuggees, recover
        /// from data loss, or change the `debuggee_id` format. Agents must handle
        /// `debuggee_id` value changing upon re-registration.
        /// </summary>
        /// <param name="debuggee">
        /// Debuggee information to register.
        /// The fields `project`, `uniquifier`, `description` and `agent_version`
        /// of the debuggee must be set.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual RegisterDebuggeeResponse RegisterDebuggee(
            Debuggee debuggee,
            CallSettings callSettings = null) => RegisterDebuggee(
                new RegisterDebuggeeRequest
                {
                    Debuggee = GaxPreconditions.CheckNotNull(debuggee, nameof(debuggee)),
                },
                callSettings);

        /// <summary>
        /// Registers the debuggee with the controller service.
        ///
        /// All agents attached to the same application must call this method with
        /// exactly the same request content to get back the same stable `debuggee_id`.
        /// Agents should call this method again whenever `google.rpc.Code.NOT_FOUND`
        /// is returned from any controller method.
        ///
        /// This protocol allows the controller service to disable debuggees, recover
        /// from data loss, or change the `debuggee_id` format. Agents must handle
        /// `debuggee_id` value changing upon re-registration.
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
        public virtual Task<RegisterDebuggeeResponse> RegisterDebuggeeAsync(
            RegisterDebuggeeRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Registers the debuggee with the controller service.
        ///
        /// All agents attached to the same application must call this method with
        /// exactly the same request content to get back the same stable `debuggee_id`.
        /// Agents should call this method again whenever `google.rpc.Code.NOT_FOUND`
        /// is returned from any controller method.
        ///
        /// This protocol allows the controller service to disable debuggees, recover
        /// from data loss, or change the `debuggee_id` format. Agents must handle
        /// `debuggee_id` value changing upon re-registration.
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
        public virtual RegisterDebuggeeResponse RegisterDebuggee(
            RegisterDebuggeeRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the list of all active breakpoints for the debuggee.
        ///
        /// The breakpoint specification (`location`, `condition`, and `expressions`
        /// fields) is semantically immutable, although the field values may
        /// change. For example, an agent may update the location line number
        /// to reflect the actual line where the breakpoint was set, but this
        /// doesn't change the breakpoint semantics.
        ///
        /// This means that an agent does not need to check if a breakpoint has changed
        /// when it encounters the same breakpoint on a successive call.
        /// Moreover, an agent should remember the breakpoints that are completed
        /// until the controller removes them from the active list to avoid
        /// setting those breakpoints again.
        /// </summary>
        /// <param name="debuggeeId">
        /// Identifies the debuggee.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListActiveBreakpointsResponse> ListActiveBreakpointsAsync(
            string debuggeeId,
            CallSettings callSettings = null) => ListActiveBreakpointsAsync(
                new ListActiveBreakpointsRequest
                {
                    DebuggeeId = GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                },
                callSettings);

        /// <summary>
        /// Returns the list of all active breakpoints for the debuggee.
        ///
        /// The breakpoint specification (`location`, `condition`, and `expressions`
        /// fields) is semantically immutable, although the field values may
        /// change. For example, an agent may update the location line number
        /// to reflect the actual line where the breakpoint was set, but this
        /// doesn't change the breakpoint semantics.
        ///
        /// This means that an agent does not need to check if a breakpoint has changed
        /// when it encounters the same breakpoint on a successive call.
        /// Moreover, an agent should remember the breakpoints that are completed
        /// until the controller removes them from the active list to avoid
        /// setting those breakpoints again.
        /// </summary>
        /// <param name="debuggeeId">
        /// Identifies the debuggee.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ListActiveBreakpointsResponse> ListActiveBreakpointsAsync(
            string debuggeeId,
            CancellationToken cancellationToken) => ListActiveBreakpointsAsync(
                debuggeeId,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of all active breakpoints for the debuggee.
        ///
        /// The breakpoint specification (`location`, `condition`, and `expressions`
        /// fields) is semantically immutable, although the field values may
        /// change. For example, an agent may update the location line number
        /// to reflect the actual line where the breakpoint was set, but this
        /// doesn't change the breakpoint semantics.
        ///
        /// This means that an agent does not need to check if a breakpoint has changed
        /// when it encounters the same breakpoint on a successive call.
        /// Moreover, an agent should remember the breakpoints that are completed
        /// until the controller removes them from the active list to avoid
        /// setting those breakpoints again.
        /// </summary>
        /// <param name="debuggeeId">
        /// Identifies the debuggee.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListActiveBreakpointsResponse ListActiveBreakpoints(
            string debuggeeId,
            CallSettings callSettings = null) => ListActiveBreakpoints(
                new ListActiveBreakpointsRequest
                {
                    DebuggeeId = GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                },
                callSettings);

        /// <summary>
        /// Returns the list of all active breakpoints for the debuggee.
        ///
        /// The breakpoint specification (`location`, `condition`, and `expressions`
        /// fields) is semantically immutable, although the field values may
        /// change. For example, an agent may update the location line number
        /// to reflect the actual line where the breakpoint was set, but this
        /// doesn't change the breakpoint semantics.
        ///
        /// This means that an agent does not need to check if a breakpoint has changed
        /// when it encounters the same breakpoint on a successive call.
        /// Moreover, an agent should remember the breakpoints that are completed
        /// until the controller removes them from the active list to avoid
        /// setting those breakpoints again.
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
        public virtual Task<ListActiveBreakpointsResponse> ListActiveBreakpointsAsync(
            ListActiveBreakpointsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the list of all active breakpoints for the debuggee.
        ///
        /// The breakpoint specification (`location`, `condition`, and `expressions`
        /// fields) is semantically immutable, although the field values may
        /// change. For example, an agent may update the location line number
        /// to reflect the actual line where the breakpoint was set, but this
        /// doesn't change the breakpoint semantics.
        ///
        /// This means that an agent does not need to check if a breakpoint has changed
        /// when it encounters the same breakpoint on a successive call.
        /// Moreover, an agent should remember the breakpoints that are completed
        /// until the controller removes them from the active list to avoid
        /// setting those breakpoints again.
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
        public virtual ListActiveBreakpointsResponse ListActiveBreakpoints(
            ListActiveBreakpointsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the breakpoint state or mutable fields.
        /// The entire Breakpoint message must be sent back to the controller service.
        ///
        /// Updates to active breakpoint fields are only allowed if the new value
        /// does not change the breakpoint specification. Updates to the `location`,
        /// `condition` and `expressions` fields should not alter the breakpoint
        /// semantics. These may only make changes such as canonicalizing a value
        /// or snapping the location to the correct line of code.
        /// </summary>
        /// <param name="debuggeeId">
        /// Identifies the debuggee being debugged.
        /// </param>
        /// <param name="breakpoint">
        /// Updated breakpoint information.
        /// The field `id` must be set.
        /// The agent must echo all Breakpoint specification fields in the update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<UpdateActiveBreakpointResponse> UpdateActiveBreakpointAsync(
            string debuggeeId,
            Breakpoint breakpoint,
            CallSettings callSettings = null) => UpdateActiveBreakpointAsync(
                new UpdateActiveBreakpointRequest
                {
                    DebuggeeId = GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    Breakpoint = GaxPreconditions.CheckNotNull(breakpoint, nameof(breakpoint)),
                },
                callSettings);

        /// <summary>
        /// Updates the breakpoint state or mutable fields.
        /// The entire Breakpoint message must be sent back to the controller service.
        ///
        /// Updates to active breakpoint fields are only allowed if the new value
        /// does not change the breakpoint specification. Updates to the `location`,
        /// `condition` and `expressions` fields should not alter the breakpoint
        /// semantics. These may only make changes such as canonicalizing a value
        /// or snapping the location to the correct line of code.
        /// </summary>
        /// <param name="debuggeeId">
        /// Identifies the debuggee being debugged.
        /// </param>
        /// <param name="breakpoint">
        /// Updated breakpoint information.
        /// The field `id` must be set.
        /// The agent must echo all Breakpoint specification fields in the update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<UpdateActiveBreakpointResponse> UpdateActiveBreakpointAsync(
            string debuggeeId,
            Breakpoint breakpoint,
            CancellationToken cancellationToken) => UpdateActiveBreakpointAsync(
                debuggeeId,
                breakpoint,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the breakpoint state or mutable fields.
        /// The entire Breakpoint message must be sent back to the controller service.
        ///
        /// Updates to active breakpoint fields are only allowed if the new value
        /// does not change the breakpoint specification. Updates to the `location`,
        /// `condition` and `expressions` fields should not alter the breakpoint
        /// semantics. These may only make changes such as canonicalizing a value
        /// or snapping the location to the correct line of code.
        /// </summary>
        /// <param name="debuggeeId">
        /// Identifies the debuggee being debugged.
        /// </param>
        /// <param name="breakpoint">
        /// Updated breakpoint information.
        /// The field `id` must be set.
        /// The agent must echo all Breakpoint specification fields in the update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual UpdateActiveBreakpointResponse UpdateActiveBreakpoint(
            string debuggeeId,
            Breakpoint breakpoint,
            CallSettings callSettings = null) => UpdateActiveBreakpoint(
                new UpdateActiveBreakpointRequest
                {
                    DebuggeeId = GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    Breakpoint = GaxPreconditions.CheckNotNull(breakpoint, nameof(breakpoint)),
                },
                callSettings);

        /// <summary>
        /// Updates the breakpoint state or mutable fields.
        /// The entire Breakpoint message must be sent back to the controller service.
        ///
        /// Updates to active breakpoint fields are only allowed if the new value
        /// does not change the breakpoint specification. Updates to the `location`,
        /// `condition` and `expressions` fields should not alter the breakpoint
        /// semantics. These may only make changes such as canonicalizing a value
        /// or snapping the location to the correct line of code.
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
        public virtual Task<UpdateActiveBreakpointResponse> UpdateActiveBreakpointAsync(
            UpdateActiveBreakpointRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the breakpoint state or mutable fields.
        /// The entire Breakpoint message must be sent back to the controller service.
        ///
        /// Updates to active breakpoint fields are only allowed if the new value
        /// does not change the breakpoint specification. Updates to the `location`,
        /// `condition` and `expressions` fields should not alter the breakpoint
        /// semantics. These may only make changes such as canonicalizing a value
        /// or snapping the location to the correct line of code.
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
        public virtual UpdateActiveBreakpointResponse UpdateActiveBreakpoint(
            UpdateActiveBreakpointRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// Controller2 client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class Controller2ClientImpl : Controller2Client
    {
        private readonly ApiCall<RegisterDebuggeeRequest, RegisterDebuggeeResponse> _callRegisterDebuggee;
        private readonly ApiCall<ListActiveBreakpointsRequest, ListActiveBreakpointsResponse> _callListActiveBreakpoints;
        private readonly ApiCall<UpdateActiveBreakpointRequest, UpdateActiveBreakpointResponse> _callUpdateActiveBreakpoint;

        /// <summary>
        /// Constructs a client wrapper for the Controller2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="Controller2Settings"/> used within this client </param>
        public Controller2ClientImpl(Controller2.Controller2Client grpcClient, Controller2Settings settings)
        {
            GrpcClient = grpcClient;
            Controller2Settings effectiveSettings = settings ?? Controller2Settings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callRegisterDebuggee = clientHelper.BuildApiCall<RegisterDebuggeeRequest, RegisterDebuggeeResponse>(
                GrpcClient.RegisterDebuggeeAsync, GrpcClient.RegisterDebuggee, effectiveSettings.RegisterDebuggeeSettings);
            _callListActiveBreakpoints = clientHelper.BuildApiCall<ListActiveBreakpointsRequest, ListActiveBreakpointsResponse>(
                GrpcClient.ListActiveBreakpointsAsync, GrpcClient.ListActiveBreakpoints, effectiveSettings.ListActiveBreakpointsSettings);
            _callUpdateActiveBreakpoint = clientHelper.BuildApiCall<UpdateActiveBreakpointRequest, UpdateActiveBreakpointResponse>(
                GrpcClient.UpdateActiveBreakpointAsync, GrpcClient.UpdateActiveBreakpoint, effectiveSettings.UpdateActiveBreakpointSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(Controller2.Controller2Client grpcClient, Controller2Settings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Controller2 client.
        /// </summary>
        public override Controller2.Controller2Client GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_RegisterDebuggeeRequest(ref RegisterDebuggeeRequest request, ref CallSettings settings);
        partial void Modify_ListActiveBreakpointsRequest(ref ListActiveBreakpointsRequest request, ref CallSettings settings);
        partial void Modify_UpdateActiveBreakpointRequest(ref UpdateActiveBreakpointRequest request, ref CallSettings settings);

        /// <summary>
        /// Registers the debuggee with the controller service.
        ///
        /// All agents attached to the same application must call this method with
        /// exactly the same request content to get back the same stable `debuggee_id`.
        /// Agents should call this method again whenever `google.rpc.Code.NOT_FOUND`
        /// is returned from any controller method.
        ///
        /// This protocol allows the controller service to disable debuggees, recover
        /// from data loss, or change the `debuggee_id` format. Agents must handle
        /// `debuggee_id` value changing upon re-registration.
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
        public override Task<RegisterDebuggeeResponse> RegisterDebuggeeAsync(
            RegisterDebuggeeRequest request,
            CallSettings callSettings = null)
        {
            Modify_RegisterDebuggeeRequest(ref request, ref callSettings);
            return _callRegisterDebuggee.Async(request, callSettings);
        }

        /// <summary>
        /// Registers the debuggee with the controller service.
        ///
        /// All agents attached to the same application must call this method with
        /// exactly the same request content to get back the same stable `debuggee_id`.
        /// Agents should call this method again whenever `google.rpc.Code.NOT_FOUND`
        /// is returned from any controller method.
        ///
        /// This protocol allows the controller service to disable debuggees, recover
        /// from data loss, or change the `debuggee_id` format. Agents must handle
        /// `debuggee_id` value changing upon re-registration.
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
        public override RegisterDebuggeeResponse RegisterDebuggee(
            RegisterDebuggeeRequest request,
            CallSettings callSettings = null)
        {
            Modify_RegisterDebuggeeRequest(ref request, ref callSettings);
            return _callRegisterDebuggee.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all active breakpoints for the debuggee.
        ///
        /// The breakpoint specification (`location`, `condition`, and `expressions`
        /// fields) is semantically immutable, although the field values may
        /// change. For example, an agent may update the location line number
        /// to reflect the actual line where the breakpoint was set, but this
        /// doesn't change the breakpoint semantics.
        ///
        /// This means that an agent does not need to check if a breakpoint has changed
        /// when it encounters the same breakpoint on a successive call.
        /// Moreover, an agent should remember the breakpoints that are completed
        /// until the controller removes them from the active list to avoid
        /// setting those breakpoints again.
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
        public override Task<ListActiveBreakpointsResponse> ListActiveBreakpointsAsync(
            ListActiveBreakpointsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListActiveBreakpointsRequest(ref request, ref callSettings);
            return _callListActiveBreakpoints.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all active breakpoints for the debuggee.
        ///
        /// The breakpoint specification (`location`, `condition`, and `expressions`
        /// fields) is semantically immutable, although the field values may
        /// change. For example, an agent may update the location line number
        /// to reflect the actual line where the breakpoint was set, but this
        /// doesn't change the breakpoint semantics.
        ///
        /// This means that an agent does not need to check if a breakpoint has changed
        /// when it encounters the same breakpoint on a successive call.
        /// Moreover, an agent should remember the breakpoints that are completed
        /// until the controller removes them from the active list to avoid
        /// setting those breakpoints again.
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
        public override ListActiveBreakpointsResponse ListActiveBreakpoints(
            ListActiveBreakpointsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListActiveBreakpointsRequest(ref request, ref callSettings);
            return _callListActiveBreakpoints.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the breakpoint state or mutable fields.
        /// The entire Breakpoint message must be sent back to the controller service.
        ///
        /// Updates to active breakpoint fields are only allowed if the new value
        /// does not change the breakpoint specification. Updates to the `location`,
        /// `condition` and `expressions` fields should not alter the breakpoint
        /// semantics. These may only make changes such as canonicalizing a value
        /// or snapping the location to the correct line of code.
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
        public override Task<UpdateActiveBreakpointResponse> UpdateActiveBreakpointAsync(
            UpdateActiveBreakpointRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateActiveBreakpointRequest(ref request, ref callSettings);
            return _callUpdateActiveBreakpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the breakpoint state or mutable fields.
        /// The entire Breakpoint message must be sent back to the controller service.
        ///
        /// Updates to active breakpoint fields are only allowed if the new value
        /// does not change the breakpoint specification. Updates to the `location`,
        /// `condition` and `expressions` fields should not alter the breakpoint
        /// semantics. These may only make changes such as canonicalizing a value
        /// or snapping the location to the correct line of code.
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
        public override UpdateActiveBreakpointResponse UpdateActiveBreakpoint(
            UpdateActiveBreakpointRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateActiveBreakpointRequest(ref request, ref callSettings);
            return _callUpdateActiveBreakpoint.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
