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

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Settings for <see cref="ParticipantsClient"/> instances.</summary>
    public sealed partial class ParticipantsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ParticipantsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ParticipantsSettings"/>.</returns>
        public static ParticipantsSettings GetDefault() => new ParticipantsSettings();

        /// <summary>Constructs a new <see cref="ParticipantsSettings"/> object with default settings.</summary>
        public ParticipantsSettings()
        {
        }

        private ParticipantsSettings(ParticipantsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateParticipantSettings = existing.CreateParticipantSettings;
            GetParticipantSettings = existing.GetParticipantSettings;
            ListParticipantsSettings = existing.ListParticipantsSettings;
            UpdateParticipantSettings = existing.UpdateParticipantSettings;
            AnalyzeContentSettings = existing.AnalyzeContentSettings;
            StreamingAnalyzeContentSettings = existing.StreamingAnalyzeContentSettings;
            StreamingAnalyzeContentStreamingSettings = existing.StreamingAnalyzeContentStreamingSettings;
            SuggestArticlesSettings = existing.SuggestArticlesSettings;
            SuggestFaqAnswersSettings = existing.SuggestFaqAnswersSettings;
            SuggestSmartRepliesSettings = existing.SuggestSmartRepliesSettings;
            ListSuggestionsSettings = existing.ListSuggestionsSettings;
            CompileSuggestionSettings = existing.CompileSuggestionSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ParticipantsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.CreateParticipant</c> and <c>ParticipantsClient.CreateParticipantAsync</c>.
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
        public gaxgrpc::CallSettings CreateParticipantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.GetParticipant</c> and <c>ParticipantsClient.GetParticipantAsync</c>.
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
        public gaxgrpc::CallSettings GetParticipantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.ListParticipants</c> and <c>ParticipantsClient.ListParticipantsAsync</c>.
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
        public gaxgrpc::CallSettings ListParticipantsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.UpdateParticipant</c> and <c>ParticipantsClient.UpdateParticipantAsync</c>.
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
        public gaxgrpc::CallSettings UpdateParticipantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.AnalyzeContent</c> and <c>ParticipantsClient.AnalyzeContentAsync</c>.
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
        /// <item><description>Timeout: 220 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnalyzeContentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(220000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.StreamingAnalyzeContent</c> and <c>ParticipantsClient.StreamingAnalyzeContentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 220 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamingAnalyzeContentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(220000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>ParticipantsClient.StreamingAnalyzeContent</c> and <c>ParticipantsClient.StreamingAnalyzeContentAsync</c>
        /// .
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamingAnalyzeContentStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.SuggestArticles</c> and <c>ParticipantsClient.SuggestArticlesAsync</c>.
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
        public gaxgrpc::CallSettings SuggestArticlesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.SuggestFaqAnswers</c> and <c>ParticipantsClient.SuggestFaqAnswersAsync</c>.
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
        public gaxgrpc::CallSettings SuggestFaqAnswersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.SuggestSmartReplies</c> and <c>ParticipantsClient.SuggestSmartRepliesAsync</c>.
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
        public gaxgrpc::CallSettings SuggestSmartRepliesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.ListSuggestions</c> and <c>ParticipantsClient.ListSuggestionsAsync</c>.
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
        public gaxgrpc::CallSettings ListSuggestionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParticipantsClient.CompileSuggestion</c> and <c>ParticipantsClient.CompileSuggestionAsync</c>.
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
        public gaxgrpc::CallSettings CompileSuggestionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ParticipantsSettings"/> object.</returns>
        public ParticipantsSettings Clone() => new ParticipantsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ParticipantsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ParticipantsClientBuilder : gaxgrpc::ClientBuilderBase<ParticipantsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ParticipantsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ParticipantsClientBuilder() : base(ParticipantsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ParticipantsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ParticipantsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ParticipantsClient Build()
        {
            ParticipantsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ParticipantsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ParticipantsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ParticipantsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ParticipantsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ParticipantsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ParticipantsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ParticipantsClient.ChannelPool;
    }

    /// <summary>Participants client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [Participants][google.cloud.dialogflow.v2beta1.Participant].
    /// </remarks>
    public abstract partial class ParticipantsClient
    {
        /// <summary>
        /// The default endpoint for the Participants service, which is a host of "dialogflow.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Participants scopes.</summary>
        /// <remarks>
        /// The default Participants scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Participants.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ParticipantsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ParticipantsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ParticipantsClient"/>.</returns>
        public static stt::Task<ParticipantsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ParticipantsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ParticipantsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ParticipantsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ParticipantsClient"/>.</returns>
        public static ParticipantsClient Create() => new ParticipantsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ParticipantsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ParticipantsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ParticipantsClient"/>.</returns>
        internal static ParticipantsClient Create(grpccore::CallInvoker callInvoker, ParticipantsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Participants.ParticipantsClient grpcClient = new Participants.ParticipantsClient(callInvoker);
            return new ParticipantsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Participants client</summary>
        public virtual Participants.ParticipantsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant CreateParticipant(CreateParticipantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> CreateParticipantAsync(CreateParticipantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> CreateParticipantAsync(CreateParticipantRequest request, st::CancellationToken cancellationToken) =>
            CreateParticipantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the conversation adding the participant.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="participant">
        /// Required. The participant to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant CreateParticipant(string parent, Participant participant, gaxgrpc::CallSettings callSettings = null) =>
            CreateParticipant(new CreateParticipantRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Participant = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
            }, callSettings);

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the conversation adding the participant.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="participant">
        /// Required. The participant to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> CreateParticipantAsync(string parent, Participant participant, gaxgrpc::CallSettings callSettings = null) =>
            CreateParticipantAsync(new CreateParticipantRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Participant = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
            }, callSettings);

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the conversation adding the participant.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="participant">
        /// Required. The participant to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> CreateParticipantAsync(string parent, Participant participant, st::CancellationToken cancellationToken) =>
            CreateParticipantAsync(parent, participant, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the conversation adding the participant.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="participant">
        /// Required. The participant to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant CreateParticipant(ConversationName parent, Participant participant, gaxgrpc::CallSettings callSettings = null) =>
            CreateParticipant(new CreateParticipantRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Participant = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
            }, callSettings);

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the conversation adding the participant.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="participant">
        /// Required. The participant to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> CreateParticipantAsync(ConversationName parent, Participant participant, gaxgrpc::CallSettings callSettings = null) =>
            CreateParticipantAsync(new CreateParticipantRequest
            {
                ParentAsConversationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Participant = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
            }, callSettings);

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the conversation adding the participant.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
        /// </param>
        /// <param name="participant">
        /// Required. The participant to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> CreateParticipantAsync(ConversationName parent, Participant participant, st::CancellationToken cancellationToken) =>
            CreateParticipantAsync(parent, participant, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant GetParticipant(GetParticipantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(GetParticipantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(GetParticipantRequest request, st::CancellationToken cancellationToken) =>
            GetParticipantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the participant. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/conversations/&lt;Conversation
        /// ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant GetParticipant(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipant(new GetParticipantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the participant. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/conversations/&lt;Conversation
        /// ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipantAsync(new GetParticipantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the participant. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/conversations/&lt;Conversation
        /// ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(string name, st::CancellationToken cancellationToken) =>
            GetParticipantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the participant. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/conversations/&lt;Conversation
        /// ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant GetParticipant(ParticipantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipant(new GetParticipantRequest
            {
                ParticipantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the participant. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/conversations/&lt;Conversation
        /// ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(ParticipantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipantAsync(new GetParticipantRequest
            {
                ParticipantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the participant. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/conversations/&lt;Conversation
        /// ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(ParticipantName name, st::CancellationToken cancellationToken) =>
            GetParticipantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Participant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParticipantsResponse, Participant> ListParticipants(ListParticipantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Participant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParticipantsResponse, Participant> ListParticipantsAsync(ListParticipantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation to list all participants from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Participant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParticipantsResponse, Participant> ListParticipants(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParticipantsRequest request = new ListParticipantsRequest
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
            return ListParticipants(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation to list all participants from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Participant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParticipantsResponse, Participant> ListParticipantsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParticipantsRequest request = new ListParticipantsRequest
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
            return ListParticipantsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation to list all participants from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Participant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParticipantsResponse, Participant> ListParticipants(ConversationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParticipantsRequest request = new ListParticipantsRequest
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
            return ListParticipants(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="parent">
        /// Required. The conversation to list all participants from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Participant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParticipantsResponse, Participant> ListParticipantsAsync(ConversationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParticipantsRequest request = new ListParticipantsRequest
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
            return ListParticipantsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant UpdateParticipant(UpdateParticipantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> UpdateParticipantAsync(UpdateParticipantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> UpdateParticipantAsync(UpdateParticipantRequest request, st::CancellationToken cancellationToken) =>
            UpdateParticipantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="participant">
        /// Required. The participant to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to specify which fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant UpdateParticipant(Participant participant, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateParticipant(new UpdateParticipantRequest
            {
                Participant = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="participant">
        /// Required. The participant to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to specify which fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> UpdateParticipantAsync(Participant participant, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateParticipantAsync(new UpdateParticipantRequest
            {
                Participant = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="participant">
        /// Required. The participant to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to specify which fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> UpdateParticipantAsync(Participant participant, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateParticipantAsync(participant, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeContentResponse AnalyzeContent(AnalyzeContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(AnalyzeContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(AnalyzeContentRequest request, st::CancellationToken cancellationToken) =>
            AnalyzeContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="textInput">
        /// The natural language text to be processed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeContentResponse AnalyzeContent(string participant, TextInput textInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContent(new AnalyzeContentRequest
            {
                Participant = gax::GaxPreconditions.CheckNotNullOrEmpty(participant, nameof(participant)),
                TextInput = textInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="textInput">
        /// The natural language text to be processed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(string participant, TextInput textInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContentAsync(new AnalyzeContentRequest
            {
                Participant = gax::GaxPreconditions.CheckNotNullOrEmpty(participant, nameof(participant)),
                TextInput = textInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="textInput">
        /// The natural language text to be processed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(string participant, TextInput textInput, st::CancellationToken cancellationToken) =>
            AnalyzeContentAsync(participant, textInput, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="textInput">
        /// The natural language text to be processed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeContentResponse AnalyzeContent(ParticipantName participant, TextInput textInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContent(new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
                TextInput = textInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="textInput">
        /// The natural language text to be processed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(ParticipantName participant, TextInput textInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContentAsync(new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
                TextInput = textInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="textInput">
        /// The natural language text to be processed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(ParticipantName participant, TextInput textInput, st::CancellationToken cancellationToken) =>
            AnalyzeContentAsync(participant, textInput, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="audioInput">
        /// The natural language speech audio to be processed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeContentResponse AnalyzeContent(string participant, AudioInput audioInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContent(new AnalyzeContentRequest
            {
                Participant = gax::GaxPreconditions.CheckNotNullOrEmpty(participant, nameof(participant)),
                AudioInput = audioInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="audioInput">
        /// The natural language speech audio to be processed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(string participant, AudioInput audioInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContentAsync(new AnalyzeContentRequest
            {
                Participant = gax::GaxPreconditions.CheckNotNullOrEmpty(participant, nameof(participant)),
                AudioInput = audioInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="audioInput">
        /// The natural language speech audio to be processed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(string participant, AudioInput audioInput, st::CancellationToken cancellationToken) =>
            AnalyzeContentAsync(participant, audioInput, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="audioInput">
        /// The natural language speech audio to be processed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeContentResponse AnalyzeContent(ParticipantName participant, AudioInput audioInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContent(new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
                AudioInput = audioInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="audioInput">
        /// The natural language speech audio to be processed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(ParticipantName participant, AudioInput audioInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContentAsync(new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
                AudioInput = audioInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="audioInput">
        /// The natural language speech audio to be processed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(ParticipantName participant, AudioInput audioInput, st::CancellationToken cancellationToken) =>
            AnalyzeContentAsync(participant, audioInput, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="eventInput">
        /// An input event to send to Dialogflow.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeContentResponse AnalyzeContent(string participant, EventInput eventInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContent(new AnalyzeContentRequest
            {
                Participant = gax::GaxPreconditions.CheckNotNullOrEmpty(participant, nameof(participant)),
                EventInput = eventInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="eventInput">
        /// An input event to send to Dialogflow.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(string participant, EventInput eventInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContentAsync(new AnalyzeContentRequest
            {
                Participant = gax::GaxPreconditions.CheckNotNullOrEmpty(participant, nameof(participant)),
                EventInput = eventInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="eventInput">
        /// An input event to send to Dialogflow.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(string participant, EventInput eventInput, st::CancellationToken cancellationToken) =>
            AnalyzeContentAsync(participant, eventInput, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="eventInput">
        /// An input event to send to Dialogflow.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeContentResponse AnalyzeContent(ParticipantName participant, EventInput eventInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContent(new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
                EventInput = eventInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="eventInput">
        /// An input event to send to Dialogflow.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(ParticipantName participant, EventInput eventInput, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeContentAsync(new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = gax::GaxPreconditions.CheckNotNull(participant, nameof(participant)),
                EventInput = eventInput,
            }, callSettings);

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="participant">
        /// Required. The name of the participant this text comes from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="eventInput">
        /// An input event to send to Dialogflow.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(ParticipantName participant, EventInput eventInput, st::CancellationToken cancellationToken) =>
            AnalyzeContentAsync(participant, eventInput, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamingAnalyzeContent(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamingAnalyzeContentStream : gaxgrpc::BidirectionalStreamingBase<StreamingAnalyzeContentRequest, StreamingAnalyzeContentResponse>
        {
        }

        /// <summary>
        /// Adds a text (e.g., chat) or audio (e.g., phone recording) message from a
        /// participant into the conversation.
        /// Note: This method is only available through the gRPC API (not REST).
        /// 
        /// The top-level message sent to the client by the server is
        /// `StreamingAnalyzeContentResponse`. Multiple response messages can be
        /// returned in order. The first one or more messages contain the
        /// `recognition_result` field. Each result represents a more complete
        /// transcript of what the user said. The next message contains the
        /// `reply_text` field, and potentially the `reply_audio` and/or the
        /// `automated_agent_reply` fields.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamingAnalyzeContentStream StreamingAnalyzeContent(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestArticlesResponse SuggestArticles(SuggestArticlesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestArticlesResponse> SuggestArticlesAsync(SuggestArticlesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestArticlesResponse> SuggestArticlesAsync(SuggestArticlesRequest request, st::CancellationToken cancellationToken) =>
            SuggestArticlesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestArticlesResponse SuggestArticles(string parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestArticles(new SuggestArticlesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestArticlesResponse> SuggestArticlesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestArticlesAsync(new SuggestArticlesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestArticlesResponse> SuggestArticlesAsync(string parent, st::CancellationToken cancellationToken) =>
            SuggestArticlesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestArticlesResponse SuggestArticles(ParticipantName parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestArticles(new SuggestArticlesRequest
            {
                ParentAsParticipantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestArticlesResponse> SuggestArticlesAsync(ParticipantName parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestArticlesAsync(new SuggestArticlesRequest
            {
                ParentAsParticipantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestArticlesResponse> SuggestArticlesAsync(ParticipantName parent, st::CancellationToken cancellationToken) =>
            SuggestArticlesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestFaqAnswersResponse SuggestFaqAnswers(SuggestFaqAnswersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestFaqAnswersResponse> SuggestFaqAnswersAsync(SuggestFaqAnswersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestFaqAnswersResponse> SuggestFaqAnswersAsync(SuggestFaqAnswersRequest request, st::CancellationToken cancellationToken) =>
            SuggestFaqAnswersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestFaqAnswersResponse SuggestFaqAnswers(string parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestFaqAnswers(new SuggestFaqAnswersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestFaqAnswersResponse> SuggestFaqAnswersAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestFaqAnswersAsync(new SuggestFaqAnswersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestFaqAnswersResponse> SuggestFaqAnswersAsync(string parent, st::CancellationToken cancellationToken) =>
            SuggestFaqAnswersAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestFaqAnswersResponse SuggestFaqAnswers(ParticipantName parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestFaqAnswers(new SuggestFaqAnswersRequest
            {
                ParentAsParticipantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestFaqAnswersResponse> SuggestFaqAnswersAsync(ParticipantName parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestFaqAnswersAsync(new SuggestFaqAnswersRequest
            {
                ParentAsParticipantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestFaqAnswersResponse> SuggestFaqAnswersAsync(ParticipantName parent, st::CancellationToken cancellationToken) =>
            SuggestFaqAnswersAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets smart replies for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestSmartRepliesResponse SuggestSmartReplies(SuggestSmartRepliesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets smart replies for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestSmartRepliesResponse> SuggestSmartRepliesAsync(SuggestSmartRepliesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets smart replies for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestSmartRepliesResponse> SuggestSmartRepliesAsync(SuggestSmartRepliesRequest request, st::CancellationToken cancellationToken) =>
            SuggestSmartRepliesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets smart replies for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestSmartRepliesResponse SuggestSmartReplies(string parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestSmartReplies(new SuggestSmartRepliesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets smart replies for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestSmartRepliesResponse> SuggestSmartRepliesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestSmartRepliesAsync(new SuggestSmartRepliesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets smart replies for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestSmartRepliesResponse> SuggestSmartRepliesAsync(string parent, st::CancellationToken cancellationToken) =>
            SuggestSmartRepliesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets smart replies for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestSmartRepliesResponse SuggestSmartReplies(ParticipantName parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestSmartReplies(new SuggestSmartRepliesRequest
            {
                ParentAsParticipantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets smart replies for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestSmartRepliesResponse> SuggestSmartRepliesAsync(ParticipantName parent, gaxgrpc::CallSettings callSettings = null) =>
            SuggestSmartRepliesAsync(new SuggestSmartRepliesRequest
            {
                ParentAsParticipantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Gets smart replies for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the participant to fetch suggestion for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversations/&lt;Conversation ID&gt;/participants/&lt;Participant ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestSmartRepliesResponse> SuggestSmartRepliesAsync(ParticipantName parent, st::CancellationToken cancellationToken) =>
            SuggestSmartRepliesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Use inline suggestion, event based suggestion or
        /// Suggestion* API instead.
        /// See
        /// [HumanAgentAssistantConfig.name][google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.name]
        /// for more details. Removal Date: 2020-09-01.
        /// 
        /// Retrieves suggestions for live agents.
        /// 
        /// This method should be used by human agent client software to fetch auto
        /// generated suggestions in real-time, while the conversation with an end user
        /// is in progress. The functionality is implemented in terms of the
        /// [list
        /// pagination](https://cloud.google.com/apis/design/design_patterns#list_pagination)
        /// design pattern. The client app should use the `next_page_token` field
        /// to fetch the next batch of suggestions. `suggestions` are sorted by
        /// `create_time` in descending order.
        /// To fetch latest suggestion, just set `page_size` to 1.
        /// To fetch new suggestions without duplication, send request with filter
        /// `create_time_epoch_microseconds &gt; [first item's create_time of previous
        /// request]` and empty page_token.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Suggestion"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedEnumerable<ListSuggestionsResponse, Suggestion> ListSuggestions(ListSuggestionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Use inline suggestion, event based suggestion or
        /// Suggestion* API instead.
        /// See
        /// [HumanAgentAssistantConfig.name][google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.name]
        /// for more details. Removal Date: 2020-09-01.
        /// 
        /// Retrieves suggestions for live agents.
        /// 
        /// This method should be used by human agent client software to fetch auto
        /// generated suggestions in real-time, while the conversation with an end user
        /// is in progress. The functionality is implemented in terms of the
        /// [list
        /// pagination](https://cloud.google.com/apis/design/design_patterns#list_pagination)
        /// design pattern. The client app should use the `next_page_token` field
        /// to fetch the next batch of suggestions. `suggestions` are sorted by
        /// `create_time` in descending order.
        /// To fetch latest suggestion, just set `page_size` to 1.
        /// To fetch new suggestions without duplication, send request with filter
        /// `create_time_epoch_microseconds &gt; [first item's create_time of previous
        /// request]` and empty page_token.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Suggestion"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedAsyncEnumerable<ListSuggestionsResponse, Suggestion> ListSuggestionsAsync(ListSuggestionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated. use
        /// [SuggestArticles][google.cloud.dialogflow.v2beta1.Participants.SuggestArticles]
        /// and
        /// [SuggestFaqAnswers][google.cloud.dialogflow.v2beta1.Participants.SuggestFaqAnswers]
        /// instead.
        /// 
        /// Gets suggestions for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual CompileSuggestionResponse CompileSuggestion(CompileSuggestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated. use
        /// [SuggestArticles][google.cloud.dialogflow.v2beta1.Participants.SuggestArticles]
        /// and
        /// [SuggestFaqAnswers][google.cloud.dialogflow.v2beta1.Participants.SuggestFaqAnswers]
        /// instead.
        /// 
        /// Gets suggestions for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<CompileSuggestionResponse> CompileSuggestionAsync(CompileSuggestionRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated. use
        /// [SuggestArticles][google.cloud.dialogflow.v2beta1.Participants.SuggestArticles]
        /// and
        /// [SuggestFaqAnswers][google.cloud.dialogflow.v2beta1.Participants.SuggestFaqAnswers]
        /// instead.
        /// 
        /// Gets suggestions for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<CompileSuggestionResponse> CompileSuggestionAsync(CompileSuggestionRequest request, st::CancellationToken cancellationToken) =>
#pragma warning restore CS0612
            CompileSuggestionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Participants client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [Participants][google.cloud.dialogflow.v2beta1.Participant].
    /// </remarks>
    public sealed partial class ParticipantsClientImpl : ParticipantsClient
    {
        private readonly gaxgrpc::ApiCall<CreateParticipantRequest, Participant> _callCreateParticipant;

        private readonly gaxgrpc::ApiCall<GetParticipantRequest, Participant> _callGetParticipant;

        private readonly gaxgrpc::ApiCall<ListParticipantsRequest, ListParticipantsResponse> _callListParticipants;

        private readonly gaxgrpc::ApiCall<UpdateParticipantRequest, Participant> _callUpdateParticipant;

        private readonly gaxgrpc::ApiCall<AnalyzeContentRequest, AnalyzeContentResponse> _callAnalyzeContent;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingAnalyzeContentRequest, StreamingAnalyzeContentResponse> _callStreamingAnalyzeContent;

        private readonly gaxgrpc::ApiCall<SuggestArticlesRequest, SuggestArticlesResponse> _callSuggestArticles;

        private readonly gaxgrpc::ApiCall<SuggestFaqAnswersRequest, SuggestFaqAnswersResponse> _callSuggestFaqAnswers;

        private readonly gaxgrpc::ApiCall<SuggestSmartRepliesRequest, SuggestSmartRepliesResponse> _callSuggestSmartReplies;

#pragma warning disable CS0612
        private readonly gaxgrpc::ApiCall<ListSuggestionsRequest, ListSuggestionsResponse> _callListSuggestions;

        private readonly gaxgrpc::ApiCall<CompileSuggestionRequest, CompileSuggestionResponse> _callCompileSuggestion;
#pragma warning restore CS0612

        /// <summary>
        /// Constructs a client wrapper for the Participants service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ParticipantsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ParticipantsClientImpl(Participants.ParticipantsClient grpcClient, ParticipantsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ParticipantsSettings effectiveSettings = settings ?? ParticipantsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateParticipant = clientHelper.BuildApiCall<CreateParticipantRequest, Participant>("CreateParticipant", grpcClient.CreateParticipantAsync, grpcClient.CreateParticipant, effectiveSettings.CreateParticipantSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateParticipant);
            Modify_CreateParticipantApiCall(ref _callCreateParticipant);
            _callGetParticipant = clientHelper.BuildApiCall<GetParticipantRequest, Participant>("GetParticipant", grpcClient.GetParticipantAsync, grpcClient.GetParticipant, effectiveSettings.GetParticipantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetParticipant);
            Modify_GetParticipantApiCall(ref _callGetParticipant);
            _callListParticipants = clientHelper.BuildApiCall<ListParticipantsRequest, ListParticipantsResponse>("ListParticipants", grpcClient.ListParticipantsAsync, grpcClient.ListParticipants, effectiveSettings.ListParticipantsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListParticipants);
            Modify_ListParticipantsApiCall(ref _callListParticipants);
            _callUpdateParticipant = clientHelper.BuildApiCall<UpdateParticipantRequest, Participant>("UpdateParticipant", grpcClient.UpdateParticipantAsync, grpcClient.UpdateParticipant, effectiveSettings.UpdateParticipantSettings).WithGoogleRequestParam("participant.name", request => request.Participant?.Name);
            Modify_ApiCall(ref _callUpdateParticipant);
            Modify_UpdateParticipantApiCall(ref _callUpdateParticipant);
            _callAnalyzeContent = clientHelper.BuildApiCall<AnalyzeContentRequest, AnalyzeContentResponse>("AnalyzeContent", grpcClient.AnalyzeContentAsync, grpcClient.AnalyzeContent, effectiveSettings.AnalyzeContentSettings).WithGoogleRequestParam("participant", request => request.Participant);
            Modify_ApiCall(ref _callAnalyzeContent);
            Modify_AnalyzeContentApiCall(ref _callAnalyzeContent);
            _callStreamingAnalyzeContent = clientHelper.BuildApiCall<StreamingAnalyzeContentRequest, StreamingAnalyzeContentResponse>("StreamingAnalyzeContent", grpcClient.StreamingAnalyzeContent, effectiveSettings.StreamingAnalyzeContentSettings, effectiveSettings.StreamingAnalyzeContentStreamingSettings);
            Modify_ApiCall(ref _callStreamingAnalyzeContent);
            Modify_StreamingAnalyzeContentApiCall(ref _callStreamingAnalyzeContent);
            _callSuggestArticles = clientHelper.BuildApiCall<SuggestArticlesRequest, SuggestArticlesResponse>("SuggestArticles", grpcClient.SuggestArticlesAsync, grpcClient.SuggestArticles, effectiveSettings.SuggestArticlesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSuggestArticles);
            Modify_SuggestArticlesApiCall(ref _callSuggestArticles);
            _callSuggestFaqAnswers = clientHelper.BuildApiCall<SuggestFaqAnswersRequest, SuggestFaqAnswersResponse>("SuggestFaqAnswers", grpcClient.SuggestFaqAnswersAsync, grpcClient.SuggestFaqAnswers, effectiveSettings.SuggestFaqAnswersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSuggestFaqAnswers);
            Modify_SuggestFaqAnswersApiCall(ref _callSuggestFaqAnswers);
            _callSuggestSmartReplies = clientHelper.BuildApiCall<SuggestSmartRepliesRequest, SuggestSmartRepliesResponse>("SuggestSmartReplies", grpcClient.SuggestSmartRepliesAsync, grpcClient.SuggestSmartReplies, effectiveSettings.SuggestSmartRepliesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSuggestSmartReplies);
            Modify_SuggestSmartRepliesApiCall(ref _callSuggestSmartReplies);
#pragma warning disable CS0612
            _callListSuggestions = clientHelper.BuildApiCall<ListSuggestionsRequest, ListSuggestionsResponse>("ListSuggestions", grpcClient.ListSuggestionsAsync, grpcClient.ListSuggestions, effectiveSettings.ListSuggestionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callListSuggestions);
            Modify_ListSuggestionsApiCall(ref _callListSuggestions);
#pragma warning disable CS0612
            _callCompileSuggestion = clientHelper.BuildApiCall<CompileSuggestionRequest, CompileSuggestionResponse>("CompileSuggestion", grpcClient.CompileSuggestionAsync, grpcClient.CompileSuggestion, effectiveSettings.CompileSuggestionSettings).WithGoogleRequestParam("parent", request => request.Parent);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callCompileSuggestion);
            Modify_CompileSuggestionApiCall(ref _callCompileSuggestion);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateParticipantApiCall(ref gaxgrpc::ApiCall<CreateParticipantRequest, Participant> call);

        partial void Modify_GetParticipantApiCall(ref gaxgrpc::ApiCall<GetParticipantRequest, Participant> call);

        partial void Modify_ListParticipantsApiCall(ref gaxgrpc::ApiCall<ListParticipantsRequest, ListParticipantsResponse> call);

        partial void Modify_UpdateParticipantApiCall(ref gaxgrpc::ApiCall<UpdateParticipantRequest, Participant> call);

        partial void Modify_AnalyzeContentApiCall(ref gaxgrpc::ApiCall<AnalyzeContentRequest, AnalyzeContentResponse> call);

        partial void Modify_StreamingAnalyzeContentApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingAnalyzeContentRequest, StreamingAnalyzeContentResponse> call);

        partial void Modify_SuggestArticlesApiCall(ref gaxgrpc::ApiCall<SuggestArticlesRequest, SuggestArticlesResponse> call);

        partial void Modify_SuggestFaqAnswersApiCall(ref gaxgrpc::ApiCall<SuggestFaqAnswersRequest, SuggestFaqAnswersResponse> call);

        partial void Modify_SuggestSmartRepliesApiCall(ref gaxgrpc::ApiCall<SuggestSmartRepliesRequest, SuggestSmartRepliesResponse> call);

#pragma warning disable CS0612
        partial void Modify_ListSuggestionsApiCall(ref gaxgrpc::ApiCall<ListSuggestionsRequest, ListSuggestionsResponse> call);

        partial void Modify_CompileSuggestionApiCall(ref gaxgrpc::ApiCall<CompileSuggestionRequest, CompileSuggestionResponse> call);
#pragma warning restore CS0612

        partial void OnConstruction(Participants.ParticipantsClient grpcClient, ParticipantsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Participants client</summary>
        public override Participants.ParticipantsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateParticipantRequest(ref CreateParticipantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetParticipantRequest(ref GetParticipantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListParticipantsRequest(ref ListParticipantsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateParticipantRequest(ref UpdateParticipantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AnalyzeContentRequest(ref AnalyzeContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingAnalyzeContentRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingAnalyzeContentRequestRequest(ref StreamingAnalyzeContentRequest request);

        partial void Modify_SuggestArticlesRequest(ref SuggestArticlesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SuggestFaqAnswersRequest(ref SuggestFaqAnswersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SuggestSmartRepliesRequest(ref SuggestSmartRepliesRequest request, ref gaxgrpc::CallSettings settings);

#pragma warning disable CS0612
        partial void Modify_ListSuggestionsRequest(ref ListSuggestionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CompileSuggestionRequest(ref CompileSuggestionRequest request, ref gaxgrpc::CallSettings settings);
#pragma warning restore CS0612

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Participant CreateParticipant(CreateParticipantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateParticipantRequest(ref request, ref callSettings);
            return _callCreateParticipant.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new participant in a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Participant> CreateParticipantAsync(CreateParticipantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateParticipantRequest(ref request, ref callSettings);
            return _callCreateParticipant.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Participant GetParticipant(GetParticipantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetParticipantRequest(ref request, ref callSettings);
            return _callGetParticipant.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a conversation participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Participant> GetParticipantAsync(GetParticipantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetParticipantRequest(ref request, ref callSettings);
            return _callGetParticipant.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Participant"/> resources.</returns>
        public override gax::PagedEnumerable<ListParticipantsResponse, Participant> ListParticipants(ListParticipantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListParticipantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListParticipantsRequest, ListParticipantsResponse, Participant>(_callListParticipants, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all participants in the specified conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Participant"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListParticipantsResponse, Participant> ListParticipantsAsync(ListParticipantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListParticipantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListParticipantsRequest, ListParticipantsResponse, Participant>(_callListParticipants, request, callSettings);
        }

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Participant UpdateParticipant(UpdateParticipantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateParticipantRequest(ref request, ref callSettings);
            return _callUpdateParticipant.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified participant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Participant> UpdateParticipantAsync(UpdateParticipantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateParticipantRequest(ref request, ref callSettings);
            return _callUpdateParticipant.Async(request, callSettings);
        }

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyzeContentResponse AnalyzeContent(AnalyzeContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeContentRequest(ref request, ref callSettings);
            return _callAnalyzeContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a text (chat, for example), or audio (phone recording, for example)
        /// message from a participant into the conversation.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalyzeContentResponse> AnalyzeContentAsync(AnalyzeContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeContentRequest(ref request, ref callSettings);
            return _callAnalyzeContent.Async(request, callSettings);
        }

        internal sealed partial class StreamingAnalyzeContentStreamImpl : StreamingAnalyzeContentStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamingAnalyzeContent</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamingAnalyzeContentRequest}"/> instance
            /// associated with this streaming call.
            /// </param>
            public StreamingAnalyzeContentStreamImpl(ParticipantsClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamingAnalyzeContentRequest, StreamingAnalyzeContentResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamingAnalyzeContentRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private ParticipantsClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamingAnalyzeContentRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamingAnalyzeContentRequest, StreamingAnalyzeContentResponse> GrpcCall { get; }

            private StreamingAnalyzeContentRequest ModifyRequest(StreamingAnalyzeContentRequest request)
            {
                _service.Modify_StreamingAnalyzeContentRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamingAnalyzeContentRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamingAnalyzeContentRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamingAnalyzeContentRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamingAnalyzeContentRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Adds a text (e.g., chat) or audio (e.g., phone recording) message from a
        /// participant into the conversation.
        /// Note: This method is only available through the gRPC API (not REST).
        /// 
        /// The top-level message sent to the client by the server is
        /// `StreamingAnalyzeContentResponse`. Multiple response messages can be
        /// returned in order. The first one or more messages contain the
        /// `recognition_result` field. Each result represents a more complete
        /// transcript of what the user said. The next message contains the
        /// `reply_text` field, and potentially the `reply_audio` and/or the
        /// `automated_agent_reply` fields.
        /// 
        /// Note: Always use agent versions for production traffic
        /// sent to virtual agents. See [Versions and
        /// environments](https://cloud.google.com/dialogflow/es/docs/agents-versions).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override ParticipantsClient.StreamingAnalyzeContentStream StreamingAnalyzeContent(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingAnalyzeContentRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamingAnalyzeContent.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamingAnalyzeContentRequest, StreamingAnalyzeContentResponse> call = _callStreamingAnalyzeContent.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamingAnalyzeContentRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamingAnalyzeContentRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingAnalyzeContentStreamImpl(this, call, writeBuffer);
        }

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SuggestArticlesResponse SuggestArticles(SuggestArticlesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestArticlesRequest(ref request, ref callSettings);
            return _callSuggestArticles.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets suggested articles for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SuggestArticlesResponse> SuggestArticlesAsync(SuggestArticlesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestArticlesRequest(ref request, ref callSettings);
            return _callSuggestArticles.Async(request, callSettings);
        }

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SuggestFaqAnswersResponse SuggestFaqAnswers(SuggestFaqAnswersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestFaqAnswersRequest(ref request, ref callSettings);
            return _callSuggestFaqAnswers.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets suggested faq answers for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SuggestFaqAnswersResponse> SuggestFaqAnswersAsync(SuggestFaqAnswersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestFaqAnswersRequest(ref request, ref callSettings);
            return _callSuggestFaqAnswers.Async(request, callSettings);
        }

        /// <summary>
        /// Gets smart replies for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SuggestSmartRepliesResponse SuggestSmartReplies(SuggestSmartRepliesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestSmartRepliesRequest(ref request, ref callSettings);
            return _callSuggestSmartReplies.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets smart replies for a participant based on specific historical
        /// messages.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SuggestSmartRepliesResponse> SuggestSmartRepliesAsync(SuggestSmartRepliesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestSmartRepliesRequest(ref request, ref callSettings);
            return _callSuggestSmartReplies.Async(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Use inline suggestion, event based suggestion or
        /// Suggestion* API instead.
        /// See
        /// [HumanAgentAssistantConfig.name][google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.name]
        /// for more details. Removal Date: 2020-09-01.
        /// 
        /// Retrieves suggestions for live agents.
        /// 
        /// This method should be used by human agent client software to fetch auto
        /// generated suggestions in real-time, while the conversation with an end user
        /// is in progress. The functionality is implemented in terms of the
        /// [list
        /// pagination](https://cloud.google.com/apis/design/design_patterns#list_pagination)
        /// design pattern. The client app should use the `next_page_token` field
        /// to fetch the next batch of suggestions. `suggestions` are sorted by
        /// `create_time` in descending order.
        /// To fetch latest suggestion, just set `page_size` to 1.
        /// To fetch new suggestions without duplication, send request with filter
        /// `create_time_epoch_microseconds &gt; [first item's create_time of previous
        /// request]` and empty page_token.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Suggestion"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override gax::PagedEnumerable<ListSuggestionsResponse, Suggestion> ListSuggestions(ListSuggestionsRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_ListSuggestionsRequest(ref request, ref callSettings);
#pragma warning disable CS0612
            return new gaxgrpc::GrpcPagedEnumerable<ListSuggestionsRequest, ListSuggestionsResponse, Suggestion>(_callListSuggestions, request, callSettings);
#pragma warning restore CS0612
        }

        /// <summary>
        /// Deprecated: Use inline suggestion, event based suggestion or
        /// Suggestion* API instead.
        /// See
        /// [HumanAgentAssistantConfig.name][google.cloud.dialogflow.v2beta1.HumanAgentAssistantConfig.name]
        /// for more details. Removal Date: 2020-09-01.
        /// 
        /// Retrieves suggestions for live agents.
        /// 
        /// This method should be used by human agent client software to fetch auto
        /// generated suggestions in real-time, while the conversation with an end user
        /// is in progress. The functionality is implemented in terms of the
        /// [list
        /// pagination](https://cloud.google.com/apis/design/design_patterns#list_pagination)
        /// design pattern. The client app should use the `next_page_token` field
        /// to fetch the next batch of suggestions. `suggestions` are sorted by
        /// `create_time` in descending order.
        /// To fetch latest suggestion, just set `page_size` to 1.
        /// To fetch new suggestions without duplication, send request with filter
        /// `create_time_epoch_microseconds &gt; [first item's create_time of previous
        /// request]` and empty page_token.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Suggestion"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override gax::PagedAsyncEnumerable<ListSuggestionsResponse, Suggestion> ListSuggestionsAsync(ListSuggestionsRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_ListSuggestionsRequest(ref request, ref callSettings);
#pragma warning disable CS0612
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSuggestionsRequest, ListSuggestionsResponse, Suggestion>(_callListSuggestions, request, callSettings);
#pragma warning restore CS0612
        }

        /// <summary>
        /// Deprecated. use
        /// [SuggestArticles][google.cloud.dialogflow.v2beta1.Participants.SuggestArticles]
        /// and
        /// [SuggestFaqAnswers][google.cloud.dialogflow.v2beta1.Participants.SuggestFaqAnswers]
        /// instead.
        /// 
        /// Gets suggestions for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override CompileSuggestionResponse CompileSuggestion(CompileSuggestionRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_CompileSuggestionRequest(ref request, ref callSettings);
            return _callCompileSuggestion.Sync(request, callSettings);
        }

        /// <summary>
        /// Deprecated. use
        /// [SuggestArticles][google.cloud.dialogflow.v2beta1.Participants.SuggestArticles]
        /// and
        /// [SuggestFaqAnswers][google.cloud.dialogflow.v2beta1.Participants.SuggestFaqAnswers]
        /// instead.
        /// 
        /// Gets suggestions for a participant based on specific historical
        /// messages.
        /// 
        /// Note that
        /// [ListSuggestions][google.cloud.dialogflow.v2beta1.Participants.ListSuggestions]
        /// will only list the auto-generated suggestions, while
        /// [CompileSuggestion][google.cloud.dialogflow.v2beta1.Participants.CompileSuggestion]
        /// will try to compile suggestion based on the provided conversation context
        /// in the real time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override stt::Task<CompileSuggestionResponse> CompileSuggestionAsync(CompileSuggestionRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_CompileSuggestionRequest(ref request, ref callSettings);
            return _callCompileSuggestion.Async(request, callSettings);
        }
    }

    public partial class ListParticipantsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSuggestionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListParticipantsResponse : gaxgrpc::IPageResponse<Participant>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Participant> GetEnumerator() => Participants.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

#pragma warning disable CS0612
    public partial class ListSuggestionsResponse : gaxgrpc::IPageResponse<Suggestion>
#pragma warning restore CS0612
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
#pragma warning disable CS0612
        public scg::IEnumerator<Suggestion> GetEnumerator() => Suggestions.GetEnumerator();
#pragma warning restore CS0612

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Participants
    {
        public partial class ParticipantsClient
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
