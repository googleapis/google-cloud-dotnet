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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Translate.V3
{
    /// <summary>Settings for <see cref="TranslationServiceClient"/> instances.</summary>
    public sealed partial class TranslationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TranslationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TranslationServiceSettings"/>.</returns>
        public static TranslationServiceSettings GetDefault() => new TranslationServiceSettings();

        /// <summary>Constructs a new <see cref="TranslationServiceSettings"/> object with default settings.</summary>
        public TranslationServiceSettings()
        {
        }

        private TranslationServiceSettings(TranslationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            TranslateTextSettings = existing.TranslateTextSettings;
            DetectLanguageSettings = existing.DetectLanguageSettings;
            GetSupportedLanguagesSettings = existing.GetSupportedLanguagesSettings;
            TranslateDocumentSettings = existing.TranslateDocumentSettings;
            BatchTranslateTextSettings = existing.BatchTranslateTextSettings;
            BatchTranslateTextOperationsSettings = existing.BatchTranslateTextOperationsSettings.Clone();
            BatchTranslateDocumentSettings = existing.BatchTranslateDocumentSettings;
            BatchTranslateDocumentOperationsSettings = existing.BatchTranslateDocumentOperationsSettings.Clone();
            CreateGlossarySettings = existing.CreateGlossarySettings;
            CreateGlossaryOperationsSettings = existing.CreateGlossaryOperationsSettings.Clone();
            ListGlossariesSettings = existing.ListGlossariesSettings;
            GetGlossarySettings = existing.GetGlossarySettings;
            DeleteGlossarySettings = existing.DeleteGlossarySettings;
            DeleteGlossaryOperationsSettings = existing.DeleteGlossaryOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(TranslationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.TranslateText</c> and <c>TranslationServiceClient.TranslateTextAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TranslateTextSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.DetectLanguage</c> and <c>TranslationServiceClient.DetectLanguageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DetectLanguageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.GetSupportedLanguages</c> and
        /// <c>TranslationServiceClient.GetSupportedLanguagesAsync</c>.
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
        public gaxgrpc::CallSettings GetSupportedLanguagesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.TranslateDocument</c> and <c>TranslationServiceClient.TranslateDocumentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TranslateDocumentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.BatchTranslateText</c> and <c>TranslationServiceClient.BatchTranslateTextAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchTranslateTextSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TranslationServiceClient.BatchTranslateText</c> and
        /// <c>TranslationServiceClient.BatchTranslateTextAsync</c>.
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
        public lro::OperationsSettings BatchTranslateTextOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.BatchTranslateDocument</c> and
        /// <c>TranslationServiceClient.BatchTranslateDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchTranslateDocumentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TranslationServiceClient.BatchTranslateDocument</c> and
        /// <c>TranslationServiceClient.BatchTranslateDocumentAsync</c>.
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
        public lro::OperationsSettings BatchTranslateDocumentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.CreateGlossary</c> and <c>TranslationServiceClient.CreateGlossaryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGlossarySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TranslationServiceClient.CreateGlossary</c> and
        /// <c>TranslationServiceClient.CreateGlossaryAsync</c>.
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
        public lro::OperationsSettings CreateGlossaryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.ListGlossaries</c> and <c>TranslationServiceClient.ListGlossariesAsync</c>.
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
        public gaxgrpc::CallSettings ListGlossariesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.GetGlossary</c> and <c>TranslationServiceClient.GetGlossaryAsync</c>.
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
        public gaxgrpc::CallSettings GetGlossarySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.DeleteGlossary</c> and <c>TranslationServiceClient.DeleteGlossaryAsync</c>.
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
        public gaxgrpc::CallSettings DeleteGlossarySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TranslationServiceClient.DeleteGlossary</c> and
        /// <c>TranslationServiceClient.DeleteGlossaryAsync</c>.
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
        public lro::OperationsSettings DeleteGlossaryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TranslationServiceSettings"/> object.</returns>
        public TranslationServiceSettings Clone() => new TranslationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TranslationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class TranslationServiceClientBuilder : gaxgrpc::ClientBuilderBase<TranslationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TranslationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TranslationServiceClientBuilder() : base(TranslationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TranslationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TranslationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TranslationServiceClient Build()
        {
            TranslationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TranslationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TranslationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TranslationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TranslationServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<TranslationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TranslationServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TranslationServiceClient.ChannelPool;
    }

    /// <summary>TranslationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides natural language translation operations.
    /// </remarks>
    public abstract partial class TranslationServiceClient
    {
        /// <summary>
        /// The default endpoint for the TranslationService service, which is a host of "translate.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "translate.googleapis.com:443";

        /// <summary>The default TranslationService scopes.</summary>
        /// <remarks>
        /// The default TranslationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-translation</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-translation",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TranslationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TranslationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TranslationServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TranslationServiceClient"/>.</returns>
        public static stt::Task<TranslationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TranslationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TranslationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TranslationServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="TranslationServiceClient"/>.</returns>
        public static TranslationServiceClient Create() => new TranslationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TranslationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TranslationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TranslationServiceClient"/>.</returns>
        internal static TranslationServiceClient Create(grpccore::CallInvoker callInvoker, TranslationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TranslationService.TranslationServiceClient grpcClient = new TranslationService.TranslationServiceClient(callInvoker);
            return new TranslationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TranslationService client</summary>
        public virtual TranslationService.TranslationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TranslateTextResponse TranslateText(TranslateTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranslateTextResponse> TranslateTextAsync(TranslateTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranslateTextResponse> TranslateTextAsync(TranslateTextRequest request, st::CancellationToken cancellationToken) =>
            TranslateTextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for requests using AutoML models or
        /// custom glossaries.
        /// 
        /// Models and glossaries must be within the same region (have same
        /// location-id), otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Required. The BCP-47 language code to use for translation of the input
        /// text, set to one of the language codes listed in Language Support.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the input in string format.
        /// We recommend the total content be less than 30k codepoints. The max length
        /// of this field is 1024.
        /// Use BatchTranslateText for larger text.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TranslateTextResponse TranslateText(string parent, string targetLanguageCode, scg::IEnumerable<string> contents, gaxgrpc::CallSettings callSettings = null) =>
            TranslateText(new TranslateTextRequest
            {
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
                TargetLanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(targetLanguageCode, nameof(targetLanguageCode)),
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for requests using AutoML models or
        /// custom glossaries.
        /// 
        /// Models and glossaries must be within the same region (have same
        /// location-id), otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Required. The BCP-47 language code to use for translation of the input
        /// text, set to one of the language codes listed in Language Support.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the input in string format.
        /// We recommend the total content be less than 30k codepoints. The max length
        /// of this field is 1024.
        /// Use BatchTranslateText for larger text.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranslateTextResponse> TranslateTextAsync(string parent, string targetLanguageCode, scg::IEnumerable<string> contents, gaxgrpc::CallSettings callSettings = null) =>
            TranslateTextAsync(new TranslateTextRequest
            {
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
                TargetLanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(targetLanguageCode, nameof(targetLanguageCode)),
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for requests using AutoML models or
        /// custom glossaries.
        /// 
        /// Models and glossaries must be within the same region (have same
        /// location-id), otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Required. The BCP-47 language code to use for translation of the input
        /// text, set to one of the language codes listed in Language Support.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the input in string format.
        /// We recommend the total content be less than 30k codepoints. The max length
        /// of this field is 1024.
        /// Use BatchTranslateText for larger text.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranslateTextResponse> TranslateTextAsync(string parent, string targetLanguageCode, scg::IEnumerable<string> contents, st::CancellationToken cancellationToken) =>
            TranslateTextAsync(parent, targetLanguageCode, contents, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for requests using AutoML models or
        /// custom glossaries.
        /// 
        /// Models and glossaries must be within the same region (have same
        /// location-id), otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Required. The BCP-47 language code to use for translation of the input
        /// text, set to one of the language codes listed in Language Support.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the input in string format.
        /// We recommend the total content be less than 30k codepoints. The max length
        /// of this field is 1024.
        /// Use BatchTranslateText for larger text.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TranslateTextResponse TranslateText(gagr::LocationName parent, string targetLanguageCode, scg::IEnumerable<string> contents, gaxgrpc::CallSettings callSettings = null) =>
            TranslateText(new TranslateTextRequest
            {
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
                TargetLanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(targetLanguageCode, nameof(targetLanguageCode)),
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for requests using AutoML models or
        /// custom glossaries.
        /// 
        /// Models and glossaries must be within the same region (have same
        /// location-id), otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Required. The BCP-47 language code to use for translation of the input
        /// text, set to one of the language codes listed in Language Support.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the input in string format.
        /// We recommend the total content be less than 30k codepoints. The max length
        /// of this field is 1024.
        /// Use BatchTranslateText for larger text.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranslateTextResponse> TranslateTextAsync(gagr::LocationName parent, string targetLanguageCode, scg::IEnumerable<string> contents, gaxgrpc::CallSettings callSettings = null) =>
            TranslateTextAsync(new TranslateTextRequest
            {
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
                TargetLanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(targetLanguageCode, nameof(targetLanguageCode)),
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for requests using AutoML models or
        /// custom glossaries.
        /// 
        /// Models and glossaries must be within the same region (have same
        /// location-id), otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Required. The BCP-47 language code to use for translation of the input
        /// text, set to one of the language codes listed in Language Support.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the input in string format.
        /// We recommend the total content be less than 30k codepoints. The max length
        /// of this field is 1024.
        /// Use BatchTranslateText for larger text.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranslateTextResponse> TranslateTextAsync(gagr::LocationName parent, string targetLanguageCode, scg::IEnumerable<string> contents, st::CancellationToken cancellationToken) =>
            TranslateTextAsync(parent, targetLanguageCode, contents, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for requests using AutoML models or
        /// custom glossaries.
        /// 
        /// Models and glossaries must be within the same region (have same
        /// location-id), otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The `model` type requested for this translation.
        /// 
        /// The format depends on model type:
        /// 
        /// - AutoML Translation models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}`
        /// 
        /// - General (built-in) models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`,
        /// 
        /// 
        /// For global (non-regionalized) requests, use `location-id` `global`.
        /// For example,
        /// `projects/{project-number-or-id}/locations/global/models/general/nmt`.
        /// 
        /// If not provided, the default Google model (NMT) will be used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Optional. The BCP-47 language code of the input text if
        /// known, for example, "en-US" or "sr-Latn". Supported language codes are
        /// listed in Language Support. If the source language isn't specified, the API
        /// attempts to identify the source language automatically and returns the
        /// source language within the response.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Required. The BCP-47 language code to use for translation of the input
        /// text, set to one of the language codes listed in Language Support.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the input in string format.
        /// We recommend the total content be less than 30k codepoints. The max length
        /// of this field is 1024.
        /// Use BatchTranslateText for larger text.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TranslateTextResponse TranslateText(string parent, string model, string mimeType, string sourceLanguageCode, string targetLanguageCode, scg::IEnumerable<string> contents, gaxgrpc::CallSettings callSettings = null) =>
            TranslateText(new TranslateTextRequest
            {
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
                MimeType = mimeType ?? "",
                SourceLanguageCode = sourceLanguageCode ?? "",
                TargetLanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(targetLanguageCode, nameof(targetLanguageCode)),
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Model = model ?? "",
            }, callSettings);

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for requests using AutoML models or
        /// custom glossaries.
        /// 
        /// Models and glossaries must be within the same region (have same
        /// location-id), otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The `model` type requested for this translation.
        /// 
        /// The format depends on model type:
        /// 
        /// - AutoML Translation models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}`
        /// 
        /// - General (built-in) models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`,
        /// 
        /// 
        /// For global (non-regionalized) requests, use `location-id` `global`.
        /// For example,
        /// `projects/{project-number-or-id}/locations/global/models/general/nmt`.
        /// 
        /// If not provided, the default Google model (NMT) will be used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Optional. The BCP-47 language code of the input text if
        /// known, for example, "en-US" or "sr-Latn". Supported language codes are
        /// listed in Language Support. If the source language isn't specified, the API
        /// attempts to identify the source language automatically and returns the
        /// source language within the response.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Required. The BCP-47 language code to use for translation of the input
        /// text, set to one of the language codes listed in Language Support.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the input in string format.
        /// We recommend the total content be less than 30k codepoints. The max length
        /// of this field is 1024.
        /// Use BatchTranslateText for larger text.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranslateTextResponse> TranslateTextAsync(string parent, string model, string mimeType, string sourceLanguageCode, string targetLanguageCode, scg::IEnumerable<string> contents, gaxgrpc::CallSettings callSettings = null) =>
            TranslateTextAsync(new TranslateTextRequest
            {
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
                MimeType = mimeType ?? "",
                SourceLanguageCode = sourceLanguageCode ?? "",
                TargetLanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(targetLanguageCode, nameof(targetLanguageCode)),
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Model = model ?? "",
            }, callSettings);

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for requests using AutoML models or
        /// custom glossaries.
        /// 
        /// Models and glossaries must be within the same region (have same
        /// location-id), otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The `model` type requested for this translation.
        /// 
        /// The format depends on model type:
        /// 
        /// - AutoML Translation models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}`
        /// 
        /// - General (built-in) models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`,
        /// 
        /// 
        /// For global (non-regionalized) requests, use `location-id` `global`.
        /// For example,
        /// `projects/{project-number-or-id}/locations/global/models/general/nmt`.
        /// 
        /// If not provided, the default Google model (NMT) will be used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Optional. The BCP-47 language code of the input text if
        /// known, for example, "en-US" or "sr-Latn". Supported language codes are
        /// listed in Language Support. If the source language isn't specified, the API
        /// attempts to identify the source language automatically and returns the
        /// source language within the response.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Required. The BCP-47 language code to use for translation of the input
        /// text, set to one of the language codes listed in Language Support.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the input in string format.
        /// We recommend the total content be less than 30k codepoints. The max length
        /// of this field is 1024.
        /// Use BatchTranslateText for larger text.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranslateTextResponse> TranslateTextAsync(string parent, string model, string mimeType, string sourceLanguageCode, string targetLanguageCode, scg::IEnumerable<string> contents, st::CancellationToken cancellationToken) =>
            TranslateTextAsync(parent, model, mimeType, sourceLanguageCode, targetLanguageCode, contents, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for requests using AutoML models or
        /// custom glossaries.
        /// 
        /// Models and glossaries must be within the same region (have same
        /// location-id), otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The `model` type requested for this translation.
        /// 
        /// The format depends on model type:
        /// 
        /// - AutoML Translation models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}`
        /// 
        /// - General (built-in) models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`,
        /// 
        /// 
        /// For global (non-regionalized) requests, use `location-id` `global`.
        /// For example,
        /// `projects/{project-number-or-id}/locations/global/models/general/nmt`.
        /// 
        /// If not provided, the default Google model (NMT) will be used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Optional. The BCP-47 language code of the input text if
        /// known, for example, "en-US" or "sr-Latn". Supported language codes are
        /// listed in Language Support. If the source language isn't specified, the API
        /// attempts to identify the source language automatically and returns the
        /// source language within the response.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Required. The BCP-47 language code to use for translation of the input
        /// text, set to one of the language codes listed in Language Support.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the input in string format.
        /// We recommend the total content be less than 30k codepoints. The max length
        /// of this field is 1024.
        /// Use BatchTranslateText for larger text.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TranslateTextResponse TranslateText(gagr::LocationName parent, string model, string mimeType, string sourceLanguageCode, string targetLanguageCode, scg::IEnumerable<string> contents, gaxgrpc::CallSettings callSettings = null) =>
            TranslateText(new TranslateTextRequest
            {
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
                MimeType = mimeType ?? "",
                SourceLanguageCode = sourceLanguageCode ?? "",
                TargetLanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(targetLanguageCode, nameof(targetLanguageCode)),
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Model = model ?? "",
            }, callSettings);

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for requests using AutoML models or
        /// custom glossaries.
        /// 
        /// Models and glossaries must be within the same region (have same
        /// location-id), otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The `model` type requested for this translation.
        /// 
        /// The format depends on model type:
        /// 
        /// - AutoML Translation models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}`
        /// 
        /// - General (built-in) models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`,
        /// 
        /// 
        /// For global (non-regionalized) requests, use `location-id` `global`.
        /// For example,
        /// `projects/{project-number-or-id}/locations/global/models/general/nmt`.
        /// 
        /// If not provided, the default Google model (NMT) will be used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Optional. The BCP-47 language code of the input text if
        /// known, for example, "en-US" or "sr-Latn". Supported language codes are
        /// listed in Language Support. If the source language isn't specified, the API
        /// attempts to identify the source language automatically and returns the
        /// source language within the response.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Required. The BCP-47 language code to use for translation of the input
        /// text, set to one of the language codes listed in Language Support.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the input in string format.
        /// We recommend the total content be less than 30k codepoints. The max length
        /// of this field is 1024.
        /// Use BatchTranslateText for larger text.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranslateTextResponse> TranslateTextAsync(gagr::LocationName parent, string model, string mimeType, string sourceLanguageCode, string targetLanguageCode, scg::IEnumerable<string> contents, gaxgrpc::CallSettings callSettings = null) =>
            TranslateTextAsync(new TranslateTextRequest
            {
                Contents =
                {
                    gax::GaxPreconditions.CheckNotNull(contents, nameof(contents)),
                },
                MimeType = mimeType ?? "",
                SourceLanguageCode = sourceLanguageCode ?? "",
                TargetLanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(targetLanguageCode, nameof(targetLanguageCode)),
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Model = model ?? "",
            }, callSettings);

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for requests using AutoML models or
        /// custom glossaries.
        /// 
        /// Models and glossaries must be within the same region (have same
        /// location-id), otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The `model` type requested for this translation.
        /// 
        /// The format depends on model type:
        /// 
        /// - AutoML Translation models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}`
        /// 
        /// - General (built-in) models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`,
        /// 
        /// 
        /// For global (non-regionalized) requests, use `location-id` `global`.
        /// For example,
        /// `projects/{project-number-or-id}/locations/global/models/general/nmt`.
        /// 
        /// If not provided, the default Google model (NMT) will be used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Optional. The BCP-47 language code of the input text if
        /// known, for example, "en-US" or "sr-Latn". Supported language codes are
        /// listed in Language Support. If the source language isn't specified, the API
        /// attempts to identify the source language automatically and returns the
        /// source language within the response.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Required. The BCP-47 language code to use for translation of the input
        /// text, set to one of the language codes listed in Language Support.
        /// </param>
        /// <param name="contents">
        /// Required. The content of the input in string format.
        /// We recommend the total content be less than 30k codepoints. The max length
        /// of this field is 1024.
        /// Use BatchTranslateText for larger text.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranslateTextResponse> TranslateTextAsync(gagr::LocationName parent, string model, string mimeType, string sourceLanguageCode, string targetLanguageCode, scg::IEnumerable<string> contents, st::CancellationToken cancellationToken) =>
            TranslateTextAsync(parent, model, mimeType, sourceLanguageCode, targetLanguageCode, contents, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DetectLanguageResponse DetectLanguage(DetectLanguageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetectLanguageResponse> DetectLanguageAsync(DetectLanguageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetectLanguageResponse> DetectLanguageAsync(DetectLanguageRequest request, st::CancellationToken cancellationToken) =>
            DetectLanguageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}/locations/{location-id}` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Only models within the same region (has same location-id) can be used.
        /// Otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The language detection model to be used.
        /// 
        /// Format:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/language-detection/{model-id}`
        /// 
        /// Only one language detection model is currently supported:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/language-detection/default`.
        /// 
        /// If not specified, the default model is used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="content">
        /// The content of the input stored as a string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DetectLanguageResponse DetectLanguage(string parent, string model, string mimeType, string content, gaxgrpc::CallSettings callSettings = null) =>
            DetectLanguage(new DetectLanguageRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Model = model ?? "",
                Content = content ?? "",
                MimeType = mimeType ?? "",
            }, callSettings);

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}/locations/{location-id}` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Only models within the same region (has same location-id) can be used.
        /// Otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The language detection model to be used.
        /// 
        /// Format:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/language-detection/{model-id}`
        /// 
        /// Only one language detection model is currently supported:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/language-detection/default`.
        /// 
        /// If not specified, the default model is used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="content">
        /// The content of the input stored as a string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetectLanguageResponse> DetectLanguageAsync(string parent, string model, string mimeType, string content, gaxgrpc::CallSettings callSettings = null) =>
            DetectLanguageAsync(new DetectLanguageRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Model = model ?? "",
                Content = content ?? "",
                MimeType = mimeType ?? "",
            }, callSettings);

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}/locations/{location-id}` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Only models within the same region (has same location-id) can be used.
        /// Otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The language detection model to be used.
        /// 
        /// Format:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/language-detection/{model-id}`
        /// 
        /// Only one language detection model is currently supported:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/language-detection/default`.
        /// 
        /// If not specified, the default model is used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="content">
        /// The content of the input stored as a string.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetectLanguageResponse> DetectLanguageAsync(string parent, string model, string mimeType, string content, st::CancellationToken cancellationToken) =>
            DetectLanguageAsync(parent, model, mimeType, content, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}/locations/{location-id}` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Only models within the same region (has same location-id) can be used.
        /// Otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The language detection model to be used.
        /// 
        /// Format:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/language-detection/{model-id}`
        /// 
        /// Only one language detection model is currently supported:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/language-detection/default`.
        /// 
        /// If not specified, the default model is used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="content">
        /// The content of the input stored as a string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DetectLanguageResponse DetectLanguage(gagr::LocationName parent, string model, string mimeType, string content, gaxgrpc::CallSettings callSettings = null) =>
            DetectLanguage(new DetectLanguageRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Model = model ?? "",
                Content = content ?? "",
                MimeType = mimeType ?? "",
            }, callSettings);

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}/locations/{location-id}` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Only models within the same region (has same location-id) can be used.
        /// Otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The language detection model to be used.
        /// 
        /// Format:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/language-detection/{model-id}`
        /// 
        /// Only one language detection model is currently supported:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/language-detection/default`.
        /// 
        /// If not specified, the default model is used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="content">
        /// The content of the input stored as a string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetectLanguageResponse> DetectLanguageAsync(gagr::LocationName parent, string model, string mimeType, string content, gaxgrpc::CallSettings callSettings = null) =>
            DetectLanguageAsync(new DetectLanguageRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Model = model ?? "",
                Content = content ?? "",
                MimeType = mimeType ?? "",
            }, callSettings);

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}/locations/{location-id}` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Only models within the same region (has same location-id) can be used.
        /// Otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The language detection model to be used.
        /// 
        /// Format:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/language-detection/{model-id}`
        /// 
        /// Only one language detection model is currently supported:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/language-detection/default`.
        /// 
        /// If not specified, the default model is used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="content">
        /// The content of the input stored as a string.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DetectLanguageResponse> DetectLanguageAsync(gagr::LocationName parent, string model, string mimeType, string content, st::CancellationToken cancellationToken) =>
            DetectLanguageAsync(parent, model, mimeType, content, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportedLanguages GetSupportedLanguages(GetSupportedLanguagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportedLanguages> GetSupportedLanguagesAsync(GetSupportedLanguagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportedLanguages> GetSupportedLanguagesAsync(GetSupportedLanguagesRequest request, st::CancellationToken cancellationToken) =>
            GetSupportedLanguagesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for AutoML models.
        /// 
        /// Only models within the same region (have same location-id) can be used,
        /// otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. Get supported languages of this model.
        /// 
        /// The format depends on model type:
        /// 
        /// - AutoML Translation models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}`
        /// 
        /// - General (built-in) models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`,
        /// 
        /// 
        /// Returns languages supported by the specified model.
        /// If missing, we get supported languages of Google general NMT model.
        /// </param>
        /// <param name="displayLanguageCode">
        /// Optional. The language to use to return localized, human readable names
        /// of supported languages. If missing, then display names are not returned
        /// in a response.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportedLanguages GetSupportedLanguages(string parent, string model, string displayLanguageCode, gaxgrpc::CallSettings callSettings = null) =>
            GetSupportedLanguages(new GetSupportedLanguagesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DisplayLanguageCode = displayLanguageCode ?? "",
                Model = model ?? "",
            }, callSettings);

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for AutoML models.
        /// 
        /// Only models within the same region (have same location-id) can be used,
        /// otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. Get supported languages of this model.
        /// 
        /// The format depends on model type:
        /// 
        /// - AutoML Translation models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}`
        /// 
        /// - General (built-in) models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`,
        /// 
        /// 
        /// Returns languages supported by the specified model.
        /// If missing, we get supported languages of Google general NMT model.
        /// </param>
        /// <param name="displayLanguageCode">
        /// Optional. The language to use to return localized, human readable names
        /// of supported languages. If missing, then display names are not returned
        /// in a response.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportedLanguages> GetSupportedLanguagesAsync(string parent, string model, string displayLanguageCode, gaxgrpc::CallSettings callSettings = null) =>
            GetSupportedLanguagesAsync(new GetSupportedLanguagesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DisplayLanguageCode = displayLanguageCode ?? "",
                Model = model ?? "",
            }, callSettings);

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for AutoML models.
        /// 
        /// Only models within the same region (have same location-id) can be used,
        /// otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. Get supported languages of this model.
        /// 
        /// The format depends on model type:
        /// 
        /// - AutoML Translation models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}`
        /// 
        /// - General (built-in) models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`,
        /// 
        /// 
        /// Returns languages supported by the specified model.
        /// If missing, we get supported languages of Google general NMT model.
        /// </param>
        /// <param name="displayLanguageCode">
        /// Optional. The language to use to return localized, human readable names
        /// of supported languages. If missing, then display names are not returned
        /// in a response.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportedLanguages> GetSupportedLanguagesAsync(string parent, string model, string displayLanguageCode, st::CancellationToken cancellationToken) =>
            GetSupportedLanguagesAsync(parent, model, displayLanguageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for AutoML models.
        /// 
        /// Only models within the same region (have same location-id) can be used,
        /// otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. Get supported languages of this model.
        /// 
        /// The format depends on model type:
        /// 
        /// - AutoML Translation models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}`
        /// 
        /// - General (built-in) models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`,
        /// 
        /// 
        /// Returns languages supported by the specified model.
        /// If missing, we get supported languages of Google general NMT model.
        /// </param>
        /// <param name="displayLanguageCode">
        /// Optional. The language to use to return localized, human readable names
        /// of supported languages. If missing, then display names are not returned
        /// in a response.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportedLanguages GetSupportedLanguages(gagr::LocationName parent, string model, string displayLanguageCode, gaxgrpc::CallSettings callSettings = null) =>
            GetSupportedLanguages(new GetSupportedLanguagesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DisplayLanguageCode = displayLanguageCode ?? "",
                Model = model ?? "",
            }, callSettings);

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for AutoML models.
        /// 
        /// Only models within the same region (have same location-id) can be used,
        /// otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. Get supported languages of this model.
        /// 
        /// The format depends on model type:
        /// 
        /// - AutoML Translation models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}`
        /// 
        /// - General (built-in) models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`,
        /// 
        /// 
        /// Returns languages supported by the specified model.
        /// If missing, we get supported languages of Google general NMT model.
        /// </param>
        /// <param name="displayLanguageCode">
        /// Optional. The language to use to return localized, human readable names
        /// of supported languages. If missing, then display names are not returned
        /// in a response.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportedLanguages> GetSupportedLanguagesAsync(gagr::LocationName parent, string model, string displayLanguageCode, gaxgrpc::CallSettings callSettings = null) =>
            GetSupportedLanguagesAsync(new GetSupportedLanguagesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DisplayLanguageCode = displayLanguageCode ?? "",
                Model = model ?? "",
            }, callSettings);

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        /// 
        /// Format: `projects/{project-number-or-id}` or
        /// `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// For global calls, use `projects/{project-number-or-id}/locations/global` or
        /// `projects/{project-number-or-id}`.
        /// 
        /// Non-global location is required for AutoML models.
        /// 
        /// Only models within the same region (have same location-id) can be used,
        /// otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. Get supported languages of this model.
        /// 
        /// The format depends on model type:
        /// 
        /// - AutoML Translation models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/{model-id}`
        /// 
        /// - General (built-in) models:
        /// `projects/{project-number-or-id}/locations/{location-id}/models/general/nmt`,
        /// 
        /// 
        /// Returns languages supported by the specified model.
        /// If missing, we get supported languages of Google general NMT model.
        /// </param>
        /// <param name="displayLanguageCode">
        /// Optional. The language to use to return localized, human readable names
        /// of supported languages. If missing, then display names are not returned
        /// in a response.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportedLanguages> GetSupportedLanguagesAsync(gagr::LocationName parent, string model, string displayLanguageCode, st::CancellationToken cancellationToken) =>
            GetSupportedLanguagesAsync(parent, model, displayLanguageCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Translates documents in synchronous mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TranslateDocumentResponse TranslateDocument(TranslateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Translates documents in synchronous mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranslateDocumentResponse> TranslateDocumentAsync(TranslateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Translates documents in synchronous mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranslateDocumentResponse> TranslateDocumentAsync(TranslateDocumentRequest request, st::CancellationToken cancellationToken) =>
            TranslateDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Translates a large volume of text in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can
        /// use google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchTranslateResponse, BatchTranslateMetadata> BatchTranslateText(BatchTranslateTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Translates a large volume of text in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can
        /// use google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>> BatchTranslateTextAsync(BatchTranslateTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Translates a large volume of text in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can
        /// use google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>> BatchTranslateTextAsync(BatchTranslateTextRequest request, st::CancellationToken cancellationToken) =>
            BatchTranslateTextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchTranslateText</c>.</summary>
        public virtual lro::OperationsClient BatchTranslateTextOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchTranslateText</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchTranslateResponse, BatchTranslateMetadata> PollOnceBatchTranslateText(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchTranslateTextOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchTranslateText</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>> PollOnceBatchTranslateTextAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchTranslateTextOperationsClient, callSettings);

        /// <summary>
        /// Translates a large volume of document in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can use
        /// google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> BatchTranslateDocument(BatchTranslateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Translates a large volume of document in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can use
        /// google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata>> BatchTranslateDocumentAsync(BatchTranslateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Translates a large volume of document in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can use
        /// google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata>> BatchTranslateDocumentAsync(BatchTranslateDocumentRequest request, st::CancellationToken cancellationToken) =>
            BatchTranslateDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchTranslateDocument</c>.</summary>
        public virtual lro::OperationsClient BatchTranslateDocumentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchTranslateDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> PollOnceBatchTranslateDocument(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchTranslateDocumentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchTranslateDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata>> PollOnceBatchTranslateDocumentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchTranslateDocumentOperationsClient, callSettings);

        /// <summary>
        /// Translates a large volume of document in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can use
        /// google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="parent">
        /// Required. Location to make a regional call.
        /// 
        /// Format: `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// The `global` location is not supported for batch translation.
        /// 
        /// Only AutoML Translation models or glossaries within the same region (have
        /// the same location-id) can be used, otherwise an INVALID_ARGUMENT (400)
        /// error is returned.
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Required. The BCP-47 language code of the input document if known, for
        /// example, "en-US" or "sr-Latn". Supported language codes are listed in
        /// Language Support (https://cloud.google.com/translate/docs/languages).
        /// </param>
        /// <param name="targetLanguageCodes">
        /// Required. The BCP-47 language code to use for translation of the input
        /// document. Specify up to 10 language codes here.
        /// </param>
        /// <param name="inputConfigs">
        /// Required. Input configurations.
        /// The total number of files matched should be &amp;lt;= 100.
        /// The total content size to translate should be &amp;lt;= 100M Unicode codepoints.
        /// The files must use UTF-8 encoding.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Output configuration.
        /// If 2 input configs match to the same file (that is, same input path),
        /// we don't generate output for duplicate inputs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> BatchTranslateDocument(string parent, string sourceLanguageCode, scg::IEnumerable<string> targetLanguageCodes, scg::IEnumerable<BatchDocumentInputConfig> inputConfigs, BatchDocumentOutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            BatchTranslateDocument(new BatchTranslateDocumentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SourceLanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceLanguageCode, nameof(sourceLanguageCode)),
                TargetLanguageCodes =
                {
                    gax::GaxPreconditions.CheckNotNull(targetLanguageCodes, nameof(targetLanguageCodes)),
                },
                InputConfigs =
                {
                    gax::GaxPreconditions.CheckNotNull(inputConfigs, nameof(inputConfigs)),
                },
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Translates a large volume of document in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can use
        /// google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="parent">
        /// Required. Location to make a regional call.
        /// 
        /// Format: `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// The `global` location is not supported for batch translation.
        /// 
        /// Only AutoML Translation models or glossaries within the same region (have
        /// the same location-id) can be used, otherwise an INVALID_ARGUMENT (400)
        /// error is returned.
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Required. The BCP-47 language code of the input document if known, for
        /// example, "en-US" or "sr-Latn". Supported language codes are listed in
        /// Language Support (https://cloud.google.com/translate/docs/languages).
        /// </param>
        /// <param name="targetLanguageCodes">
        /// Required. The BCP-47 language code to use for translation of the input
        /// document. Specify up to 10 language codes here.
        /// </param>
        /// <param name="inputConfigs">
        /// Required. Input configurations.
        /// The total number of files matched should be &amp;lt;= 100.
        /// The total content size to translate should be &amp;lt;= 100M Unicode codepoints.
        /// The files must use UTF-8 encoding.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Output configuration.
        /// If 2 input configs match to the same file (that is, same input path),
        /// we don't generate output for duplicate inputs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata>> BatchTranslateDocumentAsync(string parent, string sourceLanguageCode, scg::IEnumerable<string> targetLanguageCodes, scg::IEnumerable<BatchDocumentInputConfig> inputConfigs, BatchDocumentOutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            BatchTranslateDocumentAsync(new BatchTranslateDocumentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SourceLanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceLanguageCode, nameof(sourceLanguageCode)),
                TargetLanguageCodes =
                {
                    gax::GaxPreconditions.CheckNotNull(targetLanguageCodes, nameof(targetLanguageCodes)),
                },
                InputConfigs =
                {
                    gax::GaxPreconditions.CheckNotNull(inputConfigs, nameof(inputConfigs)),
                },
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Translates a large volume of document in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can use
        /// google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="parent">
        /// Required. Location to make a regional call.
        /// 
        /// Format: `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// The `global` location is not supported for batch translation.
        /// 
        /// Only AutoML Translation models or glossaries within the same region (have
        /// the same location-id) can be used, otherwise an INVALID_ARGUMENT (400)
        /// error is returned.
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Required. The BCP-47 language code of the input document if known, for
        /// example, "en-US" or "sr-Latn". Supported language codes are listed in
        /// Language Support (https://cloud.google.com/translate/docs/languages).
        /// </param>
        /// <param name="targetLanguageCodes">
        /// Required. The BCP-47 language code to use for translation of the input
        /// document. Specify up to 10 language codes here.
        /// </param>
        /// <param name="inputConfigs">
        /// Required. Input configurations.
        /// The total number of files matched should be &amp;lt;= 100.
        /// The total content size to translate should be &amp;lt;= 100M Unicode codepoints.
        /// The files must use UTF-8 encoding.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Output configuration.
        /// If 2 input configs match to the same file (that is, same input path),
        /// we don't generate output for duplicate inputs.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata>> BatchTranslateDocumentAsync(string parent, string sourceLanguageCode, scg::IEnumerable<string> targetLanguageCodes, scg::IEnumerable<BatchDocumentInputConfig> inputConfigs, BatchDocumentOutputConfig outputConfig, st::CancellationToken cancellationToken) =>
            BatchTranslateDocumentAsync(parent, sourceLanguageCode, targetLanguageCodes, inputConfigs, outputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Translates a large volume of document in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can use
        /// google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="parent">
        /// Required. Location to make a regional call.
        /// 
        /// Format: `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// The `global` location is not supported for batch translation.
        /// 
        /// Only AutoML Translation models or glossaries within the same region (have
        /// the same location-id) can be used, otherwise an INVALID_ARGUMENT (400)
        /// error is returned.
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Required. The BCP-47 language code of the input document if known, for
        /// example, "en-US" or "sr-Latn". Supported language codes are listed in
        /// Language Support (https://cloud.google.com/translate/docs/languages).
        /// </param>
        /// <param name="targetLanguageCodes">
        /// Required. The BCP-47 language code to use for translation of the input
        /// document. Specify up to 10 language codes here.
        /// </param>
        /// <param name="inputConfigs">
        /// Required. Input configurations.
        /// The total number of files matched should be &amp;lt;= 100.
        /// The total content size to translate should be &amp;lt;= 100M Unicode codepoints.
        /// The files must use UTF-8 encoding.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Output configuration.
        /// If 2 input configs match to the same file (that is, same input path),
        /// we don't generate output for duplicate inputs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> BatchTranslateDocument(gagr::LocationName parent, string sourceLanguageCode, scg::IEnumerable<string> targetLanguageCodes, scg::IEnumerable<BatchDocumentInputConfig> inputConfigs, BatchDocumentOutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            BatchTranslateDocument(new BatchTranslateDocumentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SourceLanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceLanguageCode, nameof(sourceLanguageCode)),
                TargetLanguageCodes =
                {
                    gax::GaxPreconditions.CheckNotNull(targetLanguageCodes, nameof(targetLanguageCodes)),
                },
                InputConfigs =
                {
                    gax::GaxPreconditions.CheckNotNull(inputConfigs, nameof(inputConfigs)),
                },
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Translates a large volume of document in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can use
        /// google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="parent">
        /// Required. Location to make a regional call.
        /// 
        /// Format: `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// The `global` location is not supported for batch translation.
        /// 
        /// Only AutoML Translation models or glossaries within the same region (have
        /// the same location-id) can be used, otherwise an INVALID_ARGUMENT (400)
        /// error is returned.
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Required. The BCP-47 language code of the input document if known, for
        /// example, "en-US" or "sr-Latn". Supported language codes are listed in
        /// Language Support (https://cloud.google.com/translate/docs/languages).
        /// </param>
        /// <param name="targetLanguageCodes">
        /// Required. The BCP-47 language code to use for translation of the input
        /// document. Specify up to 10 language codes here.
        /// </param>
        /// <param name="inputConfigs">
        /// Required. Input configurations.
        /// The total number of files matched should be &amp;lt;= 100.
        /// The total content size to translate should be &amp;lt;= 100M Unicode codepoints.
        /// The files must use UTF-8 encoding.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Output configuration.
        /// If 2 input configs match to the same file (that is, same input path),
        /// we don't generate output for duplicate inputs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata>> BatchTranslateDocumentAsync(gagr::LocationName parent, string sourceLanguageCode, scg::IEnumerable<string> targetLanguageCodes, scg::IEnumerable<BatchDocumentInputConfig> inputConfigs, BatchDocumentOutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            BatchTranslateDocumentAsync(new BatchTranslateDocumentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SourceLanguageCode = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceLanguageCode, nameof(sourceLanguageCode)),
                TargetLanguageCodes =
                {
                    gax::GaxPreconditions.CheckNotNull(targetLanguageCodes, nameof(targetLanguageCodes)),
                },
                InputConfigs =
                {
                    gax::GaxPreconditions.CheckNotNull(inputConfigs, nameof(inputConfigs)),
                },
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Translates a large volume of document in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can use
        /// google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="parent">
        /// Required. Location to make a regional call.
        /// 
        /// Format: `projects/{project-number-or-id}/locations/{location-id}`.
        /// 
        /// The `global` location is not supported for batch translation.
        /// 
        /// Only AutoML Translation models or glossaries within the same region (have
        /// the same location-id) can be used, otherwise an INVALID_ARGUMENT (400)
        /// error is returned.
        /// </param>
        /// <param name="sourceLanguageCode">
        /// Required. The BCP-47 language code of the input document if known, for
        /// example, "en-US" or "sr-Latn". Supported language codes are listed in
        /// Language Support (https://cloud.google.com/translate/docs/languages).
        /// </param>
        /// <param name="targetLanguageCodes">
        /// Required. The BCP-47 language code to use for translation of the input
        /// document. Specify up to 10 language codes here.
        /// </param>
        /// <param name="inputConfigs">
        /// Required. Input configurations.
        /// The total number of files matched should be &amp;lt;= 100.
        /// The total content size to translate should be &amp;lt;= 100M Unicode codepoints.
        /// The files must use UTF-8 encoding.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Output configuration.
        /// If 2 input configs match to the same file (that is, same input path),
        /// we don't generate output for duplicate inputs.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata>> BatchTranslateDocumentAsync(gagr::LocationName parent, string sourceLanguageCode, scg::IEnumerable<string> targetLanguageCodes, scg::IEnumerable<BatchDocumentInputConfig> inputConfigs, BatchDocumentOutputConfig outputConfig, st::CancellationToken cancellationToken) =>
            BatchTranslateDocumentAsync(parent, sourceLanguageCode, targetLanguageCodes, inputConfigs, outputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Glossary, CreateGlossaryMetadata> CreateGlossary(CreateGlossaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> CreateGlossaryAsync(CreateGlossaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> CreateGlossaryAsync(CreateGlossaryRequest request, st::CancellationToken cancellationToken) =>
            CreateGlossaryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateGlossary</c>.</summary>
        public virtual lro::OperationsClient CreateGlossaryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateGlossary</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Glossary, CreateGlossaryMetadata> PollOnceCreateGlossary(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Glossary, CreateGlossaryMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGlossaryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateGlossary</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> PollOnceCreateGlossaryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Glossary, CreateGlossaryMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateGlossaryOperationsClient, callSettings);

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The project name.
        /// </param>
        /// <param name="glossary">
        /// Required. The glossary to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Glossary, CreateGlossaryMetadata> CreateGlossary(string parent, Glossary glossary, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossary(new CreateGlossaryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Glossary = gax::GaxPreconditions.CheckNotNull(glossary, nameof(glossary)),
            }, callSettings);

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The project name.
        /// </param>
        /// <param name="glossary">
        /// Required. The glossary to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> CreateGlossaryAsync(string parent, Glossary glossary, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossaryAsync(new CreateGlossaryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Glossary = gax::GaxPreconditions.CheckNotNull(glossary, nameof(glossary)),
            }, callSettings);

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The project name.
        /// </param>
        /// <param name="glossary">
        /// Required. The glossary to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> CreateGlossaryAsync(string parent, Glossary glossary, st::CancellationToken cancellationToken) =>
            CreateGlossaryAsync(parent, glossary, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The project name.
        /// </param>
        /// <param name="glossary">
        /// Required. The glossary to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Glossary, CreateGlossaryMetadata> CreateGlossary(gagr::LocationName parent, Glossary glossary, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossary(new CreateGlossaryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Glossary = gax::GaxPreconditions.CheckNotNull(glossary, nameof(glossary)),
            }, callSettings);

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The project name.
        /// </param>
        /// <param name="glossary">
        /// Required. The glossary to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> CreateGlossaryAsync(gagr::LocationName parent, Glossary glossary, gaxgrpc::CallSettings callSettings = null) =>
            CreateGlossaryAsync(new CreateGlossaryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Glossary = gax::GaxPreconditions.CheckNotNull(glossary, nameof(glossary)),
            }, callSettings);

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The project name.
        /// </param>
        /// <param name="glossary">
        /// Required. The glossary to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> CreateGlossaryAsync(gagr::LocationName parent, Glossary glossary, st::CancellationToken cancellationToken) =>
            CreateGlossaryAsync(parent, glossary, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Glossary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGlossariesResponse, Glossary> ListGlossaries(ListGlossariesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Glossary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossariesResponse, Glossary> ListGlossariesAsync(ListGlossariesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project from which to list all of the glossaries.
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
        /// <returns>A pageable sequence of <see cref="Glossary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGlossariesResponse, Glossary> ListGlossaries(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGlossaries(new ListGlossariesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project from which to list all of the glossaries.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Glossary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossariesResponse, Glossary> ListGlossariesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGlossariesAsync(new ListGlossariesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project from which to list all of the glossaries.
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
        /// <returns>A pageable sequence of <see cref="Glossary"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGlossariesResponse, Glossary> ListGlossaries(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGlossaries(new ListGlossariesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project from which to list all of the glossaries.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Glossary"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossariesResponse, Glossary> ListGlossariesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGlossariesAsync(new ListGlossariesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Glossary GetGlossary(GetGlossaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(GetGlossaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(GetGlossaryRequest request, st::CancellationToken cancellationToken) =>
            GetGlossaryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Glossary GetGlossary(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossary(new GetGlossaryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossaryAsync(new GetGlossaryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(string name, st::CancellationToken cancellationToken) =>
            GetGlossaryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Glossary GetGlossary(GlossaryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossary(new GetGlossaryRequest
            {
                GlossaryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(GlossaryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGlossaryAsync(new GetGlossaryRequest
            {
                GlossaryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(GlossaryName name, st::CancellationToken cancellationToken) =>
            GetGlossaryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> DeleteGlossary(DeleteGlossaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> DeleteGlossaryAsync(DeleteGlossaryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> DeleteGlossaryAsync(DeleteGlossaryRequest request, st::CancellationToken cancellationToken) =>
            DeleteGlossaryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteGlossary</c>.</summary>
        public virtual lro::OperationsClient DeleteGlossaryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteGlossary</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> PollOnceDeleteGlossary(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGlossaryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteGlossary</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> PollOnceDeleteGlossaryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteGlossaryOperationsClient, callSettings);

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> DeleteGlossary(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossary(new DeleteGlossaryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> DeleteGlossaryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossaryAsync(new DeleteGlossaryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> DeleteGlossaryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGlossaryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> DeleteGlossary(GlossaryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossary(new DeleteGlossaryRequest
            {
                GlossaryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> DeleteGlossaryAsync(GlossaryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGlossaryAsync(new DeleteGlossaryRequest
            {
                GlossaryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> DeleteGlossaryAsync(GlossaryName name, st::CancellationToken cancellationToken) =>
            DeleteGlossaryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TranslationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides natural language translation operations.
    /// </remarks>
    public sealed partial class TranslationServiceClientImpl : TranslationServiceClient
    {
        private readonly gaxgrpc::ApiCall<TranslateTextRequest, TranslateTextResponse> _callTranslateText;

        private readonly gaxgrpc::ApiCall<DetectLanguageRequest, DetectLanguageResponse> _callDetectLanguage;

        private readonly gaxgrpc::ApiCall<GetSupportedLanguagesRequest, SupportedLanguages> _callGetSupportedLanguages;

        private readonly gaxgrpc::ApiCall<TranslateDocumentRequest, TranslateDocumentResponse> _callTranslateDocument;

        private readonly gaxgrpc::ApiCall<BatchTranslateTextRequest, lro::Operation> _callBatchTranslateText;

        private readonly gaxgrpc::ApiCall<BatchTranslateDocumentRequest, lro::Operation> _callBatchTranslateDocument;

        private readonly gaxgrpc::ApiCall<CreateGlossaryRequest, lro::Operation> _callCreateGlossary;

        private readonly gaxgrpc::ApiCall<ListGlossariesRequest, ListGlossariesResponse> _callListGlossaries;

        private readonly gaxgrpc::ApiCall<GetGlossaryRequest, Glossary> _callGetGlossary;

        private readonly gaxgrpc::ApiCall<DeleteGlossaryRequest, lro::Operation> _callDeleteGlossary;

        /// <summary>
        /// Constructs a client wrapper for the TranslationService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TranslationServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TranslationServiceClientImpl(TranslationService.TranslationServiceClient grpcClient, TranslationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TranslationServiceSettings effectiveSettings = settings ?? TranslationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            BatchTranslateTextOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchTranslateTextOperationsSettings, logger);
            BatchTranslateDocumentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchTranslateDocumentOperationsSettings, logger);
            CreateGlossaryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateGlossaryOperationsSettings, logger);
            DeleteGlossaryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGlossaryOperationsSettings, logger);
            _callTranslateText = clientHelper.BuildApiCall<TranslateTextRequest, TranslateTextResponse>("TranslateText", grpcClient.TranslateTextAsync, grpcClient.TranslateText, effectiveSettings.TranslateTextSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callTranslateText);
            Modify_TranslateTextApiCall(ref _callTranslateText);
            _callDetectLanguage = clientHelper.BuildApiCall<DetectLanguageRequest, DetectLanguageResponse>("DetectLanguage", grpcClient.DetectLanguageAsync, grpcClient.DetectLanguage, effectiveSettings.DetectLanguageSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callDetectLanguage);
            Modify_DetectLanguageApiCall(ref _callDetectLanguage);
            _callGetSupportedLanguages = clientHelper.BuildApiCall<GetSupportedLanguagesRequest, SupportedLanguages>("GetSupportedLanguages", grpcClient.GetSupportedLanguagesAsync, grpcClient.GetSupportedLanguages, effectiveSettings.GetSupportedLanguagesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGetSupportedLanguages);
            Modify_GetSupportedLanguagesApiCall(ref _callGetSupportedLanguages);
            _callTranslateDocument = clientHelper.BuildApiCall<TranslateDocumentRequest, TranslateDocumentResponse>("TranslateDocument", grpcClient.TranslateDocumentAsync, grpcClient.TranslateDocument, effectiveSettings.TranslateDocumentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callTranslateDocument);
            Modify_TranslateDocumentApiCall(ref _callTranslateDocument);
            _callBatchTranslateText = clientHelper.BuildApiCall<BatchTranslateTextRequest, lro::Operation>("BatchTranslateText", grpcClient.BatchTranslateTextAsync, grpcClient.BatchTranslateText, effectiveSettings.BatchTranslateTextSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchTranslateText);
            Modify_BatchTranslateTextApiCall(ref _callBatchTranslateText);
            _callBatchTranslateDocument = clientHelper.BuildApiCall<BatchTranslateDocumentRequest, lro::Operation>("BatchTranslateDocument", grpcClient.BatchTranslateDocumentAsync, grpcClient.BatchTranslateDocument, effectiveSettings.BatchTranslateDocumentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchTranslateDocument);
            Modify_BatchTranslateDocumentApiCall(ref _callBatchTranslateDocument);
            _callCreateGlossary = clientHelper.BuildApiCall<CreateGlossaryRequest, lro::Operation>("CreateGlossary", grpcClient.CreateGlossaryAsync, grpcClient.CreateGlossary, effectiveSettings.CreateGlossarySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGlossary);
            Modify_CreateGlossaryApiCall(ref _callCreateGlossary);
            _callListGlossaries = clientHelper.BuildApiCall<ListGlossariesRequest, ListGlossariesResponse>("ListGlossaries", grpcClient.ListGlossariesAsync, grpcClient.ListGlossaries, effectiveSettings.ListGlossariesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGlossaries);
            Modify_ListGlossariesApiCall(ref _callListGlossaries);
            _callGetGlossary = clientHelper.BuildApiCall<GetGlossaryRequest, Glossary>("GetGlossary", grpcClient.GetGlossaryAsync, grpcClient.GetGlossary, effectiveSettings.GetGlossarySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGlossary);
            Modify_GetGlossaryApiCall(ref _callGetGlossary);
            _callDeleteGlossary = clientHelper.BuildApiCall<DeleteGlossaryRequest, lro::Operation>("DeleteGlossary", grpcClient.DeleteGlossaryAsync, grpcClient.DeleteGlossary, effectiveSettings.DeleteGlossarySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGlossary);
            Modify_DeleteGlossaryApiCall(ref _callDeleteGlossary);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_TranslateTextApiCall(ref gaxgrpc::ApiCall<TranslateTextRequest, TranslateTextResponse> call);

        partial void Modify_DetectLanguageApiCall(ref gaxgrpc::ApiCall<DetectLanguageRequest, DetectLanguageResponse> call);

        partial void Modify_GetSupportedLanguagesApiCall(ref gaxgrpc::ApiCall<GetSupportedLanguagesRequest, SupportedLanguages> call);

        partial void Modify_TranslateDocumentApiCall(ref gaxgrpc::ApiCall<TranslateDocumentRequest, TranslateDocumentResponse> call);

        partial void Modify_BatchTranslateTextApiCall(ref gaxgrpc::ApiCall<BatchTranslateTextRequest, lro::Operation> call);

        partial void Modify_BatchTranslateDocumentApiCall(ref gaxgrpc::ApiCall<BatchTranslateDocumentRequest, lro::Operation> call);

        partial void Modify_CreateGlossaryApiCall(ref gaxgrpc::ApiCall<CreateGlossaryRequest, lro::Operation> call);

        partial void Modify_ListGlossariesApiCall(ref gaxgrpc::ApiCall<ListGlossariesRequest, ListGlossariesResponse> call);

        partial void Modify_GetGlossaryApiCall(ref gaxgrpc::ApiCall<GetGlossaryRequest, Glossary> call);

        partial void Modify_DeleteGlossaryApiCall(ref gaxgrpc::ApiCall<DeleteGlossaryRequest, lro::Operation> call);

        partial void OnConstruction(TranslationService.TranslationServiceClient grpcClient, TranslationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TranslationService client</summary>
        public override TranslationService.TranslationServiceClient GrpcClient { get; }

        partial void Modify_TranslateTextRequest(ref TranslateTextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DetectLanguageRequest(ref DetectLanguageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSupportedLanguagesRequest(ref GetSupportedLanguagesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TranslateDocumentRequest(ref TranslateDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchTranslateTextRequest(ref BatchTranslateTextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchTranslateDocumentRequest(ref BatchTranslateDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGlossaryRequest(ref CreateGlossaryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGlossariesRequest(ref ListGlossariesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGlossaryRequest(ref GetGlossaryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGlossaryRequest(ref DeleteGlossaryRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TranslateTextResponse TranslateText(TranslateTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TranslateTextRequest(ref request, ref callSettings);
            return _callTranslateText.Sync(request, callSettings);
        }

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TranslateTextResponse> TranslateTextAsync(TranslateTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TranslateTextRequest(ref request, ref callSettings);
            return _callTranslateText.Async(request, callSettings);
        }

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DetectLanguageResponse DetectLanguage(DetectLanguageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetectLanguageRequest(ref request, ref callSettings);
            return _callDetectLanguage.Sync(request, callSettings);
        }

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DetectLanguageResponse> DetectLanguageAsync(DetectLanguageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetectLanguageRequest(ref request, ref callSettings);
            return _callDetectLanguage.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SupportedLanguages GetSupportedLanguages(GetSupportedLanguagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSupportedLanguagesRequest(ref request, ref callSettings);
            return _callGetSupportedLanguages.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SupportedLanguages> GetSupportedLanguagesAsync(GetSupportedLanguagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSupportedLanguagesRequest(ref request, ref callSettings);
            return _callGetSupportedLanguages.Async(request, callSettings);
        }

        /// <summary>
        /// Translates documents in synchronous mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TranslateDocumentResponse TranslateDocument(TranslateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TranslateDocumentRequest(ref request, ref callSettings);
            return _callTranslateDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Translates documents in synchronous mode.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TranslateDocumentResponse> TranslateDocumentAsync(TranslateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TranslateDocumentRequest(ref request, ref callSettings);
            return _callTranslateDocument.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchTranslateText</c>.</summary>
        public override lro::OperationsClient BatchTranslateTextOperationsClient { get; }

        /// <summary>
        /// Translates a large volume of text in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can
        /// use google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchTranslateResponse, BatchTranslateMetadata> BatchTranslateText(BatchTranslateTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchTranslateTextRequest(ref request, ref callSettings);
            return new lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>(_callBatchTranslateText.Sync(request, callSettings), BatchTranslateTextOperationsClient);
        }

        /// <summary>
        /// Translates a large volume of text in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can
        /// use google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>> BatchTranslateTextAsync(BatchTranslateTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchTranslateTextRequest(ref request, ref callSettings);
            return new lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>(await _callBatchTranslateText.Async(request, callSettings).ConfigureAwait(false), BatchTranslateTextOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchTranslateDocument</c>.</summary>
        public override lro::OperationsClient BatchTranslateDocumentOperationsClient { get; }

        /// <summary>
        /// Translates a large volume of document in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can use
        /// google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata> BatchTranslateDocument(BatchTranslateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchTranslateDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata>(_callBatchTranslateDocument.Sync(request, callSettings), BatchTranslateDocumentOperationsClient);
        }

        /// <summary>
        /// Translates a large volume of document in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        /// 
        /// This call returns immediately and you can use
        /// google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata>> BatchTranslateDocumentAsync(BatchTranslateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchTranslateDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<BatchTranslateDocumentResponse, BatchTranslateDocumentMetadata>(await _callBatchTranslateDocument.Async(request, callSettings).ConfigureAwait(false), BatchTranslateDocumentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateGlossary</c>.</summary>
        public override lro::OperationsClient CreateGlossaryOperationsClient { get; }

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Glossary, CreateGlossaryMetadata> CreateGlossary(CreateGlossaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGlossaryRequest(ref request, ref callSettings);
            return new lro::Operation<Glossary, CreateGlossaryMetadata>(_callCreateGlossary.Sync(request, callSettings), CreateGlossaryOperationsClient);
        }

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> CreateGlossaryAsync(CreateGlossaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGlossaryRequest(ref request, ref callSettings);
            return new lro::Operation<Glossary, CreateGlossaryMetadata>(await _callCreateGlossary.Async(request, callSettings).ConfigureAwait(false), CreateGlossaryOperationsClient);
        }

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Glossary"/> resources.</returns>
        public override gax::PagedEnumerable<ListGlossariesResponse, Glossary> ListGlossaries(ListGlossariesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlossariesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGlossariesRequest, ListGlossariesResponse, Glossary>(_callListGlossaries, request, callSettings);
        }

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Glossary"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGlossariesResponse, Glossary> ListGlossariesAsync(ListGlossariesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlossariesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGlossariesRequest, ListGlossariesResponse, Glossary>(_callListGlossaries, request, callSettings);
        }

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Glossary GetGlossary(GetGlossaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlossaryRequest(ref request, ref callSettings);
            return _callGetGlossary.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Glossary> GetGlossaryAsync(GetGlossaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlossaryRequest(ref request, ref callSettings);
            return _callGetGlossary.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteGlossary</c>.</summary>
        public override lro::OperationsClient DeleteGlossaryOperationsClient { get; }

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> DeleteGlossary(DeleteGlossaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlossaryRequest(ref request, ref callSettings);
            return new lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>(_callDeleteGlossary.Sync(request, callSettings), DeleteGlossaryOperationsClient);
        }

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> DeleteGlossaryAsync(DeleteGlossaryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlossaryRequest(ref request, ref callSettings);
            return new lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>(await _callDeleteGlossary.Async(request, callSettings).ConfigureAwait(false), DeleteGlossaryOperationsClient);
        }
    }

    public partial class ListGlossariesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGlossariesResponse : gaxgrpc::IPageResponse<Glossary>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Glossary> GetEnumerator() => Glossaries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class TranslationService
    {
        public partial class TranslationServiceClient
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
