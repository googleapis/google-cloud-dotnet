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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Settings for <see cref="ConversationalSearchServiceClient"/> instances.</summary>
    public sealed partial class ConversationalSearchServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConversationalSearchServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConversationalSearchServiceSettings"/>.</returns>
        public static ConversationalSearchServiceSettings GetDefault() => new ConversationalSearchServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConversationalSearchServiceSettings"/> object with default settings.
        /// </summary>
        public ConversationalSearchServiceSettings()
        {
        }

        private ConversationalSearchServiceSettings(ConversationalSearchServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ConverseConversationSettings = existing.ConverseConversationSettings;
            CreateConversationSettings = existing.CreateConversationSettings;
            DeleteConversationSettings = existing.DeleteConversationSettings;
            UpdateConversationSettings = existing.UpdateConversationSettings;
            GetConversationSettings = existing.GetConversationSettings;
            ListConversationsSettings = existing.ListConversationsSettings;
            AnswerQuerySettings = existing.AnswerQuerySettings;
            GetAnswerSettings = existing.GetAnswerSettings;
            CreateSessionSettings = existing.CreateSessionSettings;
            DeleteSessionSettings = existing.DeleteSessionSettings;
            UpdateSessionSettings = existing.UpdateSessionSettings;
            GetSessionSettings = existing.GetSessionSettings;
            ListSessionsSettings = existing.ListSessionsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversationalSearchServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationalSearchServiceClient.ConverseConversation</c> and
        /// <c>ConversationalSearchServiceClient.ConverseConversationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ConverseConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationalSearchServiceClient.CreateConversation</c> and
        /// <c>ConversationalSearchServiceClient.CreateConversationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationalSearchServiceClient.DeleteConversation</c> and
        /// <c>ConversationalSearchServiceClient.DeleteConversationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationalSearchServiceClient.UpdateConversation</c> and
        /// <c>ConversationalSearchServiceClient.UpdateConversationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationalSearchServiceClient.GetConversation</c> and
        /// <c>ConversationalSearchServiceClient.GetConversationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationalSearchServiceClient.ListConversations</c> and
        /// <c>ConversationalSearchServiceClient.ListConversationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConversationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationalSearchServiceClient.AnswerQuery</c> and
        /// <c>ConversationalSearchServiceClient.AnswerQueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnswerQuerySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationalSearchServiceClient.GetAnswer</c> and <c>ConversationalSearchServiceClient.GetAnswerAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAnswerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationalSearchServiceClient.CreateSession</c> and
        /// <c>ConversationalSearchServiceClient.CreateSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationalSearchServiceClient.DeleteSession</c> and
        /// <c>ConversationalSearchServiceClient.DeleteSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationalSearchServiceClient.UpdateSession</c> and
        /// <c>ConversationalSearchServiceClient.UpdateSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationalSearchServiceClient.GetSession</c> and <c>ConversationalSearchServiceClient.GetSessionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationalSearchServiceClient.ListSessions</c> and
        /// <c>ConversationalSearchServiceClient.ListSessionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSessionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConversationalSearchServiceSettings"/> object.</returns>
        public ConversationalSearchServiceSettings Clone() => new ConversationalSearchServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversationalSearchServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class ConversationalSearchServiceClientBuilder : gaxgrpc::ClientBuilderBase<ConversationalSearchServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConversationalSearchServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConversationalSearchServiceClientBuilder() : base(ConversationalSearchServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConversationalSearchServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConversationalSearchServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConversationalSearchServiceClient Build()
        {
            ConversationalSearchServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConversationalSearchServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConversationalSearchServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConversationalSearchServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversationalSearchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConversationalSearchServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversationalSearchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversationalSearchServiceClient.ChannelPool;
    }

    /// <summary>ConversationalSearchService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for conversational search.
    /// </remarks>
    public abstract partial class ConversationalSearchServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConversationalSearchService service, which is a host of
        /// "discoveryengine.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default ConversationalSearchService scopes.</summary>
        /// <remarks>
        /// The default ConversationalSearchService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ConversationalSearchService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConversationalSearchServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversationalSearchServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConversationalSearchServiceClient"/>.</returns>
        public static stt::Task<ConversationalSearchServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConversationalSearchServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConversationalSearchServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversationalSearchServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConversationalSearchServiceClient"/>.</returns>
        public static ConversationalSearchServiceClient Create() => new ConversationalSearchServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConversationalSearchServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConversationalSearchServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConversationalSearchServiceClient"/>.</returns>
        internal static ConversationalSearchServiceClient Create(grpccore::CallInvoker callInvoker, ConversationalSearchServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversationalSearchService.ConversationalSearchServiceClient grpcClient = new ConversationalSearchService.ConversationalSearchServiceClient(callInvoker);
            return new ConversationalSearchServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ConversationalSearchService client</summary>
        public virtual ConversationalSearchService.ConversationalSearchServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Converses a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConverseConversationResponse ConverseConversation(ConverseConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Converses a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConverseConversationResponse> ConverseConversationAsync(ConverseConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Converses a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConverseConversationResponse> ConverseConversationAsync(ConverseConversationRequest request, st::CancellationToken cancellationToken) =>
            ConverseConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Converses a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
        /// Use
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
        /// to activate auto session mode, which automatically creates a new
        /// conversation inside a ConverseConversation session.
        /// </param>
        /// <param name="query">
        /// Required. Current user input.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConverseConversationResponse ConverseConversation(string name, TextInput query, gaxgrpc::CallSettings callSettings = null) =>
            ConverseConversation(new ConverseConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Query = gax::GaxPreconditions.CheckNotNull(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Converses a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
        /// Use
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
        /// to activate auto session mode, which automatically creates a new
        /// conversation inside a ConverseConversation session.
        /// </param>
        /// <param name="query">
        /// Required. Current user input.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConverseConversationResponse> ConverseConversationAsync(string name, TextInput query, gaxgrpc::CallSettings callSettings = null) =>
            ConverseConversationAsync(new ConverseConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Query = gax::GaxPreconditions.CheckNotNull(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Converses a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
        /// Use
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
        /// to activate auto session mode, which automatically creates a new
        /// conversation inside a ConverseConversation session.
        /// </param>
        /// <param name="query">
        /// Required. Current user input.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConverseConversationResponse> ConverseConversationAsync(string name, TextInput query, st::CancellationToken cancellationToken) =>
            ConverseConversationAsync(name, query, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Converses a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
        /// Use
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
        /// to activate auto session mode, which automatically creates a new
        /// conversation inside a ConverseConversation session.
        /// </param>
        /// <param name="query">
        /// Required. Current user input.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConverseConversationResponse ConverseConversation(ConversationName name, TextInput query, gaxgrpc::CallSettings callSettings = null) =>
            ConverseConversation(new ConverseConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Query = gax::GaxPreconditions.CheckNotNull(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Converses a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
        /// Use
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
        /// to activate auto session mode, which automatically creates a new
        /// conversation inside a ConverseConversation session.
        /// </param>
        /// <param name="query">
        /// Required. Current user input.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConverseConversationResponse> ConverseConversationAsync(ConversationName name, TextInput query, gaxgrpc::CallSettings callSettings = null) =>
            ConverseConversationAsync(new ConverseConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Query = gax::GaxPreconditions.CheckNotNull(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Converses a conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
        /// Use
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
        /// to activate auto session mode, which automatically creates a new
        /// conversation inside a ConverseConversation session.
        /// </param>
        /// <param name="query">
        /// Required. Current user input.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConverseConversationResponse> ConverseConversationAsync(ConversationName name, TextInput query, st::CancellationToken cancellationToken) =>
            ConverseConversationAsync(name, query, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// create already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CreateConversation(CreateConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// create already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(CreateConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// create already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(CreateConversationRequest request, st::CancellationToken cancellationToken) =>
            CreateConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// create already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CreateConversation(string parent, Conversation conversation, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversation(new CreateConversationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Creates a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// create already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(string parent, Conversation conversation, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationAsync(new CreateConversationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Creates a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// create already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(string parent, Conversation conversation, st::CancellationToken cancellationToken) =>
            CreateConversationAsync(parent, conversation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// create already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CreateConversation(DataStoreName parent, Conversation conversation, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversation(new CreateConversationRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Creates a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// create already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(DataStoreName parent, Conversation conversation, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationAsync(new CreateConversationRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Creates a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// create already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(DataStoreName parent, Conversation conversation, st::CancellationToken cancellationToken) =>
            CreateConversationAsync(parent, conversation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// delete does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversation(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// delete does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// delete does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(DeleteConversationRequest request, st::CancellationToken cancellationToken) =>
            DeleteConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// delete does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversation(new DeleteConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// delete does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationAsync(new DeleteConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// delete does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// delete does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversation(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversation(new DeleteConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// delete does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationAsync(new DeleteConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// delete does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationAsync(ConversationName name, st::CancellationToken cancellationToken) =>
            DeleteConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Conversation.
        /// 
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] action
        /// type cannot be changed. If the
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to update
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation UpdateConversation(UpdateConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Conversation.
        /// 
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] action
        /// type cannot be changed. If the
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to update
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> UpdateConversationAsync(UpdateConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Conversation.
        /// 
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] action
        /// type cannot be changed. If the
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to update
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> UpdateConversationAsync(UpdateConversationRequest request, st::CancellationToken cancellationToken) =>
            UpdateConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Conversation.
        /// 
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] action
        /// type cannot be changed. If the
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to update
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="conversation">
        /// Required. The Conversation to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to update.
        /// The following are NOT supported:
        /// 
        /// * [Conversation.name][google.cloud.discoveryengine.v1beta.Conversation.name]
        /// 
        /// If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation UpdateConversation(Conversation conversation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConversation(new UpdateConversationRequest
            {
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a Conversation.
        /// 
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] action
        /// type cannot be changed. If the
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to update
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="conversation">
        /// Required. The Conversation to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to update.
        /// The following are NOT supported:
        /// 
        /// * [Conversation.name][google.cloud.discoveryengine.v1beta.Conversation.name]
        /// 
        /// If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> UpdateConversationAsync(Conversation conversation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConversationAsync(new UpdateConversationRequest
            {
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a Conversation.
        /// 
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] action
        /// type cannot be changed. If the
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to update
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="conversation">
        /// Required. The Conversation to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to update.
        /// The following are NOT supported:
        /// 
        /// * [Conversation.name][google.cloud.discoveryengine.v1beta.Conversation.name]
        /// 
        /// If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> UpdateConversationAsync(Conversation conversation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConversationAsync(conversation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(GetConversationRequest request, st::CancellationToken cancellationToken) =>
            GetConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversation(new GetConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationAsync(new GetConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(string name, st::CancellationToken cancellationToken) =>
            GetConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversation(new GetConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationAsync(new GetConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Conversation to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(ConversationName name, st::CancellationToken cancellationToken) =>
            GetConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all Conversations by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Conversations by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Conversations by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
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
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
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
            return ListConversations(request, callSettings);
        }

        /// <summary>
        /// Lists all Conversations by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
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
            return ListConversationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Conversations by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
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
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(DataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConversations(request, callSettings);
        }

        /// <summary>
        /// Lists all Conversations by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(DataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConversationsAsync(request, callSettings);
        }

        /// <summary>
        /// Answer query method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnswerQueryResponse AnswerQuery(AnswerQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Answer query method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnswerQueryResponse> AnswerQueryAsync(AnswerQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Answer query method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnswerQueryResponse> AnswerQueryAsync(AnswerQueryRequest request, st::CancellationToken cancellationToken) =>
            AnswerQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Answer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Answer GetAnswer(GetAnswerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Answer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Answer> GetAnswerAsync(GetAnswerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Answer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Answer> GetAnswerAsync(GetAnswerRequest request, st::CancellationToken cancellationToken) =>
            GetAnswerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Answer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Answer to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine_id}/sessions/{session_id}/answers/{answer_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Answer GetAnswer(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnswer(new GetAnswerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Answer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Answer to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine_id}/sessions/{session_id}/answers/{answer_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Answer> GetAnswerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnswerAsync(new GetAnswerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Answer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Answer to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine_id}/sessions/{session_id}/answers/{answer_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Answer> GetAnswerAsync(string name, st::CancellationToken cancellationToken) =>
            GetAnswerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Answer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Answer to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine_id}/sessions/{session_id}/answers/{answer_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Answer GetAnswer(AnswerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnswer(new GetAnswerRequest
            {
                AnswerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Answer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Answer to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine_id}/sessions/{session_id}/answers/{answer_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Answer> GetAnswerAsync(AnswerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnswerAsync(new GetAnswerRequest
            {
                AnswerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Answer.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Answer to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine_id}/sessions/{session_id}/answers/{answer_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Answer> GetAnswerAsync(AnswerName name, st::CancellationToken cancellationToken) =>
            GetAnswerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session CreateSession(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(CreateSessionRequest request, st::CancellationToken cancellationToken) =>
            CreateSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session CreateSession(string parent, Session session, gaxgrpc::CallSettings callSettings = null) =>
            CreateSession(new CreateSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
            }, callSettings);

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(string parent, Session session, gaxgrpc::CallSettings callSettings = null) =>
            CreateSessionAsync(new CreateSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
            }, callSettings);

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(string parent, Session session, st::CancellationToken cancellationToken) =>
            CreateSessionAsync(parent, session, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session CreateSession(DataStoreName parent, Session session, gaxgrpc::CallSettings callSettings = null) =>
            CreateSession(new CreateSessionRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
            }, callSettings);

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(DataStoreName parent, Session session, gaxgrpc::CallSettings callSettings = null) =>
            CreateSessionAsync(new CreateSessionRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
            }, callSettings);

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
        /// </param>
        /// <param name="session">
        /// Required. The session to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> CreateSessionAsync(DataStoreName parent, Session session, st::CancellationToken cancellationToken) =>
            CreateSessionAsync(parent, session, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSession(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(DeleteSessionRequest request, st::CancellationToken cancellationToken) =>
            DeleteSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSession(new DeleteSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSessionAsync(new DeleteSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSession(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSession(new DeleteSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSessionAsync(new DeleteSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSessionAsync(SessionName name, st::CancellationToken cancellationToken) =>
            DeleteSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1beta.Session] action type cannot
        /// be changed. If the [Session][google.cloud.discoveryengine.v1beta.Session]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session UpdateSession(UpdateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1beta.Session] action type cannot
        /// be changed. If the [Session][google.cloud.discoveryengine.v1beta.Session]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> UpdateSessionAsync(UpdateSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1beta.Session] action type cannot
        /// be changed. If the [Session][google.cloud.discoveryengine.v1beta.Session]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> UpdateSessionAsync(UpdateSessionRequest request, st::CancellationToken cancellationToken) =>
            UpdateSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1beta.Session] action type cannot
        /// be changed. If the [Session][google.cloud.discoveryengine.v1beta.Session]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="session">
        /// Required. The Session to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Session][google.cloud.discoveryengine.v1beta.Session] to update. The
        /// following are NOT supported:
        /// 
        /// * [Session.name][google.cloud.discoveryengine.v1beta.Session.name]
        /// 
        /// If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session UpdateSession(Session session, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSession(new UpdateSessionRequest
            {
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1beta.Session] action type cannot
        /// be changed. If the [Session][google.cloud.discoveryengine.v1beta.Session]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="session">
        /// Required. The Session to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Session][google.cloud.discoveryengine.v1beta.Session] to update. The
        /// following are NOT supported:
        /// 
        /// * [Session.name][google.cloud.discoveryengine.v1beta.Session.name]
        /// 
        /// If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> UpdateSessionAsync(Session session, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSessionAsync(new UpdateSessionRequest
            {
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1beta.Session] action type cannot
        /// be changed. If the [Session][google.cloud.discoveryengine.v1beta.Session]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="session">
        /// Required. The Session to update.
        /// </param>
        /// <param name="updateMask">
        /// Indicates which fields in the provided
        /// [Session][google.cloud.discoveryengine.v1beta.Session] to update. The
        /// following are NOT supported:
        /// 
        /// * [Session.name][google.cloud.discoveryengine.v1beta.Session.name]
        /// 
        /// If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> UpdateSessionAsync(Session session, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSessionAsync(session, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(GetSessionRequest request, st::CancellationToken cancellationToken) =>
            GetSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSession(new GetSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSessionAsync(new GetSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(string name, st::CancellationToken cancellationToken) =>
            GetSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Session GetSession(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSession(new GetSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(SessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSessionAsync(new GetSessionRequest
            {
                SessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Session to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}/sessions/{session_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Session> GetSessionAsync(SessionName name, st::CancellationToken cancellationToken) =>
            GetSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
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
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
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
            return ListSessions(request, callSettings);
        }

        /// <summary>
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
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
            return ListSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
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
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(DataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSessions(request, callSettings);
        }

        /// <summary>
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(DataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSessionsAsync(request, callSettings);
        }
    }

    /// <summary>ConversationalSearchService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for conversational search.
    /// </remarks>
    public sealed partial class ConversationalSearchServiceClientImpl : ConversationalSearchServiceClient
    {
        private readonly gaxgrpc::ApiCall<ConverseConversationRequest, ConverseConversationResponse> _callConverseConversation;

        private readonly gaxgrpc::ApiCall<CreateConversationRequest, Conversation> _callCreateConversation;

        private readonly gaxgrpc::ApiCall<DeleteConversationRequest, wkt::Empty> _callDeleteConversation;

        private readonly gaxgrpc::ApiCall<UpdateConversationRequest, Conversation> _callUpdateConversation;

        private readonly gaxgrpc::ApiCall<GetConversationRequest, Conversation> _callGetConversation;

        private readonly gaxgrpc::ApiCall<ListConversationsRequest, ListConversationsResponse> _callListConversations;

        private readonly gaxgrpc::ApiCall<AnswerQueryRequest, AnswerQueryResponse> _callAnswerQuery;

        private readonly gaxgrpc::ApiCall<GetAnswerRequest, Answer> _callGetAnswer;

        private readonly gaxgrpc::ApiCall<CreateSessionRequest, Session> _callCreateSession;

        private readonly gaxgrpc::ApiCall<DeleteSessionRequest, wkt::Empty> _callDeleteSession;

        private readonly gaxgrpc::ApiCall<UpdateSessionRequest, Session> _callUpdateSession;

        private readonly gaxgrpc::ApiCall<GetSessionRequest, Session> _callGetSession;

        private readonly gaxgrpc::ApiCall<ListSessionsRequest, ListSessionsResponse> _callListSessions;

        /// <summary>
        /// Constructs a client wrapper for the ConversationalSearchService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ConversationalSearchServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConversationalSearchServiceClientImpl(ConversationalSearchService.ConversationalSearchServiceClient grpcClient, ConversationalSearchServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConversationalSearchServiceSettings effectiveSettings = settings ?? ConversationalSearchServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callConverseConversation = clientHelper.BuildApiCall<ConverseConversationRequest, ConverseConversationResponse>("ConverseConversation", grpcClient.ConverseConversationAsync, grpcClient.ConverseConversation, effectiveSettings.ConverseConversationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callConverseConversation);
            Modify_ConverseConversationApiCall(ref _callConverseConversation);
            _callCreateConversation = clientHelper.BuildApiCall<CreateConversationRequest, Conversation>("CreateConversation", grpcClient.CreateConversationAsync, grpcClient.CreateConversation, effectiveSettings.CreateConversationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConversation);
            Modify_CreateConversationApiCall(ref _callCreateConversation);
            _callDeleteConversation = clientHelper.BuildApiCall<DeleteConversationRequest, wkt::Empty>("DeleteConversation", grpcClient.DeleteConversationAsync, grpcClient.DeleteConversation, effectiveSettings.DeleteConversationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConversation);
            Modify_DeleteConversationApiCall(ref _callDeleteConversation);
            _callUpdateConversation = clientHelper.BuildApiCall<UpdateConversationRequest, Conversation>("UpdateConversation", grpcClient.UpdateConversationAsync, grpcClient.UpdateConversation, effectiveSettings.UpdateConversationSettings).WithGoogleRequestParam("conversation.name", request => request.Conversation?.Name);
            Modify_ApiCall(ref _callUpdateConversation);
            Modify_UpdateConversationApiCall(ref _callUpdateConversation);
            _callGetConversation = clientHelper.BuildApiCall<GetConversationRequest, Conversation>("GetConversation", grpcClient.GetConversationAsync, grpcClient.GetConversation, effectiveSettings.GetConversationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConversation);
            Modify_GetConversationApiCall(ref _callGetConversation);
            _callListConversations = clientHelper.BuildApiCall<ListConversationsRequest, ListConversationsResponse>("ListConversations", grpcClient.ListConversationsAsync, grpcClient.ListConversations, effectiveSettings.ListConversationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConversations);
            Modify_ListConversationsApiCall(ref _callListConversations);
            _callAnswerQuery = clientHelper.BuildApiCall<AnswerQueryRequest, AnswerQueryResponse>("AnswerQuery", grpcClient.AnswerQueryAsync, grpcClient.AnswerQuery, effectiveSettings.AnswerQuerySettings).WithGoogleRequestParam("serving_config", request => request.ServingConfig);
            Modify_ApiCall(ref _callAnswerQuery);
            Modify_AnswerQueryApiCall(ref _callAnswerQuery);
            _callGetAnswer = clientHelper.BuildApiCall<GetAnswerRequest, Answer>("GetAnswer", grpcClient.GetAnswerAsync, grpcClient.GetAnswer, effectiveSettings.GetAnswerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAnswer);
            Modify_GetAnswerApiCall(ref _callGetAnswer);
            _callCreateSession = clientHelper.BuildApiCall<CreateSessionRequest, Session>("CreateSession", grpcClient.CreateSessionAsync, grpcClient.CreateSession, effectiveSettings.CreateSessionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSession);
            Modify_CreateSessionApiCall(ref _callCreateSession);
            _callDeleteSession = clientHelper.BuildApiCall<DeleteSessionRequest, wkt::Empty>("DeleteSession", grpcClient.DeleteSessionAsync, grpcClient.DeleteSession, effectiveSettings.DeleteSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSession);
            Modify_DeleteSessionApiCall(ref _callDeleteSession);
            _callUpdateSession = clientHelper.BuildApiCall<UpdateSessionRequest, Session>("UpdateSession", grpcClient.UpdateSessionAsync, grpcClient.UpdateSession, effectiveSettings.UpdateSessionSettings).WithGoogleRequestParam("session.name", request => request.Session?.Name);
            Modify_ApiCall(ref _callUpdateSession);
            Modify_UpdateSessionApiCall(ref _callUpdateSession);
            _callGetSession = clientHelper.BuildApiCall<GetSessionRequest, Session>("GetSession", grpcClient.GetSessionAsync, grpcClient.GetSession, effectiveSettings.GetSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSession);
            Modify_GetSessionApiCall(ref _callGetSession);
            _callListSessions = clientHelper.BuildApiCall<ListSessionsRequest, ListSessionsResponse>("ListSessions", grpcClient.ListSessionsAsync, grpcClient.ListSessions, effectiveSettings.ListSessionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSessions);
            Modify_ListSessionsApiCall(ref _callListSessions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ConverseConversationApiCall(ref gaxgrpc::ApiCall<ConverseConversationRequest, ConverseConversationResponse> call);

        partial void Modify_CreateConversationApiCall(ref gaxgrpc::ApiCall<CreateConversationRequest, Conversation> call);

        partial void Modify_DeleteConversationApiCall(ref gaxgrpc::ApiCall<DeleteConversationRequest, wkt::Empty> call);

        partial void Modify_UpdateConversationApiCall(ref gaxgrpc::ApiCall<UpdateConversationRequest, Conversation> call);

        partial void Modify_GetConversationApiCall(ref gaxgrpc::ApiCall<GetConversationRequest, Conversation> call);

        partial void Modify_ListConversationsApiCall(ref gaxgrpc::ApiCall<ListConversationsRequest, ListConversationsResponse> call);

        partial void Modify_AnswerQueryApiCall(ref gaxgrpc::ApiCall<AnswerQueryRequest, AnswerQueryResponse> call);

        partial void Modify_GetAnswerApiCall(ref gaxgrpc::ApiCall<GetAnswerRequest, Answer> call);

        partial void Modify_CreateSessionApiCall(ref gaxgrpc::ApiCall<CreateSessionRequest, Session> call);

        partial void Modify_DeleteSessionApiCall(ref gaxgrpc::ApiCall<DeleteSessionRequest, wkt::Empty> call);

        partial void Modify_UpdateSessionApiCall(ref gaxgrpc::ApiCall<UpdateSessionRequest, Session> call);

        partial void Modify_GetSessionApiCall(ref gaxgrpc::ApiCall<GetSessionRequest, Session> call);

        partial void Modify_ListSessionsApiCall(ref gaxgrpc::ApiCall<ListSessionsRequest, ListSessionsResponse> call);

        partial void OnConstruction(ConversationalSearchService.ConversationalSearchServiceClient grpcClient, ConversationalSearchServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConversationalSearchService client</summary>
        public override ConversationalSearchService.ConversationalSearchServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ConverseConversationRequest(ref ConverseConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConversationRequest(ref CreateConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConversationRequest(ref DeleteConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConversationRequest(ref UpdateConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConversationRequest(ref GetConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConversationsRequest(ref ListConversationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AnswerQueryRequest(ref AnswerQueryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAnswerRequest(ref GetAnswerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSessionRequest(ref CreateSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSessionRequest(ref DeleteSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSessionRequest(ref UpdateSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSessionRequest(ref GetSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSessionsRequest(ref ListSessionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Converses a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConverseConversationResponse ConverseConversation(ConverseConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConverseConversationRequest(ref request, ref callSettings);
            return _callConverseConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Converses a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConverseConversationResponse> ConverseConversationAsync(ConverseConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConverseConversationRequest(ref request, ref callSettings);
            return _callConverseConversation.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// create already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Conversation CreateConversation(CreateConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversationRequest(ref request, ref callSettings);
            return _callCreateConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// create already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Conversation> CreateConversationAsync(CreateConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversationRequest(ref request, ref callSettings);
            return _callCreateConversation.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// delete does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteConversation(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversationRequest(ref request, ref callSettings);
            _callDeleteConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Conversation.
        /// 
        /// If the [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to
        /// delete does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteConversationAsync(DeleteConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversationRequest(ref request, ref callSettings);
            return _callDeleteConversation.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a Conversation.
        /// 
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] action
        /// type cannot be changed. If the
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to update
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Conversation UpdateConversation(UpdateConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConversationRequest(ref request, ref callSettings);
            return _callUpdateConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a Conversation.
        /// 
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] action
        /// type cannot be changed. If the
        /// [Conversation][google.cloud.discoveryengine.v1beta.Conversation] to update
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Conversation> UpdateConversationAsync(UpdateConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConversationRequest(ref request, ref callSettings);
            return _callUpdateConversation.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a Conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Conversation GetConversation(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationRequest(ref request, ref callSettings);
            return _callGetConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Conversation> GetConversationAsync(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationRequest(ref request, ref callSettings);
            return _callGetConversation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all Conversations by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public override gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConversationsRequest, ListConversationsResponse, Conversation>(_callListConversations, request, callSettings);
        }

        /// <summary>
        /// Lists all Conversations by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConversationsRequest, ListConversationsResponse, Conversation>(_callListConversations, request, callSettings);
        }

        /// <summary>
        /// Answer query method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnswerQueryResponse AnswerQuery(AnswerQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnswerQueryRequest(ref request, ref callSettings);
            return _callAnswerQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// Answer query method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnswerQueryResponse> AnswerQueryAsync(AnswerQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnswerQueryRequest(ref request, ref callSettings);
            return _callAnswerQuery.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a Answer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Answer GetAnswer(GetAnswerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnswerRequest(ref request, ref callSettings);
            return _callGetAnswer.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Answer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Answer> GetAnswerAsync(GetAnswerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnswerRequest(ref request, ref callSettings);
            return _callGetAnswer.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Session CreateSession(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionRequest(ref request, ref callSettings);
            return _callCreateSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Session> CreateSessionAsync(CreateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSessionRequest(ref request, ref callSettings);
            return _callCreateSession.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSession(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionRequest(ref request, ref callSettings);
            _callDeleteSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Session.
        /// 
        /// If the [Session][google.cloud.discoveryengine.v1beta.Session] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSessionAsync(DeleteSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSessionRequest(ref request, ref callSettings);
            return _callDeleteSession.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1beta.Session] action type cannot
        /// be changed. If the [Session][google.cloud.discoveryengine.v1beta.Session]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Session UpdateSession(UpdateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSessionRequest(ref request, ref callSettings);
            return _callUpdateSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a Session.
        /// 
        /// [Session][google.cloud.discoveryengine.v1beta.Session] action type cannot
        /// be changed. If the [Session][google.cloud.discoveryengine.v1beta.Session]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Session> UpdateSessionAsync(UpdateSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSessionRequest(ref request, ref callSettings);
            return _callUpdateSession.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Session GetSession(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSessionRequest(ref request, ref callSettings);
            return _callGetSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Session> GetSessionAsync(GetSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSessionRequest(ref request, ref callSettings);
            return _callGetSession.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Session"/> resources.</returns>
        public override gax::PagedEnumerable<ListSessionsResponse, Session> ListSessions(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSessionsRequest, ListSessionsResponse, Session>(_callListSessions, request, callSettings);
        }

        /// <summary>
        /// Lists all Sessions by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Session"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(ListSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSessionsRequest, ListSessionsResponse, Session>(_callListSessions, request, callSettings);
        }
    }

    public partial class ListConversationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSessionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConversationsResponse : gaxgrpc::IPageResponse<Conversation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Conversation> GetEnumerator() => Conversations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSessionsResponse : gaxgrpc::IPageResponse<Session>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Session> GetEnumerator() => Sessions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ConversationalSearchService
    {
        public partial class ConversationalSearchServiceClient
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
