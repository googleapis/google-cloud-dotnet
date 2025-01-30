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
using ga = Google.Api;
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

namespace Google.Cloud.RecommendationEngine.V1Beta1
{
    /// <summary>Settings for <see cref="UserEventServiceClient"/> instances.</summary>
    public sealed partial class UserEventServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UserEventServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UserEventServiceSettings"/>.</returns>
        public static UserEventServiceSettings GetDefault() => new UserEventServiceSettings();

        /// <summary>Constructs a new <see cref="UserEventServiceSettings"/> object with default settings.</summary>
        public UserEventServiceSettings()
        {
        }

        private UserEventServiceSettings(UserEventServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            WriteUserEventSettings = existing.WriteUserEventSettings;
            CollectUserEventSettings = existing.CollectUserEventSettings;
            ListUserEventsSettings = existing.ListUserEventsSettings;
            PurgeUserEventsSettings = existing.PurgeUserEventsSettings;
            PurgeUserEventsOperationsSettings = existing.PurgeUserEventsOperationsSettings.Clone();
            ImportUserEventsSettings = existing.ImportUserEventsSettings;
            ImportUserEventsOperationsSettings = existing.ImportUserEventsOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(UserEventServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserEventServiceClient.WriteUserEvent</c> and <c>UserEventServiceClient.WriteUserEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings WriteUserEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserEventServiceClient.CollectUserEvent</c> and <c>UserEventServiceClient.CollectUserEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CollectUserEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserEventServiceClient.ListUserEvents</c> and <c>UserEventServiceClient.ListUserEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListUserEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserEventServiceClient.PurgeUserEvents</c> and <c>UserEventServiceClient.PurgeUserEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PurgeUserEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>UserEventServiceClient.PurgeUserEvents</c> and
        /// <c>UserEventServiceClient.PurgeUserEventsAsync</c>.
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
        public lro::OperationsSettings PurgeUserEventsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserEventServiceClient.ImportUserEvents</c> and <c>UserEventServiceClient.ImportUserEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportUserEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>UserEventServiceClient.ImportUserEvents</c> and
        /// <c>UserEventServiceClient.ImportUserEventsAsync</c>.
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
        public lro::OperationsSettings ImportUserEventsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserEventServiceSettings"/> object.</returns>
        public UserEventServiceSettings Clone() => new UserEventServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserEventServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class UserEventServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserEventServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserEventServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public UserEventServiceClientBuilder() : base(UserEventServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref UserEventServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UserEventServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UserEventServiceClient Build()
        {
            UserEventServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UserEventServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UserEventServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UserEventServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UserEventServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<UserEventServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserEventServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserEventServiceClient.ChannelPool;
    }

    /// <summary>UserEventService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for ingesting end user actions on the customer website.
    /// </remarks>
    public abstract partial class UserEventServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserEventService service, which is a host of
        /// "recommendationengine.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "recommendationengine.googleapis.com:443";

        /// <summary>The default UserEventService scopes.</summary>
        /// <remarks>
        /// The default UserEventService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(UserEventService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="UserEventServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserEventServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UserEventServiceClient"/>.</returns>
        public static stt::Task<UserEventServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UserEventServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UserEventServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserEventServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UserEventServiceClient"/>.</returns>
        public static UserEventServiceClient Create() => new UserEventServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UserEventServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UserEventServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="UserEventServiceClient"/>.</returns>
        internal static UserEventServiceClient Create(grpccore::CallInvoker callInvoker, UserEventServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserEventService.UserEventServiceClient grpcClient = new UserEventService.UserEventServiceClient(callInvoker);
            return new UserEventServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC UserEventService client</summary>
        public virtual UserEventService.UserEventServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserEvent WriteUserEvent(WriteUserEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserEvent> WriteUserEventAsync(WriteUserEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserEvent> WriteUserEventAsync(WriteUserEventRequest request, st::CancellationToken cancellationToken) =>
            WriteUserEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore resource name, such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="userEvent">
        /// Required. User event to write.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserEvent WriteUserEvent(string parent, UserEvent userEvent, gaxgrpc::CallSettings callSettings = null) =>
            WriteUserEvent(new WriteUserEventRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserEvent = gax::GaxPreconditions.CheckNotNull(userEvent, nameof(userEvent)),
            }, callSettings);

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore resource name, such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="userEvent">
        /// Required. User event to write.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserEvent> WriteUserEventAsync(string parent, UserEvent userEvent, gaxgrpc::CallSettings callSettings = null) =>
            WriteUserEventAsync(new WriteUserEventRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserEvent = gax::GaxPreconditions.CheckNotNull(userEvent, nameof(userEvent)),
            }, callSettings);

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore resource name, such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="userEvent">
        /// Required. User event to write.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserEvent> WriteUserEventAsync(string parent, UserEvent userEvent, st::CancellationToken cancellationToken) =>
            WriteUserEventAsync(parent, userEvent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore resource name, such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="userEvent">
        /// Required. User event to write.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserEvent WriteUserEvent(EventStoreName parent, UserEvent userEvent, gaxgrpc::CallSettings callSettings = null) =>
            WriteUserEvent(new WriteUserEventRequest
            {
                ParentAsEventStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserEvent = gax::GaxPreconditions.CheckNotNull(userEvent, nameof(userEvent)),
            }, callSettings);

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore resource name, such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="userEvent">
        /// Required. User event to write.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserEvent> WriteUserEventAsync(EventStoreName parent, UserEvent userEvent, gaxgrpc::CallSettings callSettings = null) =>
            WriteUserEventAsync(new WriteUserEventRequest
            {
                ParentAsEventStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserEvent = gax::GaxPreconditions.CheckNotNull(userEvent, nameof(userEvent)),
            }, callSettings);

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore resource name, such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="userEvent">
        /// Required. User event to write.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserEvent> WriteUserEventAsync(EventStoreName parent, UserEvent userEvent, st::CancellationToken cancellationToken) =>
            WriteUserEventAsync(parent, userEvent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel.
        /// Users should not call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody CollectUserEvent(CollectUserEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel.
        /// Users should not call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> CollectUserEventAsync(CollectUserEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel.
        /// Users should not call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> CollectUserEventAsync(CollectUserEventRequest request, st::CancellationToken cancellationToken) =>
            CollectUserEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel.
        /// Users should not call this method directly.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore name, such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="userEvent">
        /// Required. URL encoded UserEvent proto.
        /// </param>
        /// <param name="uri">
        /// Optional. The url including cgi-parameters but excluding the hash fragment.
        /// The URL must be truncated to 1.5K bytes to conservatively be under the 2K
        /// bytes. This is often more useful than the referer url, because many
        /// browsers only send the domain for 3rd party requests.
        /// </param>
        /// <param name="ets">
        /// Optional. The event timestamp in milliseconds. This prevents browser
        /// caching of otherwise identical get requests. The name is abbreviated to
        /// reduce the payload bytes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody CollectUserEvent(string parent, string userEvent, string uri, long ets, gaxgrpc::CallSettings callSettings = null) =>
            CollectUserEvent(new CollectUserEventRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserEvent = gax::GaxPreconditions.CheckNotNullOrEmpty(userEvent, nameof(userEvent)),
                Uri = uri ?? "",
                Ets = ets,
            }, callSettings);

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel.
        /// Users should not call this method directly.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore name, such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="userEvent">
        /// Required. URL encoded UserEvent proto.
        /// </param>
        /// <param name="uri">
        /// Optional. The url including cgi-parameters but excluding the hash fragment.
        /// The URL must be truncated to 1.5K bytes to conservatively be under the 2K
        /// bytes. This is often more useful than the referer url, because many
        /// browsers only send the domain for 3rd party requests.
        /// </param>
        /// <param name="ets">
        /// Optional. The event timestamp in milliseconds. This prevents browser
        /// caching of otherwise identical get requests. The name is abbreviated to
        /// reduce the payload bytes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> CollectUserEventAsync(string parent, string userEvent, string uri, long ets, gaxgrpc::CallSettings callSettings = null) =>
            CollectUserEventAsync(new CollectUserEventRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                UserEvent = gax::GaxPreconditions.CheckNotNullOrEmpty(userEvent, nameof(userEvent)),
                Uri = uri ?? "",
                Ets = ets,
            }, callSettings);

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel.
        /// Users should not call this method directly.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore name, such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="userEvent">
        /// Required. URL encoded UserEvent proto.
        /// </param>
        /// <param name="uri">
        /// Optional. The url including cgi-parameters but excluding the hash fragment.
        /// The URL must be truncated to 1.5K bytes to conservatively be under the 2K
        /// bytes. This is often more useful than the referer url, because many
        /// browsers only send the domain for 3rd party requests.
        /// </param>
        /// <param name="ets">
        /// Optional. The event timestamp in milliseconds. This prevents browser
        /// caching of otherwise identical get requests. The name is abbreviated to
        /// reduce the payload bytes.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> CollectUserEventAsync(string parent, string userEvent, string uri, long ets, st::CancellationToken cancellationToken) =>
            CollectUserEventAsync(parent, userEvent, uri, ets, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel.
        /// Users should not call this method directly.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore name, such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="userEvent">
        /// Required. URL encoded UserEvent proto.
        /// </param>
        /// <param name="uri">
        /// Optional. The url including cgi-parameters but excluding the hash fragment.
        /// The URL must be truncated to 1.5K bytes to conservatively be under the 2K
        /// bytes. This is often more useful than the referer url, because many
        /// browsers only send the domain for 3rd party requests.
        /// </param>
        /// <param name="ets">
        /// Optional. The event timestamp in milliseconds. This prevents browser
        /// caching of otherwise identical get requests. The name is abbreviated to
        /// reduce the payload bytes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody CollectUserEvent(EventStoreName parent, string userEvent, string uri, long ets, gaxgrpc::CallSettings callSettings = null) =>
            CollectUserEvent(new CollectUserEventRequest
            {
                ParentAsEventStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserEvent = gax::GaxPreconditions.CheckNotNullOrEmpty(userEvent, nameof(userEvent)),
                Uri = uri ?? "",
                Ets = ets,
            }, callSettings);

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel.
        /// Users should not call this method directly.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore name, such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="userEvent">
        /// Required. URL encoded UserEvent proto.
        /// </param>
        /// <param name="uri">
        /// Optional. The url including cgi-parameters but excluding the hash fragment.
        /// The URL must be truncated to 1.5K bytes to conservatively be under the 2K
        /// bytes. This is often more useful than the referer url, because many
        /// browsers only send the domain for 3rd party requests.
        /// </param>
        /// <param name="ets">
        /// Optional. The event timestamp in milliseconds. This prevents browser
        /// caching of otherwise identical get requests. The name is abbreviated to
        /// reduce the payload bytes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> CollectUserEventAsync(EventStoreName parent, string userEvent, string uri, long ets, gaxgrpc::CallSettings callSettings = null) =>
            CollectUserEventAsync(new CollectUserEventRequest
            {
                ParentAsEventStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                UserEvent = gax::GaxPreconditions.CheckNotNullOrEmpty(userEvent, nameof(userEvent)),
                Uri = uri ?? "",
                Ets = ets,
            }, callSettings);

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel.
        /// Users should not call this method directly.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore name, such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="userEvent">
        /// Required. URL encoded UserEvent proto.
        /// </param>
        /// <param name="uri">
        /// Optional. The url including cgi-parameters but excluding the hash fragment.
        /// The URL must be truncated to 1.5K bytes to conservatively be under the 2K
        /// bytes. This is often more useful than the referer url, because many
        /// browsers only send the domain for 3rd party requests.
        /// </param>
        /// <param name="ets">
        /// Optional. The event timestamp in milliseconds. This prevents browser
        /// caching of otherwise identical get requests. The name is abbreviated to
        /// reduce the payload bytes.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> CollectUserEventAsync(EventStoreName parent, string userEvent, string uri, long ets, st::CancellationToken cancellationToken) =>
            CollectUserEventAsync(parent, userEvent, uri, ets, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a list of user events within a time range, with potential filtering.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserEventsResponse, UserEvent> ListUserEvents(ListUserEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of user events within a time range, with potential filtering.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserEventsResponse, UserEvent> ListUserEventsAsync(ListUserEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of user events within a time range, with potential filtering.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore resource name, such as
        /// `projects/*/locations/*/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="filter">
        /// Optional. Filtering expression to specify restrictions over
        /// returned events. This is a sequence of terms, where each term applies some
        /// kind of a restriction to the returned user events. Use this expression to
        /// restrict results to a specific time range, or filter events by eventType.
        /// eg: eventTime &gt; "2012-04-23T18:25:43.511Z" eventsMissingCatalogItems
        /// eventTime&lt;"2012-04-23T18:25:43.511Z" eventType=search
        /// 
        /// We expect only 3 types of fields:
        /// 
        /// * eventTime: this can be specified a maximum of 2 times, once with a
        /// less than operator and once with a greater than operator. The
        /// eventTime restrict should result in one contiguous valid eventTime
        /// range.
        /// 
        /// * eventType: only 1 eventType restriction can be specified.
        /// 
        /// * eventsMissingCatalogItems: specififying this will restrict results
        /// to events for which catalog items were not found in the catalog. The
        /// default behavior is to return only those events for which catalog
        /// items were found.
        /// 
        /// Some examples of valid filters expressions:
        /// 
        /// * Example 1: eventTime &gt; "2012-04-23T18:25:43.511Z"
        /// eventTime &lt; "2012-04-23T18:30:43.511Z"
        /// * Example 2: eventTime &gt; "2012-04-23T18:25:43.511Z"
        /// eventType = detail-page-view
        /// * Example 3: eventsMissingCatalogItems
        /// eventType = search eventTime &lt; "2018-04-23T18:30:43.511Z"
        /// * Example 4: eventTime &gt; "2012-04-23T18:25:43.511Z"
        /// * Example 5: eventType = search
        /// * Example 6: eventsMissingCatalogItems
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
        /// <returns>A pageable sequence of <see cref="UserEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserEventsResponse, UserEvent> ListUserEvents(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserEventsRequest request = new ListUserEventsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserEvents(request, callSettings);
        }

        /// <summary>
        /// Gets a list of user events within a time range, with potential filtering.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore resource name, such as
        /// `projects/*/locations/*/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="filter">
        /// Optional. Filtering expression to specify restrictions over
        /// returned events. This is a sequence of terms, where each term applies some
        /// kind of a restriction to the returned user events. Use this expression to
        /// restrict results to a specific time range, or filter events by eventType.
        /// eg: eventTime &gt; "2012-04-23T18:25:43.511Z" eventsMissingCatalogItems
        /// eventTime&lt;"2012-04-23T18:25:43.511Z" eventType=search
        /// 
        /// We expect only 3 types of fields:
        /// 
        /// * eventTime: this can be specified a maximum of 2 times, once with a
        /// less than operator and once with a greater than operator. The
        /// eventTime restrict should result in one contiguous valid eventTime
        /// range.
        /// 
        /// * eventType: only 1 eventType restriction can be specified.
        /// 
        /// * eventsMissingCatalogItems: specififying this will restrict results
        /// to events for which catalog items were not found in the catalog. The
        /// default behavior is to return only those events for which catalog
        /// items were found.
        /// 
        /// Some examples of valid filters expressions:
        /// 
        /// * Example 1: eventTime &gt; "2012-04-23T18:25:43.511Z"
        /// eventTime &lt; "2012-04-23T18:30:43.511Z"
        /// * Example 2: eventTime &gt; "2012-04-23T18:25:43.511Z"
        /// eventType = detail-page-view
        /// * Example 3: eventsMissingCatalogItems
        /// eventType = search eventTime &lt; "2018-04-23T18:30:43.511Z"
        /// * Example 4: eventTime &gt; "2012-04-23T18:25:43.511Z"
        /// * Example 5: eventType = search
        /// * Example 6: eventsMissingCatalogItems
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserEventsResponse, UserEvent> ListUserEventsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserEventsRequest request = new ListUserEventsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a list of user events within a time range, with potential filtering.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore resource name, such as
        /// `projects/*/locations/*/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="filter">
        /// Optional. Filtering expression to specify restrictions over
        /// returned events. This is a sequence of terms, where each term applies some
        /// kind of a restriction to the returned user events. Use this expression to
        /// restrict results to a specific time range, or filter events by eventType.
        /// eg: eventTime &gt; "2012-04-23T18:25:43.511Z" eventsMissingCatalogItems
        /// eventTime&lt;"2012-04-23T18:25:43.511Z" eventType=search
        /// 
        /// We expect only 3 types of fields:
        /// 
        /// * eventTime: this can be specified a maximum of 2 times, once with a
        /// less than operator and once with a greater than operator. The
        /// eventTime restrict should result in one contiguous valid eventTime
        /// range.
        /// 
        /// * eventType: only 1 eventType restriction can be specified.
        /// 
        /// * eventsMissingCatalogItems: specififying this will restrict results
        /// to events for which catalog items were not found in the catalog. The
        /// default behavior is to return only those events for which catalog
        /// items were found.
        /// 
        /// Some examples of valid filters expressions:
        /// 
        /// * Example 1: eventTime &gt; "2012-04-23T18:25:43.511Z"
        /// eventTime &lt; "2012-04-23T18:30:43.511Z"
        /// * Example 2: eventTime &gt; "2012-04-23T18:25:43.511Z"
        /// eventType = detail-page-view
        /// * Example 3: eventsMissingCatalogItems
        /// eventType = search eventTime &lt; "2018-04-23T18:30:43.511Z"
        /// * Example 4: eventTime &gt; "2012-04-23T18:25:43.511Z"
        /// * Example 5: eventType = search
        /// * Example 6: eventsMissingCatalogItems
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
        /// <returns>A pageable sequence of <see cref="UserEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListUserEventsResponse, UserEvent> ListUserEvents(EventStoreName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserEventsRequest request = new ListUserEventsRequest
            {
                ParentAsEventStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserEvents(request, callSettings);
        }

        /// <summary>
        /// Gets a list of user events within a time range, with potential filtering.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent eventStore resource name, such as
        /// `projects/*/locations/*/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="filter">
        /// Optional. Filtering expression to specify restrictions over
        /// returned events. This is a sequence of terms, where each term applies some
        /// kind of a restriction to the returned user events. Use this expression to
        /// restrict results to a specific time range, or filter events by eventType.
        /// eg: eventTime &gt; "2012-04-23T18:25:43.511Z" eventsMissingCatalogItems
        /// eventTime&lt;"2012-04-23T18:25:43.511Z" eventType=search
        /// 
        /// We expect only 3 types of fields:
        /// 
        /// * eventTime: this can be specified a maximum of 2 times, once with a
        /// less than operator and once with a greater than operator. The
        /// eventTime restrict should result in one contiguous valid eventTime
        /// range.
        /// 
        /// * eventType: only 1 eventType restriction can be specified.
        /// 
        /// * eventsMissingCatalogItems: specififying this will restrict results
        /// to events for which catalog items were not found in the catalog. The
        /// default behavior is to return only those events for which catalog
        /// items were found.
        /// 
        /// Some examples of valid filters expressions:
        /// 
        /// * Example 1: eventTime &gt; "2012-04-23T18:25:43.511Z"
        /// eventTime &lt; "2012-04-23T18:30:43.511Z"
        /// * Example 2: eventTime &gt; "2012-04-23T18:25:43.511Z"
        /// eventType = detail-page-view
        /// * Example 3: eventsMissingCatalogItems
        /// eventType = search eventTime &lt; "2018-04-23T18:30:43.511Z"
        /// * Example 4: eventTime &gt; "2012-04-23T18:25:43.511Z"
        /// * Example 5: eventType = search
        /// * Example 6: eventsMissingCatalogItems
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
        /// <returns>A pageable asynchronous sequence of <see cref="UserEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListUserEventsResponse, UserEvent> ListUserEventsAsync(EventStoreName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUserEventsRequest request = new ListUserEventsRequest
            {
                ParentAsEventStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListUserEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> PurgeUserEvents(PurgeUserEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata>> PurgeUserEventsAsync(PurgeUserEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata>> PurgeUserEventsAsync(PurgeUserEventsRequest request, st::CancellationToken cancellationToken) =>
            PurgeUserEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PurgeUserEvents</c>.</summary>
        public virtual lro::OperationsClient PurgeUserEventsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PurgeUserEvents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> PollOncePurgeUserEvents(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeUserEventsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PurgeUserEvents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata>> PollOncePurgeUserEventsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeUserEventsOperationsClient, callSettings);

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the event_store under which the events are
        /// created. The format is
        /// `projects/${projectId}/locations/global/catalogs/${catalogId}/eventStores/${eventStoreId}`
        /// </param>
        /// <param name="filter">
        /// Required. The filter string to specify the events to be deleted. Empty
        /// string filter is not allowed. This filter can also be used with
        /// ListUserEvents API to list events that will be deleted. The eligible fields
        /// for filtering are:
        /// * eventType - UserEvent.eventType field of type string.
        /// * eventTime - in ISO 8601 "zulu" format.
        /// * visitorId - field of type string. Specifying this will delete all events
        /// associated with a visitor.
        /// * userId - field of type string. Specifying this will delete all events
        /// associated with a user.
        /// Example 1: Deleting all events in a time range.
        /// `eventTime &gt; "2012-04-23T18:25:43.511Z" eventTime &lt;
        /// "2012-04-23T18:30:43.511Z"`
        /// Example 2: Deleting specific eventType in time range.
        /// `eventTime &gt; "2012-04-23T18:25:43.511Z" eventType = "detail-page-view"`
        /// Example 3: Deleting all events for a specific visitor
        /// `visitorId = visitor1024`
        /// The filtering fields are assumed to have an implicit AND.
        /// </param>
        /// <param name="force">
        /// Optional. The default value is false. Override this flag to true to
        /// actually perform the purge. If the field is not set to true, a sampling of
        /// events to be deleted will be returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> PurgeUserEvents(string parent, string filter, bool force, gaxgrpc::CallSettings callSettings = null) =>
            PurgeUserEvents(new PurgeUserEventsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the event_store under which the events are
        /// created. The format is
        /// `projects/${projectId}/locations/global/catalogs/${catalogId}/eventStores/${eventStoreId}`
        /// </param>
        /// <param name="filter">
        /// Required. The filter string to specify the events to be deleted. Empty
        /// string filter is not allowed. This filter can also be used with
        /// ListUserEvents API to list events that will be deleted. The eligible fields
        /// for filtering are:
        /// * eventType - UserEvent.eventType field of type string.
        /// * eventTime - in ISO 8601 "zulu" format.
        /// * visitorId - field of type string. Specifying this will delete all events
        /// associated with a visitor.
        /// * userId - field of type string. Specifying this will delete all events
        /// associated with a user.
        /// Example 1: Deleting all events in a time range.
        /// `eventTime &gt; "2012-04-23T18:25:43.511Z" eventTime &lt;
        /// "2012-04-23T18:30:43.511Z"`
        /// Example 2: Deleting specific eventType in time range.
        /// `eventTime &gt; "2012-04-23T18:25:43.511Z" eventType = "detail-page-view"`
        /// Example 3: Deleting all events for a specific visitor
        /// `visitorId = visitor1024`
        /// The filtering fields are assumed to have an implicit AND.
        /// </param>
        /// <param name="force">
        /// Optional. The default value is false. Override this flag to true to
        /// actually perform the purge. If the field is not set to true, a sampling of
        /// events to be deleted will be returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata>> PurgeUserEventsAsync(string parent, string filter, bool force, gaxgrpc::CallSettings callSettings = null) =>
            PurgeUserEventsAsync(new PurgeUserEventsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the event_store under which the events are
        /// created. The format is
        /// `projects/${projectId}/locations/global/catalogs/${catalogId}/eventStores/${eventStoreId}`
        /// </param>
        /// <param name="filter">
        /// Required. The filter string to specify the events to be deleted. Empty
        /// string filter is not allowed. This filter can also be used with
        /// ListUserEvents API to list events that will be deleted. The eligible fields
        /// for filtering are:
        /// * eventType - UserEvent.eventType field of type string.
        /// * eventTime - in ISO 8601 "zulu" format.
        /// * visitorId - field of type string. Specifying this will delete all events
        /// associated with a visitor.
        /// * userId - field of type string. Specifying this will delete all events
        /// associated with a user.
        /// Example 1: Deleting all events in a time range.
        /// `eventTime &gt; "2012-04-23T18:25:43.511Z" eventTime &lt;
        /// "2012-04-23T18:30:43.511Z"`
        /// Example 2: Deleting specific eventType in time range.
        /// `eventTime &gt; "2012-04-23T18:25:43.511Z" eventType = "detail-page-view"`
        /// Example 3: Deleting all events for a specific visitor
        /// `visitorId = visitor1024`
        /// The filtering fields are assumed to have an implicit AND.
        /// </param>
        /// <param name="force">
        /// Optional. The default value is false. Override this flag to true to
        /// actually perform the purge. If the field is not set to true, a sampling of
        /// events to be deleted will be returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata>> PurgeUserEventsAsync(string parent, string filter, bool force, st::CancellationToken cancellationToken) =>
            PurgeUserEventsAsync(parent, filter, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the event_store under which the events are
        /// created. The format is
        /// `projects/${projectId}/locations/global/catalogs/${catalogId}/eventStores/${eventStoreId}`
        /// </param>
        /// <param name="filter">
        /// Required. The filter string to specify the events to be deleted. Empty
        /// string filter is not allowed. This filter can also be used with
        /// ListUserEvents API to list events that will be deleted. The eligible fields
        /// for filtering are:
        /// * eventType - UserEvent.eventType field of type string.
        /// * eventTime - in ISO 8601 "zulu" format.
        /// * visitorId - field of type string. Specifying this will delete all events
        /// associated with a visitor.
        /// * userId - field of type string. Specifying this will delete all events
        /// associated with a user.
        /// Example 1: Deleting all events in a time range.
        /// `eventTime &gt; "2012-04-23T18:25:43.511Z" eventTime &lt;
        /// "2012-04-23T18:30:43.511Z"`
        /// Example 2: Deleting specific eventType in time range.
        /// `eventTime &gt; "2012-04-23T18:25:43.511Z" eventType = "detail-page-view"`
        /// Example 3: Deleting all events for a specific visitor
        /// `visitorId = visitor1024`
        /// The filtering fields are assumed to have an implicit AND.
        /// </param>
        /// <param name="force">
        /// Optional. The default value is false. Override this flag to true to
        /// actually perform the purge. If the field is not set to true, a sampling of
        /// events to be deleted will be returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> PurgeUserEvents(EventStoreName parent, string filter, bool force, gaxgrpc::CallSettings callSettings = null) =>
            PurgeUserEvents(new PurgeUserEventsRequest
            {
                ParentAsEventStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the event_store under which the events are
        /// created. The format is
        /// `projects/${projectId}/locations/global/catalogs/${catalogId}/eventStores/${eventStoreId}`
        /// </param>
        /// <param name="filter">
        /// Required. The filter string to specify the events to be deleted. Empty
        /// string filter is not allowed. This filter can also be used with
        /// ListUserEvents API to list events that will be deleted. The eligible fields
        /// for filtering are:
        /// * eventType - UserEvent.eventType field of type string.
        /// * eventTime - in ISO 8601 "zulu" format.
        /// * visitorId - field of type string. Specifying this will delete all events
        /// associated with a visitor.
        /// * userId - field of type string. Specifying this will delete all events
        /// associated with a user.
        /// Example 1: Deleting all events in a time range.
        /// `eventTime &gt; "2012-04-23T18:25:43.511Z" eventTime &lt;
        /// "2012-04-23T18:30:43.511Z"`
        /// Example 2: Deleting specific eventType in time range.
        /// `eventTime &gt; "2012-04-23T18:25:43.511Z" eventType = "detail-page-view"`
        /// Example 3: Deleting all events for a specific visitor
        /// `visitorId = visitor1024`
        /// The filtering fields are assumed to have an implicit AND.
        /// </param>
        /// <param name="force">
        /// Optional. The default value is false. Override this flag to true to
        /// actually perform the purge. If the field is not set to true, a sampling of
        /// events to be deleted will be returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata>> PurgeUserEventsAsync(EventStoreName parent, string filter, bool force, gaxgrpc::CallSettings callSettings = null) =>
            PurgeUserEventsAsync(new PurgeUserEventsRequest
            {
                ParentAsEventStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the event_store under which the events are
        /// created. The format is
        /// `projects/${projectId}/locations/global/catalogs/${catalogId}/eventStores/${eventStoreId}`
        /// </param>
        /// <param name="filter">
        /// Required. The filter string to specify the events to be deleted. Empty
        /// string filter is not allowed. This filter can also be used with
        /// ListUserEvents API to list events that will be deleted. The eligible fields
        /// for filtering are:
        /// * eventType - UserEvent.eventType field of type string.
        /// * eventTime - in ISO 8601 "zulu" format.
        /// * visitorId - field of type string. Specifying this will delete all events
        /// associated with a visitor.
        /// * userId - field of type string. Specifying this will delete all events
        /// associated with a user.
        /// Example 1: Deleting all events in a time range.
        /// `eventTime &gt; "2012-04-23T18:25:43.511Z" eventTime &lt;
        /// "2012-04-23T18:30:43.511Z"`
        /// Example 2: Deleting specific eventType in time range.
        /// `eventTime &gt; "2012-04-23T18:25:43.511Z" eventType = "detail-page-view"`
        /// Example 3: Deleting all events for a specific visitor
        /// `visitorId = visitor1024`
        /// The filtering fields are assumed to have an implicit AND.
        /// </param>
        /// <param name="force">
        /// Optional. The default value is false. Override this flag to true to
        /// actually perform the purge. If the field is not set to true, a sampling of
        /// events to be deleted will be returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata>> PurgeUserEventsAsync(EventStoreName parent, string filter, bool force, st::CancellationToken cancellationToken) =>
            PurgeUserEventsAsync(parent, filter, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportUserEventsResponse, ImportMetadata> ImportUserEvents(ImportUserEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportUserEventsResponse, ImportMetadata>> ImportUserEventsAsync(ImportUserEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportUserEventsResponse, ImportMetadata>> ImportUserEventsAsync(ImportUserEventsRequest request, st::CancellationToken cancellationToken) =>
            ImportUserEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportUserEvents</c>.</summary>
        public virtual lro::OperationsClient ImportUserEventsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportUserEvents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportUserEventsResponse, ImportMetadata> PollOnceImportUserEvents(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportUserEventsResponse, ImportMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportUserEventsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportUserEvents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportUserEventsResponse, ImportMetadata>> PollOnceImportUserEventsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportUserEventsResponse, ImportMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportUserEventsOperationsClient, callSettings);

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="parent">
        /// Required.
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`
        /// </param>
        /// <param name="requestId">
        /// Optional. Unique identifier provided by client, within the ancestor
        /// dataset scope. Ensures idempotency for expensive long running operations.
        /// Server-generated if unspecified. Up to 128 characters long. This is
        /// returned as google.longrunning.Operation.name in the response. Note that
        /// this field must not be set if the desired input config is
        /// catalog_inline_source.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location of the data.
        /// </param>
        /// <param name="errorsConfig">
        /// Optional. The desired location of errors incurred during the Import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportUserEventsResponse, ImportMetadata> ImportUserEvents(string parent, string requestId, InputConfig inputConfig, ImportErrorsConfig errorsConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportUserEvents(new ImportUserEventsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RequestId = requestId ?? "",
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                ErrorsConfig = errorsConfig,
            }, callSettings);

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="parent">
        /// Required.
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`
        /// </param>
        /// <param name="requestId">
        /// Optional. Unique identifier provided by client, within the ancestor
        /// dataset scope. Ensures idempotency for expensive long running operations.
        /// Server-generated if unspecified. Up to 128 characters long. This is
        /// returned as google.longrunning.Operation.name in the response. Note that
        /// this field must not be set if the desired input config is
        /// catalog_inline_source.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location of the data.
        /// </param>
        /// <param name="errorsConfig">
        /// Optional. The desired location of errors incurred during the Import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportUserEventsResponse, ImportMetadata>> ImportUserEventsAsync(string parent, string requestId, InputConfig inputConfig, ImportErrorsConfig errorsConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportUserEventsAsync(new ImportUserEventsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RequestId = requestId ?? "",
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                ErrorsConfig = errorsConfig,
            }, callSettings);

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="parent">
        /// Required.
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`
        /// </param>
        /// <param name="requestId">
        /// Optional. Unique identifier provided by client, within the ancestor
        /// dataset scope. Ensures idempotency for expensive long running operations.
        /// Server-generated if unspecified. Up to 128 characters long. This is
        /// returned as google.longrunning.Operation.name in the response. Note that
        /// this field must not be set if the desired input config is
        /// catalog_inline_source.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location of the data.
        /// </param>
        /// <param name="errorsConfig">
        /// Optional. The desired location of errors incurred during the Import.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportUserEventsResponse, ImportMetadata>> ImportUserEventsAsync(string parent, string requestId, InputConfig inputConfig, ImportErrorsConfig errorsConfig, st::CancellationToken cancellationToken) =>
            ImportUserEventsAsync(parent, requestId, inputConfig, errorsConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="parent">
        /// Required.
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`
        /// </param>
        /// <param name="requestId">
        /// Optional. Unique identifier provided by client, within the ancestor
        /// dataset scope. Ensures idempotency for expensive long running operations.
        /// Server-generated if unspecified. Up to 128 characters long. This is
        /// returned as google.longrunning.Operation.name in the response. Note that
        /// this field must not be set if the desired input config is
        /// catalog_inline_source.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location of the data.
        /// </param>
        /// <param name="errorsConfig">
        /// Optional. The desired location of errors incurred during the Import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportUserEventsResponse, ImportMetadata> ImportUserEvents(EventStoreName parent, string requestId, InputConfig inputConfig, ImportErrorsConfig errorsConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportUserEvents(new ImportUserEventsRequest
            {
                ParentAsEventStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RequestId = requestId ?? "",
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                ErrorsConfig = errorsConfig,
            }, callSettings);

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="parent">
        /// Required.
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`
        /// </param>
        /// <param name="requestId">
        /// Optional. Unique identifier provided by client, within the ancestor
        /// dataset scope. Ensures idempotency for expensive long running operations.
        /// Server-generated if unspecified. Up to 128 characters long. This is
        /// returned as google.longrunning.Operation.name in the response. Note that
        /// this field must not be set if the desired input config is
        /// catalog_inline_source.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location of the data.
        /// </param>
        /// <param name="errorsConfig">
        /// Optional. The desired location of errors incurred during the Import.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportUserEventsResponse, ImportMetadata>> ImportUserEventsAsync(EventStoreName parent, string requestId, InputConfig inputConfig, ImportErrorsConfig errorsConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportUserEventsAsync(new ImportUserEventsRequest
            {
                ParentAsEventStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RequestId = requestId ?? "",
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
                ErrorsConfig = errorsConfig,
            }, callSettings);

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="parent">
        /// Required.
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`
        /// </param>
        /// <param name="requestId">
        /// Optional. Unique identifier provided by client, within the ancestor
        /// dataset scope. Ensures idempotency for expensive long running operations.
        /// Server-generated if unspecified. Up to 128 characters long. This is
        /// returned as google.longrunning.Operation.name in the response. Note that
        /// this field must not be set if the desired input config is
        /// catalog_inline_source.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location of the data.
        /// </param>
        /// <param name="errorsConfig">
        /// Optional. The desired location of errors incurred during the Import.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportUserEventsResponse, ImportMetadata>> ImportUserEventsAsync(EventStoreName parent, string requestId, InputConfig inputConfig, ImportErrorsConfig errorsConfig, st::CancellationToken cancellationToken) =>
            ImportUserEventsAsync(parent, requestId, inputConfig, errorsConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>UserEventService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for ingesting end user actions on the customer website.
    /// </remarks>
    public sealed partial class UserEventServiceClientImpl : UserEventServiceClient
    {
        private readonly gaxgrpc::ApiCall<WriteUserEventRequest, UserEvent> _callWriteUserEvent;

        private readonly gaxgrpc::ApiCall<CollectUserEventRequest, ga::HttpBody> _callCollectUserEvent;

        private readonly gaxgrpc::ApiCall<ListUserEventsRequest, ListUserEventsResponse> _callListUserEvents;

        private readonly gaxgrpc::ApiCall<PurgeUserEventsRequest, lro::Operation> _callPurgeUserEvents;

        private readonly gaxgrpc::ApiCall<ImportUserEventsRequest, lro::Operation> _callImportUserEvents;

        /// <summary>
        /// Constructs a client wrapper for the UserEventService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UserEventServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public UserEventServiceClientImpl(UserEventService.UserEventServiceClient grpcClient, UserEventServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            UserEventServiceSettings effectiveSettings = settings ?? UserEventServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            PurgeUserEventsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PurgeUserEventsOperationsSettings, logger);
            ImportUserEventsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportUserEventsOperationsSettings, logger);
            _callWriteUserEvent = clientHelper.BuildApiCall<WriteUserEventRequest, UserEvent>("WriteUserEvent", grpcClient.WriteUserEventAsync, grpcClient.WriteUserEvent, effectiveSettings.WriteUserEventSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callWriteUserEvent);
            Modify_WriteUserEventApiCall(ref _callWriteUserEvent);
            _callCollectUserEvent = clientHelper.BuildApiCall<CollectUserEventRequest, ga::HttpBody>("CollectUserEvent", grpcClient.CollectUserEventAsync, grpcClient.CollectUserEvent, effectiveSettings.CollectUserEventSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCollectUserEvent);
            Modify_CollectUserEventApiCall(ref _callCollectUserEvent);
            _callListUserEvents = clientHelper.BuildApiCall<ListUserEventsRequest, ListUserEventsResponse>("ListUserEvents", grpcClient.ListUserEventsAsync, grpcClient.ListUserEvents, effectiveSettings.ListUserEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListUserEvents);
            Modify_ListUserEventsApiCall(ref _callListUserEvents);
            _callPurgeUserEvents = clientHelper.BuildApiCall<PurgeUserEventsRequest, lro::Operation>("PurgeUserEvents", grpcClient.PurgeUserEventsAsync, grpcClient.PurgeUserEvents, effectiveSettings.PurgeUserEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callPurgeUserEvents);
            Modify_PurgeUserEventsApiCall(ref _callPurgeUserEvents);
            _callImportUserEvents = clientHelper.BuildApiCall<ImportUserEventsRequest, lro::Operation>("ImportUserEvents", grpcClient.ImportUserEventsAsync, grpcClient.ImportUserEvents, effectiveSettings.ImportUserEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportUserEvents);
            Modify_ImportUserEventsApiCall(ref _callImportUserEvents);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_WriteUserEventApiCall(ref gaxgrpc::ApiCall<WriteUserEventRequest, UserEvent> call);

        partial void Modify_CollectUserEventApiCall(ref gaxgrpc::ApiCall<CollectUserEventRequest, ga::HttpBody> call);

        partial void Modify_ListUserEventsApiCall(ref gaxgrpc::ApiCall<ListUserEventsRequest, ListUserEventsResponse> call);

        partial void Modify_PurgeUserEventsApiCall(ref gaxgrpc::ApiCall<PurgeUserEventsRequest, lro::Operation> call);

        partial void Modify_ImportUserEventsApiCall(ref gaxgrpc::ApiCall<ImportUserEventsRequest, lro::Operation> call);

        partial void OnConstruction(UserEventService.UserEventServiceClient grpcClient, UserEventServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserEventService client</summary>
        public override UserEventService.UserEventServiceClient GrpcClient { get; }

        partial void Modify_WriteUserEventRequest(ref WriteUserEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CollectUserEventRequest(ref CollectUserEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUserEventsRequest(ref ListUserEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PurgeUserEventsRequest(ref PurgeUserEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportUserEventsRequest(ref ImportUserEventsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserEvent WriteUserEvent(WriteUserEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WriteUserEventRequest(ref request, ref callSettings);
            return _callWriteUserEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserEvent> WriteUserEventAsync(WriteUserEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WriteUserEventRequest(ref request, ref callSettings);
            return _callWriteUserEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel.
        /// Users should not call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::HttpBody CollectUserEvent(CollectUserEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CollectUserEventRequest(ref request, ref callSettings);
            return _callCollectUserEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel.
        /// Users should not call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::HttpBody> CollectUserEventAsync(CollectUserEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CollectUserEventRequest(ref request, ref callSettings);
            return _callCollectUserEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a list of user events within a time range, with potential filtering.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UserEvent"/> resources.</returns>
        public override gax::PagedEnumerable<ListUserEventsResponse, UserEvent> ListUserEvents(ListUserEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUserEventsRequest, ListUserEventsResponse, UserEvent>(_callListUserEvents, request, callSettings);
        }

        /// <summary>
        /// Gets a list of user events within a time range, with potential filtering.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UserEvent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListUserEventsResponse, UserEvent> ListUserEventsAsync(ListUserEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUserEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUserEventsRequest, ListUserEventsResponse, UserEvent>(_callListUserEvents, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>PurgeUserEvents</c>.</summary>
        public override lro::OperationsClient PurgeUserEventsOperationsClient { get; }

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata> PurgeUserEvents(PurgeUserEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeUserEventsRequest(ref request, ref callSettings);
            return new lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata>(_callPurgeUserEvents.Sync(request, callSettings), PurgeUserEventsOperationsClient);
        }

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata>> PurgeUserEventsAsync(PurgeUserEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeUserEventsRequest(ref request, ref callSettings);
            return new lro::Operation<PurgeUserEventsResponse, PurgeUserEventsMetadata>(await _callPurgeUserEvents.Async(request, callSettings).ConfigureAwait(false), PurgeUserEventsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportUserEvents</c>.</summary>
        public override lro::OperationsClient ImportUserEventsOperationsClient { get; }

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportUserEventsResponse, ImportMetadata> ImportUserEvents(ImportUserEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportUserEventsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportUserEventsResponse, ImportMetadata>(_callImportUserEvents.Sync(request, callSettings), ImportUserEventsOperationsClient);
        }

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportUserEventsResponse, ImportMetadata>> ImportUserEventsAsync(ImportUserEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportUserEventsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportUserEventsResponse, ImportMetadata>(await _callImportUserEvents.Async(request, callSettings).ConfigureAwait(false), ImportUserEventsOperationsClient);
        }
    }

    public partial class ListUserEventsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListUserEventsResponse : gaxgrpc::IPageResponse<UserEvent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UserEvent> GetEnumerator() => UserEvents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class UserEventService
    {
        public partial class UserEventServiceClient
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
