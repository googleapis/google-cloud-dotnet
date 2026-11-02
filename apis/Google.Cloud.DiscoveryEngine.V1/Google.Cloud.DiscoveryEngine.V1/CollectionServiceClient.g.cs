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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Settings for <see cref="CollectionServiceClient"/> instances.</summary>
    public sealed partial class CollectionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CollectionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CollectionServiceSettings"/>.</returns>
        public static CollectionServiceSettings GetDefault() => new CollectionServiceSettings();

        /// <summary>Constructs a new <see cref="CollectionServiceSettings"/> object with default settings.</summary>
        public CollectionServiceSettings()
        {
        }

        private CollectionServiceSettings(CollectionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteCollectionSettings = existing.DeleteCollectionSettings;
            DeleteCollectionOperationsSettings = existing.DeleteCollectionOperationsSettings.Clone();
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CollectionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CollectionServiceClient.DeleteCollection</c> and <c>CollectionServiceClient.DeleteCollectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCollectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CollectionServiceClient.DeleteCollection</c> and
        /// <c>CollectionServiceClient.DeleteCollectionAsync</c>.
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
        public lro::OperationsSettings DeleteCollectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CollectionServiceClient.GetIamPolicy</c> and <c>CollectionServiceClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CollectionServiceClient.SetIamPolicy</c> and <c>CollectionServiceClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CollectionServiceSettings"/> object.</returns>
        public CollectionServiceSettings Clone() => new CollectionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CollectionServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CollectionServiceClientBuilder : gaxgrpc::ClientBuilderBase<CollectionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CollectionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CollectionServiceClientBuilder() : base(CollectionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CollectionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CollectionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CollectionServiceClient Build()
        {
            CollectionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CollectionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CollectionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CollectionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CollectionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CollectionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CollectionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CollectionServiceClient.ChannelPool;
    }

    /// <summary>CollectionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [Collection][google.cloud.discoveryengine.v1.Collection]s.
    /// </remarks>
    public abstract partial class CollectionServiceClient
    {
        /// <summary>
        /// The default endpoint for the CollectionService service, which is a host of "discoveryengine.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default CollectionService scopes.</summary>
        /// <remarks>
        /// The default CollectionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.readwrite</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.serving.readwrite</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/discoveryengine.readwrite",
            "https://www.googleapis.com/auth/discoveryengine.serving.readwrite",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CollectionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CollectionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CollectionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CollectionServiceClient"/>.</returns>
        public static stt::Task<CollectionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CollectionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CollectionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CollectionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CollectionServiceClient"/>.</returns>
        public static CollectionServiceClient Create() => new CollectionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CollectionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CollectionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CollectionServiceClient"/>.</returns>
        internal static CollectionServiceClient Create(grpccore::CallInvoker callInvoker, CollectionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CollectionService.CollectionServiceClient grpcClient = new CollectionService.CollectionServiceClient(callInvoker);
            return new CollectionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CollectionService client</summary>
        public virtual CollectionService.CollectionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteCollectionMetadata> DeleteCollection(DeleteCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> DeleteCollectionAsync(DeleteCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> DeleteCollectionAsync(DeleteCollectionRequest request, st::CancellationToken cancellationToken) =>
            DeleteCollectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCollection</c>.</summary>
        public virtual lro::OperationsClient DeleteCollectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCollection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteCollectionMetadata> PollOnceDeleteCollection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteCollectionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCollectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCollection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> PollOnceDeleteCollectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteCollectionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCollectionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the Collection, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteCollectionMetadata> DeleteCollection(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollection(new DeleteCollectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the Collection, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> DeleteCollectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollectionAsync(new DeleteCollectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the Collection, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> DeleteCollectionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCollectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the Collection, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteCollectionMetadata> DeleteCollection(CollectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollection(new DeleteCollectionRequest
            {
                CollectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the Collection, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> DeleteCollectionAsync(CollectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollectionAsync(new DeleteCollectionRequest
            {
                CollectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the Collection, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> DeleteCollectionAsync(CollectionName name, st::CancellationToken cancellationToken) =>
            DeleteCollectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist.
        /// 
        /// **Important:** When setting a policy directly on a Collection resource,
        /// the only recommended roles in the bindings are:
        /// `roles/discoveryengine.admin`
        /// `roles/discoveryengine.agentspaceAdmin`
        /// `roles/discoveryengine.viewer`
        /// `roles/discoveryengine.agentspaceViewer`
        /// `roles/discoveryengine.user`
        /// `roles/discoveryengine.agentspaceUser`
        /// Attempting to grant any other role will result in a warning in logging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist.
        /// 
        /// **Important:** When setting a policy directly on a Collection resource,
        /// the only recommended roles in the bindings are:
        /// `roles/discoveryengine.admin`
        /// `roles/discoveryengine.agentspaceAdmin`
        /// `roles/discoveryengine.viewer`
        /// `roles/discoveryengine.agentspaceViewer`
        /// `roles/discoveryengine.user`
        /// `roles/discoveryengine.agentspaceUser`
        /// Attempting to grant any other role will result in a warning in logging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist.
        /// 
        /// **Important:** When setting a policy directly on a Collection resource,
        /// the only recommended roles in the bindings are:
        /// `roles/discoveryengine.admin`
        /// `roles/discoveryengine.agentspaceAdmin`
        /// `roles/discoveryengine.viewer`
        /// `roles/discoveryengine.agentspaceViewer`
        /// `roles/discoveryengine.user`
        /// `roles/discoveryengine.agentspaceUser`
        /// Attempting to grant any other role will result in a warning in logging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist.
        /// 
        /// **Important:** When setting a policy directly on a Collection resource,
        /// the only recommended roles in the bindings are:
        /// `roles/discoveryengine.admin`
        /// `roles/discoveryengine.agentspaceAdmin`
        /// `roles/discoveryengine.viewer`
        /// `roles/discoveryengine.agentspaceViewer`
        /// `roles/discoveryengine.user`
        /// `roles/discoveryengine.agentspaceUser`
        /// Attempting to grant any other role will result in a warning in logging.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist.
        /// 
        /// **Important:** When setting a policy directly on a Collection resource,
        /// the only recommended roles in the bindings are:
        /// `roles/discoveryengine.admin`
        /// `roles/discoveryengine.agentspaceAdmin`
        /// `roles/discoveryengine.viewer`
        /// `roles/discoveryengine.agentspaceViewer`
        /// `roles/discoveryengine.user`
        /// `roles/discoveryengine.agentspaceUser`
        /// Attempting to grant any other role will result in a warning in logging.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist.
        /// 
        /// **Important:** When setting a policy directly on a Collection resource,
        /// the only recommended roles in the bindings are:
        /// `roles/discoveryengine.admin`
        /// `roles/discoveryengine.agentspaceAdmin`
        /// `roles/discoveryengine.viewer`
        /// `roles/discoveryengine.agentspaceViewer`
        /// `roles/discoveryengine.user`
        /// `roles/discoveryengine.agentspaceUser`
        /// Attempting to grant any other role will result in a warning in logging.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist.
        /// 
        /// **Important:** When setting a policy directly on a Collection resource,
        /// the only recommended roles in the bindings are:
        /// `roles/discoveryengine.admin`
        /// `roles/discoveryengine.agentspaceAdmin`
        /// `roles/discoveryengine.viewer`
        /// `roles/discoveryengine.agentspaceViewer`
        /// `roles/discoveryengine.user`
        /// `roles/discoveryengine.agentspaceUser`
        /// Attempting to grant any other role will result in a warning in logging.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist.
        /// 
        /// **Important:** When setting a policy directly on a Collection resource,
        /// the only recommended roles in the bindings are:
        /// `roles/discoveryengine.admin`
        /// `roles/discoveryengine.agentspaceAdmin`
        /// `roles/discoveryengine.viewer`
        /// `roles/discoveryengine.agentspaceViewer`
        /// `roles/discoveryengine.user`
        /// `roles/discoveryengine.agentspaceUser`
        /// Attempting to grant any other role will result in a warning in logging.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist.
        /// 
        /// **Important:** When setting a policy directly on a Collection resource,
        /// the only recommended roles in the bindings are:
        /// `roles/discoveryengine.admin`
        /// `roles/discoveryengine.agentspaceAdmin`
        /// `roles/discoveryengine.viewer`
        /// `roles/discoveryengine.agentspaceViewer`
        /// `roles/discoveryengine.user`
        /// `roles/discoveryengine.agentspaceUser`
        /// Attempting to grant any other role will result in a warning in logging.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CollectionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [Collection][google.cloud.discoveryengine.v1.Collection]s.
    /// </remarks>
    public sealed partial class CollectionServiceClientImpl : CollectionServiceClient
    {
        private readonly gaxgrpc::ApiCall<DeleteCollectionRequest, lro::Operation> _callDeleteCollection;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        /// <summary>
        /// Constructs a client wrapper for the CollectionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CollectionServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CollectionServiceClientImpl(CollectionService.CollectionServiceClient grpcClient, CollectionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CollectionServiceSettings effectiveSettings = settings ?? CollectionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteCollectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCollectionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callDeleteCollection = clientHelper.BuildApiCall<DeleteCollectionRequest, lro::Operation>("DeleteCollection", grpcClient.DeleteCollectionAsync, grpcClient.DeleteCollection, effectiveSettings.DeleteCollectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCollection);
            Modify_DeleteCollectionApiCall(ref _callDeleteCollection);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteCollectionApiCall(ref gaxgrpc::ApiCall<DeleteCollectionRequest, lro::Operation> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void OnConstruction(CollectionService.CollectionServiceClient grpcClient, CollectionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CollectionService client</summary>
        public override CollectionService.CollectionServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_DeleteCollectionRequest(ref DeleteCollectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>DeleteCollection</c>.</summary>
        public override lro::OperationsClient DeleteCollectionOperationsClient { get; }

        /// <summary>
        /// Deletes a [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteCollectionMetadata> DeleteCollection(DeleteCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCollectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteCollectionMetadata>(_callDeleteCollection.Sync(request, callSettings), DeleteCollectionOperationsClient);
        }

        /// <summary>
        /// Deletes a [Collection][google.cloud.discoveryengine.v1.Collection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteCollectionMetadata>> DeleteCollectionAsync(DeleteCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCollectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteCollectionMetadata>(await _callDeleteCollection.Async(request, callSettings).ConfigureAwait(false), DeleteCollectionOperationsClient);
        }

        /// <summary>
        /// Gets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist. An empty policy is
        /// returned if the resource exists but does not have a policy set on it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist.
        /// 
        /// **Important:** When setting a policy directly on a Collection resource,
        /// the only recommended roles in the bindings are:
        /// `roles/discoveryengine.admin`
        /// `roles/discoveryengine.agentspaceAdmin`
        /// `roles/discoveryengine.viewer`
        /// `roles/discoveryengine.agentspaceViewer`
        /// `roles/discoveryengine.user`
        /// `roles/discoveryengine.agentspaceUser`
        /// Attempting to grant any other role will result in a warning in logging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM access control policy for a
        /// [Collection][google.cloud.discoveryengine.v1.Collection]. A `NOT_FOUND`
        /// error is returned if the resource does not exist.
        /// 
        /// **Important:** When setting a policy directly on a Collection resource,
        /// the only recommended roles in the bindings are:
        /// `roles/discoveryengine.admin`
        /// `roles/discoveryengine.agentspaceAdmin`
        /// `roles/discoveryengine.viewer`
        /// `roles/discoveryengine.agentspaceViewer`
        /// `roles/discoveryengine.user`
        /// `roles/discoveryengine.agentspaceUser`
        /// Attempting to grant any other role will result in a warning in logging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }
    }

    public static partial class CollectionService
    {
        public partial class CollectionServiceClient
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

    public static partial class CollectionService
    {
        public partial class CollectionServiceClient
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
