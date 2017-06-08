// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Language.V1
{
    /// <summary>
    /// Settings for a <see cref="LanguageServiceClient"/>.
    /// </summary>
    public sealed partial class LanguageServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="LanguageServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="LanguageServiceSettings"/>.
        /// </returns>
        public static LanguageServiceSettings GetDefault() => new LanguageServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="LanguageServiceSettings"/> object with default settings.
        /// </summary>
        public LanguageServiceSettings() { }

        private LanguageServiceSettings(LanguageServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AnalyzeSentimentSettings = existing.AnalyzeSentimentSettings;
            AnalyzeEntitiesSettings = existing.AnalyzeEntitiesSettings;
            AnalyzeEntitySentimentSettings = existing.AnalyzeEntitySentimentSettings;
            AnalyzeSyntaxSettings = existing.AnalyzeSyntaxSettings;
            AnnotateTextSettings = existing.AnnotateTextSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LanguageServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="LanguageServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="LanguageServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="LanguageServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="LanguageServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="LanguageServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="LanguageServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="LanguageServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="LanguageServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(60000),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.AnalyzeSentiment</c> and <c>LanguageServiceClient.AnalyzeSentimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LanguageServiceClient.AnalyzeSentiment</c> and
        /// <c>LanguageServiceClient.AnalyzeSentimentAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings AnalyzeSentimentSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.AnalyzeEntities</c> and <c>LanguageServiceClient.AnalyzeEntitiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LanguageServiceClient.AnalyzeEntities</c> and
        /// <c>LanguageServiceClient.AnalyzeEntitiesAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings AnalyzeEntitiesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.AnalyzeEntitySentiment</c> and <c>LanguageServiceClient.AnalyzeEntitySentimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LanguageServiceClient.AnalyzeEntitySentiment</c> and
        /// <c>LanguageServiceClient.AnalyzeEntitySentimentAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings AnalyzeEntitySentimentSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.AnalyzeSyntax</c> and <c>LanguageServiceClient.AnalyzeSyntaxAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LanguageServiceClient.AnalyzeSyntax</c> and
        /// <c>LanguageServiceClient.AnalyzeSyntaxAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings AnalyzeSyntaxSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.AnnotateText</c> and <c>LanguageServiceClient.AnnotateTextAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LanguageServiceClient.AnnotateText</c> and
        /// <c>LanguageServiceClient.AnnotateTextAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings AnnotateTextSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="LanguageServiceSettings"/> object.</returns>
        public LanguageServiceSettings Clone() => new LanguageServiceSettings(this);
    }

    /// <summary>
    /// LanguageService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class LanguageServiceClient
    {
        /// <summary>
        /// The default endpoint for the LanguageService service, which is a host of "language.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("language.googleapis.com", 443);

        /// <summary>
        /// The default LanguageService scopes.
        /// </summary>
        /// <remarks>
        /// The default LanguageService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="LanguageServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="LanguageServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="LanguageServiceClient"/>.</returns>
        public static async Task<LanguageServiceClient> CreateAsync(ServiceEndpoint endpoint = null, LanguageServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="LanguageServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="LanguageServiceSettings"/>.</param>
        /// <returns>The created <see cref="LanguageServiceClient"/>.</returns>
        public static LanguageServiceClient Create(ServiceEndpoint endpoint = null, LanguageServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="LanguageServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="LanguageServiceSettings"/>.</param>
        /// <returns>The created <see cref="LanguageServiceClient"/>.</returns>
        public static LanguageServiceClient Create(Channel channel, LanguageServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            LanguageService.LanguageServiceClient grpcClient = new LanguageService.LanguageServiceClient(channel);
            return new LanguageServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, LanguageServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, LanguageServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, LanguageServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, LanguageServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC LanguageService client.
        /// </summary>
        public virtual LanguageService.LanguageServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(
            Document document,
            CallSettings callSettings = null) => AnalyzeSentimentAsync(
                new AnalyzeSentimentRequest
                {
                    Document = GaxPreconditions.CheckNotNull(document, nameof(document)),
                },
                callSettings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(
            Document document,
            CancellationToken cancellationToken) => AnalyzeSentimentAsync(
                document,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AnalyzeSentimentResponse AnalyzeSentiment(
            Document document,
            CallSettings callSettings = null) => AnalyzeSentiment(
                new AnalyzeSentimentRequest
                {
                    Document = GaxPreconditions.CheckNotNull(document, nameof(document)),
                },
                callSettings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(
            AnalyzeSentimentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AnalyzeSentimentResponse AnalyzeSentiment(
            AnalyzeSentimentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(
            Document document,
            EncodingType encodingType,
            CallSettings callSettings = null) => AnalyzeEntitiesAsync(
                new AnalyzeEntitiesRequest
                {
                    Document = GaxPreconditions.CheckNotNull(document, nameof(document)),
                    EncodingType = encodingType,
                },
                callSettings);

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(
            Document document,
            EncodingType encodingType,
            CancellationToken cancellationToken) => AnalyzeEntitiesAsync(
                document,
                encodingType,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AnalyzeEntitiesResponse AnalyzeEntities(
            Document document,
            EncodingType encodingType,
            CallSettings callSettings = null) => AnalyzeEntities(
                new AnalyzeEntitiesRequest
                {
                    Document = GaxPreconditions.CheckNotNull(document, nameof(document)),
                    EncodingType = encodingType,
                },
                callSettings);

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(
            AnalyzeEntitiesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AnalyzeEntitiesResponse AnalyzeEntities(
            AnalyzeEntitiesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1beta2.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnalyzeEntitySentimentResponse> AnalyzeEntitySentimentAsync(
            Document document,
            EncodingType encodingType,
            CallSettings callSettings = null) => AnalyzeEntitySentimentAsync(
                new AnalyzeEntitySentimentRequest
                {
                    Document = GaxPreconditions.CheckNotNull(document, nameof(document)),
                    EncodingType = encodingType,
                },
                callSettings);

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1beta2.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnalyzeEntitySentimentResponse> AnalyzeEntitySentimentAsync(
            Document document,
            EncodingType encodingType,
            CancellationToken cancellationToken) => AnalyzeEntitySentimentAsync(
                document,
                encodingType,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1beta2.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AnalyzeEntitySentimentResponse AnalyzeEntitySentiment(
            Document document,
            EncodingType encodingType,
            CallSettings callSettings = null) => AnalyzeEntitySentiment(
                new AnalyzeEntitySentimentRequest
                {
                    Document = GaxPreconditions.CheckNotNull(document, nameof(document)),
                    EncodingType = encodingType,
                },
                callSettings);

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1beta2.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnalyzeEntitySentimentResponse> AnalyzeEntitySentimentAsync(
            AnalyzeEntitySentimentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1beta2.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AnalyzeEntitySentimentResponse AnalyzeEntitySentiment(
            AnalyzeEntitySentimentRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(
            Document document,
            EncodingType encodingType,
            CallSettings callSettings = null) => AnalyzeSyntaxAsync(
                new AnalyzeSyntaxRequest
                {
                    Document = GaxPreconditions.CheckNotNull(document, nameof(document)),
                    EncodingType = encodingType,
                },
                callSettings);

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(
            Document document,
            EncodingType encodingType,
            CancellationToken cancellationToken) => AnalyzeSyntaxAsync(
                document,
                encodingType,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AnalyzeSyntaxResponse AnalyzeSyntax(
            Document document,
            EncodingType encodingType,
            CallSettings callSettings = null) => AnalyzeSyntax(
                new AnalyzeSyntaxRequest
                {
                    Document = GaxPreconditions.CheckNotNull(document, nameof(document)),
                    EncodingType = encodingType,
                },
                callSettings);

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(
            AnalyzeSyntaxRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AnalyzeSyntaxResponse AnalyzeSyntax(
            AnalyzeSyntaxRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// A convenience method that provides all syntax, sentiment, and entity
        /// features in one call.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="features">
        /// The enabled features.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnnotateTextResponse> AnnotateTextAsync(
            Document document,
            AnnotateTextRequest.Types.Features features,
            EncodingType encodingType,
            CallSettings callSettings = null) => AnnotateTextAsync(
                new AnnotateTextRequest
                {
                    Document = GaxPreconditions.CheckNotNull(document, nameof(document)),
                    Features = GaxPreconditions.CheckNotNull(features, nameof(features)),
                    EncodingType = encodingType,
                },
                callSettings);

        /// <summary>
        /// A convenience method that provides all syntax, sentiment, and entity
        /// features in one call.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="features">
        /// The enabled features.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnnotateTextResponse> AnnotateTextAsync(
            Document document,
            AnnotateTextRequest.Types.Features features,
            EncodingType encodingType,
            CancellationToken cancellationToken) => AnnotateTextAsync(
                document,
                features,
                encodingType,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// A convenience method that provides all syntax, sentiment, and entity
        /// features in one call.
        /// </summary>
        /// <param name="document">
        /// Input document.
        /// </param>
        /// <param name="features">
        /// The enabled features.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AnnotateTextResponse AnnotateText(
            Document document,
            AnnotateTextRequest.Types.Features features,
            EncodingType encodingType,
            CallSettings callSettings = null) => AnnotateText(
                new AnnotateTextRequest
                {
                    Document = GaxPreconditions.CheckNotNull(document, nameof(document)),
                    Features = GaxPreconditions.CheckNotNull(features, nameof(features)),
                    EncodingType = encodingType,
                },
                callSettings);

        /// <summary>
        /// A convenience method that provides all syntax, sentiment, and entity
        /// features in one call.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AnnotateTextResponse> AnnotateTextAsync(
            AnnotateTextRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// A convenience method that provides all syntax, sentiment, and entity
        /// features in one call.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AnnotateTextResponse AnnotateText(
            AnnotateTextRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// LanguageService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class LanguageServiceClientImpl : LanguageServiceClient
    {
        private readonly ApiCall<AnalyzeSentimentRequest, AnalyzeSentimentResponse> _callAnalyzeSentiment;
        private readonly ApiCall<AnalyzeEntitiesRequest, AnalyzeEntitiesResponse> _callAnalyzeEntities;
        private readonly ApiCall<AnalyzeEntitySentimentRequest, AnalyzeEntitySentimentResponse> _callAnalyzeEntitySentiment;
        private readonly ApiCall<AnalyzeSyntaxRequest, AnalyzeSyntaxResponse> _callAnalyzeSyntax;
        private readonly ApiCall<AnnotateTextRequest, AnnotateTextResponse> _callAnnotateText;

        /// <summary>
        /// Constructs a client wrapper for the LanguageService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LanguageServiceSettings"/> used within this client </param>
        public LanguageServiceClientImpl(LanguageService.LanguageServiceClient grpcClient, LanguageServiceSettings settings)
        {
            this.GrpcClient = grpcClient;
            LanguageServiceSettings effectiveSettings = settings ?? LanguageServiceSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callAnalyzeSentiment = clientHelper.BuildApiCall<AnalyzeSentimentRequest, AnalyzeSentimentResponse>(
                GrpcClient.AnalyzeSentimentAsync, GrpcClient.AnalyzeSentiment, effectiveSettings.AnalyzeSentimentSettings);
            _callAnalyzeEntities = clientHelper.BuildApiCall<AnalyzeEntitiesRequest, AnalyzeEntitiesResponse>(
                GrpcClient.AnalyzeEntitiesAsync, GrpcClient.AnalyzeEntities, effectiveSettings.AnalyzeEntitiesSettings);
            _callAnalyzeEntitySentiment = clientHelper.BuildApiCall<AnalyzeEntitySentimentRequest, AnalyzeEntitySentimentResponse>(
                GrpcClient.AnalyzeEntitySentimentAsync, GrpcClient.AnalyzeEntitySentiment, effectiveSettings.AnalyzeEntitySentimentSettings);
            _callAnalyzeSyntax = clientHelper.BuildApiCall<AnalyzeSyntaxRequest, AnalyzeSyntaxResponse>(
                GrpcClient.AnalyzeSyntaxAsync, GrpcClient.AnalyzeSyntax, effectiveSettings.AnalyzeSyntaxSettings);
            _callAnnotateText = clientHelper.BuildApiCall<AnnotateTextRequest, AnnotateTextResponse>(
                GrpcClient.AnnotateTextAsync, GrpcClient.AnnotateText, effectiveSettings.AnnotateTextSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(LanguageService.LanguageServiceClient grpcClient, LanguageServiceSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC LanguageService client.
        /// </summary>
        public override LanguageService.LanguageServiceClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_AnalyzeSentimentRequest(ref AnalyzeSentimentRequest request, ref CallSettings settings);
        partial void Modify_AnalyzeEntitiesRequest(ref AnalyzeEntitiesRequest request, ref CallSettings settings);
        partial void Modify_AnalyzeEntitySentimentRequest(ref AnalyzeEntitySentimentRequest request, ref CallSettings settings);
        partial void Modify_AnalyzeSyntaxRequest(ref AnalyzeSyntaxRequest request, ref CallSettings settings);
        partial void Modify_AnnotateTextRequest(ref AnnotateTextRequest request, ref CallSettings settings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(
            AnalyzeSentimentRequest request,
            CallSettings callSettings = null)
        {
            Modify_AnalyzeSentimentRequest(ref request, ref callSettings);
            return _callAnalyzeSentiment.Async(request, callSettings);
        }

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override AnalyzeSentimentResponse AnalyzeSentiment(
            AnalyzeSentimentRequest request,
            CallSettings callSettings = null)
        {
            Modify_AnalyzeSentimentRequest(ref request, ref callSettings);
            return _callAnalyzeSentiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(
            AnalyzeEntitiesRequest request,
            CallSettings callSettings = null)
        {
            Modify_AnalyzeEntitiesRequest(ref request, ref callSettings);
            return _callAnalyzeEntities.Async(request, callSettings);
        }

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, salience, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override AnalyzeEntitiesResponse AnalyzeEntities(
            AnalyzeEntitiesRequest request,
            CallSettings callSettings = null)
        {
            Modify_AnalyzeEntitiesRequest(ref request, ref callSettings);
            return _callAnalyzeEntities.Sync(request, callSettings);
        }

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1beta2.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<AnalyzeEntitySentimentResponse> AnalyzeEntitySentimentAsync(
            AnalyzeEntitySentimentRequest request,
            CallSettings callSettings = null)
        {
            Modify_AnalyzeEntitySentimentRequest(ref request, ref callSettings);
            return _callAnalyzeEntitySentiment.Async(request, callSettings);
        }

        /// <summary>
        /// Finds entities, similar to [AnalyzeEntities][google.cloud.language.v1beta2.LanguageService.AnalyzeEntities] in the text and analyzes
        /// sentiment associated with each entity and its mentions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override AnalyzeEntitySentimentResponse AnalyzeEntitySentiment(
            AnalyzeEntitySentimentRequest request,
            CallSettings callSettings = null)
        {
            Modify_AnalyzeEntitySentimentRequest(ref request, ref callSettings);
            return _callAnalyzeEntitySentiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<AnalyzeSyntaxResponse> AnalyzeSyntaxAsync(
            AnalyzeSyntaxRequest request,
            CallSettings callSettings = null)
        {
            Modify_AnalyzeSyntaxRequest(ref request, ref callSettings);
            return _callAnalyzeSyntax.Async(request, callSettings);
        }

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries and
        /// tokenization along with part of speech tags, dependency trees, and other
        /// properties.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override AnalyzeSyntaxResponse AnalyzeSyntax(
            AnalyzeSyntaxRequest request,
            CallSettings callSettings = null)
        {
            Modify_AnalyzeSyntaxRequest(ref request, ref callSettings);
            return _callAnalyzeSyntax.Sync(request, callSettings);
        }

        /// <summary>
        /// A convenience method that provides all syntax, sentiment, and entity
        /// features in one call.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<AnnotateTextResponse> AnnotateTextAsync(
            AnnotateTextRequest request,
            CallSettings callSettings = null)
        {
            Modify_AnnotateTextRequest(ref request, ref callSettings);
            return _callAnnotateText.Async(request, callSettings);
        }

        /// <summary>
        /// A convenience method that provides all syntax, sentiment, and entity
        /// features in one call.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override AnnotateTextResponse AnnotateText(
            AnnotateTextRequest request,
            CallSettings callSettings = null)
        {
            Modify_AnnotateTextRequest(ref request, ref callSettings);
            return _callAnnotateText.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

}
