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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Settings for <see cref="FeaturedContentNativeDashboardServiceClient"/> instances.</summary>
    public sealed partial class FeaturedContentNativeDashboardServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="FeaturedContentNativeDashboardServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="FeaturedContentNativeDashboardServiceSettings"/>.
        /// </returns>
        public static FeaturedContentNativeDashboardServiceSettings GetDefault() =>
            new FeaturedContentNativeDashboardServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="FeaturedContentNativeDashboardServiceSettings"/> object with default settings.
        /// </summary>
        public FeaturedContentNativeDashboardServiceSettings()
        {
        }

        private FeaturedContentNativeDashboardServiceSettings(FeaturedContentNativeDashboardServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetFeaturedContentNativeDashboardSettings = existing.GetFeaturedContentNativeDashboardSettings;
            ListFeaturedContentNativeDashboardsSettings = existing.ListFeaturedContentNativeDashboardsSettings;
            InstallFeaturedContentNativeDashboardSettings = existing.InstallFeaturedContentNativeDashboardSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeaturedContentNativeDashboardServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturedContentNativeDashboardServiceClient.GetFeaturedContentNativeDashboard</c> and
        /// <c>FeaturedContentNativeDashboardServiceClient.GetFeaturedContentNativeDashboardAsync</c>.
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
        public gaxgrpc::CallSettings GetFeaturedContentNativeDashboardSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturedContentNativeDashboardServiceClient.ListFeaturedContentNativeDashboards</c> and
        /// <c>FeaturedContentNativeDashboardServiceClient.ListFeaturedContentNativeDashboardsAsync</c>.
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
        public gaxgrpc::CallSettings ListFeaturedContentNativeDashboardsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeaturedContentNativeDashboardServiceClient.InstallFeaturedContentNativeDashboard</c> and
        /// <c>FeaturedContentNativeDashboardServiceClient.InstallFeaturedContentNativeDashboardAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InstallFeaturedContentNativeDashboardSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FeaturedContentNativeDashboardServiceSettings"/> object.</returns>
        public FeaturedContentNativeDashboardServiceSettings Clone() =>
            new FeaturedContentNativeDashboardServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeaturedContentNativeDashboardServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class FeaturedContentNativeDashboardServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeaturedContentNativeDashboardServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeaturedContentNativeDashboardServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FeaturedContentNativeDashboardServiceClientBuilder() : base(FeaturedContentNativeDashboardServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FeaturedContentNativeDashboardServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeaturedContentNativeDashboardServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeaturedContentNativeDashboardServiceClient Build()
        {
            FeaturedContentNativeDashboardServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeaturedContentNativeDashboardServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeaturedContentNativeDashboardServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeaturedContentNativeDashboardServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeaturedContentNativeDashboardServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FeaturedContentNativeDashboardServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeaturedContentNativeDashboardServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeaturedContentNativeDashboardServiceClient.ChannelPool;
    }

    /// <summary>FeaturedContentNativeDashboardService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service provides functionality for managing
    /// FeaturedContentNativeDashboard.
    /// </remarks>
    public abstract partial class FeaturedContentNativeDashboardServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeaturedContentNativeDashboardService service, which is a host of
        /// "chronicle.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chronicle.googleapis.com:443";

        /// <summary>The default FeaturedContentNativeDashboardService scopes.</summary>
        /// <remarks>
        /// The default FeaturedContentNativeDashboardService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FeaturedContentNativeDashboardService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FeaturedContentNativeDashboardServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="FeaturedContentNativeDashboardServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>
        /// The task representing the created <see cref="FeaturedContentNativeDashboardServiceClient"/>.
        /// </returns>
        public static stt::Task<FeaturedContentNativeDashboardServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeaturedContentNativeDashboardServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeaturedContentNativeDashboardServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="FeaturedContentNativeDashboardServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FeaturedContentNativeDashboardServiceClient"/>.</returns>
        public static FeaturedContentNativeDashboardServiceClient Create() =>
            new FeaturedContentNativeDashboardServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeaturedContentNativeDashboardServiceClient"/> which uses the specified call invoker
        /// for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeaturedContentNativeDashboardServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FeaturedContentNativeDashboardServiceClient"/>.</returns>
        internal static FeaturedContentNativeDashboardServiceClient Create(grpccore::CallInvoker callInvoker, FeaturedContentNativeDashboardServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeaturedContentNativeDashboardService.FeaturedContentNativeDashboardServiceClient grpcClient = new FeaturedContentNativeDashboardService.FeaturedContentNativeDashboardServiceClient(callInvoker);
            return new FeaturedContentNativeDashboardServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FeaturedContentNativeDashboardService client</summary>
        public virtual FeaturedContentNativeDashboardService.FeaturedContentNativeDashboardServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get a native dashboard featured content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeaturedContentNativeDashboard GetFeaturedContentNativeDashboard(GetFeaturedContentNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a native dashboard featured content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeaturedContentNativeDashboard> GetFeaturedContentNativeDashboardAsync(GetFeaturedContentNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a native dashboard featured content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeaturedContentNativeDashboard> GetFeaturedContentNativeDashboardAsync(GetFeaturedContentNativeDashboardRequest request, st::CancellationToken cancellationToken) =>
            GetFeaturedContentNativeDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a native dashboard featured content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the FeaturedContentNativeDashboard to
        /// retrieve. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeaturedContentNativeDashboard GetFeaturedContentNativeDashboard(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeaturedContentNativeDashboard(new GetFeaturedContentNativeDashboardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a native dashboard featured content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the FeaturedContentNativeDashboard to
        /// retrieve. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeaturedContentNativeDashboard> GetFeaturedContentNativeDashboardAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeaturedContentNativeDashboardAsync(new GetFeaturedContentNativeDashboardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a native dashboard featured content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the FeaturedContentNativeDashboard to
        /// retrieve. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeaturedContentNativeDashboard> GetFeaturedContentNativeDashboardAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeaturedContentNativeDashboardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a native dashboard featured content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the FeaturedContentNativeDashboard to
        /// retrieve. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeaturedContentNativeDashboard GetFeaturedContentNativeDashboard(FeaturedContentNativeDashboardName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeaturedContentNativeDashboard(new GetFeaturedContentNativeDashboardRequest
            {
                FeaturedContentNativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a native dashboard featured content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the FeaturedContentNativeDashboard to
        /// retrieve. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeaturedContentNativeDashboard> GetFeaturedContentNativeDashboardAsync(FeaturedContentNativeDashboardName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeaturedContentNativeDashboardAsync(new GetFeaturedContentNativeDashboardRequest
            {
                FeaturedContentNativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a native dashboard featured content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the FeaturedContentNativeDashboard to
        /// retrieve. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeaturedContentNativeDashboard> GetFeaturedContentNativeDashboardAsync(FeaturedContentNativeDashboardName name, st::CancellationToken cancellationToken) =>
            GetFeaturedContentNativeDashboardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all native dashboards featured content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeaturedContentNativeDashboard"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard> ListFeaturedContentNativeDashboards(ListFeaturedContentNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all native dashboards featured content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="FeaturedContentNativeDashboard"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard> ListFeaturedContentNativeDashboardsAsync(ListFeaturedContentNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all native dashboards featured content.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// FeaturedContentNativeDashboards. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub
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
        /// <returns>A pageable sequence of <see cref="FeaturedContentNativeDashboard"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard> ListFeaturedContentNativeDashboards(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturedContentNativeDashboardsRequest request = new ListFeaturedContentNativeDashboardsRequest
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
            return ListFeaturedContentNativeDashboards(request, callSettings);
        }

        /// <summary>
        /// List all native dashboards featured content.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// FeaturedContentNativeDashboards. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub
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
        /// A pageable asynchronous sequence of <see cref="FeaturedContentNativeDashboard"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard> ListFeaturedContentNativeDashboardsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturedContentNativeDashboardsRequest request = new ListFeaturedContentNativeDashboardsRequest
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
            return ListFeaturedContentNativeDashboardsAsync(request, callSettings);
        }

        /// <summary>
        /// List all native dashboards featured content.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// FeaturedContentNativeDashboards. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub
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
        /// <returns>A pageable sequence of <see cref="FeaturedContentNativeDashboard"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard> ListFeaturedContentNativeDashboards(ContentHubName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturedContentNativeDashboardsRequest request = new ListFeaturedContentNativeDashboardsRequest
            {
                ParentAsContentHubName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeaturedContentNativeDashboards(request, callSettings);
        }

        /// <summary>
        /// List all native dashboards featured content.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// FeaturedContentNativeDashboards. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub
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
        /// A pageable asynchronous sequence of <see cref="FeaturedContentNativeDashboard"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard> ListFeaturedContentNativeDashboardsAsync(ContentHubName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeaturedContentNativeDashboardsRequest request = new ListFeaturedContentNativeDashboardsRequest
            {
                ParentAsContentHubName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeaturedContentNativeDashboardsAsync(request, callSettings);
        }

        /// <summary>
        /// Install a native dashboard featured content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstallFeaturedContentNativeDashboardResponse InstallFeaturedContentNativeDashboard(InstallFeaturedContentNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Install a native dashboard featured content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstallFeaturedContentNativeDashboardResponse> InstallFeaturedContentNativeDashboardAsync(InstallFeaturedContentNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Install a native dashboard featured content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstallFeaturedContentNativeDashboardResponse> InstallFeaturedContentNativeDashboardAsync(InstallFeaturedContentNativeDashboardRequest request, st::CancellationToken cancellationToken) =>
            InstallFeaturedContentNativeDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Install a native dashboard featured content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the FeaturedContentNativeDashboard to
        /// install. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstallFeaturedContentNativeDashboardResponse InstallFeaturedContentNativeDashboard(string name, gaxgrpc::CallSettings callSettings = null) =>
            InstallFeaturedContentNativeDashboard(new InstallFeaturedContentNativeDashboardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Install a native dashboard featured content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the FeaturedContentNativeDashboard to
        /// install. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstallFeaturedContentNativeDashboardResponse> InstallFeaturedContentNativeDashboardAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            InstallFeaturedContentNativeDashboardAsync(new InstallFeaturedContentNativeDashboardRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Install a native dashboard featured content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the FeaturedContentNativeDashboard to
        /// install. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstallFeaturedContentNativeDashboardResponse> InstallFeaturedContentNativeDashboardAsync(string name, st::CancellationToken cancellationToken) =>
            InstallFeaturedContentNativeDashboardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Install a native dashboard featured content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the FeaturedContentNativeDashboard to
        /// install. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InstallFeaturedContentNativeDashboardResponse InstallFeaturedContentNativeDashboard(FeaturedContentNativeDashboardName name, gaxgrpc::CallSettings callSettings = null) =>
            InstallFeaturedContentNativeDashboard(new InstallFeaturedContentNativeDashboardRequest
            {
                FeaturedContentNativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Install a native dashboard featured content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the FeaturedContentNativeDashboard to
        /// install. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstallFeaturedContentNativeDashboardResponse> InstallFeaturedContentNativeDashboardAsync(FeaturedContentNativeDashboardName name, gaxgrpc::CallSettings callSettings = null) =>
            InstallFeaturedContentNativeDashboardAsync(new InstallFeaturedContentNativeDashboardRequest
            {
                FeaturedContentNativeDashboardName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Install a native dashboard featured content.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the FeaturedContentNativeDashboard to
        /// install. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InstallFeaturedContentNativeDashboardResponse> InstallFeaturedContentNativeDashboardAsync(FeaturedContentNativeDashboardName name, st::CancellationToken cancellationToken) =>
            InstallFeaturedContentNativeDashboardAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FeaturedContentNativeDashboardService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service provides functionality for managing
    /// FeaturedContentNativeDashboard.
    /// </remarks>
    public sealed partial class FeaturedContentNativeDashboardServiceClientImpl : FeaturedContentNativeDashboardServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetFeaturedContentNativeDashboardRequest, FeaturedContentNativeDashboard> _callGetFeaturedContentNativeDashboard;

        private readonly gaxgrpc::ApiCall<ListFeaturedContentNativeDashboardsRequest, ListFeaturedContentNativeDashboardsResponse> _callListFeaturedContentNativeDashboards;

        private readonly gaxgrpc::ApiCall<InstallFeaturedContentNativeDashboardRequest, InstallFeaturedContentNativeDashboardResponse> _callInstallFeaturedContentNativeDashboard;

        /// <summary>
        /// Constructs a client wrapper for the FeaturedContentNativeDashboardService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="FeaturedContentNativeDashboardServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FeaturedContentNativeDashboardServiceClientImpl(FeaturedContentNativeDashboardService.FeaturedContentNativeDashboardServiceClient grpcClient, FeaturedContentNativeDashboardServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FeaturedContentNativeDashboardServiceSettings effectiveSettings = settings ?? FeaturedContentNativeDashboardServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetFeaturedContentNativeDashboard = clientHelper.BuildApiCall<GetFeaturedContentNativeDashboardRequest, FeaturedContentNativeDashboard>("GetFeaturedContentNativeDashboard", grpcClient.GetFeaturedContentNativeDashboardAsync, grpcClient.GetFeaturedContentNativeDashboard, effectiveSettings.GetFeaturedContentNativeDashboardSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFeaturedContentNativeDashboard);
            Modify_GetFeaturedContentNativeDashboardApiCall(ref _callGetFeaturedContentNativeDashboard);
            _callListFeaturedContentNativeDashboards = clientHelper.BuildApiCall<ListFeaturedContentNativeDashboardsRequest, ListFeaturedContentNativeDashboardsResponse>("ListFeaturedContentNativeDashboards", grpcClient.ListFeaturedContentNativeDashboardsAsync, grpcClient.ListFeaturedContentNativeDashboards, effectiveSettings.ListFeaturedContentNativeDashboardsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeaturedContentNativeDashboards);
            Modify_ListFeaturedContentNativeDashboardsApiCall(ref _callListFeaturedContentNativeDashboards);
            _callInstallFeaturedContentNativeDashboard = clientHelper.BuildApiCall<InstallFeaturedContentNativeDashboardRequest, InstallFeaturedContentNativeDashboardResponse>("InstallFeaturedContentNativeDashboard", grpcClient.InstallFeaturedContentNativeDashboardAsync, grpcClient.InstallFeaturedContentNativeDashboard, effectiveSettings.InstallFeaturedContentNativeDashboardSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callInstallFeaturedContentNativeDashboard);
            Modify_InstallFeaturedContentNativeDashboardApiCall(ref _callInstallFeaturedContentNativeDashboard);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetFeaturedContentNativeDashboardApiCall(ref gaxgrpc::ApiCall<GetFeaturedContentNativeDashboardRequest, FeaturedContentNativeDashboard> call);

        partial void Modify_ListFeaturedContentNativeDashboardsApiCall(ref gaxgrpc::ApiCall<ListFeaturedContentNativeDashboardsRequest, ListFeaturedContentNativeDashboardsResponse> call);

        partial void Modify_InstallFeaturedContentNativeDashboardApiCall(ref gaxgrpc::ApiCall<InstallFeaturedContentNativeDashboardRequest, InstallFeaturedContentNativeDashboardResponse> call);

        partial void OnConstruction(FeaturedContentNativeDashboardService.FeaturedContentNativeDashboardServiceClient grpcClient, FeaturedContentNativeDashboardServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeaturedContentNativeDashboardService client</summary>
        public override FeaturedContentNativeDashboardService.FeaturedContentNativeDashboardServiceClient GrpcClient { get; }

        partial void Modify_GetFeaturedContentNativeDashboardRequest(ref GetFeaturedContentNativeDashboardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeaturedContentNativeDashboardsRequest(ref ListFeaturedContentNativeDashboardsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InstallFeaturedContentNativeDashboardRequest(ref InstallFeaturedContentNativeDashboardRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get a native dashboard featured content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FeaturedContentNativeDashboard GetFeaturedContentNativeDashboard(GetFeaturedContentNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeaturedContentNativeDashboardRequest(ref request, ref callSettings);
            return _callGetFeaturedContentNativeDashboard.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a native dashboard featured content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FeaturedContentNativeDashboard> GetFeaturedContentNativeDashboardAsync(GetFeaturedContentNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeaturedContentNativeDashboardRequest(ref request, ref callSettings);
            return _callGetFeaturedContentNativeDashboard.Async(request, callSettings);
        }

        /// <summary>
        /// List all native dashboards featured content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeaturedContentNativeDashboard"/> resources.</returns>
        public override gax::PagedEnumerable<ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard> ListFeaturedContentNativeDashboards(ListFeaturedContentNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeaturedContentNativeDashboardsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFeaturedContentNativeDashboardsRequest, ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard>(_callListFeaturedContentNativeDashboards, request, callSettings);
        }

        /// <summary>
        /// List all native dashboards featured content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="FeaturedContentNativeDashboard"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard> ListFeaturedContentNativeDashboardsAsync(ListFeaturedContentNativeDashboardsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeaturedContentNativeDashboardsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFeaturedContentNativeDashboardsRequest, ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard>(_callListFeaturedContentNativeDashboards, request, callSettings);
        }

        /// <summary>
        /// Install a native dashboard featured content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InstallFeaturedContentNativeDashboardResponse InstallFeaturedContentNativeDashboard(InstallFeaturedContentNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InstallFeaturedContentNativeDashboardRequest(ref request, ref callSettings);
            return _callInstallFeaturedContentNativeDashboard.Sync(request, callSettings);
        }

        /// <summary>
        /// Install a native dashboard featured content.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InstallFeaturedContentNativeDashboardResponse> InstallFeaturedContentNativeDashboardAsync(InstallFeaturedContentNativeDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InstallFeaturedContentNativeDashboardRequest(ref request, ref callSettings);
            return _callInstallFeaturedContentNativeDashboard.Async(request, callSettings);
        }
    }

    public partial class ListFeaturedContentNativeDashboardsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFeaturedContentNativeDashboardsResponse : gaxgrpc::IPageResponse<FeaturedContentNativeDashboard>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FeaturedContentNativeDashboard> GetEnumerator() =>
            FeaturedContentNativeDashboards.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
