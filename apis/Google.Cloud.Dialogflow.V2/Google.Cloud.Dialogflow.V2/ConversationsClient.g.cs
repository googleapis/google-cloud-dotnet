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

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Settings for <see cref="ConversationsClient"/> instances.</summary>
    public sealed partial class ConversationsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConversationsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConversationsSettings"/>.</returns>
        public static ConversationsSettings GetDefault() => new ConversationsSettings();

        /// <summary>Constructs a new <see cref="ConversationsSettings"/> object with default settings.</summary>
        public ConversationsSettings()
        {
        }

        private ConversationsSettings(ConversationsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateConversationSettings = existing.CreateConversationSettings;
            ListConversationsSettings = existing.ListConversationsSettings;
            GetConversationSettings = existing.GetConversationSettings;
            CompleteConversationSettings = existing.CompleteConversationSettings;
            IngestContextReferencesSettings = existing.IngestContextReferencesSettings;
            ListMessagesSettings = existing.ListMessagesSettings;
            SuggestConversationSummarySettings = existing.SuggestConversationSummarySettings;
            GenerateStatelessSummarySettings = existing.GenerateStatelessSummarySettings;
            GenerateStatelessSuggestionSettings = existing.GenerateStatelessSuggestionSettings;
            SearchKnowledgeSettings = existing.SearchKnowledgeSettings;
            GenerateSuggestionsSettings = existing.GenerateSuggestionsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversationsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationsClient.CreateConversation</c> and <c>ConversationsClient.CreateConversationAsync</c>.
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
        public gaxgrpc::CallSettings CreateConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationsClient.ListConversations</c> and <c>ConversationsClient.ListConversationsAsync</c>.
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
        public gaxgrpc::CallSettings ListConversationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationsClient.GetConversation</c> and <c>ConversationsClient.GetConversationAsync</c>.
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
        public gaxgrpc::CallSettings GetConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationsClient.CompleteConversation</c> and <c>ConversationsClient.CompleteConversationAsync</c>.
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
        public gaxgrpc::CallSettings CompleteConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationsClient.IngestContextReferences</c> and <c>ConversationsClient.IngestContextReferencesAsync</c>
        /// .
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
        public gaxgrpc::CallSettings IngestContextReferencesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationsClient.ListMessages</c> and <c>ConversationsClient.ListMessagesAsync</c>.
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
        public gaxgrpc::CallSettings ListMessagesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationsClient.SuggestConversationSummary</c> and
        /// <c>ConversationsClient.SuggestConversationSummaryAsync</c>.
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
        public gaxgrpc::CallSettings SuggestConversationSummarySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationsClient.GenerateStatelessSummary</c> and <c>ConversationsClient.GenerateStatelessSummaryAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GenerateStatelessSummarySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationsClient.GenerateStatelessSuggestion</c> and
        /// <c>ConversationsClient.GenerateStatelessSuggestionAsync</c>.
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
        public gaxgrpc::CallSettings GenerateStatelessSuggestionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationsClient.SearchKnowledge</c> and <c>ConversationsClient.SearchKnowledgeAsync</c>.
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
        public gaxgrpc::CallSettings SearchKnowledgeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationsClient.GenerateSuggestions</c> and <c>ConversationsClient.GenerateSuggestionsAsync</c>.
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
        public gaxgrpc::CallSettings GenerateSuggestionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConversationsSettings"/> object.</returns>
        public ConversationsSettings Clone() => new ConversationsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversationsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ConversationsClientBuilder : gaxgrpc::ClientBuilderBase<ConversationsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConversationsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConversationsClientBuilder() : base(ConversationsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConversationsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConversationsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConversationsClient Build()
        {
            ConversationsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConversationsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConversationsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConversationsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConversationsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversationsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversationsClient.ChannelPool;
    }

    /// <summary>Conversations client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [Conversations][google.cloud.dialogflow.v2.Conversation].
    /// </remarks>
    public abstract partial class ConversationsClient
    {
        /// <summary>
        /// The default endpoint for the Conversations service, which is a host of "dialogflow.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Conversations scopes.</summary>
        /// <remarks>
        /// The default Conversations scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Conversations.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConversationsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ConversationsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConversationsClient"/>.</returns>
        public static stt::Task<ConversationsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConversationsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConversationsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ConversationsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConversationsClient"/>.</returns>
        public static ConversationsClient Create() => new ConversationsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConversationsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConversationsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConversationsClient"/>.</returns>
        internal static ConversationsClient Create(grpccore::CallInvoker callInvoker, ConversationsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Conversations.ConversationsClient grpcClient = new Conversations.ConversationsClient(callInvoker);
            return new ConversationsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Conversations client</summary>
        public virtual Conversations.ConversationsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new conversation. Conversations are auto-completed after 24
        /// hours.
        /// 
        /// Conversation Lifecycle:
        /// There are two stages during a conversation: Automated Agent Stage and
        /// Assist Stage.
        /// 
        /// For Automated Agent Stage, there will be a dialogflow agent responding to
        /// user queries.
        /// 
        /// For Assist Stage, there's no dialogflow agent responding to user queries.
        /// But we will provide suggestions which are generated from conversation.
        /// 
        /// If
        /// [Conversation.conversation_profile][google.cloud.dialogflow.v2.Conversation.conversation_profile]
        /// is configured for a dialogflow agent, conversation will start from
        /// `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And
        /// during `Automated Agent Stage`, once an
        /// [Intent][google.cloud.dialogflow.v2.Intent] with
        /// [Intent.live_agent_handoff][google.cloud.dialogflow.v2.Intent.live_agent_handoff]
        /// is triggered, conversation will transfer to Assist Stage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CreateConversation(CreateConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new conversation. Conversations are auto-completed after 24
        /// hours.
        /// 
        /// Conversation Lifecycle:
        /// There are two stages during a conversation: Automated Agent Stage and
        /// Assist Stage.
        /// 
        /// For Automated Agent Stage, there will be a dialogflow agent responding to
        /// user queries.
        /// 
        /// For Assist Stage, there's no dialogflow agent responding to user queries.
        /// But we will provide suggestions which are generated from conversation.
        /// 
        /// If
        /// [Conversation.conversation_profile][google.cloud.dialogflow.v2.Conversation.conversation_profile]
        /// is configured for a dialogflow agent, conversation will start from
        /// `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And
        /// during `Automated Agent Stage`, once an
        /// [Intent][google.cloud.dialogflow.v2.Intent] with
        /// [Intent.live_agent_handoff][google.cloud.dialogflow.v2.Intent.live_agent_handoff]
        /// is triggered, conversation will transfer to Assist Stage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(CreateConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new conversation. Conversations are auto-completed after 24
        /// hours.
        /// 
        /// Conversation Lifecycle:
        /// There are two stages during a conversation: Automated Agent Stage and
        /// Assist Stage.
        /// 
        /// For Automated Agent Stage, there will be a dialogflow agent responding to
        /// user queries.
        /// 
        /// For Assist Stage, there's no dialogflow agent responding to user queries.
        /// But we will provide suggestions which are generated from conversation.
        /// 
        /// If
        /// [Conversation.conversation_profile][google.cloud.dialogflow.v2.Conversation.conversation_profile]
        /// is configured for a dialogflow agent, conversation will start from
        /// `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And
        /// during `Automated Agent Stage`, once an
        /// [Intent][google.cloud.dialogflow.v2.Intent] with
        /// [Intent.live_agent_handoff][google.cloud.dialogflow.v2.Intent.live_agent_handoff]
        /// is triggered, conversation will transfer to Assist Stage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(CreateConversationRequest request, st::CancellationToken cancellationToken) =>
            CreateConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new conversation. Conversations are auto-completed after 24
        /// hours.
        /// 
        /// Conversation Lifecycle:
        /// There are two stages during a conversation: Automated Agent Stage and
        /// Assist Stage.
        /// 
        /// For Automated Agent Stage, there will be a dialogflow agent responding to
        /// user queries.
        /// 
        /// For Assist Stage, there's no dialogflow agent responding to user queries.
        /// But we will provide suggestions which are generated from conversation.
        /// 
        /// If
        /// [Conversation.conversation_profile][google.cloud.dialogflow.v2.Conversation.conversation_profile]
        /// is configured for a dialogflow agent, conversation will start from
        /// `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And
        /// during `Automated Agent Stage`, once an
        /// [Intent][google.cloud.dialogflow.v2.Intent] with
        /// [Intent.live_agent_handoff][google.cloud.dialogflow.v2.Intent.live_agent_handoff]
        /// is triggered, conversation will transfer to Assist Stage.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// Creates a new conversation. Conversations are auto-completed after 24
        /// hours.
        /// 
        /// Conversation Lifecycle:
        /// There are two stages during a conversation: Automated Agent Stage and
        /// Assist Stage.
        /// 
        /// For Automated Agent Stage, there will be a dialogflow agent responding to
        /// user queries.
        /// 
        /// For Assist Stage, there's no dialogflow agent responding to user queries.
        /// But we will provide suggestions which are generated from conversation.
        /// 
        /// If
        /// [Conversation.conversation_profile][google.cloud.dialogflow.v2.Conversation.conversation_profile]
        /// is configured for a dialogflow agent, conversation will start from
        /// `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And
        /// during `Automated Agent Stage`, once an
        /// [Intent][google.cloud.dialogflow.v2.Intent] with
        /// [Intent.live_agent_handoff][google.cloud.dialogflow.v2.Intent.live_agent_handoff]
        /// is triggered, conversation will transfer to Assist Stage.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// Creates a new conversation. Conversations are auto-completed after 24
        /// hours.
        /// 
        /// Conversation Lifecycle:
        /// There are two stages during a conversation: Automated Agent Stage and
        /// Assist Stage.
        /// 
        /// For Automated Agent Stage, there will be a dialogflow agent responding to
        /// user queries.
        /// 
        /// For Assist Stage, there's no dialogflow agent responding to user queries.
        /// But we will provide suggestions which are generated from conversation.
        /// 
        /// If
        /// [Conversation.conversation_profile][google.cloud.dialogflow.v2.Conversation.conversation_profile]
        /// is configured for a dialogflow agent, conversation will start from
        /// `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And
        /// during `Automated Agent Stage`, once an
        /// [Intent][google.cloud.dialogflow.v2.Intent] with
        /// [Intent.live_agent_handoff][google.cloud.dialogflow.v2.Intent.live_agent_handoff]
        /// is triggered, conversation will transfer to Assist Stage.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(string parent, Conversation conversation, st::CancellationToken cancellationToken) =>
            CreateConversationAsync(parent, conversation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new conversation. Conversations are auto-completed after 24
        /// hours.
        /// 
        /// Conversation Lifecycle:
        /// There are two stages during a conversation: Automated Agent Stage and
        /// Assist Stage.
        /// 
        /// For Automated Agent Stage, there will be a dialogflow agent responding to
        /// user queries.
        /// 
        /// For Assist Stage, there's no dialogflow agent responding to user queries.
        /// But we will provide suggestions which are generated from conversation.
        /// 
        /// If
        /// [Conversation.conversation_profile][google.cloud.dialogflow.v2.Conversation.conversation_profile]
        /// is configured for a dialogflow agent, conversation will start from
        /// `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And
        /// during `Automated Agent Stage`, once an
        /// [Intent][google.cloud.dialogflow.v2.Intent] with
        /// [Intent.live_agent_handoff][google.cloud.dialogflow.v2.Intent.live_agent_handoff]
        /// is triggered, conversation will transfer to Assist Stage.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CreateConversation(gagr::ProjectName parent, Conversation conversation, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversation(new CreateConversationRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Creates a new conversation. Conversations are auto-completed after 24
        /// hours.
        /// 
        /// Conversation Lifecycle:
        /// There are two stages during a conversation: Automated Agent Stage and
        /// Assist Stage.
        /// 
        /// For Automated Agent Stage, there will be a dialogflow agent responding to
        /// user queries.
        /// 
        /// For Assist Stage, there's no dialogflow agent responding to user queries.
        /// But we will provide suggestions which are generated from conversation.
        /// 
        /// If
        /// [Conversation.conversation_profile][google.cloud.dialogflow.v2.Conversation.conversation_profile]
        /// is configured for a dialogflow agent, conversation will start from
        /// `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And
        /// during `Automated Agent Stage`, once an
        /// [Intent][google.cloud.dialogflow.v2.Intent] with
        /// [Intent.live_agent_handoff][google.cloud.dialogflow.v2.Intent.live_agent_handoff]
        /// is triggered, conversation will transfer to Assist Stage.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(gagr::ProjectName parent, Conversation conversation, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationAsync(new CreateConversationRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Creates a new conversation. Conversations are auto-completed after 24
        /// hours.
        /// 
        /// Conversation Lifecycle:
        /// There are two stages during a conversation: Automated Agent Stage and
        /// Assist Stage.
        /// 
        /// For Automated Agent Stage, there will be a dialogflow agent responding to
        /// user queries.
        /// 
        /// For Assist Stage, there's no dialogflow agent responding to user queries.
        /// But we will provide suggestions which are generated from conversation.
        /// 
        /// If
        /// [Conversation.conversation_profile][google.cloud.dialogflow.v2.Conversation.conversation_profile]
        /// is configured for a dialogflow agent, conversation will start from
        /// `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And
        /// during `Automated Agent Stage`, once an
        /// [Intent][google.cloud.dialogflow.v2.Intent] with
        /// [Intent.live_agent_handoff][google.cloud.dialogflow.v2.Intent.live_agent_handoff]
        /// is triggered, conversation will transfer to Assist Stage.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(gagr::ProjectName parent, Conversation conversation, st::CancellationToken cancellationToken) =>
            CreateConversationAsync(parent, conversation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new conversation. Conversations are auto-completed after 24
        /// hours.
        /// 
        /// Conversation Lifecycle:
        /// There are two stages during a conversation: Automated Agent Stage and
        /// Assist Stage.
        /// 
        /// For Automated Agent Stage, there will be a dialogflow agent responding to
        /// user queries.
        /// 
        /// For Assist Stage, there's no dialogflow agent responding to user queries.
        /// But we will provide suggestions which are generated from conversation.
        /// 
        /// If
        /// [Conversation.conversation_profile][google.cloud.dialogflow.v2.Conversation.conversation_profile]
        /// is configured for a dialogflow agent, conversation will start from
        /// `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And
        /// during `Automated Agent Stage`, once an
        /// [Intent][google.cloud.dialogflow.v2.Intent] with
        /// [Intent.live_agent_handoff][google.cloud.dialogflow.v2.Intent.live_agent_handoff]
        /// is triggered, conversation will transfer to Assist Stage.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CreateConversation(gagr::LocationName parent, Conversation conversation, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversation(new CreateConversationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Creates a new conversation. Conversations are auto-completed after 24
        /// hours.
        /// 
        /// Conversation Lifecycle:
        /// There are two stages during a conversation: Automated Agent Stage and
        /// Assist Stage.
        /// 
        /// For Automated Agent Stage, there will be a dialogflow agent responding to
        /// user queries.
        /// 
        /// For Assist Stage, there's no dialogflow agent responding to user queries.
        /// But we will provide suggestions which are generated from conversation.
        /// 
        /// If
        /// [Conversation.conversation_profile][google.cloud.dialogflow.v2.Conversation.conversation_profile]
        /// is configured for a dialogflow agent, conversation will start from
        /// `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And
        /// during `Automated Agent Stage`, once an
        /// [Intent][google.cloud.dialogflow.v2.Intent] with
        /// [Intent.live_agent_handoff][google.cloud.dialogflow.v2.Intent.live_agent_handoff]
        /// is triggered, conversation will transfer to Assist Stage.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(gagr::LocationName parent, Conversation conversation, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationAsync(new CreateConversationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Conversation = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Creates a new conversation. Conversations are auto-completed after 24
        /// hours.
        /// 
        /// Conversation Lifecycle:
        /// There are two stages during a conversation: Automated Agent Stage and
        /// Assist Stage.
        /// 
        /// For Automated Agent Stage, there will be a dialogflow agent responding to
        /// user queries.
        /// 
        /// For Assist Stage, there's no dialogflow agent responding to user queries.
        /// But we will provide suggestions which are generated from conversation.
        /// 
        /// If
        /// [Conversation.conversation_profile][google.cloud.dialogflow.v2.Conversation.conversation_profile]
        /// is configured for a dialogflow agent, conversation will start from
        /// `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And
        /// during `Automated Agent Stage`, once an
        /// [Intent][google.cloud.dialogflow.v2.Intent] with
        /// [Intent.live_agent_handoff][google.cloud.dialogflow.v2.Intent.live_agent_handoff]
        /// is triggered, conversation will transfer to Assist Stage.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversation">
        /// Required. The conversation to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CreateConversationAsync(gagr::LocationName parent, Conversation conversation, st::CancellationToken cancellationToken) =>
            CreateConversationAsync(parent, conversation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of all conversations in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all conversations in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Conversation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(ListConversationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all conversations in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project from which to list all conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// Returns the list of all conversations in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project from which to list all conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// Returns the list of all conversations in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project from which to list all conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
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
            return ListConversations(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all conversations in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project from which to list all conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
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
            return ListConversationsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all conversations in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project from which to list all conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Returns the list of all conversations in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project from which to list all conversation.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationsRequest request = new ListConversationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Retrieves the specific conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specific conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(GetConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specific conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(GetConversationRequest request, st::CancellationToken cancellationToken) =>
            GetConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specific conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/conversations/&lt;Conversation
        /// ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversation(new GetConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specific conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/conversations/&lt;Conversation
        /// ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationAsync(new GetConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specific conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/conversations/&lt;Conversation
        /// ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(string name, st::CancellationToken cancellationToken) =>
            GetConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specific conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/conversations/&lt;Conversation
        /// ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation GetConversation(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversation(new GetConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specific conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/conversations/&lt;Conversation
        /// ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationAsync(new GetConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specific conversation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/conversations/&lt;Conversation
        /// ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> GetConversationAsync(ConversationName name, st::CancellationToken cancellationToken) =>
            GetConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Completes the specified conversation. Finished conversations are purged
        /// from the database after 30 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CompleteConversation(CompleteConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Completes the specified conversation. Finished conversations are purged
        /// from the database after 30 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CompleteConversationAsync(CompleteConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Completes the specified conversation. Finished conversations are purged
        /// from the database after 30 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CompleteConversationAsync(CompleteConversationRequest request, st::CancellationToken cancellationToken) =>
            CompleteConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Completes the specified conversation. Finished conversations are purged
        /// from the database after 30 days.
        /// </summary>
        /// <param name="name">
        /// Required. Resource identifier of the conversation to close.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CompleteConversation(string name, gaxgrpc::CallSettings callSettings = null) =>
            CompleteConversation(new CompleteConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Completes the specified conversation. Finished conversations are purged
        /// from the database after 30 days.
        /// </summary>
        /// <param name="name">
        /// Required. Resource identifier of the conversation to close.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CompleteConversationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CompleteConversationAsync(new CompleteConversationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Completes the specified conversation. Finished conversations are purged
        /// from the database after 30 days.
        /// </summary>
        /// <param name="name">
        /// Required. Resource identifier of the conversation to close.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CompleteConversationAsync(string name, st::CancellationToken cancellationToken) =>
            CompleteConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Completes the specified conversation. Finished conversations are purged
        /// from the database after 30 days.
        /// </summary>
        /// <param name="name">
        /// Required. Resource identifier of the conversation to close.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Conversation CompleteConversation(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            CompleteConversation(new CompleteConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Completes the specified conversation. Finished conversations are purged
        /// from the database after 30 days.
        /// </summary>
        /// <param name="name">
        /// Required. Resource identifier of the conversation to close.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CompleteConversationAsync(ConversationName name, gaxgrpc::CallSettings callSettings = null) =>
            CompleteConversationAsync(new CompleteConversationRequest
            {
                ConversationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Completes the specified conversation. Finished conversations are purged
        /// from the database after 30 days.
        /// </summary>
        /// <param name="name">
        /// Required. Resource identifier of the conversation to close.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Conversation> CompleteConversationAsync(ConversationName name, st::CancellationToken cancellationToken) =>
            CompleteConversationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Data ingestion API.
        /// Ingests context references for an existing conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IngestContextReferencesResponse IngestContextReferences(IngestContextReferencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Data ingestion API.
        /// Ingests context references for an existing conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IngestContextReferencesResponse> IngestContextReferencesAsync(IngestContextReferencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Data ingestion API.
        /// Ingests context references for an existing conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IngestContextReferencesResponse> IngestContextReferencesAsync(IngestContextReferencesRequest request, st::CancellationToken cancellationToken) =>
            IngestContextReferencesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Data ingestion API.
        /// Ingests context references for an existing conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. Resource identifier of the conversation to ingest context
        /// information for. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="contextReferences">
        /// Required. The context references to ingest. The key is the name of the
        /// context reference and the value contains the contents of the context
        /// reference. The key is used to incorporate ingested context references to
        /// enhance the generator.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IngestContextReferencesResponse IngestContextReferences(string conversation, scg::IDictionary<string, Conversation.Types.ContextReference> contextReferences, gaxgrpc::CallSettings callSettings = null) =>
            IngestContextReferences(new IngestContextReferencesRequest
            {
                Conversation = gax::GaxPreconditions.CheckNotNullOrEmpty(conversation, nameof(conversation)),
                ContextReferences =
                {
                    gax::GaxPreconditions.CheckNotNull(contextReferences, nameof(contextReferences)),
                },
            }, callSettings);

        /// <summary>
        /// Data ingestion API.
        /// Ingests context references for an existing conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. Resource identifier of the conversation to ingest context
        /// information for. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="contextReferences">
        /// Required. The context references to ingest. The key is the name of the
        /// context reference and the value contains the contents of the context
        /// reference. The key is used to incorporate ingested context references to
        /// enhance the generator.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IngestContextReferencesResponse> IngestContextReferencesAsync(string conversation, scg::IDictionary<string, Conversation.Types.ContextReference> contextReferences, gaxgrpc::CallSettings callSettings = null) =>
            IngestContextReferencesAsync(new IngestContextReferencesRequest
            {
                Conversation = gax::GaxPreconditions.CheckNotNullOrEmpty(conversation, nameof(conversation)),
                ContextReferences =
                {
                    gax::GaxPreconditions.CheckNotNull(contextReferences, nameof(contextReferences)),
                },
            }, callSettings);

        /// <summary>
        /// Data ingestion API.
        /// Ingests context references for an existing conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. Resource identifier of the conversation to ingest context
        /// information for. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="contextReferences">
        /// Required. The context references to ingest. The key is the name of the
        /// context reference and the value contains the contents of the context
        /// reference. The key is used to incorporate ingested context references to
        /// enhance the generator.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IngestContextReferencesResponse> IngestContextReferencesAsync(string conversation, scg::IDictionary<string, Conversation.Types.ContextReference> contextReferences, st::CancellationToken cancellationToken) =>
            IngestContextReferencesAsync(conversation, contextReferences, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Data ingestion API.
        /// Ingests context references for an existing conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. Resource identifier of the conversation to ingest context
        /// information for. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="contextReferences">
        /// Required. The context references to ingest. The key is the name of the
        /// context reference and the value contains the contents of the context
        /// reference. The key is used to incorporate ingested context references to
        /// enhance the generator.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IngestContextReferencesResponse IngestContextReferences(ConversationName conversation, scg::IDictionary<string, Conversation.Types.ContextReference> contextReferences, gaxgrpc::CallSettings callSettings = null) =>
            IngestContextReferences(new IngestContextReferencesRequest
            {
                ConversationAsConversationName = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                ContextReferences =
                {
                    gax::GaxPreconditions.CheckNotNull(contextReferences, nameof(contextReferences)),
                },
            }, callSettings);

        /// <summary>
        /// Data ingestion API.
        /// Ingests context references for an existing conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. Resource identifier of the conversation to ingest context
        /// information for. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="contextReferences">
        /// Required. The context references to ingest. The key is the name of the
        /// context reference and the value contains the contents of the context
        /// reference. The key is used to incorporate ingested context references to
        /// enhance the generator.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IngestContextReferencesResponse> IngestContextReferencesAsync(ConversationName conversation, scg::IDictionary<string, Conversation.Types.ContextReference> contextReferences, gaxgrpc::CallSettings callSettings = null) =>
            IngestContextReferencesAsync(new IngestContextReferencesRequest
            {
                ConversationAsConversationName = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
                ContextReferences =
                {
                    gax::GaxPreconditions.CheckNotNull(contextReferences, nameof(contextReferences)),
                },
            }, callSettings);

        /// <summary>
        /// Data ingestion API.
        /// Ingests context references for an existing conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. Resource identifier of the conversation to ingest context
        /// information for. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="contextReferences">
        /// Required. The context references to ingest. The key is the name of the
        /// context reference and the value contains the contents of the context
        /// reference. The key is used to incorporate ingested context references to
        /// enhance the generator.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IngestContextReferencesResponse> IngestContextReferencesAsync(ConversationName conversation, scg::IDictionary<string, Conversation.Types.ContextReference> contextReferences, st::CancellationToken cancellationToken) =>
            IngestContextReferencesAsync(conversation, contextReferences, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists messages that belong to a given conversation.
        /// `messages` are ordered by `create_time` in descending order. To fetch
        /// updates without duplication, send request with filter
        /// `create_time_epoch_microseconds &gt;
        /// [first item's create_time of previous request]` and empty page_token.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMessagesResponse, Message> ListMessages(ListMessagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists messages that belong to a given conversation.
        /// `messages` are ordered by `create_time` in descending order. To fetch
        /// updates without duplication, send request with filter
        /// `create_time_epoch_microseconds &gt;
        /// [first item's create_time of previous request]` and empty page_token.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMessagesResponse, Message> ListMessagesAsync(ListMessagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists messages that belong to a given conversation.
        /// `messages` are ordered by `create_time` in descending order. To fetch
        /// updates without duplication, send request with filter
        /// `create_time_epoch_microseconds &gt;
        /// [first item's create_time of previous request]` and empty page_token.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the conversation to list messages for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`
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
        /// <returns>A pageable sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMessagesResponse, Message> ListMessages(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessagesRequest request = new ListMessagesRequest
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
            return ListMessages(request, callSettings);
        }

        /// <summary>
        /// Lists messages that belong to a given conversation.
        /// `messages` are ordered by `create_time` in descending order. To fetch
        /// updates without duplication, send request with filter
        /// `create_time_epoch_microseconds &gt;
        /// [first item's create_time of previous request]` and empty page_token.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the conversation to list messages for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMessagesResponse, Message> ListMessagesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessagesRequest request = new ListMessagesRequest
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
            return ListMessagesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists messages that belong to a given conversation.
        /// `messages` are ordered by `create_time` in descending order. To fetch
        /// updates without duplication, send request with filter
        /// `create_time_epoch_microseconds &gt;
        /// [first item's create_time of previous request]` and empty page_token.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the conversation to list messages for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`
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
        /// <returns>A pageable sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMessagesResponse, Message> ListMessages(ConversationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessagesRequest request = new ListMessagesRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMessages(request, callSettings);
        }

        /// <summary>
        /// Lists messages that belong to a given conversation.
        /// `messages` are ordered by `create_time` in descending order. To fetch
        /// updates without duplication, send request with filter
        /// `create_time_epoch_microseconds &gt;
        /// [first item's create_time of previous request]` and empty page_token.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the conversation to list messages for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Message"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMessagesResponse, Message> ListMessagesAsync(ConversationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMessagesRequest request = new ListMessagesRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMessagesAsync(request, callSettings);
        }

        /// <summary>
        /// Suggests summary for a conversation based on specific historical messages.
        /// The range of the messages to be used for summary can be specified in the
        /// request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestConversationSummaryResponse SuggestConversationSummary(SuggestConversationSummaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Suggests summary for a conversation based on specific historical messages.
        /// The range of the messages to be used for summary can be specified in the
        /// request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestConversationSummaryResponse> SuggestConversationSummaryAsync(SuggestConversationSummaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Suggests summary for a conversation based on specific historical messages.
        /// The range of the messages to be used for summary can be specified in the
        /// request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestConversationSummaryResponse> SuggestConversationSummaryAsync(SuggestConversationSummaryRequest request, st::CancellationToken cancellationToken) =>
            SuggestConversationSummaryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Suggests summary for a conversation based on specific historical messages.
        /// The range of the messages to be used for summary can be specified in the
        /// request.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestConversationSummaryResponse SuggestConversationSummary(string conversation, gaxgrpc::CallSettings callSettings = null) =>
            SuggestConversationSummary(new SuggestConversationSummaryRequest
            {
                Conversation = gax::GaxPreconditions.CheckNotNullOrEmpty(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Suggests summary for a conversation based on specific historical messages.
        /// The range of the messages to be used for summary can be specified in the
        /// request.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestConversationSummaryResponse> SuggestConversationSummaryAsync(string conversation, gaxgrpc::CallSettings callSettings = null) =>
            SuggestConversationSummaryAsync(new SuggestConversationSummaryRequest
            {
                Conversation = gax::GaxPreconditions.CheckNotNullOrEmpty(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Suggests summary for a conversation based on specific historical messages.
        /// The range of the messages to be used for summary can be specified in the
        /// request.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestConversationSummaryResponse> SuggestConversationSummaryAsync(string conversation, st::CancellationToken cancellationToken) =>
            SuggestConversationSummaryAsync(conversation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Suggests summary for a conversation based on specific historical messages.
        /// The range of the messages to be used for summary can be specified in the
        /// request.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestConversationSummaryResponse SuggestConversationSummary(ConversationName conversation, gaxgrpc::CallSettings callSettings = null) =>
            SuggestConversationSummary(new SuggestConversationSummaryRequest
            {
                ConversationAsConversationName = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Suggests summary for a conversation based on specific historical messages.
        /// The range of the messages to be used for summary can be specified in the
        /// request.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestConversationSummaryResponse> SuggestConversationSummaryAsync(ConversationName conversation, gaxgrpc::CallSettings callSettings = null) =>
            SuggestConversationSummaryAsync(new SuggestConversationSummaryRequest
            {
                ConversationAsConversationName = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Suggests summary for a conversation based on specific historical messages.
        /// The range of the messages to be used for summary can be specified in the
        /// request.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestConversationSummaryResponse> SuggestConversationSummaryAsync(ConversationName conversation, st::CancellationToken cancellationToken) =>
            SuggestConversationSummaryAsync(conversation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates and returns a summary for a conversation that does not have a
        /// resource created for it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateStatelessSummaryResponse GenerateStatelessSummary(GenerateStatelessSummaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates and returns a summary for a conversation that does not have a
        /// resource created for it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateStatelessSummaryResponse> GenerateStatelessSummaryAsync(GenerateStatelessSummaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates and returns a summary for a conversation that does not have a
        /// resource created for it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateStatelessSummaryResponse> GenerateStatelessSummaryAsync(GenerateStatelessSummaryRequest request, st::CancellationToken cancellationToken) =>
            GenerateStatelessSummaryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates and returns a suggestion for a conversation that does not have a
        /// resource created for it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateStatelessSuggestionResponse GenerateStatelessSuggestion(GenerateStatelessSuggestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates and returns a suggestion for a conversation that does not have a
        /// resource created for it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateStatelessSuggestionResponse> GenerateStatelessSuggestionAsync(GenerateStatelessSuggestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates and returns a suggestion for a conversation that does not have a
        /// resource created for it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateStatelessSuggestionResponse> GenerateStatelessSuggestionAsync(GenerateStatelessSuggestionRequest request, st::CancellationToken cancellationToken) =>
            GenerateStatelessSuggestionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get answers for the given query based on knowledge documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchKnowledgeResponse SearchKnowledge(SearchKnowledgeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get answers for the given query based on knowledge documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchKnowledgeResponse> SearchKnowledgeAsync(SearchKnowledgeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get answers for the given query based on knowledge documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchKnowledgeResponse> SearchKnowledgeAsync(SearchKnowledgeRequest request, st::CancellationToken cancellationToken) =>
            SearchKnowledgeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates all the suggestions using generators configured in the
        /// conversation profile. A generator is used only if its trigger event is
        /// matched.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateSuggestionsResponse GenerateSuggestions(GenerateSuggestionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates all the suggestions using generators configured in the
        /// conversation profile. A generator is used only if its trigger event is
        /// matched.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateSuggestionsResponse> GenerateSuggestionsAsync(GenerateSuggestionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates all the suggestions using generators configured in the
        /// conversation profile. A generator is used only if its trigger event is
        /// matched.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateSuggestionsResponse> GenerateSuggestionsAsync(GenerateSuggestionsRequest request, st::CancellationToken cancellationToken) =>
            GenerateSuggestionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates all the suggestions using generators configured in the
        /// conversation profile. A generator is used only if its trigger event is
        /// matched.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation for which the suggestions are generated. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// 
        /// The conversation must be created with a conversation profile which has
        /// generators configured in it to be able to get suggestions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateSuggestionsResponse GenerateSuggestions(string conversation, gaxgrpc::CallSettings callSettings = null) =>
            GenerateSuggestions(new GenerateSuggestionsRequest
            {
                Conversation = gax::GaxPreconditions.CheckNotNullOrEmpty(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Generates all the suggestions using generators configured in the
        /// conversation profile. A generator is used only if its trigger event is
        /// matched.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation for which the suggestions are generated. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// 
        /// The conversation must be created with a conversation profile which has
        /// generators configured in it to be able to get suggestions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateSuggestionsResponse> GenerateSuggestionsAsync(string conversation, gaxgrpc::CallSettings callSettings = null) =>
            GenerateSuggestionsAsync(new GenerateSuggestionsRequest
            {
                Conversation = gax::GaxPreconditions.CheckNotNullOrEmpty(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Generates all the suggestions using generators configured in the
        /// conversation profile. A generator is used only if its trigger event is
        /// matched.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation for which the suggestions are generated. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// 
        /// The conversation must be created with a conversation profile which has
        /// generators configured in it to be able to get suggestions.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateSuggestionsResponse> GenerateSuggestionsAsync(string conversation, st::CancellationToken cancellationToken) =>
            GenerateSuggestionsAsync(conversation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates all the suggestions using generators configured in the
        /// conversation profile. A generator is used only if its trigger event is
        /// matched.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation for which the suggestions are generated. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// 
        /// The conversation must be created with a conversation profile which has
        /// generators configured in it to be able to get suggestions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateSuggestionsResponse GenerateSuggestions(ConversationName conversation, gaxgrpc::CallSettings callSettings = null) =>
            GenerateSuggestions(new GenerateSuggestionsRequest
            {
                ConversationAsConversationName = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Generates all the suggestions using generators configured in the
        /// conversation profile. A generator is used only if its trigger event is
        /// matched.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation for which the suggestions are generated. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// 
        /// The conversation must be created with a conversation profile which has
        /// generators configured in it to be able to get suggestions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateSuggestionsResponse> GenerateSuggestionsAsync(ConversationName conversation, gaxgrpc::CallSettings callSettings = null) =>
            GenerateSuggestionsAsync(new GenerateSuggestionsRequest
            {
                ConversationAsConversationName = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Generates all the suggestions using generators configured in the
        /// conversation profile. A generator is used only if its trigger event is
        /// matched.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation for which the suggestions are generated. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// 
        /// The conversation must be created with a conversation profile which has
        /// generators configured in it to be able to get suggestions.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateSuggestionsResponse> GenerateSuggestionsAsync(ConversationName conversation, st::CancellationToken cancellationToken) =>
            GenerateSuggestionsAsync(conversation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Conversations client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [Conversations][google.cloud.dialogflow.v2.Conversation].
    /// </remarks>
    public sealed partial class ConversationsClientImpl : ConversationsClient
    {
        private readonly gaxgrpc::ApiCall<CreateConversationRequest, Conversation> _callCreateConversation;

        private readonly gaxgrpc::ApiCall<ListConversationsRequest, ListConversationsResponse> _callListConversations;

        private readonly gaxgrpc::ApiCall<GetConversationRequest, Conversation> _callGetConversation;

        private readonly gaxgrpc::ApiCall<CompleteConversationRequest, Conversation> _callCompleteConversation;

        private readonly gaxgrpc::ApiCall<IngestContextReferencesRequest, IngestContextReferencesResponse> _callIngestContextReferences;

        private readonly gaxgrpc::ApiCall<ListMessagesRequest, ListMessagesResponse> _callListMessages;

        private readonly gaxgrpc::ApiCall<SuggestConversationSummaryRequest, SuggestConversationSummaryResponse> _callSuggestConversationSummary;

        private readonly gaxgrpc::ApiCall<GenerateStatelessSummaryRequest, GenerateStatelessSummaryResponse> _callGenerateStatelessSummary;

        private readonly gaxgrpc::ApiCall<GenerateStatelessSuggestionRequest, GenerateStatelessSuggestionResponse> _callGenerateStatelessSuggestion;

        private readonly gaxgrpc::ApiCall<SearchKnowledgeRequest, SearchKnowledgeResponse> _callSearchKnowledge;

        private readonly gaxgrpc::ApiCall<GenerateSuggestionsRequest, GenerateSuggestionsResponse> _callGenerateSuggestions;

        /// <summary>
        /// Constructs a client wrapper for the Conversations service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConversationsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConversationsClientImpl(Conversations.ConversationsClient grpcClient, ConversationsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConversationsSettings effectiveSettings = settings ?? ConversationsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateConversation = clientHelper.BuildApiCall<CreateConversationRequest, Conversation>("CreateConversation", grpcClient.CreateConversationAsync, grpcClient.CreateConversation, effectiveSettings.CreateConversationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConversation);
            Modify_CreateConversationApiCall(ref _callCreateConversation);
            _callListConversations = clientHelper.BuildApiCall<ListConversationsRequest, ListConversationsResponse>("ListConversations", grpcClient.ListConversationsAsync, grpcClient.ListConversations, effectiveSettings.ListConversationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConversations);
            Modify_ListConversationsApiCall(ref _callListConversations);
            _callGetConversation = clientHelper.BuildApiCall<GetConversationRequest, Conversation>("GetConversation", grpcClient.GetConversationAsync, grpcClient.GetConversation, effectiveSettings.GetConversationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConversation);
            Modify_GetConversationApiCall(ref _callGetConversation);
            _callCompleteConversation = clientHelper.BuildApiCall<CompleteConversationRequest, Conversation>("CompleteConversation", grpcClient.CompleteConversationAsync, grpcClient.CompleteConversation, effectiveSettings.CompleteConversationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCompleteConversation);
            Modify_CompleteConversationApiCall(ref _callCompleteConversation);
            _callIngestContextReferences = clientHelper.BuildApiCall<IngestContextReferencesRequest, IngestContextReferencesResponse>("IngestContextReferences", grpcClient.IngestContextReferencesAsync, grpcClient.IngestContextReferences, effectiveSettings.IngestContextReferencesSettings).WithGoogleRequestParam("conversation", request => request.Conversation);
            Modify_ApiCall(ref _callIngestContextReferences);
            Modify_IngestContextReferencesApiCall(ref _callIngestContextReferences);
            _callListMessages = clientHelper.BuildApiCall<ListMessagesRequest, ListMessagesResponse>("ListMessages", grpcClient.ListMessagesAsync, grpcClient.ListMessages, effectiveSettings.ListMessagesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMessages);
            Modify_ListMessagesApiCall(ref _callListMessages);
            _callSuggestConversationSummary = clientHelper.BuildApiCall<SuggestConversationSummaryRequest, SuggestConversationSummaryResponse>("SuggestConversationSummary", grpcClient.SuggestConversationSummaryAsync, grpcClient.SuggestConversationSummary, effectiveSettings.SuggestConversationSummarySettings).WithGoogleRequestParam("conversation", request => request.Conversation);
            Modify_ApiCall(ref _callSuggestConversationSummary);
            Modify_SuggestConversationSummaryApiCall(ref _callSuggestConversationSummary);
            _callGenerateStatelessSummary = clientHelper.BuildApiCall<GenerateStatelessSummaryRequest, GenerateStatelessSummaryResponse>("GenerateStatelessSummary", grpcClient.GenerateStatelessSummaryAsync, grpcClient.GenerateStatelessSummary, effectiveSettings.GenerateStatelessSummarySettings).WithGoogleRequestParam("stateless_conversation.parent", request => request.StatelessConversation?.Parent);
            Modify_ApiCall(ref _callGenerateStatelessSummary);
            Modify_GenerateStatelessSummaryApiCall(ref _callGenerateStatelessSummary);
            _callGenerateStatelessSuggestion = clientHelper.BuildApiCall<GenerateStatelessSuggestionRequest, GenerateStatelessSuggestionResponse>("GenerateStatelessSuggestion", grpcClient.GenerateStatelessSuggestionAsync, grpcClient.GenerateStatelessSuggestion, effectiveSettings.GenerateStatelessSuggestionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGenerateStatelessSuggestion);
            Modify_GenerateStatelessSuggestionApiCall(ref _callGenerateStatelessSuggestion);
            _callSearchKnowledge = clientHelper.BuildApiCall<SearchKnowledgeRequest, SearchKnowledgeResponse>("SearchKnowledge", grpcClient.SearchKnowledgeAsync, grpcClient.SearchKnowledge, effectiveSettings.SearchKnowledgeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchKnowledge);
            Modify_SearchKnowledgeApiCall(ref _callSearchKnowledge);
            _callGenerateSuggestions = clientHelper.BuildApiCall<GenerateSuggestionsRequest, GenerateSuggestionsResponse>("GenerateSuggestions", grpcClient.GenerateSuggestionsAsync, grpcClient.GenerateSuggestions, effectiveSettings.GenerateSuggestionsSettings).WithGoogleRequestParam("conversation", request => request.Conversation);
            Modify_ApiCall(ref _callGenerateSuggestions);
            Modify_GenerateSuggestionsApiCall(ref _callGenerateSuggestions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateConversationApiCall(ref gaxgrpc::ApiCall<CreateConversationRequest, Conversation> call);

        partial void Modify_ListConversationsApiCall(ref gaxgrpc::ApiCall<ListConversationsRequest, ListConversationsResponse> call);

        partial void Modify_GetConversationApiCall(ref gaxgrpc::ApiCall<GetConversationRequest, Conversation> call);

        partial void Modify_CompleteConversationApiCall(ref gaxgrpc::ApiCall<CompleteConversationRequest, Conversation> call);

        partial void Modify_IngestContextReferencesApiCall(ref gaxgrpc::ApiCall<IngestContextReferencesRequest, IngestContextReferencesResponse> call);

        partial void Modify_ListMessagesApiCall(ref gaxgrpc::ApiCall<ListMessagesRequest, ListMessagesResponse> call);

        partial void Modify_SuggestConversationSummaryApiCall(ref gaxgrpc::ApiCall<SuggestConversationSummaryRequest, SuggestConversationSummaryResponse> call);

        partial void Modify_GenerateStatelessSummaryApiCall(ref gaxgrpc::ApiCall<GenerateStatelessSummaryRequest, GenerateStatelessSummaryResponse> call);

        partial void Modify_GenerateStatelessSuggestionApiCall(ref gaxgrpc::ApiCall<GenerateStatelessSuggestionRequest, GenerateStatelessSuggestionResponse> call);

        partial void Modify_SearchKnowledgeApiCall(ref gaxgrpc::ApiCall<SearchKnowledgeRequest, SearchKnowledgeResponse> call);

        partial void Modify_GenerateSuggestionsApiCall(ref gaxgrpc::ApiCall<GenerateSuggestionsRequest, GenerateSuggestionsResponse> call);

        partial void OnConstruction(Conversations.ConversationsClient grpcClient, ConversationsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Conversations client</summary>
        public override Conversations.ConversationsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateConversationRequest(ref CreateConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConversationsRequest(ref ListConversationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConversationRequest(ref GetConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CompleteConversationRequest(ref CompleteConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_IngestContextReferencesRequest(ref IngestContextReferencesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMessagesRequest(ref ListMessagesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SuggestConversationSummaryRequest(ref SuggestConversationSummaryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateStatelessSummaryRequest(ref GenerateStatelessSummaryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateStatelessSuggestionRequest(ref GenerateStatelessSuggestionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchKnowledgeRequest(ref SearchKnowledgeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateSuggestionsRequest(ref GenerateSuggestionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new conversation. Conversations are auto-completed after 24
        /// hours.
        /// 
        /// Conversation Lifecycle:
        /// There are two stages during a conversation: Automated Agent Stage and
        /// Assist Stage.
        /// 
        /// For Automated Agent Stage, there will be a dialogflow agent responding to
        /// user queries.
        /// 
        /// For Assist Stage, there's no dialogflow agent responding to user queries.
        /// But we will provide suggestions which are generated from conversation.
        /// 
        /// If
        /// [Conversation.conversation_profile][google.cloud.dialogflow.v2.Conversation.conversation_profile]
        /// is configured for a dialogflow agent, conversation will start from
        /// `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And
        /// during `Automated Agent Stage`, once an
        /// [Intent][google.cloud.dialogflow.v2.Intent] with
        /// [Intent.live_agent_handoff][google.cloud.dialogflow.v2.Intent.live_agent_handoff]
        /// is triggered, conversation will transfer to Assist Stage.
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
        /// Creates a new conversation. Conversations are auto-completed after 24
        /// hours.
        /// 
        /// Conversation Lifecycle:
        /// There are two stages during a conversation: Automated Agent Stage and
        /// Assist Stage.
        /// 
        /// For Automated Agent Stage, there will be a dialogflow agent responding to
        /// user queries.
        /// 
        /// For Assist Stage, there's no dialogflow agent responding to user queries.
        /// But we will provide suggestions which are generated from conversation.
        /// 
        /// If
        /// [Conversation.conversation_profile][google.cloud.dialogflow.v2.Conversation.conversation_profile]
        /// is configured for a dialogflow agent, conversation will start from
        /// `Automated Agent Stage`, otherwise, it will start from `Assist Stage`. And
        /// during `Automated Agent Stage`, once an
        /// [Intent][google.cloud.dialogflow.v2.Intent] with
        /// [Intent.live_agent_handoff][google.cloud.dialogflow.v2.Intent.live_agent_handoff]
        /// is triggered, conversation will transfer to Assist Stage.
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
        /// Returns the list of all conversations in the specified project.
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
        /// Returns the list of all conversations in the specified project.
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
        /// Retrieves the specific conversation.
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
        /// Retrieves the specific conversation.
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
        /// Completes the specified conversation. Finished conversations are purged
        /// from the database after 30 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Conversation CompleteConversation(CompleteConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CompleteConversationRequest(ref request, ref callSettings);
            return _callCompleteConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// Completes the specified conversation. Finished conversations are purged
        /// from the database after 30 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Conversation> CompleteConversationAsync(CompleteConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CompleteConversationRequest(ref request, ref callSettings);
            return _callCompleteConversation.Async(request, callSettings);
        }

        /// <summary>
        /// Data ingestion API.
        /// Ingests context references for an existing conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IngestContextReferencesResponse IngestContextReferences(IngestContextReferencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IngestContextReferencesRequest(ref request, ref callSettings);
            return _callIngestContextReferences.Sync(request, callSettings);
        }

        /// <summary>
        /// Data ingestion API.
        /// Ingests context references for an existing conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IngestContextReferencesResponse> IngestContextReferencesAsync(IngestContextReferencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IngestContextReferencesRequest(ref request, ref callSettings);
            return _callIngestContextReferences.Async(request, callSettings);
        }

        /// <summary>
        /// Lists messages that belong to a given conversation.
        /// `messages` are ordered by `create_time` in descending order. To fetch
        /// updates without duplication, send request with filter
        /// `create_time_epoch_microseconds &gt;
        /// [first item's create_time of previous request]` and empty page_token.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Message"/> resources.</returns>
        public override gax::PagedEnumerable<ListMessagesResponse, Message> ListMessages(ListMessagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMessagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMessagesRequest, ListMessagesResponse, Message>(_callListMessages, request, callSettings);
        }

        /// <summary>
        /// Lists messages that belong to a given conversation.
        /// `messages` are ordered by `create_time` in descending order. To fetch
        /// updates without duplication, send request with filter
        /// `create_time_epoch_microseconds &gt;
        /// [first item's create_time of previous request]` and empty page_token.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Message"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMessagesResponse, Message> ListMessagesAsync(ListMessagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMessagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMessagesRequest, ListMessagesResponse, Message>(_callListMessages, request, callSettings);
        }

        /// <summary>
        /// Suggests summary for a conversation based on specific historical messages.
        /// The range of the messages to be used for summary can be specified in the
        /// request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SuggestConversationSummaryResponse SuggestConversationSummary(SuggestConversationSummaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestConversationSummaryRequest(ref request, ref callSettings);
            return _callSuggestConversationSummary.Sync(request, callSettings);
        }

        /// <summary>
        /// Suggests summary for a conversation based on specific historical messages.
        /// The range of the messages to be used for summary can be specified in the
        /// request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SuggestConversationSummaryResponse> SuggestConversationSummaryAsync(SuggestConversationSummaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestConversationSummaryRequest(ref request, ref callSettings);
            return _callSuggestConversationSummary.Async(request, callSettings);
        }

        /// <summary>
        /// Generates and returns a summary for a conversation that does not have a
        /// resource created for it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateStatelessSummaryResponse GenerateStatelessSummary(GenerateStatelessSummaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateStatelessSummaryRequest(ref request, ref callSettings);
            return _callGenerateStatelessSummary.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates and returns a summary for a conversation that does not have a
        /// resource created for it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateStatelessSummaryResponse> GenerateStatelessSummaryAsync(GenerateStatelessSummaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateStatelessSummaryRequest(ref request, ref callSettings);
            return _callGenerateStatelessSummary.Async(request, callSettings);
        }

        /// <summary>
        /// Generates and returns a suggestion for a conversation that does not have a
        /// resource created for it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateStatelessSuggestionResponse GenerateStatelessSuggestion(GenerateStatelessSuggestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateStatelessSuggestionRequest(ref request, ref callSettings);
            return _callGenerateStatelessSuggestion.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates and returns a suggestion for a conversation that does not have a
        /// resource created for it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateStatelessSuggestionResponse> GenerateStatelessSuggestionAsync(GenerateStatelessSuggestionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateStatelessSuggestionRequest(ref request, ref callSettings);
            return _callGenerateStatelessSuggestion.Async(request, callSettings);
        }

        /// <summary>
        /// Get answers for the given query based on knowledge documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchKnowledgeResponse SearchKnowledge(SearchKnowledgeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchKnowledgeRequest(ref request, ref callSettings);
            return _callSearchKnowledge.Sync(request, callSettings);
        }

        /// <summary>
        /// Get answers for the given query based on knowledge documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchKnowledgeResponse> SearchKnowledgeAsync(SearchKnowledgeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchKnowledgeRequest(ref request, ref callSettings);
            return _callSearchKnowledge.Async(request, callSettings);
        }

        /// <summary>
        /// Generates all the suggestions using generators configured in the
        /// conversation profile. A generator is used only if its trigger event is
        /// matched.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateSuggestionsResponse GenerateSuggestions(GenerateSuggestionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateSuggestionsRequest(ref request, ref callSettings);
            return _callGenerateSuggestions.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates all the suggestions using generators configured in the
        /// conversation profile. A generator is used only if its trigger event is
        /// matched.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateSuggestionsResponse> GenerateSuggestionsAsync(GenerateSuggestionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateSuggestionsRequest(ref request, ref callSettings);
            return _callGenerateSuggestions.Async(request, callSettings);
        }
    }

    public partial class ListConversationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMessagesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConversationsResponse : gaxgrpc::IPageResponse<Conversation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Conversation> GetEnumerator() => Conversations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMessagesResponse : gaxgrpc::IPageResponse<Message>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Message> GetEnumerator() => Messages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Conversations
    {
        public partial class ConversationsClient
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
