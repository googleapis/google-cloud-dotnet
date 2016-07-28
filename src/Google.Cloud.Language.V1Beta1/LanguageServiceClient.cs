// Copyright 2016 Google Inc. All Rights Reserved.
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
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Language.V1Beta1
{

    /// <summary>
    /// Extension methods to assist with using <see cref="LanguageServiceClient"/>.
    /// </summary>
    public static partial class LanguageServiceExtensions
    {
        /// <summary>
        /// Wrap a GRPC LanguageService client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="LanguageServiceSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="LanguageServiceClient"/> that wraps the specified GRPC client.</returns>
        public static LanguageServiceClient ToClient(
            this LanguageService.LanguageServiceClient grpcClient,
            LanguageServiceSettings settings = null
        ) => new LanguageServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a LanguageService wrapper.
    /// </summary>
    public sealed partial class LanguageServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="LanguageServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default LanguageServiceSettings.</returns>
        public static LanguageServiceSettings GetDefault() => new LanguageServiceSettings();

        /// <summary>
        /// Constructs a new LanguageServiceSettings object with default settings.
        /// </summary>
        public LanguageServiceSettings() { }

        private LanguageServiceSettings(LanguageServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AnalyzeSentimentSettings = existing.AnalyzeSentimentSettings?.Clone();
            AnalyzeEntitiesSettings = existing.AnalyzeEntitiesSettings?.Clone();
            AnnotateTextSettings = existing.AnnotateTextSettings?.Clone();
        }

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
        /// <returns>The "Default" retry backoff for <see cref="LanguageServiceClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="LanguageServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(100),
            DelayMultiplier = 1.3,
            MaxDelay = TimeSpan.FromMilliseconds(60000),
        };

        /// <summary>
        /// "Default" timeout backoff for <see cref="LanguageServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="LanguageServiceClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="LanguageServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(60000),
            DelayMultiplier = 1.0,
            MaxDelay = TimeSpan.FromMilliseconds(60000),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="LanguageServiceClient.AnalyzeSentiment"/> and <see cref="LanguageServiceClient.AnalyzeSentimentAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="LanguageServiceClient.AnalyzeSentiment"/> and
        /// <see cref="LanguageServiceClient.AnalyzeSentimentAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings AnalyzeSentimentSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="LanguageServiceClient.AnalyzeEntities"/> and <see cref="LanguageServiceClient.AnalyzeEntitiesAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="LanguageServiceClient.AnalyzeEntities"/> and
        /// <see cref="LanguageServiceClient.AnalyzeEntitiesAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings AnalyzeEntitiesSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="LanguageServiceClient.AnnotateText"/> and <see cref="LanguageServiceClient.AnnotateTextAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="LanguageServiceClient.AnnotateText"/> and
        /// <see cref="LanguageServiceClient.AnnotateTextAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings AnnotateTextSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };


        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of LanguageService settings.</returns>
        public LanguageServiceSettings Clone() => new LanguageServiceSettings(this);
    }

    /// <summary>
    /// LanguageService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class LanguageServiceClient
    {
        private static readonly ChannelPool s_channelPool = new ChannelPool();

        /// <summary>
        /// The default endpoint for the LanguageService service, which is a host of "language.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("language.googleapis.com", 443);

        /// <summary>
        /// The default LanguageService scopes
        /// </summary>
        /// <remarks>
        /// The default LanguageService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

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
        /// The underlying GRPC LanguageService client.
        /// </summary>
        public virtual LanguageService.LanguageServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document. Currently, `analyzeSentiment` only supports English text
        /// ([Document.language][google.cloud.language.v1beta1.Document.language]="EN").
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(
            Document document,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document. Currently, `analyzeSentiment` only supports English text
        /// ([Document.language][google.cloud.language.v1beta1.Document.language]="EN").
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(
            Document document,
            CancellationToken cancellationToken) => AnalyzeSentimentAsync(
                document,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document. Currently, `analyzeSentiment` only supports English text
        /// ([Document.language][google.cloud.language.v1beta1.Document.language]="EN").
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeSentimentResponse AnalyzeSentiment(
            Document document,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds named entities (currently finds proper names) in the text,
        /// entity types, salience, mentions for each entity, and other properties.
        /// </summary>
        /// <param name="document">Input document.</param>
        /// <param name="encodingType">The encoding type used by the API to calculate offsets.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(
            Document document,
            EncodingType encodingType,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds named entities (currently finds proper names) in the text,
        /// entity types, salience, mentions for each entity, and other properties.
        /// </summary>
        /// <param name="document">Input document.</param>
        /// <param name="encodingType">The encoding type used by the API to calculate offsets.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(
            Document document,
            EncodingType encodingType,
            CancellationToken cancellationToken) => AnalyzeEntitiesAsync(
                document,
                encodingType,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Finds named entities (currently finds proper names) in the text,
        /// entity types, salience, mentions for each entity, and other properties.
        /// </summary>
        /// <param name="document">Input document.</param>
        /// <param name="encodingType">The encoding type used by the API to calculate offsets.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeEntitiesResponse AnalyzeEntities(
            Document document,
            EncodingType encodingType,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Advanced API that analyzes the document and provides a full set of text
        /// annotations, including semantic, syntactic, and sentiment information. This
        /// API is intended for users who are familiar with machine learning and need
        /// in-depth text features to build upon.
        /// </summary>
        /// <param name="document">Input document.</param>
        /// <param name="features">The enabled features.</param>
        /// <param name="encodingType">The encoding type used by the API to calculate offsets.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<AnnotateTextResponse> AnnotateTextAsync(
            Document document,
            AnnotateTextRequest.Types.Features features,
            EncodingType encodingType,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Advanced API that analyzes the document and provides a full set of text
        /// annotations, including semantic, syntactic, and sentiment information. This
        /// API is intended for users who are familiar with machine learning and need
        /// in-depth text features to build upon.
        /// </summary>
        /// <param name="document">Input document.</param>
        /// <param name="features">The enabled features.</param>
        /// <param name="encodingType">The encoding type used by the API to calculate offsets.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<AnnotateTextResponse> AnnotateTextAsync(
            Document document,
            AnnotateTextRequest.Types.Features features,
            EncodingType encodingType,
            CancellationToken cancellationToken) => AnnotateTextAsync(
                document,
                features,
                encodingType,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Advanced API that analyzes the document and provides a full set of text
        /// annotations, including semantic, syntactic, and sentiment information. This
        /// API is intended for users who are familiar with machine learning and need
        /// in-depth text features to build upon.
        /// </summary>
        /// <param name="document">Input document.</param>
        /// <param name="features">The enabled features.</param>
        /// <param name="encodingType">The encoding type used by the API to calculate offsets.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotateTextResponse AnnotateText(
            Document document,
            AnnotateTextRequest.Types.Features features,
            EncodingType encodingType,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class LanguageServiceClientImpl : LanguageServiceClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<AnalyzeSentimentRequest, AnalyzeSentimentResponse> _callAnalyzeSentiment;
        private readonly ApiCall<AnalyzeEntitiesRequest, AnalyzeEntitiesResponse> _callAnalyzeEntities;
        private readonly ApiCall<AnnotateTextRequest, AnnotateTextResponse> _callAnnotateText;

        public LanguageServiceClientImpl(LanguageService.LanguageServiceClient grpcClient, LanguageServiceSettings settings)
        {
            this.GrpcClient = grpcClient;
            LanguageServiceSettings effectiveSettings = settings ?? LanguageServiceSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callAnalyzeSentiment = _clientHelper.BuildApiCall<AnalyzeSentimentRequest, AnalyzeSentimentResponse>(
                GrpcClient.AnalyzeSentimentAsync, GrpcClient.AnalyzeSentiment, effectiveSettings.AnalyzeSentimentSettings);
            _callAnalyzeEntities = _clientHelper.BuildApiCall<AnalyzeEntitiesRequest, AnalyzeEntitiesResponse>(
                GrpcClient.AnalyzeEntitiesAsync, GrpcClient.AnalyzeEntities, effectiveSettings.AnalyzeEntitiesSettings);
            _callAnnotateText = _clientHelper.BuildApiCall<AnnotateTextRequest, AnnotateTextResponse>(
                GrpcClient.AnnotateTextAsync, GrpcClient.AnnotateText, effectiveSettings.AnnotateTextSettings);
        }

        public override LanguageService.LanguageServiceClient GrpcClient { get; }

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document. Currently, `analyzeSentiment` only supports English text
        /// ([Document.language][google.cloud.language.v1beta1.Document.language]="EN").
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(
            Document document,
            CallSettings callSettings = null) => _callAnalyzeSentiment.Async(
                new AnalyzeSentimentRequest
                {
                    Document = document,
                },
                callSettings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Input document. Currently, `analyzeSentiment` only supports English text
        /// ([Document.language][google.cloud.language.v1beta1.Document.language]="EN").
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyzeSentimentResponse AnalyzeSentiment(
            Document document,
            CallSettings callSettings = null) => _callAnalyzeSentiment.Sync(
                new AnalyzeSentimentRequest
                {
                    Document = document,
                },
                callSettings);

        /// <summary>
        /// Finds named entities (currently finds proper names) in the text,
        /// entity types, salience, mentions for each entity, and other properties.
        /// </summary>
        /// <param name="document">Input document.</param>
        /// <param name="encodingType">The encoding type used by the API to calculate offsets.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(
            Document document,
            EncodingType encodingType,
            CallSettings callSettings = null) => _callAnalyzeEntities.Async(
                new AnalyzeEntitiesRequest
                {
                    Document = document,
                    EncodingType = encodingType,
                },
                callSettings);

        /// <summary>
        /// Finds named entities (currently finds proper names) in the text,
        /// entity types, salience, mentions for each entity, and other properties.
        /// </summary>
        /// <param name="document">Input document.</param>
        /// <param name="encodingType">The encoding type used by the API to calculate offsets.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyzeEntitiesResponse AnalyzeEntities(
            Document document,
            EncodingType encodingType,
            CallSettings callSettings = null) => _callAnalyzeEntities.Sync(
                new AnalyzeEntitiesRequest
                {
                    Document = document,
                    EncodingType = encodingType,
                },
                callSettings);

        /// <summary>
        /// Advanced API that analyzes the document and provides a full set of text
        /// annotations, including semantic, syntactic, and sentiment information. This
        /// API is intended for users who are familiar with machine learning and need
        /// in-depth text features to build upon.
        /// </summary>
        /// <param name="document">Input document.</param>
        /// <param name="features">The enabled features.</param>
        /// <param name="encodingType">The encoding type used by the API to calculate offsets.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<AnnotateTextResponse> AnnotateTextAsync(
            Document document,
            AnnotateTextRequest.Types.Features features,
            EncodingType encodingType,
            CallSettings callSettings = null) => _callAnnotateText.Async(
                new AnnotateTextRequest
                {
                    Document = document,
                    Features = features,
                    EncodingType = encodingType,
                },
                callSettings);

        /// <summary>
        /// Advanced API that analyzes the document and provides a full set of text
        /// annotations, including semantic, syntactic, and sentiment information. This
        /// API is intended for users who are familiar with machine learning and need
        /// in-depth text features to build upon.
        /// </summary>
        /// <param name="document">Input document.</param>
        /// <param name="features">The enabled features.</param>
        /// <param name="encodingType">The encoding type used by the API to calculate offsets.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnnotateTextResponse AnnotateText(
            Document document,
            AnnotateTextRequest.Types.Features features,
            EncodingType encodingType,
            CallSettings callSettings = null) => _callAnnotateText.Sync(
                new AnnotateTextRequest
                {
                    Document = document,
                    Features = features,
                    EncodingType = encodingType,
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

}