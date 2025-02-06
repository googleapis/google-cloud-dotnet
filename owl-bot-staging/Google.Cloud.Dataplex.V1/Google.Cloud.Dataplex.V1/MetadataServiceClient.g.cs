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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Settings for <see cref="MetadataServiceClient"/> instances.</summary>
    public sealed partial class MetadataServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MetadataServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MetadataServiceSettings"/>.</returns>
        public static MetadataServiceSettings GetDefault() => new MetadataServiceSettings();

        /// <summary>Constructs a new <see cref="MetadataServiceSettings"/> object with default settings.</summary>
        public MetadataServiceSettings()
        {
        }

        private MetadataServiceSettings(MetadataServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateEntitySettings = existing.CreateEntitySettings;
            UpdateEntitySettings = existing.UpdateEntitySettings;
            DeleteEntitySettings = existing.DeleteEntitySettings;
            GetEntitySettings = existing.GetEntitySettings;
            ListEntitiesSettings = existing.ListEntitiesSettings;
            CreatePartitionSettings = existing.CreatePartitionSettings;
            DeletePartitionSettings = existing.DeletePartitionSettings;
            GetPartitionSettings = existing.GetPartitionSettings;
            ListPartitionsSettings = existing.ListPartitionsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(MetadataServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.CreateEntity</c> and <c>MetadataServiceClient.CreateEntityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEntitySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.UpdateEntity</c> and <c>MetadataServiceClient.UpdateEntityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEntitySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.DeleteEntity</c> and <c>MetadataServiceClient.DeleteEntityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEntitySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.GetEntity</c> and <c>MetadataServiceClient.GetEntityAsync</c>.
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
        public gaxgrpc::CallSettings GetEntitySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.ListEntities</c> and <c>MetadataServiceClient.ListEntitiesAsync</c>.
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
        public gaxgrpc::CallSettings ListEntitiesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.CreatePartition</c> and <c>MetadataServiceClient.CreatePartitionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePartitionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.DeletePartition</c> and <c>MetadataServiceClient.DeletePartitionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePartitionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.GetPartition</c> and <c>MetadataServiceClient.GetPartitionAsync</c>.
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
        public gaxgrpc::CallSettings GetPartitionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetadataServiceClient.ListPartitions</c> and <c>MetadataServiceClient.ListPartitionsAsync</c>.
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
        public gaxgrpc::CallSettings ListPartitionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MetadataServiceSettings"/> object.</returns>
        public MetadataServiceSettings Clone() => new MetadataServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MetadataServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class MetadataServiceClientBuilder : gaxgrpc::ClientBuilderBase<MetadataServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MetadataServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MetadataServiceClientBuilder() : base(MetadataServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MetadataServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MetadataServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MetadataServiceClient Build()
        {
            MetadataServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MetadataServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MetadataServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MetadataServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MetadataServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MetadataServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MetadataServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MetadataServiceClient.ChannelPool;
    }

    /// <summary>MetadataService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Metadata service manages metadata resources such as tables, filesets and
    /// partitions.
    /// </remarks>
    public abstract partial class MetadataServiceClient
    {
        /// <summary>
        /// The default endpoint for the MetadataService service, which is a host of "dataplex.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataplex.googleapis.com:443";

        /// <summary>The default MetadataService scopes.</summary>
        /// <remarks>
        /// The default MetadataService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MetadataService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MetadataServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MetadataServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MetadataServiceClient"/>.</returns>
        public static stt::Task<MetadataServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MetadataServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MetadataServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MetadataServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MetadataServiceClient"/>.</returns>
        public static MetadataServiceClient Create() => new MetadataServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MetadataServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MetadataServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MetadataServiceClient"/>.</returns>
        internal static MetadataServiceClient Create(grpccore::CallInvoker callInvoker, MetadataServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MetadataService.MetadataServiceClient grpcClient = new MetadataService.MetadataServiceClient(callInvoker);
            return new MetadataServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MetadataService client</summary>
        public virtual MetadataService.MetadataServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entity CreateEntity(CreateEntityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> CreateEntityAsync(CreateEntityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> CreateEntityAsync(CreateEntityRequest request, st::CancellationToken cancellationToken) =>
            CreateEntityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a metadata entity.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="entity">
        /// Required. Entity resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entity CreateEntity(string parent, Entity entity, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntity(new CreateEntityRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Entity = gax::GaxPreconditions.CheckNotNull(entity, nameof(entity)),
            }, callSettings);

        /// <summary>
        /// Create a metadata entity.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="entity">
        /// Required. Entity resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> CreateEntityAsync(string parent, Entity entity, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityAsync(new CreateEntityRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Entity = gax::GaxPreconditions.CheckNotNull(entity, nameof(entity)),
            }, callSettings);

        /// <summary>
        /// Create a metadata entity.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="entity">
        /// Required. Entity resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> CreateEntityAsync(string parent, Entity entity, st::CancellationToken cancellationToken) =>
            CreateEntityAsync(parent, entity, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a metadata entity.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="entity">
        /// Required. Entity resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entity CreateEntity(ZoneName parent, Entity entity, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntity(new CreateEntityRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Entity = gax::GaxPreconditions.CheckNotNull(entity, nameof(entity)),
            }, callSettings);

        /// <summary>
        /// Create a metadata entity.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="entity">
        /// Required. Entity resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> CreateEntityAsync(ZoneName parent, Entity entity, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityAsync(new CreateEntityRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Entity = gax::GaxPreconditions.CheckNotNull(entity, nameof(entity)),
            }, callSettings);

        /// <summary>
        /// Create a metadata entity.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
        /// </param>
        /// <param name="entity">
        /// Required. Entity resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> CreateEntityAsync(ZoneName parent, Entity entity, st::CancellationToken cancellationToken) =>
            CreateEntityAsync(parent, entity, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a metadata entity. Only supports full resource update.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entity UpdateEntity(UpdateEntityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a metadata entity. Only supports full resource update.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> UpdateEntityAsync(UpdateEntityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a metadata entity. Only supports full resource update.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> UpdateEntityAsync(UpdateEntityRequest request, st::CancellationToken cancellationToken) =>
            UpdateEntityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntity(DeleteEntityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityAsync(DeleteEntityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityAsync(DeleteEntityRequest request, st::CancellationToken cancellationToken) =>
            DeleteEntityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntity(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntity(new DeleteEntityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityAsync(new DeleteEntityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEntityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntity(EntityName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntity(new DeleteEntityRequest
            {
                EntityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityAsync(EntityName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityAsync(new DeleteEntityRequest
            {
                EntityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityAsync(EntityName name, st::CancellationToken cancellationToken) =>
            DeleteEntityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entity GetEntity(GetEntityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> GetEntityAsync(GetEntityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> GetEntityAsync(GetEntityRequest request, st::CancellationToken cancellationToken) =>
            GetEntityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entity GetEntity(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntity(new GetEntityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> GetEntityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityAsync(new GetEntityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> GetEntityAsync(string name, st::CancellationToken cancellationToken) =>
            GetEntityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entity GetEntity(EntityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntity(new GetEntityRequest
            {
                EntityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> GetEntityAsync(EntityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityAsync(new GetEntityRequest
            {
                EntityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}.`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entity> GetEntityAsync(EntityName name, st::CancellationToken cancellationToken) =>
            GetEntityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entity"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitiesResponse, Entity> ListEntities(ListEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entity"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitiesResponse, Entity> ListEntitiesAsync(ListEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        /// <returns>A pageable sequence of <see cref="Entity"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitiesResponse, Entity> ListEntities(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitiesRequest request = new ListEntitiesRequest
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
            return ListEntities(request, callSettings);
        }

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Entity"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitiesResponse, Entity> ListEntitiesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitiesRequest request = new ListEntitiesRequest
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
            return ListEntitiesAsync(request, callSettings);
        }

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        /// <returns>A pageable sequence of <see cref="Entity"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitiesResponse, Entity> ListEntities(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitiesRequest request = new ListEntitiesRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntities(request, callSettings);
        }

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Entity"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitiesResponse, Entity> ListEntitiesAsync(ZoneName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitiesRequest request = new ListEntitiesRequest
            {
                ParentAsZoneName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntitiesAsync(request, callSettings);
        }

        /// <summary>
        /// Create a metadata partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partition CreatePartition(CreatePartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a metadata partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> CreatePartitionAsync(CreatePartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a metadata partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> CreatePartitionAsync(CreatePartitionRequest request, st::CancellationToken cancellationToken) =>
            CreatePartitionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a metadata partition.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
        /// </param>
        /// <param name="partition">
        /// Required. Partition resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partition CreatePartition(string parent, Partition partition, gaxgrpc::CallSettings callSettings = null) =>
            CreatePartition(new CreatePartitionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Partition = gax::GaxPreconditions.CheckNotNull(partition, nameof(partition)),
            }, callSettings);

        /// <summary>
        /// Create a metadata partition.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
        /// </param>
        /// <param name="partition">
        /// Required. Partition resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> CreatePartitionAsync(string parent, Partition partition, gaxgrpc::CallSettings callSettings = null) =>
            CreatePartitionAsync(new CreatePartitionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Partition = gax::GaxPreconditions.CheckNotNull(partition, nameof(partition)),
            }, callSettings);

        /// <summary>
        /// Create a metadata partition.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
        /// </param>
        /// <param name="partition">
        /// Required. Partition resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> CreatePartitionAsync(string parent, Partition partition, st::CancellationToken cancellationToken) =>
            CreatePartitionAsync(parent, partition, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a metadata partition.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
        /// </param>
        /// <param name="partition">
        /// Required. Partition resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partition CreatePartition(EntityName parent, Partition partition, gaxgrpc::CallSettings callSettings = null) =>
            CreatePartition(new CreatePartitionRequest
            {
                ParentAsEntityName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Partition = gax::GaxPreconditions.CheckNotNull(partition, nameof(partition)),
            }, callSettings);

        /// <summary>
        /// Create a metadata partition.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
        /// </param>
        /// <param name="partition">
        /// Required. Partition resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> CreatePartitionAsync(EntityName parent, Partition partition, gaxgrpc::CallSettings callSettings = null) =>
            CreatePartitionAsync(new CreatePartitionRequest
            {
                ParentAsEntityName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Partition = gax::GaxPreconditions.CheckNotNull(partition, nameof(partition)),
            }, callSettings);

        /// <summary>
        /// Create a metadata partition.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent zone:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
        /// </param>
        /// <param name="partition">
        /// Required. Partition resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> CreatePartitionAsync(EntityName parent, Partition partition, st::CancellationToken cancellationToken) =>
            CreatePartitionAsync(parent, partition, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a metadata partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePartition(DeletePartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a metadata partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePartitionAsync(DeletePartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a metadata partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePartitionAsync(DeletePartitionRequest request, st::CancellationToken cancellationToken) =>
            DeletePartitionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a metadata partition.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition.
        /// format:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}`.
        /// The {partition_value_path} segment consists of an ordered sequence of
        /// partition values separated by "/". All values must be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePartition(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePartition(new DeletePartitionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a metadata partition.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition.
        /// format:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}`.
        /// The {partition_value_path} segment consists of an ordered sequence of
        /// partition values separated by "/". All values must be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePartitionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePartitionAsync(new DeletePartitionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a metadata partition.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition.
        /// format:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}`.
        /// The {partition_value_path} segment consists of an ordered sequence of
        /// partition values separated by "/". All values must be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePartitionAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePartitionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a metadata partition.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition.
        /// format:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}`.
        /// The {partition_value_path} segment consists of an ordered sequence of
        /// partition values separated by "/". All values must be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePartition(PartitionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePartition(new DeletePartitionRequest
            {
                PartitionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a metadata partition.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition.
        /// format:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}`.
        /// The {partition_value_path} segment consists of an ordered sequence of
        /// partition values separated by "/". All values must be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePartitionAsync(PartitionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePartitionAsync(new DeletePartitionRequest
            {
                PartitionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a metadata partition.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition.
        /// format:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}`.
        /// The {partition_value_path} segment consists of an ordered sequence of
        /// partition values separated by "/". All values must be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePartitionAsync(PartitionName name, st::CancellationToken cancellationToken) =>
            DeletePartitionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partition GetPartition(GetPartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> GetPartitionAsync(GetPartitionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> GetPartitionAsync(GetPartitionRequest request, st::CancellationToken cancellationToken) =>
            GetPartitionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}`.
        /// The {partition_value_path} segment consists of an ordered sequence of
        /// partition values separated by "/". All values must be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partition GetPartition(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartition(new GetPartitionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}`.
        /// The {partition_value_path} segment consists of an ordered sequence of
        /// partition values separated by "/". All values must be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> GetPartitionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartitionAsync(new GetPartitionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}`.
        /// The {partition_value_path} segment consists of an ordered sequence of
        /// partition values separated by "/". All values must be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> GetPartitionAsync(string name, st::CancellationToken cancellationToken) =>
            GetPartitionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}`.
        /// The {partition_value_path} segment consists of an ordered sequence of
        /// partition values separated by "/". All values must be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partition GetPartition(PartitionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartition(new GetPartitionRequest
            {
                PartitionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}`.
        /// The {partition_value_path} segment consists of an ordered sequence of
        /// partition values separated by "/". All values must be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> GetPartitionAsync(PartitionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartitionAsync(new GetPartitionRequest
            {
                PartitionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partition:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}/partitions/{partition_value_path}`.
        /// The {partition_value_path} segment consists of an ordered sequence of
        /// partition values separated by "/". All values must be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partition> GetPartitionAsync(PartitionName name, st::CancellationToken cancellationToken) =>
            GetPartitionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Partition"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPartitionsResponse, Partition> ListPartitions(ListPartitionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Partition"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPartitionsResponse, Partition> ListPartitionsAsync(ListPartitionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
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
        /// <returns>A pageable sequence of <see cref="Partition"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPartitionsResponse, Partition> ListPartitions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPartitionsRequest request = new ListPartitionsRequest
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
            return ListPartitions(request, callSettings);
        }

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Partition"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPartitionsResponse, Partition> ListPartitionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPartitionsRequest request = new ListPartitionsRequest
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
            return ListPartitionsAsync(request, callSettings);
        }

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
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
        /// <returns>A pageable sequence of <see cref="Partition"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPartitionsResponse, Partition> ListPartitions(EntityName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPartitionsRequest request = new ListPartitionsRequest
            {
                ParentAsEntityName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPartitions(request, callSettings);
        }

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent entity:
        /// `projects/{project_number}/locations/{location_id}/lakes/{lake_id}/zones/{zone_id}/entities/{entity_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Partition"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPartitionsResponse, Partition> ListPartitionsAsync(EntityName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPartitionsRequest request = new ListPartitionsRequest
            {
                ParentAsEntityName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPartitionsAsync(request, callSettings);
        }
    }

    /// <summary>MetadataService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Metadata service manages metadata resources such as tables, filesets and
    /// partitions.
    /// </remarks>
    public sealed partial class MetadataServiceClientImpl : MetadataServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateEntityRequest, Entity> _callCreateEntity;

        private readonly gaxgrpc::ApiCall<UpdateEntityRequest, Entity> _callUpdateEntity;

        private readonly gaxgrpc::ApiCall<DeleteEntityRequest, wkt::Empty> _callDeleteEntity;

        private readonly gaxgrpc::ApiCall<GetEntityRequest, Entity> _callGetEntity;

        private readonly gaxgrpc::ApiCall<ListEntitiesRequest, ListEntitiesResponse> _callListEntities;

        private readonly gaxgrpc::ApiCall<CreatePartitionRequest, Partition> _callCreatePartition;

        private readonly gaxgrpc::ApiCall<DeletePartitionRequest, wkt::Empty> _callDeletePartition;

        private readonly gaxgrpc::ApiCall<GetPartitionRequest, Partition> _callGetPartition;

        private readonly gaxgrpc::ApiCall<ListPartitionsRequest, ListPartitionsResponse> _callListPartitions;

        /// <summary>
        /// Constructs a client wrapper for the MetadataService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MetadataServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MetadataServiceClientImpl(MetadataService.MetadataServiceClient grpcClient, MetadataServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MetadataServiceSettings effectiveSettings = settings ?? MetadataServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateEntity = clientHelper.BuildApiCall<CreateEntityRequest, Entity>("CreateEntity", grpcClient.CreateEntityAsync, grpcClient.CreateEntity, effectiveSettings.CreateEntitySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEntity);
            Modify_CreateEntityApiCall(ref _callCreateEntity);
            _callUpdateEntity = clientHelper.BuildApiCall<UpdateEntityRequest, Entity>("UpdateEntity", grpcClient.UpdateEntityAsync, grpcClient.UpdateEntity, effectiveSettings.UpdateEntitySettings).WithGoogleRequestParam("entity.name", request => request.Entity?.Name);
            Modify_ApiCall(ref _callUpdateEntity);
            Modify_UpdateEntityApiCall(ref _callUpdateEntity);
            _callDeleteEntity = clientHelper.BuildApiCall<DeleteEntityRequest, wkt::Empty>("DeleteEntity", grpcClient.DeleteEntityAsync, grpcClient.DeleteEntity, effectiveSettings.DeleteEntitySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEntity);
            Modify_DeleteEntityApiCall(ref _callDeleteEntity);
            _callGetEntity = clientHelper.BuildApiCall<GetEntityRequest, Entity>("GetEntity", grpcClient.GetEntityAsync, grpcClient.GetEntity, effectiveSettings.GetEntitySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEntity);
            Modify_GetEntityApiCall(ref _callGetEntity);
            _callListEntities = clientHelper.BuildApiCall<ListEntitiesRequest, ListEntitiesResponse>("ListEntities", grpcClient.ListEntitiesAsync, grpcClient.ListEntities, effectiveSettings.ListEntitiesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntities);
            Modify_ListEntitiesApiCall(ref _callListEntities);
            _callCreatePartition = clientHelper.BuildApiCall<CreatePartitionRequest, Partition>("CreatePartition", grpcClient.CreatePartitionAsync, grpcClient.CreatePartition, effectiveSettings.CreatePartitionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePartition);
            Modify_CreatePartitionApiCall(ref _callCreatePartition);
            _callDeletePartition = clientHelper.BuildApiCall<DeletePartitionRequest, wkt::Empty>("DeletePartition", grpcClient.DeletePartitionAsync, grpcClient.DeletePartition, effectiveSettings.DeletePartitionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePartition);
            Modify_DeletePartitionApiCall(ref _callDeletePartition);
            _callGetPartition = clientHelper.BuildApiCall<GetPartitionRequest, Partition>("GetPartition", grpcClient.GetPartitionAsync, grpcClient.GetPartition, effectiveSettings.GetPartitionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPartition);
            Modify_GetPartitionApiCall(ref _callGetPartition);
            _callListPartitions = clientHelper.BuildApiCall<ListPartitionsRequest, ListPartitionsResponse>("ListPartitions", grpcClient.ListPartitionsAsync, grpcClient.ListPartitions, effectiveSettings.ListPartitionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPartitions);
            Modify_ListPartitionsApiCall(ref _callListPartitions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateEntityApiCall(ref gaxgrpc::ApiCall<CreateEntityRequest, Entity> call);

        partial void Modify_UpdateEntityApiCall(ref gaxgrpc::ApiCall<UpdateEntityRequest, Entity> call);

        partial void Modify_DeleteEntityApiCall(ref gaxgrpc::ApiCall<DeleteEntityRequest, wkt::Empty> call);

        partial void Modify_GetEntityApiCall(ref gaxgrpc::ApiCall<GetEntityRequest, Entity> call);

        partial void Modify_ListEntitiesApiCall(ref gaxgrpc::ApiCall<ListEntitiesRequest, ListEntitiesResponse> call);

        partial void Modify_CreatePartitionApiCall(ref gaxgrpc::ApiCall<CreatePartitionRequest, Partition> call);

        partial void Modify_DeletePartitionApiCall(ref gaxgrpc::ApiCall<DeletePartitionRequest, wkt::Empty> call);

        partial void Modify_GetPartitionApiCall(ref gaxgrpc::ApiCall<GetPartitionRequest, Partition> call);

        partial void Modify_ListPartitionsApiCall(ref gaxgrpc::ApiCall<ListPartitionsRequest, ListPartitionsResponse> call);

        partial void OnConstruction(MetadataService.MetadataServiceClient grpcClient, MetadataServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MetadataService client</summary>
        public override MetadataService.MetadataServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateEntityRequest(ref CreateEntityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEntityRequest(ref UpdateEntityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEntityRequest(ref DeleteEntityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEntityRequest(ref GetEntityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntitiesRequest(ref ListEntitiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePartitionRequest(ref CreatePartitionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePartitionRequest(ref DeletePartitionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPartitionRequest(ref GetPartitionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPartitionsRequest(ref ListPartitionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entity CreateEntity(CreateEntityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntityRequest(ref request, ref callSettings);
            return _callCreateEntity.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entity> CreateEntityAsync(CreateEntityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntityRequest(ref request, ref callSettings);
            return _callCreateEntity.Async(request, callSettings);
        }

        /// <summary>
        /// Update a metadata entity. Only supports full resource update.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entity UpdateEntity(UpdateEntityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntityRequest(ref request, ref callSettings);
            return _callUpdateEntity.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a metadata entity. Only supports full resource update.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entity> UpdateEntityAsync(UpdateEntityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntityRequest(ref request, ref callSettings);
            return _callUpdateEntity.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEntity(DeleteEntityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntityRequest(ref request, ref callSettings);
            _callDeleteEntity.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEntityAsync(DeleteEntityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntityRequest(ref request, ref callSettings);
            return _callDeleteEntity.Async(request, callSettings);
        }

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entity GetEntity(GetEntityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntityRequest(ref request, ref callSettings);
            return _callGetEntity.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a metadata entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entity> GetEntityAsync(GetEntityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntityRequest(ref request, ref callSettings);
            return _callGetEntity.Async(request, callSettings);
        }

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entity"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntitiesResponse, Entity> ListEntities(ListEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntitiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntitiesRequest, ListEntitiesResponse, Entity>(_callListEntities, request, callSettings);
        }

        /// <summary>
        /// List metadata entities in a zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entity"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntitiesResponse, Entity> ListEntitiesAsync(ListEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntitiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntitiesRequest, ListEntitiesResponse, Entity>(_callListEntities, request, callSettings);
        }

        /// <summary>
        /// Create a metadata partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Partition CreatePartition(CreatePartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePartitionRequest(ref request, ref callSettings);
            return _callCreatePartition.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a metadata partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Partition> CreatePartitionAsync(CreatePartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePartitionRequest(ref request, ref callSettings);
            return _callCreatePartition.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a metadata partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePartition(DeletePartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePartitionRequest(ref request, ref callSettings);
            _callDeletePartition.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a metadata partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePartitionAsync(DeletePartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePartitionRequest(ref request, ref callSettings);
            return _callDeletePartition.Async(request, callSettings);
        }

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Partition GetPartition(GetPartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPartitionRequest(ref request, ref callSettings);
            return _callGetPartition.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a metadata partition of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Partition> GetPartitionAsync(GetPartitionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPartitionRequest(ref request, ref callSettings);
            return _callGetPartition.Async(request, callSettings);
        }

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Partition"/> resources.</returns>
        public override gax::PagedEnumerable<ListPartitionsResponse, Partition> ListPartitions(ListPartitionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPartitionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPartitionsRequest, ListPartitionsResponse, Partition>(_callListPartitions, request, callSettings);
        }

        /// <summary>
        /// List metadata partitions of an entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Partition"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPartitionsResponse, Partition> ListPartitionsAsync(ListPartitionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPartitionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPartitionsRequest, ListPartitionsResponse, Partition>(_callListPartitions, request, callSettings);
        }
    }

    public partial class ListEntitiesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPartitionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntitiesResponse : gaxgrpc::IPageResponse<Entity>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Entity> GetEnumerator() => Entities.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPartitionsResponse : gaxgrpc::IPageResponse<Partition>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Partition> GetEnumerator() => Partitions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class MetadataService
    {
        public partial class MetadataServiceClient
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
