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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Settings for <see cref="DashboardChartServiceClient"/> instances.</summary>
    public sealed partial class DashboardChartServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DashboardChartServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DashboardChartServiceSettings"/>.</returns>
        public static DashboardChartServiceSettings GetDefault() => new DashboardChartServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DashboardChartServiceSettings"/> object with default settings.
        /// </summary>
        public DashboardChartServiceSettings()
        {
        }

        private DashboardChartServiceSettings(DashboardChartServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDashboardChartSettings = existing.GetDashboardChartSettings;
            BatchGetDashboardChartsSettings = existing.BatchGetDashboardChartsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DashboardChartServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DashboardChartServiceClient.GetDashboardChart</c> and
        /// <c>DashboardChartServiceClient.GetDashboardChartAsync</c>.
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
        public gaxgrpc::CallSettings GetDashboardChartSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DashboardChartServiceClient.BatchGetDashboardCharts</c> and
        /// <c>DashboardChartServiceClient.BatchGetDashboardChartsAsync</c>.
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
        public gaxgrpc::CallSettings BatchGetDashboardChartsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DashboardChartServiceSettings"/> object.</returns>
        public DashboardChartServiceSettings Clone() => new DashboardChartServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DashboardChartServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DashboardChartServiceClientBuilder : gaxgrpc::ClientBuilderBase<DashboardChartServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DashboardChartServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DashboardChartServiceClientBuilder() : base(DashboardChartServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DashboardChartServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DashboardChartServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DashboardChartServiceClient Build()
        {
            DashboardChartServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DashboardChartServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DashboardChartServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DashboardChartServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DashboardChartServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DashboardChartServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DashboardChartServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DashboardChartServiceClient.ChannelPool;
    }

    /// <summary>DashboardChartService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service providing functionality for managing dashboards' charts.
    /// </remarks>
    public abstract partial class DashboardChartServiceClient
    {
        /// <summary>
        /// The default endpoint for the DashboardChartService service, which is a host of "chronicle.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chronicle.googleapis.com:443";

        /// <summary>The default DashboardChartService scopes.</summary>
        /// <remarks>
        /// The default DashboardChartService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DashboardChartService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DashboardChartServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DashboardChartServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DashboardChartServiceClient"/>.</returns>
        public static stt::Task<DashboardChartServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DashboardChartServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DashboardChartServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DashboardChartServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DashboardChartServiceClient"/>.</returns>
        public static DashboardChartServiceClient Create() => new DashboardChartServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DashboardChartServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DashboardChartServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DashboardChartServiceClient"/>.</returns>
        internal static DashboardChartServiceClient Create(grpccore::CallInvoker callInvoker, DashboardChartServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DashboardChartService.DashboardChartServiceClient grpcClient = new DashboardChartService.DashboardChartServiceClient(callInvoker);
            return new DashboardChartServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DashboardChartService client</summary>
        public virtual DashboardChartService.DashboardChartServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get a dashboard chart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DashboardChart GetDashboardChart(GetDashboardChartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a dashboard chart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DashboardChart> GetDashboardChartAsync(GetDashboardChartRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a dashboard chart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DashboardChart> GetDashboardChartAsync(GetDashboardChartRequest request, st::CancellationToken cancellationToken) =>
            GetDashboardChartAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a dashboard chart.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dashboardChart to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dashboardCharts/{chart}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DashboardChart GetDashboardChart(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDashboardChart(new GetDashboardChartRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dashboard chart.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dashboardChart to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dashboardCharts/{chart}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DashboardChart> GetDashboardChartAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDashboardChartAsync(new GetDashboardChartRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dashboard chart.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dashboardChart to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dashboardCharts/{chart}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DashboardChart> GetDashboardChartAsync(string name, st::CancellationToken cancellationToken) =>
            GetDashboardChartAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a dashboard chart.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dashboardChart to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dashboardCharts/{chart}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DashboardChart GetDashboardChart(DashboardChartName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDashboardChart(new GetDashboardChartRequest
            {
                DashboardChartName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dashboard chart.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dashboardChart to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dashboardCharts/{chart}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DashboardChart> GetDashboardChartAsync(DashboardChartName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDashboardChartAsync(new GetDashboardChartRequest
            {
                DashboardChartName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dashboard chart.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dashboardChart to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dashboardCharts/{chart}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DashboardChart> GetDashboardChartAsync(DashboardChartName name, st::CancellationToken cancellationToken) =>
            GetDashboardChartAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get dashboard charts in batches.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchGetDashboardChartsResponse BatchGetDashboardCharts(BatchGetDashboardChartsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get dashboard charts in batches.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetDashboardChartsResponse> BatchGetDashboardChartsAsync(BatchGetDashboardChartsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get dashboard charts in batches.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetDashboardChartsResponse> BatchGetDashboardChartsAsync(BatchGetDashboardChartsRequest request, st::CancellationToken cancellationToken) =>
            BatchGetDashboardChartsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get dashboard charts in batches.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource shared by all dashboard charts being
        /// retrieved. Format:
        /// projects/{project}/locations/{location}/instances/{instance} If this is
        /// set, the parent of all of the dashboard charts specified in `names` must
        /// match this field.
        /// </param>
        /// <param name="names">
        /// Required. The names of the dashboard charts to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchGetDashboardChartsResponse BatchGetDashboardCharts(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchGetDashboardCharts(new BatchGetDashboardChartsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Get dashboard charts in batches.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource shared by all dashboard charts being
        /// retrieved. Format:
        /// projects/{project}/locations/{location}/instances/{instance} If this is
        /// set, the parent of all of the dashboard charts specified in `names` must
        /// match this field.
        /// </param>
        /// <param name="names">
        /// Required. The names of the dashboard charts to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetDashboardChartsResponse> BatchGetDashboardChartsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchGetDashboardChartsAsync(new BatchGetDashboardChartsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Get dashboard charts in batches.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource shared by all dashboard charts being
        /// retrieved. Format:
        /// projects/{project}/locations/{location}/instances/{instance} If this is
        /// set, the parent of all of the dashboard charts specified in `names` must
        /// match this field.
        /// </param>
        /// <param name="names">
        /// Required. The names of the dashboard charts to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetDashboardChartsResponse> BatchGetDashboardChartsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchGetDashboardChartsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get dashboard charts in batches.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource shared by all dashboard charts being
        /// retrieved. Format:
        /// projects/{project}/locations/{location}/instances/{instance} If this is
        /// set, the parent of all of the dashboard charts specified in `names` must
        /// match this field.
        /// </param>
        /// <param name="names">
        /// Required. The names of the dashboard charts to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchGetDashboardChartsResponse BatchGetDashboardCharts(InstanceName parent, scg::IEnumerable<DashboardChartName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchGetDashboardCharts(new BatchGetDashboardChartsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DashboardChartNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Get dashboard charts in batches.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource shared by all dashboard charts being
        /// retrieved. Format:
        /// projects/{project}/locations/{location}/instances/{instance} If this is
        /// set, the parent of all of the dashboard charts specified in `names` must
        /// match this field.
        /// </param>
        /// <param name="names">
        /// Required. The names of the dashboard charts to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetDashboardChartsResponse> BatchGetDashboardChartsAsync(InstanceName parent, scg::IEnumerable<DashboardChartName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchGetDashboardChartsAsync(new BatchGetDashboardChartsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DashboardChartNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Get dashboard charts in batches.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource shared by all dashboard charts being
        /// retrieved. Format:
        /// projects/{project}/locations/{location}/instances/{instance} If this is
        /// set, the parent of all of the dashboard charts specified in `names` must
        /// match this field.
        /// </param>
        /// <param name="names">
        /// Required. The names of the dashboard charts to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetDashboardChartsResponse> BatchGetDashboardChartsAsync(InstanceName parent, scg::IEnumerable<DashboardChartName> names, st::CancellationToken cancellationToken) =>
            BatchGetDashboardChartsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DashboardChartService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service providing functionality for managing dashboards' charts.
    /// </remarks>
    public sealed partial class DashboardChartServiceClientImpl : DashboardChartServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDashboardChartRequest, DashboardChart> _callGetDashboardChart;

        private readonly gaxgrpc::ApiCall<BatchGetDashboardChartsRequest, BatchGetDashboardChartsResponse> _callBatchGetDashboardCharts;

        /// <summary>
        /// Constructs a client wrapper for the DashboardChartService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DashboardChartServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DashboardChartServiceClientImpl(DashboardChartService.DashboardChartServiceClient grpcClient, DashboardChartServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DashboardChartServiceSettings effectiveSettings = settings ?? DashboardChartServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetDashboardChart = clientHelper.BuildApiCall<GetDashboardChartRequest, DashboardChart>("GetDashboardChart", grpcClient.GetDashboardChartAsync, grpcClient.GetDashboardChart, effectiveSettings.GetDashboardChartSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDashboardChart);
            Modify_GetDashboardChartApiCall(ref _callGetDashboardChart);
            _callBatchGetDashboardCharts = clientHelper.BuildApiCall<BatchGetDashboardChartsRequest, BatchGetDashboardChartsResponse>("BatchGetDashboardCharts", grpcClient.BatchGetDashboardChartsAsync, grpcClient.BatchGetDashboardCharts, effectiveSettings.BatchGetDashboardChartsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchGetDashboardCharts);
            Modify_BatchGetDashboardChartsApiCall(ref _callBatchGetDashboardCharts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDashboardChartApiCall(ref gaxgrpc::ApiCall<GetDashboardChartRequest, DashboardChart> call);

        partial void Modify_BatchGetDashboardChartsApiCall(ref gaxgrpc::ApiCall<BatchGetDashboardChartsRequest, BatchGetDashboardChartsResponse> call);

        partial void OnConstruction(DashboardChartService.DashboardChartServiceClient grpcClient, DashboardChartServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DashboardChartService client</summary>
        public override DashboardChartService.DashboardChartServiceClient GrpcClient { get; }

        partial void Modify_GetDashboardChartRequest(ref GetDashboardChartRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchGetDashboardChartsRequest(ref BatchGetDashboardChartsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get a dashboard chart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DashboardChart GetDashboardChart(GetDashboardChartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDashboardChartRequest(ref request, ref callSettings);
            return _callGetDashboardChart.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a dashboard chart.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DashboardChart> GetDashboardChartAsync(GetDashboardChartRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDashboardChartRequest(ref request, ref callSettings);
            return _callGetDashboardChart.Async(request, callSettings);
        }

        /// <summary>
        /// Get dashboard charts in batches.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchGetDashboardChartsResponse BatchGetDashboardCharts(BatchGetDashboardChartsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetDashboardChartsRequest(ref request, ref callSettings);
            return _callBatchGetDashboardCharts.Sync(request, callSettings);
        }

        /// <summary>
        /// Get dashboard charts in batches.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchGetDashboardChartsResponse> BatchGetDashboardChartsAsync(BatchGetDashboardChartsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetDashboardChartsRequest(ref request, ref callSettings);
            return _callBatchGetDashboardCharts.Async(request, callSettings);
        }
    }
}
