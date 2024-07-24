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

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>Settings for <see cref="UptimeCheckServiceClient"/> instances.</summary>
    public sealed partial class UptimeCheckServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UptimeCheckServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UptimeCheckServiceSettings"/>.</returns>
        public static UptimeCheckServiceSettings GetDefault() => new UptimeCheckServiceSettings();

        /// <summary>Constructs a new <see cref="UptimeCheckServiceSettings"/> object with default settings.</summary>
        public UptimeCheckServiceSettings()
        {
        }

        private UptimeCheckServiceSettings(UptimeCheckServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListUptimeCheckConfigsSettings = existing.ListUptimeCheckConfigsSettings;
            GetUptimeCheckConfigSettings = existing.GetUptimeCheckConfigSettings;
            CreateUptimeCheckConfigSettings = existing.CreateUptimeCheckConfigSettings;
            UpdateUptimeCheckConfigSettings = existing.UpdateUptimeCheckConfigSettings;
            DeleteUptimeCheckConfigSettings = existing.DeleteUptimeCheckConfigSettings;
            ListUptimeCheckIpsSettings = existing.ListUptimeCheckIpsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UptimeCheckServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.ListUptimeCheckConfigs</c> and
        /// <c>UptimeCheckServiceClient.ListUptimeCheckConfigsAsync</c>.
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
        public gaxgrpc::CallSettings ListUptimeCheckConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.GetUptimeCheckConfig</c> and
        /// <c>UptimeCheckServiceClient.GetUptimeCheckConfigAsync</c>.
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
        public gaxgrpc::CallSettings GetUptimeCheckConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.CreateUptimeCheckConfig</c> and
        /// <c>UptimeCheckServiceClient.CreateUptimeCheckConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateUptimeCheckConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.UpdateUptimeCheckConfig</c> and
        /// <c>UptimeCheckServiceClient.UpdateUptimeCheckConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateUptimeCheckConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.DeleteUptimeCheckConfig</c> and
        /// <c>UptimeCheckServiceClient.DeleteUptimeCheckConfigAsync</c>.
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
        public gaxgrpc::CallSettings DeleteUptimeCheckConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.ListUptimeCheckIps</c> and <c>UptimeCheckServiceClient.ListUptimeCheckIpsAsync</c>
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
        public gaxgrpc::CallSettings ListUptimeCheckIpsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UptimeCheckServiceSettings"/> object.</returns>
        public UptimeCheckServiceSettings Clone() => new UptimeCheckServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UptimeCheckServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class UptimeCheckServiceClientBuilder : gaxgrpc::ClientBuilderBase<UptimeCheckServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UptimeCheckServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public UptimeCheckServiceClientBuilder() : base(UptimeCheckServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref UptimeCheckServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UptimeCheckServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UptimeCheckServiceClient Build()
        {
            UptimeCheckServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UptimeCheckServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UptimeCheckServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UptimeCheckServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UptimeCheckServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<UptimeCheckServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UptimeCheckServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UptimeCheckServiceClient.ChannelPool;
    }

    /// <summary>UptimeCheckService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The UptimeCheckService API is used to manage (list, create, delete, edit)
    /// Uptime check configurations in the Cloud Monitoring product. An Uptime
    /// check is a piece of configuration that determines which resources and
    /// services to monitor for availability. These configurations can also be
    /// configured interactively by navigating to the [Cloud console]
    /// (https://console.cloud.google.com), selecting the appropriate project,
    /// clicking on "Monitoring" on the left-hand side to navigate to Cloud
    /// Monitoring, and then clicking on "Uptime".
    /// </remarks>
    public abstract partial class UptimeCheckServiceClient
    {
        /// <summary>
        /// The default endpoint for the UptimeCheckService service, which is a host of "monitoring.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "monitoring.googleapis.com:443";

        /// <summary>The default UptimeCheckService scopes.</summary>
        /// <remarks>
        /// The default UptimeCheckService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring.read</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(UptimeCheckService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="UptimeCheckServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UptimeCheckServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UptimeCheckServiceClient"/>.</returns>
        public static stt::Task<UptimeCheckServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UptimeCheckServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UptimeCheckServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UptimeCheckServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="UptimeCheckServiceClient"/>.</returns>
        public static UptimeCheckServiceClient Create() => new UptimeCheckServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UptimeCheckServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UptimeCheckServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="UptimeCheckServiceClient"/>.</returns>
        internal static UptimeCheckServiceClient Create(grpccore::CallInvoker callInvoker, UptimeCheckServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UptimeCheckService.UptimeCheckServiceClient grpcClient = new UptimeCheckService.UptimeCheckServiceClient(callInvoker);
            return new UptimeCheckServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC UptimeCheckService client</summary>
        public virtual UptimeCheckService.UptimeCheckServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UptimeCheckConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigs(ListUptimeCheckConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UptimeCheckConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigsAsync(ListUptimeCheckConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// Uptime check configurations are listed. The format is:
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
        /// <returns>A pageable sequence of <see cref="UptimeCheckConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUptimeCheckConfigsRequest request = new ListUptimeCheckConfigsRequest
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
            return ListUptimeCheckConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// Uptime check configurations are listed. The format is:
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
        /// <returns>A pageable asynchronous sequence of <see cref="UptimeCheckConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUptimeCheckConfigsRequest request = new ListUptimeCheckConfigsRequest
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
            return ListUptimeCheckConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// Uptime check configurations are listed. The format is:
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
        /// <returns>A pageable sequence of <see cref="UptimeCheckConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigs(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUptimeCheckConfigsRequest request = new ListUptimeCheckConfigsRequest
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
            return ListUptimeCheckConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// Uptime check configurations are listed. The format is:
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
        /// <returns>A pageable asynchronous sequence of <see cref="UptimeCheckConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUptimeCheckConfigsRequest request = new ListUptimeCheckConfigsRequest
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
            return ListUptimeCheckConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// Uptime check configurations are listed. The format is:
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
        /// <returns>A pageable sequence of <see cref="UptimeCheckConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigs(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUptimeCheckConfigsRequest request = new ListUptimeCheckConfigsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUptimeCheckConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// Uptime check configurations are listed. The format is:
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
        /// <returns>A pageable asynchronous sequence of <see cref="UptimeCheckConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigsAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUptimeCheckConfigsRequest request = new ListUptimeCheckConfigsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUptimeCheckConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// Uptime check configurations are listed. The format is:
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
        /// <returns>A pageable sequence of <see cref="UptimeCheckConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigs(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUptimeCheckConfigsRequest request = new ListUptimeCheckConfigsRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUptimeCheckConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// Uptime check configurations are listed. The format is:
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
        /// <returns>A pageable asynchronous sequence of <see cref="UptimeCheckConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigsAsync(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUptimeCheckConfigsRequest request = new ListUptimeCheckConfigsRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUptimeCheckConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// Uptime check configurations are listed. The format is:
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
        /// <returns>A pageable sequence of <see cref="UptimeCheckConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigs(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUptimeCheckConfigsRequest request = new ListUptimeCheckConfigsRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUptimeCheckConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// Uptime check configurations are listed. The format is:
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
        /// <returns>A pageable asynchronous sequence of <see cref="UptimeCheckConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigsAsync(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUptimeCheckConfigsRequest request = new ListUptimeCheckConfigsRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUptimeCheckConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UptimeCheckConfig GetUptimeCheckConfig(GetUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(GetUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(GetUptimeCheckConfigRequest request, st::CancellationToken cancellationToken) =>
            GetUptimeCheckConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UptimeCheckConfig GetUptimeCheckConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUptimeCheckConfig(new GetUptimeCheckConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetUptimeCheckConfigAsync(new GetUptimeCheckConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetUptimeCheckConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UptimeCheckConfig GetUptimeCheckConfig(UptimeCheckConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUptimeCheckConfig(new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(UptimeCheckConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUptimeCheckConfigAsync(new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(UptimeCheckConfigName name, st::CancellationToken cancellationToken) =>
            GetUptimeCheckConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UptimeCheckConfig GetUptimeCheckConfig(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUptimeCheckConfig(new GetUptimeCheckConfigRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetUptimeCheckConfigAsync(new GetUptimeCheckConfigRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            GetUptimeCheckConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UptimeCheckConfig CreateUptimeCheckConfig(CreateUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(CreateUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(CreateUptimeCheckConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateUptimeCheckConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UptimeCheckConfig CreateUptimeCheckConfig(string parent, UptimeCheckConfig uptimeCheckConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateUptimeCheckConfig(new CreateUptimeCheckConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(string parent, UptimeCheckConfig uptimeCheckConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateUptimeCheckConfigAsync(new CreateUptimeCheckConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(string parent, UptimeCheckConfig uptimeCheckConfig, st::CancellationToken cancellationToken) =>
            CreateUptimeCheckConfigAsync(parent, uptimeCheckConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UptimeCheckConfig CreateUptimeCheckConfig(gagr::ProjectName parent, UptimeCheckConfig uptimeCheckConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateUptimeCheckConfig(new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(gagr::ProjectName parent, UptimeCheckConfig uptimeCheckConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateUptimeCheckConfigAsync(new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(gagr::ProjectName parent, UptimeCheckConfig uptimeCheckConfig, st::CancellationToken cancellationToken) =>
            CreateUptimeCheckConfigAsync(parent, uptimeCheckConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UptimeCheckConfig CreateUptimeCheckConfig(gagr::OrganizationName parent, UptimeCheckConfig uptimeCheckConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateUptimeCheckConfig(new CreateUptimeCheckConfigRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(gagr::OrganizationName parent, UptimeCheckConfig uptimeCheckConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateUptimeCheckConfigAsync(new CreateUptimeCheckConfigRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(gagr::OrganizationName parent, UptimeCheckConfig uptimeCheckConfig, st::CancellationToken cancellationToken) =>
            CreateUptimeCheckConfigAsync(parent, uptimeCheckConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UptimeCheckConfig CreateUptimeCheckConfig(gagr::FolderName parent, UptimeCheckConfig uptimeCheckConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateUptimeCheckConfig(new CreateUptimeCheckConfigRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(gagr::FolderName parent, UptimeCheckConfig uptimeCheckConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateUptimeCheckConfigAsync(new CreateUptimeCheckConfigRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(gagr::FolderName parent, UptimeCheckConfig uptimeCheckConfig, st::CancellationToken cancellationToken) =>
            CreateUptimeCheckConfigAsync(parent, uptimeCheckConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UptimeCheckConfig CreateUptimeCheckConfig(gax::IResourceName parent, UptimeCheckConfig uptimeCheckConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateUptimeCheckConfig(new CreateUptimeCheckConfigRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(gax::IResourceName parent, UptimeCheckConfig uptimeCheckConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateUptimeCheckConfigAsync(new CreateUptimeCheckConfigRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the Uptime check. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// Required. The new Uptime check configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(gax::IResourceName parent, UptimeCheckConfig uptimeCheckConfig, st::CancellationToken cancellationToken) =>
            CreateUptimeCheckConfigAsync(parent, uptimeCheckConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UptimeCheckConfig UpdateUptimeCheckConfig(UpdateUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(UpdateUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(UpdateUptimeCheckConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateUptimeCheckConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="uptimeCheckConfig">
        /// Required. If an `updateMask` has been specified, this field gives
        /// the values for the set of fields mentioned in the `updateMask`. If an
        /// `updateMask` has not been given, this Uptime check configuration replaces
        /// the current configuration. If a field is mentioned in `updateMask` but
        /// the corresponding field is omitted in this partial Uptime check
        /// configuration, it has the effect of deleting/clearing the field from the
        /// configuration on the server.
        /// 
        /// The following fields can be updated: `display_name`,
        /// `http_check`, `tcp_check`, `timeout`, `content_matchers`, and
        /// `selected_regions`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UptimeCheckConfig UpdateUptimeCheckConfig(UptimeCheckConfig uptimeCheckConfig, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUptimeCheckConfig(new UpdateUptimeCheckConfigRequest
            {
                UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
            }, callSettings);

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="uptimeCheckConfig">
        /// Required. If an `updateMask` has been specified, this field gives
        /// the values for the set of fields mentioned in the `updateMask`. If an
        /// `updateMask` has not been given, this Uptime check configuration replaces
        /// the current configuration. If a field is mentioned in `updateMask` but
        /// the corresponding field is omitted in this partial Uptime check
        /// configuration, it has the effect of deleting/clearing the field from the
        /// configuration on the server.
        /// 
        /// The following fields can be updated: `display_name`,
        /// `http_check`, `tcp_check`, `timeout`, `content_matchers`, and
        /// `selected_regions`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(UptimeCheckConfig uptimeCheckConfig, gaxgrpc::CallSettings callSettings = null) =>
            UpdateUptimeCheckConfigAsync(new UpdateUptimeCheckConfigRequest
            {
                UptimeCheckConfig = gax::GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
            }, callSettings);

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="uptimeCheckConfig">
        /// Required. If an `updateMask` has been specified, this field gives
        /// the values for the set of fields mentioned in the `updateMask`. If an
        /// `updateMask` has not been given, this Uptime check configuration replaces
        /// the current configuration. If a field is mentioned in `updateMask` but
        /// the corresponding field is omitted in this partial Uptime check
        /// configuration, it has the effect of deleting/clearing the field from the
        /// configuration on the server.
        /// 
        /// The following fields can be updated: `display_name`,
        /// `http_check`, `tcp_check`, `timeout`, `content_matchers`, and
        /// `selected_regions`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(UptimeCheckConfig uptimeCheckConfig, st::CancellationToken cancellationToken) =>
            UpdateUptimeCheckConfigAsync(uptimeCheckConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUptimeCheckConfig(DeleteUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUptimeCheckConfigAsync(DeleteUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUptimeCheckConfigAsync(DeleteUptimeCheckConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteUptimeCheckConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUptimeCheckConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUptimeCheckConfig(new DeleteUptimeCheckConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUptimeCheckConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUptimeCheckConfigAsync(new DeleteUptimeCheckConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUptimeCheckConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteUptimeCheckConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUptimeCheckConfig(UptimeCheckConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUptimeCheckConfig(new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUptimeCheckConfigAsync(UptimeCheckConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUptimeCheckConfigAsync(new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUptimeCheckConfigAsync(UptimeCheckConfigName name, st::CancellationToken cancellationToken) =>
            DeleteUptimeCheckConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteUptimeCheckConfig(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUptimeCheckConfig(new DeleteUptimeCheckConfigRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUptimeCheckConfigAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteUptimeCheckConfigAsync(new DeleteUptimeCheckConfigRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The Uptime check configuration to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/uptimeCheckConfigs/[UPTIME_CHECK_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteUptimeCheckConfigAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            DeleteUptimeCheckConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of IP addresses that checkers run from
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UptimeCheckIp"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> ListUptimeCheckIps(ListUptimeCheckIpsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of IP addresses that checkers run from
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UptimeCheckIp"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> ListUptimeCheckIpsAsync(ListUptimeCheckIpsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>UptimeCheckService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The UptimeCheckService API is used to manage (list, create, delete, edit)
    /// Uptime check configurations in the Cloud Monitoring product. An Uptime
    /// check is a piece of configuration that determines which resources and
    /// services to monitor for availability. These configurations can also be
    /// configured interactively by navigating to the [Cloud console]
    /// (https://console.cloud.google.com), selecting the appropriate project,
    /// clicking on "Monitoring" on the left-hand side to navigate to Cloud
    /// Monitoring, and then clicking on "Uptime".
    /// </remarks>
    public sealed partial class UptimeCheckServiceClientImpl : UptimeCheckServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse> _callListUptimeCheckConfigs;

        private readonly gaxgrpc::ApiCall<GetUptimeCheckConfigRequest, UptimeCheckConfig> _callGetUptimeCheckConfig;

        private readonly gaxgrpc::ApiCall<CreateUptimeCheckConfigRequest, UptimeCheckConfig> _callCreateUptimeCheckConfig;

        private readonly gaxgrpc::ApiCall<UpdateUptimeCheckConfigRequest, UptimeCheckConfig> _callUpdateUptimeCheckConfig;

        private readonly gaxgrpc::ApiCall<DeleteUptimeCheckConfigRequest, wkt::Empty> _callDeleteUptimeCheckConfig;

        private readonly gaxgrpc::ApiCall<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse> _callListUptimeCheckIps;

        /// <summary>
        /// Constructs a client wrapper for the UptimeCheckService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UptimeCheckServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public UptimeCheckServiceClientImpl(UptimeCheckService.UptimeCheckServiceClient grpcClient, UptimeCheckServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            UptimeCheckServiceSettings effectiveSettings = settings ?? UptimeCheckServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListUptimeCheckConfigs = clientHelper.BuildApiCall<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse>("ListUptimeCheckConfigs", grpcClient.ListUptimeCheckConfigsAsync, grpcClient.ListUptimeCheckConfigs, effectiveSettings.ListUptimeCheckConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUptimeCheckConfigs);
            Modify_ListUptimeCheckConfigsApiCall(ref _callListUptimeCheckConfigs);
            _callGetUptimeCheckConfig = clientHelper.BuildApiCall<GetUptimeCheckConfigRequest, UptimeCheckConfig>("GetUptimeCheckConfig", grpcClient.GetUptimeCheckConfigAsync, grpcClient.GetUptimeCheckConfig, effectiveSettings.GetUptimeCheckConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetUptimeCheckConfig);
            Modify_GetUptimeCheckConfigApiCall(ref _callGetUptimeCheckConfig);
            _callCreateUptimeCheckConfig = clientHelper.BuildApiCall<CreateUptimeCheckConfigRequest, UptimeCheckConfig>("CreateUptimeCheckConfig", grpcClient.CreateUptimeCheckConfigAsync, grpcClient.CreateUptimeCheckConfig, effectiveSettings.CreateUptimeCheckConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateUptimeCheckConfig);
            Modify_CreateUptimeCheckConfigApiCall(ref _callCreateUptimeCheckConfig);
            _callUpdateUptimeCheckConfig = clientHelper.BuildApiCall<UpdateUptimeCheckConfigRequest, UptimeCheckConfig>("UpdateUptimeCheckConfig", grpcClient.UpdateUptimeCheckConfigAsync, grpcClient.UpdateUptimeCheckConfig, effectiveSettings.UpdateUptimeCheckConfigSettings).WithGoogleRequestParam("uptime_check_config.name", request => request.UptimeCheckConfig?.Name);
            Modify_ApiCall(ref _callUpdateUptimeCheckConfig);
            Modify_UpdateUptimeCheckConfigApiCall(ref _callUpdateUptimeCheckConfig);
            _callDeleteUptimeCheckConfig = clientHelper.BuildApiCall<DeleteUptimeCheckConfigRequest, wkt::Empty>("DeleteUptimeCheckConfig", grpcClient.DeleteUptimeCheckConfigAsync, grpcClient.DeleteUptimeCheckConfig, effectiveSettings.DeleteUptimeCheckConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteUptimeCheckConfig);
            Modify_DeleteUptimeCheckConfigApiCall(ref _callDeleteUptimeCheckConfig);
            _callListUptimeCheckIps = clientHelper.BuildApiCall<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse>("ListUptimeCheckIps", grpcClient.ListUptimeCheckIpsAsync, grpcClient.ListUptimeCheckIps, effectiveSettings.ListUptimeCheckIpsSettings);
            Modify_ApiCall(ref _callListUptimeCheckIps);
            Modify_ListUptimeCheckIpsApiCall(ref _callListUptimeCheckIps);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListUptimeCheckConfigsApiCall(ref gaxgrpc::ApiCall<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse> call);

        partial void Modify_GetUptimeCheckConfigApiCall(ref gaxgrpc::ApiCall<GetUptimeCheckConfigRequest, UptimeCheckConfig> call);

        partial void Modify_CreateUptimeCheckConfigApiCall(ref gaxgrpc::ApiCall<CreateUptimeCheckConfigRequest, UptimeCheckConfig> call);

        partial void Modify_UpdateUptimeCheckConfigApiCall(ref gaxgrpc::ApiCall<UpdateUptimeCheckConfigRequest, UptimeCheckConfig> call);

        partial void Modify_DeleteUptimeCheckConfigApiCall(ref gaxgrpc::ApiCall<DeleteUptimeCheckConfigRequest, wkt::Empty> call);

        partial void Modify_ListUptimeCheckIpsApiCall(ref gaxgrpc::ApiCall<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse> call);

        partial void OnConstruction(UptimeCheckService.UptimeCheckServiceClient grpcClient, UptimeCheckServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UptimeCheckService client</summary>
        public override UptimeCheckService.UptimeCheckServiceClient GrpcClient { get; }

        partial void Modify_ListUptimeCheckConfigsRequest(ref ListUptimeCheckConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUptimeCheckConfigRequest(ref GetUptimeCheckConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateUptimeCheckConfigRequest(ref CreateUptimeCheckConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUptimeCheckConfigRequest(ref UpdateUptimeCheckConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUptimeCheckConfigRequest(ref DeleteUptimeCheckConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUptimeCheckIpsRequest(ref ListUptimeCheckIpsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UptimeCheckConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigs(ListUptimeCheckConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUptimeCheckConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse, UptimeCheckConfig>(_callListUptimeCheckConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists the existing valid Uptime check configurations for the project
        /// (leaving out any invalid configurations).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UptimeCheckConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigsAsync(ListUptimeCheckConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUptimeCheckConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse, UptimeCheckConfig>(_callListUptimeCheckConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UptimeCheckConfig GetUptimeCheckConfig(GetUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callGetUptimeCheckConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single Uptime check configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(GetUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callGetUptimeCheckConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UptimeCheckConfig CreateUptimeCheckConfig(CreateUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callCreateUptimeCheckConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new Uptime check configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(CreateUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callCreateUptimeCheckConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UptimeCheckConfig UpdateUptimeCheckConfig(UpdateUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callUpdateUptimeCheckConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an Uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `updateMask`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(UpdateUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callUpdateUptimeCheckConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteUptimeCheckConfig(DeleteUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUptimeCheckConfigRequest(ref request, ref callSettings);
            _callDeleteUptimeCheckConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an Uptime check configuration. Note that this method will fail
        /// if the Uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteUptimeCheckConfigAsync(DeleteUptimeCheckConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callDeleteUptimeCheckConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of IP addresses that checkers run from
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UptimeCheckIp"/> resources.</returns>
        public override gax::PagedEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> ListUptimeCheckIps(ListUptimeCheckIpsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUptimeCheckIpsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse, UptimeCheckIp>(_callListUptimeCheckIps, request, callSettings);
        }

        /// <summary>
        /// Returns the list of IP addresses that checkers run from
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UptimeCheckIp"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> ListUptimeCheckIpsAsync(ListUptimeCheckIpsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUptimeCheckIpsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse, UptimeCheckIp>(_callListUptimeCheckIps, request, callSettings);
        }
    }

    public partial class ListUptimeCheckConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUptimeCheckIpsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUptimeCheckConfigsResponse : gaxgrpc::IPageResponse<UptimeCheckConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UptimeCheckConfig> GetEnumerator() => UptimeCheckConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUptimeCheckIpsResponse : gaxgrpc::IPageResponse<UptimeCheckIp>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UptimeCheckIp> GetEnumerator() => UptimeCheckIps.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
