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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

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
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMetadataSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown)));

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
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CheckCompatibilitySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown)));

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
            return BetaAnalyticsDataClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<BetaAnalyticsDataClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BetaAnalyticsDataClient.Create(callInvoker, Settings, Logger);
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
        internal static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BetaAnalyticsData.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

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
        /// GA4 Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRunReportsResponse BatchRunReports(BatchRunReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// GA4 Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRunReportsResponse> BatchRunReportsAsync(BatchRunReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// GA4 Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRunReportsResponse> BatchRunReportsAsync(BatchRunReportsRequest request, st::CancellationToken cancellationToken) =>
            BatchRunReportsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// GA4 Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRunPivotReportsResponse BatchRunPivotReports(BatchRunPivotReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// GA4 Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRunPivotReportsResponse> BatchRunPivotReportsAsync(BatchRunPivotReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// GA4 Property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRunPivotReportsResponse> BatchRunPivotReportsAsync(BatchRunPivotReportsRequest request, st::CancellationToken cancellationToken) =>
            BatchRunPivotReportsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics GA4 Property Identifier is specified in the request, and
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
        /// Analytics GA4 Property Identifier is specified in the request, and
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
        /// Analytics GA4 Property Identifier is specified in the request, and
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
        /// Analytics GA4 Property Identifier is specified in the request, and
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
        /// Google Analytics GA4 Property identifier. To learn more, see [where to find
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
        /// Analytics GA4 Property Identifier is specified in the request, and
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
        /// Google Analytics GA4 Property identifier. To learn more, see [where to find
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
        /// Analytics GA4 Property Identifier is specified in the request, and
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
        /// Google Analytics GA4 Property identifier. To learn more, see [where to find
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
        /// Analytics GA4 Property Identifier is specified in the request, and
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
        /// Google Analytics GA4 Property identifier. To learn more, see [where to find
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
        /// Analytics GA4 Property Identifier is specified in the request, and
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
        /// Google Analytics GA4 Property identifier. To learn more, see [where to find
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
        /// Analytics GA4 Property Identifier is specified in the request, and
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
        /// Google Analytics GA4 Property identifier. To learn more, see [where to find
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
        /// The Google Analytics Realtime API returns a customized report of realtime
        /// event data for your property. These reports show events and usage from the
        /// last 30 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunRealtimeReportResponse RunRealtimeReport(RunRealtimeReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// The Google Analytics Realtime API returns a customized report of realtime
        /// event data for your property. These reports show events and usage from the
        /// last 30 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunRealtimeReportResponse> RunRealtimeReportAsync(RunRealtimeReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// The Google Analytics Realtime API returns a customized report of realtime
        /// event data for your property. These reports show events and usage from the
        /// last 30 minutes.
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
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
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

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
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
        /// GA4 Property.
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
        /// GA4 Property.
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
        /// GA4 Property.
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
        /// GA4 Property.
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
        /// Analytics GA4 Property Identifier is specified in the request, and
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
        /// Analytics GA4 Property Identifier is specified in the request, and
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
        /// The Google Analytics Realtime API returns a customized report of realtime
        /// event data for your property. These reports show events and usage from the
        /// last 30 minutes.
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
        /// The Google Analytics Realtime API returns a customized report of realtime
        /// event data for your property. These reports show events and usage from the
        /// last 30 minutes.
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
    }
}
