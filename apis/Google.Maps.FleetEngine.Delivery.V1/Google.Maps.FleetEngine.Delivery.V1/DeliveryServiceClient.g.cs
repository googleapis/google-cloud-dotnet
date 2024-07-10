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

namespace Google.Maps.FleetEngine.Delivery.V1
{
    /// <summary>Settings for <see cref="DeliveryServiceClient"/> instances.</summary>
    public sealed partial class DeliveryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DeliveryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DeliveryServiceSettings"/>.</returns>
        public static DeliveryServiceSettings GetDefault() => new DeliveryServiceSettings();

        /// <summary>Constructs a new <see cref="DeliveryServiceSettings"/> object with default settings.</summary>
        public DeliveryServiceSettings()
        {
        }

        private DeliveryServiceSettings(DeliveryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDeliveryVehicleSettings = existing.CreateDeliveryVehicleSettings;
            GetDeliveryVehicleSettings = existing.GetDeliveryVehicleSettings;
            UpdateDeliveryVehicleSettings = existing.UpdateDeliveryVehicleSettings;
            BatchCreateTasksSettings = existing.BatchCreateTasksSettings;
            CreateTaskSettings = existing.CreateTaskSettings;
            GetTaskSettings = existing.GetTaskSettings;
            UpdateTaskSettings = existing.UpdateTaskSettings;
            ListTasksSettings = existing.ListTasksSettings;
            GetTaskTrackingInfoSettings = existing.GetTaskTrackingInfoSettings;
            ListDeliveryVehiclesSettings = existing.ListDeliveryVehiclesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DeliveryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeliveryServiceClient.CreateDeliveryVehicle</c> and <c>DeliveryServiceClient.CreateDeliveryVehicleAsync</c>
        /// .
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
        public gaxgrpc::CallSettings CreateDeliveryVehicleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeliveryServiceClient.GetDeliveryVehicle</c> and <c>DeliveryServiceClient.GetDeliveryVehicleAsync</c>.
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
        public gaxgrpc::CallSettings GetDeliveryVehicleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeliveryServiceClient.UpdateDeliveryVehicle</c> and <c>DeliveryServiceClient.UpdateDeliveryVehicleAsync</c>
        /// .
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
        public gaxgrpc::CallSettings UpdateDeliveryVehicleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeliveryServiceClient.BatchCreateTasks</c> and <c>DeliveryServiceClient.BatchCreateTasksAsync</c>.
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
        public gaxgrpc::CallSettings BatchCreateTasksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeliveryServiceClient.CreateTask</c> and <c>DeliveryServiceClient.CreateTaskAsync</c>.
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
        public gaxgrpc::CallSettings CreateTaskSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeliveryServiceClient.GetTask</c> and <c>DeliveryServiceClient.GetTaskAsync</c>.
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
        public gaxgrpc::CallSettings GetTaskSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeliveryServiceClient.UpdateTask</c> and <c>DeliveryServiceClient.UpdateTaskAsync</c>.
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
        public gaxgrpc::CallSettings UpdateTaskSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeliveryServiceClient.ListTasks</c> and <c>DeliveryServiceClient.ListTasksAsync</c>.
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
        public gaxgrpc::CallSettings ListTasksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeliveryServiceClient.GetTaskTrackingInfo</c> and <c>DeliveryServiceClient.GetTaskTrackingInfoAsync</c>.
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
        public gaxgrpc::CallSettings GetTaskTrackingInfoSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeliveryServiceClient.ListDeliveryVehicles</c> and <c>DeliveryServiceClient.ListDeliveryVehiclesAsync</c>
        /// .
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
        public gaxgrpc::CallSettings ListDeliveryVehiclesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DeliveryServiceSettings"/> object.</returns>
        public DeliveryServiceSettings Clone() => new DeliveryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DeliveryServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DeliveryServiceClientBuilder : gaxgrpc::ClientBuilderBase<DeliveryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DeliveryServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DeliveryServiceClientBuilder() : base(DeliveryServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DeliveryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DeliveryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DeliveryServiceClient Build()
        {
            DeliveryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DeliveryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DeliveryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DeliveryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DeliveryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DeliveryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DeliveryServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DeliveryServiceClient.ChannelPool;
    }

    /// <summary>DeliveryService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Last Mile Delivery service.
    /// </remarks>
    public abstract partial class DeliveryServiceClient
    {
        /// <summary>
        /// The default endpoint for the DeliveryService service, which is a host of "fleetengine.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "fleetengine.googleapis.com:443";

        /// <summary>The default DeliveryService scopes.</summary>
        /// <remarks>
        /// The default DeliveryService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DeliveryService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DeliveryServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DeliveryServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DeliveryServiceClient"/>.</returns>
        public static stt::Task<DeliveryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DeliveryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DeliveryServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DeliveryServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DeliveryServiceClient"/>.</returns>
        public static DeliveryServiceClient Create() => new DeliveryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DeliveryServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DeliveryServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DeliveryServiceClient"/>.</returns>
        internal static DeliveryServiceClient Create(grpccore::CallInvoker callInvoker, DeliveryServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DeliveryService.DeliveryServiceClient grpcClient = new DeliveryService.DeliveryServiceClient(callInvoker);
            return new DeliveryServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DeliveryService client</summary>
        public virtual DeliveryService.DeliveryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and returns a new `DeliveryVehicle`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeliveryVehicle CreateDeliveryVehicle(CreateDeliveryVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and returns a new `DeliveryVehicle`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryVehicle> CreateDeliveryVehicleAsync(CreateDeliveryVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and returns a new `DeliveryVehicle`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryVehicle> CreateDeliveryVehicleAsync(CreateDeliveryVehicleRequest request, st::CancellationToken cancellationToken) =>
            CreateDeliveryVehicleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new `DeliveryVehicle`.
        /// </summary>
        /// <param name="parent">
        /// Required. Must be in the format `providers/{provider}`. The provider must
        /// be the Google Cloud Project ID. For example, `sample-cloud-project`.
        /// </param>
        /// <param name="deliveryVehicle">
        /// Required. The `DeliveryVehicle` entity to create. When creating a new
        /// delivery vehicle, you may set the following optional fields:
        /// 
        /// * last_location
        /// * attributes
        /// 
        /// Note: The DeliveryVehicle's `name` field is ignored. All other
        /// DeliveryVehicle fields must not be set; otherwise, an error is returned.
        /// </param>
        /// <param name="deliveryVehicleId">
        /// Required. The Delivery Vehicle ID must be unique and subject to the
        /// following restrictions:
        /// 
        /// * Must be a valid Unicode string.
        /// * Limited to a maximum length of 64 characters.
        /// * Normalized according to [Unicode Normalization Form C]
        /// (http://www.unicode.org/reports/tr15/).
        /// * May not contain any of the following ASCII characters: '/', ':', '?',
        /// ',', or '#'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeliveryVehicle CreateDeliveryVehicle(string parent, DeliveryVehicle deliveryVehicle, string deliveryVehicleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeliveryVehicle(new CreateDeliveryVehicleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeliveryVehicleId = gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryVehicleId, nameof(deliveryVehicleId)),
                DeliveryVehicle = gax::GaxPreconditions.CheckNotNull(deliveryVehicle, nameof(deliveryVehicle)),
            }, callSettings);

        /// <summary>
        /// Creates and returns a new `DeliveryVehicle`.
        /// </summary>
        /// <param name="parent">
        /// Required. Must be in the format `providers/{provider}`. The provider must
        /// be the Google Cloud Project ID. For example, `sample-cloud-project`.
        /// </param>
        /// <param name="deliveryVehicle">
        /// Required. The `DeliveryVehicle` entity to create. When creating a new
        /// delivery vehicle, you may set the following optional fields:
        /// 
        /// * last_location
        /// * attributes
        /// 
        /// Note: The DeliveryVehicle's `name` field is ignored. All other
        /// DeliveryVehicle fields must not be set; otherwise, an error is returned.
        /// </param>
        /// <param name="deliveryVehicleId">
        /// Required. The Delivery Vehicle ID must be unique and subject to the
        /// following restrictions:
        /// 
        /// * Must be a valid Unicode string.
        /// * Limited to a maximum length of 64 characters.
        /// * Normalized according to [Unicode Normalization Form C]
        /// (http://www.unicode.org/reports/tr15/).
        /// * May not contain any of the following ASCII characters: '/', ':', '?',
        /// ',', or '#'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryVehicle> CreateDeliveryVehicleAsync(string parent, DeliveryVehicle deliveryVehicle, string deliveryVehicleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeliveryVehicleAsync(new CreateDeliveryVehicleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeliveryVehicleId = gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryVehicleId, nameof(deliveryVehicleId)),
                DeliveryVehicle = gax::GaxPreconditions.CheckNotNull(deliveryVehicle, nameof(deliveryVehicle)),
            }, callSettings);

        /// <summary>
        /// Creates and returns a new `DeliveryVehicle`.
        /// </summary>
        /// <param name="parent">
        /// Required. Must be in the format `providers/{provider}`. The provider must
        /// be the Google Cloud Project ID. For example, `sample-cloud-project`.
        /// </param>
        /// <param name="deliveryVehicle">
        /// Required. The `DeliveryVehicle` entity to create. When creating a new
        /// delivery vehicle, you may set the following optional fields:
        /// 
        /// * last_location
        /// * attributes
        /// 
        /// Note: The DeliveryVehicle's `name` field is ignored. All other
        /// DeliveryVehicle fields must not be set; otherwise, an error is returned.
        /// </param>
        /// <param name="deliveryVehicleId">
        /// Required. The Delivery Vehicle ID must be unique and subject to the
        /// following restrictions:
        /// 
        /// * Must be a valid Unicode string.
        /// * Limited to a maximum length of 64 characters.
        /// * Normalized according to [Unicode Normalization Form C]
        /// (http://www.unicode.org/reports/tr15/).
        /// * May not contain any of the following ASCII characters: '/', ':', '?',
        /// ',', or '#'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryVehicle> CreateDeliveryVehicleAsync(string parent, DeliveryVehicle deliveryVehicle, string deliveryVehicleId, st::CancellationToken cancellationToken) =>
            CreateDeliveryVehicleAsync(parent, deliveryVehicle, deliveryVehicleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified `DeliveryVehicle` instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeliveryVehicle GetDeliveryVehicle(GetDeliveryVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified `DeliveryVehicle` instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryVehicle> GetDeliveryVehicleAsync(GetDeliveryVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified `DeliveryVehicle` instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryVehicle> GetDeliveryVehicleAsync(GetDeliveryVehicleRequest request, st::CancellationToken cancellationToken) =>
            GetDeliveryVehicleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified `DeliveryVehicle` instance.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/deliveryVehicles/{delivery_vehicle}`.
        /// The `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeliveryVehicle GetDeliveryVehicle(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeliveryVehicle(new GetDeliveryVehicleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified `DeliveryVehicle` instance.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/deliveryVehicles/{delivery_vehicle}`.
        /// The `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryVehicle> GetDeliveryVehicleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeliveryVehicleAsync(new GetDeliveryVehicleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified `DeliveryVehicle` instance.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/deliveryVehicles/{delivery_vehicle}`.
        /// The `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryVehicle> GetDeliveryVehicleAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeliveryVehicleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified `DeliveryVehicle` instance.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/deliveryVehicles/{delivery_vehicle}`.
        /// The `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeliveryVehicle GetDeliveryVehicle(DeliveryVehicleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeliveryVehicle(new GetDeliveryVehicleRequest
            {
                DeliveryVehicleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified `DeliveryVehicle` instance.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/deliveryVehicles/{delivery_vehicle}`.
        /// The `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryVehicle> GetDeliveryVehicleAsync(DeliveryVehicleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeliveryVehicleAsync(new GetDeliveryVehicleRequest
            {
                DeliveryVehicleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified `DeliveryVehicle` instance.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/deliveryVehicles/{delivery_vehicle}`.
        /// The `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryVehicle> GetDeliveryVehicleAsync(DeliveryVehicleName name, st::CancellationToken cancellationToken) =>
            GetDeliveryVehicleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes updated `DeliveryVehicle` data to Fleet Engine, and assigns
        /// `Tasks` to the `DeliveryVehicle`. You cannot update the name of the
        /// `DeliveryVehicle`. You *can* update `remaining_vehicle_journey_segments`,
        /// but it must contain all of the `VehicleJourneySegment`s to be persisted on
        /// the `DeliveryVehicle`. The `task_id`s are retrieved from
        /// `remaining_vehicle_journey_segments`, and their corresponding `Tasks` are
        /// assigned to the `DeliveryVehicle` if they have not yet been assigned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeliveryVehicle UpdateDeliveryVehicle(UpdateDeliveryVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes updated `DeliveryVehicle` data to Fleet Engine, and assigns
        /// `Tasks` to the `DeliveryVehicle`. You cannot update the name of the
        /// `DeliveryVehicle`. You *can* update `remaining_vehicle_journey_segments`,
        /// but it must contain all of the `VehicleJourneySegment`s to be persisted on
        /// the `DeliveryVehicle`. The `task_id`s are retrieved from
        /// `remaining_vehicle_journey_segments`, and their corresponding `Tasks` are
        /// assigned to the `DeliveryVehicle` if they have not yet been assigned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryVehicle> UpdateDeliveryVehicleAsync(UpdateDeliveryVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes updated `DeliveryVehicle` data to Fleet Engine, and assigns
        /// `Tasks` to the `DeliveryVehicle`. You cannot update the name of the
        /// `DeliveryVehicle`. You *can* update `remaining_vehicle_journey_segments`,
        /// but it must contain all of the `VehicleJourneySegment`s to be persisted on
        /// the `DeliveryVehicle`. The `task_id`s are retrieved from
        /// `remaining_vehicle_journey_segments`, and their corresponding `Tasks` are
        /// assigned to the `DeliveryVehicle` if they have not yet been assigned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryVehicle> UpdateDeliveryVehicleAsync(UpdateDeliveryVehicleRequest request, st::CancellationToken cancellationToken) =>
            UpdateDeliveryVehicleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes updated `DeliveryVehicle` data to Fleet Engine, and assigns
        /// `Tasks` to the `DeliveryVehicle`. You cannot update the name of the
        /// `DeliveryVehicle`. You *can* update `remaining_vehicle_journey_segments`,
        /// but it must contain all of the `VehicleJourneySegment`s to be persisted on
        /// the `DeliveryVehicle`. The `task_id`s are retrieved from
        /// `remaining_vehicle_journey_segments`, and their corresponding `Tasks` are
        /// assigned to the `DeliveryVehicle` if they have not yet been assigned.
        /// </summary>
        /// <param name="deliveryVehicle">
        /// Required. The `DeliveryVehicle` entity update to apply.
        /// Note: You cannot update the name of the `DeliveryVehicle`.
        /// </param>
        /// <param name="updateMask">
        /// Required. A field mask that indicates which `DeliveryVehicle` fields to
        /// update. Note that the update_mask must contain at least one field.
        /// 
        /// This is a comma-separated list of fully qualified names of fields. Example:
        /// `"remaining_vehicle_journey_segments"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeliveryVehicle UpdateDeliveryVehicle(DeliveryVehicle deliveryVehicle, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeliveryVehicle(new UpdateDeliveryVehicleRequest
            {
                DeliveryVehicle = gax::GaxPreconditions.CheckNotNull(deliveryVehicle, nameof(deliveryVehicle)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Writes updated `DeliveryVehicle` data to Fleet Engine, and assigns
        /// `Tasks` to the `DeliveryVehicle`. You cannot update the name of the
        /// `DeliveryVehicle`. You *can* update `remaining_vehicle_journey_segments`,
        /// but it must contain all of the `VehicleJourneySegment`s to be persisted on
        /// the `DeliveryVehicle`. The `task_id`s are retrieved from
        /// `remaining_vehicle_journey_segments`, and their corresponding `Tasks` are
        /// assigned to the `DeliveryVehicle` if they have not yet been assigned.
        /// </summary>
        /// <param name="deliveryVehicle">
        /// Required. The `DeliveryVehicle` entity update to apply.
        /// Note: You cannot update the name of the `DeliveryVehicle`.
        /// </param>
        /// <param name="updateMask">
        /// Required. A field mask that indicates which `DeliveryVehicle` fields to
        /// update. Note that the update_mask must contain at least one field.
        /// 
        /// This is a comma-separated list of fully qualified names of fields. Example:
        /// `"remaining_vehicle_journey_segments"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryVehicle> UpdateDeliveryVehicleAsync(DeliveryVehicle deliveryVehicle, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeliveryVehicleAsync(new UpdateDeliveryVehicleRequest
            {
                DeliveryVehicle = gax::GaxPreconditions.CheckNotNull(deliveryVehicle, nameof(deliveryVehicle)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Writes updated `DeliveryVehicle` data to Fleet Engine, and assigns
        /// `Tasks` to the `DeliveryVehicle`. You cannot update the name of the
        /// `DeliveryVehicle`. You *can* update `remaining_vehicle_journey_segments`,
        /// but it must contain all of the `VehicleJourneySegment`s to be persisted on
        /// the `DeliveryVehicle`. The `task_id`s are retrieved from
        /// `remaining_vehicle_journey_segments`, and their corresponding `Tasks` are
        /// assigned to the `DeliveryVehicle` if they have not yet been assigned.
        /// </summary>
        /// <param name="deliveryVehicle">
        /// Required. The `DeliveryVehicle` entity update to apply.
        /// Note: You cannot update the name of the `DeliveryVehicle`.
        /// </param>
        /// <param name="updateMask">
        /// Required. A field mask that indicates which `DeliveryVehicle` fields to
        /// update. Note that the update_mask must contain at least one field.
        /// 
        /// This is a comma-separated list of fully qualified names of fields. Example:
        /// `"remaining_vehicle_journey_segments"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryVehicle> UpdateDeliveryVehicleAsync(DeliveryVehicle deliveryVehicle, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDeliveryVehicleAsync(deliveryVehicle, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a batch of new `Task` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateTasksResponse BatchCreateTasks(BatchCreateTasksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and returns a batch of new `Task` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTasksResponse> BatchCreateTasksAsync(BatchCreateTasksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and returns a batch of new `Task` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateTasksResponse> BatchCreateTasksAsync(BatchCreateTasksRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateTasksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new `Task` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task CreateTask(CreateTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and returns a new `Task` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> CreateTaskAsync(CreateTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and returns a new `Task` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> CreateTaskAsync(CreateTaskRequest request, st::CancellationToken cancellationToken) =>
            CreateTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and returns a new `Task` object.
        /// </summary>
        /// <param name="parent">
        /// Required. Must be in the format `providers/{provider}`. The `provider` must
        /// be the Google Cloud Project ID. For example, `sample-cloud-project`.
        /// </param>
        /// <param name="task">
        /// Required. The Task entity to create.
        /// When creating a Task, the following fields are required:
        /// 
        /// * `type`
        /// * `state` (must be set to `OPEN`)
        /// * `tracking_id` (must not be set for `UNAVAILABLE` or `SCHEDULED_STOP`
        /// tasks, but required for all other task types)
        /// * `planned_location` (optional for `UNAVAILABLE` tasks)
        /// * `task_duration`
        /// 
        /// Note: The Task's `name` field is ignored. All other Task fields must not be
        /// set; otherwise, an error is returned.
        /// </param>
        /// <param name="taskId">
        /// Required. The Task ID must be unique, but it should be not a shipment
        /// tracking ID. To store a shipment tracking ID, use the `tracking_id` field.
        /// Note that multiple tasks can have the same `tracking_id`. Task IDs are
        /// subject to the following restrictions:
        /// 
        /// * Must be a valid Unicode string.
        /// * Limited to a maximum length of 64 characters.
        /// * Normalized according to [Unicode Normalization Form C]
        /// (http://www.unicode.org/reports/tr15/).
        /// * May not contain any of the following ASCII characters: '/', ':', '?',
        /// ',', or '#'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task CreateTask(string parent, Task task, string taskId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTask(new CreateTaskRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TaskId = gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)),
                Task = gax::GaxPreconditions.CheckNotNull(task, nameof(task)),
            }, callSettings);

        /// <summary>
        /// Creates and returns a new `Task` object.
        /// </summary>
        /// <param name="parent">
        /// Required. Must be in the format `providers/{provider}`. The `provider` must
        /// be the Google Cloud Project ID. For example, `sample-cloud-project`.
        /// </param>
        /// <param name="task">
        /// Required. The Task entity to create.
        /// When creating a Task, the following fields are required:
        /// 
        /// * `type`
        /// * `state` (must be set to `OPEN`)
        /// * `tracking_id` (must not be set for `UNAVAILABLE` or `SCHEDULED_STOP`
        /// tasks, but required for all other task types)
        /// * `planned_location` (optional for `UNAVAILABLE` tasks)
        /// * `task_duration`
        /// 
        /// Note: The Task's `name` field is ignored. All other Task fields must not be
        /// set; otherwise, an error is returned.
        /// </param>
        /// <param name="taskId">
        /// Required. The Task ID must be unique, but it should be not a shipment
        /// tracking ID. To store a shipment tracking ID, use the `tracking_id` field.
        /// Note that multiple tasks can have the same `tracking_id`. Task IDs are
        /// subject to the following restrictions:
        /// 
        /// * Must be a valid Unicode string.
        /// * Limited to a maximum length of 64 characters.
        /// * Normalized according to [Unicode Normalization Form C]
        /// (http://www.unicode.org/reports/tr15/).
        /// * May not contain any of the following ASCII characters: '/', ':', '?',
        /// ',', or '#'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> CreateTaskAsync(string parent, Task task, string taskId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTaskAsync(new CreateTaskRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TaskId = gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)),
                Task = gax::GaxPreconditions.CheckNotNull(task, nameof(task)),
            }, callSettings);

        /// <summary>
        /// Creates and returns a new `Task` object.
        /// </summary>
        /// <param name="parent">
        /// Required. Must be in the format `providers/{provider}`. The `provider` must
        /// be the Google Cloud Project ID. For example, `sample-cloud-project`.
        /// </param>
        /// <param name="task">
        /// Required. The Task entity to create.
        /// When creating a Task, the following fields are required:
        /// 
        /// * `type`
        /// * `state` (must be set to `OPEN`)
        /// * `tracking_id` (must not be set for `UNAVAILABLE` or `SCHEDULED_STOP`
        /// tasks, but required for all other task types)
        /// * `planned_location` (optional for `UNAVAILABLE` tasks)
        /// * `task_duration`
        /// 
        /// Note: The Task's `name` field is ignored. All other Task fields must not be
        /// set; otherwise, an error is returned.
        /// </param>
        /// <param name="taskId">
        /// Required. The Task ID must be unique, but it should be not a shipment
        /// tracking ID. To store a shipment tracking ID, use the `tracking_id` field.
        /// Note that multiple tasks can have the same `tracking_id`. Task IDs are
        /// subject to the following restrictions:
        /// 
        /// * Must be a valid Unicode string.
        /// * Limited to a maximum length of 64 characters.
        /// * Normalized according to [Unicode Normalization Form C]
        /// (http://www.unicode.org/reports/tr15/).
        /// * May not contain any of the following ASCII characters: '/', ':', '?',
        /// ',', or '#'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> CreateTaskAsync(string parent, Task task, string taskId, st::CancellationToken cancellationToken) =>
            CreateTaskAsync(parent, task, taskId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a `Task`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a `Task`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a `Task`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(GetTaskRequest request, st::CancellationToken cancellationToken) =>
            GetTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a `Task`.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format `providers/{provider}/tasks/{task}`. The
        /// `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTask(new GetTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a `Task`.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format `providers/{provider}/tasks/{task}`. The
        /// `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaskAsync(new GetTaskRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a `Task`.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format `providers/{provider}/tasks/{task}`. The
        /// `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(string name, st::CancellationToken cancellationToken) =>
            GetTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a `Task`.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format `providers/{provider}/tasks/{task}`. The
        /// `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task GetTask(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTask(new GetTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a `Task`.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format `providers/{provider}/tasks/{task}`. The
        /// `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(TaskName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaskAsync(new GetTaskRequest
            {
                TaskName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a `Task`.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format `providers/{provider}/tasks/{task}`. The
        /// `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> GetTaskAsync(TaskName name, st::CancellationToken cancellationToken) =>
            GetTaskAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates `Task` data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task UpdateTask(UpdateTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates `Task` data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> UpdateTaskAsync(UpdateTaskRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates `Task` data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> UpdateTaskAsync(UpdateTaskRequest request, st::CancellationToken cancellationToken) =>
            UpdateTaskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates `Task` data.
        /// </summary>
        /// <param name="task">
        /// Required. The Task associated with the update.
        /// The following fields are maintained by Fleet Engine. Do not update
        /// them using `Task.update`.
        /// 
        /// * `last_location`.
        /// * `last_location_snappable`.
        /// * `name`.
        /// * `remaining_vehicle_journey_segments`.
        /// * `task_outcome_location_source`.
        /// 
        /// Note: You cannot change the value of `task_outcome` once you set it.
        /// 
        /// If the Task has been assigned to a delivery vehicle, then don't set the
        /// Task state to CLOSED using `Task.update`. Instead, remove the `VehicleStop`
        /// that contains the Task from the delivery vehicle, which automatically sets
        /// the Task state to CLOSED.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask that indicates which Task fields to update.
        /// Note: The `update_mask` must contain at least one field.
        /// 
        /// This is a comma-separated list of fully qualified names of fields. Example:
        /// `"task_outcome,task_outcome_time,task_outcome_location"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Task UpdateTask(Task task, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTask(new UpdateTaskRequest
            {
                Task = gax::GaxPreconditions.CheckNotNull(task, nameof(task)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates `Task` data.
        /// </summary>
        /// <param name="task">
        /// Required. The Task associated with the update.
        /// The following fields are maintained by Fleet Engine. Do not update
        /// them using `Task.update`.
        /// 
        /// * `last_location`.
        /// * `last_location_snappable`.
        /// * `name`.
        /// * `remaining_vehicle_journey_segments`.
        /// * `task_outcome_location_source`.
        /// 
        /// Note: You cannot change the value of `task_outcome` once you set it.
        /// 
        /// If the Task has been assigned to a delivery vehicle, then don't set the
        /// Task state to CLOSED using `Task.update`. Instead, remove the `VehicleStop`
        /// that contains the Task from the delivery vehicle, which automatically sets
        /// the Task state to CLOSED.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask that indicates which Task fields to update.
        /// Note: The `update_mask` must contain at least one field.
        /// 
        /// This is a comma-separated list of fully qualified names of fields. Example:
        /// `"task_outcome,task_outcome_time,task_outcome_location"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> UpdateTaskAsync(Task task, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTaskAsync(new UpdateTaskRequest
            {
                Task = gax::GaxPreconditions.CheckNotNull(task, nameof(task)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates `Task` data.
        /// </summary>
        /// <param name="task">
        /// Required. The Task associated with the update.
        /// The following fields are maintained by Fleet Engine. Do not update
        /// them using `Task.update`.
        /// 
        /// * `last_location`.
        /// * `last_location_snappable`.
        /// * `name`.
        /// * `remaining_vehicle_journey_segments`.
        /// * `task_outcome_location_source`.
        /// 
        /// Note: You cannot change the value of `task_outcome` once you set it.
        /// 
        /// If the Task has been assigned to a delivery vehicle, then don't set the
        /// Task state to CLOSED using `Task.update`. Instead, remove the `VehicleStop`
        /// that contains the Task from the delivery vehicle, which automatically sets
        /// the Task state to CLOSED.
        /// </param>
        /// <param name="updateMask">
        /// Required. The field mask that indicates which Task fields to update.
        /// Note: The `update_mask` must contain at least one field.
        /// 
        /// This is a comma-separated list of fully qualified names of fields. Example:
        /// `"task_outcome,task_outcome_time,task_outcome_location"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Task> UpdateTaskAsync(Task task, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTaskAsync(task, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets all `Task`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets all `Task`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets all `Task`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Must be in the format `providers/{provider}`.
        /// The `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
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
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTasks(new ListTasksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets all `Task`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Must be in the format `providers/{provider}`.
        /// The `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTasksAsync(new ListTasksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets all `Task`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Must be in the format `providers/{provider}`.
        /// The `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
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
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(ProviderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTasks(new ListTasksRequest
            {
                ParentAsProviderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets all `Task`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Must be in the format `providers/{provider}`.
        /// The `provider` must be the Google Cloud Project ID. For example,
        /// `sample-cloud-project`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(ProviderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTasksAsync(new ListTasksRequest
            {
                ParentAsProviderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the specified `TaskTrackingInfo` instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TaskTrackingInfo GetTaskTrackingInfo(GetTaskTrackingInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified `TaskTrackingInfo` instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TaskTrackingInfo> GetTaskTrackingInfoAsync(GetTaskTrackingInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified `TaskTrackingInfo` instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TaskTrackingInfo> GetTaskTrackingInfoAsync(GetTaskTrackingInfoRequest request, st::CancellationToken cancellationToken) =>
            GetTaskTrackingInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified `TaskTrackingInfo` instance.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/taskTrackingInfo/{tracking_id}`. The `provider`
        /// must be the Google Cloud Project ID, and the `tracking_id` must be the
        /// tracking ID associated with the task. An example name can be
        /// `providers/sample-cloud-project/taskTrackingInfo/sample-tracking-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TaskTrackingInfo GetTaskTrackingInfo(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaskTrackingInfo(new GetTaskTrackingInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified `TaskTrackingInfo` instance.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/taskTrackingInfo/{tracking_id}`. The `provider`
        /// must be the Google Cloud Project ID, and the `tracking_id` must be the
        /// tracking ID associated with the task. An example name can be
        /// `providers/sample-cloud-project/taskTrackingInfo/sample-tracking-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TaskTrackingInfo> GetTaskTrackingInfoAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaskTrackingInfoAsync(new GetTaskTrackingInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified `TaskTrackingInfo` instance.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/taskTrackingInfo/{tracking_id}`. The `provider`
        /// must be the Google Cloud Project ID, and the `tracking_id` must be the
        /// tracking ID associated with the task. An example name can be
        /// `providers/sample-cloud-project/taskTrackingInfo/sample-tracking-id`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TaskTrackingInfo> GetTaskTrackingInfoAsync(string name, st::CancellationToken cancellationToken) =>
            GetTaskTrackingInfoAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified `TaskTrackingInfo` instance.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/taskTrackingInfo/{tracking_id}`. The `provider`
        /// must be the Google Cloud Project ID, and the `tracking_id` must be the
        /// tracking ID associated with the task. An example name can be
        /// `providers/sample-cloud-project/taskTrackingInfo/sample-tracking-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TaskTrackingInfo GetTaskTrackingInfo(TaskTrackingInfoName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaskTrackingInfo(new GetTaskTrackingInfoRequest
            {
                TaskTrackingInfoName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified `TaskTrackingInfo` instance.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/taskTrackingInfo/{tracking_id}`. The `provider`
        /// must be the Google Cloud Project ID, and the `tracking_id` must be the
        /// tracking ID associated with the task. An example name can be
        /// `providers/sample-cloud-project/taskTrackingInfo/sample-tracking-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TaskTrackingInfo> GetTaskTrackingInfoAsync(TaskTrackingInfoName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTaskTrackingInfoAsync(new GetTaskTrackingInfoRequest
            {
                TaskTrackingInfoName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified `TaskTrackingInfo` instance.
        /// </summary>
        /// <param name="name">
        /// Required. Must be in the format
        /// `providers/{provider}/taskTrackingInfo/{tracking_id}`. The `provider`
        /// must be the Google Cloud Project ID, and the `tracking_id` must be the
        /// tracking ID associated with the task. An example name can be
        /// `providers/sample-cloud-project/taskTrackingInfo/sample-tracking-id`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TaskTrackingInfo> GetTaskTrackingInfoAsync(TaskTrackingInfoName name, st::CancellationToken cancellationToken) =>
            GetTaskTrackingInfoAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets all `DeliveryVehicle`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeliveryVehicle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeliveryVehiclesResponse, DeliveryVehicle> ListDeliveryVehicles(ListDeliveryVehiclesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets all `DeliveryVehicle`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeliveryVehicle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeliveryVehiclesResponse, DeliveryVehicle> ListDeliveryVehiclesAsync(ListDeliveryVehiclesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets all `DeliveryVehicle`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Must be in the format `providers/{provider}`.
        /// The `provider` must be the Google Cloud Project ID.
        /// For example, `sample-cloud-project`.
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
        /// <returns>A pageable sequence of <see cref="DeliveryVehicle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeliveryVehiclesResponse, DeliveryVehicle> ListDeliveryVehicles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeliveryVehicles(new ListDeliveryVehiclesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets all `DeliveryVehicle`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Must be in the format `providers/{provider}`.
        /// The `provider` must be the Google Cloud Project ID.
        /// For example, `sample-cloud-project`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeliveryVehicle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeliveryVehiclesResponse, DeliveryVehicle> ListDeliveryVehiclesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeliveryVehiclesAsync(new ListDeliveryVehiclesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets all `DeliveryVehicle`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Must be in the format `providers/{provider}`.
        /// The `provider` must be the Google Cloud Project ID.
        /// For example, `sample-cloud-project`.
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
        /// <returns>A pageable sequence of <see cref="DeliveryVehicle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeliveryVehiclesResponse, DeliveryVehicle> ListDeliveryVehicles(ProviderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeliveryVehicles(new ListDeliveryVehiclesRequest
            {
                ParentAsProviderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets all `DeliveryVehicle`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="parent">
        /// Required. Must be in the format `providers/{provider}`.
        /// The `provider` must be the Google Cloud Project ID.
        /// For example, `sample-cloud-project`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeliveryVehicle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeliveryVehiclesResponse, DeliveryVehicle> ListDeliveryVehiclesAsync(ProviderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeliveryVehiclesAsync(new ListDeliveryVehiclesRequest
            {
                ParentAsProviderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>DeliveryService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Last Mile Delivery service.
    /// </remarks>
    public sealed partial class DeliveryServiceClientImpl : DeliveryServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDeliveryVehicleRequest, DeliveryVehicle> _callCreateDeliveryVehicle;

        private readonly gaxgrpc::ApiCall<GetDeliveryVehicleRequest, DeliveryVehicle> _callGetDeliveryVehicle;

        private readonly gaxgrpc::ApiCall<UpdateDeliveryVehicleRequest, DeliveryVehicle> _callUpdateDeliveryVehicle;

        private readonly gaxgrpc::ApiCall<BatchCreateTasksRequest, BatchCreateTasksResponse> _callBatchCreateTasks;

        private readonly gaxgrpc::ApiCall<CreateTaskRequest, Task> _callCreateTask;

        private readonly gaxgrpc::ApiCall<GetTaskRequest, Task> _callGetTask;

        private readonly gaxgrpc::ApiCall<UpdateTaskRequest, Task> _callUpdateTask;

        private readonly gaxgrpc::ApiCall<ListTasksRequest, ListTasksResponse> _callListTasks;

        private readonly gaxgrpc::ApiCall<GetTaskTrackingInfoRequest, TaskTrackingInfo> _callGetTaskTrackingInfo;

        private readonly gaxgrpc::ApiCall<ListDeliveryVehiclesRequest, ListDeliveryVehiclesResponse> _callListDeliveryVehicles;

        /// <summary>
        /// Constructs a client wrapper for the DeliveryService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DeliveryServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DeliveryServiceClientImpl(DeliveryService.DeliveryServiceClient grpcClient, DeliveryServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DeliveryServiceSettings effectiveSettings = settings ?? DeliveryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateDeliveryVehicle = clientHelper.BuildApiCall<CreateDeliveryVehicleRequest, DeliveryVehicle>("CreateDeliveryVehicle", grpcClient.CreateDeliveryVehicleAsync, grpcClient.CreateDeliveryVehicle, effectiveSettings.CreateDeliveryVehicleSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CreateDeliveryVehicleRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callCreateDeliveryVehicle);
            Modify_CreateDeliveryVehicleApiCall(ref _callCreateDeliveryVehicle);
            _callGetDeliveryVehicle = clientHelper.BuildApiCall<GetDeliveryVehicleRequest, DeliveryVehicle>("GetDeliveryVehicle", grpcClient.GetDeliveryVehicleAsync, grpcClient.GetDeliveryVehicle, effectiveSettings.GetDeliveryVehicleSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetDeliveryVehicleRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Name));
            Modify_ApiCall(ref _callGetDeliveryVehicle);
            Modify_GetDeliveryVehicleApiCall(ref _callGetDeliveryVehicle);
            _callUpdateDeliveryVehicle = clientHelper.BuildApiCall<UpdateDeliveryVehicleRequest, DeliveryVehicle>("UpdateDeliveryVehicle", grpcClient.UpdateDeliveryVehicleAsync, grpcClient.UpdateDeliveryVehicle, effectiveSettings.UpdateDeliveryVehicleSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<UpdateDeliveryVehicleRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.DeliveryVehicle?.Name));
            Modify_ApiCall(ref _callUpdateDeliveryVehicle);
            Modify_UpdateDeliveryVehicleApiCall(ref _callUpdateDeliveryVehicle);
            _callBatchCreateTasks = clientHelper.BuildApiCall<BatchCreateTasksRequest, BatchCreateTasksResponse>("BatchCreateTasks", grpcClient.BatchCreateTasksAsync, grpcClient.BatchCreateTasks, effectiveSettings.BatchCreateTasksSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<BatchCreateTasksRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callBatchCreateTasks);
            Modify_BatchCreateTasksApiCall(ref _callBatchCreateTasks);
            _callCreateTask = clientHelper.BuildApiCall<CreateTaskRequest, Task>("CreateTask", grpcClient.CreateTaskAsync, grpcClient.CreateTask, effectiveSettings.CreateTaskSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CreateTaskRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callCreateTask);
            Modify_CreateTaskApiCall(ref _callCreateTask);
            _callGetTask = clientHelper.BuildApiCall<GetTaskRequest, Task>("GetTask", grpcClient.GetTaskAsync, grpcClient.GetTask, effectiveSettings.GetTaskSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetTaskRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Name));
            Modify_ApiCall(ref _callGetTask);
            Modify_GetTaskApiCall(ref _callGetTask);
            _callUpdateTask = clientHelper.BuildApiCall<UpdateTaskRequest, Task>("UpdateTask", grpcClient.UpdateTaskAsync, grpcClient.UpdateTask, effectiveSettings.UpdateTaskSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<UpdateTaskRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Task?.Name));
            Modify_ApiCall(ref _callUpdateTask);
            Modify_UpdateTaskApiCall(ref _callUpdateTask);
            _callListTasks = clientHelper.BuildApiCall<ListTasksRequest, ListTasksResponse>("ListTasks", grpcClient.ListTasksAsync, grpcClient.ListTasks, effectiveSettings.ListTasksSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ListTasksRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callListTasks);
            Modify_ListTasksApiCall(ref _callListTasks);
            _callGetTaskTrackingInfo = clientHelper.BuildApiCall<GetTaskTrackingInfoRequest, TaskTrackingInfo>("GetTaskTrackingInfo", grpcClient.GetTaskTrackingInfoAsync, grpcClient.GetTaskTrackingInfo, effectiveSettings.GetTaskTrackingInfoSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetTaskTrackingInfoRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Name));
            Modify_ApiCall(ref _callGetTaskTrackingInfo);
            Modify_GetTaskTrackingInfoApiCall(ref _callGetTaskTrackingInfo);
            _callListDeliveryVehicles = clientHelper.BuildApiCall<ListDeliveryVehiclesRequest, ListDeliveryVehiclesResponse>("ListDeliveryVehicles", grpcClient.ListDeliveryVehiclesAsync, grpcClient.ListDeliveryVehicles, effectiveSettings.ListDeliveryVehiclesSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ListDeliveryVehiclesRequest>().WithExtractedParameter("provider_id", "^(providers/[^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callListDeliveryVehicles);
            Modify_ListDeliveryVehiclesApiCall(ref _callListDeliveryVehicles);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDeliveryVehicleApiCall(ref gaxgrpc::ApiCall<CreateDeliveryVehicleRequest, DeliveryVehicle> call);

        partial void Modify_GetDeliveryVehicleApiCall(ref gaxgrpc::ApiCall<GetDeliveryVehicleRequest, DeliveryVehicle> call);

        partial void Modify_UpdateDeliveryVehicleApiCall(ref gaxgrpc::ApiCall<UpdateDeliveryVehicleRequest, DeliveryVehicle> call);

        partial void Modify_BatchCreateTasksApiCall(ref gaxgrpc::ApiCall<BatchCreateTasksRequest, BatchCreateTasksResponse> call);

        partial void Modify_CreateTaskApiCall(ref gaxgrpc::ApiCall<CreateTaskRequest, Task> call);

        partial void Modify_GetTaskApiCall(ref gaxgrpc::ApiCall<GetTaskRequest, Task> call);

        partial void Modify_UpdateTaskApiCall(ref gaxgrpc::ApiCall<UpdateTaskRequest, Task> call);

        partial void Modify_ListTasksApiCall(ref gaxgrpc::ApiCall<ListTasksRequest, ListTasksResponse> call);

        partial void Modify_GetTaskTrackingInfoApiCall(ref gaxgrpc::ApiCall<GetTaskTrackingInfoRequest, TaskTrackingInfo> call);

        partial void Modify_ListDeliveryVehiclesApiCall(ref gaxgrpc::ApiCall<ListDeliveryVehiclesRequest, ListDeliveryVehiclesResponse> call);

        partial void OnConstruction(DeliveryService.DeliveryServiceClient grpcClient, DeliveryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DeliveryService client</summary>
        public override DeliveryService.DeliveryServiceClient GrpcClient { get; }

        partial void Modify_CreateDeliveryVehicleRequest(ref CreateDeliveryVehicleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeliveryVehicleRequest(ref GetDeliveryVehicleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDeliveryVehicleRequest(ref UpdateDeliveryVehicleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateTasksRequest(ref BatchCreateTasksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTaskRequest(ref CreateTaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTaskRequest(ref GetTaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTaskRequest(ref UpdateTaskRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTasksRequest(ref ListTasksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTaskTrackingInfoRequest(ref GetTaskTrackingInfoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeliveryVehiclesRequest(ref ListDeliveryVehiclesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates and returns a new `DeliveryVehicle`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeliveryVehicle CreateDeliveryVehicle(CreateDeliveryVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeliveryVehicleRequest(ref request, ref callSettings);
            return _callCreateDeliveryVehicle.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new `DeliveryVehicle`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeliveryVehicle> CreateDeliveryVehicleAsync(CreateDeliveryVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeliveryVehicleRequest(ref request, ref callSettings);
            return _callCreateDeliveryVehicle.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified `DeliveryVehicle` instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeliveryVehicle GetDeliveryVehicle(GetDeliveryVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeliveryVehicleRequest(ref request, ref callSettings);
            return _callGetDeliveryVehicle.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified `DeliveryVehicle` instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeliveryVehicle> GetDeliveryVehicleAsync(GetDeliveryVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeliveryVehicleRequest(ref request, ref callSettings);
            return _callGetDeliveryVehicle.Async(request, callSettings);
        }

        /// <summary>
        /// Writes updated `DeliveryVehicle` data to Fleet Engine, and assigns
        /// `Tasks` to the `DeliveryVehicle`. You cannot update the name of the
        /// `DeliveryVehicle`. You *can* update `remaining_vehicle_journey_segments`,
        /// but it must contain all of the `VehicleJourneySegment`s to be persisted on
        /// the `DeliveryVehicle`. The `task_id`s are retrieved from
        /// `remaining_vehicle_journey_segments`, and their corresponding `Tasks` are
        /// assigned to the `DeliveryVehicle` if they have not yet been assigned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeliveryVehicle UpdateDeliveryVehicle(UpdateDeliveryVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeliveryVehicleRequest(ref request, ref callSettings);
            return _callUpdateDeliveryVehicle.Sync(request, callSettings);
        }

        /// <summary>
        /// Writes updated `DeliveryVehicle` data to Fleet Engine, and assigns
        /// `Tasks` to the `DeliveryVehicle`. You cannot update the name of the
        /// `DeliveryVehicle`. You *can* update `remaining_vehicle_journey_segments`,
        /// but it must contain all of the `VehicleJourneySegment`s to be persisted on
        /// the `DeliveryVehicle`. The `task_id`s are retrieved from
        /// `remaining_vehicle_journey_segments`, and their corresponding `Tasks` are
        /// assigned to the `DeliveryVehicle` if they have not yet been assigned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeliveryVehicle> UpdateDeliveryVehicleAsync(UpdateDeliveryVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeliveryVehicleRequest(ref request, ref callSettings);
            return _callUpdateDeliveryVehicle.Async(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a batch of new `Task` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateTasksResponse BatchCreateTasks(BatchCreateTasksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateTasksRequest(ref request, ref callSettings);
            return _callBatchCreateTasks.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a batch of new `Task` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateTasksResponse> BatchCreateTasksAsync(BatchCreateTasksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateTasksRequest(ref request, ref callSettings);
            return _callBatchCreateTasks.Async(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new `Task` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Task CreateTask(CreateTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTaskRequest(ref request, ref callSettings);
            return _callCreateTask.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates and returns a new `Task` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Task> CreateTaskAsync(CreateTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTaskRequest(ref request, ref callSettings);
            return _callCreateTask.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about a `Task`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Task GetTask(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTaskRequest(ref request, ref callSettings);
            return _callGetTask.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a `Task`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Task> GetTaskAsync(GetTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTaskRequest(ref request, ref callSettings);
            return _callGetTask.Async(request, callSettings);
        }

        /// <summary>
        /// Updates `Task` data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Task UpdateTask(UpdateTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTaskRequest(ref request, ref callSettings);
            return _callUpdateTask.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates `Task` data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Task> UpdateTaskAsync(UpdateTaskRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTaskRequest(ref request, ref callSettings);
            return _callUpdateTask.Async(request, callSettings);
        }

        /// <summary>
        /// Gets all `Task`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Task"/> resources.</returns>
        public override gax::PagedEnumerable<ListTasksResponse, Task> ListTasks(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTasksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTasksRequest, ListTasksResponse, Task>(_callListTasks, request, callSettings);
        }

        /// <summary>
        /// Gets all `Task`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Task"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTasksResponse, Task> ListTasksAsync(ListTasksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTasksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTasksRequest, ListTasksResponse, Task>(_callListTasks, request, callSettings);
        }

        /// <summary>
        /// Returns the specified `TaskTrackingInfo` instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TaskTrackingInfo GetTaskTrackingInfo(GetTaskTrackingInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTaskTrackingInfoRequest(ref request, ref callSettings);
            return _callGetTaskTrackingInfo.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified `TaskTrackingInfo` instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TaskTrackingInfo> GetTaskTrackingInfoAsync(GetTaskTrackingInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTaskTrackingInfoRequest(ref request, ref callSettings);
            return _callGetTaskTrackingInfo.Async(request, callSettings);
        }

        /// <summary>
        /// Gets all `DeliveryVehicle`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeliveryVehicle"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeliveryVehiclesResponse, DeliveryVehicle> ListDeliveryVehicles(ListDeliveryVehiclesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeliveryVehiclesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeliveryVehiclesRequest, ListDeliveryVehiclesResponse, DeliveryVehicle>(_callListDeliveryVehicles, request, callSettings);
        }

        /// <summary>
        /// Gets all `DeliveryVehicle`s that meet the specified filtering criteria.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeliveryVehicle"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeliveryVehiclesResponse, DeliveryVehicle> ListDeliveryVehiclesAsync(ListDeliveryVehiclesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeliveryVehiclesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeliveryVehiclesRequest, ListDeliveryVehiclesResponse, DeliveryVehicle>(_callListDeliveryVehicles, request, callSettings);
        }
    }

    public partial class ListTasksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeliveryVehiclesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTasksResponse : gaxgrpc::IPageResponse<Task>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Task> GetEnumerator() => Tasks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDeliveryVehiclesResponse : gaxgrpc::IPageResponse<DeliveryVehicle>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DeliveryVehicle> GetEnumerator() => DeliveryVehicles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
