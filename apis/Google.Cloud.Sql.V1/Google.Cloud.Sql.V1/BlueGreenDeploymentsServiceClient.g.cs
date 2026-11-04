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

namespace Google.Cloud.Sql.V1
{
    /// <summary>Settings for <see cref="BlueGreenDeploymentsServiceClient"/> instances.</summary>
    public sealed partial class BlueGreenDeploymentsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BlueGreenDeploymentsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BlueGreenDeploymentsServiceSettings"/>.</returns>
        public static BlueGreenDeploymentsServiceSettings GetDefault() => new BlueGreenDeploymentsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="BlueGreenDeploymentsServiceSettings"/> object with default settings.
        /// </summary>
        public BlueGreenDeploymentsServiceSettings()
        {
        }

        private BlueGreenDeploymentsServiceSettings(BlueGreenDeploymentsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateBlueGreenDeploymentSettings = existing.CreateBlueGreenDeploymentSettings;
            GetBlueGreenDeploymentSettings = existing.GetBlueGreenDeploymentSettings;
            SwitchoverBlueGreenDeploymentSettings = existing.SwitchoverBlueGreenDeploymentSettings;
            ListBlueGreenDeploymentsSettings = existing.ListBlueGreenDeploymentsSettings;
            DeleteBlueGreenDeploymentSettings = existing.DeleteBlueGreenDeploymentSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BlueGreenDeploymentsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BlueGreenDeploymentsServiceClient.CreateBlueGreenDeployment</c> and
        /// <c>BlueGreenDeploymentsServiceClient.CreateBlueGreenDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBlueGreenDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BlueGreenDeploymentsServiceClient.GetBlueGreenDeployment</c> and
        /// <c>BlueGreenDeploymentsServiceClient.GetBlueGreenDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBlueGreenDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BlueGreenDeploymentsServiceClient.SwitchoverBlueGreenDeployment</c> and
        /// <c>BlueGreenDeploymentsServiceClient.SwitchoverBlueGreenDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SwitchoverBlueGreenDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BlueGreenDeploymentsServiceClient.ListBlueGreenDeployments</c> and
        /// <c>BlueGreenDeploymentsServiceClient.ListBlueGreenDeploymentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBlueGreenDeploymentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BlueGreenDeploymentsServiceClient.DeleteBlueGreenDeployment</c> and
        /// <c>BlueGreenDeploymentsServiceClient.DeleteBlueGreenDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBlueGreenDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BlueGreenDeploymentsServiceSettings"/> object.</returns>
        public BlueGreenDeploymentsServiceSettings Clone() => new BlueGreenDeploymentsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BlueGreenDeploymentsServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class BlueGreenDeploymentsServiceClientBuilder : gaxgrpc::ClientBuilderBase<BlueGreenDeploymentsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BlueGreenDeploymentsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BlueGreenDeploymentsServiceClientBuilder() : base(BlueGreenDeploymentsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BlueGreenDeploymentsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BlueGreenDeploymentsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BlueGreenDeploymentsServiceClient Build()
        {
            BlueGreenDeploymentsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BlueGreenDeploymentsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BlueGreenDeploymentsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BlueGreenDeploymentsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BlueGreenDeploymentsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BlueGreenDeploymentsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BlueGreenDeploymentsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BlueGreenDeploymentsServiceClient.ChannelPool;
    }

    /// <summary>BlueGreenDeploymentsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing blue-green deployments.
    /// </remarks>
    public abstract partial class BlueGreenDeploymentsServiceClient
    {
        /// <summary>
        /// The default endpoint for the BlueGreenDeploymentsService service, which is a host of
        /// "sqladmin.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "sqladmin.googleapis.com:443";

        /// <summary>The default BlueGreenDeploymentsService scopes.</summary>
        /// <remarks>
        /// The default BlueGreenDeploymentsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/sqlservice.admin</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/sqlservice.admin",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BlueGreenDeploymentsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BlueGreenDeploymentsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="BlueGreenDeploymentsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BlueGreenDeploymentsServiceClient"/>.</returns>
        public static stt::Task<BlueGreenDeploymentsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BlueGreenDeploymentsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BlueGreenDeploymentsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="BlueGreenDeploymentsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BlueGreenDeploymentsServiceClient"/>.</returns>
        public static BlueGreenDeploymentsServiceClient Create() => new BlueGreenDeploymentsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BlueGreenDeploymentsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BlueGreenDeploymentsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BlueGreenDeploymentsServiceClient"/>.</returns>
        internal static BlueGreenDeploymentsServiceClient Create(grpccore::CallInvoker callInvoker, BlueGreenDeploymentsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BlueGreenDeploymentsService.BlueGreenDeploymentsServiceClient grpcClient = new BlueGreenDeploymentsService.BlueGreenDeploymentsServiceClient(callInvoker);
            return new BlueGreenDeploymentsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BlueGreenDeploymentsService client</summary>
        public virtual BlueGreenDeploymentsService.BlueGreenDeploymentsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a blue-green deployment under a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation CreateBlueGreenDeployment(CreateBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a blue-green deployment under a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateBlueGreenDeploymentAsync(CreateBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a blue-green deployment under a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateBlueGreenDeploymentAsync(CreateBlueGreenDeploymentRequest request, st::CancellationToken cancellationToken) =>
            CreateBlueGreenDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a blue-green deployment under a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this blue-green deployment will be
        /// created. Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="blueGreenDeployment">
        /// Required. The `BlueGreenDeployment` resource to create.
        /// </param>
        /// <param name="blueGreenDeploymentId">
        /// Required. The ID to use for the blue-green deployment, which will become
        /// the final component of the deployment's resource name. The ID must be
        /// unique within the given project and location and between 2-63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation CreateBlueGreenDeployment(string parent, BlueGreenDeployment blueGreenDeployment, string blueGreenDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBlueGreenDeployment(new CreateBlueGreenDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BlueGreenDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(blueGreenDeploymentId, nameof(blueGreenDeploymentId)),
                BlueGreenDeployment = gax::GaxPreconditions.CheckNotNull(blueGreenDeployment, nameof(blueGreenDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a blue-green deployment under a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this blue-green deployment will be
        /// created. Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="blueGreenDeployment">
        /// Required. The `BlueGreenDeployment` resource to create.
        /// </param>
        /// <param name="blueGreenDeploymentId">
        /// Required. The ID to use for the blue-green deployment, which will become
        /// the final component of the deployment's resource name. The ID must be
        /// unique within the given project and location and between 2-63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateBlueGreenDeploymentAsync(string parent, BlueGreenDeployment blueGreenDeployment, string blueGreenDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBlueGreenDeploymentAsync(new CreateBlueGreenDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BlueGreenDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(blueGreenDeploymentId, nameof(blueGreenDeploymentId)),
                BlueGreenDeployment = gax::GaxPreconditions.CheckNotNull(blueGreenDeployment, nameof(blueGreenDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a blue-green deployment under a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this blue-green deployment will be
        /// created. Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="blueGreenDeployment">
        /// Required. The `BlueGreenDeployment` resource to create.
        /// </param>
        /// <param name="blueGreenDeploymentId">
        /// Required. The ID to use for the blue-green deployment, which will become
        /// the final component of the deployment's resource name. The ID must be
        /// unique within the given project and location and between 2-63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateBlueGreenDeploymentAsync(string parent, BlueGreenDeployment blueGreenDeployment, string blueGreenDeploymentId, st::CancellationToken cancellationToken) =>
            CreateBlueGreenDeploymentAsync(parent, blueGreenDeployment, blueGreenDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a blue-green deployment under a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this blue-green deployment will be
        /// created. Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="blueGreenDeployment">
        /// Required. The `BlueGreenDeployment` resource to create.
        /// </param>
        /// <param name="blueGreenDeploymentId">
        /// Required. The ID to use for the blue-green deployment, which will become
        /// the final component of the deployment's resource name. The ID must be
        /// unique within the given project and location and between 2-63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation CreateBlueGreenDeployment(gagr::LocationName parent, BlueGreenDeployment blueGreenDeployment, string blueGreenDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBlueGreenDeployment(new CreateBlueGreenDeploymentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BlueGreenDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(blueGreenDeploymentId, nameof(blueGreenDeploymentId)),
                BlueGreenDeployment = gax::GaxPreconditions.CheckNotNull(blueGreenDeployment, nameof(blueGreenDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a blue-green deployment under a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this blue-green deployment will be
        /// created. Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="blueGreenDeployment">
        /// Required. The `BlueGreenDeployment` resource to create.
        /// </param>
        /// <param name="blueGreenDeploymentId">
        /// Required. The ID to use for the blue-green deployment, which will become
        /// the final component of the deployment's resource name. The ID must be
        /// unique within the given project and location and between 2-63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateBlueGreenDeploymentAsync(gagr::LocationName parent, BlueGreenDeployment blueGreenDeployment, string blueGreenDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBlueGreenDeploymentAsync(new CreateBlueGreenDeploymentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BlueGreenDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(blueGreenDeploymentId, nameof(blueGreenDeploymentId)),
                BlueGreenDeployment = gax::GaxPreconditions.CheckNotNull(blueGreenDeployment, nameof(blueGreenDeployment)),
            }, callSettings);

        /// <summary>
        /// Creates a blue-green deployment under a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this blue-green deployment will be
        /// created. Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="blueGreenDeployment">
        /// Required. The `BlueGreenDeployment` resource to create.
        /// </param>
        /// <param name="blueGreenDeploymentId">
        /// Required. The ID to use for the blue-green deployment, which will become
        /// the final component of the deployment's resource name. The ID must be
        /// unique within the given project and location and between 2-63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> CreateBlueGreenDeploymentAsync(gagr::LocationName parent, BlueGreenDeployment blueGreenDeployment, string blueGreenDeploymentId, st::CancellationToken cancellationToken) =>
            CreateBlueGreenDeploymentAsync(parent, blueGreenDeployment, blueGreenDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a blue-green deployment resource under a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BlueGreenDeployment GetBlueGreenDeployment(GetBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a blue-green deployment resource under a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BlueGreenDeployment> GetBlueGreenDeploymentAsync(GetBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a blue-green deployment resource under a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BlueGreenDeployment> GetBlueGreenDeploymentAsync(GetBlueGreenDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetBlueGreenDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a blue-green deployment resource under a given project and
        /// location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BlueGreenDeployment GetBlueGreenDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBlueGreenDeployment(new GetBlueGreenDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a blue-green deployment resource under a given project and
        /// location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BlueGreenDeployment> GetBlueGreenDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBlueGreenDeploymentAsync(new GetBlueGreenDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a blue-green deployment resource under a given project and
        /// location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BlueGreenDeployment> GetBlueGreenDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetBlueGreenDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a blue-green deployment resource under a given project and
        /// location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BlueGreenDeployment GetBlueGreenDeployment(BlueGreenDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBlueGreenDeployment(new GetBlueGreenDeploymentRequest
            {
                BlueGreenDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a blue-green deployment resource under a given project and
        /// location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BlueGreenDeployment> GetBlueGreenDeploymentAsync(BlueGreenDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBlueGreenDeploymentAsync(new GetBlueGreenDeploymentRequest
            {
                BlueGreenDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a blue-green deployment resource under a given project and
        /// location.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BlueGreenDeployment> GetBlueGreenDeploymentAsync(BlueGreenDeploymentName name, st::CancellationToken cancellationToken) =>
            GetBlueGreenDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Switches over to green instance for a blue-green deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SwitchoverBlueGreenDeployment(SwitchoverBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Switches over to green instance for a blue-green deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SwitchoverBlueGreenDeploymentAsync(SwitchoverBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Switches over to green instance for a blue-green deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SwitchoverBlueGreenDeploymentAsync(SwitchoverBlueGreenDeploymentRequest request, st::CancellationToken cancellationToken) =>
            SwitchoverBlueGreenDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Switches over to green instance for a blue-green deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to switch over.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SwitchoverBlueGreenDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            SwitchoverBlueGreenDeployment(new SwitchoverBlueGreenDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Switches over to green instance for a blue-green deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to switch over.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SwitchoverBlueGreenDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            SwitchoverBlueGreenDeploymentAsync(new SwitchoverBlueGreenDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Switches over to green instance for a blue-green deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to switch over.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SwitchoverBlueGreenDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            SwitchoverBlueGreenDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Switches over to green instance for a blue-green deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to switch over.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SwitchoverBlueGreenDeployment(BlueGreenDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            SwitchoverBlueGreenDeployment(new SwitchoverBlueGreenDeploymentRequest
            {
                BlueGreenDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Switches over to green instance for a blue-green deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to switch over.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SwitchoverBlueGreenDeploymentAsync(BlueGreenDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            SwitchoverBlueGreenDeploymentAsync(new SwitchoverBlueGreenDeploymentRequest
            {
                BlueGreenDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Switches over to green instance for a blue-green deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to switch over.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SwitchoverBlueGreenDeploymentAsync(BlueGreenDeploymentName name, st::CancellationToken cancellationToken) =>
            SwitchoverBlueGreenDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists blue-green deployments under a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BlueGreenDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBlueGreenDeploymentsResponse, BlueGreenDeployment> ListBlueGreenDeployments(ListBlueGreenDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists blue-green deployments under a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BlueGreenDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBlueGreenDeploymentsResponse, BlueGreenDeployment> ListBlueGreenDeploymentsAsync(ListBlueGreenDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists blue-green deployments under a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose blue-green deployments are to be
        /// listed. Format: projects/{project}/locations/{location}
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
        /// <returns>A pageable sequence of <see cref="BlueGreenDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBlueGreenDeploymentsResponse, BlueGreenDeployment> ListBlueGreenDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBlueGreenDeploymentsRequest request = new ListBlueGreenDeploymentsRequest
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
            return ListBlueGreenDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists blue-green deployments under a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose blue-green deployments are to be
        /// listed. Format: projects/{project}/locations/{location}
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
        /// <returns>A pageable asynchronous sequence of <see cref="BlueGreenDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBlueGreenDeploymentsResponse, BlueGreenDeployment> ListBlueGreenDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBlueGreenDeploymentsRequest request = new ListBlueGreenDeploymentsRequest
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
            return ListBlueGreenDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists blue-green deployments under a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose blue-green deployments are to be
        /// listed. Format: projects/{project}/locations/{location}
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
        /// <returns>A pageable sequence of <see cref="BlueGreenDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBlueGreenDeploymentsResponse, BlueGreenDeployment> ListBlueGreenDeployments(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBlueGreenDeploymentsRequest request = new ListBlueGreenDeploymentsRequest
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
            return ListBlueGreenDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists blue-green deployments under a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose blue-green deployments are to be
        /// listed. Format: projects/{project}/locations/{location}
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
        /// <returns>A pageable asynchronous sequence of <see cref="BlueGreenDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBlueGreenDeploymentsResponse, BlueGreenDeployment> ListBlueGreenDeploymentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBlueGreenDeploymentsRequest request = new ListBlueGreenDeploymentsRequest
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
            return ListBlueGreenDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a blue-green deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DeleteBlueGreenDeployment(DeleteBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a blue-green deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteBlueGreenDeploymentAsync(DeleteBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a blue-green deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteBlueGreenDeploymentAsync(DeleteBlueGreenDeploymentRequest request, st::CancellationToken cancellationToken) =>
            DeleteBlueGreenDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a blue-green deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to delete.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DeleteBlueGreenDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBlueGreenDeployment(new DeleteBlueGreenDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a blue-green deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to delete.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteBlueGreenDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBlueGreenDeploymentAsync(new DeleteBlueGreenDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a blue-green deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to delete.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteBlueGreenDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBlueGreenDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a blue-green deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to delete.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation DeleteBlueGreenDeployment(BlueGreenDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBlueGreenDeployment(new DeleteBlueGreenDeploymentRequest
            {
                BlueGreenDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a blue-green deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to delete.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteBlueGreenDeploymentAsync(BlueGreenDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBlueGreenDeploymentAsync(new DeleteBlueGreenDeploymentRequest
            {
                BlueGreenDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a blue-green deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the blue-green deployment to delete.
        /// Format:
        /// projects/{project}/locations/{location}/blueGreenDeployments/{blue_green_deployment}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteBlueGreenDeploymentAsync(BlueGreenDeploymentName name, st::CancellationToken cancellationToken) =>
            DeleteBlueGreenDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BlueGreenDeploymentsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing blue-green deployments.
    /// </remarks>
    public sealed partial class BlueGreenDeploymentsServiceClientImpl : BlueGreenDeploymentsServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateBlueGreenDeploymentRequest, Operation> _callCreateBlueGreenDeployment;

        private readonly gaxgrpc::ApiCall<GetBlueGreenDeploymentRequest, BlueGreenDeployment> _callGetBlueGreenDeployment;

        private readonly gaxgrpc::ApiCall<SwitchoverBlueGreenDeploymentRequest, Operation> _callSwitchoverBlueGreenDeployment;

        private readonly gaxgrpc::ApiCall<ListBlueGreenDeploymentsRequest, ListBlueGreenDeploymentsResponse> _callListBlueGreenDeployments;

        private readonly gaxgrpc::ApiCall<DeleteBlueGreenDeploymentRequest, Operation> _callDeleteBlueGreenDeployment;

        /// <summary>
        /// Constructs a client wrapper for the BlueGreenDeploymentsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="BlueGreenDeploymentsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BlueGreenDeploymentsServiceClientImpl(BlueGreenDeploymentsService.BlueGreenDeploymentsServiceClient grpcClient, BlueGreenDeploymentsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BlueGreenDeploymentsServiceSettings effectiveSettings = settings ?? BlueGreenDeploymentsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateBlueGreenDeployment = clientHelper.BuildApiCall<CreateBlueGreenDeploymentRequest, Operation>("CreateBlueGreenDeployment", grpcClient.CreateBlueGreenDeploymentAsync, grpcClient.CreateBlueGreenDeployment, effectiveSettings.CreateBlueGreenDeploymentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBlueGreenDeployment);
            Modify_CreateBlueGreenDeploymentApiCall(ref _callCreateBlueGreenDeployment);
            _callGetBlueGreenDeployment = clientHelper.BuildApiCall<GetBlueGreenDeploymentRequest, BlueGreenDeployment>("GetBlueGreenDeployment", grpcClient.GetBlueGreenDeploymentAsync, grpcClient.GetBlueGreenDeployment, effectiveSettings.GetBlueGreenDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBlueGreenDeployment);
            Modify_GetBlueGreenDeploymentApiCall(ref _callGetBlueGreenDeployment);
            _callSwitchoverBlueGreenDeployment = clientHelper.BuildApiCall<SwitchoverBlueGreenDeploymentRequest, Operation>("SwitchoverBlueGreenDeployment", grpcClient.SwitchoverBlueGreenDeploymentAsync, grpcClient.SwitchoverBlueGreenDeployment, effectiveSettings.SwitchoverBlueGreenDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSwitchoverBlueGreenDeployment);
            Modify_SwitchoverBlueGreenDeploymentApiCall(ref _callSwitchoverBlueGreenDeployment);
            _callListBlueGreenDeployments = clientHelper.BuildApiCall<ListBlueGreenDeploymentsRequest, ListBlueGreenDeploymentsResponse>("ListBlueGreenDeployments", grpcClient.ListBlueGreenDeploymentsAsync, grpcClient.ListBlueGreenDeployments, effectiveSettings.ListBlueGreenDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBlueGreenDeployments);
            Modify_ListBlueGreenDeploymentsApiCall(ref _callListBlueGreenDeployments);
            _callDeleteBlueGreenDeployment = clientHelper.BuildApiCall<DeleteBlueGreenDeploymentRequest, Operation>("DeleteBlueGreenDeployment", grpcClient.DeleteBlueGreenDeploymentAsync, grpcClient.DeleteBlueGreenDeployment, effectiveSettings.DeleteBlueGreenDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBlueGreenDeployment);
            Modify_DeleteBlueGreenDeploymentApiCall(ref _callDeleteBlueGreenDeployment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateBlueGreenDeploymentApiCall(ref gaxgrpc::ApiCall<CreateBlueGreenDeploymentRequest, Operation> call);

        partial void Modify_GetBlueGreenDeploymentApiCall(ref gaxgrpc::ApiCall<GetBlueGreenDeploymentRequest, BlueGreenDeployment> call);

        partial void Modify_SwitchoverBlueGreenDeploymentApiCall(ref gaxgrpc::ApiCall<SwitchoverBlueGreenDeploymentRequest, Operation> call);

        partial void Modify_ListBlueGreenDeploymentsApiCall(ref gaxgrpc::ApiCall<ListBlueGreenDeploymentsRequest, ListBlueGreenDeploymentsResponse> call);

        partial void Modify_DeleteBlueGreenDeploymentApiCall(ref gaxgrpc::ApiCall<DeleteBlueGreenDeploymentRequest, Operation> call);

        partial void OnConstruction(BlueGreenDeploymentsService.BlueGreenDeploymentsServiceClient grpcClient, BlueGreenDeploymentsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BlueGreenDeploymentsService client</summary>
        public override BlueGreenDeploymentsService.BlueGreenDeploymentsServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateBlueGreenDeploymentRequest(ref CreateBlueGreenDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBlueGreenDeploymentRequest(ref GetBlueGreenDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SwitchoverBlueGreenDeploymentRequest(ref SwitchoverBlueGreenDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBlueGreenDeploymentsRequest(ref ListBlueGreenDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBlueGreenDeploymentRequest(ref DeleteBlueGreenDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a blue-green deployment under a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation CreateBlueGreenDeployment(CreateBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBlueGreenDeploymentRequest(ref request, ref callSettings);
            return _callCreateBlueGreenDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a blue-green deployment under a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> CreateBlueGreenDeploymentAsync(CreateBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBlueGreenDeploymentRequest(ref request, ref callSettings);
            return _callCreateBlueGreenDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a blue-green deployment resource under a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BlueGreenDeployment GetBlueGreenDeployment(GetBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBlueGreenDeploymentRequest(ref request, ref callSettings);
            return _callGetBlueGreenDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a blue-green deployment resource under a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BlueGreenDeployment> GetBlueGreenDeploymentAsync(GetBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBlueGreenDeploymentRequest(ref request, ref callSettings);
            return _callGetBlueGreenDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Switches over to green instance for a blue-green deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SwitchoverBlueGreenDeployment(SwitchoverBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SwitchoverBlueGreenDeploymentRequest(ref request, ref callSettings);
            return _callSwitchoverBlueGreenDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Switches over to green instance for a blue-green deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SwitchoverBlueGreenDeploymentAsync(SwitchoverBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SwitchoverBlueGreenDeploymentRequest(ref request, ref callSettings);
            return _callSwitchoverBlueGreenDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists blue-green deployments under a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BlueGreenDeployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListBlueGreenDeploymentsResponse, BlueGreenDeployment> ListBlueGreenDeployments(ListBlueGreenDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBlueGreenDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBlueGreenDeploymentsRequest, ListBlueGreenDeploymentsResponse, BlueGreenDeployment>(_callListBlueGreenDeployments, request, callSettings);
        }

        /// <summary>
        /// Lists blue-green deployments under a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BlueGreenDeployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBlueGreenDeploymentsResponse, BlueGreenDeployment> ListBlueGreenDeploymentsAsync(ListBlueGreenDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBlueGreenDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBlueGreenDeploymentsRequest, ListBlueGreenDeploymentsResponse, BlueGreenDeployment>(_callListBlueGreenDeployments, request, callSettings);
        }

        /// <summary>
        /// Deletes a blue-green deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation DeleteBlueGreenDeployment(DeleteBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBlueGreenDeploymentRequest(ref request, ref callSettings);
            return _callDeleteBlueGreenDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a blue-green deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteBlueGreenDeploymentAsync(DeleteBlueGreenDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBlueGreenDeploymentRequest(ref request, ref callSettings);
            return _callDeleteBlueGreenDeployment.Async(request, callSettings);
        }
    }

    public partial class ListBlueGreenDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBlueGreenDeploymentsResponse : gaxgrpc::IPageResponse<BlueGreenDeployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BlueGreenDeployment> GetEnumerator() => BlueGreenDeployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BlueGreenDeploymentsService
    {
        public partial class BlueGreenDeploymentsServiceClient
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
