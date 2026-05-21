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

namespace Google.DevicesAndServices.Health.V4
{
    /// <summary>Settings for <see cref="DataSubscriptionServiceClient"/> instances.</summary>
    public sealed partial class DataSubscriptionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataSubscriptionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataSubscriptionServiceSettings"/>.</returns>
        public static DataSubscriptionServiceSettings GetDefault() => new DataSubscriptionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DataSubscriptionServiceSettings"/> object with default settings.
        /// </summary>
        public DataSubscriptionServiceSettings()
        {
        }

        private DataSubscriptionServiceSettings(DataSubscriptionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSubscriberSettings = existing.CreateSubscriberSettings;
            CreateSubscriberOperationsSettings = existing.CreateSubscriberOperationsSettings.Clone();
            ListSubscribersSettings = existing.ListSubscribersSettings;
            UpdateSubscriberSettings = existing.UpdateSubscriberSettings;
            UpdateSubscriberOperationsSettings = existing.UpdateSubscriberOperationsSettings.Clone();
            DeleteSubscriberSettings = existing.DeleteSubscriberSettings;
            DeleteSubscriberOperationsSettings = existing.DeleteSubscriberOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(DataSubscriptionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSubscriptionServiceClient.CreateSubscriber</c> and
        /// <c>DataSubscriptionServiceClient.CreateSubscriberAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSubscriberSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataSubscriptionServiceClient.CreateSubscriber</c> and
        /// <c>DataSubscriptionServiceClient.CreateSubscriberAsync</c>.
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
        public lro::OperationsSettings CreateSubscriberOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSubscriptionServiceClient.ListSubscribers</c> and
        /// <c>DataSubscriptionServiceClient.ListSubscribersAsync</c>.
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
        public gaxgrpc::CallSettings ListSubscribersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSubscriptionServiceClient.UpdateSubscriber</c> and
        /// <c>DataSubscriptionServiceClient.UpdateSubscriberAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSubscriberSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataSubscriptionServiceClient.UpdateSubscriber</c> and
        /// <c>DataSubscriptionServiceClient.UpdateSubscriberAsync</c>.
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
        public lro::OperationsSettings UpdateSubscriberOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSubscriptionServiceClient.DeleteSubscriber</c> and
        /// <c>DataSubscriptionServiceClient.DeleteSubscriberAsync</c>.
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
        public gaxgrpc::CallSettings DeleteSubscriberSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataSubscriptionServiceClient.DeleteSubscriber</c> and
        /// <c>DataSubscriptionServiceClient.DeleteSubscriberAsync</c>.
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
        public lro::OperationsSettings DeleteSubscriberOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataSubscriptionServiceSettings"/> object.</returns>
        public DataSubscriptionServiceSettings Clone() => new DataSubscriptionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataSubscriptionServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DataSubscriptionServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataSubscriptionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataSubscriptionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataSubscriptionServiceClientBuilder() : base(DataSubscriptionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataSubscriptionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataSubscriptionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataSubscriptionServiceClient Build()
        {
            DataSubscriptionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataSubscriptionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataSubscriptionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataSubscriptionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataSubscriptionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataSubscriptionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataSubscriptionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataSubscriptionServiceClient.ChannelPool;
    }

    /// <summary>DataSubscriptionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Data Subscription Service that allows clients (e.g., Fitbit 3P
    /// applications, internal Fitbit Services) to manage their subscriber endpoints.
    /// This service provides CRUD APIs for subscribers,
    /// and also offers functionalities for subscriber verification and statistics.
    /// </remarks>
    public abstract partial class DataSubscriptionServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataSubscriptionService service, which is a host of "health.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "health.googleapis.com:443";

        /// <summary>The default DataSubscriptionService scopes.</summary>
        /// <remarks>
        /// The default DataSubscriptionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataSubscriptionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataSubscriptionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DataSubscriptionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataSubscriptionServiceClient"/>.</returns>
        public static stt::Task<DataSubscriptionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataSubscriptionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataSubscriptionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DataSubscriptionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataSubscriptionServiceClient"/>.</returns>
        public static DataSubscriptionServiceClient Create() => new DataSubscriptionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataSubscriptionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataSubscriptionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataSubscriptionServiceClient"/>.</returns>
        internal static DataSubscriptionServiceClient Create(grpccore::CallInvoker callInvoker, DataSubscriptionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataSubscriptionService.DataSubscriptionServiceClient grpcClient = new DataSubscriptionService.DataSubscriptionServiceClient(callInvoker);
            return new DataSubscriptionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataSubscriptionService client</summary>
        public virtual DataSubscriptionService.DataSubscriptionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Registers a new subscriber endpoint to receive notifications.
        /// A subscriber represents an application or service that wishes to receive
        /// data change notifications for users who have granted consent.
        /// 
        /// **Endpoint Verification:**
        /// For a subscriber to be successfully created, the provided `endpoint_uri`
        /// must be a valid HTTPS endpoint and must pass an automated verification
        /// check. The backend will send two HTTP POST requests to the `endpoint_uri`:
        /// 
        /// 1.  **Verification with Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json` and
        /// `Authorization` (with the exact value from
        /// `CreateSubscriberPayload.endpoint_authorization.secret`).
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `201 Created`.
        /// 
        /// 2.  **Verification without Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json`. The
        /// `Authorization` header is OMITTED.
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `401 Unauthorized` or `403 Forbidden`.
        /// 
        /// Both tests must pass for the subscriber creation to succeed. If
        /// verification fails, the operation will not be completed and an error will
        /// be returned. This process ensures the endpoint is reachable and correctly
        /// validates the `Authorization` header.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subscriber, CreateSubscriberMetadata> CreateSubscriber(CreateSubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers a new subscriber endpoint to receive notifications.
        /// A subscriber represents an application or service that wishes to receive
        /// data change notifications for users who have granted consent.
        /// 
        /// **Endpoint Verification:**
        /// For a subscriber to be successfully created, the provided `endpoint_uri`
        /// must be a valid HTTPS endpoint and must pass an automated verification
        /// check. The backend will send two HTTP POST requests to the `endpoint_uri`:
        /// 
        /// 1.  **Verification with Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json` and
        /// `Authorization` (with the exact value from
        /// `CreateSubscriberPayload.endpoint_authorization.secret`).
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `201 Created`.
        /// 
        /// 2.  **Verification without Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json`. The
        /// `Authorization` header is OMITTED.
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `401 Unauthorized` or `403 Forbidden`.
        /// 
        /// Both tests must pass for the subscriber creation to succeed. If
        /// verification fails, the operation will not be completed and an error will
        /// be returned. This process ensures the endpoint is reachable and correctly
        /// validates the `Authorization` header.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscriber, CreateSubscriberMetadata>> CreateSubscriberAsync(CreateSubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers a new subscriber endpoint to receive notifications.
        /// A subscriber represents an application or service that wishes to receive
        /// data change notifications for users who have granted consent.
        /// 
        /// **Endpoint Verification:**
        /// For a subscriber to be successfully created, the provided `endpoint_uri`
        /// must be a valid HTTPS endpoint and must pass an automated verification
        /// check. The backend will send two HTTP POST requests to the `endpoint_uri`:
        /// 
        /// 1.  **Verification with Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json` and
        /// `Authorization` (with the exact value from
        /// `CreateSubscriberPayload.endpoint_authorization.secret`).
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `201 Created`.
        /// 
        /// 2.  **Verification without Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json`. The
        /// `Authorization` header is OMITTED.
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `401 Unauthorized` or `403 Forbidden`.
        /// 
        /// Both tests must pass for the subscriber creation to succeed. If
        /// verification fails, the operation will not be completed and an error will
        /// be returned. This process ensures the endpoint is reachable and correctly
        /// validates the `Authorization` header.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscriber, CreateSubscriberMetadata>> CreateSubscriberAsync(CreateSubscriberRequest request, st::CancellationToken cancellationToken) =>
            CreateSubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSubscriber</c>.</summary>
        public virtual lro::OperationsClient CreateSubscriberOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSubscriber</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Subscriber, CreateSubscriberMetadata> PollOnceCreateSubscriber(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Subscriber, CreateSubscriberMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSubscriberOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSubscriber</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Subscriber, CreateSubscriberMetadata>> PollOnceCreateSubscriberAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Subscriber, CreateSubscriberMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSubscriberOperationsClient, callSettings);

        /// <summary>
        /// Registers a new subscriber endpoint to receive notifications.
        /// A subscriber represents an application or service that wishes to receive
        /// data change notifications for users who have granted consent.
        /// 
        /// **Endpoint Verification:**
        /// For a subscriber to be successfully created, the provided `endpoint_uri`
        /// must be a valid HTTPS endpoint and must pass an automated verification
        /// check. The backend will send two HTTP POST requests to the `endpoint_uri`:
        /// 
        /// 1.  **Verification with Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json` and
        /// `Authorization` (with the exact value from
        /// `CreateSubscriberPayload.endpoint_authorization.secret`).
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `201 Created`.
        /// 
        /// 2.  **Verification without Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json`. The
        /// `Authorization` header is OMITTED.
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `401 Unauthorized` or `403 Forbidden`.
        /// 
        /// Both tests must pass for the subscriber creation to succeed. If
        /// verification fails, the operation will not be completed and an error will
        /// be returned. This process ensures the endpoint is reachable and correctly
        /// validates the `Authorization` header.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this subscriber will be created.
        /// Format: projects/{project}
        /// Example: projects/my-project-123
        /// </param>
        /// <param name="subscriber">
        /// Required. The subscriber to create.
        /// </param>
        /// <param name="subscriberId">
        /// Optional. The ID to use for the subscriber, which will become the final
        /// component of the subscriber's resource name.
        /// 
        /// This value should be 4-36 characters, and valid characters
        /// are /[a-z]([a-z0-9-]{2,34}[a-z0-9])/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subscriber, CreateSubscriberMetadata> CreateSubscriber(string parent, CreateSubscriberPayload subscriber, string subscriberId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubscriber(new CreateSubscriberRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Subscriber = gax::GaxPreconditions.CheckNotNull(subscriber, nameof(subscriber)),
                SubscriberId = subscriberId ?? "",
            }, callSettings);

        /// <summary>
        /// Registers a new subscriber endpoint to receive notifications.
        /// A subscriber represents an application or service that wishes to receive
        /// data change notifications for users who have granted consent.
        /// 
        /// **Endpoint Verification:**
        /// For a subscriber to be successfully created, the provided `endpoint_uri`
        /// must be a valid HTTPS endpoint and must pass an automated verification
        /// check. The backend will send two HTTP POST requests to the `endpoint_uri`:
        /// 
        /// 1.  **Verification with Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json` and
        /// `Authorization` (with the exact value from
        /// `CreateSubscriberPayload.endpoint_authorization.secret`).
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `201 Created`.
        /// 
        /// 2.  **Verification without Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json`. The
        /// `Authorization` header is OMITTED.
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `401 Unauthorized` or `403 Forbidden`.
        /// 
        /// Both tests must pass for the subscriber creation to succeed. If
        /// verification fails, the operation will not be completed and an error will
        /// be returned. This process ensures the endpoint is reachable and correctly
        /// validates the `Authorization` header.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this subscriber will be created.
        /// Format: projects/{project}
        /// Example: projects/my-project-123
        /// </param>
        /// <param name="subscriber">
        /// Required. The subscriber to create.
        /// </param>
        /// <param name="subscriberId">
        /// Optional. The ID to use for the subscriber, which will become the final
        /// component of the subscriber's resource name.
        /// 
        /// This value should be 4-36 characters, and valid characters
        /// are /[a-z]([a-z0-9-]{2,34}[a-z0-9])/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscriber, CreateSubscriberMetadata>> CreateSubscriberAsync(string parent, CreateSubscriberPayload subscriber, string subscriberId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubscriberAsync(new CreateSubscriberRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Subscriber = gax::GaxPreconditions.CheckNotNull(subscriber, nameof(subscriber)),
                SubscriberId = subscriberId ?? "",
            }, callSettings);

        /// <summary>
        /// Registers a new subscriber endpoint to receive notifications.
        /// A subscriber represents an application or service that wishes to receive
        /// data change notifications for users who have granted consent.
        /// 
        /// **Endpoint Verification:**
        /// For a subscriber to be successfully created, the provided `endpoint_uri`
        /// must be a valid HTTPS endpoint and must pass an automated verification
        /// check. The backend will send two HTTP POST requests to the `endpoint_uri`:
        /// 
        /// 1.  **Verification with Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json` and
        /// `Authorization` (with the exact value from
        /// `CreateSubscriberPayload.endpoint_authorization.secret`).
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `201 Created`.
        /// 
        /// 2.  **Verification without Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json`. The
        /// `Authorization` header is OMITTED.
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `401 Unauthorized` or `403 Forbidden`.
        /// 
        /// Both tests must pass for the subscriber creation to succeed. If
        /// verification fails, the operation will not be completed and an error will
        /// be returned. This process ensures the endpoint is reachable and correctly
        /// validates the `Authorization` header.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this subscriber will be created.
        /// Format: projects/{project}
        /// Example: projects/my-project-123
        /// </param>
        /// <param name="subscriber">
        /// Required. The subscriber to create.
        /// </param>
        /// <param name="subscriberId">
        /// Optional. The ID to use for the subscriber, which will become the final
        /// component of the subscriber's resource name.
        /// 
        /// This value should be 4-36 characters, and valid characters
        /// are /[a-z]([a-z0-9-]{2,34}[a-z0-9])/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscriber, CreateSubscriberMetadata>> CreateSubscriberAsync(string parent, CreateSubscriberPayload subscriber, string subscriberId, st::CancellationToken cancellationToken) =>
            CreateSubscriberAsync(parent, subscriber, subscriberId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Registers a new subscriber endpoint to receive notifications.
        /// A subscriber represents an application or service that wishes to receive
        /// data change notifications for users who have granted consent.
        /// 
        /// **Endpoint Verification:**
        /// For a subscriber to be successfully created, the provided `endpoint_uri`
        /// must be a valid HTTPS endpoint and must pass an automated verification
        /// check. The backend will send two HTTP POST requests to the `endpoint_uri`:
        /// 
        /// 1.  **Verification with Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json` and
        /// `Authorization` (with the exact value from
        /// `CreateSubscriberPayload.endpoint_authorization.secret`).
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `201 Created`.
        /// 
        /// 2.  **Verification without Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json`. The
        /// `Authorization` header is OMITTED.
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `401 Unauthorized` or `403 Forbidden`.
        /// 
        /// Both tests must pass for the subscriber creation to succeed. If
        /// verification fails, the operation will not be completed and an error will
        /// be returned. This process ensures the endpoint is reachable and correctly
        /// validates the `Authorization` header.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this subscriber will be created.
        /// Format: projects/{project}
        /// Example: projects/my-project-123
        /// </param>
        /// <param name="subscriber">
        /// Required. The subscriber to create.
        /// </param>
        /// <param name="subscriberId">
        /// Optional. The ID to use for the subscriber, which will become the final
        /// component of the subscriber's resource name.
        /// 
        /// This value should be 4-36 characters, and valid characters
        /// are /[a-z]([a-z0-9-]{2,34}[a-z0-9])/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subscriber, CreateSubscriberMetadata> CreateSubscriber(gagr::ProjectName parent, CreateSubscriberPayload subscriber, string subscriberId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubscriber(new CreateSubscriberRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Subscriber = gax::GaxPreconditions.CheckNotNull(subscriber, nameof(subscriber)),
                SubscriberId = subscriberId ?? "",
            }, callSettings);

        /// <summary>
        /// Registers a new subscriber endpoint to receive notifications.
        /// A subscriber represents an application or service that wishes to receive
        /// data change notifications for users who have granted consent.
        /// 
        /// **Endpoint Verification:**
        /// For a subscriber to be successfully created, the provided `endpoint_uri`
        /// must be a valid HTTPS endpoint and must pass an automated verification
        /// check. The backend will send two HTTP POST requests to the `endpoint_uri`:
        /// 
        /// 1.  **Verification with Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json` and
        /// `Authorization` (with the exact value from
        /// `CreateSubscriberPayload.endpoint_authorization.secret`).
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `201 Created`.
        /// 
        /// 2.  **Verification without Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json`. The
        /// `Authorization` header is OMITTED.
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `401 Unauthorized` or `403 Forbidden`.
        /// 
        /// Both tests must pass for the subscriber creation to succeed. If
        /// verification fails, the operation will not be completed and an error will
        /// be returned. This process ensures the endpoint is reachable and correctly
        /// validates the `Authorization` header.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this subscriber will be created.
        /// Format: projects/{project}
        /// Example: projects/my-project-123
        /// </param>
        /// <param name="subscriber">
        /// Required. The subscriber to create.
        /// </param>
        /// <param name="subscriberId">
        /// Optional. The ID to use for the subscriber, which will become the final
        /// component of the subscriber's resource name.
        /// 
        /// This value should be 4-36 characters, and valid characters
        /// are /[a-z]([a-z0-9-]{2,34}[a-z0-9])/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscriber, CreateSubscriberMetadata>> CreateSubscriberAsync(gagr::ProjectName parent, CreateSubscriberPayload subscriber, string subscriberId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubscriberAsync(new CreateSubscriberRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Subscriber = gax::GaxPreconditions.CheckNotNull(subscriber, nameof(subscriber)),
                SubscriberId = subscriberId ?? "",
            }, callSettings);

        /// <summary>
        /// Registers a new subscriber endpoint to receive notifications.
        /// A subscriber represents an application or service that wishes to receive
        /// data change notifications for users who have granted consent.
        /// 
        /// **Endpoint Verification:**
        /// For a subscriber to be successfully created, the provided `endpoint_uri`
        /// must be a valid HTTPS endpoint and must pass an automated verification
        /// check. The backend will send two HTTP POST requests to the `endpoint_uri`:
        /// 
        /// 1.  **Verification with Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json` and
        /// `Authorization` (with the exact value from
        /// `CreateSubscriberPayload.endpoint_authorization.secret`).
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `201 Created`.
        /// 
        /// 2.  **Verification without Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json`. The
        /// `Authorization` header is OMITTED.
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `401 Unauthorized` or `403 Forbidden`.
        /// 
        /// Both tests must pass for the subscriber creation to succeed. If
        /// verification fails, the operation will not be completed and an error will
        /// be returned. This process ensures the endpoint is reachable and correctly
        /// validates the `Authorization` header.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this subscriber will be created.
        /// Format: projects/{project}
        /// Example: projects/my-project-123
        /// </param>
        /// <param name="subscriber">
        /// Required. The subscriber to create.
        /// </param>
        /// <param name="subscriberId">
        /// Optional. The ID to use for the subscriber, which will become the final
        /// component of the subscriber's resource name.
        /// 
        /// This value should be 4-36 characters, and valid characters
        /// are /[a-z]([a-z0-9-]{2,34}[a-z0-9])/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscriber, CreateSubscriberMetadata>> CreateSubscriberAsync(gagr::ProjectName parent, CreateSubscriberPayload subscriber, string subscriberId, st::CancellationToken cancellationToken) =>
            CreateSubscriberAsync(parent, subscriber, subscriberId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all subscribers registered within the owned Google Cloud Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Subscriber"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubscribersResponse, Subscriber> ListSubscribers(ListSubscribersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all subscribers registered within the owned Google Cloud Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Subscriber"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubscribersResponse, Subscriber> ListSubscribersAsync(ListSubscribersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all subscribers registered within the owned Google Cloud Project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of subscribers.
        /// Format: projects/{project}
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
        /// <returns>A pageable sequence of <see cref="Subscriber"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubscribersResponse, Subscriber> ListSubscribers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubscribersRequest request = new ListSubscribersRequest
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
            return ListSubscribers(request, callSettings);
        }

        /// <summary>
        /// Lists all subscribers registered within the owned Google Cloud Project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of subscribers.
        /// Format: projects/{project}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Subscriber"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubscribersResponse, Subscriber> ListSubscribersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubscribersRequest request = new ListSubscribersRequest
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
            return ListSubscribersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all subscribers registered within the owned Google Cloud Project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of subscribers.
        /// Format: projects/{project}
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
        /// <returns>A pageable sequence of <see cref="Subscriber"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubscribersResponse, Subscriber> ListSubscribers(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubscribersRequest request = new ListSubscribersRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSubscribers(request, callSettings);
        }

        /// <summary>
        /// Lists all subscribers registered within the owned Google Cloud Project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of subscribers.
        /// Format: projects/{project}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Subscriber"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubscribersResponse, Subscriber> ListSubscribersAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubscribersRequest request = new ListSubscribersRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSubscribersAsync(request, callSettings);
        }

        /// <summary>
        /// Updates the configuration of an existing subscriber, such as the
        /// endpoint URI or the data types it's interested in.
        /// 
        /// **Endpoint Verification:**
        /// If the `endpoint_uri` or `endpoint_authorization` field is included in the
        /// `update_mask`, the backend will re-verify the endpoint. The verification
        /// process is the same as described in `CreateSubscriber`:
        /// 
        /// 1.  **Verification with Authorization:** POST to the new or existing
        /// `endpoint_uri` with the new or existing `Authorization` secret. Expects
        /// HTTP `201 Created`.
        /// 2.  **Verification without Authorization:** POST to the `endpoint_uri`
        /// without the `Authorization` header. Expects HTTP `401 Unauthorized` or
        /// `403 Forbidden`.
        /// 
        /// Both tests must pass using the potentially updated values for the
        /// subscriber update to succeed. If verification fails, the update will not
        /// be applied, and an error will be returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subscriber, UpdateSubscriberMetadata> UpdateSubscriber(UpdateSubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the configuration of an existing subscriber, such as the
        /// endpoint URI or the data types it's interested in.
        /// 
        /// **Endpoint Verification:**
        /// If the `endpoint_uri` or `endpoint_authorization` field is included in the
        /// `update_mask`, the backend will re-verify the endpoint. The verification
        /// process is the same as described in `CreateSubscriber`:
        /// 
        /// 1.  **Verification with Authorization:** POST to the new or existing
        /// `endpoint_uri` with the new or existing `Authorization` secret. Expects
        /// HTTP `201 Created`.
        /// 2.  **Verification without Authorization:** POST to the `endpoint_uri`
        /// without the `Authorization` header. Expects HTTP `401 Unauthorized` or
        /// `403 Forbidden`.
        /// 
        /// Both tests must pass using the potentially updated values for the
        /// subscriber update to succeed. If verification fails, the update will not
        /// be applied, and an error will be returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscriber, UpdateSubscriberMetadata>> UpdateSubscriberAsync(UpdateSubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the configuration of an existing subscriber, such as the
        /// endpoint URI or the data types it's interested in.
        /// 
        /// **Endpoint Verification:**
        /// If the `endpoint_uri` or `endpoint_authorization` field is included in the
        /// `update_mask`, the backend will re-verify the endpoint. The verification
        /// process is the same as described in `CreateSubscriber`:
        /// 
        /// 1.  **Verification with Authorization:** POST to the new or existing
        /// `endpoint_uri` with the new or existing `Authorization` secret. Expects
        /// HTTP `201 Created`.
        /// 2.  **Verification without Authorization:** POST to the `endpoint_uri`
        /// without the `Authorization` header. Expects HTTP `401 Unauthorized` or
        /// `403 Forbidden`.
        /// 
        /// Both tests must pass using the potentially updated values for the
        /// subscriber update to succeed. If verification fails, the update will not
        /// be applied, and an error will be returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscriber, UpdateSubscriberMetadata>> UpdateSubscriberAsync(UpdateSubscriberRequest request, st::CancellationToken cancellationToken) =>
            UpdateSubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSubscriber</c>.</summary>
        public virtual lro::OperationsClient UpdateSubscriberOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSubscriber</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Subscriber, UpdateSubscriberMetadata> PollOnceUpdateSubscriber(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Subscriber, UpdateSubscriberMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSubscriberOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSubscriber</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Subscriber, UpdateSubscriberMetadata>> PollOnceUpdateSubscriberAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Subscriber, UpdateSubscriberMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSubscriberOperationsClient, callSettings);

        /// <summary>
        /// Updates the configuration of an existing subscriber, such as the
        /// endpoint URI or the data types it's interested in.
        /// 
        /// **Endpoint Verification:**
        /// If the `endpoint_uri` or `endpoint_authorization` field is included in the
        /// `update_mask`, the backend will re-verify the endpoint. The verification
        /// process is the same as described in `CreateSubscriber`:
        /// 
        /// 1.  **Verification with Authorization:** POST to the new or existing
        /// `endpoint_uri` with the new or existing `Authorization` secret. Expects
        /// HTTP `201 Created`.
        /// 2.  **Verification without Authorization:** POST to the `endpoint_uri`
        /// without the `Authorization` header. Expects HTTP `401 Unauthorized` or
        /// `403 Forbidden`.
        /// 
        /// Both tests must pass using the potentially updated values for the
        /// subscriber update to succeed. If verification fails, the update will not
        /// be applied, and an error will be returned.
        /// </summary>
        /// <param name="subscriber">
        /// Required. The subscriber resource to update. Its 'name' field is mapped to
        /// the URI, and the value of the 'name' field should be of the form:
        /// "projects/{project}/subscribers/{subscriber_id}".
        /// The remaining fields of the Subscriber object represent the new values
        /// for the corresponding fields in the existing subscriber resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. A field mask that specifies which fields of the Subscriber
        /// message are to be updated. This allows for partial updates. Supported
        /// fields:
        /// - endpoint_uri
        /// - subscriber_configs
        /// - endpoint_authorization
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subscriber, UpdateSubscriberMetadata> UpdateSubscriber(Subscriber subscriber, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSubscriber(new UpdateSubscriberRequest
            {
                Subscriber = gax::GaxPreconditions.CheckNotNull(subscriber, nameof(subscriber)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the configuration of an existing subscriber, such as the
        /// endpoint URI or the data types it's interested in.
        /// 
        /// **Endpoint Verification:**
        /// If the `endpoint_uri` or `endpoint_authorization` field is included in the
        /// `update_mask`, the backend will re-verify the endpoint. The verification
        /// process is the same as described in `CreateSubscriber`:
        /// 
        /// 1.  **Verification with Authorization:** POST to the new or existing
        /// `endpoint_uri` with the new or existing `Authorization` secret. Expects
        /// HTTP `201 Created`.
        /// 2.  **Verification without Authorization:** POST to the `endpoint_uri`
        /// without the `Authorization` header. Expects HTTP `401 Unauthorized` or
        /// `403 Forbidden`.
        /// 
        /// Both tests must pass using the potentially updated values for the
        /// subscriber update to succeed. If verification fails, the update will not
        /// be applied, and an error will be returned.
        /// </summary>
        /// <param name="subscriber">
        /// Required. The subscriber resource to update. Its 'name' field is mapped to
        /// the URI, and the value of the 'name' field should be of the form:
        /// "projects/{project}/subscribers/{subscriber_id}".
        /// The remaining fields of the Subscriber object represent the new values
        /// for the corresponding fields in the existing subscriber resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. A field mask that specifies which fields of the Subscriber
        /// message are to be updated. This allows for partial updates. Supported
        /// fields:
        /// - endpoint_uri
        /// - subscriber_configs
        /// - endpoint_authorization
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscriber, UpdateSubscriberMetadata>> UpdateSubscriberAsync(Subscriber subscriber, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSubscriberAsync(new UpdateSubscriberRequest
            {
                Subscriber = gax::GaxPreconditions.CheckNotNull(subscriber, nameof(subscriber)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the configuration of an existing subscriber, such as the
        /// endpoint URI or the data types it's interested in.
        /// 
        /// **Endpoint Verification:**
        /// If the `endpoint_uri` or `endpoint_authorization` field is included in the
        /// `update_mask`, the backend will re-verify the endpoint. The verification
        /// process is the same as described in `CreateSubscriber`:
        /// 
        /// 1.  **Verification with Authorization:** POST to the new or existing
        /// `endpoint_uri` with the new or existing `Authorization` secret. Expects
        /// HTTP `201 Created`.
        /// 2.  **Verification without Authorization:** POST to the `endpoint_uri`
        /// without the `Authorization` header. Expects HTTP `401 Unauthorized` or
        /// `403 Forbidden`.
        /// 
        /// Both tests must pass using the potentially updated values for the
        /// subscriber update to succeed. If verification fails, the update will not
        /// be applied, and an error will be returned.
        /// </summary>
        /// <param name="subscriber">
        /// Required. The subscriber resource to update. Its 'name' field is mapped to
        /// the URI, and the value of the 'name' field should be of the form:
        /// "projects/{project}/subscribers/{subscriber_id}".
        /// The remaining fields of the Subscriber object represent the new values
        /// for the corresponding fields in the existing subscriber resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. A field mask that specifies which fields of the Subscriber
        /// message are to be updated. This allows for partial updates. Supported
        /// fields:
        /// - endpoint_uri
        /// - subscriber_configs
        /// - endpoint_authorization
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscriber, UpdateSubscriberMetadata>> UpdateSubscriberAsync(Subscriber subscriber, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSubscriberAsync(subscriber, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a subscriber registration. This will stop all notifications
        /// to the subscriber's endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteSubscriberMetadata> DeleteSubscriber(DeleteSubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a subscriber registration. This will stop all notifications
        /// to the subscriber's endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSubscriberMetadata>> DeleteSubscriberAsync(DeleteSubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a subscriber registration. This will stop all notifications
        /// to the subscriber's endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSubscriberMetadata>> DeleteSubscriberAsync(DeleteSubscriberRequest request, st::CancellationToken cancellationToken) =>
            DeleteSubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSubscriber</c>.</summary>
        public virtual lro::OperationsClient DeleteSubscriberOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSubscriber</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteSubscriberMetadata> PollOnceDeleteSubscriber(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteSubscriberMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSubscriberOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSubscriber</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSubscriberMetadata>> PollOnceDeleteSubscriberAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteSubscriberMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSubscriberOperationsClient, callSettings);

        /// <summary>
        /// Deletes a subscriber registration. This will stop all notifications
        /// to the subscriber's endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscriber to delete.
        /// Format: projects/{project}/subscribers/{subscriber}
        /// Example: projects/my-project/subscribers/my-subscriber-123
        /// The {subscriber} ID is user-settable (4-36 characters, matching
        /// /[a-z]([a-z0-9-]{2,34}[a-z0-9])/) or system-generated if not provided
        /// during creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteSubscriberMetadata> DeleteSubscriber(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscriber(new DeleteSubscriberRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a subscriber registration. This will stop all notifications
        /// to the subscriber's endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscriber to delete.
        /// Format: projects/{project}/subscribers/{subscriber}
        /// Example: projects/my-project/subscribers/my-subscriber-123
        /// The {subscriber} ID is user-settable (4-36 characters, matching
        /// /[a-z]([a-z0-9-]{2,34}[a-z0-9])/) or system-generated if not provided
        /// during creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSubscriberMetadata>> DeleteSubscriberAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscriberAsync(new DeleteSubscriberRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a subscriber registration. This will stop all notifications
        /// to the subscriber's endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscriber to delete.
        /// Format: projects/{project}/subscribers/{subscriber}
        /// Example: projects/my-project/subscribers/my-subscriber-123
        /// The {subscriber} ID is user-settable (4-36 characters, matching
        /// /[a-z]([a-z0-9-]{2,34}[a-z0-9])/) or system-generated if not provided
        /// during creation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSubscriberMetadata>> DeleteSubscriberAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSubscriberAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a subscriber registration. This will stop all notifications
        /// to the subscriber's endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscriber to delete.
        /// Format: projects/{project}/subscribers/{subscriber}
        /// Example: projects/my-project/subscribers/my-subscriber-123
        /// The {subscriber} ID is user-settable (4-36 characters, matching
        /// /[a-z]([a-z0-9-]{2,34}[a-z0-9])/) or system-generated if not provided
        /// during creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteSubscriberMetadata> DeleteSubscriber(SubscriberName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscriber(new DeleteSubscriberRequest
            {
                SubscriberName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a subscriber registration. This will stop all notifications
        /// to the subscriber's endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscriber to delete.
        /// Format: projects/{project}/subscribers/{subscriber}
        /// Example: projects/my-project/subscribers/my-subscriber-123
        /// The {subscriber} ID is user-settable (4-36 characters, matching
        /// /[a-z]([a-z0-9-]{2,34}[a-z0-9])/) or system-generated if not provided
        /// during creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSubscriberMetadata>> DeleteSubscriberAsync(SubscriberName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscriberAsync(new DeleteSubscriberRequest
            {
                SubscriberName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a subscriber registration. This will stop all notifications
        /// to the subscriber's endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscriber to delete.
        /// Format: projects/{project}/subscribers/{subscriber}
        /// Example: projects/my-project/subscribers/my-subscriber-123
        /// The {subscriber} ID is user-settable (4-36 characters, matching
        /// /[a-z]([a-z0-9-]{2,34}[a-z0-9])/) or system-generated if not provided
        /// during creation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSubscriberMetadata>> DeleteSubscriberAsync(SubscriberName name, st::CancellationToken cancellationToken) =>
            DeleteSubscriberAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataSubscriptionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Data Subscription Service that allows clients (e.g., Fitbit 3P
    /// applications, internal Fitbit Services) to manage their subscriber endpoints.
    /// This service provides CRUD APIs for subscribers,
    /// and also offers functionalities for subscriber verification and statistics.
    /// </remarks>
    public sealed partial class DataSubscriptionServiceClientImpl : DataSubscriptionServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateSubscriberRequest, lro::Operation> _callCreateSubscriber;

        private readonly gaxgrpc::ApiCall<ListSubscribersRequest, ListSubscribersResponse> _callListSubscribers;

        private readonly gaxgrpc::ApiCall<UpdateSubscriberRequest, lro::Operation> _callUpdateSubscriber;

        private readonly gaxgrpc::ApiCall<DeleteSubscriberRequest, lro::Operation> _callDeleteSubscriber;

        /// <summary>
        /// Constructs a client wrapper for the DataSubscriptionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DataSubscriptionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataSubscriptionServiceClientImpl(DataSubscriptionService.DataSubscriptionServiceClient grpcClient, DataSubscriptionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataSubscriptionServiceSettings effectiveSettings = settings ?? DataSubscriptionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateSubscriberOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSubscriberOperationsSettings, logger);
            UpdateSubscriberOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSubscriberOperationsSettings, logger);
            DeleteSubscriberOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSubscriberOperationsSettings, logger);
            _callCreateSubscriber = clientHelper.BuildApiCall<CreateSubscriberRequest, lro::Operation>("CreateSubscriber", grpcClient.CreateSubscriberAsync, grpcClient.CreateSubscriber, effectiveSettings.CreateSubscriberSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSubscriber);
            Modify_CreateSubscriberApiCall(ref _callCreateSubscriber);
            _callListSubscribers = clientHelper.BuildApiCall<ListSubscribersRequest, ListSubscribersResponse>("ListSubscribers", grpcClient.ListSubscribersAsync, grpcClient.ListSubscribers, effectiveSettings.ListSubscribersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSubscribers);
            Modify_ListSubscribersApiCall(ref _callListSubscribers);
            _callUpdateSubscriber = clientHelper.BuildApiCall<UpdateSubscriberRequest, lro::Operation>("UpdateSubscriber", grpcClient.UpdateSubscriberAsync, grpcClient.UpdateSubscriber, effectiveSettings.UpdateSubscriberSettings).WithGoogleRequestParam("subscriber.name", request => request.Subscriber?.Name);
            Modify_ApiCall(ref _callUpdateSubscriber);
            Modify_UpdateSubscriberApiCall(ref _callUpdateSubscriber);
            _callDeleteSubscriber = clientHelper.BuildApiCall<DeleteSubscriberRequest, lro::Operation>("DeleteSubscriber", grpcClient.DeleteSubscriberAsync, grpcClient.DeleteSubscriber, effectiveSettings.DeleteSubscriberSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSubscriber);
            Modify_DeleteSubscriberApiCall(ref _callDeleteSubscriber);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSubscriberApiCall(ref gaxgrpc::ApiCall<CreateSubscriberRequest, lro::Operation> call);

        partial void Modify_ListSubscribersApiCall(ref gaxgrpc::ApiCall<ListSubscribersRequest, ListSubscribersResponse> call);

        partial void Modify_UpdateSubscriberApiCall(ref gaxgrpc::ApiCall<UpdateSubscriberRequest, lro::Operation> call);

        partial void Modify_DeleteSubscriberApiCall(ref gaxgrpc::ApiCall<DeleteSubscriberRequest, lro::Operation> call);

        partial void OnConstruction(DataSubscriptionService.DataSubscriptionServiceClient grpcClient, DataSubscriptionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataSubscriptionService client</summary>
        public override DataSubscriptionService.DataSubscriptionServiceClient GrpcClient { get; }

        partial void Modify_CreateSubscriberRequest(ref CreateSubscriberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSubscribersRequest(ref ListSubscribersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSubscriberRequest(ref UpdateSubscriberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSubscriberRequest(ref DeleteSubscriberRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateSubscriber</c>.</summary>
        public override lro::OperationsClient CreateSubscriberOperationsClient { get; }

        /// <summary>
        /// Registers a new subscriber endpoint to receive notifications.
        /// A subscriber represents an application or service that wishes to receive
        /// data change notifications for users who have granted consent.
        /// 
        /// **Endpoint Verification:**
        /// For a subscriber to be successfully created, the provided `endpoint_uri`
        /// must be a valid HTTPS endpoint and must pass an automated verification
        /// check. The backend will send two HTTP POST requests to the `endpoint_uri`:
        /// 
        /// 1.  **Verification with Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json` and
        /// `Authorization` (with the exact value from
        /// `CreateSubscriberPayload.endpoint_authorization.secret`).
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `201 Created`.
        /// 
        /// 2.  **Verification without Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json`. The
        /// `Authorization` header is OMITTED.
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `401 Unauthorized` or `403 Forbidden`.
        /// 
        /// Both tests must pass for the subscriber creation to succeed. If
        /// verification fails, the operation will not be completed and an error will
        /// be returned. This process ensures the endpoint is reachable and correctly
        /// validates the `Authorization` header.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Subscriber, CreateSubscriberMetadata> CreateSubscriber(CreateSubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSubscriberRequest(ref request, ref callSettings);
            return new lro::Operation<Subscriber, CreateSubscriberMetadata>(_callCreateSubscriber.Sync(request, callSettings), CreateSubscriberOperationsClient);
        }

        /// <summary>
        /// Registers a new subscriber endpoint to receive notifications.
        /// A subscriber represents an application or service that wishes to receive
        /// data change notifications for users who have granted consent.
        /// 
        /// **Endpoint Verification:**
        /// For a subscriber to be successfully created, the provided `endpoint_uri`
        /// must be a valid HTTPS endpoint and must pass an automated verification
        /// check. The backend will send two HTTP POST requests to the `endpoint_uri`:
        /// 
        /// 1.  **Verification with Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json` and
        /// `Authorization` (with the exact value from
        /// `CreateSubscriberPayload.endpoint_authorization.secret`).
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `201 Created`.
        /// 
        /// 2.  **Verification without Authorization:**
        /// *   **Headers:** Includes `Content-Type: application/json`. The
        /// `Authorization` header is OMITTED.
        /// *   **Body:** `{"type": "verification"}`
        /// *   **Expected Response:** HTTP `401 Unauthorized` or `403 Forbidden`.
        /// 
        /// Both tests must pass for the subscriber creation to succeed. If
        /// verification fails, the operation will not be completed and an error will
        /// be returned. This process ensures the endpoint is reachable and correctly
        /// validates the `Authorization` header.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Subscriber, CreateSubscriberMetadata>> CreateSubscriberAsync(CreateSubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSubscriberRequest(ref request, ref callSettings);
            return new lro::Operation<Subscriber, CreateSubscriberMetadata>(await _callCreateSubscriber.Async(request, callSettings).ConfigureAwait(false), CreateSubscriberOperationsClient);
        }

        /// <summary>
        /// Lists all subscribers registered within the owned Google Cloud Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Subscriber"/> resources.</returns>
        public override gax::PagedEnumerable<ListSubscribersResponse, Subscriber> ListSubscribers(ListSubscribersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubscribersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSubscribersRequest, ListSubscribersResponse, Subscriber>(_callListSubscribers, request, callSettings);
        }

        /// <summary>
        /// Lists all subscribers registered within the owned Google Cloud Project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Subscriber"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSubscribersResponse, Subscriber> ListSubscribersAsync(ListSubscribersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubscribersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSubscribersRequest, ListSubscribersResponse, Subscriber>(_callListSubscribers, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateSubscriber</c>.</summary>
        public override lro::OperationsClient UpdateSubscriberOperationsClient { get; }

        /// <summary>
        /// Updates the configuration of an existing subscriber, such as the
        /// endpoint URI or the data types it's interested in.
        /// 
        /// **Endpoint Verification:**
        /// If the `endpoint_uri` or `endpoint_authorization` field is included in the
        /// `update_mask`, the backend will re-verify the endpoint. The verification
        /// process is the same as described in `CreateSubscriber`:
        /// 
        /// 1.  **Verification with Authorization:** POST to the new or existing
        /// `endpoint_uri` with the new or existing `Authorization` secret. Expects
        /// HTTP `201 Created`.
        /// 2.  **Verification without Authorization:** POST to the `endpoint_uri`
        /// without the `Authorization` header. Expects HTTP `401 Unauthorized` or
        /// `403 Forbidden`.
        /// 
        /// Both tests must pass using the potentially updated values for the
        /// subscriber update to succeed. If verification fails, the update will not
        /// be applied, and an error will be returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Subscriber, UpdateSubscriberMetadata> UpdateSubscriber(UpdateSubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSubscriberRequest(ref request, ref callSettings);
            return new lro::Operation<Subscriber, UpdateSubscriberMetadata>(_callUpdateSubscriber.Sync(request, callSettings), UpdateSubscriberOperationsClient);
        }

        /// <summary>
        /// Updates the configuration of an existing subscriber, such as the
        /// endpoint URI or the data types it's interested in.
        /// 
        /// **Endpoint Verification:**
        /// If the `endpoint_uri` or `endpoint_authorization` field is included in the
        /// `update_mask`, the backend will re-verify the endpoint. The verification
        /// process is the same as described in `CreateSubscriber`:
        /// 
        /// 1.  **Verification with Authorization:** POST to the new or existing
        /// `endpoint_uri` with the new or existing `Authorization` secret. Expects
        /// HTTP `201 Created`.
        /// 2.  **Verification without Authorization:** POST to the `endpoint_uri`
        /// without the `Authorization` header. Expects HTTP `401 Unauthorized` or
        /// `403 Forbidden`.
        /// 
        /// Both tests must pass using the potentially updated values for the
        /// subscriber update to succeed. If verification fails, the update will not
        /// be applied, and an error will be returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Subscriber, UpdateSubscriberMetadata>> UpdateSubscriberAsync(UpdateSubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSubscriberRequest(ref request, ref callSettings);
            return new lro::Operation<Subscriber, UpdateSubscriberMetadata>(await _callUpdateSubscriber.Async(request, callSettings).ConfigureAwait(false), UpdateSubscriberOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSubscriber</c>.</summary>
        public override lro::OperationsClient DeleteSubscriberOperationsClient { get; }

        /// <summary>
        /// Deletes a subscriber registration. This will stop all notifications
        /// to the subscriber's endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteSubscriberMetadata> DeleteSubscriber(DeleteSubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSubscriberRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteSubscriberMetadata>(_callDeleteSubscriber.Sync(request, callSettings), DeleteSubscriberOperationsClient);
        }

        /// <summary>
        /// Deletes a subscriber registration. This will stop all notifications
        /// to the subscriber's endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteSubscriberMetadata>> DeleteSubscriberAsync(DeleteSubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSubscriberRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteSubscriberMetadata>(await _callDeleteSubscriber.Async(request, callSettings).ConfigureAwait(false), DeleteSubscriberOperationsClient);
        }
    }

    public partial class ListSubscribersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSubscribersResponse : gaxgrpc::IPageResponse<Subscriber>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Subscriber> GetEnumerator() => Subscribers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataSubscriptionService
    {
        public partial class DataSubscriptionServiceClient
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
}
