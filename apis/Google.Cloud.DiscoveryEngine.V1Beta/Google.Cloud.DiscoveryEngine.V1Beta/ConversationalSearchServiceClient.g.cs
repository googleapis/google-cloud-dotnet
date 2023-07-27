// Copyright 2023 Google LLC
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
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

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
            return ConversationalSearchServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<ConversationalSearchServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversationalSearchServiceClient.Create(callInvoker, Settings, Logger);
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
        /// Use
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
        /// Use
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
        /// Use
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
        /// Use
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
        /// Use
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`.
        /// Use
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/-`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
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
        /// * [conversation.name][]
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
        /// * [conversation.name][]
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
        /// * [conversation.name][]
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}/conversations/{conversation_id}`
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
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
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
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConversations(new ListConversationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all Conversations by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
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
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConversationsAsync(new ListConversationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all Conversations by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
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
        public virtual gax::PagedEnumerable<ListConversationsResponse, Conversation> ListConversations(DataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConversations(new ListConversationsRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all Conversations by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project_number}/locations/{location_id}/collections/{collection}/dataStores/{data_store_id}`
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
        public virtual gax::PagedAsyncEnumerable<ListConversationsResponse, Conversation> ListConversationsAsync(DataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListConversationsAsync(new ListConversationsRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
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
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
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
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ConverseConversationApiCall(ref gaxgrpc::ApiCall<ConverseConversationRequest, ConverseConversationResponse> call);

        partial void Modify_CreateConversationApiCall(ref gaxgrpc::ApiCall<CreateConversationRequest, Conversation> call);

        partial void Modify_DeleteConversationApiCall(ref gaxgrpc::ApiCall<DeleteConversationRequest, wkt::Empty> call);

        partial void Modify_UpdateConversationApiCall(ref gaxgrpc::ApiCall<UpdateConversationRequest, Conversation> call);

        partial void Modify_GetConversationApiCall(ref gaxgrpc::ApiCall<GetConversationRequest, Conversation> call);

        partial void Modify_ListConversationsApiCall(ref gaxgrpc::ApiCall<ListConversationsRequest, ListConversationsResponse> call);

        partial void OnConstruction(ConversationalSearchService.ConversationalSearchServiceClient grpcClient, ConversationalSearchServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConversationalSearchService client</summary>
        public override ConversationalSearchService.ConversationalSearchServiceClient GrpcClient { get; }

        partial void Modify_ConverseConversationRequest(ref ConverseConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConversationRequest(ref CreateConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConversationRequest(ref DeleteConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConversationRequest(ref UpdateConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConversationRequest(ref GetConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConversationsRequest(ref ListConversationsRequest request, ref gaxgrpc::CallSettings settings);

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
    }

    public partial class ListConversationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConversationsResponse : gaxgrpc::IPageResponse<Conversation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Conversation> GetEnumerator() => Conversations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
