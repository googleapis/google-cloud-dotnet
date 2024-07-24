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

namespace Google.Apps.Events.Subscriptions.V1
{
    /// <summary>Settings for <see cref="SubscriptionsServiceClient"/> instances.</summary>
    public sealed partial class SubscriptionsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SubscriptionsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SubscriptionsServiceSettings"/>.</returns>
        public static SubscriptionsServiceSettings GetDefault() => new SubscriptionsServiceSettings();

        /// <summary>Constructs a new <see cref="SubscriptionsServiceSettings"/> object with default settings.</summary>
        public SubscriptionsServiceSettings()
        {
        }

        private SubscriptionsServiceSettings(SubscriptionsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSubscriptionSettings = existing.CreateSubscriptionSettings;
            CreateSubscriptionOperationsSettings = existing.CreateSubscriptionOperationsSettings.Clone();
            DeleteSubscriptionSettings = existing.DeleteSubscriptionSettings;
            DeleteSubscriptionOperationsSettings = existing.DeleteSubscriptionOperationsSettings.Clone();
            GetSubscriptionSettings = existing.GetSubscriptionSettings;
            ListSubscriptionsSettings = existing.ListSubscriptionsSettings;
            UpdateSubscriptionSettings = existing.UpdateSubscriptionSettings;
            UpdateSubscriptionOperationsSettings = existing.UpdateSubscriptionOperationsSettings.Clone();
            ReactivateSubscriptionSettings = existing.ReactivateSubscriptionSettings;
            ReactivateSubscriptionOperationsSettings = existing.ReactivateSubscriptionOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(SubscriptionsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriptionsServiceClient.CreateSubscription</c> and
        /// <c>SubscriptionsServiceClient.CreateSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SubscriptionsServiceClient.CreateSubscription</c> and
        /// <c>SubscriptionsServiceClient.CreateSubscriptionAsync</c>.
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
        public lro::OperationsSettings CreateSubscriptionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriptionsServiceClient.DeleteSubscription</c> and
        /// <c>SubscriptionsServiceClient.DeleteSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SubscriptionsServiceClient.DeleteSubscription</c> and
        /// <c>SubscriptionsServiceClient.DeleteSubscriptionAsync</c>.
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
        public lro::OperationsSettings DeleteSubscriptionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriptionsServiceClient.GetSubscription</c> and <c>SubscriptionsServiceClient.GetSubscriptionAsync</c>
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
        public gaxgrpc::CallSettings GetSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriptionsServiceClient.ListSubscriptions</c> and <c>SubscriptionsServiceClient.ListSubscriptionsAsync</c>
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
        public gaxgrpc::CallSettings ListSubscriptionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriptionsServiceClient.UpdateSubscription</c> and
        /// <c>SubscriptionsServiceClient.UpdateSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SubscriptionsServiceClient.UpdateSubscription</c> and
        /// <c>SubscriptionsServiceClient.UpdateSubscriptionAsync</c>.
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
        public lro::OperationsSettings UpdateSubscriptionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriptionsServiceClient.ReactivateSubscription</c> and
        /// <c>SubscriptionsServiceClient.ReactivateSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReactivateSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SubscriptionsServiceClient.ReactivateSubscription</c> and
        /// <c>SubscriptionsServiceClient.ReactivateSubscriptionAsync</c>.
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
        public lro::OperationsSettings ReactivateSubscriptionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SubscriptionsServiceSettings"/> object.</returns>
        public SubscriptionsServiceSettings Clone() => new SubscriptionsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SubscriptionsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SubscriptionsServiceClientBuilder : gaxgrpc::ClientBuilderBase<SubscriptionsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SubscriptionsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SubscriptionsServiceClientBuilder() : base(SubscriptionsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SubscriptionsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SubscriptionsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SubscriptionsServiceClient Build()
        {
            SubscriptionsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SubscriptionsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SubscriptionsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SubscriptionsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SubscriptionsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SubscriptionsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SubscriptionsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SubscriptionsServiceClient.ChannelPool;
    }

    /// <summary>SubscriptionsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service that manages subscriptions to Google Workspace events.
    /// </remarks>
    public abstract partial class SubscriptionsServiceClient
    {
        /// <summary>
        /// The default endpoint for the SubscriptionsService service, which is a host of
        /// "workspaceevents.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "workspaceevents.googleapis.com:443";

        /// <summary>The default SubscriptionsService scopes.</summary>
        /// <remarks>
        /// The default SubscriptionsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/chat.bot</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.memberships</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.memberships.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.messages</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.messages.reactions</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.messages.reactions.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.messages.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.spaces</description></item>
        /// <item><description>https://www.googleapis.com/auth/chat.spaces.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/meetings.space.created</description></item>
        /// <item><description>https://www.googleapis.com/auth/meetings.space.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/chat.bot",
            "https://www.googleapis.com/auth/chat.memberships",
            "https://www.googleapis.com/auth/chat.memberships.readonly",
            "https://www.googleapis.com/auth/chat.messages",
            "https://www.googleapis.com/auth/chat.messages.reactions",
            "https://www.googleapis.com/auth/chat.messages.reactions.readonly",
            "https://www.googleapis.com/auth/chat.messages.readonly",
            "https://www.googleapis.com/auth/chat.spaces",
            "https://www.googleapis.com/auth/chat.spaces.readonly",
            "https://www.googleapis.com/auth/meetings.space.created",
            "https://www.googleapis.com/auth/meetings.space.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SubscriptionsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SubscriptionsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SubscriptionsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SubscriptionsServiceClient"/>.</returns>
        public static stt::Task<SubscriptionsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SubscriptionsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SubscriptionsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="SubscriptionsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SubscriptionsServiceClient"/>.</returns>
        public static SubscriptionsServiceClient Create() => new SubscriptionsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SubscriptionsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SubscriptionsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SubscriptionsServiceClient"/>.</returns>
        internal static SubscriptionsServiceClient Create(grpccore::CallInvoker callInvoker, SubscriptionsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SubscriptionsService.SubscriptionsServiceClient grpcClient = new SubscriptionsService.SubscriptionsServiceClient(callInvoker);
            return new SubscriptionsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SubscriptionsService client</summary>
        public virtual SubscriptionsService.SubscriptionsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Google Workspace subscription. To learn how to use this
        /// method, see [Create a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/create-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subscription, CreateSubscriptionMetadata> CreateSubscription(CreateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Google Workspace subscription. To learn how to use this
        /// method, see [Create a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/create-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscription, CreateSubscriptionMetadata>> CreateSubscriptionAsync(CreateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Google Workspace subscription. To learn how to use this
        /// method, see [Create a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/create-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscription, CreateSubscriptionMetadata>> CreateSubscriptionAsync(CreateSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            CreateSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSubscription</c>.</summary>
        public virtual lro::OperationsClient CreateSubscriptionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSubscription</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Subscription, CreateSubscriptionMetadata> PollOnceCreateSubscription(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Subscription, CreateSubscriptionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSubscriptionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSubscription</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Subscription, CreateSubscriptionMetadata>> PollOnceCreateSubscriptionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Subscription, CreateSubscriptionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSubscriptionOperationsClient, callSettings);

        /// <summary>
        /// Creates a Google Workspace subscription. To learn how to use this
        /// method, see [Create a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/create-subscription).
        /// </summary>
        /// <param name="subscription">
        /// Required. The subscription resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subscription, CreateSubscriptionMetadata> CreateSubscription(Subscription subscription, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubscription(new CreateSubscriptionRequest
            {
                Subscription = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
            }, callSettings);

        /// <summary>
        /// Creates a Google Workspace subscription. To learn how to use this
        /// method, see [Create a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/create-subscription).
        /// </summary>
        /// <param name="subscription">
        /// Required. The subscription resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscription, CreateSubscriptionMetadata>> CreateSubscriptionAsync(Subscription subscription, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubscriptionAsync(new CreateSubscriptionRequest
            {
                Subscription = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
            }, callSettings);

        /// <summary>
        /// Creates a Google Workspace subscription. To learn how to use this
        /// method, see [Create a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/create-subscription).
        /// </summary>
        /// <param name="subscription">
        /// Required. The subscription resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscription, CreateSubscriptionMetadata>> CreateSubscriptionAsync(Subscription subscription, st::CancellationToken cancellationToken) =>
            CreateSubscriptionAsync(subscription, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Google Workspace subscription.
        /// To learn how to use this method, see [Delete a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/delete-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteSubscriptionMetadata> DeleteSubscription(DeleteSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Google Workspace subscription.
        /// To learn how to use this method, see [Delete a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/delete-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSubscriptionMetadata>> DeleteSubscriptionAsync(DeleteSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Google Workspace subscription.
        /// To learn how to use this method, see [Delete a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/delete-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSubscriptionMetadata>> DeleteSubscriptionAsync(DeleteSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            DeleteSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSubscription</c>.</summary>
        public virtual lro::OperationsClient DeleteSubscriptionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSubscription</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteSubscriptionMetadata> PollOnceDeleteSubscription(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteSubscriptionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSubscriptionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSubscription</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSubscriptionMetadata>> PollOnceDeleteSubscriptionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteSubscriptionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSubscriptionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Google Workspace subscription.
        /// To learn how to use this method, see [Delete a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/delete-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to delete.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteSubscriptionMetadata> DeleteSubscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscription(new DeleteSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Google Workspace subscription.
        /// To learn how to use this method, see [Delete a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/delete-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to delete.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSubscriptionMetadata>> DeleteSubscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscriptionAsync(new DeleteSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Google Workspace subscription.
        /// To learn how to use this method, see [Delete a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/delete-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to delete.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSubscriptionMetadata>> DeleteSubscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Google Workspace subscription.
        /// To learn how to use this method, see [Delete a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/delete-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to delete.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteSubscriptionMetadata> DeleteSubscription(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscription(new DeleteSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Google Workspace subscription.
        /// To learn how to use this method, see [Delete a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/delete-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to delete.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSubscriptionMetadata>> DeleteSubscriptionAsync(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscriptionAsync(new DeleteSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Google Workspace subscription.
        /// To learn how to use this method, see [Delete a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/delete-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription to delete.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSubscriptionMetadata>> DeleteSubscriptionAsync(SubscriptionName name, st::CancellationToken cancellationToken) =>
            DeleteSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Google Workspace subscription. To learn how to use
        /// this method, see [Get details about a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/get-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription GetSubscription(GetSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a Google Workspace subscription. To learn how to use
        /// this method, see [Get details about a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/get-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(GetSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a Google Workspace subscription. To learn how to use
        /// this method, see [Get details about a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/get-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(GetSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            GetSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Google Workspace subscription. To learn how to use
        /// this method, see [Get details about a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/get-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription GetSubscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubscription(new GetSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Google Workspace subscription. To learn how to use
        /// this method, see [Get details about a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/get-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubscriptionAsync(new GetSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Google Workspace subscription. To learn how to use
        /// this method, see [Get details about a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/get-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            GetSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Google Workspace subscription. To learn how to use
        /// this method, see [Get details about a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/get-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription GetSubscription(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubscription(new GetSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Google Workspace subscription. To learn how to use
        /// this method, see [Get details about a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/get-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubscriptionAsync(new GetSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Google Workspace subscription. To learn how to use
        /// this method, see [Get details about a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/get-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(SubscriptionName name, st::CancellationToken cancellationToken) =>
            GetSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Google Workspace subscriptions. To learn how to use this method, see
        /// [List Google Workspace
        /// subscriptions](https://developers.google.com/workspace/events/guides/list-subscriptions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(ListSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Google Workspace subscriptions. To learn how to use this method, see
        /// [List Google Workspace
        /// subscriptions](https://developers.google.com/workspace/events/guides/list-subscriptions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(ListSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Google Workspace subscriptions. To learn how to use this method, see
        /// [List Google Workspace
        /// subscriptions](https://developers.google.com/workspace/events/guides/list-subscriptions).
        /// </summary>
        /// <param name="filter">
        /// Required. A query filter.
        /// 
        /// You can filter subscriptions by event type (`event_types`)
        /// and target resource (`target_resource`).
        /// 
        /// You must specify at least one event type in your query. To filter for
        /// multiple event types, use the `OR` operator.
        /// 
        /// To filter by both event type and target resource, use the `AND` operator
        /// and specify the full resource name, such as
        /// `//chat.googleapis.com/spaces/{space}`.
        /// 
        /// For example, the following queries are valid:
        /// 
        /// ```
        /// event_types:"google.workspace.chat.membership.v1.updated" OR
        /// event_types:"google.workspace.chat.message.v1.created"
        /// 
        /// event_types:"google.workspace.chat.message.v1.created" AND
        /// target_resource="//chat.googleapis.com/spaces/{space}"
        /// 
        /// ( event_types:"google.workspace.chat.membership.v1.updated" OR
        /// event_types:"google.workspace.chat.message.v1.created" ) AND
        /// target_resource="//chat.googleapis.com/spaces/{space}"
        /// ```
        /// 
        /// The server rejects invalid queries with an `INVALID_ARGUMENT`
        /// error.
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
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSubscriptions(request, callSettings);
        }

        /// <summary>
        /// Lists Google Workspace subscriptions. To learn how to use this method, see
        /// [List Google Workspace
        /// subscriptions](https://developers.google.com/workspace/events/guides/list-subscriptions).
        /// </summary>
        /// <param name="filter">
        /// Required. A query filter.
        /// 
        /// You can filter subscriptions by event type (`event_types`)
        /// and target resource (`target_resource`).
        /// 
        /// You must specify at least one event type in your query. To filter for
        /// multiple event types, use the `OR` operator.
        /// 
        /// To filter by both event type and target resource, use the `AND` operator
        /// and specify the full resource name, such as
        /// `//chat.googleapis.com/spaces/{space}`.
        /// 
        /// For example, the following queries are valid:
        /// 
        /// ```
        /// event_types:"google.workspace.chat.membership.v1.updated" OR
        /// event_types:"google.workspace.chat.message.v1.created"
        /// 
        /// event_types:"google.workspace.chat.message.v1.created" AND
        /// target_resource="//chat.googleapis.com/spaces/{space}"
        /// 
        /// ( event_types:"google.workspace.chat.membership.v1.updated" OR
        /// event_types:"google.workspace.chat.message.v1.created" ) AND
        /// target_resource="//chat.googleapis.com/spaces/{space}"
        /// ```
        /// 
        /// The server rejects invalid queries with an `INVALID_ARGUMENT`
        /// error.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSubscriptionsRequest request = new ListSubscriptionsRequest
            {
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSubscriptionsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates or renews a Google Workspace subscription. To learn how to use this
        /// method, see [Update or renew a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/update-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subscription, UpdateSubscriptionMetadata> UpdateSubscription(UpdateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates or renews a Google Workspace subscription. To learn how to use this
        /// method, see [Update or renew a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/update-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscription, UpdateSubscriptionMetadata>> UpdateSubscriptionAsync(UpdateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates or renews a Google Workspace subscription. To learn how to use this
        /// method, see [Update or renew a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/update-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscription, UpdateSubscriptionMetadata>> UpdateSubscriptionAsync(UpdateSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            UpdateSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSubscription</c>.</summary>
        public virtual lro::OperationsClient UpdateSubscriptionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSubscription</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Subscription, UpdateSubscriptionMetadata> PollOnceUpdateSubscription(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Subscription, UpdateSubscriptionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSubscriptionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSubscription</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Subscription, UpdateSubscriptionMetadata>> PollOnceUpdateSubscriptionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Subscription, UpdateSubscriptionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSubscriptionOperationsClient, callSettings);

        /// <summary>
        /// Updates or renews a Google Workspace subscription. To learn how to use this
        /// method, see [Update or renew a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/update-subscription).
        /// </summary>
        /// <param name="subscription">
        /// Required. The subscription to update.
        /// 
        /// The subscription's `name` field is used to identify the subscription to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Required. The field to update.
        /// 
        /// You can update one of the following fields in a subscription:
        /// 
        /// * [`expire_time`][google.apps.events.subscriptions.v1.Subscription.expire_time]: The timestamp when the
        /// subscription expires.
        /// * [`ttl`][google.apps.events.subscriptions.v1.Subscription.ttl]: The
        /// time-to-live (TTL) or duration of the
        /// subscription.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subscription, UpdateSubscriptionMetadata> UpdateSubscription(Subscription subscription, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSubscription(new UpdateSubscriptionRequest
            {
                Subscription = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates or renews a Google Workspace subscription. To learn how to use this
        /// method, see [Update or renew a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/update-subscription).
        /// </summary>
        /// <param name="subscription">
        /// Required. The subscription to update.
        /// 
        /// The subscription's `name` field is used to identify the subscription to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Required. The field to update.
        /// 
        /// You can update one of the following fields in a subscription:
        /// 
        /// * [`expire_time`][google.apps.events.subscriptions.v1.Subscription.expire_time]: The timestamp when the
        /// subscription expires.
        /// * [`ttl`][google.apps.events.subscriptions.v1.Subscription.ttl]: The
        /// time-to-live (TTL) or duration of the
        /// subscription.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscription, UpdateSubscriptionMetadata>> UpdateSubscriptionAsync(Subscription subscription, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSubscriptionAsync(new UpdateSubscriptionRequest
            {
                Subscription = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates or renews a Google Workspace subscription. To learn how to use this
        /// method, see [Update or renew a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/update-subscription).
        /// </summary>
        /// <param name="subscription">
        /// Required. The subscription to update.
        /// 
        /// The subscription's `name` field is used to identify the subscription to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Required. The field to update.
        /// 
        /// You can update one of the following fields in a subscription:
        /// 
        /// * [`expire_time`][google.apps.events.subscriptions.v1.Subscription.expire_time]: The timestamp when the
        /// subscription expires.
        /// * [`ttl`][google.apps.events.subscriptions.v1.Subscription.ttl]: The
        /// time-to-live (TTL) or duration of the
        /// subscription.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscription, UpdateSubscriptionMetadata>> UpdateSubscriptionAsync(Subscription subscription, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSubscriptionAsync(subscription, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reactivates a suspended Google Workspace subscription.
        /// 
        /// This method resets your subscription's `State` field to `ACTIVE`. Before
        /// you use this method, you must fix the error that suspended the
        /// subscription. To learn how to use this method, see [Reactivate a Google
        /// Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/reactivate-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subscription, ReactivateSubscriptionMetadata> ReactivateSubscription(ReactivateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reactivates a suspended Google Workspace subscription.
        /// 
        /// This method resets your subscription's `State` field to `ACTIVE`. Before
        /// you use this method, you must fix the error that suspended the
        /// subscription. To learn how to use this method, see [Reactivate a Google
        /// Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/reactivate-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscription, ReactivateSubscriptionMetadata>> ReactivateSubscriptionAsync(ReactivateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reactivates a suspended Google Workspace subscription.
        /// 
        /// This method resets your subscription's `State` field to `ACTIVE`. Before
        /// you use this method, you must fix the error that suspended the
        /// subscription. To learn how to use this method, see [Reactivate a Google
        /// Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/reactivate-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscription, ReactivateSubscriptionMetadata>> ReactivateSubscriptionAsync(ReactivateSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            ReactivateSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReactivateSubscription</c>.</summary>
        public virtual lro::OperationsClient ReactivateSubscriptionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReactivateSubscription</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Subscription, ReactivateSubscriptionMetadata> PollOnceReactivateSubscription(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Subscription, ReactivateSubscriptionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReactivateSubscriptionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReactivateSubscription</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Subscription, ReactivateSubscriptionMetadata>> PollOnceReactivateSubscriptionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Subscription, ReactivateSubscriptionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReactivateSubscriptionOperationsClient, callSettings);

        /// <summary>
        /// Reactivates a suspended Google Workspace subscription.
        /// 
        /// This method resets your subscription's `State` field to `ACTIVE`. Before
        /// you use this method, you must fix the error that suspended the
        /// subscription. To learn how to use this method, see [Reactivate a Google
        /// Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/reactivate-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subscription, ReactivateSubscriptionMetadata> ReactivateSubscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            ReactivateSubscription(new ReactivateSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reactivates a suspended Google Workspace subscription.
        /// 
        /// This method resets your subscription's `State` field to `ACTIVE`. Before
        /// you use this method, you must fix the error that suspended the
        /// subscription. To learn how to use this method, see [Reactivate a Google
        /// Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/reactivate-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscription, ReactivateSubscriptionMetadata>> ReactivateSubscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ReactivateSubscriptionAsync(new ReactivateSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reactivates a suspended Google Workspace subscription.
        /// 
        /// This method resets your subscription's `State` field to `ACTIVE`. Before
        /// you use this method, you must fix the error that suspended the
        /// subscription. To learn how to use this method, see [Reactivate a Google
        /// Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/reactivate-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscription, ReactivateSubscriptionMetadata>> ReactivateSubscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            ReactivateSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reactivates a suspended Google Workspace subscription.
        /// 
        /// This method resets your subscription's `State` field to `ACTIVE`. Before
        /// you use this method, you must fix the error that suspended the
        /// subscription. To learn how to use this method, see [Reactivate a Google
        /// Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/reactivate-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Subscription, ReactivateSubscriptionMetadata> ReactivateSubscription(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            ReactivateSubscription(new ReactivateSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reactivates a suspended Google Workspace subscription.
        /// 
        /// This method resets your subscription's `State` field to `ACTIVE`. Before
        /// you use this method, you must fix the error that suspended the
        /// subscription. To learn how to use this method, see [Reactivate a Google
        /// Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/reactivate-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscription, ReactivateSubscriptionMetadata>> ReactivateSubscriptionAsync(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            ReactivateSubscriptionAsync(new ReactivateSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Reactivates a suspended Google Workspace subscription.
        /// 
        /// This method resets your subscription's `State` field to `ACTIVE`. Before
        /// you use this method, you must fix the error that suspended the
        /// subscription. To learn how to use this method, see [Reactivate a Google
        /// Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/reactivate-subscription).
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the subscription.
        /// 
        /// Format: `subscriptions/{subscription}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Subscription, ReactivateSubscriptionMetadata>> ReactivateSubscriptionAsync(SubscriptionName name, st::CancellationToken cancellationToken) =>
            ReactivateSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SubscriptionsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service that manages subscriptions to Google Workspace events.
    /// </remarks>
    public sealed partial class SubscriptionsServiceClientImpl : SubscriptionsServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateSubscriptionRequest, lro::Operation> _callCreateSubscription;

        private readonly gaxgrpc::ApiCall<DeleteSubscriptionRequest, lro::Operation> _callDeleteSubscription;

        private readonly gaxgrpc::ApiCall<GetSubscriptionRequest, Subscription> _callGetSubscription;

        private readonly gaxgrpc::ApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse> _callListSubscriptions;

        private readonly gaxgrpc::ApiCall<UpdateSubscriptionRequest, lro::Operation> _callUpdateSubscription;

        private readonly gaxgrpc::ApiCall<ReactivateSubscriptionRequest, lro::Operation> _callReactivateSubscription;

        /// <summary>
        /// Constructs a client wrapper for the SubscriptionsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SubscriptionsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SubscriptionsServiceClientImpl(SubscriptionsService.SubscriptionsServiceClient grpcClient, SubscriptionsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SubscriptionsServiceSettings effectiveSettings = settings ?? SubscriptionsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateSubscriptionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSubscriptionOperationsSettings, logger);
            DeleteSubscriptionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSubscriptionOperationsSettings, logger);
            UpdateSubscriptionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSubscriptionOperationsSettings, logger);
            ReactivateSubscriptionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReactivateSubscriptionOperationsSettings, logger);
            _callCreateSubscription = clientHelper.BuildApiCall<CreateSubscriptionRequest, lro::Operation>("CreateSubscription", grpcClient.CreateSubscriptionAsync, grpcClient.CreateSubscription, effectiveSettings.CreateSubscriptionSettings);
            Modify_ApiCall(ref _callCreateSubscription);
            Modify_CreateSubscriptionApiCall(ref _callCreateSubscription);
            _callDeleteSubscription = clientHelper.BuildApiCall<DeleteSubscriptionRequest, lro::Operation>("DeleteSubscription", grpcClient.DeleteSubscriptionAsync, grpcClient.DeleteSubscription, effectiveSettings.DeleteSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSubscription);
            Modify_DeleteSubscriptionApiCall(ref _callDeleteSubscription);
            _callGetSubscription = clientHelper.BuildApiCall<GetSubscriptionRequest, Subscription>("GetSubscription", grpcClient.GetSubscriptionAsync, grpcClient.GetSubscription, effectiveSettings.GetSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSubscription);
            Modify_GetSubscriptionApiCall(ref _callGetSubscription);
            _callListSubscriptions = clientHelper.BuildApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse>("ListSubscriptions", grpcClient.ListSubscriptionsAsync, grpcClient.ListSubscriptions, effectiveSettings.ListSubscriptionsSettings);
            Modify_ApiCall(ref _callListSubscriptions);
            Modify_ListSubscriptionsApiCall(ref _callListSubscriptions);
            _callUpdateSubscription = clientHelper.BuildApiCall<UpdateSubscriptionRequest, lro::Operation>("UpdateSubscription", grpcClient.UpdateSubscriptionAsync, grpcClient.UpdateSubscription, effectiveSettings.UpdateSubscriptionSettings).WithGoogleRequestParam("subscription.name", request => request.Subscription?.Name);
            Modify_ApiCall(ref _callUpdateSubscription);
            Modify_UpdateSubscriptionApiCall(ref _callUpdateSubscription);
            _callReactivateSubscription = clientHelper.BuildApiCall<ReactivateSubscriptionRequest, lro::Operation>("ReactivateSubscription", grpcClient.ReactivateSubscriptionAsync, grpcClient.ReactivateSubscription, effectiveSettings.ReactivateSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callReactivateSubscription);
            Modify_ReactivateSubscriptionApiCall(ref _callReactivateSubscription);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSubscriptionApiCall(ref gaxgrpc::ApiCall<CreateSubscriptionRequest, lro::Operation> call);

        partial void Modify_DeleteSubscriptionApiCall(ref gaxgrpc::ApiCall<DeleteSubscriptionRequest, lro::Operation> call);

        partial void Modify_GetSubscriptionApiCall(ref gaxgrpc::ApiCall<GetSubscriptionRequest, Subscription> call);

        partial void Modify_ListSubscriptionsApiCall(ref gaxgrpc::ApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse> call);

        partial void Modify_UpdateSubscriptionApiCall(ref gaxgrpc::ApiCall<UpdateSubscriptionRequest, lro::Operation> call);

        partial void Modify_ReactivateSubscriptionApiCall(ref gaxgrpc::ApiCall<ReactivateSubscriptionRequest, lro::Operation> call);

        partial void OnConstruction(SubscriptionsService.SubscriptionsServiceClient grpcClient, SubscriptionsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SubscriptionsService client</summary>
        public override SubscriptionsService.SubscriptionsServiceClient GrpcClient { get; }

        partial void Modify_CreateSubscriptionRequest(ref CreateSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSubscriptionRequest(ref DeleteSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSubscriptionRequest(ref GetSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSubscriptionsRequest(ref ListSubscriptionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSubscriptionRequest(ref UpdateSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReactivateSubscriptionRequest(ref ReactivateSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateSubscription</c>.</summary>
        public override lro::OperationsClient CreateSubscriptionOperationsClient { get; }

        /// <summary>
        /// Creates a Google Workspace subscription. To learn how to use this
        /// method, see [Create a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/create-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Subscription, CreateSubscriptionMetadata> CreateSubscription(CreateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSubscriptionRequest(ref request, ref callSettings);
            return new lro::Operation<Subscription, CreateSubscriptionMetadata>(_callCreateSubscription.Sync(request, callSettings), CreateSubscriptionOperationsClient);
        }

        /// <summary>
        /// Creates a Google Workspace subscription. To learn how to use this
        /// method, see [Create a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/create-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Subscription, CreateSubscriptionMetadata>> CreateSubscriptionAsync(CreateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSubscriptionRequest(ref request, ref callSettings);
            return new lro::Operation<Subscription, CreateSubscriptionMetadata>(await _callCreateSubscription.Async(request, callSettings).ConfigureAwait(false), CreateSubscriptionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSubscription</c>.</summary>
        public override lro::OperationsClient DeleteSubscriptionOperationsClient { get; }

        /// <summary>
        /// Deletes a Google Workspace subscription.
        /// To learn how to use this method, see [Delete a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/delete-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteSubscriptionMetadata> DeleteSubscription(DeleteSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSubscriptionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteSubscriptionMetadata>(_callDeleteSubscription.Sync(request, callSettings), DeleteSubscriptionOperationsClient);
        }

        /// <summary>
        /// Deletes a Google Workspace subscription.
        /// To learn how to use this method, see [Delete a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/delete-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteSubscriptionMetadata>> DeleteSubscriptionAsync(DeleteSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSubscriptionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteSubscriptionMetadata>(await _callDeleteSubscription.Async(request, callSettings).ConfigureAwait(false), DeleteSubscriptionOperationsClient);
        }

        /// <summary>
        /// Gets details about a Google Workspace subscription. To learn how to use
        /// this method, see [Get details about a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/get-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Subscription GetSubscription(GetSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSubscriptionRequest(ref request, ref callSettings);
            return _callGetSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a Google Workspace subscription. To learn how to use
        /// this method, see [Get details about a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/get-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Subscription> GetSubscriptionAsync(GetSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSubscriptionRequest(ref request, ref callSettings);
            return _callGetSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Google Workspace subscriptions. To learn how to use this method, see
        /// [List Google Workspace
        /// subscriptions](https://developers.google.com/workspace/events/guides/list-subscriptions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public override gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(ListSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(_callListSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Lists Google Workspace subscriptions. To learn how to use this method, see
        /// [List Google Workspace
        /// subscriptions](https://developers.google.com/workspace/events/guides/list-subscriptions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(ListSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(_callListSubscriptions, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateSubscription</c>.</summary>
        public override lro::OperationsClient UpdateSubscriptionOperationsClient { get; }

        /// <summary>
        /// Updates or renews a Google Workspace subscription. To learn how to use this
        /// method, see [Update or renew a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/update-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Subscription, UpdateSubscriptionMetadata> UpdateSubscription(UpdateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSubscriptionRequest(ref request, ref callSettings);
            return new lro::Operation<Subscription, UpdateSubscriptionMetadata>(_callUpdateSubscription.Sync(request, callSettings), UpdateSubscriptionOperationsClient);
        }

        /// <summary>
        /// Updates or renews a Google Workspace subscription. To learn how to use this
        /// method, see [Update or renew a Google Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/update-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Subscription, UpdateSubscriptionMetadata>> UpdateSubscriptionAsync(UpdateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSubscriptionRequest(ref request, ref callSettings);
            return new lro::Operation<Subscription, UpdateSubscriptionMetadata>(await _callUpdateSubscription.Async(request, callSettings).ConfigureAwait(false), UpdateSubscriptionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReactivateSubscription</c>.</summary>
        public override lro::OperationsClient ReactivateSubscriptionOperationsClient { get; }

        /// <summary>
        /// Reactivates a suspended Google Workspace subscription.
        /// 
        /// This method resets your subscription's `State` field to `ACTIVE`. Before
        /// you use this method, you must fix the error that suspended the
        /// subscription. To learn how to use this method, see [Reactivate a Google
        /// Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/reactivate-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Subscription, ReactivateSubscriptionMetadata> ReactivateSubscription(ReactivateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReactivateSubscriptionRequest(ref request, ref callSettings);
            return new lro::Operation<Subscription, ReactivateSubscriptionMetadata>(_callReactivateSubscription.Sync(request, callSettings), ReactivateSubscriptionOperationsClient);
        }

        /// <summary>
        /// Reactivates a suspended Google Workspace subscription.
        /// 
        /// This method resets your subscription's `State` field to `ACTIVE`. Before
        /// you use this method, you must fix the error that suspended the
        /// subscription. To learn how to use this method, see [Reactivate a Google
        /// Workspace
        /// subscription](https://developers.google.com/workspace/events/guides/reactivate-subscription).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Subscription, ReactivateSubscriptionMetadata>> ReactivateSubscriptionAsync(ReactivateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReactivateSubscriptionRequest(ref request, ref callSettings);
            return new lro::Operation<Subscription, ReactivateSubscriptionMetadata>(await _callReactivateSubscription.Async(request, callSettings).ConfigureAwait(false), ReactivateSubscriptionOperationsClient);
        }
    }

    public partial class ListSubscriptionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSubscriptionsResponse : gaxgrpc::IPageResponse<Subscription>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Subscription> GetEnumerator() => Subscriptions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SubscriptionsService
    {
        public partial class SubscriptionsServiceClient
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
