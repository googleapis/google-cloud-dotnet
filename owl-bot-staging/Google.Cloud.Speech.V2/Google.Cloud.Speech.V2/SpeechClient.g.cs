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
using linq = System.Linq;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Speech.V2
{
    /// <summary>Settings for <see cref="SpeechClient"/> instances.</summary>
    public sealed partial class SpeechSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SpeechSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SpeechSettings"/>.</returns>
        public static SpeechSettings GetDefault() => new SpeechSettings();

        /// <summary>Constructs a new <see cref="SpeechSettings"/> object with default settings.</summary>
        public SpeechSettings()
        {
        }

        private SpeechSettings(SpeechSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateRecognizerSettings = existing.CreateRecognizerSettings;
            CreateRecognizerOperationsSettings = existing.CreateRecognizerOperationsSettings.Clone();
            ListRecognizersSettings = existing.ListRecognizersSettings;
            GetRecognizerSettings = existing.GetRecognizerSettings;
            UpdateRecognizerSettings = existing.UpdateRecognizerSettings;
            UpdateRecognizerOperationsSettings = existing.UpdateRecognizerOperationsSettings.Clone();
            DeleteRecognizerSettings = existing.DeleteRecognizerSettings;
            DeleteRecognizerOperationsSettings = existing.DeleteRecognizerOperationsSettings.Clone();
            UndeleteRecognizerSettings = existing.UndeleteRecognizerSettings;
            UndeleteRecognizerOperationsSettings = existing.UndeleteRecognizerOperationsSettings.Clone();
            RecognizeSettings = existing.RecognizeSettings;
            StreamingRecognizeSettings = existing.StreamingRecognizeSettings;
            StreamingRecognizeStreamingSettings = existing.StreamingRecognizeStreamingSettings;
            BatchRecognizeSettings = existing.BatchRecognizeSettings;
            BatchRecognizeOperationsSettings = existing.BatchRecognizeOperationsSettings.Clone();
            GetConfigSettings = existing.GetConfigSettings;
            UpdateConfigSettings = existing.UpdateConfigSettings;
            CreateCustomClassSettings = existing.CreateCustomClassSettings;
            CreateCustomClassOperationsSettings = existing.CreateCustomClassOperationsSettings.Clone();
            ListCustomClassesSettings = existing.ListCustomClassesSettings;
            GetCustomClassSettings = existing.GetCustomClassSettings;
            UpdateCustomClassSettings = existing.UpdateCustomClassSettings;
            UpdateCustomClassOperationsSettings = existing.UpdateCustomClassOperationsSettings.Clone();
            DeleteCustomClassSettings = existing.DeleteCustomClassSettings;
            DeleteCustomClassOperationsSettings = existing.DeleteCustomClassOperationsSettings.Clone();
            UndeleteCustomClassSettings = existing.UndeleteCustomClassSettings;
            UndeleteCustomClassOperationsSettings = existing.UndeleteCustomClassOperationsSettings.Clone();
            CreatePhraseSetSettings = existing.CreatePhraseSetSettings;
            CreatePhraseSetOperationsSettings = existing.CreatePhraseSetOperationsSettings.Clone();
            ListPhraseSetsSettings = existing.ListPhraseSetsSettings;
            GetPhraseSetSettings = existing.GetPhraseSetSettings;
            UpdatePhraseSetSettings = existing.UpdatePhraseSetSettings;
            UpdatePhraseSetOperationsSettings = existing.UpdatePhraseSetOperationsSettings.Clone();
            DeletePhraseSetSettings = existing.DeletePhraseSetSettings;
            DeletePhraseSetOperationsSettings = existing.DeletePhraseSetOperationsSettings.Clone();
            UndeletePhraseSetSettings = existing.UndeletePhraseSetSettings;
            UndeletePhraseSetOperationsSettings = existing.UndeletePhraseSetOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SpeechSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.CreateRecognizer</c> and <c>SpeechClient.CreateRecognizerAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRecognizerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.CreateRecognizer</c> and
        /// <c>SpeechClient.CreateRecognizerAsync</c>.
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
        public lro::OperationsSettings CreateRecognizerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.ListRecognizers</c> and <c>SpeechClient.ListRecognizersAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRecognizersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpeechClient.GetRecognizer</c>
        ///  and <c>SpeechClient.GetRecognizerAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRecognizerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.UpdateRecognizer</c> and <c>SpeechClient.UpdateRecognizerAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRecognizerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.UpdateRecognizer</c> and
        /// <c>SpeechClient.UpdateRecognizerAsync</c>.
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
        public lro::OperationsSettings UpdateRecognizerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.DeleteRecognizer</c> and <c>SpeechClient.DeleteRecognizerAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRecognizerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.DeleteRecognizer</c> and
        /// <c>SpeechClient.DeleteRecognizerAsync</c>.
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
        public lro::OperationsSettings DeleteRecognizerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.UndeleteRecognizer</c> and <c>SpeechClient.UndeleteRecognizerAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeleteRecognizerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.UndeleteRecognizer</c> and
        /// <c>SpeechClient.UndeleteRecognizerAsync</c>.
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
        public lro::OperationsSettings UndeleteRecognizerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpeechClient.Recognize</c>
        /// and <c>SpeechClient.RecognizeAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RecognizeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.StreamingRecognize</c> and <c>SpeechClient.StreamingRecognizeAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 5000 seconds.</remarks>
        public gaxgrpc::CallSettings StreamingRecognizeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>SpeechClient.StreamingRecognize</c>
        /// and <c>SpeechClient.StreamingRecognizeAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamingRecognizeStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpeechClient.BatchRecognize</c>
        ///  and <c>SpeechClient.BatchRecognizeAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchRecognizeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.BatchRecognize</c> and
        /// <c>SpeechClient.BatchRecognizeAsync</c>.
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
        public lro::OperationsSettings BatchRecognizeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpeechClient.GetConfig</c>
        /// and <c>SpeechClient.GetConfigAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpeechClient.UpdateConfig</c>
        ///  and <c>SpeechClient.UpdateConfigAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.CreateCustomClass</c> and <c>SpeechClient.CreateCustomClassAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCustomClassSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.CreateCustomClass</c> and
        /// <c>SpeechClient.CreateCustomClassAsync</c>.
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
        public lro::OperationsSettings CreateCustomClassOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.ListCustomClasses</c> and <c>SpeechClient.ListCustomClassesAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCustomClassesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpeechClient.GetCustomClass</c>
        ///  and <c>SpeechClient.GetCustomClassAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomClassSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.UpdateCustomClass</c> and <c>SpeechClient.UpdateCustomClassAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCustomClassSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.UpdateCustomClass</c> and
        /// <c>SpeechClient.UpdateCustomClassAsync</c>.
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
        public lro::OperationsSettings UpdateCustomClassOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.DeleteCustomClass</c> and <c>SpeechClient.DeleteCustomClassAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCustomClassSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.DeleteCustomClass</c> and
        /// <c>SpeechClient.DeleteCustomClassAsync</c>.
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
        public lro::OperationsSettings DeleteCustomClassOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.UndeleteCustomClass</c> and <c>SpeechClient.UndeleteCustomClassAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeleteCustomClassSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.UndeleteCustomClass</c> and
        /// <c>SpeechClient.UndeleteCustomClassAsync</c>.
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
        public lro::OperationsSettings UndeleteCustomClassOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.CreatePhraseSet</c> and <c>SpeechClient.CreatePhraseSetAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePhraseSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.CreatePhraseSet</c> and
        /// <c>SpeechClient.CreatePhraseSetAsync</c>.
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
        public lro::OperationsSettings CreatePhraseSetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpeechClient.ListPhraseSets</c>
        ///  and <c>SpeechClient.ListPhraseSetsAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPhraseSetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>SpeechClient.GetPhraseSet</c>
        ///  and <c>SpeechClient.GetPhraseSetAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPhraseSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.UpdatePhraseSet</c> and <c>SpeechClient.UpdatePhraseSetAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePhraseSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.UpdatePhraseSet</c> and
        /// <c>SpeechClient.UpdatePhraseSetAsync</c>.
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
        public lro::OperationsSettings UpdatePhraseSetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.DeletePhraseSet</c> and <c>SpeechClient.DeletePhraseSetAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePhraseSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.DeletePhraseSet</c> and
        /// <c>SpeechClient.DeletePhraseSetAsync</c>.
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
        public lro::OperationsSettings DeletePhraseSetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SpeechClient.UndeletePhraseSet</c> and <c>SpeechClient.UndeletePhraseSetAsync</c>.
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
        /// <item><description>Timeout: 5000 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeletePhraseSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SpeechClient.UndeletePhraseSet</c> and
        /// <c>SpeechClient.UndeletePhraseSetAsync</c>.
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
        public lro::OperationsSettings UndeletePhraseSetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SpeechSettings"/> object.</returns>
        public SpeechSettings Clone() => new SpeechSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SpeechClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class SpeechClientBuilder : gaxgrpc::ClientBuilderBase<SpeechClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SpeechSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SpeechClientBuilder() : base(SpeechClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SpeechClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SpeechClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SpeechClient Build()
        {
            SpeechClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SpeechClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SpeechClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SpeechClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SpeechClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SpeechClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SpeechClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SpeechClient.ChannelPool;
    }

    /// <summary>Speech client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Enables speech transcription and resource management.
    /// </remarks>
    public abstract partial class SpeechClient
    {
        /// <summary>
        /// The default endpoint for the Speech service, which is a host of "speech.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "speech.googleapis.com:443";

        /// <summary>The default Speech scopes.</summary>
        /// <remarks>
        /// The default Speech scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Speech.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SpeechClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="SpeechClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SpeechClient"/>.</returns>
        public static stt::Task<SpeechClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SpeechClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SpeechClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="SpeechClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SpeechClient"/>.</returns>
        public static SpeechClient Create() => new SpeechClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SpeechClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SpeechSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SpeechClient"/>.</returns>
        internal static SpeechClient Create(grpccore::CallInvoker callInvoker, SpeechSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Speech.SpeechClient grpcClient = new Speech.SpeechClient(callInvoker);
            return new SpeechClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Speech client</summary>
        public virtual Speech.SpeechClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> CreateRecognizer(CreateRecognizerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> CreateRecognizerAsync(CreateRecognizerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> CreateRecognizerAsync(CreateRecognizerRequest request, st::CancellationToken cancellationToken) =>
            CreateRecognizerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRecognizer</c>.</summary>
        public virtual lro::OperationsClient CreateRecognizerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRecognizer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> PollOnceCreateRecognizer(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Recognizer, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRecognizerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRecognizer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> PollOnceCreateRecognizerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Recognizer, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRecognizerOperationsClient, callSettings);

        /// <summary>
        /// Creates a [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this Recognizer will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="recognizer">
        /// Required. The Recognizer to create.
        /// </param>
        /// <param name="recognizerId">
        /// The ID to use for the Recognizer, which will become the final component of
        /// the Recognizer's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> CreateRecognizer(string parent, Recognizer recognizer, string recognizerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRecognizer(new CreateRecognizerRequest
            {
                Recognizer = gax::GaxPreconditions.CheckNotNull(recognizer, nameof(recognizer)),
                RecognizerId = recognizerId ?? "",
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this Recognizer will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="recognizer">
        /// Required. The Recognizer to create.
        /// </param>
        /// <param name="recognizerId">
        /// The ID to use for the Recognizer, which will become the final component of
        /// the Recognizer's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> CreateRecognizerAsync(string parent, Recognizer recognizer, string recognizerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRecognizerAsync(new CreateRecognizerRequest
            {
                Recognizer = gax::GaxPreconditions.CheckNotNull(recognizer, nameof(recognizer)),
                RecognizerId = recognizerId ?? "",
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this Recognizer will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="recognizer">
        /// Required. The Recognizer to create.
        /// </param>
        /// <param name="recognizerId">
        /// The ID to use for the Recognizer, which will become the final component of
        /// the Recognizer's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> CreateRecognizerAsync(string parent, Recognizer recognizer, string recognizerId, st::CancellationToken cancellationToken) =>
            CreateRecognizerAsync(parent, recognizer, recognizerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this Recognizer will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="recognizer">
        /// Required. The Recognizer to create.
        /// </param>
        /// <param name="recognizerId">
        /// The ID to use for the Recognizer, which will become the final component of
        /// the Recognizer's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> CreateRecognizer(gagr::LocationName parent, Recognizer recognizer, string recognizerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRecognizer(new CreateRecognizerRequest
            {
                Recognizer = gax::GaxPreconditions.CheckNotNull(recognizer, nameof(recognizer)),
                RecognizerId = recognizerId ?? "",
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this Recognizer will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="recognizer">
        /// Required. The Recognizer to create.
        /// </param>
        /// <param name="recognizerId">
        /// The ID to use for the Recognizer, which will become the final component of
        /// the Recognizer's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> CreateRecognizerAsync(gagr::LocationName parent, Recognizer recognizer, string recognizerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRecognizerAsync(new CreateRecognizerRequest
            {
                Recognizer = gax::GaxPreconditions.CheckNotNull(recognizer, nameof(recognizer)),
                RecognizerId = recognizerId ?? "",
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this Recognizer will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="recognizer">
        /// Required. The Recognizer to create.
        /// </param>
        /// <param name="recognizerId">
        /// The ID to use for the Recognizer, which will become the final component of
        /// the Recognizer's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> CreateRecognizerAsync(gagr::LocationName parent, Recognizer recognizer, string recognizerId, st::CancellationToken cancellationToken) =>
            CreateRecognizerAsync(parent, recognizer, recognizerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Recognizers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Recognizer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecognizersResponse, Recognizer> ListRecognizers(ListRecognizersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Recognizers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Recognizer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecognizersResponse, Recognizer> ListRecognizersAsync(ListRecognizersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Recognizers.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of Recognizers to list. The expected
        /// format is `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Recognizer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecognizersResponse, Recognizer> ListRecognizers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecognizersRequest request = new ListRecognizersRequest
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
            return ListRecognizers(request, callSettings);
        }

        /// <summary>
        /// Lists Recognizers.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of Recognizers to list. The expected
        /// format is `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Recognizer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecognizersResponse, Recognizer> ListRecognizersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecognizersRequest request = new ListRecognizersRequest
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
            return ListRecognizersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Recognizers.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of Recognizers to list. The expected
        /// format is `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Recognizer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecognizersResponse, Recognizer> ListRecognizers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecognizersRequest request = new ListRecognizersRequest
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
            return ListRecognizers(request, callSettings);
        }

        /// <summary>
        /// Lists Recognizers.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of Recognizers to list. The expected
        /// format is `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Recognizer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecognizersResponse, Recognizer> ListRecognizersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecognizersRequest request = new ListRecognizersRequest
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
            return ListRecognizersAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested
        /// [Recognizer][google.cloud.speech.v2.Recognizer]. Fails with
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested Recognizer doesn't
        /// exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recognizer GetRecognizer(GetRecognizerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested
        /// [Recognizer][google.cloud.speech.v2.Recognizer]. Fails with
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested Recognizer doesn't
        /// exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recognizer> GetRecognizerAsync(GetRecognizerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested
        /// [Recognizer][google.cloud.speech.v2.Recognizer]. Fails with
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested Recognizer doesn't
        /// exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recognizer> GetRecognizerAsync(GetRecognizerRequest request, st::CancellationToken cancellationToken) =>
            GetRecognizerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested
        /// [Recognizer][google.cloud.speech.v2.Recognizer]. Fails with
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested Recognizer doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recognizer GetRecognizer(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecognizer(new GetRecognizerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested
        /// [Recognizer][google.cloud.speech.v2.Recognizer]. Fails with
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested Recognizer doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recognizer> GetRecognizerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecognizerAsync(new GetRecognizerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested
        /// [Recognizer][google.cloud.speech.v2.Recognizer]. Fails with
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested Recognizer doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recognizer> GetRecognizerAsync(string name, st::CancellationToken cancellationToken) =>
            GetRecognizerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested
        /// [Recognizer][google.cloud.speech.v2.Recognizer]. Fails with
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested Recognizer doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recognizer GetRecognizer(RecognizerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecognizer(new GetRecognizerRequest
            {
                RecognizerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested
        /// [Recognizer][google.cloud.speech.v2.Recognizer]. Fails with
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested Recognizer doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recognizer> GetRecognizerAsync(RecognizerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecognizerAsync(new GetRecognizerRequest
            {
                RecognizerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested
        /// [Recognizer][google.cloud.speech.v2.Recognizer]. Fails with
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested Recognizer doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recognizer> GetRecognizerAsync(RecognizerName name, st::CancellationToken cancellationToken) =>
            GetRecognizerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> UpdateRecognizer(UpdateRecognizerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> UpdateRecognizerAsync(UpdateRecognizerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> UpdateRecognizerAsync(UpdateRecognizerRequest request, st::CancellationToken cancellationToken) =>
            UpdateRecognizerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateRecognizer</c>.</summary>
        public virtual lro::OperationsClient UpdateRecognizerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateRecognizer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> PollOnceUpdateRecognizer(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Recognizer, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRecognizerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateRecognizer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> PollOnceUpdateRecognizerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Recognizer, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRecognizerOperationsClient, callSettings);

        /// <summary>
        /// Updates the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="recognizer">
        /// Required. The Recognizer to update.
        /// 
        /// The Recognizer's `name` field is used to identify the Recognizer to update.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If empty, all non-default valued fields are
        /// considered for update. Use `*` to update the entire Recognizer resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> UpdateRecognizer(Recognizer recognizer, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRecognizer(new UpdateRecognizerRequest
            {
                Recognizer = gax::GaxPreconditions.CheckNotNull(recognizer, nameof(recognizer)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="recognizer">
        /// Required. The Recognizer to update.
        /// 
        /// The Recognizer's `name` field is used to identify the Recognizer to update.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If empty, all non-default valued fields are
        /// considered for update. Use `*` to update the entire Recognizer resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> UpdateRecognizerAsync(Recognizer recognizer, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRecognizerAsync(new UpdateRecognizerRequest
            {
                Recognizer = gax::GaxPreconditions.CheckNotNull(recognizer, nameof(recognizer)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="recognizer">
        /// Required. The Recognizer to update.
        /// 
        /// The Recognizer's `name` field is used to identify the Recognizer to update.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If empty, all non-default valued fields are
        /// considered for update. Use `*` to update the entire Recognizer resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> UpdateRecognizerAsync(Recognizer recognizer, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRecognizerAsync(recognizer, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> DeleteRecognizer(DeleteRecognizerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> DeleteRecognizerAsync(DeleteRecognizerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> DeleteRecognizerAsync(DeleteRecognizerRequest request, st::CancellationToken cancellationToken) =>
            DeleteRecognizerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRecognizer</c>.</summary>
        public virtual lro::OperationsClient DeleteRecognizerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRecognizer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> PollOnceDeleteRecognizer(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Recognizer, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRecognizerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRecognizer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> PollOnceDeleteRecognizerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Recognizer, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRecognizerOperationsClient, callSettings);

        /// <summary>
        /// Deletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to delete.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> DeleteRecognizer(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRecognizer(new DeleteRecognizerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to delete.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> DeleteRecognizerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRecognizerAsync(new DeleteRecognizerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to delete.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> DeleteRecognizerAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRecognizerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to delete.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> DeleteRecognizer(RecognizerName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRecognizer(new DeleteRecognizerRequest
            {
                RecognizerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to delete.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> DeleteRecognizerAsync(RecognizerName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRecognizerAsync(new DeleteRecognizerRequest
            {
                RecognizerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to delete.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> DeleteRecognizerAsync(RecognizerName name, st::CancellationToken cancellationToken) =>
            DeleteRecognizerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> UndeleteRecognizer(UndeleteRecognizerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> UndeleteRecognizerAsync(UndeleteRecognizerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> UndeleteRecognizerAsync(UndeleteRecognizerRequest request, st::CancellationToken cancellationToken) =>
            UndeleteRecognizerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeleteRecognizer</c>.</summary>
        public virtual lro::OperationsClient UndeleteRecognizerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeleteRecognizer</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> PollOnceUndeleteRecognizer(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Recognizer, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteRecognizerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeleteRecognizer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> PollOnceUndeleteRecognizerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Recognizer, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteRecognizerOperationsClient, callSettings);

        /// <summary>
        /// Undeletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to undelete.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> UndeleteRecognizer(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteRecognizer(new UndeleteRecognizerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to undelete.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> UndeleteRecognizerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteRecognizerAsync(new UndeleteRecognizerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to undelete.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> UndeleteRecognizerAsync(string name, st::CancellationToken cancellationToken) =>
            UndeleteRecognizerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to undelete.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Recognizer, OperationMetadata> UndeleteRecognizer(RecognizerName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteRecognizer(new UndeleteRecognizerRequest
            {
                RecognizerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to undelete.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> UndeleteRecognizerAsync(RecognizerName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteRecognizerAsync(new UndeleteRecognizerRequest
            {
                RecognizerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Recognizer to undelete.
        /// Format: `projects/{project}/locations/{location}/recognizers/{recognizer}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Recognizer, OperationMetadata>> UndeleteRecognizerAsync(RecognizerName name, st::CancellationToken cancellationToken) =>
            UndeleteRecognizerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RecognizeResponse Recognize(RecognizeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(RecognizeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(RecognizeRequest request, st::CancellationToken cancellationToken) =>
            RecognizeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.RecognizeRequest.config_mask] field
        /// can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] that override the
        /// values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all non-default valued fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="content">
        /// The audio data bytes encoded as specified in
        /// [RecognitionConfig][google.cloud.speech.v2.RecognitionConfig]. As
        /// with all bytes fields, proto buffers use a pure binary representation,
        /// whereas JSON representations use base64.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RecognizeResponse Recognize(string recognizer, RecognitionConfig config, wkt::FieldMask configMask, proto::ByteString content, gaxgrpc::CallSettings callSettings = null) =>
            Recognize(new RecognizeRequest
            {
                Recognizer = gax::GaxPreconditions.CheckNotNullOrEmpty(recognizer, nameof(recognizer)),
                Config = config,
                ConfigMask = configMask,
                Content = content ?? proto::ByteString.Empty,
            }, callSettings);

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.RecognizeRequest.config_mask] field
        /// can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] that override the
        /// values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all non-default valued fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="content">
        /// The audio data bytes encoded as specified in
        /// [RecognitionConfig][google.cloud.speech.v2.RecognitionConfig]. As
        /// with all bytes fields, proto buffers use a pure binary representation,
        /// whereas JSON representations use base64.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(string recognizer, RecognitionConfig config, wkt::FieldMask configMask, proto::ByteString content, gaxgrpc::CallSettings callSettings = null) =>
            RecognizeAsync(new RecognizeRequest
            {
                Recognizer = gax::GaxPreconditions.CheckNotNullOrEmpty(recognizer, nameof(recognizer)),
                Config = config,
                ConfigMask = configMask,
                Content = content ?? proto::ByteString.Empty,
            }, callSettings);

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.RecognizeRequest.config_mask] field
        /// can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] that override the
        /// values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all non-default valued fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="content">
        /// The audio data bytes encoded as specified in
        /// [RecognitionConfig][google.cloud.speech.v2.RecognitionConfig]. As
        /// with all bytes fields, proto buffers use a pure binary representation,
        /// whereas JSON representations use base64.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(string recognizer, RecognitionConfig config, wkt::FieldMask configMask, proto::ByteString content, st::CancellationToken cancellationToken) =>
            RecognizeAsync(recognizer, config, configMask, content, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.RecognizeRequest.config_mask] field
        /// can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] that override the
        /// values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all non-default valued fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="content">
        /// The audio data bytes encoded as specified in
        /// [RecognitionConfig][google.cloud.speech.v2.RecognitionConfig]. As
        /// with all bytes fields, proto buffers use a pure binary representation,
        /// whereas JSON representations use base64.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RecognizeResponse Recognize(RecognizerName recognizer, RecognitionConfig config, wkt::FieldMask configMask, proto::ByteString content, gaxgrpc::CallSettings callSettings = null) =>
            Recognize(new RecognizeRequest
            {
                RecognizerAsRecognizerName = gax::GaxPreconditions.CheckNotNull(recognizer, nameof(recognizer)),
                Config = config,
                ConfigMask = configMask,
                Content = content ?? proto::ByteString.Empty,
            }, callSettings);

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.RecognizeRequest.config_mask] field
        /// can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] that override the
        /// values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all non-default valued fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="content">
        /// The audio data bytes encoded as specified in
        /// [RecognitionConfig][google.cloud.speech.v2.RecognitionConfig]. As
        /// with all bytes fields, proto buffers use a pure binary representation,
        /// whereas JSON representations use base64.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(RecognizerName recognizer, RecognitionConfig config, wkt::FieldMask configMask, proto::ByteString content, gaxgrpc::CallSettings callSettings = null) =>
            RecognizeAsync(new RecognizeRequest
            {
                RecognizerAsRecognizerName = gax::GaxPreconditions.CheckNotNull(recognizer, nameof(recognizer)),
                Config = config,
                ConfigMask = configMask,
                Content = content ?? proto::ByteString.Empty,
            }, callSettings);

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.RecognizeRequest.config_mask] field
        /// can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] that override the
        /// values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all non-default valued fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="content">
        /// The audio data bytes encoded as specified in
        /// [RecognitionConfig][google.cloud.speech.v2.RecognitionConfig]. As
        /// with all bytes fields, proto buffers use a pure binary representation,
        /// whereas JSON representations use base64.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(RecognizerName recognizer, RecognitionConfig config, wkt::FieldMask configMask, proto::ByteString content, st::CancellationToken cancellationToken) =>
            RecognizeAsync(recognizer, config, configMask, content, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.RecognizeRequest.config_mask] field
        /// can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] that override the
        /// values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all non-default valued fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="uri">
        /// URI that points to a file that contains audio data bytes as specified in
        /// [RecognitionConfig][google.cloud.speech.v2.RecognitionConfig]. The file
        /// must not be compressed (for example, gzip). Currently, only Google Cloud
        /// Storage URIs are supported, which must be specified in the following
        /// format: `gs://bucket_name/object_name` (other URI formats return
        /// [INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT]). For more
        /// information, see [Request
        /// URIs](https://cloud.google.com/storage/docs/reference-uris).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RecognizeResponse Recognize(string recognizer, RecognitionConfig config, wkt::FieldMask configMask, string uri, gaxgrpc::CallSettings callSettings = null) =>
            Recognize(new RecognizeRequest
            {
                Recognizer = gax::GaxPreconditions.CheckNotNullOrEmpty(recognizer, nameof(recognizer)),
                Config = config,
                ConfigMask = configMask,
                Uri = uri ?? "",
            }, callSettings);

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.RecognizeRequest.config_mask] field
        /// can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] that override the
        /// values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all non-default valued fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="uri">
        /// URI that points to a file that contains audio data bytes as specified in
        /// [RecognitionConfig][google.cloud.speech.v2.RecognitionConfig]. The file
        /// must not be compressed (for example, gzip). Currently, only Google Cloud
        /// Storage URIs are supported, which must be specified in the following
        /// format: `gs://bucket_name/object_name` (other URI formats return
        /// [INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT]). For more
        /// information, see [Request
        /// URIs](https://cloud.google.com/storage/docs/reference-uris).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(string recognizer, RecognitionConfig config, wkt::FieldMask configMask, string uri, gaxgrpc::CallSettings callSettings = null) =>
            RecognizeAsync(new RecognizeRequest
            {
                Recognizer = gax::GaxPreconditions.CheckNotNullOrEmpty(recognizer, nameof(recognizer)),
                Config = config,
                ConfigMask = configMask,
                Uri = uri ?? "",
            }, callSettings);

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.RecognizeRequest.config_mask] field
        /// can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] that override the
        /// values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all non-default valued fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="uri">
        /// URI that points to a file that contains audio data bytes as specified in
        /// [RecognitionConfig][google.cloud.speech.v2.RecognitionConfig]. The file
        /// must not be compressed (for example, gzip). Currently, only Google Cloud
        /// Storage URIs are supported, which must be specified in the following
        /// format: `gs://bucket_name/object_name` (other URI formats return
        /// [INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT]). For more
        /// information, see [Request
        /// URIs](https://cloud.google.com/storage/docs/reference-uris).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(string recognizer, RecognitionConfig config, wkt::FieldMask configMask, string uri, st::CancellationToken cancellationToken) =>
            RecognizeAsync(recognizer, config, configMask, uri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.RecognizeRequest.config_mask] field
        /// can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] that override the
        /// values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all non-default valued fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="uri">
        /// URI that points to a file that contains audio data bytes as specified in
        /// [RecognitionConfig][google.cloud.speech.v2.RecognitionConfig]. The file
        /// must not be compressed (for example, gzip). Currently, only Google Cloud
        /// Storage URIs are supported, which must be specified in the following
        /// format: `gs://bucket_name/object_name` (other URI formats return
        /// [INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT]). For more
        /// information, see [Request
        /// URIs](https://cloud.google.com/storage/docs/reference-uris).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RecognizeResponse Recognize(RecognizerName recognizer, RecognitionConfig config, wkt::FieldMask configMask, string uri, gaxgrpc::CallSettings callSettings = null) =>
            Recognize(new RecognizeRequest
            {
                RecognizerAsRecognizerName = gax::GaxPreconditions.CheckNotNull(recognizer, nameof(recognizer)),
                Config = config,
                ConfigMask = configMask,
                Uri = uri ?? "",
            }, callSettings);

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.RecognizeRequest.config_mask] field
        /// can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] that override the
        /// values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all non-default valued fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="uri">
        /// URI that points to a file that contains audio data bytes as specified in
        /// [RecognitionConfig][google.cloud.speech.v2.RecognitionConfig]. The file
        /// must not be compressed (for example, gzip). Currently, only Google Cloud
        /// Storage URIs are supported, which must be specified in the following
        /// format: `gs://bucket_name/object_name` (other URI formats return
        /// [INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT]). For more
        /// information, see [Request
        /// URIs](https://cloud.google.com/storage/docs/reference-uris).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(RecognizerName recognizer, RecognitionConfig config, wkt::FieldMask configMask, string uri, gaxgrpc::CallSettings callSettings = null) =>
            RecognizeAsync(new RecognizeRequest
            {
                RecognizerAsRecognizerName = gax::GaxPreconditions.CheckNotNull(recognizer, nameof(recognizer)),
                Config = config,
                ConfigMask = configMask,
                Uri = uri ?? "",
            }, callSettings);

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.RecognizeRequest.config_mask] field
        /// can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] that override the
        /// values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all non-default valued fields in
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.RecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="uri">
        /// URI that points to a file that contains audio data bytes as specified in
        /// [RecognitionConfig][google.cloud.speech.v2.RecognitionConfig]. The file
        /// must not be compressed (for example, gzip). Currently, only Google Cloud
        /// Storage URIs are supported, which must be specified in the following
        /// format: `gs://bucket_name/object_name` (other URI formats return
        /// [INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT]). For more
        /// information, see [Request
        /// URIs](https://cloud.google.com/storage/docs/reference-uris).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RecognizeResponse> RecognizeAsync(RecognizerName recognizer, RecognitionConfig config, wkt::FieldMask configMask, string uri, st::CancellationToken cancellationToken) =>
            RecognizeAsync(recognizer, config, configMask, uri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamingRecognize(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamingRecognizeStream : gaxgrpc::BidirectionalStreamingBase<StreamingRecognizeRequest, StreamingRecognizeResponse>
        {
        }

        /// <summary>
        /// Performs bidirectional streaming speech recognition: receive results while
        /// sending audio. This method is only available via the gRPC API (not REST).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamingRecognizeStream StreamingRecognize(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs batch asynchronous speech recognition: send a request with N
        /// audio files and receive a long running operation that can be polled to see
        /// when the transcriptions are finished.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchRecognizeResponse, OperationMetadata> BatchRecognize(BatchRecognizeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs batch asynchronous speech recognition: send a request with N
        /// audio files and receive a long running operation that can be polled to see
        /// when the transcriptions are finished.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchRecognizeResponse, OperationMetadata>> BatchRecognizeAsync(BatchRecognizeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs batch asynchronous speech recognition: send a request with N
        /// audio files and receive a long running operation that can be polled to see
        /// when the transcriptions are finished.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchRecognizeResponse, OperationMetadata>> BatchRecognizeAsync(BatchRecognizeRequest request, st::CancellationToken cancellationToken) =>
            BatchRecognizeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchRecognize</c>.</summary>
        public virtual lro::OperationsClient BatchRecognizeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchRecognize</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchRecognizeResponse, OperationMetadata> PollOnceBatchRecognize(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchRecognizeResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchRecognizeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchRecognize</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchRecognizeResponse, OperationMetadata>> PollOnceBatchRecognizeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchRecognizeResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchRecognizeOperationsClient, callSettings);

        /// <summary>
        /// Performs batch asynchronous speech recognition: send a request with N
        /// audio files and receive a long running operation that can be polled to see
        /// when the transcriptions are finished.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.BatchRecognizeRequest.config_mask]
        /// field can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] that override
        /// the values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all given fields in
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="files">
        /// Audio files with file metadata for ASR.
        /// The maximum number of files allowed to be specified is 15.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchRecognizeResponse, OperationMetadata> BatchRecognize(string recognizer, RecognitionConfig config, wkt::FieldMask configMask, scg::IEnumerable<BatchRecognizeFileMetadata> files, gaxgrpc::CallSettings callSettings = null) =>
            BatchRecognize(new BatchRecognizeRequest
            {
                Recognizer = gax::GaxPreconditions.CheckNotNullOrEmpty(recognizer, nameof(recognizer)),
                Config = config,
                ConfigMask = configMask,
                Files =
                {
                    files ?? linq::Enumerable.Empty<BatchRecognizeFileMetadata>(),
                },
            }, callSettings);

        /// <summary>
        /// Performs batch asynchronous speech recognition: send a request with N
        /// audio files and receive a long running operation that can be polled to see
        /// when the transcriptions are finished.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.BatchRecognizeRequest.config_mask]
        /// field can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] that override
        /// the values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all given fields in
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="files">
        /// Audio files with file metadata for ASR.
        /// The maximum number of files allowed to be specified is 15.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchRecognizeResponse, OperationMetadata>> BatchRecognizeAsync(string recognizer, RecognitionConfig config, wkt::FieldMask configMask, scg::IEnumerable<BatchRecognizeFileMetadata> files, gaxgrpc::CallSettings callSettings = null) =>
            BatchRecognizeAsync(new BatchRecognizeRequest
            {
                Recognizer = gax::GaxPreconditions.CheckNotNullOrEmpty(recognizer, nameof(recognizer)),
                Config = config,
                ConfigMask = configMask,
                Files =
                {
                    files ?? linq::Enumerable.Empty<BatchRecognizeFileMetadata>(),
                },
            }, callSettings);

        /// <summary>
        /// Performs batch asynchronous speech recognition: send a request with N
        /// audio files and receive a long running operation that can be polled to see
        /// when the transcriptions are finished.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.BatchRecognizeRequest.config_mask]
        /// field can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] that override
        /// the values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all given fields in
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="files">
        /// Audio files with file metadata for ASR.
        /// The maximum number of files allowed to be specified is 15.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchRecognizeResponse, OperationMetadata>> BatchRecognizeAsync(string recognizer, RecognitionConfig config, wkt::FieldMask configMask, scg::IEnumerable<BatchRecognizeFileMetadata> files, st::CancellationToken cancellationToken) =>
            BatchRecognizeAsync(recognizer, config, configMask, files, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs batch asynchronous speech recognition: send a request with N
        /// audio files and receive a long running operation that can be polled to see
        /// when the transcriptions are finished.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.BatchRecognizeRequest.config_mask]
        /// field can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] that override
        /// the values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all given fields in
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="files">
        /// Audio files with file metadata for ASR.
        /// The maximum number of files allowed to be specified is 15.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchRecognizeResponse, OperationMetadata> BatchRecognize(RecognizerName recognizer, RecognitionConfig config, wkt::FieldMask configMask, scg::IEnumerable<BatchRecognizeFileMetadata> files, gaxgrpc::CallSettings callSettings = null) =>
            BatchRecognize(new BatchRecognizeRequest
            {
                RecognizerAsRecognizerName = gax::GaxPreconditions.CheckNotNull(recognizer, nameof(recognizer)),
                Config = config,
                ConfigMask = configMask,
                Files =
                {
                    files ?? linq::Enumerable.Empty<BatchRecognizeFileMetadata>(),
                },
            }, callSettings);

        /// <summary>
        /// Performs batch asynchronous speech recognition: send a request with N
        /// audio files and receive a long running operation that can be polled to see
        /// when the transcriptions are finished.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.BatchRecognizeRequest.config_mask]
        /// field can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] that override
        /// the values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all given fields in
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="files">
        /// Audio files with file metadata for ASR.
        /// The maximum number of files allowed to be specified is 15.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchRecognizeResponse, OperationMetadata>> BatchRecognizeAsync(RecognizerName recognizer, RecognitionConfig config, wkt::FieldMask configMask, scg::IEnumerable<BatchRecognizeFileMetadata> files, gaxgrpc::CallSettings callSettings = null) =>
            BatchRecognizeAsync(new BatchRecognizeRequest
            {
                RecognizerAsRecognizerName = gax::GaxPreconditions.CheckNotNull(recognizer, nameof(recognizer)),
                Config = config,
                ConfigMask = configMask,
                Files =
                {
                    files ?? linq::Enumerable.Empty<BatchRecognizeFileMetadata>(),
                },
            }, callSettings);

        /// <summary>
        /// Performs batch asynchronous speech recognition: send a request with N
        /// audio files and receive a long running operation that can be polled to see
        /// when the transcriptions are finished.
        /// </summary>
        /// <param name="recognizer">
        /// Required. The name of the Recognizer to use during recognition. The
        /// expected format is
        /// `projects/{project}/locations/{location}/recognizers/{recognizer}`. The
        /// {recognizer} segment may be set to `_` to use an empty implicit Recognizer.
        /// </param>
        /// <param name="config">
        /// Features and audio metadata to use for the Automatic Speech Recognition.
        /// This field in combination with the
        /// [config_mask][google.cloud.speech.v2.BatchRecognizeRequest.config_mask]
        /// field can be used to override parts of the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the Recognizer resource.
        /// </param>
        /// <param name="configMask">
        /// The list of fields in
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] that override
        /// the values in the
        /// [default_recognition_config][google.cloud.speech.v2.Recognizer.default_recognition_config]
        /// of the recognizer during this recognition request. If no mask is provided,
        /// all given fields in
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] override the
        /// values in the recognizer for this recognition request. If a mask is
        /// provided, only the fields listed in the mask override the config in the
        /// recognizer for this recognition request. If a wildcard (`*`) is provided,
        /// [config][google.cloud.speech.v2.BatchRecognizeRequest.config] completely
        /// overrides and replaces the config in the recognizer for this recognition
        /// request.
        /// </param>
        /// <param name="files">
        /// Audio files with file metadata for ASR.
        /// The maximum number of files allowed to be specified is 15.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchRecognizeResponse, OperationMetadata>> BatchRecognizeAsync(RecognizerName recognizer, RecognitionConfig config, wkt::FieldMask configMask, scg::IEnumerable<BatchRecognizeFileMetadata> files, st::CancellationToken cancellationToken) =>
            BatchRecognizeAsync(recognizer, config, configMask, files, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config GetConfig(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(GetConfigRequest request, st::CancellationToken cancellationToken) =>
            GetConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the config to retrieve. There is exactly one config
        /// resource per project per location. The expected format is
        /// `projects/{project}/locations/{location}/config`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config GetConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfig(new GetConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the config to retrieve. There is exactly one config
        /// resource per project per location. The expected format is
        /// `projects/{project}/locations/{location}/config`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfigAsync(new GetConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the config to retrieve. There is exactly one config
        /// resource per project per location. The expected format is
        /// `projects/{project}/locations/{location}/config`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the config to retrieve. There is exactly one config
        /// resource per project per location. The expected format is
        /// `projects/{project}/locations/{location}/config`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config GetConfig(ConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfig(new GetConfigRequest
            {
                ConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the config to retrieve. There is exactly one config
        /// resource per project per location. The expected format is
        /// `projects/{project}/locations/{location}/config`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(ConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfigAsync(new GetConfigRequest
            {
                ConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the config to retrieve. There is exactly one config
        /// resource per project per location. The expected format is
        /// `projects/{project}/locations/{location}/config`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(ConfigName name, st::CancellationToken cancellationToken) =>
            GetConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config UpdateConfig(UpdateConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> UpdateConfigAsync(UpdateConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> UpdateConfigAsync(UpdateConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="config">
        /// Required. The config to update.
        /// 
        /// The config's `name` field is used to identify the config to be updated.
        /// The expected format is `projects/{project}/locations/{location}/config`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config UpdateConfig(Config config, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConfig(new UpdateConfigRequest
            {
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="config">
        /// Required. The config to update.
        /// 
        /// The config's `name` field is used to identify the config to be updated.
        /// The expected format is `projects/{project}/locations/{location}/config`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> UpdateConfigAsync(Config config, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConfigAsync(new UpdateConfigRequest
            {
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="config">
        /// Required. The config to update.
        /// 
        /// The config's `name` field is used to identify the config to be updated.
        /// The expected format is `projects/{project}/locations/{location}/config`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> UpdateConfigAsync(Config config, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConfigAsync(config, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> CreateCustomClass(CreateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> CreateCustomClassAsync(CreateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> CreateCustomClassAsync(CreateCustomClassRequest request, st::CancellationToken cancellationToken) =>
            CreateCustomClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCustomClass</c>.</summary>
        public virtual lro::OperationsClient CreateCustomClassOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCustomClass</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> PollOnceCreateCustomClass(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CustomClass, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCustomClassOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCustomClass</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> PollOnceCreateCustomClassAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CustomClass, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCustomClassOperationsClient, callSettings);

        /// <summary>
        /// Creates a [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this CustomClass will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="customClass">
        /// Required. The CustomClass to create.
        /// </param>
        /// <param name="customClassId">
        /// The ID to use for the CustomClass, which will become the final component of
        /// the CustomClass's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> CreateCustomClass(string parent, CustomClass customClass, string customClassId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomClass(new CreateCustomClassRequest
            {
                CustomClass = gax::GaxPreconditions.CheckNotNull(customClass, nameof(customClass)),
                CustomClassId = customClassId ?? "",
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this CustomClass will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="customClass">
        /// Required. The CustomClass to create.
        /// </param>
        /// <param name="customClassId">
        /// The ID to use for the CustomClass, which will become the final component of
        /// the CustomClass's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> CreateCustomClassAsync(string parent, CustomClass customClass, string customClassId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomClassAsync(new CreateCustomClassRequest
            {
                CustomClass = gax::GaxPreconditions.CheckNotNull(customClass, nameof(customClass)),
                CustomClassId = customClassId ?? "",
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this CustomClass will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="customClass">
        /// Required. The CustomClass to create.
        /// </param>
        /// <param name="customClassId">
        /// The ID to use for the CustomClass, which will become the final component of
        /// the CustomClass's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> CreateCustomClassAsync(string parent, CustomClass customClass, string customClassId, st::CancellationToken cancellationToken) =>
            CreateCustomClassAsync(parent, customClass, customClassId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this CustomClass will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="customClass">
        /// Required. The CustomClass to create.
        /// </param>
        /// <param name="customClassId">
        /// The ID to use for the CustomClass, which will become the final component of
        /// the CustomClass's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> CreateCustomClass(gagr::LocationName parent, CustomClass customClass, string customClassId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomClass(new CreateCustomClassRequest
            {
                CustomClass = gax::GaxPreconditions.CheckNotNull(customClass, nameof(customClass)),
                CustomClassId = customClassId ?? "",
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this CustomClass will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="customClass">
        /// Required. The CustomClass to create.
        /// </param>
        /// <param name="customClassId">
        /// The ID to use for the CustomClass, which will become the final component of
        /// the CustomClass's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> CreateCustomClassAsync(gagr::LocationName parent, CustomClass customClass, string customClassId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomClassAsync(new CreateCustomClassRequest
            {
                CustomClass = gax::GaxPreconditions.CheckNotNull(customClass, nameof(customClass)),
                CustomClassId = customClassId ?? "",
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this CustomClass will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="customClass">
        /// Required. The CustomClass to create.
        /// </param>
        /// <param name="customClassId">
        /// The ID to use for the CustomClass, which will become the final component of
        /// the CustomClass's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> CreateCustomClassAsync(gagr::LocationName parent, CustomClass customClass, string customClassId, st::CancellationToken cancellationToken) =>
            CreateCustomClassAsync(parent, customClass, customClassId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists CustomClasses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomClass"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClasses(ListCustomClassesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CustomClasses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomClass"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClassesAsync(ListCustomClassesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CustomClasses.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of CustomClass resources to list. The
        /// expected format is `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="CustomClass"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClasses(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomClassesRequest request = new ListCustomClassesRequest
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
            return ListCustomClasses(request, callSettings);
        }

        /// <summary>
        /// Lists CustomClasses.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of CustomClass resources to list. The
        /// expected format is `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomClass"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClassesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomClassesRequest request = new ListCustomClassesRequest
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
            return ListCustomClassesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists CustomClasses.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of CustomClass resources to list. The
        /// expected format is `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="CustomClass"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClasses(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomClassesRequest request = new ListCustomClassesRequest
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
            return ListCustomClasses(request, callSettings);
        }

        /// <summary>
        /// Lists CustomClasses.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of CustomClass resources to list. The
        /// expected format is `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomClass"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClassesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomClassesRequest request = new ListCustomClassesRequest
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
            return ListCustomClassesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested
        /// [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomClass GetCustomClass(GetCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested
        /// [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> GetCustomClassAsync(GetCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested
        /// [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> GetCustomClassAsync(GetCustomClassRequest request, st::CancellationToken cancellationToken) =>
            GetCustomClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested
        /// [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomClass GetCustomClass(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomClass(new GetCustomClassRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested
        /// [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> GetCustomClassAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomClassAsync(new GetCustomClassRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested
        /// [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> GetCustomClassAsync(string name, st::CancellationToken cancellationToken) =>
            GetCustomClassAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested
        /// [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomClass GetCustomClass(CustomClassName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomClass(new GetCustomClassRequest
            {
                CustomClassName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested
        /// [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> GetCustomClassAsync(CustomClassName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomClassAsync(new GetCustomClassRequest
            {
                CustomClassName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested
        /// [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomClass> GetCustomClassAsync(CustomClassName name, st::CancellationToken cancellationToken) =>
            GetCustomClassAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> UpdateCustomClass(UpdateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> UpdateCustomClassAsync(UpdateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> UpdateCustomClassAsync(UpdateCustomClassRequest request, st::CancellationToken cancellationToken) =>
            UpdateCustomClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCustomClass</c>.</summary>
        public virtual lro::OperationsClient UpdateCustomClassOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCustomClass</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> PollOnceUpdateCustomClass(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CustomClass, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCustomClassOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCustomClass</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> PollOnceUpdateCustomClassAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CustomClass, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCustomClassOperationsClient, callSettings);

        /// <summary>
        /// Updates the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="customClass">
        /// Required. The CustomClass to update.
        /// 
        /// The CustomClass's `name` field is used to identify the CustomClass to
        /// update. Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If empty, all fields are considered for
        /// update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> UpdateCustomClass(CustomClass customClass, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomClass(new UpdateCustomClassRequest
            {
                CustomClass = gax::GaxPreconditions.CheckNotNull(customClass, nameof(customClass)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="customClass">
        /// Required. The CustomClass to update.
        /// 
        /// The CustomClass's `name` field is used to identify the CustomClass to
        /// update. Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If empty, all fields are considered for
        /// update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> UpdateCustomClassAsync(CustomClass customClass, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomClassAsync(new UpdateCustomClassRequest
            {
                CustomClass = gax::GaxPreconditions.CheckNotNull(customClass, nameof(customClass)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="customClass">
        /// Required. The CustomClass to update.
        /// 
        /// The CustomClass's `name` field is used to identify the CustomClass to
        /// update. Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated. If empty, all fields are considered for
        /// update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> UpdateCustomClassAsync(CustomClass customClass, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCustomClassAsync(customClass, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> DeleteCustomClass(DeleteCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> DeleteCustomClassAsync(DeleteCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> DeleteCustomClassAsync(DeleteCustomClassRequest request, st::CancellationToken cancellationToken) =>
            DeleteCustomClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCustomClass</c>.</summary>
        public virtual lro::OperationsClient DeleteCustomClassOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCustomClass</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> PollOnceDeleteCustomClass(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CustomClass, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCustomClassOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCustomClass</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> PollOnceDeleteCustomClassAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CustomClass, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCustomClassOperationsClient, callSettings);

        /// <summary>
        /// Deletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> DeleteCustomClass(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomClass(new DeleteCustomClassRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> DeleteCustomClassAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomClassAsync(new DeleteCustomClassRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> DeleteCustomClassAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCustomClassAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> DeleteCustomClass(CustomClassName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomClass(new DeleteCustomClassRequest
            {
                CustomClassName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> DeleteCustomClassAsync(CustomClassName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomClassAsync(new DeleteCustomClassRequest
            {
                CustomClassName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> DeleteCustomClassAsync(CustomClassName name, st::CancellationToken cancellationToken) =>
            DeleteCustomClassAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> UndeleteCustomClass(UndeleteCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> UndeleteCustomClassAsync(UndeleteCustomClassRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> UndeleteCustomClassAsync(UndeleteCustomClassRequest request, st::CancellationToken cancellationToken) =>
            UndeleteCustomClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeleteCustomClass</c>.</summary>
        public virtual lro::OperationsClient UndeleteCustomClassOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeleteCustomClass</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> PollOnceUndeleteCustomClass(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CustomClass, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteCustomClassOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeleteCustomClass</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> PollOnceUndeleteCustomClassAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CustomClass, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteCustomClassOperationsClient, callSettings);

        /// <summary>
        /// Undeletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to undelete.
        /// Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> UndeleteCustomClass(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteCustomClass(new UndeleteCustomClassRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to undelete.
        /// Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> UndeleteCustomClassAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteCustomClassAsync(new UndeleteCustomClassRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to undelete.
        /// Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> UndeleteCustomClassAsync(string name, st::CancellationToken cancellationToken) =>
            UndeleteCustomClassAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to undelete.
        /// Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomClass, OperationMetadata> UndeleteCustomClass(CustomClassName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteCustomClass(new UndeleteCustomClassRequest
            {
                CustomClassName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to undelete.
        /// Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> UndeleteCustomClassAsync(CustomClassName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteCustomClassAsync(new UndeleteCustomClassRequest
            {
                CustomClassName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the CustomClass to undelete.
        /// Format:
        /// `projects/{project}/locations/{location}/customClasses/{custom_class}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomClass, OperationMetadata>> UndeleteCustomClassAsync(CustomClassName name, st::CancellationToken cancellationToken) =>
            UndeleteCustomClassAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> CreatePhraseSet(CreatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> CreatePhraseSetAsync(CreatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> CreatePhraseSetAsync(CreatePhraseSetRequest request, st::CancellationToken cancellationToken) =>
            CreatePhraseSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePhraseSet</c>.</summary>
        public virtual lro::OperationsClient CreatePhraseSetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreatePhraseSet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> PollOnceCreatePhraseSet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PhraseSet, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePhraseSetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePhraseSet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> PollOnceCreatePhraseSetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PhraseSet, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePhraseSetOperationsClient, callSettings);

        /// <summary>
        /// Creates a [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this PhraseSet will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="phraseSet">
        /// Required. The PhraseSet to create.
        /// </param>
        /// <param name="phraseSetId">
        /// The ID to use for the PhraseSet, which will become the final component of
        /// the PhraseSet's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> CreatePhraseSet(string parent, PhraseSet phraseSet, string phraseSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseSet(new CreatePhraseSetRequest
            {
                PhraseSet = gax::GaxPreconditions.CheckNotNull(phraseSet, nameof(phraseSet)),
                PhraseSetId = phraseSetId ?? "",
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this PhraseSet will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="phraseSet">
        /// Required. The PhraseSet to create.
        /// </param>
        /// <param name="phraseSetId">
        /// The ID to use for the PhraseSet, which will become the final component of
        /// the PhraseSet's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> CreatePhraseSetAsync(string parent, PhraseSet phraseSet, string phraseSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseSetAsync(new CreatePhraseSetRequest
            {
                PhraseSet = gax::GaxPreconditions.CheckNotNull(phraseSet, nameof(phraseSet)),
                PhraseSetId = phraseSetId ?? "",
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this PhraseSet will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="phraseSet">
        /// Required. The PhraseSet to create.
        /// </param>
        /// <param name="phraseSetId">
        /// The ID to use for the PhraseSet, which will become the final component of
        /// the PhraseSet's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> CreatePhraseSetAsync(string parent, PhraseSet phraseSet, string phraseSetId, st::CancellationToken cancellationToken) =>
            CreatePhraseSetAsync(parent, phraseSet, phraseSetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this PhraseSet will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="phraseSet">
        /// Required. The PhraseSet to create.
        /// </param>
        /// <param name="phraseSetId">
        /// The ID to use for the PhraseSet, which will become the final component of
        /// the PhraseSet's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> CreatePhraseSet(gagr::LocationName parent, PhraseSet phraseSet, string phraseSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseSet(new CreatePhraseSetRequest
            {
                PhraseSet = gax::GaxPreconditions.CheckNotNull(phraseSet, nameof(phraseSet)),
                PhraseSetId = phraseSetId ?? "",
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this PhraseSet will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="phraseSet">
        /// Required. The PhraseSet to create.
        /// </param>
        /// <param name="phraseSetId">
        /// The ID to use for the PhraseSet, which will become the final component of
        /// the PhraseSet's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> CreatePhraseSetAsync(gagr::LocationName parent, PhraseSet phraseSet, string phraseSetId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhraseSetAsync(new CreatePhraseSetRequest
            {
                PhraseSet = gax::GaxPreconditions.CheckNotNull(phraseSet, nameof(phraseSet)),
                PhraseSetId = phraseSetId ?? "",
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location where this PhraseSet will be created.
        /// The expected format is `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="phraseSet">
        /// Required. The PhraseSet to create.
        /// </param>
        /// <param name="phraseSetId">
        /// The ID to use for the PhraseSet, which will become the final component of
        /// the PhraseSet's resource name.
        /// 
        /// This value should be 4-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> CreatePhraseSetAsync(gagr::LocationName parent, PhraseSet phraseSet, string phraseSetId, st::CancellationToken cancellationToken) =>
            CreatePhraseSetAsync(parent, phraseSet, phraseSetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists PhraseSets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhraseSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhraseSetsResponse, PhraseSet> ListPhraseSets(ListPhraseSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists PhraseSets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhraseSetsResponse, PhraseSet> ListPhraseSetsAsync(ListPhraseSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists PhraseSets.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of PhraseSet resources to list. The
        /// expected format is `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="PhraseSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhraseSetsResponse, PhraseSet> ListPhraseSets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhraseSetsRequest request = new ListPhraseSetsRequest
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
            return ListPhraseSets(request, callSettings);
        }

        /// <summary>
        /// Lists PhraseSets.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of PhraseSet resources to list. The
        /// expected format is `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhraseSetsResponse, PhraseSet> ListPhraseSetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhraseSetsRequest request = new ListPhraseSetsRequest
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
            return ListPhraseSetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists PhraseSets.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of PhraseSet resources to list. The
        /// expected format is `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="PhraseSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhraseSetsResponse, PhraseSet> ListPhraseSets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhraseSetsRequest request = new ListPhraseSetsRequest
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
            return ListPhraseSets(request, callSettings);
        }

        /// <summary>
        /// Lists PhraseSets.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location of PhraseSet resources to list. The
        /// expected format is `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhraseSetsResponse, PhraseSet> ListPhraseSetsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPhraseSetsRequest request = new ListPhraseSetsRequest
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
            return ListPhraseSetsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested
        /// [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseSet GetPhraseSet(GetPhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested
        /// [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> GetPhraseSetAsync(GetPhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested
        /// [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> GetPhraseSetAsync(GetPhraseSetRequest request, st::CancellationToken cancellationToken) =>
            GetPhraseSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested
        /// [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseSet GetPhraseSet(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseSet(new GetPhraseSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested
        /// [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> GetPhraseSetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseSetAsync(new GetPhraseSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested
        /// [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> GetPhraseSetAsync(string name, st::CancellationToken cancellationToken) =>
            GetPhraseSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested
        /// [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PhraseSet GetPhraseSet(PhraseSetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseSet(new GetPhraseSetRequest
            {
                PhraseSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested
        /// [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> GetPhraseSetAsync(PhraseSetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPhraseSetAsync(new GetPhraseSetRequest
            {
                PhraseSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested
        /// [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to retrieve. The expected format is
        /// `projects/{project}/locations/{location}/phraseSets/{phrase_set}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PhraseSet> GetPhraseSetAsync(PhraseSetName name, st::CancellationToken cancellationToken) =>
            GetPhraseSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> UpdatePhraseSet(UpdatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> UpdatePhraseSetAsync(UpdatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> UpdatePhraseSetAsync(UpdatePhraseSetRequest request, st::CancellationToken cancellationToken) =>
            UpdatePhraseSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdatePhraseSet</c>.</summary>
        public virtual lro::OperationsClient UpdatePhraseSetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdatePhraseSet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> PollOnceUpdatePhraseSet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PhraseSet, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePhraseSetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePhraseSet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> PollOnceUpdatePhraseSetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PhraseSet, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePhraseSetOperationsClient, callSettings);

        /// <summary>
        /// Updates the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="phraseSet">
        /// Required. The PhraseSet to update.
        /// 
        /// The PhraseSet's `name` field is used to identify the PhraseSet to update.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If empty, all non-default valued fields are
        /// considered for update. Use `*` to update the entire PhraseSet resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> UpdatePhraseSet(PhraseSet phraseSet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePhraseSet(new UpdatePhraseSetRequest
            {
                PhraseSet = gax::GaxPreconditions.CheckNotNull(phraseSet, nameof(phraseSet)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="phraseSet">
        /// Required. The PhraseSet to update.
        /// 
        /// The PhraseSet's `name` field is used to identify the PhraseSet to update.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If empty, all non-default valued fields are
        /// considered for update. Use `*` to update the entire PhraseSet resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> UpdatePhraseSetAsync(PhraseSet phraseSet, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePhraseSetAsync(new UpdatePhraseSetRequest
            {
                PhraseSet = gax::GaxPreconditions.CheckNotNull(phraseSet, nameof(phraseSet)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="phraseSet">
        /// Required. The PhraseSet to update.
        /// 
        /// The PhraseSet's `name` field is used to identify the PhraseSet to update.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If empty, all non-default valued fields are
        /// considered for update. Use `*` to update the entire PhraseSet resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> UpdatePhraseSetAsync(PhraseSet phraseSet, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePhraseSetAsync(phraseSet, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> DeletePhraseSet(DeletePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> DeletePhraseSetAsync(DeletePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> DeletePhraseSetAsync(DeletePhraseSetRequest request, st::CancellationToken cancellationToken) =>
            DeletePhraseSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePhraseSet</c>.</summary>
        public virtual lro::OperationsClient DeletePhraseSetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeletePhraseSet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> PollOnceDeletePhraseSet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PhraseSet, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePhraseSetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePhraseSet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> PollOnceDeletePhraseSetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PhraseSet, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePhraseSetOperationsClient, callSettings);

        /// <summary>
        /// Deletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to delete.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> DeletePhraseSet(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseSet(new DeletePhraseSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to delete.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> DeletePhraseSetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseSetAsync(new DeletePhraseSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to delete.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> DeletePhraseSetAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePhraseSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to delete.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> DeletePhraseSet(PhraseSetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseSet(new DeletePhraseSetRequest
            {
                PhraseSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to delete.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> DeletePhraseSetAsync(PhraseSetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhraseSetAsync(new DeletePhraseSetRequest
            {
                PhraseSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to delete.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> DeletePhraseSetAsync(PhraseSetName name, st::CancellationToken cancellationToken) =>
            DeletePhraseSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> UndeletePhraseSet(UndeletePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> UndeletePhraseSetAsync(UndeletePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> UndeletePhraseSetAsync(UndeletePhraseSetRequest request, st::CancellationToken cancellationToken) =>
            UndeletePhraseSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeletePhraseSet</c>.</summary>
        public virtual lro::OperationsClient UndeletePhraseSetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeletePhraseSet</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> PollOnceUndeletePhraseSet(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PhraseSet, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeletePhraseSetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeletePhraseSet</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> PollOnceUndeletePhraseSetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PhraseSet, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeletePhraseSetOperationsClient, callSettings);

        /// <summary>
        /// Undeletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to undelete.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> UndeletePhraseSet(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeletePhraseSet(new UndeletePhraseSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to undelete.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> UndeletePhraseSetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeletePhraseSetAsync(new UndeletePhraseSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to undelete.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> UndeletePhraseSetAsync(string name, st::CancellationToken cancellationToken) =>
            UndeletePhraseSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to undelete.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PhraseSet, OperationMetadata> UndeletePhraseSet(PhraseSetName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeletePhraseSet(new UndeletePhraseSetRequest
            {
                PhraseSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to undelete.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> UndeletePhraseSetAsync(PhraseSetName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeletePhraseSetAsync(new UndeletePhraseSetRequest
            {
                PhraseSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the PhraseSet to undelete.
        /// Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PhraseSet, OperationMetadata>> UndeletePhraseSetAsync(PhraseSetName name, st::CancellationToken cancellationToken) =>
            UndeletePhraseSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Speech client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Enables speech transcription and resource management.
    /// </remarks>
    public sealed partial class SpeechClientImpl : SpeechClient
    {
        private readonly gaxgrpc::ApiCall<CreateRecognizerRequest, lro::Operation> _callCreateRecognizer;

        private readonly gaxgrpc::ApiCall<ListRecognizersRequest, ListRecognizersResponse> _callListRecognizers;

        private readonly gaxgrpc::ApiCall<GetRecognizerRequest, Recognizer> _callGetRecognizer;

        private readonly gaxgrpc::ApiCall<UpdateRecognizerRequest, lro::Operation> _callUpdateRecognizer;

        private readonly gaxgrpc::ApiCall<DeleteRecognizerRequest, lro::Operation> _callDeleteRecognizer;

        private readonly gaxgrpc::ApiCall<UndeleteRecognizerRequest, lro::Operation> _callUndeleteRecognizer;

        private readonly gaxgrpc::ApiCall<RecognizeRequest, RecognizeResponse> _callRecognize;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> _callStreamingRecognize;

        private readonly gaxgrpc::ApiCall<BatchRecognizeRequest, lro::Operation> _callBatchRecognize;

        private readonly gaxgrpc::ApiCall<GetConfigRequest, Config> _callGetConfig;

        private readonly gaxgrpc::ApiCall<UpdateConfigRequest, Config> _callUpdateConfig;

        private readonly gaxgrpc::ApiCall<CreateCustomClassRequest, lro::Operation> _callCreateCustomClass;

        private readonly gaxgrpc::ApiCall<ListCustomClassesRequest, ListCustomClassesResponse> _callListCustomClasses;

        private readonly gaxgrpc::ApiCall<GetCustomClassRequest, CustomClass> _callGetCustomClass;

        private readonly gaxgrpc::ApiCall<UpdateCustomClassRequest, lro::Operation> _callUpdateCustomClass;

        private readonly gaxgrpc::ApiCall<DeleteCustomClassRequest, lro::Operation> _callDeleteCustomClass;

        private readonly gaxgrpc::ApiCall<UndeleteCustomClassRequest, lro::Operation> _callUndeleteCustomClass;

        private readonly gaxgrpc::ApiCall<CreatePhraseSetRequest, lro::Operation> _callCreatePhraseSet;

        private readonly gaxgrpc::ApiCall<ListPhraseSetsRequest, ListPhraseSetsResponse> _callListPhraseSets;

        private readonly gaxgrpc::ApiCall<GetPhraseSetRequest, PhraseSet> _callGetPhraseSet;

        private readonly gaxgrpc::ApiCall<UpdatePhraseSetRequest, lro::Operation> _callUpdatePhraseSet;

        private readonly gaxgrpc::ApiCall<DeletePhraseSetRequest, lro::Operation> _callDeletePhraseSet;

        private readonly gaxgrpc::ApiCall<UndeletePhraseSetRequest, lro::Operation> _callUndeletePhraseSet;

        /// <summary>
        /// Constructs a client wrapper for the Speech service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SpeechSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SpeechClientImpl(Speech.SpeechClient grpcClient, SpeechSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SpeechSettings effectiveSettings = settings ?? SpeechSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateRecognizerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateRecognizerOperationsSettings, logger);
            UpdateRecognizerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateRecognizerOperationsSettings, logger);
            DeleteRecognizerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRecognizerOperationsSettings, logger);
            UndeleteRecognizerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeleteRecognizerOperationsSettings, logger);
            BatchRecognizeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchRecognizeOperationsSettings, logger);
            CreateCustomClassOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCustomClassOperationsSettings, logger);
            UpdateCustomClassOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateCustomClassOperationsSettings, logger);
            DeleteCustomClassOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCustomClassOperationsSettings, logger);
            UndeleteCustomClassOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeleteCustomClassOperationsSettings, logger);
            CreatePhraseSetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePhraseSetOperationsSettings, logger);
            UpdatePhraseSetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdatePhraseSetOperationsSettings, logger);
            DeletePhraseSetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePhraseSetOperationsSettings, logger);
            UndeletePhraseSetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeletePhraseSetOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateRecognizer = clientHelper.BuildApiCall<CreateRecognizerRequest, lro::Operation>("CreateRecognizer", grpcClient.CreateRecognizerAsync, grpcClient.CreateRecognizer, effectiveSettings.CreateRecognizerSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRecognizer);
            Modify_CreateRecognizerApiCall(ref _callCreateRecognizer);
            _callListRecognizers = clientHelper.BuildApiCall<ListRecognizersRequest, ListRecognizersResponse>("ListRecognizers", grpcClient.ListRecognizersAsync, grpcClient.ListRecognizers, effectiveSettings.ListRecognizersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRecognizers);
            Modify_ListRecognizersApiCall(ref _callListRecognizers);
            _callGetRecognizer = clientHelper.BuildApiCall<GetRecognizerRequest, Recognizer>("GetRecognizer", grpcClient.GetRecognizerAsync, grpcClient.GetRecognizer, effectiveSettings.GetRecognizerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRecognizer);
            Modify_GetRecognizerApiCall(ref _callGetRecognizer);
            _callUpdateRecognizer = clientHelper.BuildApiCall<UpdateRecognizerRequest, lro::Operation>("UpdateRecognizer", grpcClient.UpdateRecognizerAsync, grpcClient.UpdateRecognizer, effectiveSettings.UpdateRecognizerSettings).WithGoogleRequestParam("recognizer.name", request => request.Recognizer?.Name);
            Modify_ApiCall(ref _callUpdateRecognizer);
            Modify_UpdateRecognizerApiCall(ref _callUpdateRecognizer);
            _callDeleteRecognizer = clientHelper.BuildApiCall<DeleteRecognizerRequest, lro::Operation>("DeleteRecognizer", grpcClient.DeleteRecognizerAsync, grpcClient.DeleteRecognizer, effectiveSettings.DeleteRecognizerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRecognizer);
            Modify_DeleteRecognizerApiCall(ref _callDeleteRecognizer);
            _callUndeleteRecognizer = clientHelper.BuildApiCall<UndeleteRecognizerRequest, lro::Operation>("UndeleteRecognizer", grpcClient.UndeleteRecognizerAsync, grpcClient.UndeleteRecognizer, effectiveSettings.UndeleteRecognizerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeleteRecognizer);
            Modify_UndeleteRecognizerApiCall(ref _callUndeleteRecognizer);
            _callRecognize = clientHelper.BuildApiCall<RecognizeRequest, RecognizeResponse>("Recognize", grpcClient.RecognizeAsync, grpcClient.Recognize, effectiveSettings.RecognizeSettings).WithGoogleRequestParam("recognizer", request => request.Recognizer);
            Modify_ApiCall(ref _callRecognize);
            Modify_RecognizeApiCall(ref _callRecognize);
            _callStreamingRecognize = clientHelper.BuildApiCall<StreamingRecognizeRequest, StreamingRecognizeResponse>("StreamingRecognize", grpcClient.StreamingRecognize, effectiveSettings.StreamingRecognizeSettings, effectiveSettings.StreamingRecognizeStreamingSettings);
            Modify_ApiCall(ref _callStreamingRecognize);
            Modify_StreamingRecognizeApiCall(ref _callStreamingRecognize);
            _callBatchRecognize = clientHelper.BuildApiCall<BatchRecognizeRequest, lro::Operation>("BatchRecognize", grpcClient.BatchRecognizeAsync, grpcClient.BatchRecognize, effectiveSettings.BatchRecognizeSettings).WithGoogleRequestParam("recognizer", request => request.Recognizer);
            Modify_ApiCall(ref _callBatchRecognize);
            Modify_BatchRecognizeApiCall(ref _callBatchRecognize);
            _callGetConfig = clientHelper.BuildApiCall<GetConfigRequest, Config>("GetConfig", grpcClient.GetConfigAsync, grpcClient.GetConfig, effectiveSettings.GetConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConfig);
            Modify_GetConfigApiCall(ref _callGetConfig);
            _callUpdateConfig = clientHelper.BuildApiCall<UpdateConfigRequest, Config>("UpdateConfig", grpcClient.UpdateConfigAsync, grpcClient.UpdateConfig, effectiveSettings.UpdateConfigSettings).WithGoogleRequestParam("config.name", request => request.Config?.Name);
            Modify_ApiCall(ref _callUpdateConfig);
            Modify_UpdateConfigApiCall(ref _callUpdateConfig);
            _callCreateCustomClass = clientHelper.BuildApiCall<CreateCustomClassRequest, lro::Operation>("CreateCustomClass", grpcClient.CreateCustomClassAsync, grpcClient.CreateCustomClass, effectiveSettings.CreateCustomClassSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCustomClass);
            Modify_CreateCustomClassApiCall(ref _callCreateCustomClass);
            _callListCustomClasses = clientHelper.BuildApiCall<ListCustomClassesRequest, ListCustomClassesResponse>("ListCustomClasses", grpcClient.ListCustomClassesAsync, grpcClient.ListCustomClasses, effectiveSettings.ListCustomClassesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCustomClasses);
            Modify_ListCustomClassesApiCall(ref _callListCustomClasses);
            _callGetCustomClass = clientHelper.BuildApiCall<GetCustomClassRequest, CustomClass>("GetCustomClass", grpcClient.GetCustomClassAsync, grpcClient.GetCustomClass, effectiveSettings.GetCustomClassSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCustomClass);
            Modify_GetCustomClassApiCall(ref _callGetCustomClass);
            _callUpdateCustomClass = clientHelper.BuildApiCall<UpdateCustomClassRequest, lro::Operation>("UpdateCustomClass", grpcClient.UpdateCustomClassAsync, grpcClient.UpdateCustomClass, effectiveSettings.UpdateCustomClassSettings).WithGoogleRequestParam("custom_class.name", request => request.CustomClass?.Name);
            Modify_ApiCall(ref _callUpdateCustomClass);
            Modify_UpdateCustomClassApiCall(ref _callUpdateCustomClass);
            _callDeleteCustomClass = clientHelper.BuildApiCall<DeleteCustomClassRequest, lro::Operation>("DeleteCustomClass", grpcClient.DeleteCustomClassAsync, grpcClient.DeleteCustomClass, effectiveSettings.DeleteCustomClassSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCustomClass);
            Modify_DeleteCustomClassApiCall(ref _callDeleteCustomClass);
            _callUndeleteCustomClass = clientHelper.BuildApiCall<UndeleteCustomClassRequest, lro::Operation>("UndeleteCustomClass", grpcClient.UndeleteCustomClassAsync, grpcClient.UndeleteCustomClass, effectiveSettings.UndeleteCustomClassSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeleteCustomClass);
            Modify_UndeleteCustomClassApiCall(ref _callUndeleteCustomClass);
            _callCreatePhraseSet = clientHelper.BuildApiCall<CreatePhraseSetRequest, lro::Operation>("CreatePhraseSet", grpcClient.CreatePhraseSetAsync, grpcClient.CreatePhraseSet, effectiveSettings.CreatePhraseSetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePhraseSet);
            Modify_CreatePhraseSetApiCall(ref _callCreatePhraseSet);
            _callListPhraseSets = clientHelper.BuildApiCall<ListPhraseSetsRequest, ListPhraseSetsResponse>("ListPhraseSets", grpcClient.ListPhraseSetsAsync, grpcClient.ListPhraseSets, effectiveSettings.ListPhraseSetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPhraseSets);
            Modify_ListPhraseSetsApiCall(ref _callListPhraseSets);
            _callGetPhraseSet = clientHelper.BuildApiCall<GetPhraseSetRequest, PhraseSet>("GetPhraseSet", grpcClient.GetPhraseSetAsync, grpcClient.GetPhraseSet, effectiveSettings.GetPhraseSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPhraseSet);
            Modify_GetPhraseSetApiCall(ref _callGetPhraseSet);
            _callUpdatePhraseSet = clientHelper.BuildApiCall<UpdatePhraseSetRequest, lro::Operation>("UpdatePhraseSet", grpcClient.UpdatePhraseSetAsync, grpcClient.UpdatePhraseSet, effectiveSettings.UpdatePhraseSetSettings).WithGoogleRequestParam("phrase_set.name", request => request.PhraseSet?.Name);
            Modify_ApiCall(ref _callUpdatePhraseSet);
            Modify_UpdatePhraseSetApiCall(ref _callUpdatePhraseSet);
            _callDeletePhraseSet = clientHelper.BuildApiCall<DeletePhraseSetRequest, lro::Operation>("DeletePhraseSet", grpcClient.DeletePhraseSetAsync, grpcClient.DeletePhraseSet, effectiveSettings.DeletePhraseSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePhraseSet);
            Modify_DeletePhraseSetApiCall(ref _callDeletePhraseSet);
            _callUndeletePhraseSet = clientHelper.BuildApiCall<UndeletePhraseSetRequest, lro::Operation>("UndeletePhraseSet", grpcClient.UndeletePhraseSetAsync, grpcClient.UndeletePhraseSet, effectiveSettings.UndeletePhraseSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeletePhraseSet);
            Modify_UndeletePhraseSetApiCall(ref _callUndeletePhraseSet);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateRecognizerApiCall(ref gaxgrpc::ApiCall<CreateRecognizerRequest, lro::Operation> call);

        partial void Modify_ListRecognizersApiCall(ref gaxgrpc::ApiCall<ListRecognizersRequest, ListRecognizersResponse> call);

        partial void Modify_GetRecognizerApiCall(ref gaxgrpc::ApiCall<GetRecognizerRequest, Recognizer> call);

        partial void Modify_UpdateRecognizerApiCall(ref gaxgrpc::ApiCall<UpdateRecognizerRequest, lro::Operation> call);

        partial void Modify_DeleteRecognizerApiCall(ref gaxgrpc::ApiCall<DeleteRecognizerRequest, lro::Operation> call);

        partial void Modify_UndeleteRecognizerApiCall(ref gaxgrpc::ApiCall<UndeleteRecognizerRequest, lro::Operation> call);

        partial void Modify_RecognizeApiCall(ref gaxgrpc::ApiCall<RecognizeRequest, RecognizeResponse> call);

        partial void Modify_StreamingRecognizeApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> call);

        partial void Modify_BatchRecognizeApiCall(ref gaxgrpc::ApiCall<BatchRecognizeRequest, lro::Operation> call);

        partial void Modify_GetConfigApiCall(ref gaxgrpc::ApiCall<GetConfigRequest, Config> call);

        partial void Modify_UpdateConfigApiCall(ref gaxgrpc::ApiCall<UpdateConfigRequest, Config> call);

        partial void Modify_CreateCustomClassApiCall(ref gaxgrpc::ApiCall<CreateCustomClassRequest, lro::Operation> call);

        partial void Modify_ListCustomClassesApiCall(ref gaxgrpc::ApiCall<ListCustomClassesRequest, ListCustomClassesResponse> call);

        partial void Modify_GetCustomClassApiCall(ref gaxgrpc::ApiCall<GetCustomClassRequest, CustomClass> call);

        partial void Modify_UpdateCustomClassApiCall(ref gaxgrpc::ApiCall<UpdateCustomClassRequest, lro::Operation> call);

        partial void Modify_DeleteCustomClassApiCall(ref gaxgrpc::ApiCall<DeleteCustomClassRequest, lro::Operation> call);

        partial void Modify_UndeleteCustomClassApiCall(ref gaxgrpc::ApiCall<UndeleteCustomClassRequest, lro::Operation> call);

        partial void Modify_CreatePhraseSetApiCall(ref gaxgrpc::ApiCall<CreatePhraseSetRequest, lro::Operation> call);

        partial void Modify_ListPhraseSetsApiCall(ref gaxgrpc::ApiCall<ListPhraseSetsRequest, ListPhraseSetsResponse> call);

        partial void Modify_GetPhraseSetApiCall(ref gaxgrpc::ApiCall<GetPhraseSetRequest, PhraseSet> call);

        partial void Modify_UpdatePhraseSetApiCall(ref gaxgrpc::ApiCall<UpdatePhraseSetRequest, lro::Operation> call);

        partial void Modify_DeletePhraseSetApiCall(ref gaxgrpc::ApiCall<DeletePhraseSetRequest, lro::Operation> call);

        partial void Modify_UndeletePhraseSetApiCall(ref gaxgrpc::ApiCall<UndeletePhraseSetRequest, lro::Operation> call);

        partial void OnConstruction(Speech.SpeechClient grpcClient, SpeechSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Speech client</summary>
        public override Speech.SpeechClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateRecognizerRequest(ref CreateRecognizerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRecognizersRequest(ref ListRecognizersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRecognizerRequest(ref GetRecognizerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRecognizerRequest(ref UpdateRecognizerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRecognizerRequest(ref DeleteRecognizerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeleteRecognizerRequest(ref UndeleteRecognizerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RecognizeRequest(ref RecognizeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingRecognizeRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingRecognizeRequestRequest(ref StreamingRecognizeRequest request);

        partial void Modify_BatchRecognizeRequest(ref BatchRecognizeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConfigRequest(ref GetConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConfigRequest(ref UpdateConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCustomClassRequest(ref CreateCustomClassRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomClassesRequest(ref ListCustomClassesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCustomClassRequest(ref GetCustomClassRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCustomClassRequest(ref UpdateCustomClassRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCustomClassRequest(ref DeleteCustomClassRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeleteCustomClassRequest(ref UndeleteCustomClassRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePhraseSetRequest(ref CreatePhraseSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPhraseSetsRequest(ref ListPhraseSetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPhraseSetRequest(ref GetPhraseSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePhraseSetRequest(ref UpdatePhraseSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePhraseSetRequest(ref DeletePhraseSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeletePhraseSetRequest(ref UndeletePhraseSetRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateRecognizer</c>.</summary>
        public override lro::OperationsClient CreateRecognizerOperationsClient { get; }

        /// <summary>
        /// Creates a [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Recognizer, OperationMetadata> CreateRecognizer(CreateRecognizerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRecognizerRequest(ref request, ref callSettings);
            return new lro::Operation<Recognizer, OperationMetadata>(_callCreateRecognizer.Sync(request, callSettings), CreateRecognizerOperationsClient);
        }

        /// <summary>
        /// Creates a [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Recognizer, OperationMetadata>> CreateRecognizerAsync(CreateRecognizerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRecognizerRequest(ref request, ref callSettings);
            return new lro::Operation<Recognizer, OperationMetadata>(await _callCreateRecognizer.Async(request, callSettings).ConfigureAwait(false), CreateRecognizerOperationsClient);
        }

        /// <summary>
        /// Lists Recognizers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Recognizer"/> resources.</returns>
        public override gax::PagedEnumerable<ListRecognizersResponse, Recognizer> ListRecognizers(ListRecognizersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRecognizersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRecognizersRequest, ListRecognizersResponse, Recognizer>(_callListRecognizers, request, callSettings);
        }

        /// <summary>
        /// Lists Recognizers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Recognizer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRecognizersResponse, Recognizer> ListRecognizersAsync(ListRecognizersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRecognizersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRecognizersRequest, ListRecognizersResponse, Recognizer>(_callListRecognizers, request, callSettings);
        }

        /// <summary>
        /// Returns the requested
        /// [Recognizer][google.cloud.speech.v2.Recognizer]. Fails with
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested Recognizer doesn't
        /// exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Recognizer GetRecognizer(GetRecognizerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRecognizerRequest(ref request, ref callSettings);
            return _callGetRecognizer.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested
        /// [Recognizer][google.cloud.speech.v2.Recognizer]. Fails with
        /// [NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested Recognizer doesn't
        /// exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Recognizer> GetRecognizerAsync(GetRecognizerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRecognizerRequest(ref request, ref callSettings);
            return _callGetRecognizer.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateRecognizer</c>.</summary>
        public override lro::OperationsClient UpdateRecognizerOperationsClient { get; }

        /// <summary>
        /// Updates the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Recognizer, OperationMetadata> UpdateRecognizer(UpdateRecognizerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRecognizerRequest(ref request, ref callSettings);
            return new lro::Operation<Recognizer, OperationMetadata>(_callUpdateRecognizer.Sync(request, callSettings), UpdateRecognizerOperationsClient);
        }

        /// <summary>
        /// Updates the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Recognizer, OperationMetadata>> UpdateRecognizerAsync(UpdateRecognizerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRecognizerRequest(ref request, ref callSettings);
            return new lro::Operation<Recognizer, OperationMetadata>(await _callUpdateRecognizer.Async(request, callSettings).ConfigureAwait(false), UpdateRecognizerOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteRecognizer</c>.</summary>
        public override lro::OperationsClient DeleteRecognizerOperationsClient { get; }

        /// <summary>
        /// Deletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Recognizer, OperationMetadata> DeleteRecognizer(DeleteRecognizerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRecognizerRequest(ref request, ref callSettings);
            return new lro::Operation<Recognizer, OperationMetadata>(_callDeleteRecognizer.Sync(request, callSettings), DeleteRecognizerOperationsClient);
        }

        /// <summary>
        /// Deletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Recognizer, OperationMetadata>> DeleteRecognizerAsync(DeleteRecognizerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRecognizerRequest(ref request, ref callSettings);
            return new lro::Operation<Recognizer, OperationMetadata>(await _callDeleteRecognizer.Async(request, callSettings).ConfigureAwait(false), DeleteRecognizerOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeleteRecognizer</c>.</summary>
        public override lro::OperationsClient UndeleteRecognizerOperationsClient { get; }

        /// <summary>
        /// Undeletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Recognizer, OperationMetadata> UndeleteRecognizer(UndeleteRecognizerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteRecognizerRequest(ref request, ref callSettings);
            return new lro::Operation<Recognizer, OperationMetadata>(_callUndeleteRecognizer.Sync(request, callSettings), UndeleteRecognizerOperationsClient);
        }

        /// <summary>
        /// Undeletes the [Recognizer][google.cloud.speech.v2.Recognizer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Recognizer, OperationMetadata>> UndeleteRecognizerAsync(UndeleteRecognizerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteRecognizerRequest(ref request, ref callSettings);
            return new lro::Operation<Recognizer, OperationMetadata>(await _callUndeleteRecognizer.Async(request, callSettings).ConfigureAwait(false), UndeleteRecognizerOperationsClient);
        }

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RecognizeResponse Recognize(RecognizeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RecognizeRequest(ref request, ref callSettings);
            return _callRecognize.Sync(request, callSettings);
        }

        /// <summary>
        /// Performs synchronous Speech recognition: receive results after all audio
        /// has been sent and processed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RecognizeResponse> RecognizeAsync(RecognizeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RecognizeRequest(ref request, ref callSettings);
            return _callRecognize.Async(request, callSettings);
        }

        internal sealed partial class StreamingRecognizeStreamImpl : StreamingRecognizeStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamingRecognize</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamingRecognizeRequest}"/> instance associated
            /// with this streaming call.
            /// </param>
            public StreamingRecognizeStreamImpl(SpeechClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamingRecognizeRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private SpeechClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamingRecognizeRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> GrpcCall { get; }

            private StreamingRecognizeRequest ModifyRequest(StreamingRecognizeRequest request)
            {
                _service.Modify_StreamingRecognizeRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamingRecognizeRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamingRecognizeRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamingRecognizeRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamingRecognizeRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Performs bidirectional streaming speech recognition: receive results while
        /// sending audio. This method is only available via the gRPC API (not REST).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override SpeechClient.StreamingRecognizeStream StreamingRecognize(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingRecognizeRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamingRecognize.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamingRecognizeRequest, StreamingRecognizeResponse> call = _callStreamingRecognize.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamingRecognizeRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamingRecognizeRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingRecognizeStreamImpl(this, call, writeBuffer);
        }

        /// <summary>The long-running operations client for <c>BatchRecognize</c>.</summary>
        public override lro::OperationsClient BatchRecognizeOperationsClient { get; }

        /// <summary>
        /// Performs batch asynchronous speech recognition: send a request with N
        /// audio files and receive a long running operation that can be polled to see
        /// when the transcriptions are finished.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchRecognizeResponse, OperationMetadata> BatchRecognize(BatchRecognizeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRecognizeRequest(ref request, ref callSettings);
            return new lro::Operation<BatchRecognizeResponse, OperationMetadata>(_callBatchRecognize.Sync(request, callSettings), BatchRecognizeOperationsClient);
        }

        /// <summary>
        /// Performs batch asynchronous speech recognition: send a request with N
        /// audio files and receive a long running operation that can be polled to see
        /// when the transcriptions are finished.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchRecognizeResponse, OperationMetadata>> BatchRecognizeAsync(BatchRecognizeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRecognizeRequest(ref request, ref callSettings);
            return new lro::Operation<BatchRecognizeResponse, OperationMetadata>(await _callBatchRecognize.Async(request, callSettings).ConfigureAwait(false), BatchRecognizeOperationsClient);
        }

        /// <summary>
        /// Returns the requested [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Config GetConfig(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConfigRequest(ref request, ref callSettings);
            return _callGetConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Config> GetConfigAsync(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConfigRequest(ref request, ref callSettings);
            return _callGetConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Config UpdateConfig(UpdateConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConfigRequest(ref request, ref callSettings);
            return _callUpdateConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the [Config][google.cloud.speech.v2.Config].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Config> UpdateConfigAsync(UpdateConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConfigRequest(ref request, ref callSettings);
            return _callUpdateConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCustomClass</c>.</summary>
        public override lro::OperationsClient CreateCustomClassOperationsClient { get; }

        /// <summary>
        /// Creates a [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CustomClass, OperationMetadata> CreateCustomClass(CreateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomClassRequest(ref request, ref callSettings);
            return new lro::Operation<CustomClass, OperationMetadata>(_callCreateCustomClass.Sync(request, callSettings), CreateCustomClassOperationsClient);
        }

        /// <summary>
        /// Creates a [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CustomClass, OperationMetadata>> CreateCustomClassAsync(CreateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomClassRequest(ref request, ref callSettings);
            return new lro::Operation<CustomClass, OperationMetadata>(await _callCreateCustomClass.Async(request, callSettings).ConfigureAwait(false), CreateCustomClassOperationsClient);
        }

        /// <summary>
        /// Lists CustomClasses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomClass"/> resources.</returns>
        public override gax::PagedEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClasses(ListCustomClassesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomClassesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCustomClassesRequest, ListCustomClassesResponse, CustomClass>(_callListCustomClasses, request, callSettings);
        }

        /// <summary>
        /// Lists CustomClasses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomClass"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCustomClassesResponse, CustomClass> ListCustomClassesAsync(ListCustomClassesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomClassesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCustomClassesRequest, ListCustomClassesResponse, CustomClass>(_callListCustomClasses, request, callSettings);
        }

        /// <summary>
        /// Returns the requested
        /// [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomClass GetCustomClass(GetCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomClassRequest(ref request, ref callSettings);
            return _callGetCustomClass.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested
        /// [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomClass> GetCustomClassAsync(GetCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomClassRequest(ref request, ref callSettings);
            return _callGetCustomClass.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateCustomClass</c>.</summary>
        public override lro::OperationsClient UpdateCustomClassOperationsClient { get; }

        /// <summary>
        /// Updates the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CustomClass, OperationMetadata> UpdateCustomClass(UpdateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomClassRequest(ref request, ref callSettings);
            return new lro::Operation<CustomClass, OperationMetadata>(_callUpdateCustomClass.Sync(request, callSettings), UpdateCustomClassOperationsClient);
        }

        /// <summary>
        /// Updates the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CustomClass, OperationMetadata>> UpdateCustomClassAsync(UpdateCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomClassRequest(ref request, ref callSettings);
            return new lro::Operation<CustomClass, OperationMetadata>(await _callUpdateCustomClass.Async(request, callSettings).ConfigureAwait(false), UpdateCustomClassOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCustomClass</c>.</summary>
        public override lro::OperationsClient DeleteCustomClassOperationsClient { get; }

        /// <summary>
        /// Deletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CustomClass, OperationMetadata> DeleteCustomClass(DeleteCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomClassRequest(ref request, ref callSettings);
            return new lro::Operation<CustomClass, OperationMetadata>(_callDeleteCustomClass.Sync(request, callSettings), DeleteCustomClassOperationsClient);
        }

        /// <summary>
        /// Deletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CustomClass, OperationMetadata>> DeleteCustomClassAsync(DeleteCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomClassRequest(ref request, ref callSettings);
            return new lro::Operation<CustomClass, OperationMetadata>(await _callDeleteCustomClass.Async(request, callSettings).ConfigureAwait(false), DeleteCustomClassOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeleteCustomClass</c>.</summary>
        public override lro::OperationsClient UndeleteCustomClassOperationsClient { get; }

        /// <summary>
        /// Undeletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CustomClass, OperationMetadata> UndeleteCustomClass(UndeleteCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteCustomClassRequest(ref request, ref callSettings);
            return new lro::Operation<CustomClass, OperationMetadata>(_callUndeleteCustomClass.Sync(request, callSettings), UndeleteCustomClassOperationsClient);
        }

        /// <summary>
        /// Undeletes the [CustomClass][google.cloud.speech.v2.CustomClass].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CustomClass, OperationMetadata>> UndeleteCustomClassAsync(UndeleteCustomClassRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteCustomClassRequest(ref request, ref callSettings);
            return new lro::Operation<CustomClass, OperationMetadata>(await _callUndeleteCustomClass.Async(request, callSettings).ConfigureAwait(false), UndeleteCustomClassOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreatePhraseSet</c>.</summary>
        public override lro::OperationsClient CreatePhraseSetOperationsClient { get; }

        /// <summary>
        /// Creates a [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PhraseSet, OperationMetadata> CreatePhraseSet(CreatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePhraseSetRequest(ref request, ref callSettings);
            return new lro::Operation<PhraseSet, OperationMetadata>(_callCreatePhraseSet.Sync(request, callSettings), CreatePhraseSetOperationsClient);
        }

        /// <summary>
        /// Creates a [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PhraseSet, OperationMetadata>> CreatePhraseSetAsync(CreatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePhraseSetRequest(ref request, ref callSettings);
            return new lro::Operation<PhraseSet, OperationMetadata>(await _callCreatePhraseSet.Async(request, callSettings).ConfigureAwait(false), CreatePhraseSetOperationsClient);
        }

        /// <summary>
        /// Lists PhraseSets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PhraseSet"/> resources.</returns>
        public override gax::PagedEnumerable<ListPhraseSetsResponse, PhraseSet> ListPhraseSets(ListPhraseSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhraseSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPhraseSetsRequest, ListPhraseSetsResponse, PhraseSet>(_callListPhraseSets, request, callSettings);
        }

        /// <summary>
        /// Lists PhraseSets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PhraseSet"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPhraseSetsResponse, PhraseSet> ListPhraseSetsAsync(ListPhraseSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhraseSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPhraseSetsRequest, ListPhraseSetsResponse, PhraseSet>(_callListPhraseSets, request, callSettings);
        }

        /// <summary>
        /// Returns the requested
        /// [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PhraseSet GetPhraseSet(GetPhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhraseSetRequest(ref request, ref callSettings);
            return _callGetPhraseSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested
        /// [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PhraseSet> GetPhraseSetAsync(GetPhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhraseSetRequest(ref request, ref callSettings);
            return _callGetPhraseSet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdatePhraseSet</c>.</summary>
        public override lro::OperationsClient UpdatePhraseSetOperationsClient { get; }

        /// <summary>
        /// Updates the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PhraseSet, OperationMetadata> UpdatePhraseSet(UpdatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePhraseSetRequest(ref request, ref callSettings);
            return new lro::Operation<PhraseSet, OperationMetadata>(_callUpdatePhraseSet.Sync(request, callSettings), UpdatePhraseSetOperationsClient);
        }

        /// <summary>
        /// Updates the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PhraseSet, OperationMetadata>> UpdatePhraseSetAsync(UpdatePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePhraseSetRequest(ref request, ref callSettings);
            return new lro::Operation<PhraseSet, OperationMetadata>(await _callUpdatePhraseSet.Async(request, callSettings).ConfigureAwait(false), UpdatePhraseSetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeletePhraseSet</c>.</summary>
        public override lro::OperationsClient DeletePhraseSetOperationsClient { get; }

        /// <summary>
        /// Deletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PhraseSet, OperationMetadata> DeletePhraseSet(DeletePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhraseSetRequest(ref request, ref callSettings);
            return new lro::Operation<PhraseSet, OperationMetadata>(_callDeletePhraseSet.Sync(request, callSettings), DeletePhraseSetOperationsClient);
        }

        /// <summary>
        /// Deletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PhraseSet, OperationMetadata>> DeletePhraseSetAsync(DeletePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhraseSetRequest(ref request, ref callSettings);
            return new lro::Operation<PhraseSet, OperationMetadata>(await _callDeletePhraseSet.Async(request, callSettings).ConfigureAwait(false), DeletePhraseSetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeletePhraseSet</c>.</summary>
        public override lro::OperationsClient UndeletePhraseSetOperationsClient { get; }

        /// <summary>
        /// Undeletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PhraseSet, OperationMetadata> UndeletePhraseSet(UndeletePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeletePhraseSetRequest(ref request, ref callSettings);
            return new lro::Operation<PhraseSet, OperationMetadata>(_callUndeletePhraseSet.Sync(request, callSettings), UndeletePhraseSetOperationsClient);
        }

        /// <summary>
        /// Undeletes the [PhraseSet][google.cloud.speech.v2.PhraseSet].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PhraseSet, OperationMetadata>> UndeletePhraseSetAsync(UndeletePhraseSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeletePhraseSetRequest(ref request, ref callSettings);
            return new lro::Operation<PhraseSet, OperationMetadata>(await _callUndeletePhraseSet.Async(request, callSettings).ConfigureAwait(false), UndeletePhraseSetOperationsClient);
        }
    }

    public partial class ListRecognizersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCustomClassesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPhraseSetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRecognizersResponse : gaxgrpc::IPageResponse<Recognizer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Recognizer> GetEnumerator() => Recognizers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCustomClassesResponse : gaxgrpc::IPageResponse<CustomClass>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CustomClass> GetEnumerator() => CustomClasses.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPhraseSetsResponse : gaxgrpc::IPageResponse<PhraseSet>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PhraseSet> GetEnumerator() => PhraseSets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Speech
    {
        public partial class SpeechClient
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

    public static partial class Speech
    {
        public partial class SpeechClient
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
