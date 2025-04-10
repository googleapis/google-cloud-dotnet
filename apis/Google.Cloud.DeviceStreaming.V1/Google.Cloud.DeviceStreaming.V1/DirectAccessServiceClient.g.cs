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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.DeviceStreaming.V1
{
    /// <summary>Settings for <see cref="DirectAccessServiceClient"/> instances.</summary>
    public sealed partial class DirectAccessServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DirectAccessServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DirectAccessServiceSettings"/>.</returns>
        public static DirectAccessServiceSettings GetDefault() => new DirectAccessServiceSettings();

        /// <summary>Constructs a new <see cref="DirectAccessServiceSettings"/> object with default settings.</summary>
        public DirectAccessServiceSettings()
        {
        }

        private DirectAccessServiceSettings(DirectAccessServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDeviceSessionSettings = existing.CreateDeviceSessionSettings;
            ListDeviceSessionsSettings = existing.ListDeviceSessionsSettings;
            GetDeviceSessionSettings = existing.GetDeviceSessionSettings;
            CancelDeviceSessionSettings = existing.CancelDeviceSessionSettings;
            UpdateDeviceSessionSettings = existing.UpdateDeviceSessionSettings;
            AdbConnectSettings = existing.AdbConnectSettings;
            AdbConnectStreamingSettings = existing.AdbConnectStreamingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DirectAccessServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DirectAccessServiceClient.CreateDeviceSession</c> and
        /// <c>DirectAccessServiceClient.CreateDeviceSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDeviceSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DirectAccessServiceClient.ListDeviceSessions</c> and <c>DirectAccessServiceClient.ListDeviceSessionsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeviceSessionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DirectAccessServiceClient.GetDeviceSession</c> and <c>DirectAccessServiceClient.GetDeviceSessionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDeviceSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DirectAccessServiceClient.CancelDeviceSession</c> and
        /// <c>DirectAccessServiceClient.CancelDeviceSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelDeviceSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DirectAccessServiceClient.UpdateDeviceSession</c> and
        /// <c>DirectAccessServiceClient.UpdateDeviceSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDeviceSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DirectAccessServiceClient.AdbConnect</c> and <c>DirectAccessServiceClient.AdbConnectAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 1800 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AdbConnectSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(1800000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>DirectAccessServiceClient.AdbConnect</c>
        ///  and <c>DirectAccessServiceClient.AdbConnectAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings AdbConnectStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DirectAccessServiceSettings"/> object.</returns>
        public DirectAccessServiceSettings Clone() => new DirectAccessServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DirectAccessServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DirectAccessServiceClientBuilder : gaxgrpc::ClientBuilderBase<DirectAccessServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DirectAccessServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DirectAccessServiceClientBuilder() : base(DirectAccessServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DirectAccessServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DirectAccessServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DirectAccessServiceClient Build()
        {
            DirectAccessServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DirectAccessServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DirectAccessServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DirectAccessServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DirectAccessServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DirectAccessServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DirectAccessServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DirectAccessServiceClient.ChannelPool;
    }

    /// <summary>DirectAccessService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for allocating Android devices and interacting with the
    /// live-allocated devices.
    /// 
    /// Each Session will wait for available capacity, at a higher
    /// priority over Test Execution. When allocated, the session will be exposed
    /// through a stream for integration.
    /// 
    /// DirectAccessService is currently available as a preview to select developers.
    /// You can register today on behalf of you and your team at
    /// https://developer.android.com/studio/preview/android-device-streaming
    /// </remarks>
    public abstract partial class DirectAccessServiceClient
    {
        /// <summary>
        /// The default endpoint for the DirectAccessService service, which is a host of
        /// "devicestreaming.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "devicestreaming.googleapis.com:443";

        /// <summary>The default DirectAccessService scopes.</summary>
        /// <remarks>
        /// The default DirectAccessService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DirectAccessService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DirectAccessServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DirectAccessServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DirectAccessServiceClient"/>.</returns>
        public static stt::Task<DirectAccessServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DirectAccessServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DirectAccessServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DirectAccessServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DirectAccessServiceClient"/>.</returns>
        public static DirectAccessServiceClient Create() => new DirectAccessServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DirectAccessServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DirectAccessServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DirectAccessServiceClient"/>.</returns>
        internal static DirectAccessServiceClient Create(grpccore::CallInvoker callInvoker, DirectAccessServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DirectAccessService.DirectAccessServiceClient grpcClient = new DirectAccessService.DirectAccessServiceClient(callInvoker);
            return new DirectAccessServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DirectAccessService client</summary>
        public virtual DirectAccessService.DirectAccessServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DeviceSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceSession CreateDeviceSession(CreateDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DeviceSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> CreateDeviceSessionAsync(CreateDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DeviceSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> CreateDeviceSessionAsync(CreateDeviceSessionRequest request, st::CancellationToken cancellationToken) =>
            CreateDeviceSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DeviceSession.
        /// </summary>
        /// <param name="parent">
        /// Required. The Compute Engine project under which this device will be
        /// allocated. "projects/{project_id}"
        /// </param>
        /// <param name="deviceSession">
        /// Required. A DeviceSession to create.
        /// </param>
        /// <param name="deviceSessionId">
        /// Optional. The ID to use for the DeviceSession, which will become the final
        /// component of the DeviceSession's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceSession CreateDeviceSession(string parent, DeviceSession deviceSession, string deviceSessionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeviceSession(new CreateDeviceSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeviceSession = gax::GaxPreconditions.CheckNotNull(deviceSession, nameof(deviceSession)),
                DeviceSessionId = deviceSessionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a DeviceSession.
        /// </summary>
        /// <param name="parent">
        /// Required. The Compute Engine project under which this device will be
        /// allocated. "projects/{project_id}"
        /// </param>
        /// <param name="deviceSession">
        /// Required. A DeviceSession to create.
        /// </param>
        /// <param name="deviceSessionId">
        /// Optional. The ID to use for the DeviceSession, which will become the final
        /// component of the DeviceSession's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> CreateDeviceSessionAsync(string parent, DeviceSession deviceSession, string deviceSessionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeviceSessionAsync(new CreateDeviceSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeviceSession = gax::GaxPreconditions.CheckNotNull(deviceSession, nameof(deviceSession)),
                DeviceSessionId = deviceSessionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a DeviceSession.
        /// </summary>
        /// <param name="parent">
        /// Required. The Compute Engine project under which this device will be
        /// allocated. "projects/{project_id}"
        /// </param>
        /// <param name="deviceSession">
        /// Required. A DeviceSession to create.
        /// </param>
        /// <param name="deviceSessionId">
        /// Optional. The ID to use for the DeviceSession, which will become the final
        /// component of the DeviceSession's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> CreateDeviceSessionAsync(string parent, DeviceSession deviceSession, string deviceSessionId, st::CancellationToken cancellationToken) =>
            CreateDeviceSessionAsync(parent, deviceSession, deviceSessionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DeviceSession.
        /// </summary>
        /// <param name="parent">
        /// Required. The Compute Engine project under which this device will be
        /// allocated. "projects/{project_id}"
        /// </param>
        /// <param name="deviceSession">
        /// Required. A DeviceSession to create.
        /// </param>
        /// <param name="deviceSessionId">
        /// Optional. The ID to use for the DeviceSession, which will become the final
        /// component of the DeviceSession's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceSession CreateDeviceSession(gagr::ProjectName parent, DeviceSession deviceSession, string deviceSessionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeviceSession(new CreateDeviceSessionRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeviceSession = gax::GaxPreconditions.CheckNotNull(deviceSession, nameof(deviceSession)),
                DeviceSessionId = deviceSessionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a DeviceSession.
        /// </summary>
        /// <param name="parent">
        /// Required. The Compute Engine project under which this device will be
        /// allocated. "projects/{project_id}"
        /// </param>
        /// <param name="deviceSession">
        /// Required. A DeviceSession to create.
        /// </param>
        /// <param name="deviceSessionId">
        /// Optional. The ID to use for the DeviceSession, which will become the final
        /// component of the DeviceSession's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> CreateDeviceSessionAsync(gagr::ProjectName parent, DeviceSession deviceSession, string deviceSessionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeviceSessionAsync(new CreateDeviceSessionRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeviceSession = gax::GaxPreconditions.CheckNotNull(deviceSession, nameof(deviceSession)),
                DeviceSessionId = deviceSessionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a DeviceSession.
        /// </summary>
        /// <param name="parent">
        /// Required. The Compute Engine project under which this device will be
        /// allocated. "projects/{project_id}"
        /// </param>
        /// <param name="deviceSession">
        /// Required. A DeviceSession to create.
        /// </param>
        /// <param name="deviceSessionId">
        /// Optional. The ID to use for the DeviceSession, which will become the final
        /// component of the DeviceSession's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> CreateDeviceSessionAsync(gagr::ProjectName parent, DeviceSession deviceSession, string deviceSessionId, st::CancellationToken cancellationToken) =>
            CreateDeviceSessionAsync(parent, deviceSession, deviceSessionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DeviceSessions owned by the project user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeviceSession"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceSessionsResponse, DeviceSession> ListDeviceSessions(ListDeviceSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DeviceSessions owned by the project user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceSession"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceSessionsResponse, DeviceSession> ListDeviceSessionsAsync(ListDeviceSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DeviceSessions owned by the project user.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent to request, e.g. "projects/{project_id}"
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
        /// <returns>A pageable sequence of <see cref="DeviceSession"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceSessionsResponse, DeviceSession> ListDeviceSessions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceSessionsRequest request = new ListDeviceSessionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeviceSessions(request, callSettings);
        }

        /// <summary>
        /// Lists DeviceSessions owned by the project user.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent to request, e.g. "projects/{project_id}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceSession"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceSessionsResponse, DeviceSession> ListDeviceSessionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceSessionsRequest request = new ListDeviceSessionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeviceSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DeviceSessions owned by the project user.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent to request, e.g. "projects/{project_id}"
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
        /// <returns>A pageable sequence of <see cref="DeviceSession"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeviceSessionsResponse, DeviceSession> ListDeviceSessions(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceSessionsRequest request = new ListDeviceSessionsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeviceSessions(request, callSettings);
        }

        /// <summary>
        /// Lists DeviceSessions owned by the project user.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent to request, e.g. "projects/{project_id}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceSession"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeviceSessionsResponse, DeviceSession> ListDeviceSessionsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeviceSessionsRequest request = new ListDeviceSessionsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeviceSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a DeviceSession, which documents the allocation status and
        /// whether the device is allocated. Clients making requests from this API
        /// must poll GetDeviceSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceSession GetDeviceSession(GetDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a DeviceSession, which documents the allocation status and
        /// whether the device is allocated. Clients making requests from this API
        /// must poll GetDeviceSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> GetDeviceSessionAsync(GetDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a DeviceSession, which documents the allocation status and
        /// whether the device is allocated. Clients making requests from this API
        /// must poll GetDeviceSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> GetDeviceSessionAsync(GetDeviceSessionRequest request, st::CancellationToken cancellationToken) =>
            GetDeviceSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DeviceSession, which documents the allocation status and
        /// whether the device is allocated. Clients making requests from this API
        /// must poll GetDeviceSession.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DeviceSession, e.g.
        /// "projects/{project_id}/deviceSessions/{session_id}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceSession GetDeviceSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceSession(new GetDeviceSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DeviceSession, which documents the allocation status and
        /// whether the device is allocated. Clients making requests from this API
        /// must poll GetDeviceSession.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DeviceSession, e.g.
        /// "projects/{project_id}/deviceSessions/{session_id}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> GetDeviceSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceSessionAsync(new GetDeviceSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DeviceSession, which documents the allocation status and
        /// whether the device is allocated. Clients making requests from this API
        /// must poll GetDeviceSession.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DeviceSession, e.g.
        /// "projects/{project_id}/deviceSessions/{session_id}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> GetDeviceSessionAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeviceSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DeviceSession, which documents the allocation status and
        /// whether the device is allocated. Clients making requests from this API
        /// must poll GetDeviceSession.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DeviceSession, e.g.
        /// "projects/{project_id}/deviceSessions/{session_id}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceSession GetDeviceSession(DeviceSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceSession(new GetDeviceSessionRequest
            {
                DeviceSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DeviceSession, which documents the allocation status and
        /// whether the device is allocated. Clients making requests from this API
        /// must poll GetDeviceSession.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DeviceSession, e.g.
        /// "projects/{project_id}/deviceSessions/{session_id}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> GetDeviceSessionAsync(DeviceSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeviceSessionAsync(new GetDeviceSessionRequest
            {
                DeviceSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DeviceSession, which documents the allocation status and
        /// whether the device is allocated. Clients making requests from this API
        /// must poll GetDeviceSession.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DeviceSession, e.g.
        /// "projects/{project_id}/deviceSessions/{session_id}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> GetDeviceSessionAsync(DeviceSessionName name, st::CancellationToken cancellationToken) =>
            GetDeviceSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancel a DeviceSession.
        /// This RPC changes the DeviceSession to state FINISHED and terminates all
        /// connections.
        /// Canceled sessions are not deleted and can be retrieved or
        /// listed by the user until they expire based on the 28 day deletion policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelDeviceSession(CancelDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancel a DeviceSession.
        /// This RPC changes the DeviceSession to state FINISHED and terminates all
        /// connections.
        /// Canceled sessions are not deleted and can be retrieved or
        /// listed by the user until they expire based on the 28 day deletion policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelDeviceSessionAsync(CancelDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancel a DeviceSession.
        /// This RPC changes the DeviceSession to state FINISHED and terminates all
        /// connections.
        /// Canceled sessions are not deleted and can be retrieved or
        /// listed by the user until they expire based on the 28 day deletion policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelDeviceSessionAsync(CancelDeviceSessionRequest request, st::CancellationToken cancellationToken) =>
            CancelDeviceSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the current DeviceSession to the fields described by the
        /// update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceSession UpdateDeviceSession(UpdateDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the current DeviceSession to the fields described by the
        /// update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> UpdateDeviceSessionAsync(UpdateDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the current DeviceSession to the fields described by the
        /// update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> UpdateDeviceSessionAsync(UpdateDeviceSessionRequest request, st::CancellationToken cancellationToken) =>
            UpdateDeviceSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the current DeviceSession to the fields described by the
        /// update_mask.
        /// </summary>
        /// <param name="deviceSession">
        /// Required. DeviceSession to update.
        /// The DeviceSession's `name` field is used to identify the session to update
        /// "projects/{project_id}/deviceSessions/{session_id}"
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeviceSession UpdateDeviceSession(DeviceSession deviceSession, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeviceSession(new UpdateDeviceSessionRequest
            {
                DeviceSession = gax::GaxPreconditions.CheckNotNull(deviceSession, nameof(deviceSession)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the current DeviceSession to the fields described by the
        /// update_mask.
        /// </summary>
        /// <param name="deviceSession">
        /// Required. DeviceSession to update.
        /// The DeviceSession's `name` field is used to identify the session to update
        /// "projects/{project_id}/deviceSessions/{session_id}"
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> UpdateDeviceSessionAsync(DeviceSession deviceSession, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeviceSessionAsync(new UpdateDeviceSessionRequest
            {
                DeviceSession = gax::GaxPreconditions.CheckNotNull(deviceSession, nameof(deviceSession)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the current DeviceSession to the fields described by the
        /// update_mask.
        /// </summary>
        /// <param name="deviceSession">
        /// Required. DeviceSession to update.
        /// The DeviceSession's `name` field is used to identify the session to update
        /// "projects/{project_id}/deviceSessions/{session_id}"
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeviceSession> UpdateDeviceSessionAsync(DeviceSession deviceSession, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDeviceSessionAsync(deviceSession, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="AdbConnect(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class AdbConnectStream : gaxgrpc::BidirectionalStreamingBase<AdbMessage, DeviceMessage>
        {
        }

        /// <summary>
        /// Exposes an ADB connection if the device supports ADB.
        /// gRPC headers are used to authenticate the Connect RPC, as well as
        /// associate to a particular DeviceSession.
        /// In particular, the user must specify the "X-Omnilab-Session-Name" header.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual AdbConnectStream AdbConnect(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>DirectAccessService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for allocating Android devices and interacting with the
    /// live-allocated devices.
    /// 
    /// Each Session will wait for available capacity, at a higher
    /// priority over Test Execution. When allocated, the session will be exposed
    /// through a stream for integration.
    /// 
    /// DirectAccessService is currently available as a preview to select developers.
    /// You can register today on behalf of you and your team at
    /// https://developer.android.com/studio/preview/android-device-streaming
    /// </remarks>
    public sealed partial class DirectAccessServiceClientImpl : DirectAccessServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDeviceSessionRequest, DeviceSession> _callCreateDeviceSession;

        private readonly gaxgrpc::ApiCall<ListDeviceSessionsRequest, ListDeviceSessionsResponse> _callListDeviceSessions;

        private readonly gaxgrpc::ApiCall<GetDeviceSessionRequest, DeviceSession> _callGetDeviceSession;

        private readonly gaxgrpc::ApiCall<CancelDeviceSessionRequest, wkt::Empty> _callCancelDeviceSession;

        private readonly gaxgrpc::ApiCall<UpdateDeviceSessionRequest, DeviceSession> _callUpdateDeviceSession;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<AdbMessage, DeviceMessage> _callAdbConnect;

        /// <summary>
        /// Constructs a client wrapper for the DirectAccessService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DirectAccessServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DirectAccessServiceClientImpl(DirectAccessService.DirectAccessServiceClient grpcClient, DirectAccessServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DirectAccessServiceSettings effectiveSettings = settings ?? DirectAccessServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateDeviceSession = clientHelper.BuildApiCall<CreateDeviceSessionRequest, DeviceSession>("CreateDeviceSession", grpcClient.CreateDeviceSessionAsync, grpcClient.CreateDeviceSession, effectiveSettings.CreateDeviceSessionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDeviceSession);
            Modify_CreateDeviceSessionApiCall(ref _callCreateDeviceSession);
            _callListDeviceSessions = clientHelper.BuildApiCall<ListDeviceSessionsRequest, ListDeviceSessionsResponse>("ListDeviceSessions", grpcClient.ListDeviceSessionsAsync, grpcClient.ListDeviceSessions, effectiveSettings.ListDeviceSessionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeviceSessions);
            Modify_ListDeviceSessionsApiCall(ref _callListDeviceSessions);
            _callGetDeviceSession = clientHelper.BuildApiCall<GetDeviceSessionRequest, DeviceSession>("GetDeviceSession", grpcClient.GetDeviceSessionAsync, grpcClient.GetDeviceSession, effectiveSettings.GetDeviceSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeviceSession);
            Modify_GetDeviceSessionApiCall(ref _callGetDeviceSession);
            _callCancelDeviceSession = clientHelper.BuildApiCall<CancelDeviceSessionRequest, wkt::Empty>("CancelDeviceSession", grpcClient.CancelDeviceSessionAsync, grpcClient.CancelDeviceSession, effectiveSettings.CancelDeviceSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelDeviceSession);
            Modify_CancelDeviceSessionApiCall(ref _callCancelDeviceSession);
            _callUpdateDeviceSession = clientHelper.BuildApiCall<UpdateDeviceSessionRequest, DeviceSession>("UpdateDeviceSession", grpcClient.UpdateDeviceSessionAsync, grpcClient.UpdateDeviceSession, effectiveSettings.UpdateDeviceSessionSettings).WithGoogleRequestParam("device_session.name", request => request.DeviceSession?.Name);
            Modify_ApiCall(ref _callUpdateDeviceSession);
            Modify_UpdateDeviceSessionApiCall(ref _callUpdateDeviceSession);
            _callAdbConnect = clientHelper.BuildApiCall<AdbMessage, DeviceMessage>("AdbConnect", grpcClient.AdbConnect, effectiveSettings.AdbConnectSettings, effectiveSettings.AdbConnectStreamingSettings);
            Modify_ApiCall(ref _callAdbConnect);
            Modify_AdbConnectApiCall(ref _callAdbConnect);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDeviceSessionApiCall(ref gaxgrpc::ApiCall<CreateDeviceSessionRequest, DeviceSession> call);

        partial void Modify_ListDeviceSessionsApiCall(ref gaxgrpc::ApiCall<ListDeviceSessionsRequest, ListDeviceSessionsResponse> call);

        partial void Modify_GetDeviceSessionApiCall(ref gaxgrpc::ApiCall<GetDeviceSessionRequest, DeviceSession> call);

        partial void Modify_CancelDeviceSessionApiCall(ref gaxgrpc::ApiCall<CancelDeviceSessionRequest, wkt::Empty> call);

        partial void Modify_UpdateDeviceSessionApiCall(ref gaxgrpc::ApiCall<UpdateDeviceSessionRequest, DeviceSession> call);

        partial void Modify_AdbConnectApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<AdbMessage, DeviceMessage> call);

        partial void OnConstruction(DirectAccessService.DirectAccessServiceClient grpcClient, DirectAccessServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DirectAccessService client</summary>
        public override DirectAccessService.DirectAccessServiceClient GrpcClient { get; }

        partial void Modify_CreateDeviceSessionRequest(ref CreateDeviceSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeviceSessionsRequest(ref ListDeviceSessionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeviceSessionRequest(ref GetDeviceSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelDeviceSessionRequest(ref CancelDeviceSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDeviceSessionRequest(ref UpdateDeviceSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AdbMessageCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_AdbMessageRequest(ref AdbMessage request);

        /// <summary>
        /// Creates a DeviceSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeviceSession CreateDeviceSession(CreateDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeviceSessionRequest(ref request, ref callSettings);
            return _callCreateDeviceSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a DeviceSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeviceSession> CreateDeviceSessionAsync(CreateDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeviceSessionRequest(ref request, ref callSettings);
            return _callCreateDeviceSession.Async(request, callSettings);
        }

        /// <summary>
        /// Lists DeviceSessions owned by the project user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeviceSession"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeviceSessionsResponse, DeviceSession> ListDeviceSessions(ListDeviceSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeviceSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeviceSessionsRequest, ListDeviceSessionsResponse, DeviceSession>(_callListDeviceSessions, request, callSettings);
        }

        /// <summary>
        /// Lists DeviceSessions owned by the project user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeviceSession"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeviceSessionsResponse, DeviceSession> ListDeviceSessionsAsync(ListDeviceSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeviceSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeviceSessionsRequest, ListDeviceSessionsResponse, DeviceSession>(_callListDeviceSessions, request, callSettings);
        }

        /// <summary>
        /// Gets a DeviceSession, which documents the allocation status and
        /// whether the device is allocated. Clients making requests from this API
        /// must poll GetDeviceSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeviceSession GetDeviceSession(GetDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeviceSessionRequest(ref request, ref callSettings);
            return _callGetDeviceSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a DeviceSession, which documents the allocation status and
        /// whether the device is allocated. Clients making requests from this API
        /// must poll GetDeviceSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeviceSession> GetDeviceSessionAsync(GetDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeviceSessionRequest(ref request, ref callSettings);
            return _callGetDeviceSession.Async(request, callSettings);
        }

        /// <summary>
        /// Cancel a DeviceSession.
        /// This RPC changes the DeviceSession to state FINISHED and terminates all
        /// connections.
        /// Canceled sessions are not deleted and can be retrieved or
        /// listed by the user until they expire based on the 28 day deletion policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CancelDeviceSession(CancelDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelDeviceSessionRequest(ref request, ref callSettings);
            _callCancelDeviceSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancel a DeviceSession.
        /// This RPC changes the DeviceSession to state FINISHED and terminates all
        /// connections.
        /// Canceled sessions are not deleted and can be retrieved or
        /// listed by the user until they expire based on the 28 day deletion policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CancelDeviceSessionAsync(CancelDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelDeviceSessionRequest(ref request, ref callSettings);
            return _callCancelDeviceSession.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the current DeviceSession to the fields described by the
        /// update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeviceSession UpdateDeviceSession(UpdateDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeviceSessionRequest(ref request, ref callSettings);
            return _callUpdateDeviceSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the current DeviceSession to the fields described by the
        /// update_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeviceSession> UpdateDeviceSessionAsync(UpdateDeviceSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeviceSessionRequest(ref request, ref callSettings);
            return _callUpdateDeviceSession.Async(request, callSettings);
        }

        internal sealed partial class AdbConnectStreamImpl : AdbConnectStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>AdbConnect</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{AdbMessage}"/> instance associated with this
            /// streaming call.
            /// </param>
            public AdbConnectStreamImpl(DirectAccessServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<AdbMessage, DeviceMessage> call, gaxgrpc::BufferedClientStreamWriter<AdbMessage> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private DirectAccessServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<AdbMessage> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<AdbMessage, DeviceMessage> GrpcCall { get; }

            private AdbMessage ModifyRequest(AdbMessage request)
            {
                _service.Modify_AdbMessageRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(AdbMessage message) => _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(AdbMessage message) => _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(AdbMessage message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(AdbMessage message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Exposes an ADB connection if the device supports ADB.
        /// gRPC headers are used to authenticate the Connect RPC, as well as
        /// associate to a particular DeviceSession.
        /// In particular, the user must specify the "X-Omnilab-Session-Name" header.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override DirectAccessServiceClient.AdbConnectStream AdbConnect(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_AdbMessageCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callAdbConnect.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<AdbMessage, DeviceMessage> call = _callAdbConnect.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<AdbMessage> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<AdbMessage>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new AdbConnectStreamImpl(this, call, writeBuffer);
        }
    }

    public partial class ListDeviceSessionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeviceSessionsResponse : gaxgrpc::IPageResponse<DeviceSession>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DeviceSession> GetEnumerator() => DeviceSessions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
