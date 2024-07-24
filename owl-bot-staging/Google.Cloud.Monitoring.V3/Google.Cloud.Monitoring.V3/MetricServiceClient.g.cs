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
using ga = Google.Api;
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

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>Settings for <see cref="MetricServiceClient"/> instances.</summary>
    public sealed partial class MetricServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MetricServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MetricServiceSettings"/>.</returns>
        public static MetricServiceSettings GetDefault() => new MetricServiceSettings();

        /// <summary>Constructs a new <see cref="MetricServiceSettings"/> object with default settings.</summary>
        public MetricServiceSettings()
        {
        }

        private MetricServiceSettings(MetricServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListMonitoredResourceDescriptorsSettings = existing.ListMonitoredResourceDescriptorsSettings;
            GetMonitoredResourceDescriptorSettings = existing.GetMonitoredResourceDescriptorSettings;
            ListMetricDescriptorsSettings = existing.ListMetricDescriptorsSettings;
            GetMetricDescriptorSettings = existing.GetMetricDescriptorSettings;
            CreateMetricDescriptorSettings = existing.CreateMetricDescriptorSettings;
            DeleteMetricDescriptorSettings = existing.DeleteMetricDescriptorSettings;
            ListTimeSeriesSettings = existing.ListTimeSeriesSettings;
            CreateTimeSeriesSettings = existing.CreateTimeSeriesSettings;
            CreateServiceTimeSeriesSettings = existing.CreateServiceTimeSeriesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MetricServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.ListMonitoredResourceDescriptors</c> and
        /// <c>MetricServiceClient.ListMonitoredResourceDescriptorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMonitoredResourceDescriptorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.GetMonitoredResourceDescriptor</c> and
        /// <c>MetricServiceClient.GetMonitoredResourceDescriptorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMonitoredResourceDescriptorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.ListMetricDescriptors</c> and <c>MetricServiceClient.ListMetricDescriptorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMetricDescriptorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.GetMetricDescriptor</c> and <c>MetricServiceClient.GetMetricDescriptorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMetricDescriptorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.CreateMetricDescriptor</c> and <c>MetricServiceClient.CreateMetricDescriptorAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 12 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMetricDescriptorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(12000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.DeleteMetricDescriptor</c> and <c>MetricServiceClient.DeleteMetricDescriptorAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMetricDescriptorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.ListTimeSeries</c> and <c>MetricServiceClient.ListTimeSeriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 90 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTimeSeriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(90000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.CreateTimeSeries</c> and <c>MetricServiceClient.CreateTimeSeriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 12 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTimeSeriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(12000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.CreateServiceTimeSeries</c> and <c>MetricServiceClient.CreateServiceTimeSeriesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceTimeSeriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MetricServiceSettings"/> object.</returns>
        public MetricServiceSettings Clone() => new MetricServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MetricServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class MetricServiceClientBuilder : gaxgrpc::ClientBuilderBase<MetricServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MetricServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MetricServiceClientBuilder() : base(MetricServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MetricServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MetricServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MetricServiceClient Build()
        {
            MetricServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MetricServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MetricServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MetricServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MetricServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MetricServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MetricServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MetricServiceClient.ChannelPool;
    }

    /// <summary>MetricService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages metric descriptors, monitored resource descriptors, and
    /// time series data.
    /// </remarks>
    public abstract partial class MetricServiceClient
    {
        /// <summary>
        /// The default endpoint for the MetricService service, which is a host of "monitoring.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "monitoring.googleapis.com:443";

        /// <summary>The default MetricService scopes.</summary>
        /// <remarks>
        /// The default MetricService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring.read</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring.write</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
            "https://www.googleapis.com/auth/monitoring.write",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MetricService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MetricServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MetricServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MetricServiceClient"/>.</returns>
        public static stt::Task<MetricServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MetricServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MetricServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MetricServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MetricServiceClient"/>.</returns>
        public static MetricServiceClient Create() => new MetricServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MetricServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MetricServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MetricServiceClient"/>.</returns>
        internal static MetricServiceClient Create(grpccore::CallInvoker callInvoker, MetricServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MetricService.MetricServiceClient grpcClient = new MetricService.MetricServiceClient(callInvoker);
            return new MetricServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MetricService client</summary>
        public virtual MetricService.MetricServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists monitored resource descriptors that match a filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(ListMonitoredResourceDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists monitored resource descriptors that match a filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(ListMonitoredResourceDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists monitored resource descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest
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
            return ListMonitoredResourceDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest
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
            return ListMonitoredResourceDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(gagr::ProjectName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMonitoredResourceDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(gagr::ProjectName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMonitoredResourceDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(gagr::OrganizationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMonitoredResourceDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(gagr::OrganizationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMonitoredResourceDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(gagr::FolderName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMonitoredResourceDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(gagr::FolderName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMonitoredResourceDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(gax::IResourceName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMonitoredResourceDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(gax::IResourceName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMonitoredResourceDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a single monitored resource descriptor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::MonitoredResourceDescriptor GetMonitoredResourceDescriptor(GetMonitoredResourceDescriptorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single monitored resource descriptor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(GetMonitoredResourceDescriptorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single monitored resource descriptor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(GetMonitoredResourceDescriptorRequest request, st::CancellationToken cancellationToken) =>
            GetMonitoredResourceDescriptorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single monitored resource descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The monitored resource descriptor to get.  The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/monitoredResourceDescriptors/[RESOURCE_TYPE]
        /// 
        /// The `[RESOURCE_TYPE]` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::MonitoredResourceDescriptor GetMonitoredResourceDescriptor(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMonitoredResourceDescriptor(new GetMonitoredResourceDescriptorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single monitored resource descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The monitored resource descriptor to get.  The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/monitoredResourceDescriptors/[RESOURCE_TYPE]
        /// 
        /// The `[RESOURCE_TYPE]` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMonitoredResourceDescriptorAsync(new GetMonitoredResourceDescriptorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single monitored resource descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The monitored resource descriptor to get.  The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/monitoredResourceDescriptors/[RESOURCE_TYPE]
        /// 
        /// The `[RESOURCE_TYPE]` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(string name, st::CancellationToken cancellationToken) =>
            GetMonitoredResourceDescriptorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single monitored resource descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The monitored resource descriptor to get.  The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/monitoredResourceDescriptors/[RESOURCE_TYPE]
        /// 
        /// The `[RESOURCE_TYPE]` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::MonitoredResourceDescriptor GetMonitoredResourceDescriptor(MonitoredResourceDescriptorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMonitoredResourceDescriptor(new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single monitored resource descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The monitored resource descriptor to get.  The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/monitoredResourceDescriptors/[RESOURCE_TYPE]
        /// 
        /// The `[RESOURCE_TYPE]` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(MonitoredResourceDescriptorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMonitoredResourceDescriptorAsync(new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single monitored resource descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The monitored resource descriptor to get.  The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/monitoredResourceDescriptors/[RESOURCE_TYPE]
        /// 
        /// The `[RESOURCE_TYPE]` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(MonitoredResourceDescriptorName name, st::CancellationToken cancellationToken) =>
            GetMonitoredResourceDescriptorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single monitored resource descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The monitored resource descriptor to get.  The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/monitoredResourceDescriptors/[RESOURCE_TYPE]
        /// 
        /// The `[RESOURCE_TYPE]` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::MonitoredResourceDescriptor GetMonitoredResourceDescriptor(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMonitoredResourceDescriptor(new GetMonitoredResourceDescriptorRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single monitored resource descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The monitored resource descriptor to get.  The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/monitoredResourceDescriptors/[RESOURCE_TYPE]
        /// 
        /// The `[RESOURCE_TYPE]` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMonitoredResourceDescriptorAsync(new GetMonitoredResourceDescriptorRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single monitored resource descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The monitored resource descriptor to get.  The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/monitoredResourceDescriptors/[RESOURCE_TYPE]
        /// 
        /// The `[RESOURCE_TYPE]` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            GetMonitoredResourceDescriptorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists metric descriptors that match a filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ga::MetricDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptors(ListMetricDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists metric descriptors that match a filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ga::MetricDescriptor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptorsAsync(ListMetricDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists metric descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="ga::MetricDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptors(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMetricDescriptorsRequest request = new ListMetricDescriptorsRequest
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
            return ListMetricDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists metric descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="ga::MetricDescriptor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptorsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMetricDescriptorsRequest request = new ListMetricDescriptorsRequest
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
            return ListMetricDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists metric descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="ga::MetricDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptors(gagr::ProjectName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMetricDescriptorsRequest request = new ListMetricDescriptorsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMetricDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists metric descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="ga::MetricDescriptor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptorsAsync(gagr::ProjectName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMetricDescriptorsRequest request = new ListMetricDescriptorsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMetricDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists metric descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="ga::MetricDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptors(gagr::OrganizationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMetricDescriptorsRequest request = new ListMetricDescriptorsRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMetricDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists metric descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="ga::MetricDescriptor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptorsAsync(gagr::OrganizationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMetricDescriptorsRequest request = new ListMetricDescriptorsRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMetricDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists metric descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="ga::MetricDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptors(gagr::FolderName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMetricDescriptorsRequest request = new ListMetricDescriptorsRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMetricDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists metric descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="ga::MetricDescriptor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptorsAsync(gagr::FolderName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMetricDescriptorsRequest request = new ListMetricDescriptorsRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMetricDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists metric descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="ga::MetricDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptors(gax::IResourceName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMetricDescriptorsRequest request = new ListMetricDescriptorsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMetricDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists metric descriptors that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="ga::MetricDescriptor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptorsAsync(gax::IResourceName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMetricDescriptorsRequest request = new ListMetricDescriptorsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMetricDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a single metric descriptor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::MetricDescriptor GetMetricDescriptor(GetMetricDescriptorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single metric descriptor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(GetMetricDescriptorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single metric descriptor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(GetMetricDescriptorRequest request, st::CancellationToken cancellationToken) =>
            GetMetricDescriptorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single metric descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example value of `[METRIC_ID]` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::MetricDescriptor GetMetricDescriptor(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetricDescriptor(new GetMetricDescriptorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single metric descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example value of `[METRIC_ID]` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetricDescriptorAsync(new GetMetricDescriptorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single metric descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example value of `[METRIC_ID]` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(string name, st::CancellationToken cancellationToken) =>
            GetMetricDescriptorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single metric descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example value of `[METRIC_ID]` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::MetricDescriptor GetMetricDescriptor(MetricDescriptorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetricDescriptor(new GetMetricDescriptorRequest
            {
                MetricDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single metric descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example value of `[METRIC_ID]` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(MetricDescriptorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetricDescriptorAsync(new GetMetricDescriptorRequest
            {
                MetricDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single metric descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example value of `[METRIC_ID]` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(MetricDescriptorName name, st::CancellationToken cancellationToken) =>
            GetMetricDescriptorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single metric descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example value of `[METRIC_ID]` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::MetricDescriptor GetMetricDescriptor(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetricDescriptor(new GetMetricDescriptorRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single metric descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example value of `[METRIC_ID]` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetricDescriptorAsync(new GetMetricDescriptorRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single metric descriptor.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example value of `[METRIC_ID]` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            GetMetricDescriptorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::MetricDescriptor CreateMetricDescriptor(CreateMetricDescriptorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(CreateMetricDescriptorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(CreateMetricDescriptorRequest request, st::CancellationToken cancellationToken) =>
            CreateMetricDescriptorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::MetricDescriptor CreateMetricDescriptor(string name, ga::MetricDescriptor metricDescriptor, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetricDescriptor(new CreateMetricDescriptorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                MetricDescriptor = gax::GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
            }, callSettings);

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(string name, ga::MetricDescriptor metricDescriptor, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetricDescriptorAsync(new CreateMetricDescriptorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                MetricDescriptor = gax::GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
            }, callSettings);

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(string name, ga::MetricDescriptor metricDescriptor, st::CancellationToken cancellationToken) =>
            CreateMetricDescriptorAsync(name, metricDescriptor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::MetricDescriptor CreateMetricDescriptor(gagr::ProjectName name, ga::MetricDescriptor metricDescriptor, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetricDescriptor(new CreateMetricDescriptorRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                MetricDescriptor = gax::GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
            }, callSettings);

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(gagr::ProjectName name, ga::MetricDescriptor metricDescriptor, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetricDescriptorAsync(new CreateMetricDescriptorRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                MetricDescriptor = gax::GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
            }, callSettings);

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(gagr::ProjectName name, ga::MetricDescriptor metricDescriptor, st::CancellationToken cancellationToken) =>
            CreateMetricDescriptorAsync(name, metricDescriptor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::MetricDescriptor CreateMetricDescriptor(gagr::OrganizationName name, ga::MetricDescriptor metricDescriptor, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetricDescriptor(new CreateMetricDescriptorRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                MetricDescriptor = gax::GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
            }, callSettings);

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(gagr::OrganizationName name, ga::MetricDescriptor metricDescriptor, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetricDescriptorAsync(new CreateMetricDescriptorRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                MetricDescriptor = gax::GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
            }, callSettings);

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(gagr::OrganizationName name, ga::MetricDescriptor metricDescriptor, st::CancellationToken cancellationToken) =>
            CreateMetricDescriptorAsync(name, metricDescriptor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::MetricDescriptor CreateMetricDescriptor(gagr::FolderName name, ga::MetricDescriptor metricDescriptor, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetricDescriptor(new CreateMetricDescriptorRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                MetricDescriptor = gax::GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
            }, callSettings);

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(gagr::FolderName name, ga::MetricDescriptor metricDescriptor, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetricDescriptorAsync(new CreateMetricDescriptorRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                MetricDescriptor = gax::GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
            }, callSettings);

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(gagr::FolderName name, ga::MetricDescriptor metricDescriptor, st::CancellationToken cancellationToken) =>
            CreateMetricDescriptorAsync(name, metricDescriptor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::MetricDescriptor CreateMetricDescriptor(gax::IResourceName name, ga::MetricDescriptor metricDescriptor, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetricDescriptor(new CreateMetricDescriptorRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                MetricDescriptor = gax::GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
            }, callSettings);

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(gax::IResourceName name, ga::MetricDescriptor metricDescriptor, gaxgrpc::CallSettings callSettings = null) =>
            CreateMetricDescriptorAsync(new CreateMetricDescriptorRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                MetricDescriptor = gax::GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
            }, callSettings);

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 4
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="metricDescriptor">
        /// Required. The new [custom
        /// metric](https://cloud.google.com/monitoring/custom-metrics) descriptor.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(gax::IResourceName name, ga::MetricDescriptor metricDescriptor, st::CancellationToken cancellationToken) =>
            CreateMetricDescriptorAsync(name, metricDescriptor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics) can be
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMetricDescriptor(DeleteMetricDescriptorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics) can be
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMetricDescriptorAsync(DeleteMetricDescriptorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics) can be
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMetricDescriptorAsync(DeleteMetricDescriptorRequest request, st::CancellationToken cancellationToken) =>
            DeleteMetricDescriptorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics) can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example of `[METRIC_ID]` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMetricDescriptor(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMetricDescriptor(new DeleteMetricDescriptorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics) can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example of `[METRIC_ID]` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMetricDescriptorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMetricDescriptorAsync(new DeleteMetricDescriptorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics) can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example of `[METRIC_ID]` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMetricDescriptorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMetricDescriptorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics) can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example of `[METRIC_ID]` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMetricDescriptor(MetricDescriptorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMetricDescriptor(new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics) can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example of `[METRIC_ID]` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMetricDescriptorAsync(MetricDescriptorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMetricDescriptorAsync(new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics) can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example of `[METRIC_ID]` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMetricDescriptorAsync(MetricDescriptorName name, st::CancellationToken cancellationToken) =>
            DeleteMetricDescriptorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics) can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example of `[METRIC_ID]` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMetricDescriptor(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMetricDescriptor(new DeleteMetricDescriptorRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics) can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example of `[METRIC_ID]` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMetricDescriptorAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMetricDescriptorAsync(new DeleteMetricDescriptorRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics) can be
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The metric descriptor on which to execute the request. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/metricDescriptors/[METRIC_ID]
        /// 
        /// An example of `[METRIC_ID]` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMetricDescriptorAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            DeleteMetricDescriptorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists time series that match a filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TimeSeries"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeries(ListTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists time series that match a filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TimeSeries"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeriesAsync(ListTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists time series that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name),
        /// organization or folder on which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// organizations/[ORGANIZATION_ID]
        /// folders/[FOLDER_ID]
        /// </param>
        /// <param name="filter">
        /// Required. A [monitoring
        /// filter](https://cloud.google.com/monitoring/api/v3/filters) that specifies
        /// which time series should be returned.  The filter must specify a single
        /// metric type, and can additionally specify metric labels and other
        /// information. For example:
        /// 
        /// metric.type = "compute.googleapis.com/instance/cpu/usage_time" AND
        /// metric.labels.instance_name = "my-instance-name"
        /// </param>
        /// <param name="interval">
        /// Required. The time interval for which results should be returned. Only time
        /// series that contain data points in the specified interval are included in
        /// the response.
        /// </param>
        /// <param name="view">
        /// Required. Specifies which information is returned about the time series.
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
        /// <returns>A pageable sequence of <see cref="TimeSeries"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeries(string name, string filter, TimeInterval interval, ListTimeSeriesRequest.Types.TimeSeriesView view, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTimeSeriesRequest request = new ListTimeSeriesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                Interval = gax::GaxPreconditions.CheckNotNull(interval, nameof(interval)),
                View = view,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTimeSeries(request, callSettings);
        }

        /// <summary>
        /// Lists time series that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name),
        /// organization or folder on which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// organizations/[ORGANIZATION_ID]
        /// folders/[FOLDER_ID]
        /// </param>
        /// <param name="filter">
        /// Required. A [monitoring
        /// filter](https://cloud.google.com/monitoring/api/v3/filters) that specifies
        /// which time series should be returned.  The filter must specify a single
        /// metric type, and can additionally specify metric labels and other
        /// information. For example:
        /// 
        /// metric.type = "compute.googleapis.com/instance/cpu/usage_time" AND
        /// metric.labels.instance_name = "my-instance-name"
        /// </param>
        /// <param name="interval">
        /// Required. The time interval for which results should be returned. Only time
        /// series that contain data points in the specified interval are included in
        /// the response.
        /// </param>
        /// <param name="view">
        /// Required. Specifies which information is returned about the time series.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TimeSeries"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeriesAsync(string name, string filter, TimeInterval interval, ListTimeSeriesRequest.Types.TimeSeriesView view, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTimeSeriesRequest request = new ListTimeSeriesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                Interval = gax::GaxPreconditions.CheckNotNull(interval, nameof(interval)),
                View = view,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTimeSeriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists time series that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name),
        /// organization or folder on which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// organizations/[ORGANIZATION_ID]
        /// folders/[FOLDER_ID]
        /// </param>
        /// <param name="filter">
        /// Required. A [monitoring
        /// filter](https://cloud.google.com/monitoring/api/v3/filters) that specifies
        /// which time series should be returned.  The filter must specify a single
        /// metric type, and can additionally specify metric labels and other
        /// information. For example:
        /// 
        /// metric.type = "compute.googleapis.com/instance/cpu/usage_time" AND
        /// metric.labels.instance_name = "my-instance-name"
        /// </param>
        /// <param name="interval">
        /// Required. The time interval for which results should be returned. Only time
        /// series that contain data points in the specified interval are included in
        /// the response.
        /// </param>
        /// <param name="view">
        /// Required. Specifies which information is returned about the time series.
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
        /// <returns>A pageable sequence of <see cref="TimeSeries"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeries(gagr::ProjectName name, string filter, TimeInterval interval, ListTimeSeriesRequest.Types.TimeSeriesView view, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTimeSeriesRequest request = new ListTimeSeriesRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                Interval = gax::GaxPreconditions.CheckNotNull(interval, nameof(interval)),
                View = view,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTimeSeries(request, callSettings);
        }

        /// <summary>
        /// Lists time series that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name),
        /// organization or folder on which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// organizations/[ORGANIZATION_ID]
        /// folders/[FOLDER_ID]
        /// </param>
        /// <param name="filter">
        /// Required. A [monitoring
        /// filter](https://cloud.google.com/monitoring/api/v3/filters) that specifies
        /// which time series should be returned.  The filter must specify a single
        /// metric type, and can additionally specify metric labels and other
        /// information. For example:
        /// 
        /// metric.type = "compute.googleapis.com/instance/cpu/usage_time" AND
        /// metric.labels.instance_name = "my-instance-name"
        /// </param>
        /// <param name="interval">
        /// Required. The time interval for which results should be returned. Only time
        /// series that contain data points in the specified interval are included in
        /// the response.
        /// </param>
        /// <param name="view">
        /// Required. Specifies which information is returned about the time series.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TimeSeries"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeriesAsync(gagr::ProjectName name, string filter, TimeInterval interval, ListTimeSeriesRequest.Types.TimeSeriesView view, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTimeSeriesRequest request = new ListTimeSeriesRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                Interval = gax::GaxPreconditions.CheckNotNull(interval, nameof(interval)),
                View = view,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTimeSeriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists time series that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name),
        /// organization or folder on which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// organizations/[ORGANIZATION_ID]
        /// folders/[FOLDER_ID]
        /// </param>
        /// <param name="filter">
        /// Required. A [monitoring
        /// filter](https://cloud.google.com/monitoring/api/v3/filters) that specifies
        /// which time series should be returned.  The filter must specify a single
        /// metric type, and can additionally specify metric labels and other
        /// information. For example:
        /// 
        /// metric.type = "compute.googleapis.com/instance/cpu/usage_time" AND
        /// metric.labels.instance_name = "my-instance-name"
        /// </param>
        /// <param name="interval">
        /// Required. The time interval for which results should be returned. Only time
        /// series that contain data points in the specified interval are included in
        /// the response.
        /// </param>
        /// <param name="view">
        /// Required. Specifies which information is returned about the time series.
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
        /// <returns>A pageable sequence of <see cref="TimeSeries"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeries(gagr::OrganizationName name, string filter, TimeInterval interval, ListTimeSeriesRequest.Types.TimeSeriesView view, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTimeSeriesRequest request = new ListTimeSeriesRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                Interval = gax::GaxPreconditions.CheckNotNull(interval, nameof(interval)),
                View = view,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTimeSeries(request, callSettings);
        }

        /// <summary>
        /// Lists time series that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name),
        /// organization or folder on which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// organizations/[ORGANIZATION_ID]
        /// folders/[FOLDER_ID]
        /// </param>
        /// <param name="filter">
        /// Required. A [monitoring
        /// filter](https://cloud.google.com/monitoring/api/v3/filters) that specifies
        /// which time series should be returned.  The filter must specify a single
        /// metric type, and can additionally specify metric labels and other
        /// information. For example:
        /// 
        /// metric.type = "compute.googleapis.com/instance/cpu/usage_time" AND
        /// metric.labels.instance_name = "my-instance-name"
        /// </param>
        /// <param name="interval">
        /// Required. The time interval for which results should be returned. Only time
        /// series that contain data points in the specified interval are included in
        /// the response.
        /// </param>
        /// <param name="view">
        /// Required. Specifies which information is returned about the time series.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TimeSeries"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeriesAsync(gagr::OrganizationName name, string filter, TimeInterval interval, ListTimeSeriesRequest.Types.TimeSeriesView view, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTimeSeriesRequest request = new ListTimeSeriesRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                Interval = gax::GaxPreconditions.CheckNotNull(interval, nameof(interval)),
                View = view,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTimeSeriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists time series that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name),
        /// organization or folder on which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// organizations/[ORGANIZATION_ID]
        /// folders/[FOLDER_ID]
        /// </param>
        /// <param name="filter">
        /// Required. A [monitoring
        /// filter](https://cloud.google.com/monitoring/api/v3/filters) that specifies
        /// which time series should be returned.  The filter must specify a single
        /// metric type, and can additionally specify metric labels and other
        /// information. For example:
        /// 
        /// metric.type = "compute.googleapis.com/instance/cpu/usage_time" AND
        /// metric.labels.instance_name = "my-instance-name"
        /// </param>
        /// <param name="interval">
        /// Required. The time interval for which results should be returned. Only time
        /// series that contain data points in the specified interval are included in
        /// the response.
        /// </param>
        /// <param name="view">
        /// Required. Specifies which information is returned about the time series.
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
        /// <returns>A pageable sequence of <see cref="TimeSeries"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeries(gagr::FolderName name, string filter, TimeInterval interval, ListTimeSeriesRequest.Types.TimeSeriesView view, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTimeSeriesRequest request = new ListTimeSeriesRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                Interval = gax::GaxPreconditions.CheckNotNull(interval, nameof(interval)),
                View = view,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTimeSeries(request, callSettings);
        }

        /// <summary>
        /// Lists time series that match a filter.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name),
        /// organization or folder on which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// organizations/[ORGANIZATION_ID]
        /// folders/[FOLDER_ID]
        /// </param>
        /// <param name="filter">
        /// Required. A [monitoring
        /// filter](https://cloud.google.com/monitoring/api/v3/filters) that specifies
        /// which time series should be returned.  The filter must specify a single
        /// metric type, and can additionally specify metric labels and other
        /// information. For example:
        /// 
        /// metric.type = "compute.googleapis.com/instance/cpu/usage_time" AND
        /// metric.labels.instance_name = "my-instance-name"
        /// </param>
        /// <param name="interval">
        /// Required. The time interval for which results should be returned. Only time
        /// series that contain data points in the specified interval are included in
        /// the response.
        /// </param>
        /// <param name="view">
        /// Required. Specifies which information is returned about the time series.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TimeSeries"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeriesAsync(gagr::FolderName name, string filter, TimeInterval interval, ListTimeSeriesRequest.Types.TimeSeriesView view, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTimeSeriesRequest request = new ListTimeSeriesRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                Interval = gax::GaxPreconditions.CheckNotNull(interval, nameof(interval)),
                View = view,
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTimeSeriesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// This method does not support
        /// [resource locations constraint of an organization
        /// policy](https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations#setting_the_organization_policy).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CreateTimeSeries(CreateTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// This method does not support
        /// [resource locations constraint of an organization
        /// policy](https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations#setting_the_organization_policy).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CreateTimeSeriesAsync(CreateTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// This method does not support
        /// [resource locations constraint of an organization
        /// policy](https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations#setting_the_organization_policy).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CreateTimeSeriesAsync(CreateTimeSeriesRequest request, st::CancellationToken cancellationToken) =>
            CreateTimeSeriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// This method does not support
        /// [resource locations constraint of an organization
        /// policy](https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations#setting_the_organization_policy).
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="timeSeries">
        /// Required. The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        /// 
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CreateTimeSeries(string name, scg::IEnumerable<TimeSeries> timeSeries, gaxgrpc::CallSettings callSettings = null) =>
            CreateTimeSeries(new CreateTimeSeriesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                TimeSeries =
                {
                    gax::GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// This method does not support
        /// [resource locations constraint of an organization
        /// policy](https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations#setting_the_organization_policy).
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="timeSeries">
        /// Required. The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        /// 
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CreateTimeSeriesAsync(string name, scg::IEnumerable<TimeSeries> timeSeries, gaxgrpc::CallSettings callSettings = null) =>
            CreateTimeSeriesAsync(new CreateTimeSeriesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                TimeSeries =
                {
                    gax::GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// This method does not support
        /// [resource locations constraint of an organization
        /// policy](https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations#setting_the_organization_policy).
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="timeSeries">
        /// Required. The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        /// 
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CreateTimeSeriesAsync(string name, scg::IEnumerable<TimeSeries> timeSeries, st::CancellationToken cancellationToken) =>
            CreateTimeSeriesAsync(name, timeSeries, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// This method does not support
        /// [resource locations constraint of an organization
        /// policy](https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations#setting_the_organization_policy).
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="timeSeries">
        /// Required. The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        /// 
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CreateTimeSeries(gagr::ProjectName name, scg::IEnumerable<TimeSeries> timeSeries, gaxgrpc::CallSettings callSettings = null) =>
            CreateTimeSeries(new CreateTimeSeriesRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                TimeSeries =
                {
                    gax::GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// This method does not support
        /// [resource locations constraint of an organization
        /// policy](https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations#setting_the_organization_policy).
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="timeSeries">
        /// Required. The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        /// 
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CreateTimeSeriesAsync(gagr::ProjectName name, scg::IEnumerable<TimeSeries> timeSeries, gaxgrpc::CallSettings callSettings = null) =>
            CreateTimeSeriesAsync(new CreateTimeSeriesRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                TimeSeries =
                {
                    gax::GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// This method does not support
        /// [resource locations constraint of an organization
        /// policy](https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations#setting_the_organization_policy).
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="timeSeries">
        /// Required. The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        /// 
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CreateTimeSeriesAsync(gagr::ProjectName name, scg::IEnumerable<TimeSeries> timeSeries, st::CancellationToken cancellationToken) =>
            CreateTimeSeriesAsync(name, timeSeries, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or adds data to one or more service time series. A service time
        /// series is a time series for a metric from a Google Cloud service. The
        /// response is empty if all time series in the request were written. If any
        /// time series could not be written, a corresponding failure message is
        /// included in the error response. This endpoint rejects writes to
        /// user-defined metrics.
        /// This method is only for use by Google Cloud services. Use
        /// [projects.timeSeries.create][google.monitoring.v3.MetricService.CreateTimeSeries]
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CreateServiceTimeSeries(CreateTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or adds data to one or more service time series. A service time
        /// series is a time series for a metric from a Google Cloud service. The
        /// response is empty if all time series in the request were written. If any
        /// time series could not be written, a corresponding failure message is
        /// included in the error response. This endpoint rejects writes to
        /// user-defined metrics.
        /// This method is only for use by Google Cloud services. Use
        /// [projects.timeSeries.create][google.monitoring.v3.MetricService.CreateTimeSeries]
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CreateServiceTimeSeriesAsync(CreateTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or adds data to one or more service time series. A service time
        /// series is a time series for a metric from a Google Cloud service. The
        /// response is empty if all time series in the request were written. If any
        /// time series could not be written, a corresponding failure message is
        /// included in the error response. This endpoint rejects writes to
        /// user-defined metrics.
        /// This method is only for use by Google Cloud services. Use
        /// [projects.timeSeries.create][google.monitoring.v3.MetricService.CreateTimeSeries]
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CreateServiceTimeSeriesAsync(CreateTimeSeriesRequest request, st::CancellationToken cancellationToken) =>
            CreateServiceTimeSeriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or adds data to one or more service time series. A service time
        /// series is a time series for a metric from a Google Cloud service. The
        /// response is empty if all time series in the request were written. If any
        /// time series could not be written, a corresponding failure message is
        /// included in the error response. This endpoint rejects writes to
        /// user-defined metrics.
        /// This method is only for use by Google Cloud services. Use
        /// [projects.timeSeries.create][google.monitoring.v3.MetricService.CreateTimeSeries]
        /// instead.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="timeSeries">
        /// Required. The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        /// 
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CreateServiceTimeSeries(string name, scg::IEnumerable<TimeSeries> timeSeries, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceTimeSeries(new CreateTimeSeriesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                TimeSeries =
                {
                    gax::GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or adds data to one or more service time series. A service time
        /// series is a time series for a metric from a Google Cloud service. The
        /// response is empty if all time series in the request were written. If any
        /// time series could not be written, a corresponding failure message is
        /// included in the error response. This endpoint rejects writes to
        /// user-defined metrics.
        /// This method is only for use by Google Cloud services. Use
        /// [projects.timeSeries.create][google.monitoring.v3.MetricService.CreateTimeSeries]
        /// instead.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="timeSeries">
        /// Required. The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        /// 
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CreateServiceTimeSeriesAsync(string name, scg::IEnumerable<TimeSeries> timeSeries, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceTimeSeriesAsync(new CreateTimeSeriesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                TimeSeries =
                {
                    gax::GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or adds data to one or more service time series. A service time
        /// series is a time series for a metric from a Google Cloud service. The
        /// response is empty if all time series in the request were written. If any
        /// time series could not be written, a corresponding failure message is
        /// included in the error response. This endpoint rejects writes to
        /// user-defined metrics.
        /// This method is only for use by Google Cloud services. Use
        /// [projects.timeSeries.create][google.monitoring.v3.MetricService.CreateTimeSeries]
        /// instead.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="timeSeries">
        /// Required. The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        /// 
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CreateServiceTimeSeriesAsync(string name, scg::IEnumerable<TimeSeries> timeSeries, st::CancellationToken cancellationToken) =>
            CreateServiceTimeSeriesAsync(name, timeSeries, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or adds data to one or more service time series. A service time
        /// series is a time series for a metric from a Google Cloud service. The
        /// response is empty if all time series in the request were written. If any
        /// time series could not be written, a corresponding failure message is
        /// included in the error response. This endpoint rejects writes to
        /// user-defined metrics.
        /// This method is only for use by Google Cloud services. Use
        /// [projects.timeSeries.create][google.monitoring.v3.MetricService.CreateTimeSeries]
        /// instead.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="timeSeries">
        /// Required. The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        /// 
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CreateServiceTimeSeries(gagr::ProjectName name, scg::IEnumerable<TimeSeries> timeSeries, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceTimeSeries(new CreateTimeSeriesRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                TimeSeries =
                {
                    gax::GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or adds data to one or more service time series. A service time
        /// series is a time series for a metric from a Google Cloud service. The
        /// response is empty if all time series in the request were written. If any
        /// time series could not be written, a corresponding failure message is
        /// included in the error response. This endpoint rejects writes to
        /// user-defined metrics.
        /// This method is only for use by Google Cloud services. Use
        /// [projects.timeSeries.create][google.monitoring.v3.MetricService.CreateTimeSeries]
        /// instead.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="timeSeries">
        /// Required. The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        /// 
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CreateServiceTimeSeriesAsync(gagr::ProjectName name, scg::IEnumerable<TimeSeries> timeSeries, gaxgrpc::CallSettings callSettings = null) =>
            CreateServiceTimeSeriesAsync(new CreateTimeSeriesRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                TimeSeries =
                {
                    gax::GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or adds data to one or more service time series. A service time
        /// series is a time series for a metric from a Google Cloud service. The
        /// response is empty if all time series in the request were written. If any
        /// time series could not be written, a corresponding failure message is
        /// included in the error response. This endpoint rejects writes to
        /// user-defined metrics.
        /// This method is only for use by Google Cloud services. Use
        /// [projects.timeSeries.create][google.monitoring.v3.MetricService.CreateTimeSeries]
        /// instead.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="timeSeries">
        /// Required. The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        /// 
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CreateServiceTimeSeriesAsync(gagr::ProjectName name, scg::IEnumerable<TimeSeries> timeSeries, st::CancellationToken cancellationToken) =>
            CreateServiceTimeSeriesAsync(name, timeSeries, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MetricService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages metric descriptors, monitored resource descriptors, and
    /// time series data.
    /// </remarks>
    public sealed partial class MetricServiceClientImpl : MetricServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse> _callListMonitoredResourceDescriptors;

        private readonly gaxgrpc::ApiCall<GetMonitoredResourceDescriptorRequest, ga::MonitoredResourceDescriptor> _callGetMonitoredResourceDescriptor;

        private readonly gaxgrpc::ApiCall<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse> _callListMetricDescriptors;

        private readonly gaxgrpc::ApiCall<GetMetricDescriptorRequest, ga::MetricDescriptor> _callGetMetricDescriptor;

        private readonly gaxgrpc::ApiCall<CreateMetricDescriptorRequest, ga::MetricDescriptor> _callCreateMetricDescriptor;

        private readonly gaxgrpc::ApiCall<DeleteMetricDescriptorRequest, wkt::Empty> _callDeleteMetricDescriptor;

        private readonly gaxgrpc::ApiCall<ListTimeSeriesRequest, ListTimeSeriesResponse> _callListTimeSeries;

        private readonly gaxgrpc::ApiCall<CreateTimeSeriesRequest, wkt::Empty> _callCreateTimeSeries;

        private readonly gaxgrpc::ApiCall<CreateTimeSeriesRequest, wkt::Empty> _callCreateServiceTimeSeries;

        /// <summary>
        /// Constructs a client wrapper for the MetricService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MetricServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MetricServiceClientImpl(MetricService.MetricServiceClient grpcClient, MetricServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MetricServiceSettings effectiveSettings = settings ?? MetricServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListMonitoredResourceDescriptors = clientHelper.BuildApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse>("ListMonitoredResourceDescriptors", grpcClient.ListMonitoredResourceDescriptorsAsync, grpcClient.ListMonitoredResourceDescriptors, effectiveSettings.ListMonitoredResourceDescriptorsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListMonitoredResourceDescriptors);
            Modify_ListMonitoredResourceDescriptorsApiCall(ref _callListMonitoredResourceDescriptors);
            _callGetMonitoredResourceDescriptor = clientHelper.BuildApiCall<GetMonitoredResourceDescriptorRequest, ga::MonitoredResourceDescriptor>("GetMonitoredResourceDescriptor", grpcClient.GetMonitoredResourceDescriptorAsync, grpcClient.GetMonitoredResourceDescriptor, effectiveSettings.GetMonitoredResourceDescriptorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMonitoredResourceDescriptor);
            Modify_GetMonitoredResourceDescriptorApiCall(ref _callGetMonitoredResourceDescriptor);
            _callListMetricDescriptors = clientHelper.BuildApiCall<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse>("ListMetricDescriptors", grpcClient.ListMetricDescriptorsAsync, grpcClient.ListMetricDescriptors, effectiveSettings.ListMetricDescriptorsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListMetricDescriptors);
            Modify_ListMetricDescriptorsApiCall(ref _callListMetricDescriptors);
            _callGetMetricDescriptor = clientHelper.BuildApiCall<GetMetricDescriptorRequest, ga::MetricDescriptor>("GetMetricDescriptor", grpcClient.GetMetricDescriptorAsync, grpcClient.GetMetricDescriptor, effectiveSettings.GetMetricDescriptorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMetricDescriptor);
            Modify_GetMetricDescriptorApiCall(ref _callGetMetricDescriptor);
            _callCreateMetricDescriptor = clientHelper.BuildApiCall<CreateMetricDescriptorRequest, ga::MetricDescriptor>("CreateMetricDescriptor", grpcClient.CreateMetricDescriptorAsync, grpcClient.CreateMetricDescriptor, effectiveSettings.CreateMetricDescriptorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCreateMetricDescriptor);
            Modify_CreateMetricDescriptorApiCall(ref _callCreateMetricDescriptor);
            _callDeleteMetricDescriptor = clientHelper.BuildApiCall<DeleteMetricDescriptorRequest, wkt::Empty>("DeleteMetricDescriptor", grpcClient.DeleteMetricDescriptorAsync, grpcClient.DeleteMetricDescriptor, effectiveSettings.DeleteMetricDescriptorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMetricDescriptor);
            Modify_DeleteMetricDescriptorApiCall(ref _callDeleteMetricDescriptor);
            _callListTimeSeries = clientHelper.BuildApiCall<ListTimeSeriesRequest, ListTimeSeriesResponse>("ListTimeSeries", grpcClient.ListTimeSeriesAsync, grpcClient.ListTimeSeries, effectiveSettings.ListTimeSeriesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListTimeSeries);
            Modify_ListTimeSeriesApiCall(ref _callListTimeSeries);
            _callCreateTimeSeries = clientHelper.BuildApiCall<CreateTimeSeriesRequest, wkt::Empty>("CreateTimeSeries", grpcClient.CreateTimeSeriesAsync, grpcClient.CreateTimeSeries, effectiveSettings.CreateTimeSeriesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCreateTimeSeries);
            Modify_CreateTimeSeriesApiCall(ref _callCreateTimeSeries);
            _callCreateServiceTimeSeries = clientHelper.BuildApiCall<CreateTimeSeriesRequest, wkt::Empty>("CreateServiceTimeSeries", grpcClient.CreateServiceTimeSeriesAsync, grpcClient.CreateServiceTimeSeries, effectiveSettings.CreateServiceTimeSeriesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCreateServiceTimeSeries);
            Modify_CreateServiceTimeSeriesApiCall(ref _callCreateServiceTimeSeries);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListMonitoredResourceDescriptorsApiCall(ref gaxgrpc::ApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse> call);

        partial void Modify_GetMonitoredResourceDescriptorApiCall(ref gaxgrpc::ApiCall<GetMonitoredResourceDescriptorRequest, ga::MonitoredResourceDescriptor> call);

        partial void Modify_ListMetricDescriptorsApiCall(ref gaxgrpc::ApiCall<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse> call);

        partial void Modify_GetMetricDescriptorApiCall(ref gaxgrpc::ApiCall<GetMetricDescriptorRequest, ga::MetricDescriptor> call);

        partial void Modify_CreateMetricDescriptorApiCall(ref gaxgrpc::ApiCall<CreateMetricDescriptorRequest, ga::MetricDescriptor> call);

        partial void Modify_DeleteMetricDescriptorApiCall(ref gaxgrpc::ApiCall<DeleteMetricDescriptorRequest, wkt::Empty> call);

        partial void Modify_ListTimeSeriesApiCall(ref gaxgrpc::ApiCall<ListTimeSeriesRequest, ListTimeSeriesResponse> call);

        partial void Modify_CreateTimeSeriesApiCall(ref gaxgrpc::ApiCall<CreateTimeSeriesRequest, wkt::Empty> call);

        partial void Modify_CreateServiceTimeSeriesApiCall(ref gaxgrpc::ApiCall<CreateTimeSeriesRequest, wkt::Empty> call);

        partial void OnConstruction(MetricService.MetricServiceClient grpcClient, MetricServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MetricService client</summary>
        public override MetricService.MetricServiceClient GrpcClient { get; }

        partial void Modify_ListMonitoredResourceDescriptorsRequest(ref ListMonitoredResourceDescriptorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMonitoredResourceDescriptorRequest(ref GetMonitoredResourceDescriptorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMetricDescriptorsRequest(ref ListMetricDescriptorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMetricDescriptorRequest(ref GetMetricDescriptorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMetricDescriptorRequest(ref CreateMetricDescriptorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMetricDescriptorRequest(ref DeleteMetricDescriptorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTimeSeriesRequest(ref ListTimeSeriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTimeSeriesRequest(ref CreateTimeSeriesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists monitored resource descriptors that match a filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.</returns>
        public override gax::PagedEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(ListMonitoredResourceDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMonitoredResourceDescriptorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor>(_callListMonitoredResourceDescriptors, request, callSettings);
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(ListMonitoredResourceDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMonitoredResourceDescriptorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor>(_callListMonitoredResourceDescriptors, request, callSettings);
        }

        /// <summary>
        /// Gets a single monitored resource descriptor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::MonitoredResourceDescriptor GetMonitoredResourceDescriptor(GetMonitoredResourceDescriptorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMonitoredResourceDescriptorRequest(ref request, ref callSettings);
            return _callGetMonitoredResourceDescriptor.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single monitored resource descriptor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(GetMonitoredResourceDescriptorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMonitoredResourceDescriptorRequest(ref request, ref callSettings);
            return _callGetMonitoredResourceDescriptor.Async(request, callSettings);
        }

        /// <summary>
        /// Lists metric descriptors that match a filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ga::MetricDescriptor"/> resources.</returns>
        public override gax::PagedEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptors(ListMetricDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMetricDescriptorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse, ga::MetricDescriptor>(_callListMetricDescriptors, request, callSettings);
        }

        /// <summary>
        /// Lists metric descriptors that match a filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ga::MetricDescriptor"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptorsAsync(ListMetricDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMetricDescriptorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse, ga::MetricDescriptor>(_callListMetricDescriptors, request, callSettings);
        }

        /// <summary>
        /// Gets a single metric descriptor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::MetricDescriptor GetMetricDescriptor(GetMetricDescriptorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetricDescriptorRequest(ref request, ref callSettings);
            return _callGetMetricDescriptor.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single metric descriptor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(GetMetricDescriptorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetricDescriptorRequest(ref request, ref callSettings);
            return _callGetMetricDescriptor.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::MetricDescriptor CreateMetricDescriptor(CreateMetricDescriptorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMetricDescriptorRequest(ref request, ref callSettings);
            return _callCreateMetricDescriptor.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new metric descriptor.
        /// The creation is executed asynchronously.
        /// User-created metric descriptors define
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics).
        /// The metric descriptor is updated if it already exists,
        /// except that metric labels are never removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(CreateMetricDescriptorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMetricDescriptorRequest(ref request, ref callSettings);
            return _callCreateMetricDescriptor.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics) can be
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteMetricDescriptor(DeleteMetricDescriptorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMetricDescriptorRequest(ref request, ref callSettings);
            _callDeleteMetricDescriptor.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](https://cloud.google.com/monitoring/custom-metrics) can be
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteMetricDescriptorAsync(DeleteMetricDescriptorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMetricDescriptorRequest(ref request, ref callSettings);
            return _callDeleteMetricDescriptor.Async(request, callSettings);
        }

        /// <summary>
        /// Lists time series that match a filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TimeSeries"/> resources.</returns>
        public override gax::PagedEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeries(ListTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTimeSeriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTimeSeriesRequest, ListTimeSeriesResponse, TimeSeries>(_callListTimeSeries, request, callSettings);
        }

        /// <summary>
        /// Lists time series that match a filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TimeSeries"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeriesAsync(ListTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTimeSeriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTimeSeriesRequest, ListTimeSeriesResponse, TimeSeries>(_callListTimeSeries, request, callSettings);
        }

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// This method does not support
        /// [resource locations constraint of an organization
        /// policy](https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations#setting_the_organization_policy).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CreateTimeSeries(CreateTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTimeSeriesRequest(ref request, ref callSettings);
            _callCreateTimeSeries.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// This method does not support
        /// [resource locations constraint of an organization
        /// policy](https://cloud.google.com/resource-manager/docs/organization-policy/defining-locations#setting_the_organization_policy).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CreateTimeSeriesAsync(CreateTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTimeSeriesRequest(ref request, ref callSettings);
            return _callCreateTimeSeries.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or adds data to one or more service time series. A service time
        /// series is a time series for a metric from a Google Cloud service. The
        /// response is empty if all time series in the request were written. If any
        /// time series could not be written, a corresponding failure message is
        /// included in the error response. This endpoint rejects writes to
        /// user-defined metrics.
        /// This method is only for use by Google Cloud services. Use
        /// [projects.timeSeries.create][google.monitoring.v3.MetricService.CreateTimeSeries]
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CreateServiceTimeSeries(CreateTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTimeSeriesRequest(ref request, ref callSettings);
            _callCreateServiceTimeSeries.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or adds data to one or more service time series. A service time
        /// series is a time series for a metric from a Google Cloud service. The
        /// response is empty if all time series in the request were written. If any
        /// time series could not be written, a corresponding failure message is
        /// included in the error response. This endpoint rejects writes to
        /// user-defined metrics.
        /// This method is only for use by Google Cloud services. Use
        /// [projects.timeSeries.create][google.monitoring.v3.MetricService.CreateTimeSeries]
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CreateServiceTimeSeriesAsync(CreateTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTimeSeriesRequest(ref request, ref callSettings);
            return _callCreateServiceTimeSeries.Async(request, callSettings);
        }
    }

    public partial class ListMonitoredResourceDescriptorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMetricDescriptorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTimeSeriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMonitoredResourceDescriptorsResponse : gaxgrpc::IPageResponse<ga::MonitoredResourceDescriptor>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ga::MonitoredResourceDescriptor> GetEnumerator() => ResourceDescriptors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMetricDescriptorsResponse : gaxgrpc::IPageResponse<ga::MetricDescriptor>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ga::MetricDescriptor> GetEnumerator() => MetricDescriptors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTimeSeriesResponse : gaxgrpc::IPageResponse<TimeSeries>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TimeSeries> GetEnumerator() => TimeSeries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
