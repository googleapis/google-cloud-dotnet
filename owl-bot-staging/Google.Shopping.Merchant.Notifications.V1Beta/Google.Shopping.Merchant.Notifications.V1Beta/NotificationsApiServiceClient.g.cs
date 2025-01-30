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

namespace Google.Shopping.Merchant.Notifications.V1Beta
{
    /// <summary>Settings for <see cref="NotificationsApiServiceClient"/> instances.</summary>
    public sealed partial class NotificationsApiServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NotificationsApiServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NotificationsApiServiceSettings"/>.</returns>
        public static NotificationsApiServiceSettings GetDefault() => new NotificationsApiServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="NotificationsApiServiceSettings"/> object with default settings.
        /// </summary>
        public NotificationsApiServiceSettings()
        {
        }

        private NotificationsApiServiceSettings(NotificationsApiServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetNotificationSubscriptionSettings = existing.GetNotificationSubscriptionSettings;
            CreateNotificationSubscriptionSettings = existing.CreateNotificationSubscriptionSettings;
            UpdateNotificationSubscriptionSettings = existing.UpdateNotificationSubscriptionSettings;
            DeleteNotificationSubscriptionSettings = existing.DeleteNotificationSubscriptionSettings;
            ListNotificationSubscriptionsSettings = existing.ListNotificationSubscriptionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(NotificationsApiServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationsApiServiceClient.GetNotificationSubscription</c> and
        /// <c>NotificationsApiServiceClient.GetNotificationSubscriptionAsync</c>.
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
        public gaxgrpc::CallSettings GetNotificationSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationsApiServiceClient.CreateNotificationSubscription</c> and
        /// <c>NotificationsApiServiceClient.CreateNotificationSubscriptionAsync</c>.
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
        public gaxgrpc::CallSettings CreateNotificationSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationsApiServiceClient.UpdateNotificationSubscription</c> and
        /// <c>NotificationsApiServiceClient.UpdateNotificationSubscriptionAsync</c>.
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
        public gaxgrpc::CallSettings UpdateNotificationSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationsApiServiceClient.DeleteNotificationSubscription</c> and
        /// <c>NotificationsApiServiceClient.DeleteNotificationSubscriptionAsync</c>.
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
        public gaxgrpc::CallSettings DeleteNotificationSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationsApiServiceClient.ListNotificationSubscriptions</c> and
        /// <c>NotificationsApiServiceClient.ListNotificationSubscriptionsAsync</c>.
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
        public gaxgrpc::CallSettings ListNotificationSubscriptionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="NotificationsApiServiceSettings"/> object.</returns>
        public NotificationsApiServiceSettings Clone() => new NotificationsApiServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NotificationsApiServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class NotificationsApiServiceClientBuilder : gaxgrpc::ClientBuilderBase<NotificationsApiServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NotificationsApiServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NotificationsApiServiceClientBuilder() : base(NotificationsApiServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NotificationsApiServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NotificationsApiServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NotificationsApiServiceClient Build()
        {
            NotificationsApiServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NotificationsApiServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NotificationsApiServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NotificationsApiServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NotificationsApiServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<NotificationsApiServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NotificationsApiServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NotificationsApiServiceClient.ChannelPool;
    }

    /// <summary>NotificationsApiService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage notification subscriptions for merchants
    /// </remarks>
    public abstract partial class NotificationsApiServiceClient
    {
        /// <summary>
        /// The default endpoint for the NotificationsApiService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default NotificationsApiService scopes.</summary>
        /// <remarks>
        /// The default NotificationsApiService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NotificationsApiService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NotificationsApiServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="NotificationsApiServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NotificationsApiServiceClient"/>.</returns>
        public static stt::Task<NotificationsApiServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NotificationsApiServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NotificationsApiServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="NotificationsApiServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="NotificationsApiServiceClient"/>.</returns>
        public static NotificationsApiServiceClient Create() => new NotificationsApiServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NotificationsApiServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NotificationsApiServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NotificationsApiServiceClient"/>.</returns>
        internal static NotificationsApiServiceClient Create(grpccore::CallInvoker callInvoker, NotificationsApiServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NotificationsApiService.NotificationsApiServiceClient grpcClient = new NotificationsApiService.NotificationsApiServiceClient(callInvoker);
            return new NotificationsApiServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC NotificationsApiService client</summary>
        public virtual NotificationsApiService.NotificationsApiServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets notification subscriptions for an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationSubscription GetNotificationSubscription(GetNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets notification subscriptions for an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> GetNotificationSubscriptionAsync(GetNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets notification subscriptions for an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> GetNotificationSubscriptionAsync(GetNotificationSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            GetNotificationSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets notification subscriptions for an account.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` of the notification subscription.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationSubscription GetNotificationSubscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationSubscription(new GetNotificationSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets notification subscriptions for an account.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` of the notification subscription.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> GetNotificationSubscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationSubscriptionAsync(new GetNotificationSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets notification subscriptions for an account.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` of the notification subscription.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> GetNotificationSubscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            GetNotificationSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets notification subscriptions for an account.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` of the notification subscription.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationSubscription GetNotificationSubscription(NotificationSubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationSubscription(new GetNotificationSubscriptionRequest
            {
                NotificationSubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets notification subscriptions for an account.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` of the notification subscription.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> GetNotificationSubscriptionAsync(NotificationSubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationSubscriptionAsync(new GetNotificationSubscriptionRequest
            {
                NotificationSubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets notification subscriptions for an account.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` of the notification subscription.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> GetNotificationSubscriptionAsync(NotificationSubscriptionName name, st::CancellationToken cancellationToken) =>
            GetNotificationSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a notification subscription for a merchant. We will allow the
        /// following types of notification subscriptions to exist together (per
        /// merchant as a subscriber per event type):
        /// 1. Subscription for all managed accounts + subscription for self
        /// 2. Multiple "partial" subscriptions for managed accounts + subscription
        /// for self
        /// 
        /// we will not allow (per merchant as a subscriber per event type):
        /// 1. multiple self subscriptions.
        /// 2. multiple "all managed accounts" subscriptions.
        /// 3. all and partial subscriptions at the same time.
        /// 4. multiple partial subscriptions for the same target account
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationSubscription CreateNotificationSubscription(CreateNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a notification subscription for a merchant. We will allow the
        /// following types of notification subscriptions to exist together (per
        /// merchant as a subscriber per event type):
        /// 1. Subscription for all managed accounts + subscription for self
        /// 2. Multiple "partial" subscriptions for managed accounts + subscription
        /// for self
        /// 
        /// we will not allow (per merchant as a subscriber per event type):
        /// 1. multiple self subscriptions.
        /// 2. multiple "all managed accounts" subscriptions.
        /// 3. all and partial subscriptions at the same time.
        /// 4. multiple partial subscriptions for the same target account
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> CreateNotificationSubscriptionAsync(CreateNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a notification subscription for a merchant. We will allow the
        /// following types of notification subscriptions to exist together (per
        /// merchant as a subscriber per event type):
        /// 1. Subscription for all managed accounts + subscription for self
        /// 2. Multiple "partial" subscriptions for managed accounts + subscription
        /// for self
        /// 
        /// we will not allow (per merchant as a subscriber per event type):
        /// 1. multiple self subscriptions.
        /// 2. multiple "all managed accounts" subscriptions.
        /// 3. all and partial subscriptions at the same time.
        /// 4. multiple partial subscriptions for the same target account
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> CreateNotificationSubscriptionAsync(CreateNotificationSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            CreateNotificationSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a notification subscription for a merchant. We will allow the
        /// following types of notification subscriptions to exist together (per
        /// merchant as a subscriber per event type):
        /// 1. Subscription for all managed accounts + subscription for self
        /// 2. Multiple "partial" subscriptions for managed accounts + subscription
        /// for self
        /// 
        /// we will not allow (per merchant as a subscriber per event type):
        /// 1. multiple self subscriptions.
        /// 2. multiple "all managed accounts" subscriptions.
        /// 3. all and partial subscriptions at the same time.
        /// 4. multiple partial subscriptions for the same target account
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account that owns the new notification subscription.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="notificationSubscription">
        /// Required. The notification subscription to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationSubscription CreateNotificationSubscription(string parent, NotificationSubscription notificationSubscription, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationSubscription(new CreateNotificationSubscriptionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NotificationSubscription = gax::GaxPreconditions.CheckNotNull(notificationSubscription, nameof(notificationSubscription)),
            }, callSettings);

        /// <summary>
        /// Creates a notification subscription for a merchant. We will allow the
        /// following types of notification subscriptions to exist together (per
        /// merchant as a subscriber per event type):
        /// 1. Subscription for all managed accounts + subscription for self
        /// 2. Multiple "partial" subscriptions for managed accounts + subscription
        /// for self
        /// 
        /// we will not allow (per merchant as a subscriber per event type):
        /// 1. multiple self subscriptions.
        /// 2. multiple "all managed accounts" subscriptions.
        /// 3. all and partial subscriptions at the same time.
        /// 4. multiple partial subscriptions for the same target account
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account that owns the new notification subscription.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="notificationSubscription">
        /// Required. The notification subscription to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> CreateNotificationSubscriptionAsync(string parent, NotificationSubscription notificationSubscription, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationSubscriptionAsync(new CreateNotificationSubscriptionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                NotificationSubscription = gax::GaxPreconditions.CheckNotNull(notificationSubscription, nameof(notificationSubscription)),
            }, callSettings);

        /// <summary>
        /// Creates a notification subscription for a merchant. We will allow the
        /// following types of notification subscriptions to exist together (per
        /// merchant as a subscriber per event type):
        /// 1. Subscription for all managed accounts + subscription for self
        /// 2. Multiple "partial" subscriptions for managed accounts + subscription
        /// for self
        /// 
        /// we will not allow (per merchant as a subscriber per event type):
        /// 1. multiple self subscriptions.
        /// 2. multiple "all managed accounts" subscriptions.
        /// 3. all and partial subscriptions at the same time.
        /// 4. multiple partial subscriptions for the same target account
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account that owns the new notification subscription.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="notificationSubscription">
        /// Required. The notification subscription to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> CreateNotificationSubscriptionAsync(string parent, NotificationSubscription notificationSubscription, st::CancellationToken cancellationToken) =>
            CreateNotificationSubscriptionAsync(parent, notificationSubscription, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a notification subscription for a merchant. We will allow the
        /// following types of notification subscriptions to exist together (per
        /// merchant as a subscriber per event type):
        /// 1. Subscription for all managed accounts + subscription for self
        /// 2. Multiple "partial" subscriptions for managed accounts + subscription
        /// for self
        /// 
        /// we will not allow (per merchant as a subscriber per event type):
        /// 1. multiple self subscriptions.
        /// 2. multiple "all managed accounts" subscriptions.
        /// 3. all and partial subscriptions at the same time.
        /// 4. multiple partial subscriptions for the same target account
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account that owns the new notification subscription.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="notificationSubscription">
        /// Required. The notification subscription to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationSubscription CreateNotificationSubscription(AccountName parent, NotificationSubscription notificationSubscription, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationSubscription(new CreateNotificationSubscriptionRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NotificationSubscription = gax::GaxPreconditions.CheckNotNull(notificationSubscription, nameof(notificationSubscription)),
            }, callSettings);

        /// <summary>
        /// Creates a notification subscription for a merchant. We will allow the
        /// following types of notification subscriptions to exist together (per
        /// merchant as a subscriber per event type):
        /// 1. Subscription for all managed accounts + subscription for self
        /// 2. Multiple "partial" subscriptions for managed accounts + subscription
        /// for self
        /// 
        /// we will not allow (per merchant as a subscriber per event type):
        /// 1. multiple self subscriptions.
        /// 2. multiple "all managed accounts" subscriptions.
        /// 3. all and partial subscriptions at the same time.
        /// 4. multiple partial subscriptions for the same target account
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account that owns the new notification subscription.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="notificationSubscription">
        /// Required. The notification subscription to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> CreateNotificationSubscriptionAsync(AccountName parent, NotificationSubscription notificationSubscription, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationSubscriptionAsync(new CreateNotificationSubscriptionRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                NotificationSubscription = gax::GaxPreconditions.CheckNotNull(notificationSubscription, nameof(notificationSubscription)),
            }, callSettings);

        /// <summary>
        /// Creates a notification subscription for a merchant. We will allow the
        /// following types of notification subscriptions to exist together (per
        /// merchant as a subscriber per event type):
        /// 1. Subscription for all managed accounts + subscription for self
        /// 2. Multiple "partial" subscriptions for managed accounts + subscription
        /// for self
        /// 
        /// we will not allow (per merchant as a subscriber per event type):
        /// 1. multiple self subscriptions.
        /// 2. multiple "all managed accounts" subscriptions.
        /// 3. all and partial subscriptions at the same time.
        /// 4. multiple partial subscriptions for the same target account
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account that owns the new notification subscription.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="notificationSubscription">
        /// Required. The notification subscription to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> CreateNotificationSubscriptionAsync(AccountName parent, NotificationSubscription notificationSubscription, st::CancellationToken cancellationToken) =>
            CreateNotificationSubscriptionAsync(parent, notificationSubscription, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing notification subscription for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationSubscription UpdateNotificationSubscription(UpdateNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing notification subscription for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> UpdateNotificationSubscriptionAsync(UpdateNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing notification subscription for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> UpdateNotificationSubscriptionAsync(UpdateNotificationSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            UpdateNotificationSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing notification subscription for a merchant.
        /// </summary>
        /// <param name="notificationSubscription">
        /// Required. The new version of the notification subscription that should be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationSubscription UpdateNotificationSubscription(NotificationSubscription notificationSubscription, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNotificationSubscription(new UpdateNotificationSubscriptionRequest
            {
                NotificationSubscription = gax::GaxPreconditions.CheckNotNull(notificationSubscription, nameof(notificationSubscription)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing notification subscription for a merchant.
        /// </summary>
        /// <param name="notificationSubscription">
        /// Required. The new version of the notification subscription that should be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> UpdateNotificationSubscriptionAsync(NotificationSubscription notificationSubscription, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNotificationSubscriptionAsync(new UpdateNotificationSubscriptionRequest
            {
                NotificationSubscription = gax::GaxPreconditions.CheckNotNull(notificationSubscription, nameof(notificationSubscription)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing notification subscription for a merchant.
        /// </summary>
        /// <param name="notificationSubscription">
        /// Required. The new version of the notification subscription that should be
        /// updated.
        /// </param>
        /// <param name="updateMask">
        /// List of fields being updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationSubscription> UpdateNotificationSubscriptionAsync(NotificationSubscription notificationSubscription, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateNotificationSubscriptionAsync(notificationSubscription, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a notification subscription for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNotificationSubscription(DeleteNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a notification subscription for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationSubscriptionAsync(DeleteNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a notification subscription for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationSubscriptionAsync(DeleteNotificationSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            DeleteNotificationSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a notification subscription for a merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the notification subscription to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNotificationSubscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationSubscription(new DeleteNotificationSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a notification subscription for a merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the notification subscription to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationSubscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationSubscriptionAsync(new DeleteNotificationSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a notification subscription for a merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the notification subscription to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationSubscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteNotificationSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a notification subscription for a merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the notification subscription to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNotificationSubscription(NotificationSubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationSubscription(new DeleteNotificationSubscriptionRequest
            {
                NotificationSubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a notification subscription for a merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the notification subscription to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationSubscriptionAsync(NotificationSubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationSubscriptionAsync(new DeleteNotificationSubscriptionRequest
            {
                NotificationSubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a notification subscription for a merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the notification subscription to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationSubscriptionAsync(NotificationSubscriptionName name, st::CancellationToken cancellationToken) =>
            DeleteNotificationSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets all the notification subscriptions for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationSubscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationSubscriptionsResponse, NotificationSubscription> ListNotificationSubscriptions(ListNotificationSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets all the notification subscriptions for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationSubscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationSubscriptionsResponse, NotificationSubscription> ListNotificationSubscriptionsAsync(ListNotificationSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets all the notification subscriptions for a merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account who owns the notification subscriptions.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable sequence of <see cref="NotificationSubscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationSubscriptionsResponse, NotificationSubscription> ListNotificationSubscriptions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationSubscriptionsRequest request = new ListNotificationSubscriptionsRequest
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
            return ListNotificationSubscriptions(request, callSettings);
        }

        /// <summary>
        /// Gets all the notification subscriptions for a merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account who owns the notification subscriptions.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationSubscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationSubscriptionsResponse, NotificationSubscription> ListNotificationSubscriptionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationSubscriptionsRequest request = new ListNotificationSubscriptionsRequest
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
            return ListNotificationSubscriptionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets all the notification subscriptions for a merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account who owns the notification subscriptions.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable sequence of <see cref="NotificationSubscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationSubscriptionsResponse, NotificationSubscription> ListNotificationSubscriptions(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationSubscriptionsRequest request = new ListNotificationSubscriptionsRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationSubscriptions(request, callSettings);
        }

        /// <summary>
        /// Gets all the notification subscriptions for a merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account who owns the notification subscriptions.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationSubscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationSubscriptionsResponse, NotificationSubscription> ListNotificationSubscriptionsAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationSubscriptionsRequest request = new ListNotificationSubscriptionsRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationSubscriptionsAsync(request, callSettings);
        }
    }

    /// <summary>NotificationsApiService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage notification subscriptions for merchants
    /// </remarks>
    public sealed partial class NotificationsApiServiceClientImpl : NotificationsApiServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetNotificationSubscriptionRequest, NotificationSubscription> _callGetNotificationSubscription;

        private readonly gaxgrpc::ApiCall<CreateNotificationSubscriptionRequest, NotificationSubscription> _callCreateNotificationSubscription;

        private readonly gaxgrpc::ApiCall<UpdateNotificationSubscriptionRequest, NotificationSubscription> _callUpdateNotificationSubscription;

        private readonly gaxgrpc::ApiCall<DeleteNotificationSubscriptionRequest, wkt::Empty> _callDeleteNotificationSubscription;

        private readonly gaxgrpc::ApiCall<ListNotificationSubscriptionsRequest, ListNotificationSubscriptionsResponse> _callListNotificationSubscriptions;

        /// <summary>
        /// Constructs a client wrapper for the NotificationsApiService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="NotificationsApiServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NotificationsApiServiceClientImpl(NotificationsApiService.NotificationsApiServiceClient grpcClient, NotificationsApiServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NotificationsApiServiceSettings effectiveSettings = settings ?? NotificationsApiServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetNotificationSubscription = clientHelper.BuildApiCall<GetNotificationSubscriptionRequest, NotificationSubscription>("GetNotificationSubscription", grpcClient.GetNotificationSubscriptionAsync, grpcClient.GetNotificationSubscription, effectiveSettings.GetNotificationSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNotificationSubscription);
            Modify_GetNotificationSubscriptionApiCall(ref _callGetNotificationSubscription);
            _callCreateNotificationSubscription = clientHelper.BuildApiCall<CreateNotificationSubscriptionRequest, NotificationSubscription>("CreateNotificationSubscription", grpcClient.CreateNotificationSubscriptionAsync, grpcClient.CreateNotificationSubscription, effectiveSettings.CreateNotificationSubscriptionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateNotificationSubscription);
            Modify_CreateNotificationSubscriptionApiCall(ref _callCreateNotificationSubscription);
            _callUpdateNotificationSubscription = clientHelper.BuildApiCall<UpdateNotificationSubscriptionRequest, NotificationSubscription>("UpdateNotificationSubscription", grpcClient.UpdateNotificationSubscriptionAsync, grpcClient.UpdateNotificationSubscription, effectiveSettings.UpdateNotificationSubscriptionSettings).WithGoogleRequestParam("notification_subscription.name", request => request.NotificationSubscription?.Name);
            Modify_ApiCall(ref _callUpdateNotificationSubscription);
            Modify_UpdateNotificationSubscriptionApiCall(ref _callUpdateNotificationSubscription);
            _callDeleteNotificationSubscription = clientHelper.BuildApiCall<DeleteNotificationSubscriptionRequest, wkt::Empty>("DeleteNotificationSubscription", grpcClient.DeleteNotificationSubscriptionAsync, grpcClient.DeleteNotificationSubscription, effectiveSettings.DeleteNotificationSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteNotificationSubscription);
            Modify_DeleteNotificationSubscriptionApiCall(ref _callDeleteNotificationSubscription);
            _callListNotificationSubscriptions = clientHelper.BuildApiCall<ListNotificationSubscriptionsRequest, ListNotificationSubscriptionsResponse>("ListNotificationSubscriptions", grpcClient.ListNotificationSubscriptionsAsync, grpcClient.ListNotificationSubscriptions, effectiveSettings.ListNotificationSubscriptionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNotificationSubscriptions);
            Modify_ListNotificationSubscriptionsApiCall(ref _callListNotificationSubscriptions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetNotificationSubscriptionApiCall(ref gaxgrpc::ApiCall<GetNotificationSubscriptionRequest, NotificationSubscription> call);

        partial void Modify_CreateNotificationSubscriptionApiCall(ref gaxgrpc::ApiCall<CreateNotificationSubscriptionRequest, NotificationSubscription> call);

        partial void Modify_UpdateNotificationSubscriptionApiCall(ref gaxgrpc::ApiCall<UpdateNotificationSubscriptionRequest, NotificationSubscription> call);

        partial void Modify_DeleteNotificationSubscriptionApiCall(ref gaxgrpc::ApiCall<DeleteNotificationSubscriptionRequest, wkt::Empty> call);

        partial void Modify_ListNotificationSubscriptionsApiCall(ref gaxgrpc::ApiCall<ListNotificationSubscriptionsRequest, ListNotificationSubscriptionsResponse> call);

        partial void OnConstruction(NotificationsApiService.NotificationsApiServiceClient grpcClient, NotificationsApiServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NotificationsApiService client</summary>
        public override NotificationsApiService.NotificationsApiServiceClient GrpcClient { get; }

        partial void Modify_GetNotificationSubscriptionRequest(ref GetNotificationSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateNotificationSubscriptionRequest(ref CreateNotificationSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNotificationSubscriptionRequest(ref UpdateNotificationSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNotificationSubscriptionRequest(ref DeleteNotificationSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNotificationSubscriptionsRequest(ref ListNotificationSubscriptionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets notification subscriptions for an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotificationSubscription GetNotificationSubscription(GetNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationSubscriptionRequest(ref request, ref callSettings);
            return _callGetNotificationSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets notification subscriptions for an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotificationSubscription> GetNotificationSubscriptionAsync(GetNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationSubscriptionRequest(ref request, ref callSettings);
            return _callGetNotificationSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a notification subscription for a merchant. We will allow the
        /// following types of notification subscriptions to exist together (per
        /// merchant as a subscriber per event type):
        /// 1. Subscription for all managed accounts + subscription for self
        /// 2. Multiple "partial" subscriptions for managed accounts + subscription
        /// for self
        /// 
        /// we will not allow (per merchant as a subscriber per event type):
        /// 1. multiple self subscriptions.
        /// 2. multiple "all managed accounts" subscriptions.
        /// 3. all and partial subscriptions at the same time.
        /// 4. multiple partial subscriptions for the same target account
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotificationSubscription CreateNotificationSubscription(CreateNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNotificationSubscriptionRequest(ref request, ref callSettings);
            return _callCreateNotificationSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a notification subscription for a merchant. We will allow the
        /// following types of notification subscriptions to exist together (per
        /// merchant as a subscriber per event type):
        /// 1. Subscription for all managed accounts + subscription for self
        /// 2. Multiple "partial" subscriptions for managed accounts + subscription
        /// for self
        /// 
        /// we will not allow (per merchant as a subscriber per event type):
        /// 1. multiple self subscriptions.
        /// 2. multiple "all managed accounts" subscriptions.
        /// 3. all and partial subscriptions at the same time.
        /// 4. multiple partial subscriptions for the same target account
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotificationSubscription> CreateNotificationSubscriptionAsync(CreateNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNotificationSubscriptionRequest(ref request, ref callSettings);
            return _callCreateNotificationSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing notification subscription for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotificationSubscription UpdateNotificationSubscription(UpdateNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNotificationSubscriptionRequest(ref request, ref callSettings);
            return _callUpdateNotificationSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing notification subscription for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotificationSubscription> UpdateNotificationSubscriptionAsync(UpdateNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNotificationSubscriptionRequest(ref request, ref callSettings);
            return _callUpdateNotificationSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a notification subscription for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteNotificationSubscription(DeleteNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNotificationSubscriptionRequest(ref request, ref callSettings);
            _callDeleteNotificationSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a notification subscription for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteNotificationSubscriptionAsync(DeleteNotificationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNotificationSubscriptionRequest(ref request, ref callSettings);
            return _callDeleteNotificationSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Gets all the notification subscriptions for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationSubscription"/> resources.</returns>
        public override gax::PagedEnumerable<ListNotificationSubscriptionsResponse, NotificationSubscription> ListNotificationSubscriptions(ListNotificationSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNotificationSubscriptionsRequest, ListNotificationSubscriptionsResponse, NotificationSubscription>(_callListNotificationSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Gets all the notification subscriptions for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationSubscription"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNotificationSubscriptionsResponse, NotificationSubscription> ListNotificationSubscriptionsAsync(ListNotificationSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNotificationSubscriptionsRequest, ListNotificationSubscriptionsResponse, NotificationSubscription>(_callListNotificationSubscriptions, request, callSettings);
        }
    }

    public partial class ListNotificationSubscriptionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNotificationSubscriptionsResponse : gaxgrpc::IPageResponse<NotificationSubscription>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NotificationSubscription> GetEnumerator() => NotificationSubscriptions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
