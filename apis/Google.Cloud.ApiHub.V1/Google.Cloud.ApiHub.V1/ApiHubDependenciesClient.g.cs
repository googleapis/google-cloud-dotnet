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

namespace Google.Cloud.ApiHub.V1
{
    /// <summary>Settings for <see cref="ApiHubDependenciesClient"/> instances.</summary>
    public sealed partial class ApiHubDependenciesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ApiHubDependenciesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ApiHubDependenciesSettings"/>.</returns>
        public static ApiHubDependenciesSettings GetDefault() => new ApiHubDependenciesSettings();

        /// <summary>Constructs a new <see cref="ApiHubDependenciesSettings"/> object with default settings.</summary>
        public ApiHubDependenciesSettings()
        {
        }

        private ApiHubDependenciesSettings(ApiHubDependenciesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDependencySettings = existing.CreateDependencySettings;
            GetDependencySettings = existing.GetDependencySettings;
            UpdateDependencySettings = existing.UpdateDependencySettings;
            DeleteDependencySettings = existing.DeleteDependencySettings;
            ListDependenciesSettings = existing.ListDependenciesSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ApiHubDependenciesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubDependenciesClient.CreateDependency</c> and <c>ApiHubDependenciesClient.CreateDependencyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDependencySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubDependenciesClient.GetDependency</c> and <c>ApiHubDependenciesClient.GetDependencyAsync</c>.
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
        public gaxgrpc::CallSettings GetDependencySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubDependenciesClient.UpdateDependency</c> and <c>ApiHubDependenciesClient.UpdateDependencyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDependencySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubDependenciesClient.DeleteDependency</c> and <c>ApiHubDependenciesClient.DeleteDependencyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDependencySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubDependenciesClient.ListDependencies</c> and <c>ApiHubDependenciesClient.ListDependenciesAsync</c>.
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
        public gaxgrpc::CallSettings ListDependenciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ApiHubDependenciesSettings"/> object.</returns>
        public ApiHubDependenciesSettings Clone() => new ApiHubDependenciesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ApiHubDependenciesClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ApiHubDependenciesClientBuilder : gaxgrpc::ClientBuilderBase<ApiHubDependenciesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ApiHubDependenciesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ApiHubDependenciesClientBuilder() : base(ApiHubDependenciesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ApiHubDependenciesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ApiHubDependenciesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ApiHubDependenciesClient Build()
        {
            ApiHubDependenciesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ApiHubDependenciesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ApiHubDependenciesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ApiHubDependenciesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ApiHubDependenciesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ApiHubDependenciesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ApiHubDependenciesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ApiHubDependenciesClient.ChannelPool;
    }

    /// <summary>ApiHubDependencies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service provides methods for various operations related to a
    /// [Dependency][google.cloud.apihub.v1.Dependency] in the API hub.
    /// </remarks>
    public abstract partial class ApiHubDependenciesClient
    {
        /// <summary>
        /// The default endpoint for the ApiHubDependencies service, which is a host of "apihub.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apihub.googleapis.com:443";

        /// <summary>The default ApiHubDependencies scopes.</summary>
        /// <remarks>
        /// The default ApiHubDependencies scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ApiHubDependencies.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ApiHubDependenciesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApiHubDependenciesClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ApiHubDependenciesClient"/>.</returns>
        public static stt::Task<ApiHubDependenciesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ApiHubDependenciesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ApiHubDependenciesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApiHubDependenciesClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="ApiHubDependenciesClient"/>.</returns>
        public static ApiHubDependenciesClient Create() => new ApiHubDependenciesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ApiHubDependenciesClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ApiHubDependenciesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ApiHubDependenciesClient"/>.</returns>
        internal static ApiHubDependenciesClient Create(grpccore::CallInvoker callInvoker, ApiHubDependenciesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ApiHubDependencies.ApiHubDependenciesClient grpcClient = new ApiHubDependencies.ApiHubDependenciesClient(callInvoker);
            return new ApiHubDependenciesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ApiHubDependencies client</summary>
        public virtual ApiHubDependencies.ApiHubDependenciesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a dependency between two entities in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dependency CreateDependency(CreateDependencyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a dependency between two entities in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> CreateDependencyAsync(CreateDependencyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a dependency between two entities in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> CreateDependencyAsync(CreateDependencyRequest request, st::CancellationToken cancellationToken) =>
            CreateDependencyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a dependency between two entities in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the dependency resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dependency">
        /// Required. The dependency resource to create.
        /// </param>
        /// <param name="dependencyId">
        /// Optional. The ID to use for the dependency resource, which will become the
        /// final component of the dependency's resource name. This field is optional.
        /// * If provided, the same will be used. The service will throw an error if
        /// duplicate id is provided by the client.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are `[a-z][A-Z][0-9]-_`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dependency CreateDependency(string parent, Dependency dependency, string dependencyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDependency(new CreateDependencyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DependencyId = dependencyId ?? "",
                Dependency = gax::GaxPreconditions.CheckNotNull(dependency, nameof(dependency)),
            }, callSettings);

        /// <summary>
        /// Create a dependency between two entities in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the dependency resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dependency">
        /// Required. The dependency resource to create.
        /// </param>
        /// <param name="dependencyId">
        /// Optional. The ID to use for the dependency resource, which will become the
        /// final component of the dependency's resource name. This field is optional.
        /// * If provided, the same will be used. The service will throw an error if
        /// duplicate id is provided by the client.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are `[a-z][A-Z][0-9]-_`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> CreateDependencyAsync(string parent, Dependency dependency, string dependencyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDependencyAsync(new CreateDependencyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DependencyId = dependencyId ?? "",
                Dependency = gax::GaxPreconditions.CheckNotNull(dependency, nameof(dependency)),
            }, callSettings);

        /// <summary>
        /// Create a dependency between two entities in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the dependency resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dependency">
        /// Required. The dependency resource to create.
        /// </param>
        /// <param name="dependencyId">
        /// Optional. The ID to use for the dependency resource, which will become the
        /// final component of the dependency's resource name. This field is optional.
        /// * If provided, the same will be used. The service will throw an error if
        /// duplicate id is provided by the client.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are `[a-z][A-Z][0-9]-_`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> CreateDependencyAsync(string parent, Dependency dependency, string dependencyId, st::CancellationToken cancellationToken) =>
            CreateDependencyAsync(parent, dependency, dependencyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a dependency between two entities in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the dependency resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dependency">
        /// Required. The dependency resource to create.
        /// </param>
        /// <param name="dependencyId">
        /// Optional. The ID to use for the dependency resource, which will become the
        /// final component of the dependency's resource name. This field is optional.
        /// * If provided, the same will be used. The service will throw an error if
        /// duplicate id is provided by the client.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are `[a-z][A-Z][0-9]-_`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dependency CreateDependency(gagr::LocationName parent, Dependency dependency, string dependencyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDependency(new CreateDependencyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DependencyId = dependencyId ?? "",
                Dependency = gax::GaxPreconditions.CheckNotNull(dependency, nameof(dependency)),
            }, callSettings);

        /// <summary>
        /// Create a dependency between two entities in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the dependency resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dependency">
        /// Required. The dependency resource to create.
        /// </param>
        /// <param name="dependencyId">
        /// Optional. The ID to use for the dependency resource, which will become the
        /// final component of the dependency's resource name. This field is optional.
        /// * If provided, the same will be used. The service will throw an error if
        /// duplicate id is provided by the client.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are `[a-z][A-Z][0-9]-_`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> CreateDependencyAsync(gagr::LocationName parent, Dependency dependency, string dependencyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDependencyAsync(new CreateDependencyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DependencyId = dependencyId ?? "",
                Dependency = gax::GaxPreconditions.CheckNotNull(dependency, nameof(dependency)),
            }, callSettings);

        /// <summary>
        /// Create a dependency between two entities in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the dependency resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="dependency">
        /// Required. The dependency resource to create.
        /// </param>
        /// <param name="dependencyId">
        /// Optional. The ID to use for the dependency resource, which will become the
        /// final component of the dependency's resource name. This field is optional.
        /// * If provided, the same will be used. The service will throw an error if
        /// duplicate id is provided by the client.
        /// * If not provided, a system generated id will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are `[a-z][A-Z][0-9]-_`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> CreateDependencyAsync(gagr::LocationName parent, Dependency dependency, string dependencyId, st::CancellationToken cancellationToken) =>
            CreateDependencyAsync(parent, dependency, dependencyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a dependency resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dependency GetDependency(GetDependencyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about a dependency resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> GetDependencyAsync(GetDependencyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about a dependency resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> GetDependencyAsync(GetDependencyRequest request, st::CancellationToken cancellationToken) =>
            GetDependencyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a dependency resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dependency resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dependency GetDependency(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDependency(new GetDependencyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a dependency resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dependency resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> GetDependencyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDependencyAsync(new GetDependencyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a dependency resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dependency resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> GetDependencyAsync(string name, st::CancellationToken cancellationToken) =>
            GetDependencyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a dependency resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dependency resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dependency GetDependency(DependencyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDependency(new GetDependencyRequest
            {
                DependencyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a dependency resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dependency resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> GetDependencyAsync(DependencyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDependencyAsync(new GetDependencyRequest
            {
                DependencyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a dependency resource in the API hub.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dependency resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> GetDependencyAsync(DependencyName name, st::CancellationToken cancellationToken) =>
            GetDependencyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a dependency based on the
        /// [update_mask][google.cloud.apihub.v1.UpdateDependencyRequest.update_mask]
        /// provided in the request.
        /// 
        /// The following fields in the [dependency][google.cloud.apihub.v1.Dependency]
        /// can be updated:
        /// * [description][google.cloud.apihub.v1.Dependency.description]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dependency UpdateDependency(UpdateDependencyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a dependency based on the
        /// [update_mask][google.cloud.apihub.v1.UpdateDependencyRequest.update_mask]
        /// provided in the request.
        /// 
        /// The following fields in the [dependency][google.cloud.apihub.v1.Dependency]
        /// can be updated:
        /// * [description][google.cloud.apihub.v1.Dependency.description]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> UpdateDependencyAsync(UpdateDependencyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a dependency based on the
        /// [update_mask][google.cloud.apihub.v1.UpdateDependencyRequest.update_mask]
        /// provided in the request.
        /// 
        /// The following fields in the [dependency][google.cloud.apihub.v1.Dependency]
        /// can be updated:
        /// * [description][google.cloud.apihub.v1.Dependency.description]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> UpdateDependencyAsync(UpdateDependencyRequest request, st::CancellationToken cancellationToken) =>
            UpdateDependencyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a dependency based on the
        /// [update_mask][google.cloud.apihub.v1.UpdateDependencyRequest.update_mask]
        /// provided in the request.
        /// 
        /// The following fields in the [dependency][google.cloud.apihub.v1.Dependency]
        /// can be updated:
        /// * [description][google.cloud.apihub.v1.Dependency.description]
        /// </summary>
        /// <param name="dependency">
        /// Required. The dependency resource to update.
        /// 
        /// The dependency's `name` field is used to identify the dependency to update.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dependency UpdateDependency(Dependency dependency, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDependency(new UpdateDependencyRequest
            {
                Dependency = gax::GaxPreconditions.CheckNotNull(dependency, nameof(dependency)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a dependency based on the
        /// [update_mask][google.cloud.apihub.v1.UpdateDependencyRequest.update_mask]
        /// provided in the request.
        /// 
        /// The following fields in the [dependency][google.cloud.apihub.v1.Dependency]
        /// can be updated:
        /// * [description][google.cloud.apihub.v1.Dependency.description]
        /// </summary>
        /// <param name="dependency">
        /// Required. The dependency resource to update.
        /// 
        /// The dependency's `name` field is used to identify the dependency to update.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> UpdateDependencyAsync(Dependency dependency, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDependencyAsync(new UpdateDependencyRequest
            {
                Dependency = gax::GaxPreconditions.CheckNotNull(dependency, nameof(dependency)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a dependency based on the
        /// [update_mask][google.cloud.apihub.v1.UpdateDependencyRequest.update_mask]
        /// provided in the request.
        /// 
        /// The following fields in the [dependency][google.cloud.apihub.v1.Dependency]
        /// can be updated:
        /// * [description][google.cloud.apihub.v1.Dependency.description]
        /// </summary>
        /// <param name="dependency">
        /// Required. The dependency resource to update.
        /// 
        /// The dependency's `name` field is used to identify the dependency to update.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dependency> UpdateDependencyAsync(Dependency dependency, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDependencyAsync(dependency, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the dependency resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDependency(DeleteDependencyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the dependency resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDependencyAsync(DeleteDependencyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the dependency resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDependencyAsync(DeleteDependencyRequest request, st::CancellationToken cancellationToken) =>
            DeleteDependencyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the dependency resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dependency resource to delete.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDependency(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDependency(new DeleteDependencyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the dependency resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dependency resource to delete.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDependencyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDependencyAsync(new DeleteDependencyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the dependency resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dependency resource to delete.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDependencyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDependencyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the dependency resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dependency resource to delete.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDependency(DependencyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDependency(new DeleteDependencyRequest
            {
                DependencyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the dependency resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dependency resource to delete.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDependencyAsync(DependencyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDependencyAsync(new DeleteDependencyRequest
            {
                DependencyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the dependency resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the dependency resource to delete.
        /// Format: `projects/{project}/locations/{location}/dependencies/{dependency}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDependencyAsync(DependencyName name, st::CancellationToken cancellationToken) =>
            DeleteDependencyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List dependencies based on the provided filter and pagination parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dependency"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDependenciesResponse, Dependency> ListDependencies(ListDependenciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List dependencies based on the provided filter and pagination parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dependency"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDependenciesResponse, Dependency> ListDependenciesAsync(ListDependenciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List dependencies based on the provided filter and pagination parameters.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of dependency resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Dependency"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDependenciesResponse, Dependency> ListDependencies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDependenciesRequest request = new ListDependenciesRequest
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
            return ListDependencies(request, callSettings);
        }

        /// <summary>
        /// List dependencies based on the provided filter and pagination parameters.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of dependency resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Dependency"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDependenciesResponse, Dependency> ListDependenciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDependenciesRequest request = new ListDependenciesRequest
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
            return ListDependenciesAsync(request, callSettings);
        }

        /// <summary>
        /// List dependencies based on the provided filter and pagination parameters.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of dependency resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Dependency"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDependenciesResponse, Dependency> ListDependencies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDependenciesRequest request = new ListDependenciesRequest
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
            return ListDependencies(request, callSettings);
        }

        /// <summary>
        /// List dependencies based on the provided filter and pagination parameters.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns this collection of dependency resources.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Dependency"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDependenciesResponse, Dependency> ListDependenciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDependenciesRequest request = new ListDependenciesRequest
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
            return ListDependenciesAsync(request, callSettings);
        }
    }

    /// <summary>ApiHubDependencies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service provides methods for various operations related to a
    /// [Dependency][google.cloud.apihub.v1.Dependency] in the API hub.
    /// </remarks>
    public sealed partial class ApiHubDependenciesClientImpl : ApiHubDependenciesClient
    {
        private readonly gaxgrpc::ApiCall<CreateDependencyRequest, Dependency> _callCreateDependency;

        private readonly gaxgrpc::ApiCall<GetDependencyRequest, Dependency> _callGetDependency;

        private readonly gaxgrpc::ApiCall<UpdateDependencyRequest, Dependency> _callUpdateDependency;

        private readonly gaxgrpc::ApiCall<DeleteDependencyRequest, wkt::Empty> _callDeleteDependency;

        private readonly gaxgrpc::ApiCall<ListDependenciesRequest, ListDependenciesResponse> _callListDependencies;

        /// <summary>
        /// Constructs a client wrapper for the ApiHubDependencies service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ApiHubDependenciesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ApiHubDependenciesClientImpl(ApiHubDependencies.ApiHubDependenciesClient grpcClient, ApiHubDependenciesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ApiHubDependenciesSettings effectiveSettings = settings ?? ApiHubDependenciesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateDependency = clientHelper.BuildApiCall<CreateDependencyRequest, Dependency>("CreateDependency", grpcClient.CreateDependencyAsync, grpcClient.CreateDependency, effectiveSettings.CreateDependencySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDependency);
            Modify_CreateDependencyApiCall(ref _callCreateDependency);
            _callGetDependency = clientHelper.BuildApiCall<GetDependencyRequest, Dependency>("GetDependency", grpcClient.GetDependencyAsync, grpcClient.GetDependency, effectiveSettings.GetDependencySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDependency);
            Modify_GetDependencyApiCall(ref _callGetDependency);
            _callUpdateDependency = clientHelper.BuildApiCall<UpdateDependencyRequest, Dependency>("UpdateDependency", grpcClient.UpdateDependencyAsync, grpcClient.UpdateDependency, effectiveSettings.UpdateDependencySettings).WithGoogleRequestParam("dependency.name", request => request.Dependency?.Name);
            Modify_ApiCall(ref _callUpdateDependency);
            Modify_UpdateDependencyApiCall(ref _callUpdateDependency);
            _callDeleteDependency = clientHelper.BuildApiCall<DeleteDependencyRequest, wkt::Empty>("DeleteDependency", grpcClient.DeleteDependencyAsync, grpcClient.DeleteDependency, effectiveSettings.DeleteDependencySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDependency);
            Modify_DeleteDependencyApiCall(ref _callDeleteDependency);
            _callListDependencies = clientHelper.BuildApiCall<ListDependenciesRequest, ListDependenciesResponse>("ListDependencies", grpcClient.ListDependenciesAsync, grpcClient.ListDependencies, effectiveSettings.ListDependenciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDependencies);
            Modify_ListDependenciesApiCall(ref _callListDependencies);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDependencyApiCall(ref gaxgrpc::ApiCall<CreateDependencyRequest, Dependency> call);

        partial void Modify_GetDependencyApiCall(ref gaxgrpc::ApiCall<GetDependencyRequest, Dependency> call);

        partial void Modify_UpdateDependencyApiCall(ref gaxgrpc::ApiCall<UpdateDependencyRequest, Dependency> call);

        partial void Modify_DeleteDependencyApiCall(ref gaxgrpc::ApiCall<DeleteDependencyRequest, wkt::Empty> call);

        partial void Modify_ListDependenciesApiCall(ref gaxgrpc::ApiCall<ListDependenciesRequest, ListDependenciesResponse> call);

        partial void OnConstruction(ApiHubDependencies.ApiHubDependenciesClient grpcClient, ApiHubDependenciesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ApiHubDependencies client</summary>
        public override ApiHubDependencies.ApiHubDependenciesClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateDependencyRequest(ref CreateDependencyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDependencyRequest(ref GetDependencyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDependencyRequest(ref UpdateDependencyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDependencyRequest(ref DeleteDependencyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDependenciesRequest(ref ListDependenciesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a dependency between two entities in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dependency CreateDependency(CreateDependencyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDependencyRequest(ref request, ref callSettings);
            return _callCreateDependency.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a dependency between two entities in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dependency> CreateDependencyAsync(CreateDependencyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDependencyRequest(ref request, ref callSettings);
            return _callCreateDependency.Async(request, callSettings);
        }

        /// <summary>
        /// Get details about a dependency resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dependency GetDependency(GetDependencyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDependencyRequest(ref request, ref callSettings);
            return _callGetDependency.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details about a dependency resource in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dependency> GetDependencyAsync(GetDependencyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDependencyRequest(ref request, ref callSettings);
            return _callGetDependency.Async(request, callSettings);
        }

        /// <summary>
        /// Update a dependency based on the
        /// [update_mask][google.cloud.apihub.v1.UpdateDependencyRequest.update_mask]
        /// provided in the request.
        /// 
        /// The following fields in the [dependency][google.cloud.apihub.v1.Dependency]
        /// can be updated:
        /// * [description][google.cloud.apihub.v1.Dependency.description]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dependency UpdateDependency(UpdateDependencyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDependencyRequest(ref request, ref callSettings);
            return _callUpdateDependency.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a dependency based on the
        /// [update_mask][google.cloud.apihub.v1.UpdateDependencyRequest.update_mask]
        /// provided in the request.
        /// 
        /// The following fields in the [dependency][google.cloud.apihub.v1.Dependency]
        /// can be updated:
        /// * [description][google.cloud.apihub.v1.Dependency.description]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dependency> UpdateDependencyAsync(UpdateDependencyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDependencyRequest(ref request, ref callSettings);
            return _callUpdateDependency.Async(request, callSettings);
        }

        /// <summary>
        /// Delete the dependency resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDependency(DeleteDependencyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDependencyRequest(ref request, ref callSettings);
            _callDeleteDependency.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete the dependency resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDependencyAsync(DeleteDependencyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDependencyRequest(ref request, ref callSettings);
            return _callDeleteDependency.Async(request, callSettings);
        }

        /// <summary>
        /// List dependencies based on the provided filter and pagination parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dependency"/> resources.</returns>
        public override gax::PagedEnumerable<ListDependenciesResponse, Dependency> ListDependencies(ListDependenciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDependenciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDependenciesRequest, ListDependenciesResponse, Dependency>(_callListDependencies, request, callSettings);
        }

        /// <summary>
        /// List dependencies based on the provided filter and pagination parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dependency"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDependenciesResponse, Dependency> ListDependenciesAsync(ListDependenciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDependenciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDependenciesRequest, ListDependenciesResponse, Dependency>(_callListDependencies, request, callSettings);
        }
    }

    public partial class ListDependenciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDependenciesResponse : gaxgrpc::IPageResponse<Dependency>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Dependency> GetEnumerator() => Dependencies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ApiHubDependencies
    {
        public partial class ApiHubDependenciesClient
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
