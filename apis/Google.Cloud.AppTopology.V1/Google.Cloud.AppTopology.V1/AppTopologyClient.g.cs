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

namespace Google.Cloud.AppTopology.V1
{
    /// <summary>Settings for <see cref="AppTopologyClient"/> instances.</summary>
    public sealed partial class AppTopologySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AppTopologySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AppTopologySettings"/>.</returns>
        public static AppTopologySettings GetDefault() => new AppTopologySettings();

        /// <summary>Constructs a new <see cref="AppTopologySettings"/> object with default settings.</summary>
        public AppTopologySettings()
        {
        }

        private AppTopologySettings(AppTopologySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateDiscoveredResourcesTopologySettings = existing.GenerateDiscoveredResourcesTopologySettings;
            GetSchemaSettings = existing.GetSchemaSettings;
            GetDomainSettings = existing.GetDomainSettings;
            ListDomainsSettings = existing.ListDomainsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AppTopologySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppTopologyClient.GenerateDiscoveredResourcesTopology</c> and
        /// <c>AppTopologyClient.GenerateDiscoveredResourcesTopologyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateDiscoveredResourcesTopologySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppTopologyClient.GetSchema</c>
        ///  and <c>AppTopologyClient.GetSchemaAsync</c>.
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
        public gaxgrpc::CallSettings GetSchemaSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AppTopologyClient.GetDomain</c>
        ///  and <c>AppTopologyClient.GetDomainAsync</c>.
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
        public gaxgrpc::CallSettings GetDomainSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AppTopologyClient.ListDomains</c> and <c>AppTopologyClient.ListDomainsAsync</c>.
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
        public gaxgrpc::CallSettings ListDomainsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AppTopologySettings"/> object.</returns>
        public AppTopologySettings Clone() => new AppTopologySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AppTopologyClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AppTopologyClientBuilder : gaxgrpc::ClientBuilderBase<AppTopologyClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AppTopologySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AppTopologyClientBuilder() : base(AppTopologyClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AppTopologyClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AppTopologyClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AppTopologyClient Build()
        {
            AppTopologyClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AppTopologyClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AppTopologyClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AppTopologyClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AppTopologyClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AppTopologyClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AppTopologyClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AppTopologyClient.ChannelPool;
    }

    /// <summary>AppTopology client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class AppTopologyClient
    {
        /// <summary>
        /// The default endpoint for the AppTopology service, which is a host of "apptopology.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apptopology.googleapis.com:443";

        /// <summary>The default AppTopology scopes.</summary>
        /// <remarks>
        /// The default AppTopology scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/apptopology.read-only</description></item>
        /// <item><description>https://www.googleapis.com/auth/apptopology.read-write</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/apptopology.read-only",
            "https://www.googleapis.com/auth/apptopology.read-write",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AppTopology.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AppTopologyClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AppTopologyClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AppTopologyClient"/>.</returns>
        public static stt::Task<AppTopologyClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AppTopologyClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AppTopologyClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AppTopologyClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AppTopologyClient"/>.</returns>
        public static AppTopologyClient Create() => new AppTopologyClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AppTopologyClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AppTopologySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AppTopologyClient"/>.</returns>
        internal static AppTopologyClient Create(grpccore::CallInvoker callInvoker, AppTopologySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AppTopology.AppTopologyClient grpcClient = new AppTopology.AppTopologyClient(callInvoker);
            return new AppTopologyClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AppTopology client</summary>
        public virtual AppTopology.AppTopologyClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Generate the topology for all resources in the given project. If the
        /// project represents an
        /// [app
        /// boundary](https://cloud.google.com/app-hub/docs/reference/rest/v1/Boundary),
        /// the topology is generated for all resources in the boundary.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateDiscoveredResourcesTopologyResponse GenerateDiscoveredResourcesTopology(GenerateDiscoveredResourcesTopologyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate the topology for all resources in the given project. If the
        /// project represents an
        /// [app
        /// boundary](https://cloud.google.com/app-hub/docs/reference/rest/v1/Boundary),
        /// the topology is generated for all resources in the boundary.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateDiscoveredResourcesTopologyResponse> GenerateDiscoveredResourcesTopologyAsync(GenerateDiscoveredResourcesTopologyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate the topology for all resources in the given project. If the
        /// project represents an
        /// [app
        /// boundary](https://cloud.google.com/app-hub/docs/reference/rest/v1/Boundary),
        /// the topology is generated for all resources in the boundary.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateDiscoveredResourcesTopologyResponse> GenerateDiscoveredResourcesTopologyAsync(GenerateDiscoveredResourcesTopologyRequest request, st::CancellationToken cancellationToken) =>
            GenerateDiscoveredResourcesTopologyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate the topology for all resources in the given project. If the
        /// project represents an
        /// [app
        /// boundary](https://cloud.google.com/app-hub/docs/reference/rest/v1/Boundary),
        /// the topology is generated for all resources in the boundary.
        /// </summary>
        /// <param name="name">
        /// Required. The project to query discoverable resources on.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredResourcesTopology`.
        /// Only `global` location is supported.
        /// </param>
        /// <param name="topologyDomains">
        /// Required. The full resource name of the domain of the app topology.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}`
        /// Caller must have apptopology.domains.get permission on each of the domains.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateDiscoveredResourcesTopologyResponse GenerateDiscoveredResourcesTopology(string name, scg::IEnumerable<string> topologyDomains, gaxgrpc::CallSettings callSettings = null) =>
            GenerateDiscoveredResourcesTopology(new GenerateDiscoveredResourcesTopologyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                TopologyDomains =
                {
                    gax::GaxPreconditions.CheckNotNull(topologyDomains, nameof(topologyDomains)),
                },
            }, callSettings);

        /// <summary>
        /// Generate the topology for all resources in the given project. If the
        /// project represents an
        /// [app
        /// boundary](https://cloud.google.com/app-hub/docs/reference/rest/v1/Boundary),
        /// the topology is generated for all resources in the boundary.
        /// </summary>
        /// <param name="name">
        /// Required. The project to query discoverable resources on.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredResourcesTopology`.
        /// Only `global` location is supported.
        /// </param>
        /// <param name="topologyDomains">
        /// Required. The full resource name of the domain of the app topology.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}`
        /// Caller must have apptopology.domains.get permission on each of the domains.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateDiscoveredResourcesTopologyResponse> GenerateDiscoveredResourcesTopologyAsync(string name, scg::IEnumerable<string> topologyDomains, gaxgrpc::CallSettings callSettings = null) =>
            GenerateDiscoveredResourcesTopologyAsync(new GenerateDiscoveredResourcesTopologyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                TopologyDomains =
                {
                    gax::GaxPreconditions.CheckNotNull(topologyDomains, nameof(topologyDomains)),
                },
            }, callSettings);

        /// <summary>
        /// Generate the topology for all resources in the given project. If the
        /// project represents an
        /// [app
        /// boundary](https://cloud.google.com/app-hub/docs/reference/rest/v1/Boundary),
        /// the topology is generated for all resources in the boundary.
        /// </summary>
        /// <param name="name">
        /// Required. The project to query discoverable resources on.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredResourcesTopology`.
        /// Only `global` location is supported.
        /// </param>
        /// <param name="topologyDomains">
        /// Required. The full resource name of the domain of the app topology.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}`
        /// Caller must have apptopology.domains.get permission on each of the domains.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateDiscoveredResourcesTopologyResponse> GenerateDiscoveredResourcesTopologyAsync(string name, scg::IEnumerable<string> topologyDomains, st::CancellationToken cancellationToken) =>
            GenerateDiscoveredResourcesTopologyAsync(name, topologyDomains, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate the topology for all resources in the given project. If the
        /// project represents an
        /// [app
        /// boundary](https://cloud.google.com/app-hub/docs/reference/rest/v1/Boundary),
        /// the topology is generated for all resources in the boundary.
        /// </summary>
        /// <param name="name">
        /// Required. The project to query discoverable resources on.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredResourcesTopology`.
        /// Only `global` location is supported.
        /// </param>
        /// <param name="topologyDomains">
        /// Required. The full resource name of the domain of the app topology.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}`
        /// Caller must have apptopology.domains.get permission on each of the domains.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateDiscoveredResourcesTopologyResponse GenerateDiscoveredResourcesTopology(DiscoveredResourcesTopologyName name, scg::IEnumerable<DomainName> topologyDomains, gaxgrpc::CallSettings callSettings = null) =>
            GenerateDiscoveredResourcesTopology(new GenerateDiscoveredResourcesTopologyRequest
            {
                DiscoveredResourcesTopologyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                TopologyDomainsAsDomainNames =
                {
                    gax::GaxPreconditions.CheckNotNull(topologyDomains, nameof(topologyDomains)),
                },
            }, callSettings);

        /// <summary>
        /// Generate the topology for all resources in the given project. If the
        /// project represents an
        /// [app
        /// boundary](https://cloud.google.com/app-hub/docs/reference/rest/v1/Boundary),
        /// the topology is generated for all resources in the boundary.
        /// </summary>
        /// <param name="name">
        /// Required. The project to query discoverable resources on.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredResourcesTopology`.
        /// Only `global` location is supported.
        /// </param>
        /// <param name="topologyDomains">
        /// Required. The full resource name of the domain of the app topology.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}`
        /// Caller must have apptopology.domains.get permission on each of the domains.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateDiscoveredResourcesTopologyResponse> GenerateDiscoveredResourcesTopologyAsync(DiscoveredResourcesTopologyName name, scg::IEnumerable<DomainName> topologyDomains, gaxgrpc::CallSettings callSettings = null) =>
            GenerateDiscoveredResourcesTopologyAsync(new GenerateDiscoveredResourcesTopologyRequest
            {
                DiscoveredResourcesTopologyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                TopologyDomainsAsDomainNames =
                {
                    gax::GaxPreconditions.CheckNotNull(topologyDomains, nameof(topologyDomains)),
                },
            }, callSettings);

        /// <summary>
        /// Generate the topology for all resources in the given project. If the
        /// project represents an
        /// [app
        /// boundary](https://cloud.google.com/app-hub/docs/reference/rest/v1/Boundary),
        /// the topology is generated for all resources in the boundary.
        /// </summary>
        /// <param name="name">
        /// Required. The project to query discoverable resources on.
        /// Expected format:
        /// `projects/{project}/locations/{location}/discoveredResourcesTopology`.
        /// Only `global` location is supported.
        /// </param>
        /// <param name="topologyDomains">
        /// Required. The full resource name of the domain of the app topology.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}`
        /// Caller must have apptopology.domains.get permission on each of the domains.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateDiscoveredResourcesTopologyResponse> GenerateDiscoveredResourcesTopologyAsync(DiscoveredResourcesTopologyName name, scg::IEnumerable<DomainName> topologyDomains, st::CancellationToken cancellationToken) =>
            GenerateDiscoveredResourcesTopologyAsync(name, topologyDomains, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the schema for the specified topology domain. The schema
        /// defines the NodeTypes and EdgeTypes that are supported in
        /// GenerateDiscoveredResourcesTopology requests and responses for a given
        /// domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schema GetSchema(GetSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the schema for the specified topology domain. The schema
        /// defines the NodeTypes and EdgeTypes that are supported in
        /// GenerateDiscoveredResourcesTopology requests and responses for a given
        /// domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(GetSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the schema for the specified topology domain. The schema
        /// defines the NodeTypes and EdgeTypes that are supported in
        /// GenerateDiscoveredResourcesTopology requests and responses for a given
        /// domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(GetSchemaRequest request, st::CancellationToken cancellationToken) =>
            GetSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the schema for the specified topology domain. The schema
        /// defines the NodeTypes and EdgeTypes that are supported in
        /// GenerateDiscoveredResourcesTopology requests and responses for a given
        /// domain.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the singleton domain schema resource.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}/schema`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schema GetSchema(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchema(new GetSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the schema for the specified topology domain. The schema
        /// defines the NodeTypes and EdgeTypes that are supported in
        /// GenerateDiscoveredResourcesTopology requests and responses for a given
        /// domain.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the singleton domain schema resource.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}/schema`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchemaAsync(new GetSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the schema for the specified topology domain. The schema
        /// defines the NodeTypes and EdgeTypes that are supported in
        /// GenerateDiscoveredResourcesTopology requests and responses for a given
        /// domain.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the singleton domain schema resource.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}/schema`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(string name, st::CancellationToken cancellationToken) =>
            GetSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the schema for the specified topology domain. The schema
        /// defines the NodeTypes and EdgeTypes that are supported in
        /// GenerateDiscoveredResourcesTopology requests and responses for a given
        /// domain.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the singleton domain schema resource.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}/schema`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schema GetSchema(SchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchema(new GetSchemaRequest
            {
                SchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the schema for the specified topology domain. The schema
        /// defines the NodeTypes and EdgeTypes that are supported in
        /// GenerateDiscoveredResourcesTopology requests and responses for a given
        /// domain.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the singleton domain schema resource.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}/schema`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(SchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchemaAsync(new GetSchemaRequest
            {
                SchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the schema for the specified topology domain. The schema
        /// defines the NodeTypes and EdgeTypes that are supported in
        /// GenerateDiscoveredResourcesTopology requests and responses for a given
        /// domain.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the singleton domain schema resource.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}/schema`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(SchemaName name, st::CancellationToken cancellationToken) =>
            GetSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified topology domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Domain GetDomain(GetDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified topology domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Domain> GetDomainAsync(GetDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified topology domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Domain> GetDomainAsync(GetDomainRequest request, st::CancellationToken cancellationToken) =>
            GetDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified topology domain.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the domain to retrieve.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Domain GetDomain(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDomain(new GetDomainRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified topology domain.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the domain to retrieve.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Domain> GetDomainAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDomainAsync(new GetDomainRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified topology domain.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the domain to retrieve.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Domain> GetDomainAsync(string name, st::CancellationToken cancellationToken) =>
            GetDomainAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified topology domain.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the domain to retrieve.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Domain GetDomain(DomainName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDomain(new GetDomainRequest
            {
                DomainName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified topology domain.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the domain to retrieve.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Domain> GetDomainAsync(DomainName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDomainAsync(new GetDomainRequest
            {
                DomainName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified topology domain.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the domain to retrieve.
        /// Format: `projects/{project}/locations/{location}/domains/{domain}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Domain> GetDomainAsync(DomainName name, st::CancellationToken cancellationToken) =>
            GetDomainAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the topology domains available in a specific location.
        /// Only `global` location is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Domain"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDomainsResponse, Domain> ListDomains(ListDomainsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the topology domains available in a specific location.
        /// Only `global` location is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Domain"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDomainsResponse, Domain> ListDomainsAsync(ListDomainsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the topology domains available in a specific location.
        /// Only `global` location is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to list domains for.
        /// Format: `projects/{project}/locations/{location}`
        /// Only `global` location is supported.
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
        /// <returns>A pageable sequence of <see cref="Domain"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDomainsResponse, Domain> ListDomains(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDomainsRequest request = new ListDomainsRequest
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
            return ListDomains(request, callSettings);
        }

        /// <summary>
        /// Lists the topology domains available in a specific location.
        /// Only `global` location is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to list domains for.
        /// Format: `projects/{project}/locations/{location}`
        /// Only `global` location is supported.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Domain"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDomainsResponse, Domain> ListDomainsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDomainsRequest request = new ListDomainsRequest
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
            return ListDomainsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the topology domains available in a specific location.
        /// Only `global` location is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to list domains for.
        /// Format: `projects/{project}/locations/{location}`
        /// Only `global` location is supported.
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
        /// <returns>A pageable sequence of <see cref="Domain"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDomainsResponse, Domain> ListDomains(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDomainsRequest request = new ListDomainsRequest
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
            return ListDomains(request, callSettings);
        }

        /// <summary>
        /// Lists the topology domains available in a specific location.
        /// Only `global` location is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location to list domains for.
        /// Format: `projects/{project}/locations/{location}`
        /// Only `global` location is supported.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Domain"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDomainsResponse, Domain> ListDomainsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDomainsRequest request = new ListDomainsRequest
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
            return ListDomainsAsync(request, callSettings);
        }
    }

    /// <summary>AppTopology client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class AppTopologyClientImpl : AppTopologyClient
    {
        private readonly gaxgrpc::ApiCall<GenerateDiscoveredResourcesTopologyRequest, GenerateDiscoveredResourcesTopologyResponse> _callGenerateDiscoveredResourcesTopology;

        private readonly gaxgrpc::ApiCall<GetSchemaRequest, Schema> _callGetSchema;

        private readonly gaxgrpc::ApiCall<GetDomainRequest, Domain> _callGetDomain;

        private readonly gaxgrpc::ApiCall<ListDomainsRequest, ListDomainsResponse> _callListDomains;

        /// <summary>
        /// Constructs a client wrapper for the AppTopology service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AppTopologySettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AppTopologyClientImpl(AppTopology.AppTopologyClient grpcClient, AppTopologySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AppTopologySettings effectiveSettings = settings ?? AppTopologySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGenerateDiscoveredResourcesTopology = clientHelper.BuildApiCall<GenerateDiscoveredResourcesTopologyRequest, GenerateDiscoveredResourcesTopologyResponse>("GenerateDiscoveredResourcesTopology", grpcClient.GenerateDiscoveredResourcesTopologyAsync, grpcClient.GenerateDiscoveredResourcesTopology, effectiveSettings.GenerateDiscoveredResourcesTopologySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateDiscoveredResourcesTopology);
            Modify_GenerateDiscoveredResourcesTopologyApiCall(ref _callGenerateDiscoveredResourcesTopology);
            _callGetSchema = clientHelper.BuildApiCall<GetSchemaRequest, Schema>("GetSchema", grpcClient.GetSchemaAsync, grpcClient.GetSchema, effectiveSettings.GetSchemaSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSchema);
            Modify_GetSchemaApiCall(ref _callGetSchema);
            _callGetDomain = clientHelper.BuildApiCall<GetDomainRequest, Domain>("GetDomain", grpcClient.GetDomainAsync, grpcClient.GetDomain, effectiveSettings.GetDomainSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDomain);
            Modify_GetDomainApiCall(ref _callGetDomain);
            _callListDomains = clientHelper.BuildApiCall<ListDomainsRequest, ListDomainsResponse>("ListDomains", grpcClient.ListDomainsAsync, grpcClient.ListDomains, effectiveSettings.ListDomainsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDomains);
            Modify_ListDomainsApiCall(ref _callListDomains);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateDiscoveredResourcesTopologyApiCall(ref gaxgrpc::ApiCall<GenerateDiscoveredResourcesTopologyRequest, GenerateDiscoveredResourcesTopologyResponse> call);

        partial void Modify_GetSchemaApiCall(ref gaxgrpc::ApiCall<GetSchemaRequest, Schema> call);

        partial void Modify_GetDomainApiCall(ref gaxgrpc::ApiCall<GetDomainRequest, Domain> call);

        partial void Modify_ListDomainsApiCall(ref gaxgrpc::ApiCall<ListDomainsRequest, ListDomainsResponse> call);

        partial void OnConstruction(AppTopology.AppTopologyClient grpcClient, AppTopologySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AppTopology client</summary>
        public override AppTopology.AppTopologyClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GenerateDiscoveredResourcesTopologyRequest(ref GenerateDiscoveredResourcesTopologyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSchemaRequest(ref GetSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDomainRequest(ref GetDomainRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDomainsRequest(ref ListDomainsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Generate the topology for all resources in the given project. If the
        /// project represents an
        /// [app
        /// boundary](https://cloud.google.com/app-hub/docs/reference/rest/v1/Boundary),
        /// the topology is generated for all resources in the boundary.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateDiscoveredResourcesTopologyResponse GenerateDiscoveredResourcesTopology(GenerateDiscoveredResourcesTopologyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateDiscoveredResourcesTopologyRequest(ref request, ref callSettings);
            return _callGenerateDiscoveredResourcesTopology.Sync(request, callSettings);
        }

        /// <summary>
        /// Generate the topology for all resources in the given project. If the
        /// project represents an
        /// [app
        /// boundary](https://cloud.google.com/app-hub/docs/reference/rest/v1/Boundary),
        /// the topology is generated for all resources in the boundary.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateDiscoveredResourcesTopologyResponse> GenerateDiscoveredResourcesTopologyAsync(GenerateDiscoveredResourcesTopologyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateDiscoveredResourcesTopologyRequest(ref request, ref callSettings);
            return _callGenerateDiscoveredResourcesTopology.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the schema for the specified topology domain. The schema
        /// defines the NodeTypes and EdgeTypes that are supported in
        /// GenerateDiscoveredResourcesTopology requests and responses for a given
        /// domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Schema GetSchema(GetSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSchemaRequest(ref request, ref callSettings);
            return _callGetSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the schema for the specified topology domain. The schema
        /// defines the NodeTypes and EdgeTypes that are supported in
        /// GenerateDiscoveredResourcesTopology requests and responses for a given
        /// domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Schema> GetSchemaAsync(GetSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSchemaRequest(ref request, ref callSettings);
            return _callGetSchema.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified topology domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Domain GetDomain(GetDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDomainRequest(ref request, ref callSettings);
            return _callGetDomain.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified topology domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Domain> GetDomainAsync(GetDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDomainRequest(ref request, ref callSettings);
            return _callGetDomain.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the topology domains available in a specific location.
        /// Only `global` location is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Domain"/> resources.</returns>
        public override gax::PagedEnumerable<ListDomainsResponse, Domain> ListDomains(ListDomainsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDomainsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDomainsRequest, ListDomainsResponse, Domain>(_callListDomains, request, callSettings);
        }

        /// <summary>
        /// Lists the topology domains available in a specific location.
        /// Only `global` location is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Domain"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDomainsResponse, Domain> ListDomainsAsync(ListDomainsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDomainsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDomainsRequest, ListDomainsResponse, Domain>(_callListDomains, request, callSettings);
        }
    }

    public partial class ListDomainsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDomainsResponse : gaxgrpc::IPageResponse<Domain>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Domain> GetEnumerator() => Domains.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AppTopology
    {
        public partial class AppTopologyClient
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
