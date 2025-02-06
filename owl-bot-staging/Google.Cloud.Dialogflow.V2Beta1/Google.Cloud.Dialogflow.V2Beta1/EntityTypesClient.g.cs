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

namespace Google.Cloud.Dialogflow.V2Beta1
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
            ListEntityTypesSettings = existing.ListEntityTypesSettings;
            GetEntityTypeSettings = existing.GetEntityTypeSettings;
            CreateEntityTypeSettings = existing.CreateEntityTypeSettings;
            UpdateEntityTypeSettings = existing.UpdateEntityTypeSettings;
            DeleteEntityTypeSettings = existing.DeleteEntityTypeSettings;
            BatchUpdateEntityTypesSettings = existing.BatchUpdateEntityTypesSettings;
            BatchUpdateEntityTypesOperationsSettings = existing.BatchUpdateEntityTypesOperationsSettings.Clone();
            BatchDeleteEntityTypesSettings = existing.BatchDeleteEntityTypesSettings;
            BatchDeleteEntityTypesOperationsSettings = existing.BatchDeleteEntityTypesOperationsSettings.Clone();
            BatchCreateEntitiesSettings = existing.BatchCreateEntitiesSettings;
            BatchCreateEntitiesOperationsSettings = existing.BatchCreateEntitiesOperationsSettings.Clone();
            BatchUpdateEntitiesSettings = existing.BatchUpdateEntitiesSettings;
            BatchUpdateEntitiesOperationsSettings = existing.BatchUpdateEntitiesOperationsSettings.Clone();
            BatchDeleteEntitiesSettings = existing.BatchDeleteEntitiesSettings;
            BatchDeleteEntitiesOperationsSettings = existing.BatchDeleteEntitiesOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EntityTypesSettings existing);

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
        /// <c>EntityTypesClient.BatchUpdateEntityTypes</c> and <c>EntityTypesClient.BatchUpdateEntityTypesAsync</c>.
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
        public gaxgrpc::CallSettings BatchUpdateEntityTypesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EntityTypesClient.BatchUpdateEntityTypes</c> and
        /// <c>EntityTypesClient.BatchUpdateEntityTypesAsync</c>.
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
        public lro::OperationsSettings BatchUpdateEntityTypesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.BatchDeleteEntityTypes</c> and <c>EntityTypesClient.BatchDeleteEntityTypesAsync</c>.
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
        public gaxgrpc::CallSettings BatchDeleteEntityTypesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EntityTypesClient.BatchDeleteEntityTypes</c> and
        /// <c>EntityTypesClient.BatchDeleteEntityTypesAsync</c>.
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
        public lro::OperationsSettings BatchDeleteEntityTypesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.BatchCreateEntities</c> and <c>EntityTypesClient.BatchCreateEntitiesAsync</c>.
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
        public gaxgrpc::CallSettings BatchCreateEntitiesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EntityTypesClient.BatchCreateEntities</c> and
        /// <c>EntityTypesClient.BatchCreateEntitiesAsync</c>.
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
        public lro::OperationsSettings BatchCreateEntitiesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.BatchUpdateEntities</c> and <c>EntityTypesClient.BatchUpdateEntitiesAsync</c>.
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
        public gaxgrpc::CallSettings BatchUpdateEntitiesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EntityTypesClient.BatchUpdateEntities</c> and
        /// <c>EntityTypesClient.BatchUpdateEntitiesAsync</c>.
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
        public lro::OperationsSettings BatchUpdateEntitiesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EntityTypesClient.BatchDeleteEntities</c> and <c>EntityTypesClient.BatchDeleteEntitiesAsync</c>.
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
        public gaxgrpc::CallSettings BatchDeleteEntitiesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EntityTypesClient.BatchDeleteEntities</c> and
        /// <c>EntityTypesClient.BatchDeleteEntitiesAsync</c>.
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
        public lro::OperationsSettings BatchDeleteEntitiesOperationsSettings { get; set; } = new lro::OperationsSettings
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
    /// Service for managing
    /// [EntityTypes][google.cloud.dialogflow.v2beta1.EntityType].
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
        /// Required. The agent to list all entity types from.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// Required. The agent to list all entity types from.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// Required. The agent to list all entity types from.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// Required. The agent to list all entity types from.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// Returns the list of all entity types in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all entity types from.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
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
        public virtual gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(string parent, string languageCode, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LanguageCode = languageCode ?? "",
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
        /// Required. The agent to list all entity types from.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
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
        public virtual gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(string parent, string languageCode, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LanguageCode = languageCode ?? "",
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
        /// Required. The agent to list all entity types from.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
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
        public virtual gax::PagedEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypes(AgentName parent, string languageCode, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LanguageCode = languageCode ?? "",
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
        /// Required. The agent to list all entity types from.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
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
        public virtual gax::PagedAsyncEnumerable<ListEntityTypesResponse, EntityType> ListEntityTypesAsync(AgentName parent, string languageCode, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntityTypesRequest request = new ListEntityTypesRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LanguageCode = languageCode ?? "",
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
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
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
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
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
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
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
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
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
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
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
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(EntityTypeName name, st::CancellationToken cancellationToken) =>
            GetEntityTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType GetEntityType(string name, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityType(new GetEntityTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(string name, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityTypeAsync(new GetEntityTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(string name, string languageCode, st::CancellationToken cancellationToken) =>
            GetEntityTypeAsync(name, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType GetEntityType(EntityTypeName name, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityType(new GetEntityTypeRequest
            {
                EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(EntityTypeName name, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityTypeAsync(new GetEntityTypeRequest
            {
                EntityTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Retrieves the specified entity type.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> GetEntityTypeAsync(EntityTypeName name, string languageCode, st::CancellationToken cancellationToken) =>
            GetEntityTypeAsync(name, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType CreateEntityType(CreateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(CreateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(CreateEntityTypeRequest request, st::CancellationToken cancellationToken) =>
            CreateEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(AgentName parent, EntityType entityType, st::CancellationToken cancellationToken) =>
            CreateEntityTypeAsync(parent, entityType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType CreateEntityType(string parent, EntityType entityType, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityType(new CreateEntityTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(string parent, EntityType entityType, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityTypeAsync(new CreateEntityTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(string parent, EntityType entityType, string languageCode, st::CancellationToken cancellationToken) =>
            CreateEntityTypeAsync(parent, entityType, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType CreateEntityType(AgentName parent, EntityType entityType, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityType(new CreateEntityTypeRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(AgentName parent, EntityType entityType, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityTypeAsync(new CreateEntityTypeRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an entity type in the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a entity type for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
        /// </param>
        /// <param name="entityType">
        /// Required. The entity type to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> CreateEntityTypeAsync(AgentName parent, EntityType entityType, string languageCode, st::CancellationToken cancellationToken) =>
            CreateEntityTypeAsync(parent, entityType, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType UpdateEntityType(UpdateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(UpdateEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(UpdateEntityTypeRequest request, st::CancellationToken cancellationToken) =>
            UpdateEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType UpdateEntityType(EntityType entityType, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntityType(new UpdateEntityTypeRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(EntityType entityType, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntityTypeAsync(new UpdateEntityTypeRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
            }, callSettings);

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(EntityType entityType, st::CancellationToken cancellationToken) =>
            UpdateEntityTypeAsync(entityType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType UpdateEntityType(EntityType entityType, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntityType(new UpdateEntityTypeRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(EntityType entityType, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntityTypeAsync(new UpdateEntityTypeRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(EntityType entityType, string languageCode, st::CancellationToken cancellationToken) =>
            UpdateEntityTypeAsync(entityType, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityType UpdateEntityType(EntityType entityType, string languageCode, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntityType(new UpdateEntityTypeRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                LanguageCode = languageCode ?? "",
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(EntityType entityType, string languageCode, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntityTypeAsync(new UpdateEntityTypeRequest
            {
                EntityType = gax::GaxPreconditions.CheckNotNull(entityType, nameof(entityType)),
                LanguageCode = languageCode ?? "",
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="entityType">
        /// Required. The entity type to update.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityType> UpdateEntityTypeAsync(EntityType entityType, string languageCode, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEntityTypeAsync(entityType, languageCode, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntityType(DeleteEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityTypeAsync(DeleteEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityTypeAsync(DeleteEntityTypeRequest request, st::CancellationToken cancellationToken) =>
            DeleteEntityTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityTypeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEntityTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified entity type.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the entity type to delete.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityTypeAsync(EntityTypeName name, st::CancellationToken cancellationToken) =>
            DeleteEntityTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates/Creates multiple entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [BatchUpdateEntityTypesResponse][google.cloud.dialogflow.v2beta1.BatchUpdateEntityTypesResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchUpdateEntityTypesResponse, wkt::Struct> BatchUpdateEntityTypes(BatchUpdateEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates/Creates multiple entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [BatchUpdateEntityTypesResponse][google.cloud.dialogflow.v2beta1.BatchUpdateEntityTypesResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateEntityTypesResponse, wkt::Struct>> BatchUpdateEntityTypesAsync(BatchUpdateEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates/Creates multiple entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [BatchUpdateEntityTypesResponse][google.cloud.dialogflow.v2beta1.BatchUpdateEntityTypesResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateEntityTypesResponse, wkt::Struct>> BatchUpdateEntityTypesAsync(BatchUpdateEntityTypesRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateEntityTypesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchUpdateEntityTypes</c>.</summary>
        public virtual lro::OperationsClient BatchUpdateEntityTypesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchUpdateEntityTypes</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchUpdateEntityTypesResponse, wkt::Struct> PollOnceBatchUpdateEntityTypes(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchUpdateEntityTypesResponse, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchUpdateEntityTypesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchUpdateEntityTypes</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchUpdateEntityTypesResponse, wkt::Struct>> PollOnceBatchUpdateEntityTypesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchUpdateEntityTypesResponse, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchUpdateEntityTypesOperationsClient, callSettings);

        /// <summary>
        /// Deletes entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchDeleteEntityTypes(BatchDeleteEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntityTypesAsync(BatchDeleteEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntityTypesAsync(BatchDeleteEntityTypesRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteEntityTypesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchDeleteEntityTypes</c>.</summary>
        public virtual lro::OperationsClient BatchDeleteEntityTypesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchDeleteEntityTypes</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> PollOnceBatchDeleteEntityTypes(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchDeleteEntityTypesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchDeleteEntityTypes</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> PollOnceBatchDeleteEntityTypesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchDeleteEntityTypesOperationsClient, callSettings);

        /// <summary>
        /// Deletes entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`.
        /// </param>
        /// <param name="entityTypeNames">
        /// Required. The names entity types to delete. All names must point to the
        /// same agent as `parent`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchDeleteEntityTypes(string parent, scg::IEnumerable<string> entityTypeNames, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteEntityTypes(new BatchDeleteEntityTypesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityTypeNames =
                {
                    gax::GaxPreconditions.CheckNotNull(entityTypeNames, nameof(entityTypeNames)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`.
        /// </param>
        /// <param name="entityTypeNames">
        /// Required. The names entity types to delete. All names must point to the
        /// same agent as `parent`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntityTypesAsync(string parent, scg::IEnumerable<string> entityTypeNames, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteEntityTypesAsync(new BatchDeleteEntityTypesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityTypeNames =
                {
                    gax::GaxPreconditions.CheckNotNull(entityTypeNames, nameof(entityTypeNames)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`.
        /// </param>
        /// <param name="entityTypeNames">
        /// Required. The names entity types to delete. All names must point to the
        /// same agent as `parent`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntityTypesAsync(string parent, scg::IEnumerable<string> entityTypeNames, st::CancellationToken cancellationToken) =>
            BatchDeleteEntityTypesAsync(parent, entityTypeNames, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`.
        /// </param>
        /// <param name="entityTypeNames">
        /// Required. The names entity types to delete. All names must point to the
        /// same agent as `parent`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchDeleteEntityTypes(AgentName parent, scg::IEnumerable<string> entityTypeNames, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteEntityTypes(new BatchDeleteEntityTypesRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityTypeNames =
                {
                    gax::GaxPreconditions.CheckNotNull(entityTypeNames, nameof(entityTypeNames)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`.
        /// </param>
        /// <param name="entityTypeNames">
        /// Required. The names entity types to delete. All names must point to the
        /// same agent as `parent`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntityTypesAsync(AgentName parent, scg::IEnumerable<string> entityTypeNames, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteEntityTypesAsync(new BatchDeleteEntityTypesRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityTypeNames =
                {
                    gax::GaxPreconditions.CheckNotNull(entityTypeNames, nameof(entityTypeNames)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the agent to delete all entities types for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`.
        /// </param>
        /// <param name="entityTypeNames">
        /// Required. The names entity types to delete. All names must point to the
        /// same agent as `parent`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntityTypesAsync(AgentName parent, scg::IEnumerable<string> entityTypeNames, st::CancellationToken cancellationToken) =>
            BatchDeleteEntityTypesAsync(parent, entityTypeNames, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchCreateEntities(BatchCreateEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchCreateEntitiesAsync(BatchCreateEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchCreateEntitiesAsync(BatchCreateEntitiesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateEntitiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchCreateEntities</c>.</summary>
        public virtual lro::OperationsClient BatchCreateEntitiesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchCreateEntities</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> PollOnceBatchCreateEntities(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchCreateEntitiesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchCreateEntities</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> PollOnceBatchCreateEntitiesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchCreateEntitiesOperationsClient, callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchCreateEntities(string parent, scg::IEnumerable<EntityType.Types.Entity> entities, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateEntities(new BatchCreateEntitiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
            }, callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchCreateEntitiesAsync(string parent, scg::IEnumerable<EntityType.Types.Entity> entities, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateEntitiesAsync(new BatchCreateEntitiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
            }, callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchCreateEntitiesAsync(string parent, scg::IEnumerable<EntityType.Types.Entity> entities, st::CancellationToken cancellationToken) =>
            BatchCreateEntitiesAsync(parent, entities, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchCreateEntities(EntityTypeName parent, scg::IEnumerable<EntityType.Types.Entity> entities, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateEntities(new BatchCreateEntitiesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
            }, callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchCreateEntitiesAsync(EntityTypeName parent, scg::IEnumerable<EntityType.Types.Entity> entities, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateEntitiesAsync(new BatchCreateEntitiesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
            }, callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchCreateEntitiesAsync(EntityTypeName parent, scg::IEnumerable<EntityType.Types.Entity> entities, st::CancellationToken cancellationToken) =>
            BatchCreateEntitiesAsync(parent, entities, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchCreateEntities(string parent, scg::IEnumerable<EntityType.Types.Entity> entities, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateEntities(new BatchCreateEntitiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchCreateEntitiesAsync(string parent, scg::IEnumerable<EntityType.Types.Entity> entities, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateEntitiesAsync(new BatchCreateEntitiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchCreateEntitiesAsync(string parent, scg::IEnumerable<EntityType.Types.Entity> entities, string languageCode, st::CancellationToken cancellationToken) =>
            BatchCreateEntitiesAsync(parent, entities, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchCreateEntities(EntityTypeName parent, scg::IEnumerable<EntityType.Types.Entity> entities, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateEntities(new BatchCreateEntitiesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchCreateEntitiesAsync(EntityTypeName parent, scg::IEnumerable<EntityType.Types.Entity> entities, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateEntitiesAsync(new BatchCreateEntitiesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchCreateEntitiesAsync(EntityTypeName parent, scg::IEnumerable<EntityType.Types.Entity> entities, string languageCode, st::CancellationToken cancellationToken) =>
            BatchCreateEntitiesAsync(parent, entities, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchUpdateEntities(BatchUpdateEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchUpdateEntitiesAsync(BatchUpdateEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchUpdateEntitiesAsync(BatchUpdateEntitiesRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateEntitiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchUpdateEntities</c>.</summary>
        public virtual lro::OperationsClient BatchUpdateEntitiesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchUpdateEntities</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> PollOnceBatchUpdateEntities(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchUpdateEntitiesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchUpdateEntities</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> PollOnceBatchUpdateEntitiesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchUpdateEntitiesOperationsClient, callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchUpdateEntities(string parent, scg::IEnumerable<EntityType.Types.Entity> entities, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateEntities(new BatchUpdateEntitiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
            }, callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchUpdateEntitiesAsync(string parent, scg::IEnumerable<EntityType.Types.Entity> entities, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateEntitiesAsync(new BatchUpdateEntitiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
            }, callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchUpdateEntitiesAsync(string parent, scg::IEnumerable<EntityType.Types.Entity> entities, st::CancellationToken cancellationToken) =>
            BatchUpdateEntitiesAsync(parent, entities, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchUpdateEntities(EntityTypeName parent, scg::IEnumerable<EntityType.Types.Entity> entities, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateEntities(new BatchUpdateEntitiesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
            }, callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchUpdateEntitiesAsync(EntityTypeName parent, scg::IEnumerable<EntityType.Types.Entity> entities, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateEntitiesAsync(new BatchUpdateEntitiesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
            }, callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchUpdateEntitiesAsync(EntityTypeName parent, scg::IEnumerable<EntityType.Types.Entity> entities, st::CancellationToken cancellationToken) =>
            BatchUpdateEntitiesAsync(parent, entities, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchUpdateEntities(string parent, scg::IEnumerable<EntityType.Types.Entity> entities, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateEntities(new BatchUpdateEntitiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchUpdateEntitiesAsync(string parent, scg::IEnumerable<EntityType.Types.Entity> entities, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateEntitiesAsync(new BatchUpdateEntitiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchUpdateEntitiesAsync(string parent, scg::IEnumerable<EntityType.Types.Entity> entities, string languageCode, st::CancellationToken cancellationToken) =>
            BatchUpdateEntitiesAsync(parent, entities, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchUpdateEntities(EntityTypeName parent, scg::IEnumerable<EntityType.Types.Entity> entities, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateEntities(new BatchUpdateEntitiesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchUpdateEntitiesAsync(EntityTypeName parent, scg::IEnumerable<EntityType.Types.Entity> entities, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateEntitiesAsync(new BatchUpdateEntitiesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Entities =
                {
                    gax::GaxPreconditions.CheckNotNull(entities, nameof(entities)),
                },
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to update or create entities in.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entities">
        /// Required. The entities to update or create.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchUpdateEntitiesAsync(EntityTypeName parent, scg::IEnumerable<EntityType.Types.Entity> entities, string languageCode, st::CancellationToken cancellationToken) =>
            BatchUpdateEntitiesAsync(parent, entities, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchDeleteEntities(BatchDeleteEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntitiesAsync(BatchDeleteEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntitiesAsync(BatchDeleteEntitiesRequest request, st::CancellationToken cancellationToken) =>
            BatchDeleteEntitiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchDeleteEntities</c>.</summary>
        public virtual lro::OperationsClient BatchDeleteEntitiesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchDeleteEntities</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> PollOnceBatchDeleteEntities(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchDeleteEntitiesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchDeleteEntities</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> PollOnceBatchDeleteEntitiesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchDeleteEntitiesOperationsClient, callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entityValues">
        /// Required. The reference `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchDeleteEntities(string parent, scg::IEnumerable<string> entityValues, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteEntities(new BatchDeleteEntitiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityValues =
                {
                    gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entityValues">
        /// Required. The reference `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntitiesAsync(string parent, scg::IEnumerable<string> entityValues, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteEntitiesAsync(new BatchDeleteEntitiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityValues =
                {
                    gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entityValues">
        /// Required. The reference `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntitiesAsync(string parent, scg::IEnumerable<string> entityValues, st::CancellationToken cancellationToken) =>
            BatchDeleteEntitiesAsync(parent, entityValues, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entityValues">
        /// Required. The reference `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchDeleteEntities(EntityTypeName parent, scg::IEnumerable<string> entityValues, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteEntities(new BatchDeleteEntitiesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityValues =
                {
                    gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entityValues">
        /// Required. The reference `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntitiesAsync(EntityTypeName parent, scg::IEnumerable<string> entityValues, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteEntitiesAsync(new BatchDeleteEntitiesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityValues =
                {
                    gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)),
                },
            }, callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entityValues">
        /// Required. The reference `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntitiesAsync(EntityTypeName parent, scg::IEnumerable<string> entityValues, st::CancellationToken cancellationToken) =>
            BatchDeleteEntitiesAsync(parent, entityValues, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entityValues">
        /// Required. The reference `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchDeleteEntities(string parent, scg::IEnumerable<string> entityValues, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteEntities(new BatchDeleteEntitiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityValues =
                {
                    gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)),
                },
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entityValues">
        /// Required. The reference `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntitiesAsync(string parent, scg::IEnumerable<string> entityValues, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteEntitiesAsync(new BatchDeleteEntitiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityValues =
                {
                    gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)),
                },
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entityValues">
        /// Required. The reference `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntitiesAsync(string parent, scg::IEnumerable<string> entityValues, string languageCode, st::CancellationToken cancellationToken) =>
            BatchDeleteEntitiesAsync(parent, entityValues, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entityValues">
        /// Required. The reference `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> BatchDeleteEntities(EntityTypeName parent, scg::IEnumerable<string> entityValues, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteEntities(new BatchDeleteEntitiesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityValues =
                {
                    gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)),
                },
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entityValues">
        /// Required. The reference `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntitiesAsync(EntityTypeName parent, scg::IEnumerable<string> entityValues, string languageCode, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeleteEntitiesAsync(new BatchDeleteEntitiesRequest
            {
                ParentAsEntityTypeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityValues =
                {
                    gax::GaxPreconditions.CheckNotNull(entityValues, nameof(entityValues)),
                },
                LanguageCode = languageCode ?? "",
            }, callSettings);

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the entity type to delete entries for.
        /// Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/entityTypes/&lt;Entity Type ID&gt;`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/entityTypes/&lt;Entity
        /// Type ID&gt;`
        /// </param>
        /// <param name="entityValues">
        /// Required. The reference `values` of the entities to delete. Note that
        /// these are not fully-qualified names, i.e. they don't start with
        /// `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="languageCode">
        /// Optional. The language used to access language-specific data.
        /// If not specified, the agent's default language is used.
        /// For more information, see
        /// [Multilingual intent and entity
        /// data](https://cloud.google.com/dialogflow/docs/agents-multilingual#intent-entity).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntitiesAsync(EntityTypeName parent, scg::IEnumerable<string> entityValues, string languageCode, st::CancellationToken cancellationToken) =>
            BatchDeleteEntitiesAsync(parent, entityValues, languageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EntityTypes client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [EntityTypes][google.cloud.dialogflow.v2beta1.EntityType].
    /// </remarks>
    public sealed partial class EntityTypesClientImpl : EntityTypesClient
    {
        private readonly gaxgrpc::ApiCall<ListEntityTypesRequest, ListEntityTypesResponse> _callListEntityTypes;

        private readonly gaxgrpc::ApiCall<GetEntityTypeRequest, EntityType> _callGetEntityType;

        private readonly gaxgrpc::ApiCall<CreateEntityTypeRequest, EntityType> _callCreateEntityType;

        private readonly gaxgrpc::ApiCall<UpdateEntityTypeRequest, EntityType> _callUpdateEntityType;

        private readonly gaxgrpc::ApiCall<DeleteEntityTypeRequest, wkt::Empty> _callDeleteEntityType;

        private readonly gaxgrpc::ApiCall<BatchUpdateEntityTypesRequest, lro::Operation> _callBatchUpdateEntityTypes;

        private readonly gaxgrpc::ApiCall<BatchDeleteEntityTypesRequest, lro::Operation> _callBatchDeleteEntityTypes;

        private readonly gaxgrpc::ApiCall<BatchCreateEntitiesRequest, lro::Operation> _callBatchCreateEntities;

        private readonly gaxgrpc::ApiCall<BatchUpdateEntitiesRequest, lro::Operation> _callBatchUpdateEntities;

        private readonly gaxgrpc::ApiCall<BatchDeleteEntitiesRequest, lro::Operation> _callBatchDeleteEntities;

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
            BatchUpdateEntityTypesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchUpdateEntityTypesOperationsSettings, logger);
            BatchDeleteEntityTypesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchDeleteEntityTypesOperationsSettings, logger);
            BatchCreateEntitiesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchCreateEntitiesOperationsSettings, logger);
            BatchUpdateEntitiesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchUpdateEntitiesOperationsSettings, logger);
            BatchDeleteEntitiesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchDeleteEntitiesOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListEntityTypes = clientHelper.BuildApiCall<ListEntityTypesRequest, ListEntityTypesResponse>("ListEntityTypes", grpcClient.ListEntityTypesAsync, grpcClient.ListEntityTypes, effectiveSettings.ListEntityTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntityTypes);
            Modify_ListEntityTypesApiCall(ref _callListEntityTypes);
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
            _callBatchUpdateEntityTypes = clientHelper.BuildApiCall<BatchUpdateEntityTypesRequest, lro::Operation>("BatchUpdateEntityTypes", grpcClient.BatchUpdateEntityTypesAsync, grpcClient.BatchUpdateEntityTypes, effectiveSettings.BatchUpdateEntityTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateEntityTypes);
            Modify_BatchUpdateEntityTypesApiCall(ref _callBatchUpdateEntityTypes);
            _callBatchDeleteEntityTypes = clientHelper.BuildApiCall<BatchDeleteEntityTypesRequest, lro::Operation>("BatchDeleteEntityTypes", grpcClient.BatchDeleteEntityTypesAsync, grpcClient.BatchDeleteEntityTypes, effectiveSettings.BatchDeleteEntityTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteEntityTypes);
            Modify_BatchDeleteEntityTypesApiCall(ref _callBatchDeleteEntityTypes);
            _callBatchCreateEntities = clientHelper.BuildApiCall<BatchCreateEntitiesRequest, lro::Operation>("BatchCreateEntities", grpcClient.BatchCreateEntitiesAsync, grpcClient.BatchCreateEntities, effectiveSettings.BatchCreateEntitiesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateEntities);
            Modify_BatchCreateEntitiesApiCall(ref _callBatchCreateEntities);
            _callBatchUpdateEntities = clientHelper.BuildApiCall<BatchUpdateEntitiesRequest, lro::Operation>("BatchUpdateEntities", grpcClient.BatchUpdateEntitiesAsync, grpcClient.BatchUpdateEntities, effectiveSettings.BatchUpdateEntitiesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateEntities);
            Modify_BatchUpdateEntitiesApiCall(ref _callBatchUpdateEntities);
            _callBatchDeleteEntities = clientHelper.BuildApiCall<BatchDeleteEntitiesRequest, lro::Operation>("BatchDeleteEntities", grpcClient.BatchDeleteEntitiesAsync, grpcClient.BatchDeleteEntities, effectiveSettings.BatchDeleteEntitiesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeleteEntities);
            Modify_BatchDeleteEntitiesApiCall(ref _callBatchDeleteEntities);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListEntityTypesApiCall(ref gaxgrpc::ApiCall<ListEntityTypesRequest, ListEntityTypesResponse> call);

        partial void Modify_GetEntityTypeApiCall(ref gaxgrpc::ApiCall<GetEntityTypeRequest, EntityType> call);

        partial void Modify_CreateEntityTypeApiCall(ref gaxgrpc::ApiCall<CreateEntityTypeRequest, EntityType> call);

        partial void Modify_UpdateEntityTypeApiCall(ref gaxgrpc::ApiCall<UpdateEntityTypeRequest, EntityType> call);

        partial void Modify_DeleteEntityTypeApiCall(ref gaxgrpc::ApiCall<DeleteEntityTypeRequest, wkt::Empty> call);

        partial void Modify_BatchUpdateEntityTypesApiCall(ref gaxgrpc::ApiCall<BatchUpdateEntityTypesRequest, lro::Operation> call);

        partial void Modify_BatchDeleteEntityTypesApiCall(ref gaxgrpc::ApiCall<BatchDeleteEntityTypesRequest, lro::Operation> call);

        partial void Modify_BatchCreateEntitiesApiCall(ref gaxgrpc::ApiCall<BatchCreateEntitiesRequest, lro::Operation> call);

        partial void Modify_BatchUpdateEntitiesApiCall(ref gaxgrpc::ApiCall<BatchUpdateEntitiesRequest, lro::Operation> call);

        partial void Modify_BatchDeleteEntitiesApiCall(ref gaxgrpc::ApiCall<BatchDeleteEntitiesRequest, lro::Operation> call);

        partial void OnConstruction(EntityTypes.EntityTypesClient grpcClient, EntityTypesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EntityTypes client</summary>
        public override EntityTypes.EntityTypesClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListEntityTypesRequest(ref ListEntityTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEntityTypeRequest(ref GetEntityTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEntityTypeRequest(ref CreateEntityTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEntityTypeRequest(ref UpdateEntityTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEntityTypeRequest(ref DeleteEntityTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateEntityTypesRequest(ref BatchUpdateEntityTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteEntityTypesRequest(ref BatchDeleteEntityTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateEntitiesRequest(ref BatchCreateEntitiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateEntitiesRequest(ref BatchUpdateEntitiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeleteEntitiesRequest(ref BatchDeleteEntitiesRequest request, ref gaxgrpc::CallSettings settings);

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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
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
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEntityTypeAsync(DeleteEntityTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntityTypeRequest(ref request, ref callSettings);
            return _callDeleteEntityType.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchUpdateEntityTypes</c>.</summary>
        public override lro::OperationsClient BatchUpdateEntityTypesOperationsClient { get; }

        /// <summary>
        /// Updates/Creates multiple entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [BatchUpdateEntityTypesResponse][google.cloud.dialogflow.v2beta1.BatchUpdateEntityTypesResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchUpdateEntityTypesResponse, wkt::Struct> BatchUpdateEntityTypes(BatchUpdateEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateEntityTypesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchUpdateEntityTypesResponse, wkt::Struct>(_callBatchUpdateEntityTypes.Sync(request, callSettings), BatchUpdateEntityTypesOperationsClient);
        }

        /// <summary>
        /// Updates/Creates multiple entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [BatchUpdateEntityTypesResponse][google.cloud.dialogflow.v2beta1.BatchUpdateEntityTypesResponse]
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchUpdateEntityTypesResponse, wkt::Struct>> BatchUpdateEntityTypesAsync(BatchUpdateEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateEntityTypesRequest(ref request, ref callSettings);
            return new lro::Operation<BatchUpdateEntityTypesResponse, wkt::Struct>(await _callBatchUpdateEntityTypes.Async(request, callSettings).ConfigureAwait(false), BatchUpdateEntityTypesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchDeleteEntityTypes</c>.</summary>
        public override lro::OperationsClient BatchDeleteEntityTypesOperationsClient { get; }

        /// <summary>
        /// Deletes entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Struct> BatchDeleteEntityTypes(BatchDeleteEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteEntityTypesRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(_callBatchDeleteEntityTypes.Sync(request, callSettings), BatchDeleteEntityTypesOperationsClient);
        }

        /// <summary>
        /// Deletes entity types in the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntityTypesAsync(BatchDeleteEntityTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteEntityTypesRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(await _callBatchDeleteEntityTypes.Async(request, callSettings).ConfigureAwait(false), BatchDeleteEntityTypesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchCreateEntities</c>.</summary>
        public override lro::OperationsClient BatchCreateEntitiesOperationsClient { get; }

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Struct> BatchCreateEntities(BatchCreateEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(_callBatchCreateEntities.Sync(request, callSettings), BatchCreateEntitiesOperationsClient);
        }

        /// <summary>
        /// Creates multiple new entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchCreateEntitiesAsync(BatchCreateEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(await _callBatchCreateEntities.Async(request, callSettings).ConfigureAwait(false), BatchCreateEntitiesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchUpdateEntities</c>.</summary>
        public override lro::OperationsClient BatchUpdateEntitiesOperationsClient { get; }

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Struct> BatchUpdateEntities(BatchUpdateEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(_callBatchUpdateEntities.Sync(request, callSettings), BatchUpdateEntitiesOperationsClient);
        }

        /// <summary>
        /// Updates or creates multiple entities in the specified entity type. This
        /// method does not affect entities in the entity type that aren't explicitly
        /// specified in the request.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchUpdateEntitiesAsync(BatchUpdateEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(await _callBatchUpdateEntities.Async(request, callSettings).ConfigureAwait(false), BatchUpdateEntitiesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchDeleteEntities</c>.</summary>
        public override lro::OperationsClient BatchDeleteEntitiesOperationsClient { get; }

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Struct> BatchDeleteEntities(BatchDeleteEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(_callBatchDeleteEntities.Sync(request, callSettings), BatchDeleteEntitiesOperationsClient);
        }

        /// <summary>
        /// Deletes entities in the specified entity type.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> BatchDeleteEntitiesAsync(BatchDeleteEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeleteEntitiesRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(await _callBatchDeleteEntities.Async(request, callSettings).ConfigureAwait(false), BatchDeleteEntitiesOperationsClient);
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
