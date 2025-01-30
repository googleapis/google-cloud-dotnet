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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Language.V2
{
    /// <summary>Settings for <see cref="LanguageServiceClient"/> instances.</summary>
    public sealed partial class LanguageServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LanguageServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LanguageServiceSettings"/>.</returns>
        public static LanguageServiceSettings GetDefault() => new LanguageServiceSettings();

        /// <summary>Constructs a new <see cref="LanguageServiceSettings"/> object with default settings.</summary>
        public LanguageServiceSettings()
        {
        }

        private LanguageServiceSettings(LanguageServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AnalyzeSentimentSettings = existing.AnalyzeSentimentSettings;
            AnalyzeEntitiesSettings = existing.AnalyzeEntitiesSettings;
            ClassifyTextSettings = existing.ClassifyTextSettings;
            ModerateTextSettings = existing.ModerateTextSettings;
            AnnotateTextSettings = existing.AnnotateTextSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LanguageServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.AnalyzeSentiment</c> and <c>LanguageServiceClient.AnalyzeSentimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnalyzeSentimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.AnalyzeEntities</c> and <c>LanguageServiceClient.AnalyzeEntitiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnalyzeEntitiesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.ClassifyText</c> and <c>LanguageServiceClient.ClassifyTextAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ClassifyTextSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.ModerateText</c> and <c>LanguageServiceClient.ModerateTextAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ModerateTextSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageServiceClient.AnnotateText</c> and <c>LanguageServiceClient.AnnotateTextAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnnotateTextSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LanguageServiceSettings"/> object.</returns>
        public LanguageServiceSettings Clone() => new LanguageServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LanguageServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class LanguageServiceClientBuilder : gaxgrpc::ClientBuilderBase<LanguageServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LanguageServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LanguageServiceClientBuilder() : base(LanguageServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LanguageServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LanguageServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LanguageServiceClient Build()
        {
            LanguageServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LanguageServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LanguageServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LanguageServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LanguageServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LanguageServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LanguageServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LanguageServiceClient.ChannelPool;
    }

    /// <summary>LanguageService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides text analysis operations such as sentiment analysis and entity
    /// recognition.
    /// </remarks>
    public abstract partial class LanguageServiceClient
    {
        /// <summary>
        /// The default endpoint for the LanguageService service, which is a host of "language.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "language.googleapis.com:443";

        /// <summary>The default LanguageService scopes.</summary>
        /// <remarks>
        /// The default LanguageService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-language</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-language",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LanguageService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LanguageServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LanguageServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LanguageServiceClient"/>.</returns>
        public static stt::Task<LanguageServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LanguageServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LanguageServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LanguageServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LanguageServiceClient"/>.</returns>
        public static LanguageServiceClient Create() => new LanguageServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LanguageServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LanguageServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LanguageServiceClient"/>.</returns>
        internal static LanguageServiceClient Create(grpccore::CallInvoker callInvoker, LanguageServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LanguageService.LanguageServiceClient grpcClient = new LanguageService.LanguageServiceClient(callInvoker);
            return new LanguageServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LanguageService client</summary>
        public virtual LanguageService.LanguageServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeSentimentResponse AnalyzeSentiment(AnalyzeSentimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(AnalyzeSentimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(AnalyzeSentimentRequest request, st::CancellationToken cancellationToken) =>
            AnalyzeSentimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate sentence offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeSentimentResponse AnalyzeSentiment(Document document, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeSentiment(new AnalyzeSentimentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate sentence offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(Document document, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeSentimentAsync(new AnalyzeSentimentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate sentence offsets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(Document document, EncodingType encodingType, st::CancellationToken cancellationToken) =>
            AnalyzeSentimentAsync(document, encodingType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeSentimentResponse AnalyzeSentiment(Document document, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeSentiment(new AnalyzeSentimentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(Document document, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeSentimentAsync(new AnalyzeSentimentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(Document document, st::CancellationToken cancellationToken) =>
            AnalyzeSentimentAsync(document, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, probability, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeEntitiesResponse AnalyzeEntities(AnalyzeEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, probability, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(AnalyzeEntitiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, probability, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(AnalyzeEntitiesRequest request, st::CancellationToken cancellationToken) =>
            AnalyzeEntitiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, probability, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeEntitiesResponse AnalyzeEntities(Document document, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeEntities(new AnalyzeEntitiesRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, probability, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(Document document, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeEntitiesAsync(new AnalyzeEntitiesRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, probability, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(Document document, EncodingType encodingType, st::CancellationToken cancellationToken) =>
            AnalyzeEntitiesAsync(document, encodingType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, probability, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeEntitiesResponse AnalyzeEntities(Document document, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeEntities(new AnalyzeEntitiesRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, probability, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(Document document, gaxgrpc::CallSettings callSettings = null) =>
            AnalyzeEntitiesAsync(new AnalyzeEntitiesRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, probability, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(Document document, st::CancellationToken cancellationToken) =>
            AnalyzeEntitiesAsync(document, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClassifyTextResponse ClassifyText(ClassifyTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClassifyTextResponse> ClassifyTextAsync(ClassifyTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClassifyTextResponse> ClassifyTextAsync(ClassifyTextRequest request, st::CancellationToken cancellationToken) =>
            ClassifyTextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClassifyTextResponse ClassifyText(Document document, gaxgrpc::CallSettings callSettings = null) =>
            ClassifyText(new ClassifyTextRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClassifyTextResponse> ClassifyTextAsync(Document document, gaxgrpc::CallSettings callSettings = null) =>
            ClassifyTextAsync(new ClassifyTextRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClassifyTextResponse> ClassifyTextAsync(Document document, st::CancellationToken cancellationToken) =>
            ClassifyTextAsync(document, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moderates a document for harmful and sensitive categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModerateTextResponse ModerateText(ModerateTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moderates a document for harmful and sensitive categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModerateTextResponse> ModerateTextAsync(ModerateTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moderates a document for harmful and sensitive categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModerateTextResponse> ModerateTextAsync(ModerateTextRequest request, st::CancellationToken cancellationToken) =>
            ModerateTextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moderates a document for harmful and sensitive categories.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModerateTextResponse ModerateText(Document document, gaxgrpc::CallSettings callSettings = null) =>
            ModerateText(new ModerateTextRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Moderates a document for harmful and sensitive categories.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModerateTextResponse> ModerateTextAsync(Document document, gaxgrpc::CallSettings callSettings = null) =>
            ModerateTextAsync(new ModerateTextRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Moderates a document for harmful and sensitive categories.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModerateTextResponse> ModerateTextAsync(Document document, st::CancellationToken cancellationToken) =>
            ModerateTextAsync(document, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// A convenience method that provides all features in one call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotateTextResponse AnnotateText(AnnotateTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// A convenience method that provides all features in one call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateTextResponse> AnnotateTextAsync(AnnotateTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// A convenience method that provides all features in one call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateTextResponse> AnnotateTextAsync(AnnotateTextRequest request, st::CancellationToken cancellationToken) =>
            AnnotateTextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// A convenience method that provides all features in one call.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="features">
        /// Required. The enabled features.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotateTextResponse AnnotateText(Document document, AnnotateTextRequest.Types.Features features, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateText(new AnnotateTextRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                Features = gax::GaxPreconditions.CheckNotNull(features, nameof(features)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// A convenience method that provides all features in one call.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="features">
        /// Required. The enabled features.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateTextResponse> AnnotateTextAsync(Document document, AnnotateTextRequest.Types.Features features, EncodingType encodingType, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateTextAsync(new AnnotateTextRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                Features = gax::GaxPreconditions.CheckNotNull(features, nameof(features)),
                EncodingType = encodingType,
            }, callSettings);

        /// <summary>
        /// A convenience method that provides all features in one call.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="features">
        /// Required. The enabled features.
        /// </param>
        /// <param name="encodingType">
        /// The encoding type used by the API to calculate offsets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateTextResponse> AnnotateTextAsync(Document document, AnnotateTextRequest.Types.Features features, EncodingType encodingType, st::CancellationToken cancellationToken) =>
            AnnotateTextAsync(document, features, encodingType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// A convenience method that provides all features in one call.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="features">
        /// Required. The enabled features.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotateTextResponse AnnotateText(Document document, AnnotateTextRequest.Types.Features features, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateText(new AnnotateTextRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                Features = gax::GaxPreconditions.CheckNotNull(features, nameof(features)),
            }, callSettings);

        /// <summary>
        /// A convenience method that provides all features in one call.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="features">
        /// Required. The enabled features.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateTextResponse> AnnotateTextAsync(Document document, AnnotateTextRequest.Types.Features features, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateTextAsync(new AnnotateTextRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                Features = gax::GaxPreconditions.CheckNotNull(features, nameof(features)),
            }, callSettings);

        /// <summary>
        /// A convenience method that provides all features in one call.
        /// </summary>
        /// <param name="document">
        /// Required. Input document.
        /// </param>
        /// <param name="features">
        /// Required. The enabled features.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateTextResponse> AnnotateTextAsync(Document document, AnnotateTextRequest.Types.Features features, st::CancellationToken cancellationToken) =>
            AnnotateTextAsync(document, features, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LanguageService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides text analysis operations such as sentiment analysis and entity
    /// recognition.
    /// </remarks>
    public sealed partial class LanguageServiceClientImpl : LanguageServiceClient
    {
        private readonly gaxgrpc::ApiCall<AnalyzeSentimentRequest, AnalyzeSentimentResponse> _callAnalyzeSentiment;

        private readonly gaxgrpc::ApiCall<AnalyzeEntitiesRequest, AnalyzeEntitiesResponse> _callAnalyzeEntities;

        private readonly gaxgrpc::ApiCall<ClassifyTextRequest, ClassifyTextResponse> _callClassifyText;

        private readonly gaxgrpc::ApiCall<ModerateTextRequest, ModerateTextResponse> _callModerateText;

        private readonly gaxgrpc::ApiCall<AnnotateTextRequest, AnnotateTextResponse> _callAnnotateText;

        /// <summary>
        /// Constructs a client wrapper for the LanguageService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LanguageServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LanguageServiceClientImpl(LanguageService.LanguageServiceClient grpcClient, LanguageServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LanguageServiceSettings effectiveSettings = settings ?? LanguageServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callAnalyzeSentiment = clientHelper.BuildApiCall<AnalyzeSentimentRequest, AnalyzeSentimentResponse>("AnalyzeSentiment", grpcClient.AnalyzeSentimentAsync, grpcClient.AnalyzeSentiment, effectiveSettings.AnalyzeSentimentSettings);
            Modify_ApiCall(ref _callAnalyzeSentiment);
            Modify_AnalyzeSentimentApiCall(ref _callAnalyzeSentiment);
            _callAnalyzeEntities = clientHelper.BuildApiCall<AnalyzeEntitiesRequest, AnalyzeEntitiesResponse>("AnalyzeEntities", grpcClient.AnalyzeEntitiesAsync, grpcClient.AnalyzeEntities, effectiveSettings.AnalyzeEntitiesSettings);
            Modify_ApiCall(ref _callAnalyzeEntities);
            Modify_AnalyzeEntitiesApiCall(ref _callAnalyzeEntities);
            _callClassifyText = clientHelper.BuildApiCall<ClassifyTextRequest, ClassifyTextResponse>("ClassifyText", grpcClient.ClassifyTextAsync, grpcClient.ClassifyText, effectiveSettings.ClassifyTextSettings);
            Modify_ApiCall(ref _callClassifyText);
            Modify_ClassifyTextApiCall(ref _callClassifyText);
            _callModerateText = clientHelper.BuildApiCall<ModerateTextRequest, ModerateTextResponse>("ModerateText", grpcClient.ModerateTextAsync, grpcClient.ModerateText, effectiveSettings.ModerateTextSettings);
            Modify_ApiCall(ref _callModerateText);
            Modify_ModerateTextApiCall(ref _callModerateText);
            _callAnnotateText = clientHelper.BuildApiCall<AnnotateTextRequest, AnnotateTextResponse>("AnnotateText", grpcClient.AnnotateTextAsync, grpcClient.AnnotateText, effectiveSettings.AnnotateTextSettings);
            Modify_ApiCall(ref _callAnnotateText);
            Modify_AnnotateTextApiCall(ref _callAnnotateText);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AnalyzeSentimentApiCall(ref gaxgrpc::ApiCall<AnalyzeSentimentRequest, AnalyzeSentimentResponse> call);

        partial void Modify_AnalyzeEntitiesApiCall(ref gaxgrpc::ApiCall<AnalyzeEntitiesRequest, AnalyzeEntitiesResponse> call);

        partial void Modify_ClassifyTextApiCall(ref gaxgrpc::ApiCall<ClassifyTextRequest, ClassifyTextResponse> call);

        partial void Modify_ModerateTextApiCall(ref gaxgrpc::ApiCall<ModerateTextRequest, ModerateTextResponse> call);

        partial void Modify_AnnotateTextApiCall(ref gaxgrpc::ApiCall<AnnotateTextRequest, AnnotateTextResponse> call);

        partial void OnConstruction(LanguageService.LanguageServiceClient grpcClient, LanguageServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LanguageService client</summary>
        public override LanguageService.LanguageServiceClient GrpcClient { get; }

        partial void Modify_AnalyzeSentimentRequest(ref AnalyzeSentimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AnalyzeEntitiesRequest(ref AnalyzeEntitiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ClassifyTextRequest(ref ClassifyTextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ModerateTextRequest(ref ModerateTextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AnnotateTextRequest(ref AnnotateTextRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyzeSentimentResponse AnalyzeSentiment(AnalyzeSentimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeSentimentRequest(ref request, ref callSettings);
            return _callAnalyzeSentiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Analyzes the sentiment of the provided text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(AnalyzeSentimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeSentimentRequest(ref request, ref callSettings);
            return _callAnalyzeSentiment.Async(request, callSettings);
        }

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, probability, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyzeEntitiesResponse AnalyzeEntities(AnalyzeEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeEntitiesRequest(ref request, ref callSettings);
            return _callAnalyzeEntities.Sync(request, callSettings);
        }

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the text
        /// along with entity types, probability, mentions for each entity, and
        /// other properties.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalyzeEntitiesResponse> AnalyzeEntitiesAsync(AnalyzeEntitiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeEntitiesRequest(ref request, ref callSettings);
            return _callAnalyzeEntities.Async(request, callSettings);
        }

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ClassifyTextResponse ClassifyText(ClassifyTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ClassifyTextRequest(ref request, ref callSettings);
            return _callClassifyText.Sync(request, callSettings);
        }

        /// <summary>
        /// Classifies a document into categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ClassifyTextResponse> ClassifyTextAsync(ClassifyTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ClassifyTextRequest(ref request, ref callSettings);
            return _callClassifyText.Async(request, callSettings);
        }

        /// <summary>
        /// Moderates a document for harmful and sensitive categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ModerateTextResponse ModerateText(ModerateTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ModerateTextRequest(ref request, ref callSettings);
            return _callModerateText.Sync(request, callSettings);
        }

        /// <summary>
        /// Moderates a document for harmful and sensitive categories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ModerateTextResponse> ModerateTextAsync(ModerateTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ModerateTextRequest(ref request, ref callSettings);
            return _callModerateText.Async(request, callSettings);
        }

        /// <summary>
        /// A convenience method that provides all features in one call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnnotateTextResponse AnnotateText(AnnotateTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnotateTextRequest(ref request, ref callSettings);
            return _callAnnotateText.Sync(request, callSettings);
        }

        /// <summary>
        /// A convenience method that provides all features in one call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnnotateTextResponse> AnnotateTextAsync(AnnotateTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnotateTextRequest(ref request, ref callSettings);
            return _callAnnotateText.Async(request, callSettings);
        }
    }
}
