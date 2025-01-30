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

namespace Google.Analytics.Data.V1Beta
{
    /// <summary>Settings for <see cref="BetaAnalyticsDataClient"/> instances.</summary>
    public sealed partial class BetaAnalyticsDataSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BetaAnalyticsDataSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BetaAnalyticsDataSettings"/>.</returns>
        public static BetaAnalyticsDataSettings GetDefault() => new BetaAnalyticsDataSettings();

        /// <summary>Constructs a new <see cref="BetaAnalyticsDataSettings"/> object with default settings.</summary>
        public BetaAnalyticsDataSettings()
        {
        }

        private BetaAnalyticsDataSettings(BetaAnalyticsDataSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RunReportSettings = existing.RunReportSettings;
            RunPivotReportSettings = existing.RunPivotReportSettings;
            BatchRunReportsSettings = existing.BatchRunReportsSettings;
            BatchRunPivotReportsSettings = existing.BatchRunPivotReportsSettings;
            GetMetadataSettings = existing.GetMetadataSettings;
            RunRealtimeReportSettings = existing.RunRealtimeReportSettings;
            CheckCompatibilitySettings = existing.CheckCompatibilitySettings;
            CreateAudienceExportSettings = existing.CreateAudienceExportSettings;
            CreateAudienceExportOperationsSettings = existing.CreateAudienceExportOperationsSettings.Clone();
            QueryAudienceExportSettings = existing.QueryAudienceExportSettings;
            GetAudienceExportSettings = existing.GetAudienceExportSettings;
            ListAudienceExportsSettings = existing.ListAudienceExportsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BetaAnalyticsDataSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BetaAnalyticsDataClient.RunReport</c> and <c>BetaAnalyticsDataClient.RunReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BetaAnalyticsDataClient.RunPivotReport</c> and <c>BetaAnalyticsDataClient.RunPivotReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunPivotReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BetaAnalyticsDataClient.BatchRunReports</c> and <c>BetaAnalyticsDataClient.BatchRunReportsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchRunReportsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BetaAnalyticsDataClient.BatchRunPivotReports</c> and <c>BetaAnalyticsDataClient.BatchRunPivotReportsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchRunPivotReportsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BetaAnalyticsDataClient.GetMetadata</c> and <c>BetaAnalyticsDataClient.GetMetadataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMetadataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BetaAnalyticsDataClient.RunRealtimeReport</c> and <c>BetaAnalyticsDataClient.RunRealtimeReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunRealtimeReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BetaAnalyticsDataClient.CheckCompatibility</c> and <c>BetaAnalyticsDataClient.CheckCompatibilityAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CheckCompatibilitySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BetaAnalyticsDataClient.CreateAudienceExport</c> and <c>BetaAnalyticsDataClient.CreateAudienceExportAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAudienceExportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BetaAnalyticsDataClient.CreateAudienceExport</c> and
        /// <c>BetaAnalyticsDataClient.CreateAudienceExportAsync</c>.
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
        public lro::OperationsSettings CreateAudienceExportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BetaAnalyticsDataClient.QueryAudienceExport</c> and <c>BetaAnalyticsDataClient.QueryAudienceExportAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryAudienceExportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BetaAnalyticsDataClient.GetAudienceExport</c> and <c>BetaAnalyticsDataClient.GetAudienceExportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAudienceExportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BetaAnalyticsDataClient.ListAudienceExports</c> and <c>BetaAnalyticsDataClient.ListAudienceExportsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAudienceExportsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BetaAnalyticsDataSettings"/> object.</returns>
        public BetaAnalyticsDataSettings Clone() => new BetaAnalyticsDataSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BetaAnalyticsDataClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class BetaAnalyticsDataClientBuilder : gaxgrpc::ClientBuilderBase<BetaAnalyticsDataClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BetaAnalyticsDataSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BetaAnalyticsDataClientBuilder() : base(BetaAnalyticsDataClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BetaAnalyticsDataClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BetaAnalyticsDataClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BetaAnalyticsDataClient Build()
        {
            BetaAnalyticsDataClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BetaAnalyticsDataClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BetaAnalyticsDataClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BetaAnalyticsDataClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BetaAnalyticsDataClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BetaAnalyticsDataClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BetaAnalyticsDataClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BetaAnalyticsDataClient.ChannelPool;
    }

    /// <summary>BetaAnalyticsData client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Google Analytics reporting data service.
    /// </remarks>
    public abstract partial class BetaAnalyticsDataClient
    {
        /// <summary>
        /// The default endpoint for the BetaAnalyticsData service, which is a host of "analyticsdata.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "analyticsdata.googleapis.com:443";

        /// <summary>The default BetaAnalyticsData scopes.</summary>
        /// <remarks>
        /// The default BetaAnalyticsData scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/analytics</description></item>
        /// <item><description>https://www.googleapis.com/auth/analytics.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/analytics",
            "https://www.googleapis.com/auth/analytics.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BetaAnalyticsData.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BetaAnalyticsDataClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BetaAnalyticsDataClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BetaAnalyticsDataClient"/>.</returns>
        public static stt::Task<BetaAnalyticsDataClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BetaAnalyticsDataClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BetaAnalyticsDataClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BetaAnalyticsDataClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BetaAnalyticsDataClient"/>.</returns>
        public static BetaAnalyticsDataClient Create() => new BetaAnalyticsDataClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BetaAnalyticsDataClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BetaAnalyticsDataSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BetaAnalyticsDataClient"/>.</returns>
        internal static BetaAnalyticsDataClient Create(grpccore::CallInvoker callInvoker, BetaAnalyticsDataSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BetaAnalyticsData.BetaAnalyticsDataClient grpcClient = new BetaAnalyticsData.BetaAnalyticsDataClient(callInvoker);
            return new BetaAnalyticsDataClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BetaAnalyticsData client</summary>
        public virtual BetaAnalyticsData.BetaAnalyticsDataClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// 
        /// For a guide to constructing requests &amp; understanding responses, see
        /// [Creating a
        /// Report](https://developers.google.com/analytics/devguides/reporting/data/v1/basics).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunReportResponse RunReport(RunReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// 
        /// For a guide to constructing requests &amp; understanding responses, see
        /// [Creating a
        /// Report](https://developers.google.com/analytics/devguides/reporting/data/v1/basics).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunReportResponse> RunReportAsync(RunReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// 
        /// For a guide to constructing requests &amp; understanding responses, see
        /// [Creating a
        /// Report](https://developers.google.com/analytics/devguides/reporting/data/v1/basics).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunReportResponse> RunReportAsync(RunReportRequest request, st::CancellationToken cancellationToken) =>
            RunReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunPivotReportResponse RunPivotReport(RunPivotReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunPivotReportResponse> RunPivotReportAsync(RunPivotReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunPivotReportResponse> RunPivotReportAsync(RunPivotReportRequest request, st::CancellationToken cancellationToken) =>
            RunPivotReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Google Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRunReportsResponse BatchRunReports(BatchRunReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Google Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRunReportsResponse> BatchRunReportsAsync(BatchRunReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Google Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRunReportsResponse> BatchRunReportsAsync(BatchRunReportsRequest request, st::CancellationToken cancellationToken) =>
            BatchRunReportsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Google Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRunPivotReportsResponse BatchRunPivotReports(BatchRunPivotReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Google Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRunPivotReportsResponse> BatchRunPivotReportsAsync(BatchRunPivotReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Google Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRunPivotReportsResponse> BatchRunPivotReportsAsync(BatchRunPivotReportsRequest request, st::CancellationToken cancellationToken) =>
            BatchRunPivotReportsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics property identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Metadata GetMetadata(GetMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics property identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metadata> GetMetadataAsync(GetMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics property identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metadata> GetMetadataAsync(GetMetadataRequest request, st::CancellationToken cancellationToken) =>
            GetMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics property identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the metadata to retrieve. This name field is
        /// specified in the URL path and not URL parameters. Property is a numeric
        /// Google Analytics property identifier. To learn more, see [where to find
        /// your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id).
        /// 
        /// Example: properties/1234/metadata
        /// 
        /// Set the Property ID to 0 for dimensions and metrics common to all
        /// properties. In this special mode, this method will not return custom
        /// dimensions and metrics.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Metadata GetMetadata(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadata(new GetMetadataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics property identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the metadata to retrieve. This name field is
        /// specified in the URL path and not URL parameters. Property is a numeric
        /// Google Analytics property identifier. To learn more, see [where to find
        /// your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id).
        /// 
        /// Example: properties/1234/metadata
        /// 
        /// Set the Property ID to 0 for dimensions and metrics common to all
        /// properties. In this special mode, this method will not return custom
        /// dimensions and metrics.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metadata> GetMetadataAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataAsync(new GetMetadataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics property identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the metadata to retrieve. This name field is
        /// specified in the URL path and not URL parameters. Property is a numeric
        /// Google Analytics property identifier. To learn more, see [where to find
        /// your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id).
        /// 
        /// Example: properties/1234/metadata
        /// 
        /// Set the Property ID to 0 for dimensions and metrics common to all
        /// properties. In this special mode, this method will not return custom
        /// dimensions and metrics.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metadata> GetMetadataAsync(string name, st::CancellationToken cancellationToken) =>
            GetMetadataAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics property identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the metadata to retrieve. This name field is
        /// specified in the URL path and not URL parameters. Property is a numeric
        /// Google Analytics property identifier. To learn more, see [where to find
        /// your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id).
        /// 
        /// Example: properties/1234/metadata
        /// 
        /// Set the Property ID to 0 for dimensions and metrics common to all
        /// properties. In this special mode, this method will not return custom
        /// dimensions and metrics.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Metadata GetMetadata(MetadataName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadata(new GetMetadataRequest
            {
                MetadataName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics property identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the metadata to retrieve. This name field is
        /// specified in the URL path and not URL parameters. Property is a numeric
        /// Google Analytics property identifier. To learn more, see [where to find
        /// your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id).
        /// 
        /// Example: properties/1234/metadata
        /// 
        /// Set the Property ID to 0 for dimensions and metrics common to all
        /// properties. In this special mode, this method will not return custom
        /// dimensions and metrics.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metadata> GetMetadataAsync(MetadataName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataAsync(new GetMetadataRequest
            {
                MetadataName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics property identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the metadata to retrieve. This name field is
        /// specified in the URL path and not URL parameters. Property is a numeric
        /// Google Analytics property identifier. To learn more, see [where to find
        /// your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id).
        /// 
        /// Example: properties/1234/metadata
        /// 
        /// Set the Property ID to 0 for dimensions and metrics common to all
        /// properties. In this special mode, this method will not return custom
        /// dimensions and metrics.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metadata> GetMetadataAsync(MetadataName name, st::CancellationToken cancellationToken) =>
            GetMetadataAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a customized report of realtime event data for your property.
        /// Events appear in realtime reports seconds after they have been sent to
        /// the Google Analytics. Realtime reports show events and usage data for the
        /// periods of time ranging from the present moment to 30 minutes ago (up to
        /// 60 minutes for Google Analytics 360 properties).
        /// 
        /// For a guide to constructing realtime requests &amp; understanding responses,
        /// see [Creating a Realtime
        /// Report](https://developers.google.com/analytics/devguides/reporting/data/v1/realtime-basics).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunRealtimeReportResponse RunRealtimeReport(RunRealtimeReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a customized report of realtime event data for your property.
        /// Events appear in realtime reports seconds after they have been sent to
        /// the Google Analytics. Realtime reports show events and usage data for the
        /// periods of time ranging from the present moment to 30 minutes ago (up to
        /// 60 minutes for Google Analytics 360 properties).
        /// 
        /// For a guide to constructing realtime requests &amp; understanding responses,
        /// see [Creating a Realtime
        /// Report](https://developers.google.com/analytics/devguides/reporting/data/v1/realtime-basics).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunRealtimeReportResponse> RunRealtimeReportAsync(RunRealtimeReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a customized report of realtime event data for your property.
        /// Events appear in realtime reports seconds after they have been sent to
        /// the Google Analytics. Realtime reports show events and usage data for the
        /// periods of time ranging from the present moment to 30 minutes ago (up to
        /// 60 minutes for Google Analytics 360 properties).
        /// 
        /// For a guide to constructing realtime requests &amp; understanding responses,
        /// see [Creating a Realtime
        /// Report](https://developers.google.com/analytics/devguides/reporting/data/v1/realtime-basics).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunRealtimeReportResponse> RunRealtimeReportAsync(RunRealtimeReportRequest request, st::CancellationToken cancellationToken) =>
            RunRealtimeReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This compatibility method lists dimensions and metrics that can be added to
        /// a report request and maintain compatibility. This method fails if the
        /// request's dimensions and metrics are incompatible.
        /// 
        /// In Google Analytics, reports fail if they request incompatible dimensions
        /// and/or metrics; in that case, you will need to remove dimensions and/or
        /// metrics from the incompatible report until the report is compatible.
        /// 
        /// The Realtime and Core reports have different compatibility rules. This
        /// method checks compatibility for Core reports.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckCompatibilityResponse CheckCompatibility(CheckCompatibilityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This compatibility method lists dimensions and metrics that can be added to
        /// a report request and maintain compatibility. This method fails if the
        /// request's dimensions and metrics are incompatible.
        /// 
        /// In Google Analytics, reports fail if they request incompatible dimensions
        /// and/or metrics; in that case, you will need to remove dimensions and/or
        /// metrics from the incompatible report until the report is compatible.
        /// 
        /// The Realtime and Core reports have different compatibility rules. This
        /// method checks compatibility for Core reports.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckCompatibilityResponse> CheckCompatibilityAsync(CheckCompatibilityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This compatibility method lists dimensions and metrics that can be added to
        /// a report request and maintain compatibility. This method fails if the
        /// request's dimensions and metrics are incompatible.
        /// 
        /// In Google Analytics, reports fail if they request incompatible dimensions
        /// and/or metrics; in that case, you will need to remove dimensions and/or
        /// metrics from the incompatible report until the report is compatible.
        /// 
        /// The Realtime and Core reports have different compatibility rules. This
        /// method checks compatibility for Core reports.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckCompatibilityResponse> CheckCompatibilityAsync(CheckCompatibilityRequest request, st::CancellationToken cancellationToken) =>
            CheckCompatibilityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an audience export for later retrieval. This method quickly returns
        /// the audience export's resource name and initiates a long running
        /// asynchronous request to form an audience export. To export the users in an
        /// audience export, first create the audience export through this method and
        /// then send the audience resource name to the `QueryAudienceExport` method.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// An audience export is a snapshot of the users currently in the audience at
        /// the time of audience export creation. Creating audience exports for one
        /// audience on different days will return different results as users enter and
        /// exit the audience.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572. Audience exports
        /// contain the users in each audience.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AudienceExport, AudienceExportMetadata> CreateAudienceExport(CreateAudienceExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an audience export for later retrieval. This method quickly returns
        /// the audience export's resource name and initiates a long running
        /// asynchronous request to form an audience export. To export the users in an
        /// audience export, first create the audience export through this method and
        /// then send the audience resource name to the `QueryAudienceExport` method.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// An audience export is a snapshot of the users currently in the audience at
        /// the time of audience export creation. Creating audience exports for one
        /// audience on different days will return different results as users enter and
        /// exit the audience.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572. Audience exports
        /// contain the users in each audience.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AudienceExport, AudienceExportMetadata>> CreateAudienceExportAsync(CreateAudienceExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an audience export for later retrieval. This method quickly returns
        /// the audience export's resource name and initiates a long running
        /// asynchronous request to form an audience export. To export the users in an
        /// audience export, first create the audience export through this method and
        /// then send the audience resource name to the `QueryAudienceExport` method.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// An audience export is a snapshot of the users currently in the audience at
        /// the time of audience export creation. Creating audience exports for one
        /// audience on different days will return different results as users enter and
        /// exit the audience.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572. Audience exports
        /// contain the users in each audience.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AudienceExport, AudienceExportMetadata>> CreateAudienceExportAsync(CreateAudienceExportRequest request, st::CancellationToken cancellationToken) =>
            CreateAudienceExportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAudienceExport</c>.</summary>
        public virtual lro::OperationsClient CreateAudienceExportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAudienceExport</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AudienceExport, AudienceExportMetadata> PollOnceCreateAudienceExport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AudienceExport, AudienceExportMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAudienceExportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAudienceExport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AudienceExport, AudienceExportMetadata>> PollOnceCreateAudienceExportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AudienceExport, AudienceExportMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAudienceExportOperationsClient, callSettings);

        /// <summary>
        /// Creates an audience export for later retrieval. This method quickly returns
        /// the audience export's resource name and initiates a long running
        /// asynchronous request to form an audience export. To export the users in an
        /// audience export, first create the audience export through this method and
        /// then send the audience resource name to the `QueryAudienceExport` method.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// An audience export is a snapshot of the users currently in the audience at
        /// the time of audience export creation. Creating audience exports for one
        /// audience on different days will return different results as users enter and
        /// exit the audience.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572. Audience exports
        /// contain the users in each audience.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this audience export will be created.
        /// Format: `properties/{property}`
        /// </param>
        /// <param name="audienceExport">
        /// Required. The audience export to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AudienceExport, AudienceExportMetadata> CreateAudienceExport(string parent, AudienceExport audienceExport, gaxgrpc::CallSettings callSettings = null) =>
            CreateAudienceExport(new CreateAudienceExportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AudienceExport = gax::GaxPreconditions.CheckNotNull(audienceExport, nameof(audienceExport)),
            }, callSettings);

        /// <summary>
        /// Creates an audience export for later retrieval. This method quickly returns
        /// the audience export's resource name and initiates a long running
        /// asynchronous request to form an audience export. To export the users in an
        /// audience export, first create the audience export through this method and
        /// then send the audience resource name to the `QueryAudienceExport` method.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// An audience export is a snapshot of the users currently in the audience at
        /// the time of audience export creation. Creating audience exports for one
        /// audience on different days will return different results as users enter and
        /// exit the audience.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572. Audience exports
        /// contain the users in each audience.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this audience export will be created.
        /// Format: `properties/{property}`
        /// </param>
        /// <param name="audienceExport">
        /// Required. The audience export to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AudienceExport, AudienceExportMetadata>> CreateAudienceExportAsync(string parent, AudienceExport audienceExport, gaxgrpc::CallSettings callSettings = null) =>
            CreateAudienceExportAsync(new CreateAudienceExportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AudienceExport = gax::GaxPreconditions.CheckNotNull(audienceExport, nameof(audienceExport)),
            }, callSettings);

        /// <summary>
        /// Creates an audience export for later retrieval. This method quickly returns
        /// the audience export's resource name and initiates a long running
        /// asynchronous request to form an audience export. To export the users in an
        /// audience export, first create the audience export through this method and
        /// then send the audience resource name to the `QueryAudienceExport` method.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// An audience export is a snapshot of the users currently in the audience at
        /// the time of audience export creation. Creating audience exports for one
        /// audience on different days will return different results as users enter and
        /// exit the audience.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572. Audience exports
        /// contain the users in each audience.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this audience export will be created.
        /// Format: `properties/{property}`
        /// </param>
        /// <param name="audienceExport">
        /// Required. The audience export to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AudienceExport, AudienceExportMetadata>> CreateAudienceExportAsync(string parent, AudienceExport audienceExport, st::CancellationToken cancellationToken) =>
            CreateAudienceExportAsync(parent, audienceExport, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an audience export for later retrieval. This method quickly returns
        /// the audience export's resource name and initiates a long running
        /// asynchronous request to form an audience export. To export the users in an
        /// audience export, first create the audience export through this method and
        /// then send the audience resource name to the `QueryAudienceExport` method.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// An audience export is a snapshot of the users currently in the audience at
        /// the time of audience export creation. Creating audience exports for one
        /// audience on different days will return different results as users enter and
        /// exit the audience.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572. Audience exports
        /// contain the users in each audience.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this audience export will be created.
        /// Format: `properties/{property}`
        /// </param>
        /// <param name="audienceExport">
        /// Required. The audience export to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AudienceExport, AudienceExportMetadata> CreateAudienceExport(PropertyName parent, AudienceExport audienceExport, gaxgrpc::CallSettings callSettings = null) =>
            CreateAudienceExport(new CreateAudienceExportRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AudienceExport = gax::GaxPreconditions.CheckNotNull(audienceExport, nameof(audienceExport)),
            }, callSettings);

        /// <summary>
        /// Creates an audience export for later retrieval. This method quickly returns
        /// the audience export's resource name and initiates a long running
        /// asynchronous request to form an audience export. To export the users in an
        /// audience export, first create the audience export through this method and
        /// then send the audience resource name to the `QueryAudienceExport` method.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// An audience export is a snapshot of the users currently in the audience at
        /// the time of audience export creation. Creating audience exports for one
        /// audience on different days will return different results as users enter and
        /// exit the audience.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572. Audience exports
        /// contain the users in each audience.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this audience export will be created.
        /// Format: `properties/{property}`
        /// </param>
        /// <param name="audienceExport">
        /// Required. The audience export to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AudienceExport, AudienceExportMetadata>> CreateAudienceExportAsync(PropertyName parent, AudienceExport audienceExport, gaxgrpc::CallSettings callSettings = null) =>
            CreateAudienceExportAsync(new CreateAudienceExportRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AudienceExport = gax::GaxPreconditions.CheckNotNull(audienceExport, nameof(audienceExport)),
            }, callSettings);

        /// <summary>
        /// Creates an audience export for later retrieval. This method quickly returns
        /// the audience export's resource name and initiates a long running
        /// asynchronous request to form an audience export. To export the users in an
        /// audience export, first create the audience export through this method and
        /// then send the audience resource name to the `QueryAudienceExport` method.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// An audience export is a snapshot of the users currently in the audience at
        /// the time of audience export creation. Creating audience exports for one
        /// audience on different days will return different results as users enter and
        /// exit the audience.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572. Audience exports
        /// contain the users in each audience.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this audience export will be created.
        /// Format: `properties/{property}`
        /// </param>
        /// <param name="audienceExport">
        /// Required. The audience export to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AudienceExport, AudienceExportMetadata>> CreateAudienceExportAsync(PropertyName parent, AudienceExport audienceExport, st::CancellationToken cancellationToken) =>
            CreateAudienceExportAsync(parent, audienceExport, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an audience export of users. After creating an audience, the
        /// users are not immediately available for exporting. First, a request to
        /// `CreateAudienceExport` is necessary to create an audience export of users,
        /// and then second, this method is used to retrieve the users in the audience
        /// export.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryAudienceExportResponse QueryAudienceExport(QueryAudienceExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an audience export of users. After creating an audience, the
        /// users are not immediately available for exporting. First, a request to
        /// `CreateAudienceExport` is necessary to create an audience export of users,
        /// and then second, this method is used to retrieve the users in the audience
        /// export.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryAudienceExportResponse> QueryAudienceExportAsync(QueryAudienceExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an audience export of users. After creating an audience, the
        /// users are not immediately available for exporting. First, a request to
        /// `CreateAudienceExport` is necessary to create an audience export of users,
        /// and then second, this method is used to retrieve the users in the audience
        /// export.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryAudienceExportResponse> QueryAudienceExportAsync(QueryAudienceExportRequest request, st::CancellationToken cancellationToken) =>
            QueryAudienceExportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an audience export of users. After creating an audience, the
        /// users are not immediately available for exporting. First, a request to
        /// `CreateAudienceExport` is necessary to create an audience export of users,
        /// and then second, this method is used to retrieve the users in the audience
        /// export.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the audience export to retrieve users from.
        /// Format: `properties/{property}/audienceExports/{audience_export}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryAudienceExportResponse QueryAudienceExport(string name, gaxgrpc::CallSettings callSettings = null) =>
            QueryAudienceExport(new QueryAudienceExportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an audience export of users. After creating an audience, the
        /// users are not immediately available for exporting. First, a request to
        /// `CreateAudienceExport` is necessary to create an audience export of users,
        /// and then second, this method is used to retrieve the users in the audience
        /// export.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the audience export to retrieve users from.
        /// Format: `properties/{property}/audienceExports/{audience_export}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryAudienceExportResponse> QueryAudienceExportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            QueryAudienceExportAsync(new QueryAudienceExportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an audience export of users. After creating an audience, the
        /// users are not immediately available for exporting. First, a request to
        /// `CreateAudienceExport` is necessary to create an audience export of users,
        /// and then second, this method is used to retrieve the users in the audience
        /// export.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the audience export to retrieve users from.
        /// Format: `properties/{property}/audienceExports/{audience_export}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryAudienceExportResponse> QueryAudienceExportAsync(string name, st::CancellationToken cancellationToken) =>
            QueryAudienceExportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets configuration metadata about a specific audience export. This method
        /// can be used to understand an audience export after it has been created.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AudienceExport GetAudienceExport(GetAudienceExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets configuration metadata about a specific audience export. This method
        /// can be used to understand an audience export after it has been created.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceExport> GetAudienceExportAsync(GetAudienceExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets configuration metadata about a specific audience export. This method
        /// can be used to understand an audience export after it has been created.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceExport> GetAudienceExportAsync(GetAudienceExportRequest request, st::CancellationToken cancellationToken) =>
            GetAudienceExportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets configuration metadata about a specific audience export. This method
        /// can be used to understand an audience export after it has been created.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="name">
        /// Required. The audience export resource name.
        /// Format: `properties/{property}/audienceExports/{audience_export}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AudienceExport GetAudienceExport(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAudienceExport(new GetAudienceExportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets configuration metadata about a specific audience export. This method
        /// can be used to understand an audience export after it has been created.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="name">
        /// Required. The audience export resource name.
        /// Format: `properties/{property}/audienceExports/{audience_export}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceExport> GetAudienceExportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAudienceExportAsync(new GetAudienceExportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets configuration metadata about a specific audience export. This method
        /// can be used to understand an audience export after it has been created.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="name">
        /// Required. The audience export resource name.
        /// Format: `properties/{property}/audienceExports/{audience_export}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceExport> GetAudienceExportAsync(string name, st::CancellationToken cancellationToken) =>
            GetAudienceExportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets configuration metadata about a specific audience export. This method
        /// can be used to understand an audience export after it has been created.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="name">
        /// Required. The audience export resource name.
        /// Format: `properties/{property}/audienceExports/{audience_export}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AudienceExport GetAudienceExport(AudienceExportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAudienceExport(new GetAudienceExportRequest
            {
                AudienceExportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets configuration metadata about a specific audience export. This method
        /// can be used to understand an audience export after it has been created.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="name">
        /// Required. The audience export resource name.
        /// Format: `properties/{property}/audienceExports/{audience_export}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceExport> GetAudienceExportAsync(AudienceExportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAudienceExportAsync(new GetAudienceExportRequest
            {
                AudienceExportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets configuration metadata about a specific audience export. This method
        /// can be used to understand an audience export after it has been created.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="name">
        /// Required. The audience export resource name.
        /// Format: `properties/{property}/audienceExports/{audience_export}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AudienceExport> GetAudienceExportAsync(AudienceExportName name, st::CancellationToken cancellationToken) =>
            GetAudienceExportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all audience exports for a property. This method can be used for you
        /// to find and reuse existing audience exports rather than creating
        /// unnecessary new audience exports. The same audience can have multiple
        /// audience exports that represent the export of users that were in an
        /// audience on different days.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AudienceExport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAudienceExportsResponse, AudienceExport> ListAudienceExports(ListAudienceExportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all audience exports for a property. This method can be used for you
        /// to find and reuse existing audience exports rather than creating
        /// unnecessary new audience exports. The same audience can have multiple
        /// audience exports that represent the export of users that were in an
        /// audience on different days.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AudienceExport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAudienceExportsResponse, AudienceExport> ListAudienceExportsAsync(ListAudienceExportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all audience exports for a property. This method can be used for you
        /// to find and reuse existing audience exports rather than creating
        /// unnecessary new audience exports. The same audience can have multiple
        /// audience exports that represent the export of users that were in an
        /// audience on different days.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="parent">
        /// Required. All audience exports for this property will be listed in the
        /// response. Format: `properties/{property}`
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
        /// <returns>A pageable sequence of <see cref="AudienceExport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAudienceExportsResponse, AudienceExport> ListAudienceExports(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAudienceExportsRequest request = new ListAudienceExportsRequest
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
            return ListAudienceExports(request, callSettings);
        }

        /// <summary>
        /// Lists all audience exports for a property. This method can be used for you
        /// to find and reuse existing audience exports rather than creating
        /// unnecessary new audience exports. The same audience can have multiple
        /// audience exports that represent the export of users that were in an
        /// audience on different days.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="parent">
        /// Required. All audience exports for this property will be listed in the
        /// response. Format: `properties/{property}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AudienceExport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAudienceExportsResponse, AudienceExport> ListAudienceExportsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAudienceExportsRequest request = new ListAudienceExportsRequest
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
            return ListAudienceExportsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all audience exports for a property. This method can be used for you
        /// to find and reuse existing audience exports rather than creating
        /// unnecessary new audience exports. The same audience can have multiple
        /// audience exports that represent the export of users that were in an
        /// audience on different days.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="parent">
        /// Required. All audience exports for this property will be listed in the
        /// response. Format: `properties/{property}`
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
        /// <returns>A pageable sequence of <see cref="AudienceExport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAudienceExportsResponse, AudienceExport> ListAudienceExports(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAudienceExportsRequest request = new ListAudienceExportsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAudienceExports(request, callSettings);
        }

        /// <summary>
        /// Lists all audience exports for a property. This method can be used for you
        /// to find and reuse existing audience exports rather than creating
        /// unnecessary new audience exports. The same audience can have multiple
        /// audience exports that represent the export of users that were in an
        /// audience on different days.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="parent">
        /// Required. All audience exports for this property will be listed in the
        /// response. Format: `properties/{property}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AudienceExport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAudienceExportsResponse, AudienceExport> ListAudienceExportsAsync(PropertyName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAudienceExportsRequest request = new ListAudienceExportsRequest
            {
                ParentAsPropertyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAudienceExportsAsync(request, callSettings);
        }
    }

    /// <summary>BetaAnalyticsData client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Google Analytics reporting data service.
    /// </remarks>
    public sealed partial class BetaAnalyticsDataClientImpl : BetaAnalyticsDataClient
    {
        private readonly gaxgrpc::ApiCall<RunReportRequest, RunReportResponse> _callRunReport;

        private readonly gaxgrpc::ApiCall<RunPivotReportRequest, RunPivotReportResponse> _callRunPivotReport;

        private readonly gaxgrpc::ApiCall<BatchRunReportsRequest, BatchRunReportsResponse> _callBatchRunReports;

        private readonly gaxgrpc::ApiCall<BatchRunPivotReportsRequest, BatchRunPivotReportsResponse> _callBatchRunPivotReports;

        private readonly gaxgrpc::ApiCall<GetMetadataRequest, Metadata> _callGetMetadata;

        private readonly gaxgrpc::ApiCall<RunRealtimeReportRequest, RunRealtimeReportResponse> _callRunRealtimeReport;

        private readonly gaxgrpc::ApiCall<CheckCompatibilityRequest, CheckCompatibilityResponse> _callCheckCompatibility;

        private readonly gaxgrpc::ApiCall<CreateAudienceExportRequest, lro::Operation> _callCreateAudienceExport;

        private readonly gaxgrpc::ApiCall<QueryAudienceExportRequest, QueryAudienceExportResponse> _callQueryAudienceExport;

        private readonly gaxgrpc::ApiCall<GetAudienceExportRequest, AudienceExport> _callGetAudienceExport;

        private readonly gaxgrpc::ApiCall<ListAudienceExportsRequest, ListAudienceExportsResponse> _callListAudienceExports;

        /// <summary>
        /// Constructs a client wrapper for the BetaAnalyticsData service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BetaAnalyticsDataSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BetaAnalyticsDataClientImpl(BetaAnalyticsData.BetaAnalyticsDataClient grpcClient, BetaAnalyticsDataSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BetaAnalyticsDataSettings effectiveSettings = settings ?? BetaAnalyticsDataSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateAudienceExportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAudienceExportOperationsSettings, logger);
            _callRunReport = clientHelper.BuildApiCall<RunReportRequest, RunReportResponse>("RunReport", grpcClient.RunReportAsync, grpcClient.RunReport, effectiveSettings.RunReportSettings).WithGoogleRequestParam("property", request => request.Property);
            Modify_ApiCall(ref _callRunReport);
            Modify_RunReportApiCall(ref _callRunReport);
            _callRunPivotReport = clientHelper.BuildApiCall<RunPivotReportRequest, RunPivotReportResponse>("RunPivotReport", grpcClient.RunPivotReportAsync, grpcClient.RunPivotReport, effectiveSettings.RunPivotReportSettings).WithGoogleRequestParam("property", request => request.Property);
            Modify_ApiCall(ref _callRunPivotReport);
            Modify_RunPivotReportApiCall(ref _callRunPivotReport);
            _callBatchRunReports = clientHelper.BuildApiCall<BatchRunReportsRequest, BatchRunReportsResponse>("BatchRunReports", grpcClient.BatchRunReportsAsync, grpcClient.BatchRunReports, effectiveSettings.BatchRunReportsSettings).WithGoogleRequestParam("property", request => request.Property);
            Modify_ApiCall(ref _callBatchRunReports);
            Modify_BatchRunReportsApiCall(ref _callBatchRunReports);
            _callBatchRunPivotReports = clientHelper.BuildApiCall<BatchRunPivotReportsRequest, BatchRunPivotReportsResponse>("BatchRunPivotReports", grpcClient.BatchRunPivotReportsAsync, grpcClient.BatchRunPivotReports, effectiveSettings.BatchRunPivotReportsSettings).WithGoogleRequestParam("property", request => request.Property);
            Modify_ApiCall(ref _callBatchRunPivotReports);
            Modify_BatchRunPivotReportsApiCall(ref _callBatchRunPivotReports);
            _callGetMetadata = clientHelper.BuildApiCall<GetMetadataRequest, Metadata>("GetMetadata", grpcClient.GetMetadataAsync, grpcClient.GetMetadata, effectiveSettings.GetMetadataSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMetadata);
            Modify_GetMetadataApiCall(ref _callGetMetadata);
            _callRunRealtimeReport = clientHelper.BuildApiCall<RunRealtimeReportRequest, RunRealtimeReportResponse>("RunRealtimeReport", grpcClient.RunRealtimeReportAsync, grpcClient.RunRealtimeReport, effectiveSettings.RunRealtimeReportSettings).WithGoogleRequestParam("property", request => request.Property);
            Modify_ApiCall(ref _callRunRealtimeReport);
            Modify_RunRealtimeReportApiCall(ref _callRunRealtimeReport);
            _callCheckCompatibility = clientHelper.BuildApiCall<CheckCompatibilityRequest, CheckCompatibilityResponse>("CheckCompatibility", grpcClient.CheckCompatibilityAsync, grpcClient.CheckCompatibility, effectiveSettings.CheckCompatibilitySettings).WithGoogleRequestParam("property", request => request.Property);
            Modify_ApiCall(ref _callCheckCompatibility);
            Modify_CheckCompatibilityApiCall(ref _callCheckCompatibility);
            _callCreateAudienceExport = clientHelper.BuildApiCall<CreateAudienceExportRequest, lro::Operation>("CreateAudienceExport", grpcClient.CreateAudienceExportAsync, grpcClient.CreateAudienceExport, effectiveSettings.CreateAudienceExportSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAudienceExport);
            Modify_CreateAudienceExportApiCall(ref _callCreateAudienceExport);
            _callQueryAudienceExport = clientHelper.BuildApiCall<QueryAudienceExportRequest, QueryAudienceExportResponse>("QueryAudienceExport", grpcClient.QueryAudienceExportAsync, grpcClient.QueryAudienceExport, effectiveSettings.QueryAudienceExportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callQueryAudienceExport);
            Modify_QueryAudienceExportApiCall(ref _callQueryAudienceExport);
            _callGetAudienceExport = clientHelper.BuildApiCall<GetAudienceExportRequest, AudienceExport>("GetAudienceExport", grpcClient.GetAudienceExportAsync, grpcClient.GetAudienceExport, effectiveSettings.GetAudienceExportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAudienceExport);
            Modify_GetAudienceExportApiCall(ref _callGetAudienceExport);
            _callListAudienceExports = clientHelper.BuildApiCall<ListAudienceExportsRequest, ListAudienceExportsResponse>("ListAudienceExports", grpcClient.ListAudienceExportsAsync, grpcClient.ListAudienceExports, effectiveSettings.ListAudienceExportsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAudienceExports);
            Modify_ListAudienceExportsApiCall(ref _callListAudienceExports);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RunReportApiCall(ref gaxgrpc::ApiCall<RunReportRequest, RunReportResponse> call);

        partial void Modify_RunPivotReportApiCall(ref gaxgrpc::ApiCall<RunPivotReportRequest, RunPivotReportResponse> call);

        partial void Modify_BatchRunReportsApiCall(ref gaxgrpc::ApiCall<BatchRunReportsRequest, BatchRunReportsResponse> call);

        partial void Modify_BatchRunPivotReportsApiCall(ref gaxgrpc::ApiCall<BatchRunPivotReportsRequest, BatchRunPivotReportsResponse> call);

        partial void Modify_GetMetadataApiCall(ref gaxgrpc::ApiCall<GetMetadataRequest, Metadata> call);

        partial void Modify_RunRealtimeReportApiCall(ref gaxgrpc::ApiCall<RunRealtimeReportRequest, RunRealtimeReportResponse> call);

        partial void Modify_CheckCompatibilityApiCall(ref gaxgrpc::ApiCall<CheckCompatibilityRequest, CheckCompatibilityResponse> call);

        partial void Modify_CreateAudienceExportApiCall(ref gaxgrpc::ApiCall<CreateAudienceExportRequest, lro::Operation> call);

        partial void Modify_QueryAudienceExportApiCall(ref gaxgrpc::ApiCall<QueryAudienceExportRequest, QueryAudienceExportResponse> call);

        partial void Modify_GetAudienceExportApiCall(ref gaxgrpc::ApiCall<GetAudienceExportRequest, AudienceExport> call);

        partial void Modify_ListAudienceExportsApiCall(ref gaxgrpc::ApiCall<ListAudienceExportsRequest, ListAudienceExportsResponse> call);

        partial void OnConstruction(BetaAnalyticsData.BetaAnalyticsDataClient grpcClient, BetaAnalyticsDataSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BetaAnalyticsData client</summary>
        public override BetaAnalyticsData.BetaAnalyticsDataClient GrpcClient { get; }

        partial void Modify_RunReportRequest(ref RunReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunPivotReportRequest(ref RunPivotReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchRunReportsRequest(ref BatchRunReportsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchRunPivotReportsRequest(ref BatchRunPivotReportsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMetadataRequest(ref GetMetadataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunRealtimeReportRequest(ref RunRealtimeReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CheckCompatibilityRequest(ref CheckCompatibilityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAudienceExportRequest(ref CreateAudienceExportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryAudienceExportRequest(ref QueryAudienceExportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAudienceExportRequest(ref GetAudienceExportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAudienceExportsRequest(ref ListAudienceExportsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// 
        /// For a guide to constructing requests &amp; understanding responses, see
        /// [Creating a
        /// Report](https://developers.google.com/analytics/devguides/reporting/data/v1/basics).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunReportResponse RunReport(RunReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunReportRequest(ref request, ref callSettings);
            return _callRunReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// 
        /// For a guide to constructing requests &amp; understanding responses, see
        /// [Creating a
        /// Report](https://developers.google.com/analytics/devguides/reporting/data/v1/basics).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunReportResponse> RunReportAsync(RunReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunReportRequest(ref request, ref callSettings);
            return _callRunReport.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunPivotReportResponse RunPivotReport(RunPivotReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunPivotReportRequest(ref request, ref callSettings);
            return _callRunPivotReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunPivotReportResponse> RunPivotReportAsync(RunPivotReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunPivotReportRequest(ref request, ref callSettings);
            return _callRunPivotReport.Async(request, callSettings);
        }

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Google Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchRunReportsResponse BatchRunReports(BatchRunReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunReportsRequest(ref request, ref callSettings);
            return _callBatchRunReports.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Google Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchRunReportsResponse> BatchRunReportsAsync(BatchRunReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunReportsRequest(ref request, ref callSettings);
            return _callBatchRunReports.Async(request, callSettings);
        }

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Google Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchRunPivotReportsResponse BatchRunPivotReports(BatchRunPivotReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunPivotReportsRequest(ref request, ref callSettings);
            return _callBatchRunPivotReports.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Google Analytics property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchRunPivotReportsResponse> BatchRunPivotReportsAsync(BatchRunPivotReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunPivotReportsRequest(ref request, ref callSettings);
            return _callBatchRunPivotReports.Async(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics property identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Metadata GetMetadata(GetMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetadataRequest(ref request, ref callSettings);
            return _callGetMetadata.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics property identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Metadata> GetMetadataAsync(GetMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetadataRequest(ref request, ref callSettings);
            return _callGetMetadata.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a customized report of realtime event data for your property.
        /// Events appear in realtime reports seconds after they have been sent to
        /// the Google Analytics. Realtime reports show events and usage data for the
        /// periods of time ranging from the present moment to 30 minutes ago (up to
        /// 60 minutes for Google Analytics 360 properties).
        /// 
        /// For a guide to constructing realtime requests &amp; understanding responses,
        /// see [Creating a Realtime
        /// Report](https://developers.google.com/analytics/devguides/reporting/data/v1/realtime-basics).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunRealtimeReportResponse RunRealtimeReport(RunRealtimeReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunRealtimeReportRequest(ref request, ref callSettings);
            return _callRunRealtimeReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a customized report of realtime event data for your property.
        /// Events appear in realtime reports seconds after they have been sent to
        /// the Google Analytics. Realtime reports show events and usage data for the
        /// periods of time ranging from the present moment to 30 minutes ago (up to
        /// 60 minutes for Google Analytics 360 properties).
        /// 
        /// For a guide to constructing realtime requests &amp; understanding responses,
        /// see [Creating a Realtime
        /// Report](https://developers.google.com/analytics/devguides/reporting/data/v1/realtime-basics).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunRealtimeReportResponse> RunRealtimeReportAsync(RunRealtimeReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunRealtimeReportRequest(ref request, ref callSettings);
            return _callRunRealtimeReport.Async(request, callSettings);
        }

        /// <summary>
        /// This compatibility method lists dimensions and metrics that can be added to
        /// a report request and maintain compatibility. This method fails if the
        /// request's dimensions and metrics are incompatible.
        /// 
        /// In Google Analytics, reports fail if they request incompatible dimensions
        /// and/or metrics; in that case, you will need to remove dimensions and/or
        /// metrics from the incompatible report until the report is compatible.
        /// 
        /// The Realtime and Core reports have different compatibility rules. This
        /// method checks compatibility for Core reports.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckCompatibilityResponse CheckCompatibility(CheckCompatibilityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckCompatibilityRequest(ref request, ref callSettings);
            return _callCheckCompatibility.Sync(request, callSettings);
        }

        /// <summary>
        /// This compatibility method lists dimensions and metrics that can be added to
        /// a report request and maintain compatibility. This method fails if the
        /// request's dimensions and metrics are incompatible.
        /// 
        /// In Google Analytics, reports fail if they request incompatible dimensions
        /// and/or metrics; in that case, you will need to remove dimensions and/or
        /// metrics from the incompatible report until the report is compatible.
        /// 
        /// The Realtime and Core reports have different compatibility rules. This
        /// method checks compatibility for Core reports.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckCompatibilityResponse> CheckCompatibilityAsync(CheckCompatibilityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckCompatibilityRequest(ref request, ref callSettings);
            return _callCheckCompatibility.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAudienceExport</c>.</summary>
        public override lro::OperationsClient CreateAudienceExportOperationsClient { get; }

        /// <summary>
        /// Creates an audience export for later retrieval. This method quickly returns
        /// the audience export's resource name and initiates a long running
        /// asynchronous request to form an audience export. To export the users in an
        /// audience export, first create the audience export through this method and
        /// then send the audience resource name to the `QueryAudienceExport` method.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// An audience export is a snapshot of the users currently in the audience at
        /// the time of audience export creation. Creating audience exports for one
        /// audience on different days will return different results as users enter and
        /// exit the audience.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572. Audience exports
        /// contain the users in each audience.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AudienceExport, AudienceExportMetadata> CreateAudienceExport(CreateAudienceExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAudienceExportRequest(ref request, ref callSettings);
            return new lro::Operation<AudienceExport, AudienceExportMetadata>(_callCreateAudienceExport.Sync(request, callSettings), CreateAudienceExportOperationsClient);
        }

        /// <summary>
        /// Creates an audience export for later retrieval. This method quickly returns
        /// the audience export's resource name and initiates a long running
        /// asynchronous request to form an audience export. To export the users in an
        /// audience export, first create the audience export through this method and
        /// then send the audience resource name to the `QueryAudienceExport` method.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// An audience export is a snapshot of the users currently in the audience at
        /// the time of audience export creation. Creating audience exports for one
        /// audience on different days will return different results as users enter and
        /// exit the audience.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572. Audience exports
        /// contain the users in each audience.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AudienceExport, AudienceExportMetadata>> CreateAudienceExportAsync(CreateAudienceExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAudienceExportRequest(ref request, ref callSettings);
            return new lro::Operation<AudienceExport, AudienceExportMetadata>(await _callCreateAudienceExport.Async(request, callSettings).ConfigureAwait(false), CreateAudienceExportOperationsClient);
        }

        /// <summary>
        /// Retrieves an audience export of users. After creating an audience, the
        /// users are not immediately available for exporting. First, a request to
        /// `CreateAudienceExport` is necessary to create an audience export of users,
        /// and then second, this method is used to retrieve the users in the audience
        /// export.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QueryAudienceExportResponse QueryAudienceExport(QueryAudienceExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryAudienceExportRequest(ref request, ref callSettings);
            return _callQueryAudienceExport.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves an audience export of users. After creating an audience, the
        /// users are not immediately available for exporting. First, a request to
        /// `CreateAudienceExport` is necessary to create an audience export of users,
        /// and then second, this method is used to retrieve the users in the audience
        /// export.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audiences in Google Analytics 4 allow you to segment your users in the ways
        /// that are important to your business. To learn more, see
        /// https://support.google.com/analytics/answer/9267572.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QueryAudienceExportResponse> QueryAudienceExportAsync(QueryAudienceExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryAudienceExportRequest(ref request, ref callSettings);
            return _callQueryAudienceExport.Async(request, callSettings);
        }

        /// <summary>
        /// Gets configuration metadata about a specific audience export. This method
        /// can be used to understand an audience export after it has been created.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AudienceExport GetAudienceExport(GetAudienceExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAudienceExportRequest(ref request, ref callSettings);
            return _callGetAudienceExport.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets configuration metadata about a specific audience export. This method
        /// can be used to understand an audience export after it has been created.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AudienceExport> GetAudienceExportAsync(GetAudienceExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAudienceExportRequest(ref request, ref callSettings);
            return _callGetAudienceExport.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all audience exports for a property. This method can be used for you
        /// to find and reuse existing audience exports rather than creating
        /// unnecessary new audience exports. The same audience can have multiple
        /// audience exports that represent the export of users that were in an
        /// audience on different days.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AudienceExport"/> resources.</returns>
        public override gax::PagedEnumerable<ListAudienceExportsResponse, AudienceExport> ListAudienceExports(ListAudienceExportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAudienceExportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAudienceExportsRequest, ListAudienceExportsResponse, AudienceExport>(_callListAudienceExports, request, callSettings);
        }

        /// <summary>
        /// Lists all audience exports for a property. This method can be used for you
        /// to find and reuse existing audience exports rather than creating
        /// unnecessary new audience exports. The same audience can have multiple
        /// audience exports that represent the export of users that were in an
        /// audience on different days.
        /// 
        /// See [Creating an Audience
        /// Export](https://developers.google.com/analytics/devguides/reporting/data/v1/audience-list-basics)
        /// for an introduction to Audience Exports with examples.
        /// 
        /// Audience Export APIs have some methods at alpha and other methods at beta
        /// stability. The intention is to advance methods to beta stability after some
        /// feedback and adoption. To give your feedback on this API, complete the
        /// [Google Analytics Audience Export API
        /// Feedback](https://forms.gle/EeA5u5LW6PEggtCEA) form.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AudienceExport"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAudienceExportsResponse, AudienceExport> ListAudienceExportsAsync(ListAudienceExportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAudienceExportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAudienceExportsRequest, ListAudienceExportsResponse, AudienceExport>(_callListAudienceExports, request, callSettings);
        }
    }

    public partial class ListAudienceExportsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAudienceExportsResponse : gaxgrpc::IPageResponse<AudienceExport>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AudienceExport> GetEnumerator() => AudienceExports.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BetaAnalyticsData
    {
        public partial class BetaAnalyticsDataClient
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
