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

namespace Google.Apps.Meet.V2
{
    /// <summary>Settings for <see cref="ConferenceRecordsServiceClient"/> instances.</summary>
    public sealed partial class ConferenceRecordsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConferenceRecordsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConferenceRecordsServiceSettings"/>.</returns>
        public static ConferenceRecordsServiceSettings GetDefault() => new ConferenceRecordsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConferenceRecordsServiceSettings"/> object with default settings.
        /// </summary>
        public ConferenceRecordsServiceSettings()
        {
        }

        private ConferenceRecordsServiceSettings(ConferenceRecordsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetConferenceRecordSettings = existing.GetConferenceRecordSettings;
            ListConferenceRecordsSettings = existing.ListConferenceRecordsSettings;
            GetParticipantSettings = existing.GetParticipantSettings;
            ListParticipantsSettings = existing.ListParticipantsSettings;
            GetParticipantSessionSettings = existing.GetParticipantSessionSettings;
            ListParticipantSessionsSettings = existing.ListParticipantSessionsSettings;
            GetRecordingSettings = existing.GetRecordingSettings;
            ListRecordingsSettings = existing.ListRecordingsSettings;
            GetTranscriptSettings = existing.GetTranscriptSettings;
            ListTranscriptsSettings = existing.ListTranscriptsSettings;
            GetTranscriptEntrySettings = existing.GetTranscriptEntrySettings;
            ListTranscriptEntriesSettings = existing.ListTranscriptEntriesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConferenceRecordsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConferenceRecordsServiceClient.GetConferenceRecord</c> and
        /// <c>ConferenceRecordsServiceClient.GetConferenceRecordAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConferenceRecordSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConferenceRecordsServiceClient.ListConferenceRecords</c> and
        /// <c>ConferenceRecordsServiceClient.ListConferenceRecordsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConferenceRecordsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConferenceRecordsServiceClient.GetParticipant</c> and
        /// <c>ConferenceRecordsServiceClient.GetParticipantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetParticipantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConferenceRecordsServiceClient.ListParticipants</c> and
        /// <c>ConferenceRecordsServiceClient.ListParticipantsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListParticipantsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConferenceRecordsServiceClient.GetParticipantSession</c> and
        /// <c>ConferenceRecordsServiceClient.GetParticipantSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetParticipantSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConferenceRecordsServiceClient.ListParticipantSessions</c> and
        /// <c>ConferenceRecordsServiceClient.ListParticipantSessionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListParticipantSessionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConferenceRecordsServiceClient.GetRecording</c> and <c>ConferenceRecordsServiceClient.GetRecordingAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRecordingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConferenceRecordsServiceClient.ListRecordings</c> and
        /// <c>ConferenceRecordsServiceClient.ListRecordingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRecordingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConferenceRecordsServiceClient.GetTranscript</c> and <c>ConferenceRecordsServiceClient.GetTranscriptAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTranscriptSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConferenceRecordsServiceClient.ListTranscripts</c> and
        /// <c>ConferenceRecordsServiceClient.ListTranscriptsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTranscriptsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConferenceRecordsServiceClient.GetTranscriptEntry</c> and
        /// <c>ConferenceRecordsServiceClient.GetTranscriptEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTranscriptEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConferenceRecordsServiceClient.ListTranscriptEntries</c> and
        /// <c>ConferenceRecordsServiceClient.ListTranscriptEntriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTranscriptEntriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConferenceRecordsServiceSettings"/> object.</returns>
        public ConferenceRecordsServiceSettings Clone() => new ConferenceRecordsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConferenceRecordsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ConferenceRecordsServiceClientBuilder : gaxgrpc::ClientBuilderBase<ConferenceRecordsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConferenceRecordsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConferenceRecordsServiceClientBuilder() : base(ConferenceRecordsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConferenceRecordsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConferenceRecordsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConferenceRecordsServiceClient Build()
        {
            ConferenceRecordsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConferenceRecordsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConferenceRecordsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConferenceRecordsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConferenceRecordsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConferenceRecordsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConferenceRecordsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConferenceRecordsServiceClient.ChannelPool;
    }

    /// <summary>ConferenceRecordsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// REST API for services dealing with conference records.
    /// </remarks>
    public abstract partial class ConferenceRecordsServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConferenceRecordsService service, which is a host of "meet.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "meet.googleapis.com:443";

        /// <summary>The default ConferenceRecordsService scopes.</summary>
        /// <remarks>
        /// The default ConferenceRecordsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/meetings.space.created</description></item>
        /// <item><description>https://www.googleapis.com/auth/meetings.space.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/meetings.space.created",
            "https://www.googleapis.com/auth/meetings.space.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ConferenceRecordsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConferenceRecordsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConferenceRecordsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConferenceRecordsServiceClient"/>.</returns>
        public static stt::Task<ConferenceRecordsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConferenceRecordsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConferenceRecordsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ConferenceRecordsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConferenceRecordsServiceClient"/>.</returns>
        public static ConferenceRecordsServiceClient Create() => new ConferenceRecordsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConferenceRecordsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConferenceRecordsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConferenceRecordsServiceClient"/>.</returns>
        internal static ConferenceRecordsServiceClient Create(grpccore::CallInvoker callInvoker, ConferenceRecordsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConferenceRecordsService.ConferenceRecordsServiceClient grpcClient = new ConferenceRecordsService.ConferenceRecordsServiceClient(callInvoker);
            return new ConferenceRecordsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ConferenceRecordsService client</summary>
        public virtual ConferenceRecordsService.ConferenceRecordsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a conference record by conference ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConferenceRecord GetConferenceRecord(GetConferenceRecordRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a conference record by conference ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConferenceRecord> GetConferenceRecordAsync(GetConferenceRecordRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a conference record by conference ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConferenceRecord> GetConferenceRecordAsync(GetConferenceRecordRequest request, st::CancellationToken cancellationToken) =>
            GetConferenceRecordAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a conference record by conference ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the conference.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConferenceRecord GetConferenceRecord(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConferenceRecord(new GetConferenceRecordRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a conference record by conference ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the conference.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConferenceRecord> GetConferenceRecordAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConferenceRecordAsync(new GetConferenceRecordRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a conference record by conference ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the conference.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConferenceRecord> GetConferenceRecordAsync(string name, st::CancellationToken cancellationToken) =>
            GetConferenceRecordAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a conference record by conference ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the conference.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConferenceRecord GetConferenceRecord(ConferenceRecordName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConferenceRecord(new GetConferenceRecordRequest
            {
                ConferenceRecordName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a conference record by conference ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the conference.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConferenceRecord> GetConferenceRecordAsync(ConferenceRecordName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConferenceRecordAsync(new GetConferenceRecordRequest
            {
                ConferenceRecordName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a conference record by conference ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the conference.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConferenceRecord> GetConferenceRecordAsync(ConferenceRecordName name, st::CancellationToken cancellationToken) =>
            GetConferenceRecordAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the conference records. By default, ordered by start time and in
        /// descending order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConferenceRecord"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConferenceRecordsResponse, ConferenceRecord> ListConferenceRecords(ListConferenceRecordsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the conference records. By default, ordered by start time and in
        /// descending order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConferenceRecord"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConferenceRecordsResponse, ConferenceRecord> ListConferenceRecordsAsync(ListConferenceRecordsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a participant by participant ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant GetParticipant(GetParticipantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a participant by participant ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(GetParticipantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a participant by participant ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(GetParticipantRequest request, st::CancellationToken cancellationToken) =>
            GetParticipantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a participant by participant ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the participant.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant GetParticipant(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipant(new GetParticipantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a participant by participant ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the participant.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipantAsync(new GetParticipantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a participant by participant ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the participant.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(string name, st::CancellationToken cancellationToken) =>
            GetParticipantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a participant by participant ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the participant.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Participant GetParticipant(ParticipantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipant(new GetParticipantRequest
            {
                ParticipantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a participant by participant ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the participant.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(ParticipantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipantAsync(new GetParticipantRequest
            {
                ParticipantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a participant by participant ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the participant.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Participant> GetParticipantAsync(ParticipantName name, st::CancellationToken cancellationToken) =>
            GetParticipantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the participants in a conference record. By default, ordered by join
        /// time and in descending order. This API supports `fields` as standard
        /// parameters like every other API. However, when the `fields` request
        /// parameter is omitted, this API defaults to `'participants/*,
        /// next_page_token'`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Participant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParticipantsResponse, Participant> ListParticipants(ListParticipantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the participants in a conference record. By default, ordered by join
        /// time and in descending order. This API supports `fields` as standard
        /// parameters like every other API. However, when the `fields` request
        /// parameter is omitted, this API defaults to `'participants/*,
        /// next_page_token'`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Participant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParticipantsResponse, Participant> ListParticipantsAsync(ListParticipantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the participants in a conference record. By default, ordered by join
        /// time and in descending order. This API supports `fields` as standard
        /// parameters like every other API. However, when the `fields` request
        /// parameter is omitted, this API defaults to `'participants/*,
        /// next_page_token'`.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `conferenceRecords/{conference_record}`
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
        /// Lists the participants in a conference record. By default, ordered by join
        /// time and in descending order. This API supports `fields` as standard
        /// parameters like every other API. However, when the `fields` request
        /// parameter is omitted, this API defaults to `'participants/*,
        /// next_page_token'`.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `conferenceRecords/{conference_record}`
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
        /// Lists the participants in a conference record. By default, ordered by join
        /// time and in descending order. This API supports `fields` as standard
        /// parameters like every other API. However, when the `fields` request
        /// parameter is omitted, this API defaults to `'participants/*,
        /// next_page_token'`.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `conferenceRecords/{conference_record}`
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
        public virtual gax::PagedEnumerable<ListParticipantsResponse, Participant> ListParticipants(ConferenceRecordName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParticipantsRequest request = new ListParticipantsRequest
            {
                ParentAsConferenceRecordName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists the participants in a conference record. By default, ordered by join
        /// time and in descending order. This API supports `fields` as standard
        /// parameters like every other API. However, when the `fields` request
        /// parameter is omitted, this API defaults to `'participants/*,
        /// next_page_token'`.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `conferenceRecords/{conference_record}`
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
        public virtual gax::PagedAsyncEnumerable<ListParticipantsResponse, Participant> ListParticipantsAsync(ConferenceRecordName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParticipantsRequest request = new ListParticipantsRequest
            {
                ParentAsConferenceRecordName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Gets a participant session by participant session ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ParticipantSession GetParticipantSession(GetParticipantSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a participant session by participant session ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParticipantSession> GetParticipantSessionAsync(GetParticipantSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a participant session by participant session ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParticipantSession> GetParticipantSessionAsync(GetParticipantSessionRequest request, st::CancellationToken cancellationToken) =>
            GetParticipantSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a participant session by participant session ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the participant.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ParticipantSession GetParticipantSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipantSession(new GetParticipantSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a participant session by participant session ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the participant.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParticipantSession> GetParticipantSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipantSessionAsync(new GetParticipantSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a participant session by participant session ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the participant.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParticipantSession> GetParticipantSessionAsync(string name, st::CancellationToken cancellationToken) =>
            GetParticipantSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a participant session by participant session ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the participant.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ParticipantSession GetParticipantSession(ParticipantSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipantSession(new GetParticipantSessionRequest
            {
                ParticipantSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a participant session by participant session ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the participant.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParticipantSession> GetParticipantSessionAsync(ParticipantSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetParticipantSessionAsync(new GetParticipantSessionRequest
            {
                ParticipantSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a participant session by participant session ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the participant.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParticipantSession> GetParticipantSessionAsync(ParticipantSessionName name, st::CancellationToken cancellationToken) =>
            GetParticipantSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the participant sessions of a participant in a conference record. By
        /// default, ordered by join time and in descending order. This API supports
        /// `fields` as standard parameters like every other API. However, when the
        /// `fields` request parameter is omitted this API defaults to
        /// `'participantsessions/*, next_page_token'`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ParticipantSession"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParticipantSessionsResponse, ParticipantSession> ListParticipantSessions(ListParticipantSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the participant sessions of a participant in a conference record. By
        /// default, ordered by join time and in descending order. This API supports
        /// `fields` as standard parameters like every other API. However, when the
        /// `fields` request parameter is omitted this API defaults to
        /// `'participantsessions/*, next_page_token'`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ParticipantSession"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParticipantSessionsResponse, ParticipantSession> ListParticipantSessionsAsync(ListParticipantSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the participant sessions of a participant in a conference record. By
        /// default, ordered by join time and in descending order. This API supports
        /// `fields` as standard parameters like every other API. However, when the
        /// `fields` request parameter is omitted this API defaults to
        /// `'participantsessions/*, next_page_token'`.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `conferenceRecords/{conference_record}/participants/{participant}`
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
        /// <returns>A pageable sequence of <see cref="ParticipantSession"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParticipantSessionsResponse, ParticipantSession> ListParticipantSessions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParticipantSessionsRequest request = new ListParticipantSessionsRequest
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
            return ListParticipantSessions(request, callSettings);
        }

        /// <summary>
        /// Lists the participant sessions of a participant in a conference record. By
        /// default, ordered by join time and in descending order. This API supports
        /// `fields` as standard parameters like every other API. However, when the
        /// `fields` request parameter is omitted this API defaults to
        /// `'participantsessions/*, next_page_token'`.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `conferenceRecords/{conference_record}/participants/{participant}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ParticipantSession"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParticipantSessionsResponse, ParticipantSession> ListParticipantSessionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParticipantSessionsRequest request = new ListParticipantSessionsRequest
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
            return ListParticipantSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the participant sessions of a participant in a conference record. By
        /// default, ordered by join time and in descending order. This API supports
        /// `fields` as standard parameters like every other API. However, when the
        /// `fields` request parameter is omitted this API defaults to
        /// `'participantsessions/*, next_page_token'`.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `conferenceRecords/{conference_record}/participants/{participant}`
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
        /// <returns>A pageable sequence of <see cref="ParticipantSession"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParticipantSessionsResponse, ParticipantSession> ListParticipantSessions(ParticipantName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParticipantSessionsRequest request = new ListParticipantSessionsRequest
            {
                ParentAsParticipantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListParticipantSessions(request, callSettings);
        }

        /// <summary>
        /// Lists the participant sessions of a participant in a conference record. By
        /// default, ordered by join time and in descending order. This API supports
        /// `fields` as standard parameters like every other API. However, when the
        /// `fields` request parameter is omitted this API defaults to
        /// `'participantsessions/*, next_page_token'`.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `conferenceRecords/{conference_record}/participants/{participant}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ParticipantSession"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParticipantSessionsResponse, ParticipantSession> ListParticipantSessionsAsync(ParticipantName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParticipantSessionsRequest request = new ListParticipantSessionsRequest
            {
                ParentAsParticipantName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListParticipantSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a recording by recording ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recording GetRecording(GetRecordingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a recording by recording ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> GetRecordingAsync(GetRecordingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a recording by recording ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> GetRecordingAsync(GetRecordingRequest request, st::CancellationToken cancellationToken) =>
            GetRecordingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a recording by recording ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the recording.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recording GetRecording(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecording(new GetRecordingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a recording by recording ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the recording.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> GetRecordingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecordingAsync(new GetRecordingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a recording by recording ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the recording.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> GetRecordingAsync(string name, st::CancellationToken cancellationToken) =>
            GetRecordingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a recording by recording ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the recording.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Recording GetRecording(RecordingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecording(new GetRecordingRequest
            {
                RecordingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a recording by recording ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the recording.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> GetRecordingAsync(RecordingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRecordingAsync(new GetRecordingRequest
            {
                RecordingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a recording by recording ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the recording.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Recording> GetRecordingAsync(RecordingName name, st::CancellationToken cancellationToken) =>
            GetRecordingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the recording resources from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Recording"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecordingsResponse, Recording> ListRecordings(ListRecordingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the recording resources from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Recording"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecordingsResponse, Recording> ListRecordingsAsync(ListRecordingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the recording resources from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `conferenceRecords/{conference_record}`
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
        /// <returns>A pageable sequence of <see cref="Recording"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecordingsResponse, Recording> ListRecordings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecordingsRequest request = new ListRecordingsRequest
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
            return ListRecordings(request, callSettings);
        }

        /// <summary>
        /// Lists the recording resources from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `conferenceRecords/{conference_record}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Recording"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecordingsResponse, Recording> ListRecordingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecordingsRequest request = new ListRecordingsRequest
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
            return ListRecordingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the recording resources from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `conferenceRecords/{conference_record}`
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
        /// <returns>A pageable sequence of <see cref="Recording"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRecordingsResponse, Recording> ListRecordings(ConferenceRecordName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecordingsRequest request = new ListRecordingsRequest
            {
                ParentAsConferenceRecordName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRecordings(request, callSettings);
        }

        /// <summary>
        /// Lists the recording resources from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `conferenceRecords/{conference_record}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Recording"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRecordingsResponse, Recording> ListRecordingsAsync(ConferenceRecordName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRecordingsRequest request = new ListRecordingsRequest
            {
                ParentAsConferenceRecordName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRecordingsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a transcript by transcript ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Transcript GetTranscript(GetTranscriptRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a transcript by transcript ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transcript> GetTranscriptAsync(GetTranscriptRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a transcript by transcript ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transcript> GetTranscriptAsync(GetTranscriptRequest request, st::CancellationToken cancellationToken) =>
            GetTranscriptAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a transcript by transcript ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the transcript.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Transcript GetTranscript(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTranscript(new GetTranscriptRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a transcript by transcript ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the transcript.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transcript> GetTranscriptAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTranscriptAsync(new GetTranscriptRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a transcript by transcript ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the transcript.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transcript> GetTranscriptAsync(string name, st::CancellationToken cancellationToken) =>
            GetTranscriptAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a transcript by transcript ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the transcript.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Transcript GetTranscript(TranscriptName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTranscript(new GetTranscriptRequest
            {
                TranscriptName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a transcript by transcript ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the transcript.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transcript> GetTranscriptAsync(TranscriptName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTranscriptAsync(new GetTranscriptRequest
            {
                TranscriptName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a transcript by transcript ID.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the transcript.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Transcript> GetTranscriptAsync(TranscriptName name, st::CancellationToken cancellationToken) =>
            GetTranscriptAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the set of transcripts from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Transcript"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTranscriptsResponse, Transcript> ListTranscripts(ListTranscriptsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the set of transcripts from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Transcript"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTranscriptsResponse, Transcript> ListTranscriptsAsync(ListTranscriptsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the set of transcripts from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `conferenceRecords/{conference_record}`
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
        /// <returns>A pageable sequence of <see cref="Transcript"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTranscriptsResponse, Transcript> ListTranscripts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTranscriptsRequest request = new ListTranscriptsRequest
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
            return ListTranscripts(request, callSettings);
        }

        /// <summary>
        /// Lists the set of transcripts from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `conferenceRecords/{conference_record}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Transcript"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTranscriptsResponse, Transcript> ListTranscriptsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTranscriptsRequest request = new ListTranscriptsRequest
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
            return ListTranscriptsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the set of transcripts from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `conferenceRecords/{conference_record}`
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
        /// <returns>A pageable sequence of <see cref="Transcript"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTranscriptsResponse, Transcript> ListTranscripts(ConferenceRecordName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTranscriptsRequest request = new ListTranscriptsRequest
            {
                ParentAsConferenceRecordName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTranscripts(request, callSettings);
        }

        /// <summary>
        /// Lists the set of transcripts from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `conferenceRecords/{conference_record}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Transcript"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTranscriptsResponse, Transcript> ListTranscriptsAsync(ConferenceRecordName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTranscriptsRequest request = new ListTranscriptsRequest
            {
                ParentAsConferenceRecordName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTranscriptsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a `TranscriptEntry` resource by entry ID.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TranscriptEntry GetTranscriptEntry(GetTranscriptEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a `TranscriptEntry` resource by entry ID.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranscriptEntry> GetTranscriptEntryAsync(GetTranscriptEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a `TranscriptEntry` resource by entry ID.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranscriptEntry> GetTranscriptEntryAsync(GetTranscriptEntryRequest request, st::CancellationToken cancellationToken) =>
            GetTranscriptEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a `TranscriptEntry` resource by entry ID.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `TranscriptEntry`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TranscriptEntry GetTranscriptEntry(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTranscriptEntry(new GetTranscriptEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a `TranscriptEntry` resource by entry ID.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `TranscriptEntry`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranscriptEntry> GetTranscriptEntryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTranscriptEntryAsync(new GetTranscriptEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a `TranscriptEntry` resource by entry ID.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `TranscriptEntry`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranscriptEntry> GetTranscriptEntryAsync(string name, st::CancellationToken cancellationToken) =>
            GetTranscriptEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a `TranscriptEntry` resource by entry ID.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `TranscriptEntry`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TranscriptEntry GetTranscriptEntry(TranscriptEntryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTranscriptEntry(new GetTranscriptEntryRequest
            {
                TranscriptEntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a `TranscriptEntry` resource by entry ID.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `TranscriptEntry`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranscriptEntry> GetTranscriptEntryAsync(TranscriptEntryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTranscriptEntryAsync(new GetTranscriptEntryRequest
            {
                TranscriptEntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a `TranscriptEntry` resource by entry ID.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the `TranscriptEntry`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TranscriptEntry> GetTranscriptEntryAsync(TranscriptEntryName name, st::CancellationToken cancellationToken) =>
            GetTranscriptEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the structured transcript entries per transcript. By default, ordered
        /// by start time and in ascending order.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TranscriptEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTranscriptEntriesResponse, TranscriptEntry> ListTranscriptEntries(ListTranscriptEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the structured transcript entries per transcript. By default, ordered
        /// by start time and in ascending order.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TranscriptEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTranscriptEntriesResponse, TranscriptEntry> ListTranscriptEntriesAsync(ListTranscriptEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the structured transcript entries per transcript. By default, ordered
        /// by start time and in ascending order.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `conferenceRecords/{conference_record}/transcripts/{transcript}`
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
        /// <returns>A pageable sequence of <see cref="TranscriptEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTranscriptEntriesResponse, TranscriptEntry> ListTranscriptEntries(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTranscriptEntriesRequest request = new ListTranscriptEntriesRequest
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
            return ListTranscriptEntries(request, callSettings);
        }

        /// <summary>
        /// Lists the structured transcript entries per transcript. By default, ordered
        /// by start time and in ascending order.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `conferenceRecords/{conference_record}/transcripts/{transcript}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TranscriptEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTranscriptEntriesResponse, TranscriptEntry> ListTranscriptEntriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTranscriptEntriesRequest request = new ListTranscriptEntriesRequest
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
            return ListTranscriptEntriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the structured transcript entries per transcript. By default, ordered
        /// by start time and in ascending order.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `conferenceRecords/{conference_record}/transcripts/{transcript}`
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
        /// <returns>A pageable sequence of <see cref="TranscriptEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTranscriptEntriesResponse, TranscriptEntry> ListTranscriptEntries(TranscriptName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTranscriptEntriesRequest request = new ListTranscriptEntriesRequest
            {
                ParentAsTranscriptName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTranscriptEntries(request, callSettings);
        }

        /// <summary>
        /// Lists the structured transcript entries per transcript. By default, ordered
        /// by start time and in ascending order.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `conferenceRecords/{conference_record}/transcripts/{transcript}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TranscriptEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTranscriptEntriesResponse, TranscriptEntry> ListTranscriptEntriesAsync(TranscriptName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTranscriptEntriesRequest request = new ListTranscriptEntriesRequest
            {
                ParentAsTranscriptName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTranscriptEntriesAsync(request, callSettings);
        }
    }

    /// <summary>ConferenceRecordsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// REST API for services dealing with conference records.
    /// </remarks>
    public sealed partial class ConferenceRecordsServiceClientImpl : ConferenceRecordsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetConferenceRecordRequest, ConferenceRecord> _callGetConferenceRecord;

        private readonly gaxgrpc::ApiCall<ListConferenceRecordsRequest, ListConferenceRecordsResponse> _callListConferenceRecords;

        private readonly gaxgrpc::ApiCall<GetParticipantRequest, Participant> _callGetParticipant;

        private readonly gaxgrpc::ApiCall<ListParticipantsRequest, ListParticipantsResponse> _callListParticipants;

        private readonly gaxgrpc::ApiCall<GetParticipantSessionRequest, ParticipantSession> _callGetParticipantSession;

        private readonly gaxgrpc::ApiCall<ListParticipantSessionsRequest, ListParticipantSessionsResponse> _callListParticipantSessions;

        private readonly gaxgrpc::ApiCall<GetRecordingRequest, Recording> _callGetRecording;

        private readonly gaxgrpc::ApiCall<ListRecordingsRequest, ListRecordingsResponse> _callListRecordings;

        private readonly gaxgrpc::ApiCall<GetTranscriptRequest, Transcript> _callGetTranscript;

        private readonly gaxgrpc::ApiCall<ListTranscriptsRequest, ListTranscriptsResponse> _callListTranscripts;

        private readonly gaxgrpc::ApiCall<GetTranscriptEntryRequest, TranscriptEntry> _callGetTranscriptEntry;

        private readonly gaxgrpc::ApiCall<ListTranscriptEntriesRequest, ListTranscriptEntriesResponse> _callListTranscriptEntries;

        /// <summary>
        /// Constructs a client wrapper for the ConferenceRecordsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ConferenceRecordsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConferenceRecordsServiceClientImpl(ConferenceRecordsService.ConferenceRecordsServiceClient grpcClient, ConferenceRecordsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConferenceRecordsServiceSettings effectiveSettings = settings ?? ConferenceRecordsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetConferenceRecord = clientHelper.BuildApiCall<GetConferenceRecordRequest, ConferenceRecord>("GetConferenceRecord", grpcClient.GetConferenceRecordAsync, grpcClient.GetConferenceRecord, effectiveSettings.GetConferenceRecordSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConferenceRecord);
            Modify_GetConferenceRecordApiCall(ref _callGetConferenceRecord);
            _callListConferenceRecords = clientHelper.BuildApiCall<ListConferenceRecordsRequest, ListConferenceRecordsResponse>("ListConferenceRecords", grpcClient.ListConferenceRecordsAsync, grpcClient.ListConferenceRecords, effectiveSettings.ListConferenceRecordsSettings);
            Modify_ApiCall(ref _callListConferenceRecords);
            Modify_ListConferenceRecordsApiCall(ref _callListConferenceRecords);
            _callGetParticipant = clientHelper.BuildApiCall<GetParticipantRequest, Participant>("GetParticipant", grpcClient.GetParticipantAsync, grpcClient.GetParticipant, effectiveSettings.GetParticipantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetParticipant);
            Modify_GetParticipantApiCall(ref _callGetParticipant);
            _callListParticipants = clientHelper.BuildApiCall<ListParticipantsRequest, ListParticipantsResponse>("ListParticipants", grpcClient.ListParticipantsAsync, grpcClient.ListParticipants, effectiveSettings.ListParticipantsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListParticipants);
            Modify_ListParticipantsApiCall(ref _callListParticipants);
            _callGetParticipantSession = clientHelper.BuildApiCall<GetParticipantSessionRequest, ParticipantSession>("GetParticipantSession", grpcClient.GetParticipantSessionAsync, grpcClient.GetParticipantSession, effectiveSettings.GetParticipantSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetParticipantSession);
            Modify_GetParticipantSessionApiCall(ref _callGetParticipantSession);
            _callListParticipantSessions = clientHelper.BuildApiCall<ListParticipantSessionsRequest, ListParticipantSessionsResponse>("ListParticipantSessions", grpcClient.ListParticipantSessionsAsync, grpcClient.ListParticipantSessions, effectiveSettings.ListParticipantSessionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListParticipantSessions);
            Modify_ListParticipantSessionsApiCall(ref _callListParticipantSessions);
            _callGetRecording = clientHelper.BuildApiCall<GetRecordingRequest, Recording>("GetRecording", grpcClient.GetRecordingAsync, grpcClient.GetRecording, effectiveSettings.GetRecordingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRecording);
            Modify_GetRecordingApiCall(ref _callGetRecording);
            _callListRecordings = clientHelper.BuildApiCall<ListRecordingsRequest, ListRecordingsResponse>("ListRecordings", grpcClient.ListRecordingsAsync, grpcClient.ListRecordings, effectiveSettings.ListRecordingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRecordings);
            Modify_ListRecordingsApiCall(ref _callListRecordings);
            _callGetTranscript = clientHelper.BuildApiCall<GetTranscriptRequest, Transcript>("GetTranscript", grpcClient.GetTranscriptAsync, grpcClient.GetTranscript, effectiveSettings.GetTranscriptSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTranscript);
            Modify_GetTranscriptApiCall(ref _callGetTranscript);
            _callListTranscripts = clientHelper.BuildApiCall<ListTranscriptsRequest, ListTranscriptsResponse>("ListTranscripts", grpcClient.ListTranscriptsAsync, grpcClient.ListTranscripts, effectiveSettings.ListTranscriptsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTranscripts);
            Modify_ListTranscriptsApiCall(ref _callListTranscripts);
            _callGetTranscriptEntry = clientHelper.BuildApiCall<GetTranscriptEntryRequest, TranscriptEntry>("GetTranscriptEntry", grpcClient.GetTranscriptEntryAsync, grpcClient.GetTranscriptEntry, effectiveSettings.GetTranscriptEntrySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTranscriptEntry);
            Modify_GetTranscriptEntryApiCall(ref _callGetTranscriptEntry);
            _callListTranscriptEntries = clientHelper.BuildApiCall<ListTranscriptEntriesRequest, ListTranscriptEntriesResponse>("ListTranscriptEntries", grpcClient.ListTranscriptEntriesAsync, grpcClient.ListTranscriptEntries, effectiveSettings.ListTranscriptEntriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTranscriptEntries);
            Modify_ListTranscriptEntriesApiCall(ref _callListTranscriptEntries);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetConferenceRecordApiCall(ref gaxgrpc::ApiCall<GetConferenceRecordRequest, ConferenceRecord> call);

        partial void Modify_ListConferenceRecordsApiCall(ref gaxgrpc::ApiCall<ListConferenceRecordsRequest, ListConferenceRecordsResponse> call);

        partial void Modify_GetParticipantApiCall(ref gaxgrpc::ApiCall<GetParticipantRequest, Participant> call);

        partial void Modify_ListParticipantsApiCall(ref gaxgrpc::ApiCall<ListParticipantsRequest, ListParticipantsResponse> call);

        partial void Modify_GetParticipantSessionApiCall(ref gaxgrpc::ApiCall<GetParticipantSessionRequest, ParticipantSession> call);

        partial void Modify_ListParticipantSessionsApiCall(ref gaxgrpc::ApiCall<ListParticipantSessionsRequest, ListParticipantSessionsResponse> call);

        partial void Modify_GetRecordingApiCall(ref gaxgrpc::ApiCall<GetRecordingRequest, Recording> call);

        partial void Modify_ListRecordingsApiCall(ref gaxgrpc::ApiCall<ListRecordingsRequest, ListRecordingsResponse> call);

        partial void Modify_GetTranscriptApiCall(ref gaxgrpc::ApiCall<GetTranscriptRequest, Transcript> call);

        partial void Modify_ListTranscriptsApiCall(ref gaxgrpc::ApiCall<ListTranscriptsRequest, ListTranscriptsResponse> call);

        partial void Modify_GetTranscriptEntryApiCall(ref gaxgrpc::ApiCall<GetTranscriptEntryRequest, TranscriptEntry> call);

        partial void Modify_ListTranscriptEntriesApiCall(ref gaxgrpc::ApiCall<ListTranscriptEntriesRequest, ListTranscriptEntriesResponse> call);

        partial void OnConstruction(ConferenceRecordsService.ConferenceRecordsServiceClient grpcClient, ConferenceRecordsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConferenceRecordsService client</summary>
        public override ConferenceRecordsService.ConferenceRecordsServiceClient GrpcClient { get; }

        partial void Modify_GetConferenceRecordRequest(ref GetConferenceRecordRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConferenceRecordsRequest(ref ListConferenceRecordsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetParticipantRequest(ref GetParticipantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListParticipantsRequest(ref ListParticipantsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetParticipantSessionRequest(ref GetParticipantSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListParticipantSessionsRequest(ref ListParticipantSessionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRecordingRequest(ref GetRecordingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRecordingsRequest(ref ListRecordingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTranscriptRequest(ref GetTranscriptRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTranscriptsRequest(ref ListTranscriptsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTranscriptEntryRequest(ref GetTranscriptEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTranscriptEntriesRequest(ref ListTranscriptEntriesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a conference record by conference ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConferenceRecord GetConferenceRecord(GetConferenceRecordRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConferenceRecordRequest(ref request, ref callSettings);
            return _callGetConferenceRecord.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a conference record by conference ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConferenceRecord> GetConferenceRecordAsync(GetConferenceRecordRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConferenceRecordRequest(ref request, ref callSettings);
            return _callGetConferenceRecord.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the conference records. By default, ordered by start time and in
        /// descending order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConferenceRecord"/> resources.</returns>
        public override gax::PagedEnumerable<ListConferenceRecordsResponse, ConferenceRecord> ListConferenceRecords(ListConferenceRecordsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConferenceRecordsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConferenceRecordsRequest, ListConferenceRecordsResponse, ConferenceRecord>(_callListConferenceRecords, request, callSettings);
        }

        /// <summary>
        /// Lists the conference records. By default, ordered by start time and in
        /// descending order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConferenceRecord"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConferenceRecordsResponse, ConferenceRecord> ListConferenceRecordsAsync(ListConferenceRecordsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConferenceRecordsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConferenceRecordsRequest, ListConferenceRecordsResponse, ConferenceRecord>(_callListConferenceRecords, request, callSettings);
        }

        /// <summary>
        /// Gets a participant by participant ID.
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
        /// Gets a participant by participant ID.
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
        /// Lists the participants in a conference record. By default, ordered by join
        /// time and in descending order. This API supports `fields` as standard
        /// parameters like every other API. However, when the `fields` request
        /// parameter is omitted, this API defaults to `'participants/*,
        /// next_page_token'`.
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
        /// Lists the participants in a conference record. By default, ordered by join
        /// time and in descending order. This API supports `fields` as standard
        /// parameters like every other API. However, when the `fields` request
        /// parameter is omitted, this API defaults to `'participants/*,
        /// next_page_token'`.
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
        /// Gets a participant session by participant session ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ParticipantSession GetParticipantSession(GetParticipantSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetParticipantSessionRequest(ref request, ref callSettings);
            return _callGetParticipantSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a participant session by participant session ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ParticipantSession> GetParticipantSessionAsync(GetParticipantSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetParticipantSessionRequest(ref request, ref callSettings);
            return _callGetParticipantSession.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the participant sessions of a participant in a conference record. By
        /// default, ordered by join time and in descending order. This API supports
        /// `fields` as standard parameters like every other API. However, when the
        /// `fields` request parameter is omitted this API defaults to
        /// `'participantsessions/*, next_page_token'`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ParticipantSession"/> resources.</returns>
        public override gax::PagedEnumerable<ListParticipantSessionsResponse, ParticipantSession> ListParticipantSessions(ListParticipantSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListParticipantSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListParticipantSessionsRequest, ListParticipantSessionsResponse, ParticipantSession>(_callListParticipantSessions, request, callSettings);
        }

        /// <summary>
        /// Lists the participant sessions of a participant in a conference record. By
        /// default, ordered by join time and in descending order. This API supports
        /// `fields` as standard parameters like every other API. However, when the
        /// `fields` request parameter is omitted this API defaults to
        /// `'participantsessions/*, next_page_token'`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ParticipantSession"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListParticipantSessionsResponse, ParticipantSession> ListParticipantSessionsAsync(ListParticipantSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListParticipantSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListParticipantSessionsRequest, ListParticipantSessionsResponse, ParticipantSession>(_callListParticipantSessions, request, callSettings);
        }

        /// <summary>
        /// Gets a recording by recording ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Recording GetRecording(GetRecordingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRecordingRequest(ref request, ref callSettings);
            return _callGetRecording.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a recording by recording ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Recording> GetRecordingAsync(GetRecordingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRecordingRequest(ref request, ref callSettings);
            return _callGetRecording.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the recording resources from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Recording"/> resources.</returns>
        public override gax::PagedEnumerable<ListRecordingsResponse, Recording> ListRecordings(ListRecordingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRecordingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRecordingsRequest, ListRecordingsResponse, Recording>(_callListRecordings, request, callSettings);
        }

        /// <summary>
        /// Lists the recording resources from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Recording"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRecordingsResponse, Recording> ListRecordingsAsync(ListRecordingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRecordingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRecordingsRequest, ListRecordingsResponse, Recording>(_callListRecordings, request, callSettings);
        }

        /// <summary>
        /// Gets a transcript by transcript ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Transcript GetTranscript(GetTranscriptRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTranscriptRequest(ref request, ref callSettings);
            return _callGetTranscript.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a transcript by transcript ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Transcript> GetTranscriptAsync(GetTranscriptRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTranscriptRequest(ref request, ref callSettings);
            return _callGetTranscript.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the set of transcripts from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Transcript"/> resources.</returns>
        public override gax::PagedEnumerable<ListTranscriptsResponse, Transcript> ListTranscripts(ListTranscriptsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTranscriptsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTranscriptsRequest, ListTranscriptsResponse, Transcript>(_callListTranscripts, request, callSettings);
        }

        /// <summary>
        /// Lists the set of transcripts from the conference record. By default,
        /// ordered by start time and in ascending order.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Transcript"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTranscriptsResponse, Transcript> ListTranscriptsAsync(ListTranscriptsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTranscriptsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTranscriptsRequest, ListTranscriptsResponse, Transcript>(_callListTranscripts, request, callSettings);
        }

        /// <summary>
        /// Gets a `TranscriptEntry` resource by entry ID.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TranscriptEntry GetTranscriptEntry(GetTranscriptEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTranscriptEntryRequest(ref request, ref callSettings);
            return _callGetTranscriptEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a `TranscriptEntry` resource by entry ID.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TranscriptEntry> GetTranscriptEntryAsync(GetTranscriptEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTranscriptEntryRequest(ref request, ref callSettings);
            return _callGetTranscriptEntry.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the structured transcript entries per transcript. By default, ordered
        /// by start time and in ascending order.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TranscriptEntry"/> resources.</returns>
        public override gax::PagedEnumerable<ListTranscriptEntriesResponse, TranscriptEntry> ListTranscriptEntries(ListTranscriptEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTranscriptEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTranscriptEntriesRequest, ListTranscriptEntriesResponse, TranscriptEntry>(_callListTranscriptEntries, request, callSettings);
        }

        /// <summary>
        /// Lists the structured transcript entries per transcript. By default, ordered
        /// by start time and in ascending order.
        /// 
        /// Note: The transcript entries returned by the Google Meet API might not
        /// match the transcription found in the Google Docs transcript file. This can
        /// occur when the Google Docs transcript file is modified after generation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TranscriptEntry"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTranscriptEntriesResponse, TranscriptEntry> ListTranscriptEntriesAsync(ListTranscriptEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTranscriptEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTranscriptEntriesRequest, ListTranscriptEntriesResponse, TranscriptEntry>(_callListTranscriptEntries, request, callSettings);
        }
    }

    public partial class ListConferenceRecordsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListParticipantsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListParticipantSessionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRecordingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTranscriptsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTranscriptEntriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConferenceRecordsResponse : gaxgrpc::IPageResponse<ConferenceRecord>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConferenceRecord> GetEnumerator() => ConferenceRecords.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListParticipantsResponse : gaxgrpc::IPageResponse<Participant>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Participant> GetEnumerator() => Participants.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListParticipantSessionsResponse : gaxgrpc::IPageResponse<ParticipantSession>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ParticipantSession> GetEnumerator() => ParticipantSessions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRecordingsResponse : gaxgrpc::IPageResponse<Recording>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Recording> GetEnumerator() => Recordings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTranscriptsResponse : gaxgrpc::IPageResponse<Transcript>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Transcript> GetEnumerator() => Transcripts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTranscriptEntriesResponse : gaxgrpc::IPageResponse<TranscriptEntry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TranscriptEntry> GetEnumerator() => TranscriptEntries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
