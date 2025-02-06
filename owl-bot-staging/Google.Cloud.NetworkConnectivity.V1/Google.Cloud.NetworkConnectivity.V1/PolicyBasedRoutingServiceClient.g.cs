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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.NetworkConnectivity.V1
{
    /// <summary>Settings for <see cref="PolicyBasedRoutingServiceClient"/> instances.</summary>
    public sealed partial class PolicyBasedRoutingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PolicyBasedRoutingServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PolicyBasedRoutingServiceSettings"/>.</returns>
        public static PolicyBasedRoutingServiceSettings GetDefault() => new PolicyBasedRoutingServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="PolicyBasedRoutingServiceSettings"/> object with default settings.
        /// </summary>
        public PolicyBasedRoutingServiceSettings()
        {
        }

        private PolicyBasedRoutingServiceSettings(PolicyBasedRoutingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListPolicyBasedRoutesSettings = existing.ListPolicyBasedRoutesSettings;
            GetPolicyBasedRouteSettings = existing.GetPolicyBasedRouteSettings;
            CreatePolicyBasedRouteSettings = existing.CreatePolicyBasedRouteSettings;
            CreatePolicyBasedRouteOperationsSettings = existing.CreatePolicyBasedRouteOperationsSettings.Clone();
            DeletePolicyBasedRouteSettings = existing.DeletePolicyBasedRouteSettings;
            DeletePolicyBasedRouteOperationsSettings = existing.DeletePolicyBasedRouteOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(PolicyBasedRoutingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyBasedRoutingServiceClient.ListPolicyBasedRoutes</c> and
        /// <c>PolicyBasedRoutingServiceClient.ListPolicyBasedRoutesAsync</c>.
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
        public gaxgrpc::CallSettings ListPolicyBasedRoutesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyBasedRoutingServiceClient.GetPolicyBasedRoute</c> and
        /// <c>PolicyBasedRoutingServiceClient.GetPolicyBasedRouteAsync</c>.
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
        public gaxgrpc::CallSettings GetPolicyBasedRouteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyBasedRoutingServiceClient.CreatePolicyBasedRoute</c> and
        /// <c>PolicyBasedRoutingServiceClient.CreatePolicyBasedRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePolicyBasedRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PolicyBasedRoutingServiceClient.CreatePolicyBasedRoute</c>
        /// and <c>PolicyBasedRoutingServiceClient.CreatePolicyBasedRouteAsync</c>.
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
        public lro::OperationsSettings CreatePolicyBasedRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PolicyBasedRoutingServiceClient.DeletePolicyBasedRoute</c> and
        /// <c>PolicyBasedRoutingServiceClient.DeletePolicyBasedRouteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePolicyBasedRouteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PolicyBasedRoutingServiceClient.DeletePolicyBasedRoute</c>
        /// and <c>PolicyBasedRoutingServiceClient.DeletePolicyBasedRouteAsync</c>.
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
        public lro::OperationsSettings DeletePolicyBasedRouteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PolicyBasedRoutingServiceSettings"/> object.</returns>
        public PolicyBasedRoutingServiceSettings Clone() => new PolicyBasedRoutingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PolicyBasedRoutingServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class PolicyBasedRoutingServiceClientBuilder : gaxgrpc::ClientBuilderBase<PolicyBasedRoutingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PolicyBasedRoutingServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PolicyBasedRoutingServiceClientBuilder() : base(PolicyBasedRoutingServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PolicyBasedRoutingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PolicyBasedRoutingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PolicyBasedRoutingServiceClient Build()
        {
            PolicyBasedRoutingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PolicyBasedRoutingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PolicyBasedRoutingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PolicyBasedRoutingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PolicyBasedRoutingServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PolicyBasedRoutingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PolicyBasedRoutingServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PolicyBasedRoutingServiceClient.ChannelPool;
    }

    /// <summary>PolicyBasedRoutingService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Policy-Based Routing allows GCP customers to specify flexibile routing
    /// policies for Layer 4 traffic traversing through the connected service.
    /// </remarks>
    public abstract partial class PolicyBasedRoutingServiceClient
    {
        /// <summary>
        /// The default endpoint for the PolicyBasedRoutingService service, which is a host of
        /// "networkconnectivity.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networkconnectivity.googleapis.com:443";

        /// <summary>The default PolicyBasedRoutingService scopes.</summary>
        /// <remarks>
        /// The default PolicyBasedRoutingService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PolicyBasedRoutingService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PolicyBasedRoutingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PolicyBasedRoutingServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PolicyBasedRoutingServiceClient"/>.</returns>
        public static stt::Task<PolicyBasedRoutingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PolicyBasedRoutingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PolicyBasedRoutingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PolicyBasedRoutingServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PolicyBasedRoutingServiceClient"/>.</returns>
        public static PolicyBasedRoutingServiceClient Create() => new PolicyBasedRoutingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PolicyBasedRoutingServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PolicyBasedRoutingServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PolicyBasedRoutingServiceClient"/>.</returns>
        internal static PolicyBasedRoutingServiceClient Create(grpccore::CallInvoker callInvoker, PolicyBasedRoutingServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PolicyBasedRoutingService.PolicyBasedRoutingServiceClient grpcClient = new PolicyBasedRoutingService.PolicyBasedRoutingServiceClient(callInvoker);
            return new PolicyBasedRoutingServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PolicyBasedRoutingService client</summary>
        public virtual PolicyBasedRoutingService.PolicyBasedRoutingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists PolicyBasedRoutes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PolicyBasedRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPolicyBasedRoutesResponse, PolicyBasedRoute> ListPolicyBasedRoutes(ListPolicyBasedRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists PolicyBasedRoutes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBasedRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPolicyBasedRoutesResponse, PolicyBasedRoute> ListPolicyBasedRoutesAsync(ListPolicyBasedRoutesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists PolicyBasedRoutes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable sequence of <see cref="PolicyBasedRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPolicyBasedRoutesResponse, PolicyBasedRoute> ListPolicyBasedRoutes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyBasedRoutesRequest request = new ListPolicyBasedRoutesRequest
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
            return ListPolicyBasedRoutes(request, callSettings);
        }

        /// <summary>
        /// Lists PolicyBasedRoutes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBasedRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPolicyBasedRoutesResponse, PolicyBasedRoute> ListPolicyBasedRoutesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyBasedRoutesRequest request = new ListPolicyBasedRoutesRequest
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
            return ListPolicyBasedRoutesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists PolicyBasedRoutes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable sequence of <see cref="PolicyBasedRoute"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPolicyBasedRoutesResponse, PolicyBasedRoute> ListPolicyBasedRoutes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyBasedRoutesRequest request = new ListPolicyBasedRoutesRequest
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
            return ListPolicyBasedRoutes(request, callSettings);
        }

        /// <summary>
        /// Lists PolicyBasedRoutes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBasedRoute"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPolicyBasedRoutesResponse, PolicyBasedRoute> ListPolicyBasedRoutesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPolicyBasedRoutesRequest request = new ListPolicyBasedRoutesRequest
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
            return ListPolicyBasedRoutesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single PolicyBasedRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PolicyBasedRoute GetPolicyBasedRoute(GetPolicyBasedRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single PolicyBasedRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyBasedRoute> GetPolicyBasedRouteAsync(GetPolicyBasedRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single PolicyBasedRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyBasedRoute> GetPolicyBasedRouteAsync(GetPolicyBasedRouteRequest request, st::CancellationToken cancellationToken) =>
            GetPolicyBasedRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single PolicyBasedRoute.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the PolicyBasedRoute resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PolicyBasedRoute GetPolicyBasedRoute(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyBasedRoute(new GetPolicyBasedRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PolicyBasedRoute.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the PolicyBasedRoute resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyBasedRoute> GetPolicyBasedRouteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyBasedRouteAsync(new GetPolicyBasedRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PolicyBasedRoute.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the PolicyBasedRoute resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyBasedRoute> GetPolicyBasedRouteAsync(string name, st::CancellationToken cancellationToken) =>
            GetPolicyBasedRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single PolicyBasedRoute.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the PolicyBasedRoute resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PolicyBasedRoute GetPolicyBasedRoute(PolicyBasedRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyBasedRoute(new GetPolicyBasedRouteRequest
            {
                PolicyBasedRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PolicyBasedRoute.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the PolicyBasedRoute resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyBasedRoute> GetPolicyBasedRouteAsync(PolicyBasedRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyBasedRouteAsync(new GetPolicyBasedRouteRequest
            {
                PolicyBasedRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PolicyBasedRoute.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the PolicyBasedRoute resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PolicyBasedRoute> GetPolicyBasedRouteAsync(PolicyBasedRouteName name, st::CancellationToken cancellationToken) =>
            GetPolicyBasedRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new PolicyBasedRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PolicyBasedRoute, OperationMetadata> CreatePolicyBasedRoute(CreatePolicyBasedRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new PolicyBasedRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBasedRoute, OperationMetadata>> CreatePolicyBasedRouteAsync(CreatePolicyBasedRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new PolicyBasedRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBasedRoute, OperationMetadata>> CreatePolicyBasedRouteAsync(CreatePolicyBasedRouteRequest request, st::CancellationToken cancellationToken) =>
            CreatePolicyBasedRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePolicyBasedRoute</c>.</summary>
        public virtual lro::OperationsClient CreatePolicyBasedRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePolicyBasedRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PolicyBasedRoute, OperationMetadata> PollOnceCreatePolicyBasedRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PolicyBasedRoute, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePolicyBasedRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePolicyBasedRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PolicyBasedRoute, OperationMetadata>> PollOnceCreatePolicyBasedRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PolicyBasedRoute, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePolicyBasedRouteOperationsClient, callSettings);

        /// <summary>
        /// Creates a new PolicyBasedRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the PolicyBasedRoute.
        /// </param>
        /// <param name="policyBasedRoute">
        /// Required. Initial values for a new Policy Based Route.
        /// </param>
        /// <param name="policyBasedRouteId">
        /// Required. Unique id for the Policy Based Route to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PolicyBasedRoute, OperationMetadata> CreatePolicyBasedRoute(string parent, PolicyBasedRoute policyBasedRoute, string policyBasedRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyBasedRoute(new CreatePolicyBasedRouteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PolicyBasedRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyBasedRouteId, nameof(policyBasedRouteId)),
                PolicyBasedRoute = gax::GaxPreconditions.CheckNotNull(policyBasedRoute, nameof(policyBasedRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new PolicyBasedRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the PolicyBasedRoute.
        /// </param>
        /// <param name="policyBasedRoute">
        /// Required. Initial values for a new Policy Based Route.
        /// </param>
        /// <param name="policyBasedRouteId">
        /// Required. Unique id for the Policy Based Route to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBasedRoute, OperationMetadata>> CreatePolicyBasedRouteAsync(string parent, PolicyBasedRoute policyBasedRoute, string policyBasedRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyBasedRouteAsync(new CreatePolicyBasedRouteRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PolicyBasedRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyBasedRouteId, nameof(policyBasedRouteId)),
                PolicyBasedRoute = gax::GaxPreconditions.CheckNotNull(policyBasedRoute, nameof(policyBasedRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new PolicyBasedRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the PolicyBasedRoute.
        /// </param>
        /// <param name="policyBasedRoute">
        /// Required. Initial values for a new Policy Based Route.
        /// </param>
        /// <param name="policyBasedRouteId">
        /// Required. Unique id for the Policy Based Route to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBasedRoute, OperationMetadata>> CreatePolicyBasedRouteAsync(string parent, PolicyBasedRoute policyBasedRoute, string policyBasedRouteId, st::CancellationToken cancellationToken) =>
            CreatePolicyBasedRouteAsync(parent, policyBasedRoute, policyBasedRouteId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new PolicyBasedRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the PolicyBasedRoute.
        /// </param>
        /// <param name="policyBasedRoute">
        /// Required. Initial values for a new Policy Based Route.
        /// </param>
        /// <param name="policyBasedRouteId">
        /// Required. Unique id for the Policy Based Route to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PolicyBasedRoute, OperationMetadata> CreatePolicyBasedRoute(gagr::LocationName parent, PolicyBasedRoute policyBasedRoute, string policyBasedRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyBasedRoute(new CreatePolicyBasedRouteRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PolicyBasedRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyBasedRouteId, nameof(policyBasedRouteId)),
                PolicyBasedRoute = gax::GaxPreconditions.CheckNotNull(policyBasedRoute, nameof(policyBasedRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new PolicyBasedRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the PolicyBasedRoute.
        /// </param>
        /// <param name="policyBasedRoute">
        /// Required. Initial values for a new Policy Based Route.
        /// </param>
        /// <param name="policyBasedRouteId">
        /// Required. Unique id for the Policy Based Route to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBasedRoute, OperationMetadata>> CreatePolicyBasedRouteAsync(gagr::LocationName parent, PolicyBasedRoute policyBasedRoute, string policyBasedRouteId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyBasedRouteAsync(new CreatePolicyBasedRouteRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PolicyBasedRouteId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyBasedRouteId, nameof(policyBasedRouteId)),
                PolicyBasedRoute = gax::GaxPreconditions.CheckNotNull(policyBasedRoute, nameof(policyBasedRoute)),
            }, callSettings);

        /// <summary>
        /// Creates a new PolicyBasedRoute in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the PolicyBasedRoute.
        /// </param>
        /// <param name="policyBasedRoute">
        /// Required. Initial values for a new Policy Based Route.
        /// </param>
        /// <param name="policyBasedRouteId">
        /// Required. Unique id for the Policy Based Route to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PolicyBasedRoute, OperationMetadata>> CreatePolicyBasedRouteAsync(gagr::LocationName parent, PolicyBasedRoute policyBasedRoute, string policyBasedRouteId, st::CancellationToken cancellationToken) =>
            CreatePolicyBasedRouteAsync(parent, policyBasedRoute, policyBasedRouteId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single PolicyBasedRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePolicyBasedRoute(DeletePolicyBasedRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single PolicyBasedRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePolicyBasedRouteAsync(DeletePolicyBasedRouteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single PolicyBasedRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePolicyBasedRouteAsync(DeletePolicyBasedRouteRequest request, st::CancellationToken cancellationToken) =>
            DeletePolicyBasedRouteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePolicyBasedRoute</c>.</summary>
        public virtual lro::OperationsClient DeletePolicyBasedRouteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePolicyBasedRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeletePolicyBasedRoute(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePolicyBasedRouteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePolicyBasedRoute</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeletePolicyBasedRouteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePolicyBasedRouteOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single PolicyBasedRoute.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the PolicyBasedRoute resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePolicyBasedRoute(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyBasedRoute(new DeletePolicyBasedRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single PolicyBasedRoute.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the PolicyBasedRoute resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePolicyBasedRouteAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyBasedRouteAsync(new DeletePolicyBasedRouteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single PolicyBasedRoute.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the PolicyBasedRoute resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePolicyBasedRouteAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePolicyBasedRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single PolicyBasedRoute.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the PolicyBasedRoute resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeletePolicyBasedRoute(PolicyBasedRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyBasedRoute(new DeletePolicyBasedRouteRequest
            {
                PolicyBasedRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single PolicyBasedRoute.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the PolicyBasedRoute resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePolicyBasedRouteAsync(PolicyBasedRouteName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyBasedRouteAsync(new DeletePolicyBasedRouteRequest
            {
                PolicyBasedRouteName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single PolicyBasedRoute.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the PolicyBasedRoute resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePolicyBasedRouteAsync(PolicyBasedRouteName name, st::CancellationToken cancellationToken) =>
            DeletePolicyBasedRouteAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PolicyBasedRoutingService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Policy-Based Routing allows GCP customers to specify flexibile routing
    /// policies for Layer 4 traffic traversing through the connected service.
    /// </remarks>
    public sealed partial class PolicyBasedRoutingServiceClientImpl : PolicyBasedRoutingServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListPolicyBasedRoutesRequest, ListPolicyBasedRoutesResponse> _callListPolicyBasedRoutes;

        private readonly gaxgrpc::ApiCall<GetPolicyBasedRouteRequest, PolicyBasedRoute> _callGetPolicyBasedRoute;

        private readonly gaxgrpc::ApiCall<CreatePolicyBasedRouteRequest, lro::Operation> _callCreatePolicyBasedRoute;

        private readonly gaxgrpc::ApiCall<DeletePolicyBasedRouteRequest, lro::Operation> _callDeletePolicyBasedRoute;

        /// <summary>
        /// Constructs a client wrapper for the PolicyBasedRoutingService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PolicyBasedRoutingServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PolicyBasedRoutingServiceClientImpl(PolicyBasedRoutingService.PolicyBasedRoutingServiceClient grpcClient, PolicyBasedRoutingServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PolicyBasedRoutingServiceSettings effectiveSettings = settings ?? PolicyBasedRoutingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreatePolicyBasedRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePolicyBasedRouteOperationsSettings, logger);
            DeletePolicyBasedRouteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePolicyBasedRouteOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListPolicyBasedRoutes = clientHelper.BuildApiCall<ListPolicyBasedRoutesRequest, ListPolicyBasedRoutesResponse>("ListPolicyBasedRoutes", grpcClient.ListPolicyBasedRoutesAsync, grpcClient.ListPolicyBasedRoutes, effectiveSettings.ListPolicyBasedRoutesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPolicyBasedRoutes);
            Modify_ListPolicyBasedRoutesApiCall(ref _callListPolicyBasedRoutes);
            _callGetPolicyBasedRoute = clientHelper.BuildApiCall<GetPolicyBasedRouteRequest, PolicyBasedRoute>("GetPolicyBasedRoute", grpcClient.GetPolicyBasedRouteAsync, grpcClient.GetPolicyBasedRoute, effectiveSettings.GetPolicyBasedRouteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPolicyBasedRoute);
            Modify_GetPolicyBasedRouteApiCall(ref _callGetPolicyBasedRoute);
            _callCreatePolicyBasedRoute = clientHelper.BuildApiCall<CreatePolicyBasedRouteRequest, lro::Operation>("CreatePolicyBasedRoute", grpcClient.CreatePolicyBasedRouteAsync, grpcClient.CreatePolicyBasedRoute, effectiveSettings.CreatePolicyBasedRouteSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePolicyBasedRoute);
            Modify_CreatePolicyBasedRouteApiCall(ref _callCreatePolicyBasedRoute);
            _callDeletePolicyBasedRoute = clientHelper.BuildApiCall<DeletePolicyBasedRouteRequest, lro::Operation>("DeletePolicyBasedRoute", grpcClient.DeletePolicyBasedRouteAsync, grpcClient.DeletePolicyBasedRoute, effectiveSettings.DeletePolicyBasedRouteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePolicyBasedRoute);
            Modify_DeletePolicyBasedRouteApiCall(ref _callDeletePolicyBasedRoute);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListPolicyBasedRoutesApiCall(ref gaxgrpc::ApiCall<ListPolicyBasedRoutesRequest, ListPolicyBasedRoutesResponse> call);

        partial void Modify_GetPolicyBasedRouteApiCall(ref gaxgrpc::ApiCall<GetPolicyBasedRouteRequest, PolicyBasedRoute> call);

        partial void Modify_CreatePolicyBasedRouteApiCall(ref gaxgrpc::ApiCall<CreatePolicyBasedRouteRequest, lro::Operation> call);

        partial void Modify_DeletePolicyBasedRouteApiCall(ref gaxgrpc::ApiCall<DeletePolicyBasedRouteRequest, lro::Operation> call);

        partial void OnConstruction(PolicyBasedRoutingService.PolicyBasedRoutingServiceClient grpcClient, PolicyBasedRoutingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PolicyBasedRoutingService client</summary>
        public override PolicyBasedRoutingService.PolicyBasedRoutingServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListPolicyBasedRoutesRequest(ref ListPolicyBasedRoutesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPolicyBasedRouteRequest(ref GetPolicyBasedRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePolicyBasedRouteRequest(ref CreatePolicyBasedRouteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePolicyBasedRouteRequest(ref DeletePolicyBasedRouteRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists PolicyBasedRoutes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PolicyBasedRoute"/> resources.</returns>
        public override gax::PagedEnumerable<ListPolicyBasedRoutesResponse, PolicyBasedRoute> ListPolicyBasedRoutes(ListPolicyBasedRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPolicyBasedRoutesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPolicyBasedRoutesRequest, ListPolicyBasedRoutesResponse, PolicyBasedRoute>(_callListPolicyBasedRoutes, request, callSettings);
        }

        /// <summary>
        /// Lists PolicyBasedRoutes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PolicyBasedRoute"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPolicyBasedRoutesResponse, PolicyBasedRoute> ListPolicyBasedRoutesAsync(ListPolicyBasedRoutesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPolicyBasedRoutesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPolicyBasedRoutesRequest, ListPolicyBasedRoutesResponse, PolicyBasedRoute>(_callListPolicyBasedRoutes, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single PolicyBasedRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PolicyBasedRoute GetPolicyBasedRoute(GetPolicyBasedRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPolicyBasedRouteRequest(ref request, ref callSettings);
            return _callGetPolicyBasedRoute.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single PolicyBasedRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PolicyBasedRoute> GetPolicyBasedRouteAsync(GetPolicyBasedRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPolicyBasedRouteRequest(ref request, ref callSettings);
            return _callGetPolicyBasedRoute.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreatePolicyBasedRoute</c>.</summary>
        public override lro::OperationsClient CreatePolicyBasedRouteOperationsClient { get; }

        /// <summary>
        /// Creates a new PolicyBasedRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PolicyBasedRoute, OperationMetadata> CreatePolicyBasedRoute(CreatePolicyBasedRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePolicyBasedRouteRequest(ref request, ref callSettings);
            return new lro::Operation<PolicyBasedRoute, OperationMetadata>(_callCreatePolicyBasedRoute.Sync(request, callSettings), CreatePolicyBasedRouteOperationsClient);
        }

        /// <summary>
        /// Creates a new PolicyBasedRoute in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PolicyBasedRoute, OperationMetadata>> CreatePolicyBasedRouteAsync(CreatePolicyBasedRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePolicyBasedRouteRequest(ref request, ref callSettings);
            return new lro::Operation<PolicyBasedRoute, OperationMetadata>(await _callCreatePolicyBasedRoute.Async(request, callSettings).ConfigureAwait(false), CreatePolicyBasedRouteOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeletePolicyBasedRoute</c>.</summary>
        public override lro::OperationsClient DeletePolicyBasedRouteOperationsClient { get; }

        /// <summary>
        /// Deletes a single PolicyBasedRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeletePolicyBasedRoute(DeletePolicyBasedRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePolicyBasedRouteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeletePolicyBasedRoute.Sync(request, callSettings), DeletePolicyBasedRouteOperationsClient);
        }

        /// <summary>
        /// Deletes a single PolicyBasedRoute.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeletePolicyBasedRouteAsync(DeletePolicyBasedRouteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePolicyBasedRouteRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeletePolicyBasedRoute.Async(request, callSettings).ConfigureAwait(false), DeletePolicyBasedRouteOperationsClient);
        }
    }

    public partial class ListPolicyBasedRoutesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPolicyBasedRoutesResponse : gaxgrpc::IPageResponse<PolicyBasedRoute>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PolicyBasedRoute> GetEnumerator() => PolicyBasedRoutes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class PolicyBasedRoutingService
    {
        public partial class PolicyBasedRoutingServiceClient
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

    public static partial class PolicyBasedRoutingService
    {
        public partial class PolicyBasedRoutingServiceClient
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

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
