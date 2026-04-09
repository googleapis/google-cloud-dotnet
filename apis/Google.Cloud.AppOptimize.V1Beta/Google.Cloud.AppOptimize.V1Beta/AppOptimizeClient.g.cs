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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.AppOptimize.V1Beta
{
    /// <summary>Settings for <see cref="AppOptimizeClient"/> instances.</summary>
    public sealed partial class AppOptimizeSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AppOptimizeSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AppOptimizeSettings"/>.</returns>
        public static AppOptimizeSettings GetDefault() => new AppOptimizeSettings();

        /// <summary>Constructs a new <see cref="AppOptimizeSettings"/> object with default settings.</summary>
        public AppOptimizeSettings()
        {
        }

        private AppOptimizeSettings(AppOptimizeSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateReportSettings = existing.CreateReportSettings;
            CreateReportOperationsSettings = existing.CreateReportOperationsSettings.Clone();
            GetReportSettings = existing.GetReportSettings;
            ListReportsSettings = existing.ListReportsSettings;
            DeleteReportSettings = existing.DeleteReportSettings;
            ReadReportSettings = existing.ReadReportSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AppOptimizeSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppOptimizeClient.CreateReport</c> and <c>AppOptimizeClient.CreateReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AppOptimizeClient.CreateReport</c> and
        /// <c>AppOptimizeClient.CreateReportAsync</c>.
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
        public lro::OperationsSettings CreateReportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppOptimizeClient.GetReport</c>
        ///  and <c>AppOptimizeClient.GetReportAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppOptimizeClient.ListReports</c> and <c>AppOptimizeClient.ListReportsAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReportsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppOptimizeClient.DeleteReport</c> and <c>AppOptimizeClient.DeleteReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppOptimizeClient.ReadReport</c> and <c>AppOptimizeClient.ReadReportAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReadReportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AppOptimizeSettings"/> object.</returns>
        public AppOptimizeSettings Clone() => new AppOptimizeSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AppOptimizeClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AppOptimizeClientBuilder : gaxgrpc::ClientBuilderBase<AppOptimizeClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AppOptimizeSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AppOptimizeClientBuilder() : base(AppOptimizeClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AppOptimizeClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AppOptimizeClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AppOptimizeClient Build()
        {
            AppOptimizeClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AppOptimizeClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AppOptimizeClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AppOptimizeClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AppOptimizeClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AppOptimizeClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AppOptimizeClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AppOptimizeClient.ChannelPool;
    }

    /// <summary>AppOptimize client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing and querying optimization reports.
    /// </remarks>
    public abstract partial class AppOptimizeClient
    {
        /// <summary>
        /// The default endpoint for the AppOptimize service, which is a host of "appoptimize.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "appoptimize.googleapis.com:443";

        /// <summary>The default AppOptimize scopes.</summary>
        /// <remarks>
        /// The default AppOptimize scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AppOptimize.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AppOptimizeClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AppOptimizeClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AppOptimizeClient"/>.</returns>
        public static stt::Task<AppOptimizeClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AppOptimizeClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AppOptimizeClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AppOptimizeClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AppOptimizeClient"/>.</returns>
        public static AppOptimizeClient Create() => new AppOptimizeClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AppOptimizeClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AppOptimizeSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AppOptimizeClient"/>.</returns>
        internal static AppOptimizeClient Create(grpccore::CallInvoker callInvoker, AppOptimizeSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AppOptimize.AppOptimizeClient grpcClient = new AppOptimize.AppOptimizeClient(callInvoker);
            return new AppOptimizeClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AppOptimize client</summary>
        public virtual AppOptimize.AppOptimizeClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new report.
        /// 
        /// This initiates a long-running operation that, upon completion, results
        /// in a report resource. Once the report is created, its results can be read
        /// via `ReadReport`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Report, OperationMetadata> CreateReport(CreateReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new report.
        /// 
        /// This initiates a long-running operation that, upon completion, results
        /// in a report resource. Once the report is created, its results can be read
        /// via `ReadReport`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Report, OperationMetadata>> CreateReportAsync(CreateReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new report.
        /// 
        /// This initiates a long-running operation that, upon completion, results
        /// in a report resource. Once the report is created, its results can be read
        /// via `ReadReport`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Report, OperationMetadata>> CreateReportAsync(CreateReportRequest request, st::CancellationToken cancellationToken) =>
            CreateReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateReport</c>.</summary>
        public virtual lro::OperationsClient CreateReportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Report, OperationMetadata> PollOnceCreateReport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Report, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Report, OperationMetadata>> PollOnceCreateReportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Report, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReportOperationsClient, callSettings);

        /// <summary>
        /// Creates a new report.
        /// 
        /// This initiates a long-running operation that, upon completion, results
        /// in a report resource. Once the report is created, its results can be read
        /// via `ReadReport`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Google Cloud project that will own the report.
        /// 
        /// This value does not define the scope of the report data. See `Report.scope`
        /// for setting the data scope.
        /// 
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="report">
        /// Required. The report resource to create.
        /// </param>
        /// <param name="reportId">
        /// Required. The ID to use for this report. This ID must be unique within
        /// the parent project and should comply with RFC 1034 restrictions (letters,
        /// numbers, and hyphen, with the first character a letter, the last a letter
        /// or a number, and a 63 character maximum).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Report, OperationMetadata> CreateReport(string parent, Report report, string reportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReport(new CreateReportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReportId = gax::GaxPreconditions.CheckNotNullOrEmpty(reportId, nameof(reportId)),
                Report = gax::GaxPreconditions.CheckNotNull(report, nameof(report)),
            }, callSettings);

        /// <summary>
        /// Creates a new report.
        /// 
        /// This initiates a long-running operation that, upon completion, results
        /// in a report resource. Once the report is created, its results can be read
        /// via `ReadReport`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Google Cloud project that will own the report.
        /// 
        /// This value does not define the scope of the report data. See `Report.scope`
        /// for setting the data scope.
        /// 
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="report">
        /// Required. The report resource to create.
        /// </param>
        /// <param name="reportId">
        /// Required. The ID to use for this report. This ID must be unique within
        /// the parent project and should comply with RFC 1034 restrictions (letters,
        /// numbers, and hyphen, with the first character a letter, the last a letter
        /// or a number, and a 63 character maximum).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Report, OperationMetadata>> CreateReportAsync(string parent, Report report, string reportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportAsync(new CreateReportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReportId = gax::GaxPreconditions.CheckNotNullOrEmpty(reportId, nameof(reportId)),
                Report = gax::GaxPreconditions.CheckNotNull(report, nameof(report)),
            }, callSettings);

        /// <summary>
        /// Creates a new report.
        /// 
        /// This initiates a long-running operation that, upon completion, results
        /// in a report resource. Once the report is created, its results can be read
        /// via `ReadReport`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Google Cloud project that will own the report.
        /// 
        /// This value does not define the scope of the report data. See `Report.scope`
        /// for setting the data scope.
        /// 
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="report">
        /// Required. The report resource to create.
        /// </param>
        /// <param name="reportId">
        /// Required. The ID to use for this report. This ID must be unique within
        /// the parent project and should comply with RFC 1034 restrictions (letters,
        /// numbers, and hyphen, with the first character a letter, the last a letter
        /// or a number, and a 63 character maximum).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Report, OperationMetadata>> CreateReportAsync(string parent, Report report, string reportId, st::CancellationToken cancellationToken) =>
            CreateReportAsync(parent, report, reportId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new report.
        /// 
        /// This initiates a long-running operation that, upon completion, results
        /// in a report resource. Once the report is created, its results can be read
        /// via `ReadReport`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Google Cloud project that will own the report.
        /// 
        /// This value does not define the scope of the report data. See `Report.scope`
        /// for setting the data scope.
        /// 
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="report">
        /// Required. The report resource to create.
        /// </param>
        /// <param name="reportId">
        /// Required. The ID to use for this report. This ID must be unique within
        /// the parent project and should comply with RFC 1034 restrictions (letters,
        /// numbers, and hyphen, with the first character a letter, the last a letter
        /// or a number, and a 63 character maximum).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Report, OperationMetadata> CreateReport(gagr::LocationName parent, Report report, string reportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReport(new CreateReportRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReportId = gax::GaxPreconditions.CheckNotNullOrEmpty(reportId, nameof(reportId)),
                Report = gax::GaxPreconditions.CheckNotNull(report, nameof(report)),
            }, callSettings);

        /// <summary>
        /// Creates a new report.
        /// 
        /// This initiates a long-running operation that, upon completion, results
        /// in a report resource. Once the report is created, its results can be read
        /// via `ReadReport`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Google Cloud project that will own the report.
        /// 
        /// This value does not define the scope of the report data. See `Report.scope`
        /// for setting the data scope.
        /// 
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="report">
        /// Required. The report resource to create.
        /// </param>
        /// <param name="reportId">
        /// Required. The ID to use for this report. This ID must be unique within
        /// the parent project and should comply with RFC 1034 restrictions (letters,
        /// numbers, and hyphen, with the first character a letter, the last a letter
        /// or a number, and a 63 character maximum).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Report, OperationMetadata>> CreateReportAsync(gagr::LocationName parent, Report report, string reportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportAsync(new CreateReportRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReportId = gax::GaxPreconditions.CheckNotNullOrEmpty(reportId, nameof(reportId)),
                Report = gax::GaxPreconditions.CheckNotNull(report, nameof(report)),
            }, callSettings);

        /// <summary>
        /// Creates a new report.
        /// 
        /// This initiates a long-running operation that, upon completion, results
        /// in a report resource. Once the report is created, its results can be read
        /// via `ReadReport`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Google Cloud project that will own the report.
        /// 
        /// This value does not define the scope of the report data. See `Report.scope`
        /// for setting the data scope.
        /// 
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="report">
        /// Required. The report resource to create.
        /// </param>
        /// <param name="reportId">
        /// Required. The ID to use for this report. This ID must be unique within
        /// the parent project and should comply with RFC 1034 restrictions (letters,
        /// numbers, and hyphen, with the first character a letter, the last a letter
        /// or a number, and a 63 character maximum).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Report, OperationMetadata>> CreateReportAsync(gagr::LocationName parent, Report report, string reportId, st::CancellationToken cancellationToken) =>
            CreateReportAsync(parent, report, reportId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the details of a report configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Report GetReport(GetReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the details of a report configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(GetReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the details of a report configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(GetReportRequest request, st::CancellationToken cancellationToken) =>
            GetReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the details of a report configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the report to retrieve.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Report GetReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReport(new GetReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the details of a report configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the report to retrieve.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportAsync(new GetReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the details of a report configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the report to retrieve.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(string name, st::CancellationToken cancellationToken) =>
            GetReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the details of a report configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the report to retrieve.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Report GetReport(ReportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReport(new GetReportRequest
            {
                ReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the details of a report configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the report to retrieve.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(ReportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportAsync(new GetReportRequest
            {
                ReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the details of a report configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the report to retrieve.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Report> GetReportAsync(ReportName name, st::CancellationToken cancellationToken) =>
            GetReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists reports within a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Report"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportsResponse, Report> ListReports(ListReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists reports within a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Report"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportsResponse, Report> ListReportsAsync(ListReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists reports within a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project whose reports are to be listed.
        /// 
        /// Format: `projects/{project}/locations/{location}`.
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
        /// Lists reports within a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project whose reports are to be listed.
        /// 
        /// Format: `projects/{project}/locations/{location}`.
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
        /// Lists reports within a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project whose reports are to be listed.
        /// 
        /// Format: `projects/{project}/locations/{location}`.
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
        public virtual gax::PagedEnumerable<ListReportsResponse, Report> ListReports(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportsRequest request = new ListReportsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists reports within a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project whose reports are to be listed.
        /// 
        /// Format: `projects/{project}/locations/{location}`.
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
        public virtual gax::PagedAsyncEnumerable<ListReportsResponse, Report> ListReportsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportsRequest request = new ListReportsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Deletes the specified report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReport(DeleteReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportAsync(DeleteReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportAsync(DeleteReportRequest request, st::CancellationToken cancellationToken) =>
            DeleteReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified report.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the report to delete.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReport(new DeleteReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified report.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the report to delete.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportAsync(new DeleteReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified report.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the report to delete.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified report.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the report to delete.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReport(ReportName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReport(new DeleteReportRequest
            {
                ReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified report.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the report to delete.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportAsync(ReportName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportAsync(new DeleteReportRequest
            {
                ReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified report.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the report to delete.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportAsync(ReportName name, st::CancellationToken cancellationToken) =>
            DeleteReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reads data within a specified report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="wkt::ListValue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ReadReportResponse, wkt::ListValue> ReadReport(ReadReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads data within a specified report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="wkt::ListValue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ReadReportResponse, wkt::ListValue> ReadReportAsync(ReadReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads data within a specified report.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the report to query.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
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
        /// <returns>A pageable sequence of <see cref="wkt::ListValue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ReadReportResponse, wkt::ListValue> ReadReport(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ReadReportRequest request = new ReadReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ReadReport(request, callSettings);
        }

        /// <summary>
        /// Reads data within a specified report.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the report to query.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="wkt::ListValue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ReadReportResponse, wkt::ListValue> ReadReportAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ReadReportRequest request = new ReadReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ReadReportAsync(request, callSettings);
        }

        /// <summary>
        /// Reads data within a specified report.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the report to query.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
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
        /// <returns>A pageable sequence of <see cref="wkt::ListValue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ReadReportResponse, wkt::ListValue> ReadReport(ReportName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ReadReportRequest request = new ReadReportRequest
            {
                ReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ReadReport(request, callSettings);
        }

        /// <summary>
        /// Reads data within a specified report.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the report to query.
        /// 
        /// Format: `projects/{project}/locations/{location}/reports/{report_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="wkt::ListValue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ReadReportResponse, wkt::ListValue> ReadReportAsync(ReportName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ReadReportRequest request = new ReadReportRequest
            {
                ReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ReadReportAsync(request, callSettings);
        }
    }

    /// <summary>AppOptimize client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing and querying optimization reports.
    /// </remarks>
    public sealed partial class AppOptimizeClientImpl : AppOptimizeClient
    {
        private readonly gaxgrpc::ApiCall<CreateReportRequest, lro::Operation> _callCreateReport;

        private readonly gaxgrpc::ApiCall<GetReportRequest, Report> _callGetReport;

        private readonly gaxgrpc::ApiCall<ListReportsRequest, ListReportsResponse> _callListReports;

        private readonly gaxgrpc::ApiCall<DeleteReportRequest, wkt::Empty> _callDeleteReport;

        private readonly gaxgrpc::ApiCall<ReadReportRequest, ReadReportResponse> _callReadReport;

        /// <summary>
        /// Constructs a client wrapper for the AppOptimize service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AppOptimizeSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AppOptimizeClientImpl(AppOptimize.AppOptimizeClient grpcClient, AppOptimizeSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AppOptimizeSettings effectiveSettings = settings ?? AppOptimizeSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateReportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateReportOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateReport = clientHelper.BuildApiCall<CreateReportRequest, lro::Operation>("CreateReport", grpcClient.CreateReportAsync, grpcClient.CreateReport, effectiveSettings.CreateReportSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReport);
            Modify_CreateReportApiCall(ref _callCreateReport);
            _callGetReport = clientHelper.BuildApiCall<GetReportRequest, Report>("GetReport", grpcClient.GetReportAsync, grpcClient.GetReport, effectiveSettings.GetReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReport);
            Modify_GetReportApiCall(ref _callGetReport);
            _callListReports = clientHelper.BuildApiCall<ListReportsRequest, ListReportsResponse>("ListReports", grpcClient.ListReportsAsync, grpcClient.ListReports, effectiveSettings.ListReportsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReports);
            Modify_ListReportsApiCall(ref _callListReports);
            _callDeleteReport = clientHelper.BuildApiCall<DeleteReportRequest, wkt::Empty>("DeleteReport", grpcClient.DeleteReportAsync, grpcClient.DeleteReport, effectiveSettings.DeleteReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteReport);
            Modify_DeleteReportApiCall(ref _callDeleteReport);
            _callReadReport = clientHelper.BuildApiCall<ReadReportRequest, ReadReportResponse>("ReadReport", grpcClient.ReadReportAsync, grpcClient.ReadReport, effectiveSettings.ReadReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callReadReport);
            Modify_ReadReportApiCall(ref _callReadReport);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateReportApiCall(ref gaxgrpc::ApiCall<CreateReportRequest, lro::Operation> call);

        partial void Modify_GetReportApiCall(ref gaxgrpc::ApiCall<GetReportRequest, Report> call);

        partial void Modify_ListReportsApiCall(ref gaxgrpc::ApiCall<ListReportsRequest, ListReportsResponse> call);

        partial void Modify_DeleteReportApiCall(ref gaxgrpc::ApiCall<DeleteReportRequest, wkt::Empty> call);

        partial void Modify_ReadReportApiCall(ref gaxgrpc::ApiCall<ReadReportRequest, ReadReportResponse> call);

        partial void OnConstruction(AppOptimize.AppOptimizeClient grpcClient, AppOptimizeSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AppOptimize client</summary>
        public override AppOptimize.AppOptimizeClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateReportRequest(ref CreateReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReportRequest(ref GetReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReportsRequest(ref ListReportsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReportRequest(ref DeleteReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadReportRequest(ref ReadReportRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateReport</c>.</summary>
        public override lro::OperationsClient CreateReportOperationsClient { get; }

        /// <summary>
        /// Creates a new report.
        /// 
        /// This initiates a long-running operation that, upon completion, results
        /// in a report resource. Once the report is created, its results can be read
        /// via `ReadReport`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Report, OperationMetadata> CreateReport(CreateReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReportRequest(ref request, ref callSettings);
            return new lro::Operation<Report, OperationMetadata>(_callCreateReport.Sync(request, callSettings), CreateReportOperationsClient);
        }

        /// <summary>
        /// Creates a new report.
        /// 
        /// This initiates a long-running operation that, upon completion, results
        /// in a report resource. Once the report is created, its results can be read
        /// via `ReadReport`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Report, OperationMetadata>> CreateReportAsync(CreateReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReportRequest(ref request, ref callSettings);
            return new lro::Operation<Report, OperationMetadata>(await _callCreateReport.Async(request, callSettings).ConfigureAwait(false), CreateReportOperationsClient);
        }

        /// <summary>
        /// Retrieves the details of a report configuration.
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
        /// Retrieves the details of a report configuration.
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
        /// Lists reports within a given project.
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
        /// Lists reports within a given project.
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
        /// Deletes the specified report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteReport(DeleteReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReportRequest(ref request, ref callSettings);
            _callDeleteReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteReportAsync(DeleteReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReportRequest(ref request, ref callSettings);
            return _callDeleteReport.Async(request, callSettings);
        }

        /// <summary>
        /// Reads data within a specified report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="wkt::ListValue"/> resources.</returns>
        public override gax::PagedEnumerable<ReadReportResponse, wkt::ListValue> ReadReport(ReadReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadReportRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ReadReportRequest, ReadReportResponse, wkt::ListValue>(_callReadReport, request, callSettings);
        }

        /// <summary>
        /// Reads data within a specified report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="wkt::ListValue"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ReadReportResponse, wkt::ListValue> ReadReportAsync(ReadReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadReportRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ReadReportRequest, ReadReportResponse, wkt::ListValue>(_callReadReport, request, callSettings);
        }
    }

    public partial class ListReportsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ReadReportRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReportsResponse : gaxgrpc::IPageResponse<Report>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Report> GetEnumerator() => Reports.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ReadReportResponse : gaxgrpc::IPageResponse<wkt::ListValue>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<wkt::ListValue> GetEnumerator() => Rows.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AppOptimize
    {
        public partial class AppOptimizeClient
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

    public static partial class AppOptimize
    {
        public partial class AppOptimizeClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
