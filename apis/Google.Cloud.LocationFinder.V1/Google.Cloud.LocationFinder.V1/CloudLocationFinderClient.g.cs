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

namespace Google.Cloud.LocationFinder.V1
{
    /// <summary>Settings for <see cref="CloudLocationFinderClient"/> instances.</summary>
    public sealed partial class CloudLocationFinderSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudLocationFinderSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudLocationFinderSettings"/>.</returns>
        public static CloudLocationFinderSettings GetDefault() => new CloudLocationFinderSettings();

        /// <summary>Constructs a new <see cref="CloudLocationFinderSettings"/> object with default settings.</summary>
        public CloudLocationFinderSettings()
        {
        }

        private CloudLocationFinderSettings(CloudLocationFinderSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListCloudLocationsSettings = existing.ListCloudLocationsSettings;
            GetCloudLocationSettings = existing.GetCloudLocationSettings;
            SearchCloudLocationsSettings = existing.SearchCloudLocationsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudLocationFinderSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudLocationFinderClient.ListCloudLocations</c> and <c>CloudLocationFinderClient.ListCloudLocationsAsync</c>
        /// .
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
        public gaxgrpc::CallSettings ListCloudLocationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudLocationFinderClient.GetCloudLocation</c> and <c>CloudLocationFinderClient.GetCloudLocationAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GetCloudLocationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudLocationFinderClient.SearchCloudLocations</c> and
        /// <c>CloudLocationFinderClient.SearchCloudLocationsAsync</c>.
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
        public gaxgrpc::CallSettings SearchCloudLocationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudLocationFinderSettings"/> object.</returns>
        public CloudLocationFinderSettings Clone() => new CloudLocationFinderSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudLocationFinderClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CloudLocationFinderClientBuilder : gaxgrpc::ClientBuilderBase<CloudLocationFinderClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudLocationFinderSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudLocationFinderClientBuilder() : base(CloudLocationFinderClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudLocationFinderClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudLocationFinderClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudLocationFinderClient Build()
        {
            CloudLocationFinderClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudLocationFinderClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudLocationFinderClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudLocationFinderClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudLocationFinderClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudLocationFinderClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudLocationFinderClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudLocationFinderClient.ChannelPool;
    }

    /// <summary>CloudLocationFinder client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class CloudLocationFinderClient
    {
        /// <summary>
        /// The default endpoint for the CloudLocationFinder service, which is a host of
        /// "cloudlocationfinder.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudlocationfinder.googleapis.com:443";

        /// <summary>The default CloudLocationFinder scopes.</summary>
        /// <remarks>
        /// The default CloudLocationFinder scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudLocationFinder.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudLocationFinderClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CloudLocationFinderClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudLocationFinderClient"/>.</returns>
        public static stt::Task<CloudLocationFinderClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudLocationFinderClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudLocationFinderClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CloudLocationFinderClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudLocationFinderClient"/>.</returns>
        public static CloudLocationFinderClient Create() => new CloudLocationFinderClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudLocationFinderClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudLocationFinderSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudLocationFinderClient"/>.</returns>
        internal static CloudLocationFinderClient Create(grpccore::CallInvoker callInvoker, CloudLocationFinderSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudLocationFinder.CloudLocationFinderClient grpcClient = new CloudLocationFinder.CloudLocationFinderClient(callInvoker);
            return new CloudLocationFinderClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudLocationFinder client</summary>
        public virtual CloudLocationFinder.CloudLocationFinderClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists cloud locations under a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudLocation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudLocationsResponse, CloudLocation> ListCloudLocations(ListCloudLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists cloud locations under a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudLocation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudLocationsResponse, CloudLocation> ListCloudLocationsAsync(ListCloudLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists cloud locations under a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of cloud locations.
        /// Format: projects/{project}/locations/{location}
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
        /// <returns>A pageable sequence of <see cref="CloudLocation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudLocationsResponse, CloudLocation> ListCloudLocations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudLocationsRequest request = new ListCloudLocationsRequest
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
            return ListCloudLocations(request, callSettings);
        }

        /// <summary>
        /// Lists cloud locations under a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of cloud locations.
        /// Format: projects/{project}/locations/{location}
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
        /// <returns>A pageable asynchronous sequence of <see cref="CloudLocation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudLocationsResponse, CloudLocation> ListCloudLocationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudLocationsRequest request = new ListCloudLocationsRequest
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
            return ListCloudLocationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists cloud locations under a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of cloud locations.
        /// Format: projects/{project}/locations/{location}
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
        /// <returns>A pageable sequence of <see cref="CloudLocation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudLocationsResponse, CloudLocation> ListCloudLocations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudLocationsRequest request = new ListCloudLocationsRequest
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
            return ListCloudLocations(request, callSettings);
        }

        /// <summary>
        /// Lists cloud locations under a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of cloud locations.
        /// Format: projects/{project}/locations/{location}
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
        /// <returns>A pageable asynchronous sequence of <see cref="CloudLocation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudLocationsResponse, CloudLocation> ListCloudLocationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudLocationsRequest request = new ListCloudLocationsRequest
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
            return ListCloudLocationsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about a cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudLocation GetCloudLocation(GetCloudLocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a resource containing information about a cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudLocation> GetCloudLocationAsync(GetCloudLocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a resource containing information about a cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudLocation> GetCloudLocationAsync(GetCloudLocationRequest request, st::CancellationToken cancellationToken) =>
            GetCloudLocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a resource containing information about a cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudLocation GetCloudLocation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudLocation(new GetCloudLocationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about a cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudLocation> GetCloudLocationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudLocationAsync(new GetCloudLocationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about a cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudLocation> GetCloudLocationAsync(string name, st::CancellationToken cancellationToken) =>
            GetCloudLocationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a resource containing information about a cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudLocation GetCloudLocation(CloudLocationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudLocation(new GetCloudLocationRequest
            {
                CloudLocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about a cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudLocation> GetCloudLocationAsync(CloudLocationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudLocationAsync(new GetCloudLocationRequest
            {
                CloudLocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about a cloud location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudLocation> GetCloudLocationAsync(CloudLocationName name, st::CancellationToken cancellationToken) =>
            GetCloudLocationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches for cloud locations from a given source location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudLocation"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchCloudLocationsResponse, CloudLocation> SearchCloudLocations(SearchCloudLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for cloud locations from a given source location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudLocation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchCloudLocationsResponse, CloudLocation> SearchCloudLocationsAsync(SearchCloudLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for cloud locations from a given source location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of cloud locations.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="sourceCloudLocation">
        /// Required. The source cloud location to search from.
        /// Example search can be searching nearby cloud locations from the source
        /// cloud location by latency.
        /// </param>
        /// <param name="query">
        /// Optional. The query string in search query syntax. While filter is used to
        /// filter the search results by attributes, query is used to specify the
        /// search requirements.
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
        /// <returns>A pageable sequence of <see cref="CloudLocation"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchCloudLocationsResponse, CloudLocation> SearchCloudLocations(string parent, string sourceCloudLocation, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchCloudLocationsRequest request = new SearchCloudLocationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SourceCloudLocation = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceCloudLocation, nameof(sourceCloudLocation)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchCloudLocations(request, callSettings);
        }

        /// <summary>
        /// Searches for cloud locations from a given source location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of cloud locations.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="sourceCloudLocation">
        /// Required. The source cloud location to search from.
        /// Example search can be searching nearby cloud locations from the source
        /// cloud location by latency.
        /// </param>
        /// <param name="query">
        /// Optional. The query string in search query syntax. While filter is used to
        /// filter the search results by attributes, query is used to specify the
        /// search requirements.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CloudLocation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchCloudLocationsResponse, CloudLocation> SearchCloudLocationsAsync(string parent, string sourceCloudLocation, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchCloudLocationsRequest request = new SearchCloudLocationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SourceCloudLocation = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceCloudLocation, nameof(sourceCloudLocation)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchCloudLocationsAsync(request, callSettings);
        }

        /// <summary>
        /// Searches for cloud locations from a given source location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of cloud locations.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="sourceCloudLocation">
        /// Required. The source cloud location to search from.
        /// Example search can be searching nearby cloud locations from the source
        /// cloud location by latency.
        /// </param>
        /// <param name="query">
        /// Optional. The query string in search query syntax. While filter is used to
        /// filter the search results by attributes, query is used to specify the
        /// search requirements.
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
        /// <returns>A pageable sequence of <see cref="CloudLocation"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchCloudLocationsResponse, CloudLocation> SearchCloudLocations(gagr::LocationName parent, CloudLocationName sourceCloudLocation, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchCloudLocationsRequest request = new SearchCloudLocationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SourceCloudLocationAsCloudLocationName = gax::GaxPreconditions.CheckNotNull(sourceCloudLocation, nameof(sourceCloudLocation)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchCloudLocations(request, callSettings);
        }

        /// <summary>
        /// Searches for cloud locations from a given source location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of cloud locations.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="sourceCloudLocation">
        /// Required. The source cloud location to search from.
        /// Example search can be searching nearby cloud locations from the source
        /// cloud location by latency.
        /// </param>
        /// <param name="query">
        /// Optional. The query string in search query syntax. While filter is used to
        /// filter the search results by attributes, query is used to specify the
        /// search requirements.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CloudLocation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchCloudLocationsResponse, CloudLocation> SearchCloudLocationsAsync(gagr::LocationName parent, CloudLocationName sourceCloudLocation, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchCloudLocationsRequest request = new SearchCloudLocationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SourceCloudLocationAsCloudLocationName = gax::GaxPreconditions.CheckNotNull(sourceCloudLocation, nameof(sourceCloudLocation)),
                Query = query ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchCloudLocationsAsync(request, callSettings);
        }
    }

    /// <summary>CloudLocationFinder client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class CloudLocationFinderClientImpl : CloudLocationFinderClient
    {
        private readonly gaxgrpc::ApiCall<ListCloudLocationsRequest, ListCloudLocationsResponse> _callListCloudLocations;

        private readonly gaxgrpc::ApiCall<GetCloudLocationRequest, CloudLocation> _callGetCloudLocation;

        private readonly gaxgrpc::ApiCall<SearchCloudLocationsRequest, SearchCloudLocationsResponse> _callSearchCloudLocations;

        /// <summary>
        /// Constructs a client wrapper for the CloudLocationFinder service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudLocationFinderSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudLocationFinderClientImpl(CloudLocationFinder.CloudLocationFinderClient grpcClient, CloudLocationFinderSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudLocationFinderSettings effectiveSettings = settings ?? CloudLocationFinderSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListCloudLocations = clientHelper.BuildApiCall<ListCloudLocationsRequest, ListCloudLocationsResponse>("ListCloudLocations", grpcClient.ListCloudLocationsAsync, grpcClient.ListCloudLocations, effectiveSettings.ListCloudLocationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCloudLocations);
            Modify_ListCloudLocationsApiCall(ref _callListCloudLocations);
            _callGetCloudLocation = clientHelper.BuildApiCall<GetCloudLocationRequest, CloudLocation>("GetCloudLocation", grpcClient.GetCloudLocationAsync, grpcClient.GetCloudLocation, effectiveSettings.GetCloudLocationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCloudLocation);
            Modify_GetCloudLocationApiCall(ref _callGetCloudLocation);
            _callSearchCloudLocations = clientHelper.BuildApiCall<SearchCloudLocationsRequest, SearchCloudLocationsResponse>("SearchCloudLocations", grpcClient.SearchCloudLocationsAsync, grpcClient.SearchCloudLocations, effectiveSettings.SearchCloudLocationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchCloudLocations);
            Modify_SearchCloudLocationsApiCall(ref _callSearchCloudLocations);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListCloudLocationsApiCall(ref gaxgrpc::ApiCall<ListCloudLocationsRequest, ListCloudLocationsResponse> call);

        partial void Modify_GetCloudLocationApiCall(ref gaxgrpc::ApiCall<GetCloudLocationRequest, CloudLocation> call);

        partial void Modify_SearchCloudLocationsApiCall(ref gaxgrpc::ApiCall<SearchCloudLocationsRequest, SearchCloudLocationsResponse> call);

        partial void OnConstruction(CloudLocationFinder.CloudLocationFinderClient grpcClient, CloudLocationFinderSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudLocationFinder client</summary>
        public override CloudLocationFinder.CloudLocationFinderClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListCloudLocationsRequest(ref ListCloudLocationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCloudLocationRequest(ref GetCloudLocationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchCloudLocationsRequest(ref SearchCloudLocationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists cloud locations under a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudLocation"/> resources.</returns>
        public override gax::PagedEnumerable<ListCloudLocationsResponse, CloudLocation> ListCloudLocations(ListCloudLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCloudLocationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCloudLocationsRequest, ListCloudLocationsResponse, CloudLocation>(_callListCloudLocations, request, callSettings);
        }

        /// <summary>
        /// Lists cloud locations under a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudLocation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCloudLocationsResponse, CloudLocation> ListCloudLocationsAsync(ListCloudLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCloudLocationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCloudLocationsRequest, ListCloudLocationsResponse, CloudLocation>(_callListCloudLocations, request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about a cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CloudLocation GetCloudLocation(GetCloudLocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCloudLocationRequest(ref request, ref callSettings);
            return _callGetCloudLocation.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about a cloud location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CloudLocation> GetCloudLocationAsync(GetCloudLocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCloudLocationRequest(ref request, ref callSettings);
            return _callGetCloudLocation.Async(request, callSettings);
        }

        /// <summary>
        /// Searches for cloud locations from a given source location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudLocation"/> resources.</returns>
        public override gax::PagedEnumerable<SearchCloudLocationsResponse, CloudLocation> SearchCloudLocations(SearchCloudLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchCloudLocationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchCloudLocationsRequest, SearchCloudLocationsResponse, CloudLocation>(_callSearchCloudLocations, request, callSettings);
        }

        /// <summary>
        /// Searches for cloud locations from a given source location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudLocation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchCloudLocationsResponse, CloudLocation> SearchCloudLocationsAsync(SearchCloudLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchCloudLocationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchCloudLocationsRequest, SearchCloudLocationsResponse, CloudLocation>(_callSearchCloudLocations, request, callSettings);
        }
    }

    public partial class ListCloudLocationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchCloudLocationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCloudLocationsResponse : gaxgrpc::IPageResponse<CloudLocation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CloudLocation> GetEnumerator() => CloudLocations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchCloudLocationsResponse : gaxgrpc::IPageResponse<CloudLocation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CloudLocation> GetEnumerator() => CloudLocations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CloudLocationFinder
    {
        public partial class CloudLocationFinderClient
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
