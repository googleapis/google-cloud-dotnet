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

namespace Google.Cloud.ApiHub.V1
{
    /// <summary>Settings for <see cref="ApiHubDiscoveryClient"/> instances.</summary>
    public sealed partial class ApiHubDiscoverySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ApiHubDiscoverySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ApiHubDiscoverySettings"/>.</returns>
        public static ApiHubDiscoverySettings GetDefault() => new ApiHubDiscoverySettings();

        /// <summary>Constructs a new <see cref="ApiHubDiscoverySettings"/> object with default settings.</summary>
        public ApiHubDiscoverySettings()
        {
        }

        private ApiHubDiscoverySettings(ApiHubDiscoverySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDiscoveredApiObservationsSettings = existing.ListDiscoveredApiObservationsSettings;
            GetDiscoveredApiObservationSettings = existing.GetDiscoveredApiObservationSettings;
            ListDiscoveredApiOperationsSettings = existing.ListDiscoveredApiOperationsSettings;
            GetDiscoveredApiOperationSettings = existing.GetDiscoveredApiOperationSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ApiHubDiscoverySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubDiscoveryClient.ListDiscoveredApiObservations</c> and
        /// <c>ApiHubDiscoveryClient.ListDiscoveredApiObservationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDiscoveredApiObservationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubDiscoveryClient.GetDiscoveredApiObservation</c> and
        /// <c>ApiHubDiscoveryClient.GetDiscoveredApiObservationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDiscoveredApiObservationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubDiscoveryClient.ListDiscoveredApiOperations</c> and
        /// <c>ApiHubDiscoveryClient.ListDiscoveredApiOperationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDiscoveredApiOperationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubDiscoveryClient.GetDiscoveredApiOperation</c> and
        /// <c>ApiHubDiscoveryClient.GetDiscoveredApiOperationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDiscoveredApiOperationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ApiHubDiscoverySettings"/> object.</returns>
        public ApiHubDiscoverySettings Clone() => new ApiHubDiscoverySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ApiHubDiscoveryClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ApiHubDiscoveryClientBuilder : gaxgrpc::ClientBuilderBase<ApiHubDiscoveryClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ApiHubDiscoverySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ApiHubDiscoveryClientBuilder() : base(ApiHubDiscoveryClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ApiHubDiscoveryClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ApiHubDiscoveryClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ApiHubDiscoveryClient Build()
        {
            ApiHubDiscoveryClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ApiHubDiscoveryClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ApiHubDiscoveryClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ApiHubDiscoveryClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ApiHubDiscoveryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ApiHubDiscoveryClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ApiHubDiscoveryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ApiHubDiscoveryClient.ChannelPool;
    }

    /// <summary>ApiHubDiscovery client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service exposes methods used to manage DiscoveredApiObservations
    /// and DiscoveredApiOperations.
    /// </remarks>
    public abstract partial class ApiHubDiscoveryClient
    {
        /// <summary>
        /// The default endpoint for the ApiHubDiscovery service, which is a host of "apihub.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apihub.googleapis.com:443";

        /// <summary>The default ApiHubDiscovery scopes.</summary>
        /// <remarks>
        /// The default ApiHubDiscovery scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ApiHubDiscovery.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ApiHubDiscoveryClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApiHubDiscoveryClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ApiHubDiscoveryClient"/>.</returns>
        public static stt::Task<ApiHubDiscoveryClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ApiHubDiscoveryClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ApiHubDiscoveryClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApiHubDiscoveryClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ApiHubDiscoveryClient"/>.</returns>
        public static ApiHubDiscoveryClient Create() => new ApiHubDiscoveryClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ApiHubDiscoveryClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ApiHubDiscoverySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ApiHubDiscoveryClient"/>.</returns>
        internal static ApiHubDiscoveryClient Create(grpccore::CallInvoker callInvoker, ApiHubDiscoverySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ApiHubDiscovery.ApiHubDiscoveryClient grpcClient = new ApiHubDiscovery.ApiHubDiscoveryClient(callInvoker);
            return new ApiHubDiscoveryClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ApiHubDiscovery client</summary>
        public virtual ApiHubDiscovery.ApiHubDiscoveryClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the DiscoveredAPIObservations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DiscoveredApiObservation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveredApiObservationsResponse, DiscoveredApiObservation> ListDiscoveredApiObservations(ListDiscoveredApiObservationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the DiscoveredAPIObservations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredApiObservation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveredApiObservationsResponse, DiscoveredApiObservation> ListDiscoveredApiObservationsAsync(ListDiscoveredApiObservationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the DiscoveredAPIObservations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ApiObservations.
        /// Format:
        /// projects/{project}/locations/{location}
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
        /// <returns>A pageable sequence of <see cref="DiscoveredApiObservation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveredApiObservationsResponse, DiscoveredApiObservation> ListDiscoveredApiObservations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredApiObservationsRequest request = new ListDiscoveredApiObservationsRequest
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
            return ListDiscoveredApiObservations(request, callSettings);
        }

        /// <summary>
        /// Lists all the DiscoveredAPIObservations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ApiObservations.
        /// Format:
        /// projects/{project}/locations/{location}
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
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredApiObservation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveredApiObservationsResponse, DiscoveredApiObservation> ListDiscoveredApiObservationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredApiObservationsRequest request = new ListDiscoveredApiObservationsRequest
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
            return ListDiscoveredApiObservationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the DiscoveredAPIObservations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ApiObservations.
        /// Format:
        /// projects/{project}/locations/{location}
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
        /// <returns>A pageable sequence of <see cref="DiscoveredApiObservation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveredApiObservationsResponse, DiscoveredApiObservation> ListDiscoveredApiObservations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredApiObservationsRequest request = new ListDiscoveredApiObservationsRequest
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
            return ListDiscoveredApiObservations(request, callSettings);
        }

        /// <summary>
        /// Lists all the DiscoveredAPIObservations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ApiObservations.
        /// Format:
        /// projects/{project}/locations/{location}
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
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredApiObservation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveredApiObservationsResponse, DiscoveredApiObservation> ListDiscoveredApiObservationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredApiObservationsRequest request = new ListDiscoveredApiObservationsRequest
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
            return ListDiscoveredApiObservationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a DiscoveredAPIObservation in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveredApiObservation GetDiscoveredApiObservation(GetDiscoveredApiObservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a DiscoveredAPIObservation in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredApiObservation> GetDiscoveredApiObservationAsync(GetDiscoveredApiObservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a DiscoveredAPIObservation in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredApiObservation> GetDiscoveredApiObservationAsync(GetDiscoveredApiObservationRequest request, st::CancellationToken cancellationToken) =>
            GetDiscoveredApiObservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DiscoveredAPIObservation in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DiscoveredApiObservation to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveredApiObservation GetDiscoveredApiObservation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredApiObservation(new GetDiscoveredApiObservationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DiscoveredAPIObservation in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DiscoveredApiObservation to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredApiObservation> GetDiscoveredApiObservationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredApiObservationAsync(new GetDiscoveredApiObservationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DiscoveredAPIObservation in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DiscoveredApiObservation to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredApiObservation> GetDiscoveredApiObservationAsync(string name, st::CancellationToken cancellationToken) =>
            GetDiscoveredApiObservationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DiscoveredAPIObservation in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DiscoveredApiObservation to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveredApiObservation GetDiscoveredApiObservation(DiscoveredApiObservationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredApiObservation(new GetDiscoveredApiObservationRequest
            {
                DiscoveredApiObservationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DiscoveredAPIObservation in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DiscoveredApiObservation to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredApiObservation> GetDiscoveredApiObservationAsync(DiscoveredApiObservationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredApiObservationAsync(new GetDiscoveredApiObservationRequest
            {
                DiscoveredApiObservationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DiscoveredAPIObservation in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DiscoveredApiObservation to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredApiObservation> GetDiscoveredApiObservationAsync(DiscoveredApiObservationName name, st::CancellationToken cancellationToken) =>
            GetDiscoveredApiObservationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the DiscoveredAPIOperations in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DiscoveredApiOperation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveredApiOperationsResponse, DiscoveredApiOperation> ListDiscoveredApiOperations(ListDiscoveredApiOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the DiscoveredAPIOperations in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredApiOperation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveredApiOperationsResponse, DiscoveredApiOperation> ListDiscoveredApiOperationsAsync(ListDiscoveredApiOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the DiscoveredAPIOperations in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// DiscoveredApiOperations. Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}
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
        /// <returns>A pageable sequence of <see cref="DiscoveredApiOperation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveredApiOperationsResponse, DiscoveredApiOperation> ListDiscoveredApiOperations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredApiOperationsRequest request = new ListDiscoveredApiOperationsRequest
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
            return ListDiscoveredApiOperations(request, callSettings);
        }

        /// <summary>
        /// Lists all the DiscoveredAPIOperations in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// DiscoveredApiOperations. Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}
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
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredApiOperation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveredApiOperationsResponse, DiscoveredApiOperation> ListDiscoveredApiOperationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredApiOperationsRequest request = new ListDiscoveredApiOperationsRequest
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
            return ListDiscoveredApiOperationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the DiscoveredAPIOperations in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// DiscoveredApiOperations. Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}
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
        /// <returns>A pageable sequence of <see cref="DiscoveredApiOperation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveredApiOperationsResponse, DiscoveredApiOperation> ListDiscoveredApiOperations(DiscoveredApiObservationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredApiOperationsRequest request = new ListDiscoveredApiOperationsRequest
            {
                ParentAsDiscoveredApiObservationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDiscoveredApiOperations(request, callSettings);
        }

        /// <summary>
        /// Lists all the DiscoveredAPIOperations in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of
        /// DiscoveredApiOperations. Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}
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
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredApiOperation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveredApiOperationsResponse, DiscoveredApiOperation> ListDiscoveredApiOperationsAsync(DiscoveredApiObservationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveredApiOperationsRequest request = new ListDiscoveredApiOperationsRequest
            {
                ParentAsDiscoveredApiObservationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDiscoveredApiOperationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a DiscoveredAPIOperation in a given project, location,
        /// ApiObservation and ApiOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveredApiOperation GetDiscoveredApiOperation(GetDiscoveredApiOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a DiscoveredAPIOperation in a given project, location,
        /// ApiObservation and ApiOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredApiOperation> GetDiscoveredApiOperationAsync(GetDiscoveredApiOperationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a DiscoveredAPIOperation in a given project, location,
        /// ApiObservation and ApiOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredApiOperation> GetDiscoveredApiOperationAsync(GetDiscoveredApiOperationRequest request, st::CancellationToken cancellationToken) =>
            GetDiscoveredApiOperationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DiscoveredAPIOperation in a given project, location,
        /// ApiObservation and ApiOperation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DiscoveredApiOperation to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}/discoveredApiOperations/{discovered_api_operation}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveredApiOperation GetDiscoveredApiOperation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredApiOperation(new GetDiscoveredApiOperationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DiscoveredAPIOperation in a given project, location,
        /// ApiObservation and ApiOperation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DiscoveredApiOperation to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}/discoveredApiOperations/{discovered_api_operation}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredApiOperation> GetDiscoveredApiOperationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredApiOperationAsync(new GetDiscoveredApiOperationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DiscoveredAPIOperation in a given project, location,
        /// ApiObservation and ApiOperation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DiscoveredApiOperation to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}/discoveredApiOperations/{discovered_api_operation}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredApiOperation> GetDiscoveredApiOperationAsync(string name, st::CancellationToken cancellationToken) =>
            GetDiscoveredApiOperationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DiscoveredAPIOperation in a given project, location,
        /// ApiObservation and ApiOperation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DiscoveredApiOperation to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}/discoveredApiOperations/{discovered_api_operation}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveredApiOperation GetDiscoveredApiOperation(DiscoveredApiOperationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredApiOperation(new GetDiscoveredApiOperationRequest
            {
                DiscoveredApiOperationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DiscoveredAPIOperation in a given project, location,
        /// ApiObservation and ApiOperation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DiscoveredApiOperation to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}/discoveredApiOperations/{discovered_api_operation}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredApiOperation> GetDiscoveredApiOperationAsync(DiscoveredApiOperationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveredApiOperationAsync(new GetDiscoveredApiOperationRequest
            {
                DiscoveredApiOperationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DiscoveredAPIOperation in a given project, location,
        /// ApiObservation and ApiOperation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DiscoveredApiOperation to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/discoveredApiObservations/{discovered_api_observation}/discoveredApiOperations/{discovered_api_operation}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveredApiOperation> GetDiscoveredApiOperationAsync(DiscoveredApiOperationName name, st::CancellationToken cancellationToken) =>
            GetDiscoveredApiOperationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ApiHubDiscovery client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service exposes methods used to manage DiscoveredApiObservations
    /// and DiscoveredApiOperations.
    /// </remarks>
    public sealed partial class ApiHubDiscoveryClientImpl : ApiHubDiscoveryClient
    {
        private readonly gaxgrpc::ApiCall<ListDiscoveredApiObservationsRequest, ListDiscoveredApiObservationsResponse> _callListDiscoveredApiObservations;

        private readonly gaxgrpc::ApiCall<GetDiscoveredApiObservationRequest, DiscoveredApiObservation> _callGetDiscoveredApiObservation;

        private readonly gaxgrpc::ApiCall<ListDiscoveredApiOperationsRequest, ListDiscoveredApiOperationsResponse> _callListDiscoveredApiOperations;

        private readonly gaxgrpc::ApiCall<GetDiscoveredApiOperationRequest, DiscoveredApiOperation> _callGetDiscoveredApiOperation;

        /// <summary>
        /// Constructs a client wrapper for the ApiHubDiscovery service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ApiHubDiscoverySettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ApiHubDiscoveryClientImpl(ApiHubDiscovery.ApiHubDiscoveryClient grpcClient, ApiHubDiscoverySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ApiHubDiscoverySettings effectiveSettings = settings ?? ApiHubDiscoverySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListDiscoveredApiObservations = clientHelper.BuildApiCall<ListDiscoveredApiObservationsRequest, ListDiscoveredApiObservationsResponse>("ListDiscoveredApiObservations", grpcClient.ListDiscoveredApiObservationsAsync, grpcClient.ListDiscoveredApiObservations, effectiveSettings.ListDiscoveredApiObservationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDiscoveredApiObservations);
            Modify_ListDiscoveredApiObservationsApiCall(ref _callListDiscoveredApiObservations);
            _callGetDiscoveredApiObservation = clientHelper.BuildApiCall<GetDiscoveredApiObservationRequest, DiscoveredApiObservation>("GetDiscoveredApiObservation", grpcClient.GetDiscoveredApiObservationAsync, grpcClient.GetDiscoveredApiObservation, effectiveSettings.GetDiscoveredApiObservationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDiscoveredApiObservation);
            Modify_GetDiscoveredApiObservationApiCall(ref _callGetDiscoveredApiObservation);
            _callListDiscoveredApiOperations = clientHelper.BuildApiCall<ListDiscoveredApiOperationsRequest, ListDiscoveredApiOperationsResponse>("ListDiscoveredApiOperations", grpcClient.ListDiscoveredApiOperationsAsync, grpcClient.ListDiscoveredApiOperations, effectiveSettings.ListDiscoveredApiOperationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDiscoveredApiOperations);
            Modify_ListDiscoveredApiOperationsApiCall(ref _callListDiscoveredApiOperations);
            _callGetDiscoveredApiOperation = clientHelper.BuildApiCall<GetDiscoveredApiOperationRequest, DiscoveredApiOperation>("GetDiscoveredApiOperation", grpcClient.GetDiscoveredApiOperationAsync, grpcClient.GetDiscoveredApiOperation, effectiveSettings.GetDiscoveredApiOperationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDiscoveredApiOperation);
            Modify_GetDiscoveredApiOperationApiCall(ref _callGetDiscoveredApiOperation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListDiscoveredApiObservationsApiCall(ref gaxgrpc::ApiCall<ListDiscoveredApiObservationsRequest, ListDiscoveredApiObservationsResponse> call);

        partial void Modify_GetDiscoveredApiObservationApiCall(ref gaxgrpc::ApiCall<GetDiscoveredApiObservationRequest, DiscoveredApiObservation> call);

        partial void Modify_ListDiscoveredApiOperationsApiCall(ref gaxgrpc::ApiCall<ListDiscoveredApiOperationsRequest, ListDiscoveredApiOperationsResponse> call);

        partial void Modify_GetDiscoveredApiOperationApiCall(ref gaxgrpc::ApiCall<GetDiscoveredApiOperationRequest, DiscoveredApiOperation> call);

        partial void OnConstruction(ApiHubDiscovery.ApiHubDiscoveryClient grpcClient, ApiHubDiscoverySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ApiHubDiscovery client</summary>
        public override ApiHubDiscovery.ApiHubDiscoveryClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListDiscoveredApiObservationsRequest(ref ListDiscoveredApiObservationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDiscoveredApiObservationRequest(ref GetDiscoveredApiObservationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDiscoveredApiOperationsRequest(ref ListDiscoveredApiOperationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDiscoveredApiOperationRequest(ref GetDiscoveredApiOperationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all the DiscoveredAPIObservations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DiscoveredApiObservation"/> resources.</returns>
        public override gax::PagedEnumerable<ListDiscoveredApiObservationsResponse, DiscoveredApiObservation> ListDiscoveredApiObservations(ListDiscoveredApiObservationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDiscoveredApiObservationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDiscoveredApiObservationsRequest, ListDiscoveredApiObservationsResponse, DiscoveredApiObservation>(_callListDiscoveredApiObservations, request, callSettings);
        }

        /// <summary>
        /// Lists all the DiscoveredAPIObservations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredApiObservation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDiscoveredApiObservationsResponse, DiscoveredApiObservation> ListDiscoveredApiObservationsAsync(ListDiscoveredApiObservationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDiscoveredApiObservationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDiscoveredApiObservationsRequest, ListDiscoveredApiObservationsResponse, DiscoveredApiObservation>(_callListDiscoveredApiObservations, request, callSettings);
        }

        /// <summary>
        /// Gets a DiscoveredAPIObservation in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DiscoveredApiObservation GetDiscoveredApiObservation(GetDiscoveredApiObservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDiscoveredApiObservationRequest(ref request, ref callSettings);
            return _callGetDiscoveredApiObservation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a DiscoveredAPIObservation in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DiscoveredApiObservation> GetDiscoveredApiObservationAsync(GetDiscoveredApiObservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDiscoveredApiObservationRequest(ref request, ref callSettings);
            return _callGetDiscoveredApiObservation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the DiscoveredAPIOperations in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DiscoveredApiOperation"/> resources.</returns>
        public override gax::PagedEnumerable<ListDiscoveredApiOperationsResponse, DiscoveredApiOperation> ListDiscoveredApiOperations(ListDiscoveredApiOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDiscoveredApiOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDiscoveredApiOperationsRequest, ListDiscoveredApiOperationsResponse, DiscoveredApiOperation>(_callListDiscoveredApiOperations, request, callSettings);
        }

        /// <summary>
        /// Lists all the DiscoveredAPIOperations in a given project, location and
        /// ApiObservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveredApiOperation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDiscoveredApiOperationsResponse, DiscoveredApiOperation> ListDiscoveredApiOperationsAsync(ListDiscoveredApiOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDiscoveredApiOperationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDiscoveredApiOperationsRequest, ListDiscoveredApiOperationsResponse, DiscoveredApiOperation>(_callListDiscoveredApiOperations, request, callSettings);
        }

        /// <summary>
        /// Gets a DiscoveredAPIOperation in a given project, location,
        /// ApiObservation and ApiOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DiscoveredApiOperation GetDiscoveredApiOperation(GetDiscoveredApiOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDiscoveredApiOperationRequest(ref request, ref callSettings);
            return _callGetDiscoveredApiOperation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a DiscoveredAPIOperation in a given project, location,
        /// ApiObservation and ApiOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DiscoveredApiOperation> GetDiscoveredApiOperationAsync(GetDiscoveredApiOperationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDiscoveredApiOperationRequest(ref request, ref callSettings);
            return _callGetDiscoveredApiOperation.Async(request, callSettings);
        }
    }

    public partial class ListDiscoveredApiObservationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDiscoveredApiOperationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDiscoveredApiObservationsResponse : gaxgrpc::IPageResponse<DiscoveredApiObservation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DiscoveredApiObservation> GetEnumerator() => DiscoveredApiObservations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDiscoveredApiOperationsResponse : gaxgrpc::IPageResponse<DiscoveredApiOperation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DiscoveredApiOperation> GetEnumerator() => DiscoveredApiOperations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ApiHubDiscovery
    {
        public partial class ApiHubDiscoveryClient
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
