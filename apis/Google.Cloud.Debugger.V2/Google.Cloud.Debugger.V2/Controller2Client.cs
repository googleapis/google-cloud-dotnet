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
    /// Settings for a <see cref="Controller2Client"/>.
    /// </summary>
    public sealed partial class Controller2Settings : gaxgrpc::ServiceSettingsBase
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
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RegisterDebuggeeSettings = existing.RegisterDebuggeeSettings;
            ListActiveBreakpointsSettings = existing.ListActiveBreakpointsSettings;
            UpdateActiveBreakpointSettings = existing.UpdateActiveBreakpointSettings;
            OnCopy(existing);
        }

        partial void OnCopy(Controller2Settings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="Controller2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="Controller2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

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
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
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
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(60000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Controller2Client.RegisterDebuggee</c> and <c>Controller2Client.RegisterDebuggeeAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Controller2Client.RegisterDebuggee</c> and
        /// <c>Controller2Client.RegisterDebuggeeAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings RegisterDebuggeeSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Controller2Client.ListActiveBreakpoints</c> and <c>Controller2Client.ListActiveBreakpointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Controller2Client.ListActiveBreakpoints</c> and
        /// <c>Controller2Client.ListActiveBreakpointsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListActiveBreakpointsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Controller2Client.UpdateActiveBreakpoint</c> and <c>Controller2Client.UpdateActiveBreakpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>Controller2Client.UpdateActiveBreakpoint</c> and
        /// <c>Controller2Client.UpdateActiveBreakpointAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateActiveBreakpointSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
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
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("clouddebugger.googleapis.com", 443);

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
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud_debugger",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="Controller2Client"/>, applying defaults for all unspecified settings,
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
        /// Controller2Client client = await Controller2Client.CreateAsync();
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
        ///     Controller2Client.DefaultEndpoint.Host, Controller2Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// Controller2Client client = Controller2Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="Controller2Settings"/>.</param>
        /// <returns>The task representing the created <see cref="Controller2Client"/>.</returns>
        public static async stt::Task<Controller2Client> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, Controller2Settings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="Controller2Client"/>, applying defaults for all unspecified settings,
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
        /// Controller2Client client = Controller2Client.Create();
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
        ///     Controller2Client.DefaultEndpoint.Host, Controller2Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// Controller2Client client = Controller2Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="Controller2Settings"/>.</param>
        /// <returns>The created <see cref="Controller2Client"/>.</returns>
        public static Controller2Client Create(gaxgrpc::ServiceEndpoint endpoint = null, Controller2Settings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="Controller2Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="Controller2Settings"/>.</param>
        /// <returns>The created <see cref="Controller2Client"/>.</returns>
        public static Controller2Client Create(grpccore::Channel channel, Controller2Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="Controller2Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="Controller2Settings"/>.</param>
        /// <returns>The created <see cref="Controller2Client"/>.</returns>
        public static Controller2Client Create(grpccore::CallInvoker callInvoker, Controller2Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Controller2.Controller2Client grpcClient = new Controller2.Controller2Client(callInvoker);
            return new Controller2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, Controller2Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, Controller2Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, Controller2Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, Controller2Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC Controller2 client.
        /// </summary>
        public virtual Controller2.Controller2Client GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
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
        public virtual stt::Task<RegisterDebuggeeResponse> RegisterDebuggeeAsync(
            Debuggee debuggee,
            gaxgrpc::CallSettings callSettings = null) => RegisterDebuggeeAsync(
                new RegisterDebuggeeRequest
                {
                    Debuggee = gax::GaxPreconditions.CheckNotNull(debuggee, nameof(debuggee)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<RegisterDebuggeeResponse> RegisterDebuggeeAsync(
            Debuggee debuggee,
            st::CancellationToken cancellationToken) => RegisterDebuggeeAsync(
                debuggee,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => RegisterDebuggee(
                new RegisterDebuggeeRequest
                {
                    Debuggee = gax::GaxPreconditions.CheckNotNull(debuggee, nameof(debuggee)),
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
        public virtual stt::Task<RegisterDebuggeeResponse> RegisterDebuggeeAsync(
            RegisterDebuggeeRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<RegisterDebuggeeResponse> RegisterDebuggeeAsync(
            RegisterDebuggeeRequest request,
            st::CancellationToken cancellationToken) => RegisterDebuggeeAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<ListActiveBreakpointsResponse> ListActiveBreakpointsAsync(
            string debuggeeId,
            gaxgrpc::CallSettings callSettings = null) => ListActiveBreakpointsAsync(
                new ListActiveBreakpointsRequest
                {
                    DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListActiveBreakpointsResponse> ListActiveBreakpointsAsync(
            string debuggeeId,
            st::CancellationToken cancellationToken) => ListActiveBreakpointsAsync(
                debuggeeId,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => ListActiveBreakpoints(
                new ListActiveBreakpointsRequest
                {
                    DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
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
        public virtual stt::Task<ListActiveBreakpointsResponse> ListActiveBreakpointsAsync(
            ListActiveBreakpointsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListActiveBreakpointsResponse> ListActiveBreakpointsAsync(
            ListActiveBreakpointsRequest request,
            st::CancellationToken cancellationToken) => ListActiveBreakpointsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<UpdateActiveBreakpointResponse> UpdateActiveBreakpointAsync(
            string debuggeeId,
            Breakpoint breakpoint,
            gaxgrpc::CallSettings callSettings = null) => UpdateActiveBreakpointAsync(
                new UpdateActiveBreakpointRequest
                {
                    DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    Breakpoint = gax::GaxPreconditions.CheckNotNull(breakpoint, nameof(breakpoint)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UpdateActiveBreakpointResponse> UpdateActiveBreakpointAsync(
            string debuggeeId,
            Breakpoint breakpoint,
            st::CancellationToken cancellationToken) => UpdateActiveBreakpointAsync(
                debuggeeId,
                breakpoint,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => UpdateActiveBreakpoint(
                new UpdateActiveBreakpointRequest
                {
                    DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                    Breakpoint = gax::GaxPreconditions.CheckNotNull(breakpoint, nameof(breakpoint)),
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
        public virtual stt::Task<UpdateActiveBreakpointResponse> UpdateActiveBreakpointAsync(
            UpdateActiveBreakpointRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UpdateActiveBreakpointResponse> UpdateActiveBreakpointAsync(
            UpdateActiveBreakpointRequest request,
            st::CancellationToken cancellationToken) => UpdateActiveBreakpointAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// Controller2 client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class Controller2ClientImpl : Controller2Client
    {
        private readonly gaxgrpc::ApiCall<RegisterDebuggeeRequest, RegisterDebuggeeResponse> _callRegisterDebuggee;
        private readonly gaxgrpc::ApiCall<ListActiveBreakpointsRequest, ListActiveBreakpointsResponse> _callListActiveBreakpoints;
        private readonly gaxgrpc::ApiCall<UpdateActiveBreakpointRequest, UpdateActiveBreakpointResponse> _callUpdateActiveBreakpoint;

        /// <summary>
        /// Constructs a client wrapper for the Controller2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="Controller2Settings"/> used within this client </param>
        public Controller2ClientImpl(Controller2.Controller2Client grpcClient, Controller2Settings settings)
        {
            GrpcClient = grpcClient;
            Controller2Settings effectiveSettings = settings ?? Controller2Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callRegisterDebuggee = clientHelper.BuildApiCall<RegisterDebuggeeRequest, RegisterDebuggeeResponse>(
                GrpcClient.RegisterDebuggeeAsync, GrpcClient.RegisterDebuggee, effectiveSettings.RegisterDebuggeeSettings);
            _callListActiveBreakpoints = clientHelper.BuildApiCall<ListActiveBreakpointsRequest, ListActiveBreakpointsResponse>(
                GrpcClient.ListActiveBreakpointsAsync, GrpcClient.ListActiveBreakpoints, effectiveSettings.ListActiveBreakpointsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"debuggee_id={request.DebuggeeId}"));
            _callUpdateActiveBreakpoint = clientHelper.BuildApiCall<UpdateActiveBreakpointRequest, UpdateActiveBreakpointResponse>(
                GrpcClient.UpdateActiveBreakpointAsync, GrpcClient.UpdateActiveBreakpoint, effectiveSettings.UpdateActiveBreakpointSettings);
            Modify_ApiCall(ref _callRegisterDebuggee);
            Modify_RegisterDebuggeeApiCall(ref _callRegisterDebuggee);
            Modify_ApiCall(ref _callListActiveBreakpoints);
            Modify_ListActiveBreakpointsApiCall(ref _callListActiveBreakpoints);
            Modify_ApiCall(ref _callUpdateActiveBreakpoint);
            Modify_UpdateActiveBreakpointApiCall(ref _callUpdateActiveBreakpoint);
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
        partial void Modify_RegisterDebuggeeApiCall(ref gaxgrpc::ApiCall<RegisterDebuggeeRequest, RegisterDebuggeeResponse> call);
        partial void Modify_ListActiveBreakpointsApiCall(ref gaxgrpc::ApiCall<ListActiveBreakpointsRequest, ListActiveBreakpointsResponse> call);
        partial void Modify_UpdateActiveBreakpointApiCall(ref gaxgrpc::ApiCall<UpdateActiveBreakpointRequest, UpdateActiveBreakpointResponse> call);
        partial void OnConstruction(Controller2.Controller2Client grpcClient, Controller2Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC Controller2 client.
        /// </summary>
        public override Controller2.Controller2Client GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<RegisterDebuggeeResponse> RegisterDebuggeeAsync(
            RegisterDebuggeeRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<ListActiveBreakpointsResponse> ListActiveBreakpointsAsync(
            ListActiveBreakpointsRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<UpdateActiveBreakpointResponse> UpdateActiveBreakpointAsync(
            UpdateActiveBreakpointRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateActiveBreakpointRequest(ref request, ref callSettings);
            return _callUpdateActiveBreakpoint.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
