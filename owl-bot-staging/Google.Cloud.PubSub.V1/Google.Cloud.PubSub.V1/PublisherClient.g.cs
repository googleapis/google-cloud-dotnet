// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1
{
    /// <summary>Settings for <see cref="PublisherClient"/> instances.</summary>
    public sealed partial class PublisherSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PublisherSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PublisherSettings"/>.</returns>
        public static PublisherSettings GetDefault() => new PublisherSettings();

        /// <summary>Constructs a new <see cref="PublisherSettings"/> object with default settings.</summary>
        public PublisherSettings()
        {
        }

        private PublisherSettings(PublisherSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateTopicSettings = existing.CreateTopicSettings;
            UpdateTopicSettings = existing.UpdateTopicSettings;
            PublishSettings = existing.PublishSettings;
            GetTopicSettings = existing.GetTopicSettings;
            ListTopicsSettings = existing.ListTopicsSettings;
            ListTopicSubscriptionsSettings = existing.ListTopicSubscriptionsSettings;
            ListTopicSnapshotsSettings = existing.ListTopicSnapshotsSettings;
            DeleteTopicSettings = existing.DeleteTopicSettings;
            DetachSubscriptionSettings = existing.DetachSubscriptionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PublisherSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PublisherClient.CreateTopic</c>
        ///  and <c>PublisherClient.CreateTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTopicSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PublisherClient.UpdateTopic</c>
        ///  and <c>PublisherClient.UpdateTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTopicSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PublisherClient.Publish</c>
        /// and <c>PublisherClient.PublishAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Aborted"/>,
        /// <see cref="grpccore::StatusCode.Cancelled"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>, <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PublishSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.Internal, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PublisherClient.GetTopic</c>
        ///  and <c>PublisherClient.GetTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Aborted"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTopicSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Aborted, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PublisherClient.ListTopics</c>
        ///  and <c>PublisherClient.ListTopicsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Aborted"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTopicsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Aborted, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherClient.ListTopicSubscriptions</c> and <c>PublisherClient.ListTopicSubscriptionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Aborted"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTopicSubscriptionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Aborted, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherClient.ListTopicSnapshots</c> and <c>PublisherClient.ListTopicSnapshotsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Aborted"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTopicSnapshotsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Aborted, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PublisherClient.DeleteTopic</c>
        ///  and <c>PublisherClient.DeleteTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTopicSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherClient.DetachSubscription</c> and <c>PublisherClient.DetachSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DetachSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PublisherSettings"/> object.</returns>
        public PublisherSettings Clone() => new PublisherSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PublisherClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class PublisherClientBuilder : gaxgrpc::ClientBuilderBase<PublisherClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PublisherSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PublisherClientBuilder()
        {
            UseJwtAccessWithScopes = PublisherClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref PublisherClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PublisherClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PublisherClient Build()
        {
            PublisherClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PublisherClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PublisherClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PublisherClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PublisherClient.Create(callInvoker, Settings);
        }

        private async stt::Task<PublisherClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PublisherClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => PublisherClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PublisherClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PublisherClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Publisher client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that an application uses to manipulate topics, and to send
    /// messages to a topic.
    /// </remarks>
    public abstract partial class PublisherClient
    {
        /// <summary>
        /// The default endpoint for the Publisher service, which is a host of "pubsub.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "pubsub.googleapis.com:443";

        /// <summary>The default Publisher scopes.</summary>
        /// <remarks>
        /// The default Publisher scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/pubsub</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/pubsub",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="PublisherClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="PublisherClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PublisherClient"/>.</returns>
        public static stt::Task<PublisherClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PublisherClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PublisherClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="PublisherClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PublisherClient"/>.</returns>
        public static PublisherClient Create() => new PublisherClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PublisherClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PublisherSettings"/>.</param>
        /// <returns>The created <see cref="PublisherClient"/>.</returns>
        internal static PublisherClient Create(grpccore::CallInvoker callInvoker, PublisherSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Publisher.PublisherClient grpcClient = new Publisher.PublisherClient(callInvoker);
            return new PublisherClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Publisher client</summary>
        public virtual Publisher.PublisherClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/admin#resource_names).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic CreateTopic(Topic request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/admin#resource_names).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(Topic request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/admin#resource_names).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(Topic request, st::CancellationToken cancellationToken) =>
            CreateTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/admin#resource_names).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic. It must have the format
        /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter,
        /// and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent
        /// signs (`%`). It must be between 3 and 255 characters in length, and it
        /// must not start with `"goog"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic CreateTopic(string name, gaxgrpc::CallSettings callSettings = null) =>
            CreateTopic(new Topic
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/admin#resource_names).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic. It must have the format
        /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter,
        /// and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent
        /// signs (`%`). It must be between 3 and 255 characters in length, and it
        /// must not start with `"goog"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CreateTopicAsync(new Topic
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/admin#resource_names).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic. It must have the format
        /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter,
        /// and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent
        /// signs (`%`). It must be between 3 and 255 characters in length, and it
        /// must not start with `"goog"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(string name, st::CancellationToken cancellationToken) =>
            CreateTopicAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/admin#resource_names).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic. It must have the format
        /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter,
        /// and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent
        /// signs (`%`). It must be between 3 and 255 characters in length, and it
        /// must not start with `"goog"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic CreateTopic(TopicName name, gaxgrpc::CallSettings callSettings = null) =>
            CreateTopic(new Topic
            {
                TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/admin#resource_names).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic. It must have the format
        /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter,
        /// and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent
        /// signs (`%`). It must be between 3 and 255 characters in length, and it
        /// must not start with `"goog"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(TopicName name, gaxgrpc::CallSettings callSettings = null) =>
            CreateTopicAsync(new Topic
            {
                TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/admin#resource_names).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic. It must have the format
        /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter,
        /// and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent
        /// signs (`%`). It must be between 3 and 255 characters in length, and it
        /// must not start with `"goog"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(TopicName name, st::CancellationToken cancellationToken) =>
            CreateTopicAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing topic. Note that certain properties of a
        /// topic are not modifiable.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic UpdateTopic(UpdateTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing topic. Note that certain properties of a
        /// topic are not modifiable.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> UpdateTopicAsync(UpdateTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing topic. Note that certain properties of a
        /// topic are not modifiable.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> UpdateTopicAsync(UpdateTopicRequest request, st::CancellationToken cancellationToken) =>
            UpdateTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublishResponse Publish(PublishRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublishResponse> PublishAsync(PublishRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublishResponse> PublishAsync(PublishRequest request, st::CancellationToken cancellationToken) =>
            PublishAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
        /// </summary>
        /// <param name="topic">
        /// Required. The messages in the request will be published on this topic.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="messages">
        /// Required. The messages to publish.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublishResponse Publish(string topic, scg::IEnumerable<PubsubMessage> messages, gaxgrpc::CallSettings callSettings = null) =>
            Publish(new PublishRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
                Messages =
                {
                    gax::GaxPreconditions.CheckNotNull(messages, nameof(messages)),
                },
            }, callSettings);

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
        /// </summary>
        /// <param name="topic">
        /// Required. The messages in the request will be published on this topic.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="messages">
        /// Required. The messages to publish.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublishResponse> PublishAsync(string topic, scg::IEnumerable<PubsubMessage> messages, gaxgrpc::CallSettings callSettings = null) =>
            PublishAsync(new PublishRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
                Messages =
                {
                    gax::GaxPreconditions.CheckNotNull(messages, nameof(messages)),
                },
            }, callSettings);

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
        /// </summary>
        /// <param name="topic">
        /// Required. The messages in the request will be published on this topic.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="messages">
        /// Required. The messages to publish.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublishResponse> PublishAsync(string topic, scg::IEnumerable<PubsubMessage> messages, st::CancellationToken cancellationToken) =>
            PublishAsync(topic, messages, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
        /// </summary>
        /// <param name="topic">
        /// Required. The messages in the request will be published on this topic.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="messages">
        /// Required. The messages to publish.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublishResponse Publish(TopicName topic, scg::IEnumerable<PubsubMessage> messages, gaxgrpc::CallSettings callSettings = null) =>
            Publish(new PublishRequest
            {
                TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                Messages =
                {
                    gax::GaxPreconditions.CheckNotNull(messages, nameof(messages)),
                },
            }, callSettings);

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
        /// </summary>
        /// <param name="topic">
        /// Required. The messages in the request will be published on this topic.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="messages">
        /// Required. The messages to publish.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublishResponse> PublishAsync(TopicName topic, scg::IEnumerable<PubsubMessage> messages, gaxgrpc::CallSettings callSettings = null) =>
            PublishAsync(new PublishRequest
            {
                TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                Messages =
                {
                    gax::GaxPreconditions.CheckNotNull(messages, nameof(messages)),
                },
            }, callSettings);

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
        /// </summary>
        /// <param name="topic">
        /// Required. The messages in the request will be published on this topic.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="messages">
        /// Required. The messages to publish.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublishResponse> PublishAsync(TopicName topic, scg::IEnumerable<PubsubMessage> messages, st::CancellationToken cancellationToken) =>
            PublishAsync(topic, messages, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic GetTopic(GetTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(GetTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(GetTopicRequest request, st::CancellationToken cancellationToken) =>
            GetTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The name of the topic to get.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic GetTopic(string topic, gaxgrpc::CallSettings callSettings = null) =>
            GetTopic(new GetTopicRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
            }, callSettings);

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The name of the topic to get.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(string topic, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicAsync(new GetTopicRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
            }, callSettings);

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The name of the topic to get.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(string topic, st::CancellationToken cancellationToken) =>
            GetTopicAsync(topic, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The name of the topic to get.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic GetTopic(TopicName topic, gaxgrpc::CallSettings callSettings = null) =>
            GetTopic(new GetTopicRequest
            {
                TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
            }, callSettings);

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The name of the topic to get.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(TopicName topic, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicAsync(new GetTopicRequest
            {
                TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
            }, callSettings);

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The name of the topic to get.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(TopicName topic, st::CancellationToken cancellationToken) =>
            GetTopicAsync(topic, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(ListTopicsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(ListTopicsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="project">
        /// Required. The name of the project in which to list topics.
        /// Format is `projects/{project-id}`.
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
        /// <returns>A pageable sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopics(new ListTopicsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="project">
        /// Required. The name of the project in which to list topics.
        /// Format is `projects/{project-id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicsAsync(new ListTopicsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="project">
        /// Required. The name of the project in which to list topics.
        /// Format is `projects/{project-id}`.
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
        /// <returns>A pageable sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(ProjectName project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopics(new ListTopicsRequest
            {
                ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="project">
        /// Required. The name of the project in which to list topics.
        /// Format is `projects/{project-id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(ProjectName project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicsAsync(new ListTopicsRequest
            {
                ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the names of the attached subscriptions on this topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptions(ListTopicSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the names of the attached subscriptions on this topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptionsAsync(ListTopicSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the names of the attached subscriptions on this topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The name of the topic that subscriptions are attached to.
        /// Format is `projects/{project}/topics/{topic}`.
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptions(string topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicSubscriptions(new ListTopicSubscriptionsRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the names of the attached subscriptions on this topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The name of the topic that subscriptions are attached to.
        /// Format is `projects/{project}/topics/{topic}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptionsAsync(string topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicSubscriptionsAsync(new ListTopicSubscriptionsRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the names of the attached subscriptions on this topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The name of the topic that subscriptions are attached to.
        /// Format is `projects/{project}/topics/{topic}`.
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptions(TopicName topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicSubscriptions(new ListTopicSubscriptionsRequest
            {
                TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the names of the attached subscriptions on this topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The name of the topic that subscriptions are attached to.
        /// Format is `projects/{project}/topics/{topic}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptionsAsync(TopicName topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicSubscriptionsAsync(new ListTopicSubscriptionsRequest
            {
                TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the names of the snapshots on this topic. Snapshots are used in
        /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations,
        /// which allow you to manage message acknowledgments in bulk. That is, you can
        /// set the acknowledgment state of messages in an existing subscription to the
        /// state captured by a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicSnapshotsResponse, string> ListTopicSnapshots(ListTopicSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the names of the snapshots on this topic. Snapshots are used in
        /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations,
        /// which allow you to manage message acknowledgments in bulk. That is, you can
        /// set the acknowledgment state of messages in an existing subscription to the
        /// state captured by a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicSnapshotsResponse, string> ListTopicSnapshotsAsync(ListTopicSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the names of the snapshots on this topic. Snapshots are used in
        /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations,
        /// which allow you to manage message acknowledgments in bulk. That is, you can
        /// set the acknowledgment state of messages in an existing subscription to the
        /// state captured by a snapshot.
        /// </summary>
        /// <param name="topic">
        /// Required. The name of the topic that snapshots are attached to.
        /// Format is `projects/{project}/topics/{topic}`.
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicSnapshotsResponse, string> ListTopicSnapshots(string topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicSnapshots(new ListTopicSnapshotsRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the names of the snapshots on this topic. Snapshots are used in
        /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations,
        /// which allow you to manage message acknowledgments in bulk. That is, you can
        /// set the acknowledgment state of messages in an existing subscription to the
        /// state captured by a snapshot.
        /// </summary>
        /// <param name="topic">
        /// Required. The name of the topic that snapshots are attached to.
        /// Format is `projects/{project}/topics/{topic}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicSnapshotsResponse, string> ListTopicSnapshotsAsync(string topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicSnapshotsAsync(new ListTopicSnapshotsRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the names of the snapshots on this topic. Snapshots are used in
        /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations,
        /// which allow you to manage message acknowledgments in bulk. That is, you can
        /// set the acknowledgment state of messages in an existing subscription to the
        /// state captured by a snapshot.
        /// </summary>
        /// <param name="topic">
        /// Required. The name of the topic that snapshots are attached to.
        /// Format is `projects/{project}/topics/{topic}`.
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicSnapshotsResponse, string> ListTopicSnapshots(TopicName topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicSnapshots(new ListTopicSnapshotsRequest
            {
                TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the names of the snapshots on this topic. Snapshots are used in
        /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations,
        /// which allow you to manage message acknowledgments in bulk. That is, you can
        /// set the acknowledgment state of messages in an existing subscription to the
        /// state captured by a snapshot.
        /// </summary>
        /// <param name="topic">
        /// Required. The name of the topic that snapshots are attached to.
        /// Format is `projects/{project}/topics/{topic}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicSnapshotsResponse, string> ListTopicSnapshotsAsync(TopicName topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicSnapshotsAsync(new ListTopicSnapshotsRequest
            {
                TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTopic(DeleteTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(DeleteTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(DeleteTopicRequest request, st::CancellationToken cancellationToken) =>
            DeleteTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="topic">
        /// Required. Name of the topic to delete.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTopic(string topic, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTopic(new DeleteTopicRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
            }, callSettings);

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="topic">
        /// Required. Name of the topic to delete.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(string topic, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTopicAsync(new DeleteTopicRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
            }, callSettings);

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="topic">
        /// Required. Name of the topic to delete.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(string topic, st::CancellationToken cancellationToken) =>
            DeleteTopicAsync(topic, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="topic">
        /// Required. Name of the topic to delete.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTopic(TopicName topic, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTopic(new DeleteTopicRequest
            {
                TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
            }, callSettings);

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="topic">
        /// Required. Name of the topic to delete.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(TopicName topic, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTopicAsync(new DeleteTopicRequest
            {
                TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
            }, callSettings);

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="topic">
        /// Required. Name of the topic to delete.
        /// Format is `projects/{project}/topics/{topic}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(TopicName topic, st::CancellationToken cancellationToken) =>
            DeleteTopicAsync(topic, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Detaches a subscription from this topic. All messages retained in the
        /// subscription are dropped. Subsequent `Pull` and `StreamingPull` requests
        /// will return FAILED_PRECONDITION. If the subscription is a push
        /// subscription, pushes to the endpoint will stop.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DetachSubscriptionResponse DetachSubscription(DetachSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Detaches a subscription from this topic. All messages retained in the
        /// subscription are dropped. Subsequent `Pull` and `StreamingPull` requests
        /// will return FAILED_PRECONDITION. If the subscription is a push
        /// subscription, pushes to the endpoint will stop.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetachSubscriptionResponse> DetachSubscriptionAsync(DetachSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Detaches a subscription from this topic. All messages retained in the
        /// subscription are dropped. Subsequent `Pull` and `StreamingPull` requests
        /// will return FAILED_PRECONDITION. If the subscription is a push
        /// subscription, pushes to the endpoint will stop.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetachSubscriptionResponse> DetachSubscriptionAsync(DetachSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            DetachSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Publisher client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that an application uses to manipulate topics, and to send
    /// messages to a topic.
    /// </remarks>
    public sealed partial class PublisherClientImpl : PublisherClient
    {
        private readonly gaxgrpc::ApiCall<Topic, Topic> _callCreateTopic;

        private readonly gaxgrpc::ApiCall<UpdateTopicRequest, Topic> _callUpdateTopic;

        private readonly gaxgrpc::ApiCall<PublishRequest, PublishResponse> _callPublish;

        private readonly gaxgrpc::ApiCall<GetTopicRequest, Topic> _callGetTopic;

        private readonly gaxgrpc::ApiCall<ListTopicsRequest, ListTopicsResponse> _callListTopics;

        private readonly gaxgrpc::ApiCall<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse> _callListTopicSubscriptions;

        private readonly gaxgrpc::ApiCall<ListTopicSnapshotsRequest, ListTopicSnapshotsResponse> _callListTopicSnapshots;

        private readonly gaxgrpc::ApiCall<DeleteTopicRequest, wkt::Empty> _callDeleteTopic;

        private readonly gaxgrpc::ApiCall<DetachSubscriptionRequest, DetachSubscriptionResponse> _callDetachSubscription;

        /// <summary>
        /// Constructs a client wrapper for the Publisher service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PublisherSettings"/> used within this client.</param>
        public PublisherClientImpl(Publisher.PublisherClient grpcClient, PublisherSettings settings)
        {
            GrpcClient = grpcClient;
            PublisherSettings effectiveSettings = settings ?? PublisherSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateTopic = clientHelper.BuildApiCall<Topic, Topic>(grpcClient.CreateTopicAsync, grpcClient.CreateTopic, effectiveSettings.CreateTopicSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCreateTopic);
            Modify_CreateTopicApiCall(ref _callCreateTopic);
            _callUpdateTopic = clientHelper.BuildApiCall<UpdateTopicRequest, Topic>(grpcClient.UpdateTopicAsync, grpcClient.UpdateTopic, effectiveSettings.UpdateTopicSettings).WithGoogleRequestParam("topic.name", request => request.Topic?.Name);
            Modify_ApiCall(ref _callUpdateTopic);
            Modify_UpdateTopicApiCall(ref _callUpdateTopic);
            _callPublish = clientHelper.BuildApiCall<PublishRequest, PublishResponse>(grpcClient.PublishAsync, grpcClient.Publish, effectiveSettings.PublishSettings).WithGoogleRequestParam("topic", request => request.Topic);
            Modify_ApiCall(ref _callPublish);
            Modify_PublishApiCall(ref _callPublish);
            _callGetTopic = clientHelper.BuildApiCall<GetTopicRequest, Topic>(grpcClient.GetTopicAsync, grpcClient.GetTopic, effectiveSettings.GetTopicSettings).WithGoogleRequestParam("topic", request => request.Topic);
            Modify_ApiCall(ref _callGetTopic);
            Modify_GetTopicApiCall(ref _callGetTopic);
            _callListTopics = clientHelper.BuildApiCall<ListTopicsRequest, ListTopicsResponse>(grpcClient.ListTopicsAsync, grpcClient.ListTopics, effectiveSettings.ListTopicsSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callListTopics);
            Modify_ListTopicsApiCall(ref _callListTopics);
            _callListTopicSubscriptions = clientHelper.BuildApiCall<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse>(grpcClient.ListTopicSubscriptionsAsync, grpcClient.ListTopicSubscriptions, effectiveSettings.ListTopicSubscriptionsSettings).WithGoogleRequestParam("topic", request => request.Topic);
            Modify_ApiCall(ref _callListTopicSubscriptions);
            Modify_ListTopicSubscriptionsApiCall(ref _callListTopicSubscriptions);
            _callListTopicSnapshots = clientHelper.BuildApiCall<ListTopicSnapshotsRequest, ListTopicSnapshotsResponse>(grpcClient.ListTopicSnapshotsAsync, grpcClient.ListTopicSnapshots, effectiveSettings.ListTopicSnapshotsSettings).WithGoogleRequestParam("topic", request => request.Topic);
            Modify_ApiCall(ref _callListTopicSnapshots);
            Modify_ListTopicSnapshotsApiCall(ref _callListTopicSnapshots);
            _callDeleteTopic = clientHelper.BuildApiCall<DeleteTopicRequest, wkt::Empty>(grpcClient.DeleteTopicAsync, grpcClient.DeleteTopic, effectiveSettings.DeleteTopicSettings).WithGoogleRequestParam("topic", request => request.Topic);
            Modify_ApiCall(ref _callDeleteTopic);
            Modify_DeleteTopicApiCall(ref _callDeleteTopic);
            _callDetachSubscription = clientHelper.BuildApiCall<DetachSubscriptionRequest, DetachSubscriptionResponse>(grpcClient.DetachSubscriptionAsync, grpcClient.DetachSubscription, effectiveSettings.DetachSubscriptionSettings).WithGoogleRequestParam("subscription", request => request.Subscription);
            Modify_ApiCall(ref _callDetachSubscription);
            Modify_DetachSubscriptionApiCall(ref _callDetachSubscription);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateTopicApiCall(ref gaxgrpc::ApiCall<Topic, Topic> call);

        partial void Modify_UpdateTopicApiCall(ref gaxgrpc::ApiCall<UpdateTopicRequest, Topic> call);

        partial void Modify_PublishApiCall(ref gaxgrpc::ApiCall<PublishRequest, PublishResponse> call);

        partial void Modify_GetTopicApiCall(ref gaxgrpc::ApiCall<GetTopicRequest, Topic> call);

        partial void Modify_ListTopicsApiCall(ref gaxgrpc::ApiCall<ListTopicsRequest, ListTopicsResponse> call);

        partial void Modify_ListTopicSubscriptionsApiCall(ref gaxgrpc::ApiCall<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse> call);

        partial void Modify_ListTopicSnapshotsApiCall(ref gaxgrpc::ApiCall<ListTopicSnapshotsRequest, ListTopicSnapshotsResponse> call);

        partial void Modify_DeleteTopicApiCall(ref gaxgrpc::ApiCall<DeleteTopicRequest, wkt::Empty> call);

        partial void Modify_DetachSubscriptionApiCall(ref gaxgrpc::ApiCall<DetachSubscriptionRequest, DetachSubscriptionResponse> call);

        partial void OnConstruction(Publisher.PublisherClient grpcClient, PublisherSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Publisher client</summary>
        public override Publisher.PublisherClient GrpcClient { get; }

        partial void Modify_Topic(ref Topic request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTopicRequest(ref UpdateTopicRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PublishRequest(ref PublishRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTopicRequest(ref GetTopicRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTopicsRequest(ref ListTopicsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTopicSubscriptionsRequest(ref ListTopicSubscriptionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTopicSnapshotsRequest(ref ListTopicSnapshotsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTopicRequest(ref DeleteTopicRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DetachSubscriptionRequest(ref DetachSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/admin#resource_names).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Topic CreateTopic(Topic request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Topic(ref request, ref callSettings);
            return _callCreateTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/admin#resource_names).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Topic> CreateTopicAsync(Topic request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Topic(ref request, ref callSettings);
            return _callCreateTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing topic. Note that certain properties of a
        /// topic are not modifiable.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Topic UpdateTopic(UpdateTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTopicRequest(ref request, ref callSettings);
            return _callUpdateTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing topic. Note that certain properties of a
        /// topic are not modifiable.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Topic> UpdateTopicAsync(UpdateTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTopicRequest(ref request, ref callSettings);
            return _callUpdateTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublishResponse Publish(PublishRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PublishRequest(ref request, ref callSettings);
            return _callPublish.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PublishResponse> PublishAsync(PublishRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PublishRequest(ref request, ref callSettings);
            return _callPublish.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Topic GetTopic(GetTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTopicRequest(ref request, ref callSettings);
            return _callGetTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the configuration of a topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Topic> GetTopicAsync(GetTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTopicRequest(ref request, ref callSettings);
            return _callGetTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Topic"/> resources.</returns>
        public override gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(ListTopicsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTopicsRequest, ListTopicsResponse, Topic>(_callListTopics, request, callSettings);
        }

        /// <summary>
        /// Lists matching topics.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Topic"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(ListTopicsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTopicsRequest, ListTopicsResponse, Topic>(_callListTopics, request, callSettings);
        }

        /// <summary>
        /// Lists the names of the attached subscriptions on this topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptions(ListTopicSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse, string>(_callListTopicSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Lists the names of the attached subscriptions on this topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptionsAsync(ListTopicSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse, string>(_callListTopicSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Lists the names of the snapshots on this topic. Snapshots are used in
        /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations,
        /// which allow you to manage message acknowledgments in bulk. That is, you can
        /// set the acknowledgment state of messages in an existing subscription to the
        /// state captured by a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<ListTopicSnapshotsResponse, string> ListTopicSnapshots(ListTopicSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTopicSnapshotsRequest, ListTopicSnapshotsResponse, string>(_callListTopicSnapshots, request, callSettings);
        }

        /// <summary>
        /// Lists the names of the snapshots on this topic. Snapshots are used in
        /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations,
        /// which allow you to manage message acknowledgments in bulk. That is, you can
        /// set the acknowledgment state of messages in an existing subscription to the
        /// state captured by a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTopicSnapshotsResponse, string> ListTopicSnapshotsAsync(ListTopicSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTopicSnapshotsRequest, ListTopicSnapshotsResponse, string>(_callListTopicSnapshots, request, callSettings);
        }

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTopic(DeleteTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTopicRequest(ref request, ref callSettings);
            _callDeleteTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the topic with the given name. Returns `NOT_FOUND` if the topic
        /// does not exist. After a topic is deleted, a new topic may be created with
        /// the same name; this is an entirely new topic with none of the old
        /// configuration or subscriptions. Existing subscriptions to this topic are
        /// not deleted, but their `topic` field is set to `_deleted-topic_`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTopicAsync(DeleteTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTopicRequest(ref request, ref callSettings);
            return _callDeleteTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Detaches a subscription from this topic. All messages retained in the
        /// subscription are dropped. Subsequent `Pull` and `StreamingPull` requests
        /// will return FAILED_PRECONDITION. If the subscription is a push
        /// subscription, pushes to the endpoint will stop.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DetachSubscriptionResponse DetachSubscription(DetachSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetachSubscriptionRequest(ref request, ref callSettings);
            return _callDetachSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Detaches a subscription from this topic. All messages retained in the
        /// subscription are dropped. Subsequent `Pull` and `StreamingPull` requests
        /// will return FAILED_PRECONDITION. If the subscription is a push
        /// subscription, pushes to the endpoint will stop.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DetachSubscriptionResponse> DetachSubscriptionAsync(DetachSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetachSubscriptionRequest(ref request, ref callSettings);
            return _callDetachSubscription.Async(request, callSettings);
        }
    }

    public partial class ListTopicsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTopicSubscriptionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTopicSnapshotsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTopicsResponse : gaxgrpc::IPageResponse<Topic>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Topic> GetEnumerator() => Topics.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTopicSubscriptionsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => Subscriptions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTopicSnapshotsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => Snapshots.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
