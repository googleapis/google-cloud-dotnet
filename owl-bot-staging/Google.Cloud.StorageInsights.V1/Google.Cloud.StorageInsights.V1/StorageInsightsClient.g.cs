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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.StorageInsights.V1
{
    /// <summary>Settings for <see cref="StorageInsightsClient"/> instances.</summary>
    public sealed partial class StorageInsightsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="StorageInsightsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="StorageInsightsSettings"/>.</returns>
        public static StorageInsightsSettings GetDefault() => new StorageInsightsSettings();

        /// <summary>Constructs a new <see cref="StorageInsightsSettings"/> object with default settings.</summary>
        public StorageInsightsSettings()
        {
        }

        private StorageInsightsSettings(StorageInsightsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListReportConfigsSettings = existing.ListReportConfigsSettings;
            GetReportConfigSettings = existing.GetReportConfigSettings;
            CreateReportConfigSettings = existing.CreateReportConfigSettings;
            UpdateReportConfigSettings = existing.UpdateReportConfigSettings;
            DeleteReportConfigSettings = existing.DeleteReportConfigSettings;
            ListReportDetailsSettings = existing.ListReportDetailsSettings;
            GetReportDetailSettings = existing.GetReportDetailSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(StorageInsightsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.ListReportConfigs</c> and <c>StorageInsightsClient.ListReportConfigsAsync</c>.
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
        public gaxgrpc::CallSettings ListReportConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.GetReportConfig</c> and <c>StorageInsightsClient.GetReportConfigAsync</c>.
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
        public gaxgrpc::CallSettings GetReportConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.CreateReportConfig</c> and <c>StorageInsightsClient.CreateReportConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReportConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.UpdateReportConfig</c> and <c>StorageInsightsClient.UpdateReportConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateReportConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.DeleteReportConfig</c> and <c>StorageInsightsClient.DeleteReportConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReportConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.ListReportDetails</c> and <c>StorageInsightsClient.ListReportDetailsAsync</c>.
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
        public gaxgrpc::CallSettings ListReportDetailsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.GetReportDetail</c> and <c>StorageInsightsClient.GetReportDetailAsync</c>.
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
        public gaxgrpc::CallSettings GetReportDetailSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="StorageInsightsSettings"/> object.</returns>
        public StorageInsightsSettings Clone() => new StorageInsightsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="StorageInsightsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class StorageInsightsClientBuilder : gaxgrpc::ClientBuilderBase<StorageInsightsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public StorageInsightsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public StorageInsightsClientBuilder() : base(StorageInsightsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref StorageInsightsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<StorageInsightsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override StorageInsightsClient Build()
        {
            StorageInsightsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<StorageInsightsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<StorageInsightsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private StorageInsightsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return StorageInsightsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<StorageInsightsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return StorageInsightsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => StorageInsightsClient.ChannelPool;
    }

    /// <summary>StorageInsights client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class StorageInsightsClient
    {
        /// <summary>
        /// The default endpoint for the StorageInsights service, which is a host of "storageinsights.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "storageinsights.googleapis.com:443";

        /// <summary>The default StorageInsights scopes.</summary>
        /// <remarks>
        /// The default StorageInsights scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(StorageInsights.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="StorageInsightsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="StorageInsightsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="StorageInsightsClient"/>.</returns>
        public static stt::Task<StorageInsightsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new StorageInsightsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="StorageInsightsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="StorageInsightsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="StorageInsightsClient"/>.</returns>
        public static StorageInsightsClient Create() => new StorageInsightsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="StorageInsightsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="StorageInsightsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="StorageInsightsClient"/>.</returns>
        internal static StorageInsightsClient Create(grpccore::CallInvoker callInvoker, StorageInsightsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            StorageInsights.StorageInsightsClient grpcClient = new StorageInsights.StorageInsightsClient(callInvoker);
            return new StorageInsightsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC StorageInsights client</summary>
        public virtual StorageInsights.StorageInsightsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigs(ListReportConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigsAsync(ListReportConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportConfigsRequest
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
        /// <returns>A pageable sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportConfigsRequest request = new ListReportConfigsRequest
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
            return ListReportConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportConfigsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportConfigsRequest request = new ListReportConfigsRequest
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
            return ListReportConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportConfigsRequest
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
        /// <returns>A pageable sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportConfigsRequest request = new ListReportConfigsRequest
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
            return ListReportConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportConfigsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportConfigsRequest request = new ListReportConfigsRequest
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
            return ListReportConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig GetReportConfig(GetReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(GetReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(GetReportConfigRequest request, st::CancellationToken cancellationToken) =>
            GetReportConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig GetReportConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportConfig(new GetReportConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportConfigAsync(new GetReportConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetReportConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig GetReportConfig(ReportConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportConfig(new GetReportConfigRequest
            {
                ReportConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(ReportConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportConfigAsync(new GetReportConfigRequest
            {
                ReportConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(ReportConfigName name, st::CancellationToken cancellationToken) =>
            GetReportConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig CreateReportConfig(CreateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> CreateReportConfigAsync(CreateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> CreateReportConfigAsync(CreateReportConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateReportConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig CreateReportConfig(string parent, ReportConfig reportConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportConfig(new CreateReportConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> CreateReportConfigAsync(string parent, ReportConfig reportConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportConfigAsync(new CreateReportConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> CreateReportConfigAsync(string parent, ReportConfig reportConfig, st::CancellationToken cancellationToken) =>
            CreateReportConfigAsync(parent, reportConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig CreateReportConfig(gagr::LocationName parent, ReportConfig reportConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportConfig(new CreateReportConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> CreateReportConfigAsync(gagr::LocationName parent, ReportConfig reportConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportConfigAsync(new CreateReportConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> CreateReportConfigAsync(gagr::LocationName parent, ReportConfig reportConfig, st::CancellationToken cancellationToken) =>
            CreateReportConfigAsync(parent, reportConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig UpdateReportConfig(UpdateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> UpdateReportConfigAsync(UpdateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> UpdateReportConfigAsync(UpdateReportConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateReportConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="reportConfig">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ReportConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig UpdateReportConfig(ReportConfig reportConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReportConfig(new UpdateReportConfigRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="reportConfig">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ReportConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> UpdateReportConfigAsync(ReportConfig reportConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReportConfigAsync(new UpdateReportConfigRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="reportConfig">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ReportConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> UpdateReportConfigAsync(ReportConfig reportConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateReportConfigAsync(reportConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReportConfig(DeleteReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportConfigAsync(DeleteReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportConfigAsync(DeleteReportConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteReportConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReportConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportConfig(new DeleteReportConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportConfigAsync(new DeleteReportConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReportConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReportConfig(ReportConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportConfig(new DeleteReportConfigRequest
            {
                ReportConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportConfigAsync(ReportConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportConfigAsync(new DeleteReportConfigRequest
            {
                ReportConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportConfigAsync(ReportConfigName name, st::CancellationToken cancellationToken) =>
            DeleteReportConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReportDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetails(ListReportDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReportDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetailsAsync(ListReportDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportDetailsRequest
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
        /// <returns>A pageable sequence of <see cref="ReportDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetails(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportDetailsRequest request = new ListReportDetailsRequest
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
            return ListReportDetails(request, callSettings);
        }

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportDetailsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReportDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetailsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportDetailsRequest request = new ListReportDetailsRequest
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
            return ListReportDetailsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportDetailsRequest
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
        /// <returns>A pageable sequence of <see cref="ReportDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetails(ReportConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportDetailsRequest request = new ListReportDetailsRequest
            {
                ParentAsReportConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReportDetails(request, callSettings);
        }

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportDetailsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReportDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetailsAsync(ReportConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportDetailsRequest request = new ListReportDetailsRequest
            {
                ParentAsReportConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReportDetailsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportDetail GetReportDetail(GetReportDetailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportDetail> GetReportDetailAsync(GetReportDetailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportDetail> GetReportDetailAsync(GetReportDetailRequest request, st::CancellationToken cancellationToken) =>
            GetReportDetailAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportDetail GetReportDetail(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportDetail(new GetReportDetailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportDetail> GetReportDetailAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportDetailAsync(new GetReportDetailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportDetail> GetReportDetailAsync(string name, st::CancellationToken cancellationToken) =>
            GetReportDetailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportDetail GetReportDetail(ReportDetailName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportDetail(new GetReportDetailRequest
            {
                ReportDetailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportDetail> GetReportDetailAsync(ReportDetailName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportDetailAsync(new GetReportDetailRequest
            {
                ReportDetailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportDetail> GetReportDetailAsync(ReportDetailName name, st::CancellationToken cancellationToken) =>
            GetReportDetailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>StorageInsights client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class StorageInsightsClientImpl : StorageInsightsClient
    {
        private readonly gaxgrpc::ApiCall<ListReportConfigsRequest, ListReportConfigsResponse> _callListReportConfigs;

        private readonly gaxgrpc::ApiCall<GetReportConfigRequest, ReportConfig> _callGetReportConfig;

        private readonly gaxgrpc::ApiCall<CreateReportConfigRequest, ReportConfig> _callCreateReportConfig;

        private readonly gaxgrpc::ApiCall<UpdateReportConfigRequest, ReportConfig> _callUpdateReportConfig;

        private readonly gaxgrpc::ApiCall<DeleteReportConfigRequest, wkt::Empty> _callDeleteReportConfig;

        private readonly gaxgrpc::ApiCall<ListReportDetailsRequest, ListReportDetailsResponse> _callListReportDetails;

        private readonly gaxgrpc::ApiCall<GetReportDetailRequest, ReportDetail> _callGetReportDetail;

        /// <summary>
        /// Constructs a client wrapper for the StorageInsights service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="StorageInsightsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public StorageInsightsClientImpl(StorageInsights.StorageInsightsClient grpcClient, StorageInsightsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            StorageInsightsSettings effectiveSettings = settings ?? StorageInsightsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListReportConfigs = clientHelper.BuildApiCall<ListReportConfigsRequest, ListReportConfigsResponse>("ListReportConfigs", grpcClient.ListReportConfigsAsync, grpcClient.ListReportConfigs, effectiveSettings.ListReportConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReportConfigs);
            Modify_ListReportConfigsApiCall(ref _callListReportConfigs);
            _callGetReportConfig = clientHelper.BuildApiCall<GetReportConfigRequest, ReportConfig>("GetReportConfig", grpcClient.GetReportConfigAsync, grpcClient.GetReportConfig, effectiveSettings.GetReportConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReportConfig);
            Modify_GetReportConfigApiCall(ref _callGetReportConfig);
            _callCreateReportConfig = clientHelper.BuildApiCall<CreateReportConfigRequest, ReportConfig>("CreateReportConfig", grpcClient.CreateReportConfigAsync, grpcClient.CreateReportConfig, effectiveSettings.CreateReportConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReportConfig);
            Modify_CreateReportConfigApiCall(ref _callCreateReportConfig);
            _callUpdateReportConfig = clientHelper.BuildApiCall<UpdateReportConfigRequest, ReportConfig>("UpdateReportConfig", grpcClient.UpdateReportConfigAsync, grpcClient.UpdateReportConfig, effectiveSettings.UpdateReportConfigSettings).WithGoogleRequestParam("report_config.name", request => request.ReportConfig?.Name);
            Modify_ApiCall(ref _callUpdateReportConfig);
            Modify_UpdateReportConfigApiCall(ref _callUpdateReportConfig);
            _callDeleteReportConfig = clientHelper.BuildApiCall<DeleteReportConfigRequest, wkt::Empty>("DeleteReportConfig", grpcClient.DeleteReportConfigAsync, grpcClient.DeleteReportConfig, effectiveSettings.DeleteReportConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteReportConfig);
            Modify_DeleteReportConfigApiCall(ref _callDeleteReportConfig);
            _callListReportDetails = clientHelper.BuildApiCall<ListReportDetailsRequest, ListReportDetailsResponse>("ListReportDetails", grpcClient.ListReportDetailsAsync, grpcClient.ListReportDetails, effectiveSettings.ListReportDetailsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReportDetails);
            Modify_ListReportDetailsApiCall(ref _callListReportDetails);
            _callGetReportDetail = clientHelper.BuildApiCall<GetReportDetailRequest, ReportDetail>("GetReportDetail", grpcClient.GetReportDetailAsync, grpcClient.GetReportDetail, effectiveSettings.GetReportDetailSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReportDetail);
            Modify_GetReportDetailApiCall(ref _callGetReportDetail);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListReportConfigsApiCall(ref gaxgrpc::ApiCall<ListReportConfigsRequest, ListReportConfigsResponse> call);

        partial void Modify_GetReportConfigApiCall(ref gaxgrpc::ApiCall<GetReportConfigRequest, ReportConfig> call);

        partial void Modify_CreateReportConfigApiCall(ref gaxgrpc::ApiCall<CreateReportConfigRequest, ReportConfig> call);

        partial void Modify_UpdateReportConfigApiCall(ref gaxgrpc::ApiCall<UpdateReportConfigRequest, ReportConfig> call);

        partial void Modify_DeleteReportConfigApiCall(ref gaxgrpc::ApiCall<DeleteReportConfigRequest, wkt::Empty> call);

        partial void Modify_ListReportDetailsApiCall(ref gaxgrpc::ApiCall<ListReportDetailsRequest, ListReportDetailsResponse> call);

        partial void Modify_GetReportDetailApiCall(ref gaxgrpc::ApiCall<GetReportDetailRequest, ReportDetail> call);

        partial void OnConstruction(StorageInsights.StorageInsightsClient grpcClient, StorageInsightsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC StorageInsights client</summary>
        public override StorageInsights.StorageInsightsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListReportConfigsRequest(ref ListReportConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReportConfigRequest(ref GetReportConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReportConfigRequest(ref CreateReportConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateReportConfigRequest(ref UpdateReportConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReportConfigRequest(ref DeleteReportConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReportDetailsRequest(ref ListReportDetailsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReportDetailRequest(ref GetReportDetailRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReportConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigs(ListReportConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReportConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReportConfigsRequest, ListReportConfigsResponse, ReportConfig>(_callListReportConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReportConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigsAsync(ListReportConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReportConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReportConfigsRequest, ListReportConfigsResponse, ReportConfig>(_callListReportConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportConfig GetReportConfig(GetReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReportConfigRequest(ref request, ref callSettings);
            return _callGetReportConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportConfig> GetReportConfigAsync(GetReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReportConfigRequest(ref request, ref callSettings);
            return _callGetReportConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportConfig CreateReportConfig(CreateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReportConfigRequest(ref request, ref callSettings);
            return _callCreateReportConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportConfig> CreateReportConfigAsync(CreateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReportConfigRequest(ref request, ref callSettings);
            return _callCreateReportConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportConfig UpdateReportConfig(UpdateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReportConfigRequest(ref request, ref callSettings);
            return _callUpdateReportConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportConfig> UpdateReportConfigAsync(UpdateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReportConfigRequest(ref request, ref callSettings);
            return _callUpdateReportConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteReportConfig(DeleteReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReportConfigRequest(ref request, ref callSettings);
            _callDeleteReportConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteReportConfigAsync(DeleteReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReportConfigRequest(ref request, ref callSettings);
            return _callDeleteReportConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReportDetail"/> resources.</returns>
        public override gax::PagedEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetails(ListReportDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReportDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReportDetailsRequest, ListReportDetailsResponse, ReportDetail>(_callListReportDetails, request, callSettings);
        }

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReportDetail"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetailsAsync(ListReportDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReportDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReportDetailsRequest, ListReportDetailsResponse, ReportDetail>(_callListReportDetails, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportDetail GetReportDetail(GetReportDetailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReportDetailRequest(ref request, ref callSettings);
            return _callGetReportDetail.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportDetail> GetReportDetailAsync(GetReportDetailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReportDetailRequest(ref request, ref callSettings);
            return _callGetReportDetail.Async(request, callSettings);
        }
    }

    public partial class ListReportConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReportDetailsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReportConfigsResponse : gaxgrpc::IPageResponse<ReportConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReportConfig> GetEnumerator() => ReportConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReportDetailsResponse : gaxgrpc::IPageResponse<ReportDetail>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReportDetail> GetEnumerator() => ReportDetails.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class StorageInsights
    {
        public partial class StorageInsightsClient
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
