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
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.CloudSecurityCompliance.V1
{
    /// <summary>Settings for <see cref="MonitoringClient"/> instances.</summary>
    public sealed partial class MonitoringSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MonitoringSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MonitoringSettings"/>.</returns>
        public static MonitoringSettings GetDefault() => new MonitoringSettings();

        /// <summary>Constructs a new <see cref="MonitoringSettings"/> object with default settings.</summary>
        public MonitoringSettings()
        {
        }

        private MonitoringSettings(MonitoringSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListFrameworkComplianceSummariesSettings = existing.ListFrameworkComplianceSummariesSettings;
            ListFindingSummariesSettings = existing.ListFindingSummariesSettings;
            FetchFrameworkComplianceReportSettings = existing.FetchFrameworkComplianceReportSettings;
            ListControlComplianceSummariesSettings = existing.ListControlComplianceSummariesSettings;
            AggregateFrameworkComplianceReportSettings = existing.AggregateFrameworkComplianceReportSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MonitoringSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MonitoringClient.ListFrameworkComplianceSummaries</c> and
        /// <c>MonitoringClient.ListFrameworkComplianceSummariesAsync</c>.
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
        public gaxgrpc::CallSettings ListFrameworkComplianceSummariesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MonitoringClient.ListFindingSummaries</c> and <c>MonitoringClient.ListFindingSummariesAsync</c>.
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
        public gaxgrpc::CallSettings ListFindingSummariesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MonitoringClient.FetchFrameworkComplianceReport</c> and
        /// <c>MonitoringClient.FetchFrameworkComplianceReportAsync</c>.
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
        public gaxgrpc::CallSettings FetchFrameworkComplianceReportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MonitoringClient.ListControlComplianceSummaries</c> and
        /// <c>MonitoringClient.ListControlComplianceSummariesAsync</c>.
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
        public gaxgrpc::CallSettings ListControlComplianceSummariesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MonitoringClient.AggregateFrameworkComplianceReport</c> and
        /// <c>MonitoringClient.AggregateFrameworkComplianceReportAsync</c>.
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
        public gaxgrpc::CallSettings AggregateFrameworkComplianceReportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MonitoringSettings"/> object.</returns>
        public MonitoringSettings Clone() => new MonitoringSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MonitoringClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class MonitoringClientBuilder : gaxgrpc::ClientBuilderBase<MonitoringClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MonitoringSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MonitoringClientBuilder() : base(MonitoringClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MonitoringClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MonitoringClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MonitoringClient Build()
        {
            MonitoringClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MonitoringClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MonitoringClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MonitoringClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MonitoringClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MonitoringClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MonitoringClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MonitoringClient.ChannelPool;
    }

    /// <summary>Monitoring client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class MonitoringClient
    {
        /// <summary>
        /// The default endpoint for the Monitoring service, which is a host of "cloudsecuritycompliance.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudsecuritycompliance.googleapis.com:443";

        /// <summary>The default Monitoring scopes.</summary>
        /// <remarks>
        /// The default Monitoring scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Monitoring.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MonitoringClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MonitoringClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MonitoringClient"/>.</returns>
        public static stt::Task<MonitoringClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MonitoringClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MonitoringClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="MonitoringClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MonitoringClient"/>.</returns>
        public static MonitoringClient Create() => new MonitoringClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MonitoringClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MonitoringSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MonitoringClient"/>.</returns>
        internal static MonitoringClient Create(grpccore::CallInvoker callInvoker, MonitoringSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Monitoring.MonitoringClient grpcClient = new Monitoring.MonitoringClient(callInvoker);
            return new MonitoringClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Monitoring client</summary>
        public virtual Monitoring.MonitoringClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the framework compliance summary for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FrameworkComplianceSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> ListFrameworkComplianceSummaries(ListFrameworkComplianceSummariesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the framework compliance summary for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkComplianceSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> ListFrameworkComplianceSummariesAsync(ListFrameworkComplianceSummariesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the framework compliance summary for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework compliance summary.
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
        /// <returns>A pageable sequence of <see cref="FrameworkComplianceSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> ListFrameworkComplianceSummaries(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkComplianceSummariesRequest request = new ListFrameworkComplianceSummariesRequest
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
            return ListFrameworkComplianceSummaries(request, callSettings);
        }

        /// <summary>
        /// Lists the framework compliance summary for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework compliance summary.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkComplianceSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> ListFrameworkComplianceSummariesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkComplianceSummariesRequest request = new ListFrameworkComplianceSummariesRequest
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
            return ListFrameworkComplianceSummariesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the framework compliance summary for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework compliance summary.
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
        /// <returns>A pageable sequence of <see cref="FrameworkComplianceSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> ListFrameworkComplianceSummaries(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkComplianceSummariesRequest request = new ListFrameworkComplianceSummariesRequest
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
            return ListFrameworkComplianceSummaries(request, callSettings);
        }

        /// <summary>
        /// Lists the framework compliance summary for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework compliance summary.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkComplianceSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> ListFrameworkComplianceSummariesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkComplianceSummariesRequest request = new ListFrameworkComplianceSummariesRequest
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
            return ListFrameworkComplianceSummariesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the framework compliance summary for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework compliance summary.
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
        /// <returns>A pageable sequence of <see cref="FrameworkComplianceSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> ListFrameworkComplianceSummaries(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkComplianceSummariesRequest request = new ListFrameworkComplianceSummariesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFrameworkComplianceSummaries(request, callSettings);
        }

        /// <summary>
        /// Lists the framework compliance summary for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework compliance summary.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkComplianceSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> ListFrameworkComplianceSummariesAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkComplianceSummariesRequest request = new ListFrameworkComplianceSummariesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFrameworkComplianceSummariesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the framework compliance summary for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework compliance summary.
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
        /// <returns>A pageable sequence of <see cref="FrameworkComplianceSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> ListFrameworkComplianceSummaries(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkComplianceSummariesRequest request = new ListFrameworkComplianceSummariesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFrameworkComplianceSummaries(request, callSettings);
        }

        /// <summary>
        /// Lists the framework compliance summary for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework compliance summary.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkComplianceSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> ListFrameworkComplianceSummariesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworkComplianceSummariesRequest request = new ListFrameworkComplianceSummariesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFrameworkComplianceSummariesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the finding summary by category for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FindingSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFindingSummariesResponse, FindingSummary> ListFindingSummaries(ListFindingSummariesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the finding summary by category for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FindingSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingSummariesResponse, FindingSummary> ListFindingSummariesAsync(ListFindingSummariesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the finding summary by category for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework overview page.
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
        /// <returns>A pageable sequence of <see cref="FindingSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFindingSummariesResponse, FindingSummary> ListFindingSummaries(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingSummariesRequest request = new ListFindingSummariesRequest
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
            return ListFindingSummaries(request, callSettings);
        }

        /// <summary>
        /// Lists the finding summary by category for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework overview page.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FindingSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingSummariesResponse, FindingSummary> ListFindingSummariesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingSummariesRequest request = new ListFindingSummariesRequest
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
            return ListFindingSummariesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the finding summary by category for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework overview page.
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
        /// <returns>A pageable sequence of <see cref="FindingSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFindingSummariesResponse, FindingSummary> ListFindingSummaries(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingSummariesRequest request = new ListFindingSummariesRequest
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
            return ListFindingSummaries(request, callSettings);
        }

        /// <summary>
        /// Lists the finding summary by category for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework overview page.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FindingSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingSummariesResponse, FindingSummary> ListFindingSummariesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingSummariesRequest request = new ListFindingSummariesRequest
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
            return ListFindingSummariesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the finding summary by category for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework overview page.
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
        /// <returns>A pageable sequence of <see cref="FindingSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFindingSummariesResponse, FindingSummary> ListFindingSummaries(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingSummariesRequest request = new ListFindingSummariesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFindingSummaries(request, callSettings);
        }

        /// <summary>
        /// Lists the finding summary by category for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework overview page.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FindingSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingSummariesResponse, FindingSummary> ListFindingSummariesAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingSummariesRequest request = new ListFindingSummariesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFindingSummariesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the finding summary by category for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework overview page.
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
        /// <returns>A pageable sequence of <see cref="FindingSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFindingSummariesResponse, FindingSummary> ListFindingSummaries(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingSummariesRequest request = new ListFindingSummariesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFindingSummaries(request, callSettings);
        }

        /// <summary>
        /// Lists the finding summary by category for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework overview page.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FindingSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingSummariesResponse, FindingSummary> ListFindingSummariesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingSummariesRequest request = new ListFindingSummariesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFindingSummariesAsync(request, callSettings);
        }

        /// <summary>
        /// Fetches the framework compliance report for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FrameworkComplianceReport FetchFrameworkComplianceReport(FetchFrameworkComplianceReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches the framework compliance report for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkComplianceReport> FetchFrameworkComplianceReportAsync(FetchFrameworkComplianceReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches the framework compliance report for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkComplianceReport> FetchFrameworkComplianceReportAsync(FetchFrameworkComplianceReportRequest request, st::CancellationToken cancellationToken) =>
            FetchFrameworkComplianceReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches the framework compliance report for a given scope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework compliance report to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FrameworkComplianceReport FetchFrameworkComplianceReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            FetchFrameworkComplianceReport(new FetchFrameworkComplianceReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the framework compliance report for a given scope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework compliance report to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkComplianceReport> FetchFrameworkComplianceReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            FetchFrameworkComplianceReportAsync(new FetchFrameworkComplianceReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the framework compliance report for a given scope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework compliance report to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkComplianceReport> FetchFrameworkComplianceReportAsync(string name, st::CancellationToken cancellationToken) =>
            FetchFrameworkComplianceReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches the framework compliance report for a given scope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework compliance report to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FrameworkComplianceReport FetchFrameworkComplianceReport(FrameworkComplianceReportName name, gaxgrpc::CallSettings callSettings = null) =>
            FetchFrameworkComplianceReport(new FetchFrameworkComplianceReportRequest
            {
                FrameworkComplianceReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the framework compliance report for a given scope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework compliance report to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkComplianceReport> FetchFrameworkComplianceReportAsync(FrameworkComplianceReportName name, gaxgrpc::CallSettings callSettings = null) =>
            FetchFrameworkComplianceReportAsync(new FetchFrameworkComplianceReportRequest
            {
                FrameworkComplianceReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the framework compliance report for a given scope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework compliance report to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FrameworkComplianceReport> FetchFrameworkComplianceReportAsync(FrameworkComplianceReportName name, st::CancellationToken cancellationToken) =>
            FetchFrameworkComplianceReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the control compliance summary for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ControlComplianceSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListControlComplianceSummariesResponse, ControlComplianceSummary> ListControlComplianceSummaries(ListControlComplianceSummariesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the control compliance summary for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ControlComplianceSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListControlComplianceSummariesResponse, ControlComplianceSummary> ListControlComplianceSummariesAsync(ListControlComplianceSummariesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the control compliance summary for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework overview page.
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
        /// <returns>A pageable sequence of <see cref="ControlComplianceSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListControlComplianceSummariesResponse, ControlComplianceSummary> ListControlComplianceSummaries(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListControlComplianceSummariesRequest request = new ListControlComplianceSummariesRequest
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
            return ListControlComplianceSummaries(request, callSettings);
        }

        /// <summary>
        /// Lists the control compliance summary for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework overview page.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ControlComplianceSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListControlComplianceSummariesResponse, ControlComplianceSummary> ListControlComplianceSummariesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListControlComplianceSummariesRequest request = new ListControlComplianceSummariesRequest
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
            return ListControlComplianceSummariesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the control compliance summary for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework overview page.
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
        /// <returns>A pageable sequence of <see cref="ControlComplianceSummary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListControlComplianceSummariesResponse, ControlComplianceSummary> ListControlComplianceSummaries(FrameworkComplianceReportName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListControlComplianceSummariesRequest request = new ListControlComplianceSummariesRequest
            {
                ParentAsFrameworkComplianceReportName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListControlComplianceSummaries(request, callSettings);
        }

        /// <summary>
        /// Lists the control compliance summary for a given scope.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent scope for the framework overview page.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ControlComplianceSummary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListControlComplianceSummariesResponse, ControlComplianceSummary> ListControlComplianceSummariesAsync(FrameworkComplianceReportName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListControlComplianceSummariesRequest request = new ListControlComplianceSummariesRequest
            {
                ParentAsFrameworkComplianceReportName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListControlComplianceSummariesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the aggregated compliance report over time for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AggregateFrameworkComplianceReportResponse AggregateFrameworkComplianceReport(AggregateFrameworkComplianceReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the aggregated compliance report over time for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AggregateFrameworkComplianceReportResponse> AggregateFrameworkComplianceReportAsync(AggregateFrameworkComplianceReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the aggregated compliance report over time for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AggregateFrameworkComplianceReportResponse> AggregateFrameworkComplianceReportAsync(AggregateFrameworkComplianceReportRequest request, st::CancellationToken cancellationToken) =>
            AggregateFrameworkComplianceReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the aggregated compliance report over time for a given scope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the aggregated compliance report over time to
        /// retrieve.
        /// 
        /// The supported format is:
        /// `organizations/{organization_id}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AggregateFrameworkComplianceReportResponse AggregateFrameworkComplianceReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            AggregateFrameworkComplianceReport(new AggregateFrameworkComplianceReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the aggregated compliance report over time for a given scope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the aggregated compliance report over time to
        /// retrieve.
        /// 
        /// The supported format is:
        /// `organizations/{organization_id}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AggregateFrameworkComplianceReportResponse> AggregateFrameworkComplianceReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            AggregateFrameworkComplianceReportAsync(new AggregateFrameworkComplianceReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the aggregated compliance report over time for a given scope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the aggregated compliance report over time to
        /// retrieve.
        /// 
        /// The supported format is:
        /// `organizations/{organization_id}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AggregateFrameworkComplianceReportResponse> AggregateFrameworkComplianceReportAsync(string name, st::CancellationToken cancellationToken) =>
            AggregateFrameworkComplianceReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the aggregated compliance report over time for a given scope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the aggregated compliance report over time to
        /// retrieve.
        /// 
        /// The supported format is:
        /// `organizations/{organization_id}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AggregateFrameworkComplianceReportResponse AggregateFrameworkComplianceReport(FrameworkComplianceReportName name, gaxgrpc::CallSettings callSettings = null) =>
            AggregateFrameworkComplianceReport(new AggregateFrameworkComplianceReportRequest
            {
                FrameworkComplianceReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the aggregated compliance report over time for a given scope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the aggregated compliance report over time to
        /// retrieve.
        /// 
        /// The supported format is:
        /// `organizations/{organization_id}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AggregateFrameworkComplianceReportResponse> AggregateFrameworkComplianceReportAsync(FrameworkComplianceReportName name, gaxgrpc::CallSettings callSettings = null) =>
            AggregateFrameworkComplianceReportAsync(new AggregateFrameworkComplianceReportRequest
            {
                FrameworkComplianceReportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the aggregated compliance report over time for a given scope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the aggregated compliance report over time to
        /// retrieve.
        /// 
        /// The supported format is:
        /// `organizations/{organization_id}/locations/{location}/frameworkComplianceReports/{framework_compliance_report}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AggregateFrameworkComplianceReportResponse> AggregateFrameworkComplianceReportAsync(FrameworkComplianceReportName name, st::CancellationToken cancellationToken) =>
            AggregateFrameworkComplianceReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Monitoring client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class MonitoringClientImpl : MonitoringClient
    {
        private readonly gaxgrpc::ApiCall<ListFrameworkComplianceSummariesRequest, ListFrameworkComplianceSummariesResponse> _callListFrameworkComplianceSummaries;

        private readonly gaxgrpc::ApiCall<ListFindingSummariesRequest, ListFindingSummariesResponse> _callListFindingSummaries;

        private readonly gaxgrpc::ApiCall<FetchFrameworkComplianceReportRequest, FrameworkComplianceReport> _callFetchFrameworkComplianceReport;

        private readonly gaxgrpc::ApiCall<ListControlComplianceSummariesRequest, ListControlComplianceSummariesResponse> _callListControlComplianceSummaries;

        private readonly gaxgrpc::ApiCall<AggregateFrameworkComplianceReportRequest, AggregateFrameworkComplianceReportResponse> _callAggregateFrameworkComplianceReport;

        /// <summary>
        /// Constructs a client wrapper for the Monitoring service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MonitoringSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MonitoringClientImpl(Monitoring.MonitoringClient grpcClient, MonitoringSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MonitoringSettings effectiveSettings = settings ?? MonitoringSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListFrameworkComplianceSummaries = clientHelper.BuildApiCall<ListFrameworkComplianceSummariesRequest, ListFrameworkComplianceSummariesResponse>("ListFrameworkComplianceSummaries", grpcClient.ListFrameworkComplianceSummariesAsync, grpcClient.ListFrameworkComplianceSummaries, effectiveSettings.ListFrameworkComplianceSummariesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFrameworkComplianceSummaries);
            Modify_ListFrameworkComplianceSummariesApiCall(ref _callListFrameworkComplianceSummaries);
            _callListFindingSummaries = clientHelper.BuildApiCall<ListFindingSummariesRequest, ListFindingSummariesResponse>("ListFindingSummaries", grpcClient.ListFindingSummariesAsync, grpcClient.ListFindingSummaries, effectiveSettings.ListFindingSummariesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFindingSummaries);
            Modify_ListFindingSummariesApiCall(ref _callListFindingSummaries);
            _callFetchFrameworkComplianceReport = clientHelper.BuildApiCall<FetchFrameworkComplianceReportRequest, FrameworkComplianceReport>("FetchFrameworkComplianceReport", grpcClient.FetchFrameworkComplianceReportAsync, grpcClient.FetchFrameworkComplianceReport, effectiveSettings.FetchFrameworkComplianceReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFetchFrameworkComplianceReport);
            Modify_FetchFrameworkComplianceReportApiCall(ref _callFetchFrameworkComplianceReport);
            _callListControlComplianceSummaries = clientHelper.BuildApiCall<ListControlComplianceSummariesRequest, ListControlComplianceSummariesResponse>("ListControlComplianceSummaries", grpcClient.ListControlComplianceSummariesAsync, grpcClient.ListControlComplianceSummaries, effectiveSettings.ListControlComplianceSummariesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListControlComplianceSummaries);
            Modify_ListControlComplianceSummariesApiCall(ref _callListControlComplianceSummaries);
            _callAggregateFrameworkComplianceReport = clientHelper.BuildApiCall<AggregateFrameworkComplianceReportRequest, AggregateFrameworkComplianceReportResponse>("AggregateFrameworkComplianceReport", grpcClient.AggregateFrameworkComplianceReportAsync, grpcClient.AggregateFrameworkComplianceReport, effectiveSettings.AggregateFrameworkComplianceReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAggregateFrameworkComplianceReport);
            Modify_AggregateFrameworkComplianceReportApiCall(ref _callAggregateFrameworkComplianceReport);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListFrameworkComplianceSummariesApiCall(ref gaxgrpc::ApiCall<ListFrameworkComplianceSummariesRequest, ListFrameworkComplianceSummariesResponse> call);

        partial void Modify_ListFindingSummariesApiCall(ref gaxgrpc::ApiCall<ListFindingSummariesRequest, ListFindingSummariesResponse> call);

        partial void Modify_FetchFrameworkComplianceReportApiCall(ref gaxgrpc::ApiCall<FetchFrameworkComplianceReportRequest, FrameworkComplianceReport> call);

        partial void Modify_ListControlComplianceSummariesApiCall(ref gaxgrpc::ApiCall<ListControlComplianceSummariesRequest, ListControlComplianceSummariesResponse> call);

        partial void Modify_AggregateFrameworkComplianceReportApiCall(ref gaxgrpc::ApiCall<AggregateFrameworkComplianceReportRequest, AggregateFrameworkComplianceReportResponse> call);

        partial void OnConstruction(Monitoring.MonitoringClient grpcClient, MonitoringSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Monitoring client</summary>
        public override Monitoring.MonitoringClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListFrameworkComplianceSummariesRequest(ref ListFrameworkComplianceSummariesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFindingSummariesRequest(ref ListFindingSummariesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchFrameworkComplianceReportRequest(ref FetchFrameworkComplianceReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListControlComplianceSummariesRequest(ref ListControlComplianceSummariesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AggregateFrameworkComplianceReportRequest(ref AggregateFrameworkComplianceReportRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the framework compliance summary for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FrameworkComplianceSummary"/> resources.</returns>
        public override gax::PagedEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> ListFrameworkComplianceSummaries(ListFrameworkComplianceSummariesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFrameworkComplianceSummariesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFrameworkComplianceSummariesRequest, ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary>(_callListFrameworkComplianceSummaries, request, callSettings);
        }

        /// <summary>
        /// Lists the framework compliance summary for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FrameworkComplianceSummary"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> ListFrameworkComplianceSummariesAsync(ListFrameworkComplianceSummariesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFrameworkComplianceSummariesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFrameworkComplianceSummariesRequest, ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary>(_callListFrameworkComplianceSummaries, request, callSettings);
        }

        /// <summary>
        /// Lists the finding summary by category for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FindingSummary"/> resources.</returns>
        public override gax::PagedEnumerable<ListFindingSummariesResponse, FindingSummary> ListFindingSummaries(ListFindingSummariesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFindingSummariesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFindingSummariesRequest, ListFindingSummariesResponse, FindingSummary>(_callListFindingSummaries, request, callSettings);
        }

        /// <summary>
        /// Lists the finding summary by category for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FindingSummary"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFindingSummariesResponse, FindingSummary> ListFindingSummariesAsync(ListFindingSummariesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFindingSummariesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFindingSummariesRequest, ListFindingSummariesResponse, FindingSummary>(_callListFindingSummaries, request, callSettings);
        }

        /// <summary>
        /// Fetches the framework compliance report for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FrameworkComplianceReport FetchFrameworkComplianceReport(FetchFrameworkComplianceReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchFrameworkComplianceReportRequest(ref request, ref callSettings);
            return _callFetchFrameworkComplianceReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches the framework compliance report for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FrameworkComplianceReport> FetchFrameworkComplianceReportAsync(FetchFrameworkComplianceReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchFrameworkComplianceReportRequest(ref request, ref callSettings);
            return _callFetchFrameworkComplianceReport.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the control compliance summary for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ControlComplianceSummary"/> resources.</returns>
        public override gax::PagedEnumerable<ListControlComplianceSummariesResponse, ControlComplianceSummary> ListControlComplianceSummaries(ListControlComplianceSummariesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListControlComplianceSummariesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListControlComplianceSummariesRequest, ListControlComplianceSummariesResponse, ControlComplianceSummary>(_callListControlComplianceSummaries, request, callSettings);
        }

        /// <summary>
        /// Lists the control compliance summary for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ControlComplianceSummary"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListControlComplianceSummariesResponse, ControlComplianceSummary> ListControlComplianceSummariesAsync(ListControlComplianceSummariesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListControlComplianceSummariesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListControlComplianceSummariesRequest, ListControlComplianceSummariesResponse, ControlComplianceSummary>(_callListControlComplianceSummaries, request, callSettings);
        }

        /// <summary>
        /// Gets the aggregated compliance report over time for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AggregateFrameworkComplianceReportResponse AggregateFrameworkComplianceReport(AggregateFrameworkComplianceReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregateFrameworkComplianceReportRequest(ref request, ref callSettings);
            return _callAggregateFrameworkComplianceReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the aggregated compliance report over time for a given scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AggregateFrameworkComplianceReportResponse> AggregateFrameworkComplianceReportAsync(AggregateFrameworkComplianceReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregateFrameworkComplianceReportRequest(ref request, ref callSettings);
            return _callAggregateFrameworkComplianceReport.Async(request, callSettings);
        }
    }

    public partial class ListFrameworkComplianceSummariesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFindingSummariesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListControlComplianceSummariesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFrameworkComplianceSummariesResponse : gaxgrpc::IPageResponse<FrameworkComplianceSummary>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FrameworkComplianceSummary> GetEnumerator() => FrameworkComplianceSummaries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFindingSummariesResponse : gaxgrpc::IPageResponse<FindingSummary>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FindingSummary> GetEnumerator() => FindingSummaries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListControlComplianceSummariesResponse : gaxgrpc::IPageResponse<ControlComplianceSummary>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ControlComplianceSummary> GetEnumerator() => ControlComplianceSummaries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Monitoring
    {
        public partial class MonitoringClient
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
