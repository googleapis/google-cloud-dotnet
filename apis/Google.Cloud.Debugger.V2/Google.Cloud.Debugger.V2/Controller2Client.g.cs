// Copyright 2021 Google LLC
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
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Debugger.V2
{
    /// <summary>Settings for <see cref="Controller2Client"/> instances.</summary>
    public sealed partial class Controller2Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="Controller2Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="Controller2Settings"/>.</returns>
        public static Controller2Settings GetDefault() => new Controller2Settings();

        /// <summary>Constructs a new <see cref="Controller2Settings"/> object with default settings.</summary>
        public Controller2Settings()
        {
        }

        private Controller2Settings(Controller2Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RegisterDebuggeeSettings = existing.RegisterDebuggeeSettings;
            ListActiveBreakpointsSettings = existing.ListActiveBreakpointsSettings;
            UpdateActiveBreakpointSettings = existing.UpdateActiveBreakpointSettings;
            OnCopy(existing);
        }

        partial void OnCopy(Controller2Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Controller2Client.RegisterDebuggee</c> and <c>Controller2Client.RegisterDebuggeeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RegisterDebuggeeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Controller2Client.ListActiveBreakpoints</c> and <c>Controller2Client.ListActiveBreakpointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListActiveBreakpointsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Controller2Client.UpdateActiveBreakpoint</c> and <c>Controller2Client.UpdateActiveBreakpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateActiveBreakpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="Controller2Settings"/> object.</returns>
        public Controller2Settings Clone() => new Controller2Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="Controller2Client"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class Controller2ClientBuilder : gaxgrpc::ClientBuilderBase<Controller2Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public Controller2Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public Controller2ClientBuilder()
        {
            UseJwtAccessWithScopes = Controller2Client.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref Controller2Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<Controller2Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override Controller2Client Build()
        {
            Controller2Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<Controller2Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<Controller2Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private Controller2Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return Controller2Client.Create(callInvoker, Settings);
        }

        private async stt::Task<Controller2Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return Controller2Client.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => Controller2Client.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => Controller2Client.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => Controller2Client.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Controller2 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Controller service provides the API for orchestrating a collection of
    /// debugger agents to perform debugging tasks. These agents are each attached
    /// to a process of an application which may include one or more replicas.
    /// 
    /// The debugger agents register with the Controller to identify the application
    /// being debugged, the Debuggee. All agents that register with the same data,
    /// represent the same Debuggee, and are assigned the same `debuggee_id`.
    /// 
    /// The debugger agents call the Controller to retrieve  the list of active
    /// Breakpoints. Agents with the same `debuggee_id` get the same breakpoints
    /// list. An agent that can fulfill the breakpoint request updates the
    /// Controller with the breakpoint result. The controller selects the first
    /// result received and discards the rest of the results.
    /// Agents that poll again for active breakpoints will no longer have
    /// the completed breakpoint in the list and should remove that breakpoint from
    /// their attached process.
    /// 
    /// The Controller service does not provide a way to retrieve the results of
    /// a completed breakpoint. This functionality is available using the Debugger
    /// service.
    /// </remarks>
    public abstract partial class Controller2Client
    {
        /// <summary>
        /// The default endpoint for the Controller2 service, which is a host of "clouddebugger.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "clouddebugger.googleapis.com:443";

        /// <summary>The default Controller2 scopes.</summary>
        /// <remarks>
        /// The default Controller2 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud_debugger</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud_debugger",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="Controller2Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="Controller2ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="Controller2Client"/>.</returns>
        public static stt::Task<Controller2Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new Controller2ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="Controller2Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="Controller2ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="Controller2Client"/>.</returns>
        public static Controller2Client Create() => new Controller2ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="Controller2Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="Controller2Settings"/>.</param>
        /// <returns>The created <see cref="Controller2Client"/>.</returns>
        internal static Controller2Client Create(grpccore::CallInvoker callInvoker, Controller2Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Controller2.Controller2Client grpcClient = new Controller2.Controller2Client(callInvoker);
            return new Controller2ClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Controller2 client</summary>
        public virtual Controller2.Controller2Client GrpcClient => throw new sys::NotImplementedException();

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegisterDebuggeeResponse RegisterDebuggee(RegisterDebuggeeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegisterDebuggeeResponse> RegisterDebuggeeAsync(RegisterDebuggeeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegisterDebuggeeResponse> RegisterDebuggeeAsync(RegisterDebuggeeRequest request, st::CancellationToken cancellationToken) =>
            RegisterDebuggeeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. Debuggee information to register.
        /// The fields `project`, `uniquifier`, `description` and `agent_version`
        /// of the debuggee must be set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegisterDebuggeeResponse RegisterDebuggee(Debuggee debuggee, gaxgrpc::CallSettings callSettings = null) =>
            RegisterDebuggee(new RegisterDebuggeeRequest
            {
                Debuggee = gax::GaxPreconditions.CheckNotNull(debuggee, nameof(debuggee)),
            }, callSettings);

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
        /// Required. Debuggee information to register.
        /// The fields `project`, `uniquifier`, `description` and `agent_version`
        /// of the debuggee must be set.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegisterDebuggeeResponse> RegisterDebuggeeAsync(Debuggee debuggee, gaxgrpc::CallSettings callSettings = null) =>
            RegisterDebuggeeAsync(new RegisterDebuggeeRequest
            {
                Debuggee = gax::GaxPreconditions.CheckNotNull(debuggee, nameof(debuggee)),
            }, callSettings);

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
        /// Required. Debuggee information to register.
        /// The fields `project`, `uniquifier`, `description` and `agent_version`
        /// of the debuggee must be set.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegisterDebuggeeResponse> RegisterDebuggeeAsync(Debuggee debuggee, st::CancellationToken cancellationToken) =>
            RegisterDebuggeeAsync(debuggee, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListActiveBreakpointsResponse ListActiveBreakpoints(ListActiveBreakpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListActiveBreakpointsResponse> ListActiveBreakpointsAsync(ListActiveBreakpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListActiveBreakpointsResponse> ListActiveBreakpointsAsync(ListActiveBreakpointsRequest request, st::CancellationToken cancellationToken) =>
            ListActiveBreakpointsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. Identifies the debuggee.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListActiveBreakpointsResponse ListActiveBreakpoints(string debuggeeId, gaxgrpc::CallSettings callSettings = null) =>
            ListActiveBreakpoints(new ListActiveBreakpointsRequest
            {
                DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
            }, callSettings);

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
        /// Required. Identifies the debuggee.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListActiveBreakpointsResponse> ListActiveBreakpointsAsync(string debuggeeId, gaxgrpc::CallSettings callSettings = null) =>
            ListActiveBreakpointsAsync(new ListActiveBreakpointsRequest
            {
                DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
            }, callSettings);

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
        /// Required. Identifies the debuggee.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListActiveBreakpointsResponse> ListActiveBreakpointsAsync(string debuggeeId, st::CancellationToken cancellationToken) =>
            ListActiveBreakpointsAsync(debuggeeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpdateActiveBreakpointResponse UpdateActiveBreakpoint(UpdateActiveBreakpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateActiveBreakpointResponse> UpdateActiveBreakpointAsync(UpdateActiveBreakpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateActiveBreakpointResponse> UpdateActiveBreakpointAsync(UpdateActiveBreakpointRequest request, st::CancellationToken cancellationToken) =>
            UpdateActiveBreakpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. Identifies the debuggee being debugged.
        /// </param>
        /// <param name="breakpoint">
        /// Required. Updated breakpoint information.
        /// The field `id` must be set.
        /// The agent must echo all Breakpoint specification fields in the update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpdateActiveBreakpointResponse UpdateActiveBreakpoint(string debuggeeId, Breakpoint breakpoint, gaxgrpc::CallSettings callSettings = null) =>
            UpdateActiveBreakpoint(new UpdateActiveBreakpointRequest
            {
                DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                Breakpoint = gax::GaxPreconditions.CheckNotNull(breakpoint, nameof(breakpoint)),
            }, callSettings);

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
        /// Required. Identifies the debuggee being debugged.
        /// </param>
        /// <param name="breakpoint">
        /// Required. Updated breakpoint information.
        /// The field `id` must be set.
        /// The agent must echo all Breakpoint specification fields in the update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateActiveBreakpointResponse> UpdateActiveBreakpointAsync(string debuggeeId, Breakpoint breakpoint, gaxgrpc::CallSettings callSettings = null) =>
            UpdateActiveBreakpointAsync(new UpdateActiveBreakpointRequest
            {
                DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                Breakpoint = gax::GaxPreconditions.CheckNotNull(breakpoint, nameof(breakpoint)),
            }, callSettings);

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
        /// Required. Identifies the debuggee being debugged.
        /// </param>
        /// <param name="breakpoint">
        /// Required. Updated breakpoint information.
        /// The field `id` must be set.
        /// The agent must echo all Breakpoint specification fields in the update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateActiveBreakpointResponse> UpdateActiveBreakpointAsync(string debuggeeId, Breakpoint breakpoint, st::CancellationToken cancellationToken) =>
            UpdateActiveBreakpointAsync(debuggeeId, breakpoint, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Controller2 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Controller service provides the API for orchestrating a collection of
    /// debugger agents to perform debugging tasks. These agents are each attached
    /// to a process of an application which may include one or more replicas.
    /// 
    /// The debugger agents register with the Controller to identify the application
    /// being debugged, the Debuggee. All agents that register with the same data,
    /// represent the same Debuggee, and are assigned the same `debuggee_id`.
    /// 
    /// The debugger agents call the Controller to retrieve  the list of active
    /// Breakpoints. Agents with the same `debuggee_id` get the same breakpoints
    /// list. An agent that can fulfill the breakpoint request updates the
    /// Controller with the breakpoint result. The controller selects the first
    /// result received and discards the rest of the results.
    /// Agents that poll again for active breakpoints will no longer have
    /// the completed breakpoint in the list and should remove that breakpoint from
    /// their attached process.
    /// 
    /// The Controller service does not provide a way to retrieve the results of
    /// a completed breakpoint. This functionality is available using the Debugger
    /// service.
    /// </remarks>
    public sealed partial class Controller2ClientImpl : Controller2Client
    {
        private readonly gaxgrpc::ApiCall<RegisterDebuggeeRequest, RegisterDebuggeeResponse> _callRegisterDebuggee;

        private readonly gaxgrpc::ApiCall<ListActiveBreakpointsRequest, ListActiveBreakpointsResponse> _callListActiveBreakpoints;

        private readonly gaxgrpc::ApiCall<UpdateActiveBreakpointRequest, UpdateActiveBreakpointResponse> _callUpdateActiveBreakpoint;

        /// <summary>
        /// Constructs a client wrapper for the Controller2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="Controller2Settings"/> used within this client.</param>
        public Controller2ClientImpl(Controller2.Controller2Client grpcClient, Controller2Settings settings)
        {
            GrpcClient = grpcClient;
            Controller2Settings effectiveSettings = settings ?? Controller2Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callRegisterDebuggee = clientHelper.BuildApiCall<RegisterDebuggeeRequest, RegisterDebuggeeResponse>(grpcClient.RegisterDebuggeeAsync, grpcClient.RegisterDebuggee, effectiveSettings.RegisterDebuggeeSettings);
            Modify_ApiCall(ref _callRegisterDebuggee);
            Modify_RegisterDebuggeeApiCall(ref _callRegisterDebuggee);
            _callListActiveBreakpoints = clientHelper.BuildApiCall<ListActiveBreakpointsRequest, ListActiveBreakpointsResponse>(grpcClient.ListActiveBreakpointsAsync, grpcClient.ListActiveBreakpoints, effectiveSettings.ListActiveBreakpointsSettings).WithGoogleRequestParam("debuggee_id", request => request.DebuggeeId);
            Modify_ApiCall(ref _callListActiveBreakpoints);
            Modify_ListActiveBreakpointsApiCall(ref _callListActiveBreakpoints);
            _callUpdateActiveBreakpoint = clientHelper.BuildApiCall<UpdateActiveBreakpointRequest, UpdateActiveBreakpointResponse>(grpcClient.UpdateActiveBreakpointAsync, grpcClient.UpdateActiveBreakpoint, effectiveSettings.UpdateActiveBreakpointSettings).WithGoogleRequestParam("debuggee_id", request => request.DebuggeeId).WithGoogleRequestParam("breakpoint.id", request => request.Breakpoint?.Id);
            Modify_ApiCall(ref _callUpdateActiveBreakpoint);
            Modify_UpdateActiveBreakpointApiCall(ref _callUpdateActiveBreakpoint);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RegisterDebuggeeApiCall(ref gaxgrpc::ApiCall<RegisterDebuggeeRequest, RegisterDebuggeeResponse> call);

        partial void Modify_ListActiveBreakpointsApiCall(ref gaxgrpc::ApiCall<ListActiveBreakpointsRequest, ListActiveBreakpointsResponse> call);

        partial void Modify_UpdateActiveBreakpointApiCall(ref gaxgrpc::ApiCall<UpdateActiveBreakpointRequest, UpdateActiveBreakpointResponse> call);

        partial void OnConstruction(Controller2.Controller2Client grpcClient, Controller2Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Controller2 client</summary>
        public override Controller2.Controller2Client GrpcClient { get; }

        partial void Modify_RegisterDebuggeeRequest(ref RegisterDebuggeeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListActiveBreakpointsRequest(ref ListActiveBreakpointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateActiveBreakpointRequest(ref UpdateActiveBreakpointRequest request, ref gaxgrpc::CallSettings settings);

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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RegisterDebuggeeResponse RegisterDebuggee(RegisterDebuggeeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterDebuggeeRequest(ref request, ref callSettings);
            return _callRegisterDebuggee.Sync(request, callSettings);
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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RegisterDebuggeeResponse> RegisterDebuggeeAsync(RegisterDebuggeeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterDebuggeeRequest(ref request, ref callSettings);
            return _callRegisterDebuggee.Async(request, callSettings);
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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListActiveBreakpointsResponse ListActiveBreakpoints(ListActiveBreakpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListActiveBreakpointsRequest(ref request, ref callSettings);
            return _callListActiveBreakpoints.Sync(request, callSettings);
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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListActiveBreakpointsResponse> ListActiveBreakpointsAsync(ListActiveBreakpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListActiveBreakpointsRequest(ref request, ref callSettings);
            return _callListActiveBreakpoints.Async(request, callSettings);
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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UpdateActiveBreakpointResponse UpdateActiveBreakpoint(UpdateActiveBreakpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateActiveBreakpointRequest(ref request, ref callSettings);
            return _callUpdateActiveBreakpoint.Sync(request, callSettings);
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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UpdateActiveBreakpointResponse> UpdateActiveBreakpointAsync(UpdateActiveBreakpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateActiveBreakpointRequest(ref request, ref callSettings);
            return _callUpdateActiveBreakpoint.Async(request, callSettings);
        }
    }
}
