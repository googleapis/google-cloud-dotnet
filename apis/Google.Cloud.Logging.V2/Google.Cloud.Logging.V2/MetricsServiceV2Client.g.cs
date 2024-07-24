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

namespace Google.Cloud.Logging.V2
{
    /// <summary>Settings for <see cref="MetricsServiceV2Client"/> instances.</summary>
    public sealed partial class MetricsServiceV2Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MetricsServiceV2Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MetricsServiceV2Settings"/>.</returns>
        public static MetricsServiceV2Settings GetDefault() => new MetricsServiceV2Settings();

        /// <summary>Constructs a new <see cref="MetricsServiceV2Settings"/> object with default settings.</summary>
        public MetricsServiceV2Settings()
        {
        }

        private MetricsServiceV2Settings(MetricsServiceV2Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListLogMetricsSettings = existing.ListLogMetricsSettings;
            GetLogMetricSettings = existing.GetLogMetricSettings;
            CreateLogMetricSettings = existing.CreateLogMetricSettings;
            UpdateLogMetricSettings = existing.UpdateLogMetricSettings;
            DeleteLogMetricSettings = existing.DeleteLogMetricSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MetricsServiceV2Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsServiceV2Client.ListLogMetrics</c> and <c>MetricsServiceV2Client.ListLogMetricsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLogMetricsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsServiceV2Client.GetLogMetric</c> and <c>MetricsServiceV2Client.GetLogMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLogMetricSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsServiceV2Client.CreateLogMetric</c> and <c>MetricsServiceV2Client.CreateLogMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateLogMetricSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsServiceV2Client.UpdateLogMetric</c> and <c>MetricsServiceV2Client.UpdateLogMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateLogMetricSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsServiceV2Client.DeleteLogMetric</c> and <c>MetricsServiceV2Client.DeleteLogMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteLogMetricSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MetricsServiceV2Settings"/> object.</returns>
        public MetricsServiceV2Settings Clone() => new MetricsServiceV2Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MetricsServiceV2Client"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class MetricsServiceV2ClientBuilder : gaxgrpc::ClientBuilderBase<MetricsServiceV2Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MetricsServiceV2Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MetricsServiceV2ClientBuilder() : base(MetricsServiceV2Client.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MetricsServiceV2Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MetricsServiceV2Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override MetricsServiceV2Client Build()
        {
            MetricsServiceV2Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MetricsServiceV2Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MetricsServiceV2Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MetricsServiceV2Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MetricsServiceV2Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MetricsServiceV2Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MetricsServiceV2Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MetricsServiceV2Client.ChannelPool;
    }

    /// <summary>MetricsServiceV2 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for configuring logs-based metrics.
    /// </remarks>
    public abstract partial class MetricsServiceV2Client
    {
        /// <summary>
        /// The default endpoint for the MetricsServiceV2 service, which is a host of "logging.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "logging.googleapis.com:443";

        /// <summary>The default MetricsServiceV2 scopes.</summary>
        /// <remarks>
        /// The default MetricsServiceV2 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// <item><description>https://www.googleapis.com/auth/logging.admin</description></item>
        /// <item><description>https://www.googleapis.com/auth/logging.read</description></item>
        /// <item><description>https://www.googleapis.com/auth/logging.write</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/logging.admin",
            "https://www.googleapis.com/auth/logging.read",
            "https://www.googleapis.com/auth/logging.write",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MetricsServiceV2.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MetricsServiceV2Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MetricsServiceV2ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MetricsServiceV2Client"/>.</returns>
        public static stt::Task<MetricsServiceV2Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MetricsServiceV2ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MetricsServiceV2Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MetricsServiceV2ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MetricsServiceV2Client"/>.</returns>
        public static MetricsServiceV2Client Create() => new MetricsServiceV2ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MetricsServiceV2Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MetricsServiceV2Settings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MetricsServiceV2Client"/>.</returns>
        internal static MetricsServiceV2Client Create(grpccore::CallInvoker callInvoker, MetricsServiceV2Settings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MetricsServiceV2.MetricsServiceV2Client grpcClient = new MetricsServiceV2.MetricsServiceV2Client(callInvoker);
            return new MetricsServiceV2ClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MetricsServiceV2 client</summary>
        public virtual MetricsServiceV2.MetricsServiceV2Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogMetric"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetrics(ListLogMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogMetric"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetricsAsync(ListLogMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project containing the metrics:
        /// 
        /// "projects/[PROJECT_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogMetric"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetrics(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogMetricsRequest request = new ListLogMetricsRequest
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
            return ListLogMetrics(request, callSettings);
        }

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project containing the metrics:
        /// 
        /// "projects/[PROJECT_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogMetric"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetricsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogMetricsRequest request = new ListLogMetricsRequest
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
            return ListLogMetricsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project containing the metrics:
        /// 
        /// "projects/[PROJECT_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogMetric"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetrics(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogMetricsRequest request = new ListLogMetricsRequest
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
            return ListLogMetrics(request, callSettings);
        }

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project containing the metrics:
        /// 
        /// "projects/[PROJECT_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogMetric"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetricsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogMetricsRequest request = new ListLogMetricsRequest
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
            return ListLogMetricsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric GetLogMetric(GetLogMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> GetLogMetricAsync(GetLogMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> GetLogMetricAsync(GetLogMetricRequest request, st::CancellationToken cancellationToken) =>
            GetLogMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the desired metric:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric GetLogMetric(string metricName, gaxgrpc::CallSettings callSettings = null) =>
            GetLogMetric(new GetLogMetricRequest
            {
                MetricName = gax::GaxPreconditions.CheckNotNullOrEmpty(metricName, nameof(metricName)),
            }, callSettings);

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the desired metric:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> GetLogMetricAsync(string metricName, gaxgrpc::CallSettings callSettings = null) =>
            GetLogMetricAsync(new GetLogMetricRequest
            {
                MetricName = gax::GaxPreconditions.CheckNotNullOrEmpty(metricName, nameof(metricName)),
            }, callSettings);

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the desired metric:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> GetLogMetricAsync(string metricName, st::CancellationToken cancellationToken) =>
            GetLogMetricAsync(metricName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the desired metric:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric GetLogMetric(LogMetricName metricName, gaxgrpc::CallSettings callSettings = null) =>
            GetLogMetric(new GetLogMetricRequest
            {
                MetricNameAsLogMetricName = gax::GaxPreconditions.CheckNotNull(metricName, nameof(metricName)),
            }, callSettings);

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the desired metric:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> GetLogMetricAsync(LogMetricName metricName, gaxgrpc::CallSettings callSettings = null) =>
            GetLogMetricAsync(new GetLogMetricRequest
            {
                MetricNameAsLogMetricName = gax::GaxPreconditions.CheckNotNull(metricName, nameof(metricName)),
            }, callSettings);

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the desired metric:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> GetLogMetricAsync(LogMetricName metricName, st::CancellationToken cancellationToken) =>
            GetLogMetricAsync(metricName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric CreateLogMetric(CreateLogMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> CreateLogMetricAsync(CreateLogMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> CreateLogMetricAsync(CreateLogMetricRequest request, st::CancellationToken cancellationToken) =>
            CreateLogMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project in which to create the metric:
        /// 
        /// "projects/[PROJECT_ID]"
        /// 
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// Required. The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric CreateLogMetric(string parent, LogMetric metric, gaxgrpc::CallSettings callSettings = null) =>
            CreateLogMetric(new CreateLogMetricRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
            }, callSettings);

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project in which to create the metric:
        /// 
        /// "projects/[PROJECT_ID]"
        /// 
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// Required. The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> CreateLogMetricAsync(string parent, LogMetric metric, gaxgrpc::CallSettings callSettings = null) =>
            CreateLogMetricAsync(new CreateLogMetricRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
            }, callSettings);

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project in which to create the metric:
        /// 
        /// "projects/[PROJECT_ID]"
        /// 
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// Required. The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> CreateLogMetricAsync(string parent, LogMetric metric, st::CancellationToken cancellationToken) =>
            CreateLogMetricAsync(parent, metric, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project in which to create the metric:
        /// 
        /// "projects/[PROJECT_ID]"
        /// 
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// Required. The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric CreateLogMetric(gagr::ProjectName parent, LogMetric metric, gaxgrpc::CallSettings callSettings = null) =>
            CreateLogMetric(new CreateLogMetricRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
            }, callSettings);

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project in which to create the metric:
        /// 
        /// "projects/[PROJECT_ID]"
        /// 
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// Required. The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> CreateLogMetricAsync(gagr::ProjectName parent, LogMetric metric, gaxgrpc::CallSettings callSettings = null) =>
            CreateLogMetricAsync(new CreateLogMetricRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
            }, callSettings);

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project in which to create the metric:
        /// 
        /// "projects/[PROJECT_ID]"
        /// 
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// Required. The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> CreateLogMetricAsync(gagr::ProjectName parent, LogMetric metric, st::CancellationToken cancellationToken) =>
            CreateLogMetricAsync(parent, metric, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric UpdateLogMetric(UpdateLogMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> UpdateLogMetricAsync(UpdateLogMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> UpdateLogMetricAsync(UpdateLogMetricRequest request, st::CancellationToken cancellationToken) =>
            UpdateLogMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to update:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// 
        /// The updated metric must be provided in the request and it's
        /// `name` field must be the same as `[METRIC_ID]` If the metric
        /// does not exist in `[PROJECT_ID]`, then a new metric is created.
        /// </param>
        /// <param name="metric">
        /// Required. The updated metric.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric UpdateLogMetric(string metricName, LogMetric metric, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLogMetric(new UpdateLogMetricRequest
            {
                MetricName = gax::GaxPreconditions.CheckNotNullOrEmpty(metricName, nameof(metricName)),
                Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
            }, callSettings);

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to update:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// 
        /// The updated metric must be provided in the request and it's
        /// `name` field must be the same as `[METRIC_ID]` If the metric
        /// does not exist in `[PROJECT_ID]`, then a new metric is created.
        /// </param>
        /// <param name="metric">
        /// Required. The updated metric.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> UpdateLogMetricAsync(string metricName, LogMetric metric, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLogMetricAsync(new UpdateLogMetricRequest
            {
                MetricName = gax::GaxPreconditions.CheckNotNullOrEmpty(metricName, nameof(metricName)),
                Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
            }, callSettings);

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to update:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// 
        /// The updated metric must be provided in the request and it's
        /// `name` field must be the same as `[METRIC_ID]` If the metric
        /// does not exist in `[PROJECT_ID]`, then a new metric is created.
        /// </param>
        /// <param name="metric">
        /// Required. The updated metric.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> UpdateLogMetricAsync(string metricName, LogMetric metric, st::CancellationToken cancellationToken) =>
            UpdateLogMetricAsync(metricName, metric, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to update:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// 
        /// The updated metric must be provided in the request and it's
        /// `name` field must be the same as `[METRIC_ID]` If the metric
        /// does not exist in `[PROJECT_ID]`, then a new metric is created.
        /// </param>
        /// <param name="metric">
        /// Required. The updated metric.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric UpdateLogMetric(LogMetricName metricName, LogMetric metric, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLogMetric(new UpdateLogMetricRequest
            {
                MetricNameAsLogMetricName = gax::GaxPreconditions.CheckNotNull(metricName, nameof(metricName)),
                Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
            }, callSettings);

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to update:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// 
        /// The updated metric must be provided in the request and it's
        /// `name` field must be the same as `[METRIC_ID]` If the metric
        /// does not exist in `[PROJECT_ID]`, then a new metric is created.
        /// </param>
        /// <param name="metric">
        /// Required. The updated metric.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> UpdateLogMetricAsync(LogMetricName metricName, LogMetric metric, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLogMetricAsync(new UpdateLogMetricRequest
            {
                MetricNameAsLogMetricName = gax::GaxPreconditions.CheckNotNull(metricName, nameof(metricName)),
                Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
            }, callSettings);

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to update:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// 
        /// The updated metric must be provided in the request and it's
        /// `name` field must be the same as `[METRIC_ID]` If the metric
        /// does not exist in `[PROJECT_ID]`, then a new metric is created.
        /// </param>
        /// <param name="metric">
        /// Required. The updated metric.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogMetric> UpdateLogMetricAsync(LogMetricName metricName, LogMetric metric, st::CancellationToken cancellationToken) =>
            UpdateLogMetricAsync(metricName, metric, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLogMetric(DeleteLogMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLogMetricAsync(DeleteLogMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLogMetricAsync(DeleteLogMetricRequest request, st::CancellationToken cancellationToken) =>
            DeleteLogMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to delete:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLogMetric(string metricName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLogMetric(new DeleteLogMetricRequest
            {
                MetricName = gax::GaxPreconditions.CheckNotNullOrEmpty(metricName, nameof(metricName)),
            }, callSettings);

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to delete:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLogMetricAsync(string metricName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLogMetricAsync(new DeleteLogMetricRequest
            {
                MetricName = gax::GaxPreconditions.CheckNotNullOrEmpty(metricName, nameof(metricName)),
            }, callSettings);

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to delete:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLogMetricAsync(string metricName, st::CancellationToken cancellationToken) =>
            DeleteLogMetricAsync(metricName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to delete:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLogMetric(LogMetricName metricName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLogMetric(new DeleteLogMetricRequest
            {
                MetricNameAsLogMetricName = gax::GaxPreconditions.CheckNotNull(metricName, nameof(metricName)),
            }, callSettings);

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to delete:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLogMetricAsync(LogMetricName metricName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLogMetricAsync(new DeleteLogMetricRequest
            {
                MetricNameAsLogMetricName = gax::GaxPreconditions.CheckNotNull(metricName, nameof(metricName)),
            }, callSettings);

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to delete:
        /// 
        /// "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLogMetricAsync(LogMetricName metricName, st::CancellationToken cancellationToken) =>
            DeleteLogMetricAsync(metricName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MetricsServiceV2 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for configuring logs-based metrics.
    /// </remarks>
    public sealed partial class MetricsServiceV2ClientImpl : MetricsServiceV2Client
    {
        private readonly gaxgrpc::ApiCall<ListLogMetricsRequest, ListLogMetricsResponse> _callListLogMetrics;

        private readonly gaxgrpc::ApiCall<GetLogMetricRequest, LogMetric> _callGetLogMetric;

        private readonly gaxgrpc::ApiCall<CreateLogMetricRequest, LogMetric> _callCreateLogMetric;

        private readonly gaxgrpc::ApiCall<UpdateLogMetricRequest, LogMetric> _callUpdateLogMetric;

        private readonly gaxgrpc::ApiCall<DeleteLogMetricRequest, wkt::Empty> _callDeleteLogMetric;

        /// <summary>
        /// Constructs a client wrapper for the MetricsServiceV2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MetricsServiceV2Settings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MetricsServiceV2ClientImpl(MetricsServiceV2.MetricsServiceV2Client grpcClient, MetricsServiceV2Settings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MetricsServiceV2Settings effectiveSettings = settings ?? MetricsServiceV2Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListLogMetrics = clientHelper.BuildApiCall<ListLogMetricsRequest, ListLogMetricsResponse>("ListLogMetrics", grpcClient.ListLogMetricsAsync, grpcClient.ListLogMetrics, effectiveSettings.ListLogMetricsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLogMetrics);
            Modify_ListLogMetricsApiCall(ref _callListLogMetrics);
            _callGetLogMetric = clientHelper.BuildApiCall<GetLogMetricRequest, LogMetric>("GetLogMetric", grpcClient.GetLogMetricAsync, grpcClient.GetLogMetric, effectiveSettings.GetLogMetricSettings).WithGoogleRequestParam("metric_name", request => request.MetricName);
            Modify_ApiCall(ref _callGetLogMetric);
            Modify_GetLogMetricApiCall(ref _callGetLogMetric);
            _callCreateLogMetric = clientHelper.BuildApiCall<CreateLogMetricRequest, LogMetric>("CreateLogMetric", grpcClient.CreateLogMetricAsync, grpcClient.CreateLogMetric, effectiveSettings.CreateLogMetricSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateLogMetric);
            Modify_CreateLogMetricApiCall(ref _callCreateLogMetric);
            _callUpdateLogMetric = clientHelper.BuildApiCall<UpdateLogMetricRequest, LogMetric>("UpdateLogMetric", grpcClient.UpdateLogMetricAsync, grpcClient.UpdateLogMetric, effectiveSettings.UpdateLogMetricSettings).WithGoogleRequestParam("metric_name", request => request.MetricName);
            Modify_ApiCall(ref _callUpdateLogMetric);
            Modify_UpdateLogMetricApiCall(ref _callUpdateLogMetric);
            _callDeleteLogMetric = clientHelper.BuildApiCall<DeleteLogMetricRequest, wkt::Empty>("DeleteLogMetric", grpcClient.DeleteLogMetricAsync, grpcClient.DeleteLogMetric, effectiveSettings.DeleteLogMetricSettings).WithGoogleRequestParam("metric_name", request => request.MetricName);
            Modify_ApiCall(ref _callDeleteLogMetric);
            Modify_DeleteLogMetricApiCall(ref _callDeleteLogMetric);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListLogMetricsApiCall(ref gaxgrpc::ApiCall<ListLogMetricsRequest, ListLogMetricsResponse> call);

        partial void Modify_GetLogMetricApiCall(ref gaxgrpc::ApiCall<GetLogMetricRequest, LogMetric> call);

        partial void Modify_CreateLogMetricApiCall(ref gaxgrpc::ApiCall<CreateLogMetricRequest, LogMetric> call);

        partial void Modify_UpdateLogMetricApiCall(ref gaxgrpc::ApiCall<UpdateLogMetricRequest, LogMetric> call);

        partial void Modify_DeleteLogMetricApiCall(ref gaxgrpc::ApiCall<DeleteLogMetricRequest, wkt::Empty> call);

        partial void OnConstruction(MetricsServiceV2.MetricsServiceV2Client grpcClient, MetricsServiceV2Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MetricsServiceV2 client</summary>
        public override MetricsServiceV2.MetricsServiceV2Client GrpcClient { get; }

        partial void Modify_ListLogMetricsRequest(ref ListLogMetricsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLogMetricRequest(ref GetLogMetricRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateLogMetricRequest(ref CreateLogMetricRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateLogMetricRequest(ref UpdateLogMetricRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteLogMetricRequest(ref DeleteLogMetricRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogMetric"/> resources.</returns>
        public override gax::PagedEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetrics(ListLogMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogMetricsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLogMetricsRequest, ListLogMetricsResponse, LogMetric>(_callListLogMetrics, request, callSettings);
        }

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogMetric"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetricsAsync(ListLogMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogMetricsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLogMetricsRequest, ListLogMetricsResponse, LogMetric>(_callListLogMetrics, request, callSettings);
        }

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogMetric GetLogMetric(GetLogMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLogMetricRequest(ref request, ref callSettings);
            return _callGetLogMetric.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogMetric> GetLogMetricAsync(GetLogMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLogMetricRequest(ref request, ref callSettings);
            return _callGetLogMetric.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogMetric CreateLogMetric(CreateLogMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLogMetricRequest(ref request, ref callSettings);
            return _callCreateLogMetric.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogMetric> CreateLogMetricAsync(CreateLogMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLogMetricRequest(ref request, ref callSettings);
            return _callCreateLogMetric.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogMetric UpdateLogMetric(UpdateLogMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLogMetricRequest(ref request, ref callSettings);
            return _callUpdateLogMetric.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogMetric> UpdateLogMetricAsync(UpdateLogMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLogMetricRequest(ref request, ref callSettings);
            return _callUpdateLogMetric.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteLogMetric(DeleteLogMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLogMetricRequest(ref request, ref callSettings);
            _callDeleteLogMetric.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteLogMetricAsync(DeleteLogMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLogMetricRequest(ref request, ref callSettings);
            return _callDeleteLogMetric.Async(request, callSettings);
        }
    }

    public partial class ListLogMetricsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLogMetricsResponse : gaxgrpc::IPageResponse<LogMetric>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LogMetric> GetEnumerator() => Metrics.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
