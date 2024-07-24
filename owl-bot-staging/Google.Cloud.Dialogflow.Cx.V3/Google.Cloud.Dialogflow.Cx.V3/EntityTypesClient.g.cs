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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
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

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Settings for <see cref="EntityTypesClient"/> instances.</summary>
    public sealed partial class EntityTypesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EntityTypesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EntityTypesSettings"/>.</returns>
        public static EntityTypesSettings GetDefault() => new EntityTypesSettings();

        /// <summary>Constructs a new <see cref="EntityTypesSettings"/> object with default settings.</summary>
        public EntityTypesSettings()
        {
        }

        private EntityTypesSettings(EntityTypesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetEntityTypeSettings = existing.GetEntityTypeSettings;
            CreateEntityTypeSettings = existing.CreateEntityTypeSettings;
            UpdateEntityTypeSettings = existing.UpdateEntityTypeSettings;
            DeleteEntityTypeSettings = existing.DeleteEntityTypeSettings;
            ListEntityTypesSettings = existing.ListEntityTypesSettings;
            ExportEntityTypesSettings = existing.ExportEntityTypesSettings;
            ExportEntityTypesOperationsSettings = existing.ExportEntityTypesOperationsSettings.Clone();
            ImportEntityTypesSettings = existing.ImportEntityTypesSettings;
            ImportEntityTypesOperationsSettings = existing.ImportEntityTypesOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EntityTypesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.GetEntityType</c> and <c>EntityTypesClient.GetEntityTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEntityTypeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.CreateEntityType</c> and <c>EntityTypesClient.CreateEntityTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEntityTypeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.UpdateEntityType</c> and <c>EntityTypesClient.UpdateEntityTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEntityTypeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.DeleteEntityType</c> and <c>EntityTypesClient.DeleteEntityTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEntityTypeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.ListEntityTypes</c> and <c>EntityTypesClient.ListEntityTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEntityTypesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.ExportEntityTypes</c> and <c>EntityTypesClient.ExportEntityTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportEntityTypesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EntityTypesClient.ExportEntityTypes</c> and
        /// <c>EntityTypesClient.ExportEntityTypesAsync</c>.
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
        public lro::OperationsSettings ExportEntityTypesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.ImportEntityTypes</c> and <c>EntityTypesClient.ImportEntityTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportEntityTypesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EntityTypesClient.ImportEntityTypes</c> and
        /// <c>EntityTypesClient.ImportEntityTypesAsync</c>.
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
        public lro::OperationsSettings ImportEntityTypesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EntityTypesSettings"/> object.</returns>
        public EntityTypesSettings Clone() => new EntityTypesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EntityTypesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class EntityTypesClientBuilder : gaxgrpc::ClientBuilderBase<EntityTypesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EntityTypesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EntityTypesClientBuilder() : base(EntityTypesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EntityTypesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EntityTypesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EntityTypesClient Build()
        {
            EntityTypesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EntityTypesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EntityTypesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EntityTypesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EntityTypesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EntityTypesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EntityTypesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EntityTypesClient.ChannelPool;
    }

    /// <summary>EntityTypes client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [EntityTypes][google.cloud.dialogflow.cx.v3.EntityType].
    /// </remarks>
    public abstract partial class EntityTypesClient
    {
        /// <summary>
        /// The default endpoint for the EntityTypes service, which is a host of "dialogflow.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default EntityTypes scopes.</summary>
        /// <remarks>
        /// The default EntityTypes scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EntityTypes.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EntityTypesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EntityTypesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EntityTypesClient"/>.</returns>
        public static stt::Task<EntityTypesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EntityTypesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EntityTypesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EntityTypesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EntityTypesClient"/>.</returns>
        public static EntityTypesClient Create() => new EntityTypesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EntityTypesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EntityTypesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EntityTypesClient"/>.</returns>
        internal static EntityTypesClient Create(grpccore::CallInvoker callInvoker, EntityTypesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EntityTypes.EntityTypesClient grpcClient = new EntityTypes.EntityTypesClient(callInvoker);
            return new EntityTypesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EntityTypes client</summary>
        public virtual EntityTypes.EntityTypesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType GetEntityType(GetEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(GetEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(GetEntityTypeRequest request, st::CancellationToken cancellationToken) =>
            GetEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType GetEntityType(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityType(new GetEntityTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityTypeAsync(new GetEntityTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(string name, st::CancellationToken cancellationToken) =>
            GetEntityTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType GetEntityType(EntityTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityType(new GetEntityTypeRequest
            {
                EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(EntityTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityTypeAsync(new GetEntityTypeRequest
            {
                EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(EntityTypeName name, st::CancellationToken cancellationToken) =>
            GetEntityTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType CreateEntityType(CreateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(CreateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(CreateEntityTypeRequest request, st::CancellationToken cancellationToken) =>
            CreateEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType CreateEntityType(string parent, EntityType entityType, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityType(new CreateEntityTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(string parent, EntityType entityType, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityTypeAsync(new CreateEntityTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(string parent, EntityType entityType, st::CancellationToken cancellationToken) =>
            CreateEntityTypeAsync(parent, entityType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType CreateEntityType(AgentName parent, EntityType entityType, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityType(new CreateEntityTypeRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(AgentName parent, EntityType entityType, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityTypeAsync(new CreateEntityTypeRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(AgentName parent, EntityType entityType, st::CancellationToken cancellationToken) =>
            CreateEntityTypeAsync(parent, entityType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType UpdateEntityType(UpdateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(UpdateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(UpdateEntityTypeRequest request, st::CancellationToken cancellationToken) =>
            UpdateEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType UpdateEntityType(EntityType entityType, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntityType(new UpdateEntityTypeRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(EntityType entityType, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntityTypeAsync(new UpdateEntityTypeRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(EntityType entityType, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEntityTypeAsync(entityType, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntityType(DeleteEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityTypeAsync(DeleteEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityTypeAsync(DeleteEntityTypeRequest request, st::CancellationToken cancellationToken) =>
            DeleteEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntityType(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityType(new DeleteEntityTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityTypeAsync(new DeleteEntityTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityTypeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEntityTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntityType(EntityTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityType(new DeleteEntityTypeRequest
            {
                EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityTypeAsync(EntityTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityTypeAsync(new DeleteEntityTypeRequest
            {
                EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent
        /// ID&gt;/entityTypes/&lt;Entity Type ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityTypeAsync(EntityTypeName name, st::CancellationToken cancellationToken) =>
            DeleteEntityTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntityType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(ListEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntityType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(ListEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all entity types for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="EntityType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntityTypesRequest request = new ListEntityTypesRequest
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
            return ListEntityTypes(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all entity types for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntityType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntityTypesRequest request = new ListEntityTypesRequest
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
            return ListEntityTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all entity types for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="EntityType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntityTypes(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all entity types for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agents/&lt;Agent ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntityType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntityTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Exports the selected entity types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata> ExportEntityTypes(ExportEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the selected entity types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata>> ExportEntityTypesAsync(ExportEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the selected entity types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata>> ExportEntityTypesAsync(ExportEntityTypesRequest request, st::CancellationToken cancellationToken) =>
            ExportEntityTypesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportEntityTypes</c>.</summary>
        public virtual lro::OperationsClient ExportEntityTypesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportEntityTypes</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata> PollOnceExportEntityTypes(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportEntityTypesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportEntityTypes</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata>> PollOnceExportEntityTypesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportEntityTypesOperationsClient, callSettings);

        /// <summary>
        /// Imports the specified entitytypes into the agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata> ImportEntityTypes(ImportEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the specified entitytypes into the agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata>> ImportEntityTypesAsync(ImportEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the specified entitytypes into the agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata>> ImportEntityTypesAsync(ImportEntityTypesRequest request, st::CancellationToken cancellationToken) =>
            ImportEntityTypesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportEntityTypes</c>.</summary>
        public virtual lro::OperationsClient ImportEntityTypesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportEntityTypes</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata> PollOnceImportEntityTypes(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportEntityTypesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportEntityTypes</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata>> PollOnceImportEntityTypesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportEntityTypesOperationsClient, callSettings);
    }

    /// <summary>EntityTypes client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [EntityTypes][google.cloud.dialogflow.cx.v3.EntityType].
    /// </remarks>
    public sealed partial class EntityTypesClientImpl : EntityTypesClient
    {
        private readonly gaxgrpc::ApiCall<GetEntityTypeRequest, EntityType> _callGetEntityType;

        private readonly gaxgrpc::ApiCall<CreateEntityTypeRequest, EntityType> _callCreateEntityType;

        private readonly gaxgrpc::ApiCall<UpdateEntityTypeRequest, EntityType> _callUpdateEntityType;

        private readonly gaxgrpc::ApiCall<DeleteEntityTypeRequest, wkt::Empty> _callDeleteEntityType;

        private readonly gaxgrpc::ApiCall<ListEntityTypesRequest, ListEntityTypesResponse> _callListEntityTypes;

        private readonly gaxgrpc::ApiCall<ExportEntityTypesRequest, lro::Operation> _callExportEntityTypes;

        private readonly gaxgrpc::ApiCall<ImportEntityTypesRequest, lro::Operation> _callImportEntityTypes;

        /// <summary>
        /// Constructs a client wrapper for the EntityTypes service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EntityTypesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EntityTypesClientImpl(EntityTypes.EntityTypesClient grpcClient, EntityTypesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EntityTypesSettings effectiveSettings = settings ?? EntityTypesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ExportEntityTypesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportEntityTypesOperationsSettings, logger);
            ImportEntityTypesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportEntityTypesOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetEntityType = clientHelper.BuildApiCall<GetEntityTypeRequest, EntityType>("GetEntityType", grpcClient.GetEntityTypeAsync, grpcClient.GetEntityType, effectiveSettings.GetEntityTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEntityType);
            Modify_GetEntityTypeApiCall(ref _callGetEntityType);
            _callCreateEntityType = clientHelper.BuildApiCall<CreateEntityTypeRequest, EntityType>("CreateEntityType", grpcClient.CreateEntityTypeAsync, grpcClient.CreateEntityType, effectiveSettings.CreateEntityTypeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEntityType);
            Modify_CreateEntityTypeApiCall(ref _callCreateEntityType);
            _callUpdateEntityType = clientHelper.BuildApiCall<UpdateEntityTypeRequest, EntityType>("UpdateEntityType", grpcClient.UpdateEntityTypeAsync, grpcClient.UpdateEntityType, effectiveSettings.UpdateEntityTypeSettings).WithGoogleRequestParam("entity_type.name", request => request.EntityType?.Name);
            Modify_ApiCall(ref _callUpdateEntityType);
            Modify_UpdateEntityTypeApiCall(ref _callUpdateEntityType);
            _callDeleteEntityType = clientHelper.BuildApiCall<DeleteEntityTypeRequest, wkt::Empty>("DeleteEntityType", grpcClient.DeleteEntityTypeAsync, grpcClient.DeleteEntityType, effectiveSettings.DeleteEntityTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEntityType);
            Modify_DeleteEntityTypeApiCall(ref _callDeleteEntityType);
            _callListEntityTypes = clientHelper.BuildApiCall<ListEntityTypesRequest, ListEntityTypesResponse>("ListEntityTypes", grpcClient.ListEntityTypesAsync, grpcClient.ListEntityTypes, effectiveSettings.ListEntityTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntityTypes);
            Modify_ListEntityTypesApiCall(ref _callListEntityTypes);
            _callExportEntityTypes = clientHelper.BuildApiCall<ExportEntityTypesRequest, lro::Operation>("ExportEntityTypes", grpcClient.ExportEntityTypesAsync, grpcClient.ExportEntityTypes, effectiveSettings.ExportEntityTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportEntityTypes);
            Modify_ExportEntityTypesApiCall(ref _callExportEntityTypes);
            _callImportEntityTypes = clientHelper.BuildApiCall<ImportEntityTypesRequest, lro::Operation>("ImportEntityTypes", grpcClient.ImportEntityTypesAsync, grpcClient.ImportEntityTypes, effectiveSettings.ImportEntityTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportEntityTypes);
            Modify_ImportEntityTypesApiCall(ref _callImportEntityTypes);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetEntityTypeApiCall(ref gaxgrpc::ApiCall<GetEntityTypeRequest, EntityType> call);

        partial void Modify_CreateEntityTypeApiCall(ref gaxgrpc::ApiCall<CreateEntityTypeRequest, EntityType> call);

        partial void Modify_UpdateEntityTypeApiCall(ref gaxgrpc::ApiCall<UpdateEntityTypeRequest, EntityType> call);

        partial void Modify_DeleteEntityTypeApiCall(ref gaxgrpc::ApiCall<DeleteEntityTypeRequest, wkt::Empty> call);

        partial void Modify_ListEntityTypesApiCall(ref gaxgrpc::ApiCall<ListEntityTypesRequest, ListEntityTypesResponse> call);

        partial void Modify_ExportEntityTypesApiCall(ref gaxgrpc::ApiCall<ExportEntityTypesRequest, lro::Operation> call);

        partial void Modify_ImportEntityTypesApiCall(ref gaxgrpc::ApiCall<ImportEntityTypesRequest, lro::Operation> call);

        partial void OnConstruction(EntityTypes.EntityTypesClient grpcClient, EntityTypesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EntityTypes client</summary>
        public override EntityTypes.EntityTypesClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetEntityTypeRequest(ref GetEntityTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEntityTypeRequest(ref CreateEntityTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEntityTypeRequest(ref UpdateEntityTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEntityTypeRequest(ref DeleteEntityTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntityTypesRequest(ref ListEntityTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportEntityTypesRequest(ref ExportEntityTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportEntityTypesRequest(ref ImportEntityTypesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntityType GetEntityType(GetEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntityTypeRequest(ref request, ref callSettings);
            return _callGetEntityType.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntityType> GetEntityTypeAsync(GetEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntityTypeRequest(ref request, ref callSettings);
            return _callGetEntityType.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntityType CreateEntityType(CreateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntityTypeRequest(ref request, ref callSettings);
            return _callCreateEntityType.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntityType> CreateEntityTypeAsync(CreateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntityTypeRequest(ref request, ref callSettings);
            return _callCreateEntityType.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntityType UpdateEntityType(UpdateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntityTypeRequest(ref request, ref callSettings);
            return _callUpdateEntityType.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntityType> UpdateEntityTypeAsync(UpdateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntityTypeRequest(ref request, ref callSettings);
            return _callUpdateEntityType.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEntityType(DeleteEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntityTypeRequest(ref request, ref callSettings);
            _callDeleteEntityType.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEntityTypeAsync(DeleteEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntityTypeRequest(ref request, ref callSettings);
            return _callDeleteEntityType.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntityType"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(ListEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntityTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntityTypesRequest, ListEntityTypesResponse, EntityType>(_callListEntityTypes, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntityType"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(ListEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntityTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntityTypesRequest, ListEntityTypesResponse, EntityType>(_callListEntityTypes, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ExportEntityTypes</c>.</summary>
        public override lro::OperationsClient ExportEntityTypesOperationsClient { get; }

        /// <summary>
        /// Exports the selected entity types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata> ExportEntityTypes(ExportEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportEntityTypesRequest(ref request, ref callSettings);
            return new lro::Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata>(_callExportEntityTypes.Sync(request, callSettings), ExportEntityTypesOperationsClient);
        }

        /// <summary>
        /// Exports the selected entity types.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata>> ExportEntityTypesAsync(ExportEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportEntityTypesRequest(ref request, ref callSettings);
            return new lro::Operation<ExportEntityTypesResponse, ExportEntityTypesMetadata>(await _callExportEntityTypes.Async(request, callSettings).ConfigureAwait(false), ExportEntityTypesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportEntityTypes</c>.</summary>
        public override lro::OperationsClient ImportEntityTypesOperationsClient { get; }

        /// <summary>
        /// Imports the specified entitytypes into the agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata> ImportEntityTypes(ImportEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportEntityTypesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata>(_callImportEntityTypes.Sync(request, callSettings), ImportEntityTypesOperationsClient);
        }

        /// <summary>
        /// Imports the specified entitytypes into the agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata>> ImportEntityTypesAsync(ImportEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportEntityTypesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportEntityTypesResponse, ImportEntityTypesMetadata>(await _callImportEntityTypes.Async(request, callSettings).ConfigureAwait(false), ImportEntityTypesOperationsClient);
        }
    }

    public partial class ListEntityTypesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntityTypesResponse : gaxgrpc::IPageResponse<EntityType>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EntityType> GetEnumerator() => EntityTypes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class EntityTypes
    {
        public partial class EntityTypesClient
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

    public static partial class EntityTypes
    {
        public partial class EntityTypesClient
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
