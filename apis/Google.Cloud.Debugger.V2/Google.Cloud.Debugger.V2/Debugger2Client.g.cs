// Copyright 2022 Google LLC
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
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Debugger.V2
{
    /// <summary>Settings for <see cref="Debugger2Client"/> instances.</summary>
    public sealed partial class Debugger2Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="Debugger2Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="Debugger2Settings"/>.</returns>
        public static Debugger2Settings GetDefault() => new Debugger2Settings();

        /// <summary>Constructs a new <see cref="Debugger2Settings"/> object with default settings.</summary>
        public Debugger2Settings()
        {
        }

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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.SetBreakpoint</c> and <c>Debugger2Client.SetBreakpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetBreakpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.GetBreakpoint</c> and <c>Debugger2Client.GetBreakpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBreakpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.DeleteBreakpoint</c> and <c>Debugger2Client.DeleteBreakpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBreakpointSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.ListBreakpoints</c> and <c>Debugger2Client.ListBreakpointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBreakpointsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>Debugger2Client.ListDebuggees</c> and <c>Debugger2Client.ListDebuggeesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDebuggeesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="Debugger2Settings"/> object.</returns>
        public Debugger2Settings Clone() => new Debugger2Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="Debugger2Client"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class Debugger2ClientBuilder : gaxgrpc::ClientBuilderBase<Debugger2Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public Debugger2Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public Debugger2ClientBuilder() : base(Debugger2Client.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref Debugger2Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<Debugger2Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override Debugger2Client Build()
        {
            Debugger2Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<Debugger2Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<Debugger2Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private Debugger2Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return Debugger2Client.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<Debugger2Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return Debugger2Client.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => Debugger2Client.ChannelPool;
    }

    /// <summary>Debugger2 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Debugger service provides the API that allows users to collect run-time
    /// information from a running application, without stopping or slowing it down
    /// and without modifying its state.  An application may include one or
    /// more replicated processes performing the same work.
    /// 
    /// A debugged application is represented using the Debuggee concept. The
    /// Debugger service provides a way to query for available debuggees, but does
    /// not provide a way to create one.  A debuggee is created using the Controller
    /// service, usually by running a debugger agent with the application.
    /// 
    /// The Debugger service enables the client to set one or more Breakpoints on a
    /// Debuggee and collect the results of the set Breakpoints.
    /// </remarks>
    public abstract partial class Debugger2Client
    {
        /// <summary>
        /// The default endpoint for the Debugger2 service, which is a host of "clouddebugger.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "clouddebugger.googleapis.com:443";

        /// <summary>The default Debugger2 scopes.</summary>
        /// <remarks>
        /// The default Debugger2 scopes are:
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

        /// <summary>The service metadata associated with this client type.</summary>
        internal static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Debugger2.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="Debugger2Client"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="Debugger2ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="Debugger2Client"/>.</returns>
        public static stt::Task<Debugger2Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new Debugger2ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="Debugger2Client"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="Debugger2ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="Debugger2Client"/>.</returns>
        public static Debugger2Client Create() => new Debugger2ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="Debugger2Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="Debugger2Settings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="Debugger2Client"/>.</returns>
        internal static Debugger2Client Create(grpccore::CallInvoker callInvoker, Debugger2Settings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Debugger2.Debugger2Client grpcClient = new Debugger2.Debugger2Client(callInvoker);
            return new Debugger2ClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Debugger2 client</summary>
        public virtual Debugger2.Debugger2Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the breakpoint to the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SetBreakpointResponse SetBreakpoint(SetBreakpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the breakpoint to the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SetBreakpointResponse> SetBreakpointAsync(SetBreakpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the breakpoint to the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SetBreakpointResponse> SetBreakpointAsync(SetBreakpointRequest request, st::CancellationToken cancellationToken) =>
            SetBreakpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SetBreakpointResponse SetBreakpoint(string debuggeeId, Breakpoint breakpoint, string clientVersion, gaxgrpc::CallSettings callSettings = null) =>
            SetBreakpoint(new SetBreakpointRequest
            {
                DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                Breakpoint = gax::GaxPreconditions.CheckNotNull(breakpoint, nameof(breakpoint)),
                ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
            }, callSettings);

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SetBreakpointResponse> SetBreakpointAsync(string debuggeeId, Breakpoint breakpoint, string clientVersion, gaxgrpc::CallSettings callSettings = null) =>
            SetBreakpointAsync(new SetBreakpointRequest
            {
                DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                Breakpoint = gax::GaxPreconditions.CheckNotNull(breakpoint, nameof(breakpoint)),
                ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
            }, callSettings);

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
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SetBreakpointResponse> SetBreakpointAsync(string debuggeeId, Breakpoint breakpoint, string clientVersion, st::CancellationToken cancellationToken) =>
            SetBreakpointAsync(debuggeeId, breakpoint, clientVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets breakpoint information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetBreakpointResponse GetBreakpoint(GetBreakpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets breakpoint information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetBreakpointResponse> GetBreakpointAsync(GetBreakpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets breakpoint information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetBreakpointResponse> GetBreakpointAsync(GetBreakpointRequest request, st::CancellationToken cancellationToken) =>
            GetBreakpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetBreakpointResponse GetBreakpoint(string debuggeeId, string breakpointId, string clientVersion, gaxgrpc::CallSettings callSettings = null) =>
            GetBreakpoint(new GetBreakpointRequest
            {
                DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                BreakpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(breakpointId, nameof(breakpointId)),
                ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
            }, callSettings);

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetBreakpointResponse> GetBreakpointAsync(string debuggeeId, string breakpointId, string clientVersion, gaxgrpc::CallSettings callSettings = null) =>
            GetBreakpointAsync(new GetBreakpointRequest
            {
                DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                BreakpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(breakpointId, nameof(breakpointId)),
                ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
            }, callSettings);

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
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetBreakpointResponse> GetBreakpointAsync(string debuggeeId, string breakpointId, string clientVersion, st::CancellationToken cancellationToken) =>
            GetBreakpointAsync(debuggeeId, breakpointId, clientVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBreakpoint(DeleteBreakpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBreakpointAsync(DeleteBreakpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBreakpointAsync(DeleteBreakpointRequest request, st::CancellationToken cancellationToken) =>
            DeleteBreakpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBreakpoint(string debuggeeId, string breakpointId, string clientVersion, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBreakpoint(new DeleteBreakpointRequest
            {
                DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                BreakpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(breakpointId, nameof(breakpointId)),
                ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
            }, callSettings);

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBreakpointAsync(string debuggeeId, string breakpointId, string clientVersion, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBreakpointAsync(new DeleteBreakpointRequest
            {
                DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                BreakpointId = gax::GaxPreconditions.CheckNotNullOrEmpty(breakpointId, nameof(breakpointId)),
                ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
            }, callSettings);

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
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBreakpointAsync(string debuggeeId, string breakpointId, string clientVersion, st::CancellationToken cancellationToken) =>
            DeleteBreakpointAsync(debuggeeId, breakpointId, clientVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all breakpoints for the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListBreakpointsResponse ListBreakpoints(ListBreakpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all breakpoints for the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBreakpointsResponse> ListBreakpointsAsync(ListBreakpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all breakpoints for the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBreakpointsResponse> ListBreakpointsAsync(ListBreakpointsRequest request, st::CancellationToken cancellationToken) =>
            ListBreakpointsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListBreakpointsResponse ListBreakpoints(string debuggeeId, string clientVersion, gaxgrpc::CallSettings callSettings = null) =>
            ListBreakpoints(new ListBreakpointsRequest
            {
                DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
            }, callSettings);

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBreakpointsResponse> ListBreakpointsAsync(string debuggeeId, string clientVersion, gaxgrpc::CallSettings callSettings = null) =>
            ListBreakpointsAsync(new ListBreakpointsRequest
            {
                DebuggeeId = gax::GaxPreconditions.CheckNotNullOrEmpty(debuggeeId, nameof(debuggeeId)),
                ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
            }, callSettings);

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
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBreakpointsResponse> ListBreakpointsAsync(string debuggeeId, string clientVersion, st::CancellationToken cancellationToken) =>
            ListBreakpointsAsync(debuggeeId, clientVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the debuggees that the user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListDebuggeesResponse ListDebuggees(ListDebuggeesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the debuggees that the user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDebuggeesResponse> ListDebuggeesAsync(ListDebuggeesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the debuggees that the user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDebuggeesResponse> ListDebuggeesAsync(ListDebuggeesRequest request, st::CancellationToken cancellationToken) =>
            ListDebuggeesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListDebuggeesResponse ListDebuggees(string project, string clientVersion, gaxgrpc::CallSettings callSettings = null) =>
            ListDebuggees(new ListDebuggeesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
            }, callSettings);

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDebuggeesResponse> ListDebuggeesAsync(string project, string clientVersion, gaxgrpc::CallSettings callSettings = null) =>
            ListDebuggeesAsync(new ListDebuggeesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ClientVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(clientVersion, nameof(clientVersion)),
            }, callSettings);

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
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDebuggeesResponse> ListDebuggeesAsync(string project, string clientVersion, st::CancellationToken cancellationToken) =>
            ListDebuggeesAsync(project, clientVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Debugger2 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Debugger service provides the API that allows users to collect run-time
    /// information from a running application, without stopping or slowing it down
    /// and without modifying its state.  An application may include one or
    /// more replicated processes performing the same work.
    /// 
    /// A debugged application is represented using the Debuggee concept. The
    /// Debugger service provides a way to query for available debuggees, but does
    /// not provide a way to create one.  A debuggee is created using the Controller
    /// service, usually by running a debugger agent with the application.
    /// 
    /// The Debugger service enables the client to set one or more Breakpoints on a
    /// Debuggee and collect the results of the set Breakpoints.
    /// </remarks>
    public sealed partial class Debugger2ClientImpl : Debugger2Client
    {
        private readonly gaxgrpc::ApiCall<SetBreakpointRequest, SetBreakpointResponse> _callSetBreakpoint;

        private readonly gaxgrpc::ApiCall<GetBreakpointRequest, GetBreakpointResponse> _callGetBreakpoint;

        private readonly gaxgrpc::ApiCall<DeleteBreakpointRequest, wkt::Empty> _callDeleteBreakpoint;

        private readonly gaxgrpc::ApiCall<ListBreakpointsRequest, ListBreakpointsResponse> _callListBreakpoints;

        private readonly gaxgrpc::ApiCall<ListDebuggeesRequest, ListDebuggeesResponse> _callListDebuggees;

        /// <summary>
        /// Constructs a client wrapper for the Debugger2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="Debugger2Settings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public Debugger2ClientImpl(Debugger2.Debugger2Client grpcClient, Debugger2Settings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            Debugger2Settings effectiveSettings = settings ?? Debugger2Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callSetBreakpoint = clientHelper.BuildApiCall<SetBreakpointRequest, SetBreakpointResponse>("SetBreakpoint", grpcClient.SetBreakpointAsync, grpcClient.SetBreakpoint, effectiveSettings.SetBreakpointSettings).WithGoogleRequestParam("debuggee_id", request => request.DebuggeeId);
            Modify_ApiCall(ref _callSetBreakpoint);
            Modify_SetBreakpointApiCall(ref _callSetBreakpoint);
            _callGetBreakpoint = clientHelper.BuildApiCall<GetBreakpointRequest, GetBreakpointResponse>("GetBreakpoint", grpcClient.GetBreakpointAsync, grpcClient.GetBreakpoint, effectiveSettings.GetBreakpointSettings).WithGoogleRequestParam("debuggee_id", request => request.DebuggeeId).WithGoogleRequestParam("breakpoint_id", request => request.BreakpointId);
            Modify_ApiCall(ref _callGetBreakpoint);
            Modify_GetBreakpointApiCall(ref _callGetBreakpoint);
            _callDeleteBreakpoint = clientHelper.BuildApiCall<DeleteBreakpointRequest, wkt::Empty>("DeleteBreakpoint", grpcClient.DeleteBreakpointAsync, grpcClient.DeleteBreakpoint, effectiveSettings.DeleteBreakpointSettings).WithGoogleRequestParam("debuggee_id", request => request.DebuggeeId).WithGoogleRequestParam("breakpoint_id", request => request.BreakpointId);
            Modify_ApiCall(ref _callDeleteBreakpoint);
            Modify_DeleteBreakpointApiCall(ref _callDeleteBreakpoint);
            _callListBreakpoints = clientHelper.BuildApiCall<ListBreakpointsRequest, ListBreakpointsResponse>("ListBreakpoints", grpcClient.ListBreakpointsAsync, grpcClient.ListBreakpoints, effectiveSettings.ListBreakpointsSettings).WithGoogleRequestParam("debuggee_id", request => request.DebuggeeId);
            Modify_ApiCall(ref _callListBreakpoints);
            Modify_ListBreakpointsApiCall(ref _callListBreakpoints);
            _callListDebuggees = clientHelper.BuildApiCall<ListDebuggeesRequest, ListDebuggeesResponse>("ListDebuggees", grpcClient.ListDebuggeesAsync, grpcClient.ListDebuggees, effectiveSettings.ListDebuggeesSettings);
            Modify_ApiCall(ref _callListDebuggees);
            Modify_ListDebuggeesApiCall(ref _callListDebuggees);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SetBreakpointApiCall(ref gaxgrpc::ApiCall<SetBreakpointRequest, SetBreakpointResponse> call);

        partial void Modify_GetBreakpointApiCall(ref gaxgrpc::ApiCall<GetBreakpointRequest, GetBreakpointResponse> call);

        partial void Modify_DeleteBreakpointApiCall(ref gaxgrpc::ApiCall<DeleteBreakpointRequest, wkt::Empty> call);

        partial void Modify_ListBreakpointsApiCall(ref gaxgrpc::ApiCall<ListBreakpointsRequest, ListBreakpointsResponse> call);

        partial void Modify_ListDebuggeesApiCall(ref gaxgrpc::ApiCall<ListDebuggeesRequest, ListDebuggeesResponse> call);

        partial void OnConstruction(Debugger2.Debugger2Client grpcClient, Debugger2Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Debugger2 client</summary>
        public override Debugger2.Debugger2Client GrpcClient { get; }

        partial void Modify_SetBreakpointRequest(ref SetBreakpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBreakpointRequest(ref GetBreakpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBreakpointRequest(ref DeleteBreakpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBreakpointsRequest(ref ListBreakpointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDebuggeesRequest(ref ListDebuggeesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Sets the breakpoint to the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SetBreakpointResponse SetBreakpoint(SetBreakpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetBreakpointRequest(ref request, ref callSettings);
            return _callSetBreakpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the breakpoint to the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SetBreakpointResponse> SetBreakpointAsync(SetBreakpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetBreakpointRequest(ref request, ref callSettings);
            return _callSetBreakpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Gets breakpoint information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GetBreakpointResponse GetBreakpoint(GetBreakpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBreakpointRequest(ref request, ref callSettings);
            return _callGetBreakpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets breakpoint information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GetBreakpointResponse> GetBreakpointAsync(GetBreakpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBreakpointRequest(ref request, ref callSettings);
            return _callGetBreakpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteBreakpoint(DeleteBreakpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBreakpointRequest(ref request, ref callSettings);
            _callDeleteBreakpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the breakpoint from the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteBreakpointAsync(DeleteBreakpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBreakpointRequest(ref request, ref callSettings);
            return _callDeleteBreakpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all breakpoints for the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListBreakpointsResponse ListBreakpoints(ListBreakpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBreakpointsRequest(ref request, ref callSettings);
            return _callListBreakpoints.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all breakpoints for the debuggee.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListBreakpointsResponse> ListBreakpointsAsync(ListBreakpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBreakpointsRequest(ref request, ref callSettings);
            return _callListBreakpoints.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the debuggees that the user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListDebuggeesResponse ListDebuggees(ListDebuggeesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDebuggeesRequest(ref request, ref callSettings);
            return _callListDebuggees.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all the debuggees that the user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListDebuggeesResponse> ListDebuggeesAsync(ListDebuggeesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDebuggeesRequest(ref request, ref callSettings);
            return _callListDebuggees.Async(request, callSettings);
        }
    }
}
