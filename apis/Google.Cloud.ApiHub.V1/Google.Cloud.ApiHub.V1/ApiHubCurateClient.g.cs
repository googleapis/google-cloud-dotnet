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

namespace Google.Cloud.ApiHub.V1
{
    /// <summary>Settings for <see cref="ApiHubCurateClient"/> instances.</summary>
    public sealed partial class ApiHubCurateSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ApiHubCurateSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ApiHubCurateSettings"/>.</returns>
        public static ApiHubCurateSettings GetDefault() => new ApiHubCurateSettings();

        /// <summary>Constructs a new <see cref="ApiHubCurateSettings"/> object with default settings.</summary>
        public ApiHubCurateSettings()
        {
        }

        private ApiHubCurateSettings(ApiHubCurateSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateCurationSettings = existing.CreateCurationSettings;
            GetCurationSettings = existing.GetCurationSettings;
            ListCurationsSettings = existing.ListCurationsSettings;
            UpdateCurationSettings = existing.UpdateCurationSettings;
            DeleteCurationSettings = existing.DeleteCurationSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ApiHubCurateSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubCurateClient.CreateCuration</c> and <c>ApiHubCurateClient.CreateCurationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCurationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubCurateClient.GetCuration</c> and <c>ApiHubCurateClient.GetCurationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCurationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubCurateClient.ListCurations</c> and <c>ApiHubCurateClient.ListCurationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCurationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubCurateClient.UpdateCuration</c> and <c>ApiHubCurateClient.UpdateCurationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCurationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ApiHubCurateClient.DeleteCuration</c> and <c>ApiHubCurateClient.DeleteCurationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCurationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ApiHubCurateSettings"/> object.</returns>
        public ApiHubCurateSettings Clone() => new ApiHubCurateSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ApiHubCurateClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ApiHubCurateClientBuilder : gaxgrpc::ClientBuilderBase<ApiHubCurateClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ApiHubCurateSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ApiHubCurateClientBuilder() : base(ApiHubCurateClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ApiHubCurateClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ApiHubCurateClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ApiHubCurateClient Build()
        {
            ApiHubCurateClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ApiHubCurateClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ApiHubCurateClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ApiHubCurateClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ApiHubCurateClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ApiHubCurateClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ApiHubCurateClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ApiHubCurateClient.ChannelPool;
    }

    /// <summary>ApiHubCurate client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service is used for managing curations for processing API data consumed
    /// from collect layer.
    /// </remarks>
    public abstract partial class ApiHubCurateClient
    {
        /// <summary>
        /// The default endpoint for the ApiHubCurate service, which is a host of "apihub.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "apihub.googleapis.com:443";

        /// <summary>The default ApiHubCurate scopes.</summary>
        /// <remarks>
        /// The default ApiHubCurate scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ApiHubCurate.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ApiHubCurateClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApiHubCurateClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ApiHubCurateClient"/>.</returns>
        public static stt::Task<ApiHubCurateClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ApiHubCurateClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ApiHubCurateClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ApiHubCurateClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ApiHubCurateClient"/>.</returns>
        public static ApiHubCurateClient Create() => new ApiHubCurateClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ApiHubCurateClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ApiHubCurateSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ApiHubCurateClient"/>.</returns>
        internal static ApiHubCurateClient Create(grpccore::CallInvoker callInvoker, ApiHubCurateSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ApiHubCurate.ApiHubCurateClient grpcClient = new ApiHubCurate.ApiHubCurateClient(callInvoker);
            return new ApiHubCurateClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ApiHubCurate client</summary>
        public virtual ApiHubCurate.ApiHubCurateClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a curation resource in the API hub.
        /// Once a curation resource is created, plugin instances can start using it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Curation CreateCuration(CreateCurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a curation resource in the API hub.
        /// Once a curation resource is created, plugin instances can start using it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> CreateCurationAsync(CreateCurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a curation resource in the API hub.
        /// Once a curation resource is created, plugin instances can start using it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> CreateCurationAsync(CreateCurationRequest request, st::CancellationToken cancellationToken) =>
            CreateCurationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a curation resource in the API hub.
        /// Once a curation resource is created, plugin instances can start using it.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the curation resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="curation">
        /// Required. The curation resource to create.
        /// </param>
        /// <param name="curationId">
        /// Optional. The ID to use for the curation resource, which will become the
        /// final component of the curations's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified ID is already used by another curation resource in the API
        /// hub.
        /// * If not provided, a system generated ID will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Curation CreateCuration(string parent, Curation curation, string curationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCuration(new CreateCurationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CurationId = curationId ?? "",
                Curation = gax::GaxPreconditions.CheckNotNull(curation, nameof(curation)),
            }, callSettings);

        /// <summary>
        /// Create a curation resource in the API hub.
        /// Once a curation resource is created, plugin instances can start using it.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the curation resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="curation">
        /// Required. The curation resource to create.
        /// </param>
        /// <param name="curationId">
        /// Optional. The ID to use for the curation resource, which will become the
        /// final component of the curations's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified ID is already used by another curation resource in the API
        /// hub.
        /// * If not provided, a system generated ID will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> CreateCurationAsync(string parent, Curation curation, string curationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCurationAsync(new CreateCurationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CurationId = curationId ?? "",
                Curation = gax::GaxPreconditions.CheckNotNull(curation, nameof(curation)),
            }, callSettings);

        /// <summary>
        /// Create a curation resource in the API hub.
        /// Once a curation resource is created, plugin instances can start using it.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the curation resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="curation">
        /// Required. The curation resource to create.
        /// </param>
        /// <param name="curationId">
        /// Optional. The ID to use for the curation resource, which will become the
        /// final component of the curations's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified ID is already used by another curation resource in the API
        /// hub.
        /// * If not provided, a system generated ID will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> CreateCurationAsync(string parent, Curation curation, string curationId, st::CancellationToken cancellationToken) =>
            CreateCurationAsync(parent, curation, curationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a curation resource in the API hub.
        /// Once a curation resource is created, plugin instances can start using it.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the curation resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="curation">
        /// Required. The curation resource to create.
        /// </param>
        /// <param name="curationId">
        /// Optional. The ID to use for the curation resource, which will become the
        /// final component of the curations's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified ID is already used by another curation resource in the API
        /// hub.
        /// * If not provided, a system generated ID will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Curation CreateCuration(gagr::LocationName parent, Curation curation, string curationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCuration(new CreateCurationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CurationId = curationId ?? "",
                Curation = gax::GaxPreconditions.CheckNotNull(curation, nameof(curation)),
            }, callSettings);

        /// <summary>
        /// Create a curation resource in the API hub.
        /// Once a curation resource is created, plugin instances can start using it.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the curation resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="curation">
        /// Required. The curation resource to create.
        /// </param>
        /// <param name="curationId">
        /// Optional. The ID to use for the curation resource, which will become the
        /// final component of the curations's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified ID is already used by another curation resource in the API
        /// hub.
        /// * If not provided, a system generated ID will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> CreateCurationAsync(gagr::LocationName parent, Curation curation, string curationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCurationAsync(new CreateCurationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CurationId = curationId ?? "",
                Curation = gax::GaxPreconditions.CheckNotNull(curation, nameof(curation)),
            }, callSettings);

        /// <summary>
        /// Create a curation resource in the API hub.
        /// Once a curation resource is created, plugin instances can start using it.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource for the curation resource.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="curation">
        /// Required. The curation resource to create.
        /// </param>
        /// <param name="curationId">
        /// Optional. The ID to use for the curation resource, which will become the
        /// final component of the curations's resource name. This field is optional.
        /// 
        /// * If provided, the same will be used. The service will throw an error if
        /// the specified ID is already used by another curation resource in the API
        /// hub.
        /// * If not provided, a system generated ID will be used.
        /// 
        /// This value should be 4-500 characters, and valid characters
        /// are /[a-z][A-Z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> CreateCurationAsync(gagr::LocationName parent, Curation curation, string curationId, st::CancellationToken cancellationToken) =>
            CreateCurationAsync(parent, curation, curationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get curation resource details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Curation GetCuration(GetCurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get curation resource details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> GetCurationAsync(GetCurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get curation resource details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> GetCurationAsync(GetCurationRequest request, st::CancellationToken cancellationToken) =>
            GetCurationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get curation resource details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the curation resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Curation GetCuration(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCuration(new GetCurationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get curation resource details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the curation resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> GetCurationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCurationAsync(new GetCurationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get curation resource details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the curation resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> GetCurationAsync(string name, st::CancellationToken cancellationToken) =>
            GetCurationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get curation resource details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the curation resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Curation GetCuration(CurationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCuration(new GetCurationRequest
            {
                CurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get curation resource details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the curation resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> GetCurationAsync(CurationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCurationAsync(new GetCurationRequest
            {
                CurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get curation resource details.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the curation resource to retrieve.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> GetCurationAsync(CurationName name, st::CancellationToken cancellationToken) =>
            GetCurationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List curation resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Curation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCurationsResponse, Curation> ListCurations(ListCurationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List curation resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Curation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCurationsResponse, Curation> ListCurationsAsync(ListCurationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List curation resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of curation resources.
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
        /// <returns>A pageable sequence of <see cref="Curation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCurationsResponse, Curation> ListCurations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCurationsRequest request = new ListCurationsRequest
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
            return ListCurations(request, callSettings);
        }

        /// <summary>
        /// List curation resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of curation resources.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Curation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCurationsResponse, Curation> ListCurationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCurationsRequest request = new ListCurationsRequest
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
            return ListCurationsAsync(request, callSettings);
        }

        /// <summary>
        /// List curation resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of curation resources.
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
        /// <returns>A pageable sequence of <see cref="Curation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCurationsResponse, Curation> ListCurations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCurationsRequest request = new ListCurationsRequest
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
            return ListCurations(request, callSettings);
        }

        /// <summary>
        /// List curation resources in the API hub.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of curation resources.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Curation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCurationsResponse, Curation> ListCurationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCurationsRequest request = new ListCurationsRequest
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
            return ListCurationsAsync(request, callSettings);
        }

        /// <summary>
        /// Update a curation resource in the API hub. The following fields in the
        /// [curation][google.cloud.apihub.v1.Curation] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Curation.display_name]
        /// * [description][google.cloud.apihub.v1.Curation.description]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Curation UpdateCuration(UpdateCurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a curation resource in the API hub. The following fields in the
        /// [curation][google.cloud.apihub.v1.Curation] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Curation.display_name]
        /// * [description][google.cloud.apihub.v1.Curation.description]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> UpdateCurationAsync(UpdateCurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a curation resource in the API hub. The following fields in the
        /// [curation][google.cloud.apihub.v1.Curation] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Curation.display_name]
        /// * [description][google.cloud.apihub.v1.Curation.description]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> UpdateCurationAsync(UpdateCurationRequest request, st::CancellationToken cancellationToken) =>
            UpdateCurationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a curation resource in the API hub. The following fields in the
        /// [curation][google.cloud.apihub.v1.Curation] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Curation.display_name]
        /// * [description][google.cloud.apihub.v1.Curation.description]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="curation">
        /// Required. The curation resource to update.
        /// 
        /// The curation resource's `name` field is used to identify the curation
        /// resource to update.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Curation UpdateCuration(Curation curation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCuration(new UpdateCurationRequest
            {
                Curation = gax::GaxPreconditions.CheckNotNull(curation, nameof(curation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a curation resource in the API hub. The following fields in the
        /// [curation][google.cloud.apihub.v1.Curation] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Curation.display_name]
        /// * [description][google.cloud.apihub.v1.Curation.description]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="curation">
        /// Required. The curation resource to update.
        /// 
        /// The curation resource's `name` field is used to identify the curation
        /// resource to update.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> UpdateCurationAsync(Curation curation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCurationAsync(new UpdateCurationRequest
            {
                Curation = gax::GaxPreconditions.CheckNotNull(curation, nameof(curation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a curation resource in the API hub. The following fields in the
        /// [curation][google.cloud.apihub.v1.Curation] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Curation.display_name]
        /// * [description][google.cloud.apihub.v1.Curation.description]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="curation">
        /// Required. The curation resource to update.
        /// 
        /// The curation resource's `name` field is used to identify the curation
        /// resource to update.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Curation> UpdateCurationAsync(Curation curation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCurationAsync(curation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a curation resource in the API hub. A curation can only be deleted
        /// if it's not being used by any plugin instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCuration(DeleteCurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a curation resource in the API hub. A curation can only be deleted
        /// if it's not being used by any plugin instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCurationAsync(DeleteCurationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a curation resource in the API hub. A curation can only be deleted
        /// if it's not being used by any plugin instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCurationAsync(DeleteCurationRequest request, st::CancellationToken cancellationToken) =>
            DeleteCurationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a curation resource in the API hub. A curation can only be deleted
        /// if it's not being used by any plugin instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the curation resource to delete.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCuration(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCuration(new DeleteCurationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a curation resource in the API hub. A curation can only be deleted
        /// if it's not being used by any plugin instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the curation resource to delete.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCurationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCurationAsync(new DeleteCurationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a curation resource in the API hub. A curation can only be deleted
        /// if it's not being used by any plugin instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the curation resource to delete.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCurationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCurationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a curation resource in the API hub. A curation can only be deleted
        /// if it's not being used by any plugin instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the curation resource to delete.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCuration(CurationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCuration(new DeleteCurationRequest
            {
                CurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a curation resource in the API hub. A curation can only be deleted
        /// if it's not being used by any plugin instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the curation resource to delete.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCurationAsync(CurationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCurationAsync(new DeleteCurationRequest
            {
                CurationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a curation resource in the API hub. A curation can only be deleted
        /// if it's not being used by any plugin instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the curation resource to delete.
        /// Format: `projects/{project}/locations/{location}/curations/{curation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCurationAsync(CurationName name, st::CancellationToken cancellationToken) =>
            DeleteCurationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ApiHubCurate client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service is used for managing curations for processing API data consumed
    /// from collect layer.
    /// </remarks>
    public sealed partial class ApiHubCurateClientImpl : ApiHubCurateClient
    {
        private readonly gaxgrpc::ApiCall<CreateCurationRequest, Curation> _callCreateCuration;

        private readonly gaxgrpc::ApiCall<GetCurationRequest, Curation> _callGetCuration;

        private readonly gaxgrpc::ApiCall<ListCurationsRequest, ListCurationsResponse> _callListCurations;

        private readonly gaxgrpc::ApiCall<UpdateCurationRequest, Curation> _callUpdateCuration;

        private readonly gaxgrpc::ApiCall<DeleteCurationRequest, wkt::Empty> _callDeleteCuration;

        /// <summary>
        /// Constructs a client wrapper for the ApiHubCurate service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ApiHubCurateSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ApiHubCurateClientImpl(ApiHubCurate.ApiHubCurateClient grpcClient, ApiHubCurateSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ApiHubCurateSettings effectiveSettings = settings ?? ApiHubCurateSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateCuration = clientHelper.BuildApiCall<CreateCurationRequest, Curation>("CreateCuration", grpcClient.CreateCurationAsync, grpcClient.CreateCuration, effectiveSettings.CreateCurationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCuration);
            Modify_CreateCurationApiCall(ref _callCreateCuration);
            _callGetCuration = clientHelper.BuildApiCall<GetCurationRequest, Curation>("GetCuration", grpcClient.GetCurationAsync, grpcClient.GetCuration, effectiveSettings.GetCurationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCuration);
            Modify_GetCurationApiCall(ref _callGetCuration);
            _callListCurations = clientHelper.BuildApiCall<ListCurationsRequest, ListCurationsResponse>("ListCurations", grpcClient.ListCurationsAsync, grpcClient.ListCurations, effectiveSettings.ListCurationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCurations);
            Modify_ListCurationsApiCall(ref _callListCurations);
            _callUpdateCuration = clientHelper.BuildApiCall<UpdateCurationRequest, Curation>("UpdateCuration", grpcClient.UpdateCurationAsync, grpcClient.UpdateCuration, effectiveSettings.UpdateCurationSettings).WithGoogleRequestParam("curation.name", request => request.Curation?.Name);
            Modify_ApiCall(ref _callUpdateCuration);
            Modify_UpdateCurationApiCall(ref _callUpdateCuration);
            _callDeleteCuration = clientHelper.BuildApiCall<DeleteCurationRequest, wkt::Empty>("DeleteCuration", grpcClient.DeleteCurationAsync, grpcClient.DeleteCuration, effectiveSettings.DeleteCurationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCuration);
            Modify_DeleteCurationApiCall(ref _callDeleteCuration);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateCurationApiCall(ref gaxgrpc::ApiCall<CreateCurationRequest, Curation> call);

        partial void Modify_GetCurationApiCall(ref gaxgrpc::ApiCall<GetCurationRequest, Curation> call);

        partial void Modify_ListCurationsApiCall(ref gaxgrpc::ApiCall<ListCurationsRequest, ListCurationsResponse> call);

        partial void Modify_UpdateCurationApiCall(ref gaxgrpc::ApiCall<UpdateCurationRequest, Curation> call);

        partial void Modify_DeleteCurationApiCall(ref gaxgrpc::ApiCall<DeleteCurationRequest, wkt::Empty> call);

        partial void OnConstruction(ApiHubCurate.ApiHubCurateClient grpcClient, ApiHubCurateSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ApiHubCurate client</summary>
        public override ApiHubCurate.ApiHubCurateClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateCurationRequest(ref CreateCurationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCurationRequest(ref GetCurationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCurationsRequest(ref ListCurationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCurationRequest(ref UpdateCurationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCurationRequest(ref DeleteCurationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a curation resource in the API hub.
        /// Once a curation resource is created, plugin instances can start using it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Curation CreateCuration(CreateCurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCurationRequest(ref request, ref callSettings);
            return _callCreateCuration.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a curation resource in the API hub.
        /// Once a curation resource is created, plugin instances can start using it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Curation> CreateCurationAsync(CreateCurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCurationRequest(ref request, ref callSettings);
            return _callCreateCuration.Async(request, callSettings);
        }

        /// <summary>
        /// Get curation resource details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Curation GetCuration(GetCurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCurationRequest(ref request, ref callSettings);
            return _callGetCuration.Sync(request, callSettings);
        }

        /// <summary>
        /// Get curation resource details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Curation> GetCurationAsync(GetCurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCurationRequest(ref request, ref callSettings);
            return _callGetCuration.Async(request, callSettings);
        }

        /// <summary>
        /// List curation resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Curation"/> resources.</returns>
        public override gax::PagedEnumerable<ListCurationsResponse, Curation> ListCurations(ListCurationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCurationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCurationsRequest, ListCurationsResponse, Curation>(_callListCurations, request, callSettings);
        }

        /// <summary>
        /// List curation resources in the API hub.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Curation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCurationsResponse, Curation> ListCurationsAsync(ListCurationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCurationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCurationsRequest, ListCurationsResponse, Curation>(_callListCurations, request, callSettings);
        }

        /// <summary>
        /// Update a curation resource in the API hub. The following fields in the
        /// [curation][google.cloud.apihub.v1.Curation] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Curation.display_name]
        /// * [description][google.cloud.apihub.v1.Curation.description]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Curation UpdateCuration(UpdateCurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCurationRequest(ref request, ref callSettings);
            return _callUpdateCuration.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a curation resource in the API hub. The following fields in the
        /// [curation][google.cloud.apihub.v1.Curation] can be updated:
        /// 
        /// * [display_name][google.cloud.apihub.v1.Curation.display_name]
        /// * [description][google.cloud.apihub.v1.Curation.description]
        /// 
        /// The
        /// [update_mask][google.cloud.apihub.v1.UpdateApiRequest.update_mask]
        /// should be used to specify the fields being updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Curation> UpdateCurationAsync(UpdateCurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCurationRequest(ref request, ref callSettings);
            return _callUpdateCuration.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a curation resource in the API hub. A curation can only be deleted
        /// if it's not being used by any plugin instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCuration(DeleteCurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCurationRequest(ref request, ref callSettings);
            _callDeleteCuration.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a curation resource in the API hub. A curation can only be deleted
        /// if it's not being used by any plugin instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCurationAsync(DeleteCurationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCurationRequest(ref request, ref callSettings);
            return _callDeleteCuration.Async(request, callSettings);
        }
    }

    public partial class ListCurationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCurationsResponse : gaxgrpc::IPageResponse<Curation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Curation> GetEnumerator() => Curations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ApiHubCurate
    {
        public partial class ApiHubCurateClient
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
