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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.PubSub.V1
{
    /// <summary>Settings for <see cref="PublisherServiceApiClient"/> instances.</summary>
    public sealed partial class PublisherServiceApiSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PublisherServiceApiSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PublisherServiceApiSettings"/>.</returns>
        public static PublisherServiceApiSettings GetDefault() => new PublisherServiceApiSettings();

        /// <summary>Constructs a new <see cref="PublisherServiceApiSettings"/> object with default settings.</summary>
        public PublisherServiceApiSettings()
        {
        }

        private PublisherServiceApiSettings(PublisherServiceApiSettings existing) : base(existing)
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
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(PublisherServiceApiSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceApiClient.CreateTopic</c> and <c>PublisherServiceApiClient.CreateTopicAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceApiClient.UpdateTopic</c> and <c>PublisherServiceApiClient.UpdateTopicAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceApiClient.Publish</c> and <c>PublisherServiceApiClient.PublishAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 4</description></item>
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
        public gaxgrpc::CallSettings PublishSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 4, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Aborted, grpccore::StatusCode.Cancelled, grpccore::StatusCode.Internal, grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceApiClient.GetTopic</c> and <c>PublisherServiceApiClient.GetTopicAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceApiClient.ListTopics</c> and <c>PublisherServiceApiClient.ListTopicsAsync</c>.
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
        /// <c>PublisherServiceApiClient.ListTopicSubscriptions</c> and
        /// <c>PublisherServiceApiClient.ListTopicSubscriptionsAsync</c>.
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
        /// <c>PublisherServiceApiClient.ListTopicSnapshots</c> and <c>PublisherServiceApiClient.ListTopicSnapshotsAsync</c>
        /// .
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceApiClient.DeleteTopic</c> and <c>PublisherServiceApiClient.DeleteTopicAsync</c>.
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
        /// <c>PublisherServiceApiClient.DetachSubscription</c> and <c>PublisherServiceApiClient.DetachSubscriptionAsync</c>
        /// .
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

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PublisherServiceApiSettings"/> object.</returns>
        public PublisherServiceApiSettings Clone() => new PublisherServiceApiSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PublisherServiceApiClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class PublisherServiceApiClientBuilder : gaxgrpc::ClientBuilderBase<PublisherServiceApiClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PublisherServiceApiSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PublisherServiceApiClientBuilder() : base(PublisherServiceApiClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PublisherServiceApiClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PublisherServiceApiClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PublisherServiceApiClient Build()
        {
            PublisherServiceApiClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PublisherServiceApiClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PublisherServiceApiClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PublisherServiceApiClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PublisherServiceApiClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PublisherServiceApiClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PublisherServiceApiClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PublisherServiceApiClient.ChannelPool;
    }

    /// <summary>PublisherServiceApi client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that an application uses to manipulate topics, and to send
    /// messages to a topic.
    /// </remarks>
    public abstract partial class PublisherServiceApiClient
    {
        /// <summary>
        /// The default endpoint for the PublisherServiceApi service, which is a host of "pubsub.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "pubsub.googleapis.com:443";

        /// <summary>The default PublisherServiceApi scopes.</summary>
        /// <remarks>
        /// The default PublisherServiceApi scopes are:
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

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Publisher.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PublisherServiceApiClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="PublisherServiceApiClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PublisherServiceApiClient"/>.</returns>
        public static stt::Task<PublisherServiceApiClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PublisherServiceApiClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PublisherServiceApiClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="PublisherServiceApiClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PublisherServiceApiClient"/>.</returns>
        public static PublisherServiceApiClient Create() => new PublisherServiceApiClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PublisherServiceApiClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PublisherServiceApiSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PublisherServiceApiClient"/>.</returns>
        internal static PublisherServiceApiClient Create(grpccore::CallInvoker callInvoker, PublisherServiceApiSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Publisher.PublisherClient grpcClient = new Publisher.PublisherClient(callInvoker);
            return new PublisherServiceApiClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PublisherServiceApi client</summary>
        public virtual Publisher.PublisherClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic CreateTopic(Topic request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(Topic request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(Topic request, st::CancellationToken cancellationToken) =>
            CreateTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the given topic with the given name. See the [resource name rules]
        /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names).
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
        /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names).
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
        /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names).
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
        /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names).
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
        /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names).
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
        /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names).
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
        /// Updates an existing topic by updating the fields specified in the update
        /// mask. Note that certain properties of a topic are not modifiable.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic UpdateTopic(UpdateTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing topic by updating the fields specified in the update
        /// mask. Note that certain properties of a topic are not modifiable.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> UpdateTopicAsync(UpdateTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing topic by updating the fields specified in the update
        /// mask. Note that certain properties of a topic are not modifiable.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> UpdateTopicAsync(UpdateTopicRequest request, st::CancellationToken cancellationToken) =>
            UpdateTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing topic by updating the fields specified in the update
        /// mask. Note that certain properties of a topic are not modifiable.
        /// </summary>
        /// <param name="topic">
        /// Required. The updated topic object.
        /// </param>
        /// <param name="updateMask">
        /// Required. Indicates which fields in the provided topic to update. Must be
        /// specified and non-empty. Note that if `update_mask` contains
        /// "message_storage_policy" but the `message_storage_policy` is not set in
        /// the `topic` provided above, then the updated value is determined by the
        /// policy configured at the project or organization level.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic UpdateTopic(Topic topic, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTopic(new UpdateTopicRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing topic by updating the fields specified in the update
        /// mask. Note that certain properties of a topic are not modifiable.
        /// </summary>
        /// <param name="topic">
        /// Required. The updated topic object.
        /// </param>
        /// <param name="updateMask">
        /// Required. Indicates which fields in the provided topic to update. Must be
        /// specified and non-empty. Note that if `update_mask` contains
        /// "message_storage_policy" but the `message_storage_policy` is not set in
        /// the `topic` provided above, then the updated value is determined by the
        /// policy configured at the project or organization level.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> UpdateTopicAsync(Topic topic, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTopicAsync(new UpdateTopicRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing topic by updating the fields specified in the update
        /// mask. Note that certain properties of a topic are not modifiable.
        /// </summary>
        /// <param name="topic">
        /// Required. The updated topic object.
        /// </param>
        /// <param name="updateMask">
        /// Required. Indicates which fields in the provided topic to update. Must be
        /// specified and non-empty. Note that if `update_mask` contains
        /// "message_storage_policy" but the `message_storage_policy` is not set in
        /// the `topic` provided above, then the updated value is determined by the
        /// policy configured at the project or organization level.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> UpdateTopicAsync(Topic topic, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTopicAsync(topic, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicsRequest request = new ListTopicsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTopics(request, callSettings);
        }

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
        public virtual gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicsRequest request = new ListTopicsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTopicsAsync(request, callSettings);
        }

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
        public virtual gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(gagr::ProjectName project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicsRequest request = new ListTopicsRequest
            {
                ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTopics(request, callSettings);
        }

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
        public virtual gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(gagr::ProjectName project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicsRequest request = new ListTopicsRequest
            {
                ProjectAsProjectName = gax::GaxPreconditions.CheckNotNull(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTopicsAsync(request, callSettings);
        }

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
        public virtual gax::PagedEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptions(string topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTopicSubscriptions(request, callSettings);
        }

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
        public virtual gax::PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptionsAsync(string topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTopicSubscriptionsAsync(request, callSettings);
        }

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
        public virtual gax::PagedEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptions(TopicName topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTopicSubscriptions(request, callSettings);
        }

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
        public virtual gax::PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptionsAsync(TopicName topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicSubscriptionsRequest request = new ListTopicSubscriptionsRequest
            {
                TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTopicSubscriptionsAsync(request, callSettings);
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
        public virtual gax::PagedEnumerable<ListTopicSnapshotsResponse, string> ListTopicSnapshots(string topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicSnapshotsRequest request = new ListTopicSnapshotsRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTopicSnapshots(request, callSettings);
        }

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
        public virtual gax::PagedAsyncEnumerable<ListTopicSnapshotsResponse, string> ListTopicSnapshotsAsync(string topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicSnapshotsRequest request = new ListTopicSnapshotsRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNullOrEmpty(topic, nameof(topic)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTopicSnapshotsAsync(request, callSettings);
        }

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
        public virtual gax::PagedEnumerable<ListTopicSnapshotsResponse, string> ListTopicSnapshots(TopicName topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicSnapshotsRequest request = new ListTopicSnapshotsRequest
            {
                TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTopicSnapshots(request, callSettings);
        }

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
        public virtual gax::PagedAsyncEnumerable<ListTopicSnapshotsResponse, string> ListTopicSnapshotsAsync(TopicName topic, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicSnapshotsRequest request = new ListTopicSnapshotsRequest
            {
                TopicAsTopicName = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTopicSnapshotsAsync(request, callSettings);
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

    /// <summary>PublisherServiceApi client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that an application uses to manipulate topics, and to send
    /// messages to a topic.
    /// </remarks>
    public sealed partial class PublisherServiceApiClientImpl : PublisherServiceApiClient
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
        /// Constructs a client wrapper for the PublisherServiceApi service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PublisherServiceApiSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PublisherServiceApiClientImpl(Publisher.PublisherClient grpcClient, PublisherServiceApiSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PublisherServiceApiSettings effectiveSettings = settings ?? PublisherServiceApiSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateTopic = clientHelper.BuildApiCall<Topic, Topic>("CreateTopic", grpcClient.CreateTopicAsync, grpcClient.CreateTopic, effectiveSettings.CreateTopicSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCreateTopic);
            Modify_CreateTopicApiCall(ref _callCreateTopic);
            _callUpdateTopic = clientHelper.BuildApiCall<UpdateTopicRequest, Topic>("UpdateTopic", grpcClient.UpdateTopicAsync, grpcClient.UpdateTopic, effectiveSettings.UpdateTopicSettings).WithGoogleRequestParam("topic.name", request => request.Topic?.Name);
            Modify_ApiCall(ref _callUpdateTopic);
            Modify_UpdateTopicApiCall(ref _callUpdateTopic);
            _callPublish = clientHelper.BuildApiCall<PublishRequest, PublishResponse>("Publish", grpcClient.PublishAsync, grpcClient.Publish, effectiveSettings.PublishSettings).WithGoogleRequestParam("topic", request => request.Topic);
            Modify_ApiCall(ref _callPublish);
            Modify_PublishApiCall(ref _callPublish);
            _callGetTopic = clientHelper.BuildApiCall<GetTopicRequest, Topic>("GetTopic", grpcClient.GetTopicAsync, grpcClient.GetTopic, effectiveSettings.GetTopicSettings).WithGoogleRequestParam("topic", request => request.Topic);
            Modify_ApiCall(ref _callGetTopic);
            Modify_GetTopicApiCall(ref _callGetTopic);
            _callListTopics = clientHelper.BuildApiCall<ListTopicsRequest, ListTopicsResponse>("ListTopics", grpcClient.ListTopicsAsync, grpcClient.ListTopics, effectiveSettings.ListTopicsSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callListTopics);
            Modify_ListTopicsApiCall(ref _callListTopics);
            _callListTopicSubscriptions = clientHelper.BuildApiCall<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse>("ListTopicSubscriptions", grpcClient.ListTopicSubscriptionsAsync, grpcClient.ListTopicSubscriptions, effectiveSettings.ListTopicSubscriptionsSettings).WithGoogleRequestParam("topic", request => request.Topic);
            Modify_ApiCall(ref _callListTopicSubscriptions);
            Modify_ListTopicSubscriptionsApiCall(ref _callListTopicSubscriptions);
            _callListTopicSnapshots = clientHelper.BuildApiCall<ListTopicSnapshotsRequest, ListTopicSnapshotsResponse>("ListTopicSnapshots", grpcClient.ListTopicSnapshotsAsync, grpcClient.ListTopicSnapshots, effectiveSettings.ListTopicSnapshotsSettings).WithGoogleRequestParam("topic", request => request.Topic);
            Modify_ApiCall(ref _callListTopicSnapshots);
            Modify_ListTopicSnapshotsApiCall(ref _callListTopicSnapshots);
            _callDeleteTopic = clientHelper.BuildApiCall<DeleteTopicRequest, wkt::Empty>("DeleteTopic", grpcClient.DeleteTopicAsync, grpcClient.DeleteTopic, effectiveSettings.DeleteTopicSettings).WithGoogleRequestParam("topic", request => request.Topic);
            Modify_ApiCall(ref _callDeleteTopic);
            Modify_DeleteTopicApiCall(ref _callDeleteTopic);
            _callDetachSubscription = clientHelper.BuildApiCall<DetachSubscriptionRequest, DetachSubscriptionResponse>("DetachSubscription", grpcClient.DetachSubscriptionAsync, grpcClient.DetachSubscription, effectiveSettings.DetachSubscriptionSettings).WithGoogleRequestParam("subscription", request => request.Subscription);
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

        partial void OnConstruction(Publisher.PublisherClient grpcClient, PublisherServiceApiSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PublisherServiceApi client</summary>
        public override Publisher.PublisherClient GrpcClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

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
        /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names).
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
        /// (https://cloud.google.com/pubsub/docs/pubsub-basics#resource_names).
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
        /// Updates an existing topic by updating the fields specified in the update
        /// mask. Note that certain properties of a topic are not modifiable.
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
        /// Updates an existing topic by updating the fields specified in the update
        /// mask. Note that certain properties of a topic are not modifiable.
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

    public static partial class Publisher
    {
        public partial class PublisherClient
        {
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
