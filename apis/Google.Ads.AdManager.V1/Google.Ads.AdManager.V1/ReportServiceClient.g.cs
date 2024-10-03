// Copyright 2024 Google LLC
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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="ReportServiceClient"/> instances.</summary>
    public sealed partial class ReportServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReportServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReportServiceSettings"/>.</returns>
        public static ReportServiceSettings GetDefault() => new ReportServiceSettings();

        /// <summary>Constructs a new <see cref="ReportServiceSettings"/> object with default settings.</summary>
        public ReportServiceSettings()
        {
        }

        private ReportServiceSettings(ReportServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetReportSettings = existing.GetReportSettings;
            ListReportsSettings = existing.ListReportsSettings;
            CreateReportSettings = existing.CreateReportSettings;
            UpdateReportSettings = existing.UpdateReportSettings;
            RunReportSettings = existing.RunReportSettings;
            RunReportOperationsSettings = existing.RunReportOperationsSettings.Clone();
            FetchReportResultRowsSettings = existing.FetchReportResultRowsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReportServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReportServiceClient.GetReport</c> and <c>ReportServiceClient.GetReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReportServiceClient.ListReports</c> and <c>ReportServiceClient.ListReportsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReportsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReportServiceClient.CreateReport</c> and <c>ReportServiceClient.CreateReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReportServiceClient.UpdateReport</c> and <c>ReportServiceClient.UpdateReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReportServiceClient.RunReport</c> and <c>ReportServiceClient.RunReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ReportServiceClient.RunReport</c> and
        /// <c>ReportServiceClient.RunReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RunReportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReportServiceClient.FetchReportResultRows</c> and <c>ReportServiceClient.FetchReportResultRowsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchReportResultRowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReportServiceSettings"/> object.</returns>
        public ReportServiceSettings Clone() => new ReportServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReportServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ReportServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReportServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReportServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReportServiceClientBuilder() : base(ReportServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReportServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReportServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReportServiceClient Build()
        {
            ReportServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReportServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReportServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReportServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReportServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReportServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReportServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReportServiceClient.ChannelPool;
    }

    /// <summary>ReportService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for interacting with reports.
    /// </remarks>
    public abstract partial class ReportServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReportService service, which is a host of "admanager.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default ReportService scopes.</summary>
        /// <remarks>The default ReportService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReportService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReportServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReportServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReportServiceClient"/>.</returns>
        public static stt::Task<ReportServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReportServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReportServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReportServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ReportServiceClient"/>.</returns>
        public static ReportServiceClient Create() => new ReportServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReportServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReportServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReportServiceClient"/>.</returns>
        internal static ReportServiceClient Create(grpccore::CallInvoker callInvoker, ReportServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReportService.ReportServiceClient grpcClient = new ReportService.ReportServiceClient(callInvoker);
            return new ReportServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ReportService client</summary>
        public virtual ReportService.ReportServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Report GetReport(GetReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(GetReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(GetReportRequest request, st::CancellationToken cancellationToken) =>
            GetReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Report` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the report.
        /// Format: `networks/{network_code}/reports/{report_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Report GetReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReport(new GetReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Report` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the report.
        /// Format: `networks/{network_code}/reports/{report_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportAsync(new GetReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Report` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the report.
        /// Format: `networks/{network_code}/reports/{report_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(string name, st::CancellationToken cancellationToken) =>
            GetReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Report` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the report.
        /// Format: `networks/{network_code}/reports/{report_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Report GetReport(ReportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReport(new GetReportRequest
            {
                ReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Report` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the report.
        /// Format: `networks/{network_code}/reports/{report_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(ReportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportAsync(new GetReportRequest
            {
                ReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Report` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the report.
        /// Format: `networks/{network_code}/reports/{report_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(ReportName name, st::CancellationToken cancellationToken) =>
            GetReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `Report` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Report"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportsResponse, Report> ListReports(ListReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Report` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Report"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportsResponse, Report> ListReportsAsync(ListReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Report` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of reports.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="Report"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportsResponse, Report> ListReports(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportsRequest request = new ListReportsRequest
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
            return ListReports(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Report` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of reports.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Report"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportsResponse, Report> ListReportsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportsRequest request = new ListReportsRequest
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
            return ListReportsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Report` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of reports.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="Report"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportsResponse, Report> ListReports(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportsRequest request = new ListReportsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReports(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Report` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of reports.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Report"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportsResponse, Report> ListReportsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportsRequest request = new ListReportsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReportsAsync(request, callSettings);
        }

        /// <summary>
        /// API to create a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Report CreateReport(CreateReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> CreateReportAsync(CreateReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> CreateReportAsync(CreateReportRequest request, st::CancellationToken cancellationToken) =>
            CreateReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `Report` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Report` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="report">
        /// Required. The `Report` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Report CreateReport(string parent, Report report, gaxgrpc::CallSettings callSettings = null) =>
            CreateReport(new CreateReportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Report = gax::GaxPreconditions.CheckNotNull(report, nameof(report)),
            }, callSettings);

        /// <summary>
        /// API to create a `Report` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Report` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="report">
        /// Required. The `Report` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> CreateReportAsync(string parent, Report report, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportAsync(new CreateReportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Report = gax::GaxPreconditions.CheckNotNull(report, nameof(report)),
            }, callSettings);

        /// <summary>
        /// API to create a `Report` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Report` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="report">
        /// Required. The `Report` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> CreateReportAsync(string parent, Report report, st::CancellationToken cancellationToken) =>
            CreateReportAsync(parent, report, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `Report` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Report` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="report">
        /// Required. The `Report` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Report CreateReport(NetworkName parent, Report report, gaxgrpc::CallSettings callSettings = null) =>
            CreateReport(new CreateReportRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Report = gax::GaxPreconditions.CheckNotNull(report, nameof(report)),
            }, callSettings);

        /// <summary>
        /// API to create a `Report` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Report` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="report">
        /// Required. The `Report` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> CreateReportAsync(NetworkName parent, Report report, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportAsync(new CreateReportRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Report = gax::GaxPreconditions.CheckNotNull(report, nameof(report)),
            }, callSettings);

        /// <summary>
        /// API to create a `Report` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Report` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="report">
        /// Required. The `Report` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> CreateReportAsync(NetworkName parent, Report report, st::CancellationToken cancellationToken) =>
            CreateReportAsync(parent, report, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Report UpdateReport(UpdateReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> UpdateReportAsync(UpdateReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> UpdateReportAsync(UpdateReportRequest request, st::CancellationToken cancellationToken) =>
            UpdateReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `Report` object.
        /// </summary>
        /// <param name="report">
        /// Required. The `Report` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Report UpdateReport(Report report, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReport(new UpdateReportRequest
            {
                Report = gax::GaxPreconditions.CheckNotNull(report, nameof(report)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update a `Report` object.
        /// </summary>
        /// <param name="report">
        /// Required. The `Report` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> UpdateReportAsync(Report report, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReportAsync(new UpdateReportRequest
            {
                Report = gax::GaxPreconditions.CheckNotNull(report, nameof(report)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// API to update a `Report` object.
        /// </summary>
        /// <param name="report">
        /// Required. The `Report` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> UpdateReportAsync(Report report, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateReportAsync(report, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates the execution of an existing report asynchronously. Users can
        /// get the report by polling this operation via
        /// `OperationsService.GetOperation`.
        /// Poll every 5 seconds initially, with an exponential
        /// backoff. Once a report is complete, the operation will contain a
        /// `RunReportResponse` in its response field containing a report_result that
        /// can be passed to the `FetchReportResultRows` method to retrieve the report
        /// data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RunReportResponse, RunReportMetadata> RunReport(RunReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates the execution of an existing report asynchronously. Users can
        /// get the report by polling this operation via
        /// `OperationsService.GetOperation`.
        /// Poll every 5 seconds initially, with an exponential
        /// backoff. Once a report is complete, the operation will contain a
        /// `RunReportResponse` in its response field containing a report_result that
        /// can be passed to the `FetchReportResultRows` method to retrieve the report
        /// data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunReportResponse, RunReportMetadata>> RunReportAsync(RunReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates the execution of an existing report asynchronously. Users can
        /// get the report by polling this operation via
        /// `OperationsService.GetOperation`.
        /// Poll every 5 seconds initially, with an exponential
        /// backoff. Once a report is complete, the operation will contain a
        /// `RunReportResponse` in its response field containing a report_result that
        /// can be passed to the `FetchReportResultRows` method to retrieve the report
        /// data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunReportResponse, RunReportMetadata>> RunReportAsync(RunReportRequest request, st::CancellationToken cancellationToken) =>
            RunReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunReport</c>.</summary>
        public virtual lro::OperationsClient RunReportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RunReportResponse, RunReportMetadata> PollOnceRunReport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RunReportResponse, RunReportMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunReportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RunReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RunReportResponse, RunReportMetadata>> PollOnceRunReportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RunReportResponse, RunReportMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunReportOperationsClient, callSettings);

        /// <summary>
        /// Initiates the execution of an existing report asynchronously. Users can
        /// get the report by polling this operation via
        /// `OperationsService.GetOperation`.
        /// Poll every 5 seconds initially, with an exponential
        /// backoff. Once a report is complete, the operation will contain a
        /// `RunReportResponse` in its response field containing a report_result that
        /// can be passed to the `FetchReportResultRows` method to retrieve the report
        /// data.
        /// </summary>
        /// <param name="name">
        /// Required. The report to run.
        /// Format: `networks/{network_code}/reports/{report_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RunReportResponse, RunReportMetadata> RunReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            RunReport(new RunReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Initiates the execution of an existing report asynchronously. Users can
        /// get the report by polling this operation via
        /// `OperationsService.GetOperation`.
        /// Poll every 5 seconds initially, with an exponential
        /// backoff. Once a report is complete, the operation will contain a
        /// `RunReportResponse` in its response field containing a report_result that
        /// can be passed to the `FetchReportResultRows` method to retrieve the report
        /// data.
        /// </summary>
        /// <param name="name">
        /// Required. The report to run.
        /// Format: `networks/{network_code}/reports/{report_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunReportResponse, RunReportMetadata>> RunReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RunReportAsync(new RunReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Initiates the execution of an existing report asynchronously. Users can
        /// get the report by polling this operation via
        /// `OperationsService.GetOperation`.
        /// Poll every 5 seconds initially, with an exponential
        /// backoff. Once a report is complete, the operation will contain a
        /// `RunReportResponse` in its response field containing a report_result that
        /// can be passed to the `FetchReportResultRows` method to retrieve the report
        /// data.
        /// </summary>
        /// <param name="name">
        /// Required. The report to run.
        /// Format: `networks/{network_code}/reports/{report_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunReportResponse, RunReportMetadata>> RunReportAsync(string name, st::CancellationToken cancellationToken) =>
            RunReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates the execution of an existing report asynchronously. Users can
        /// get the report by polling this operation via
        /// `OperationsService.GetOperation`.
        /// Poll every 5 seconds initially, with an exponential
        /// backoff. Once a report is complete, the operation will contain a
        /// `RunReportResponse` in its response field containing a report_result that
        /// can be passed to the `FetchReportResultRows` method to retrieve the report
        /// data.
        /// </summary>
        /// <param name="name">
        /// Required. The report to run.
        /// Format: `networks/{network_code}/reports/{report_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RunReportResponse, RunReportMetadata> RunReport(ReportName name, gaxgrpc::CallSettings callSettings = null) =>
            RunReport(new RunReportRequest
            {
                ReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Initiates the execution of an existing report asynchronously. Users can
        /// get the report by polling this operation via
        /// `OperationsService.GetOperation`.
        /// Poll every 5 seconds initially, with an exponential
        /// backoff. Once a report is complete, the operation will contain a
        /// `RunReportResponse` in its response field containing a report_result that
        /// can be passed to the `FetchReportResultRows` method to retrieve the report
        /// data.
        /// </summary>
        /// <param name="name">
        /// Required. The report to run.
        /// Format: `networks/{network_code}/reports/{report_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunReportResponse, RunReportMetadata>> RunReportAsync(ReportName name, gaxgrpc::CallSettings callSettings = null) =>
            RunReportAsync(new RunReportRequest
            {
                ReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Initiates the execution of an existing report asynchronously. Users can
        /// get the report by polling this operation via
        /// `OperationsService.GetOperation`.
        /// Poll every 5 seconds initially, with an exponential
        /// backoff. Once a report is complete, the operation will contain a
        /// `RunReportResponse` in its response field containing a report_result that
        /// can be passed to the `FetchReportResultRows` method to retrieve the report
        /// data.
        /// </summary>
        /// <param name="name">
        /// Required. The report to run.
        /// Format: `networks/{network_code}/reports/{report_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunReportResponse, RunReportMetadata>> RunReportAsync(ReportName name, st::CancellationToken cancellationToken) =>
            RunReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the result rows from a completed report.
        /// The caller must have previously called `RunReport` and waited for that
        /// operation to complete. The rows will be returned according to the order
        /// specified by the `sorts` member of the report definition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Report.Types.DataTable.Types.Row"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchReportResultRowsResponse, Report.Types.DataTable.Types.Row> FetchReportResultRows(FetchReportResultRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the result rows from a completed report.
        /// The caller must have previously called `RunReport` and waited for that
        /// operation to complete. The rows will be returned according to the order
        /// specified by the `sorts` member of the report definition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Report.Types.DataTable.Types.Row"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<FetchReportResultRowsResponse, Report.Types.DataTable.Types.Row> FetchReportResultRowsAsync(FetchReportResultRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the result rows from a completed report.
        /// The caller must have previously called `RunReport` and waited for that
        /// operation to complete. The rows will be returned according to the order
        /// specified by the `sorts` member of the report definition.
        /// </summary>
        /// <param name="name">
        /// The report result being fetched.
        /// Format:
        /// `networks/{network_code}/reports/{report_id}/results/{report_result_id}`
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
        /// <returns>A pageable sequence of <see cref="Report.Types.DataTable.Types.Row"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchReportResultRowsResponse, Report.Types.DataTable.Types.Row> FetchReportResultRows(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchReportResultRowsRequest request = new FetchReportResultRowsRequest { Name = name ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchReportResultRows(request, callSettings);
        }

        /// <summary>
        /// Returns the result rows from a completed report.
        /// The caller must have previously called `RunReport` and waited for that
        /// operation to complete. The rows will be returned according to the order
        /// specified by the `sorts` member of the report definition.
        /// </summary>
        /// <param name="name">
        /// The report result being fetched.
        /// Format:
        /// `networks/{network_code}/reports/{report_id}/results/{report_result_id}`
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Report.Types.DataTable.Types.Row"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<FetchReportResultRowsResponse, Report.Types.DataTable.Types.Row> FetchReportResultRowsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchReportResultRowsRequest request = new FetchReportResultRowsRequest { Name = name ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchReportResultRowsAsync(request, callSettings);
        }
    }

    /// <summary>ReportService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for interacting with reports.
    /// </remarks>
    public sealed partial class ReportServiceClientImpl : ReportServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetReportRequest, Report> _callGetReport;

        private readonly gaxgrpc::ApiCall<ListReportsRequest, ListReportsResponse> _callListReports;

        private readonly gaxgrpc::ApiCall<CreateReportRequest, Report> _callCreateReport;

        private readonly gaxgrpc::ApiCall<UpdateReportRequest, Report> _callUpdateReport;

        private readonly gaxgrpc::ApiCall<RunReportRequest, lro::Operation> _callRunReport;

        private readonly gaxgrpc::ApiCall<FetchReportResultRowsRequest, FetchReportResultRowsResponse> _callFetchReportResultRows;

        /// <summary>
        /// Constructs a client wrapper for the ReportService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReportServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReportServiceClientImpl(ReportService.ReportServiceClient grpcClient, ReportServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReportServiceSettings effectiveSettings = settings ?? ReportServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            RunReportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunReportOperationsSettings, logger);
            _callGetReport = clientHelper.BuildApiCall<GetReportRequest, Report>("GetReport", grpcClient.GetReportAsync, grpcClient.GetReport, effectiveSettings.GetReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReport);
            Modify_GetReportApiCall(ref _callGetReport);
            _callListReports = clientHelper.BuildApiCall<ListReportsRequest, ListReportsResponse>("ListReports", grpcClient.ListReportsAsync, grpcClient.ListReports, effectiveSettings.ListReportsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReports);
            Modify_ListReportsApiCall(ref _callListReports);
            _callCreateReport = clientHelper.BuildApiCall<CreateReportRequest, Report>("CreateReport", grpcClient.CreateReportAsync, grpcClient.CreateReport, effectiveSettings.CreateReportSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReport);
            Modify_CreateReportApiCall(ref _callCreateReport);
            _callUpdateReport = clientHelper.BuildApiCall<UpdateReportRequest, Report>("UpdateReport", grpcClient.UpdateReportAsync, grpcClient.UpdateReport, effectiveSettings.UpdateReportSettings).WithGoogleRequestParam("report.name", request => request.Report?.Name);
            Modify_ApiCall(ref _callUpdateReport);
            Modify_UpdateReportApiCall(ref _callUpdateReport);
            _callRunReport = clientHelper.BuildApiCall<RunReportRequest, lro::Operation>("RunReport", grpcClient.RunReportAsync, grpcClient.RunReport, effectiveSettings.RunReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRunReport);
            Modify_RunReportApiCall(ref _callRunReport);
            _callFetchReportResultRows = clientHelper.BuildApiCall<FetchReportResultRowsRequest, FetchReportResultRowsResponse>("FetchReportResultRows", grpcClient.FetchReportResultRowsAsync, grpcClient.FetchReportResultRows, effectiveSettings.FetchReportResultRowsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFetchReportResultRows);
            Modify_FetchReportResultRowsApiCall(ref _callFetchReportResultRows);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetReportApiCall(ref gaxgrpc::ApiCall<GetReportRequest, Report> call);

        partial void Modify_ListReportsApiCall(ref gaxgrpc::ApiCall<ListReportsRequest, ListReportsResponse> call);

        partial void Modify_CreateReportApiCall(ref gaxgrpc::ApiCall<CreateReportRequest, Report> call);

        partial void Modify_UpdateReportApiCall(ref gaxgrpc::ApiCall<UpdateReportRequest, Report> call);

        partial void Modify_RunReportApiCall(ref gaxgrpc::ApiCall<RunReportRequest, lro::Operation> call);

        partial void Modify_FetchReportResultRowsApiCall(ref gaxgrpc::ApiCall<FetchReportResultRowsRequest, FetchReportResultRowsResponse> call);

        partial void OnConstruction(ReportService.ReportServiceClient grpcClient, ReportServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReportService client</summary>
        public override ReportService.ReportServiceClient GrpcClient { get; }

        partial void Modify_GetReportRequest(ref GetReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReportsRequest(ref ListReportsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReportRequest(ref CreateReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateReportRequest(ref UpdateReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunReportRequest(ref RunReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchReportResultRowsRequest(ref FetchReportResultRowsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Report GetReport(GetReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReportRequest(ref request, ref callSettings);
            return _callGetReport.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Report> GetReportAsync(GetReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReportRequest(ref request, ref callSettings);
            return _callGetReport.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Report` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Report"/> resources.</returns>
        public override gax::PagedEnumerable<ListReportsResponse, Report> ListReports(ListReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReportsRequest, ListReportsResponse, Report>(_callListReports, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Report` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Report"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReportsResponse, Report> ListReportsAsync(ListReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReportsRequest, ListReportsResponse, Report>(_callListReports, request, callSettings);
        }

        /// <summary>
        /// API to create a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Report CreateReport(CreateReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReportRequest(ref request, ref callSettings);
            return _callCreateReport.Sync(request, callSettings);
        }

        /// <summary>
        /// API to create a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Report> CreateReportAsync(CreateReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReportRequest(ref request, ref callSettings);
            return _callCreateReport.Async(request, callSettings);
        }

        /// <summary>
        /// API to update a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Report UpdateReport(UpdateReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReportRequest(ref request, ref callSettings);
            return _callUpdateReport.Sync(request, callSettings);
        }

        /// <summary>
        /// API to update a `Report` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Report> UpdateReportAsync(UpdateReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReportRequest(ref request, ref callSettings);
            return _callUpdateReport.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RunReport</c>.</summary>
        public override lro::OperationsClient RunReportOperationsClient { get; }

        /// <summary>
        /// Initiates the execution of an existing report asynchronously. Users can
        /// get the report by polling this operation via
        /// `OperationsService.GetOperation`.
        /// Poll every 5 seconds initially, with an exponential
        /// backoff. Once a report is complete, the operation will contain a
        /// `RunReportResponse` in its response field containing a report_result that
        /// can be passed to the `FetchReportResultRows` method to retrieve the report
        /// data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RunReportResponse, RunReportMetadata> RunReport(RunReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunReportRequest(ref request, ref callSettings);
            return new lro::Operation<RunReportResponse, RunReportMetadata>(_callRunReport.Sync(request, callSettings), RunReportOperationsClient);
        }

        /// <summary>
        /// Initiates the execution of an existing report asynchronously. Users can
        /// get the report by polling this operation via
        /// `OperationsService.GetOperation`.
        /// Poll every 5 seconds initially, with an exponential
        /// backoff. Once a report is complete, the operation will contain a
        /// `RunReportResponse` in its response field containing a report_result that
        /// can be passed to the `FetchReportResultRows` method to retrieve the report
        /// data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RunReportResponse, RunReportMetadata>> RunReportAsync(RunReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunReportRequest(ref request, ref callSettings);
            return new lro::Operation<RunReportResponse, RunReportMetadata>(await _callRunReport.Async(request, callSettings).ConfigureAwait(false), RunReportOperationsClient);
        }

        /// <summary>
        /// Returns the result rows from a completed report.
        /// The caller must have previously called `RunReport` and waited for that
        /// operation to complete. The rows will be returned according to the order
        /// specified by the `sorts` member of the report definition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Report.Types.DataTable.Types.Row"/> resources.</returns>
        public override gax::PagedEnumerable<FetchReportResultRowsResponse, Report.Types.DataTable.Types.Row> FetchReportResultRows(FetchReportResultRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchReportResultRowsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchReportResultRowsRequest, FetchReportResultRowsResponse, Report.Types.DataTable.Types.Row>(_callFetchReportResultRows, request, callSettings);
        }

        /// <summary>
        /// Returns the result rows from a completed report.
        /// The caller must have previously called `RunReport` and waited for that
        /// operation to complete. The rows will be returned according to the order
        /// specified by the `sorts` member of the report definition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Report.Types.DataTable.Types.Row"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<FetchReportResultRowsResponse, Report.Types.DataTable.Types.Row> FetchReportResultRowsAsync(FetchReportResultRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchReportResultRowsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchReportResultRowsRequest, FetchReportResultRowsResponse, Report.Types.DataTable.Types.Row>(_callFetchReportResultRows, request, callSettings);
        }
    }

    public partial class ListReportsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchReportResultRowsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReportsResponse : gaxgrpc::IPageResponse<Report>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Report> GetEnumerator() => Reports.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchReportResultRowsResponse : gaxgrpc::IPageResponse<Report.Types.DataTable.Types.Row>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Report.Types.DataTable.Types.Row> GetEnumerator() => Rows.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ReportService
    {
        public partial class ReportServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
