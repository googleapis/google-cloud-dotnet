// Copyright 2026 Google LLC
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

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Settings for <see cref="NativeDashboardServiceClient"/> instances.</summary>
    public sealed partial class NativeDashboardServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NativeDashboardServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NativeDashboardServiceSettings"/>.</returns>
        public static NativeDashboardServiceSettings GetDefault() => new NativeDashboardServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="NativeDashboardServiceSettings"/> object with default settings.
        /// </summary>
        public NativeDashboardServiceSettings()
        {
        }

        private NativeDashboardServiceSettings(NativeDashboardServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateNativeDashboardSettings = existing.CreateNativeDashboardSettings;
            GetNativeDashboardSettings = existing.GetNativeDashboardSettings;
            ListNativeDashboardsSettings = existing.ListNativeDashboardsSettings;
            UpdateNativeDashboardSettings = existing.UpdateNativeDashboardSettings;
            DuplicateNativeDashboardSettings = existing.DuplicateNativeDashboardSettings;
            DeleteNativeDashboardSettings = existing.DeleteNativeDashboardSettings;
            AddChartSettings = existing.AddChartSettings;
            RemoveChartSettings = existing.RemoveChartSettings;
            EditChartSettings = existing.EditChartSettings;
            DuplicateChartSettings = existing.DuplicateChartSettings;
            ExportNativeDashboardsSettings = existing.ExportNativeDashboardsSettings;
            ImportNativeDashboardsSettings = existing.ImportNativeDashboardsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(NativeDashboardServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeDashboardServiceClient.CreateNativeDashboard</c> and
        /// <c>NativeDashboardServiceClient.CreateNativeDashboardAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateNativeDashboardSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeDashboardServiceClient.GetNativeDashboard</c> and
        /// <c>NativeDashboardServiceClient.GetNativeDashboardAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNativeDashboardSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeDashboardServiceClient.ListNativeDashboards</c> and
        /// <c>NativeDashboardServiceClient.ListNativeDashboardsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNativeDashboardsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeDashboardServiceClient.UpdateNativeDashboard</c> and
        /// <c>NativeDashboardServiceClient.UpdateNativeDashboardAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateNativeDashboardSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeDashboardServiceClient.DuplicateNativeDashboard</c> and
        /// <c>NativeDashboardServiceClient.DuplicateNativeDashboardAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DuplicateNativeDashboardSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeDashboardServiceClient.DeleteNativeDashboard</c> and
        /// <c>NativeDashboardServiceClient.DeleteNativeDashboardAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNativeDashboardSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeDashboardServiceClient.AddChart</c> and <c>NativeDashboardServiceClient.AddChartAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddChartSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeDashboardServiceClient.RemoveChart</c> and <c>NativeDashboardServiceClient.RemoveChartAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveChartSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeDashboardServiceClient.EditChart</c> and <c>NativeDashboardServiceClient.EditChartAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EditChartSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeDashboardServiceClient.DuplicateChart</c> and <c>NativeDashboardServiceClient.DuplicateChartAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DuplicateChartSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeDashboardServiceClient.ExportNativeDashboards</c> and
        /// <c>NativeDashboardServiceClient.ExportNativeDashboardsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportNativeDashboardsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NativeDashboardServiceClient.ImportNativeDashboards</c> and
        /// <c>NativeDashboardServiceClient.ImportNativeDashboardsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportNativeDashboardsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="NativeDashboardServiceSettings"/> object.</returns>
        public NativeDashboardServiceSettings Clone() => new NativeDashboardServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NativeDashboardServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class NativeDashboardServiceClientBuilder : gaxgrpc::ClientBuilderBase<NativeDashboardServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NativeDashboardServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NativeDashboardServiceClientBuilder() : base(NativeDashboardServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NativeDashboardServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NativeDashboardServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NativeDashboardServiceClient Build()
        {
            NativeDashboardServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NativeDashboardServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NativeDashboardServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NativeDashboardServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NativeDashboardServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<NativeDashboardServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NativeDashboardServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NativeDashboardServiceClient.ChannelPool;
    }

    /// <summary>NativeDashboardService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service providing functionality for managing native dashboards.
    /// </remarks>
    public abstract partial class NativeDashboardServiceClient
    {
        /// <summary>
        /// The default endpoint for the NativeDashboardService service, which is a host of "chronicle.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chronicle.googleapis.com:443";

        /// <summary>The default NativeDashboardService scopes.</summary>
        /// <remarks>
        /// The default NativeDashboardService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/chronicle</description></item>
        /// <item><description>https://www.googleapis.com/auth/chronicle.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/chronicle",
            "https://www.googleapis.com/auth/chronicle.readonly",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NativeDashboardService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NativeDashboardServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="NativeDashboardServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NativeDashboardServiceClient"/>.</returns>
        public static stt::Task<NativeDashboardServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NativeDashboardServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NativeDashboardServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="NativeDashboardServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="NativeDashboardServiceClient"/>.</returns>
        public static NativeDashboardServiceClient Create() => new NativeDashboardServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NativeDashboardServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NativeDashboardServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NativeDashboardServiceClient"/>.</returns>
        internal static NativeDashboardServiceClient Create(grpccore::CallInvoker callInvoker, NativeDashboardServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NativeDashboardService.NativeDashboardServiceClient grpcClient = new NativeDashboardService.NativeDashboardServiceClient(callInvoker);
            return new NativeDashboardServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC NativeDashboardService client</summary>
        public virtual NativeDashboardService.NativeDashboardServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeDashboard CreateNativeDashboard(CreateNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> CreateNativeDashboardAsync(CreateNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> CreateNativeDashboardAsync(CreateNativeDashboardRequest request, st::CancellationToken cancellationToken) =>
            CreateNativeDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a dashboard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this dashboard will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="nativeDashboard">
        /// Required. The dashboard to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeDashboard CreateNativeDashboard(string parent, NativeDashboard nativeDashboard, gaxgrpc::CallSettings callSettings = null) =>
            CreateNativeDashboard(new CreateNativeDashboardRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NativeDashboard = gax::GaxPreconditions.CheckNotNull(nativeDashboard, nameof(nativeDashboard)),
            }, callSettings);

        /// <summary>
        /// Create a dashboard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this dashboard will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="nativeDashboard">
        /// Required. The dashboard to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> CreateNativeDashboardAsync(string parent, NativeDashboard nativeDashboard, gaxgrpc::CallSettings callSettings = null) =>
            CreateNativeDashboardAsync(new CreateNativeDashboardRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NativeDashboard = gax::GaxPreconditions.CheckNotNull(nativeDashboard, nameof(nativeDashboard)),
            }, callSettings);

        /// <summary>
        /// Create a dashboard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this dashboard will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="nativeDashboard">
        /// Required. The dashboard to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> CreateNativeDashboardAsync(string parent, NativeDashboard nativeDashboard, st::CancellationToken cancellationToken) =>
            CreateNativeDashboardAsync(parent, nativeDashboard, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a dashboard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this dashboard will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="nativeDashboard">
        /// Required. The dashboard to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeDashboard CreateNativeDashboard(InstanceName parent, NativeDashboard nativeDashboard, gaxgrpc::CallSettings callSettings = null) =>
            CreateNativeDashboard(new CreateNativeDashboardRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NativeDashboard = gax::GaxPreconditions.CheckNotNull(nativeDashboard, nameof(nativeDashboard)),
            }, callSettings);

        /// <summary>
        /// Create a dashboard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this dashboard will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="nativeDashboard">
        /// Required. The dashboard to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> CreateNativeDashboardAsync(InstanceName parent, NativeDashboard nativeDashboard, gaxgrpc::CallSettings callSettings = null) =>
            CreateNativeDashboardAsync(new CreateNativeDashboardRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NativeDashboard = gax::GaxPreconditions.CheckNotNull(nativeDashboard, nameof(nativeDashboard)),
            }, callSettings);

        /// <summary>
        /// Create a dashboard.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this dashboard will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="nativeDashboard">
        /// Required. The dashboard to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> CreateNativeDashboardAsync(InstanceName parent, NativeDashboard nativeDashboard, st::CancellationToken cancellationToken) =>
            CreateNativeDashboardAsync(parent, nativeDashboard, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeDashboard GetNativeDashboard(GetNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> GetNativeDashboardAsync(GetNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> GetNativeDashboardAsync(GetNativeDashboardRequest request, st::CancellationToken cancellationToken) =>
            GetNativeDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to fetch.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeDashboard GetNativeDashboard(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNativeDashboard(new GetNativeDashboardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to fetch.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> GetNativeDashboardAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNativeDashboardAsync(new GetNativeDashboardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to fetch.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> GetNativeDashboardAsync(string name, st::CancellationToken cancellationToken) =>
            GetNativeDashboardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to fetch.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeDashboard GetNativeDashboard(NativeDashboardName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNativeDashboard(new GetNativeDashboardRequest
            {
                NativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to fetch.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> GetNativeDashboardAsync(NativeDashboardName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNativeDashboardAsync(new GetNativeDashboardRequest
            {
                NativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to fetch.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> GetNativeDashboardAsync(NativeDashboardName name, st::CancellationToken cancellationToken) =>
            GetNativeDashboardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NativeDashboard"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNativeDashboardsResponse, NativeDashboard> ListNativeDashboards(ListNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NativeDashboard"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNativeDashboardsResponse, NativeDashboard> ListNativeDashboardsAsync(ListNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent owning this dashboard collection.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="NativeDashboard"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNativeDashboardsResponse, NativeDashboard> ListNativeDashboards(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNativeDashboardsRequest request = new ListNativeDashboardsRequest
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
            return ListNativeDashboards(request, callSettings);
        }

        /// <summary>
        /// List all dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent owning this dashboard collection.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="NativeDashboard"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNativeDashboardsResponse, NativeDashboard> ListNativeDashboardsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNativeDashboardsRequest request = new ListNativeDashboardsRequest
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
            return ListNativeDashboardsAsync(request, callSettings);
        }

        /// <summary>
        /// List all dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent owning this dashboard collection.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="NativeDashboard"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNativeDashboardsResponse, NativeDashboard> ListNativeDashboards(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNativeDashboardsRequest request = new ListNativeDashboardsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNativeDashboards(request, callSettings);
        }

        /// <summary>
        /// List all dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent owning this dashboard collection.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="NativeDashboard"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNativeDashboardsResponse, NativeDashboard> ListNativeDashboardsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNativeDashboardsRequest request = new ListNativeDashboardsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNativeDashboardsAsync(request, callSettings);
        }

        /// <summary>
        /// Update a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeDashboard UpdateNativeDashboard(UpdateNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> UpdateNativeDashboardAsync(UpdateNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> UpdateNativeDashboardAsync(UpdateNativeDashboardRequest request, st::CancellationToken cancellationToken) =>
            UpdateNativeDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a dashboard.
        /// </summary>
        /// <param name="nativeDashboard">
        /// Required. The dashboard to update.
        /// 
        /// The dashboard's `name` field is used to identify the dashboard to update.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="updateMask">
        /// Required. LINT.IfChange(update_mask_values)
        /// The list of fields to update.
        /// Supported paths are -
        /// display_name
        /// description
        /// definition.filters
        /// definition.charts
        /// type
        /// access
        /// dashboard_user_data.is_pinned
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeDashboard UpdateNativeDashboard(NativeDashboard nativeDashboard, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNativeDashboard(new UpdateNativeDashboardRequest
            {
                NativeDashboard = gax::GaxPreconditions.CheckNotNull(nativeDashboard, nameof(nativeDashboard)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a dashboard.
        /// </summary>
        /// <param name="nativeDashboard">
        /// Required. The dashboard to update.
        /// 
        /// The dashboard's `name` field is used to identify the dashboard to update.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="updateMask">
        /// Required. LINT.IfChange(update_mask_values)
        /// The list of fields to update.
        /// Supported paths are -
        /// display_name
        /// description
        /// definition.filters
        /// definition.charts
        /// type
        /// access
        /// dashboard_user_data.is_pinned
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> UpdateNativeDashboardAsync(NativeDashboard nativeDashboard, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNativeDashboardAsync(new UpdateNativeDashboardRequest
            {
                NativeDashboard = gax::GaxPreconditions.CheckNotNull(nativeDashboard, nameof(nativeDashboard)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a dashboard.
        /// </summary>
        /// <param name="nativeDashboard">
        /// Required. The dashboard to update.
        /// 
        /// The dashboard's `name` field is used to identify the dashboard to update.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="updateMask">
        /// Required. LINT.IfChange(update_mask_values)
        /// The list of fields to update.
        /// Supported paths are -
        /// display_name
        /// description
        /// definition.filters
        /// definition.charts
        /// type
        /// access
        /// dashboard_user_data.is_pinned
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> UpdateNativeDashboardAsync(NativeDashboard nativeDashboard, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateNativeDashboardAsync(nativeDashboard, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Duplicate a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeDashboard DuplicateNativeDashboard(DuplicateNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Duplicate a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> DuplicateNativeDashboardAsync(DuplicateNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Duplicate a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> DuplicateNativeDashboardAsync(DuplicateNativeDashboardRequest request, st::CancellationToken cancellationToken) =>
            DuplicateNativeDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Duplicate a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to duplicate.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="nativeDashboard">
        /// Required. Any fields that need modification can be passed through this like
        /// name, description etc.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeDashboard DuplicateNativeDashboard(string name, NativeDashboard nativeDashboard, gaxgrpc::CallSettings callSettings = null) =>
            DuplicateNativeDashboard(new DuplicateNativeDashboardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NativeDashboard = gax::GaxPreconditions.CheckNotNull(nativeDashboard, nameof(nativeDashboard)),
            }, callSettings);

        /// <summary>
        /// Duplicate a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to duplicate.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="nativeDashboard">
        /// Required. Any fields that need modification can be passed through this like
        /// name, description etc.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> DuplicateNativeDashboardAsync(string name, NativeDashboard nativeDashboard, gaxgrpc::CallSettings callSettings = null) =>
            DuplicateNativeDashboardAsync(new DuplicateNativeDashboardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NativeDashboard = gax::GaxPreconditions.CheckNotNull(nativeDashboard, nameof(nativeDashboard)),
            }, callSettings);

        /// <summary>
        /// Duplicate a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to duplicate.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="nativeDashboard">
        /// Required. Any fields that need modification can be passed through this like
        /// name, description etc.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> DuplicateNativeDashboardAsync(string name, NativeDashboard nativeDashboard, st::CancellationToken cancellationToken) =>
            DuplicateNativeDashboardAsync(name, nativeDashboard, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Duplicate a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to duplicate.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="nativeDashboard">
        /// Required. Any fields that need modification can be passed through this like
        /// name, description etc.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeDashboard DuplicateNativeDashboard(NativeDashboardName name, NativeDashboard nativeDashboard, gaxgrpc::CallSettings callSettings = null) =>
            DuplicateNativeDashboard(new DuplicateNativeDashboardRequest
            {
                NativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NativeDashboard = gax::GaxPreconditions.CheckNotNull(nativeDashboard, nameof(nativeDashboard)),
            }, callSettings);

        /// <summary>
        /// Duplicate a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to duplicate.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="nativeDashboard">
        /// Required. Any fields that need modification can be passed through this like
        /// name, description etc.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> DuplicateNativeDashboardAsync(NativeDashboardName name, NativeDashboard nativeDashboard, gaxgrpc::CallSettings callSettings = null) =>
            DuplicateNativeDashboardAsync(new DuplicateNativeDashboardRequest
            {
                NativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NativeDashboard = gax::GaxPreconditions.CheckNotNull(nativeDashboard, nameof(nativeDashboard)),
            }, callSettings);

        /// <summary>
        /// Duplicate a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to duplicate.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="nativeDashboard">
        /// Required. Any fields that need modification can be passed through this like
        /// name, description etc.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> DuplicateNativeDashboardAsync(NativeDashboardName name, NativeDashboard nativeDashboard, st::CancellationToken cancellationToken) =>
            DuplicateNativeDashboardAsync(name, nativeDashboard, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNativeDashboard(DeleteNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNativeDashboardAsync(DeleteNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNativeDashboardAsync(DeleteNativeDashboardRequest request, st::CancellationToken cancellationToken) =>
            DeleteNativeDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to delete.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNativeDashboard(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNativeDashboard(new DeleteNativeDashboardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to delete.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNativeDashboardAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNativeDashboardAsync(new DeleteNativeDashboardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to delete.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNativeDashboardAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteNativeDashboardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to delete.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNativeDashboard(NativeDashboardName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNativeDashboard(new DeleteNativeDashboardRequest
            {
                NativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to delete.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNativeDashboardAsync(NativeDashboardName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNativeDashboardAsync(new DeleteNativeDashboardRequest
            {
                NativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to delete.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNativeDashboardAsync(NativeDashboardName name, st::CancellationToken cancellationToken) =>
            DeleteNativeDashboardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddChartResponse AddChart(AddChartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddChartResponse> AddChartAsync(AddChartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddChartResponse> AddChartAsync(AddChartRequest request, st::CancellationToken cancellationToken) =>
            AddChartAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to add chart in.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="dashboardQuery">
        /// Optional. Query used to create the chart.
        /// </param>
        /// <param name="dashboardChart">
        /// Required. Chart to be added to the dashboard.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddChartResponse AddChart(string name, DashboardQuery dashboardQuery, DashboardChart dashboardChart, gaxgrpc::CallSettings callSettings = null) =>
            AddChart(new AddChartRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DashboardQuery = dashboardQuery,
                DashboardChart = gax::GaxPreconditions.CheckNotNull(dashboardChart, nameof(dashboardChart)),
            }, callSettings);

        /// <summary>
        /// Add chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to add chart in.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="dashboardQuery">
        /// Optional. Query used to create the chart.
        /// </param>
        /// <param name="dashboardChart">
        /// Required. Chart to be added to the dashboard.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddChartResponse> AddChartAsync(string name, DashboardQuery dashboardQuery, DashboardChart dashboardChart, gaxgrpc::CallSettings callSettings = null) =>
            AddChartAsync(new AddChartRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DashboardQuery = dashboardQuery,
                DashboardChart = gax::GaxPreconditions.CheckNotNull(dashboardChart, nameof(dashboardChart)),
            }, callSettings);

        /// <summary>
        /// Add chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to add chart in.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="dashboardQuery">
        /// Optional. Query used to create the chart.
        /// </param>
        /// <param name="dashboardChart">
        /// Required. Chart to be added to the dashboard.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddChartResponse> AddChartAsync(string name, DashboardQuery dashboardQuery, DashboardChart dashboardChart, st::CancellationToken cancellationToken) =>
            AddChartAsync(name, dashboardQuery, dashboardChart, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to add chart in.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="dashboardQuery">
        /// Optional. Query used to create the chart.
        /// </param>
        /// <param name="dashboardChart">
        /// Required. Chart to be added to the dashboard.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddChartResponse AddChart(NativeDashboardName name, DashboardQuery dashboardQuery, DashboardChart dashboardChart, gaxgrpc::CallSettings callSettings = null) =>
            AddChart(new AddChartRequest
            {
                NativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DashboardQuery = dashboardQuery,
                DashboardChart = gax::GaxPreconditions.CheckNotNull(dashboardChart, nameof(dashboardChart)),
            }, callSettings);

        /// <summary>
        /// Add chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to add chart in.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="dashboardQuery">
        /// Optional. Query used to create the chart.
        /// </param>
        /// <param name="dashboardChart">
        /// Required. Chart to be added to the dashboard.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddChartResponse> AddChartAsync(NativeDashboardName name, DashboardQuery dashboardQuery, DashboardChart dashboardChart, gaxgrpc::CallSettings callSettings = null) =>
            AddChartAsync(new AddChartRequest
            {
                NativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DashboardQuery = dashboardQuery,
                DashboardChart = gax::GaxPreconditions.CheckNotNull(dashboardChart, nameof(dashboardChart)),
            }, callSettings);

        /// <summary>
        /// Add chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to add chart in.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="dashboardQuery">
        /// Optional. Query used to create the chart.
        /// </param>
        /// <param name="dashboardChart">
        /// Required. Chart to be added to the dashboard.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddChartResponse> AddChartAsync(NativeDashboardName name, DashboardQuery dashboardQuery, DashboardChart dashboardChart, st::CancellationToken cancellationToken) =>
            AddChartAsync(name, dashboardQuery, dashboardChart, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove chart from a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeDashboard RemoveChart(RemoveChartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove chart from a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> RemoveChartAsync(RemoveChartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove chart from a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> RemoveChartAsync(RemoveChartRequest request, st::CancellationToken cancellationToken) =>
            RemoveChartAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove chart from a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to remove chart from.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeDashboard RemoveChart(string name, gaxgrpc::CallSettings callSettings = null) =>
            RemoveChart(new RemoveChartRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Remove chart from a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to remove chart from.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> RemoveChartAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RemoveChartAsync(new RemoveChartRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Remove chart from a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to remove chart from.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> RemoveChartAsync(string name, st::CancellationToken cancellationToken) =>
            RemoveChartAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove chart from a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to remove chart from.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NativeDashboard RemoveChart(NativeDashboardName name, gaxgrpc::CallSettings callSettings = null) =>
            RemoveChart(new RemoveChartRequest
            {
                NativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Remove chart from a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to remove chart from.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> RemoveChartAsync(NativeDashboardName name, gaxgrpc::CallSettings callSettings = null) =>
            RemoveChartAsync(new RemoveChartRequest
            {
                NativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Remove chart from a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to remove chart from.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NativeDashboard> RemoveChartAsync(NativeDashboardName name, st::CancellationToken cancellationToken) =>
            RemoveChartAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Edit chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EditChartResponse EditChart(EditChartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Edit chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EditChartResponse> EditChartAsync(EditChartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Edit chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EditChartResponse> EditChartAsync(EditChartRequest request, st::CancellationToken cancellationToken) =>
            EditChartAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Edit chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to edit chart in.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="dashboardQuery">
        /// Optional. Query for the edited chart.
        /// </param>
        /// <param name="dashboardChart">
        /// Optional. Edited chart.
        /// </param>
        /// <param name="editMask">
        /// Required. The list of fields to edit for chart and query.
        /// Supported paths in chart are -
        /// dashboard_chart.display_name
        /// dashboard_chart.description
        /// dashboard_chart.chart_datasource.data_sources
        /// dashboard_chart.visualization
        /// dashboard_chart.visualization.button
        /// dashboard_chart.visualization.markdown
        /// dashboard_chart.drill_down_config
        /// Supported paths in query are -
        /// dashboard_query.query
        /// dashboard_query.input
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EditChartResponse EditChart(string name, DashboardQuery dashboardQuery, DashboardChart dashboardChart, wkt::FieldMask editMask, gaxgrpc::CallSettings callSettings = null) =>
            EditChart(new EditChartRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DashboardQuery = dashboardQuery,
                DashboardChart = dashboardChart,
                EditMask = gax::GaxPreconditions.CheckNotNull(editMask, nameof(editMask)),
            }, callSettings);

        /// <summary>
        /// Edit chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to edit chart in.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="dashboardQuery">
        /// Optional. Query for the edited chart.
        /// </param>
        /// <param name="dashboardChart">
        /// Optional. Edited chart.
        /// </param>
        /// <param name="editMask">
        /// Required. The list of fields to edit for chart and query.
        /// Supported paths in chart are -
        /// dashboard_chart.display_name
        /// dashboard_chart.description
        /// dashboard_chart.chart_datasource.data_sources
        /// dashboard_chart.visualization
        /// dashboard_chart.visualization.button
        /// dashboard_chart.visualization.markdown
        /// dashboard_chart.drill_down_config
        /// Supported paths in query are -
        /// dashboard_query.query
        /// dashboard_query.input
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EditChartResponse> EditChartAsync(string name, DashboardQuery dashboardQuery, DashboardChart dashboardChart, wkt::FieldMask editMask, gaxgrpc::CallSettings callSettings = null) =>
            EditChartAsync(new EditChartRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DashboardQuery = dashboardQuery,
                DashboardChart = dashboardChart,
                EditMask = gax::GaxPreconditions.CheckNotNull(editMask, nameof(editMask)),
            }, callSettings);

        /// <summary>
        /// Edit chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to edit chart in.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="dashboardQuery">
        /// Optional. Query for the edited chart.
        /// </param>
        /// <param name="dashboardChart">
        /// Optional. Edited chart.
        /// </param>
        /// <param name="editMask">
        /// Required. The list of fields to edit for chart and query.
        /// Supported paths in chart are -
        /// dashboard_chart.display_name
        /// dashboard_chart.description
        /// dashboard_chart.chart_datasource.data_sources
        /// dashboard_chart.visualization
        /// dashboard_chart.visualization.button
        /// dashboard_chart.visualization.markdown
        /// dashboard_chart.drill_down_config
        /// Supported paths in query are -
        /// dashboard_query.query
        /// dashboard_query.input
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EditChartResponse> EditChartAsync(string name, DashboardQuery dashboardQuery, DashboardChart dashboardChart, wkt::FieldMask editMask, st::CancellationToken cancellationToken) =>
            EditChartAsync(name, dashboardQuery, dashboardChart, editMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Edit chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to edit chart in.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="dashboardQuery">
        /// Optional. Query for the edited chart.
        /// </param>
        /// <param name="dashboardChart">
        /// Optional. Edited chart.
        /// </param>
        /// <param name="editMask">
        /// Required. The list of fields to edit for chart and query.
        /// Supported paths in chart are -
        /// dashboard_chart.display_name
        /// dashboard_chart.description
        /// dashboard_chart.chart_datasource.data_sources
        /// dashboard_chart.visualization
        /// dashboard_chart.visualization.button
        /// dashboard_chart.visualization.markdown
        /// dashboard_chart.drill_down_config
        /// Supported paths in query are -
        /// dashboard_query.query
        /// dashboard_query.input
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EditChartResponse EditChart(NativeDashboardName name, DashboardQuery dashboardQuery, DashboardChart dashboardChart, wkt::FieldMask editMask, gaxgrpc::CallSettings callSettings = null) =>
            EditChart(new EditChartRequest
            {
                NativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DashboardQuery = dashboardQuery,
                DashboardChart = dashboardChart,
                EditMask = gax::GaxPreconditions.CheckNotNull(editMask, nameof(editMask)),
            }, callSettings);

        /// <summary>
        /// Edit chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to edit chart in.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="dashboardQuery">
        /// Optional. Query for the edited chart.
        /// </param>
        /// <param name="dashboardChart">
        /// Optional. Edited chart.
        /// </param>
        /// <param name="editMask">
        /// Required. The list of fields to edit for chart and query.
        /// Supported paths in chart are -
        /// dashboard_chart.display_name
        /// dashboard_chart.description
        /// dashboard_chart.chart_datasource.data_sources
        /// dashboard_chart.visualization
        /// dashboard_chart.visualization.button
        /// dashboard_chart.visualization.markdown
        /// dashboard_chart.drill_down_config
        /// Supported paths in query are -
        /// dashboard_query.query
        /// dashboard_query.input
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EditChartResponse> EditChartAsync(NativeDashboardName name, DashboardQuery dashboardQuery, DashboardChart dashboardChart, wkt::FieldMask editMask, gaxgrpc::CallSettings callSettings = null) =>
            EditChartAsync(new EditChartRequest
            {
                NativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DashboardQuery = dashboardQuery,
                DashboardChart = dashboardChart,
                EditMask = gax::GaxPreconditions.CheckNotNull(editMask, nameof(editMask)),
            }, callSettings);

        /// <summary>
        /// Edit chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name to edit chart in.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="dashboardQuery">
        /// Optional. Query for the edited chart.
        /// </param>
        /// <param name="dashboardChart">
        /// Optional. Edited chart.
        /// </param>
        /// <param name="editMask">
        /// Required. The list of fields to edit for chart and query.
        /// Supported paths in chart are -
        /// dashboard_chart.display_name
        /// dashboard_chart.description
        /// dashboard_chart.chart_datasource.data_sources
        /// dashboard_chart.visualization
        /// dashboard_chart.visualization.button
        /// dashboard_chart.visualization.markdown
        /// dashboard_chart.drill_down_config
        /// Supported paths in query are -
        /// dashboard_query.query
        /// dashboard_query.input
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EditChartResponse> EditChartAsync(NativeDashboardName name, DashboardQuery dashboardQuery, DashboardChart dashboardChart, wkt::FieldMask editMask, st::CancellationToken cancellationToken) =>
            EditChartAsync(name, dashboardQuery, dashboardChart, editMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Duplicate chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DuplicateChartResponse DuplicateChart(DuplicateChartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Duplicate chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DuplicateChartResponse> DuplicateChartAsync(DuplicateChartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Duplicate chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DuplicateChartResponse> DuplicateChartAsync(DuplicateChartRequest request, st::CancellationToken cancellationToken) =>
            DuplicateChartAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Duplicate chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name that involves chart duplication.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DuplicateChartResponse DuplicateChart(string name, gaxgrpc::CallSettings callSettings = null) =>
            DuplicateChart(new DuplicateChartRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Duplicate chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name that involves chart duplication.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DuplicateChartResponse> DuplicateChartAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DuplicateChartAsync(new DuplicateChartRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Duplicate chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name that involves chart duplication.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DuplicateChartResponse> DuplicateChartAsync(string name, st::CancellationToken cancellationToken) =>
            DuplicateChartAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Duplicate chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name that involves chart duplication.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DuplicateChartResponse DuplicateChart(NativeDashboardName name, gaxgrpc::CallSettings callSettings = null) =>
            DuplicateChart(new DuplicateChartRequest
            {
                NativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Duplicate chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name that involves chart duplication.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DuplicateChartResponse> DuplicateChartAsync(NativeDashboardName name, gaxgrpc::CallSettings callSettings = null) =>
            DuplicateChartAsync(new DuplicateChartRequest
            {
                NativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Duplicate chart in a dashboard.
        /// </summary>
        /// <param name="name">
        /// Required. The dashboard name that involves chart duplication.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/nativeDashboards/{dashboard}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DuplicateChartResponse> DuplicateChartAsync(NativeDashboardName name, st::CancellationToken cancellationToken) =>
            DuplicateChartAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExportNativeDashboardsResponse ExportNativeDashboards(ExportNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportNativeDashboardsResponse> ExportNativeDashboardsAsync(ExportNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportNativeDashboardsResponse> ExportNativeDashboardsAsync(ExportNativeDashboardsRequest request, st::CancellationToken cancellationToken) =>
            ExportNativeDashboardsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource that the dashboards to be exported belong to.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the dashboards to export.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExportNativeDashboardsResponse ExportNativeDashboards(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            ExportNativeDashboards(new ExportNativeDashboardsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Exports the dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource that the dashboards to be exported belong to.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the dashboards to export.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportNativeDashboardsResponse> ExportNativeDashboardsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            ExportNativeDashboardsAsync(new ExportNativeDashboardsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Exports the dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource that the dashboards to be exported belong to.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the dashboards to export.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportNativeDashboardsResponse> ExportNativeDashboardsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            ExportNativeDashboardsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource that the dashboards to be exported belong to.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the dashboards to export.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExportNativeDashboardsResponse ExportNativeDashboards(InstanceName parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            ExportNativeDashboards(new ExportNativeDashboardsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Exports the dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource that the dashboards to be exported belong to.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the dashboards to export.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportNativeDashboardsResponse> ExportNativeDashboardsAsync(InstanceName parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            ExportNativeDashboardsAsync(new ExportNativeDashboardsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Exports the dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource that the dashboards to be exported belong to.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the dashboards to export.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportNativeDashboardsResponse> ExportNativeDashboardsAsync(InstanceName parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            ExportNativeDashboardsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports the dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportNativeDashboardsResponse ImportNativeDashboards(ImportNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportNativeDashboardsResponse> ImportNativeDashboardsAsync(ImportNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportNativeDashboardsResponse> ImportNativeDashboardsAsync(ImportNativeDashboardsRequest request, st::CancellationToken cancellationToken) =>
            ImportNativeDashboardsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports the dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this dashboard will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="source">
        /// Required. The data will imported from this proto.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportNativeDashboardsResponse ImportNativeDashboards(string parent, ImportNativeDashboardsInlineSource source, gaxgrpc::CallSettings callSettings = null) =>
            ImportNativeDashboards(new ImportNativeDashboardsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Imports the dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this dashboard will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="source">
        /// Required. The data will imported from this proto.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportNativeDashboardsResponse> ImportNativeDashboardsAsync(string parent, ImportNativeDashboardsInlineSource source, gaxgrpc::CallSettings callSettings = null) =>
            ImportNativeDashboardsAsync(new ImportNativeDashboardsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Imports the dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this dashboard will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="source">
        /// Required. The data will imported from this proto.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportNativeDashboardsResponse> ImportNativeDashboardsAsync(string parent, ImportNativeDashboardsInlineSource source, st::CancellationToken cancellationToken) =>
            ImportNativeDashboardsAsync(parent, source, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports the dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this dashboard will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="source">
        /// Required. The data will imported from this proto.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportNativeDashboardsResponse ImportNativeDashboards(InstanceName parent, ImportNativeDashboardsInlineSource source, gaxgrpc::CallSettings callSettings = null) =>
            ImportNativeDashboards(new ImportNativeDashboardsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Imports the dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this dashboard will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="source">
        /// Required. The data will imported from this proto.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportNativeDashboardsResponse> ImportNativeDashboardsAsync(InstanceName parent, ImportNativeDashboardsInlineSource source, gaxgrpc::CallSettings callSettings = null) =>
            ImportNativeDashboardsAsync(new ImportNativeDashboardsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Imports the dashboards.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this dashboard will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="source">
        /// Required. The data will imported from this proto.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportNativeDashboardsResponse> ImportNativeDashboardsAsync(InstanceName parent, ImportNativeDashboardsInlineSource source, st::CancellationToken cancellationToken) =>
            ImportNativeDashboardsAsync(parent, source, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>NativeDashboardService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service providing functionality for managing native dashboards.
    /// </remarks>
    public sealed partial class NativeDashboardServiceClientImpl : NativeDashboardServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateNativeDashboardRequest, NativeDashboard> _callCreateNativeDashboard;

        private readonly gaxgrpc::ApiCall<GetNativeDashboardRequest, NativeDashboard> _callGetNativeDashboard;

        private readonly gaxgrpc::ApiCall<ListNativeDashboardsRequest, ListNativeDashboardsResponse> _callListNativeDashboards;

        private readonly gaxgrpc::ApiCall<UpdateNativeDashboardRequest, NativeDashboard> _callUpdateNativeDashboard;

        private readonly gaxgrpc::ApiCall<DuplicateNativeDashboardRequest, NativeDashboard> _callDuplicateNativeDashboard;

        private readonly gaxgrpc::ApiCall<DeleteNativeDashboardRequest, wkt::Empty> _callDeleteNativeDashboard;

        private readonly gaxgrpc::ApiCall<AddChartRequest, AddChartResponse> _callAddChart;

        private readonly gaxgrpc::ApiCall<RemoveChartRequest, NativeDashboard> _callRemoveChart;

        private readonly gaxgrpc::ApiCall<EditChartRequest, EditChartResponse> _callEditChart;

        private readonly gaxgrpc::ApiCall<DuplicateChartRequest, DuplicateChartResponse> _callDuplicateChart;

        private readonly gaxgrpc::ApiCall<ExportNativeDashboardsRequest, ExportNativeDashboardsResponse> _callExportNativeDashboards;

        private readonly gaxgrpc::ApiCall<ImportNativeDashboardsRequest, ImportNativeDashboardsResponse> _callImportNativeDashboards;

        /// <summary>
        /// Constructs a client wrapper for the NativeDashboardService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="NativeDashboardServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NativeDashboardServiceClientImpl(NativeDashboardService.NativeDashboardServiceClient grpcClient, NativeDashboardServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NativeDashboardServiceSettings effectiveSettings = settings ?? NativeDashboardServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateNativeDashboard = clientHelper.BuildApiCall<CreateNativeDashboardRequest, NativeDashboard>("CreateNativeDashboard", grpcClient.CreateNativeDashboardAsync, grpcClient.CreateNativeDashboard, effectiveSettings.CreateNativeDashboardSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateNativeDashboard);
            Modify_CreateNativeDashboardApiCall(ref _callCreateNativeDashboard);
            _callGetNativeDashboard = clientHelper.BuildApiCall<GetNativeDashboardRequest, NativeDashboard>("GetNativeDashboard", grpcClient.GetNativeDashboardAsync, grpcClient.GetNativeDashboard, effectiveSettings.GetNativeDashboardSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNativeDashboard);
            Modify_GetNativeDashboardApiCall(ref _callGetNativeDashboard);
            _callListNativeDashboards = clientHelper.BuildApiCall<ListNativeDashboardsRequest, ListNativeDashboardsResponse>("ListNativeDashboards", grpcClient.ListNativeDashboardsAsync, grpcClient.ListNativeDashboards, effectiveSettings.ListNativeDashboardsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNativeDashboards);
            Modify_ListNativeDashboardsApiCall(ref _callListNativeDashboards);
            _callUpdateNativeDashboard = clientHelper.BuildApiCall<UpdateNativeDashboardRequest, NativeDashboard>("UpdateNativeDashboard", grpcClient.UpdateNativeDashboardAsync, grpcClient.UpdateNativeDashboard, effectiveSettings.UpdateNativeDashboardSettings).WithGoogleRequestParam("native_dashboard.name", request => request.NativeDashboard?.Name);
            Modify_ApiCall(ref _callUpdateNativeDashboard);
            Modify_UpdateNativeDashboardApiCall(ref _callUpdateNativeDashboard);
            _callDuplicateNativeDashboard = clientHelper.BuildApiCall<DuplicateNativeDashboardRequest, NativeDashboard>("DuplicateNativeDashboard", grpcClient.DuplicateNativeDashboardAsync, grpcClient.DuplicateNativeDashboard, effectiveSettings.DuplicateNativeDashboardSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDuplicateNativeDashboard);
            Modify_DuplicateNativeDashboardApiCall(ref _callDuplicateNativeDashboard);
            _callDeleteNativeDashboard = clientHelper.BuildApiCall<DeleteNativeDashboardRequest, wkt::Empty>("DeleteNativeDashboard", grpcClient.DeleteNativeDashboardAsync, grpcClient.DeleteNativeDashboard, effectiveSettings.DeleteNativeDashboardSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteNativeDashboard);
            Modify_DeleteNativeDashboardApiCall(ref _callDeleteNativeDashboard);
            _callAddChart = clientHelper.BuildApiCall<AddChartRequest, AddChartResponse>("AddChart", grpcClient.AddChartAsync, grpcClient.AddChart, effectiveSettings.AddChartSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAddChart);
            Modify_AddChartApiCall(ref _callAddChart);
            _callRemoveChart = clientHelper.BuildApiCall<RemoveChartRequest, NativeDashboard>("RemoveChart", grpcClient.RemoveChartAsync, grpcClient.RemoveChart, effectiveSettings.RemoveChartSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRemoveChart);
            Modify_RemoveChartApiCall(ref _callRemoveChart);
            _callEditChart = clientHelper.BuildApiCall<EditChartRequest, EditChartResponse>("EditChart", grpcClient.EditChartAsync, grpcClient.EditChart, effectiveSettings.EditChartSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEditChart);
            Modify_EditChartApiCall(ref _callEditChart);
            _callDuplicateChart = clientHelper.BuildApiCall<DuplicateChartRequest, DuplicateChartResponse>("DuplicateChart", grpcClient.DuplicateChartAsync, grpcClient.DuplicateChart, effectiveSettings.DuplicateChartSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDuplicateChart);
            Modify_DuplicateChartApiCall(ref _callDuplicateChart);
            _callExportNativeDashboards = clientHelper.BuildApiCall<ExportNativeDashboardsRequest, ExportNativeDashboardsResponse>("ExportNativeDashboards", grpcClient.ExportNativeDashboardsAsync, grpcClient.ExportNativeDashboards, effectiveSettings.ExportNativeDashboardsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportNativeDashboards);
            Modify_ExportNativeDashboardsApiCall(ref _callExportNativeDashboards);
            _callImportNativeDashboards = clientHelper.BuildApiCall<ImportNativeDashboardsRequest, ImportNativeDashboardsResponse>("ImportNativeDashboards", grpcClient.ImportNativeDashboardsAsync, grpcClient.ImportNativeDashboards, effectiveSettings.ImportNativeDashboardsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportNativeDashboards);
            Modify_ImportNativeDashboardsApiCall(ref _callImportNativeDashboards);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateNativeDashboardApiCall(ref gaxgrpc::ApiCall<CreateNativeDashboardRequest, NativeDashboard> call);

        partial void Modify_GetNativeDashboardApiCall(ref gaxgrpc::ApiCall<GetNativeDashboardRequest, NativeDashboard> call);

        partial void Modify_ListNativeDashboardsApiCall(ref gaxgrpc::ApiCall<ListNativeDashboardsRequest, ListNativeDashboardsResponse> call);

        partial void Modify_UpdateNativeDashboardApiCall(ref gaxgrpc::ApiCall<UpdateNativeDashboardRequest, NativeDashboard> call);

        partial void Modify_DuplicateNativeDashboardApiCall(ref gaxgrpc::ApiCall<DuplicateNativeDashboardRequest, NativeDashboard> call);

        partial void Modify_DeleteNativeDashboardApiCall(ref gaxgrpc::ApiCall<DeleteNativeDashboardRequest, wkt::Empty> call);

        partial void Modify_AddChartApiCall(ref gaxgrpc::ApiCall<AddChartRequest, AddChartResponse> call);

        partial void Modify_RemoveChartApiCall(ref gaxgrpc::ApiCall<RemoveChartRequest, NativeDashboard> call);

        partial void Modify_EditChartApiCall(ref gaxgrpc::ApiCall<EditChartRequest, EditChartResponse> call);

        partial void Modify_DuplicateChartApiCall(ref gaxgrpc::ApiCall<DuplicateChartRequest, DuplicateChartResponse> call);

        partial void Modify_ExportNativeDashboardsApiCall(ref gaxgrpc::ApiCall<ExportNativeDashboardsRequest, ExportNativeDashboardsResponse> call);

        partial void Modify_ImportNativeDashboardsApiCall(ref gaxgrpc::ApiCall<ImportNativeDashboardsRequest, ImportNativeDashboardsResponse> call);

        partial void OnConstruction(NativeDashboardService.NativeDashboardServiceClient grpcClient, NativeDashboardServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NativeDashboardService client</summary>
        public override NativeDashboardService.NativeDashboardServiceClient GrpcClient { get; }

        partial void Modify_CreateNativeDashboardRequest(ref CreateNativeDashboardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNativeDashboardRequest(ref GetNativeDashboardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNativeDashboardsRequest(ref ListNativeDashboardsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNativeDashboardRequest(ref UpdateNativeDashboardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DuplicateNativeDashboardRequest(ref DuplicateNativeDashboardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNativeDashboardRequest(ref DeleteNativeDashboardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddChartRequest(ref AddChartRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveChartRequest(ref RemoveChartRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EditChartRequest(ref EditChartRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DuplicateChartRequest(ref DuplicateChartRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportNativeDashboardsRequest(ref ExportNativeDashboardsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportNativeDashboardsRequest(ref ImportNativeDashboardsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NativeDashboard CreateNativeDashboard(CreateNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNativeDashboardRequest(ref request, ref callSettings);
            return _callCreateNativeDashboard.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NativeDashboard> CreateNativeDashboardAsync(CreateNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNativeDashboardRequest(ref request, ref callSettings);
            return _callCreateNativeDashboard.Async(request, callSettings);
        }

        /// <summary>
        /// Get a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NativeDashboard GetNativeDashboard(GetNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNativeDashboardRequest(ref request, ref callSettings);
            return _callGetNativeDashboard.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NativeDashboard> GetNativeDashboardAsync(GetNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNativeDashboardRequest(ref request, ref callSettings);
            return _callGetNativeDashboard.Async(request, callSettings);
        }

        /// <summary>
        /// List all dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NativeDashboard"/> resources.</returns>
        public override gax::PagedEnumerable<ListNativeDashboardsResponse, NativeDashboard> ListNativeDashboards(ListNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNativeDashboardsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNativeDashboardsRequest, ListNativeDashboardsResponse, NativeDashboard>(_callListNativeDashboards, request, callSettings);
        }

        /// <summary>
        /// List all dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NativeDashboard"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNativeDashboardsResponse, NativeDashboard> ListNativeDashboardsAsync(ListNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNativeDashboardsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNativeDashboardsRequest, ListNativeDashboardsResponse, NativeDashboard>(_callListNativeDashboards, request, callSettings);
        }

        /// <summary>
        /// Update a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NativeDashboard UpdateNativeDashboard(UpdateNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNativeDashboardRequest(ref request, ref callSettings);
            return _callUpdateNativeDashboard.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NativeDashboard> UpdateNativeDashboardAsync(UpdateNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNativeDashboardRequest(ref request, ref callSettings);
            return _callUpdateNativeDashboard.Async(request, callSettings);
        }

        /// <summary>
        /// Duplicate a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NativeDashboard DuplicateNativeDashboard(DuplicateNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DuplicateNativeDashboardRequest(ref request, ref callSettings);
            return _callDuplicateNativeDashboard.Sync(request, callSettings);
        }

        /// <summary>
        /// Duplicate a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NativeDashboard> DuplicateNativeDashboardAsync(DuplicateNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DuplicateNativeDashboardRequest(ref request, ref callSettings);
            return _callDuplicateNativeDashboard.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteNativeDashboard(DeleteNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNativeDashboardRequest(ref request, ref callSettings);
            _callDeleteNativeDashboard.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteNativeDashboardAsync(DeleteNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNativeDashboardRequest(ref request, ref callSettings);
            return _callDeleteNativeDashboard.Async(request, callSettings);
        }

        /// <summary>
        /// Add chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AddChartResponse AddChart(AddChartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddChartRequest(ref request, ref callSettings);
            return _callAddChart.Sync(request, callSettings);
        }

        /// <summary>
        /// Add chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AddChartResponse> AddChartAsync(AddChartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddChartRequest(ref request, ref callSettings);
            return _callAddChart.Async(request, callSettings);
        }

        /// <summary>
        /// Remove chart from a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NativeDashboard RemoveChart(RemoveChartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveChartRequest(ref request, ref callSettings);
            return _callRemoveChart.Sync(request, callSettings);
        }

        /// <summary>
        /// Remove chart from a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NativeDashboard> RemoveChartAsync(RemoveChartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveChartRequest(ref request, ref callSettings);
            return _callRemoveChart.Async(request, callSettings);
        }

        /// <summary>
        /// Edit chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EditChartResponse EditChart(EditChartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EditChartRequest(ref request, ref callSettings);
            return _callEditChart.Sync(request, callSettings);
        }

        /// <summary>
        /// Edit chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EditChartResponse> EditChartAsync(EditChartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EditChartRequest(ref request, ref callSettings);
            return _callEditChart.Async(request, callSettings);
        }

        /// <summary>
        /// Duplicate chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DuplicateChartResponse DuplicateChart(DuplicateChartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DuplicateChartRequest(ref request, ref callSettings);
            return _callDuplicateChart.Sync(request, callSettings);
        }

        /// <summary>
        /// Duplicate chart in a dashboard.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DuplicateChartResponse> DuplicateChartAsync(DuplicateChartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DuplicateChartRequest(ref request, ref callSettings);
            return _callDuplicateChart.Async(request, callSettings);
        }

        /// <summary>
        /// Exports the dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExportNativeDashboardsResponse ExportNativeDashboards(ExportNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportNativeDashboardsRequest(ref request, ref callSettings);
            return _callExportNativeDashboards.Sync(request, callSettings);
        }

        /// <summary>
        /// Exports the dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExportNativeDashboardsResponse> ExportNativeDashboardsAsync(ExportNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportNativeDashboardsRequest(ref request, ref callSettings);
            return _callExportNativeDashboards.Async(request, callSettings);
        }

        /// <summary>
        /// Imports the dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ImportNativeDashboardsResponse ImportNativeDashboards(ImportNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportNativeDashboardsRequest(ref request, ref callSettings);
            return _callImportNativeDashboards.Sync(request, callSettings);
        }

        /// <summary>
        /// Imports the dashboards.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ImportNativeDashboardsResponse> ImportNativeDashboardsAsync(ImportNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportNativeDashboardsRequest(ref request, ref callSettings);
            return _callImportNativeDashboards.Async(request, callSettings);
        }
    }

    public partial class ListNativeDashboardsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNativeDashboardsResponse : gaxgrpc::IPageResponse<NativeDashboard>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NativeDashboard> GetEnumerator() => NativeDashboards.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
